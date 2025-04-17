<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_DataBarang
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
        txtSearch = New TextBox()
        Label1 = New Label()
        btnAddBarang = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label32 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label16 = New Label()
        Label31 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label15 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(557, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 10
        Label2.Text = "search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(614, 49)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(156, 27)
        txtSearch.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 41)
        Label1.TabIndex = 7
        Label1.Text = "Barang"
        ' 
        ' btnAddBarang
        ' 
        btnAddBarang.Location = New Point(589, 12)
        btnAddBarang.Margin = New Padding(3, 4, 3, 4)
        btnAddBarang.Name = "btnAddBarang"
        btnAddBarang.Size = New Size(123, 29)
        btnAddBarang.TabIndex = 0
        btnAddBarang.Text = "Tambah Barang"
        btnAddBarang.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackgroundImageLayout = ImageLayout.None
        TableLayoutPanel1.ColumnCount = 9
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.749556F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.51865F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.77551F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.3061228F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.5306129F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1554184F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 59F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 79F))
        TableLayoutPanel1.Controls.Add(Label7, 5, 0)
        TableLayoutPanel1.Controls.Add(Label32, 8, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(Label4, 1, 0)
        TableLayoutPanel1.Controls.Add(Label16, 6, 0)
        TableLayoutPanel1.Controls.Add(Label31, 7, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(Label6, 3, 0)
        TableLayoutPanel1.Controls.Add(Label15, 4, 0)
        TableLayoutPanel1.Location = New Point(8, 58)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 82.4F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 17.6F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 48F))
        TableLayoutPanel1.Size = New Size(704, 351)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(625, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(51, 20)
        Label32.TabIndex = 35
        Label32.Text = "Hapus"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 20)
        Label3.TabIndex = 27
        Label3.Text = "No"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 40)
        Label4.TabIndex = 28
        Label4.Text = "Nama Barang"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(475, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 20)
        Label16.TabIndex = 33
        Label16.Text = "Supplier"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(566, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(35, 20)
        Label31.TabIndex = 34
        Label31.Text = "Edit"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(134, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 20)
        Label5.TabIndex = 29
        Label5.Text = "Stok"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(183, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 20)
        Label6.TabIndex = 30
        Label6.Text = "Harga"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(269, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(66, 20)
        Label15.TabIndex = 32
        Label15.Text = "Kategori"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TableLayoutPanel1)
        Panel3.Controls.Add(btnAddBarang)
        Panel3.Location = New Point(39, 94)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(731, 496)
        Panel3.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(362, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 20)
        Label7.TabIndex = 36
        Label7.Text = "Tanggal"
        ' 
        ' UC_DataBarang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Name = "UC_DataBarang"
        Size = New Size(808, 639)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddBarang As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label

End Class
