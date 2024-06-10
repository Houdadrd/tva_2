Imports System.Data.SqlClient

Public Class SocForm
    Private T As DataTable
    Dim con As SqlConnection

    Sub Connexion()
        Try
            con = New SqlConnection("initial catalog=dec_tva ; data source=DESKTOP-HDVAAHA\SQLEXPRESS ;
            integrated security=true")
            con.Open()
        Catch ex As Exception
            MsgBox("Erreur" + ex.Message)
        End Try
    End Sub
    Sub ListerSociete()
        Try
            ' Vérifiez que la connexion est ouverte
            If con Is Nothing OrElse con.State = ConnectionState.Closed Then
                Connexion()
            End If
            Dim cmd As New SqlCommand("SELECT IfS AS [Identifiant fiscal], RaisonSocial AS [Raison social], adresse, ville, type_activitee AS [Type activitée] FROM Societe", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            T = New DataTable
            T.Load(dr)
            DGViewSociete.DataSource = T
            dr.Close()
        Catch ex As Exception
            MsgBox("Erreur lors de l'accès à la base de données : " & ex.Message)
        End Try
    End Sub
    Private Sub SocForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
        ListerSociete()
    End Sub
    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        AddSocForm.Show()
        Me.Hide()
    End Sub
    Private Sub DGViewSociete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewSociete.CellContentClick

    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        ' Vérifier si une ligne est sélectionnée
        If DGViewSociete.SelectedRows.Count > 0 Then
            ' Obtenir la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DGViewSociete.SelectedRows(0)

            ' Obtenir les valeurs des cellules de la ligne sélectionnée
            Dim identifiantFiscal As String = selectedRow.Cells("Identifiant fiscal").Value.ToString()
            Dim raisonSociale As String = selectedRow.Cells("Raison social").Value.ToString()
            Dim adresse As String = selectedRow.Cells("adresse").Value.ToString()
            Dim ville As String = selectedRow.Cells("ville").Value.ToString()
            Dim typeActivitee As String = selectedRow.Cells("Type activitée").Value.ToString()

            ' Créer une instance du formulaire de détails
            Dim detailsForm As New DetailSocForm(identifiantFiscal, raisonSociale, adresse, ville, typeActivitee)

            ' Afficher le formulaire de détails
            detailsForm.ShowDialog()
        Else
            MessageBox.Show("Veuillez sélectionner une ligne.", "Aucune ligne sélectionnée")
        End If
    End Sub

    Private Sub DGViewSociete_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewSociete.CellDoubleClick
        ' Vérifier si une ligne est sélectionnée
        If e.RowIndex >= 0 AndAlso e.RowIndex < DGViewSociete.Rows.Count Then
            ' Obtenir la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DGViewSociete.Rows(e.RowIndex)

            ' Obtenir les valeurs des cellules de la ligne sélectionnée
            Dim identifiantFiscal As String = selectedRow.Cells("Identifiant fiscal").Value.ToString()
            Dim raisonSociale As String = selectedRow.Cells("Raison social").Value.ToString()
            Dim adresse As String = selectedRow.Cells("adresse").Value.ToString()
            Dim ville As String = selectedRow.Cells("ville").Value.ToString()
            Dim typeActivitee As String = selectedRow.Cells("Type activitée").Value.ToString()

            ' Créer une instance du formulaire de détails
            Dim detailsForm As New DetailSocForm(identifiantFiscal, raisonSociale, adresse, ville, typeActivitee)

            ' Afficher le formulaire de détails
            detailsForm.ShowDialog()
        End If
    End Sub
End Class