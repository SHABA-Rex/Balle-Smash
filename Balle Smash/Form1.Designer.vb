<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.La_BateAutomatique = New System.Windows.Forms.Label()
        Me.Timer_Montee1 = New System.Windows.Forms.Timer(Me.components)
        Me.La_Balle = New System.Windows.Forms.Label()
        Me.Timer_De_Deplacement_De_La_Bate_Automatique = New System.Windows.Forms.Timer(Me.components)
        Me.LimiteDroite = New System.Windows.Forms.Label()
        Me.Timer_Montee2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_descente1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_descente2 = New System.Windows.Forms.Timer(Me.components)
        Me.Limite_DroiteDuJoueur = New System.Windows.Forms.Label()
        Me.La_BateDuJoueurPrincipale = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'La_BateAutomatique
        '
        Me.La_BateAutomatique.BackColor = System.Drawing.Color.LimeGreen
        Me.La_BateAutomatique.Location = New System.Drawing.Point(216, 0)
        Me.La_BateAutomatique.Name = "La_BateAutomatique"
        Me.La_BateAutomatique.Size = New System.Drawing.Size(219, 10)
        Me.La_BateAutomatique.TabIndex = 0
        '
        'Timer_Montee1
        '
        Me.Timer_Montee1.Interval = 20
        '
        'La_Balle
        '
        Me.La_Balle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.La_Balle.Location = New System.Drawing.Point(12, 439)
        Me.La_Balle.Name = "La_Balle"
        Me.La_Balle.Size = New System.Drawing.Size(26, 26)
        Me.La_Balle.TabIndex = 7
        '
        'Timer_De_Deplacement_De_La_Bate_Automatique
        '
        Me.Timer_De_Deplacement_De_La_Bate_Automatique.Interval = 20
        '
        'LimiteDroite
        '
        Me.LimiteDroite.BackColor = System.Drawing.Color.Gray
        Me.LimiteDroite.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimiteDroite.Location = New System.Drawing.Point(435, 0)
        Me.LimiteDroite.Name = "LimiteDroite"
        Me.LimiteDroite.Size = New System.Drawing.Size(10, 10)
        Me.LimiteDroite.TabIndex = 8
        Me.LimiteDroite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_Montee2
        '
        Me.Timer_Montee2.Interval = 20
        '
        'Timer_descente1
        '
        Me.Timer_descente1.Interval = 20
        '
        'Timer_descente2
        '
        Me.Timer_descente2.Interval = 20
        '
        'Limite_DroiteDuJoueur
        '
        Me.Limite_DroiteDuJoueur.BackColor = System.Drawing.Color.Gray
        Me.Limite_DroiteDuJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limite_DroiteDuJoueur.Location = New System.Drawing.Point(435, 483)
        Me.Limite_DroiteDuJoueur.Name = "Limite_DroiteDuJoueur"
        Me.Limite_DroiteDuJoueur.Size = New System.Drawing.Size(10, 10)
        Me.Limite_DroiteDuJoueur.TabIndex = 10
        Me.Limite_DroiteDuJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La_BateDuJoueurPrincipale
        '
        Me.La_BateDuJoueurPrincipale.BackColor = System.Drawing.Color.LimeGreen
        Me.La_BateDuJoueurPrincipale.Location = New System.Drawing.Point(216, 483)
        Me.La_BateDuJoueurPrincipale.Name = "La_BateDuJoueurPrincipale"
        Me.La_BateDuJoueurPrincipale.Size = New System.Drawing.Size(219, 10)
        Me.La_BateDuJoueurPrincipale.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 492)
        Me.Controls.Add(Me.Limite_DroiteDuJoueur)
        Me.Controls.Add(Me.La_BateDuJoueurPrincipale)
        Me.Controls.Add(Me.LimiteDroite)
        Me.Controls.Add(Me.La_Balle)
        Me.Controls.Add(Me.La_BateAutomatique)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents La_BateAutomatique As Label
    Friend WithEvents Timer_Montee1 As Timer
    Friend WithEvents La_Balle As Label
    Friend WithEvents Timer_De_Deplacement_De_La_Bate_Automatique As Timer
    Friend WithEvents LimiteDroite As Label
    Friend WithEvents Timer_Montee2 As Timer
    Friend WithEvents Timer_descente1 As Timer
    Friend WithEvents Timer_descente2 As Timer
    Friend WithEvents Limite_DroiteDuJoueur As Label
    Friend WithEvents La_BateDuJoueurPrincipale As Label
End Class
