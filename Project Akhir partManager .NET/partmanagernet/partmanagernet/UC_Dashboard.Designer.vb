<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Dashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblLvlAkses = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.lblDataBarang = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.labelJumlahMasuk = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tabelstok = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labelJumlahKeluar = New System.Windows.Forms.Label()
        Me.lblBarangMasuk = New System.Windows.Forms.Label()
        Me.pbBarangMasuk = New System.Windows.Forms.PictureBox()
        Me.pbDataBarang = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.tabelstok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pbBarangMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLvlAkses
        '
        Me.lblLvlAkses.AutoSize = True
        Me.lblLvlAkses.BackColor = System.Drawing.Color.White
        Me.lblLvlAkses.Location = New System.Drawing.Point(177, 435)
        Me.lblLvlAkses.Name = "lblLvlAkses"
        Me.lblLvlAkses.Size = New System.Drawing.Size(50, 16)
        Me.lblLvlAkses.TabIndex = 37
        Me.lblLvlAkses.Text = "ADMIN"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(177, 413)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(44, 16)
        Me.lblUsername.TabIndex = 36
        Me.lblUsername.Text = "admin"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(47, 413)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Username"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(47, 435)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 20)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Level Akses"
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.BackColor = System.Drawing.Color.White
        Me.lblDetail.Location = New System.Drawing.Point(47, 387)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(78, 16)
        Me.lblDetail.TabIndex = 33
        Me.lblDetail.Text = "Detail Login"
        '
        'lblDataBarang
        '
        Me.lblDataBarang.AutoSize = True
        Me.lblDataBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblDataBarang.ForeColor = System.Drawing.Color.White
        Me.lblDataBarang.Location = New System.Drawing.Point(45, 85)
        Me.lblDataBarang.Name = "lblDataBarang"
        Me.lblDataBarang.Size = New System.Drawing.Size(138, 16)
        Me.lblDataBarang.TabIndex = 27
        Me.lblDataBarang.Text = "Barang Masuk Hari Ini"
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        Me.lblHeader.Size = New System.Drawing.Size(808, 82)
        Me.lblHeader.TabIndex = 40
        Me.lblHeader.Text = "Dashboard"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelJumlahMasuk
        '
        Me.labelJumlahMasuk.AutoSize = True
        Me.labelJumlahMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.labelJumlahMasuk.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.labelJumlahMasuk.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelJumlahMasuk.Location = New System.Drawing.Point(63, 0)
        Me.labelJumlahMasuk.Name = "labelJumlahMasuk"
        Me.labelJumlahMasuk.Size = New System.Drawing.Size(77, 89)
        Me.labelJumlahMasuk.TabIndex = 41
        Me.labelJumlahMasuk.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tabelstok)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(319, 91)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 262)
        Me.Panel1.TabIndex = 43
        '
        'tabelstok
        '
        Me.tabelstok.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabelstok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tabelstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelstok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelstok.Location = New System.Drawing.Point(0, 20)
        Me.tabelstok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabelstok.Name = "tabelstok"
        Me.tabelstok.ReadOnly = True
        Me.tabelstok.RowHeadersWidth = 51
        Me.tabelstok.Size = New System.Drawing.Size(436, 242)
        Me.tabelstok.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(394, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PERHATIAN! STOK BARANG BERIKUT HAMPIR HABIS!"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.labelJumlahMasuk)
        Me.Panel2.Controls.Add(Me.lblDataBarang)
        Me.Panel2.Controls.Add(Me.pbDataBarang)
        Me.Panel2.Location = New System.Drawing.Point(41, 105)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 118)
        Me.Panel2.TabIndex = 44
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.labelJumlahKeluar)
        Me.Panel3.Controls.Add(Me.lblBarangMasuk)
        Me.Panel3.Controls.Add(Me.pbBarangMasuk)
        Me.Panel3.Location = New System.Drawing.Point(41, 235)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 118)
        Me.Panel3.TabIndex = 45
        '
        'labelJumlahKeluar
        '
        Me.labelJumlahKeluar.AutoSize = True
        Me.labelJumlahKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.labelJumlahKeluar.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.labelJumlahKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelJumlahKeluar.Location = New System.Drawing.Point(81, 0)
        Me.labelJumlahKeluar.Name = "labelJumlahKeluar"
        Me.labelJumlahKeluar.Size = New System.Drawing.Size(77, 89)
        Me.labelJumlahKeluar.TabIndex = 42
        Me.labelJumlahKeluar.Text = "0"
        '
        'lblBarangMasuk
        '
        Me.lblBarangMasuk.AutoSize = True
        Me.lblBarangMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblBarangMasuk.ForeColor = System.Drawing.Color.White
        Me.lblBarangMasuk.Location = New System.Drawing.Point(49, 86)
        Me.lblBarangMasuk.Name = "lblBarangMasuk"
        Me.lblBarangMasuk.Size = New System.Drawing.Size(136, 16)
        Me.lblBarangMasuk.TabIndex = 28
        Me.lblBarangMasuk.Text = "Barang Keluar Hari Ini"
        '
        'pbBarangMasuk
        '
        Me.pbBarangMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.pbBarangMasuk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbBarangMasuk.Location = New System.Drawing.Point(0, 0)
        Me.pbBarangMasuk.Name = "pbBarangMasuk"
        Me.pbBarangMasuk.Size = New System.Drawing.Size(250, 118)
        Me.pbBarangMasuk.TabIndex = 24
        Me.pbBarangMasuk.TabStop = False
        '
        'pbDataBarang
        '
        Me.pbDataBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.pbDataBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbDataBarang.Location = New System.Drawing.Point(0, 0)
        Me.pbDataBarang.Name = "pbDataBarang"
        Me.pbDataBarang.Size = New System.Drawing.Size(250, 118)
        Me.pbDataBarang.TabIndex = 23
        Me.pbDataBarang.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(43, 384)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(238, 74)
        Me.PictureBox6.TabIndex = 32
        Me.PictureBox6.TabStop = False
        '
        'UC_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblLvlAkses)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.PictureBox6)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UC_Dashboard"
        Me.Size = New System.Drawing.Size(792, 574)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tabelstok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pbBarangMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
