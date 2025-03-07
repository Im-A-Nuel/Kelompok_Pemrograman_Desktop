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
        appTrackBar = New TrackBar()
        lblApp = New Label()
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
        lblName.Location = New Point(18, 15)
        lblName.Name = "lblName"
        lblName.Size = New Size(47, 15)
        lblName.TabIndex = 0
        lblName.Text = "Volume"
        ' 
        ' picVolume
        ' 
        picVolume.Image = My.Resources.Resources.low_volume
        picVolume.Location = New Point(227, 9)
        picVolume.Margin = New Padding(3, 2, 3, 2)
        picVolume.Name = "picVolume"
        picVolume.Size = New Size(29, 27)
        picVolume.SizeMode = PictureBoxSizeMode.StretchImage
        picVolume.TabIndex = 0
        picVolume.TabStop = False
        ' 
        ' lblVolume
        ' 
        lblVolume.AutoSize = True
        lblVolume.ForeColor = Color.White
        lblVolume.Location = New Point(274, 15)
        lblVolume.Name = "lblVolume"
        lblVolume.Size = New Size(23, 15)
        lblVolume.TabIndex = 1
        lblVolume.Text = "0%"
        ' 
        ' tbVolumeApp
        ' 
        tbVolumeApp.Location = New Point(304, 13)
        tbVolumeApp.Margin = New Padding(3, 2, 3, 2)
        tbVolumeApp.Maximum = 100
        tbVolumeApp.Name = "tbVolumeApp"
        tbVolumeApp.Size = New Size(225, 45)
        tbVolumeApp.TabIndex = 2
        tbVolumeApp.TickFrequency = 10
        ' 
        ' lblOutputDevice
        ' 
        lblOutputDevice.AutoSize = True
        lblOutputDevice.ForeColor = Color.White
        lblOutputDevice.Location = New Point(18, 71)
        lblOutputDevice.Name = "lblOutputDevice"
        lblOutputDevice.Size = New Size(83, 15)
        lblOutputDevice.TabIndex = 3
        lblOutputDevice.Text = "Output Device"
        ' 
        ' cmbOutputDevice
        ' 
        cmbOutputDevice.FormattingEnabled = True
        cmbOutputDevice.Location = New Point(182, 68)
        cmbOutputDevice.Margin = New Padding(3, 2, 3, 2)
        cmbOutputDevice.Name = "cmbOutputDevice"
        cmbOutputDevice.Size = New Size(302, 23)
        cmbOutputDevice.TabIndex = 4
        ' 
        ' lblInputDevice
        ' 
        lblInputDevice.AutoSize = True
        lblInputDevice.ForeColor = Color.White
        lblInputDevice.Location = New Point(18, 122)
        lblInputDevice.Name = "lblInputDevice"
        lblInputDevice.Size = New Size(73, 15)
        lblInputDevice.TabIndex = 5
        lblInputDevice.Text = "Input Device"
        ' 
        ' cmbInputDevice
        ' 
        cmbInputDevice.FormattingEnabled = True
        cmbInputDevice.Location = New Point(182, 119)
        cmbInputDevice.Margin = New Padding(3, 2, 3, 2)
        cmbInputDevice.Name = "cmbInputDevice"
        cmbInputDevice.Size = New Size(302, 23)
        cmbInputDevice.TabIndex = 6
        ' 
        ' pbVolumeLevel
        ' 
        pbVolumeLevel.Location = New Point(18, 160)
        pbVolumeLevel.Margin = New Padding(3, 2, 3, 2)
        pbVolumeLevel.Name = "pbVolumeLevel"
        pbVolumeLevel.Size = New Size(234, 22)
        pbVolumeLevel.TabIndex = 7
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.ForeColor = Color.White
        lblTimer.Location = New Point(375, 164)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(89, 15)
        lblTimer.TabIndex = 8
        lblTimer.Text = "Timer : 00:00:00"
        ' 
        ' picTime
        ' 
        picTime.Image = My.Resources.Resources.stopwatch
        picTime.Location = New Point(480, 158)
        picTime.Margin = New Padding(3, 2, 3, 2)
        picTime.Name = "picTime"
        picTime.Size = New Size(29, 27)
        picTime.SizeMode = PictureBoxSizeMode.StretchImage
        picTime.TabIndex = 9
        picTime.TabStop = False
        ' 
        ' pnlAppsContainer
        ' 
        pnlAppsContainer.Controls.Add(appTrackBar)
        pnlAppsContainer.Controls.Add(lblApp)
        pnlAppsContainer.Dock = DockStyle.Bottom
        pnlAppsContainer.Location = New Point(0, 191)
        pnlAppsContainer.Margin = New Padding(3, 2, 3, 2)
        pnlAppsContainer.Name = "pnlAppsContainer"
        pnlAppsContainer.Size = New Size(555, 199)
        pnlAppsContainer.TabIndex = 10
        ' 
        ' appTrackBar
        ' 
        appTrackBar.Location = New Point(182, 12)
        appTrackBar.Margin = New Padding(3, 2, 3, 2)
        appTrackBar.Maximum = 100
        appTrackBar.Name = "appTrackBar"
        appTrackBar.Size = New Size(347, 45)
        appTrackBar.TabIndex = 12
        appTrackBar.TickFrequency = 10
        ' 
        ' lblApp
        ' 
        lblApp.AutoSize = True
        lblApp.ForeColor = Color.White
        lblApp.Location = New Point(18, 12)
        lblApp.Name = "lblApp"
        lblApp.Size = New Size(67, 15)
        lblApp.TabIndex = 11
        lblApp.Text = "$AppName"
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
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(63), CByte(81))
        ClientSize = New Size(555, 390)
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
        Margin = New Padding(3, 2, 3, 2)
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
