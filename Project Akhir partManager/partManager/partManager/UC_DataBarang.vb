Imports MySql.Data.MySqlClient

Public Class UC_DataBarang

    Private Sub UC_DataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarang("")
    End Sub

    Private Sub LoadDataBarang(keyword As String)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("nama_barang", "Nama Barang")
        DataGridView1.Columns.Add("kategori", "Kategori")

        Dim editButton As New DataGridViewButtonColumn()
        editButton.HeaderText = "Edit"
        editButton.Text = "Edit"
        editButton.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(editButton)

        Dim hapusButton As New DataGridViewButtonColumn()
        hapusButton.HeaderText = "Hapus"
        hapusButton.Text = "Hapus"
        hapusButton.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(hapusButton)

        If conn.State = ConnectionState.Closed Then conn.Open()

        ' Perbaikan di sini: pakai parameter untuk search keyword
        Dim sql = "SELECT * FROM tblbarang WHERE nama_barang LIKE @keyword OR kategori LIKE @keyword"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Using reader = cmd.ExecuteReader()
                Dim no = 1
                While reader.Read()
                    DataGridView1.Rows.Add(
                   no,
                   reader("nama_barang").ToString(),
                   reader("kategori").ToString()
                )
                    no += 1
                End While
            End Using
        End Using

        Dim minRowCount As Integer = 11
        Dim dataRowCount As Integer = DataGridView1.Rows.Count

        If dataRowCount < minRowCount Then
            For i As Integer = 1 To (minRowCount - dataRowCount)
                Dim idx As Integer = DataGridView1.Rows.Add()
                With DataGridView1.Rows(idx)
                    .Cells("No").Value = ""
                    .Cells("nama_barang").Value = ""
                    .Cells("kategori").Value = ""
                    .Cells(3).Value = ""
                    .Cells(4).Value = ""
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





    Private Sub EditBarang(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idBarang As Integer = CInt(btn.Tag)
        Dim frm As New Tambah_Barang()
        frm.Mode = "Edit"
        frm.BarangID = idBarang
        frm.RefreshCallback = Sub() LoadDataBarang(txtSearch.Text)
        frm.ShowDialog()
    End Sub

    Private Sub HapusBarang(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idBarang As Integer = CInt(btn.Tag)

        If MessageBox.Show("Yakin ingin menghapus barang ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql = "DELETE FROM tblbarang WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", idBarang)
                cmd.ExecuteNonQuery()
            End Using
            LoadDataBarang(txtSearch.Text)
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs)
        LoadDataBarang(txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDataBarang(txtSearch.Text)
    End Sub


    Private Sub btnAddBarang_Click(sender As Object, e As EventArgs) Handles btnAddBarang.Click
        Dim frm As New Tambah_Barang()
        frm.Mode = "Add"
        frm.RefreshCallback = Sub() LoadDataBarang(txtSearch.Text)
        frm.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        If String.IsNullOrEmpty(DataGridView1.Rows(e.RowIndex).Cells("nama_barang").Value?.ToString()) Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim namaBarang As String = row.Cells("nama_barang").Value.ToString()

        If e.ColumnIndex = 3 Then
            Dim idBarang As Integer = GetIdBarangByNama(namaBarang)
            Dim frm As New Tambah_Barang()
            frm.Mode = "Edit"
            frm.BarangID = idBarang
            frm.RefreshCallback = Sub() LoadDataBarang(txtSearch.Text)
            frm.ShowDialog()
        End If

        If e.ColumnIndex = 4 Then
            Dim idBarang As Integer = GetIdBarangByNama(namaBarang)
            If AdaTransaksiBarang(idBarang) Then
                MessageBox.Show("Barang tidak bisa dihapus karena sudah digunakan di transaksi Barang Masuk/Keluar.", "Tidak Bisa Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Yakin ingin menghapus barang ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim sql = "DELETE FROM tblbarang WHERE id = @id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", idBarang)
                    cmd.ExecuteNonQuery()
                End Using
                LoadDataBarang(txtSearch.Text)
            End If
        End If

    End Sub



    Private Function GetIdBarangByNama(nama As String) As Integer
        Dim sql = "SELECT id FROM tblbarang WHERE nama_barang = @nama LIMIT 1"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nama", nama)
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, CInt(result), 0)
        End Using
    End Function


    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.RowIndex >= 0 Then
            Dim isDummyRow As Boolean = String.IsNullOrEmpty(DataGridView1.Rows(e.RowIndex).Cells("nama_barang").Value?.ToString())
            If isDummyRow AndAlso (e.ColumnIndex = 3 OrElse e.ColumnIndex = 4) Then
                e.PaintBackground(e.CellBounds, True)
                e.Handled = True
            End If
        End If
    End Sub

    Private Function AdaTransaksiBarang(idBarang As Integer) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM barang_masuk WHERE id_barang=@id UNION ALL SELECT COUNT(*) FROM barang_keluar WHERE id_barang=@id"
        Dim total As Integer = 0
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", idBarang)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    If reader(0) > 0 Then Return True
                End While
            End Using
        End Using
        Return False
    End Function


End Class
