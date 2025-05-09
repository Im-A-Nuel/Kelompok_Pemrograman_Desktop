Public Class OpsiBorder

    Public Property WarnaBorder As Color
    Public Property KetebalanBorder As Integer

    Private Sub OpsiBorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbWarnaBorder.Items.AddRange({"Merah", "Hijau", "Biru", "Hitam", "Putih"})
        cbWarnaBorder.SelectedIndex = 0


        For i As Integer = 1 To 100
            cbTebalBorder.Items.Add(i & " px")
        Next
        cbTebalBorder.SelectedIndex = 0
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Select Case cbWarnaBorder.SelectedItem.ToString()
            Case "Merah" : WarnaBorder = Color.Red
            Case "Hijau" : WarnaBorder = Color.Green
            Case "Biru" : WarnaBorder = Color.Blue
            Case "Hitam" : WarnaBorder = Color.Black
            Case "Putih" : WarnaBorder = Color.White
        End Select

        KetebalanBorder = Integer.Parse(cbTebalBorder.SelectedItem.ToString().Substring(0, 1))

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


End Class