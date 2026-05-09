Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Public Class FormInventory

    '═══════════════════════════════════════════════════════════
    ' STATE
    '═══════════════════════════════════════════════════════════
    ' ID parfum yang sedang diedit (-1 = mode tambah baru)
    Private editingId As Integer = -1
    ' Path gambar yang dipilih user di drawer
    Private selectedGambar As String = ""
    ' DataTable hasil query terakhir (dipakai untuk baca ID per baris)
    Private dtKini As DataTable

    '═══════════════════════════════════════════════════════════
    ' FORM LOAD
    '═══════════════════════════════════════════════════════════
    Private Sub FormInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        ' Cek koneksi database
        If Not ConnectionModule.TestConnection() Then
            MsgBox("Tidak dapat terhubung ke database." & vbCrLf &
                   "Periksa konfigurasi di ModuleKoneksi.vb",
                   MsgBoxStyle.Critical, "Koneksi Gagal")
            Me.Close()
            Return
        End If

        SetupDataGridView()
        MuatDataDariDB()
        RefreshStats()
        StyleActiveNavButton(btnNavInventory)
        pnlDrawer.Visible = False
    End Sub

    '═══════════════════════════════════════════════════════════
    ' SETUP DATAGRIDVIEW  (kolom dibuat manual)
    '═══════════════════════════════════════════════════════════
    Private Sub SetupDataGridView()
        With dgvInventory
            .AutoGenerateColumns = False
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .GridColor = Color.FromArgb(240, 238, 235)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.FromArgb(40, 35, 30)
            .DefaultCellStyle.Font = New Font("Segoe UI", 9)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 242, 238)
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 20, 15)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 251, 249)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 246, 243)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 90, 80)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 7, FontStyle.Bold)
            .ColumnHeadersHeight = 36
            .RowTemplate.Height = 64
            .EnableHeadersVisualStyles = False
        End With

        dgvInventory.Columns.Clear()

        ' Kolom gambar (PictureBox manual)
        Dim colImg As New DataGridViewImageColumn()
        colImg.HeaderText = "IMAGE"
        colImg.Width = 70
        colImg.Name = "colGambar"
        colImg.ReadOnly = True
        colImg.DefaultCellStyle.NullValue = Nothing
        dgvInventory.Columns.Add(colImg)

        ' Kolom teks – DataPropertyName harus cocok dengan nama kolom DB
        TambahKolomTeks("nama_parfum", "NAMA PARFUM", 200)
        TambahKolomTeks("merk", "MERK / BRAND", 190)
        TambahKolomTeks("stok", "STOK", 110)
        TambahKolomTeks("harga", "HARGA", 140)
        dgvInventory.Columns("col_stok").DataPropertyName = ""
        dgvInventory.Columns("col_harga").DataPropertyName = ""

        ' Tombol Edit
        Dim colEdit As New DataGridViewButtonColumn()
        colEdit.HeaderText = "OPTIONS"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        colEdit.Width = 70
        colEdit.Name = "colEdit"
        colEdit.FlatStyle = FlatStyle.Flat
        colEdit.DefaultCellStyle.BackColor = Color.White
        colEdit.DefaultCellStyle.ForeColor = Color.FromArgb(80, 70, 60)
        dgvInventory.Columns.Add(colEdit)

        ' Tombol Hapus
        Dim colDel As New DataGridViewButtonColumn()
        colDel.HeaderText = ""
        colDel.Text = "Hapus"
        colDel.UseColumnTextForButtonValue = True
        colDel.Width = 65
        colDel.Name = "colHapus"
        colDel.FlatStyle = FlatStyle.Flat
        colDel.DefaultCellStyle.BackColor = Color.White
        colDel.DefaultCellStyle.ForeColor = Color.FromArgb(180, 60, 60)
        dgvInventory.Columns.Add(colDel)
    End Sub

    Private Sub TambahKolomTeks(dataField As String, header As String, width As Integer)
        Dim col As New DataGridViewTextBoxColumn()
        col.DataPropertyName = dataField
        col.HeaderText = header
        col.Width = width
        col.Name = "col_" & dataField
        dgvInventory.Columns.Add(col)
    End Sub

    '═══════════════════════════════════════════════════════════
    ' MUAT / REFRESH DATA DARI DATABASE
    '═══════════════════════════════════════════════════════════
    Private Sub MuatDataDariDB(Optional keyword As String = "")
        Dim dt As DataTable

        If String.IsNullOrWhiteSpace(keyword) Then
            dt = ModuleParfum.GetAllParfum()
        Else
            dt = ModuleParfum.CariParfum(keyword)
        End If

        If dt Is Nothing Then
            MsgBox("Gagal memuat data dari database.", MsgBoxStyle.Exclamation)
            Return
        End If

        dtKini = dt
        IkatGrid(dt)
        RefreshStats()
    End Sub

    '── Ikat DataTable ke DGV lalu format sel ─────────────────
    Private Sub IkatGrid(dt As DataTable)
        dgvInventory.DataSource = Nothing
        dgvInventory.DataSource = dt

        For Each row As DataGridViewRow In dgvInventory.Rows
            If row.Index >= dt.Rows.Count Then Continue For
            Dim dr As DataRow = dt.Rows(row.Index)

            ' Warna stok
            Dim stok As Integer = CInt(dr("stok"))
            row.Cells("col_stok").Style.ForeColor =
                If(stok <= 5, Color.FromArgb(200, 50, 50), Color.FromArgb(50, 150, 80))
            row.Cells("col_stok").Value = stok.ToString("00") & " Unit"

            ' Format harga Rupiah
            row.Cells("col_harga").Value =
                ValidationModule.FormatRupiah(CDec(dr("harga")))

            ' Gambar (jika ada path)
            Dim gambarPath As String = If(IsDBNull(dr("gambar_path")), "", dr("gambar_path").ToString())
            If Not String.IsNullOrWhiteSpace(gambarPath) AndAlso File.Exists(gambarPath) Then
                Try
                    row.Cells("colGambar").Value =
                        New Bitmap(Image.FromFile(gambarPath), 52, 52)
                Catch
                    row.Cells("colGambar").Value = Nothing
                End Try
            Else
                row.Cells("colGambar").Value = Nothing
            End If
        Next

        lblShowingText.Text = $"Menampilkan {dt.Rows.Count} parfum"
    End Sub

    '═══════════════════════════════════════════════════════════
    ' STATISTIK (panel atas)
    '═══════════════════════════════════════════════════════════
    Private Sub RefreshStats()
        ' Total nilai inventori dari DB
        Dim totalNilai As Decimal = ModuleParfum.GetTotalNilaiInventori()
        lblRevValue.Text = ValidationModule.FormatRupiah(totalNilai)

        ' Jumlah item
        Dim jumlahItem As Integer = ModuleParfum.GetJumlahItem()
        lblEntrValue.Text = jumlahItem.ToString("00")

        ' Stok rendah (≤5)
        Dim dtRendah As DataTable = ModuleParfum.GetItemStokRendah(5)
        Dim jmlRendah As Integer = If(dtRendah IsNot Nothing, dtRendah.Rows.Count, 0)
        lblSlotsValue.Text = jmlRendah.ToString("00")
        lblSlotsAction.Text = If(jmlRendah > 0, "Stok Menipis!", "Stok Aman")
        lblSlotsAction.ForeColor = If(jmlRendah > 0,
            Color.FromArgb(210, 100, 30),
            Color.FromArgb(50, 150, 80))
    End Sub

    '═══════════════════════════════════════════════════════════
    ' CELL CLICK – Edit / Hapus
    '═══════════════════════════════════════════════════════════
    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvInventory.CellClick

        If e.RowIndex < 0 OrElse dtKini Is Nothing OrElse
           e.RowIndex >= dtKini.Rows.Count Then Return

        Dim idParfum As Integer = CInt(dtKini.Rows(e.RowIndex)("id"))

        Select Case dgvInventory.Columns(e.ColumnIndex).Name
            Case "colEdit"
                BukaDrawerEdit(idParfum, e.RowIndex)
            Case "colHapus"
                KonfirmasiHapus(idParfum, e.RowIndex)
        End Select
    End Sub

    '═══════════════════════════════════════════════════════════
    ' TOMBOL ADD NEW
    '═══════════════════════════════════════════════════════════
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        editingId = -1
        selectedGambar = ""
        lblDrawerTitle.Text = "Tambah Parfum Baru"
        BersihkanDrawer()
        TampilkanDrawer()
    End Sub

    '═══════════════════════════════════════════════════════════
    ' BUKA DRAWER UNTUK EDIT
    '═══════════════════════════════════════════════════════════
    Private Sub BukaDrawerEdit(idParfum As Integer, rowIdx As Integer)
        Dim dt As DataTable = ModuleParfum.GetParfumById(idParfum)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MsgBox("Data parfum tidak ditemukan.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim dr As DataRow = dt.Rows(0)
        editingId = idParfum

        lblDrawerTitle.Text = "Edit Parfum"
        txtFragranceName.Text = dr("nama_parfum").ToString()
        txtOriginBrand.Text = dr("merk").ToString()
        txtRetailPrice.Text = CDec(dr("harga")).ToString("0.00")
        txtCurrentStock.Text = dr("stok").ToString()

        ' Parse notes gabungan  →  TOP || HEART || BASE || CONC
        Dim notesGabung As String = If(IsDBNull(dr("notes")), "", dr("notes").ToString())
        ParseNotesGabung(notesGabung)

        ' Gambar
        selectedGambar = If(IsDBNull(dr("gambar_path")), "", dr("gambar_path").ToString())
        lblPhotoHint.Text = If(String.IsNullOrWhiteSpace(selectedGambar),
                               "Drop file atau klik untuk browse",
                               Path.GetFileName(selectedGambar))

        ValidationModule.ResetSemuaTextBox(txtFragranceName, txtOriginBrand,
                                          txtRetailPrice, txtCurrentStock)
        TampilkanDrawer()
    End Sub

    '═══════════════════════════════════════════════════════════
    ' SIMPAN (INSERT / UPDATE)
    '═══════════════════════════════════════════════════════════
    Private Sub btnSaveFragrance_Click(sender As Object, e As EventArgs) _
        Handles btnSaveFragrance.Click

        ' Reset highlight error
        ValidationModule.ResetSemuaTextBox(txtFragranceName, txtOriginBrand,
                                          txtRetailPrice, txtCurrentStock)

        ' Validasi via ModuleValidasi
        Dim v As ValidationModule.HasilValidasi = ValidationModule.ValidasiParfum(
            txtFragranceName.Text,
            txtOriginBrand.Text,
            txtRetailPrice.Text,
            txtCurrentStock.Text)

        If Not v.Valid Then
            MsgBox(v.Pesan, MsgBoxStyle.Exclamation, "Validasi Gagal")
            ' Tandai field yang salah
            Select Case v.Field
                Case "NamaParfum" : ValidationModule.TandaiError(txtFragranceName)
                Case "Merk" : ValidationModule.TandaiError(txtOriginBrand)
                Case "Harga" : ValidationModule.TandaiError(txtRetailPrice)
                Case "Stok" : ValidationModule.TandaiError(txtCurrentStock)
            End Select
            Return
        End If

        ' Validasi gambar (opsional)
        Dim vGambar = ValidationModule.ValidasiGambar(selectedGambar)
        If Not vGambar.Valid Then
            MsgBox(vGambar.Pesan, MsgBoxStyle.Exclamation, "Validasi Gambar")
            Return
        End If

        Dim harga As Decimal = ValidationModule.ParseDesimal(txtRetailPrice.Text)
        Dim stok As Integer = CInt(txtCurrentStock.Text.Trim())
        Dim notes As String = BuatNotesGabung()
        Dim berhasil As Boolean

        If editingId = -1 Then
            '── INSERT ──────────────────────────────────────────
            berhasil = ModuleParfum.TambahParfum(
                txtFragranceName.Text.Trim(),
                txtOriginBrand.Text.Trim(),
                harga, stok, notes, selectedGambar)

            If berhasil Then
                MsgBox("Parfum berhasil ditambahkan!", MsgBoxStyle.Information, "Berhasil")
            End If
        Else
            '── UPDATE ──────────────────────────────────────────
            berhasil = ModuleParfum.UpdateParfum(
                editingId,
                txtFragranceName.Text.Trim(),
                txtOriginBrand.Text.Trim(),
                harga, stok, notes, selectedGambar)

            If berhasil Then
                MsgBox("Data parfum berhasil diperbarui!", MsgBoxStyle.Information, "Berhasil")
            End If
        End If

        If berhasil Then
            MuatDataDariDB(txtSearch.Text.Trim())
            SembunyikanDrawer()
        End If
    End Sub

    '═══════════════════════════════════════════════════════════
    ' HAPUS PARFUM
    '═══════════════════════════════════════════════════════════
    Private Sub KonfirmasiHapus(idParfum As Integer, rowIdx As Integer)
        Dim nama As String = dtKini.Rows(rowIdx)("nama_parfum").ToString()
        Dim res = MsgBox($"Hapus ""{nama}"" dari inventori?{vbCrLf}" &
                         "Semua transaksi terkait juga akan dihapus (CASCADE).",
                         MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                         "Konfirmasi Hapus")

        If res = MsgBoxResult.Yes Then
            Dim berhasil = ModuleParfum.HapusParfum(idParfum)
            If berhasil Then
                MsgBox("Parfum berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                MuatDataDariDB(txtSearch.Text.Trim())
                If pnlDrawer.Visible Then SembunyikanDrawer()
            End If
        End If
    End Sub

    '═══════════════════════════════════════════════════════════
    ' UPLOAD FOTO – klik area foto
    '═══════════════════════════════════════════════════════════
    Private Sub pnlPhotoUpload_Click(sender As Object, e As EventArgs) _
        Handles pnlPhotoUpload.Click

        Using dlg As New OpenFileDialog()
            dlg.Title = "Pilih Foto Parfum"
            dlg.Filter = "Gambar|*.jpg;*.jpeg;*.png;*.bmp;*.webp"
            If dlg.ShowDialog() = DialogResult.OK Then
                Dim vGambar = ValidationModule.ValidasiGambar(dlg.FileName)
                If Not vGambar.Valid Then
                    MsgBox(vGambar.Pesan, MsgBoxStyle.Exclamation, "File Tidak Valid")
                    Return
                End If
                selectedGambar = dlg.FileName
                lblPhotoHint.Text = Path.GetFileName(dlg.FileName)
                lblPhotoIcon.Text = "[OK]"
            End If
        End Using
    End Sub

    '═══════════════════════════════════════════════════════════
    ' SEARCH REAL-TIME
    '═══════════════════════════════════════════════════════════
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) _
        Handles txtSearch.TextChanged

        MuatDataDariDB(txtSearch.Text.Trim())
    End Sub

    '═══════════════════════════════════════════════════════════
    ' HELPER – Notes gabungan (simpan ke kolom `notes` DB)
    ' Format: [TOP]...[/TOP][HEART]...[/HEART][BASE]...[/BASE][CONC]...[/CONC]
    '═══════════════════════════════════════════════════════════
    Private Function BuatNotesGabung() As String
        Return $"[TOP]{txtTopNotes.Text.Trim()}[/TOP]" &
               $"[HEART]{txtHeartNotes.Text.Trim()}[/HEART]" &
               $"[BASE]{txtBaseNotes.Text.Trim()}[/BASE]" &
               $"[CONC]{cboConcentration.Text}[/CONC]"
    End Function

    Private Sub ParseNotesGabung(gabung As String)
        txtTopNotes.Text = AmbilSegmen(gabung, "[TOP]", "[/TOP]")
        txtHeartNotes.Text = AmbilSegmen(gabung, "[HEART]", "[/HEART]")
        txtBaseNotes.Text = AmbilSegmen(gabung, "[BASE]", "[/BASE]")
        Dim conc = AmbilSegmen(gabung, "[CONC]", "[/CONC]")
        If conc <> "" Then
            Dim idx = cboConcentration.Items.IndexOf(conc)
            cboConcentration.SelectedIndex = If(idx >= 0, idx, 0)
        Else
            cboConcentration.SelectedIndex = 0
        End If
    End Sub

    Private Function AmbilSegmen(teks As String,
                                  tagBuka As String,
                                  tagTutup As String) As String
        Dim iStart = teks.IndexOf(tagBuka)
        Dim iEnd = teks.IndexOf(tagTutup)
        If iStart < 0 OrElse iEnd < 0 Then Return ""
        iStart += tagBuka.Length
        If iStart >= iEnd Then Return ""
        Return teks.Substring(iStart, iEnd - iStart)
    End Function

    '═══════════════════════════════════════════════════════════
    ' DRAWER SHOW / HIDE / CLEAR
    '═══════════════════════════════════════════════════════════
    Private Sub TampilkanDrawer()
        pnlDrawer.Visible = True
        pnlDrawer.BringToFront()
    End Sub

    Private Sub SembunyikanDrawer()
        pnlDrawer.Visible = False
        editingId = -1
        selectedGambar = ""
    End Sub

    Private Sub BersihkanDrawer()
        txtFragranceName.Text = ""
        txtOriginBrand.Text = ""
        txtRetailPrice.Text = "0.00"
        txtCurrentStock.Text = "0"
        txtTopNotes.Text = ""
        txtHeartNotes.Text = ""
        txtBaseNotes.Text = ""
        cboConcentration.SelectedIndex = 0
        lblPhotoHint.Text = "Drop file atau klik untuk browse"
        lblPhotoIcon.Text = "[+]"
        selectedGambar = ""
        ValidationModule.ResetSemuaTextBox(txtFragranceName, txtOriginBrand,
                                          txtRetailPrice, txtCurrentStock)
    End Sub

    '═══════════════════════════════════════════════════════════
    ' DRAWER – TOMBOL CANCEL & CLOSE
    '═══════════════════════════════════════════════════════════
    Private Sub btnCancelDrawer_Click(sender As Object, e As EventArgs) _
        Handles btnCancelDrawer.Click
        SembunyikanDrawer()
    End Sub

    Private Sub btnCloseDrawer_Click(sender As Object, e As EventArgs) _
        Handles btnCloseDrawer.Click
        SembunyikanDrawer()
    End Sub

    '═══════════════════════════════════════════════════════════
    ' NAV SIDEBAR
    '═══════════════════════════════════════════════════════════
    Private Sub StyleActiveNavButton(activeBtn As Button)
        For Each ctrl As Control In pnlSidebar.Controls
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).BackColor = Color.Transparent
                DirectCast(ctrl, Button).ForeColor = Color.FromArgb(150, 140, 130)
                DirectCast(ctrl, Button).Font = New Font("Segoe UI", 9)
            End If
        Next
        activeBtn.BackColor = Color.FromArgb(45, 40, 35)
        activeBtn.ForeColor = Color.White
        activeBtn.Font = New Font("Segoe UI", 9, FontStyle.Bold)
    End Sub

    Private Sub btnNavDashboard_Click(s As Object, e As EventArgs) Handles btnNavDashboard.Click
        StyleActiveNavButton(btnNavDashboard)
    End Sub
    Private Sub btnNavInventory_Click(s As Object, e As EventArgs) Handles btnNavInventory.Click
        StyleActiveNavButton(btnNavInventory)
    End Sub
    Private Sub btnNavFragrances_Click(s As Object, e As EventArgs) Handles btnNavFragrances.Click
        StyleActiveNavButton(btnNavFragrances)
    End Sub
    Private Sub btnNavAnalytics_Click(s As Object, e As EventArgs) Handles btnNavAnalytics.Click
        StyleActiveNavButton(btnNavAnalytics)
    End Sub

    '═══════════════════════════════════════════════════════════
    ' PAGINASI (placeholder – bisa dikembangkan)
    '═══════════════════════════════════════════════════════════
    Private Sub btnPrevPage_Click(s As Object, e As EventArgs) Handles btnPrevPage.Click
        ' TODO: implementasi paginasi server-side
    End Sub
    Private Sub btnNextPage_Click(s As Object, e As EventArgs) Handles btnNextPage.Click
        ' TODO: implementasi paginasi server-side
    End Sub

    '═══════════════════════════════════════════════════════════
    ' TUTUP FORM
    '═══════════════════════════════════════════════════════════
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()
    End Sub

    '═══════════════════════════════════════════════════════════
    ' DRAG FORM (borderless)
    '═══════════════════════════════════════════════════════════
    Private Sub FormInventory_MouseDown(s As Object, e As MouseEventArgs) _
        Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, &H2, 0)
        End If
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean : End Function
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer,
                                        wParam As Integer, lParam As Integer) As Integer
    End Function

End Class