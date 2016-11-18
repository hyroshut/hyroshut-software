Imports Hyroshut.Hyro
Public Class Form1
    Dim sdn As New Shutdowner()
    Dim btn1text As String

    Public Event NewVersionAvailable(ByVal version As String)

    Private Sub LogInButtonWithProgress1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogInButtonWithProgress1.Click
        LogInGroupBox1.Enabled = Not LogInGroupBox1.Enabled
        LogInGroupBox2.Enabled = Not LogInGroupBox2.Enabled
        If (sdn.getSeconds() >= 1) Then
            shutdownTimer.Stop()
            LogInButtonWithProgress1.Text = btn1text
            sdn.setSeconds(0)
            LogInButtonWithProgress1.Maximum = 0
            LogInButtonWithProgress1.Value = 0
        Else
            Dim ptype As String
            If LogInRadioButton1.Checked Then
                ptype = "stop"
            ElseIf LogInRadioButton2.Checked Then
                ptype = "restart"
            Else
                ptype = "hibernate"
            End If
            Dim days = NumericUpDown1.Value
            Dim hours = NumericUpDown2.Value
            Dim minutes = NumericUpDown3.Value
            Dim seconds = 0
            Dim secondsbeforeshutdown = Calculator.toSecond(
                days,
                hours,
                minutes,
)
            If (secondsbeforeshutdown = False Or (Not LogInRadioButton1.Checked And Not LogInRadioButton2.Checked And Not LogInRadioButton3.Checked)) Then
                MessageBox.Show("Vous devez selectionner le temps avant l'arrêt et le mode de fermeture !", "Erreur (Code 21)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                LogInGroupBox1.Enabled = True
                LogInGroupBox2.Enabled = True
            Else
                If secondsbeforeshutdown = 540360 Then
                    If MessageBox.Show("Voulez vous vraiment utiliser 666 ?", "Hyroshut", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.No Then
                        LogInGroupBox1.Enabled = Not LogInGroupBox1.Enabled
                        LogInGroupBox2.Enabled = Not LogInGroupBox2.Enabled
                        Exit Sub
                    End If
                End If
                LogInButtonWithProgress1.Maximum = secondsbeforeshutdown
                LogInButtonWithProgress1.Value = secondsbeforeshutdown
                sdn.setSeconds(secondsbeforeshutdown)
                shutdownTimer.Start()
                btn1text = LogInButtonWithProgress1.Text
                LogInButtonWithProgress1.Text = "Annuler"
                If My.Config.getKey("savetime") Then
                    My.Config.changetime(days, hours, minutes, seconds)
                    My.Config.updateConfig.setKey("type", ptype, "others").save()
                End If
            End If
        End If
    End Sub

    Private Sub shutdownTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles shutdownTimer.Tick
        Dim decremented = sdn.decrementsSeconds()
        If (decremented = 0) Then
            If LogInRadioButton1.Checked Then
                sdn.shutdownPC(My.Config.getKey("devmode"))
            ElseIf LogInRadioButton2.Checked Then
                sdn.restartPC(My.Config.getKey("devmode"))
            ElseIf LogInRadioButton3.Checked Then
                sdn.hibernate(My.Config.getKey("devmode"))
            End If
            shutdownTimer.Stop()
            LogInButtonWithProgress1.Text = btn1text
        End If
        LogInButtonWithProgress1.Value -= 1
    End Sub

    Private Sub LogInButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogInButton1.Click
        TopMost = False
        Settings.ShowDialog()
    End Sub

    Private Sub NewVersion(ByVal version As String) Handles MyClass.NewVersionAvailable
        If MessageBox.Show("Une nouvelle version est disponible, voulez vous la télécharger ?", "Nouvelle version !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            Process.Start(My.Info.Site & "/?from=hyroshut-app-1-1-0&for=new_version")
            End
        Else
            Label1.Visible = True
        End If
    End Sub

    Private Sub Form1_Loaded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If My.Config.getKey("checkupdate") Then
            Dim new_version As String
            Try
                Dim url = My.Info.Site & "/version.txt"
                new_version = (New Net.WebClient).DownloadString(url)
            Catch ex As Exception
                new_version = My.Info.Version
            End Try
            If My.Info.Version <> new_version Then
                RaiseEvent NewVersionAvailable(new_version)
            End If
        End If
        Try
            TopMost = My.Config.getKey("topmost")
            If My.Config.getKey("savetime") Then
                NumericUpDown1.Value = My.Config.getTime("days", "time")
                NumericUpDown2.Value = My.Config.getTime("hours", "time")
                NumericUpDown3.Value = My.Config.getTime("minutes", "time")
                If My.Config.getTime("type", "others") = "restart" Then
                    LogInRadioButton2.Checked = True
                Else
                    LogInRadioButton1.Checked = True
                End If
                shutdownTimer.Interval = IIf(My.Config.getKey("devmode"), 100, 1000)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class