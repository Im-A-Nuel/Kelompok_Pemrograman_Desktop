Module Program
    <STAThread()>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Loop login -> main
        While True
            Using loginForm As New Login()
                If loginForm.ShowDialog() = DialogResult.OK Then
                    Application.Run(New Main())
                    ' Setelah Main di-close, jika ingin logout dan kembali ke login, hapus session.txt di Main sebelum close
                    Exit While
                Else
                    ' Jika login tidak berhasil (Cancel/Close), aplikasi keluar
                    Exit While
                End If
            End Using
        End While
    End Sub
End Module
