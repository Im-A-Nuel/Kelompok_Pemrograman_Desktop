Module program
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Cek apakah file session ada
        If System.IO.File.Exists("session.txt") Then
            Dim lines() As String = System.IO.File.ReadAllLines("session.txt")
            If lines.Length = 2 Then
                LoggedInUsername = lines(0)
                LoggedInRole = lines(1)

                ' Jalankan form utama langsung
                Application.Run(New Main())
                Return
            End If
        End If

        ' Kalau gak ada session, buka form login
        Application.Run(New Login())
    End Sub
End Module
