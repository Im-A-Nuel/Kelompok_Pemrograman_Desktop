Imports MySql.Data.MySqlClient

Public Class tambah_user
    Public Mode As String = "tambah"
    Public RefreshCallback As Action

    Private Sub LoadDataBarang()
        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql = "SELECT * FROM tblbarang WHERE id = @id"
    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtNama.Text = "" Or cbRole.Text = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = "INSERT INTO tbluser (username, password, nama_lengkap, role) VALUES (@username, @password, @nama, @role)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text))
                cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                cmd.Parameters.AddWithValue("@role", cbRole.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("User berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If RefreshCallback IsNot Nothing Then RefreshCallback.Invoke()

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class