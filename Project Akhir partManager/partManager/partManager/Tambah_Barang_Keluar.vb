Imports MySql.Data.MySqlClient

Public Class Tambah_Barang_Keluar

    Dim stokBarangTerpilih As Integer = 0
    Dim idBarangTerpilih As Integer = 0

    Private Sub Tambah_Barang_Keluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBarang()
        cbJenisKeluar.Items.AddRange(New Object() {"Penjualan", "Pemakaian", "Transfer", "Rusak", "Lain-lain"})
        cbJenisKeluar.SelectedIndex = 0
        dtpTanggal.Value = Date.Today
        txtTransaksi.Enabled = (cbJenisKeluar.SelectedItem.ToString() = "Penjualan")
    End Sub

    Private Sub LoadBarang()
        Dim sql As String = "SELECT id, nama_barang FROM tblbarang"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(sql, conn)
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        cbBarang.DataSource = dt
        cbBarang.DisplayMember = "nama_barang"
        cbBarang.ValueMember = "id"
        cbBarang.SelectedIndex = -1
        lblStokTersedia.Text = "Stok : -"
    End Sub


    Private Sub cbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBarang.SelectedIndexChanged
        If cbBarang.SelectedIndex >= 0 Then
            If TypeOf cbBarang.SelectedValue Is Integer Then
                idBarangTerpilih = CInt(cbBarang.SelectedValue)
            ElseIf TypeOf cbBarang.SelectedItem Is DataRowView Then
                idBarangTerpilih = CInt(CType(cbBarang.SelectedItem, DataRowView)("id"))
            Else
                idBarangTerpilih = 0
            End If
            stokBarangTerpilih = GetStokBarang(idBarangTerpilih)
            lblStokTersedia.Text = "Stok: " & stokBarangTerpilih.ToString()
        Else
            lblStokTersedia.Text = "Stok: -"
            stokBarangTerpilih = 0
            idBarangTerpilih = 0
        End If
    End Sub


    Private Function GetStokBarang(idBarang As Integer) As Integer
        ' Hitung stok = semua masuk - semua keluar untuk barang tsb
        Dim sqlMasuk As String = "SELECT IFNULL(SUM(jumlah),0) FROM barang_masuk WHERE id_barang=@id"
        Dim sqlKeluar As String = "SELECT IFNULL(SUM(jumlah),0) FROM barang_keluar WHERE id_barang=@id"
        Dim masuk As Integer = 0, keluar As Integer = 0
        Using cmd As New MySqlCommand(sqlMasuk, conn)
            cmd.Parameters.AddWithValue("@id", idBarang)
            If conn.State = ConnectionState.Closed Then conn.Open()
            masuk = CInt(cmd.ExecuteScalar())
        End Using
        Using cmd As New MySqlCommand(sqlKeluar, conn)
            cmd.Parameters.AddWithValue("@id", idBarang)
            keluar = CInt(cmd.ExecuteScalar())
        End Using
        Return masuk - keluar
    End Function

    Private Sub cbJenisKeluar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenisKeluar.SelectedIndexChanged
        ' Hanya aktif jika Penjualan
        If cbJenisKeluar.SelectedItem.ToString() = "Penjualan" Then
            txtTransaksi.Enabled = True
        Else
            txtTransaksi.Enabled = False
            txtTransaksi.Text = ""
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi data
        If cbBarang.SelectedIndex < 0 Then
            MessageBox.Show("Pilih barang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If nudJumlah.Value <= 0 Then
            MessageBox.Show("Jumlah harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If nudJumlah.Value > stokBarangTerpilih Then
            MessageBox.Show("Stok tidak cukup!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cbJenisKeluar.SelectedItem.ToString() = "Penjualan" AndAlso String.IsNullOrWhiteSpace(txtTransaksi.Text) Then
            MessageBox.Show("No. Transaksi harus diisi untuk penjualan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Simpan data ke database
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = "INSERT INTO barang_keluar (id_barang, jumlah, tanggal, keterangan, supplier, user_input) VALUES (@id_barang, @jumlah, @tanggal, @keterangan, @supplier, @user_input)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id_barang", idBarangTerpilih)
                cmd.Parameters.AddWithValue("@jumlah", nudJumlah.Value)
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                ' Keterangan gabungan
                Dim keteranganGabungan As String = cbJenisKeluar.SelectedItem.ToString()
                If cbJenisKeluar.SelectedItem.ToString() = "Penjualan" AndAlso Not String.IsNullOrWhiteSpace(txtTransaksi.Text) Then
                    keteranganGabungan &= " | No.Transaksi: " & txtTransaksi.Text
                End If
                If Not String.IsNullOrWhiteSpace(txtKeterangan.Text) Then
                    keteranganGabungan &= " | " & txtKeterangan.Text
                End If
                cmd.Parameters.AddWithValue("@keterangan", keteranganGabungan)
                cmd.Parameters.AddWithValue("@supplier", "")
                cmd.Parameters.AddWithValue("@user_input", ModAuth.CurrentUserName)
                cmd.ExecuteNonQuery()
            End Using

            ' Insert ke riwayat_stok
            Dim sql2 As String = "INSERT INTO riwayat_stok (id_barang, aksi, jumlah, tanggal, user_input) VALUES (@id_barang, 'keluar', @jumlah, @tanggal, @user_input)"
            Using cmd2 As New MySqlCommand(sql2, conn)
                cmd2.Parameters.AddWithValue("@id_barang", idBarangTerpilih)
                cmd2.Parameters.AddWithValue("@jumlah", nudJumlah.Value)
                cmd2.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                cmd2.Parameters.AddWithValue("@user_input", ModAuth.CurrentUserName)
                cmd2.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data barang keluar berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal simpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class