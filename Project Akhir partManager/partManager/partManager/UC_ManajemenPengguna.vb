Imports MySql.Data.MySqlClient

Public Class UC_ManajemenPengguna

    Private Sub UC_ManajemenPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataPengguna("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadDataPengguna(TextBox1.Text)
    End Sub

    Private Sub LoadDataPengguna(keyword As String)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        ' Tambahkan kolom
        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("Username", "Username")
        DataGridView1.Columns.Add("Role", "Role")

        ' Kolom Edit
        Dim colEdit As New DataGridViewButtonColumn()
        colEdit.HeaderText = "Edit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(colEdit)

        ' Kolom Hapus
        Dim colHapus As New DataGridViewButtonColumn()
        colHapus.HeaderText = "Hapus"
        colHapus.Text = "Hapus"
        colHapus.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(colHapus)

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql As String = "SELECT * FROM tbluser WHERE username LIKE @key OR role LIKE @key"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Using reader = cmd.ExecuteReader()
                Dim no = 1
                While reader.Read()
                    DataGridView1.Rows.Add(no,
                                           reader("username").ToString(),
                                           reader("role").ToString())
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Tag = reader("id")
                    no += 1
                End While
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idUser As Integer = CInt(DataGridView1.Rows(e.RowIndex).Tag)

        If e.ColumnIndex = 3 Then ' Edit
            MessageBox.Show("Edit Pengguna ID: " & idUser)
            ' Panggil form edit jika ada
        ElseIf e.ColumnIndex = 4 Then ' Hapus
            If MessageBox.Show("Yakin ingin menghapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim sql = "DELETE FROM tbluser WHERE id = @id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", idUser)
                    cmd.ExecuteNonQuery()
                End Using
                LoadDataPengguna(TextBox1.Text)
            End If
        End If
    End Sub

End Class
