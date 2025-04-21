Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Dim role As String = Login(txtUsername.Text, txtPassword.Text)

        If role = "admin" OrElse role = "karyawan" OrElse role = "manajer" Then
            MessageBox.Show("Login sebagai " & role)

            SaveSessionToFile(txtUsername.Text, role)

            LoggedInUsername = txtUsername.Text
            LoggedInRole = role


            Dim mainForm As New Main()
            mainForm.Show()


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

    Private Sub SaveSessionToFile(username As String, role As String)
        Dim lines() As String = {username, role}
        System.IO.File.WriteAllLines("session.txt", lines)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()

        If Main.IsLoggedIn Then
            Me.Hide()
            Return
        End If

        If System.IO.File.Exists("session.txt") Then
            Dim lines() As String = System.IO.File.ReadAllLines("session.txt")
            If lines.Length = 2 Then
                LoggedInUsername = lines(0)
                LoggedInRole = lines(1)

                Dim mainForm As New Main()
                mainForm.Show()

                Main.IsLoggedIn = True

                Me.Hide()
                Me.Opacity = 0
            End If
        End If
    End Sub


    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnMasuk.PerformClick()
        End If
    End Sub


    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub

End Class
