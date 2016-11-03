Namespace My

    Public Class Info
        Shared Property ProgramData = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
    End Class

    ' Les événements suivants sont disponibles pour MyApplication :
    ' 
    ' Startup : déclenché au démarrage de l'application avant la création du formulaire de démarrage.
    ' Shutdown : déclenché après la fermeture de tous les formulaires de l'application. Cet événement n'est pas déclenché si l'application se termine de façon anormale.
    ' UnhandledException : déclenché si l'application rencontre une exception non gérée.
    ' StartupNextInstance : déclenché lors du lancement d'une application à instance unique et si cette application est déjà active. 
    ' NetworkAvailabilityChanged : déclenché lorsque la connexion réseau est connectée ou déconnectée.
    Partial Friend Class MyApplication

        Sub ApplicationStatup() Handles MyClass.Startup
            If Not IO.Directory.Exists(My.Info.ProgramData) Then
                IO.Directory.CreateDirectory(My.Info.ProgramData)
            End If
            If Not IO.File.Exists("Hyroshut.pdb") Then
                MessageBox.Show("Le fichier Hyroshut.pdb est manquant ! Reinstaller le logiciel pour le récupérer !", "Erreur (code 22)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End

            End If
            If Not IO.File.Exists(My.Info.ProgramData + "\config.ini") Then
                Dim file = IO.File.CreateText(My.Info.ProgramData + "\config.ini")
                file.WriteLine("[general]" & vbCrLf & "topmost=False" & vbCrLf & "savetime=True" & vbCrLf & "devmode=False")
                file.Close()
            End If
            If Not IO.File.Exists(My.Info.ProgramData + "saved_time.ini") Then
                Dim file = IO.File.CreateText(My.Info.ProgramData + "saved_time.ini")
                file.WriteLine("[time]" & vbCrLf & "days=0" & vbCrLf & "hours=0" & vbCrLf & "minutes=0" & vbCrLf & "[others]" & vbCrLf & "seconds=0" & vbCrLf & "type=stop")
                file.Close()
            End If
        End Sub


    End Class


End Namespace

