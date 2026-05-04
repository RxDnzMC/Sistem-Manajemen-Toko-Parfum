Imports System.Text.RegularExpressions

Module ValidationModule

    '═══════════════════════════════════════════════════════════
    ' HASIL VALIDASI
    '═══════════════════════════════════════════════════════════
    Public Class HasilValidasi
        Public Property Valid As Boolean = True
        Public Property Pesan As String = ""
        Public Property Field As String = ""   ' nama field bermasalah

        Public Sub New(valid As Boolean, pesan As String, Optional field As String = "")
            Me.Valid = valid
            Me.Pesan = pesan
            Me.Field = field
        End Sub
    End Class

    '═══════════════════════════════════════════════════════════
    ' VALIDASI FORM PARFUM (ADD / EDIT)
    '═══════════════════════════════════════════════════════════
    Public Function ValidasiParfum(namaParfum As String,
                                   merk As String,
                                   hargaStr As String,
                                   stokStr As String) As HasilValidasi

        ' 1. Nama parfum
        If String.IsNullOrWhiteSpace(namaParfum) Then
            Return New HasilValidasi(False, "Nama parfum tidak boleh kosong.", "NamaParfum")
        End If
        If namaParfum.Trim().Length < 2 Then
            Return New HasilValidasi(False, "Nama parfum minimal 2 karakter.", "NamaParfum")
        End If
        If namaParfum.Trim().Length > 100 Then
            Return New HasilValidasi(False, "Nama parfum maksimal 100 karakter.", "NamaParfum")
        End If

        ' 2. Merk
        If String.IsNullOrWhiteSpace(merk) Then
            Return New HasilValidasi(False, "Merk / Brand tidak boleh kosong.", "Merk")
        End If
        If merk.Trim().Length < 2 Then
            Return New HasilValidasi(False, "Merk minimal 2 karakter.", "Merk")
        End If
        If merk.Trim().Length > 100 Then
            Return New HasilValidasi(False, "Merk maksimal 100 karakter.", "Merk")
        End If

        ' 3. Harga
        If String.IsNullOrWhiteSpace(hargaStr) Then
            Return New HasilValidasi(False, "Harga tidak boleh kosong.", "Harga")
        End If
        Dim harga As Decimal
        If Not Decimal.TryParse(hargaStr.Trim().Replace(",", "."),
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                harga) Then
            Return New HasilValidasi(False, "Harga harus berupa angka (contoh: 250000 atau 250000.00).", "Harga")
        End If
        If harga <= 0 Then
            Return New HasilValidasi(False, "Harga harus lebih dari 0.", "Harga")
        End If
        If harga > 99999999.99D Then
            Return New HasilValidasi(False, "Harga melebihi batas maksimal.", "Harga")
        End If

        ' 4. Stok
        If String.IsNullOrWhiteSpace(stokStr) Then
            Return New HasilValidasi(False, "Stok tidak boleh kosong.", "Stok")
        End If
        Dim stok As Integer
        If Not Integer.TryParse(stokStr.Trim(), stok) Then
            Return New HasilValidasi(False, "Stok harus berupa angka bulat (contoh: 10).", "Stok")
        End If
        If stok < 0 Then
            Return New HasilValidasi(False, "Stok tidak boleh negatif.", "Stok")
        End If
        If stok > 99999 Then
            Return New HasilValidasi(False, "Stok melebihi batas maksimal (99999).", "Stok")
        End If

        Return New HasilValidasi(True, "OK")
    End Function

    '═══════════════════════════════════════════════════════════
    ' VALIDASI FORM TRANSAKSI PENJUALAN
    '═══════════════════════════════════════════════════════════
    Public Function ValidasiTransaksi(idParfum As Integer,
                                      jumlahStr As String,
                                      stokTersedia As Integer) As HasilValidasi

        ' 1. Parfum harus dipilih
        If idParfum <= 0 Then
            Return New HasilValidasi(False, "Silakan pilih parfum terlebih dahulu.", "IdParfum")
        End If

        ' 2. Jumlah beli
        If String.IsNullOrWhiteSpace(jumlahStr) Then
            Return New HasilValidasi(False, "Jumlah beli tidak boleh kosong.", "JumlahBeli")
        End If
        Dim jumlah As Integer
        If Not Integer.TryParse(jumlahStr.Trim(), jumlah) Then
            Return New HasilValidasi(False, "Jumlah beli harus berupa angka bulat.", "JumlahBeli")
        End If
        If jumlah <= 0 Then
            Return New HasilValidasi(False, "Jumlah beli harus minimal 1.", "JumlahBeli")
        End If

        ' 3. Cek stok mencukupi
        If jumlah > stokTersedia Then
            Return New HasilValidasi(False,
                $"Jumlah beli ({jumlah}) melebihi stok tersedia ({stokTersedia}).",
                "JumlahBeli")
        End If

        Return New HasilValidasi(True, "OK")
    End Function

    '═══════════════════════════════════════════════════════════
    ' VALIDASI PATH GAMBAR
    '═══════════════════════════════════════════════════════════
    Public Function ValidasiGambar(filePath As String) As HasilValidasi
        If String.IsNullOrWhiteSpace(filePath) Then
            Return New HasilValidasi(True, "OK")   ' gambar opsional
        End If
        If Not System.IO.File.Exists(filePath) Then
            Return New HasilValidasi(False, "File gambar tidak ditemukan di path yang dipilih.", "Gambar")
        End If
        Dim ext As String = System.IO.Path.GetExtension(filePath).ToLower()
        Dim allowedExt() As String = {".jpg", ".jpeg", ".png", ".bmp", ".webp"}
        If Not allowedExt.Contains(ext) Then
            Return New HasilValidasi(False,
                "Format gambar tidak didukung. Gunakan: JPG, PNG, BMP, atau WEBP.",
                "Gambar")
        End If
        Dim info As New System.IO.FileInfo(filePath)
        If info.Length > 5 * 1024 * 1024 Then   ' maks 5 MB
            Return New HasilValidasi(False, "Ukuran gambar maksimal 5 MB.", "Gambar")
        End If
        Return New HasilValidasi(True, "OK")
    End Function

    '═══════════════════════════════════════════════════════════
    ' HELPER – Tandai TextBox error / normal
    '═══════════════════════════════════════════════════════════
    Public Sub TandaiError(tb As System.Windows.Forms.TextBox,
                            Optional isError As Boolean = True)
        tb.BackColor = If(isError,
                          System.Drawing.Color.FromArgb(255, 235, 235),
                          System.Drawing.Color.White)
    End Sub

    Public Sub ResetSemuaTextBox(ParamArray controls() As System.Windows.Forms.TextBox)
        For Each tb In controls
            TandaiError(tb, False)
        Next
    End Sub

    '═══════════════════════════════════════════════════════════
    ' HELPER – Parse desimal aman (titik/koma)
    '═══════════════════════════════════════════════════════════
    Public Function ParseDesimal(teks As String) As Decimal
        Dim cleaned = teks.Trim().Replace(",", ".")
        Dim hasil As Decimal
        Decimal.TryParse(cleaned,
                         System.Globalization.NumberStyles.Any,
                         System.Globalization.CultureInfo.InvariantCulture,
                         hasil)
        Return hasil
    End Function

    '═══════════════════════════════════════════════════════════
    ' HELPER – Format Rupiah
    '═══════════════════════════════════════════════════════════
    Public Function FormatRupiah(nilai As Decimal) As String
        Return "Rp " & nilai.ToString("N0", New System.Globalization.CultureInfo("id-ID"))
    End Function

End Module