<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Laporan
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label16 = New Label()
        Label15 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Panel3 = New Panel()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackgroundImageLayout = ImageLayout.None
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.401384F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.9550171F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.77551F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.3061228F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.5306129F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1554184F))
        TableLayoutPanel1.Controls.Add(Label16, 6, 0)
        TableLayoutPanel1.Controls.Add(Label15, 4, 0)
        TableLayoutPanel1.Controls.Add(Label6, 3, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(Label7, 1, 0)
        TableLayoutPanel1.Controls.Add(Label13, 0, 0)
        TableLayoutPanel1.Controls.Add(Label14, 5, 0)
        TableLayoutPanel1.Location = New Point(28, 280)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 28.5714283F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 71.42857F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 76F))
        TableLayoutPanel1.Size = New Size(644, 162)
        TableLayoutPanel1.TabIndex = 10
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(541, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(50, 15)
        Label16.TabIndex = 6
        Label16.Text = "Supplier"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(307, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(51, 15)
        Label15.TabIndex = 5
        Label15.Text = "Kategori"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(209, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 3
        Label6.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(153, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 2
        Label5.Text = "Stok"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(44, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 15)
        Label7.TabIndex = 1
        Label7.Text = "Nama Barang"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(3, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(23, 15)
        Label13.TabIndex = 0
        Label13.Text = "No"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(413, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(87, 15)
        Label14.TabIndex = 4
        Label14.Text = "Tanggal Masuk"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(DateTimePicker2)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Location = New Point(28, 76)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(651, 187)
        Panel3.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(10, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Cari"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Selesai"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 3
        Label2.Text = "Tanggal Mulai"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(10, 93)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(222, 23)
        DateTimePicker2.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(10, 35)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(222, 23)
        DateTimePicker1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(38, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 32)
        Label1.TabIndex = 11
        Label1.Text = "Laporan Barang"
        ' 
        ' UC_Laporan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UC_Laporan"
        Size = New Size(707, 479)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label

End Class
