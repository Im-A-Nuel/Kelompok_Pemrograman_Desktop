Imports MySql.Data.MySqlClient

Public Class UC_BarangKeluar

    Private Sub UC_BarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarangKeluar("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadDataBarangKeluar(TextBox1.Text)
    End Sub

    Private Sub LoadDataBarangKeluar(keyword As String)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        ' Kolom-kolom
        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("NamaBarang", "Nama Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Kategori", "Kategori")
        DataGridView1.Columns.Add("Tanggal", "Tanggal")
        DataGridView1.Columns.Add("Supplier", "Supplier")

        ' Tombol Edit
        Dim colEdit As New DataGridViewButtonColumn()
        colEdit.HeaderText = "Edit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(colEdit)

        ' Tombol Hapus
        Dim colHapus As New DataGridViewButtonColumn()
        colHapus.HeaderText = "Hapus"
        colHapus.Text = "Hapus"
        colHapus.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(colHapus)

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql As String =
            "SELECT bk.id, b.nama_barang, bk.jumlah, b.kategori, bk.tanggal, bk.supplier 
             FROM barang_keluar bk 
             JOIN tblbarang b ON bk.id_barang = b.id 
             WHERE b.nama_barang LIKE @key OR b.kategori LIKE @key OR bk.tanggal LIKE @key"

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Using reader = cmd.ExecuteReader()
                Dim no = 1
                While reader.Read()
                    DataGridView1.Rows.Add(
                        no,
                        reader("nama_barang").ToString(),
                        reader("jumlah").ToString(),
                        reader("kategori").ToString(),
                        CDate(reader("tanggal")).ToString("dd-MM-yyyy"),
                        reader("supplier").ToString()
                    )
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Tag = reader("id")
                    no += 1
                End While
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        Dim idBarangKeluar As Integer = CInt(DataGridView1.Rows(e.RowIndex).Tag)

        If e.ColumnIndex = 7 Then ' Edit
            MessageBox.Show("Edit Barang Keluar ID: " & idBarangKeluar)
            ' TODO: Panggil form edit jika ada
        ElseIf e.ColumnIndex = 8 Then ' Hapus
            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim sql = "DELETE FROM barang_keluar WHERE id = @id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", idBarangKeluar)
                    cmd.ExecuteNonQuery()
                End Using
                LoadDataBarangKeluar(TextBox1.Text)
            End If
        End If
    End Sub

End Class
