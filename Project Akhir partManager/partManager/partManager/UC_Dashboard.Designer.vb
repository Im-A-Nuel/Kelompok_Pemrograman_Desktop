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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblLvlAkses = New Label()
        lblUsername = New Label()
        Label14 = New Label()
        Label13 = New Label()
        lblDetail = New Label()
        PictureBox6 = New PictureBox()
        lblDataBarang = New Label()
        pbDataBarang = New PictureBox()
        lblHeader = New Label()
        labelJumlahMasuk = New Label()
        Panel1 = New Panel()
        tabelstok = New DataGridView()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        labelJumlahKeluar = New Label()
        lblBarangMasuk = New Label()
        pbBarangMasuk = New PictureBox()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDataBarang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(tabelstok, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(pbBarangMasuk, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblLvlAkses
        ' 
        lblLvlAkses.AutoSize = True
        lblLvlAkses.BackColor = Color.White
        lblLvlAkses.Location = New Point(177, 544)
        lblLvlAkses.Name = "lblLvlAkses"
        lblLvlAkses.Size = New Size(58, 20)
        lblLvlAkses.TabIndex = 37
        lblLvlAkses.Text = "ADMIN"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.White
        lblUsername.Location = New Point(177, 516)
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
        Label14.Location = New Point(47, 516)
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
        Label13.Location = New Point(47, 544)
        Label13.Name = "Label13"
        Label13.Size = New Size(90, 20)
        Label13.TabIndex = 34
        Label13.Text = "Level Akses"
        ' 
        ' lblDetail
        ' 
        lblDetail.AutoSize = True
        lblDetail.BackColor = Color.White
        lblDetail.Location = New Point(47, 484)
        lblDetail.Name = "lblDetail"
        lblDetail.Size = New Size(90, 20)
        lblDetail.TabIndex = 33
        lblDetail.Text = "Detail Login"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Location = New Point(43, 480)
        PictureBox6.Margin = New Padding(3, 4, 3, 4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(238, 92)
        PictureBox6.TabIndex = 32
        PictureBox6.TabStop = False
        ' 
        ' lblDataBarang
        ' 
        lblDataBarang.AutoSize = True
        lblDataBarang.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblDataBarang.ForeColor = Color.White
        lblDataBarang.Location = New Point(45, 106)
        lblDataBarang.Name = "lblDataBarang"
        lblDataBarang.Size = New Size(154, 20)
        lblDataBarang.TabIndex = 27
        lblDataBarang.Text = "Barang Masuk Hari Ini"
        ' 
        ' pbDataBarang
        ' 
        pbDataBarang.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        pbDataBarang.Dock = DockStyle.Fill
        pbDataBarang.Location = New Point(0, 0)
        pbDataBarang.Margin = New Padding(3, 4, 3, 4)
        pbDataBarang.Name = "pbDataBarang"
        pbDataBarang.Size = New Size(250, 147)
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
        ' labelJumlahMasuk
        ' 
        labelJumlahMasuk.AutoSize = True
        labelJumlahMasuk.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        labelJumlahMasuk.Font = New Font("Segoe UI", 40F, FontStyle.Bold)
        labelJumlahMasuk.ForeColor = SystemColors.ButtonFace
        labelJumlahMasuk.Location = New Point(84, 0)
        labelJumlahMasuk.Name = "labelJumlahMasuk"
        labelJumlahMasuk.Size = New Size(77, 89)
        labelJumlahMasuk.TabIndex = 41
        labelJumlahMasuk.Text = "0"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(tabelstok)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(319, 114)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(436, 327)
        Panel1.TabIndex = 43
        ' 
        ' tabelstok
        ' 
        tabelstok.BackgroundColor = Color.White
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        tabelstok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        tabelstok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabelstok.Dock = DockStyle.Fill
        tabelstok.Location = New Point(0, 20)
        tabelstok.Name = "tabelstok"
        tabelstok.ReadOnly = True
        tabelstok.RowHeadersWidth = 51
        tabelstok.Size = New Size(436, 307)
        tabelstok.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Top
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(394, 20)
        Label3.TabIndex = 0
        Label3.Text = "PERHATIAN! STOK BARANG BERIKUT HAMPIR HABIS!"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(labelJumlahMasuk)
        Panel2.Controls.Add(lblDataBarang)
        Panel2.Controls.Add(pbDataBarang)
        Panel2.Location = New Point(41, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 147)
        Panel2.TabIndex = 44
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(labelJumlahKeluar)
        Panel3.Controls.Add(lblBarangMasuk)
        Panel3.Controls.Add(pbBarangMasuk)
        Panel3.Location = New Point(41, 294)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 147)
        Panel3.TabIndex = 45
        ' 
        ' labelJumlahKeluar
        ' 
        labelJumlahKeluar.AutoSize = True
        labelJumlahKeluar.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        labelJumlahKeluar.Font = New Font("Segoe UI", 40F, FontStyle.Bold)
        labelJumlahKeluar.ForeColor = SystemColors.ButtonFace
        labelJumlahKeluar.Location = New Point(84, 0)
        labelJumlahKeluar.Name = "labelJumlahKeluar"
        labelJumlahKeluar.Size = New Size(77, 89)
        labelJumlahKeluar.TabIndex = 42
        labelJumlahKeluar.Text = "0"
        ' 
        ' lblBarangMasuk
        ' 
        lblBarangMasuk.AutoSize = True
        lblBarangMasuk.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblBarangMasuk.ForeColor = Color.White
        lblBarangMasuk.Location = New Point(49, 107)
        lblBarangMasuk.Name = "lblBarangMasuk"
        lblBarangMasuk.Size = New Size(154, 20)
        lblBarangMasuk.TabIndex = 28
        lblBarangMasuk.Text = "Barang Keluar Hari Ini"
        ' 
        ' pbBarangMasuk
        ' 
        pbBarangMasuk.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        pbBarangMasuk.Dock = DockStyle.Fill
        pbBarangMasuk.Location = New Point(0, 0)
        pbBarangMasuk.Margin = New Padding(3, 4, 3, 4)
        pbBarangMasuk.Name = "pbBarangMasuk"
        pbBarangMasuk.Size = New Size(250, 147)
        pbBarangMasuk.TabIndex = 24
        pbBarangMasuk.TabStop = False
        ' 
        ' UC_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblHeader)
        Controls.Add(lblLvlAkses)
        Controls.Add(lblUsername)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(lblDetail)
        Controls.Add(PictureBox6)
        Name = "UC_Dashboard"
        Size = New Size(808, 639)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDataBarang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(tabelstok, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(pbBarangMasuk, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblLvlAkses As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDetail As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblDataBarang As Label
    Friend WithEvents pbDataBarang As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents labelJumlahMasuk As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tabelstok As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelJumlahKeluar As Label
    Friend WithEvents lblBarangMasuk As Label
    Friend WithEvents pbBarangMasuk As PictureBox

End Class
