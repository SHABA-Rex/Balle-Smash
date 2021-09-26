<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Les_Scores_Et_Niveaux
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Les_Scores_Et_Niveaux))
        Me.Scores = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Le_Niveau = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Rejouer = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.SuspendLayout()
        '
        'Scores
        '
        Me.Scores.AnimationHoverSpeed = 0.07!
        Me.Scores.AnimationSpeed = 0.03!
        Me.Scores.BaseColor = System.Drawing.Color.LimeGreen
        Me.Scores.BorderColor = System.Drawing.Color.Black
        Me.Scores.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Scores.CheckedBorderColor = System.Drawing.Color.Black
        Me.Scores.CheckedForeColor = System.Drawing.Color.White
        Me.Scores.CheckedImage = CType(resources.GetObject("Scores.CheckedImage"), System.Drawing.Image)
        Me.Scores.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Scores.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Scores.FocusedColor = System.Drawing.Color.Empty
        Me.Scores.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scores.ForeColor = System.Drawing.Color.White
        Me.Scores.Image = CType(resources.GetObject("Scores.Image"), System.Drawing.Image)
        Me.Scores.ImageSize = New System.Drawing.Size(52, 52)
        Me.Scores.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Scores.Location = New System.Drawing.Point(4, 30)
        Me.Scores.Name = "Scores"
        Me.Scores.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.Scores.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Scores.OnHoverForeColor = System.Drawing.Color.White
        Me.Scores.OnHoverImage = Nothing
        Me.Scores.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Scores.OnPressedColor = System.Drawing.Color.Black
        Me.Scores.Size = New System.Drawing.Size(127, 130)
        Me.Scores.TabIndex = 0
        Me.Scores.Text = "MON SCORE"
        '
        'Le_Niveau
        '
        Me.Le_Niveau.AnimationHoverSpeed = 0.07!
        Me.Le_Niveau.AnimationSpeed = 0.03!
        Me.Le_Niveau.BaseColor = System.Drawing.Color.LimeGreen
        Me.Le_Niveau.BorderColor = System.Drawing.Color.Black
        Me.Le_Niveau.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Le_Niveau.CheckedBorderColor = System.Drawing.Color.Black
        Me.Le_Niveau.CheckedForeColor = System.Drawing.Color.White
        Me.Le_Niveau.CheckedImage = CType(resources.GetObject("Le_Niveau.CheckedImage"), System.Drawing.Image)
        Me.Le_Niveau.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Le_Niveau.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Le_Niveau.FocusedColor = System.Drawing.Color.Empty
        Me.Le_Niveau.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Le_Niveau.ForeColor = System.Drawing.Color.White
        Me.Le_Niveau.Image = CType(resources.GetObject("Le_Niveau.Image"), System.Drawing.Image)
        Me.Le_Niveau.ImageSize = New System.Drawing.Size(52, 52)
        Me.Le_Niveau.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Le_Niveau.Location = New System.Drawing.Point(136, 30)
        Me.Le_Niveau.Name = "Le_Niveau"
        Me.Le_Niveau.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.Le_Niveau.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Le_Niveau.OnHoverForeColor = System.Drawing.Color.White
        Me.Le_Niveau.OnHoverImage = Nothing
        Me.Le_Niveau.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Le_Niveau.OnPressedColor = System.Drawing.Color.Black
        Me.Le_Niveau.Size = New System.Drawing.Size(126, 130)
        Me.Le_Niveau.TabIndex = 1
        Me.Le_Niveau.Text = "CHANGER LE NIVEAU DU JEU"
        '
        'Rejouer
        '
        Me.Rejouer.AnimationHoverSpeed = 0.07!
        Me.Rejouer.AnimationSpeed = 0.03!
        Me.Rejouer.BaseColor = System.Drawing.Color.LimeGreen
        Me.Rejouer.BorderColor = System.Drawing.Color.Black
        Me.Rejouer.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Rejouer.CheckedBorderColor = System.Drawing.Color.Black
        Me.Rejouer.CheckedForeColor = System.Drawing.Color.White
        Me.Rejouer.CheckedImage = CType(resources.GetObject("Rejouer.CheckedImage"), System.Drawing.Image)
        Me.Rejouer.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Rejouer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Rejouer.FocusedColor = System.Drawing.Color.Empty
        Me.Rejouer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rejouer.ForeColor = System.Drawing.Color.White
        Me.Rejouer.Image = CType(resources.GetObject("Rejouer.Image"), System.Drawing.Image)
        Me.Rejouer.ImageSize = New System.Drawing.Size(52, 52)
        Me.Rejouer.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Rejouer.Location = New System.Drawing.Point(268, 30)
        Me.Rejouer.Name = "Rejouer"
        Me.Rejouer.OnHoverBaseColor = System.Drawing.Color.Orange
        Me.Rejouer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Rejouer.OnHoverForeColor = System.Drawing.Color.White
        Me.Rejouer.OnHoverImage = Nothing
        Me.Rejouer.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Rejouer.OnPressedColor = System.Drawing.Color.Black
        Me.Rejouer.Size = New System.Drawing.Size(131, 130)
        Me.Rejouer.TabIndex = 2
        Me.Rejouer.Text = "JE REJOUE LA PARTIE"
        '
        'Les_Scores_Et_Niveaux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(406, 174)
        Me.Controls.Add(Me.Rejouer)
        Me.Controls.Add(Me.Le_Niveau)
        Me.Controls.Add(Me.Scores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Les_Scores_Et_Niveaux"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Les_Scores_Et_Niveaux"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Scores As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents Le_Niveau As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents Rejouer As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
