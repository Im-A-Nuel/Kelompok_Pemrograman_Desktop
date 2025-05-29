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
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        lblHeader = New Label()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(39, 99)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(729, 487)
        Panel3.TabIndex = 20
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 48)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(726, 371)
        DataGridView1.TabIndex = 2
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
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblHeader.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Padding = New Padding(18, 0, 0, 0)
        lblHeader.Size = New Size(808, 102)
        lblHeader.TabIndex = 21
        lblHeader.Text = "Manajemen Pengguna"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UC_ManajemenPengguna
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(lblHeader)
        Controls.Add(Panel3)
        Name = "UC_ManajemenPengguna"
        Size = New Size(808, 639)
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblHeader As Label

End Class
