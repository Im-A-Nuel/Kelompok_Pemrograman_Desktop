Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module ModuleDatabase
    Public conn As MySqlConnection

    Public Sub ConnectDB()
        Dim connectionString As String = "server=127.0.0.1;port=3306;user id=root;password=;database=partmanager"


        conn = New MySqlConnection(connectionString)

        Try
            conn.Open()
            Console.WriteLine("Koneksi ke MySQL berhasil!")
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Module
