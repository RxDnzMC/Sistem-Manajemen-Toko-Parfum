Imports System.Windows.Forms

Module ValidationModule
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiNumericUpDown(ep As ErrorProvider, num As NumericUpDown, pesan As String) As Boolean
        If num.Value <= 0 Then
            ep.SetError(num, pesan)
            Return False
        Else
            ep.SetError(num, "")
            Return True
        End If
    End Function

    Public Function ValidasiDataParfum(ep As ErrorProvider, txtNama As TextBox, txtMerk As TextBox, numHarga As NumericUpDown, numStok As NumericUpDown) As Boolean
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama Parfum tidak boleh kosong")
        Dim merkValid As Boolean = ValidasiTextBox(ep, txtMerk, "Merk tidak boleh kosong")
        Dim hargaValid As Boolean = ValidasiNumericUpDown(ep, numHarga, "Harga harus lebih dari 0")
        Dim stokValid As Boolean = ValidasiNumericUpDown(ep, numStok, "Stok harus lebih dari 0")

        Return namaValid And merkValid And hargaValid And stokValid
    End Function

    Public Function ValidasiGambar(ep As ErrorProvider, pb As PictureBox, path As String, pesan As String) As Boolean
        If String.IsNullOrEmpty(path) OrElse Not IO.File.Exists(path) Then
            ep.SetError(pb, pesan)
            Return False
        Else
            ep.SetError(pb, "")
            Return True
        End If
    End Function
End Module