Namespace Hyro
    Public Class Shutdowner
        Dim seconds As Integer = 0
        Public Function shutdownPC(Optional ByVal devmode As Boolean = False)
            Return Me.executecommand("shutdown.exe", "/s /t " & IIf(devmode, "180", "0"))
        End Function

        Public Function restartPC(Optional ByVal devmode As Boolean = False)
            Return Me.executecommand("shutdown.exe", "/r /t " & IIf(devmode, "180", "0"))
        End Function

        Private Function executecommand(filename, arguments)
            Try
                Dim process = New Process
                process.StartInfo.FileName = filename
                process.StartInfo.Arguments = arguments
                process.Start()
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.ToString(), "Erreur 23", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Function getSeconds()
            Return Me.seconds
        End Function

        Public Sub setSeconds(ByVal seconds As Integer)
            Me.seconds = seconds
        End Sub

        Public Function decrementsSeconds()
            Dim seconds = Me.getSeconds() - 1
            Me.setSeconds(seconds)
            Return seconds
        End Function

        Public Function hibernate(v As Object)
            Return Me.executecommand("rundll32.exe", "powrprof.dll,SetSuspendState")
        End Function
    End Class
End Namespace