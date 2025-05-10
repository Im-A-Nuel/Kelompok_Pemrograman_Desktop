Public Class frmHistogramBalok
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub frmHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r, g, b, max As Integer
        Dim hR, hG, hB As Integer
        Dim bmp = New Bitmap(frmUtama.PictureBox1.Image)
        Dim frekR(255), frekG(255), frekB(255) As Integer

        ' Hitung frekuensi setiap intensitas warna
        For bar As Integer = 0 To bmp.Height - 1
            For kol As Integer = 0 To bmp.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                frekR(r) += 1
                frekG(g) += 1
                frekB(b) += 1
            Next
        Next

        ' Tentukan nilai maksimum frekuensi
        max = frekR.Max()
        max = Math.Max(max, frekG.Max())
        max = Math.Max(max, frekB.Max())

        ' Gambar histogram sebagai blok
        Dim histoWidth As Integer = 256
        Dim histoHeight As Integer = 200
        Dim histo = New Bitmap(histoWidth, histoHeight)
        Dim gHisto As Graphics = Graphics.FromImage(histo)
        gHisto.Clear(Color.White)

        For i As Integer = 0 To 255
            hR = CInt(frekR(i) / max * histoHeight)
            hG = CInt(frekG(i) / max * histoHeight)
            hB = CInt(frekB(i) / max * histoHeight)

            ' Gambar blok histogram dengan tinggi proporsional
            If hR > 0 Then gHisto.FillRectangle(Brushes.Red, i, histoHeight - hR, 1, hR)
            If hG > 0 Then gHisto.FillRectangle(Brushes.Green, i, histoHeight - hG, 1, hG)
            If hB > 0 Then gHisto.FillRectangle(Brushes.Blue, i, histoHeight - hB, 1, hB)
        Next

        PictureBox1.Image = histo
    End Sub
End Class