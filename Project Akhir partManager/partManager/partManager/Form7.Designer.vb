<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Label13 = New Label()
        Button6 = New Button()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        PictureBox7 = New PictureBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Location = New Point(2, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(211, 480)
        Panel1.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F)
        Label13.Location = New Point(12, 272)
        Label13.Name = "Label13"
        Label13.Size = New Size(165, 21)
        Label13.TabIndex = 10
        Label13.Text = "Manajemen Pengguna"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(54, 430)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(88, 28)
        Button6.TabIndex = 8
        Button6.Text = "Keluar"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(12, 237)
        Label12.Name = "Label12"
        Label12.Size = New Size(67, 21)
        Label12.TabIndex = 5
        Label12.Text = "Laporan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(12, 202)
        Label11.Name = "Label11"
        Label11.Size = New Size(77, 21)
        Label11.TabIndex = 4
        Label11.Text = "Penjualan"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(12, 166)
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
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(54, 63)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 1
        Label8.Text = "admin"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Location = New Point(12, 50)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(37, 38)
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        Panel2.Location = New Point(1, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(885, 44)
        Panel2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(226, 142)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(210, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(226, 194)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(210, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(226, 247)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(210, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(226, 364)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(210, 23)
        TextBox5.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(766, 445)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 22)
        Button1.TabIndex = 10
        Button1.Text = "Tambah Barang"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(226, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 11
        Label1.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(226, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 12
        Label2.Text = "Stok"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(226, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 13
        Label3.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(226, 287)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 14
        Label4.Text = "Kategori"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(226, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 15
        Label5.Text = "Supplier"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"GPU", "Motherboard", "Monitor"})
        ComboBox1.Location = New Point(226, 305)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(210, 23)
        ComboBox1.TabIndex = 16
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(886, 479)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form7"
        Text = "Form7"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
