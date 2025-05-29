Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tambah_Barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Panel2 = New Panel()
        lblHeader = New Label()
        txtNamaBarang = New TextBox()
        txtDeskripsi = New TextBox()
        btnTambahBarang = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        cbKategori = New ComboBox()
        btnBatal = New Button()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(35), CByte(108), CByte(208))
        Panel2.Controls.Add(lblHeader)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(561, 58)
        Panel2.TabIndex = 4
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
        lblHeader.Size = New Size(561, 58)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Tambah Data Barang"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNamaBarang
        ' 
        txtNamaBarang.Font = New Font("Segoe UI", 9F)
        txtNamaBarang.Location = New Point(65, 95)
        txtNamaBarang.Name = "txtNamaBarang"
        txtNamaBarang.Size = New Size(410, 27)
        txtNamaBarang.TabIndex = 1
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Font = New Font("Segoe UI", 9F)
        txtDeskripsi.Location = New Point(65, 160)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(410, 100)
        txtDeskripsi.TabIndex = 2
        ' 
        ' btnTambahBarang
        ' 
        btnTambahBarang.BackColor = Color.FromArgb(CByte(35), CByte(108), CByte(208))
        btnTambahBarang.FlatAppearance.BorderSize = 0
        btnTambahBarang.FlatStyle = FlatStyle.Flat
        btnTambahBarang.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnTambahBarang.ForeColor = Color.White
        btnTambahBarang.Location = New Point(351, 389)
        btnTambahBarang.Name = "btnTambahBarang"
        btnTambahBarang.Size = New Size(128, 34)
        btnTambahBarang.TabIndex = 4
        btnTambahBarang.Text = "Tambah Barang"
        btnTambahBarang.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label1.Location = New Point(65, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 20)
        Label1.TabIndex = 11
        Label1.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label2.Location = New Point(65, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 12
        Label2.Text = "Deskripsi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label4.Location = New Point(65, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 14
        Label4.Text = "Kategori"
        ' 
        ' cbKategori
        ' 
        cbKategori.Font = New Font("Segoe UI", 9F)
        cbKategori.FormattingEnabled = True
        cbKategori.Items.AddRange(New Object() {"Prosesor (CPU)", "Motherboard", "RAM (Memory)", "Harddisk / SSD", "Power Supply", "VGA (Graphics Card)", "Casing", "Monitor", "Keyboard", "Mouse", "Cooling Fan", "Kabel & Connector", "Network (LAN Card / Modem)", "Software / License", "Aksesoris"})
        cbKategori.Location = New Point(65, 300)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(260, 28)
        cbKategori.TabIndex = 3
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Silver
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        btnBatal.Location = New Point(205, 389)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(120, 38)
        btnBatal.TabIndex = 15
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Tambah_Barang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(561, 460)
        Controls.Add(btnBatal)
        Controls.Add(Panel2)
        Controls.Add(txtNamaBarang)
        Controls.Add(Label1)
        Controls.Add(txtDeskripsi)
        Controls.Add(Label2)
        Controls.Add(cbKategori)
        Controls.Add(Label4)
        Controls.Add(btnTambahBarang)
        MaximizeBox = False
        Name = "Tambah_Barang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tambah Barang"
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Tambahkan variabel lblHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents btnTambahBarang As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents btnBatal As Button
End Class
