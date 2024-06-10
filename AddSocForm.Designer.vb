<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSocForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtIF = New System.Windows.Forms.TextBox()
        Me.txtAct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.txtRgm = New System.Windows.Forms.TextBox()
        Me.txtAdr = New System.Windows.Forms.TextBox()
        Me.txtRS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(560, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 53)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtIF
        '
        Me.txtIF.Location = New System.Drawing.Point(171, 114)
        Me.txtIF.Name = "txtIF"
        Me.txtIF.Size = New System.Drawing.Size(176, 27)
        Me.txtIF.TabIndex = 100
        '
        'txtAct
        '
        Me.txtAct.Location = New System.Drawing.Point(1019, 119)
        Me.txtAct.Name = "txtAct"
        Me.txtAct.Size = New System.Drawing.Size(211, 27)
        Me.txtAct.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(832, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 28)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Type d'activitée"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(901, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 28)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Ville"
        '
        'txtV
        '
        Me.txtV.Location = New System.Drawing.Point(1019, 60)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(193, 27)
        Me.txtV.TabIndex = 96
        '
        'txtRgm
        '
        Me.txtRgm.Location = New System.Drawing.Point(540, 118)
        Me.txtRgm.Name = "txtRgm"
        Me.txtRgm.Size = New System.Drawing.Size(174, 27)
        Me.txtRgm.TabIndex = 95
        '
        'txtAdr
        '
        Me.txtAdr.Location = New System.Drawing.Point(540, 60)
        Me.txtAdr.Name = "txtAdr"
        Me.txtAdr.Size = New System.Drawing.Size(174, 27)
        Me.txtAdr.TabIndex = 94
        '
        'txtRS
        '
        Me.txtRS.Location = New System.Drawing.Point(171, 64)
        Me.txtRS.Name = "txtRS"
        Me.txtRS.Size = New System.Drawing.Size(176, 27)
        Me.txtRS.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(437, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 28)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Regime"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(437, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 28)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Adresse"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(-3, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Identifiant fiscal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 28)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Raison social"
        '
        'AddSocForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 270)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIF)
        Me.Controls.Add(Me.txtAct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtV)
        Me.Controls.Add(Me.txtRgm)
        Me.Controls.Add(Me.txtAdr)
        Me.Controls.Add(Me.txtRS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddSocForm"
        Me.Text = "AddSocForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtIF As TextBox
    Friend WithEvents txtAct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtV As TextBox
    Friend WithEvents txtRgm As TextBox
    Friend WithEvents txtAdr As TextBox
    Friend WithEvents txtRS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
