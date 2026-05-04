<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventory
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlSidebar = New Panel()
        lblAura = New Label()
        lblPerfumerie = New Label()
        lblManageSub = New Label()
        pnlSideDiv = New Panel()
        btnNavDashboard = New Button()
        btnNavInventory = New Button()
        btnNavFragrances = New Button()
        btnNavAnalytics = New Button()
        btnNavSettings = New Button()
        btnNavLogout = New Button()
        pnlUserBadge = New Panel()
        lblUserInitials = New Label()
        lblUserName = New Label()
        lblUserRole = New Label()
        pnlContent = New Panel()
        pnlTopBar = New Panel()
        lblStockMgmt = New Label()
        lblCollectionTitle = New Label()
        txtSearch = New TextBox()
        btnAddNew = New Button()
        btnCloseForm = New Button()
        pnlStats = New Panel()
        pnlStatRevenue = New Panel()
        lblRevTitle = New Label()
        lblRevValue = New Label()
        lblRevChange = New Label()
        pnlStatSlots = New Panel()
        lblSlotsTitle = New Label()
        lblSlotsValue = New Label()
        lblSlotsAction = New Label()
        pnlStatEntries = New Panel()
        lblEntrTitle = New Label()
        lblEntrValue = New Label()
        lblEntrLabel = New Label()
        dgvInventory = New DataGridView()
        pnlPagination = New Panel()
        lblShowingText = New Label()
        btnPrevPage = New Button()
        btnNextPage = New Button()
        pnlDrawer = New Panel()
        pnlDrawerTop = New Panel()
        lblDrawerTitle = New Label()
        btnCloseDrawer = New Button()
        pnlDrawerScroll = New Panel()
        lblSecIdentity = New Label()
        lblFragName = New Label()
        txtFragranceName = New TextBox()
        lblOriginBrand = New Label()
        txtOriginBrand = New TextBox()
        lblConcentration = New Label()
        cboConcentration = New ComboBox()
        lblSecInventory = New Label()
        lblRetailPrice = New Label()
        txtRetailPrice = New TextBox()
        lblCurrentStock = New Label()
        txtCurrentStock = New TextBox()
        lblSecOlfactory = New Label()
        lblTopNotes = New Label()
        txtTopNotes = New TextBox()
        lblHeartNotes = New Label()
        txtHeartNotes = New TextBox()
        lblBaseNotes = New Label()
        txtBaseNotes = New TextBox()
        lblSecPhoto = New Label()
        pnlPhotoUpload = New Panel()
        lblPhotoIcon = New Label()
        lblPhotoHint = New Label()
        pnlDrawerBottom = New Panel()
        btnSaveFragrance = New Button()
        btnCancelDrawer = New Button()
        pnlSidebar.SuspendLayout()
        pnlUserBadge.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlTopBar.SuspendLayout()
        pnlStats.SuspendLayout()
        pnlStatRevenue.SuspendLayout()
        pnlStatSlots.SuspendLayout()
        pnlStatEntries.SuspendLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        pnlPagination.SuspendLayout()
        pnlDrawer.SuspendLayout()
        pnlDrawerTop.SuspendLayout()
        pnlDrawerScroll.SuspendLayout()
        pnlPhotoUpload.SuspendLayout()
        pnlDrawerBottom.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(22), CByte(18), CByte(14))
        pnlSidebar.Controls.Add(lblAura)
        pnlSidebar.Controls.Add(lblPerfumerie)
        pnlSidebar.Controls.Add(lblManageSub)
        pnlSidebar.Controls.Add(pnlSideDiv)
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Controls.Add(btnNavInventory)
        pnlSidebar.Controls.Add(btnNavFragrances)
        pnlSidebar.Controls.Add(btnNavAnalytics)
        pnlSidebar.Controls.Add(btnNavSettings)
        pnlSidebar.Controls.Add(btnNavLogout)
        pnlSidebar.Controls.Add(pnlUserBadge)
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(110, 840)
        pnlSidebar.TabIndex = 0
        ' 
        ' lblAura
        ' 
        lblAura.AutoSize = True
        lblAura.Font = New Font("Garamond", 14F, FontStyle.Bold)
        lblAura.ForeColor = Color.FromArgb(CByte(240), CByte(230), CByte(210))
        lblAura.Location = New Point(14, 20)
        lblAura.Name = "lblAura"
        lblAura.Size = New Size(79, 27)
        lblAura.TabIndex = 0
        lblAura.Text = "AURA"
        ' 
        ' lblPerfumerie
        ' 
        lblPerfumerie.AutoSize = True
        lblPerfumerie.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblPerfumerie.ForeColor = Color.FromArgb(CByte(180), CByte(165), CByte(140))
        lblPerfumerie.Location = New Point(14, 38)
        lblPerfumerie.Name = "lblPerfumerie"
        lblPerfumerie.Size = New Size(78, 15)
        lblPerfumerie.TabIndex = 1
        lblPerfumerie.Text = "PERFUMERIE"
        ' 
        ' lblManageSub
        ' 
        lblManageSub.AutoSize = True
        lblManageSub.Font = New Font("Segoe UI", 6.5F)
        lblManageSub.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblManageSub.Location = New Point(14, 54)
        lblManageSub.Name = "lblManageSub"
        lblManageSub.Size = New Size(91, 13)
        lblManageSub.TabIndex = 2
        lblManageSub.Text = "Management Kit"
        ' 
        ' pnlSideDiv
        ' 
        pnlSideDiv.BackColor = Color.FromArgb(CByte(45), CByte(40), CByte(35))
        pnlSideDiv.Location = New Point(14, 74)
        pnlSideDiv.Name = "pnlSideDiv"
        pnlSideDiv.Size = New Size(82, 1)
        pnlSideDiv.TabIndex = 3
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.BackColor = Color.Transparent
        btnNavDashboard.Cursor = Cursors.Hand
        btnNavDashboard.FlatAppearance.BorderSize = 0
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI", 9F)
        btnNavDashboard.ForeColor = Color.FromArgb(CByte(150), CByte(140), CByte(130))
        btnNavDashboard.Location = New Point(0, 90)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Padding = New Padding(12, 0, 0, 0)
        btnNavDashboard.Size = New Size(110, 38)
        btnNavDashboard.TabIndex = 4
        btnNavDashboard.Text = "Dashboard"
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnNavInventory
        ' 
        btnNavInventory.BackColor = Color.FromArgb(CByte(45), CByte(40), CByte(35))
        btnNavInventory.Cursor = Cursors.Hand
        btnNavInventory.FlatAppearance.BorderSize = 0
        btnNavInventory.FlatStyle = FlatStyle.Flat
        btnNavInventory.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNavInventory.ForeColor = Color.White
        btnNavInventory.Location = New Point(0, 130)
        btnNavInventory.Name = "btnNavInventory"
        btnNavInventory.Padding = New Padding(12, 0, 0, 0)
        btnNavInventory.Size = New Size(110, 38)
        btnNavInventory.TabIndex = 5
        btnNavInventory.Text = "Inventory"
        btnNavInventory.TextAlign = ContentAlignment.MiddleLeft
        btnNavInventory.UseVisualStyleBackColor = False
        ' 
        ' btnNavFragrances
        ' 
        btnNavFragrances.BackColor = Color.Transparent
        btnNavFragrances.Cursor = Cursors.Hand
        btnNavFragrances.FlatAppearance.BorderSize = 0
        btnNavFragrances.FlatStyle = FlatStyle.Flat
        btnNavFragrances.Font = New Font("Segoe UI", 9F)
        btnNavFragrances.ForeColor = Color.FromArgb(CByte(150), CByte(140), CByte(130))
        btnNavFragrances.Location = New Point(0, 170)
        btnNavFragrances.Name = "btnNavFragrances"
        btnNavFragrances.Padding = New Padding(12, 0, 0, 0)
        btnNavFragrances.Size = New Size(110, 38)
        btnNavFragrances.TabIndex = 6
        btnNavFragrances.Text = "Fragrances"
        btnNavFragrances.TextAlign = ContentAlignment.MiddleLeft
        btnNavFragrances.UseVisualStyleBackColor = False
        ' 
        ' btnNavAnalytics
        ' 
        btnNavAnalytics.BackColor = Color.Transparent
        btnNavAnalytics.Cursor = Cursors.Hand
        btnNavAnalytics.FlatAppearance.BorderSize = 0
        btnNavAnalytics.FlatStyle = FlatStyle.Flat
        btnNavAnalytics.Font = New Font("Segoe UI", 9F)
        btnNavAnalytics.ForeColor = Color.FromArgb(CByte(150), CByte(140), CByte(130))
        btnNavAnalytics.Location = New Point(0, 210)
        btnNavAnalytics.Name = "btnNavAnalytics"
        btnNavAnalytics.Padding = New Padding(12, 0, 0, 0)
        btnNavAnalytics.Size = New Size(110, 38)
        btnNavAnalytics.TabIndex = 7
        btnNavAnalytics.Text = "Analytics"
        btnNavAnalytics.TextAlign = ContentAlignment.MiddleLeft
        btnNavAnalytics.UseVisualStyleBackColor = False
        ' 
        ' btnNavSettings
        ' 
        btnNavSettings.BackColor = Color.Transparent
        btnNavSettings.Cursor = Cursors.Hand
        btnNavSettings.FlatAppearance.BorderSize = 0
        btnNavSettings.FlatStyle = FlatStyle.Flat
        btnNavSettings.Font = New Font("Segoe UI", 8.5F)
        btnNavSettings.ForeColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        btnNavSettings.Location = New Point(0, 740)
        btnNavSettings.Name = "btnNavSettings"
        btnNavSettings.Padding = New Padding(12, 0, 0, 0)
        btnNavSettings.Size = New Size(110, 38)
        btnNavSettings.TabIndex = 8
        btnNavSettings.Text = "Settings"
        btnNavSettings.TextAlign = ContentAlignment.MiddleLeft
        btnNavSettings.UseVisualStyleBackColor = False
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.BackColor = Color.Transparent
        btnNavLogout.Cursor = Cursors.Hand
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 8.5F)
        btnNavLogout.ForeColor = Color.FromArgb(CByte(180), CByte(80), CByte(80))
        btnNavLogout.Location = New Point(0, 778)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Padding = New Padding(12, 0, 0, 0)
        btnNavLogout.Size = New Size(110, 38)
        btnNavLogout.TabIndex = 9
        btnNavLogout.Text = "Logout"
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlUserBadge
        ' 
        pnlUserBadge.BackColor = Color.FromArgb(CByte(32), CByte(28), CByte(22))
        pnlUserBadge.Controls.Add(lblUserInitials)
        pnlUserBadge.Controls.Add(lblUserName)
        pnlUserBadge.Controls.Add(lblUserRole)
        pnlUserBadge.Location = New Point(0, 816)
        pnlUserBadge.Name = "pnlUserBadge"
        pnlUserBadge.Size = New Size(110, 24)
        pnlUserBadge.TabIndex = 10
        ' 
        ' lblUserInitials
        ' 
        lblUserInitials.AutoSize = True
        lblUserInitials.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblUserInitials.ForeColor = Color.FromArgb(CByte(220), CByte(210), CByte(195))
        lblUserInitials.Location = New Point(8, 5)
        lblUserInitials.Name = "lblUserInitials"
        lblUserInitials.Size = New Size(22, 15)
        lblUserInitials.TabIndex = 0
        lblUserInitials.Text = "AP"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 7.5F)
        lblUserName.ForeColor = Color.FromArgb(CByte(200), CByte(190), CByte(175))
        lblUserName.Location = New Point(28, 4)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(77, 17)
        lblUserName.TabIndex = 1
        lblUserName.Text = "A. Perfumist"
        ' 
        ' lblUserRole
        ' 
        lblUserRole.AutoSize = True
        lblUserRole.Font = New Font("Segoe UI", 6F)
        lblUserRole.ForeColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        lblUserRole.Location = New Point(28, 14)
        lblUserRole.Name = "lblUserRole"
        lblUserRole.Size = New Size(37, 12)
        lblUserRole.TabIndex = 2
        lblUserRole.Text = "Curator"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(243), CByte(240))
        pnlContent.Controls.Add(pnlTopBar)
        pnlContent.Controls.Add(pnlStats)
        pnlContent.Controls.Add(dgvInventory)
        pnlContent.Controls.Add(pnlPagination)
        pnlContent.Location = New Point(110, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(990, 840)
        pnlContent.TabIndex = 1
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.BackColor = Color.FromArgb(CByte(245), CByte(243), CByte(240))
        pnlTopBar.Controls.Add(lblStockMgmt)
        pnlTopBar.Controls.Add(lblCollectionTitle)
        pnlTopBar.Controls.Add(txtSearch)
        pnlTopBar.Controls.Add(btnAddNew)
        pnlTopBar.Controls.Add(btnCloseForm)
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(990, 75)
        pnlTopBar.TabIndex = 0
        ' 
        ' lblStockMgmt
        ' 
        lblStockMgmt.AutoSize = True
        lblStockMgmt.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblStockMgmt.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblStockMgmt.Location = New Point(24, 14)
        lblStockMgmt.Name = "lblStockMgmt"
        lblStockMgmt.Size = New Size(132, 15)
        lblStockMgmt.TabIndex = 0
        lblStockMgmt.Text = "STOCK MANAGEMENT"
        ' 
        ' lblCollectionTitle
        ' 
        lblCollectionTitle.AutoSize = True
        lblCollectionTitle.Font = New Font("Garamond", 18F, FontStyle.Bold)
        lblCollectionTitle.ForeColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        lblCollectionTitle.Location = New Point(22, 28)
        lblCollectionTitle.Name = "lblCollectionTitle"
        lblCollectionTitle.Size = New Size(280, 34)
        lblCollectionTitle.TabIndex = 1
        lblCollectionTitle.Text = "Fragrance Collection"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9F)
        txtSearch.ForeColor = Color.FromArgb(CByte(80), CByte(70), CByte(60))
        txtSearch.Location = New Point(580, 26)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(180, 27)
        txtSearch.TabIndex = 2
        ' 
        ' btnAddNew
        ' 
        btnAddNew.BackColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        btnAddNew.Cursor = Cursors.Hand
        btnAddNew.FlatAppearance.BorderSize = 0
        btnAddNew.FlatStyle = FlatStyle.Flat
        btnAddNew.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        btnAddNew.ForeColor = Color.White
        btnAddNew.Location = New Point(776, 22)
        btnAddNew.Name = "btnAddNew"
        btnAddNew.Size = New Size(180, 32)
        btnAddNew.TabIndex = 3
        btnAddNew.Text = "+ TAMBAH PARFUM"
        btnAddNew.UseVisualStyleBackColor = False
        ' 
        ' btnCloseForm
        ' 
        btnCloseForm.BackColor = Color.Transparent
        btnCloseForm.Cursor = Cursors.Hand
        btnCloseForm.FlatAppearance.BorderSize = 0
        btnCloseForm.FlatStyle = FlatStyle.Flat
        btnCloseForm.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCloseForm.ForeColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        btnCloseForm.Location = New Point(960, 8)
        btnCloseForm.Name = "btnCloseForm"
        btnCloseForm.Size = New Size(24, 24)
        btnCloseForm.TabIndex = 4
        btnCloseForm.Text = "X"
        btnCloseForm.UseVisualStyleBackColor = False
        ' 
        ' pnlStats
        ' 
        pnlStats.BackColor = Color.FromArgb(CByte(245), CByte(243), CByte(240))
        pnlStats.Controls.Add(pnlStatRevenue)
        pnlStats.Controls.Add(pnlStatSlots)
        pnlStats.Controls.Add(pnlStatEntries)
        pnlStats.Location = New Point(0, 75)
        pnlStats.Name = "pnlStats"
        pnlStats.Size = New Size(990, 95)
        pnlStats.TabIndex = 1
        ' 
        ' pnlStatRevenue
        ' 
        pnlStatRevenue.BackColor = Color.White
        pnlStatRevenue.Controls.Add(lblRevTitle)
        pnlStatRevenue.Controls.Add(lblRevValue)
        pnlStatRevenue.Controls.Add(lblRevChange)
        pnlStatRevenue.Location = New Point(24, 10)
        pnlStatRevenue.Name = "pnlStatRevenue"
        pnlStatRevenue.Size = New Size(296, 75)
        pnlStatRevenue.TabIndex = 0
        ' 
        ' lblRevTitle
        ' 
        lblRevTitle.AutoSize = True
        lblRevTitle.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblRevTitle.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblRevTitle.Location = New Point(14, 12)
        lblRevTitle.Name = "lblRevTitle"
        lblRevTitle.Size = New Size(144, 15)
        lblRevTitle.TabIndex = 0
        lblRevTitle.Text = "TOTAL NILAI INVENTORI"
        ' 
        ' lblRevValue
        ' 
        lblRevValue.AutoSize = True
        lblRevValue.Font = New Font("Garamond", 20F, FontStyle.Bold)
        lblRevValue.ForeColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        lblRevValue.Location = New Point(12, 28)
        lblRevValue.Name = "lblRevValue"
        lblRevValue.Size = New Size(85, 38)
        lblRevValue.TabIndex = 1
        lblRevValue.Text = "Rp 0"
        ' 
        ' lblRevChange
        ' 
        lblRevChange.AutoSize = True
        lblRevChange.Font = New Font("Segoe UI", 8F)
        lblRevChange.ForeColor = Color.FromArgb(CByte(130), CByte(120), CByte(110))
        lblRevChange.Location = New Point(14, 56)
        lblRevChange.Name = "lblRevChange"
        lblRevChange.Size = New Size(91, 19)
        lblRevChange.TabIndex = 2
        lblRevChange.Text = "dari database"
        ' 
        ' pnlStatSlots
        ' 
        pnlStatSlots.BackColor = Color.White
        pnlStatSlots.Controls.Add(lblSlotsTitle)
        pnlStatSlots.Controls.Add(lblSlotsValue)
        pnlStatSlots.Controls.Add(lblSlotsAction)
        pnlStatSlots.Location = New Point(336, 10)
        pnlStatSlots.Name = "pnlStatSlots"
        pnlStatSlots.Size = New Size(296, 75)
        pnlStatSlots.TabIndex = 1
        ' 
        ' lblSlotsTitle
        ' 
        lblSlotsTitle.AutoSize = True
        lblSlotsTitle.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblSlotsTitle.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblSlotsTitle.Location = New Point(14, 12)
        lblSlotsTitle.Name = "lblSlotsTitle"
        lblSlotsTitle.Size = New Size(89, 15)
        lblSlotsTitle.TabIndex = 0
        lblSlotsTitle.Text = "STOK MENIPIS"
        ' 
        ' lblSlotsValue
        ' 
        lblSlotsValue.AutoSize = True
        lblSlotsValue.Font = New Font("Garamond", 22F, FontStyle.Bold)
        lblSlotsValue.ForeColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        lblSlotsValue.Location = New Point(12, 28)
        lblSlotsValue.Name = "lblSlotsValue"
        lblSlotsValue.Size = New Size(52, 42)
        lblSlotsValue.TabIndex = 1
        lblSlotsValue.Text = "00"
        ' 
        ' lblSlotsAction
        ' 
        lblSlotsAction.AutoSize = True
        lblSlotsAction.Font = New Font("Segoe UI", 8F)
        lblSlotsAction.ForeColor = Color.FromArgb(CByte(50), CByte(150), CByte(80))
        lblSlotsAction.Location = New Point(52, 40)
        lblSlotsAction.Name = "lblSlotsAction"
        lblSlotsAction.Size = New Size(76, 19)
        lblSlotsAction.TabIndex = 2
        lblSlotsAction.Text = "Stok Aman"
        ' 
        ' pnlStatEntries
        ' 
        pnlStatEntries.BackColor = Color.White
        pnlStatEntries.Controls.Add(lblEntrTitle)
        pnlStatEntries.Controls.Add(lblEntrValue)
        pnlStatEntries.Controls.Add(lblEntrLabel)
        pnlStatEntries.Location = New Point(648, 10)
        pnlStatEntries.Name = "pnlStatEntries"
        pnlStatEntries.Size = New Size(296, 75)
        pnlStatEntries.TabIndex = 2
        ' 
        ' lblEntrTitle
        ' 
        lblEntrTitle.AutoSize = True
        lblEntrTitle.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblEntrTitle.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblEntrTitle.Location = New Point(14, 12)
        lblEntrTitle.Name = "lblEntrTitle"
        lblEntrTitle.Size = New Size(74, 15)
        lblEntrTitle.TabIndex = 0
        lblEntrTitle.Text = "TOTAL ITEM"
        ' 
        ' lblEntrValue
        ' 
        lblEntrValue.AutoSize = True
        lblEntrValue.Font = New Font("Garamond", 22F, FontStyle.Bold)
        lblEntrValue.ForeColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        lblEntrValue.Location = New Point(12, 28)
        lblEntrValue.Name = "lblEntrValue"
        lblEntrValue.Size = New Size(52, 42)
        lblEntrValue.TabIndex = 1
        lblEntrValue.Text = "00"
        ' 
        ' lblEntrLabel
        ' 
        lblEntrLabel.AutoSize = True
        lblEntrLabel.Font = New Font("Segoe UI", 8F)
        lblEntrLabel.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblEntrLabel.Location = New Point(50, 40)
        lblEntrLabel.Name = "lblEntrLabel"
        lblEntrLabel.Size = New Size(111, 19)
        lblEntrLabel.TabIndex = 2
        lblEntrLabel.Text = "Parfum Terdaftar"
        ' 
        ' dgvInventory
        ' 
        dgvInventory.BackgroundColor = Color.White
        dgvInventory.BorderStyle = BorderStyle.None
        dgvInventory.ColumnHeadersHeight = 29
        dgvInventory.Location = New Point(24, 178)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowHeadersWidth = 51
        dgvInventory.ScrollBars = ScrollBars.Vertical
        dgvInventory.Size = New Size(942, 560)
        dgvInventory.TabIndex = 2
        ' 
        ' pnlPagination
        ' 
        pnlPagination.BackColor = Color.FromArgb(CByte(245), CByte(243), CByte(240))
        pnlPagination.Controls.Add(lblShowingText)
        pnlPagination.Controls.Add(btnPrevPage)
        pnlPagination.Controls.Add(btnNextPage)
        pnlPagination.Location = New Point(24, 748)
        pnlPagination.Name = "pnlPagination"
        pnlPagination.Size = New Size(942, 40)
        pnlPagination.TabIndex = 3
        ' 
        ' lblShowingText
        ' 
        lblShowingText.AutoSize = True
        lblShowingText.Font = New Font("Segoe UI", 8.5F)
        lblShowingText.ForeColor = Color.FromArgb(CByte(130), CByte(120), CByte(110))
        lblShowingText.Location = New Point(0, 10)
        lblShowingText.Name = "lblShowingText"
        lblShowingText.Size = New Size(107, 20)
        lblShowingText.TabIndex = 0
        lblShowingText.Text = "Memuat data..."
        ' 
        ' btnPrevPage
        ' 
        btnPrevPage.BackColor = Color.White
        btnPrevPage.Cursor = Cursors.Hand
        btnPrevPage.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(215), CByte(210))
        btnPrevPage.FlatStyle = FlatStyle.Flat
        btnPrevPage.ForeColor = Color.FromArgb(CByte(80), CByte(70), CByte(60))
        btnPrevPage.Location = New Point(856, 6)
        btnPrevPage.Name = "btnPrevPage"
        btnPrevPage.Size = New Size(32, 28)
        btnPrevPage.TabIndex = 1
        btnPrevPage.Text = "<"
        btnPrevPage.UseVisualStyleBackColor = False
        ' 
        ' btnNextPage
        ' 
        btnNextPage.BackColor = Color.White
        btnNextPage.Cursor = Cursors.Hand
        btnNextPage.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(215), CByte(210))
        btnNextPage.FlatStyle = FlatStyle.Flat
        btnNextPage.ForeColor = Color.FromArgb(CByte(80), CByte(70), CByte(60))
        btnNextPage.Location = New Point(892, 6)
        btnNextPage.Name = "btnNextPage"
        btnNextPage.Size = New Size(32, 28)
        btnNextPage.TabIndex = 2
        btnNextPage.Text = ">"
        btnNextPage.UseVisualStyleBackColor = False
        ' 
        ' pnlDrawer
        ' 
        pnlDrawer.BackColor = Color.White
        pnlDrawer.Controls.Add(pnlDrawerTop)
        pnlDrawer.Controls.Add(pnlDrawerScroll)
        pnlDrawer.Controls.Add(pnlDrawerBottom)
        pnlDrawer.Location = New Point(875, 0)
        pnlDrawer.Name = "pnlDrawer"
        pnlDrawer.Size = New Size(225, 840)
        pnlDrawer.TabIndex = 10
        pnlDrawer.Visible = False
        ' 
        ' pnlDrawerTop
        ' 
        pnlDrawerTop.BackColor = Color.White
        pnlDrawerTop.Controls.Add(lblDrawerTitle)
        pnlDrawerTop.Controls.Add(btnCloseDrawer)
        pnlDrawerTop.Location = New Point(0, 0)
        pnlDrawerTop.Name = "pnlDrawerTop"
        pnlDrawerTop.Size = New Size(225, 48)
        pnlDrawerTop.TabIndex = 0
        ' 
        ' lblDrawerTitle
        ' 
        lblDrawerTitle.AutoSize = True
        lblDrawerTitle.Font = New Font("Garamond", 12F, FontStyle.Bold)
        lblDrawerTitle.ForeColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        lblDrawerTitle.Location = New Point(14, 14)
        lblDrawerTitle.Name = "lblDrawerTitle"
        lblDrawerTitle.Size = New Size(196, 22)
        lblDrawerTitle.TabIndex = 0
        lblDrawerTitle.Text = "Tambah Parfum Baru"
        ' 
        ' btnCloseDrawer
        ' 
        btnCloseDrawer.BackColor = Color.Transparent
        btnCloseDrawer.Cursor = Cursors.Hand
        btnCloseDrawer.FlatAppearance.BorderSize = 0
        btnCloseDrawer.FlatStyle = FlatStyle.Flat
        btnCloseDrawer.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnCloseDrawer.ForeColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        btnCloseDrawer.Location = New Point(196, 14)
        btnCloseDrawer.Name = "btnCloseDrawer"
        btnCloseDrawer.Size = New Size(20, 20)
        btnCloseDrawer.TabIndex = 1
        btnCloseDrawer.Text = "X"
        btnCloseDrawer.UseVisualStyleBackColor = False
        ' 
        ' pnlDrawerScroll
        ' 
        pnlDrawerScroll.AutoScroll = True
        pnlDrawerScroll.BackColor = Color.White
        pnlDrawerScroll.Controls.Add(lblSecIdentity)
        pnlDrawerScroll.Controls.Add(lblFragName)
        pnlDrawerScroll.Controls.Add(txtFragranceName)
        pnlDrawerScroll.Controls.Add(lblOriginBrand)
        pnlDrawerScroll.Controls.Add(txtOriginBrand)
        pnlDrawerScroll.Controls.Add(lblConcentration)
        pnlDrawerScroll.Controls.Add(cboConcentration)
        pnlDrawerScroll.Controls.Add(lblSecInventory)
        pnlDrawerScroll.Controls.Add(lblRetailPrice)
        pnlDrawerScroll.Controls.Add(txtRetailPrice)
        pnlDrawerScroll.Controls.Add(lblCurrentStock)
        pnlDrawerScroll.Controls.Add(txtCurrentStock)
        pnlDrawerScroll.Controls.Add(lblSecOlfactory)
        pnlDrawerScroll.Controls.Add(lblTopNotes)
        pnlDrawerScroll.Controls.Add(txtTopNotes)
        pnlDrawerScroll.Controls.Add(lblHeartNotes)
        pnlDrawerScroll.Controls.Add(txtHeartNotes)
        pnlDrawerScroll.Controls.Add(lblBaseNotes)
        pnlDrawerScroll.Controls.Add(txtBaseNotes)
        pnlDrawerScroll.Controls.Add(lblSecPhoto)
        pnlDrawerScroll.Controls.Add(pnlPhotoUpload)
        pnlDrawerScroll.Location = New Point(0, 48)
        pnlDrawerScroll.Name = "pnlDrawerScroll"
        pnlDrawerScroll.Size = New Size(225, 736)
        pnlDrawerScroll.TabIndex = 1
        ' 
        ' lblSecIdentity
        ' 
        lblSecIdentity.AutoSize = True
        lblSecIdentity.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblSecIdentity.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblSecIdentity.Location = New Point(14, 14)
        lblSecIdentity.Name = "lblSecIdentity"
        lblSecIdentity.Size = New Size(60, 15)
        lblSecIdentity.TabIndex = 0
        lblSecIdentity.Text = "IDENTITY"
        ' 
        ' lblFragName
        ' 
        lblFragName.AutoSize = True
        lblFragName.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblFragName.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblFragName.Location = New Point(14, 34)
        lblFragName.Name = "lblFragName"
        lblFragName.Size = New Size(102, 15)
        lblFragName.TabIndex = 1
        lblFragName.Text = "NAMA PARFUM *"
        ' 
        ' txtFragranceName
        ' 
        txtFragranceName.BackColor = Color.White
        txtFragranceName.BorderStyle = BorderStyle.FixedSingle
        txtFragranceName.Font = New Font("Segoe UI", 9F)
        txtFragranceName.ForeColor = Color.FromArgb(CByte(40), CByte(35), CByte(30))
        txtFragranceName.Location = New Point(14, 50)
        txtFragranceName.MaxLength = 100
        txtFragranceName.Name = "txtFragranceName"
        txtFragranceName.Size = New Size(197, 27)
        txtFragranceName.TabIndex = 2
        ' 
        ' lblOriginBrand
        ' 
        lblOriginBrand.AutoSize = True
        lblOriginBrand.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblOriginBrand.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblOriginBrand.Location = New Point(14, 84)
        lblOriginBrand.Name = "lblOriginBrand"
        lblOriginBrand.Size = New Size(101, 15)
        lblOriginBrand.TabIndex = 3
        lblOriginBrand.Text = "MERK / BRAND *"
        ' 
        ' txtOriginBrand
        ' 
        txtOriginBrand.BackColor = Color.White
        txtOriginBrand.BorderStyle = BorderStyle.FixedSingle
        txtOriginBrand.Font = New Font("Segoe UI", 9F)
        txtOriginBrand.ForeColor = Color.FromArgb(CByte(40), CByte(35), CByte(30))
        txtOriginBrand.Location = New Point(14, 100)
        txtOriginBrand.MaxLength = 100
        txtOriginBrand.Name = "txtOriginBrand"
        txtOriginBrand.Size = New Size(197, 27)
        txtOriginBrand.TabIndex = 4
        ' 
        ' lblConcentration
        ' 
        lblConcentration.AutoSize = True
        lblConcentration.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblConcentration.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblConcentration.Location = New Point(14, 134)
        lblConcentration.Name = "lblConcentration"
        lblConcentration.Size = New Size(89, 15)
        lblConcentration.TabIndex = 5
        lblConcentration.Text = "KONSENTRASI"
        ' 
        ' cboConcentration
        ' 
        cboConcentration.BackColor = Color.White
        cboConcentration.DropDownStyle = ComboBoxStyle.DropDownList
        cboConcentration.FlatStyle = FlatStyle.Flat
        cboConcentration.Font = New Font("Segoe UI", 9F)
        cboConcentration.ForeColor = Color.FromArgb(CByte(40), CByte(35), CByte(30))
        cboConcentration.Items.AddRange(New Object() {"Eau de Parfum", "Extrait de Parfum", "Eau de Toilette", "Eau de Cologne", "Parfum"})
        cboConcentration.Location = New Point(14, 150)
        cboConcentration.Name = "cboConcentration"
        cboConcentration.Size = New Size(197, 28)
        cboConcentration.TabIndex = 6
        ' 
        ' lblSecInventory
        ' 
        lblSecInventory.AutoSize = True
        lblSecInventory.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblSecInventory.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblSecInventory.Location = New Point(14, 190)
        lblSecInventory.Name = "lblSecInventory"
        lblSecInventory.Size = New Size(122, 15)
        lblSecInventory.TabIndex = 7
        lblSecInventory.Text = "INVENTORY & HARGA"
        ' 
        ' lblRetailPrice
        ' 
        lblRetailPrice.AutoSize = True
        lblRetailPrice.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblRetailPrice.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblRetailPrice.Location = New Point(14, 210)
        lblRetailPrice.Name = "lblRetailPrice"
        lblRetailPrice.Size = New Size(83, 15)
        lblRetailPrice.TabIndex = 8
        lblRetailPrice.Text = "HARGA (Rp) *"
        ' 
        ' txtRetailPrice
        ' 
        txtRetailPrice.BackColor = Color.White
        txtRetailPrice.BorderStyle = BorderStyle.FixedSingle
        txtRetailPrice.Font = New Font("Segoe UI", 9F)
        txtRetailPrice.ForeColor = Color.FromArgb(CByte(40), CByte(35), CByte(30))
        txtRetailPrice.Location = New Point(14, 226)
        txtRetailPrice.Name = "txtRetailPrice"
        txtRetailPrice.Size = New Size(90, 27)
        txtRetailPrice.TabIndex = 9
        txtRetailPrice.Text = "0.00"
        ' 
        ' lblCurrentStock
        ' 
        lblCurrentStock.AutoSize = True
        lblCurrentStock.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblCurrentStock.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblCurrentStock.Location = New Point(118, 210)
        lblCurrentStock.Name = "lblCurrentStock"
        lblCurrentStock.Size = New Size(46, 15)
        lblCurrentStock.TabIndex = 10
        lblCurrentStock.Text = "STOK *"
        ' 
        ' txtCurrentStock
        ' 
        txtCurrentStock.BackColor = Color.White
        txtCurrentStock.BorderStyle = BorderStyle.FixedSingle
        txtCurrentStock.Font = New Font("Segoe UI", 9F)
        txtCurrentStock.ForeColor = Color.FromArgb(CByte(40), CByte(35), CByte(30))
        txtCurrentStock.Location = New Point(118, 226)
        txtCurrentStock.Name = "txtCurrentStock"
        txtCurrentStock.Size = New Size(93, 27)
        txtCurrentStock.TabIndex = 11
        txtCurrentStock.Text = "0"
        ' 
        ' lblSecOlfactory
        ' 
        lblSecOlfactory.AutoSize = True
        lblSecOlfactory.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblSecOlfactory.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblSecOlfactory.Location = New Point(14, 268)
        lblSecOlfactory.Name = "lblSecOlfactory"
        lblSecOlfactory.Size = New Size(114, 15)
        lblSecOlfactory.TabIndex = 12
        lblSecOlfactory.Text = "OLFACTORY NOTES"
        ' 
        ' lblTopNotes
        ' 
        lblTopNotes.AutoSize = True
        lblTopNotes.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblTopNotes.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblTopNotes.Location = New Point(14, 288)
        lblTopNotes.Name = "lblTopNotes"
        lblTopNotes.Size = New Size(71, 15)
        lblTopNotes.TabIndex = 13
        lblTopNotes.Text = "TOP NOTES"
        ' 
        ' txtTopNotes
        ' 
        txtTopNotes.BackColor = Color.White
        txtTopNotes.BorderStyle = BorderStyle.FixedSingle
        txtTopNotes.Font = New Font("Segoe UI", 8.5F)
        txtTopNotes.ForeColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        txtTopNotes.Location = New Point(14, 304)
        txtTopNotes.Multiline = True
        txtTopNotes.Name = "txtTopNotes"
        txtTopNotes.Size = New Size(197, 44)
        txtTopNotes.TabIndex = 14
        ' 
        ' lblHeartNotes
        ' 
        lblHeartNotes.AutoSize = True
        lblHeartNotes.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblHeartNotes.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblHeartNotes.Location = New Point(14, 358)
        lblHeartNotes.Name = "lblHeartNotes"
        lblHeartNotes.Size = New Size(86, 15)
        lblHeartNotes.TabIndex = 15
        lblHeartNotes.Text = "HEART NOTES"
        ' 
        ' txtHeartNotes
        ' 
        txtHeartNotes.BackColor = Color.White
        txtHeartNotes.BorderStyle = BorderStyle.FixedSingle
        txtHeartNotes.Font = New Font("Segoe UI", 8.5F)
        txtHeartNotes.ForeColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        txtHeartNotes.Location = New Point(14, 374)
        txtHeartNotes.Multiline = True
        txtHeartNotes.Name = "txtHeartNotes"
        txtHeartNotes.Size = New Size(197, 44)
        txtHeartNotes.TabIndex = 16
        ' 
        ' lblBaseNotes
        ' 
        lblBaseNotes.AutoSize = True
        lblBaseNotes.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblBaseNotes.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblBaseNotes.Location = New Point(14, 428)
        lblBaseNotes.Name = "lblBaseNotes"
        lblBaseNotes.Size = New Size(77, 15)
        lblBaseNotes.TabIndex = 17
        lblBaseNotes.Text = "BASE NOTES"
        ' 
        ' txtBaseNotes
        ' 
        txtBaseNotes.BackColor = Color.White
        txtBaseNotes.BorderStyle = BorderStyle.FixedSingle
        txtBaseNotes.Font = New Font("Segoe UI", 8.5F)
        txtBaseNotes.ForeColor = Color.FromArgb(CByte(120), CByte(110), CByte(100))
        txtBaseNotes.Location = New Point(14, 444)
        txtBaseNotes.Multiline = True
        txtBaseNotes.Name = "txtBaseNotes"
        txtBaseNotes.Size = New Size(197, 44)
        txtBaseNotes.TabIndex = 18
        ' 
        ' lblSecPhoto
        ' 
        lblSecPhoto.AutoSize = True
        lblSecPhoto.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblSecPhoto.ForeColor = Color.FromArgb(CByte(140), CByte(130), CByte(120))
        lblSecPhoto.Location = New Point(14, 500)
        lblSecPhoto.Name = "lblSecPhoto"
        lblSecPhoto.Size = New Size(91, 15)
        lblSecPhoto.TabIndex = 19
        lblSecPhoto.Text = "FOTO PRODUK"
        ' 
        ' pnlPhotoUpload
        ' 
        pnlPhotoUpload.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(246))
        pnlPhotoUpload.BorderStyle = BorderStyle.FixedSingle
        pnlPhotoUpload.Controls.Add(lblPhotoIcon)
        pnlPhotoUpload.Controls.Add(lblPhotoHint)
        pnlPhotoUpload.Cursor = Cursors.Hand
        pnlPhotoUpload.Location = New Point(14, 518)
        pnlPhotoUpload.Name = "pnlPhotoUpload"
        pnlPhotoUpload.Size = New Size(197, 80)
        pnlPhotoUpload.TabIndex = 20
        ' 
        ' lblPhotoIcon
        ' 
        lblPhotoIcon.AutoSize = True
        lblPhotoIcon.Font = New Font("Segoe UI", 12F)
        lblPhotoIcon.ForeColor = Color.FromArgb(CByte(180), CByte(170), CByte(160))
        lblPhotoIcon.Location = New Point(74, 14)
        lblPhotoIcon.Name = "lblPhotoIcon"
        lblPhotoIcon.Size = New Size(38, 28)
        lblPhotoIcon.TabIndex = 0
        lblPhotoIcon.Text = "[+]"
        ' 
        ' lblPhotoHint
        ' 
        lblPhotoHint.Font = New Font("Segoe UI", 7F)
        lblPhotoHint.ForeColor = Color.FromArgb(CByte(160), CByte(150), CByte(140))
        lblPhotoHint.Location = New Point(6, 50)
        lblPhotoHint.Name = "lblPhotoHint"
        lblPhotoHint.Size = New Size(185, 28)
        lblPhotoHint.TabIndex = 1
        lblPhotoHint.Text = "Drop file atau klik untuk browse"
        lblPhotoHint.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlDrawerBottom
        ' 
        pnlDrawerBottom.BackColor = Color.White
        pnlDrawerBottom.Controls.Add(btnSaveFragrance)
        pnlDrawerBottom.Controls.Add(btnCancelDrawer)
        pnlDrawerBottom.Location = New Point(0, 784)
        pnlDrawerBottom.Name = "pnlDrawerBottom"
        pnlDrawerBottom.Size = New Size(225, 56)
        pnlDrawerBottom.TabIndex = 2
        ' 
        ' btnSaveFragrance
        ' 
        btnSaveFragrance.BackColor = Color.FromArgb(CByte(25), CByte(20), CByte(15))
        btnSaveFragrance.Cursor = Cursors.Hand
        btnSaveFragrance.FlatAppearance.BorderSize = 0
        btnSaveFragrance.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(44), CByte(38))
        btnSaveFragrance.FlatStyle = FlatStyle.Flat
        btnSaveFragrance.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        btnSaveFragrance.ForeColor = Color.White
        btnSaveFragrance.Location = New Point(10, 12)
        btnSaveFragrance.Name = "btnSaveFragrance"
        btnSaveFragrance.Size = New Size(120, 32)
        btnSaveFragrance.TabIndex = 0
        btnSaveFragrance.Text = "SIMPAN"
        btnSaveFragrance.UseVisualStyleBackColor = False
        ' 
        ' btnCancelDrawer
        ' 
        btnCancelDrawer.BackColor = Color.White
        btnCancelDrawer.Cursor = Cursors.Hand
        btnCancelDrawer.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(205), CByte(200))
        btnCancelDrawer.FlatStyle = FlatStyle.Flat
        btnCancelDrawer.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        btnCancelDrawer.ForeColor = Color.FromArgb(CByte(80), CByte(70), CByte(60))
        btnCancelDrawer.Location = New Point(138, 12)
        btnCancelDrawer.Name = "btnCancelDrawer"
        btnCancelDrawer.Size = New Size(76, 32)
        btnCancelDrawer.TabIndex = 1
        btnCancelDrawer.Text = "BATAL"
        btnCancelDrawer.UseVisualStyleBackColor = False
        ' 
        ' FormInventory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(243), CByte(240))
        ClientSize = New Size(1100, 840)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlContent)
        Controls.Add(pnlDrawer)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormInventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aura Perfumerie - Inventory"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlUserBadge.ResumeLayout(False)
        pnlUserBadge.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlStats.ResumeLayout(False)
        pnlStatRevenue.ResumeLayout(False)
        pnlStatRevenue.PerformLayout()
        pnlStatSlots.ResumeLayout(False)
        pnlStatSlots.PerformLayout()
        pnlStatEntries.ResumeLayout(False)
        pnlStatEntries.PerformLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        pnlPagination.ResumeLayout(False)
        pnlPagination.PerformLayout()
        pnlDrawer.ResumeLayout(False)
        pnlDrawerTop.ResumeLayout(False)
        pnlDrawerTop.PerformLayout()
        pnlDrawerScroll.ResumeLayout(False)
        pnlDrawerScroll.PerformLayout()
        pnlPhotoUpload.ResumeLayout(False)
        pnlPhotoUpload.PerformLayout()
        pnlDrawerBottom.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    '── Control Declarations ────────────────────────────────────────
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents lblAura As System.Windows.Forms.Label
    Friend WithEvents lblPerfumerie As System.Windows.Forms.Label
    Friend WithEvents lblManageSub As System.Windows.Forms.Label
    Friend WithEvents pnlSideDiv As System.Windows.Forms.Panel
    Friend WithEvents btnNavDashboard As System.Windows.Forms.Button
    Friend WithEvents btnNavInventory As System.Windows.Forms.Button
    Friend WithEvents btnNavFragrances As System.Windows.Forms.Button
    Friend WithEvents btnNavAnalytics As System.Windows.Forms.Button
    Friend WithEvents btnNavSettings As System.Windows.Forms.Button
    Friend WithEvents btnNavLogout As System.Windows.Forms.Button
    Friend WithEvents pnlUserBadge As System.Windows.Forms.Panel
    Friend WithEvents lblUserInitials As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserRole As System.Windows.Forms.Label
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
    Friend WithEvents lblStockMgmt As System.Windows.Forms.Label
    Friend WithEvents lblCollectionTitle As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnCloseForm As System.Windows.Forms.Button
    Friend WithEvents pnlStats As System.Windows.Forms.Panel
    Friend WithEvents pnlStatRevenue As System.Windows.Forms.Panel
    Friend WithEvents lblRevTitle As System.Windows.Forms.Label
    Friend WithEvents lblRevValue As System.Windows.Forms.Label
    Friend WithEvents lblRevChange As System.Windows.Forms.Label
    Friend WithEvents pnlStatSlots As System.Windows.Forms.Panel
    Friend WithEvents lblSlotsTitle As System.Windows.Forms.Label
    Friend WithEvents lblSlotsValue As System.Windows.Forms.Label
    Friend WithEvents lblSlotsAction As System.Windows.Forms.Label
    Friend WithEvents pnlStatEntries As System.Windows.Forms.Panel
    Friend WithEvents lblEntrTitle As System.Windows.Forms.Label
    Friend WithEvents lblEntrValue As System.Windows.Forms.Label
    Friend WithEvents lblEntrLabel As System.Windows.Forms.Label
    Friend WithEvents dgvInventory As System.Windows.Forms.DataGridView
    Friend WithEvents pnlPagination As System.Windows.Forms.Panel
    Friend WithEvents lblShowingText As System.Windows.Forms.Label
    Friend WithEvents btnPrevPage As System.Windows.Forms.Button
    Friend WithEvents btnNextPage As System.Windows.Forms.Button
    Friend WithEvents pnlDrawer As System.Windows.Forms.Panel
    Friend WithEvents pnlDrawerTop As System.Windows.Forms.Panel
    Friend WithEvents lblDrawerTitle As System.Windows.Forms.Label
    Friend WithEvents btnCloseDrawer As System.Windows.Forms.Button
    Friend WithEvents pnlDrawerScroll As System.Windows.Forms.Panel
    Friend WithEvents lblSecIdentity As System.Windows.Forms.Label
    Friend WithEvents lblFragName As System.Windows.Forms.Label
    Friend WithEvents txtFragranceName As System.Windows.Forms.TextBox
    Friend WithEvents lblOriginBrand As System.Windows.Forms.Label
    Friend WithEvents txtOriginBrand As System.Windows.Forms.TextBox
    Friend WithEvents lblConcentration As System.Windows.Forms.Label
    Friend WithEvents cboConcentration As System.Windows.Forms.ComboBox
    Friend WithEvents lblSecInventory As System.Windows.Forms.Label
    Friend WithEvents lblRetailPrice As System.Windows.Forms.Label
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentStock As System.Windows.Forms.Label
    Friend WithEvents txtCurrentStock As System.Windows.Forms.TextBox
    Friend WithEvents lblSecOlfactory As System.Windows.Forms.Label
    Friend WithEvents lblTopNotes As System.Windows.Forms.Label
    Friend WithEvents txtTopNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblHeartNotes As System.Windows.Forms.Label
    Friend WithEvents txtHeartNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblBaseNotes As System.Windows.Forms.Label
    Friend WithEvents txtBaseNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblSecPhoto As System.Windows.Forms.Label
    Friend WithEvents pnlPhotoUpload As System.Windows.Forms.Panel
    Friend WithEvents lblPhotoIcon As System.Windows.Forms.Label
    Friend WithEvents lblPhotoHint As System.Windows.Forms.Label
    Friend WithEvents pnlDrawerBottom As System.Windows.Forms.Panel
    Friend WithEvents btnSaveFragrance As System.Windows.Forms.Button
    Friend WithEvents btnCancelDrawer As System.Windows.Forms.Button

End Class