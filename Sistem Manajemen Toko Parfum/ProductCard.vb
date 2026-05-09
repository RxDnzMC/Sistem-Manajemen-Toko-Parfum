Imports System.ComponentModel

Public Class ProductCard

    ' Memberitahu VS Designer untuk tidak menyimpan properti ini ke file Designer utama
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ProductID As String

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ParfumName As String
        Get
            Return LblName.Text
        End Get
        Set(value As String)
            LblName.Text = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ParfumPrice As String
        Get
            Return LblPrice.Text
        End Get
        Set(value As String)
            LblPrice.Text = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ParfumCategory As String
        Get
            Return LblCategory.Text
        End Get
        Set(value As String)
            LblCategory.Text = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ParfumDescription As String
        Get
            Return LblDesc.Text
        End Get
        Set(value As String)
            LblDesc.Text = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ParfumImage As Image
        Get
            Return PicImage.Image
        End Get
        Set(value As Image)
            PicImage.Image = value
        End Set
    End Property

    '' Event saat kartu diklik (untuk dimasukkan ke keranjang)
    'Private Sub Card_Clicked(sender As Object, e As EventArgs) Handles MyBase.Click, PicImage.Click, PanelInfo.Click, LblName.Click
    '    MessageBox.Show(ParfumName & " dipilih!")
    'End Sub
End Class