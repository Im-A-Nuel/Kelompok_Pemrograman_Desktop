Imports System.Data.SqlClient
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Login

    Private isLoginSuccess As Boolean = False

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Dim role As String = Login(txtUsername.Text, txtPassword.Text)

        If role = "admin" OrElse role = "karyawan" OrElse role = "manajer" Then
            ' Set variable session
            SaveSessionToFile(txtUsername.Text, role)
            LoggedInUsername = txtUsername.Text
            LoggedInRole = role
            ModAuth.CurrentUserName = txtUsername.Text
            ModAuth.CurrentUserRole = role

            Me.Hide()
            Dim mainForm As New Main()
            mainForm.ShowDialog()
            Me.Show()
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
            'cmd.Parameters.AddWithValue("@pass", password)
            cmd.Parameters.AddWithValue("@pass", HashPassword(password))

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

    Private Function HashPassword(password As String) As String
        Using sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
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
            LoggedInUsername = lines(0)
            LoggedInRole = lines(1)
            ModAuth.CurrentUserName = LoggedInUsername
            ModAuth.CurrentUserRole = LoggedInRole

            Dim mainForm As New Main()
            Me.Hide()
            mainForm.ShowDialog()
            'Me.Show()                   
            Exit Sub
        End If
    End Sub



    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnMasuk.PerformClick()
        End If
    End Sub


    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isLoginSuccess Then
            ' Biarkan close tanpa konfirmasi jika login berhasil
            Return
        End If

        'Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If result <> DialogResult.Yes Then
        '    e.Cancel = True
        'End If
    End Sub


End Class
