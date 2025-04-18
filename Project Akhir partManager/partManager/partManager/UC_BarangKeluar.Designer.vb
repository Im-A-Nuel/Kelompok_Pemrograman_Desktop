<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_BarangKeluar
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
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label32 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label31 = New Label()
        Panel3 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(494, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 17
        Label2.Text = "search:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(543, 49)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(126, 23)
        TextBox1.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 32)
        Label1.TabIndex = 15
        Label1.Text = "Barang Keluar"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(545, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(41, 15)
        Label32.TabIndex = 26
        Label32.Text = "Hapus"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(414, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(50, 15)
        Label16.TabIndex = 6
        Label16.Text = "Supplier"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(235, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(51, 15)
        Label15.TabIndex = 5
        Label15.Text = "Kategori"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(160, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 3
        Label6.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(117, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 2
        Label5.Text = "Stok"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 30)
        Label4.TabIndex = 1
        Label4.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(23, 15)
        Label3.TabIndex = 0
        Label3.Text = "No"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(316, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 15)
        Label7.TabIndex = 4
        Label7.Text = "Tanggal Keluar"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(493, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(27, 15)
        Label31.TabIndex = 21
        Label31.Text = "Edit"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TableLayoutPanel1)
        Panel3.Location = New Point(38, 77)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(629, 362)
        Panel3.TabIndex = 18
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackgroundImageLayout = ImageLayout.None
        TableLayoutPanel1.ColumnCount = 9
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.401384F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.9550171F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.77551F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.3061228F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.5306129F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1554184F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 52F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 74F))
        TableLayoutPanel1.Controls.Add(Label32, 8, 0)
        TableLayoutPanel1.Controls.Add(Label16, 6, 0)
        TableLayoutPanel1.Controls.Add(Label15, 4, 0)
        TableLayoutPanel1.Controls.Add(Label6, 3, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(Label4, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(Label7, 5, 0)
        TableLayoutPanel1.Controls.Add(Label31, 7, 0)
        TableLayoutPanel1.Location = New Point(7, 41)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 28.5714283F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 71.42857F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 76F))
        TableLayoutPanel1.Size = New Size(620, 233)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' UC_BarangKeluar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UC_BarangKeluar"
        Size = New Size(707, 479)
        Panel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
