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
        SidebarNavigation1 = New SidebarNavigation()
        PanelCurrentOrder = New Panel()
        FlowLayoutPanelCartItems = New FlowLayoutPanel()
        CartItem1 = New CartItem()
        PanelOrderFooter = New Panel()
        OrderFooter1 = New OrderFooter()
        PanelGallery = New Panel()
        FlowLayoutPanelProducts = New FlowLayoutPanel()
        ProductCard3 = New ProductCard()
        ProductCard1 = New ProductCard()
        ProductCard2 = New ProductCard()
        LabelTitle = New Label()
        PanelSidebar.SuspendLayout()
        PanelCurrentOrder.SuspendLayout()
        FlowLayoutPanelCartItems.SuspendLayout()
        PanelOrderFooter.SuspendLayout()
        PanelGallery.SuspendLayout()
        FlowLayoutPanelProducts.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.White
        PanelSidebar.Controls.Add(SidebarNavigation1)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Margin = New Padding(3, 4, 3, 4)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(220, 960)
        PanelSidebar.TabIndex = 0
        ' 
        ' SidebarNavigation1
        ' 
        SidebarNavigation1.BackColor = Color.White
        SidebarNavigation1.Dock = DockStyle.Fill
        SidebarNavigation1.Location = New Point(0, 0)
        SidebarNavigation1.Margin = New Padding(3, 4, 3, 4)
        SidebarNavigation1.Name = "SidebarNavigation1"
        SidebarNavigation1.Size = New Size(220, 960)
        SidebarNavigation1.TabIndex = 0
        ' 
        ' PanelCurrentOrder
        ' 
        PanelCurrentOrder.BackColor = Color.White
        PanelCurrentOrder.Controls.Add(FlowLayoutPanelCartItems)
        PanelCurrentOrder.Controls.Add(PanelOrderFooter)
        PanelCurrentOrder.Dock = DockStyle.Right
        PanelCurrentOrder.Location = New Point(917, 0)
        PanelCurrentOrder.Margin = New Padding(3, 4, 3, 4)
        PanelCurrentOrder.Name = "PanelCurrentOrder"
        PanelCurrentOrder.Size = New Size(363, 960)
        PanelCurrentOrder.TabIndex = 1
        ' 
        ' FlowLayoutPanelCartItems
        ' 
        FlowLayoutPanelCartItems.AutoScroll = True
        FlowLayoutPanelCartItems.Controls.Add(CartItem1)
        FlowLayoutPanelCartItems.Dock = DockStyle.Fill
        FlowLayoutPanelCartItems.Location = New Point(0, 0)
        FlowLayoutPanelCartItems.Margin = New Padding(3, 4, 3, 4)
        FlowLayoutPanelCartItems.Name = "FlowLayoutPanelCartItems"
        FlowLayoutPanelCartItems.Size = New Size(363, 664)
        FlowLayoutPanelCartItems.TabIndex = 1
        ' 
        ' CartItem1
        ' 
        CartItem1.BackColor = Color.White
        CartItem1.Location = New Point(0, 0)
        CartItem1.Margin = New Padding(0, 0, 0, 14)
        CartItem1.Name = "CartItem1"
        CartItem1.Size = New Size(363, 125)
        CartItem1.TabIndex = 0
        ' 
        ' PanelOrderFooter
        ' 
        PanelOrderFooter.Controls.Add(OrderFooter1)
        PanelOrderFooter.Dock = DockStyle.Bottom
        PanelOrderFooter.Location = New Point(0, 664)
        PanelOrderFooter.Margin = New Padding(3, 4, 3, 4)
        PanelOrderFooter.Name = "PanelOrderFooter"
        PanelOrderFooter.Size = New Size(363, 296)
        PanelOrderFooter.TabIndex = 1
        ' 
        ' OrderFooter1
        ' 
        OrderFooter1.BackColor = Color.White
        OrderFooter1.Dock = DockStyle.Fill
        OrderFooter1.Location = New Point(0, 0)
        OrderFooter1.Margin = New Padding(3, 4, 3, 4)
        OrderFooter1.Name = "OrderFooter1"
        OrderFooter1.Size = New Size(363, 296)
        OrderFooter1.TabIndex = 0
        ' 
        ' PanelGallery
        ' 
        PanelGallery.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        PanelGallery.Controls.Add(FlowLayoutPanelProducts)
        PanelGallery.Dock = DockStyle.Fill
        PanelGallery.Location = New Point(220, 0)
        PanelGallery.Margin = New Padding(3, 4, 3, 4)
        PanelGallery.Name = "PanelGallery"
        PanelGallery.Size = New Size(697, 960)
        PanelGallery.TabIndex = 2
        ' 
        ' FlowLayoutPanelProducts
        ' 
        FlowLayoutPanelProducts.AutoScroll = True
        FlowLayoutPanelProducts.Controls.Add(ProductCard3)
        FlowLayoutPanelProducts.Controls.Add(ProductCard1)
        FlowLayoutPanelProducts.Controls.Add(ProductCard2)
        FlowLayoutPanelProducts.Dock = DockStyle.Fill
        FlowLayoutPanelProducts.Location = New Point(0, 0)
        FlowLayoutPanelProducts.Margin = New Padding(3, 4, 3, 4)
        FlowLayoutPanelProducts.Name = "FlowLayoutPanelProducts"
        FlowLayoutPanelProducts.Padding = New Padding(13, 15, 10, 15)
        FlowLayoutPanelProducts.Size = New Size(697, 960)
        FlowLayoutPanelProducts.TabIndex = 1
        ' 
        ' ProductCard3
        ' 
        ProductCard3.BackColor = Color.White
        ProductCard3.Location = New Point(30, 35)
        ProductCard3.Margin = New Padding(17, 20, 17, 20)
        ProductCard3.Name = "ProductCard3"
        ProductCard3.Size = New Size(190, 360)
        ProductCard3.TabIndex = 6
        ' 
        ' ProductCard1
        ' 
        ProductCard1.BackColor = Color.White
        ProductCard1.Location = New Point(254, 35)
        ProductCard1.Margin = New Padding(17, 20, 17, 20)
        ProductCard1.Name = "ProductCard1"
        ProductCard1.Size = New Size(190, 360)
        ProductCard1.TabIndex = 5
        ' 
        ' ProductCard2
        ' 
        ProductCard2.BackColor = Color.White
        ProductCard2.Location = New Point(478, 35)
        ProductCard2.Margin = New Padding(17, 20, 17, 20)
        ProductCard2.Name = "ProductCard2"
        ProductCard2.Size = New Size(190, 360)
        ProductCard2.TabIndex = 4
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
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 960)
        Controls.Add(PanelGallery)
        Controls.Add(PanelSidebar)
        Controls.Add(PanelCurrentOrder)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormKasir"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aura Perfumerie - POS"
        WindowState = FormWindowState.Maximized
        PanelSidebar.ResumeLayout(False)
        PanelCurrentOrder.ResumeLayout(False)
        FlowLayoutPanelCartItems.ResumeLayout(False)
        PanelOrderFooter.ResumeLayout(False)
        PanelGallery.ResumeLayout(False)
        FlowLayoutPanelProducts.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSidebar As System.Windows.Forms.Panel
    Friend WithEvents PanelCurrentOrder As System.Windows.Forms.Panel
    Friend WithEvents PanelGallery As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanelProducts As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelCartItems As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PanelOrderFooter As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents CartItem1 As CartItem
    Friend WithEvents OrderFooter1 As OrderFooter
    Friend WithEvents SidebarNavigation1 As SidebarNavigation
    Friend WithEvents ProductCard3 As ProductCard
    Friend WithEvents ProductCard1 As ProductCard
    Friend WithEvents ProductCard2 As ProductCard
End Class