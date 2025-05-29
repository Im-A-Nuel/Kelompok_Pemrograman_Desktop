<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Barang_Keluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelHeader = New Panel()
        lblHeader = New Label()
        cbBarang = New ComboBox()
        nudJumlah = New NumericUpDown()
        dtpTanggal = New DateTimePicker()
        cbJenisKeluar = New ComboBox()
        txtTransaksi = New TextBox()
        txtKeterangan = New TextBox()
        btnSimpan = New Button()
        btnBatal = New Button()
        lblStokTersedia = New Label()
        lblBarang = New Label()
        lblJumlah = New Label()
        lblTanggal = New Label()
        lblJenis = New Label()
        lblTransaksi = New Label()
        lblKeterangan = New Label()
        PanelHeader.SuspendLayout()
        CType(nudJumlah, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(35), CByte(108), CByte(208))
        PanelHeader.Controls.Add(lblHeader)
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(760, 55)
        PanelHeader.TabIndex = 100
        ' 
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblHeader.Dock = DockStyle.Fill
        lblHeader.Font = New Font("Segoe UI", 13.75F, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Padding = New Padding(18, 0, 0, 0)
        lblHeader.Size = New Size(760, 55)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Barang Keluar"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbBarang
        ' 
        cbBarang.DropDownStyle = ComboBoxStyle.DropDownList
        cbBarang.Font = New Font("Segoe UI", 9F)
        cbBarang.Location = New Point(200, 72)
        cbBarang.Name = "cbBarang"
        cbBarang.Size = New Size(260, 28)
        cbBarang.TabIndex = 102
        ' 
        ' nudJumlah
        ' 
        nudJumlah.Font = New Font("Segoe UI", 9F)
        nudJumlah.Location = New Point(200, 117)
        nudJumlah.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nudJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudJumlah.Name = "nudJumlah"
        nudJumlah.Size = New Size(150, 27)
        nudJumlah.TabIndex = 105
        nudJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Font = New Font("Segoe UI", 9F)
        dtpTanggal.Location = New Point(200, 162)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(220, 27)
        dtpTanggal.TabIndex = 107
        ' 
        ' cbJenisKeluar
        ' 
        cbJenisKeluar.DropDownStyle = ComboBoxStyle.DropDownList
        cbJenisKeluar.Font = New Font("Segoe UI", 9F)
        cbJenisKeluar.Location = New Point(200, 207)
        cbJenisKeluar.Name = "cbJenisKeluar"
        cbJenisKeluar.Size = New Size(200, 28)
        cbJenisKeluar.TabIndex = 109
        ' 
        ' txtTransaksi
        ' 
        txtTransaksi.Font = New Font("Segoe UI", 9F)
        txtTransaksi.Location = New Point(200, 252)
        txtTransaksi.Name = "txtTransaksi"
        txtTransaksi.Size = New Size(250, 27)
        txtTransaksi.TabIndex = 111
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Font = New Font("Segoe UI", 9F)
        txtKeterangan.Location = New Point(200, 302)
        txtKeterangan.Multiline = True
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(350, 65)
        txtKeterangan.TabIndex = 113
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(35), CByte(108), CByte(208))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(560, 395)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(120, 38)
        btnSimpan.TabIndex = 114
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Silver
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        btnBatal.Location = New Point(430, 395)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(100, 38)
        btnBatal.TabIndex = 115
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' lblStokTersedia
        ' 
        lblStokTersedia.AutoSize = True
        lblStokTersedia.Font = New Font("Segoe UI", 10F, FontStyle.Italic)
        lblStokTersedia.ForeColor = Color.FromArgb(CByte(35), CByte(108), CByte(208))
        lblStokTersedia.Location = New Point(470, 76)
        lblStokTersedia.Name = "lblStokTersedia"
        lblStokTersedia.Size = New Size(59, 23)
        lblStokTersedia.TabIndex = 103
        lblStokTersedia.Text = "Stok: 0"
        ' 
        ' lblBarang
        ' 
        lblBarang.AutoSize = True
        lblBarang.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblBarang.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lblBarang.Location = New Point(55, 75)
        lblBarang.Name = "lblBarang"
        lblBarang.Size = New Size(59, 20)
        lblBarang.TabIndex = 101
        lblBarang.Text = "Barang"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblJumlah.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lblJumlah.Location = New Point(55, 120)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(60, 20)
        lblJumlah.TabIndex = 104
        lblJumlah.Text = "Jumlah"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTanggal.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lblTanggal.Location = New Point(55, 165)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(64, 20)
        lblTanggal.TabIndex = 106
        lblTanggal.Text = "Tanggal"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblJenis.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lblJenis.Location = New Point(55, 210)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(93, 20)
        lblJenis.TabIndex = 108
        lblJenis.Text = "Jenis Keluar"
        ' 
        ' lblTransaksi
        ' 
        lblTransaksi.AutoSize = True
        lblTransaksi.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTransaksi.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lblTransaksi.Location = New Point(55, 255)
        lblTransaksi.Name = "lblTransaksi"
        lblTransaksi.Size = New Size(103, 20)
        lblTransaksi.TabIndex = 110
        lblTransaksi.Text = "No. Transaksi"
        ' 
        ' lblKeterangan
        ' 
        lblKeterangan.AutoSize = True
        lblKeterangan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblKeterangan.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lblKeterangan.Location = New Point(55, 305)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(90, 20)
        lblKeterangan.TabIndex = 112
        lblKeterangan.Text = "Keterangan"
        ' 
        ' Tambah_Barang_Keluar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(760, 460)
        Controls.Add(PanelHeader)
        Controls.Add(lblBarang)
        Controls.Add(cbBarang)
        Controls.Add(lblStokTersedia)
        Controls.Add(lblJumlah)
        Controls.Add(nudJumlah)
        Controls.Add(lblTanggal)
        Controls.Add(dtpTanggal)
        Controls.Add(lblJenis)
        Controls.Add(cbJenisKeluar)
        Controls.Add(lblTransaksi)
        Controls.Add(txtTransaksi)
        Controls.Add(lblKeterangan)
        Controls.Add(txtKeterangan)
        Controls.Add(btnSimpan)
        Controls.Add(btnBatal)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Tambah_Barang_Keluar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Barang Keluar"
        PanelHeader.ResumeLayout(False)
        CType(nudJumlah, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Tambahkan di deklarasi:
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents cbBarang As ComboBox
    Friend WithEvents nudJumlah As NumericUpDown
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents cbJenisKeluar As ComboBox
    Friend WithEvents txtTransaksi As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblStokTersedia As Label
    Friend WithEvents lblBarang As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTransaksi As Label
    Friend WithEvents lblKeterangan As Label

End Class
