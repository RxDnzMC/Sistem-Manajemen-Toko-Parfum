Imports MySqlConnector
Imports System.IO

Public Class FormKasir

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tes koneksi dari ConnectionModule milikmu
        If ConnectionModule.TestConnection() Then
            MuatProdukKeGallery()
        Else
            MessageBox.Show("Koneksi ke database gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private _altF4Pressed As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            _altF4Pressed = True
            MessageBox.Show("ALT + F4 is disabled for this application.")
            Return True ' Consume the key press, prevent form closing
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub MuatProdukKeGallery()
        ' 1. Bersihkan panel agar tidak ada penumpukan kartu saat refresh
        FlowLayoutPanelProducts.Controls.Clear()

        ' 2. Sesuaikan Query dengan struktur tabel di ConnectionModule milikmu
        Dim query As String = "SELECT id, nama_parfum, merk, harga, notes, gambar_path FROM parfum"

        Try
            ' Mengambil data menggunakan ExecuteQuery dari ConnectionModule
            Dim dt As DataTable = ConnectionModule.ExecuteQuery(query)

            ' Jika datatable kosong atau null, hentikan proses
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Exit Sub
            End If

            ' 3. Iterasi setiap baris data
            For Each row As DataRow In dt.Rows
                Dim card As New ProductCard()

                ' Map data ke Properti ProductCard (Sesuaikan dengan nama kolom DB kamu)
                card.ProductID = row("id").ToString()
                card.ParfumName = row("nama_parfum").ToString()
                card.ParfumCategory = row("merk").ToString() ' Menggunakan kolom merk sebagai kategori
                card.ParfumDescription = row("notes").ToString() ' Menggunakan notes sebagai deskripsi

                ' Format Harga ke Rupiah
                Dim harga As Decimal = Convert.ToDecimal(row("harga"))
                card.ParfumPrice = "Rp " & harga.ToString("N0")

                ' 4. Loading Gambar dengan aman menggunakan MemoryStream
                Dim imagePath As String = row("gambar_path").ToString()
                If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                    Try
                        Dim bytes As Byte() = File.ReadAllBytes(imagePath)
                        Using ms As New MemoryStream(bytes)
                            card.ParfumImage = Image.FromStream(ms)
                        End Using
                    Catch
                        ' Jika gambar gagal dimuat (corrupt, dsb), abaikan agar pakai gambar default di designer
                    End Try
                End If

                ' 5. Tambahkan Event Klik
                AddHandler card.Click, AddressOf ProductCard_Clicked
                For Each ctrl As Control In card.Controls
                    AddHandler ctrl.Click, AddressOf ProductCard_Clicked
                    ' Jika ada sub-panel (seperti PanelInfo)
                    For Each subCtrl As Control In ctrl.Controls
                        AddHandler subCtrl.Click, AddressOf ProductCard_Clicked
                    Next
                Next

                ' 6. Masukkan kartu ke dalam panel galeri
                FlowLayoutPanelProducts.Controls.Add(card)
            Next

        Catch ex As Exception
            MessageBox.Show("Gagal memuat produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event Handler saat produk dipilih
    Private Sub ProductCard_Clicked(sender As Object, e As EventArgs)
        Dim clickedCard As ProductCard = Nothing
        ' Cari objek ProductCard dari elemen yang diklik (karena bisa saja yang diklik label/gambar di dalam kartu)
        If TypeOf sender Is ProductCard Then
            clickedCard = DirectCast(sender, ProductCard)
        ElseIf TypeOf DirectCast(sender, Control).Parent Is ProductCard Then
            clickedCard = DirectCast(DirectCast(sender, Control).Parent, ProductCard)
        ElseIf TypeOf DirectCast(sender, Control).Parent.Parent Is ProductCard Then
            clickedCard = DirectCast(DirectCast(sender, Control).Parent.Parent, ProductCard)
        End If
        If clickedCard IsNot Nothing Then
            TambahKeKeranjang(clickedCard)
        End If
    End Sub
    Private Sub TambahKeKeranjang(product As ProductCard)
        Dim itemSudahAda As CartItem = Nothing

        ' 1. Cek apakah produk dengan ID yang sama sudah ada di keranjang
        For Each ctrl As Control In FlowLayoutPanelCartItems.Controls
            If TypeOf ctrl Is CartItem Then
                Dim itemInCart = DirectCast(ctrl, CartItem)
                ' Membandingkan nama atau ID produk
                If itemInCart.ItemName = product.ParfumName Then
                    itemSudahAda = itemInCart
                    Exit For
                End If
            End If
        Next

        ' 2. Logika: Jika sudah ada, tambah Qty. Jika belum, buat baru.
        If itemSudahAda IsNot Nothing Then
            itemSudahAda.ItemQty += 1
        Else
            ' Buat instance CartItem baru
            Dim newItem As New CartItem()

            ' Mapping data dari ProductCard ke CartItem
            newItem.ItemName = product.ParfumName
            newItem.ItemDesc = product.ParfumDescription
            newItem.ItemImage = product.ParfumImage

            ' Bersihkan string harga ("Rp 150.000" / "$245.00" -> jadi angka desimal murni)
            Dim cleanPrice As String = product.ParfumPrice.Replace("Rp", "").Replace("$", "").Replace(".", "").Replace(",", "").Trim()
            Dim priceValue As Decimal = 0
            Decimal.TryParse(cleanPrice, priceValue)

            newItem.UnitPrice = priceValue
            newItem.ItemQty = 1 ' Default awal

            ' Memasang "Telinga" untuk mendengarkan sinyal perubahan dari CartItem
            AddHandler newItem.ItemUpdated, AddressOf HitungTotalKeseluruhan
            AddHandler newItem.ItemRemoved, AddressOf HapusItemDariKeranjang

            ' Masukkan ke dalam UI Panel Keranjang
            FlowLayoutPanelCartItems.Controls.Add(newItem)
        End If

        ' Hitung ulang total belanjaan
        HitungTotalKeseluruhan()
    End Sub

    Public Sub HitungTotalKeseluruhan()
        Dim totalSubtotal As Decimal = 0

        ' Loop semua item yang ada di keranjang
        For Each ctrl As Control In FlowLayoutPanelCartItems.Controls
            If TypeOf ctrl Is CartItem Then
                Dim item = DirectCast(ctrl, CartItem)
                totalSubtotal += (item.UnitPrice * item.ItemQty)
            End If
        Next

        ' Kirim hasilnya ke OrderFooter untuk ditampilkan
        OrderFooter1.UpdateTotals(totalSubtotal)
    End Sub

    ' Menangani event saat tombol (X) di CartItem diklik
    Private Sub HapusItemDariKeranjang(item As CartItem)
        FlowLayoutPanelCartItems.Controls.Remove(item)
        item.Dispose()
        HitungTotalKeseluruhan() ' Hitung ulang setelah barang dihapus
    End Sub

    ' Menangani event jika tombol "Confirm Payment" di Footer diklik
    Private Sub OrderFooter1_PaymentConfirmed() Handles OrderFooter1.PaymentConfirmed
        ' Kosongkan panel keranjang
        FlowLayoutPanelCartItems.Controls.Clear()
        ' Reset angka footer ke 0
        OrderFooter1.ClearFooter()
    End Sub
End Class