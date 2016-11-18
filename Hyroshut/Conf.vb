Namespace Hyro
    Public MustInherit Class MyConfigBase
        Protected Property ini As Hyroshut.IniFile
        Private Property filename As String

        Sub New(ByVal filename As String)
            Me.filename = filename
            Dim inifile = New IniFile()
            If Not IO.File.Exists(filename) Then
                Dim created = createFileIfNotExists(filename)
                If Not created Then
                    Dim msg = "Le fichier """ + filename + """ est manquant ! Voulez vous obtenir de l'aide sur se problème via internet ?"
                    If MessageBox.Show(msg, "Erreur (Code 22) !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Process.Start(My.Info.Site & "/help/code-22?file=" + filename.Replace(".", "%2E"))
                        End
                    Else
                        End
                    End If
                End If
            End If
            inifile.Load(filename)
            Me.ini = inifile
        End Sub

        Public Function getKey(ByVal key As String, Optional ByVal section As String = "general")
            Try
                Return Me.ini.GetSection(section).GetKey(key).GetValue()
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function updateConfig() As NewConfig
            Return New NewConfig(Me.ini, filename)
        End Function

        Class NewConfig
            Private Property ini As IniFile
            Private Property filename As String

            Sub New(ByVal ini As IniFile, ByVal filename As String)
                Me.filename = filename
                Me.ini = ini
            End Sub

            Public Function setKey(ByVal key As String, ByVal value As Object, Optional ByVal section As String = "general") As NewConfig
                Me.ini.AddSection(section).AddKey(key).SetValue(value)
                Return Me
            End Function

            Public Function save()
                Me.ini.Save(filename)
                Return New NewConfig(Me.ini, filename)
            End Function
        End Class



        MustOverride Function createFileIfNotExists(ByVal filename)

    End Class

    Public Class MyConfig

        Inherits MyConfigBase
        Dim instance = vbNull

        Sub New()
            MyBase.New(My.Info.ProgramData + "\config.ini")
        End Sub

        Public Overrides Function createFileIfNotExists(ByVal filename)
            Return False
        End Function
    End Class

    Public Class SaveTime
        Inherits MyConfigBase

        Sub New()
            MyBase.New(My.Info.ProgramData + "\saved_time.ini")
        End Sub

        Public Sub save(ByVal years As Integer, ByVal hours As Integer, ByVal minutes As Integer, Optional ByVal seconds As Integer = 0)
            With Me.updateConfig()
                .setKey("days", years, "time")
                .setKey("hours", hours, "time")
                .setKey("minutes", minutes, "time")
                ' Others
                .setKey("seconds", seconds, "others")
                .save()
            End With
        End Sub

        Public Overrides Function createFileIfNotExists(ByVal filename)
            Dim inifile = New IniFile
            inifile.AddSection("time")
            inifile.GetSection("time").AddKey("days").SetValue(0)
            inifile.GetSection("time").AddKey("hours").SetValue(0)
            inifile.GetSection("time").AddKey("minutes").SetValue(0)
            inifile.AddSection("others").AddKey("seconds").SetValue(0)
            inifile.AddSection("others").AddKey("type").SetValue("stop")
            inifile.Save(filename)
            Return(True)
        End Function
    End Class
End Namespace