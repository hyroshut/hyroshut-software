Imports Hyroshut.Hyro
Public Class Form1
    Dim sdn As New Shutdowner()
    Dim btn1text As String
    Dim myConfig As New MyConfig
    Dim savetime As New SaveTime

    Private Sub LogInButtonWithProgress1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress1.Click
        LogInGroupBox1.Enabled = Not LogInGroupBox1.Enabled
        LogInGroupBox2.Enabled = Not LogInGroupBox2.Enabled
        If (sdn.getSeconds() >= 1) Then
            shutdownTimer.Stop()
            LogInButtonWithProgress1.Text = btn1text
            sdn.setSeconds(0)
            LogInButtonWithProgress1.Maximum = 0
            LogInButtonWithProgress1.Value = 0
        Else
            Dim ptype = IIf(LogInRadioButton1.Checked, "stop", "restart")
            Dim days = NumericUpDown1.Value
            Dim hours = NumericUpDown2.Value
            Dim minutes = NumericUpDown3.Value
            Dim seconds = 0
            Dim secondsbeforeshutdown = Calculator.toSecond(
                days,
                hours,
                minutes,
            )
            If (secondsbeforeshutdown = False Or (LogInRadioButton1.Checked = False And LogInRadioButton2.Checked = False)) Then
                MessageBox.Show("Vous devez selectionner le temps avant l'arrêt et le mode de fermeture !", "Erreur (Code 21)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                LogInGroupBox1.Enabled = True
                LogInGroupBox2.Enabled = True
            Else
                LogInButtonWithProgress1.Maximum = secondsbeforeshutdown
                LogInButtonWithProgress1.Value = secondsbeforeshutdown
                sdn.setSeconds(secondsbeforeshutdown)
                shutdownTimer.Start()
                btn1text = LogInButtonWithProgress1.Text
                LogInButtonWithProgress1.Text = "Annuler"
                If myConfig.getKey("savetime") Then
                    savetime.save(days, hours, minutes, seconds)
                    savetime.updateConfig.setKey("type", ptype, "others").save()
                End If
            End If
        End If
    End Sub

    Private Sub shutdownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shutdownTimer.Tick
        Dim decremented = sdn.decrementsSeconds()
        If (decremented = 0) Then
            If LogInRadioButton1.Checked Then
                sdn.shutdownPC(myConfig.getKey("devmode"))
            Else
                sdn.restartPC(myConfig.getKey("devmode"))
            End If
            shutdownTimer.Stop()
            LogInButtonWithProgress1.Text = btn1text
        End If
        LogInButtonWithProgress1.Value -= 1
    End Sub

    Private Sub LogInButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButton1.Click
        TopMost = False
        Settings.ShowDialog()
    End Sub

    Private Sub Form1_Loaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TopMost = myConfig.getKey("topmost")
            If myConfig.getKey("savetime") Then
                NumericUpDown1.Value = savetime.getKey("days", "time")
                NumericUpDown2.Value = savetime.getKey("hours", "time")
                NumericUpDown3.Value = savetime.getKey("minutes", "time")
                If savetime.getKey("type", "others") = "restart" Then
                    LogInRadioButton2.Checked = True
                Else
                    LogInRadioButton1.Checked = True
                End If
                shutdownTimer.Interval = IIf(myConfig.getKey("devmode"), 100, 1000)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class