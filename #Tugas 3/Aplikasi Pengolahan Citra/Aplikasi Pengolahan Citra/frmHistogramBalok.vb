Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmHistogramBalok
    Public Property Gambar As Bitmap

    Private Sub frmHistogramBalok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Gambar Is Nothing Then
            MessageBox.Show("Gambar tidak ditemukan.")
            Return
        End If

        Dim histogramR(255) As Integer
        Dim histogramG(255) As Integer
        Dim histogramB(255) As Integer

        For y As Integer = 0 To Gambar.Height - 1
            For x As Integer = 0 To Gambar.Width - 1
                Dim warna As Color = Gambar.GetPixel(x, y)
                histogramR(warna.R) += 1
                histogramG(warna.G) += 1
                histogramB(warna.B) += 1
            Next
        Next

        With Chart1
            .Series.Clear()
            .ChartAreas(0).AxisX.Interval = 5

            .Series.Add("Red")
            .Series("Red").ChartType = SeriesChartType.Column
            .Series("Red").Color = Color.Red

            .Series.Add("Green")
            .Series("Green").ChartType = SeriesChartType.Column
            .Series("Green").Color = Color.Green

            .Series.Add("Blue")
            .Series("Blue").ChartType = SeriesChartType.Column
            .Series("Blue").Color = Color.Blue
        End With

        For i As Integer = 73 To 100
            Chart1.Series("Red").Points.AddXY(i, histogramR(i))
            Chart1.Series("Green").Points.AddXY(i, histogramG(i))
            Chart1.Series("Blue").Points.AddXY(i, histogramB(i))
        Next
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class
