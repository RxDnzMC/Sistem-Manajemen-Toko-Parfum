<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderFooter
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
        LblSubtotalText = New Label()
        LblSubtotalValue = New Label()
        LblTaxText = New Label()
        LblTaxValue = New Label()
        PanelDivider = New Panel()
        LblTotalText = New Label()
        LblTotalValue = New Label()
        BtnAssignClient = New Button()
        BtnConfirmPayment = New Button()
        SuspendLayout()
        ' 
        ' LblSubtotalText
        ' 
        LblSubtotalText.AutoSize = True
        LblSubtotalText.Font = New Font("Segoe UI", 8.0F)
        LblSubtotalText.ForeColor = Color.Gray
        LblSubtotalText.Location = New Point(29, 33)
        LblSubtotalText.Margin = New Padding(4, 0, 4, 0)
        LblSubtotalText.Name = "LblSubtotalText"
        LblSubtotalText.Size = New Size(60, 19)
        LblSubtotalText.TabIndex = 0
        LblSubtotalText.Text = "Subtotal"
        ' 
        ' LblSubtotalValue
        ' 
        LblSubtotalValue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblSubtotalValue.Font = New Font("Segoe UI", 8.0F)
        LblSubtotalValue.Location = New Point(371, 33)
        LblSubtotalValue.Margin = New Padding(4, 0, 4, 0)
        LblSubtotalValue.Name = "LblSubtotalValue"
        LblSubtotalValue.Size = New Size(143, 25)
        LblSubtotalValue.TabIndex = 1
        LblSubtotalValue.Text = "$0.00"
        LblSubtotalValue.TextAlign = ContentAlignment.TopRight
        ' 
        ' LblTaxText
        ' 
        LblTaxText.AutoSize = True
        LblTaxText.Font = New Font("Segoe UI", 8.0F)
        LblTaxText.ForeColor = Color.Gray
        LblTaxText.Location = New Point(29, 75)
        LblTaxText.Margin = New Padding(4, 0, 4, 0)
        LblTaxText.Name = "LblTaxText"
        LblTaxText.Size = New Size(103, 19)
        LblTaxText.TabIndex = 2
        LblTaxText.Text = "Sales Tax (8.5%)"
        ' 
        ' LblTaxValue
        ' 
        LblTaxValue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblTaxValue.Font = New Font("Segoe UI", 8.0F)
        LblTaxValue.Location = New Point(371, 75)
        LblTaxValue.Margin = New Padding(4, 0, 4, 0)
        LblTaxValue.Name = "LblTaxValue"
        LblTaxValue.Size = New Size(143, 25)
        LblTaxValue.TabIndex = 3
        LblTaxValue.Text = "$0.00"
        LblTaxValue.TextAlign = ContentAlignment.TopRight
        ' 
        ' PanelDivider
        ' 
        PanelDivider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        PanelDivider.Location = New Point(29, 125)
        PanelDivider.Margin = New Padding(4, 5, 4, 5)
        PanelDivider.Name = "PanelDivider"
        PanelDivider.Size = New Size(486, 2)
        PanelDivider.TabIndex = 4
        ' 
        ' LblTotalText
        ' 
        LblTotalText.AutoSize = True
        LblTotalText.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblTotalText.Location = New Point(29, 158)
        LblTotalText.Margin = New Padding(4, 0, 4, 0)
        LblTotalText.Name = "LblTotalText"
        LblTotalText.Size = New Size(44, 20)
        LblTotalText.TabIndex = 5
        LblTotalText.Text = "Total"
        ' 
        ' LblTotalValue
        ' 
        LblTotalValue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblTotalValue.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblTotalValue.Location = New Point(371, 158)
        LblTotalValue.Margin = New Padding(4, 0, 4, 0)
        LblTotalValue.Name = "LblTotalValue"
        LblTotalValue.Size = New Size(143, 25)
        LblTotalValue.TabIndex = 6
        LblTotalValue.Text = "$0.00"
        LblTotalValue.TextAlign = ContentAlignment.TopRight
        ' 
        ' BtnAssignClient
        ' 
        BtnAssignClient.BackColor = Color.White
        BtnAssignClient.Cursor = Cursors.Hand
        BtnAssignClient.FlatAppearance.BorderColor = Color.LightGray
        BtnAssignClient.FlatStyle = FlatStyle.Flat
        BtnAssignClient.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        BtnAssignClient.Location = New Point(29, 217)
        BtnAssignClient.Margin = New Padding(4, 5, 4, 5)
        BtnAssignClient.Name = "BtnAssignClient"
        BtnAssignClient.Size = New Size(486, 50)
        BtnAssignClient.TabIndex = 7
        BtnAssignClient.Text = "ASSIGN CLIENT"
        BtnAssignClient.UseVisualStyleBackColor = False
        ' 
        ' BtnConfirmPayment
        ' 
        BtnConfirmPayment.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        BtnConfirmPayment.Cursor = Cursors.Hand
        BtnConfirmPayment.FlatAppearance.BorderSize = 0
        BtnConfirmPayment.FlatStyle = FlatStyle.Flat
        BtnConfirmPayment.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        BtnConfirmPayment.ForeColor = Color.White
        BtnConfirmPayment.Location = New Point(29, 283)
        BtnConfirmPayment.Margin = New Padding(4, 5, 4, 5)
        BtnConfirmPayment.Name = "BtnConfirmPayment"
        BtnConfirmPayment.Size = New Size(486, 58)
        BtnConfirmPayment.TabIndex = 8
        BtnConfirmPayment.Text = "CONFIRM PAYMENT & PRINT RECEIPT  →"
        BtnConfirmPayment.UseVisualStyleBackColor = False
        ' 
        ' OrderFooter
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(BtnConfirmPayment)
        Controls.Add(BtnAssignClient)
        Controls.Add(LblTotalValue)
        Controls.Add(LblTotalText)
        Controls.Add(PanelDivider)
        Controls.Add(LblTaxValue)
        Controls.Add(LblTaxText)
        Controls.Add(LblSubtotalValue)
        Controls.Add(LblSubtotalText)
        Margin = New Padding(4, 5, 4, 5)
        Name = "OrderFooter"
        Size = New Size(543, 367)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LblSubtotalText As System.Windows.Forms.Label
    Friend WithEvents LblSubtotalValue As System.Windows.Forms.Label
    Friend WithEvents LblTaxText As System.Windows.Forms.Label
    Friend WithEvents LblTaxValue As System.Windows.Forms.Label
    Friend WithEvents PanelDivider As System.Windows.Forms.Panel
    Friend WithEvents LblTotalText As System.Windows.Forms.Label
    Friend WithEvents LblTotalValue As System.Windows.Forms.Label
    Friend WithEvents BtnAssignClient As System.Windows.Forms.Button
    Friend WithEvents BtnConfirmPayment As System.Windows.Forms.Button
End Class