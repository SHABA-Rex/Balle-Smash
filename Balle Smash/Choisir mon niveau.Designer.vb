<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choisir_mon_niveau
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choisir_mon_niveau))
        Me.Niveau_Normal = New Guna.UI.WinForms.GunaButton()
        Me.Niveau_Intermediaire = New Guna.UI.WinForms.GunaButton()
        Me.Haut_Niveau = New Guna.UI.WinForms.GunaButton()
        Me.LabelDeBack = New System.Windows.Forms.Label()
        Me.Boutton_Retour = New Guna.UI.WinForms.GunaImageButton()
        Me.SuspendLayout()
        '
        'Niveau_Normal
        '
        Me.Niveau_Normal.AnimationHoverSpeed = 0.07!
        Me.Niveau_Normal.AnimationSpeed = 0.03!
        Me.Niveau_Normal.BaseColor = System.Drawing.Color.LimeGreen
        Me.Niveau_Normal.BorderColor = System.Drawing.Color.Black
        Me.Niveau_Normal.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Niveau_Normal.FocusedColor = System.Drawing.Color.Empty
        Me.Niveau_Normal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Niveau_Normal.ForeColor = System.Drawing.Color.White
        Me.Niveau_Normal.Image = CType(resources.GetObject("Niveau_Normal.Image"), System.Drawing.Image)
        Me.Niveau_Normal.ImageSize = New System.Drawing.Size(20, 20)
        Me.Niveau_Normal.Location = New System.Drawing.Point(34, 33)
        Me.Niveau_Normal.Name = "Niveau_Normal"
        Me.Niveau_Normal.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Niveau_Normal.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Niveau_Normal.OnHoverForeColor = System.Drawing.Color.White
        Me.Niveau_Normal.OnHoverImage = Nothing
        Me.Niveau_Normal.OnPressedColor = System.Drawing.Color.Black
        Me.Niveau_Normal.Size = New System.Drawing.Size(210, 42)
        Me.Niveau_Normal.TabIndex = 0
        Me.Niveau_Normal.Text = "Normal"
        Me.Niveau_Normal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Niveau_Intermediaire
        '
        Me.Niveau_Intermediaire.AnimationHoverSpeed = 0.07!
        Me.Niveau_Intermediaire.AnimationSpeed = 0.03!
        Me.Niveau_Intermediaire.BaseColor = System.Drawing.Color.LimeGreen
        Me.Niveau_Intermediaire.BorderColor = System.Drawing.Color.Black
        Me.Niveau_Intermediaire.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Niveau_Intermediaire.FocusedColor = System.Drawing.Color.Empty
        Me.Niveau_Intermediaire.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Niveau_Intermediaire.ForeColor = System.Drawing.Color.White
        Me.Niveau_Intermediaire.Image = CType(resources.GetObject("Niveau_Intermediaire.Image"), System.Drawing.Image)
        Me.Niveau_Intermediaire.ImageSize = New System.Drawing.Size(20, 20)
        Me.Niveau_Intermediaire.Location = New System.Drawing.Point(34, 84)
        Me.Niveau_Intermediaire.Name = "Niveau_Intermediaire"
        Me.Niveau_Intermediaire.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.Niveau_Intermediaire.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Niveau_Intermediaire.OnHoverForeColor = System.Drawing.Color.White
        Me.Niveau_Intermediaire.OnHoverImage = Nothing
        Me.Niveau_Intermediaire.OnPressedColor = System.Drawing.Color.Black
        Me.Niveau_Intermediaire.Size = New System.Drawing.Size(210, 42)
        Me.Niveau_Intermediaire.TabIndex = 1
        Me.Niveau_Intermediaire.Text = "Intermédiaire"
        Me.Niveau_Intermediaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Haut_Niveau
        '
        Me.Haut_Niveau.AnimationHoverSpeed = 0.07!
        Me.Haut_Niveau.AnimationSpeed = 0.03!
        Me.Haut_Niveau.BaseColor = System.Drawing.Color.LimeGreen
        Me.Haut_Niveau.BorderColor = System.Drawing.Color.Black
        Me.Haut_Niveau.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Haut_Niveau.FocusedColor = System.Drawing.Color.Empty
        Me.Haut_Niveau.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Haut_Niveau.ForeColor = System.Drawing.Color.White
        Me.Haut_Niveau.Image = CType(resources.GetObject("Haut_Niveau.Image"), System.Drawing.Image)
        Me.Haut_Niveau.ImageSize = New System.Drawing.Size(20, 20)
        Me.Haut_Niveau.Location = New System.Drawing.Point(34, 136)
        Me.Haut_Niveau.Name = "Haut_Niveau"
        Me.Haut_Niveau.OnHoverBaseColor = System.Drawing.Color.Red
        Me.Haut_Niveau.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Haut_Niveau.OnHoverForeColor = System.Drawing.Color.White
        Me.Haut_Niveau.OnHoverImage = Nothing
        Me.Haut_Niveau.OnPressedColor = System.Drawing.Color.Black
        Me.Haut_Niveau.Size = New System.Drawing.Size(210, 42)
        Me.Haut_Niveau.TabIndex = 2
        Me.Haut_Niveau.Text = "Haut-Niveau"
        Me.Haut_Niveau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelDeBack
        '
        Me.LabelDeBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelDeBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeBack.Location = New System.Drawing.Point(23, 1)
        Me.LabelDeBack.Name = "LabelDeBack"
        Me.LabelDeBack.Size = New System.Drawing.Size(42, 16)
        Me.LabelDeBack.TabIndex = 10
        Me.LabelDeBack.Text = "Retour"
        Me.LabelDeBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Boutton_Retour
        '
        Me.Boutton_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Boutton_Retour.BackgroundImage = Global.Balle_Smash.My.Resources.Resources.back_arrow
        Me.Boutton_Retour.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Boutton_Retour.Image = Nothing
        Me.Boutton_Retour.ImageSize = New System.Drawing.Size(20, 20)
        Me.Boutton_Retour.Location = New System.Drawing.Point(-2, -2)
        Me.Boutton_Retour.Name = "Boutton_Retour"
        Me.Boutton_Retour.OnHoverImage = Nothing
        Me.Boutton_Retour.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.Boutton_Retour.Size = New System.Drawing.Size(28, 25)
        Me.Boutton_Retour.TabIndex = 9
        '
        'Choisir_mon_niveau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(278, 218)
        Me.Controls.Add(Me.LabelDeBack)
        Me.Controls.Add(Me.Boutton_Retour)
        Me.Controls.Add(Me.Haut_Niveau)
        Me.Controls.Add(Me.Niveau_Intermediaire)
        Me.Controls.Add(Me.Niveau_Normal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Choisir_mon_niveau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choisir_mon_niveau"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Niveau_Normal As Guna.UI.WinForms.GunaButton
    Friend WithEvents Niveau_Intermediaire As Guna.UI.WinForms.GunaButton
    Friend WithEvents Haut_Niveau As Guna.UI.WinForms.GunaButton
    Friend WithEvents LabelDeBack As Label
    Friend WithEvents Boutton_Retour As Guna.UI.WinForms.GunaImageButton
End Class
