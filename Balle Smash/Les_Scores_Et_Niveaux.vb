Public Class Les_Scores_Et_Niveaux
    Private Sub Scores_Click(sender As Object, e As EventArgs) Handles Scores.Click
        Score_des_joueurs.Show()
        Me.Hide()
    End Sub

    Private Sub Le_Niveau_Click(sender As Object, e As EventArgs) Handles Le_Niveau.Click
        Choisir_mon_niveau.Show()
        Me.Hide()
    End Sub

    Private Sub Rejouer_Click(sender As Object, e As EventArgs) Handles Rejouer.Click
        'Dim absEtOrdDeBateAuto, limiteRightBateAuto, limiteRightDuJoueurPrincipale, abscEtOrdDeBatePrincipale As Point
        'absEtOrdDeBateAuto.X = 216
        'absEtOrdDeBateAuto.Y = 0
        'limiteRightBateAuto.X = 435
        'limiteRightBateAuto.Y = 0
        'abscEtOrdDeBatePrincipale.X = 216
        'abscEtOrdDeBatePrincipale.Y = 483
        'limiteRightDuJoueurPrincipale.X = 435
        'limiteRightDuJoueurPrincipale.Y = 483
        'Form1.La_BateAutomatique.Location = absEtOrdDeBateAuto
        'Form1.La_BateDuJoueurPrincipale.Location = abscEtOrdDeBatePrincipale
        'Form1.LimiteDroite.Location = limiteRightBateAuto
        'Form1.Limite_DroiteDuJoueur.Location = limiteRightDuJoueurPrincipale
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
    End Sub
End Class