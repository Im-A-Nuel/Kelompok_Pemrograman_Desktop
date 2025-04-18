Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Dim role As String = Login(txtUsername.Text, txtPassword.Text)
        If role = "admin" Then
            MessageBox.Show("Login sebagai Admin")
            ' Buka form Admin
            Main.Show()
            Me.Hide()
        ElseIf role = "karyawan" Then
            MessageBox.Show("Login sebagai Karyawan")
            ' Buka form Karyawan
            Main.Show()
            Me.Hide()
        ElseIf role = "manager" Then
            MessageBox.Show("Login sebagai Manager")
            ' Buka form Manager
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Public Function Login(username As String, password As String) As String
        Dim role As String = ""

        Try

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "SELECT role FROM tbluser WHERE username=@user AND password=@pass"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                role = reader("role").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return role
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
    End Sub
End Class
