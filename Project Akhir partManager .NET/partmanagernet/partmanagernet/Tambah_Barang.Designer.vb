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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.btnTambahBarang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(561, 46)
        Me.Panel2.TabIndex = 4
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        Me.lblHeader.Size = New System.Drawing.Size(561, 46)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Tambah Data Barang"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaBarang.Location = New System.Drawing.Point(65, 76)
        Me.txtNamaBarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(410, 27)
        Me.txtNamaBarang.TabIndex = 1
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDeskripsi.Location = New System.Drawing.Point(65, 128)
        Me.txtDeskripsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDeskripsi.Multiline = True
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDeskripsi.Size = New System.Drawing.Size(410, 81)
        Me.txtDeskripsi.TabIndex = 2
        '
        'btnTambahBarang
        '
        Me.btnTambahBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnTambahBarang.FlatAppearance.BorderSize = 0
        Me.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambahBarang.ForeColor = System.Drawing.Color.White
        Me.btnTambahBarang.Location = New System.Drawing.Point(351, 311)
        Me.btnTambahBarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambahBarang.Name = "btnTambahBarang"
        Me.btnTambahBarang.Size = New System.Drawing.Size(128, 30)
        Me.btnTambahBarang.TabIndex = 4
        Me.btnTambahBarang.Text = "Tambah Barang"
        Me.btnTambahBarang.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(65, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(65, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Deskripsi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(65, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kategori"
        '
        'cbKategori
        '
        Me.cbKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Items.AddRange(New Object() {"Prosesor (CPU)", "Motherboard", "RAM (Memory)", "Harddisk / SSD", "Power Supply", "VGA (Graphics Card)", "Casing", "Monitor", "Keyboard", "Mouse", "Cooling Fan", "Kabel & Connector", "Network (LAN Card / Modem)", "Software / License", "Aksesoris"})
        Me.cbKategori.Location = New System.Drawing.Point(65, 240)
        Me.cbKategori.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(260, 28)
        Me.cbKategori.TabIndex = 3
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Silver
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBatal.Location = New System.Drawing.Point(205, 311)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(120, 30)
        Me.btnBatal.TabIndex = 15
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Tambah_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(561, 368)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDeskripsi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbKategori)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTambahBarang)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Tambah_Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Barang"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
