<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InscriForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InscriForm))
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmotPasse = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(285, 399)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(151, 28)
        Me.CmbStatus.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(112, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 28)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Status"
        '
        'txtmotPasse
        '
        Me.txtmotPasse.Location = New System.Drawing.Point(269, 339)
        Me.txtmotPasse.Multiline = True
        Me.txtmotPasse.Name = "txtmotPasse"
        Me.txtmotPasse.Size = New System.Drawing.Size(177, 35)
        Me.txtmotPasse.TabIndex = 36
        Me.txtmotPasse.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(269, 273)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(177, 36)
        Me.txtUsername.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(205, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 40)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "S'inscrire"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(219, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'btnFermer
        '
        Me.btnFermer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFermer.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFermer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFermer.Location = New System.Drawing.Point(285, 500)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(132, 56)
        Me.btnFermer.TabIndex = 40
        Me.btnFermer.Text = "Quitter"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRegister.Location = New System.Drawing.Point(109, 500)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(131, 56)
        Me.btnRegister.TabIndex = 39
        Me.btnRegister.Text = "Valider"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(80, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 28)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Mot de passe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(61, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 28)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nom d'utilisateur"
        '
        'InscriForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 599)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmotPasse)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InscriForm"
        Me.Text = "InscriForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmotPasse As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFermer As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
