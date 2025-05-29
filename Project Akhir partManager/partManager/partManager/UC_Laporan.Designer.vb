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
        tablePanel = New TableLayoutPanel()
        Label16 = New Label()
        Label15 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Panel3 = New Panel()
        ButtonSavePDF = New Button()
        btnCari = New Button()
        Label3 = New Label()
        Label2 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        lblHeader = New Label()
        tablePanel.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' tablePanel
        ' 
        tablePanel.AutoScroll = True
        tablePanel.BackgroundImageLayout = ImageLayout.None
        tablePanel.ColumnCount = 7
        tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.401384F))
        tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.9550171F))
        tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.77551F))
        tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.3061228F))
        tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.5306129F))
        tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1554184F))
        tablePanel.Controls.Add(Label16, 6, 0)
        tablePanel.Controls.Add(Label15, 4, 0)
        tablePanel.Controls.Add(Label6, 3, 0)
        tablePanel.Controls.Add(Label5, 2, 0)
        tablePanel.Controls.Add(Label7, 1, 0)
        tablePanel.Controls.Add(Label13, 0, 0)
        tablePanel.Controls.Add(Label14, 5, 0)
        tablePanel.Location = New Point(32, 373)
        tablePanel.Margin = New Padding(3, 4, 3, 4)
        tablePanel.Name = "tablePanel"
        tablePanel.RowCount = 3
        tablePanel.RowStyles.Add(New RowStyle(SizeType.Percent, 28.5714283F))
        tablePanel.RowStyles.Add(New RowStyle(SizeType.Percent, 71.42857F))
        tablePanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 101F))
        tablePanel.Size = New Size(736, 216)
        tablePanel.TabIndex = 10
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(618, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 20)
        Label16.TabIndex = 6
        Label16.Text = "Supplier"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(350, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(66, 20)
        Label15.TabIndex = 5
        Label15.Text = "Kategori"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(238, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 20)
        Label6.TabIndex = 3
        Label6.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(174, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 20)
        Label5.TabIndex = 2
        Label5.Text = "Stok"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(50, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 20)
        Label7.TabIndex = 1
        Label7.Text = "Nama Barang"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(3, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(29, 20)
        Label13.TabIndex = 0
        Label13.Text = "No"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(471, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(107, 20)
        Label14.TabIndex = 4
        Label14.Text = "Tanggal Masuk"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(ButtonSavePDF)
        Panel3.Controls.Add(btnCari)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(DateTimePicker2)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Location = New Point(32, 101)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(744, 249)
        Panel3.TabIndex = 12
        ' 
        ' ButtonSavePDF
        ' 
        ButtonSavePDF.FlatStyle = FlatStyle.System
        ButtonSavePDF.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSavePDF.ForeColor = SystemColors.ActiveCaptionText
        ButtonSavePDF.Image = My.Resources.Resources.WIN_20240905_07_43_27_Pro
        ButtonSavePDF.Location = New Point(509, 47)
        ButtonSavePDF.Name = "ButtonSavePDF"
        ButtonSavePDF.Size = New Size(182, 170)
        ButtonSavePDF.TabIndex = 6
        ButtonSavePDF.Text = "🖨️" & vbCrLf & "Save as PDF"
        ButtonSavePDF.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(11, 201)
        btnCari.Margin = New Padding(3, 4, 3, 4)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(86, 31)
        btnCari.TabIndex = 5
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 20)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Selesai"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 3
        Label2.Text = "Tanggal Mulai"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(11, 124)
        DateTimePicker2.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(253, 27)
        DateTimePicker2.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(11, 47)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(253, 27)
        DateTimePicker1.TabIndex = 0
        ' 
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblHeader.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Padding = New Padding(18, 0, 0, 0)
        lblHeader.Size = New Size(808, 102)
        lblHeader.TabIndex = 13
        lblHeader.Text = "Laporan Barang"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UC_Laporan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(lblHeader)
        Controls.Add(tablePanel)
        Controls.Add(Panel3)
        Name = "UC_Laporan"
        Size = New Size(808, 618)
        tablePanel.ResumeLayout(False)
        tablePanel.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tablePanel As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCari As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ButtonSavePDF As Button
    Friend WithEvents lblHeader As Label

End Class
