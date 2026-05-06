Imports System.ComponentModel

Public Class CartItem

    ' Properti harga satuan (dalam angka asli) untuk perhitungan matematika
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property UnitPrice As Decimal = 0

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ItemName As String
        Get
            Return LblItemName.Text
        End Get
        Set(value As String)
            LblItemName.Text = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ItemDesc As String
        Get
            Return LblItemDesc.Text
        End Get
        Set(value As String)
            LblItemDesc.Text = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ItemQty As Integer
        Get
            Return Integer.Parse(LblQty.Text)
        End Get
        Set(value As Integer)
            LblQty.Text = value.ToString()
            UpdateDisplayPrice() ' Update harga saat qty berubah
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ItemImage As Image
        Get
            Return PicItem.Image
        End Get
        Set(value As Image)
            PicItem.Image = value
        End Set
    End Property

    ' Fungsi untuk mengupdate teks label harga berdasarkan Harga Satuan x Qty
    Public Sub UpdateDisplayPrice()
        Dim totalPrice As Decimal = UnitPrice * ItemQty
        LblItemPrice.Text = "$" & totalPrice.ToString("N2")
    End Sub

    ' Event Klik Tombol Plus
    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        ItemQty += 1
        ' TODO: Nanti panggil fungsi di FormKasir untuk update Total Keseluruhan
    End Sub

    ' Event Klik Tombol Minus
    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        If ItemQty > 1 Then
            ItemQty -= 1
            ' TODO: Nanti panggil fungsi di FormKasir untuk update Total Keseluruhan
        End If
    End Sub

    ' Event Klik Tombol Silang (X)
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Me.Parent.Controls.Remove(Me)
        ' TODO: Nanti panggil fungsi di FormKasir untuk update Total Keseluruhan
    End Sub

End Class