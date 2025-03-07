Imports NAudio.CoreAudioApi
Imports NAudio.CoreAudioApi.Interfaces

Public Class Form1
    Dim enumerator As New MMDeviceEnumerator()
    Dim defaultDevice As MMDevice
    Dim updateTimer As New Timer()
    Dim countdownTime As Integer
    Dim fadeThreshold As Integer = 10
    Private appControls As New Dictionary(Of String, TrackBar)
    Private appLabels As New Dictionary(Of String, Label)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOutputDevices()
        LoadInputDevices()
        SetDefaultVolume()
        AddHandler tbVolumeApp.Scroll, AddressOf tbVolumeApp_Scroll
        AddHandler defaultDevice.AudioEndpointVolume.OnVolumeNotification, AddressOf OnVolumeNotification
        UpdateVolumeImage(tbVolumeApp.Value)

        AddHandler updateTimer.Tick, AddressOf UpdateAudioLevel
        updateTimer.Interval = 100
        updateTimer.Start()

        AddHandler tmrUpdate.Tick, AddressOf RefreshIODevices
        tmrUpdate.Interval = 2000
        tmrUpdate.Start()

        AddHandler timerCountDown.Tick, AddressOf TimerCountDown_Tick
        timerCountDown.Interval = 1000

        UpdateAudioApplications()
    End Sub

    Private Sub RefreshIODevicesAndApps(sender As Object, e As EventArgs)
        LoadOutputDevices()
        LoadInputDevices()
        UpdateAudioApplications()
    End Sub

    Private Sub UpdateAudioApplications()
        Dim sessions = defaultDevice.AudioSessionManager.Sessions
        Dim currentApps As New List(Of String)

        For i As Integer = 0 To sessions.Count - 1
            Dim session As AudioSessionControl = sessions(i)
            If Not session.IsSystemSoundsSession AndAlso session.State = AudioSessionState.AudioSessionStateActive Then
                Dim processId As UInteger = session.GetProcessID
                Dim process As Process
                Try
                    process = Process.GetProcessById(CInt(processId))
                    Dim appName As String = process.ProcessName

                    currentApps.Add(appName)

                    If Not appControls.ContainsKey(appName) Then
                        AddApplicationControl(appName)
                    End If

                    Dim sessionVolume As Single = session.SimpleAudioVolume.Volume * 100
                    If appControls.ContainsKey(appName) Then
                        appControls(appName).Value = CInt(sessionVolume)
                    End If
                Catch ex As Exception
                    Continue For
                End Try
            End If
        Next

        Dim appsToRemove As New List(Of String)
        For Each app In appControls.Keys
            If Not currentApps.Contains(app) Then
                appsToRemove.Add(app)
            End If
        Next

        For Each app In appsToRemove
            RemoveApplicationControl(app)
        Next
    End Sub

    Private Sub AddApplicationControl(appName As String)
        Dim lbl As New Label()
        lbl.Name = "lblApp_" & appName
        lbl.Text = appName
        lbl.AutoSize = True

        Dim tb As New TrackBar()
        tb.Name = "tbApp_" & appName
        tb.Minimum = 0
        tb.Maximum = 100
        tb.Value = 100 ' Default to 100%
        tb.Width = 200
        AddHandler tb.Scroll, AddressOf AppTrackBar_Scroll

        Dim yPos As Integer = appControls.Count * 40
        lbl.Location = New Point(0, yPos + 5)
        tb.Location = New Point(100, yPos)

        pnlAppsContainer.Controls.Add(lbl)
        pnlAppsContainer.Controls.Add(tb)
        appControls.Add(appName, tb)
        appLabels.Add(appName, lbl)
    End Sub

    Private Sub RemoveApplicationControl(appName As String)
        If appControls.ContainsKey(appName) Then
            pnlAppsContainer.Controls.Remove(appControls(appName))
            pnlAppsContainer.Controls.Remove(appLabels(appName))
            appControls.Remove(appName)
            appLabels.Remove(appName)
        End If
    End Sub

    Private Sub AppTrackBar_Scroll(sender As Object, e As EventArgs)
        Dim tb As TrackBar = DirectCast(sender, TrackBar)
        Dim appName As String = tb.Name.Replace("tbApp_", "")

        Dim sessions = defaultDevice.AudioSessionManager.Sessions
        For i As Integer = 0 To sessions.Count - 1
            Dim session As AudioSessionControl = sessions(i)
            If Not session.IsSystemSoundsSession Then
                Dim processId As UInteger = session.GetProcessID
                Dim process As Process
                Try
                    process = Process.GetProcessById(CInt(processId))
                    If process.ProcessName = appName Then
                        session.SimpleAudioVolume.Volume = tb.Value / 100.0F
                        Exit For
                    End If
                Catch ex As Exception
                    Continue For
                End Try
            End If
        Next
    End Sub


    Private Sub picTime_Click(sender As Object, e As EventArgs) Handles picTime.Click
        Form2.Show()
    End Sub

    Private Sub LoadOutputDevices()
        cmbOutputDevice.Items.Clear()
        Dim outputDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)

        For Each device In outputDevices
            cmbOutputDevice.Items.Add(device.FriendlyName)
        Next

        If cmbOutputDevice.Items.Count > 0 Then
            cmbOutputDevice.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadInputDevices()
        cmbInputDevice.Items.Clear()
        Dim inputDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)

        For Each device In inputDevices
            cmbInputDevice.Items.Add(device.FriendlyName)
        Next

        If cmbInputDevice.Items.Count > 0 Then
            cmbInputDevice.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbOutputDevice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOutputDevice.SelectedIndexChanged

    End Sub

    Private Sub tbVolumeApp_Scroll(sender As Object, e As EventArgs)
        lblVolume.Text = tbVolumeApp.Value.ToString() & "%"
        UpdateVolumeImage(tbVolumeApp.Value)
        SetSystemVolume(tbVolumeApp.Value)
    End Sub

    Private Sub UpdateVolumeImage(volume As Integer)
        If volume = 0 Then
            picVolume.Image = My.Resources.no_volume
        ElseIf volume <= 60 Then
            picVolume.Image = My.Resources.low_volume
        Else
            picVolume.Image = My.Resources.medium_volume
        End If
    End Sub

    Private Sub SetDefaultVolume()
        defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Dim systemVolume = CInt(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
        tbVolumeApp.Value = systemVolume
        lblVolume.Text = systemVolume.ToString() & "%"
    End Sub

    Private Sub SetSystemVolume(volume As Integer)
        If defaultDevice IsNot Nothing Then
            defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = volume / 100.0F
        End If
    End Sub

    Private Sub OnVolumeNotification(data As AudioVolumeNotificationData)
        If Not tbVolumeApp.Value = CInt(data.MasterVolume * 100) Then
            tbVolumeApp.Value = CInt(data.MasterVolume * 100)
            lblVolume.Text = tbVolumeApp.Value.ToString() & "%"
            UpdateVolumeImage(tbVolumeApp.Value)
        End If
    End Sub

    Private Sub UpdateAudioLevel(sender As Object, e As EventArgs)
        If defaultDevice IsNot Nothing Then
            Dim audioLevel = CInt(defaultDevice.AudioMeterInformation.MasterPeakValue * 100)
            pbVolumeLevel.Value = audioLevel
        End If
    End Sub

    Private Sub RefreshIODevices(sender As Object, e As EventArgs)
        LoadOutputDevices()
        LoadInputDevices()
    End Sub

    Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs)
        If countdownTime > 0 Then
            countdownTime -= 1
            lblTimer.Text = "Timer : " & TimeSpan.FromSeconds(countdownTime).ToString("hh\:mm\:ss")

            If countdownTime <= fadeThreshold Then
                Dim fadeVolume = CInt((countdownTime / fadeThreshold) * 100)
                SetSystemVolume(fadeVolume)
                tbVolumeApp.Value = fadeVolume
                lblVolume.Text = fadeVolume.ToString() & "%"
                UpdateVolumeImage(fadeVolume)
            End If
        Else
            SetSystemVolume(0)
            timerCountDown.Stop()
            MessageBox.Show("Session ended, audio has been stopped", "Timer Countdown", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub SetCountdownTime(hours As Integer, minutes As Integer)
        countdownTime = (hours * 3600) + (minutes * 60)
        lblTimer.Text = "Timer : " & TimeSpan.FromSeconds(countdownTime).ToString("hh\:mm\:ss")
        timerCountDown.Start()
    End Sub
End Class

