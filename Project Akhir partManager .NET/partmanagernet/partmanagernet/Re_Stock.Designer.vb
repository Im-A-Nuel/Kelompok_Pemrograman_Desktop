<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Re_Stock
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.cbBarang = New System.Windows.Forms.ComboBox()
        Me.nudJumlah = New System.Windows.Forms.NumericUpDown()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelHeader.SuspendLayout()
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.lblHeader)
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(586, 44)
        Me.PanelHeader.TabIndex = 100
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
        Me.lblHeader.Size = New System.Drawing.Size(586, 44)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Re-Stock Barang"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbBarang
        '
        Me.cbBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbBarang.FormattingEnabled = True
        Me.cbBarang.Location = New System.Drawing.Point(170, 64)
        Me.cbBarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbBarang.Name = "cbBarang"
        Me.cbBarang.Size = New System.Drawing.Size(320, 28)
        Me.cbBarang.TabIndex = 0
        '
        'nudJumlah
        '
        Me.nudJumlah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudJumlah.Location = New System.Drawing.Point(170, 104)
        Me.nudJumlah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudJumlah.Name = "nudJumlah"
        Me.nudJumlah.Size = New System.Drawing.Size(150, 27)
        Me.nudJumlah.TabIndex = 1
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTanggal.Location = New System.Drawing.Point(170, 144)
        Me.dtpTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(220, 27)
        Me.dtpTanggal.TabIndex = 2
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSupplier.Location = New System.Drawing.Point(170, 184)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(320, 27)
        Me.txtSupplier.TabIndex = 3
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(355, 236)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(135, 30)
        Me.btnSimpan.TabIndex = 4
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Silver
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBatal.Location = New System.Drawing.Point(195, 236)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(120, 30)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(55, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(55, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Jumlah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(55, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(55, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Supplier"
        '
        'Re_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(586, 304)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.cbBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudJumlah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Re_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-Stock Barang"
        Me.PanelHeader.ResumeLayout(False)
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
