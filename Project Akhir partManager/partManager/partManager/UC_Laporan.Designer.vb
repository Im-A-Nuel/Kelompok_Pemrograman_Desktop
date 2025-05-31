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
        Panel3 = New Panel()
        ButtonSavePDF = New Button()
        btnCari = New Button()
        Label3 = New Label()
        Label2 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        lblHeader = New Label()
        Panel1 = New Panel()
        DataGridViewRiwayat = New DataGridView()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(ButtonSavePDF)
        Panel3.Controls.Add(btnCari)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(DateTimePicker2)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Location = New Point(28, 76)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(651, 187)
        Panel3.TabIndex = 12
        ' 
        ' ButtonSavePDF
        ' 
        ButtonSavePDF.FlatStyle = FlatStyle.System
        ButtonSavePDF.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSavePDF.ForeColor = SystemColors.ActiveCaptionText
        ButtonSavePDF.Image = My.Resources.Resources.WIN_20240905_07_43_27_Pro
        ButtonSavePDF.Location = New Point(445, 35)
        ButtonSavePDF.Margin = New Padding(3, 2, 3, 2)
        ButtonSavePDF.Name = "ButtonSavePDF"
        ButtonSavePDF.Size = New Size(159, 128)
        ButtonSavePDF.TabIndex = 6
        ButtonSavePDF.Text = "🖨️" & vbCrLf & "Save as PDF"
        ButtonSavePDF.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(10, 151)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(75, 23)
        btnCari.TabIndex = 5
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
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
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblHeader.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Padding = New Padding(16, 0, 0, 0)
        lblHeader.Size = New Size(707, 76)
        lblHeader.TabIndex = 13
        lblHeader.Text = "Laporan Barang"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridViewRiwayat)
        Panel1.Location = New Point(28, 282)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(651, 165)
        Panel1.TabIndex = 14
        ' 
        ' DataGridViewRiwayat
        ' 
        DataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewRiwayat.Dock = DockStyle.Fill
        DataGridViewRiwayat.Location = New Point(0, 0)
        DataGridViewRiwayat.Name = "DataGridViewRiwayat"
        DataGridViewRiwayat.Size = New Size(651, 165)
        DataGridViewRiwayat.TabIndex = 0
        ' 
        ' UC_Laporan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(Panel1)
        Controls.Add(lblHeader)
        Controls.Add(Panel3)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UC_Laporan"
        Size = New Size(707, 464)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCari As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ButtonSavePDF As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewRiwayat As DataGridView

End Class
