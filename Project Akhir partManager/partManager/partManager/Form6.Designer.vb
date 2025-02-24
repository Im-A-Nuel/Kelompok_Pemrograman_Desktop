<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Panel1 = New Panel()
        Label17 = New Label()
        Button6 = New Button()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        PictureBox7 = New PictureBox()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Location = New Point(1, -1)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 640)
        Panel1.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F)
        Label17.Location = New Point(14, 358)
        Label17.Name = "Label17"
        Label17.Size = New Size(206, 28)
        Label17.TabIndex = 9
        Label17.Text = "Manajemen Pengguna"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(62, 572)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(101, 37)
        Button6.TabIndex = 8
        Button6.Text = "Keluar"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(14, 316)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 28)
        Label12.TabIndex = 5
        Label12.Text = "Laporan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(14, 270)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 28)
        Label11.TabIndex = 4
        Label11.Text = "Penjualan"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(14, 222)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 28)
        Label10.TabIndex = 3
        Label10.Text = "Barang"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(13, 180)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 28)
        Label9.TabIndex = 2
        Label9.Text = "Dashboard"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(62, 84)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 1
        Label8.Text = "admin"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Location = New Point(14, 66)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(42, 50)
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        Panel2.Location = New Point(1, -1)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1011, 58)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(266, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 41)
        Label1.TabIndex = 8
        Label1.Text = "Laporan"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1012, 639)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form6"
        Text = "partManager"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
