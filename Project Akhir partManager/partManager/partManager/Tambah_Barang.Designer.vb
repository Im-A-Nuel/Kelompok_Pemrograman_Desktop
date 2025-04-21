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
        txtStok = New TextBox()
        txtHarga = New TextBox()
        txtSupplier = New TextBox()
        btnTambahBarang = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        cbKategori = New ComboBox()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        Panel2.Location = New Point(1, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(494, 44)
        Panel2.TabIndex = 4
        ' 
        ' txtNamaBarang
        ' 
        txtNamaBarang.Location = New Point(57, 101)
        txtNamaBarang.Name = "txtNamaBarang"
        txtNamaBarang.Size = New Size(305, 23)
        txtNamaBarang.TabIndex = 5
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(57, 154)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(118, 23)
        txtStok.TabIndex = 6
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(57, 206)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(210, 23)
        txtHarga.TabIndex = 7
        ' 
        ' txtSupplier
        ' 
        txtSupplier.Location = New Point(57, 323)
        txtSupplier.Name = "txtSupplier"
        txtSupplier.Size = New Size(305, 23)
        txtSupplier.TabIndex = 9
        ' 
        ' btnTambahBarang
        ' 
        btnTambahBarang.Location = New Point(352, 388)
        btnTambahBarang.Name = "btnTambahBarang"
        btnTambahBarang.Size = New Size(108, 22)
        btnTambahBarang.TabIndex = 10
        btnTambahBarang.Text = "Tambah Barang"
        btnTambahBarang.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 11
        Label1.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 12
        Label2.Text = "Stok"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 13
        Label3.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(57, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 14
        Label4.Text = "Kategori"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(57, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 15
        Label5.Text = "Supplier"
        ' 
        ' cbKategori
        ' 
        cbKategori.FormattingEnabled = True
        cbKategori.Items.AddRange(New Object() {"Prosesor (CPU)", "Motherboard", "RAM (Memory)", "Harddisk / SSD", "Power Supply", "VGA (Graphics Card)", "Casing", "Monitor", "Keyboard", "Mouse", "Cooling Fan", "Kabel & Connector", "Network (LAN Card / Modem)", "Software / License", "Aksesoris"})
        cbKategori.Location = New Point(57, 265)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(210, 23)
        cbKategori.TabIndex = 16
        ' 
        ' Tambah_Barang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(491, 436)
        Controls.Add(cbKategori)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnTambahBarang)
        Controls.Add(txtSupplier)
        Controls.Add(txtHarga)
        Controls.Add(txtStok)
        Controls.Add(txtNamaBarang)
        Controls.Add(Panel2)
        MaximizeBox = False
        Name = "Tambah_Barang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tambah Barang"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents btnTambahBarang As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbKategori As ComboBox
End Class
