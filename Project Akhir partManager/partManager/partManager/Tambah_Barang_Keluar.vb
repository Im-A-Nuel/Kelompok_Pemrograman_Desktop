Imports MySql.Data.MySqlClient

Public Class Tambah_Barang_Keluar

    Dim stokBarangTerpilih As Integer = 0
    Dim idBarangTerpilih As Integer = 0
    Public Property IsEditMode As Boolean = False
    Public Property EditID As Integer = 0


    Private Sub Tambah_Barang_Keluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbJenisKeluar.Items.AddRange(New Object() {"Penjualan", "Pemakaian", "Transfer", "Rusak", "Lain-lain"})

        LoadBarang()

        If IsEditMode Then
            LoadDataEdit()
        Else
            cbJenisKeluar.SelectedIndex = 0
            dtpTanggal.Value = Date.Today
        End If

        If cbJenisKeluar.SelectedItem IsNot Nothing Then
            txtTransaksi.Enabled = (cbJenisKeluar.SelectedItem.ToString() = "Penjualan")
        Else
            txtTransaksi.Enabled = False
        End If
    End Sub

    Private Sub LoadDataEdit()
        Dim sql As String = "SELECT bk.*, b.nama_barang FROM barang_keluar bk JOIN tblbarang b ON bk.id_barang = b.id WHERE bk.id = @id"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", EditID)
            If conn.State = ConnectionState.Closed Then conn.Open()
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim idBarang = CInt(reader("id_barang"))
                    Dim jumlah = CInt(reader("jumlah"))
                    Dim tanggal = Convert.ToDateTime(reader("tanggal"))
                    Dim ket As String = reader("keterangan").ToString()
                    Dim aksiDb As String = reader("aksi").ToString()
                    reader.Close()

                    ' *** PASTIKAN cbBarang memiliki data sebelum set SelectedValue ***
                    ' Ini penting agar SelectedValue tidak dipanggil saat DataSource masih kosong
                    If cbBarang.DataSource IsNot Nothing AndAlso DirectCast(cbBarang.DataSource, DataTable).Rows.Count > 0 Then
                        cbBarang.SelectedValue = idBarang
                    End If

                    nudJumlah.Value = jumlah
                    dtpTanggal.Value = tanggal

                    If cbJenisKeluar.Items.Contains(aksiDb) Then
                        cbJenisKeluar.SelectedItem = aksiDb
                    Else
                        cbJenisKeluar.SelectedItem = "Lain-lain"
                    End If

                    If aksiDb = "Penjualan" Then
                        Dim match = System.Text.RegularExpressions.Regex.Match(ket, "No\.Transaksi:\s*(.*?)(?:\s*\||$)")
                        If match.Success Then
                            txtTransaksi.Text = match.Groups(1).Value.Trim()
                        End If
                    End If

                    Dim potonganKeterangan = ket.Split("|"c).Select(Function(x) x.Trim()).ToList()

                    If potonganKeterangan.Any() AndAlso potonganKeterangan(0) = aksiDb Then
                        potonganKeterangan.RemoveAt(0)
                    End If

                    txtKeterangan.Text = String.Join(" | ", potonganKeterangan.Where(Function(x) Not x.StartsWith("No.Transaksi")).ToList())

                End If
            End Using
        End Using
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Function GetJenisDariKeterangan(ket As String) As String
        Dim jenisList = {"Penjualan", "Pemakaian", "Transfer", "Rusak", "Lain-lain"}
        For Each jenis In jenisList
            If ket.StartsWith(jenis) Then Return jenis
        Next
        Return "Lain-lain"
    End Function


    Private Sub LoadBarang()
        Dim sql As String = "SELECT id, nama_barang FROM tblbarang ORDER BY nama_barang ASC"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(sql, conn)
            If conn.State = ConnectionState.Closed Then conn.Open()
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using
        If conn.State = ConnectionState.Open Then conn.Close()

        cbBarang.DataSource = dt
        cbBarang.DisplayMember = "nama_barang"
        cbBarang.ValueMember = "id"
        cbBarang.SelectedIndex = -1
        lblStokTersedia.Text = "Stok : -"
    End Sub


    Private Sub cbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBarang.SelectedIndexChanged
        If cbBarang.SelectedIndex >= 0 Then
            If cbBarang.SelectedValue IsNot Nothing Then
                ' Cek tipe SelectedValue
                If TypeOf cbBarang.SelectedValue Is DataRowView Then
                    ' Jika masih DataRowView, ambil nilai kolom id dari objek tersebut
                    Dim drv As DataRowView = DirectCast(cbBarang.SelectedValue, DataRowView)
                    idBarangTerpilih = Convert.ToInt32(drv("id"))
                Else
                    ' Jika langsung Integer atau tipe lain yang sesuai, langsung konversi
                    idBarangTerpilih = Convert.ToInt32(cbBarang.SelectedValue)
                End If

                stokBarangTerpilih = GetStokBarang(idBarangTerpilih)
                lblStokTersedia.Text = "Stok: " & stokBarangTerpilih.ToString()
            Else
                lblStokTersedia.Text = "Stok: -"
                stokBarangTerpilih = 0
                idBarangTerpilih = 0
            End If
        Else
            lblStokTersedia.Text = "Stok: -"
            stokBarangTerpilih = 0
            idBarangTerpilih = 0
        End If
    End Sub



    Private Function GetStokBarang(idBarang As Integer) As Integer
        Dim sqlMasuk As String = "SELECT IFNULL(SUM(jumlah),0) FROM barang_masuk WHERE id_barang=@id"
        Dim sqlKeluar As String = "SELECT IFNULL(SUM(jumlah),0) FROM barang_keluar WHERE id_barang=@id"
        Dim masuk As Integer = 0, keluar As Integer = 0
        If conn.State = ConnectionState.Closed Then conn.Open()
        Using cmd As New MySqlCommand(sqlMasuk, conn)
            cmd.Parameters.AddWithValue("@id", idBarang)
            masuk = CInt(cmd.ExecuteScalar())
        End Using
        Using cmd As New MySqlCommand(sqlKeluar, conn)
            cmd.Parameters.AddWithValue("@id", idBarang)
            keluar = CInt(cmd.ExecuteScalar())
        End Using
        If conn.State = ConnectionState.Open Then conn.Close()
        Return masuk - keluar
    End Function

    Private Sub cbJenisKeluar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenisKeluar.SelectedIndexChanged
        If cbJenisKeluar.SelectedItem IsNot Nothing Then
            If cbJenisKeluar.SelectedItem.ToString() = "Penjualan" Then
                txtTransaksi.Enabled = True
            Else
                txtTransaksi.Enabled = False
                txtTransaksi.Text = ""
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cbBarang.SelectedIndex < 0 Then
            MessageBox.Show("Pilih barang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If nudJumlah.Value <= 0 Then
            MessageBox.Show("Jumlah harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsEditMode Then
            If nudJumlah.Value > stokBarangTerpilih Then
                MessageBox.Show("Stok tidak cukup!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            Dim jumlahLama As Integer = 0
            Dim sqlJumlahLama As String = "SELECT jumlah FROM barang_keluar WHERE id = @id"
            Using cmdJumlahLama As New MySqlCommand(sqlJumlahLama, conn)
                cmdJumlahLama.Parameters.AddWithValue("@id", EditID)
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim result = cmdJumlahLama.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    jumlahLama = CInt(result)
                End If
                If conn.State = ConnectionState.Open Then conn.Close()
            End Using

            Dim stokSetelahKembaliJumlahLama = GetStokBarang(idBarangTerpilih) + jumlahLama
            If nudJumlah.Value > stokSetelahKembaliJumlahLama Then
                MessageBox.Show("Jumlah melebihi stok yang tersedia setelah penyesuaian!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        ' Validasi khusus Penjualan
        If cbJenisKeluar.SelectedItem.ToString() = "Penjualan" AndAlso String.IsNullOrWhiteSpace(txtTransaksi.Text) Then
            MessageBox.Show("No. Transaksi harus diisi untuk penjualan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim aksi As String = cbJenisKeluar.SelectedItem.ToString()
            Dim keteranganGabungan As String

            If aksi = "Penjualan" Then
                keteranganGabungan = "No.Transaksi: " & txtTransaksi.Text.Trim()
                If Not String.IsNullOrWhiteSpace(txtKeterangan.Text) Then
                    keteranganGabungan &= " | " & txtKeterangan.Text.Trim()
                End If
            Else
                keteranganGabungan = txtKeterangan.Text.Trim()
            End If

            If IsEditMode Then
                Dim sqlUpdate As String = "UPDATE barang_keluar SET id_barang=@id_barang, jumlah=@jumlah, tanggal=@tanggal, keterangan=@keterangan, aksi=@aksi, supplier=@supplier, user_input=@user_input WHERE id=@id"
                Using cmd As New MySqlCommand(sqlUpdate, conn)
                    cmd.Parameters.AddWithValue("@id_barang", idBarangTerpilih)
                    cmd.Parameters.AddWithValue("@jumlah", nudJumlah.Value)
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@keterangan", keteranganGabungan)
                    cmd.Parameters.AddWithValue("@aksi", aksi)
                    cmd.Parameters.AddWithValue("@supplier", "")
                    cmd.Parameters.AddWithValue("@user_input", ModAuth.CurrentUserName)
                    cmd.Parameters.AddWithValue("@id", EditID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data barang keluar berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim sqlInsert As String = "INSERT INTO barang_keluar (id_barang, jumlah, tanggal, keterangan, aksi, supplier, user_input) VALUES (@id_barang, @jumlah, @tanggal, @keterangan, @aksi, @supplier, @user_input)"
                Using cmd As New MySqlCommand(sqlInsert, conn)
                    cmd.Parameters.AddWithValue("@id_barang", idBarangTerpilih)
                    cmd.Parameters.AddWithValue("@jumlah", nudJumlah.Value)
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@keterangan", keteranganGabungan)
                    cmd.Parameters.AddWithValue("@aksi", aksi)
                    cmd.Parameters.AddWithValue("@supplier", "")
                    cmd.Parameters.AddWithValue("@user_input", ModAuth.CurrentUserName)
                    cmd.ExecuteNonQuery()
                End Using

                Dim sqlRiwayat As String = "INSERT INTO riwayat_stok (id_barang, aksi, jumlah, tanggal, user_input) VALUES (@id_barang, 'keluar', @jumlah, @tanggal, @user_input)"
                Using cmd2 As New MySqlCommand(sqlRiwayat, conn)
                    cmd2.Parameters.AddWithValue("@id_barang", idBarangTerpilih)
                    cmd2.Parameters.AddWithValue("@jumlah", nudJumlah.Value)
                    cmd2.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                    cmd2.Parameters.AddWithValue("@user_input", ModAuth.CurrentUserName)
                    cmd2.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data barang keluar berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal simpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub



    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class