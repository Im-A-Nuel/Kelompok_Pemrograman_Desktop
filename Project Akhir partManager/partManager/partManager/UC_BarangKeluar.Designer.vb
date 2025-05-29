<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_BarangKeluar
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
        Label2 = New Label()
        TextBox1 = New TextBox()
        Panel3 = New Panel()
        btnAddBarangKeluar = New Button()
        DataGridView1 = New DataGridView()
        lblHeader = New Label()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(565, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 17
        Label2.Text = "search:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(621, 65)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(143, 27)
        TextBox1.TabIndex = 16
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnAddBarangKeluar)
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(43, 103)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(719, 483)
        Panel3.TabIndex = 18
        ' 
        ' btnAddBarangKeluar
        ' 
        btnAddBarangKeluar.Location = New Point(578, 12)
        btnAddBarangKeluar.Name = "btnAddBarangKeluar"
        btnAddBarangKeluar.Size = New Size(128, 29)
        btnAddBarangKeluar.TabIndex = 3
        btnAddBarangKeluar.Text = "+ Barang Keluar"
        btnAddBarangKeluar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 52)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(716, 428)
        DataGridView1.TabIndex = 2
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
        lblHeader.TabIndex = 19
        lblHeader.Text = "Barang Keluar"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UC_BarangKeluar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(lblHeader)
        Controls.Add(Panel3)
        Name = "UC_BarangKeluar"
        Size = New Size(808, 639)
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnAddBarangKeluar As Button

End Class
