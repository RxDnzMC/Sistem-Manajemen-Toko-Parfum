<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        DashboardToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        tpTambah = New TabPage()
        lblTitleTambah = New Label()
        lblNamaBaru = New Label()
        txtNamaBaru = New TextBox()
        lblMerkBaru = New Label()
        txtMerkBaru = New TextBox()
        lblHargaBaru = New Label()
        numHargaBaru = New NumericUpDown()
        lblStokBaru = New Label()
        numStokBaru = New NumericUpDown()
        lblNotesBaru = New Label()
        txtNotesBaru = New TextBox()
        pbGambarBaru = New PictureBox()
        btnPilihGambar = New Button()
        btnSimpan = New Button()
        tpDaftar = New TabPage()
        lblSearch = New Label()
        txtSearch = New TextBox()
        dgvParfum = New DataGridView()
        gbEdit = New GroupBox()
        lblIdEdit = New Label()
        txtIdEdit = New TextBox()
        lblNamaEdit = New Label()
        txtNamaEdit = New TextBox()
        lblMerkEdit = New Label()
        txtMerkEdit = New TextBox()
        lblHargaEdit = New Label()
        numHargaEdit = New NumericUpDown()
        lblStokEdit = New Label()
        numStokEdit = New NumericUpDown()
        lblNotesEdit = New Label()
        txtNotesEdit = New TextBox()
        pbGambarEdit = New PictureBox()
        btnPilihGambarEdit = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        tpTransaksi = New TabPage()
        lblTitleTransaksi = New Label()
        lblPilihParfum = New Label()
        cmbPilihParfum = New ComboBox()
        lblJumlahBeli = New Label()
        numJumlahBeli = New NumericUpDown()
        lblTotalHarga = New Label()
        txtTotalHarga = New TextBox()
        btnCatatTransaksi = New Button()
        dgvTransaksi = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        tpTambah.SuspendLayout()
        CType(numHargaBaru, ComponentModel.ISupportInitialize).BeginInit()
        CType(numStokBaru, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbGambarBaru, ComponentModel.ISupportInitialize).BeginInit()
        tpDaftar.SuspendLayout()
        CType(dgvParfum, ComponentModel.ISupportInitialize).BeginInit()
        gbEdit.SuspendLayout()
        CType(numHargaEdit, ComponentModel.ISupportInitialize).BeginInit()
        CType(numStokEdit, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbGambarEdit, ComponentModel.ISupportInitialize).BeginInit()
        tpTransaksi.SuspendLayout()
        CType(numJumlahBeli, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(98, 24)
        DashboardToolStripMenuItem.Text = "Dashboard"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        KeluarToolStripMenuItem.ForeColor = Color.Crimson
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(67, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpTambah)
        TabControl1.Controls.Add(tpDaftar)
        TabControl1.Controls.Add(tpTransaksi)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.ItemSize = New Size(150, 35)
        TabControl1.Location = New Point(0, 28)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 772)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabIndex = 1
        ' 
        ' tpTambah
        ' 
        tpTambah.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        tpTambah.Controls.Add(lblTitleTambah)
        tpTambah.Controls.Add(lblNamaBaru)
        tpTambah.Controls.Add(txtNamaBaru)
        tpTambah.Controls.Add(lblMerkBaru)
        tpTambah.Controls.Add(txtMerkBaru)
        tpTambah.Controls.Add(lblHargaBaru)
        tpTambah.Controls.Add(numHargaBaru)
        tpTambah.Controls.Add(lblStokBaru)
        tpTambah.Controls.Add(numStokBaru)
        tpTambah.Controls.Add(lblNotesBaru)
        tpTambah.Controls.Add(txtNotesBaru)
        tpTambah.Controls.Add(pbGambarBaru)
        tpTambah.Controls.Add(btnPilihGambar)
        tpTambah.Controls.Add(btnSimpan)
        tpTambah.Location = New Point(4, 39)
        tpTambah.Name = "tpTambah"
        tpTambah.Padding = New Padding(3)
        tpTambah.Size = New Size(792, 729)
        tpTambah.TabIndex = 0
        tpTambah.Text = "Tambah Parfum Baru"
        ' 
        ' lblTitleTambah
        ' 
        lblTitleTambah.AutoSize = True
        lblTitleTambah.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleTambah.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblTitleTambah.Location = New Point(20, 20)
        lblTitleTambah.Name = "lblTitleTambah"
        lblTitleTambah.Size = New Size(263, 38)
        lblTitleTambah.TabIndex = 0
        lblTitleTambah.Text = "Input Data Parfum"
        ' 
        ' lblNamaBaru
        ' 
        lblNamaBaru.AutoSize = True
        lblNamaBaru.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblNamaBaru.Location = New Point(20, 80)
        lblNamaBaru.Name = "lblNamaBaru"
        lblNamaBaru.Size = New Size(104, 20)
        lblNamaBaru.TabIndex = 1
        lblNamaBaru.Text = "Nama Parfum"
        ' 
        ' txtNamaBaru
        ' 
        txtNamaBaru.BorderStyle = BorderStyle.FixedSingle
        txtNamaBaru.Location = New Point(130, 77)
        txtNamaBaru.Name = "txtNamaBaru"
        txtNamaBaru.Size = New Size(250, 27)
        txtNamaBaru.TabIndex = 2
        ' 
        ' lblMerkBaru
        ' 
        lblMerkBaru.AutoSize = True
        lblMerkBaru.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblMerkBaru.Location = New Point(20, 120)
        lblMerkBaru.Name = "lblMerkBaru"
        lblMerkBaru.Size = New Size(45, 20)
        lblMerkBaru.TabIndex = 3
        lblMerkBaru.Text = "Merk"
        ' 
        ' txtMerkBaru
        ' 
        txtMerkBaru.BorderStyle = BorderStyle.FixedSingle
        txtMerkBaru.Location = New Point(130, 117)
        txtMerkBaru.Name = "txtMerkBaru"
        txtMerkBaru.Size = New Size(250, 27)
        txtMerkBaru.TabIndex = 4
        ' 
        ' lblHargaBaru
        ' 
        lblHargaBaru.AutoSize = True
        lblHargaBaru.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblHargaBaru.Location = New Point(20, 160)
        lblHargaBaru.Name = "lblHargaBaru"
        lblHargaBaru.Size = New Size(51, 20)
        lblHargaBaru.TabIndex = 5
        lblHargaBaru.Text = "Harga"
        ' 
        ' numHargaBaru
        ' 
        numHargaBaru.BorderStyle = BorderStyle.FixedSingle
        numHargaBaru.Location = New Point(130, 158)
        numHargaBaru.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        numHargaBaru.Name = "numHargaBaru"
        numHargaBaru.Size = New Size(150, 27)
        numHargaBaru.TabIndex = 6
        ' 
        ' lblStokBaru
        ' 
        lblStokBaru.AutoSize = True
        lblStokBaru.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblStokBaru.Location = New Point(20, 200)
        lblStokBaru.Name = "lblStokBaru"
        lblStokBaru.Size = New Size(39, 20)
        lblStokBaru.TabIndex = 7
        lblStokBaru.Text = "Stok"
        ' 
        ' numStokBaru
        ' 
        numStokBaru.BorderStyle = BorderStyle.FixedSingle
        numStokBaru.Location = New Point(130, 198)
        numStokBaru.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numStokBaru.Name = "numStokBaru"
        numStokBaru.Size = New Size(100, 27)
        numStokBaru.TabIndex = 8
        ' 
        ' lblNotesBaru
        ' 
        lblNotesBaru.AutoSize = True
        lblNotesBaru.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblNotesBaru.Location = New Point(20, 240)
        lblNotesBaru.Name = "lblNotesBaru"
        lblNotesBaru.Size = New Size(49, 20)
        lblNotesBaru.TabIndex = 9
        lblNotesBaru.Text = "Notes"
        ' 
        ' txtNotesBaru
        ' 
        txtNotesBaru.BorderStyle = BorderStyle.FixedSingle
        txtNotesBaru.Location = New Point(130, 237)
        txtNotesBaru.Multiline = True
        txtNotesBaru.Name = "txtNotesBaru"
        txtNotesBaru.Size = New Size(250, 100)
        txtNotesBaru.TabIndex = 10
        ' 
        ' pbGambarBaru
        ' 
        pbGambarBaru.BackColor = Color.White
        pbGambarBaru.BorderStyle = BorderStyle.FixedSingle
        pbGambarBaru.Location = New Point(420, 77)
        pbGambarBaru.Name = "pbGambarBaru"
        pbGambarBaru.Size = New Size(260, 260)
        pbGambarBaru.SizeMode = PictureBoxSizeMode.Zoom
        pbGambarBaru.TabIndex = 11
        pbGambarBaru.TabStop = False
        ' 
        ' btnPilihGambar
        ' 
        btnPilihGambar.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnPilihGambar.Cursor = Cursors.Hand
        btnPilihGambar.FlatAppearance.BorderSize = 0
        btnPilihGambar.FlatStyle = FlatStyle.Flat
        btnPilihGambar.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnPilihGambar.Location = New Point(420, 347)
        btnPilihGambar.Name = "btnPilihGambar"
        btnPilihGambar.Size = New Size(260, 35)
        btnPilihGambar.TabIndex = 12
        btnPilihGambar.Text = "Pilih Gambar"
        btnPilihGambar.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.MediumSeaGreen
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(130, 350)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(250, 45)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "SIMPAN DATA"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' tpDaftar
        ' 
        tpDaftar.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        tpDaftar.Controls.Add(lblSearch)
        tpDaftar.Controls.Add(txtSearch)
        tpDaftar.Controls.Add(dgvParfum)
        tpDaftar.Controls.Add(gbEdit)
        tpDaftar.Location = New Point(4, 39)
        tpDaftar.Name = "tpDaftar"
        tpDaftar.Padding = New Padding(3)
        tpDaftar.Size = New Size(792, 729)
        tpDaftar.TabIndex = 1
        tpDaftar.Text = "Daftar & Kelola Parfum"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblSearch.Location = New Point(20, 20)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(72, 20)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Cari Data"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Location = New Point(100, 17)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(300, 27)
        txtSearch.TabIndex = 1
        ' 
        ' dgvParfum
        ' 
        dgvParfum.AllowUserToAddRows = False
        dgvParfum.AllowUserToDeleteRows = False
        dgvParfum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvParfum.BackgroundColor = Color.White
        dgvParfum.BorderStyle = BorderStyle.None
        dgvParfum.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvParfum.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvParfum.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvParfum.ColumnHeadersHeight = 35
        dgvParfum.EnableHeadersVisualStyles = False
        dgvParfum.GridColor = Color.Gainsboro
        dgvParfum.Location = New Point(20, 60)
        dgvParfum.Name = "dgvParfum"
        dgvParfum.ReadOnly = True
        dgvParfum.RowHeadersVisible = False
        dgvParfum.RowHeadersWidth = 51
        DataGridViewCellStyle2.Padding = New Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(251))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        dgvParfum.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvParfum.RowTemplate.Height = 30
        dgvParfum.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvParfum.Size = New Size(750, 250)
        dgvParfum.TabIndex = 2
        ' 
        ' gbEdit
        ' 
        gbEdit.BackColor = Color.White
        gbEdit.Controls.Add(lblIdEdit)
        gbEdit.Controls.Add(txtIdEdit)
        gbEdit.Controls.Add(lblNamaEdit)
        gbEdit.Controls.Add(txtNamaEdit)
        gbEdit.Controls.Add(lblMerkEdit)
        gbEdit.Controls.Add(txtMerkEdit)
        gbEdit.Controls.Add(lblHargaEdit)
        gbEdit.Controls.Add(numHargaEdit)
        gbEdit.Controls.Add(lblStokEdit)
        gbEdit.Controls.Add(numStokEdit)
        gbEdit.Controls.Add(lblNotesEdit)
        gbEdit.Controls.Add(txtNotesEdit)
        gbEdit.Controls.Add(pbGambarEdit)
        gbEdit.Controls.Add(btnPilihGambarEdit)
        gbEdit.Controls.Add(btnUpdate)
        gbEdit.Controls.Add(btnDelete)
        gbEdit.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        gbEdit.Location = New Point(20, 330)
        gbEdit.Name = "gbEdit"
        gbEdit.Size = New Size(750, 380)
        gbEdit.TabIndex = 3
        gbEdit.TabStop = False
        gbEdit.Text = "Ubah & Hapus Data"
        ' 
        ' lblIdEdit
        ' 
        lblIdEdit.AutoSize = True
        lblIdEdit.Font = New Font("Segoe UI", 9.0F)
        lblIdEdit.Location = New Point(20, 40)
        lblIdEdit.Name = "lblIdEdit"
        lblIdEdit.Size = New Size(74, 20)
        lblIdEdit.TabIndex = 0
        lblIdEdit.Text = "ID Parfum"
        ' 
        ' txtIdEdit
        ' 
        txtIdEdit.BackColor = Color.WhiteSmoke
        txtIdEdit.BorderStyle = BorderStyle.FixedSingle
        txtIdEdit.Font = New Font("Segoe UI", 9.0F)
        txtIdEdit.Location = New Point(130, 37)
        txtIdEdit.Name = "txtIdEdit"
        txtIdEdit.ReadOnly = True
        txtIdEdit.Size = New Size(100, 27)
        txtIdEdit.TabIndex = 1
        ' 
        ' lblNamaEdit
        ' 
        lblNamaEdit.AutoSize = True
        lblNamaEdit.Font = New Font("Segoe UI", 9.0F)
        lblNamaEdit.Location = New Point(20, 80)
        lblNamaEdit.Name = "lblNamaEdit"
        lblNamaEdit.Size = New Size(99, 20)
        lblNamaEdit.TabIndex = 2
        lblNamaEdit.Text = "Nama Parfum"
        ' 
        ' txtNamaEdit
        ' 
        txtNamaEdit.BorderStyle = BorderStyle.FixedSingle
        txtNamaEdit.Font = New Font("Segoe UI", 9.0F)
        txtNamaEdit.Location = New Point(130, 77)
        txtNamaEdit.Name = "txtNamaEdit"
        txtNamaEdit.Size = New Size(250, 27)
        txtNamaEdit.TabIndex = 3
        ' 
        ' lblMerkEdit
        ' 
        lblMerkEdit.AutoSize = True
        lblMerkEdit.Font = New Font("Segoe UI", 9.0F)
        lblMerkEdit.Location = New Point(20, 120)
        lblMerkEdit.Name = "lblMerkEdit"
        lblMerkEdit.Size = New Size(42, 20)
        lblMerkEdit.TabIndex = 4
        lblMerkEdit.Text = "Merk"
        ' 
        ' txtMerkEdit
        ' 
        txtMerkEdit.BorderStyle = BorderStyle.FixedSingle
        txtMerkEdit.Font = New Font("Segoe UI", 9.0F)
        txtMerkEdit.Location = New Point(130, 117)
        txtMerkEdit.Name = "txtMerkEdit"
        txtMerkEdit.Size = New Size(250, 27)
        txtMerkEdit.TabIndex = 5
        ' 
        ' lblHargaEdit
        ' 
        lblHargaEdit.AutoSize = True
        lblHargaEdit.Font = New Font("Segoe UI", 9.0F)
        lblHargaEdit.Location = New Point(20, 160)
        lblHargaEdit.Name = "lblHargaEdit"
        lblHargaEdit.Size = New Size(50, 20)
        lblHargaEdit.TabIndex = 6
        lblHargaEdit.Text = "Harga"
        ' 
        ' numHargaEdit
        ' 
        numHargaEdit.BorderStyle = BorderStyle.FixedSingle
        numHargaEdit.Font = New Font("Segoe UI", 9.0F)
        numHargaEdit.Location = New Point(130, 158)
        numHargaEdit.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        numHargaEdit.Name = "numHargaEdit"
        numHargaEdit.Size = New Size(150, 27)
        numHargaEdit.TabIndex = 7
        ' 
        ' lblStokEdit
        ' 
        lblStokEdit.AutoSize = True
        lblStokEdit.Font = New Font("Segoe UI", 9.0F)
        lblStokEdit.Location = New Point(20, 200)
        lblStokEdit.Name = "lblStokEdit"
        lblStokEdit.Size = New Size(38, 20)
        lblStokEdit.TabIndex = 8
        lblStokEdit.Text = "Stok"
        ' 
        ' numStokEdit
        ' 
        numStokEdit.BorderStyle = BorderStyle.FixedSingle
        numStokEdit.Font = New Font("Segoe UI", 9.0F)
        numStokEdit.Location = New Point(130, 198)
        numStokEdit.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numStokEdit.Name = "numStokEdit"
        numStokEdit.Size = New Size(100, 27)
        numStokEdit.TabIndex = 9
        ' 
        ' lblNotesEdit
        ' 
        lblNotesEdit.AutoSize = True
        lblNotesEdit.Font = New Font("Segoe UI", 9.0F)
        lblNotesEdit.Location = New Point(20, 240)
        lblNotesEdit.Name = "lblNotesEdit"
        lblNotesEdit.Size = New Size(48, 20)
        lblNotesEdit.TabIndex = 10
        lblNotesEdit.Text = "Notes"
        ' 
        ' txtNotesEdit
        ' 
        txtNotesEdit.BorderStyle = BorderStyle.FixedSingle
        txtNotesEdit.Font = New Font("Segoe UI", 9.0F)
        txtNotesEdit.Location = New Point(130, 237)
        txtNotesEdit.Multiline = True
        txtNotesEdit.Name = "txtNotesEdit"
        txtNotesEdit.Size = New Size(250, 100)
        txtNotesEdit.TabIndex = 11
        ' 
        ' pbGambarEdit
        ' 
        pbGambarEdit.BackColor = Color.WhiteSmoke
        pbGambarEdit.BorderStyle = BorderStyle.FixedSingle
        pbGambarEdit.Location = New Point(420, 37)
        pbGambarEdit.Name = "pbGambarEdit"
        pbGambarEdit.Size = New Size(200, 200)
        pbGambarEdit.SizeMode = PictureBoxSizeMode.Zoom
        pbGambarEdit.TabIndex = 12
        pbGambarEdit.TabStop = False
        ' 
        ' btnPilihGambarEdit
        ' 
        btnPilihGambarEdit.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnPilihGambarEdit.Cursor = Cursors.Hand
        btnPilihGambarEdit.FlatAppearance.BorderSize = 0
        btnPilihGambarEdit.FlatStyle = FlatStyle.Flat
        btnPilihGambarEdit.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnPilihGambarEdit.Location = New Point(420, 250)
        btnPilihGambarEdit.Name = "btnPilihGambarEdit"
        btnPilihGambarEdit.Size = New Size(200, 35)
        btnPilihGambarEdit.TabIndex = 15
        btnPilihGambarEdit.Text = "Ubah Gambar"
        btnPilihGambarEdit.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.DodgerBlue
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(630, 245)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(100, 40)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Crimson
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(630, 295)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 40)
        btnDelete.TabIndex = 14
        btnDelete.Text = "HAPUS"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' tpTransaksi
        ' 
        tpTransaksi.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        tpTransaksi.Controls.Add(lblTitleTransaksi)
        tpTransaksi.Controls.Add(lblPilihParfum)
        tpTransaksi.Controls.Add(cmbPilihParfum)
        tpTransaksi.Controls.Add(lblJumlahBeli)
        tpTransaksi.Controls.Add(numJumlahBeli)
        tpTransaksi.Controls.Add(lblTotalHarga)
        tpTransaksi.Controls.Add(txtTotalHarga)
        tpTransaksi.Controls.Add(btnCatatTransaksi)
        tpTransaksi.Controls.Add(dgvTransaksi)
        tpTransaksi.Location = New Point(4, 39)
        tpTransaksi.Name = "tpTransaksi"
        tpTransaksi.Padding = New Padding(3)
        tpTransaksi.Size = New Size(792, 729)
        tpTransaksi.TabIndex = 2
        tpTransaksi.Text = "Transaksi Penjualan"
        ' 
        ' lblTitleTransaksi
        ' 
        lblTitleTransaksi.AutoSize = True
        lblTitleTransaksi.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleTransaksi.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblTitleTransaksi.Location = New Point(20, 20)
        lblTitleTransaksi.Name = "lblTitleTransaksi"
        lblTitleTransaksi.Size = New Size(257, 38)
        lblTitleTransaksi.TabIndex = 0
        lblTitleTransaksi.Text = "Kasir Toko Parfum"
        ' 
        ' lblPilihParfum
        ' 
        lblPilihParfum.AutoSize = True
        lblPilihParfum.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblPilihParfum.Location = New Point(20, 80)
        lblPilihParfum.Name = "lblPilihParfum"
        lblPilihParfum.Size = New Size(93, 20)
        lblPilihParfum.TabIndex = 1
        lblPilihParfum.Text = "Pilih Parfum"
        ' 
        ' cmbPilihParfum
        ' 
        cmbPilihParfum.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPilihParfum.FormattingEnabled = True
        cmbPilihParfum.Location = New Point(150, 77)
        cmbPilihParfum.Name = "cmbPilihParfum"
        cmbPilihParfum.Size = New Size(250, 28)
        cmbPilihParfum.TabIndex = 2
        ' 
        ' lblJumlahBeli
        ' 
        lblJumlahBeli.AutoSize = True
        lblJumlahBeli.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblJumlahBeli.Location = New Point(20, 120)
        lblJumlahBeli.Name = "lblJumlahBeli"
        lblJumlahBeli.Size = New Size(87, 20)
        lblJumlahBeli.TabIndex = 3
        lblJumlahBeli.Text = "Jumlah Beli"
        ' 
        ' numJumlahBeli
        ' 
        numJumlahBeli.BorderStyle = BorderStyle.FixedSingle
        numJumlahBeli.Location = New Point(150, 118)
        numJumlahBeli.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numJumlahBeli.Name = "numJumlahBeli"
        numJumlahBeli.Size = New Size(100, 27)
        numJumlahBeli.TabIndex = 4
        ' 
        ' lblTotalHarga
        ' 
        lblTotalHarga.AutoSize = True
        lblTotalHarga.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblTotalHarga.Location = New Point(20, 160)
        lblTotalHarga.Name = "lblTotalHarga"
        lblTotalHarga.Size = New Size(88, 20)
        lblTotalHarga.TabIndex = 5
        lblTotalHarga.Text = "Total Harga"
        ' 
        ' txtTotalHarga
        ' 
        txtTotalHarga.BorderStyle = BorderStyle.FixedSingle
        txtTotalHarga.Location = New Point(150, 157)
        txtTotalHarga.Name = "txtTotalHarga"
        txtTotalHarga.ReadOnly = True
        txtTotalHarga.Size = New Size(200, 27)
        txtTotalHarga.TabIndex = 6
        ' 
        ' btnCatatTransaksi
        ' 
        btnCatatTransaksi.BackColor = Color.MediumSeaGreen
        btnCatatTransaksi.Cursor = Cursors.Hand
        btnCatatTransaksi.FlatAppearance.BorderSize = 0
        btnCatatTransaksi.FlatStyle = FlatStyle.Flat
        btnCatatTransaksi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnCatatTransaksi.ForeColor = Color.White
        btnCatatTransaksi.Location = New Point(150, 200)
        btnCatatTransaksi.Name = "btnCatatTransaksi"
        btnCatatTransaksi.Size = New Size(250, 45)
        btnCatatTransaksi.TabIndex = 7
        btnCatatTransaksi.Text = "CATAT TRANSAKSI"
        btnCatatTransaksi.UseVisualStyleBackColor = False
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.AllowUserToAddRows = False
        dgvTransaksi.AllowUserToDeleteRows = False
        dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransaksi.BackgroundColor = Color.White
        dgvTransaksi.BorderStyle = BorderStyle.None
        dgvTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvTransaksi.ColumnHeadersHeight = 35
        dgvTransaksi.EnableHeadersVisualStyles = False
        dgvTransaksi.GridColor = Color.Gainsboro
        dgvTransaksi.Location = New Point(20, 270)
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.ReadOnly = True
        dgvTransaksi.RowHeadersVisible = False
        dgvTransaksi.RowHeadersWidth = 51
        DataGridViewCellStyle4.Padding = New Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(251))
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        dgvTransaksi.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvTransaksi.RowTemplate.Height = 30
        dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransaksi.Size = New Size(750, 430)
        dgvTransaksi.TabIndex = 8
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        ClientSize = New Size(800, 800)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplikasi Manajemen Toko Parfum"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tpTambah.ResumeLayout(False)
        tpTambah.PerformLayout()
        CType(numHargaBaru, ComponentModel.ISupportInitialize).EndInit()
        CType(numStokBaru, ComponentModel.ISupportInitialize).EndInit()
        CType(pbGambarBaru, ComponentModel.ISupportInitialize).EndInit()
        tpDaftar.ResumeLayout(False)
        tpDaftar.PerformLayout()
        CType(dgvParfum, ComponentModel.ISupportInitialize).EndInit()
        gbEdit.ResumeLayout(False)
        gbEdit.PerformLayout()
        CType(numHargaEdit, ComponentModel.ISupportInitialize).EndInit()
        CType(numStokEdit, ComponentModel.ISupportInitialize).EndInit()
        CType(pbGambarEdit, ComponentModel.ISupportInitialize).EndInit()
        tpTransaksi.ResumeLayout(False)
        tpTransaksi.PerformLayout()
        CType(numJumlahBeli, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpTambah As System.Windows.Forms.TabPage
    Friend WithEvents lblTitleTambah As System.Windows.Forms.Label
    Friend WithEvents lblNamaBaru As System.Windows.Forms.Label
    Friend WithEvents txtNamaBaru As System.Windows.Forms.TextBox
    Friend WithEvents lblMerkBaru As System.Windows.Forms.Label
    Friend WithEvents txtMerkBaru As System.Windows.Forms.TextBox
    Friend WithEvents lblHargaBaru As System.Windows.Forms.Label
    Friend WithEvents numHargaBaru As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStokBaru As System.Windows.Forms.Label
    Friend WithEvents numStokBaru As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNotesBaru As System.Windows.Forms.Label
    Friend WithEvents txtNotesBaru As System.Windows.Forms.TextBox
    Friend WithEvents pbGambarBaru As System.Windows.Forms.PictureBox
    Friend WithEvents btnPilihGambar As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents tpDaftar As System.Windows.Forms.TabPage
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvParfum As System.Windows.Forms.DataGridView
    Friend WithEvents gbEdit As System.Windows.Forms.GroupBox
    Friend WithEvents lblIdEdit As System.Windows.Forms.Label
    Friend WithEvents txtIdEdit As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaEdit As System.Windows.Forms.Label
    Friend WithEvents txtNamaEdit As System.Windows.Forms.TextBox
    Friend WithEvents lblMerkEdit As System.Windows.Forms.Label
    Friend WithEvents txtMerkEdit As System.Windows.Forms.TextBox
    Friend WithEvents lblHargaEdit As System.Windows.Forms.Label
    Friend WithEvents numHargaEdit As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStokEdit As System.Windows.Forms.Label
    Friend WithEvents numStokEdit As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNotesEdit As System.Windows.Forms.Label
    Friend WithEvents txtNotesEdit As System.Windows.Forms.TextBox
    Friend WithEvents pbGambarEdit As System.Windows.Forms.PictureBox
    Friend WithEvents btnPilihGambarEdit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents tpTransaksi As System.Windows.Forms.TabPage
    Friend WithEvents lblTitleTransaksi As System.Windows.Forms.Label
    Friend WithEvents lblPilihParfum As System.Windows.Forms.Label
    Friend WithEvents cmbPilihParfum As System.Windows.Forms.ComboBox
    Friend WithEvents lblJumlahBeli As System.Windows.Forms.Label
    Friend WithEvents numJumlahBeli As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTotalHarga As System.Windows.Forms.Label
    Friend WithEvents txtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents btnCatatTransaksi As System.Windows.Forms.Button
    Friend WithEvents dgvTransaksi As System.Windows.Forms.DataGridView

    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class