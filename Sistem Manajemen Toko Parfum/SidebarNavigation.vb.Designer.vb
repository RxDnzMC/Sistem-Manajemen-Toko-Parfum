<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SidebarNavigation
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
        PanelLogo = New Panel()
        LblSubBrand = New Label()
        LblBrand = New Label()
        BtnDashboard = New Button()
        BtnInventory = New Button()
        BtnPOS = New Button()
        BtnAnalytics = New Button()
        BtnSettings = New Button()
        BtnLogout = New Button()
        PanelLogo.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(LblSubBrand)
        PanelLogo.Controls.Add(LblBrand)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Margin = New Padding(4, 5, 4, 5)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(314, 167)
        PanelLogo.TabIndex = 0
        ' 
        ' LblSubBrand
        ' 
        LblSubBrand.AutoSize = True
        LblSubBrand.Font = New Font("Segoe UI", 6.0F)
        LblSubBrand.ForeColor = Color.Gray
        LblSubBrand.Location = New Point(31, 83)
        LblSubBrand.Margin = New Padding(4, 0, 4, 0)
        LblSubBrand.Name = "LblSubBrand"
        LblSubBrand.Size = New Size(99, 12)
        LblSubBrand.TabIndex = 1
        LblSubBrand.Text = "MANAGEMENT SUITE"
        ' 
        ' LblBrand
        ' 
        LblBrand.AutoSize = True
        LblBrand.Font = New Font("Georgia", 11.0F, FontStyle.Bold)
        LblBrand.Location = New Point(29, 50)
        LblBrand.Margin = New Padding(4, 0, 4, 0)
        LblBrand.Name = "LblBrand"
        LblBrand.Size = New Size(175, 23)
        LblBrand.TabIndex = 0
        LblBrand.Text = "Aura Perfumerie"
        ' 
        ' BtnDashboard
        ' 
        BtnDashboard.Dock = DockStyle.Top
        BtnDashboard.FlatAppearance.BorderSize = 0
        BtnDashboard.FlatStyle = FlatStyle.Flat
        BtnDashboard.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnDashboard.ForeColor = Color.Gray
        BtnDashboard.Location = New Point(0, 167)
        BtnDashboard.Margin = New Padding(4, 5, 4, 5)
        BtnDashboard.Name = "BtnDashboard"
        BtnDashboard.Padding = New Padding(43, 0, 0, 0)
        BtnDashboard.Size = New Size(314, 75)
        BtnDashboard.TabIndex = 1
        BtnDashboard.Text = "  DASHBOARD"
        BtnDashboard.TextAlign = ContentAlignment.MiddleLeft
        BtnDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnInventory
        ' 
        BtnInventory.Dock = DockStyle.Top
        BtnInventory.FlatAppearance.BorderSize = 0
        BtnInventory.FlatStyle = FlatStyle.Flat
        BtnInventory.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnInventory.ForeColor = Color.Gray
        BtnInventory.Location = New Point(0, 242)
        BtnInventory.Margin = New Padding(4, 5, 4, 5)
        BtnInventory.Name = "BtnInventory"
        BtnInventory.Padding = New Padding(43, 0, 0, 0)
        BtnInventory.Size = New Size(314, 75)
        BtnInventory.TabIndex = 2
        BtnInventory.Text = "  INVENTORY"
        BtnInventory.TextAlign = ContentAlignment.MiddleLeft
        BtnInventory.UseVisualStyleBackColor = True
        ' 
        ' BtnPOS
        ' 
        BtnPOS.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        BtnPOS.Dock = DockStyle.Top
        BtnPOS.FlatAppearance.BorderSize = 0
        BtnPOS.FlatStyle = FlatStyle.Flat
        BtnPOS.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnPOS.ForeColor = Color.Black
        BtnPOS.Location = New Point(0, 317)
        BtnPOS.Margin = New Padding(4, 5, 4, 5)
        BtnPOS.Name = "BtnPOS"
        BtnPOS.Padding = New Padding(43, 0, 0, 0)
        BtnPOS.Size = New Size(314, 75)
        BtnPOS.TabIndex = 3
        BtnPOS.Text = "  POS SYSTEM"
        BtnPOS.TextAlign = ContentAlignment.MiddleLeft
        BtnPOS.UseVisualStyleBackColor = False
        ' 
        ' BtnAnalytics
        ' 
        BtnAnalytics.Dock = DockStyle.Top
        BtnAnalytics.FlatAppearance.BorderSize = 0
        BtnAnalytics.FlatStyle = FlatStyle.Flat
        BtnAnalytics.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnAnalytics.ForeColor = Color.Gray
        BtnAnalytics.Location = New Point(0, 392)
        BtnAnalytics.Margin = New Padding(4, 5, 4, 5)
        BtnAnalytics.Name = "BtnAnalytics"
        BtnAnalytics.Padding = New Padding(43, 0, 0, 0)
        BtnAnalytics.Size = New Size(314, 75)
        BtnAnalytics.TabIndex = 4
        BtnAnalytics.Text = "  ANALYTICS"
        BtnAnalytics.TextAlign = ContentAlignment.MiddleLeft
        BtnAnalytics.UseVisualStyleBackColor = True
        ' 
        ' BtnSettings
        ' 
        BtnSettings.Dock = DockStyle.Bottom
        BtnSettings.FlatAppearance.BorderSize = 0
        BtnSettings.FlatStyle = FlatStyle.Flat
        BtnSettings.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnSettings.ForeColor = Color.Gray
        BtnSettings.Location = New Point(0, 1183)
        BtnSettings.Margin = New Padding(4, 5, 4, 5)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Padding = New Padding(43, 0, 0, 0)
        BtnSettings.Size = New Size(314, 75)
        BtnSettings.TabIndex = 5
        BtnSettings.Text = "  SETTINGS"
        BtnSettings.TextAlign = ContentAlignment.MiddleLeft
        BtnSettings.UseVisualStyleBackColor = True
        ' 
        ' BtnLogout
        ' 
        BtnLogout.Dock = DockStyle.Bottom
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnLogout.ForeColor = Color.Gray
        BtnLogout.Location = New Point(0, 1258)
        BtnLogout.Margin = New Padding(4, 5, 4, 5)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Padding = New Padding(43, 0, 0, 0)
        BtnLogout.Size = New Size(314, 75)
        BtnLogout.TabIndex = 6
        BtnLogout.Text = "  LOGOUT"
        BtnLogout.TextAlign = ContentAlignment.MiddleLeft
        BtnLogout.UseVisualStyleBackColor = True
        ' 
        ' SidebarNavigation
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(BtnAnalytics)
        Controls.Add(BtnPOS)
        Controls.Add(BtnInventory)
        Controls.Add(BtnDashboard)
        Controls.Add(PanelLogo)
        Controls.Add(BtnSettings)
        Controls.Add(BtnLogout)
        Margin = New Padding(4, 5, 4, 5)
        Name = "SidebarNavigation"
        Size = New Size(314, 1333)
        PanelLogo.ResumeLayout(False)
        PanelLogo.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogo As System.Windows.Forms.Panel
    Friend WithEvents LblBrand As System.Windows.Forms.Label
    Friend WithEvents LblSubBrand As System.Windows.Forms.Label
    Friend WithEvents BtnDashboard As System.Windows.Forms.Button
    Friend WithEvents BtnInventory As System.Windows.Forms.Button
    Friend WithEvents BtnPOS As System.Windows.Forms.Button
    Friend WithEvents BtnAnalytics As System.Windows.Forms.Button
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
End Class