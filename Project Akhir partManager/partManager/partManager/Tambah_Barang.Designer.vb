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
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(564, 59)
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
        ' txtStok
        ' 
        txtStok.Location = New Point(65, 205)
        txtStok.Margin = New Padding(3, 4, 3, 4)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(134, 27)
        txtStok.TabIndex = 6
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(65, 275)
        txtHarga.Margin = New Padding(3, 4, 3, 4)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(239, 27)
        txtHarga.TabIndex = 7
        ' 
        ' txtSupplier
        ' 
        txtSupplier.Location = New Point(65, 431)
        txtSupplier.Margin = New Padding(3, 4, 3, 4)
        txtSupplier.Name = "txtSupplier"
        txtSupplier.Size = New Size(348, 27)
        txtSupplier.TabIndex = 9
        ' 
        ' btnTambahBarang
        ' 
        btnTambahBarang.Location = New Point(402, 518)
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
        Label2.Size = New Size(38, 20)
        Label2.TabIndex = 12
        Label2.Text = "Stok"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 13
        Label3.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 14
        Label4.Text = "Kategori"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(65, 407)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 15
        Label5.Text = "Supplier"
        ' 
        ' cbKategori
        ' 
        cbKategori.FormattingEnabled = True
        cbKategori.Items.AddRange(New Object() {"Prosesor (CPU)", "Motherboard", "RAM (Memory)", "Harddisk / SSD", "Power Supply", "VGA (Graphics Card)", "Casing", "Monitor", "Keyboard", "Mouse", "Cooling Fan", "Kabel & Connector", "Network (LAN Card / Modem)", "Software / License", "Aksesoris"})
        cbKategori.Location = New Point(65, 353)
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
        ClientSize = New Size(561, 582)
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
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Tambah_Barang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form7"
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
