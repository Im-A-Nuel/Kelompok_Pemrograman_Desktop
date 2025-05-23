Imports System.IO

Public Class Form2
    ' Game configuration
    Dim gridSize As Integer = 20
    Dim gridWidth As Integer = Me.Width / 10
    Dim gridHeight As Integer = Me.Height / 10

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

        For i = 1 To 2
            playerSnake.Add(New Point(5 - i, 5))
            botSnake1.Add(New Point(15 - i, 5))
            botSnake2.Add(New Point(10 - i, 15))
        Next

        score = 0
        isGameOver = False

        For i = 1 To 5
            foodList.Add(GetRandomEmptyCell())
        Next

        ' Load HighScore
        Dim hsPath As String = Application.StartupPath & "\highscore.txt"
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
        If isGameOver Then
            timerGame.Stop()
            ' Save HighScore
            If score > highScore Then
                highScore = score
                File.WriteAllText(Application.StartupPath & "\highscore.txt", highScore.ToString())
            End If
            Me.Invalidate()
            Return
        End If

        ' Move player snake
        MoveSnake(playerSnake, playerDir)

        ' Move bots (bisa diupgrade ke AI)
        bot1Dir = GetRandomDirection(botSnake1)
        MoveSnake(botSnake1, bot1Dir)

        bot2Dir = GetRandomDirection(botSnake2)
        MoveSnake(botSnake2, bot2Dir)

        ' Player eat food
        Dim eatIdx As Integer = foodList.FindIndex(Function(f) f = playerSnake(0))
        If eatIdx >= 0 Then
            score += 10
            playerSnake.Add(playerSnake.Last)
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        ' Bot1 eat food
        eatIdx = foodList.FindIndex(Function(f) f = botSnake1(0))
        If eatIdx >= 0 Then
            botSnake1.Add(botSnake1.Last)
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        ' Bot2 eat food
        eatIdx = foodList.FindIndex(Function(f) f = botSnake2(0))
        If eatIdx >= 0 Then
            botSnake2.Add(botSnake2.Last)
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        ' ====== COLLISION DETECTION ======
        ' Player to itself
        If playerSnake.Skip(1).Any(Function(pt) pt = playerSnake(0)) Then
            isGameOver = True
            timerGame.Stop()
        End If

        ' Player to bots' body
        If botSnake1.Any(Function(pt) pt = playerSnake(0)) OrElse botSnake2.Any(Function(pt) pt = playerSnake(0)) Then
            isGameOver = True
            timerGame.Stop()
        End If

        ' Bot1 to itself
        If botSnake1.Skip(1).Any(Function(pt) pt = botSnake1(0)) Then
            ResetBot(botSnake1, New Point(15, 5))
        End If

        ' Bot2 to itself
        If botSnake2.Skip(1).Any(Function(pt) pt = botSnake2(0)) Then
            ResetBot(botSnake2, New Point(10, 15))
        End If

        ' Bot1 vs Bot2
        If botSnake2.Any(Function(pt) pt = botSnake1(0)) Then
            ResetBot(botSnake1, New Point(15, 5))
        End If
        If botSnake1.Any(Function(pt) pt = botSnake2(0)) Then
            ResetBot(botSnake2, New Point(10, 15))
        End If

        ' Bot ke tubuh player
        If playerSnake.Any(Function(pt) pt = botSnake1(0)) Then
            ResetBot(botSnake1, New Point(15, 5))
            score += 50
        End If
        If playerSnake.Any(Function(pt) pt = botSnake2(0)) Then
            ResetBot(botSnake2, New Point(10, 15))
            score += 50
        End If

        Me.Invalidate()
    End Sub

    Sub MoveSnake(ByRef snake As List(Of Point), dir As Point)
        Dim newHead As Point = New Point((snake(0).X + dir.X + gridWidth) Mod gridWidth,
                                         (snake(0).Y + dir.Y + gridHeight) Mod gridHeight)
        snake.Insert(0, newHead)
        snake.RemoveAt(snake.Count - 1)
    End Sub

    Function GetRandomDirection(snake As List(Of Point)) As Point
        ' Bot random movement (bisa diganti AI)
        Dim dirs As New List(Of Point) From {
            New Point(0, -1), New Point(0, 1), New Point(-1, 0), New Point(1, 0)
        }
        Dim currDir As Point = New Point(snake(0).X - snake(1).X, snake(0).Y - snake(1).Y)
        dirs = dirs.Where(Function(d) d <> New Point(-currDir.X, -currDir.Y)).ToList() ' tidak mundur
        Return dirs(random.Next(dirs.Count))
    End Function

    Sub ResetBot(ByRef bot As List(Of Point), startPos As Point)
        bot.Clear()
        bot.Add(startPos)
        For i = 1 To 2
            bot.Add(New Point(startPos.X - i, startPos.Y))
        Next
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        ' Draw food
        For Each food In foodList
            e.Graphics.FillEllipse(Brushes.Yellow, food.X * gridSize, food.Y * gridSize, gridSize, gridSize)
        Next
        ' Draw snakes
        For Each pt In playerSnake
            e.Graphics.FillRectangle(Brushes.Green, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next
        For Each pt In botSnake1
            e.Graphics.FillRectangle(Brushes.Red, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next
        For Each pt In botSnake2
            e.Graphics.FillRectangle(Brushes.Purple, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next

        e.Graphics.DrawString("Score: " & score, New Font("Arial", 12), Brushes.White, 5, gridHeight * gridSize + 5)
        e.Graphics.DrawString("High Score: " & highScore, New Font("Arial", 12), Brushes.Yellow, 120, gridHeight * gridSize + 5)

        If isGameOver Then
            Dim msg = "Game Over!" & vbCrLf & "Tekan Enter untuk restart"
            Dim size = e.Graphics.MeasureString(msg, New Font("Arial", 22))
            e.Graphics.DrawString(msg, New Font("Arial", 22), Brushes.White,
                                  (Me.ClientSize.Width - size.Width) / 2, (Me.ClientSize.Height - size.Height) / 2)
        End If
    End Sub
End Class
