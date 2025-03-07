<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblName = New Label()
        picVolume = New PictureBox()
        lblVolume = New Label()
        tbVolumeApp = New TrackBar()
        lblOutputDevice = New Label()
        cmbOutputDevice = New ComboBox()
        lblInputDevice = New Label()
        cmbInputDevice = New ComboBox()
        pbVolumeLevel = New ProgressBar()
        lblTimer = New Label()
        picTime = New PictureBox()
        pnlAppsContainer = New Panel()
        lblApp = New Label()
        appTrackBar = New TrackBar()
        tmrUpdate = New Timer(components)
        timerCountDown = New Timer(components)
        CType(picVolume, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbVolumeApp, ComponentModel.ISupportInitialize).BeginInit()
        CType(picTime, ComponentModel.ISupportInitialize).BeginInit()
        pnlAppsContainer.SuspendLayout()
        CType(appTrackBar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.ForeColor = Color.White
        lblName.Location = New Point(21, 20)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 20)
        lblName.TabIndex = 0
        lblName.Text = "Volume"
        ' 
        ' picVolume
        ' 
        picVolume.Image = My.Resources.Resources.medium_volume
        picVolume.Location = New Point(171, 12)
        picVolume.Name = "picVolume"
        picVolume.Size = New Size(33, 36)
        picVolume.SizeMode = PictureBoxSizeMode.StretchImage
        picVolume.TabIndex = 0
        picVolume.TabStop = False
        ' 
        ' lblVolume
        ' 
        lblVolume.AutoSize = True
        lblVolume.ForeColor = Color.White
        lblVolume.Location = New Point(225, 20)
        lblVolume.Name = "lblVolume"
        lblVolume.Size = New Size(119, 20)
        lblVolume.TabIndex = 1
        lblVolume.Text = "DIILANGIN NNTI"
        ' 
        ' tbVolumeApp
        ' 
        tbVolumeApp.Location = New Point(348, 17)
        tbVolumeApp.Maximum = 100
        tbVolumeApp.Name = "tbVolumeApp"
        tbVolumeApp.Size = New Size(257, 56)
        tbVolumeApp.TabIndex = 2
        tbVolumeApp.TickFrequency = 10
        ' 
        ' lblOutputDevice
        ' 
        lblOutputDevice.AutoSize = True
        lblOutputDevice.ForeColor = Color.White
        lblOutputDevice.Location = New Point(21, 95)
        lblOutputDevice.Name = "lblOutputDevice"
        lblOutputDevice.Size = New Size(104, 20)
        lblOutputDevice.TabIndex = 3
        lblOutputDevice.Text = "Output Device"
        ' 
        ' cmbOutputDevice
        ' 
        cmbOutputDevice.FormattingEnabled = True
        cmbOutputDevice.Location = New Point(208, 91)
        cmbOutputDevice.Name = "cmbOutputDevice"
        cmbOutputDevice.Size = New Size(345, 28)
        cmbOutputDevice.TabIndex = 4
        ' 
        ' lblInputDevice
        ' 
        lblInputDevice.AutoSize = True
        lblInputDevice.ForeColor = Color.White
        lblInputDevice.Location = New Point(21, 162)
        lblInputDevice.Name = "lblInputDevice"
        lblInputDevice.Size = New Size(92, 20)
        lblInputDevice.TabIndex = 5
        lblInputDevice.Text = "Input Device"
        ' 
        ' cmbInputDevice
        ' 
        cmbInputDevice.FormattingEnabled = True
        cmbInputDevice.Location = New Point(208, 159)
        cmbInputDevice.Name = "cmbInputDevice"
        cmbInputDevice.Size = New Size(345, 28)
        cmbInputDevice.TabIndex = 6
        ' 
        ' pbVolumeLevel
        ' 
        pbVolumeLevel.Location = New Point(21, 214)
        pbVolumeLevel.Name = "pbVolumeLevel"
        pbVolumeLevel.Size = New Size(268, 29)
        pbVolumeLevel.TabIndex = 7
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.ForeColor = Color.White
        lblTimer.Location = New Point(429, 219)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(112, 20)
        lblTimer.TabIndex = 8
        lblTimer.Text = "Timer : 00:00:00"
        ' 
        ' picTime
        ' 
        picTime.Image = My.Resources.Resources.stopwatch
        picTime.Location = New Point(548, 210)
        picTime.Name = "picTime"
        picTime.Size = New Size(33, 36)
        picTime.SizeMode = PictureBoxSizeMode.StretchImage
        picTime.TabIndex = 9
        picTime.TabStop = False
        ' 
        ' pnlAppsContainer
        ' 
        pnlAppsContainer.Controls.Add(appTrackBar)
        pnlAppsContainer.Controls.Add(lblApp)
        pnlAppsContainer.Dock = DockStyle.Bottom
        pnlAppsContainer.Location = New Point(0, 255)
        pnlAppsContainer.Name = "pnlAppsContainer"
        pnlAppsContainer.Size = New Size(634, 265)
        pnlAppsContainer.TabIndex = 10
        ' 
        ' lblApp
        ' 
        lblApp.AutoSize = True
        lblApp.ForeColor = Color.White
        lblApp.Location = New Point(21, 16)
        lblApp.Name = "lblApp"
        lblApp.Size = New Size(85, 20)
        lblApp.TabIndex = 11
        lblApp.Text = "$AppName"
        ' 
        ' appTrackBar
        ' 
        appTrackBar.Location = New Point(208, 16)
        appTrackBar.Maximum = 100
        appTrackBar.Name = "appTrackBar"
        appTrackBar.Size = New Size(397, 56)
        appTrackBar.TabIndex = 12
        appTrackBar.TickFrequency = 10
        ' 
        ' tmrUpdate
        ' 
        tmrUpdate.Interval = 2000
        ' 
        ' timerCountDown
        ' 
        timerCountDown.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(63), CByte(81))
        ClientSize = New Size(634, 520)
        Controls.Add(pnlAppsContainer)
        Controls.Add(picTime)
        Controls.Add(lblTimer)
        Controls.Add(pbVolumeLevel)
        Controls.Add(cmbInputDevice)
        Controls.Add(lblInputDevice)
        Controls.Add(cmbOutputDevice)
        Controls.Add(lblOutputDevice)
        Controls.Add(tbVolumeApp)
        Controls.Add(lblVolume)
        Controls.Add(picVolume)
        Controls.Add(lblName)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Audio Mixer"
        CType(picVolume, ComponentModel.ISupportInitialize).EndInit()
        CType(tbVolumeApp, ComponentModel.ISupportInitialize).EndInit()
        CType(picTime, ComponentModel.ISupportInitialize).EndInit()
        pnlAppsContainer.ResumeLayout(False)
        pnlAppsContainer.PerformLayout()
        CType(appTrackBar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents picVolume As PictureBox
    Friend WithEvents lblVolume As Label
    Friend WithEvents tbVolumeApp As TrackBar
    Friend WithEvents lblOutputDevice As Label
    Friend WithEvents cmbOutputDevice As ComboBox
    Friend WithEvents lblInputDevice As Label
    Friend WithEvents cmbInputDevice As ComboBox
    Friend WithEvents pbVolumeLevel As ProgressBar
    Friend WithEvents lblTimer As Label
    Friend WithEvents picTime As PictureBox
    Friend WithEvents pnlAppsContainer As Panel
    Friend WithEvents appTrackBar As TrackBar
    Friend WithEvents lblApp As Label
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents timerCountDown As Timer

End Class
