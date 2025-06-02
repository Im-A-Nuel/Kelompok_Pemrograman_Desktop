Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Laporan_Grafik

    Private connectionString As String = "Server=127.0.0.1;Database=partmanager;Uid=root;Pwd="

    Private Sub Laporan_Grafik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbJenisKeluar.Items.Clear()
        cbJenisKeluar.Items.AddRange(New Object() {"Semua", "Penjualan", "Pemakaian", "Transfer", "Rusak", "Lain-lain"})
        cbJenisKeluar.SelectedIndex = 0

        AddHandler cbJenisKeluar.SelectedIndexChanged, AddressOf cbJenisKeluar_SelectedIndexChanged

        LoadChartData("Semua")
    End Sub

    Private Sub cbJenisKeluar_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim kategori As String = cbJenisKeluar.SelectedItem.ToString()
        LoadChartData(kategori)
    End Sub

    Private Sub LoadChartData(kategori As String)
        Dim dt As New DataTable()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim query As String = ""
                Dim titleText As String = ""
                If kategori = "Semua" Then
                    titleText = "Grafik Barang Masuk dan Keluar (Semua Jenis)"
                    query = "
                        SELECT
                            b.nama_barang,
                            IFNULL(SUM(bm.jumlah), 0) AS total_masuk,
                            IFNULL(SUM(bk.jumlah), 0) AS total_keluar
                        FROM tblbarang b
                        LEFT JOIN barang_masuk bm ON b.id = bm.id_barang
                        LEFT JOIN barang_keluar bk ON b.id = bk.id_barang
                        GROUP BY b.nama_barang
                        ORDER BY (IFNULL(SUM(bm.jumlah),0) + IFNULL(SUM(bk.jumlah),0)) DESC
                        LIMIT 20;
                    "
                Else
                    titleText = $"Grafik Barang Keluar: {kategori}"
                    query = "
                        SELECT
                            b.nama_barang,
                            IFNULL(SUM(bk.jumlah), 0) AS total_keluar
                        FROM tblbarang b
                        LEFT JOIN barang_keluar bk ON b.id = bk.id_barang
                        WHERE bk.aksi = @kategori
                        GROUP BY b.nama_barang
                        ORDER BY total_keluar DESC
                        LIMIT 20;
                    "
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If kategori <> "Semua" Then
                        cmd.Parameters.AddWithValue("@kategori", kategori)
                    End If
                    conn.Open()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using

            ' Bersihkan chart dulu
            Chart1.Series.Clear()
            Chart1.Titles.Clear()
            Chart1.Legends.Clear()

            ' Tambah title dinamis
            Chart1.Titles.Add(kategori)
            Chart1.Titles(0).Font = New Font("Segoe UI", 14, FontStyle.Bold)

            ' Setup legend
            Dim legend As New Legend()
            legend.Docking = Docking.Top
            legend.Alignment = StringAlignment.Center
            legend.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            Chart1.Legends.Add(legend)

            ' Setup Chart Area
            With Chart1.ChartAreas(0)
                .AxisX.Title = "Nama Barang"
                .AxisX.TitleFont = New Font("Segoe UI", 11, FontStyle.Bold)
                .AxisX.LabelStyle.Angle = -45
                .AxisX.Interval = 1
                .AxisX.MajorGrid.LineColor = Color.LightGray

                .AxisY.Title = "Jumlah"
                .AxisY.TitleFont = New Font("Segoe UI", 11, FontStyle.Bold)
                .AxisY.MajorGrid.LineColor = Color.LightGray
            End With

            If kategori = "Semua" Then
                Dim seriesMasuk As New Series("Barang Masuk") With {
                    .ChartType = SeriesChartType.Column,
                    .Color = Color.FromArgb(62, 130, 247)
                }
                Dim seriesKeluar As New Series("Barang Keluar") With {
                    .ChartType = SeriesChartType.Column,
                    .Color = Color.FromArgb(237, 125, 49)
                }

                For Each row As DataRow In dt.Rows
                    seriesMasuk.Points.AddXY(row("nama_barang").ToString(), Convert.ToInt32(row("total_masuk")))
                    seriesKeluar.Points.AddXY(row("nama_barang").ToString(), Convert.ToInt32(row("total_keluar")))
                Next

                Chart1.Series.Add(seriesMasuk)
                Chart1.Series.Add(seriesKeluar)
            Else
                Dim seriesKeluar As New Series("Jumlah Keluar") With {
                    .ChartType = SeriesChartType.Column,
                    .Color = Color.FromArgb(237, 125, 49)
                }

                For Each row As DataRow In dt.Rows
                    seriesKeluar.Points.AddXY(row("nama_barang").ToString(), Convert.ToInt32(row("total_keluar")))
                Next

                Chart1.Series.Add(seriesKeluar)
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data grafik: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
