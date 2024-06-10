<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCltForm
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
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtCIN = New System.Windows.Forms.TextBox()
        Me.txtAdr = New System.Windows.Forms.TextBox()
        Me.txtNC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEm = New System.Windows.Forms.TextBox()
        Me.DTPDNais = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(210, 286)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(151, 27)
        Me.txtTel.TabIndex = 64
        '
        'txtCIN
        '
        Me.txtCIN.Location = New System.Drawing.Point(210, 202)
        Me.txtCIN.Name = "txtCIN"
        Me.txtCIN.Size = New System.Drawing.Size(151, 27)
        Me.txtCIN.TabIndex = 63
        '
        'txtAdr
        '
        Me.txtAdr.Location = New System.Drawing.Point(210, 132)
        Me.txtAdr.Name = "txtAdr"
        Me.txtAdr.Size = New System.Drawing.Size(151, 27)
        Me.txtAdr.TabIndex = 62
        '
        'txtNC
        '
        Me.txtNC.Location = New System.Drawing.Point(210, 54)
        Me.txtNC.Name = "txtNC"
        Me.txtNC.Size = New System.Drawing.Size(151, 27)
        Me.txtNC.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(50, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 28)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Téléphone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(83, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 28)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "CIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(73, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 28)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Adresse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(33, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 28)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Nom Complet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(73, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 28)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(2, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 28)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Date de naissance"
        '
        'txtEm
        '
        Me.txtEm.Location = New System.Drawing.Point(210, 361)
        Me.txtEm.Name = "txtEm"
        Me.txtEm.Size = New System.Drawing.Size(151, 27)
        Me.txtEm.TabIndex = 67
        '
        'DTPDNais
        '
        Me.DTPDNais.Location = New System.Drawing.Point(210, 434)
        Me.DTPDNais.Name = "DTPDNais"
        Me.DTPDNais.Size = New System.Drawing.Size(250, 27)
        Me.DTPDNais.TabIndex = 68
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(571, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 53)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddCltForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 494)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTPDNais)
        Me.Controls.Add(Me.txtEm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtCIN)
        Me.Controls.Add(Me.txtAdr)
        Me.Controls.Add(Me.txtNC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddCltForm"
        Me.Text = "AddCltForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtCIN As TextBox
    Friend WithEvents txtAdr As TextBox
    Friend WithEvents txtNC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEm As TextBox
    Friend WithEvents DTPDNais As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
