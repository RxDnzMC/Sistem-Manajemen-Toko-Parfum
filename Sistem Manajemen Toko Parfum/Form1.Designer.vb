<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pnlCard = New Panel()
        pnlLeft = New Panel()
        picPerfume = New PictureBox()
        lblBrandName = New Label()
        lblBrandTagline = New Label()
        pnlRight = New Panel()
        lblLEssence = New Label()
        lblSuite = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblSecurityKey = New Label()
        pnlPasswordWrap = New Panel()
        txtSecurityKey = New TextBox()
        btnEye = New Button()
        chkRemember = New CheckBox()
        lnkResetKey = New LinkLabel()
        btnAuthenticate = New Button()
        pnlDivider = New Panel()
        lblOrLeft = New Label()
        lnkGuest = New LinkLabel()
        lblOrRight = New Label()
        pnlSecurityNotice = New Panel()
        lblShieldIcon = New Label()
        lblSecurityText = New Label()
        btnClose = New Button()
        pnlCard.SuspendLayout()
        pnlLeft.SuspendLayout()
        CType(picPerfume, ComponentModel.ISupportInitialize).BeginInit()
        pnlRight.SuspendLayout()
        pnlPasswordWrap.SuspendLayout()
        pnlDivider.SuspendLayout()
        pnlSecurityNotice.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.White
        pnlCard.Controls.Add(pnlLeft)
        pnlCard.Controls.Add(pnlRight)
        pnlCard.Location = New Point(174, 192)
        pnlCard.Margin = New Padding(4, 5, 4, 5)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(934, 570)
        pnlCard.TabIndex = 0
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.FromArgb(CByte(42), CByte(36), CByte(30))
        pnlLeft.Controls.Add(picPerfume)
        pnlLeft.Controls.Add(lblBrandName)
        pnlLeft.Controls.Add(lblBrandTagline)
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Margin = New Padding(4, 5, 4, 5)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(374, 570)
        pnlLeft.TabIndex = 0
        ' 
        ' picPerfume
        ' 
        picPerfume.BackColor = Color.Transparent
        picPerfume.Location = New Point(0, 0)
        picPerfume.Margin = New Padding(4, 5, 4, 5)
        picPerfume.Name = "picPerfume"
        picPerfume.Size = New Size(374, 570)
        picPerfume.SizeMode = PictureBoxSizeMode.StretchImage
        picPerfume.TabIndex = 0
        picPerfume.TabStop = False
        ' 
        ' lblBrandName
        ' 
        lblBrandName.AutoSize = True
        lblBrandName.BackColor = Color.Transparent
        lblBrandName.Font = New Font("Georgia", 11F, FontStyle.Italic)
        lblBrandName.ForeColor = Color.FromArgb(CByte(240), CByte(230), CByte(210))
        lblBrandName.Location = New Point(24, 490)
        lblBrandName.Margin = New Padding(4, 0, 4, 0)
        lblBrandName.Name = "lblBrandName"
        lblBrandName.Size = New Size(165, 23)
        lblBrandName.TabIndex = 1
        lblBrandName.Text = "L'Art de L'Essence"
        ' 
        ' lblBrandTagline
        ' 
        lblBrandTagline.AutoSize = True
        lblBrandTagline.BackColor = Color.Transparent
        lblBrandTagline.Font = New Font("Segoe UI", 6F)
        lblBrandTagline.ForeColor = Color.FromArgb(CByte(180), CByte(165), CByte(140))
        lblBrandTagline.Location = New Point(24, 520)
        lblBrandTagline.Margin = New Padding(4, 0, 4, 0)
        lblBrandTagline.Name = "lblBrandTagline"
        lblBrandTagline.Size = New Size(206, 12)
        lblBrandTagline.TabIndex = 2
        lblBrandTagline.Text = "CURATING SENSORY EXCELLENCE SINCE 1974"
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.White
        pnlRight.Controls.Add(lblLEssence)
        pnlRight.Controls.Add(lblSuite)
        pnlRight.Controls.Add(lblUsername)
        pnlRight.Controls.Add(txtUsername)
        pnlRight.Controls.Add(lblSecurityKey)
        pnlRight.Controls.Add(pnlPasswordWrap)
        pnlRight.Controls.Add(chkRemember)
        pnlRight.Controls.Add(lnkResetKey)
        pnlRight.Controls.Add(btnAuthenticate)
        pnlRight.Controls.Add(pnlDivider)
        pnlRight.Controls.Add(pnlSecurityNotice)
        pnlRight.Location = New Point(374, 0)
        pnlRight.Margin = New Padding(4, 5, 4, 5)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(560, 570)
        pnlRight.TabIndex = 1
        ' 
        ' lblLEssence
        ' 
        lblLEssence.AutoSize = True
        lblLEssence.Font = New Font("Garamond", 15F, FontStyle.Bold)
        lblLEssence.ForeColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        lblLEssence.Location = New Point(42, 46)
        lblLEssence.Margin = New Padding(4, 0, 4, 0)
        lblLEssence.Name = "lblLEssence"
        lblLEssence.Size = New Size(154, 29)
        lblLEssence.TabIndex = 0
        lblLEssence.Text = "L'ESSENCE"
        ' 
        ' lblSuite
        ' 
        lblSuite.AutoSize = True
        lblSuite.Font = New Font("Segoe UI", 7F)
        lblSuite.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblSuite.Location = New Point(46, 83)
        lblSuite.Margin = New Padding(4, 0, 4, 0)
        lblSuite.Name = "lblSuite"
        lblSuite.Size = New Size(157, 15)
        lblSuite.TabIndex = 1
        lblSuite.Text = "SHOP MANAGEMENT SUITE"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblUsername.Location = New Point(42, 130)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(71, 15)
        lblUsername.TabIndex = 2
        lblUsername.Text = "USERNAME"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 9F)
        txtUsername.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtUsername.Location = New Point(42, 155)
        txtUsername.Margin = New Padding(4, 5, 4, 5)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(474, 40)
        txtUsername.TabIndex = 3
        ' 
        ' lblSecurityKey
        ' 
        lblSecurityKey.AutoSize = True
        lblSecurityKey.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblSecurityKey.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblSecurityKey.Location = New Point(42, 220)
        lblSecurityKey.Margin = New Padding(4, 0, 4, 0)
        lblSecurityKey.Name = "lblSecurityKey"
        lblSecurityKey.Size = New Size(86, 15)
        lblSecurityKey.TabIndex = 4
        lblSecurityKey.Text = "SECURITY KEY"
        ' 
        ' pnlPasswordWrap
        ' 
        pnlPasswordWrap.BackColor = Color.White
        pnlPasswordWrap.BorderStyle = BorderStyle.FixedSingle
        pnlPasswordWrap.Controls.Add(txtSecurityKey)
        pnlPasswordWrap.Controls.Add(btnEye)
        pnlPasswordWrap.Location = New Point(42, 245)
        pnlPasswordWrap.Margin = New Padding(4, 5, 4, 5)
        pnlPasswordWrap.Name = "pnlPasswordWrap"
        pnlPasswordWrap.Size = New Size(474, 42)
        pnlPasswordWrap.TabIndex = 5
        ' 
        ' txtSecurityKey
        ' 
        txtSecurityKey.BackColor = Color.White
        txtSecurityKey.BorderStyle = BorderStyle.None
        txtSecurityKey.Font = New Font("Segoe UI", 9F)
        txtSecurityKey.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtSecurityKey.Location = New Point(0, 0)
        txtSecurityKey.Margin = New Padding(4, 5, 4, 5)
        txtSecurityKey.Multiline = True
        txtSecurityKey.Name = "txtSecurityKey"
        txtSecurityKey.Size = New Size(426, 40)
        txtSecurityKey.TabIndex = 0
        ' 
        ' btnEye
        ' 
        btnEye.BackColor = Color.White
        btnEye.Cursor = Cursors.Hand
        btnEye.FlatAppearance.BorderSize = 0
        btnEye.FlatStyle = FlatStyle.Flat
        btnEye.Font = New Font("Segoe UI", 9F)
        btnEye.ForeColor = Color.FromArgb(CByte(150), CByte(140), CByte(130))
        btnEye.Location = New Point(430, 0)
        btnEye.Margin = New Padding(4, 5, 4, 5)
        btnEye.Name = "btnEye"
        btnEye.Size = New Size(40, 40)
        btnEye.TabIndex = 1
        btnEye.Text = "o"
        btnEye.UseVisualStyleBackColor = False
        ' 
        ' chkRemember
        ' 
        chkRemember.AutoSize = True
        chkRemember.Cursor = Cursors.Hand
        chkRemember.Font = New Font("Segoe UI", 8F)
        chkRemember.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        chkRemember.Location = New Point(42, 308)
        chkRemember.Margin = New Padding(4, 5, 4, 5)
        chkRemember.Name = "chkRemember"
        chkRemember.Size = New Size(145, 23)
        chkRemember.TabIndex = 6
        chkRemember.Text = "Remember session"
        ' 
        ' lnkResetKey
        ' 
        lnkResetKey.ActiveLinkColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        lnkResetKey.AutoSize = True
        lnkResetKey.Cursor = Cursors.Hand
        lnkResetKey.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lnkResetKey.LinkColor = Color.FromArgb(CByte(80), CByte(70), CByte(60))
        lnkResetKey.Location = New Point(410, 312)
        lnkResetKey.Margin = New Padding(4, 0, 4, 0)
        lnkResetKey.Name = "lnkResetKey"
        lnkResetKey.Size = New Size(65, 15)
        lnkResetKey.TabIndex = 7
        lnkResetKey.TabStop = True
        lnkResetKey.Text = "RESET KEY"
        lnkResetKey.VisitedLinkColor = Color.FromArgb(CByte(80), CByte(70), CByte(60))
        ' 
        ' btnAuthenticate
        ' 
        btnAuthenticate.BackColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        btnAuthenticate.Cursor = Cursors.Hand
        btnAuthenticate.FlatAppearance.BorderSize = 0
        btnAuthenticate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(44), CByte(38))
        btnAuthenticate.FlatStyle = FlatStyle.Flat
        btnAuthenticate.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        btnAuthenticate.ForeColor = Color.White
        btnAuthenticate.Location = New Point(42, 350)
        btnAuthenticate.Margin = New Padding(4, 5, 4, 5)
        btnAuthenticate.Name = "btnAuthenticate"
        btnAuthenticate.Size = New Size(474, 58)
        btnAuthenticate.TabIndex = 8
        btnAuthenticate.Text = "AUTHENTICATE ACCESS"
        btnAuthenticate.UseVisualStyleBackColor = False
        ' 
        ' pnlDivider
        ' 
        pnlDivider.BackColor = Color.Transparent
        pnlDivider.Controls.Add(lblOrLeft)
        pnlDivider.Controls.Add(lnkGuest)
        pnlDivider.Controls.Add(lblOrRight)
        pnlDivider.Location = New Point(42, 422)
        pnlDivider.Margin = New Padding(4, 5, 4, 5)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(474, 30)
        pnlDivider.TabIndex = 9
        ' 
        ' lblOrLeft
        ' 
        lblOrLeft.BackColor = Color.FromArgb(CByte(210), CByte(200), CByte(190))
        lblOrLeft.Location = New Point(0, 15)
        lblOrLeft.Margin = New Padding(4, 0, 4, 0)
        lblOrLeft.Name = "lblOrLeft"
        lblOrLeft.Size = New Size(194, 2)
        lblOrLeft.TabIndex = 0
        ' 
        ' lnkGuest
        ' 
        lnkGuest.ActiveLinkColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        lnkGuest.AutoSize = True
        lnkGuest.Cursor = Cursors.Hand
        lnkGuest.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lnkGuest.LinkColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        lnkGuest.Location = New Point(208, 5)
        lnkGuest.Margin = New Padding(4, 0, 4, 0)
        lnkGuest.Name = "lnkGuest"
        lnkGuest.Size = New Size(52, 19)
        lnkGuest.TabIndex = 1
        lnkGuest.TabStop = True
        lnkGuest.Text = "GUEST"
        lnkGuest.VisitedLinkColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        ' 
        ' lblOrRight
        ' 
        lblOrRight.BackColor = Color.FromArgb(CByte(210), CByte(200), CByte(190))
        lblOrRight.Location = New Point(282, 15)
        lblOrRight.Margin = New Padding(4, 0, 4, 0)
        lblOrRight.Name = "lblOrRight"
        lblOrRight.Size = New Size(192, 2)
        lblOrRight.TabIndex = 2
        ' 
        ' pnlSecurityNotice
        ' 
        pnlSecurityNotice.BackColor = Color.Transparent
        pnlSecurityNotice.Controls.Add(lblShieldIcon)
        pnlSecurityNotice.Controls.Add(lblSecurityText)
        pnlSecurityNotice.Location = New Point(42, 465)
        pnlSecurityNotice.Margin = New Padding(4, 5, 4, 5)
        pnlSecurityNotice.Name = "pnlSecurityNotice"
        pnlSecurityNotice.Size = New Size(474, 70)
        pnlSecurityNotice.TabIndex = 10
        ' 
        ' lblShieldIcon
        ' 
        lblShieldIcon.AutoSize = True
        lblShieldIcon.Font = New Font("Segoe UI", 11F)
        lblShieldIcon.ForeColor = Color.FromArgb(CByte(160), CByte(145), CByte(125))
        lblShieldIcon.Location = New Point(0, 10)
        lblShieldIcon.Margin = New Padding(4, 0, 4, 0)
        lblShieldIcon.Name = "lblShieldIcon"
        lblShieldIcon.Size = New Size(26, 25)
        lblShieldIcon.TabIndex = 0
        lblShieldIcon.Text = "O"
        ' 
        ' lblSecurityText
        ' 
        lblSecurityText.Font = New Font("Segoe UI", 7.5F)
        lblSecurityText.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblSecurityText.Location = New Point(34, 6)
        lblSecurityText.Margin = New Padding(4, 0, 4, 0)
        lblSecurityText.Name = "lblSecurityText"
        lblSecurityText.Size = New Size(430, 55)
        lblSecurityText.TabIndex = 1
        lblSecurityText.Text = "This environment is restricted to authorized curators." & vbCrLf & "All access attempts are recorded for internal audit."
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(237), CByte(232), CByte(224))
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(210), CByte(200))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClose.ForeColor = Color.FromArgb(CByte(90), CByte(80), CByte(70))
        btnClose.Location = New Point(1226, 12)
        btnClose.Margin = New Padding(4, 5, 4, 5)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(42, 50)
        btnClose.TabIndex = 99
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(232), CByte(224))
        ClientSize = New Size(1280, 882)
        Controls.Add(pnlCard)
        Controls.Add(btnClose)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "L'Essence - Shop Management Suite"
        pnlCard.ResumeLayout(False)
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        CType(picPerfume, ComponentModel.ISupportInitialize).EndInit()
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        pnlPasswordWrap.ResumeLayout(False)
        pnlPasswordWrap.PerformLayout()
        pnlDivider.ResumeLayout(False)
        pnlDivider.PerformLayout()
        pnlSecurityNotice.ResumeLayout(False)
        pnlSecurityNotice.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents picPerfume As System.Windows.Forms.PictureBox
    Friend WithEvents lblBrandName As System.Windows.Forms.Label
    Friend WithEvents lblBrandTagline As System.Windows.Forms.Label
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblLEssence As System.Windows.Forms.Label
    Friend WithEvents lblSuite As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblSecurityKey As System.Windows.Forms.Label
    Friend WithEvents pnlPasswordWrap As System.Windows.Forms.Panel
    Friend WithEvents txtSecurityKey As System.Windows.Forms.TextBox
    Friend WithEvents btnEye As System.Windows.Forms.Button
    Friend WithEvents chkRemember As System.Windows.Forms.CheckBox
    Friend WithEvents lnkResetKey As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAuthenticate As System.Windows.Forms.Button
    Friend WithEvents pnlDivider As System.Windows.Forms.Panel
    Friend WithEvents lblOrLeft As System.Windows.Forms.Label
    Friend WithEvents lnkGuest As System.Windows.Forms.LinkLabel
    Friend WithEvents lblOrRight As System.Windows.Forms.Label
    Friend WithEvents pnlSecurityNotice As System.Windows.Forms.Panel
    Friend WithEvents lblShieldIcon As System.Windows.Forms.Label
    Friend WithEvents lblSecurityText As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class