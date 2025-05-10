Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmUtama
    Private gambarAseli As Bitmap
    Dim namafile As String = ""

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim img = Image.FromFile(openFileDialog1.FileName)
            If img Is Nothing Then
                MessageBox.Show("Gambar tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            PictureBox1.Image = img
            namafile = openFileDialog1.FileName

            tbRed.Minimum = -128
            tbRed.Maximum = 128
            tbRed.Value = 0

            tbGreen.Minimum = -128
            tbGreen.Maximum = 128
            tbGreen.Value = 0

            tbBlue.Minimum = -128
            tbBlue.Maximum = 128
            tbBlue.Value = 0
        End If
    End Sub



    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image
        MyPicture = PictureBox1.Image

        saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(saveFileDialog1.FileName,
                System.Drawing.Imaging.ImageFormat.Bmp)
            End If
            If saveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(saveFileDialog1.FileName,
                System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
    End Sub

    Private Sub PropertiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiToolStripMenuItem.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " + PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " + PictureBox1.Image.Height.ToString)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GreyscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyscaleToolStripMenuItem.Click


        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim r, g, b, gray As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    r = bmp.GetPixel(kol, bar).R
                    g = bmp.GetPixel(kol, bar).G
                    b = bmp.GetPixel(kol, bar).B
                    gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                    bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
                Next
            Next
            PictureBox1.Image = bmp
        End If

    End Sub

    Private Sub CerahkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerahkanToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim r, g, b As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)
            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    r = bmp.GetPixel(kol, bar).R + 10
                    g = bmp.GetPixel(kol, bar).G + 10
                    b = bmp.GetPixel(kol, bar).B + 10
                    If r > 255 Then r = 255
                    If g > 255 Then g = 255
                    If b > 255 Then b = 255
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
                Next
            Next

            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub GelapkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GelapkanToolStripMenuItem.Click


        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim r, g, b As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    r = bmp.GetPixel(kol, bar).R - 10
                    g = bmp.GetPixel(kol, bar).G - 10
                    b = bmp.GetPixel(kol, bar).B - 10
                    If r < 0 Then r = 0
                    If g < 0 Then g = 0
                    If b < 0 Then b = 0
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub TambahKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKontrasToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim r, g, b As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    r = bmp.GetPixel(kol, bar).R
                    g = bmp.GetPixel(kol, bar).G
                    b = bmp.GetPixel(kol, bar).B
                    r = Math.Round(128 + (1.1 * (r - 128)))
                    g = Math.Round(128 + (1.1 * (g - 128)))
                    b = Math.Round(128 + (1.1 * (b - 128)))
                    If r < 0 Then r = 0
                    If g < 0 Then g = 0
                    If b < 0 Then b = 0
                    If r > 255 Then r = 255
                    If g > 255 Then g = 255
                    If b > 255 Then b = 255
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub
    Private Sub KurangiKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KurangiKontrasToolStripMenuItem.Click
        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim r, g, b As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    r = bmp.GetPixel(kol, bar).R
                    g = bmp.GetPixel(kol, bar).G
                    b = bmp.GetPixel(kol, bar).B
                    r = Math.Round(128 + (0.90909 * (r - 128)))
                    g = Math.Round(128 + (0.90909 * (g - 128)))
                    b = Math.Round(128 + (0.90909 * (b - 128)))
                    If r < 0 Then r = 0
                    If g < 0 Then g = 0
                    If b < 0 Then b = 0
                    If r > 255 Then r = 255
                    If g > 255 Then g = 255
                    If b > 255 Then b = 255
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim r, g, b As Integer
            Dim bmp = New Bitmap(namafile)
            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    r = bmp.GetPixel(kol, bar).R
                    g = bmp.GetPixel(kol, bar).G
                    b = bmp.GetPixel(kol, bar).B
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
                Next
            Next
            PictureBox1.Image = bmp

        End If
    End Sub

    Private Sub TampilkanHistgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilkanHistgramToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            frmHistogram.ShowDialog()

        End If
    End Sub

    Private Sub TajamkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TajamkanToolStripMenuItem.Click


        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim r, g, b As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)
            Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}

            For bar As Integer = 1 To PictureBox1.Image.Height - 2
                For kol As Integer = 1 To PictureBox1.Image.Width - 2
                    r = 0
                    g = 0
                    b = 0
                    For i As Integer = 0 To 8
                        r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                        g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                        b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                    Next
                    r = Math.Floor(r / 3)
                    g = Math.Floor(g / 3)
                    b = Math.Floor(b / 3)
                    If r < 0 Then r = 0
                    If g < 0 Then g = 0
                    If b < 0 Then b = 0
                    If r > 255 Then r = 255
                    If g > 255 Then g = 255
                    If b > 255 Then b = 255
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
                Next
            Next

            PictureBox1.Image = bmp

        End If
    End Sub

    Private Sub KaburkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaburkanToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim r, g, b As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)
            Dim kernel As Integer() = {1, 1, 1, 1, 1, 1, 1, 1, 1}

            For bar As Integer = 1 To PictureBox1.Image.Height - 2
                For kol As Integer = 1 To PictureBox1.Image.Width - 2
                    r = 0
                    g = 0
                    b = 0
                    For i As Integer = 0 To 8
                        r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                        g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                        b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                    Next
                    r = Math.Floor(r / 9)
                    g = Math.Floor(g / 9)
                    b = Math.Floor(b / 9)
                    If r < 0 Then r = 0
                    If g < 0 Then g = 0
                    If b < 0 Then b = 0
                    If r > 255 Then r = 255
                    If g > 255 Then g = 255
                    If b > 255 Then b = 255
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
                Next
            Next

            PictureBox1.Image = bmp

        End If
    End Sub

    Private Sub PutarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PutarToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim bmp = New Bitmap(PictureBox1.Image)
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
            PictureBox1.Image = bmp

        End If
    End Sub

    Private Sub FlipHorzontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorzontalToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim original As Bitmap = CType(PictureBox1.Image, Bitmap)
            Dim lebar As Integer = original.Width
            Dim tinggi As Integer = original.Height

            Dim putar As New Bitmap(lebar, tinggi)

            For y As Integer = 0 To Height - 1
                For x As Integer = 0 To Width - 1
                    Dim imgAsli As Color = original.GetPixel(x, y)
                    putar.SetPixel(Width - 1 - x, y, imgAsli)
                Next
            Next

            PictureBox1.Image = putar

        End If

    End Sub

    Private Sub FlipVertikalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipVertikalToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim bmp = New Bitmap(PictureBox1.Image)
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
            PictureBox1.Image = bmp

        End If
    End Sub

    Private Sub UjiKernel3x3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UjiKernel3x3ToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim r, g, b As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)
            Dim kernel As Integer() = {1, 2, 1, 2, 4, 2, 1, 2, 1}

            For bar As Integer = 1 To PictureBox1.Image.Height - 2
                For kol As Integer = 1 To PictureBox1.Image.Width - 2
                    r = 0
                    g = 0
                    b = 0
                    For i As Integer = 0 To 8
                        r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                        g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                        b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                    Next
                    r = Math.Floor(r / 16)
                    g = Math.Floor(g / 16)
                    b = Math.Floor(b / 16)
                    If r < 0 Then r = 0
                    If g < 0 Then g = 0
                    If b < 0 Then b = 0
                    If r > 255 Then r = 255
                    If g > 255 Then g = 255
                    If b > 255 Then b = 255
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
                Next
            Next

            PictureBox1.Image = bmp

        End If
    End Sub

    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim opsi As New OpsiBorder()
            If opsi.ShowDialog() = DialogResult.OK Then
                Dim warna As Color = opsi.WarnaBorder
                Dim ketebalan As Integer = opsi.KetebalanBorder

                Dim original As Bitmap = CType(PictureBox1.Image, Bitmap)
                Dim bmp As New Bitmap(original.Width + 2 * ketebalan, original.Height + 2 * ketebalan)

                Using g As Graphics = Graphics.FromImage(bmp)
                    g.Clear(warna)
                    g.DrawImage(original, ketebalan, ketebalan)
                End Using
                PictureBox1.Image = bmp
            End If

        End If
    End Sub

    Private Sub WatermarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatermarkToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frm As New Watermark()
        If frm.ShowDialog() = DialogResult.OK Then
            Dim img As New Bitmap(PictureBox1.Image)
            Dim teks = frm.WatermarkText
            Dim font = New Font("Arial", 50, FontStyle.Bold)
            Dim brush = New SolidBrush(Color.White)

            Using g As Graphics = Graphics.FromImage(img)
                Dim xStep = 150
                Dim yStep = 100
                For y As Integer = 0 To img.Height Step yStep
                    For x As Integer = 0 To img.Width Step xStep
                        g.DrawString(teks, font, brush, x, y)
                    Next
                Next
            End Using

            PictureBox1.Image = img
        End If

    End Sub

    Private Sub InversiWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversiWarnaToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bmp As New Bitmap(PictureBox1.Image)

        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim pixel As Color = bmp.GetPixel(x, y)
                Dim r As Integer = 255 - pixel.R
                Dim g As Integer = 255 - pixel.G
                Dim b As Integer = 255 - pixel.B
                bmp.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaMerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaMerahToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bmp As New Bitmap(PictureBox1.Image)

        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim pixel As Color = bmp.GetPixel(x, y)
                bmp.SetPixel(x, y, Color.FromArgb(pixel.R, 0, 0))
            Next
        Next

        PictureBox1.Image = bmp

    End Sub

    Private Sub RonaHijauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaHijauToolStripMenuItem.Click


        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim bmp As New Bitmap(PictureBox1.Image)
        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim pixel As Color = bmp.GetPixel(x, y)
                bmp.SetPixel(x, y, Color.FromArgb(0, pixel.G, 0))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaBiruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaBiruToolStripMenuItem.Click

        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim bmp As New Bitmap(PictureBox1.Image)
        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim pixel As Color = bmp.GetPixel(x, y)
                bmp.SetPixel(x, y, Color.FromArgb(0, 0, pixel.B))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaSpesialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaSpesialToolStripMenuItem.Click
        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim bmp As New Bitmap(PictureBox1.Image)
            For y As Integer = 0 To bmp.Height - 1
                For x As Integer = 0 To bmp.Width - 1
                    Dim pixel As Color = bmp.GetPixel(x, y)
                    Dim r As Integer = pixel.R
                    Dim g As Integer = pixel.G
                    Dim b As Integer = pixel.B
                    bmp.SetPixel(x, y, Color.FromArgb(g, b, r))
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub



    Private Sub HistogramToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HistogramToolStripMenuItem1.Click

    End Sub

    Private Sub AdjustColorBalance()
        If namafile.Equals("") Then
            MessageBox.Show("Pilih Gambar terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim original As New Bitmap(namafile)
        Dim bmp As New Bitmap(PictureBox1.Image)

        Dim redOffset As Integer = tbRed.Value
        Dim greenOffset As Integer = tbGreen.Value
        Dim blueOffset As Integer = tbBlue.Value

        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim originalPixel As Color = original.GetPixel(x, y)
                Dim r As Integer = originalPixel.R
                Dim g As Integer = originalPixel.G
                Dim b As Integer = originalPixel.B


                If redOffset > 0 Then
                    r = Math.Min(255, r + redOffset)
                ElseIf redOffset < 0 Then
                    r = Math.Max(0, r + redOffset)
                End If

                If greenOffset > 0 Then
                    g = Math.Min(255, g + greenOffset)
                ElseIf greenOffset < 0 Then
                    g = Math.Max(0, g + greenOffset)
                End If

                If blueOffset > 0 Then
                    b = Math.Min(255, b + blueOffset)
                ElseIf blueOffset < 0 Then
                    b = Math.Max(0, b + blueOffset)
                End If

                bmp.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        PictureBox1.Image = bmp
    End Sub

    Private Sub tbRed_Scroll(sender As Object, e As EventArgs) Handles tbRed.Scroll
        AdjustColorBalance()
    End Sub

    Private Sub tbGreen_Scroll(sender As Object, e As EventArgs) Handles tbGreen.Scroll
        AdjustColorBalance()
    End Sub

    Private Sub tbBlue_Scroll(sender As Object, e As EventArgs) Handles tbBlue.Scroll
        AdjustColorBalance()
    End Sub
End Class

