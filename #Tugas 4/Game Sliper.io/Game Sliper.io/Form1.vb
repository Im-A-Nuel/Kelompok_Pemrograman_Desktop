Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1

    Dim path As String = AppDomain.CurrentDomain.BaseDirectory
    Dim imageHome As Image

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageHome = Image.FromFile(path & "\asset\logo.jpg")
        picLogo.Image = New Bitmap(picLogo.Width, picLogo.Height)

        Using g As Graphics = Graphics.FromImage(picLogo.Image)
            g.DrawImage(imageHome, 0, 0, picLogo.Width, picLogo.Height)
        End Using
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class