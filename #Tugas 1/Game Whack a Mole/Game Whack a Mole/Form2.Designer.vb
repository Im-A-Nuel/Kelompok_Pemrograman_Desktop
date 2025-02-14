<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        pbRefresh = New PictureBox()
        pbMole1 = New PictureBox()
        pbMole2 = New PictureBox()
        pbMole3 = New PictureBox()
        pbMole4 = New PictureBox()
        pbMole5 = New PictureBox()
        pbMole6 = New PictureBox()
        pbMole7 = New PictureBox()
        lblScore = New Label()
        lblHighScore = New Label()
        lblTime = New Label()
        Label4 = New Label()
        CType(pbRefresh, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole4, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbRefresh
        ' 
        pbRefresh.BackColor = Color.Transparent
        pbRefresh.BackgroundImage = CType(resources.GetObject("pbRefresh.BackgroundImage"), Image)
        pbRefresh.BackgroundImageLayout = ImageLayout.Stretch
        pbRefresh.Location = New Point(19, 24)
        pbRefresh.Name = "pbRefresh"
        pbRefresh.Size = New Size(65, 53)
        pbRefresh.TabIndex = 0
        pbRefresh.TabStop = False
        ' 
        ' pbMole1
        ' 
        pbMole1.BackColor = Color.Transparent
        pbMole1.BackgroundImage = CType(resources.GetObject("pbMole1.BackgroundImage"), Image)
        pbMole1.BackgroundImageLayout = ImageLayout.Stretch
        pbMole1.Location = New Point(314, 202)
        pbMole1.Name = "pbMole1"
        pbMole1.Size = New Size(134, 127)
        pbMole1.TabIndex = 1
        pbMole1.TabStop = False
        pbMole1.Visible = False
        ' 
        ' pbMole2
        ' 
        pbMole2.BackColor = Color.Transparent
        pbMole2.BackgroundImage = CType(resources.GetObject("pbMole2.BackgroundImage"), Image)
        pbMole2.BackgroundImageLayout = ImageLayout.Stretch
        pbMole2.Location = New Point(63, 266)
        pbMole2.Name = "pbMole2"
        pbMole2.Size = New Size(134, 127)
        pbMole2.TabIndex = 2
        pbMole2.TabStop = False
        pbMole2.Visible = False
        ' 
        ' pbMole3
        ' 
        pbMole3.BackColor = Color.Transparent
        pbMole3.BackgroundImage = CType(resources.GetObject("pbMole3.BackgroundImage"), Image)
        pbMole3.BackgroundImageLayout = ImageLayout.Stretch
        pbMole3.Location = New Point(466, 326)
        pbMole3.Name = "pbMole3"
        pbMole3.Size = New Size(134, 127)
        pbMole3.TabIndex = 3
        pbMole3.TabStop = False
        pbMole3.Visible = False
        ' 
        ' pbMole4
        ' 
        pbMole4.BackColor = Color.Transparent
        pbMole4.BackgroundImage = CType(resources.GetObject("pbMole4.BackgroundImage"), Image)
        pbMole4.BackgroundImageLayout = ImageLayout.Stretch
        pbMole4.Location = New Point(187, 390)
        pbMole4.Name = "pbMole4"
        pbMole4.Size = New Size(134, 127)
        pbMole4.TabIndex = 4
        pbMole4.TabStop = False
        pbMole4.Visible = False
        ' 
        ' pbMole5
        ' 
        pbMole5.BackColor = Color.Transparent
        pbMole5.BackgroundImage = CType(resources.GetObject("pbMole5.BackgroundImage"), Image)
        pbMole5.BackgroundImageLayout = ImageLayout.Stretch
        pbMole5.Location = New Point(491, 470)
        pbMole5.Name = "pbMole5"
        pbMole5.Size = New Size(134, 127)
        pbMole5.TabIndex = 5
        pbMole5.TabStop = False
        pbMole5.Visible = False
        ' 
        ' pbMole6
        ' 
        pbMole6.BackColor = Color.Transparent
        pbMole6.BackgroundImage = CType(resources.GetObject("pbMole6.BackgroundImage"), Image)
        pbMole6.BackgroundImageLayout = ImageLayout.Stretch
        pbMole6.Location = New Point(52, 540)
        pbMole6.Name = "pbMole6"
        pbMole6.Size = New Size(134, 127)
        pbMole6.TabIndex = 6
        pbMole6.TabStop = False
        pbMole6.Visible = False
        ' 
        ' pbMole7
        ' 
        pbMole7.BackColor = Color.Transparent
        pbMole7.BackgroundImage = CType(resources.GetObject("pbMole7.BackgroundImage"), Image)
        pbMole7.BackgroundImageLayout = ImageLayout.Stretch
        pbMole7.Location = New Point(329, 616)
        pbMole7.Name = "pbMole7"
        pbMole7.Size = New Size(134, 127)
        pbMole7.TabIndex = 7
        pbMole7.TabStop = False
        pbMole7.Visible = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Felix Titling", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.ForeColor = SystemColors.Window
        lblScore.Location = New Point(52, 166)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(59, 63)
        lblScore.TabIndex = 8
        lblScore.Text = "0"
        ' 
        ' lblHighScore
        ' 
        lblHighScore.AutoSize = True
        lblHighScore.BackColor = Color.Transparent
        lblHighScore.Font = New Font("Felix Titling", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHighScore.ForeColor = SystemColors.Window
        lblHighScore.Location = New Point(329, 120)
        lblHighScore.Name = "lblHighScore"
        lblHighScore.Size = New Size(59, 63)
        lblHighScore.TabIndex = 9
        lblHighScore.Text = "0"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Felix Titling", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = SystemColors.Window
        lblTime.Location = New Point(580, 159)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(52, 55)
        lblTime.TabIndex = 10
        lblTime.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Window
        Label4.Location = New Point(298, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 30)
        Label4.TabIndex = 11
        Label4.Text = "Best Score"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(684, 791)
        Controls.Add(Label4)
        Controls.Add(lblTime)
        Controls.Add(lblHighScore)
        Controls.Add(lblScore)
        Controls.Add(pbMole7)
        Controls.Add(pbMole6)
        Controls.Add(pbMole5)
        Controls.Add(pbMole4)
        Controls.Add(pbMole3)
        Controls.Add(pbMole2)
        Controls.Add(pbMole1)
        Controls.Add(pbRefresh)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Whack a Mole!"
        CType(pbRefresh, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole4, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbRefresh As PictureBox
    Friend WithEvents pbMole1 As PictureBox
    Friend WithEvents pbMole2 As PictureBox
    Friend WithEvents pbMole3 As PictureBox
    Friend WithEvents pbMole4 As PictureBox
    Friend WithEvents pbMole5 As PictureBox
    Friend WithEvents pbMole6 As PictureBox
    Friend WithEvents pbMole7 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblHighScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label4 As Label
End Class
