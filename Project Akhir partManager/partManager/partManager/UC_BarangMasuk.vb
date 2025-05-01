Imports MySql.Data.MySqlClient

Public Class UC_BarangMasuk

    Private Sub UC_BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarangMasuk("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadDataBarangMasuk(TextBox1.Text)
    End Sub

    Private Sub LoadDataBarangMasuk(keyword As String)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("NamaBarang", "Nama Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Kategori", "Kategori")
        DataGridView1.Columns.Add("Tanggal", "Tanggal")
        DataGridView1.Columns.Add("Supplier", "Supplier")

        Dim btnEdit As New DataGridViewButtonColumn()
        btnEdit.HeaderText = "Edit"
        btnEdit.Text = "Edit"
        btnEdit.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnEdit)

        Dim btnHapus As New DataGridViewButtonColumn()
        btnHapus.HeaderText = "Hapus"
        btnHapus.Text = "Hapus"
        btnHapus.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnHapus)

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql As String = "SELECT bm.id, b.nama_barang, bm.jumlah, b.kategori, bm.tanggal, bm.supplier " &
                            "FROM barang_masuk bm JOIN tblbarang b ON bm.id_barang = b.id " &
                            "WHERE b.nama_barang LIKE @key OR b.kategori LIKE @key OR bm.tanggal LIKE @key"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Using reader = cmd.ExecuteReader()
                Dim no = 1
                While reader.Read()
                    DataGridView1.Rows.Add(no,
                                           reader("nama_barang").ToString(),
                                           reader("jumlah").ToString(),
                                           reader("kategori").ToString(),
                                           Convert.ToDateTime(reader("tanggal")).ToString("dd-MM-yyyy"),
                                           reader("supplier").ToString())
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Tag = reader("id")
                    no += 1
                End While
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim idBarangMasuk As Integer = CInt(DataGridView1.Rows(e.RowIndex).Tag)

            If e.ColumnIndex = 7 Then
                MessageBox.Show("Edit Barang Masuk ID: " & idBarangMasuk)
            End If

            If e.ColumnIndex = 8 Then 
                If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim sql = "DELETE FROM barang_masuk WHERE id = @id"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@id", idBarangMasuk)
                        cmd.ExecuteNonQuery()
                    End Using
                    LoadDataBarangMasuk(TextBox1.Text)
                End If
            End If
        End If
    End Sub

End Class
