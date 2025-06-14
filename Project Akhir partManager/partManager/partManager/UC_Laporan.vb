﻿Imports System.IO
Imports MySql.Data.MySqlClient
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class UC_Laporan

    Private isFiltered As Boolean = False
    Private filterStartDate As Date
    Private filterEndDate As Date

    Private Sub UC_Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isFiltered = False
        LoadData()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        filterStartDate = DateTimePicker1.Value.Date
        filterEndDate = DateTimePicker2.Value.Date
        isFiltered = True
        LoadData(filterStartDate, filterEndDate)
    End Sub

    Private Sub LoadData(Optional startDate As Date = Nothing, Optional endDate As Date = Nothing)
        dataGridViewRiwayat.Rows.Clear()
        dataGridViewRiwayat.Columns.Clear()

        Dim headers() As String = {"No", "Nama Barang", "Aksi", "Jumlah", "Tanggal", "User"}
        For Each header As String In headers
            dataGridViewRiwayat.Columns.Add(header, header)
        Next

        Dim connectionString As String = "Server=127.0.0.1;Database=partmanager;Uid=root;Pwd="
        Dim query As String = "SELECT riwayat_stok.id, tblbarang.nama_barang, aksi, jumlah, tanggal, user_input " &
                              "FROM riwayat_stok INNER JOIN tblbarang ON riwayat_stok.id_barang = tblbarang.id"

        If startDate <> Date.MinValue AndAlso endDate <> Date.MinValue Then
            query &= " WHERE tanggal BETWEEN @StartDate AND @EndDate"
        End If

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                If startDate <> Date.MinValue AndAlso endDate <> Date.MinValue Then
                    command.Parameters.AddWithValue("@StartDate", startDate)
                    command.Parameters.AddWithValue("@EndDate", endDate)
                End If

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim no As Integer = 1
                        While reader.Read()
                            dataGridViewRiwayat.Rows.Add({
                                no.ToString(),
                                reader("nama_barang").ToString(),
                                reader("aksi").ToString(),
                                reader("jumlah").ToString(),
                                CDate(reader("tanggal")).ToString("dd-MM-yyyy"),
                                reader("user_input").ToString()
                            })
                            no += 1
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ButtonSavePDF_Click(sender As Object, e As EventArgs) Handles ButtonSavePDF.Click
        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "PDF Files|*.pdf",
            .Title = "Simpan Laporan ke PDF"
        }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New PdfDocument()
                doc.Info.Title = "Laporan Riwayat Stok"
                Dim page As PdfPage = doc.AddPage()
                Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
                Dim fontRegular As New XFont("Times New Roman", 10, XFontStyleEx.Regular)
                Dim fontBold As New XFont("Times New Roman", 10, XFontStyleEx.Bold)

                Dim yPos As Double = 40
                Dim xMargin As Double = 40
                Dim rowHeight As Double = 20

                gfx.DrawString("Laporan Riwayat Stok", New XFont("Times New Roman", 14, XFontStyleEx.Bold), XBrushes.Black, New XRect(0, yPos, page.Width, 30), XStringFormats.TopCenter)
                yPos += 30

                Dim periodeText As String
                If isFiltered Then
                    If filterStartDate = filterEndDate Then
                        periodeText = "Periode: " & filterStartDate.ToString("dd-MM-yyyy")
                    Else
                        periodeText = "Periode: " & filterStartDate.ToString("dd-MM-yyyy") & " s/d " & filterEndDate.ToString("dd-MM-yyyy")
                    End If
                Else
                    periodeText = "Periode: Semua Data"
                End If
                gfx.DrawString(periodeText, fontRegular, XBrushes.Black, New XRect(0, yPos, page.Width, 20), XStringFormats.TopCenter)
                yPos += 30

                Dim colCount As Integer = dataGridViewRiwayat.ColumnCount
                Dim colWidth As Double = (page.Width - 2 * xMargin) / colCount

                ' Header
                For col As Integer = 0 To colCount - 1
                    Dim headerText As String = dataGridViewRiwayat.Columns(col).HeaderText
                    gfx.DrawString(headerText, fontBold, XBrushes.Black, New XRect(xMargin + (col * colWidth), yPos, colWidth, rowHeight), XStringFormats.TopLeft)
                Next
                yPos += rowHeight

                ' Rows
                For Each row As DataGridViewRow In dataGridViewRiwayat.Rows
                    If row.IsNewRow Then Continue For

                    For col As Integer = 0 To colCount - 1
                        Dim text As String = row.Cells(col).Value?.ToString()
                        gfx.DrawString(text, fontRegular, XBrushes.Black, New XRect(xMargin + (col * colWidth), yPos, colWidth, rowHeight), XStringFormats.TopLeft)
                    Next
                    yPos += rowHeight

                    If yPos + rowHeight > page.Height.Point - 40 Then
                        page = doc.AddPage()
                        gfx = XGraphics.FromPdfPage(page)
                        yPos = 40
                    End If
                Next

                doc.Save(saveFileDialog.FileName)
                MessageBox.Show("Laporan berhasil disimpan sebagai PDF.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menyimpan PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnGrafik_Click(sender As Object, e As EventArgs) Handles btnGrafik.Click

    End Sub
End Class
