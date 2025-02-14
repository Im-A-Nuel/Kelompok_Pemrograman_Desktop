Public Class Form1
    Private Sub pbPlay_Click(sender As Object, e As EventArgs) Handles pbPlay.Click


        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()

    End Sub
End Class
