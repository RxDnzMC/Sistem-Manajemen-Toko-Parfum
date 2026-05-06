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
        CartItem1 = New CartItem()
        PanelOrderFooter = New Panel()
        OrderFooter1 = New OrderFooter()
        PanelGallery = New Panel()
        FlowLayoutPanelProducts = New FlowLayoutPanel()
        PanelHeaderGallery = New Panel()
        ProductCard1 = New ProductCard()
        LabelTitle = New Label()
        SidebarNavigation1 = New SidebarNavigation()
        PanelSidebar.SuspendLayout()
        PanelCurrentOrder.SuspendLayout()
        FlowLayoutPanelCartItems.SuspendLayout()
        PanelOrderFooter.SuspendLayout()
        PanelGallery.SuspendLayout()
        PanelHeaderGallery.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.White
        PanelSidebar.Controls.Add(SidebarNavigation1)
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
        FlowLayoutPanelCartItems.Controls.Add(CartItem1)
        FlowLayoutPanelCartItems.Dock = DockStyle.Fill
        FlowLayoutPanelCartItems.Location = New Point(0, 0)
        FlowLayoutPanelCartItems.Margin = New Padding(4, 5, 4, 5)
        FlowLayoutPanelCartItems.Name = "FlowLayoutPanelCartItems"
        FlowLayoutPanelCartItems.Size = New Size(475, 743)
        FlowLayoutPanelCartItems.TabIndex = 0
        ' 
        ' CartItem1
        ' 
        CartItem1.BackColor = Color.White
        CartItem1.Location = New Point(0, 0)
        CartItem1.Margin = New Padding(0, 0, 0, 17)
        CartItem1.Name = "CartItem1"
        CartItem1.Size = New Size(608, 156)
        CartItem1.TabIndex = 0
        ' 
        ' PanelOrderFooter
        ' 
        PanelOrderFooter.Controls.Add(OrderFooter1)
        PanelOrderFooter.Dock = DockStyle.Bottom
        PanelOrderFooter.Location = New Point(0, 743)
        PanelOrderFooter.Margin = New Padding(4, 5, 4, 5)
        PanelOrderFooter.Name = "PanelOrderFooter"
        PanelOrderFooter.Size = New Size(475, 312)
        PanelOrderFooter.TabIndex = 1
        ' 
        ' OrderFooter1
        ' 
        OrderFooter1.BackColor = Color.White
        OrderFooter1.Dock = DockStyle.Fill
        OrderFooter1.Location = New Point(0, 0)
        OrderFooter1.Margin = New Padding(4, 5, 4, 5)
        OrderFooter1.Name = "OrderFooter1"
        OrderFooter1.Size = New Size(475, 312)
        OrderFooter1.TabIndex = 0
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
        PanelHeaderGallery.Controls.Add(ProductCard1)
        PanelHeaderGallery.Dock = DockStyle.Top
        PanelHeaderGallery.Location = New Point(0, 0)
        PanelHeaderGallery.Margin = New Padding(4, 5, 4, 5)
        PanelHeaderGallery.Name = "PanelHeaderGallery"
        PanelHeaderGallery.Size = New Size(850, 1250)
        PanelHeaderGallery.TabIndex = 0
        ' 
        ' ProductCard1
        ' 
        ProductCard1.BackColor = Color.White
        ProductCard1.Location = New Point(0, 0)
        ProductCard1.Margin = New Padding(21, 25, 21, 25)
        ProductCard1.Name = "ProductCard1"
        ProductCard1.Size = New Size(464, 709)
        ProductCard1.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.Location = New Point(0, 0)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(100, 23)
        LabelTitle.TabIndex = 0
        ' 
        ' SidebarNavigation1
        ' 
        SidebarNavigation1.BackColor = Color.White
        SidebarNavigation1.Dock = DockStyle.Fill
        SidebarNavigation1.Location = New Point(0, 0)
        SidebarNavigation1.Margin = New Padding(4, 5, 4, 5)
        SidebarNavigation1.Name = "SidebarNavigation1"
        SidebarNavigation1.Size = New Size(275, 1055)
        SidebarNavigation1.TabIndex = 0
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
        PanelSidebar.ResumeLayout(False)
        PanelCurrentOrder.ResumeLayout(False)
        FlowLayoutPanelCartItems.ResumeLayout(False)
        PanelOrderFooter.ResumeLayout(False)
        PanelGallery.ResumeLayout(False)
        PanelHeaderGallery.ResumeLayout(False)
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
    Friend WithEvents CartItem1 As CartItem
    Friend WithEvents OrderFooter1 As OrderFooter
    Friend WithEvents ProductCard1 As ProductCard
    Friend WithEvents SidebarNavigation1 As SidebarNavigation
End Class