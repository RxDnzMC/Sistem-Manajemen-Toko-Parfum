Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class Form1

    Private isPasswordVisible As Boolean = False

    '─────────────────────────────────────────────
    ' FORM LOAD
    '─────────────────────────────────────────────
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        ApplyPlaceholder(txtUsername, "operator.name")
        ApplyPlaceholder(txtSecurityKey, "")
        txtSecurityKey.PasswordChar = "●"c
        txtSecurityKey.UseSystemPasswordChar = False
    End Sub

    '─────────────────────────────────────────────
    ' PLACEHOLDER HELPER
    '─────────────────────────────────────────────
    Private Sub ApplyPlaceholder(tb As TextBox, placeholder As String)
        If placeholder = "" Then Exit Sub
        tb.Text = placeholder
        tb.ForeColor = Color.FromArgb(160, 160, 160)
        AddHandler tb.Enter, Sub(s, ev)
                                 Dim t = DirectCast(s, TextBox)
                                 If t.Text = placeholder Then
                                     t.Text = ""
                                     t.ForeColor = Color.FromArgb(40, 40, 40)
                                 End If
                             End Sub
        AddHandler tb.Leave, Sub(s, ev)
                                 Dim t = DirectCast(s, TextBox)
                                 If t.Text = "" Then
                                     t.Text = placeholder
                                     t.ForeColor = Color.FromArgb(160, 160, 160)
                                 End If
                             End Sub
    End Sub

    '─────────────────────────────────────────────
    ' TOGGLE PASSWORD VISIBILITY
    '─────────────────────────────────────────────
    Private Sub btnEye_Click(sender As Object, e As EventArgs) Handles btnEye.Click
        isPasswordVisible = Not isPasswordVisible
        If isPasswordVisible Then
            txtSecurityKey.PasswordChar = Chr(0)
            txtSecurityKey.UseSystemPasswordChar = False
            btnEye.Text = "🙈"
        Else
            txtSecurityKey.PasswordChar = "●"c
            txtSecurityKey.UseSystemPasswordChar = False
            btnEye.Text = "👁"
        End If
        txtSecurityKey.Focus()
    End Sub

    '─────────────────────────────────────────────
    ' AUTHENTICATE ACCESS
    '─────────────────────────────────────────────
    Private Sub btnAuthenticate_Click(sender As Object, e As EventArgs) Handles btnAuthenticate.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim seckey As String = txtSecurityKey.Text.Trim()

        If username = "" OrElse username = "operator.name" Then
            HighlightError(txtUsername)
            MsgBox("Username is required.", MsgBoxStyle.Exclamation, "L'Essence – Authentication")
            Return
        End If

        If seckey = "" Then
            HighlightError(txtSecurityKey)
            MsgBox("Security key is required.", MsgBoxStyle.Exclamation, "L'Essence – Authentication")
            Return
        End If

        ' ── Replace this block with your real auth logic ──
        If username = "curator" AndAlso seckey = "1234" Then
            ' Menyembunyikan form login dan membuka inventory
            Me.Hide()
            Dim invForm As New FormInventory()
            invForm.ShowDialog()
            Me.Close() ' Menutup aplikasi sepenuhnya jika form inventory ditutup
        Else
            MsgBox("Invalid credentials. This attempt has been recorded.", MsgBoxStyle.Critical, "L'Essence – Access Denied")
        End If
    End Sub

    Private Sub HighlightError(tb As TextBox)
        tb.BackColor = Color.FromArgb(255, 245, 245)
        Dim tmr As New Timer()
        tmr.Interval = 1200
        AddHandler tmr.Tick, Sub()
                                 tb.BackColor = Color.White
                                 tmr.Stop()
                                 tmr.Dispose()
                             End Sub
        tmr.Start()
    End Sub

    '─────────────────────────────────────────────
    ' RESET KEY LINK
    '─────────────────────────────────────────────
    Private Sub lnkResetKey_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkResetKey.LinkClicked
        MsgBox("A reset link will be sent to the registered curator email.", MsgBoxStyle.Information, "L'Essence – Key Reset")
    End Sub

    '─────────────────────────────────────────────
    ' GUEST LINK
    '─────────────────────────────────────────────
    Private Sub lnkGuest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGuest.LinkClicked
        MsgBox("Continuing as guest. Limited access granted.", MsgBoxStyle.Information, "L'Essence – Guest Mode")
    End Sub

    '─────────────────────────────────────────────
    ' CUSTOM PAINT – left panel gradient overlay
    '─────────────────────────────────────────────
    Private Sub pnlLeft_Paint(sender As Object, e As PaintEventArgs) Handles pnlLeft.Paint
        Dim rect As New Rectangle(0, pnlLeft.Height - 120, pnlLeft.Width, 120)
        Using br As New LinearGradientBrush(rect,
                                            Color.Transparent,
                                            Color.FromArgb(200, 30, 25, 20),
                                            LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(br, rect)
        End Using
    End Sub

    '─────────────────────────────────────────────
    ' DRAGGABLE BORDERLESS FORM
    '─────────────────────────────────────────────
    Private _dragging As Boolean = False
    Private _dragStart As Point

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        _dragging = True
        _dragStart = e.Location
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If _dragging Then
            Me.Left += e.X - _dragStart.X
            Me.Top += e.Y - _dragStart.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        _dragging = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub picPerfume_Click(sender As Object, e As EventArgs) Handles picPerfume.Click

    End Sub
End Class