<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Dashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblLaporan = New Label()
        pbLaporan = New PictureBox()
        lblLvlAkses = New Label()
        lblUsername = New Label()
        Label14 = New Label()
        Label13 = New Label()
        lblDetail = New Label()
        PictureBox6 = New PictureBox()
        lblManPengguna = New Label()
        pbManPengguna = New PictureBox()
        lblBarangKeluar = New Label()
        lblBarangMasuk = New Label()
        lblDataBarang = New Label()
        pbBarangKeluar = New PictureBox()
        pbBarangMasuk = New PictureBox()
        pbDataBarang = New PictureBox()
        lblHeader = New Label()
        CType(pbLaporan, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbManPengguna, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBarangKeluar, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBarangMasuk, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDataBarang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblLaporan
        ' 
        lblLaporan.AutoSize = True
        lblLaporan.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblLaporan.ForeColor = Color.White
        lblLaporan.Location = New Point(325, 393)
        lblLaporan.Name = "lblLaporan"
        lblLaporan.Size = New Size(63, 20)
        lblLaporan.TabIndex = 39
        lblLaporan.Text = "Laporan"
        ' 
        ' pbLaporan
        ' 
        pbLaporan.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        pbLaporan.Location = New Point(305, 295)
        pbLaporan.Margin = New Padding(3, 4, 3, 4)
        pbLaporan.Name = "pbLaporan"
        pbLaporan.Size = New Size(199, 146)
        pbLaporan.TabIndex = 38
        pbLaporan.TabStop = False
        ' 
        ' lblLvlAkses
        ' 
        lblLvlAkses.AutoSize = True
        lblLvlAkses.BackColor = Color.White
        lblLvlAkses.Location = New Point(198, 563)
        lblLvlAkses.Name = "lblLvlAkses"
        lblLvlAkses.Size = New Size(58, 20)
        lblLvlAkses.TabIndex = 37
        lblLvlAkses.Text = "ADMIN"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.White
        lblUsername.Location = New Point(198, 535)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(51, 20)
        lblUsername.TabIndex = 36
        lblUsername.Text = "admin"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.White
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label14.Location = New Point(68, 535)
        Label14.Name = "Label14"
        Label14.Size = New Size(80, 20)
        Label14.TabIndex = 35
        Label14.Text = "Username"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.White
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label13.Location = New Point(68, 563)
        Label13.Name = "Label13"
        Label13.Size = New Size(90, 20)
        Label13.TabIndex = 34
        Label13.Text = "Level Akses"
        ' 
        ' lblDetail
        ' 
        lblDetail.AutoSize = True
        lblDetail.BackColor = Color.White
        lblDetail.Location = New Point(68, 503)
        lblDetail.Name = "lblDetail"
        lblDetail.Size = New Size(90, 20)
        lblDetail.TabIndex = 33
        lblDetail.Text = "Detail Login"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Location = New Point(64, 499)
        PictureBox6.Margin = New Padding(3, 4, 3, 4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(238, 92)
        PictureBox6.TabIndex = 32
        PictureBox6.TabStop = False
        ' 
        ' lblManPengguna
        ' 
        lblManPengguna.AutoSize = True
        lblManPengguna.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblManPengguna.ForeColor = Color.White
        lblManPengguna.Location = New Point(82, 396)
        lblManPengguna.Name = "lblManPengguna"
        lblManPengguna.Size = New Size(156, 20)
        lblManPengguna.TabIndex = 31
        lblManPengguna.Text = "Manajemen Pengguna"
        ' 
        ' pbManPengguna
        ' 
        pbManPengguna.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        pbManPengguna.Location = New Point(66, 295)
        pbManPengguna.Margin = New Padding(3, 4, 3, 4)
        pbManPengguna.Name = "pbManPengguna"
        pbManPengguna.Size = New Size(199, 146)
        pbManPengguna.TabIndex = 30
        pbManPengguna.TabStop = False
        ' 
        ' lblBarangKeluar
        ' 
        lblBarangKeluar.AutoSize = True
        lblBarangKeluar.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblBarangKeluar.ForeColor = Color.White
        lblBarangKeluar.Location = New Point(565, 228)
        lblBarangKeluar.Name = "lblBarangKeluar"
        lblBarangKeluar.Size = New Size(102, 20)
        lblBarangKeluar.TabIndex = 29
        lblBarangKeluar.Text = "Barang Keluar"
        ' 
        ' lblBarangMasuk
        ' 
        lblBarangMasuk.AutoSize = True
        lblBarangMasuk.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblBarangMasuk.ForeColor = Color.White
        lblBarangMasuk.Location = New Point(328, 226)
        lblBarangMasuk.Name = "lblBarangMasuk"
        lblBarangMasuk.Size = New Size(102, 20)
        lblBarangMasuk.TabIndex = 28
        lblBarangMasuk.Text = "Barang Masuk"
        ' 
        ' lblDataBarang
        ' 
        lblDataBarang.AutoSize = True
        lblDataBarang.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblDataBarang.ForeColor = Color.White
        lblDataBarang.Location = New Point(83, 226)
        lblDataBarang.Name = "lblDataBarang"
        lblDataBarang.Size = New Size(92, 20)
        lblDataBarang.TabIndex = 27
        lblDataBarang.Text = "Data Barang"
        ' 
        ' pbBarangKeluar
        ' 
        pbBarangKeluar.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        pbBarangKeluar.Location = New Point(545, 130)
        pbBarangKeluar.Margin = New Padding(3, 4, 3, 4)
        pbBarangKeluar.Name = "pbBarangKeluar"
        pbBarangKeluar.Size = New Size(199, 146)
        pbBarangKeluar.TabIndex = 25
        pbBarangKeluar.TabStop = False
        ' 
        ' pbBarangMasuk
        ' 
        pbBarangMasuk.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        pbBarangMasuk.Location = New Point(305, 130)
        pbBarangMasuk.Margin = New Padding(3, 4, 3, 4)
        pbBarangMasuk.Name = "pbBarangMasuk"
        pbBarangMasuk.Size = New Size(199, 146)
        pbBarangMasuk.TabIndex = 24
        pbBarangMasuk.TabStop = False
        ' 
        ' pbDataBarang
        ' 
        pbDataBarang.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        pbDataBarang.Location = New Point(66, 130)
        pbDataBarang.Margin = New Padding(3, 4, 3, 4)
        pbDataBarang.Name = "pbDataBarang"
        pbDataBarang.Size = New Size(199, 146)
        pbDataBarang.TabIndex = 23
        pbDataBarang.TabStop = False
        ' 
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblHeader.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Padding = New Padding(18, 0, 0, 0)
        lblHeader.Size = New Size(808, 102)
        lblHeader.TabIndex = 40
        lblHeader.Text = "Dashboard"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UC_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(lblHeader)
        Controls.Add(lblLaporan)
        Controls.Add(pbLaporan)
        Controls.Add(lblLvlAkses)
        Controls.Add(lblUsername)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(lblDetail)
        Controls.Add(PictureBox6)
        Controls.Add(lblManPengguna)
        Controls.Add(pbManPengguna)
        Controls.Add(lblBarangKeluar)
        Controls.Add(lblBarangMasuk)
        Controls.Add(lblDataBarang)
        Controls.Add(pbBarangKeluar)
        Controls.Add(pbBarangMasuk)
        Controls.Add(pbDataBarang)
        Name = "UC_Dashboard"
        Size = New Size(808, 639)
        CType(pbLaporan, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbManPengguna, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBarangKeluar, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBarangMasuk, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDataBarang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLaporan As Label
    Friend WithEvents pbLaporan As PictureBox
    Friend WithEvents lblLvlAkses As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDetail As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblManPengguna As Label
    Friend WithEvents pbManPengguna As PictureBox
    Friend WithEvents lblBarangKeluar As Label
    Friend WithEvents lblBarangMasuk As Label
    Friend WithEvents lblDataBarang As Label
    Friend WithEvents pbBarangKeluar As PictureBox
    Friend WithEvents pbBarangMasuk As PictureBox
    Friend WithEvents pbDataBarang As PictureBox
    Friend WithEvents lblHeader As Label

End Class
