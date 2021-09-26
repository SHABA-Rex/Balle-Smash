Public Class Choisir_mon_niveau
    Private Sub Boutton_Retour_Click(sender As Object, e As EventArgs) Handles Boutton_Retour.Click
        Les_Scores_Et_Niveaux.Show()
        Me.Dispose()
    End Sub
    Private Sub Boutton_RetourMouseHover(sender As Object, e As EventArgs) Handles Boutton_Retour.MouseHover
        LabelDeBack.Show()
    End Sub
    Private Sub Boutton_RetourMouseLeave(sender As Object, e As EventArgs) Handles Boutton_Retour.MouseLeave
        LabelDeBack.Hide()
    End Sub

    Private Sub Score_des_joueurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelDeBack.Hide()
    End Sub

    Private Sub Niveau_Normal_Click(sender As Object, e As EventArgs) Handles Niveau_Normal.Click
        Form1.Timer_Montee1.Interval = 30
        Form1.Timer_Montee2.Interval = 30
        Form1.Timer_descente1.Interval = 30
        Form1.Timer_descente2.Interval = 30
        Form1.Timer_De_Deplacement_De_La_Bate_Automatique.Interval = 20
        Me.Dispose()
        activerTimer_descente1 = False
        activerTimer_descente2 = False
        activerTimer_Montee1 = False
        activerTimer_Montee2 = False
        Form1.Timer_descente1.Stop()
        Form1.Timer_descente2.Stop()
        Form1.Timer_Montee1.Stop()
        Form1.Timer_Montee2.Stop()
        Form1.Timer_De_Deplacement_De_La_Bate_Automatique.Stop()
        choisirLaMonteePourDemarrerLeJeu()
        choisirLaPositionDeLaBallePourDemarrerLeJeu()
        'nbreDePasPourAllerVersLaGaucheOuVersLaDroite = 3
    End Sub

    Private Sub Niveau_Intermediaire_Click(sender As Object, e As EventArgs) Handles Niveau_Intermediaire.Click
        'Diminuer le temps du timer augmente la vitesse de la balle et de la bateAutomatique
        Form1.Timer_Montee1.Interval = 28
        Form1.Timer_Montee2.Interval = 28
        Form1.Timer_descente1.Interval = 28
        Form1.Timer_descente2.Interval = 28
        Form1.Timer_De_Deplacement_De_La_Bate_Automatique.Interval = 20
        Me.Dispose()
        activerTimer_descente1 = False
        activerTimer_descente2 = False
        activerTimer_Montee1 = False
        activerTimer_Montee2 = False
        Form1.Timer_descente1.Stop()
        Form1.Timer_descente2.Stop()
        Form1.Timer_Montee1.Stop()
        Form1.Timer_Montee2.Stop()
        Form1.Timer_De_Deplacement_De_La_Bate_Automatique.Stop()
        choisirLaMonteePourDemarrerLeJeu()
        choisirLaPositionDeLaBallePourDemarrerLeJeu()
        'nbreDePasPourAllerVersLaGaucheOuVersLaDroite = 3
    End Sub

    Private Sub Haut_Niveau_Click(sender As Object, e As EventArgs) Handles Haut_Niveau.Click
        Form1.Timer_Montee1.Interval = 20
        Form1.Timer_Montee2.Interval = 20
        Form1.Timer_descente1.Interval = 20
        Form1.Timer_descente2.Interval = 20
        Form1.Timer_De_Deplacement_De_La_Bate_Automatique.Interval = 5
        Me.Dispose()
        activerTimer_descente1 = False
        activerTimer_descente2 = False
        activerTimer_Montee1 = False
        activerTimer_Montee2 = False
        Form1.Timer_descente1.Stop()
        Form1.Timer_descente2.Stop()
        Form1.Timer_Montee1.Stop()
        Form1.Timer_Montee2.Stop()
        Form1.Timer_De_Deplacement_De_La_Bate_Automatique.Stop()
        choisirLaMonteePourDemarrerLeJeu()
        choisirLaPositionDeLaBallePourDemarrerLeJeu()
        'nbreDePasPourAllerVersLaGaucheOuVersLaDroite = 3
    End Sub
End Class