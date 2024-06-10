Imports System.Data.SqlClient

Public Class ClientForm
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
    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        AddCltForm.Show()
    End Sub
    Sub listerClt()
        Try
            If con Is Nothing OrElse con.State = ConnectionState.Closed Then
                Connexion()
            End If
            Dim cmd As New SqlCommand("SELECT CIN, NomComplet AS [Nom Complet], adresse, Tel AS [Téléphone] FROM Client", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            T = New DataTable
            T.Load(dr)
            DGViewClient.DataSource = T
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DGViewClient_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewClient.CellContentDoubleClick
        ' Vérifier si une ligne est sélectionnée
        If e.RowIndex >= 0 AndAlso e.RowIndex < DGViewClient.Rows.Count Then
            ' Obtenir la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DGViewClient.Rows(e.RowIndex)

            ' Obtenir les valeurs des cellules de la ligne sélectionnée
            Dim cin As String = selectedRow.Cells("CIN").Value.ToString()
            Dim nc As String = selectedRow.Cells("Nom Complet").Value.ToString()
            Dim adresse As String = selectedRow.Cells("adresse").Value.ToString()
            Dim tel As String = selectedRow.Cells("Téléphone").Value.ToString()

            ' Créer une instance du formulaire de détails
            Dim detailsForm As New DetailsCltForm(cin, nc, adresse, tel)

            ' Afficher le formulaire de détails
            detailsForm.ShowDialog()
        End If
    End Sub
    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
        listerClt()
    End Sub
    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        ' Vérifier si une ligne est sélectionnée
        If DGViewClient.SelectedRows.Count > 0 Then
            ' Obtenir la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DGViewClient.SelectedRows(0)

            ' Obtenir les valeurs des cellules de la ligne sélectionnée
            Dim cin As String = selectedRow.Cells("CIN").Value.ToString()
            Dim nc As String = selectedRow.Cells("Nom Complet").Value.ToString()
            Dim adresse As String = selectedRow.Cells("adresse").Value.ToString()
            Dim tel As String = selectedRow.Cells("Téléphone").Value.ToString()

            ' Créer une instance du formulaire de détails
            Dim detailsForm As New DetailsCltForm(cin, nc, adresse, tel)

            ' Afficher le formulaire de détails
            detailsForm.ShowDialog()
        Else
            MessageBox.Show("Veuillez sélectionner une ligne.", "Aucune ligne sélectionnée")
        End If
    End Sub
End Class