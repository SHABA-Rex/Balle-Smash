Imports Guna.UI.WinForms
Module Fonctions
    Public Sub choisirLaPositionDeLaBallePourDemarrerLeJeu()
        'Ici il est question de faire avancer ou reculer la balle a chaque tour de jeu, chaque fois qu'on appuyera sur le boutton rejouer.
        'On veut que la  balle avance vers la droite de 20 en 20 jusqu'à atteindre le côte droit de la fenêtre(<Form1.Width - 42),ceci se fait apres la fin d'une partie.
        'On veut aussi que la balle recule vers la Gauche de 20 en 20 jusqu'à atteindre le côte gauche de la fenêtre(>0).
        'If (positionDeLaBallePourDemarrerLeJeu.X < 0) Then
        '    sensDeLaBalle = "sensPositif"
        'ElseIf (positionDeLaBallePourDemarrerLeJeu.X > 420) Then
        '    sensDeLaBalle = "sensNegatif"
        'End If

        'If (positionDeLaBallePourDemarrerLeJeu.X > 0) And sensDeLaBalle = "sensNegatif" Then
        '    positionDeLaBallePourDemarrerLeJeu.X -= 200
        'ElseIf (positionDeLaBallePourDemarrerLeJeu.X < 420) And positionDeLaBallePourDemarrerLeJeu.X > 0 And sensDeLaBalle = "sensPositif" Then
        '    positionDeLaBallePourDemarrerLeJeu.X += 200
        'End If
        positionDeLaBallePourDemarrerLeJeu.X += 50
        If (positionDeLaBallePourDemarrerLeJeu.X = 450) Then
            positionDeLaBallePourDemarrerLeJeu.X = 12
        End If
        Form1.La_Balle.Location = positionDeLaBallePourDemarrerLeJeu
    End Sub
    Public Sub choisirLaMonteePourDemarrerLeJeu()
        'Ici on va choisir quelle montee va etre effectue pour demarrer le jeu 
        'Lorsqu'une montee est choisie alors obligatoirement au prochain tour de jeu c'est l'autre montee qui sera choisie.
        If (laMonteeChoisiePourDemarrerLeJeu = 1) Then
            activerTimer_Montee1 = True
            Form1.Timer_Montee1.Start()
            laMonteeChoisiePourDemarrerLeJeu = 2
        ElseIf (laMonteeChoisiePourDemarrerLeJeu = 2)
            activerTimer_Montee2 = True
            Form1.Timer_Montee2.Start()
            laMonteeChoisiePourDemarrerLeJeu = 1
        End If
    End Sub
    Public Sub arreterLeJeu()
        If (Form1.La_Balle.Location.Y < -40) Then
            activerTimer_Montee1 = False
            activerTimer_Montee2 = False
            activerTimer_descente1 = False
            activerTimer_descente2 = False
            monScore += 10
            Score_des_joueurs.Mon_Score.Text = monScore
            Score_des_joueurs.Son_Score.Text = sonScore
            Les_Scores_Et_Niveaux.Show()
        End If
        If (Form1.La_Balle.Location.Y > Form1.Height - 20) Then
            activerTimer_Montee1 = False
            activerTimer_Montee2 = False
            activerTimer_descente1 = False
            activerTimer_descente2 = False
            sonScore += 10
            Score_des_joueurs.Mon_Score.Text = monScore
            Score_des_joueurs.Son_Score.Text = sonScore
            Les_Scores_Et_Niveaux.Show()
        End If
    End Sub
    Public Sub montee1(ByRef Balle As Label)
        'Dans la condition1 on fait avancer la balle jusqu'à ce qu'on atteigne l'ordonnee de la bateAutomatique.
        'Car dans le deplacement de la balle , à l'arriver il se produit deux choses soit on touche la bateAutomatique
        'Soit on depasse la bateAutomatique , en la traversant.
        'Dans la condition2 on vérifie si la balle a toucher la bateAutomatique :
        '1-Si la position de la balle est situé entre la posit de la bateAutomatique et la limiteDroite alors on arrete la balle.
        '2-Sinon alors on continue de faire avancer la balle jusqu'à depasser les limites.
        activerTimer_Montee1 = True
        activerTimer_Montee2 = False

        positionDeLaBalle = Balle.Location
        If (positionDeLaBalle.Y > 10) Then
            'Condition1
            positionDeLaBalle.X += 3
            positionDeLaBalle.Y -= 5
        End If

        If positionDeLaBalle.Y <= 10 And Not (positionDeLaBalle.X >= Form1.La_BateAutomatique.Location.X And positionDeLaBalle.X <= Form1.LimiteDroite.Location.X) Then
            'Condition2: Si la position de la balle n'est pas situé sur la balle 
            positionDeLaBalle.X += 3
            positionDeLaBalle.Y -= 5
        End If
        Balle.Location = positionDeLaBalle
        ricoche(Balle)
        arreterLeJeu()
        mouvementEncours = "montee1"
    End Sub
    Public Sub montee2(ByRef Balle As Label)
        'L'explication des conditions des différentes conditions est pareil a celles du haut.
        activerTimer_Montee2 = True
        activerTimer_Montee1 = False
        positionDeLaBalle = Balle.Location
        If (positionDeLaBalle.Y > 10) Then
            'Condition1
            positionDeLaBalle.X -= 3
            positionDeLaBalle.Y -= 5
        End If

        If positionDeLaBalle.Y <= 10 And Not (positionDeLaBalle.X >= Form1.La_BateAutomatique.Location.X And positionDeLaBalle.X <= Form1.LimiteDroite.Location.X) Then
            'Condition2: Si la position de la balle n'est pas situé sur la balle 
            positionDeLaBalle.X -= 3
            positionDeLaBalle.Y -= 5
        End If

        Balle.Location = positionDeLaBalle
        ricoche(Balle)
        arreterLeJeu()
        mouvementEncours = "montee2"
    End Sub
    Public Sub descente1(ByRef Balle As Label)
        activerTimer_descente1 = True
        activerTimer_descente2 = False
        positionDeLaBalle.X += 3
        positionDeLaBalle.Y += 5
        'Cette condition permet de ricocher sur le cote droit de la fenetre , lorsque la balle arrive sur lui apres la descente1.
        'La ricoche permet de faire une autre descente , qui est la descente2 mais en ricochant sur le cote droit de la fenetre.(C'est pour ça le True)
        ricoche(Balle)
        Balle.Location = positionDeLaBalle
        arreterLeJeu()
        mouvementEncours = "descente1"
    End Sub
    Public Sub descente2(ByRef Balle As Label)
        activerTimer_descente1 = False
        activerTimer_descente2 = True
        positionDeLaBalle.X -= 3
        positionDeLaBalle.Y += 5
        'Cette condition permet de ricocher sur le cote gauche de la fenetre , lorsque la balle arrive sur lui apres la descente2.
        'La ricoche permet de faire une autre descente , qui est la descente1 mais en ricochant sur le cote gauche de la fenetre.(C'est pour ça le True)
        ricoche(Balle)
        Balle.Location = positionDeLaBalle
        arreterLeJeu()
        mouvementEncours = "descente2"
    End Sub
    Public Sub ricoche(ByRef Balle As Label)
        'La condition1 permet de faire ricocher la balle(Qui est entrain d'entamer la descente2), sur la bate du joueur principal.
        'Et ainsi d'entamer un nouveau mouvement qui est la montee2.
        'Evidement il faut penser à reactiver le deplacement de la bateAutomatique, vu qu'on l'a desactivee apres  l'une ou l'autre montee(montee1,montee2)
        'C'est pour cette raison qu'on va activer cette fonction à nouveau.
        If (mouvementEncours = "montee1") Then
            If Form1.La_Balle.Location.Y <= 10 And (Form1.La_Balle.Location.X >= Form1.La_BateAutomatique.Location.X And positionDeLaBalle.X <= Form1.LimiteDroite.Location.X) Then
                Form1.Timer_descente1.Start()
                activerTimer_Montee1 = False
                activerTimer_Montee2 = False
                activerTimer_descente1 = True
                activerTimer_descente2 = False
            End If
            If (positionDeLaBalle.X > Form1.Width - 42) Then
                activerTimer_descente1 = False
                activerTimer_descente2 = False
                activerTimer_Montee1 = False
                activerTimer_Montee2 = True
                Form1.Timer_Montee2.Start()
            End If
        ElseIf (mouvementEncours = "montee2") Then
            If Form1.La_Balle.Location.Y <= 10 And (Form1.La_Balle.Location.X >= Form1.La_BateAutomatique.Location.X And positionDeLaBalle.X <= Form1.LimiteDroite.Location.X) Then
                Form1.Timer_descente2.Start()
                activerTimer_Montee1 = False
                activerTimer_Montee2 = False
                activerTimer_descente1 = False
                activerTimer_descente2 = True
            End If
            If (positionDeLaBalle.X < 0) Then
                activerTimer_descente1 = False
                activerTimer_descente2 = False
                activerTimer_Montee1 = True
                activerTimer_Montee2 = False
                Form1.Timer_Montee1.Start()
            End If
        ElseIf (mouvementEncours = "descente2")
            If (positionDeLaBalle.X < 0) Then
                activerTimer_descente1 = True
                activerTimer_descente2 = False
                activerTimer_Montee1 = False
                activerTimer_Montee2 = False
                Form1.Timer_descente1.Start()
            End If
            If Form1.La_Balle.Location.Y >= (Form1.Height - 81) And (Form1.La_Balle.Location.X >= Form1.La_BateDuJoueurPrincipale.Location.X And positionDeLaBalle.X <= Form1.Limite_DroiteDuJoueur.Location.X) Then
                'Condition1
                Form1.Timer_Montee2.Start()
                activerTimer_Montee1 = False
                activerTimer_Montee2 = True
                activerTimer_descente1 = False
                activerTimer_descente2 = False
            End If
        ElseIf (mouvementEncours = "descente1") Then
            If (positionDeLaBalle.X > Form1.Width - 42) Then
                activerTimer_descente1 = False
                activerTimer_descente2 = True
                activerTimer_Montee1 = False
                activerTimer_Montee2 = False
                Form1.Timer_descente2.Start()
            End If
            If Form1.La_Balle.Location.Y >= (Form1.Height - 81) And (Form1.La_Balle.Location.X >= Form1.La_BateDuJoueurPrincipale.Location.X And positionDeLaBalle.X <= Form1.Limite_DroiteDuJoueur.Location.X) Then
                'Condition1
                Form1.Timer_Montee1.Start()
                activerTimer_Montee1 = True
                activerTimer_Montee2 = False
                activerTimer_descente1 = False
                activerTimer_descente2 = False
            End If
        End If


    End Sub

    Public Sub determinerLaPositionDeLaBalleALarriver(ByRef Balle As Label, ByRef activerCetteFonction As Boolean)
        'If (mouvementEncours = "montee2") Then
        '    Form1.Label4.Text = activerLaFonction
        'End If
        'If (activerCetteFonction) Then
        positionFinaleDeLaBalle = Form1.La_Balle.Location
        Select Case (mouvementEncours)
            Case "montee1"
                While (positionFinaleDeLaBalle.Y > 10) 'Calcul de la position de la balle à l'arriver (par rapport a l'ordonne de la bate ordonne=10)
                    positionFinaleDeLaBalle.X += 3
                    positionFinaleDeLaBalle.Y -= 5
                End While
                If (positionFinaleDeLaBalle.X > Form1.La_BateAutomatique.Location.X) Then
                    condition1_ALaMain = True
                    condition2_ALaMain = False
                End If
                If (positionFinaleDeLaBalle.X < Form1.La_BateAutomatique.Location.X) Then
                    condition2_ALaMain = True
                    condition1_ALaMain = False
                End If
                Form1.Timer_De_Deplacement_De_La_Bate_Automatique.Start()
            Case "montee2"
                While (positionFinaleDeLaBalle.Y > 10)
                    positionFinaleDeLaBalle.X -= 3
                    positionFinaleDeLaBalle.Y -= 5
                End While
                If (positionFinaleDeLaBalle.X > Form1.La_BateAutomatique.Location.X) Then
                    condition1_ALaMain = True
                    condition2_ALaMain = False
                End If
                If (positionFinaleDeLaBalle.X < Form1.La_BateAutomatique.Location.X) Then
                    condition2_ALaMain = True
                    condition1_ALaMain = False
                End If
                Form1.Timer_De_Deplacement_De_La_Bate_Automatique.Start()
        End Select
        '    activerCetteFonction = False
        'End If
    End Sub
End Module
