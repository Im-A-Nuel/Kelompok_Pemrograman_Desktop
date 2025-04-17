Imports MySql.Data.MySqlClient

Public Class UC_DataBarang

    Private Sub UC_DataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBarang("")
    End Sub

    Private Sub LoadDataBarang(keyword As String)
        TableLayoutPanel1.SuspendLayout()

        For i = TableLayoutPanel1.RowCount - 1 To 3 Step -1
            For Each ctrl As Control In TableLayoutPanel1.Controls
                If TableLayoutPanel1.GetRow(ctrl) = i Then
                    TableLayoutPanel1.Controls.Remove(ctrl)
                End If
            Next
            TableLayoutPanel1.RowStyles.RemoveAt(i)
            TableLayoutPanel1.RowCount -= 1
        Next

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

                    TableLayoutPanel1.Controls.Add(New Label With {.Text = no.ToString(), .AutoSize = True, .Anchor = AnchorStyles.Left}, 0, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("nama_barang").ToString(), .AutoSize = True, .Anchor = AnchorStyles.Left}, 1, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("stok").ToString(), .AutoSize = True, .Anchor = AnchorStyles.Left}, 2, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("harga").ToString(), .AutoSize = True, .Anchor = AnchorStyles.Left}, 3, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("kategori").ToString(), .AutoSize = True, .Anchor = AnchorStyles.Left}, 4, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = Convert.ToDateTime(reader("tanggal_masuk")).ToShortDateString(), .AutoSize = True, .Anchor = AnchorStyles.Left}, 5, rowIndex)
                    TableLayoutPanel1.Controls.Add(New Label With {.Text = reader("supplier").ToString(), .AutoSize = True, .Anchor = AnchorStyles.Left}, 6, rowIndex)

                    Dim btnEdit As New Button With {.Text = "Edit", .Tag = reader("id"), .Width = 60, .Height = 30}
                    AddHandler btnEdit.Click, AddressOf EditBarang
                    TableLayoutPanel1.Controls.Add(btnEdit, 7, rowIndex)

                    Dim btnHapus As New Button With {.Text = "Hapus", .Tag = reader("id"), .Width = 60, .Height = 30, .BackColor = Color.Red, .ForeColor = Color.White}
                    AddHandler btnHapus.Click, AddressOf HapusBarang
                    TableLayoutPanel1.Controls.Add(btnHapus, 8, rowIndex)

                    rowIndex += 1
                    no += 1
                End While
            End Using
        End Using

        TableLayoutPanel1.ResumeLayout()
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

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDataBarang(txtSearch.Text)
        End If
    End Sub

    Private Sub btnAddBarang_Click(sender As Object, e As EventArgs) Handles btnAddBarang.Click
        Dim frm As New Tambah_Barang()
        frm.Mode = "Add"
        frm.RefreshCallback = Sub() LoadDataBarang(txtSearch.Text)
        frm.ShowDialog()
    End Sub

End Class
