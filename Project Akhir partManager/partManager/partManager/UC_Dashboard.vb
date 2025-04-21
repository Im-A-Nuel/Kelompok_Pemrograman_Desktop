Public Class UC_Dashboard
    Private Sub UC_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUserInfo()
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
        pbBarangKeluar.Visible = False
        lblBarangKeluar.Visible = False
        pbLaporan.Visible = False
        lblLaporan.Visible = False
        pbManPengguna.Visible = False
        lblManPengguna.Visible = False

        Select Case role.ToLower()
            Case "admin"
                pbDataBarang.Visible = True : lblDataBarang.Visible = True
                pbBarangMasuk.Visible = True : lblBarangMasuk.Visible = True
                pbBarangKeluar.Visible = True : lblBarangKeluar.Visible = True
                pbLaporan.Visible = True : lblLaporan.Visible = True
                pbManPengguna.Visible = True : lblManPengguna.Visible = True

            Case "karyawan"
                pbDataBarang.Visible = True : lblDataBarang.Visible = True
                pbBarangMasuk.Visible = True : lblBarangMasuk.Visible = True
                pbBarangKeluar.Visible = True : lblBarangKeluar.Visible = True

            Case "manajer"
                pbLaporan.Visible = True : lblLaporan.Visible = True
        End Select

        SusunGrid()
    End Sub

    Private Sub SusunGrid()
        Dim controls = New List(Of Tuple(Of PictureBox, Label)) From {
        Tuple.Create(pbDataBarang, lblDataBarang),
        Tuple.Create(pbBarangMasuk, lblBarangMasuk),
        Tuple.Create(pbBarangKeluar, lblBarangKeluar),
        Tuple.Create(pbManPengguna, lblManPengguna),
        Tuple.Create(pbLaporan, lblLaporan)
    }

        Dim startX As Integer = 66
        Dim startY As Integer = 102
        Dim spacingX As Integer = 213
        Dim spacingY As Integer = 145
        Dim maxPerRow As Integer = 3

        Dim index As Integer = 0

        For Each item In controls
            If item.Item1.Visible Then
                Dim row = index \ maxPerRow
                Dim col = index Mod maxPerRow

                Dim x = startX + col * spacingX
                Dim y = startY + row * spacingY

                item.Item1.Location = New Point(x, y)
                item.Item2.Location = New Point(x + 20, y + 80)

                index += 1
            End If
        Next
    End Sub


End Class