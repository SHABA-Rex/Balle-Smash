<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score_des_joueurs
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
        Me.Mon_Score = New System.Windows.Forms.Label()
        Me.Son_Score = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelDeBack = New System.Windows.Forms.Label()
        Me.Boutton_Retour = New Guna.UI.WinForms.GunaImageButton()
        Me.SuspendLayout()
        '
        'Mon_Score
        '
        Me.Mon_Score.BackColor = System.Drawing.Color.Lime
        Me.Mon_Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.25!)
        Me.Mon_Score.Location = New System.Drawing.Point(-1, 53)
        Me.Mon_Score.Name = "Mon_Score"
        Me.Mon_Score.Size = New System.Drawing.Size(194, 222)
        Me.Mon_Score.TabIndex = 2
        Me.Mon_Score.Text = "0"
        Me.Mon_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Son_Score
        '
        Me.Son_Score.BackColor = System.Drawing.Color.Lime
        Me.Son_Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.25!)
        Me.Son_Score.Location = New System.Drawing.Point(187, 53)
        Me.Son_Score.Name = "Son_Score"
        Me.Son_Score.Size = New System.Drawing.Size(182, 222)
        Me.Son_Score.TabIndex = 3
        Me.Son_Score.Text = "0"
        Me.Son_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(183, -12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 287)
        Me.Label3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, -8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 60)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mon Score"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(202, -8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 60)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Son Score"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDeBack
        '
        Me.LabelDeBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelDeBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeBack.Location = New System.Drawing.Point(24, 1)
        Me.LabelDeBack.Name = "LabelDeBack"
        Me.LabelDeBack.Size = New System.Drawing.Size(42, 16)
        Me.LabelDeBack.TabIndex = 8
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
        Me.Boutton_Retour.Location = New System.Drawing.Point(-1, -2)
        Me.Boutton_Retour.Name = "Boutton_Retour"
        Me.Boutton_Retour.OnHoverImage = Nothing
        Me.Boutton_Retour.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.Boutton_Retour.Size = New System.Drawing.Size(28, 25)
        Me.Boutton_Retour.TabIndex = 7
        '
        'Score_des_joueurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(368, 273)
        Me.Controls.Add(Me.LabelDeBack)
        Me.Controls.Add(Me.Boutton_Retour)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Son_Score)
        Me.Controls.Add(Me.Mon_Score)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Score_des_joueurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scores des joueurs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mon_Score As Label
    Friend WithEvents Son_Score As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelDeBack As Label
    Friend WithEvents Boutton_Retour As Guna.UI.WinForms.GunaImageButton
End Class
