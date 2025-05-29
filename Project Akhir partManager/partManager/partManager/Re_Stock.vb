Imports MySql.Data.MySqlClient

Public Class Re_Stock
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
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cbBarang.SelectedValue Is Nothing OrElse nudJumlah.Value <= 0 Then
            MessageBox.Show("Lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim userInput As String = ModAuth.CurrentUserName

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

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
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
