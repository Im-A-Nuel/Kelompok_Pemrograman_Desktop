<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Barang
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel2 = New Panel()
        txtNamaBarang = New TextBox()
        txtDeskripsi = New TextBox()
        btnTambahBarang = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        cbKategori = New ComboBox()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        Panel2.Location = New Point(1, -1)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(565, 59)
        Panel2.TabIndex = 4
        ' 
        ' txtNamaBarang
        ' 
        txtNamaBarang.Location = New Point(65, 135)
        txtNamaBarang.Margin = New Padding(3, 4, 3, 4)
        txtNamaBarang.Name = "txtNamaBarang"
        txtNamaBarang.Size = New Size(348, 27)
        txtNamaBarang.TabIndex = 5
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(65, 205)
        txtDeskripsi.Margin = New Padding(3, 4, 3, 4)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(460, 146)
        txtDeskripsi.TabIndex = 6
        ' 
        ' btnTambahBarang
        ' 
        btnTambahBarang.Location = New Point(402, 492)
        btnTambahBarang.Margin = New Padding(3, 4, 3, 4)
        btnTambahBarang.Name = "btnTambahBarang"
        btnTambahBarang.Size = New Size(123, 29)
        btnTambahBarang.TabIndex = 10
        btnTambahBarang.Text = "Tambah Barang"
        btnTambahBarang.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 11
        Label1.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 12
        Label2.Text = "Deskripsi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 365)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 14
        Label4.Text = "Kategori"
        ' 
        ' cbKategori
        ' 
        cbKategori.FormattingEnabled = True
        cbKategori.Items.AddRange(New Object() {"Prosesor (CPU)", "Motherboard", "RAM (Memory)", "Harddisk / SSD", "Power Supply", "VGA (Graphics Card)", "Casing", "Monitor", "Keyboard", "Mouse", "Cooling Fan", "Kabel & Connector", "Network (LAN Card / Modem)", "Software / License", "Aksesoris"})
        cbKategori.Location = New Point(65, 389)
        cbKategori.Margin = New Padding(3, 4, 3, 4)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(239, 28)
        cbKategori.TabIndex = 16
        ' 
        ' Tambah_Barang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(561, 546)
        Controls.Add(cbKategori)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnTambahBarang)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtNamaBarang)
        Controls.Add(Panel2)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Tambah_Barang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tambah Barang"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents btnTambahBarang As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbKategori As ComboBox
End Class
