Public Class MenuAdminForm
    Private Sub AjouterSociétéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterSociétéToolStripMenuItem.Click
        SocForm.Show()
    End Sub

    Private Sub ListeDesClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesClientsToolStripMenuItem.Click
        ClientForm.Show()
    End Sub

    Private Sub ListeDeFournisseursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDeFournisseursToolStripMenuItem.Click
        'FourniForm.Show()
        FourniForm.Show()

    End Sub

    Private Sub CréerUneNouvelleDéclarationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUneNouvelleDéclarationToolStripMenuItem.Click
        DeclaForm.Show()

    End Sub
End Class