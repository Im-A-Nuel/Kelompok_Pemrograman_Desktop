Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx
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
        DataGridViewRiwayat.Rows.Clear()
        DataGridViewRiwayat.Columns.Clear()

        Dim headers() As String = {"No", "Nama Barang", "Aksi", "Jumlah", "Tanggal", "User"}
        For Each header As String In headers
            DataGridViewRiwayat.Columns.Add(header, header)
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
                            DataGridViewRiwayat.Rows.Add({
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


        With DataGridViewRiwayat
            .Font = New Font("Segoe UI", 9)
            .RowTemplate.Height = 32
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(62, 82, 142)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .EnableHeadersVisualStyles = False
            .GridColor = Color.FromArgb(220, 220, 220)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 247, 255)
            .RowsDefaultCellStyle.BackColor = Color.White
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 235, 255)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .Columns("No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For Each col As DataGridViewColumn In .Columns
                If TypeOf col Is DataGridViewButtonColumn Then
                    col.DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                    col.DefaultCellStyle.BackColor = Color.FromArgb(230, 243, 255)
                    col.DefaultCellStyle.ForeColor = Color.FromArgb(35, 108, 208)
                End If
            Next
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersHeight = 40
            .RowHeadersVisible = False
        End With
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
                Dim fontRegular As New XFont("Times New Roman", 10, XFontStyle.Regular)
                Dim fontBold As New XFont("Times New Roman", 10, XFontStyle.Bold)

                Dim yPos As Double = 40
                Dim xMargin As Double = 40
                Dim rowHeight As Double = 20

                gfx.DrawString("Laporan Riwayat Stok", New XFont("Times New Roman", 14, XFontStyle.Bold), XBrushes.Black, New XRect(0, yPos, page.Width, 30), XStringFormats.TopCenter)
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

                Dim colCount As Integer = DataGridViewRiwayat.ColumnCount
                Dim colWidth As Double = (page.Width.Point - 2 * xMargin) / colCount

                ' Header
                For col As Integer = 0 To colCount - 1
                    Dim headerText As String = DataGridViewRiwayat.Columns(col).HeaderText
                    gfx.DrawString(headerText, fontBold, XBrushes.Black, New XRect(xMargin + (col * colWidth), yPos, colWidth, rowHeight), XStringFormats.TopLeft)
                Next
                yPos += rowHeight

                ' Rows
                For Each row As DataGridViewRow In DataGridViewRiwayat.Rows
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
        Dim frmGrafik As New Laporan_Grafik()
        frmGrafik.ShowDialog()
    End Sub
End Class
