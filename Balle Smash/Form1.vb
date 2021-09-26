'UNE GRANDE PRECISION , NE MET PAS DE BUTTON DANS UN FORMULAIRE 
'LORSQUE TU VEUX DEPLACER UN OBJET DANS LE FORMULAIRE , COMME UNE BALLE, UNE BATE CAR CA PRODUIT UNE ERREUR
'SURTOUT QUAND TU MET UN TIMER SUR LE FORMULAIRE
'LE MIEUX C'EST D'UTILISER UN LABEL ET DE LUI DONNER LA FORME QUE TU VEUX.


Public Class Form1
    'La raison pour laquelle  on ne declare pas cette variable dans le fichier Les_Variables.vb
    'C'est que çette declaration produit un erreur, donc elle est declaree ici car ça produit pas d'erreur 
    Dim abscisseEtordonneDeLaBateDuJoueurPrincipale, abscisseEtordonneDeLaLimiteDroite As Point
    Private Sub Form1_KeyDown(sender As Object, evenement As KeyEventArgs) Handles Me.KeyDown
        'La Condition1 permet de faire reculer la bate du joueur principale vers la gauche autant de fois que ceci sera vrai  PositionBate>0
        'La Condition2 permet de faire avancer la bate du joueur principale vers la droite autant de fois que ceci sera vrai PositionBate<LargeurFenetre
        'LargeurFentre=Me.Width - 17

        If (evenement.KeyCode = Keys.Left) Then
            If (abscisseEtordonneDeLaBateDuJoueurPrincipale.X > 0) Then 'Condition1
                abscisseEtordonneDeLaBateDuJoueurPrincipale.X -= 3 'nbreDePasPourAllerVersLaGaucheOuVersLaDroite
                abscisseEtordonneDeLaLimiteDroite.X -= 3 'nbreDePasPourAllerVersLaGaucheOuVersLaDroite
            End If
        End If
            If (evenement.KeyCode = Keys.Right) Then
            If (abscisseEtordonneDeLaLimiteDroite.X < Me.Width - 17) Then 'Conditon2
                abscisseEtordonneDeLaBateDuJoueurPrincipale.X += 3 'nbreDePasPourAllerVersLaGaucheOuVersLaDroite
                abscisseEtordonneDeLaLimiteDroite.X += 3 'nbreDePasPourAllerVersLaGaucheOuVersLaDroite
            End If
        End If
            La_BateDuJoueurPrincipale.Location = abscisseEtordonneDeLaBateDuJoueurPrincipale
            Limite_DroiteDuJoueur.Location = abscisseEtordonneDeLaLimiteDroite


    End Sub


    Private Sub Timer_Montee1_Tick(sender As Object, e As EventArgs) Handles Timer_Montee1.Tick
        If (activerTimer_Montee1) Then
            montee1(La_Balle)
            determinerLaPositionDeLaBalleALarriver(La_Balle, activerLaFonction)
        End If
    End Sub

    Private Sub Timer_De_Deplacement_De_La_Bate_Automatique_Tick(sender As Object, e As EventArgs) Handles Timer_De_Deplacement_De_La_Bate_Automatique.Tick
        'La condition1 permet de déplacer LaBateAutomatique dans le sens positif des abscisses
        'La condition2 permet de déplacer LaBateAutomatique dans le sens négatif des abscisses
        'La condition majeure à vérifier sera toujours de savoir si laBateAutomatique est située entre les limites qu'elle doit pas depasser.
        'Ces limites sont l'abscisse de l'extrémité gauche et l'abscisse de l'extrémité droite

        'Le -10 sur cette condition c'est pour créer une distance entre la balle et le coteGauche(l'abscisse) de la bateAutomatique comme tu peut voir.
        If positionDeLaLimiteDroite.X < Me.Width - 17 Then
            If (positionDeLaBateAutomatique.X < positionFinaleDeLaBalle.X - 10) And condition1_ALaMain Then
                'Condition1
                positionDeLaBateAutomatique.X += 3
                positionDeLaLimiteDroite.X += 3
                LimiteDroite.Location = positionDeLaLimiteDroite
                La_BateAutomatique.Location = positionDeLaBateAutomatique
            End If
        End If
        If (positionDeLaBateAutomatique.X > 0) Then
            If (positionDeLaBateAutomatique.X > positionFinaleDeLaBalle.X - 10) And condition2_ALaMain Then
                'Condition2
                positionDeLaBateAutomatique.X -= 3
                positionDeLaLimiteDroite.X -= 3
                LimiteDroite.Location = positionDeLaLimiteDroite
                La_BateAutomatique.Location = positionDeLaBateAutomatique
            End If
        End If

        'Met le mouvement 
    End Sub

    Private Sub Timer_Montee2_Tick(sender As Object, e As EventArgs) Handles Timer_Montee2.Tick
        If (activerTimer_Montee2) Then
            montee2(La_Balle)
            determinerLaPositionDeLaBalleALarriver(La_Balle, activerLaFonction)
        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        'Ici on veut que pour toute les fois où la fenetre va changer de taille alors la bate du joueur principale va se repositionnee seul.
        'Elle va se repositionner par rapport à la taille de la fenetre puisque ce n'est que l'ordonne de la bateDuJoueur qui change, lorsque la taille de la fenetre change.   
        abscisseEtordonneDeLaBateDuJoueurPrincipale.X = La_BateDuJoueurPrincipale.Location.X
        abscisseEtordonneDeLaBateDuJoueurPrincipale.Y = Me.Height - 48
        abscisseEtordonneDeLaLimiteDroite.X = Limite_DroiteDuJoueur.Location.X
        abscisseEtordonneDeLaLimiteDroite.Y = Me.Height - 48

        La_BateDuJoueurPrincipale.Location = abscisseEtordonneDeLaBateDuJoueurPrincipale
        Limite_DroiteDuJoueur.Location = abscisseEtordonneDeLaLimiteDroite
    End Sub

    Private Sub Timer_descente1_Tick(sender As Object, e As EventArgs) Handles Timer_descente1.Tick
        If (activerTimer_descente1) Then
            descente1(La_Balle)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On a besoin de cette variable afin de dire ou est ce la balle va etre pour demarrer le jeu.
        'Le sensPositif indique dans quelle sens on designe la position de la balle
        positionDeLaBallePourDemarrerLeJeu.X = 12
        positionDeLaBallePourDemarrerLeJeu.Y = 439
        La_Balle.Location = positionDeLaBallePourDemarrerLeJeu
        'sensDeLaBalle = "sensPositif"
        LimiteDroite.BackColor = Color.LimeGreen
        Limite_DroiteDuJoueur.BackColor = Color.LimeGreen
        choisirLaMonteePourDemarrerLeJeu()
    End Sub

    Private Sub Timer_descente2_Tick(sender As Object, e As EventArgs) Handles Timer_descente2.Tick
        If (activerTimer_descente2) Then
            descente2(La_Balle)
        End If
    End Sub

End Class
