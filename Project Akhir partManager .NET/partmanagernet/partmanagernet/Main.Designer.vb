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
        Me.PanelKanan = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.flowPanelMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnDataBarang = New System.Windows.Forms.Button()
        Me.btnBarangMasuk = New System.Windows.Forms.Button()
        Me.btnBarangKeluar = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnManajemenP = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PanelKiri = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.flowPanelMenu.SuspendLayout()
        Me.PanelKiri.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelKanan
        '
        Me.PanelKanan.BackColor = System.Drawing.Color.White
        Me.PanelKanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKanan.Location = New System.Drawing.Point(238, 0)
        Me.PanelKanan.Name = "PanelKanan"
        Me.PanelKanan.Size = New System.Drawing.Size(792, 574)
        Me.PanelKanan.TabIndex = 2
        '
        'flowPanelMenu
        '
        Me.flowPanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.flowPanelMenu.Controls.Add(Me.btnDashboard)
        Me.flowPanelMenu.Controls.Add(Me.btnDataBarang)
        Me.flowPanelMenu.Controls.Add(Me.btnBarangMasuk)
        Me.flowPanelMenu.Controls.Add(Me.btnBarangKeluar)
        Me.flowPanelMenu.Controls.Add(Me.btnLaporan)
        Me.flowPanelMenu.Controls.Add(Me.btnManajemenP)
        Me.flowPanelMenu.Controls.Add(Me.btnLogout)
        Me.flowPanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowPanelMenu.Location = New System.Drawing.Point(0, 104)
        Me.flowPanelMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.flowPanelMenu.Name = "flowPanelMenu"
        Me.flowPanelMenu.Size = New System.Drawing.Size(230, 461)
        Me.flowPanelMenu.TabIndex = 10
        Me.flowPanelMenu.WrapContents = False
        '
        'btnDashboard
        '
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.Location = New System.Drawing.Point(3, 2)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(195, 49)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnDataBarang
        '
        Me.btnDataBarang.Image = CType(resources.GetObject("btnDataBarang.Image"), System.Drawing.Image)
        Me.btnDataBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDataBarang.Location = New System.Drawing.Point(3, 55)
        Me.btnDataBarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDataBarang.Name = "btnDataBarang"
        Me.btnDataBarang.Size = New System.Drawing.Size(195, 49)
        Me.btnDataBarang.TabIndex = 1
        Me.btnDataBarang.Text = "Data Barang"
        Me.btnDataBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnBarangMasuk
        '
        Me.btnBarangMasuk.Image = CType(resources.GetObject("btnBarangMasuk.Image"), System.Drawing.Image)
        Me.btnBarangMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBarangMasuk.Location = New System.Drawing.Point(3, 108)
        Me.btnBarangMasuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBarangMasuk.Name = "btnBarangMasuk"
        Me.btnBarangMasuk.Size = New System.Drawing.Size(195, 49)
        Me.btnBarangMasuk.TabIndex = 2
        Me.btnBarangMasuk.Text = "Barang Masuk"
        Me.btnBarangMasuk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnBarangKeluar
        '
        Me.btnBarangKeluar.Image = CType(resources.GetObject("btnBarangKeluar.Image"), System.Drawing.Image)
        Me.btnBarangKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBarangKeluar.Location = New System.Drawing.Point(3, 161)
        Me.btnBarangKeluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBarangKeluar.Name = "btnBarangKeluar"
        Me.btnBarangKeluar.Size = New System.Drawing.Size(195, 49)
        Me.btnBarangKeluar.TabIndex = 3
        Me.btnBarangKeluar.Text = "Barang Keluar"
        Me.btnBarangKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnLaporan
        '
        Me.btnLaporan.Image = CType(resources.GetObject("btnLaporan.Image"), System.Drawing.Image)
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLaporan.Location = New System.Drawing.Point(3, 214)
        Me.btnLaporan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(195, 49)
        Me.btnLaporan.TabIndex = 4
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnManajemenP
        '
        Me.btnManajemenP.Image = CType(resources.GetObject("btnManajemenP.Image"), System.Drawing.Image)
        Me.btnManajemenP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManajemenP.Location = New System.Drawing.Point(3, 267)
        Me.btnManajemenP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnManajemenP.Name = "btnManajemenP"
        Me.btnManajemenP.Size = New System.Drawing.Size(195, 49)
        Me.btnManajemenP.TabIndex = 5
        Me.btnManajemenP.Text = "Manajemen Pengguna"
        Me.btnManajemenP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnLogout
        '
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.Location = New System.Drawing.Point(3, 320)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(195, 49)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(17, 73)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(201, 25)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "admin"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelKiri
        '
        Me.PanelKiri.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelKiri.Controls.Add(Me.lblUser)
        Me.PanelKiri.Controls.Add(Me.PictureBox7)
        Me.PanelKiri.Controls.Add(Me.flowPanelMenu)
        Me.PanelKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelKiri.Location = New System.Drawing.Point(0, 0)
        Me.PanelKiri.Name = "PanelKiri"
        Me.PanelKiri.Size = New System.Drawing.Size(238, 574)
        Me.PanelKiri.TabIndex = 3
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.partmanagernet.My.Resources.Resources.profile_user1
        Me.PictureBox7.Location = New System.Drawing.Point(89, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 58)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 574)
        Me.Controls.Add(Me.PanelKanan)
        Me.Controls.Add(Me.PanelKiri)
        Me.DoubleBuffered = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "partManager"
        Me.flowPanelMenu.ResumeLayout(False)
        Me.PanelKiri.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
