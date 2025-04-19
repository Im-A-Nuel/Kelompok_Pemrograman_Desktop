Imports MySql.Data.MySqlClient

Public Class UC_BarangMasuk
    Private Sub UC_BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarangMasuk("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadDataBarangMasuk(TextBox1.Text)
    End Sub

    Private Sub LoadDataBarangMasuk(keyword As String)
        ' Hapus semua baris kecuali header (baris ke-0)
        For i = TableLayoutPanel1.RowCount - 1 To 1 Step -1
            For j = TableLayoutPanel1.ColumnCount - 1 To 0 Step -1
                Dim ctrl = TableLayoutPanel1.GetControlFromPosition(j, i)
                If ctrl IsNot Nothing Then
                    TableLayoutPanel1.Controls.Remove(ctrl)
                    ctrl.Dispose()
                End If
            Next
            TableLayoutPanel1.RowStyles.RemoveAt(i)
            TableLayoutPanel1.RowCount -= 1
        Next

        If conn.State = ConnectionState.Closed Then conn.Open()

        Dim sql As String = "SELECT bm.id, b.nama_barang, bm.jumlah, b.harga, b.kategori, bm.tanggal, b.supplier " &
                        "FROM barang_masuk bm JOIN tblbarang b ON bm.id_barang = b.id " &
                        "WHERE b.nama_barang LIKE @key OR b.kategori LIKE @key OR bm.tanggal LIKE @key"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Using reader = cmd.ExecuteReader()
                Dim rowIndex = 1
                Dim no = 1
                While reader.Read()
                    TableLayoutPanel1.RowCount += 1
                    TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40))

                    TableLayoutPanel1.Controls.Add(New Label With {.Text = no.ToString(), .AutoSize = True}, 0, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("nama_barang").ToString(), .AutoSize = True}, 1, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("jumlah").ToString(), .AutoSize = True}, 2, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("harga").ToString(), .AutoSize = True}, 3, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("kategori").ToString(), .AutoSize = True}, 4, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = CDate(reader("tanggal")).ToString("dd-MM-yyyy"), .AutoSize = True}, 5, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("supplier").ToString(), .AutoSize = True}, 6, rowIndex)

                    Dim btnEdit As New Button With {
                    .Text = "Edit",
                    .Tag = reader("id"),
                    .Height = 30,
                    .Width = 50
                }
                    AddHandler btnEdit.Click, AddressOf BtnEdit_Click
                    TableLayoutPanel1.Controls.Add(btnEdit, 7, rowIndex)

                    Dim btnHapus As New Button With {
                    .Text = "Hapus",
                    .Tag = reader("id"),
                    .Height = 30,
                    .Width = 60,
                    .BackColor = Color.Red,
                    .ForeColor = Color.White
                }
                    AddHandler btnHapus.Click, AddressOf BtnHapus_Click
                    TableLayoutPanel1.Controls.Add(btnHapus, 8, rowIndex)

                    rowIndex += 1
                    no += 1
                End While
            End Using
        End Using
    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idBarangMasuk As Integer = CInt(btn.Tag)
        MessageBox.Show("Edit Barang Masuk ID: " & idBarangMasuk)
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idBarangMasuk As Integer = CInt(btn.Tag)

        If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql = "DELETE FROM barang_masuk WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", idBarangMasuk)
                cmd.ExecuteNonQuery()
            End Using
            LoadDataBarangMasuk(TextBox1.Text)
        End If
    End Sub
End Class
