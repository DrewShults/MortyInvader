Public Class FormName

    Dim SRight As Boolean
    Dim SLeft As Boolean
    Dim ShooterSpeed As Integer
    Dim ShotSpeed As Integer
    Dim InvaderSpeed As Integer
    Dim InvaderDrop As Integer
    Const NumOfInvaders As Integer = 15
    Dim IRight(NumOfInvaders) As Boolean

    Dim Invaders(NumOfInvaders) As PictureBox
    Dim x As Integer
    Dim ShotDown As Integer



    Private Sub TimerMain_Tick(ByVal sender As System.Object, e As EventArgs) Handles TimerMain.Tick
        MoveShooter()
        FireShot()
        MoveInvader()
        CheckGameOver()
        CheckHit()
    End Sub

    Private Sub FormName_KeyDown(ByVal sender As System.Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyValue = Keys.Right Then
            SRight = True
            SLeft = False
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = True
            SRight = False
        End If

        If e.KeyValue = Keys.Space And Shot.Visible = False Then
            My.Computer.Audio.Play(My.Resources.wow1, AudioPlayMode.Background)
            Shot.Top = Shooter.Top
            Shot.Left = Shooter.Left + (Shooter.Width / 2) - (Shot.Width / 2)
            Shot.Visible = True
        End If
        If e.KeyCode = Keys.Escape Then


            TimerMain.Stop()
            GroupBox1.Show()

        End If



    End Sub

    Private Sub MoveShooter()
        If SRight = True And Shooter.Left + Shooter.Width < Me.ClientRectangle.Width Then
            Shooter.Left += ShooterSpeed
        End If
        If SLeft = True And Shooter.Left > Me.ClientRectangle.Left Then
            Shooter.Left -= ShooterSpeed
        End If
    End Sub

    Private Sub FormName_KeyUp(ByVal sender As System.Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            SRight = False
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = False
        End If
    End Sub

    Private Sub FormName_Load(ByVal sender As System.Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
        LoadInvaders()
        TimerMain.Stop()
    End Sub
    Private Sub LoadSettings()
        ShotSpeed = 10
        ShooterSpeed = 3
        Shot.Visible = False
        For Me.x = 1 To NumOfInvaders
            IRight(x) = True
            InvaderSpeed = 5
            InvaderDrop = 50
        Next
    End Sub

    Private Sub FireShot()
        If Shot.Visible = True Then
            Shot.Top -= ShotSpeed
        End If

        If Shot.Top + Shot.Height < Me.ClientRectangle.Top Then
            Shot.Visible = False
        End If
    End Sub
    Private Sub MoveInvader()
        For Me.x = 1 To NumOfInvaders
            If IRight(x) = True Then
                Invaders(x).Left += InvaderSpeed
            Else
                Invaders(x).Left -= InvaderSpeed
            End If

            If Invaders(x).Left + Invaders(x).Width > Me.ClientRectangle.Width And IRight(x) = True Then
                IRight(x) = False
                Invaders(x).Top += InvaderDrop
            End If

            If Invaders(x).Left < Me.ClientRectangle.Left And IRight(x) = False Then
                IRight(x) = True
                Invaders(x).Top += InvaderDrop
            End If
        Next
    End Sub

    Private Sub CheckGameOver()
        For Me.x = 1 To NumOfInvaders
            If Invaders(x).Top + Invaders(x).Height >= Shooter.Top And Invaders(x).Visible = True Then
                TimerMain.Enabled = False
                'Me.x = NumOfInvaders
                MsgBox("Game Over! You Lose!")
            End If
        Next
        If ShotDown = NumOfInvaders Then
                TimerMain.Enabled = False
            MsgBox("You Saved The Planet!")
        End If


    End Sub

    Private Sub CheckHit()
        For Me.x = 1 To NumOfInvaders
            If (Shot.Top + Shot.Height >= Invaders(x).Top) And (Shot.Top <= Invaders(x).Top + Invaders(x).Height) And (Shot.Left + Shot.Width >= Invaders(x).Left) And (Shot.Left <= Invaders(x).Left + Invaders(x).Width) And Shot.Visible = True And Invaders(x).Visible = True Then
                Invaders(x).Visible = False

                Shot.Visible = False

                ShotDown += 1
            End If
        Next



    End Sub

    Private Sub LoadInvaders()
        For Me.x = 1 To NumOfInvaders
            Invaders(x) = New PictureBox With {
                .Image = My.Resources.Alien,
                .Width = 50,
                .Height = 50,
                .BackColor = Color.Transparent,
                .Left = (-50 * x) - (x * 5)
            }
            Controls.Add(Invaders(x))
        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = False
        Me.Focus()
        TimerMain.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class