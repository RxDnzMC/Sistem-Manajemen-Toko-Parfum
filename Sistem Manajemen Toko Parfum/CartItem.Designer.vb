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
        Me.PicItem = New System.Windows.Forms.PictureBox()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.LblItemDesc = New System.Windows.Forms.Label()
        Me.LblItemPrice = New System.Windows.Forms.Label()
        Me.BtnMinus = New System.Windows.Forms.Button()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.BtnPlus = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicItem (Gambar Thumbail Kecil)
        '
        Me.PicItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PicItem.Location = New System.Drawing.Point(10, 10)
        Me.PicItem.Name = "PicItem"
        Me.PicItem.Size = New System.Drawing.Size(50, 50)
        Me.PicItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicItem.TabIndex = 0
        Me.PicItem.TabStop = False
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblItemName.Location = New System.Drawing.Point(70, 10)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(96, 15)
        Me.LblItemName.TabIndex = 1
        Me.LblItemName.Text = "Midnight Santal"
        '
        'LblItemDesc
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemDesc.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblItemDesc.ForeColor = System.Drawing.Color.Gray
        Me.LblItemDesc.Location = New System.Drawing.Point(70, 27)
        Me.LblItemDesc.Name = "LblItemDesc"
        Me.LblItemDesc.Size = New System.Drawing.Size(110, 12)
        Me.LblItemDesc.TabIndex = 2
        Me.LblItemDesc.Text = "100ml • EAU DE PARFUM"
        '
        'BtnMinus
        '
        Me.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinus.FlatAppearance.BorderSize = 0
        Me.BtnMinus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BtnMinus.Location = New System.Drawing.Point(70, 45)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(20, 20)
        Me.BtnMinus.TabIndex = 3
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'LblQty
        '
        Me.LblQty.AutoSize = True
        Me.LblQty.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblQty.Location = New System.Drawing.Point(95, 47)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(13, 15)
        Me.LblQty.TabIndex = 4
        Me.LblQty.Text = "1"
        '
        'BtnPlus
        '
        Me.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlus.FlatAppearance.BorderSize = 0
        Me.BtnPlus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPlus.Location = New System.Drawing.Point(115, 45)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(20, 20)
        Me.BtnPlus.TabIndex = 5
        Me.BtnPlus.Text = "+"
        Me.BtnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'LblItemPrice
        '
        Me.LblItemPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblItemPrice.Location = New System.Drawing.Point(240, 45)
        Me.LblItemPrice.Name = "LblItemPrice"
        Me.LblItemPrice.Size = New System.Drawing.Size(80, 20)
        Me.LblItemPrice.TabIndex = 6
        Me.LblItemPrice.Text = "$245.00"
        Me.LblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnRemove
        '
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.FlatAppearance.BorderSize = 0
        Me.BtnRemove.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular)
        Me.BtnRemove.ForeColor = System.Drawing.Color.DarkGray
        Me.BtnRemove.Location = New System.Drawing.Point(300, 10)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(20, 20)
        Me.BtnRemove.TabIndex = 7
        Me.BtnRemove.Text = "X"
        Me.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'CartItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.LblItemPrice)
        Me.Controls.Add(Me.BtnPlus)
        Me.Controls.Add(Me.LblQty)
        Me.Controls.Add(Me.BtnMinus)
        Me.Controls.Add(Me.LblItemDesc)
        Me.Controls.Add(Me.LblItemName)
        Me.Controls.Add(Me.PicItem)
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10) ' Margin bawah 10 agar ada jarak antar item
        Me.Name = "CartItem"
        Me.Size = New System.Drawing.Size(340, 75)
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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