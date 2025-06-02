Imports MySql.Data.MySqlClient

Public Class UC_BarangKeluar

    Private Sub UC_BarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarangKeluar("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadDataBarangKeluar(TextBox1.Text)
    End Sub

    Private Sub LoadDataBarangKeluar(keyword As String)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("NamaBarang", "Nama Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Kategori", "Kategori")
        DataGridView1.Columns.Add("Tanggal", "Tanggal")
        DataGridView1.Columns.Add("Aksi", "Aksi") ' Tambahkan kolom aksi

        Dim colEdit As New DataGridViewButtonColumn()
        colEdit.HeaderText = "Edit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(colEdit)

        Dim colHapus As New DataGridViewButtonColumn()
        colHapus.HeaderText = "Hapus"
        colHapus.Text = "Hapus"
        colHapus.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(colHapus)

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql As String =
            "SELECT bk.id, b.nama_barang, bk.jumlah, b.kategori, bk.tanggal, bk.aksi
             FROM barang_keluar bk 
             JOIN tblbarang b ON bk.id_barang = b.id 
             WHERE b.nama_barang LIKE @key OR b.kategori LIKE @key OR bk.tanggal LIKE @key"

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Using reader = cmd.ExecuteReader()
                Dim no = 1
                While reader.Read()
                    Dim rowIndex = DataGridView1.Rows.Add(
                        no,
                        reader("nama_barang").ToString(),
                        reader("jumlah").ToString(),
                        reader("kategori").ToString(),
                        CDate(reader("tanggal")).ToString("dd-MM-yyyy"),
                        reader("aksi").ToString()
                    )
                    DataGridView1.Rows(rowIndex).Tag = reader("id")
                    no += 1
                End While

            End Using
        End Using
        conn.Close()

        Dim minRowCount As Integer = 11
        Dim dataRowCount As Integer = DataGridView1.Rows.Count
        If dataRowCount < minRowCount Then
            For i As Integer = 1 To (minRowCount - dataRowCount)
                Dim idx As Integer = DataGridView1.Rows.Add()
                With DataGridView1.Rows(idx)
                    .Cells("No").Value = ""
                    .Cells("NamaBarang").Value = ""
                    .Cells("Jumlah").Value = ""
                    .Cells("Kategori").Value = ""
                    .Cells("Tanggal").Value = ""
                    .Cells("Aksi").Value = ""
                    .Cells(6).Value = ""
                    .Cells(7).Value = ""
                    .Tag = Nothing
                End With
            Next
        End If

        With DataGridView1
            .Font = New Font("Segoe UI", 9)
            .RowTemplate.Height = 32

            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(62, 82, 142)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
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
            .Columns("Jumlah").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Aksi").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub ' Pastikan bukan header

        ' Cek apakah baris tersebut punya data (NamaBarang tidak kosong)
        If String.IsNullOrEmpty(DataGridView1.Rows(e.RowIndex).Cells("NamaBarang").Value?.ToString()) Then
            Exit Sub
        End If

        ' Ambil ID dari Tag baris
        Dim idBarangKeluar As Integer = 0
        If DataGridView1.Rows(e.RowIndex).Tag IsNot Nothing Then
            idBarangKeluar = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Tag)
        End If

        If idBarangKeluar = 0 Then
            MessageBox.Show("ID data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Cek tombol yang diklik berdasarkan kolom
        If e.ColumnIndex = 6 Then ' Kolom Edit
            Dim frm As New Tambah_Barang_Keluar()
            frm.IsEditMode = True
            frm.EditID = idBarangKeluar
            frm.ShowDialog()

            ' Reload data setelah edit
            LoadDataBarangKeluar(TextBox1.Text)

        ElseIf e.ColumnIndex = 7 Then ' Kolom Hapus
            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim sql = "DELETE FROM barang_keluar WHERE id = @id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", idBarangKeluar)
                    cmd.ExecuteNonQuery()
                End Using
                conn.Close()

                ' Reload data setelah hapus
                LoadDataBarangKeluar(TextBox1.Text)
            End If
        End If
    End Sub


    Private Function GetIdBarangKeluarByNamaBarang(namaBarang As String) As Integer
        Dim sql As String = "SELECT barang_keluar.id FROM barang_keluar " &
                            "INNER JOIN tblbarang ON barang_keluar.id_barang = tblbarang.id " &
                            "WHERE tblbarang.nama_barang = @namaBarang LIMIT 1"

        If conn.State = ConnectionState.Closed Then conn.Open()

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@namaBarang", namaBarang)
            Dim result = cmd.ExecuteScalar()
            conn.Close()
            Return If(result IsNot Nothing, CInt(result), 0)
        End Using
    End Function

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.RowIndex >= 0 Then
            Dim isDummyRow As Boolean = String.IsNullOrEmpty(DataGridView1.Rows(e.RowIndex).Cells("NamaBarang").Value?.ToString())
            If isDummyRow AndAlso (e.ColumnIndex = 6 OrElse e.ColumnIndex = 7) Then
                e.PaintBackground(e.CellBounds, True)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnAddBarangKeluar_Click(sender As Object, e As EventArgs) Handles btnAddBarangKeluar.Click
        Dim frm As New Tambah_Barang_Keluar()
        frm.ShowDialog()
        LoadDataBarangKeluar(TextBox1.Text)
    End Sub

End Class
