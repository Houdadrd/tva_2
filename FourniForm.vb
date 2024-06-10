Imports System.Data.SqlClient

Public Class FourniForm
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
    Sub listerFourni()
        Try
            If con Is Nothing OrElse con.State = ConnectionState.Closed Then
                Connexion()
            End If
            Dim cmd = New SqlCommand("select IFFourni as [Identifiant fiscal], nom as [Nom Complet], ICE, adresse, Tel as [Téléphone], email as [Email] from Fournisseur", con)
            Dim dr = cmd.ExecuteReader()
            T = New DataTable
            T.Load(dr)
            DGViewFourni.DataSource = T
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FourniForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
        listerFourni()
    End Sub
    Private Sub DGViewFourni_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewFourni.CellContentDoubleClick
        ' Vérifier si une ligne est sélectionnée
        If e.RowIndex >= 0 AndAlso e.RowIndex < DGViewFourni.Rows.Count Then
            ' Obtenir la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DGViewFourni.Rows(e.RowIndex)

            ' Obtenir les valeurs des cellules de la ligne sélectionnée
            Dim ifF As String = selectedRow.Cells("Identifiant fiscal").Value.ToString()
            Dim nc As String = selectedRow.Cells("Nom Complet").Value.ToString()
            Dim adresse As String = selectedRow.Cells("adresse").Value.ToString()
            Dim tel As String = selectedRow.Cells("Téléphone").Value.ToString()
            Dim ice As String = selectedRow.Cells("ICE").Value.ToString()
            Dim em As String = selectedRow.Cells("ICE").Value.ToString()


            ' Créer une instance du formulaire de détails
            Dim detailsForm As New DetailsFournForm(ifF, ice, nc, adresse, tel, em)

            ' Afficher le formulaire de détails
            detailsForm.ShowDialog()
        End If
    End Sub
    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        ' Vérifier si une ligne est sélectionnée
        If DGViewFourni.SelectedRows.Count > 0 Then
            ' Obtenir la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DGViewFourni.SelectedRows(0)

            ' Obtenir les valeurs des cellules de la ligne sélectionnée
            Dim ifF As String = selectedRow.Cells("Identifiant fiscal").Value.ToString()
            Dim nc As String = selectedRow.Cells("Nom Complet").Value.ToString()
            Dim adresse As String = selectedRow.Cells("adresse").Value.ToString()
            Dim tel As String = selectedRow.Cells("Téléphone").Value.ToString()
            Dim ice As String = selectedRow.Cells("Email").Value.ToString()
            Dim em As String = selectedRow.Cells("ICE").Value.ToString()



            ' Créer une instance du formulaire de détails
            Dim detailsForm As New DetailsFournForm(ifF, ice, nc, adresse, tel, em)

            ' Afficher le formulaire de détails
            detailsForm.ShowDialog()
        Else
            MessageBox.Show("Veuillez sélectionner une ligne.", "Aucune ligne sélectionnée")
        End If
    End Sub
End Class