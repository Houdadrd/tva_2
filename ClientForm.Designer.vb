<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientForm))
        Me.DGViewClient = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGViewClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGViewClient
        '
        Me.DGViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewClient.Location = New System.Drawing.Point(24, 37)
        Me.DGViewClient.Name = "DGViewClient"
        Me.DGViewClient.RowHeadersWidth = 51
        Me.DGViewClient.RowTemplate.Height = 29
        Me.DGViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewClient.Size = New System.Drawing.Size(674, 586)
        Me.DGViewClient.TabIndex = 81
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.OuvrirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 28)
        Me.MenuStrip1.TabIndex = 82
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Checked = True
        Me.AjouterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AjouterToolStripMenuItem.Image = CType(resources.GetObject("AjouterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.AjouterToolStripMenuItem.Text = "Nouveau"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Image = CType(resources.GetObject("ModifierToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Image = CType(resources.GetObject("OuvrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'ClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 635)
        Me.Controls.Add(Me.DGViewClient)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "ClientForm"
        Me.Text = "ClientForm"
        CType(Me.DGViewClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGViewClient As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
End Class
