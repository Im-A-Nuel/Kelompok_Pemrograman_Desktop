Public Class Form2

    Private score As Integer = 0
    Private time As Integer = 30
    Private highScore As Integer = 0
    Private random As New Random()
    Private timer As System.Timers.Timer
    Private moleTimer As System.Timers.Timer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Whack a Mole!")
        InitializeGame()
    End Sub

    Private Sub InitializeGame()
        lblScore.Text = score
        lblTime.Text = time
        lblHighScore.Text = highScore

        timer = New Timers.Timer(1000)
        AddHandler timer.Elapsed, AddressOf OnGameTimerEvent
        timer.Start()

        moleTimer = New Timers.Timer(random.Next(1000))
        AddHandler moleTimer.Elapsed, AddressOf OnMoleTimerEvent
        moleTimer.Start()
    End Sub

    Private Sub OnMoleTimerEvent(sender As Object, e As Timers.ElapsedEventArgs)

        Dim moleIndex As Integer = random.Next(1, 8)
        For i As Integer = 1 To 7
            Dim pbMole As PictureBox = CType(Me.Controls("pbMole" & i), PictureBox)
            pbMole.Invoke(Sub() pbMole.Visible = (i = moleIndex))
        Next

    End Sub

    Private Sub OnGameTimerEvent(sender As Object, e As Timers.ElapsedEventArgs)
        If time > 0 Then
            time -= 1
            lblTime.Invoke(Sub() lblTime.Text = time.ToString())
        Else
            timer.Stop()
            moleTimer.Stop()

            If score > highScore Then
                highScore = score
                lblHighScore.Invoke(Sub() lblHighScore.Text = highScore.ToString())
            End If

            MessageBox.Show("Waktu telah habis!")
            Dim result As DialogResult = MessageBox.Show("Apakah Anda ingin memulai permainan kembali?", "Permainan Selesai", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ResetGame()
            Else
                Me.Close()
                Form1.Close()
            End If
        End If


    End Sub



    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("Terimakasih telah mencoba Whack a Mole!")
    End Sub


    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        ResetGame()
    End Sub

    Private Sub ResetGame()

    End Sub

End Class