Imports NAudio.CoreAudioApi
Imports NAudio.CoreAudioApi.Interfaces

Public Class Form1
    Dim enumerator As New MMDeviceEnumerator()
    Dim defaultDevice As MMDevice
    Dim updateTimer As New Timer()
    Dim countdownTime As Integer
    Dim fadeThreshold As Integer = 10

    Dim audioSessions As New List(Of AudioSessionControl)()


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

        AddHandler tmrUpdate.Tick, AddressOf UpdateAudioSessions
        tmrUpdate.Interval = 2000
        tmrUpdate.Start()

        AddHandler timerCountDown.Tick, AddressOf TimerCountDown_Tick
        timerCountDown.Interval = 1000

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

    Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles timerCountDown.Tick
        If countdownTime > 0 Then
            countdownTime -= 1
            lblTimer.Text = "Timer : " & TimeSpan.FromSeconds(countdownTime).ToString("hh\:mm\:ss")

            If countdownTime <= fadeThreshold Then
                Dim currentVolume As Integer = GetCurrentSystemVolume()
                Dim fadeVolume As Integer = CInt((countdownTime / fadeThreshold) * currentVolume)
                SetSystemVolume(fadeVolume)
                tbVolumeApp.Value = fadeVolume
                lblVolume.Text = fadeVolume.ToString() & "%"
                UpdateVolumeImage(fadeVolume)
            End If
        ElseIf timerCountDown.Enabled Then
            timerCountDown.Stop()
            SetSystemVolume(0)
            MessageBox.Show("Waktu habis! Semua audio telah dimatikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Public Sub SetCountdownTime(hours As Integer, minutes As Integer)
        countdownTime = (hours * 3600) + (minutes * 60)
        lblTimer.Text = "Timer : " & TimeSpan.FromSeconds(countdownTime).ToString("hh\:mm\:ss")
        timerCountDown.Start()
    End Sub

    Private Function GetCurrentSystemVolume() As Integer
        Dim enumerator As New MMDeviceEnumerator()
        Dim device As MMDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Return CInt(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
    End Function

    Private Sub UpdateAudioSessions(sender As Object, e As EventArgs)
        pnlAppsContainer.Controls.Clear()
        audioSessions.Clear()

        defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)

        Dim yOffset As Integer = 10

        For i As Integer = 0 To defaultDevice.AudioSessionManager.Sessions.Count - 1
            Dim session As AudioSessionControl = defaultDevice.AudioSessionManager.Sessions(i)

            If session.State = AudioSessionState.AudioSessionStateActive Then
                Dim appName As String = session.DisplayName

                If String.IsNullOrEmpty(appName) Then
                    Try
                        Dim processId As Integer = session.GetProcessID()
                        If processId > 0 Then
                            Dim process As Process = Process.GetProcessById(processId)
                            appName = process.ProcessName
                        End If
                    Catch ex As Exception
                        appName = "Unknown App"
                    End Try
                End If

                Dim maxTextWidth As Integer = 130

                Dim lblApp As New Label()
                lblApp.ForeColor = Color.White
                lblApp.Location = New Point(10, yOffset)
                lblApp.AutoSize = True
                lblApp.MaximumSize = New Size(maxTextWidth, 0)

                If TextRenderer.MeasureText(appName, lblApp.Font).Width > maxTextWidth Then
                    While TextRenderer.MeasureText(appName & "...", lblApp.Font).Width > maxTextWidth AndAlso appName.Length > 3
                        appName = appName.Substring(0, appName.Length - 1)
                    End While
                    appName &= "..."
                End If

                lblApp.Text = appName

                Dim appTrackBar As New TrackBar()
                appTrackBar.Minimum = 0
                appTrackBar.Maximum = 100
                appTrackBar.TickFrequency = 1
                appTrackBar.Value = CInt(session.SimpleAudioVolume.Volume * 100)
                appTrackBar.Size = New Size(480, 70)
                appTrackBar.Location = New Point(150, yOffset - 5)

                AddHandler appTrackBar.Scroll, Sub()
                                                   session.SimpleAudioVolume.Volume = appTrackBar.Value / 100.0F
                                               End Sub

                pnlAppsContainer.Controls.Add(lblApp)
                pnlAppsContainer.Controls.Add(appTrackBar)

                yOffset += 60
            End If
        Next

    End Sub

End Class

