Public Class OrderFooter

    ' Event agar FormKasir tahu kapan pembayaran selesai dan bisa mengosongkan keranjang
    Public Event PaymentConfirmed()
    Public Sub UpdateTotals(subtotal As Decimal)
        Dim taxRate As Decimal = 0.085D ' Pajak 8.5%
        Dim taxAmount As Decimal = subtotal * taxRate
        Dim total As Decimal = subtotal + taxAmount

        ' Atau tetap menggunakan "$" & ... jika ingin hardcoded
        LblSubtotalValue.Text = subtotal.ToString("C2")
        LblTaxValue.Text = taxAmount.ToString("C2")
        LblTotalValue.Text = total.ToString("C2")
    End Sub
    Public Sub ClearFooter()
        UpdateTotals(0)
    End Sub

    ' Event saat tombol "Confirm Payment" diklik
    Private Sub BtnConfirmPayment_Click(sender As Object, e As EventArgs) Handles BtnConfirmPayment.Click
        ' Validasi sederhana: Jangan proses jika totalnya 0
        If LblTotalValue.Text = "$0.00" Or LblTotalValue.Text = "Rp0,00" Then
            MessageBox.Show("Keranjang masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = MessageBox.Show("Konfirmasi pembayaran dan cetak struk?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Di sini nanti tempat logika simpan ke database (Tabel Transaksi)
            MessageBox.Show("Pembayaran Berhasil Disimpan!", "Aura Perfumerie", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Beritahu FormKasir bahwa pembayaran sukses
            RaiseEvent PaymentConfirmed()
        End If
    End Sub

    ' Event untuk tombol Assign Client (Opsional)
    Private Sub BtnAssignClient_Click(sender As Object, e As EventArgs) Handles BtnAssignClient.Click
        MessageBox.Show("Fitur Pilih Pelanggan akan segera hadir.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class