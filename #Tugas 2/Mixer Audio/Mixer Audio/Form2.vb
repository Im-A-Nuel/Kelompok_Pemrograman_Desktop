Public Class Form2
    Private Sub btnAplly_Click(sender As Object, e As EventArgs) Handles btnAplly.Click
        Dim hours As Integer = CInt(txtHour.Value)
        Dim minutes As Integer = CInt(txtMinute.Value)
        Form1.SetCountdownTime(hours, minutes)
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtHour.Value = 0
        txtMinute.Value = 0
    End Sub
End Class
