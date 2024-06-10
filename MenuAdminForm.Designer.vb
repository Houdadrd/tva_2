<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdminForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjouterDesUtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociétéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterSociétéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FournisseurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDeFournisseursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DéclarationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerUneNouvelleDéclarationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(835, 434)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterDesUtilisateursToolStripMenuItem, Me.SociétéToolStripMenuItem, Me.ClientToolStripMenuItem, Me.FournisseurToolStripMenuItem, Me.DéclarationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(835, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjouterDesUtilisateursToolStripMenuItem
        '
        Me.AjouterDesUtilisateursToolStripMenuItem.Image = CType(resources.GetObject("AjouterDesUtilisateursToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjouterDesUtilisateursToolStripMenuItem.Name = "AjouterDesUtilisateursToolStripMenuItem"
        Me.AjouterDesUtilisateursToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.AjouterDesUtilisateursToolStripMenuItem.Text = "Ajouter des utilisateurs"
        '
        'SociétéToolStripMenuItem
        '
        Me.SociétéToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterSociétéToolStripMenuItem})
        Me.SociétéToolStripMenuItem.Image = CType(resources.GetObject("SociétéToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SociétéToolStripMenuItem.Name = "SociétéToolStripMenuItem"
        Me.SociétéToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.SociétéToolStripMenuItem.Text = "Société"
        '
        'AjouterSociétéToolStripMenuItem
        '
        Me.AjouterSociétéToolStripMenuItem.Name = "AjouterSociétéToolStripMenuItem"
        Me.AjouterSociétéToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.AjouterSociétéToolStripMenuItem.Text = "Liste des sociétés"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesClientsToolStripMenuItem})
        Me.ClientToolStripMenuItem.Image = CType(resources.GetObject("ClientToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'ListeDesClientsToolStripMenuItem
        '
        Me.ListeDesClientsToolStripMenuItem.Name = "ListeDesClientsToolStripMenuItem"
        Me.ListeDesClientsToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ListeDesClientsToolStripMenuItem.Text = "Liste des clients"
        '
        'FournisseurToolStripMenuItem
        '
        Me.FournisseurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDeFournisseursToolStripMenuItem})
        Me.FournisseurToolStripMenuItem.Image = CType(resources.GetObject("FournisseurToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FournisseurToolStripMenuItem.Name = "FournisseurToolStripMenuItem"
        Me.FournisseurToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.FournisseurToolStripMenuItem.Text = "Fournisseur"
        '
        'ListeDeFournisseursToolStripMenuItem
        '
        Me.ListeDeFournisseursToolStripMenuItem.Name = "ListeDeFournisseursToolStripMenuItem"
        Me.ListeDeFournisseursToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ListeDeFournisseursToolStripMenuItem.Text = "Liste de fournisseurs"
        '
        'DéclarationToolStripMenuItem
        '
        Me.DéclarationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréerUneNouvelleDéclarationToolStripMenuItem})
        Me.DéclarationToolStripMenuItem.Image = CType(resources.GetObject("DéclarationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DéclarationToolStripMenuItem.Name = "DéclarationToolStripMenuItem"
        Me.DéclarationToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.DéclarationToolStripMenuItem.Text = "Déclaration"
        '
        'CréerUneNouvelleDéclarationToolStripMenuItem
        '
        Me.CréerUneNouvelleDéclarationToolStripMenuItem.Name = "CréerUneNouvelleDéclarationToolStripMenuItem"
        Me.CréerUneNouvelleDéclarationToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.CréerUneNouvelleDéclarationToolStripMenuItem.Text = "Créer une nouvelle déclaration"
        '
        'MenuAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 466)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuAdminForm"
        Me.Text = "MenuAdminForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AjouterDesUtilisateursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociétéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterSociétéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FournisseurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDeFournisseursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DéclarationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CréerUneNouvelleDéclarationToolStripMenuItem As ToolStripMenuItem
End Class
