<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeclaForm
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
        Me.txtAn = New System.Windows.Forms.TextBox()
        Me.cmbBoxPeriode = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbBoxSoc = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAn
        '
        Me.txtAn.Location = New System.Drawing.Point(147, 156)
        Me.txtAn.Name = "txtAn"
        Me.txtAn.Size = New System.Drawing.Size(151, 27)
        Me.txtAn.TabIndex = 22
        '
        'cmbBoxPeriode
        '
        Me.cmbBoxPeriode.FormattingEnabled = True
        Me.cmbBoxPeriode.Location = New System.Drawing.Point(147, 93)
        Me.cmbBoxPeriode.Name = "cmbBoxPeriode"
        Me.cmbBoxPeriode.Size = New System.Drawing.Size(151, 28)
        Me.cmbBoxPeriode.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1831, 658)
        Me.DataGridView1.TabIndex = 20
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(1159, 92)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 69)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Vider"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(933, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 69)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Générer fichier XML"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(737, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 69)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Importer un fichier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbBoxSoc
        '
        Me.cmbBoxSoc.FormattingEnabled = True
        Me.cmbBoxSoc.Location = New System.Drawing.Point(147, 27)
        Me.cmbBoxSoc.Name = "cmbBoxSoc"
        Me.cmbBoxSoc.Size = New System.Drawing.Size(151, 28)
        Me.cmbBoxSoc.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(41, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Année"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(41, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Période"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(48, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Société"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(480, 92)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(236, 70)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Télécharger feuille de préparation"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DeclaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 907)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtAn)
        Me.Controls.Add(Me.cmbBoxPeriode)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbBoxSoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DeclaForm"
        Me.Text = "DeclaForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAn As TextBox
    Friend WithEvents cmbBoxPeriode As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbBoxSoc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button3 As Button
End Class
