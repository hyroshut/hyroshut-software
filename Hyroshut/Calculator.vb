Namespace Hyro
    Class Calculator
        Shared Function toSecond(
                           Optional ByRef days As Integer = 0,
                           Optional ByRef hours As Integer = 0,
                           Optional ByRef minutes As Integer = 0,
                           Optional ByRef seconds As Integer = 0)
            Dim result = 0
            result += seconds
            result += minutes * 60
            result += hours * 3600
            result += days * 86400

            If (result = 0) Then
                Return False
            End If

            Return result
        End Function
    End Class
End Namespace