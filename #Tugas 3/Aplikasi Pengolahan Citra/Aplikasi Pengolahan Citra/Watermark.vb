Public Class Watermark

    Public Property WatermarkText As String
    Public Property WatermarkFont As Font
    Public Property WatermarkColor As Color


    Private Sub Watermark_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtWatermark.Text) Then
            MessageBox.Show("Masukkan teks watermark!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        WatermarkText = txtWatermark.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class