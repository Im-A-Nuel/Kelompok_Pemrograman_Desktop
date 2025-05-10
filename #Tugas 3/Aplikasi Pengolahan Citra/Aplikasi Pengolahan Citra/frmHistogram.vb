Public Class frmHistogram
    Private Sub frmHistogram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r, g, b, max As Integer
        Dim hR, hG, hB As Integer
        Dim bmp = New Bitmap(frmUtama.PictureBox1.Image)
        Dim frekR(256), frekG(256), frekB(256) As Integer
        For i As Integer = 0 To 255
            frekR(i) = 0
            frekG(i) = 0
            frekB(i) = 0
        Next
        For bar As Integer = 1 To frmUtama.PictureBox1.Image.Height - 2
            For kol As Integer = 1 To frmUtama.PictureBox1.Image.Width - 2
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                frekR(r) = frekR(r) + 1
                frekG(g) = frekG(g) + 1
                frekB(b) = frekB(b) + 1
            Next
        Next
        Dim histo = New Bitmap(256, 200)
        max = 0
        For i As Integer = 0 To 255
            If frekR(i) > max Then max = frekR(i)
            If frekG(i) > max Then max = frekG(i)
            If frekB(i) > max Then max = frekB(i)
        Next
        For i As Integer = 0 To 255
            hR = Math.Round(frekR(i) / max * 199)
            hG = Math.Round(frekG(i) / max * 199)
            hB = Math.Round(frekB(i) / max * 199)
            If hR > 199 Then hR = 199
            If hG > 199 Then hG = 199
            If hB > 199 Then hB = 199
            histo.SetPixel(i, 199 - hR, Color.Red)
            histo.SetPixel(i, 199 - hG, Color.Green)
            histo.SetPixel(i, 199 - hB, Color.Blue)
        Next
        PictureBox1.Image = histo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class