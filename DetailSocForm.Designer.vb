<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailSocForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIF = New System.Windows.Forms.TextBox()
        Me.txtAct = New System.Windows.Forms.TextBox()
        Me.lblTypeActivite = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.txtRgm = New System.Windows.Forms.TextBox()
        Me.txtAdr = New System.Windows.Forms.TextBox()
        Me.txtRS = New System.Windows.Forms.TextBox()
        Me.lblRegime = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.txtPrd = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtIF
        '
        Me.txtIF.Location = New System.Drawing.Point(192, 96)
        Me.txtIF.Name = "txtIF"
        Me.txtIF.Size = New System.Drawing.Size(176, 27)
        Me.txtIF.TabIndex = 112
        '
        'txtAct
        '
        Me.txtAct.Location = New System.Drawing.Point(192, 208)
        Me.txtAct.Name = "txtAct"
        Me.txtAct.Size = New System.Drawing.Size(176, 27)
        Me.txtAct.TabIndex = 111
        '
        'lblTypeActivite
        '
        Me.lblTypeActivite.AutoSize = True
        Me.lblTypeActivite.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTypeActivite.Location = New System.Drawing.Point(12, 204)
        Me.lblTypeActivite.Name = "lblTypeActivite"
        Me.lblTypeActivite.Size = New System.Drawing.Size(163, 28)
        Me.lblTypeActivite.TabIndex = 110
        Me.lblTypeActivite.Text = "Type d'activitée"
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblVille.Location = New System.Drawing.Point(62, 153)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(54, 28)
        Me.lblVille.TabIndex = 109
        Me.lblVille.Text = "Ville"
        '
        'txtV
        '
        Me.txtV.Location = New System.Drawing.Point(192, 153)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(176, 27)
        Me.txtV.TabIndex = 108
        '
        'txtRgm
        '
        Me.txtRgm.Location = New System.Drawing.Point(702, 95)
        Me.txtRgm.Name = "txtRgm"
        Me.txtRgm.Size = New System.Drawing.Size(174, 27)
        Me.txtRgm.TabIndex = 107
        '
        'txtAdr
        '
        Me.txtAdr.Location = New System.Drawing.Point(702, 46)
        Me.txtAdr.Name = "txtAdr"
        Me.txtAdr.Size = New System.Drawing.Size(174, 27)
        Me.txtAdr.TabIndex = 106
        '
        'txtRS
        '
        Me.txtRS.Location = New System.Drawing.Point(192, 46)
        Me.txtRS.Name = "txtRS"
        Me.txtRS.Size = New System.Drawing.Size(176, 27)
        Me.txtRS.TabIndex = 105
        '
        'lblRegime
        '
        Me.lblRegime.AutoSize = True
        Me.lblRegime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegime.Location = New System.Drawing.Point(599, 95)
        Me.lblRegime.Name = "lblRegime"
        Me.lblRegime.Size = New System.Drawing.Size(83, 28)
        Me.lblRegime.TabIndex = 104
        Me.lblRegime.Text = "Regime"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAdresse.Location = New System.Drawing.Point(596, 42)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(86, 28)
        Me.lblAdresse.TabIndex = 103
        Me.lblAdresse.Text = "Adresse"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(18, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Identifiant fiscal"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNom.Location = New System.Drawing.Point(42, 42)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(135, 28)
        Me.lblNom.TabIndex = 101
        Me.lblNom.Text = "Raison social"
        '
        'btnFermer
        '
        Me.btnFermer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFermer.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFermer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFermer.Location = New System.Drawing.Point(823, 319)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(118, 51)
        Me.btnFermer.TabIndex = 113
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'txtPrd
        '
        Me.txtPrd.Location = New System.Drawing.Point(702, 208)
        Me.txtPrd.Name = "txtPrd"
        Me.txtPrd.Size = New System.Drawing.Size(174, 27)
        Me.txtPrd.TabIndex = 117
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(702, 154)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(174, 27)
        Me.txtTel.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(596, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 28)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Période"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(587, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 28)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Téléphone"
        '
        'DetailSocForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 382)
        Me.Controls.Add(Me.txtPrd)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.txtIF)
        Me.Controls.Add(Me.txtAct)
        Me.Controls.Add(Me.lblTypeActivite)
        Me.Controls.Add(Me.lblVille)
        Me.Controls.Add(Me.txtV)
        Me.Controls.Add(Me.txtRgm)
        Me.Controls.Add(Me.txtAdr)
        Me.Controls.Add(Me.txtRS)
        Me.Controls.Add(Me.lblRegime)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNom)
        Me.Name = "DetailSocForm"
        Me.Text = "DetailSocForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIF As TextBox
    Friend WithEvents txtAct As TextBox
    Friend WithEvents lblTypeActivite As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents txtV As TextBox
    Friend WithEvents txtRgm As TextBox
    Friend WithEvents txtAdr As TextBox
    Friend WithEvents txtRS As TextBox
    Friend WithEvents lblRegime As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents btnFermer As Button
    Friend WithEvents txtPrd As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
