Imports MySqlConnector
Module ConnectionModule

    '═══════════════════════════════════════════════════════════
    ' KONFIGURASI KONEKSI – sesuaikan dengan server Anda
    '═══════════════════════════════════════════════════════════
    Private Const SERVER As String = "localhost"
    Private Const PORT As String = "3306"
    Private Const DATABASE As String = "db_toko_parfum"
    Private Const USER As String = "root"
    Private Const PASSWORD As String = ""          ' ganti jika ada password
    Private Const TIMEOUT As String = "30"

    Private ReadOnly ConnectionString As String =
        $"Server={SERVER};Port={PORT};Database={DATABASE};" &
        $"Uid={USER};Pwd={PASSWORD};Connect Timeout={TIMEOUT};" &
        "CharSet=utf8mb4;Allow Zero Datetime=True;Convert Zero Datetime=True;"

    '───────────────────────────────────────────────────────────
    ' Buat dan buka koneksi baru
    ' Kembalikan Nothing jika gagal (error sudah di-handle)
    '───────────────────────────────────────────────────────────
    Public Function GetConnection() As MySqlConnection
        Try
            Dim conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Return conn
        Catch ex As MySqlException
            ShowDBError("Gagal membuka koneksi database.", ex)
            Return Nothing
        Catch ex As Exception
            ShowDBError("Kesalahan tidak terduga saat koneksi.", ex)
            Return Nothing
        End Try
    End Function

    '───────────────────────────────────────────────────────────
    ' Tes koneksi (dipakai saat aplikasi pertama kali dijalankan)
    '───────────────────────────────────────────────────────────
    Public Function TestConnection() As Boolean
        Dim conn As MySqlConnection = GetConnection()
        If conn Is Nothing Then Return False
        conn.Close()
        conn.Dispose()
        Return True
    End Function

    '───────────────────────────────────────────────────────────
    ' Tutup koneksi dengan aman
    '───────────────────────────────────────────────────────────
    Public Sub CloseConnection(ByRef conn As MySqlConnection)
        Try
            If conn IsNot Nothing AndAlso
               conn.State = System.Data.ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            ' abaikan error saat menutup
        Finally
            If conn IsNot Nothing Then
                conn.Dispose()
                conn = Nothing
            End If
        End Try
    End Sub

    '───────────────────────────────────────────────────────────
    ' Eksekusi Non-Query (INSERT / UPDATE / DELETE)
    ' Kembalikan jumlah baris terpengaruh, -1 jika error
    '───────────────────────────────────────────────────────────
    Public Function ExecuteNonQuery(sql As String,
                                   ParamArray params() As MySqlParameter) As Integer
        Dim conn As MySqlConnection = GetConnection()
        If conn Is Nothing Then Return -1

        Try
            Using cmd As New MySqlCommand(sql, conn)
                If params IsNot Nothing Then
                    For Each p As MySqlParameter In params
                        cmd.Parameters.Add(p)
                    Next
                End If
                Return cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            ShowDBError("Gagal menjalankan perintah SQL.", ex)
            Return -1
        Finally
            CloseConnection(conn)
        End Try
    End Function

    '───────────────────────────────────────────────────────────
    ' Eksekusi Query SELECT → kembalikan DataTable
    ' Kembalikan Nothing jika error
    '───────────────────────────────────────────────────────────
    Public Function ExecuteQuery(sql As String,
                                 ParamArray params() As MySqlParameter) As DataTable
        Dim conn As MySqlConnection = GetConnection()
        If conn Is Nothing Then Return Nothing

        Try
            Using cmd As New MySqlCommand(sql, conn)
                If params IsNot Nothing Then
                    For Each p As MySqlParameter In params
                        cmd.Parameters.Add(p)
                    Next
                End If
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        Catch ex As MySqlException
            ShowDBError("Gagal mengambil data dari database.", ex)
            Return Nothing
        Finally
            CloseConnection(conn)
        End Try
    End Function

    '───────────────────────────────────────────────────────────
    ' Eksekusi Scalar (COUNT, MAX, MIN, SUM, dll)
    ' Kembalikan Nothing jika error
    '───────────────────────────────────────────────────────────
    Public Function ExecuteScalar(sql As String,
                                  ParamArray params() As MySqlParameter) As Object
        Dim conn As MySqlConnection = GetConnection()
        If conn Is Nothing Then Return Nothing

        Try
            Using cmd As New MySqlCommand(sql, conn)
                If params IsNot Nothing Then
                    For Each p As MySqlParameter In params
                        cmd.Parameters.Add(p)
                    Next
                End If
                Return cmd.ExecuteScalar()
            End Using
        Catch ex As MySqlException
            ShowDBError("Gagal mengeksekusi scalar query.", ex)
            Return Nothing
        Finally
            CloseConnection(conn)
        End Try
    End Function

    '───────────────────────────────────────────────────────────
    ' Helper tampil pesan error DB
    '───────────────────────────────────────────────────────────
    Private Sub ShowDBError(pesan As String, ex As Exception)
        MsgBox($"{pesan}{vbCrLf}{vbCrLf}Detail: {ex.Message}",
               MsgBoxStyle.Critical, "Database Error – Aura Perfumerie")
    End Sub

End Module