Imports MySql.Data.MySqlClient

Public Class Re_Stock

    Public Property Mode As String = "Add"
    Public Property BarangMasukID As Integer = 0

    Private Sub Re_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT id, nama_barang FROM tblbarang"
        Dim dt As New DataTable()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            cbBarang.DataSource = dt
            cbBarang.DisplayMember = "nama_barang"
            cbBarang.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Gagal load barang: " & ex.Message)
        End Try

        dtpTanggal.Value = DateTime.Today

        If Mode = "Edit" AndAlso BarangMasukID > 0 Then
            LoadBarangMasuk()
            btnSimpan.Text = "Update"
            lblHeader.Text = "Edit Barang Masuk"
        Else
            btnSimpan.Text = "Simpan"
            lblHeader.Text = "Re-Stock"
        End If
    End Sub

    Private Sub LoadBarangMasuk()
        Dim sql As String = "SELECT * FROM barang_masuk WHERE id = @id"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", BarangMasukID)
            If conn.State = ConnectionState.Closed Then conn.Open()
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    cbBarang.SelectedValue = reader("id_barang")
                    nudJumlah.Value = Convert.ToDecimal(reader("jumlah"))
                    dtpTanggal.Value = Convert.ToDateTime(reader("tanggal"))
                    txtSupplier.Text = reader("supplier").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cbBarang.SelectedValue Is Nothing OrElse nudJumlah.Value <= 0 Then
            MessageBox.Show("Lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim userInput As String = ModAuth.CurrentUserName

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            If Mode = "Edit" AndAlso BarangMasukID > 0 Then
                ' UPDATE barang_masuk
                Dim sql As String = "UPDATE barang_masuk SET id_barang=@id_barang, jumlah=@jumlah, tanggal=@tanggal, supplier=@supplier, user_input=@user_input WHERE id=@id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id_barang", cbBarang.SelectedValue)
                    cmd.Parameters.AddWithValue("@jumlah", nudJumlah.Value)
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text)
                    cmd.Parameters.AddWithValue("@user_input", userInput)
                    cmd.Parameters.AddWithValue("@id", BarangMasukID)
                    cmd.ExecuteNonQuery()
                End Using
                ' Optional: Insert ke riwayat_stok update, atau update entry lama jika perlu
                MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' INSERT seperti biasa
                Dim sql As String = "INSERT INTO barang_masuk (id_barang, jumlah, tanggal, supplier, user_input) VALUES (@id_barang, @jumlah, @tanggal, @supplier, @user_input)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id_barang", cbBarang.SelectedValue)
                    cmd.Parameters.AddWithValue("@jumlah", nudJumlah.Value)
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text)
                    cmd.Parameters.AddWithValue("@user_input", userInput)
                    cmd.ExecuteNonQuery()
                End Using

                Dim sql2 As String = "INSERT INTO riwayat_stok (id_barang, aksi, jumlah, tanggal, user_input) VALUES (@id_barang, 'masuk', @jumlah, @tanggal, @user_input)"
                Using cmd2 As New MySqlCommand(sql2, conn)
                    cmd2.Parameters.AddWithValue("@id_barang", cbBarang.SelectedValue)
                    cmd2.Parameters.AddWithValue("@jumlah", nudJumlah.Value)
                    cmd2.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                    cmd2.Parameters.AddWithValue("@user_input", userInput)
                    cmd2.ExecuteNonQuery()
                End Using

                MessageBox.Show("Stok berhasil ditambah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub
End Class
