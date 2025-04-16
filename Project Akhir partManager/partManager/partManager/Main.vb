Public Class Main
    Private Sub TampilkanUserControl(ByVal uc As UserControl)
        PanelKanan.Controls.Clear()
        uc.Dock = DockStyle.Fill
        PanelKanan.Controls.Add(uc)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        TampilkanUserControl(New UC_Dashboard())
    End Sub

    Private Sub btnDataBarang_Click(sender As Object, e As EventArgs) Handles btnDataBarang.Click
        TampilkanUserControl(New UC_DataBarang())
    End Sub

    Private Sub btnBarangMasuk_Click(sender As Object, e As EventArgs) Handles btnBarangMasuk.Click
        TampilkanUserControl(New UC_BarangMasuk())
    End Sub

    Private Sub btnBarangKeluar_Click(sender As Object, e As EventArgs) Handles btnBarangKeluar.Click
        TampilkanUserControl(New UC_BarangKeluar())
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        TampilkanUserControl(New UC_Laporan)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New Main()
        loginForm.Show()
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanUserControl(New UC_Dashboard())
    End Sub

    Private Sub btnManajemenP_Click(sender As Object, e As EventArgs) Handles btnManajemenP.Click
        TampilkanUserControl(New UC_ManajemenPengguna)
    End Sub
End Class