Imports MySql.Data.MySqlClient

Public Class UC_ManajemenPengguna
    Private Sub UC_ManajemenPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataPengguna("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadDataPengguna(TextBox1.Text)
    End Sub

    Private Sub LoadDataPengguna(keyword As String)
        For i = TableLayoutPanel1.RowCount - 1 To 1 Step -1
            For Each ctrl As Control In TableLayoutPanel1.Controls
                If TableLayoutPanel1.GetRow(ctrl) = i Then
                    TableLayoutPanel1.Controls.Remove(ctrl)
                End If
            Next
            TableLayoutPanel1.RowStyles.RemoveAt(i)
            TableLayoutPanel1.RowCount -= 1
        Next

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql As String = "SELECT * FROM tbluser WHERE username LIKE @key OR role LIKE @key"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Using reader = cmd.ExecuteReader()
                Dim rowIndex = 1
                Dim no = 1
                While reader.Read()
                    TableLayoutPanel1.RowCount += 1
                    TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40))

                    TableLayoutPanel1.Controls.Add(New Label With {.Text = no.ToString(), .AutoSize = True}, 0, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("username").ToString(), .AutoSize = True}, 1, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("role").ToString(), .AutoSize = True}, 2, rowIndex)

                    Dim btnEdit As New Button With {
                        .Text = "Edit",
                        .Tag = reader("id"),
                        .Height = 30,
                        .Width = 50
                    }
                    AddHandler btnEdit.Click, AddressOf BtnEdit_Click
                    TableLayoutPanel1.Controls.Add(btnEdit, 4, rowIndex)

                    Dim btnHapus As New Button With {
                        .Text = "Hapus",
                        .Tag = reader("id"),
                        .Height = 30,
                        .Width = 60,
                        .BackColor = Color.Red,
                        .ForeColor = Color.White
                    }
                    AddHandler btnHapus.Click, AddressOf BtnHapus_Click
                    TableLayoutPanel1.Controls.Add(btnHapus, 5, rowIndex)

                    rowIndex += 1
                    no += 1
                End While
            End Using
        End Using
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idUser As Integer = CInt(btn.Tag)
        MessageBox.Show("Edit Pengguna ID: " & idUser)
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idUser As Integer = CInt(btn.Tag)

        If MessageBox.Show("Yakin ingin menghapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql = "DELETE FROM tbluser WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", idUser)
                cmd.ExecuteNonQuery()
            End Using
            LoadDataPengguna(TextBox1.Text)
        End If
    End Sub
End Class
