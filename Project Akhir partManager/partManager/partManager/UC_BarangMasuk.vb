Imports MySql.Data.MySqlClient

Public Class UC_BarangMasuk

    Private Sub UC_BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarangMasuk("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadDataBarangMasuk(TextBox1.Text)
    End Sub

    Private Sub LoadDataBarangMasuk(keyword As String)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("NamaBarang", "Nama Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Kategori", "Kategori")
        DataGridView1.Columns.Add("Tanggal", "Tanggal")
        DataGridView1.Columns.Add("Supplier", "Supplier")

        Dim btnEdit As New DataGridViewButtonColumn()
        btnEdit.HeaderText = "Edit"
        btnEdit.Text = "Edit"
        btnEdit.UseColumnTextForButtonValue = True
        btnEdit.Width = 60
        DataGridView1.Columns.Add(btnEdit)

        Dim btnHapus As New DataGridViewButtonColumn()
        btnHapus.HeaderText = "Hapus"
        btnHapus.Text = "Hapus"
        btnHapus.UseColumnTextForButtonValue = True
        btnHapus.Width = 60
        DataGridView1.Columns.Add(btnHapus)

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql As String = "SELECT bm.id, b.nama_barang, bm.jumlah, b.kategori, bm.tanggal, bm.supplier " &
                            "FROM barang_masuk bm " &
                            "JOIN tblbarang b ON bm.id_barang = b.id " &
                            "WHERE b.nama_barang LIKE @key OR b.kategori LIKE @key OR bm.tanggal LIKE @key"

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Using reader = cmd.ExecuteReader()
                Dim no = 1
                While reader.Read()
                    Dim idx As Integer = DataGridView1.Rows.Add(no,
                        reader("nama_barang").ToString(),
                        reader("jumlah").ToString(),
                        reader("kategori").ToString(),
                        Convert.ToDateTime(reader("tanggal")).ToString("dd-MM-yyyy"),
                        reader("supplier").ToString())
                    DataGridView1.Rows(idx).Tag = reader("id")
                    no += 1
                End While
            End Using
        End Using

        ' Dummy rows
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
                    .Cells("Supplier").Value = ""
                    .Cells(6).Value = ""
                    .Cells(7).Value = ""
                    .Tag = Nothing
                End With
            Next
        End If

        ' Gaya
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
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersHeight = 40
            .RowHeadersVisible = False

            For Each col As DataGridViewColumn In .Columns
                If TypeOf col Is DataGridViewButtonColumn Then
                    col.DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                    col.DefaultCellStyle.BackColor = Color.FromArgb(230, 243, 255)
                    col.DefaultCellStyle.ForeColor = Color.FromArgb(35, 108, 208)
                End If
            Next
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If String.IsNullOrEmpty(DataGridView1.Rows(e.RowIndex).Cells("NamaBarang").Value?.ToString()) Then Exit Sub

        Dim idBarangMasuk As Integer = 0
        If DataGridView1.Rows(e.RowIndex).Tag IsNot Nothing Then
            idBarangMasuk = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Tag)
        End If

        If idBarangMasuk = 0 Then
            MessageBox.Show("ID data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If e.ColumnIndex = 6 Then
            Dim frm As New Re_Stock()
            frm.Mode = "Edit"
            frm.BarangMasukID = idBarangMasuk
            frm.ShowDialog()
            LoadDataBarangMasuk(TextBox1.Text)
        ElseIf e.ColumnIndex = 7 Then
            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim sql = "DELETE FROM barang_masuk WHERE id = @id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", idBarangMasuk)
                    cmd.ExecuteNonQuery()
                End Using
                LoadDataBarangMasuk(TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub btnReStock_Click(sender As Object, e As EventArgs) Handles btnReStock.Click
        Dim frm As New Re_Stock()
        frm.ShowDialog()
        LoadDataBarangMasuk(TextBox1.Text)
    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.RowIndex >= 0 Then
            Dim isDummyRow As Boolean = String.IsNullOrEmpty(DataGridView1.Rows(e.RowIndex).Cells("NamaBarang").Value?.ToString())
            If isDummyRow AndAlso (e.ColumnIndex = 6 OrElse e.ColumnIndex = 7) Then
                e.PaintBackground(e.CellBounds, True)
                e.Handled = True
            End If
        End If
    End Sub

End Class
