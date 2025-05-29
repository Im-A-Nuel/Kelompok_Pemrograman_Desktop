<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_user
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelHeader = New Panel()
        lblHeader = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtNama = New TextBox()
        cbRole = New ComboBox()
        btnTambah = New Button()
        btnBatal = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PanelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(35), CByte(108), CByte(208))
        PanelHeader.Controls.Add(lblHeader)
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(561, 58)
        PanelHeader.TabIndex = 100
        ' 
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.FromArgb(CByte(62), CByte(82), CByte(142))
        lblHeader.Dock = DockStyle.Fill
        lblHeader.Font = New Font("Segoe UI", 13.75F, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Padding = New Padding(18, 0, 0, 0)
        lblHeader.Size = New Size(561, 58)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Tambah User"
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 9F)
        txtUsername.Location = New Point(50, 95)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(400, 27)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 9F)
        txtPassword.Location = New Point(50, 165)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(400, 27)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 9F)
        txtNama.Location = New Point(50, 235)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(400, 27)
        txtNama.TabIndex = 3
        ' 
        ' cbRole
        ' 
        cbRole.Font = New Font("Segoe UI", 9F)
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"Admin", "Manajer", "Karyawan"})
        cbRole.Location = New Point(50, 305)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(250, 28)
        cbRole.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(35), CByte(108), CByte(208))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(325, 370)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(125, 38)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Silver
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        btnBatal.Location = New Point(180, 370)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(120, 38)
        btnBatal.TabIndex = 5
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label1.Location = New Point(50, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 10
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label2.Location = New Point(50, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 11
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label3.Location = New Point(50, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 12
        Label3.Text = "Nama Lengkap"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label4.Location = New Point(50, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 20)
        Label4.TabIndex = 13
        Label4.Text = "Role"
        ' 
        ' tambah_user
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(492, 440)
        Controls.Add(btnBatal)
        Controls.Add(PanelHeader)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(cbRole)
        Controls.Add(Label4)
        Controls.Add(btnTambah)
        MaximizeBox = False
        Name = "tambah_user"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tambah User"
        PanelHeader.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBatal As Button

End Class
