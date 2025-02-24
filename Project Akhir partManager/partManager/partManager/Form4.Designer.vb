<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label14 = New Label()
        Label13 = New Label()
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
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(178, 450)
        Panel1.TabIndex = 2
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F)
        Label14.Location = New Point(12, 272)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 21)
        Label14.TabIndex = 7
        Label14.Text = "Laporan"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F)
        Label13.Location = New Point(12, 420)
        Label13.Name = "Label13"
        Label13.Size = New Size(54, 21)
        Label13.TabIndex = 6
        Label13.Text = "Keluar"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(12, 237)
        Label12.Name = "Label12"
        Label12.Size = New Size(77, 21)
        Label12.TabIndex = 5
        Label12.Text = "Penjualan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(12, 202)
        Label11.Name = "Label11"
        Label11.Size = New Size(109, 21)
        Label11.TabIndex = 4
        Label11.Text = "Barang Masuk"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(12, 167)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 21)
        Label10.TabIndex = 3
        Label10.Text = "Barang"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(11, 135)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 21)
        Label9.TabIndex = 2
        Label9.Text = "Dashboard"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(60, 52)
        Label8.Name = "Label8"
        Label8.Size = New Size(37, 15)
        Label8.TabIndex = 1
        Label8.Text = "nama"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Location = New Point(12, 49)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(37, 38)
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        Panel2.Location = New Point(0, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(801, 44)
        Panel2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(193, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 32)
        Label1.TabIndex = 4
        Label1.Text = "Supplier"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
