Imports System.ComponentModel

Public Class CartItem
    Public Event ItemUpdated()
    Public Event ItemRemoved(item As CartItem)
    ' Properti harga satuan (dalam angka asli) untuk perhitungan matematika
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property UnitPrice As Decimal = 0

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ProductID As String

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
            UpdateDisplayPrice()

            ' Kirim sinyal bahwa ada perubahan harga/kuantitas
            RaiseEvent ItemUpdated()
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

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        ItemQty += 1
    End Sub

    ' Event Klik Tombol Minus
    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        If ItemQty > 1 Then
            ItemQty -= 1
        End If
    End Sub

    ' Event Klik Tombol Silang (X)
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        RaiseEvent ItemRemoved(Me)
    End Sub

End Class