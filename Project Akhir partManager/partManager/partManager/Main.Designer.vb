<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        PanelKanan = New Panel()
        PanelKiri = New Panel()
        Label8 = New Label()
        PictureBox7 = New PictureBox()
        btnDashboard = New Button()
        btnDataBarang = New Button()
        btnBarangMasuk = New Button()
        btnBarangKeluar = New Button()
        btnLaporan = New Button()
        btnLogout = New Button()
        btnManajemenP = New Button()
        PanelKiri.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelKanan
        ' 
        PanelKanan.BackColor = Color.White
        PanelKanan.Dock = DockStyle.Fill
        PanelKanan.Location = New Point(204, 0)
        PanelKanan.Margin = New Padding(3, 4, 3, 4)
        PanelKanan.Name = "PanelKanan"
        PanelKanan.Size = New Size(808, 639)
        PanelKanan.TabIndex = 2
        ' 
        ' PanelKiri
        ' 
        PanelKiri.BackColor = SystemColors.ActiveCaption
        PanelKiri.Controls.Add(btnManajemenP)
        PanelKiri.Controls.Add(Label8)
        PanelKiri.Controls.Add(PictureBox7)
        PanelKiri.Controls.Add(btnDashboard)
        PanelKiri.Controls.Add(btnDataBarang)
        PanelKiri.Controls.Add(btnBarangMasuk)
        PanelKiri.Controls.Add(btnBarangKeluar)
        PanelKiri.Controls.Add(btnLaporan)
        PanelKiri.Controls.Add(btnLogout)
        PanelKiri.Dock = DockStyle.Left
        PanelKiri.Location = New Point(0, 0)
        PanelKiri.Margin = New Padding(3, 4, 3, 4)
        PanelKiri.Name = "PanelKiri"
        PanelKiri.Size = New Size(204, 639)
        PanelKiri.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(75, 99)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 7
        Label8.Text = "admin"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.WIN_20240905_07_43_27_Pro
        PictureBox7.Location = New Point(53, 22)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(88, 73)
        PictureBox7.TabIndex = 6
        PictureBox7.TabStop = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(12, 146)
        btnDashboard.Margin = New Padding(3, 4, 3, 4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(180, 50)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        ' 
        ' btnDataBarang
        ' 
        btnDataBarang.Location = New Point(12, 209)
        btnDataBarang.Margin = New Padding(3, 4, 3, 4)
        btnDataBarang.Name = "btnDataBarang"
        btnDataBarang.Size = New Size(180, 50)
        btnDataBarang.TabIndex = 1
        btnDataBarang.Text = "Data Barang"
        ' 
        ' btnBarangMasuk
        ' 
        btnBarangMasuk.Location = New Point(12, 271)
        btnBarangMasuk.Margin = New Padding(3, 4, 3, 4)
        btnBarangMasuk.Name = "btnBarangMasuk"
        btnBarangMasuk.Size = New Size(180, 50)
        btnBarangMasuk.TabIndex = 2
        btnBarangMasuk.Text = "Barang Masuk"
        ' 
        ' btnBarangKeluar
        ' 
        btnBarangKeluar.Location = New Point(12, 333)
        btnBarangKeluar.Margin = New Padding(3, 4, 3, 4)
        btnBarangKeluar.Name = "btnBarangKeluar"
        btnBarangKeluar.Size = New Size(180, 50)
        btnBarangKeluar.TabIndex = 3
        btnBarangKeluar.Text = "Barang Keluar"
        ' 
        ' btnLaporan
        ' 
        btnLaporan.Location = New Point(12, 396)
        btnLaporan.Margin = New Padding(3, 4, 3, 4)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Size = New Size(180, 50)
        btnLaporan.TabIndex = 4
        btnLaporan.Text = "Laporan"
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(12, 531)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(180, 50)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        ' 
        ' btnManajemenP
        ' 
        btnManajemenP.Location = New Point(12, 463)
        btnManajemenP.Margin = New Padding(3, 4, 3, 4)
        btnManajemenP.Name = "btnManajemenP"
        btnManajemenP.Size = New Size(180, 50)
        btnManajemenP.TabIndex = 8
        btnManajemenP.Text = "Manajemen Pengguna"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(1012, 639)
        Controls.Add(PanelKanan)
        Controls.Add(PanelKiri)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "partManager"
        PanelKiri.ResumeLayout(False)
        PanelKiri.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents PanelKanan As Panel
    Private WithEvents PanelKiri As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Private WithEvents btnDashboard As Button
    Private WithEvents btnDataBarang As Button
    Private WithEvents btnBarangMasuk As Button
    Private WithEvents btnBarangKeluar As Button
    Private WithEvents btnLaporan As Button
    Private WithEvents btnLogout As Button
    Private WithEvents btnManajemenP As Button
End Class
