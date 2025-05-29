<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_DataBarang
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
        txtSearch = New TextBox()
        btnAddBarang = New Button()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        lblHeader = New Label()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(555, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 10
        Label2.Text = "search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(614, 62)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(156, 27)
        txtSearch.TabIndex = 9
        ' 
        ' btnAddBarang
        ' 
        btnAddBarang.Location = New Point(589, 20)
        btnAddBarang.Margin = New Padding(3, 4, 3, 4)
        btnAddBarang.Name = "btnAddBarang"
        btnAddBarang.Size = New Size(123, 29)
        btnAddBarang.TabIndex = 0
        btnAddBarang.Text = "Tambah Barang"
        btnAddBarang.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(btnAddBarang)
        Panel3.Location = New Point(39, 94)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(731, 496)
        Panel3.TabIndex = 8
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 64)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(729, 411)
        DataGridView1.TabIndex = 2
        ' 
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblHeader.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Padding = New Padding(18, 0, 0, 0)
        lblHeader.Size = New Size(808, 102)
        lblHeader.TabIndex = 11
        lblHeader.Text = "Data Barang"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UC_DataBarang
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(lblHeader)
        Controls.Add(Panel3)
        Name = "UC_DataBarang"
        Size = New Size(808, 639)
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAddBarang As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblHeader As Label

End Class
