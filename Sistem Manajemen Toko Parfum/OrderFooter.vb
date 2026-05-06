Public Class OrderFooter

    ' Fungsi untuk mengkalkulasi dan menampilkan total secara otomatis
    Public Sub UpdateTotals(subtotal As Decimal)
        Dim taxRate As Decimal = 0.085D ' Pajak 8.5% sesuai desain Figma
        Dim taxAmount As Decimal = subtotal * taxRate
        Dim total As Decimal = subtotal + taxAmount

        LblSubtotalValue.Text = "$" & subtotal.ToString("N2")
        LblTaxValue.Text = "$" & taxAmount.ToString("N2")
        LblTotalValue.Text = "$" & total.ToString("N2")
    End Sub

    Private Sub BtnConfirmPayment_Click(sender As Object, e As EventArgs) Handles BtnConfirmPayment.Click
        ' Area eksekusi saat kasir menekan tombol bayar
        MessageBox.Show("Memproses pembayaran...", "Aura Perfumerie", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class