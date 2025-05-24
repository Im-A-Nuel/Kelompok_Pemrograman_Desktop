Imports System.IO

Public Class Form2
    Dim Lingkaran As Image = Image.FromFile(Application.StartupPath & "\asset\lingkaran.png")
    Dim persegiMerah As Image = Image.FromFile(Application.StartupPath & "\asset\persegi.png")
    Dim persegiHijau As Image = Image.FromFile(Application.StartupPath & "\asset\persegiHijau.png")
    Dim persegiPink As Image = Image.FromFile(Application.StartupPath & "\asset\persegiPink.png")

    ' Game configuration
    Dim gridSize As Integer = 20
    Dim gridWidth As Integer = Me.Width \ 10
    Dim gridHeight As Integer = Me.Height \ 10

    ' Snake data
    Dim playerSnake As New List(Of Point)
    Dim botSnake1 As New List(Of Point)
    Dim botSnake2 As New List(Of Point)
    Dim foodList As New List(Of Point)
    Dim random As New Random()

    Dim playerDir As Point = New Point(1, 0)
    Dim bot1Dir As Point = New Point(0, 1)
    Dim bot2Dir As Point = New Point(0, -1)

    Dim timerGame As New Timer()
    Dim score As Integer = 0
    Dim highScore As Integer = 0

    Dim isGameOver As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetClientSizeCore(gridWidth * gridSize, gridHeight * gridSize + 40)
        StartNewGame()
        timerGame.Interval = 120
        AddHandler timerGame.Tick, AddressOf GameLoop
        timerGame.Start()
        Me.Focus()
    End Sub

    Sub StartNewGame()
        playerSnake.Clear()
        botSnake1.Clear()
        botSnake2.Clear()
        foodList.Clear()

        playerDir = New Point(1, 0)
        bot1Dir = New Point(0, 1)
        bot2Dir = New Point(0, -1)

        playerSnake.Add(New Point(5, 5))
        botSnake1.Add(New Point(15, 5))
        botSnake2.Add(New Point(10, 15))

        score = 0
        isGameOver = False

        For i = 1 To 5
            foodList.Add(GetRandomEmptyCell())
        Next

        ' Load HighScore
        Dim hsPath As String = Application.StartupPath & "\asset\highscore.txt"
        If File.Exists(hsPath) Then
            Integer.TryParse(File.ReadAllText(hsPath), highScore)
        Else
            highScore = 0
        End If

        Me.Invalidate()
    End Sub

    Private Function GetRandomEmptyCell() As Point
        Dim pt As Point
        Do
            pt = New Point(random.Next(0, gridWidth), random.Next(0, gridHeight))
        Loop While playerSnake.Contains(pt) OrElse botSnake1.Contains(pt) OrElse botSnake2.Contains(pt) OrElse foodList.Contains(pt)
        Return pt
    End Function

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If isGameOver Then
            If e.KeyCode = Keys.Enter Then
                StartNewGame()
                timerGame.Start()
            End If

            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
            Exit Sub
        End If

        Select Case e.KeyCode
            Case Keys.Left
                If playerDir.X <> 1 Then playerDir = New Point(-1, 0)
            Case Keys.Right
                If playerDir.X <> -1 Then playerDir = New Point(1, 0)
            Case Keys.Up
                If playerDir.Y <> 1 Then playerDir = New Point(0, -1)
            Case Keys.Down
                If playerDir.Y <> -1 Then playerDir = New Point(0, 1)
        End Select
    End Sub

    Private Sub GameLoop(sender As Object, e As EventArgs)
        Dim lastTailPlayer As Point = playerSnake.Last
        Dim lastTailBot1 As Point = botSnake1.Last
        Dim lastTailBot2 As Point = botSnake2.Last

        If playerSnake(0) = botSnake1(0) OrElse playerSnake(0) = botSnake2(0) Then
            isGameOver = True
            timerGame.Stop()
        End If

        MoveSnake(playerSnake, playerDir)
        bot1Dir = GetRandomDirection(botSnake1, bot1Dir)
        MoveSnake(botSnake1, bot1Dir)
        bot2Dir = GetRandomDirection(botSnake2, bot2Dir)
        MoveSnake(botSnake2, bot2Dir)

        ' Player makan food
        Dim eatIdx As Integer = foodList.FindIndex(Function(f) f = playerSnake(0))
        If eatIdx >= 0 Then
            GrowSnake(playerSnake, lastTailPlayer)
            score += 10
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        ' Bot1 makan food
        eatIdx = foodList.FindIndex(Function(f) f = botSnake1(0))
        If eatIdx >= 0 Then
            GrowSnake(botSnake1, lastTailBot1)
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        ' Bot2 makan food
        eatIdx = foodList.FindIndex(Function(f) f = botSnake2(0))
        If eatIdx >= 0 Then
            GrowSnake(botSnake2, lastTailBot2)
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        ' Player kena dirinya sendiri
        If playerSnake.Skip(1).Any(Function(pt) pt = playerSnake(0)) Then
            isGameOver = True
            timerGame.Stop()
        End If

        ' Bot kena dirinya sendiri, di-reset
        If botSnake1.Skip(1).Any(Function(pt) pt = botSnake1(0)) Then
            ResetBot(botSnake1, New Point(15, 5))
        End If
        If botSnake2.Skip(1).Any(Function(pt) pt = botSnake2(0)) Then
            ResetBot(botSnake2, New Point(10, 15))
        End If

        ' Bot bertabrakan satu sama lain, di-reset
        If botSnake2.Any(Function(pt) pt = botSnake1(0)) Then
            ResetBot(botSnake1, New Point(15, 5))
        End If
        If botSnake1.Any(Function(pt) pt = botSnake2(0)) Then
            ResetBot(botSnake2, New Point(10, 15))
        End If

        ' Player makan badan bot (bukan kepala), bot di-reset dan player dapat skor
        If botSnake1.Skip(1).Any(Function(pt) pt = playerSnake(0)) Then
            ResetBot(botSnake1, New Point(15, 5))
            score += 50
        End If
        If botSnake2.Skip(1).Any(Function(pt) pt = playerSnake(0)) Then
            ResetBot(botSnake2, New Point(10, 15))
            score += 50
        End If

        Me.Invalidate()

        If isGameOver Then
            timerGame.Stop()
            ' Save HighScore
            If score > highScore Then
                highScore = score
                File.WriteAllText(Application.StartupPath & "\asset\highscore.txt", highScore.ToString())
            End If
            Me.Invalidate()
            Return
        End If
    End Sub

    Sub MoveSnake(ByRef snake As List(Of Point), dir As Point)
        Dim newHead As Point = New Point((snake(0).X + dir.X + gridWidth) Mod gridWidth,
                                         (snake(0).Y + dir.Y + gridHeight) Mod gridHeight)
        snake.Insert(0, newHead)
        snake.RemoveAt(snake.Count - 1)
    End Sub

    Sub GrowSnake(ByRef snake As List(Of Point), tailPos As Point)
        snake.Add(tailPos)
    End Sub

    Function GetRandomDirection(snake As List(Of Point), lastDir As Point) As Point
        Dim dirs As New List(Of Point) From {
            New Point(0, -1), New Point(0, 1), New Point(-1, 0), New Point(1, 0)
        }
        Dim currDir As Point = lastDir

        If snake.Count >= 2 Then
            If Not (snake(0) = snake(1)) Then
                currDir = New Point(snake(0).X - snake(1).X, snake(0).Y - snake(1).Y)
            End If
        End If

        Dim filtered = dirs.Where(Function(d) d <> New Point(-currDir.X, -currDir.Y)).ToList()
        If filtered.Count = 0 Then filtered = dirs

        Return filtered(random.Next(filtered.Count))
    End Function

    Sub ResetBot(ByRef bot As List(Of Point), startPos As Point)
        bot.Clear()
        bot.Add(startPos)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        For Each food In foodList
            e.Graphics.DrawImage(Lingkaran, food.X * gridSize, food.Y * gridSize, gridSize, gridSize)
        Next

        For Each pt In playerSnake
            e.Graphics.DrawImage(persegiHijau, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next

        For Each pt In botSnake1
            e.Graphics.DrawImage(persegiMerah, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next

        For Each pt In botSnake2
            e.Graphics.DrawImage(persegiPink, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next

        e.Graphics.DrawString("Score: " & score, New Font("Arial", 12), Brushes.White, 5, gridHeight * gridSize + 5)
        e.Graphics.DrawString("High Score: " & highScore, New Font("Arial", 12), Brushes.Yellow, 120, gridHeight * gridSize + 5)

        If isGameOver Then
            Dim msg = "Game Over!"
            Dim msgKeterangan = "Tekan Enter untuk restart" & vbCrLf & "Tekan Esc untuk exit"
            Dim fontMsg As New Font("Arial", 22)
            Dim fontKet As New Font("Arial", 15)
            Dim sizeMsg = e.Graphics.MeasureString(msg, fontMsg)
            Dim sizeKet = e.Graphics.MeasureString(msgKeterangan, fontKet)

            Dim totalHeight As Single = sizeMsg.Height + 10 + sizeKet.Height
            Dim startY As Single = (Me.ClientSize.Height - totalHeight) / 2
            Dim centerX As Single = (Me.ClientSize.Width - sizeMsg.Width) / 2

            e.Graphics.DrawString(msg, fontMsg, Brushes.White, centerX, startY)
            Dim ketX As Single = (Me.ClientSize.Width - sizeKet.Width) / 2
            e.Graphics.DrawString(msgKeterangan, fontKet, Brushes.White, ketX, startY + sizeMsg.Height + 10)
        End If
    End Sub

End Class
