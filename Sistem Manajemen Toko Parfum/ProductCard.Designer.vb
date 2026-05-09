<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PicImage = New System.Windows.Forms.PictureBox()
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.LblDesc = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicImage (Gambar Parfum)
        '
        Me.PicImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PicImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicImage.Location = New System.Drawing.Point(0, 0)
        Me.PicImage.Name = "PicImage"
        Me.PicImage.Size = New System.Drawing.Size(190, 190)
        Me.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImage.TabIndex = 0
        Me.PicImage.TabStop = False
        '
        'PanelInfo (Area Teks di Bawah Gambar)
        '
        Me.PanelInfo.BackColor = System.Drawing.Color.White
        Me.PanelInfo.Controls.Add(Me.LblPrice)
        Me.PanelInfo.Controls.Add(Me.LblCategory)
        Me.PanelInfo.Controls.Add(Me.LblDesc)
        Me.PanelInfo.Controls.Add(Me.LblName)
        Me.PanelInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInfo.Location = New System.Drawing.Point(0, 190)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New System.Drawing.Size(190, 80)
        Me.PanelInfo.TabIndex = 1
        '
        'LblPrice (Harga di Kanan Atas Panel)
        '
        Me.LblPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPrice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPrice.Location = New System.Drawing.Point(100, 10)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(80, 15)
        Me.LblPrice.TabIndex = 3
        Me.LblPrice.Text = "$245.00"
        Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblCategory (Kategori Kiri Atas)
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblCategory.ForeColor = System.Drawing.Color.Gray
        Me.LblCategory.Location = New System.Drawing.Point(10, 10)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(87, 12)
        Me.LblCategory.TabIndex = 2
        Me.LblCategory.Text = "EAU DE PARFUM"
        '
        'LblName (Nama Parfum)
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblName.Location = New System.Drawing.Point(8, 30)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(115, 19)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Midnight Santal"
        '
        'LblDesc (Deskripsi Volume & Notes)
        '
        Me.LblDesc.AutoSize = True
        Me.LblDesc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblDesc.ForeColor = System.Drawing.Color.DarkGray
        Me.LblDesc.Location = New System.Drawing.Point(10, 52)
        Me.LblDesc.Name = "LblDesc"
        Me.LblDesc.Size = New System.Drawing.Size(120, 13)
        Me.LblDesc.TabIndex = 1
        Me.LblDesc.Text = "100ml • Spicy Woody"
        '
        'ProductCard (Setingan Kartu Utama)
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PanelInfo)
        Me.Controls.Add(Me.PicImage)
        Me.Margin = New System.Windows.Forms.Padding(10) ' Memberi jarak antar kartu di FlowLayoutPanel
        Me.Name = "ProductCard"
        Me.Size = New System.Drawing.Size(190, 270)
        Me.Cursor = System.Windows.Forms.Cursors.Hand ' Mengubah kursor jadi tangan saat di-hover
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInfo.ResumeLayout(False)
        Me.PanelInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicImage As System.Windows.Forms.PictureBox
    Friend WithEvents PanelInfo As System.Windows.Forms.Panel
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents LblDesc As System.Windows.Forms.Label
End Class