Imports MySql.Data.MySqlClient

Public Class Tambah_Barang
    Public Mode As String = "Add"
    Public BarangID As Integer = -1
    Public RefreshCallback As Action

    Private Sub Tambah_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()

        If Mode = "Edit" AndAlso BarangID <> -1 Then
            LoadDataBarang()
            btnTambahBarang.Text = "Update Barang"
        Else
            btnTambahBarang.Text = "Tambah Barang"
        End If
    End Sub

    Private Sub LoadKategori()
        cbKategori.Items.Clear()
        cbKategori.Items.AddRange({"Prosesor", "Motherboard", "RAM", "SSD", "Power Supply", "Monitor", "Keyboard", "Mouse"})
    End Sub

    Private Sub LoadDataBarang()
        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim sql = "SELECT * FROM tblbarang WHERE id = @id"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", BarangID)
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtNamaBarang.Text = reader("nama_barang").ToString()
                    txtStok.Text = reader("stok").ToString()
                    txtHarga.Text = reader("harga").ToString()
                    cbKategori.Text = reader("kategori").ToString()
                    txtSupplier.Text = reader("supplier").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Function IsValidInput() As Boolean
        If String.IsNullOrWhiteSpace(txtNamaBarang.Text) Then
            MessageBox.Show("Nama barang wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaBarang.Focus()
            Return False
        End If
        If Not Integer.TryParse(txtStok.Text, Nothing) OrElse Val(txtStok.Text) < 0 Then
            MessageBox.Show("Stok harus berupa angka dan tidak boleh negatif!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStok.Focus()
            Return False
        End If
        If Not Decimal.TryParse(txtHarga.Text, Nothing) OrElse Val(txtHarga.Text) <= 0 Then
            MessageBox.Show("Harga harus angka dan lebih dari 0!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus()
            Return False
        End If
        If cbKategori.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih kategori!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbKategori.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnTambahBarang_Click(sender As Object, e As EventArgs) Handles btnTambahBarang.Click
        If Not IsValidInput() Then Exit Sub

        If conn.State = ConnectionState.Closed Then conn.Open()

        If Mode = "Add" Then
            Dim sql = "INSERT INTO tblbarang (nama_barang, stok, harga, kategori, tanggal_masuk, supplier) VALUES (@nama_barang, @stok, @harga, @kategori, @tanggal_masuk, @supplier)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nama_barang", txtNamaBarang.Text)
                cmd.Parameters.AddWithValue("@stok", CInt(txtStok.Text))
                cmd.Parameters.AddWithValue("@harga", CDec(txtHarga.Text))
                cmd.Parameters.AddWithValue("@kategori", cbKategori.Text)
                cmd.Parameters.AddWithValue("@tanggal_masuk", DateTime.Now)
                cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Barang berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Mode = "Edit" AndAlso BarangID <> -1 Then
            Dim sql = "UPDATE tblbarang SET nama_barang=@nama_barang, stok=@stok, harga=@harga, kategori=@kategori, supplier=@supplier WHERE id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nama_barang", txtNamaBarang.Text)
                cmd.Parameters.AddWithValue("@stok", CInt(txtStok.Text))
                cmd.Parameters.AddWithValue("@harga", CDec(txtHarga.Text))
                cmd.Parameters.AddWithValue("@kategori", cbKategori.Text)
                cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text)
                cmd.Parameters.AddWithValue("@id", BarangID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Barang berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Panggil refresh callback jika tersedia
        RefreshCallback?.Invoke()

        Me.Close()
    End Sub
End Class
