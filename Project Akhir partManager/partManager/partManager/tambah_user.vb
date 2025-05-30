Imports MySql.Data.MySqlClient

Public Class tambah_user
    Public Mode As String = "tambah"
    Public UserID As Integer = 0
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
        If txtUsername.Text = "" Or (Mode = "tambah" And txtPassword.Text = "") Or txtNama.Text = "" Or cbRole.Text = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            If Mode = "edit" AndAlso UserID > 0 Then
                Dim sql As String
                If txtPassword.Text <> "" Then
                    sql = "UPDATE tbluser SET password=@password, nama_lengkap=@nama, role=@role WHERE id=@id"
                Else
                    sql = "UPDATE tbluser SET nama_lengkap=@nama, role=@role WHERE id=@id"
                End If
                Using cmd As New MySqlCommand(sql, conn)
                    If txtPassword.Text <> "" Then
                        cmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text))
                    End If
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                    cmd.Parameters.AddWithValue("@role", cbRole.Text)
                    cmd.Parameters.AddWithValue("@id", UserID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("User berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim sql As String = "INSERT INTO tbluser (username, password, nama_lengkap, role) VALUES (@username, @password, @nama, @role)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text))
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                    cmd.Parameters.AddWithValue("@role", cbRole.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("User berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If RefreshCallback IsNot Nothing Then RefreshCallback.Invoke()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub tambah_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = "edit" AndAlso UserID > 0 Then
            btnTambah.Text = "Update"
            LoadDataUser()
        Else
            btnTambah.Text = "Tambah"
            txtUsername.Enabled = True
        End If
    End Sub

    Private Sub LoadDataUser()
        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql = "SELECT * FROM tbluser WHERE id = @id"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", UserID)
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtUsername.Text = reader("username").ToString()
                    txtNama.Text = reader("nama_lengkap").ToString()
                    cbRole.Text = reader("role").ToString()
                    txtUsername.Enabled = False
                End If
            End Using
        End Using
    End Sub

End Class