Imports MySql.Data.MySqlClient

Public Class UC_Dashboard
    Private Sub UC_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUserInfo()
        LoadBarangStokRendah()
        LoadJumlahHariIni()
    End Sub

    Public Sub UpdateUserInfo()
        If Not String.IsNullOrEmpty(Session.LoggedInUsername) Then
            lblUsername.Text = Session.LoggedInUsername
        Else
            lblUsername.Text = "Belum Login"
        End If

        If Not String.IsNullOrEmpty(Session.LoggedInRole) Then
            lblLvlAkses.Text = Session.LoggedInRole.ToUpper()
        Else
            lblLvlAkses.Text = "Tidak Diketahui"
        End If
    End Sub

    Public Sub UpdateUserInfo(Optional username As String = "", Optional role As String = "")
        If Not String.IsNullOrEmpty(username) Then lblUsername.Text = username
        If Not String.IsNullOrEmpty(role) Then lblLvlAkses.Text = role.ToUpper()

        pbDataBarang.Visible = False
        lblDataBarang.Visible = False
        pbBarangMasuk.Visible = False
        lblBarangMasuk.Visible = False

        Select Case role.ToLower()
            Case "admin"
                pbDataBarang.Visible = True : lblDataBarang.Visible = True
                pbBarangMasuk.Visible = True : lblBarangMasuk.Visible = True
            Case "karyawan"
                pbDataBarang.Visible = True : lblDataBarang.Visible = True
                pbBarangMasuk.Visible = True : lblBarangMasuk.Visible = True

            Case "manajer"
        End Select

        'SusunGrid()
    End Sub

    Private Sub SusunGrid()
        Dim controls = New List(Of Tuple(Of PictureBox, Label)) From {
        Tuple.Create(pbDataBarang, lblDataBarang),
        Tuple.Create(pbBarangMasuk, lblBarangMasuk)
    }

        'Dim startX As Integer = 66
        'Dim startY As Integer = 102
        'Dim spacingX As Integer = 213
        'Dim spacingY As Integer = 145
        'Dim maxPerRow As Integer = 3

        'Dim index As Integer = 0

        'For Each item In controls
        '    If item.Item1.Visible Then
        '        Dim row = index \ maxPerRow
        '        Dim col = index Mod maxPerRow

        '        Dim x = startX + col * spacingX
        '        Dim y = startY + row * spacingY

        '        item.Item1.Location = New Point(x, y)
        '        item.Item2.Location = New Point(x + 20, y + 80)

        '        index += 1
        '    End If
        'Next
    End Sub

    Private Sub LoadBarangStokRendah()
        Dim connStr As String = "server=localhost;userid=root;password=;database=partmanager"
        Dim conn As New MySqlConnection(connStr)

        Try
            conn.Open()

            Dim query As String = "
            SELECT 
    b.nama_barang,
    IFNULL(m.total_masuk, 0) - IFNULL(k.total_keluar, 0) AS sisa_stok
FROM tblbarang b
LEFT JOIN (
    SELECT id_barang, SUM(jumlah) AS total_masuk
    FROM barang_masuk
    GROUP BY id_barang
) m ON b.id = m.id_barang
LEFT JOIN (
    SELECT id_barang, SUM(jumlah) AS total_keluar
    FROM barang_keluar
    GROUP BY id_barang
) k ON b.id = k.id_barang
HAVING sisa_stok < 10;
        "

            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            tabelstok.DataSource = dt
            tabelstok.Columns(0).HeaderText = "Nama Barang"
            tabelstok.Columns(1).HeaderText = "Stok Tersisa"

            tabelstok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            tabelstok.Columns(0).FillWeight = 70
            tabelstok.Columns(1).FillWeight = 30
            tabelstok.RowHeadersVisible = False

            tabelstok.EnableHeadersVisualStyles = False
            tabelstok.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
            tabelstok.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            tabelstok.DefaultCellStyle.Font = New Font("Segoe UI", 10)
            tabelstok.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            tabelstok.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadJumlahHariIni()
        Dim connStr As String = "server=localhost;userid=root;password=;database=partmanager"
        Dim conn As New MySqlConnection(connStr)

        Try
            conn.Open()

            ' Hitung jumlah barang masuk hari ini
            Dim queryMasuk As String = "
            SELECT IFNULL(SUM(jumlah), 0) 
            FROM barang_masuk 
            WHERE DATE(tanggal) = CURRENT_DATE;
        "
            Dim cmdMasuk As New MySqlCommand(queryMasuk, conn)
            Dim totalMasuk As Integer = Convert.ToInt32(cmdMasuk.ExecuteScalar())
            labelJumlahMasuk.Text = totalMasuk.ToString()

            ' Hitung jumlah barang keluar hari ini
            Dim queryKeluar As String = "
            SELECT IFNULL(SUM(jumlah), 0) 
            FROM barang_keluar 
            WHERE DATE(tanggal) = CURRENT_DATE;
        "
            Dim cmdKeluar As New MySqlCommand(queryKeluar, conn)
            Dim totalKeluar As Integer = Convert.ToInt32(cmdKeluar.ExecuteScalar())
            labelJumlahKeluar.Text = totalKeluar.ToString()

        Catch ex As Exception
            MessageBox.Show("Gagal memuat jumlah hari ini: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

End Class