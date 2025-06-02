<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Laporan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnGrafik = New System.Windows.Forms.Button()
        Me.ButtonSavePDF = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewRiwayat = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnGrafik)
        Me.Panel3.Controls.Add(Me.ButtonSavePDF)
        Me.Panel3.Controls.Add(Me.btnCari)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DateTimePicker2)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Location = New System.Drawing.Point(32, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(744, 199)
        Me.Panel3.TabIndex = 12
        '
        'btnGrafik
        '
        Me.btnGrafik.Location = New System.Drawing.Point(114, 161)
        Me.btnGrafik.Name = "btnGrafik"
        Me.btnGrafik.Size = New System.Drawing.Size(86, 25)
        Me.btnGrafik.TabIndex = 7
        Me.btnGrafik.Text = "Chart"
        Me.btnGrafik.UseVisualStyleBackColor = True
        '
        'ButtonSavePDF
        '
        Me.ButtonSavePDF.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonSavePDF.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSavePDF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonSavePDF.Location = New System.Drawing.Point(509, 37)
        Me.ButtonSavePDF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSavePDF.Name = "ButtonSavePDF"
        Me.ButtonSavePDF.Size = New System.Drawing.Size(182, 137)
        Me.ButtonSavePDF.TabIndex = 6
        Me.ButtonSavePDF.Text = "🖨️" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save as PDF"
        Me.ButtonSavePDF.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(11, 161)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(86, 25)
        Me.btnCari.TabIndex = 5
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal Selesai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal Mulai"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(11, 99)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(253, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(11, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(253, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        Me.lblHeader.Size = New System.Drawing.Size(808, 81)
        Me.lblHeader.TabIndex = 13
        Me.lblHeader.Text = "Laporan Barang"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewRiwayat)
        Me.Panel1.Location = New System.Drawing.Point(32, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 233)
        Me.Panel1.TabIndex = 14
        '
        'DataGridViewRiwayat
        '
        Me.DataGridViewRiwayat.ColumnHeadersHeight = 29
        Me.DataGridViewRiwayat.Location = New System.Drawing.Point(0, 3)
        Me.DataGridViewRiwayat.Name = "DataGridViewRiwayat"
        Me.DataGridViewRiwayat.RowHeadersWidth = 51
        Me.DataGridViewRiwayat.Size = New System.Drawing.Size(741, 227)
        Me.DataGridViewRiwayat.TabIndex = 0
        '
        'UC_Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UC_Laporan"
        Me.Size = New System.Drawing.Size(792, 574)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents btnGrafik As Button

End Class
