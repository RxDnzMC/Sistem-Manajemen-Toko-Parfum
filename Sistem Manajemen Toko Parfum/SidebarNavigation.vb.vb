Imports System.ComponentModel.Design

Public Class SidebarNavigation

    ' Fungsi untuk menambahkan efek hover pada semua tombol menu
    Private Sub SidebarNavigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                ' Lewati tombol POS System karena itu menu yang sedang aktif saat ini
                If btn.Name <> "BtnPOS" Then
                    AddHandler btn.MouseEnter, AddressOf Menu_MouseEnter
                    AddHandler btn.MouseLeave, AddressOf Menu_MouseLeave
                End If
            End If
        Next
    End Sub

    Private Sub Menu_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(250, 250, 250) ' Abu-abu sangat terang saat di-hover
        btn.ForeColor = Color.Black
    End Sub

    Private Sub Menu_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.White
        btn.ForeColor = Color.Gray
    End Sub

    ' Contoh event saat tombol Inventory diklik
    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
        ' Menyembunyikan form saat ini dan membuka form inventory
        ' Dim frmInventory As New FormInventory()
        ' frmInventory.Show()
        ' Me.FindForm().Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        ' 1. Berikan konfirmasi kepada user
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' 2. Cari Form utama (FormKasir) yang menampung UserControl ini
            Dim parentForm As Form = Me.FindForm()

            If parentForm IsNot Nothing Then
                ' 3. Tampilkan kembali Form Login (Form1)
                Dim loginForm As New Form1()
                loginForm.Show()
                ' 4. Tutup FormKasir
                parentForm.Close()
                'Project Shutdown diubah dari main form close, jadi Last Form Closed
            End If
        End If
    End Sub
End Class