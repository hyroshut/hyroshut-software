Namespace My
    Public Class Info
        Shared Property ProgramData = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
        Public Shared Property Site = "https://www.hyroshut.ml"
        Public Shared Property Version = "v1.1.1"
    End Class

    Public Class Config
        Shared myconfig As Hyro.MyConfig
        Shared savetime As Hyro.SaveTime
        Shared Sub setConfigs(myconfigObj, savetimeObj)
            myconfig = myconfigObj
            savetime = savetimeObj
        End Sub

        Shared Function getKey(key, Optional section = "general")
            Return myconfig.getKey(key, section)
        End Function

        Shared Function updateConfig()
            Return myconfig.updateConfig()
        End Function

        Shared Function getTime(key, Optional section = "time")
            Return savetime.getKey(key, section)
        End Function

        Shared Function updateTime()
            Return savetime.updateConfig()
        End Function

        Shared Sub changetime(years, hours, minutes, Optional seconds = 0)
            savetime.save(years, hours, minutes, seconds)
        End Sub

    End Class
End Namespace