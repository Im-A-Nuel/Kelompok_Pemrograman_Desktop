Imports MySql.Data.MySqlClient

Public Class UC_DataBarang

    Private Sub UC_DataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarang("")
    End Sub

    Private Sub LoadDataBarang(keyword As String)
        ' Kosongkan isi TableLayoutPanel1 dulu
        For i = TableLayoutPanel1.RowCount - 1 To 3 Step -1
            For Each ctrl As Control In TableLayoutPanel1.Controls
                If TableLayoutPanel1.GetRow(ctrl) = i Then
                    TableLayoutPanel1.Controls.Remove(ctrl)
                End If
            Next
            TableLayoutPanel1.RowStyles.RemoveAt(i)
            TableLayoutPanel1.RowCount -= 1
        Next

        ' Koneksi dan query
        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql = "SELECT * FROM tblbarang WHERE nama_barang LIKE @keyword OR kategori LIKE @keyword"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
            Using reader = cmd.ExecuteReader()
                Dim rowIndex = 3
                Dim no = 1

                While reader.Read()
                    TableLayoutPanel1.RowCount += 1
                    TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50))

                    ' Data barang
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = no.ToString()}, 0, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("nama_barang").ToString()}, 1, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("stok").ToString()}, 2, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("harga").ToString()}, 3, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("kategori").ToString()}, 4, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = Convert.ToDateTime(reader("tanggal_masuk")).ToShortDateString()}, 5, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("supplier").ToString()}, 6, rowIndex)

                    ' Tombol Edit
                    Dim btnEdit As New Button With {.Text = "Edit", .Tag = reader("id")}
                    AddHandler btnEdit.Click, AddressOf EditBarang
                    TableLayoutPanel1.Controls.Add(btnEdit, 7, rowIndex)

                    ' Tombol Hapus
                    Dim btnHapus As New Button With {.Text = "Hapus", .Tag = reader("id")}
                    AddHandler btnHapus.Click, AddressOf HapusBarang
                    TableLayoutPanel1.Controls.Add(btnHapus, 8, rowIndex)

                    rowIndex += 1
                    no += 1
                End While
            End Using
        End Using
    End Sub

    Private Sub EditBarang(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idBarang As Integer = CInt(btn.Tag)

        MessageBox.Show("Edit barang dengan ID: " & idBarang.ToString())
        ' TODO: Tambahkan form popup edit barang
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDataBarang(txtSearch.Text)
    End Sub

    Private Sub btnAddBarang_Click(sender As Object, e As EventArgs) Handles btnAddBarang.Click
        MessageBox.Show("Tambah Barang diklik.")
        ' TODO: Panggil Form untuk tambah barang baru
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        MessageBox.Show("Restock barang.")
        ' TODO: Tambahkan form input restock barang
    End Sub
End Class
