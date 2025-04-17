<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ManajemenPengguna
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TableLayoutPanel1)
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(39, 98)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(729, 487)
        Panel3.TabIndex = 20
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackgroundImageLayout = ImageLayout.None
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.2420092F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.6621F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.09589F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 134F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 78F))
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(Label4, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(Label7, 3, 0)
        TableLayoutPanel1.Controls.Add(Label31, 4, 0)
        TableLayoutPanel1.Controls.Add(Label32, 5, 0)
        TableLayoutPanel1.Location = New Point(8, 56)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 41.60584F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 58.39416F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 63.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 56.0F))
        TableLayoutPanel1.Size = New Size(688, 216)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(235, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 20)
        Label5.TabIndex = 2
        Label5.Text = "Role"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(55, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 20)
        Label4.TabIndex = 1
        Label4.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 20)
        Label3.TabIndex = 0
        Label3.Text = "No"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(397, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 20)
        Label7.TabIndex = 21
        Label7.Text = "Tanggal Masuk"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(531, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(35, 20)
        Label31.TabIndex = 27
        Label31.Text = "Edit"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(611, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(51, 20)
        Label32.TabIndex = 32
        Label32.Text = "Hapus"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(555, 12)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 29)
        Button1.TabIndex = 0
        Button1.Text = "Tambah User"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(316, 41)
        Label1.TabIndex = 17
        Label1.Text = "Manajemen Pengguna"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(616, 59)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(154, 27)
        TextBox1.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(559, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 19
        Label2.Text = "search:"
        ' 
        ' UC_ManajemenPengguna
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Name = "UC_ManajemenPengguna"
        Size = New Size(808, 639)
        Panel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label

End Class
