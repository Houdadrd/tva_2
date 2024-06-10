<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailsFournForm
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
        Me.txtNC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEm = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtICE = New System.Windows.Forms.TextBox()
        Me.txtAdr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIF
        '
        Me.txtIF.Location = New System.Drawing.Point(185, 106)
        Me.txtIF.Name = "txtIF"
        Me.txtIF.Size = New System.Drawing.Size(170, 27)
        Me.txtIF.TabIndex = 88
        '
        'txtNC
        '
        Me.txtNC.Location = New System.Drawing.Point(185, 44)
        Me.txtNC.Name = "txtNC"
        Me.txtNC.Size = New System.Drawing.Size(170, 27)
        Me.txtNC.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Identifiant fiscal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 28)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Nom complet"
        '
        'txtEm
        '
        Me.txtEm.Location = New System.Drawing.Point(774, 170)
        Me.txtEm.Name = "txtEm"
        Me.txtEm.Size = New System.Drawing.Size(169, 27)
        Me.txtEm.TabIndex = 100
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(774, 102)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(169, 27)
        Me.txtTel.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(675, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 28)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(639, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 28)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Téléphone "
        '
        'txtICE
        '
        Me.txtICE.Location = New System.Drawing.Point(774, 40)
        Me.txtICE.Name = "txtICE"
        Me.txtICE.Size = New System.Drawing.Size(169, 27)
        Me.txtICE.TabIndex = 96
        '
        'txtAdr
        '
        Me.txtAdr.Location = New System.Drawing.Point(185, 174)
        Me.txtAdr.Name = "txtAdr"
        Me.txtAdr.Size = New System.Drawing.Size(170, 27)
        Me.txtAdr.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(684, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 28)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "ICE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(82, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 28)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Adresse"
        '
        'btnFermer
        '
        Me.btnFermer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFermer.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFermer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFermer.Location = New System.Drawing.Point(896, 229)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(118, 51)
        Me.btnFermer.TabIndex = 114
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'DetailsFournForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 286)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.txtEm)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtICE)
        Me.Controls.Add(Me.txtAdr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIF)
        Me.Controls.Add(Me.txtNC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DetailsFournForm"
        Me.Text = "DetailsFournForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIF As TextBox
    Friend WithEvents txtNC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEm As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtICE As TextBox
    Friend WithEvents txtAdr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFermer As Button
End Class
