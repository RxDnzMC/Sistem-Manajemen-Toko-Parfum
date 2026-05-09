Imports MySqlConnector
Imports System.IO

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

    ' Nama file SQL yang akan dicari di dalam folder aplikasi
    Private Const SQL_FILE As String = "db_toko_parfum.sql"

    ' Koneksi khusus ke server untuk membuat database (tanpa parameter Database=)
    Private ReadOnly ServerConnectionString As String =
        $"Server={SERVER};Port={PORT};Uid={USER};Pwd={PASSWORD};Connect Timeout={TIMEOUT};" &
        "CharSet=utf8mb4;"

    ' Koneksi utama ke database aplikasi
    Private ReadOnly ConnectionString As String =
        $"Server={SERVER};Port={PORT};Database={DATABASE};" &
        $"Uid={USER};Pwd={PASSWORD};Connect Timeout={TIMEOUT};" &
        "CharSet=utf8mb4;Allow Zero Datetime=True;Convert Zero Datetime=True;" &
        "Allow User Variables=True;"

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
    ' Tes koneksi & Inisialisasi Database (Auto-Create & Import)
    ' Dipanggil saat aplikasi pertama kali dijalankan
    '───────────────────────────────────────────────────────────
    Public Function TestConnection() As Boolean
        ' 1. Eksekusi CREATE DATABASE ke server MySQL
        Try
            Using connServer As New MySqlConnection(ServerConnectionString)
                connServer.Open()
                Dim sqlCreate As String = $"CREATE DATABASE IF NOT EXISTS `{DATABASE}` CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;"
                Using cmd As New MySqlCommand(sqlCreate, connServer)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ShowDBError("Gagal terhubung ke server MySQL atau membuat database.", ex)
            Return False
        End Try

        ' 2. Koneksikan ke Database yang sudah dipastikan ada
        Dim conn As MySqlConnection = GetConnection()
        If conn Is Nothing Then Return False

        ' 3. Cek apakah tabel sudah ada di dalam database
        Dim databaseKosong As Boolean = True
        Try
            Using cmd As New MySqlCommand("SHOW TABLES;", conn)
                Using reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        databaseKosong = False ' Tabel sudah ada, tidak perlu impor
                    End If
                End Using
            End Using
        Catch ex As Exception
            ShowDBError("Gagal memeriksa tabel database.", ex)
            CloseConnection(conn)
            Return False
        End Try

        ' 4. Jika kosong, cari file .sql atau buat tabel dasar secara otomatis
        If databaseKosong Then
            Dim sqlPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SQL_FILE)

            Dim tabelSudahDibuat As Boolean = False

            ' Opsi A: Jika file .sql ADA, lakukan import
            If File.Exists(sqlPath) Then
                Try
                    Dim scriptContent As String = File.ReadAllText(sqlPath)
                    Using cmdScript As New MySqlCommand(scriptContent, conn)
                        cmdScript.ExecuteNonQuery()
                    End Using
                    tabelSudahDibuat = True
                Catch ex As Exception
                    ' Jika gagal import, kita biarkan lanjut ke Opsi B
                End Try
            End If

            ' Opsi B: Jika file .sql TIDAK ADA (opsional) atau gagal dibaca, 
            ' buat tabel `parfum` kosong secara otomatis agar program tidak error.
            If Not tabelSudahDibuat Then
                Try
                    Dim createTableSql As String =
                        "CREATE TABLE IF NOT EXISTS `parfum` (" &
                        "  `id` INT AUTO_INCREMENT PRIMARY KEY," &
                        "  `nama_parfum` VARCHAR(255) NOT NULL," &
                        "  `merk` VARCHAR(255) NOT NULL," &
                        "  `harga` DECIMAL(15,2) NOT NULL DEFAULT 0," &
                        "  `stok` INT NOT NULL DEFAULT 0," &
                        "  `notes` TEXT," &
                        "  `gambar_path` VARCHAR(500)" &
                        ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;"

                    Using cmdCreate As New MySqlCommand(createTableSql, conn)
                        cmdCreate.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    ShowDBError("Gagal membuat tabel dasar database.", ex)
                    CloseConnection(conn)
                    Return False
                End Try
            End If
        End If

        CloseConnection(conn)
        Return True
    End Function

    '───────────────────────────────────────────────────────────
    ' Tutup koneksi dengan aman
    '───────────────────────────────────────────────────────────
    Public Sub CloseConnection(ByRef conn As MySqlConnection)
        Try
            If conn IsNot Nothing AndAlso conn.State = System.Data.ConnectionState.Open Then
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
    '───────────────────────────────────────────────────────────
    Public Function ExecuteNonQuery(sql As String, ParamArray params() As MySqlParameter) As Integer
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
    '───────────────────────────────────────────────────────────
    Public Function ExecuteQuery(sql As String, ParamArray params() As MySqlParameter) As DataTable
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
    '───────────────────────────────────────────────────────────
    Public Function ExecuteScalar(sql As String, ParamArray params() As MySqlParameter) As Object
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