Public Class Score_des_joueurs
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
End Class