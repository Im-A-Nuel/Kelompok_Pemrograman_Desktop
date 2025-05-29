<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        PanelKanan = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        flowPanelMenu = New FlowLayoutPanel()
        btnDashboard = New Button()
        btnDataBarang = New Button()
        btnBarangMasuk = New Button()
        btnBarangKeluar = New Button()
        btnLaporan = New Button()
        btnManajemenP = New Button()
        btnLogout = New Button()
        PictureBox7 = New PictureBox()
        lblUser = New Label()
        PanelKiri = New Panel()
        flowPanelMenu.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        PanelKiri.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelKanan
        ' 
        PanelKanan.BackColor = Color.White
        PanelKanan.Dock = DockStyle.Fill
        PanelKanan.Location = New Point(204, 0)
        PanelKanan.Margin = New Padding(3, 4, 3, 4)
        PanelKanan.Name = "PanelKanan"
        PanelKanan.Size = New Size(808, 639)
        PanelKanan.TabIndex = 2
        ' 
        ' flowPanelMenu
        ' 
        flowPanelMenu.BackColor = SystemColors.ActiveCaption
        flowPanelMenu.Controls.Add(btnDashboard)
        flowPanelMenu.Controls.Add(btnDataBarang)
        flowPanelMenu.Controls.Add(btnBarangMasuk)
        flowPanelMenu.Controls.Add(btnBarangKeluar)
        flowPanelMenu.Controls.Add(btnLaporan)
        flowPanelMenu.Controls.Add(btnManajemenP)
        flowPanelMenu.Controls.Add(btnLogout)
        flowPanelMenu.FlowDirection = FlowDirection.TopDown
        flowPanelMenu.Location = New Point(0, 130)
        flowPanelMenu.Margin = New Padding(0)
        flowPanelMenu.Name = "flowPanelMenu"
        flowPanelMenu.Size = New Size(204, 500)
        flowPanelMenu.TabIndex = 10
        flowPanelMenu.WrapContents = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(3, 3)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(195, 61)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        btnDashboard.Image = New Bitmap(My.Resources.dashboard, New Size(32, 32))
        btnDashboard.ImageAlign = ContentAlignment.MiddleRight
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        ' 
        ' btnDataBarang
        ' 
        btnDataBarang.Location = New Point(3, 70)
        btnDataBarang.Name = "btnDataBarang"
        btnDataBarang.Size = New Size(195, 61)
        btnDataBarang.TabIndex = 1
        btnDataBarang.Text = "Data Barang"
        btnDataBarang.Image = New Bitmap(My.Resources.box, New Size(32, 32))
        btnDataBarang.ImageAlign = ContentAlignment.MiddleRight
        btnDataBarang.TextImageRelation = TextImageRelation.ImageBeforeText
        ' 
        ' btnBarangMasuk
        ' 
        btnBarangMasuk.Location = New Point(3, 137)
        btnBarangMasuk.Name = "btnBarangMasuk"
        btnBarangMasuk.Size = New Size(195, 61)
        btnBarangMasuk.TabIndex = 2
        btnBarangMasuk.Text = "Barang Masuk"
        btnBarangMasuk.Image = New Bitmap(My.Resources._in, New Size(24, 24))
        btnBarangMasuk.ImageAlign = ContentAlignment.MiddleRight
        btnBarangMasuk.TextImageRelation = TextImageRelation.ImageBeforeText
        ' 
        ' btnBarangKeluar
        ' 
        btnBarangKeluar.Location = New Point(3, 204)
        btnBarangKeluar.Name = "btnBarangKeluar"
        btnBarangKeluar.Size = New Size(195, 61)
        btnBarangKeluar.TabIndex = 3
        btnBarangKeluar.Text = "Barang Keluar"
        btnBarangKeluar.Image = New Bitmap(My.Resources.out, New Size(24, 24))
        btnBarangKeluar.ImageAlign = ContentAlignment.MiddleRight
        btnBarangKeluar.TextImageRelation = TextImageRelation.ImageBeforeText
        ' 
        ' btnLaporan
        ' 
        btnLaporan.Location = New Point(3, 271)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Size = New Size(195, 61)
        btnLaporan.TabIndex = 4
        btnLaporan.Text = "Laporan"
        btnLaporan.Image = New Bitmap(My.Resources.report, New Size(32, 32))
        btnLaporan.ImageAlign = ContentAlignment.MiddleRight
        btnLaporan.TextImageRelation = TextImageRelation.ImageBeforeText
        ' 
        ' btnManajemenP
        ' 
        btnManajemenP.Location = New Point(3, 338)
        btnManajemenP.Name = "btnManajemenP"
        btnManajemenP.Size = New Size(195, 61)
        btnManajemenP.TabIndex = 5
        btnManajemenP.Text = "Manajemen Pengguna"
        btnManajemenP.Image = New Bitmap(My.Resources.user, New Size(32, 32))
        btnManajemenP.ImageAlign = ContentAlignment.MiddleLeft
        btnManajemenP.TextImageRelation = TextImageRelation.ImageBeforeText
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(3, 405)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(195, 61)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.Image = New Bitmap(My.Resources.logout, New Size(32, 32))
        btnLogout.ImageAlign = ContentAlignment.MiddleRight
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(67, 22)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(72, 73)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 6
        PictureBox7.TabStop = False
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(3, 99)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(201, 31)
        lblUser.TabIndex = 7
        lblUser.Text = "admin"
        lblUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelKiri
        ' 
        PanelKiri.BackColor = SystemColors.ActiveCaption
        PanelKiri.Controls.Add(lblUser)
        PanelKiri.Controls.Add(PictureBox7)
        PanelKiri.Controls.Add(flowPanelMenu)
        PanelKiri.Dock = DockStyle.Left
        PanelKiri.Location = New Point(0, 0)
        PanelKiri.Margin = New Padding(3, 4, 3, 4)
        PanelKiri.Name = "PanelKiri"
        PanelKiri.Size = New Size(204, 639)
        PanelKiri.TabIndex = 3
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(1012, 639)
        Controls.Add(PanelKanan)
        Controls.Add(PanelKiri)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "partManager"
        flowPanelMenu.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        PanelKiri.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents PanelKanan As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents btnLogout As Button
    Private WithEvents btnLaporan As Button
    Private WithEvents btnBarangKeluar As Button
    Private WithEvents btnBarangMasuk As Button
    Private WithEvents btnDataBarang As Button
    Private WithEvents btnDashboard As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblUser As Label
    Private WithEvents btnManajemenP As Button
    Private WithEvents PanelKiri As Panel
    Private WithEvents flowPanelMenu As FlowLayoutPanel
End Class
