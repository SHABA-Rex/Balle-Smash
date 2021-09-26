Module Les_Variables
    Public laMonteeChoisiePourDemarrerLeJeu As Integer = 1
    Public monScore, sonScore As Integer
    'Public nbreDePasPourAllerVersLaGaucheOuVersLaDroite As Integer = 3
    Public positionDeLaBalle, positionFinaleDeLaBalle, positionDeLaBallePourDemarrerLeJeu As Point
    Public positionDeLaBateAutomatique As Point = Form1.La_BateAutomatique.Location
    Public mouvementEncours, sensDeLaBalle As String
    Public activerLaFonction As Boolean = True
    Public positionDeLaLimiteDroite As Point = Form1.LimiteDroite.Location
    Public laPositionFinale_De_LaBalleSeSitueDevantLaBateAutomatique As Boolean = False
    Public laPositionFinale_De_laBalleSeSitueDerrièreLaBateAutomatique As Boolean = False
    Public condition1_ALaMain = False, condition2_ALaMain = False
    Public activerTimer_Montee1 = True, activerTimer_Montee2 = True, activerTimer_descente1 = True, activerTimer_descente2 = True
    'Par rapport à ces deux variables booleene (qui sont utilisés dans le Timer_De_Deplacement), il s'agit d'activer ou de désactiver les conditions condition1 ou condition2.
    'Car on ne veut pas que ces deux conditions s'active de maniere infini, car si on quitte la condition1 , alors on va activer la condition2
    'Et lorsqu'on va quitter la condition2 alors on entrera dans la condition1 et ainsi de suite donc pour eviter ça on va activer ou désactiver
    'L'une des conditions quand l'autre sera activé.

End Module
