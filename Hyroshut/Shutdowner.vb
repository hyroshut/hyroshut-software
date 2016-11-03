Namespace Hyro
    Public Class Shutdowner
        Dim seconds As Integer = 0
        Public Function shutdownPC(Optional ByVal devmode As Boolean = False)
            Try
                Dim process = New Process
                process.StartInfo.FileName = "shutdown.exe"
                process.StartInfo.Arguments = "/s /t " + IIf(devmode, "180", "0")
                process.Start()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            Return True
        End Function

        Public Function restartPC(Optional ByVal devmode As Boolean = False)
            Try
                Dim process = New Process
                process.StartInfo.FileName = "shutdown.exe"
                process.StartInfo.Arguments = "/r /t " + IIf(devmode, "180", "0")
                process.Start()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            Return True
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
    End Class
End Namespace