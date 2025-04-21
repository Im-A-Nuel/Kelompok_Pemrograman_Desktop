Public Class Main

    Public Shared IsLoggedIn As Boolean = False

    Private Sub TampilkanUserControl(ByVal uc As UserControl, ByVal selectedButton As Button)
        PanelKanan.Controls.Clear()
        uc.Dock = DockStyle.Fill
        PanelKanan.Controls.Add(uc)

        ResetHighlightMenu()
        selectedButton.BackColor = Color.SteelBlue
        selectedButton.ForeColor = Color.White
        selectedButton.Font = New Font(selectedButton.Font, FontStyle.Bold)

        If TypeOf uc Is UC_Dashboard Then
            Dim dashboard = DirectCast(uc, UC_Dashboard)
            dashboard.UpdateUserInfo()
        End If
    End Sub

    Private Sub ResetHighlightMenu()
        For Each ctrl As Control In flowPanelMenu.Controls
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = SystemColors.Control
                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font(ctrl.Font, FontStyle.Regular)
            End If
        Next
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        TampilkanUserControl(New UC_Dashboard(), btnDashboard)
    End Sub

    Private Sub btnDataBarang_Click(sender As Object, e As EventArgs) Handles btnDataBarang.Click
        TampilkanUserControl(New UC_DataBarang(), btnDataBarang)
    End Sub

    Private Sub btnBarangMasuk_Click(sender As Object, e As EventArgs) Handles btnBarangMasuk.Click
        TampilkanUserControl(New UC_BarangMasuk(), btnBarangMasuk)
    End Sub

    Private Sub btnBarangKeluar_Click(sender As Object, e As EventArgs) Handles btnBarangKeluar.Click
        TampilkanUserControl(New UC_BarangKeluar(), btnBarangKeluar)
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        TampilkanUserControl(New UC_Laporan(), btnLaporan)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If System.IO.File.Exists("session.txt") Then
                System.IO.File.Delete("session.txt")
            End If

            Main.IsLoggedIn = False

            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each btn In {btnDashboard, btnDataBarang, btnBarangMasuk, btnBarangKeluar, btnLaporan, btnManajemenP, btnLogout}
            btn.Width = 170
            btn.Height = 50
        Next

        If String.IsNullOrEmpty(LoggedInUsername) OrElse String.IsNullOrEmpty(LoggedInRole) Then
            MessageBox.Show("Session tidak valid.")
            Me.Close()
            Return
        End If

        lblUser.Text = LoggedInUsername

        Select Case LoggedInRole.ToLower()
            Case "admin"
                btnDashboard.Visible = True
                btnDataBarang.Visible = True
                btnBarangMasuk.Visible = True
                btnBarangKeluar.Visible = True
                btnLaporan.Visible = True
                btnManajemenP.Visible = True
            Case "karyawan"
                btnDashboard.Visible = True
                btnDataBarang.Visible = True
                btnBarangMasuk.Visible = True
                btnBarangKeluar.Visible = True
                btnLaporan.Visible = False
                btnManajemenP.Visible = False
            Case "manajer"
                btnDashboard.Visible = True
                btnDataBarang.Visible = False
                btnBarangMasuk.Visible = False
                btnBarangKeluar.Visible = False
                btnLaporan.Visible = True
                btnManajemenP.Visible = False
            Case Else
                MessageBox.Show("Role tidak dikenal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
        End Select

        Dim dashboard As New UC_Dashboard()
        dashboard.UpdateUserInfo(LoggedInUsername, LoggedInRole)
        TampilkanUserControl(dashboard, btnDashboard)
    End Sub

    Private Sub btnManajemenP_Click(sender As Object, e As EventArgs) Handles btnManajemenP.Click
        TampilkanUserControl(New UC_ManajemenPengguna(), btnManajemenP)
    End Sub

    'Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '    If result = DialogResult.Yes Then
    '        Application.Exit()
    '    Else
    '        e.Cancel = True
    '    End If
    'End Sub

End Class