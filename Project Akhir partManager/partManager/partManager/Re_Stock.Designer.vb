<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Re_Stock
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
        txtSupplier = New TextBox()
        btnSimpan = New Button()
        btnBatal = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
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
        PanelHeader.Size = New Size(586, 55)
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
        lblHeader.Size = New Size(586, 55)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Re-Stock Barang"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbBarang
        ' 
        cbBarang.Font = New Font("Segoe UI", 9F)
        cbBarang.FormattingEnabled = True
        cbBarang.Location = New Point(170, 80)
        cbBarang.Name = "cbBarang"
        cbBarang.Size = New Size(320, 28)
        cbBarang.TabIndex = 0
        ' 
        ' nudJumlah
        ' 
        nudJumlah.Font = New Font("Segoe UI", 9F)
        nudJumlah.Location = New Point(170, 130)
        nudJumlah.Name = "nudJumlah"
        nudJumlah.Size = New Size(150, 27)
        nudJumlah.TabIndex = 1
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Font = New Font("Segoe UI", 9F)
        dtpTanggal.Location = New Point(170, 180)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(220, 27)
        dtpTanggal.TabIndex = 2
        ' 
        ' txtSupplier
        ' 
        txtSupplier.Font = New Font("Segoe UI", 9F)
        txtSupplier.Location = New Point(170, 230)
        txtSupplier.Name = "txtSupplier"
        txtSupplier.Size = New Size(320, 27)
        txtSupplier.TabIndex = 3
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(35), CByte(108), CByte(208))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(355, 295)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(135, 38)
        btnSimpan.TabIndex = 4
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
        btnBatal.Location = New Point(195, 295)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(120, 38)
        btnBatal.TabIndex = 5
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label1.Location = New Point(55, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 10
        Label1.Text = "Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label2.Location = New Point(55, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 11
        Label2.Text = "Jumlah"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label3.Location = New Point(55, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 12
        Label3.Text = "Tanggal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label4.Location = New Point(55, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 13
        Label4.Text = "Supplier"
        ' 
        ' Re_Stock
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(586, 380)
        Controls.Add(PanelHeader)
        Controls.Add(cbBarang)
        Controls.Add(Label1)
        Controls.Add(nudJumlah)
        Controls.Add(Label2)
        Controls.Add(dtpTanggal)
        Controls.Add(Label3)
        Controls.Add(txtSupplier)
        Controls.Add(Label4)
        Controls.Add(btnSimpan)
        Controls.Add(btnBatal)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Re_Stock"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Re-Stock Barang"
        PanelHeader.ResumeLayout(False)
        CType(nudJumlah, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents cbBarang As ComboBox
    Friend WithEvents nudJumlah As NumericUpDown
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
