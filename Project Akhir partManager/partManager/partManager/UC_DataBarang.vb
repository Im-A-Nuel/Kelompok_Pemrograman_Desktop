Imports MySql.Data.MySqlClient

Public Class UC_DataBarang

    Private Sub UC_DataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarang("")
    End Sub


    Private Sub LoadDataBarang(keyword As String)

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("nama_barang", "Nama Barang")
        DataGridView1.Columns.Add("deskripsi", "Deskripsi")

        Dim editButton As New DataGridViewButtonColumn()
        editButton.HeaderText = "Edit"
        editButton.Text = "Edit"
        editButton.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(editButton)

        Dim hapusButton As New DataGridViewButtonColumn()
        hapusButton.HeaderText = "Hapus"
        hapusButton.Text = "Hapus"
        hapusButton.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(hapusButton)

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql = "SELECT * FROM tblbarang"
        Using cmd As New MySqlCommand(sql, conn)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    DataGridView1.Rows.Add(
                                       reader("id").ToString(),
                                       reader("nama_barang").ToString(),
                                       reader("deskripsi").ToString(),
                                       reader("kategori").ToString())
                End While
            End Using
        End Using
    End Sub



    Private Sub EditBarang(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idBarang As Integer = CInt(btn.Tag)

        Dim frm As New Tambah_Barang()
        frm.Mode = "Edit"
        frm.BarangID = idBarang
        frm.RefreshCallback = Sub() LoadDataBarang(txtSearch.Text)
        frm.ShowDialog()
    End Sub

    Private Sub HapusBarang(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idBarang As Integer = CInt(btn.Tag)

        If MessageBox.Show("Yakin ingin menghapus barang ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql = "DELETE FROM tblbarang WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", idBarang)
                cmd.ExecuteNonQuery()
            End Using
            LoadDataBarang(txtSearch.Text)
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs)
        LoadDataBarang(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDataBarang(txtSearch.Text)
        End If
    End Sub

    Private Sub btnAddBarang_Click(sender As Object, e As EventArgs) Handles btnAddBarang.Click
        Dim frm As New Tambah_Barang()
        frm.Mode = "Add"
        frm.RefreshCallback = Sub() LoadDataBarang(txtSearch.Text)
        frm.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            Dim namaBarang As String = row.Cells("nama_barang").Value.ToString()

            If e.ColumnIndex = 3 Then
                Dim idBarang As Integer = GetIdBarangByNama(namaBarang)
                Dim frm As New Tambah_Barang()
                frm.Mode = "Edit"
                frm.BarangID = idBarang
                frm.RefreshCallback = Sub() LoadDataBarang(txtSearch.Text)
                frm.ShowDialog()
            End If

            If e.ColumnIndex = 4 Then
                If MessageBox.Show("Yakin ingin menghapus barang ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim idBarang As Integer = GetIdBarangByNama(namaBarang)
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim sql = "DELETE FROM tblbarang WHERE id = @id"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@id", idBarang)
                        cmd.ExecuteNonQuery()
                    End Using
                    LoadDataBarang(txtSearch.Text)
                End If
            End If
        End If
    End Sub


    Private Function GetIdBarangByNama(nama As String) As Integer
        Dim sql = "SELECT id FROM tblbarang WHERE nama_barang = @nama LIMIT 1"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nama", nama)
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, CInt(result), 0)
        End Using
    End Function

End Class
