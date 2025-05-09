<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerahkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GelapkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KurangiKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilkanHistgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EfekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TajamkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaburkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PutarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipHorzontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipVertikalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UjiKernel3x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tugas3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WatermarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InversiWarnaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaMerahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaHijauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaBiruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaSpesialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistogramToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbRed = New System.Windows.Forms.TrackBar()
        Me.tbGreen = New System.Windows.Forms.TrackBar()
        Me.tbBlue = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(723, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HistogramToolStripMenuItem, Me.EfekToolStripMenuItem, Me.Tugas3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.PropertiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'PropertiToolStripMenuItem
        '
        Me.PropertiToolStripMenuItem.Name = "PropertiToolStripMenuItem"
        Me.PropertiToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.PropertiToolStripMenuItem.Text = "Properti"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'HistogramToolStripMenuItem
        '
        Me.HistogramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreyscaleToolStripMenuItem, Me.CerahkanToolStripMenuItem, Me.GelapkanToolStripMenuItem, Me.TambahKontrasToolStripMenuItem, Me.KurangiKontrasToolStripMenuItem, Me.ResetToolStripMenuItem, Me.TampilkanHistgramToolStripMenuItem})
        Me.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        Me.HistogramToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.HistogramToolStripMenuItem.Text = "Histogram"
        '
        'GreyscaleToolStripMenuItem
        '
        Me.GreyscaleToolStripMenuItem.Name = "GreyscaleToolStripMenuItem"
        Me.GreyscaleToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.GreyscaleToolStripMenuItem.Text = "Greyscale"
        '
        'CerahkanToolStripMenuItem
        '
        Me.CerahkanToolStripMenuItem.Name = "CerahkanToolStripMenuItem"
        Me.CerahkanToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.CerahkanToolStripMenuItem.Text = "Cerahkan"
        '
        'GelapkanToolStripMenuItem
        '
        Me.GelapkanToolStripMenuItem.Name = "GelapkanToolStripMenuItem"
        Me.GelapkanToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.GelapkanToolStripMenuItem.Text = "Gelapkan"
        '
        'TambahKontrasToolStripMenuItem
        '
        Me.TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        Me.TambahKontrasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TambahKontrasToolStripMenuItem.Text = "Tambah Kontras"
        '
        'KurangiKontrasToolStripMenuItem
        '
        Me.KurangiKontrasToolStripMenuItem.Name = "KurangiKontrasToolStripMenuItem"
        Me.KurangiKontrasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.KurangiKontrasToolStripMenuItem.Text = "Kurangi Kontras"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'TampilkanHistgramToolStripMenuItem
        '
        Me.TampilkanHistgramToolStripMenuItem.Name = "TampilkanHistgramToolStripMenuItem"
        Me.TampilkanHistgramToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TampilkanHistgramToolStripMenuItem.Text = "Tampilkan Histogram"
        '
        'EfekToolStripMenuItem
        '
        Me.EfekToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TajamkanToolStripMenuItem, Me.KaburkanToolStripMenuItem, Me.PutarToolStripMenuItem, Me.FlipHorzontalToolStripMenuItem, Me.FlipVertikalToolStripMenuItem, Me.UjiKernel3x3ToolStripMenuItem})
        Me.EfekToolStripMenuItem.Name = "EfekToolStripMenuItem"
        Me.EfekToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.EfekToolStripMenuItem.Text = "Effects"
        '
        'TajamkanToolStripMenuItem
        '
        Me.TajamkanToolStripMenuItem.Name = "TajamkanToolStripMenuItem"
        Me.TajamkanToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.TajamkanToolStripMenuItem.Text = "Tajamkan"
        '
        'KaburkanToolStripMenuItem
        '
        Me.KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        Me.KaburkanToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.KaburkanToolStripMenuItem.Text = "Kaburkan"
        '
        'PutarToolStripMenuItem
        '
        Me.PutarToolStripMenuItem.Name = "PutarToolStripMenuItem"
        Me.PutarToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.PutarToolStripMenuItem.Text = "Putar 90 derajat"
        '
        'FlipHorzontalToolStripMenuItem
        '
        Me.FlipHorzontalToolStripMenuItem.Name = "FlipHorzontalToolStripMenuItem"
        Me.FlipHorzontalToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.FlipHorzontalToolStripMenuItem.Text = "Flip Horizontal"
        '
        'FlipVertikalToolStripMenuItem
        '
        Me.FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        Me.FlipVertikalToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.FlipVertikalToolStripMenuItem.Text = "Flip Vertikal"
        '
        'UjiKernel3x3ToolStripMenuItem
        '
        Me.UjiKernel3x3ToolStripMenuItem.Name = "UjiKernel3x3ToolStripMenuItem"
        Me.UjiKernel3x3ToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.UjiKernel3x3ToolStripMenuItem.Text = "Gaussian Blur"
        '
        'Tugas3ToolStripMenuItem
        '
        Me.Tugas3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorderToolStripMenuItem, Me.WatermarkToolStripMenuItem, Me.InversiWarnaToolStripMenuItem, Me.RonaMerahToolStripMenuItem, Me.RonaHijauToolStripMenuItem, Me.RonaBiruToolStripMenuItem, Me.RonaSpesialToolStripMenuItem, Me.HistogramToolStripMenuItem1})
        Me.Tugas3ToolStripMenuItem.Name = "Tugas3ToolStripMenuItem"
        Me.Tugas3ToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.Tugas3ToolStripMenuItem.Text = "Tugas 3"
        '
        'BorderToolStripMenuItem
        '
        Me.BorderToolStripMenuItem.Name = "BorderToolStripMenuItem"
        Me.BorderToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BorderToolStripMenuItem.Text = "Border"
        '
        'WatermarkToolStripMenuItem
        '
        Me.WatermarkToolStripMenuItem.Name = "WatermarkToolStripMenuItem"
        Me.WatermarkToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.WatermarkToolStripMenuItem.Text = "Watermark"
        '
        'InversiWarnaToolStripMenuItem
        '
        Me.InversiWarnaToolStripMenuItem.Name = "InversiWarnaToolStripMenuItem"
        Me.InversiWarnaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.InversiWarnaToolStripMenuItem.Text = "Inversi Warna"
        '
        'RonaMerahToolStripMenuItem
        '
        Me.RonaMerahToolStripMenuItem.Name = "RonaMerahToolStripMenuItem"
        Me.RonaMerahToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RonaMerahToolStripMenuItem.Text = "Rona Merah"
        '
        'RonaHijauToolStripMenuItem
        '
        Me.RonaHijauToolStripMenuItem.Name = "RonaHijauToolStripMenuItem"
        Me.RonaHijauToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RonaHijauToolStripMenuItem.Text = "Rona Hijau"
        '
        'RonaBiruToolStripMenuItem
        '
        Me.RonaBiruToolStripMenuItem.Name = "RonaBiruToolStripMenuItem"
        Me.RonaBiruToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RonaBiruToolStripMenuItem.Text = "Rona Biru"
        '
        'RonaSpesialToolStripMenuItem
        '
        Me.RonaSpesialToolStripMenuItem.Name = "RonaSpesialToolStripMenuItem"
        Me.RonaSpesialToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RonaSpesialToolStripMenuItem.Text = "Rona Spesial"
        '
        'HistogramToolStripMenuItem1
        '
        Me.HistogramToolStripMenuItem1.Name = "HistogramToolStripMenuItem1"
        Me.HistogramToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.HistogramToolStripMenuItem1.Text = "Histogram  Balok"
        '
        'tbRed
        '
        Me.tbRed.Location = New System.Drawing.Point(38, 478)
        Me.tbRed.Name = "tbRed"
        Me.tbRed.Size = New System.Drawing.Size(153, 56)
        Me.tbRed.TabIndex = 2
        '
        'tbGreen
        '
        Me.tbGreen.Location = New System.Drawing.Point(277, 478)
        Me.tbGreen.Name = "tbGreen"
        Me.tbGreen.Size = New System.Drawing.Size(153, 56)
        Me.tbGreen.TabIndex = 3
        '
        'tbBlue
        '
        Me.tbBlue.Location = New System.Drawing.Point(530, 478)
        Me.tbBlue.Name = "tbBlue"
        Me.tbBlue.Size = New System.Drawing.Size(153, 56)
        Me.tbBlue.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 518)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 518)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Green"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(591, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Blue"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 558)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbBlue)
        Me.Controls.Add(Me.tbGreen)
        Me.Controls.Add(Me.tbRed)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengolahan Citra"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerahkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelapkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurangiKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TampilkanHistgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EfekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PutarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipHorzontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UjiKernel3x3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tugas3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WatermarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InversiWarnaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaMerahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaHijauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaBiruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaSpesialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tbRed As TrackBar
    Friend WithEvents tbGreen As TrackBar
    Friend WithEvents tbBlue As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
