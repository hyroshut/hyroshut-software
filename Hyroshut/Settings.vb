Imports Hyroshut.Hyro
Public Class Settings

    Dim myConfig As MyConfig

    Sub New()
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.myConfig = New MyConfig
    End Sub

    Private Sub LogInButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButton1.Click
        With myConfig.updateConfig()
            .setKey("topmost", LogInCheckBox1.Checked)
            .setKey("savetime", LogInCheckBox2.Checked)
            .setKey("devmode", LogInCheckBox3.Checked)
            .save()
        End With
        Dim msg = "Les modifications vont être pris en compte après le redémarrage du logiciel, voulez vous le redémarrer maintenant ?"
        Dim res = MessageBox.Show(msg, "Hyroshut", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If res = Windows.Forms.DialogResult.Yes Then
            Application.Restart()
        End If
        Me.Close()
    End Sub

    Public Function read(ByVal key)
        Return myConfig.getKey(key)
    End Function

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogInCheckBox1.Checked = read("topmost")
        LogInCheckBox2.Checked = read("savetime")
        LogInCheckBox3.Checked = read("devmode")
    End Sub

    Private Sub LogInCheckBox3_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox3.CheckedChanged
        If LogInCheckBox3.Checked Then
            If MessageBox.Show("Ce mode permer d'ajouter 3 minutes de plus au temps choisis et d'accèlerer les timer pour eviter que les développeurs de ce logiciel perdent du temps et que leurs ordinateurs s'arrete ! Voulez vous activer ce mode ?", "Mode développeur", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                LogInCheckBox3.Checked = False
            Else
                MessageBox.Show("Pour annuler la fermeture de l'ordinateur taper la commande ""shutdown.exe -a""", "Mode développeur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub LogInButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButton2.Click
        Close()
    End Sub
End Class