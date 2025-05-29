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

        Dim minRowCount As Integer = 10
        Dim dataRowCount As Integer = DataGridView1.Rows.Count

        If dataRowCount < minRowCount Then
            For i As Integer = 1 To (minRowCount - dataRowCount)
                Dim idx As Integer = DataGridView1.Rows.Add()
                With DataGridView1.Rows(idx)
                    .Cells("No").Value = ""
                    .Cells("Username").Value = ""
                    .Cells("Role").Value = ""
                    .Cells(3).Value = "" ' cell edit
                    .Cells(4).Value = "" ' cell hapus
                    .Tag = Nothing ' tag clear
                End With
            Next
        End If


        With DataGridView1
            .Font = New Font("Segoe UI", 10)
            .RowTemplate.Height = 32
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(62, 82, 142)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .EnableHeadersVisualStyles = False

            .GridColor = Color.FromArgb(220, 220, 220)

            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 247, 255)
            .RowsDefaultCellStyle.BackColor = Color.White


            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 235, 255)
            .DefaultCellStyle.SelectionForeColor = Color.Black

            .Columns("No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("Role").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For Each col As DataGridViewColumn In .Columns
                If TypeOf col Is DataGridViewButtonColumn Then
                    col.DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                    col.DefaultCellStyle.BackColor = Color.FromArgb(230, 243, 255)
                    col.DefaultCellStyle.ForeColor = Color.FromArgb(35, 108, 208)
                End If
            Next

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersHeight = 40
            .RowHeadersVisible = False
        End With

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        If String.IsNullOrEmpty(DataGridView1.Rows(e.RowIndex).Cells("Username").Value?.ToString()) Then
            Exit Sub
        End If

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

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.RowIndex >= 0 Then
            Dim isDummyRow As Boolean = String.IsNullOrEmpty(DataGridView1.Rows(e.RowIndex).Cells("Username").Value?.ToString())
            If isDummyRow AndAlso (e.ColumnIndex = 3 OrElse e.ColumnIndex = 4) Then
                e.PaintBackground(e.CellBounds, True)
                e.Handled = True ' Jangan render tombol sama sekali
            End If
        End If
    End Sub

End Class
