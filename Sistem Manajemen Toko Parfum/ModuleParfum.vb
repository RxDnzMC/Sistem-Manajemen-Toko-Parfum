Imports MySqlConnector

Module ModuleParfum

    '═══════════════════════════════════════════════════════════
    ' READ – Ambil semua parfum
    '═══════════════════════════════════════════════════════════
    Public Function GetAllParfum() As DataTable
        Dim sql = "SELECT id, nama_parfum, merk, harga, stok, notes, gambar_path " &
                  "FROM parfum ORDER BY id DESC"
        Return ExecuteQuery(sql)
    End Function

    '───────────────────────────────────────────────────────────
    ' READ – Cari parfum berdasarkan keyword
    '───────────────────────────────────────────────────────────
    Public Function CariParfum(keyword As String) As DataTable
        Dim sql = "SELECT id, nama_parfum, merk, harga, stok, notes, gambar_path " &
                  "FROM parfum " &
                  "WHERE nama_parfum LIKE @kw OR merk LIKE @kw " &
                  "ORDER BY id DESC"
        Return ExecuteQuery(sql,
               New MySqlParameter("@kw", $"%{keyword.Trim()}%"))
    End Function

    '───────────────────────────────────────────────────────────
    ' READ – Satu parfum by ID
    '───────────────────────────────────────────────────────────
    Public Function GetParfumById(id As Integer) As DataTable
        Dim sql = "SELECT id, nama_parfum, merk, harga, stok, notes, gambar_path " &
                  "FROM parfum WHERE id = @id LIMIT 1"
        Return ExecuteQuery(sql, New MySqlParameter("@id", id))
    End Function

    '═══════════════════════════════════════════════════════════
    ' CREATE – Tambah parfum baru
    '═══════════════════════════════════════════════════════════
    Public Function TambahParfum(namaParfum As String,
                                  merk As String,
                                  harga As Decimal,
                                  stok As Integer,
                                  notes As String,
                                  gambarPath As String) As Boolean
        ' Validasi dulu
        Dim v = ValidationModule.ValidasiParfum(namaParfum, merk, harga.ToString(), stok.ToString())
        If Not v.Valid Then
            MsgBox(v.Pesan, MsgBoxStyle.Exclamation, "Validasi Gagal")
            Return False
        End If

        Dim sql = "INSERT INTO parfum (nama_parfum, merk, harga, stok, notes, gambar_path) " &
                  "VALUES (@nama, @merk, @harga, @stok, @notes, @gambar)"

        Dim result = ExecuteNonQuery(sql,
            New MySqlParameter("@nama", namaParfum.Trim()),
            New MySqlParameter("@merk", merk.Trim()),
            New MySqlParameter("@harga", harga),
            New MySqlParameter("@stok", stok),
            New MySqlParameter("@notes", If(String.IsNullOrWhiteSpace(notes), DBNull.Value, CObj(notes.Trim()))),
            New MySqlParameter("@gambar", If(String.IsNullOrWhiteSpace(gambarPath), DBNull.Value, CObj(gambarPath.Trim()))))

        Return result > 0
    End Function

    '═══════════════════════════════════════════════════════════
    ' UPDATE – Perbarui parfum
    '═══════════════════════════════════════════════════════════
    Public Function UpdateParfum(id As Integer,
                                  namaParfum As String,
                                  merk As String,
                                  harga As Decimal,
                                  stok As Integer,
                                  notes As String,
                                  gambarPath As String) As Boolean
        Dim v = ValidationModule.ValidasiParfum(namaParfum, merk, harga.ToString(), stok.ToString())
        If Not v.Valid Then
            MsgBox(v.Pesan, MsgBoxStyle.Exclamation, "Validasi Gagal")
            Return False
        End If

        Dim sql = "UPDATE parfum SET " &
                  "  nama_parfum = @nama, " &
                  "  merk        = @merk, " &
                  "  harga       = @harga, " &
                  "  stok        = @stok, " &
                  "  notes       = @notes, " &
                  "  gambar_path = @gambar " &
                  "WHERE id = @id"

        Dim result = ExecuteNonQuery(sql,
            New MySqlParameter("@nama", namaParfum.Trim()),
            New MySqlParameter("@merk", merk.Trim()),
            New MySqlParameter("@harga", harga),
            New MySqlParameter("@stok", stok),
            New MySqlParameter("@notes", If(String.IsNullOrWhiteSpace(notes), DBNull.Value, CObj(notes.Trim()))),
            New MySqlParameter("@gambar", If(String.IsNullOrWhiteSpace(gambarPath), DBNull.Value, CObj(gambarPath.Trim()))),
            New MySqlParameter("@id", id))

        Return result > 0
    End Function

    '═══════════════════════════════════════════════════════════
    ' DELETE – Hapus parfum
    '═══════════════════════════════════════════════════════════
    Public Function HapusParfum(id As Integer) As Boolean
        Dim sql = "DELETE FROM parfum WHERE id = @id"
        Dim result = ExecuteNonQuery(sql, New MySqlParameter("@id", id))
        Return result > 0
    End Function

    '═══════════════════════════════════════════════════════════
    ' UPDATE STOK SAJA (dipanggil setelah transaksi)
    '═══════════════════════════════════════════════════════════
    Public Function UpdateStok(id As Integer,
                                stokBaru As Integer) As Boolean
        Dim sql = "UPDATE parfum SET stok = @stok WHERE id = @id"
        Dim result = ExecuteNonQuery(sql,
            New MySqlParameter("@stok", stokBaru),
            New MySqlParameter("@id", id))
        Return result > 0
    End Function

    '═══════════════════════════════════════════════════════════
    ' STATISTIK – Total nilai inventori
    '═══════════════════════════════════════════════════════════
    Public Function GetTotalNilaiInventori() As Decimal
        Dim sql = "SELECT COALESCE(SUM(harga * stok), 0) FROM parfum"
        Dim result = ExecuteScalar(sql)
        If result Is Nothing OrElse IsDBNull(result) Then Return 0
        Return CDec(result)
    End Function

    Public Function GetJumlahItem() As Integer
        Dim sql = "SELECT COUNT(*) FROM parfum"
        Dim result = ExecuteScalar(sql)
        If result Is Nothing OrElse IsDBNull(result) Then Return 0
        Return CInt(result)
    End Function

    Public Function GetItemStokRendah(threshold As Integer) As DataTable
        Dim sql = "SELECT id, nama_parfum, merk, stok FROM parfum " &
                  "WHERE stok <= @thr ORDER BY stok ASC"
        Return ExecuteQuery(sql, New MySqlParameter("@thr", threshold))
    End Function

End Module