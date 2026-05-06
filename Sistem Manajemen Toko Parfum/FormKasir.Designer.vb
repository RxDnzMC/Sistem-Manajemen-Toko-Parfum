<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelSidebar = New Panel()
        PanelCurrentOrder = New Panel()
        FlowLayoutPanelCartItems = New FlowLayoutPanel()
        PanelOrderFooter = New Panel()
        PanelGallery = New Panel()
        FlowLayoutPanelProducts = New FlowLayoutPanel()
        PanelHeaderGallery = New Panel()
        LabelTitle = New Label()
        PanelCurrentOrder.SuspendLayout()
        PanelGallery.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.White
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Margin = New Padding(4, 5, 4, 5)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(275, 1055)
        PanelSidebar.TabIndex = 0
        ' 
        ' PanelCurrentOrder
        ' 
        PanelCurrentOrder.BackColor = Color.White
        PanelCurrentOrder.Controls.Add(FlowLayoutPanelCartItems)
        PanelCurrentOrder.Controls.Add(PanelOrderFooter)
        PanelCurrentOrder.Dock = DockStyle.Right
        PanelCurrentOrder.Location = New Point(1125, 0)
        PanelCurrentOrder.Margin = New Padding(4, 5, 4, 5)
        PanelCurrentOrder.Name = "PanelCurrentOrder"
        PanelCurrentOrder.Size = New Size(475, 1055)
        PanelCurrentOrder.TabIndex = 1
        ' 
        ' FlowLayoutPanelCartItems
        ' 
        FlowLayoutPanelCartItems.AutoScroll = True
        FlowLayoutPanelCartItems.Dock = DockStyle.Fill
        FlowLayoutPanelCartItems.Location = New Point(0, 0)
        FlowLayoutPanelCartItems.Margin = New Padding(4, 5, 4, 5)
        FlowLayoutPanelCartItems.Name = "FlowLayoutPanelCartItems"
        FlowLayoutPanelCartItems.Size = New Size(475, 743)
        FlowLayoutPanelCartItems.TabIndex = 0
        ' 
        ' PanelOrderFooter
        ' 
        PanelOrderFooter.Dock = DockStyle.Bottom
        PanelOrderFooter.Location = New Point(0, 743)
        PanelOrderFooter.Margin = New Padding(4, 5, 4, 5)
        PanelOrderFooter.Name = "PanelOrderFooter"
        PanelOrderFooter.Size = New Size(475, 312)
        PanelOrderFooter.TabIndex = 1
        ' 
        ' PanelGallery
        ' 
        PanelGallery.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        PanelGallery.Controls.Add(FlowLayoutPanelProducts)
        PanelGallery.Controls.Add(PanelHeaderGallery)
        PanelGallery.Dock = DockStyle.Fill
        PanelGallery.Location = New Point(275, 0)
        PanelGallery.Margin = New Padding(4, 5, 4, 5)
        PanelGallery.Name = "PanelGallery"
        PanelGallery.Size = New Size(850, 1055)
        PanelGallery.TabIndex = 2
        ' 
        ' FlowLayoutPanelProducts
        ' 
        FlowLayoutPanelProducts.AutoScroll = True
        FlowLayoutPanelProducts.Dock = DockStyle.Fill
        FlowLayoutPanelProducts.Location = New Point(0, 1250)
        FlowLayoutPanelProducts.Margin = New Padding(4, 5, 4, 5)
        FlowLayoutPanelProducts.Name = "FlowLayoutPanelProducts"
        FlowLayoutPanelProducts.Padding = New Padding(25, 31, 25, 31)
        FlowLayoutPanelProducts.Size = New Size(850, 0)
        FlowLayoutPanelProducts.TabIndex = 1
        ' 
        ' PanelHeaderGallery
        ' 
        PanelHeaderGallery.Dock = DockStyle.Top
        PanelHeaderGallery.Location = New Point(0, 0)
        PanelHeaderGallery.Margin = New Padding(4, 5, 4, 5)
        PanelHeaderGallery.Name = "PanelHeaderGallery"
        PanelHeaderGallery.Size = New Size(850, 1250)
        PanelHeaderGallery.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.Location = New Point(0, 0)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(100, 23)
        LabelTitle.TabIndex = 0
        ' 
        ' FormKasir
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1600, 1055)
        Controls.Add(PanelGallery)
        Controls.Add(PanelSidebar)
        Controls.Add(PanelCurrentOrder)
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormKasir"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aura Perfumerie - POS"
        WindowState = FormWindowState.Maximized
        PanelCurrentOrder.ResumeLayout(False)
        PanelGallery.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSidebar As System.Windows.Forms.Panel
    Friend WithEvents PanelCurrentOrder As System.Windows.Forms.Panel
    Friend WithEvents PanelGallery As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanelProducts As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PanelHeaderGallery As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanelCartItems As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PanelOrderFooter As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
End Class