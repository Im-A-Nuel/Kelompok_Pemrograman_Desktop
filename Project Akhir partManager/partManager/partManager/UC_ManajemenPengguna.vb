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

        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("Username", "Username")
        DataGridView1.Columns.Add("Role", "Role")

        Dim colEdit As New DataGridViewButtonColumn()
        colEdit.HeaderText = "Edit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(colEdit)

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

        Dim username As String = DataGridView1.Rows(e.RowIndex).Cells("Username").Value.ToString()
        Dim idUser As Integer = GetIdUserByUsername(username)

        If e.ColumnIndex = 3 Then
            MessageBox.Show("Edit Pengguna ID: " & idUser)

        ElseIf e.ColumnIndex = 4 Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New tambah_user()
        frm.RefreshCallback = Sub() LoadDataPengguna(TextBox1.Text)
        frm.ShowDialog()
    End Sub

    Private Function GetIdUserByUsername(username As String) As Integer
        Dim sql = "SELECT id FROM tbluser WHERE username = @username LIMIT 1"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@username", username)
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, CInt(result), 0)
        End Using
    End Function
End Class
