<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CartItem
    Inherits System.Windows.Forms.UserControl

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
        PicItem = New PictureBox()
        LblItemName = New Label()
        LblItemDesc = New Label()
        LblItemPrice = New Label()
        BtnMinus = New Button()
        LblQty = New Label()
        BtnPlus = New Button()
        BtnRemove = New Button()
        CType(PicItem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicItem
        ' 
        PicItem.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        PicItem.Location = New Point(11, 13)
        PicItem.Margin = New Padding(3, 4, 3, 4)
        PicItem.Name = "PicItem"
        PicItem.Size = New Size(57, 67)
        PicItem.SizeMode = PictureBoxSizeMode.StretchImage
        PicItem.TabIndex = 0
        PicItem.TabStop = False
        ' 
        ' LblItemName
        ' 
        LblItemName.AutoSize = True
        LblItemName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblItemName.Location = New Point(80, 13)
        LblItemName.Name = "LblItemName"
        LblItemName.Size = New Size(120, 20)
        LblItemName.TabIndex = 1
        LblItemName.Text = "Midnight Santal"
        ' 
        ' LblItemDesc
        ' 
        LblItemDesc.Font = New Font("Segoe UI", 7F)
        LblItemDesc.ForeColor = Color.Gray
        LblItemDesc.Location = New Point(80, 36)
        LblItemDesc.Name = "LblItemDesc"
        LblItemDesc.Size = New Size(126, 16)
        LblItemDesc.TabIndex = 2
        LblItemDesc.Text = "100ml • EAU DE PARFUM"
        ' 
        ' LblItemPrice
        ' 
        LblItemPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblItemPrice.Location = New Point(259, 60)
        LblItemPrice.Name = "LblItemPrice"
        LblItemPrice.Size = New Size(91, 27)
        LblItemPrice.TabIndex = 6
        LblItemPrice.Text = "$245.00"
        LblItemPrice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' BtnMinus
        ' 
        BtnMinus.Cursor = Cursors.Hand
        BtnMinus.FlatAppearance.BorderSize = 0
        BtnMinus.FlatStyle = FlatStyle.Flat
        BtnMinus.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        BtnMinus.Location = New Point(80, 60)
        BtnMinus.Margin = New Padding(3, 4, 3, 4)
        BtnMinus.Name = "BtnMinus"
        BtnMinus.Size = New Size(23, 27)
        BtnMinus.TabIndex = 3
        BtnMinus.Text = "-"
        ' 
        ' LblQty
        ' 
        LblQty.AutoSize = True
        LblQty.Font = New Font("Segoe UI", 9F)
        LblQty.Location = New Point(109, 63)
        LblQty.Name = "LblQty"
        LblQty.Size = New Size(17, 20)
        LblQty.TabIndex = 4
        LblQty.Text = "1"
        ' 
        ' BtnPlus
        ' 
        BtnPlus.Cursor = Cursors.Hand
        BtnPlus.FlatAppearance.BorderSize = 0
        BtnPlus.FlatStyle = FlatStyle.Flat
        BtnPlus.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        BtnPlus.Location = New Point(131, 60)
        BtnPlus.Margin = New Padding(3, 4, 3, 4)
        BtnPlus.Name = "BtnPlus"
        BtnPlus.Size = New Size(23, 27)
        BtnPlus.TabIndex = 5
        BtnPlus.Text = "+"
        ' 
        ' BtnRemove
        ' 
        BtnRemove.Cursor = Cursors.Hand
        BtnRemove.FlatAppearance.BorderSize = 0
        BtnRemove.FlatStyle = FlatStyle.Flat
        BtnRemove.Font = New Font("Segoe UI", 8F)
        BtnRemove.ForeColor = Color.DarkGray
        BtnRemove.Location = New Point(328, 13)
        BtnRemove.Margin = New Padding(3, 4, 3, 4)
        BtnRemove.Name = "BtnRemove"
        BtnRemove.Size = New Size(23, 27)
        BtnRemove.TabIndex = 7
        BtnRemove.Text = "X"
        ' 
        ' CartItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(BtnRemove)
        Controls.Add(LblItemPrice)
        Controls.Add(BtnPlus)
        Controls.Add(LblQty)
        Controls.Add(BtnMinus)
        Controls.Add(LblItemDesc)
        Controls.Add(LblItemName)
        Controls.Add(PicItem)
        Margin = New Padding(0, 0, 0, 13)
        Name = "CartItem"
        Size = New Size(363, 100)
        CType(PicItem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PicItem As System.Windows.Forms.PictureBox
    Friend WithEvents LblItemName As System.Windows.Forms.Label
    Friend WithEvents LblItemDesc As System.Windows.Forms.Label
    Friend WithEvents LblItemPrice As System.Windows.Forms.Label
    Friend WithEvents BtnMinus As System.Windows.Forms.Button
    Friend WithEvents LblQty As System.Windows.Forms.Label
    Friend WithEvents BtnPlus As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
End Class