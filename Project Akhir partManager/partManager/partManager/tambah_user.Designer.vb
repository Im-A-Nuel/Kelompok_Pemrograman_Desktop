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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnTambah = New Button()
        txtUsername = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label3 = New Label()
        txtNama = New TextBox()
        cbRole = New ComboBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 14
        Label1.Text = "Username"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(339, 340)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(108, 22)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(44, 72)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(305, 23)
        txtUsername.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 16
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(44, 136)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(305, 23)
        txtPassword.TabIndex = 15
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 18
        Label3.Text = "Nama Lengkao"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(44, 202)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(305, 23)
        txtNama.TabIndex = 17
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"Admin", "Manajer", "Karyawan"})
        cbRole.Location = New Point(44, 263)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(210, 23)
        cbRole.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(44, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 19
        Label4.Text = "Role"
        ' 
        ' tambah_user
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(215), CByte(230), CByte(244))
        ClientSize = New Size(491, 410)
        Controls.Add(cbRole)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(Label1)
        Controls.Add(btnTambah)
        Controls.Add(txtUsername)
        Name = "tambah_user"
        Text = "tambah_user"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents Label4 As Label
End Class
