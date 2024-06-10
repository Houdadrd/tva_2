Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml
Imports Microsoft.VisualBasic.FileIO

Public Class DeclaForm
    'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;"
    'Dim excelConnection As OleDbConnection
    'Dim excelDataAdapter As OleDbDataAdapter
    Dim excelDataTable As New DataTable()
    'Dim textDataTable As New DataTable()
    'Dim csvDataTable As New DataTable()

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
    Sub CmbSociete()
        Try
            Dim cmd = New SqlCommand("select IfS from Societe", con)
            Dim dr = cmd.ExecuteReader()
            Dim T As New DataTable
            T.Load(dr)
            cmbBoxSoc.ValueMember = "IfS"
            cmbBoxSoc.DisplayMember = "IfS"
            cmbBoxSoc.DataSource = T
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des sociétés: " & ex.Message)
        End Try
    End Sub
    Private Sub DeclaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
        CmbSociete()
        cmbBoxPeriode_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'OpenFileDialog1.ShowDialog()
        Dim openFileDialog1 As New OpenFileDialog()

        'openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        openFileDialog1.Title = "Select an Excel File"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName
            Dim fileExtension As String = Path.GetExtension(filePath)

            If fileExtension = ".xls" OrElse fileExtension = ".xlsx" Then
                ImportExcel(filePath)
            ElseIf fileExtension = ".txt" Then
                ImportText(filePath)
            ElseIf fileExtension = ".csv" Then
                ImportCSV(filePath)
            Else
                MessageBox.Show("Le fichier sélectionné n'est pas pris en charge.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub ImportExcel(filePath As String)
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filePath & ";Extended Properties='Excel 12.0;HDR=YES;'"
        Dim excelConnection As New OleDbConnection(connectionString)
        Try

            excelConnection.Open()
            Dim excelCommand As New OleDbCommand("SELECT * FROM [Feuil1$]", excelConnection)
            Dim excelDataAdapter As New OleDbDataAdapter(excelCommand)
           
            excelDataAdapter.Fill(excelDataTable)
            DataGridView1.DataSource = excelDataTable
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'importation du fichier Excel : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            excelConnection.Close()
        End Try
    End Sub
    Private Sub ImportText(filePath As String)
        Dim textLines As String() = File.ReadAllLines(filePath)
        Dim textDataTable As New DataTable()

        ' Supposons que le fichier texte contient des données séparées par des tabulations
        ' textDataTable.Columns.AddRange({"N°ordre de la facture", "N° de facture", "Désignation du bien ou service", "Montant HT", "Montant de la TVA", "Montant TTC", "I.F du fournisseur", "Nom ou Raison sociale du fournisseur", "Taux de la TVA", "Prorata", "Mode de paiement", "Date de paiement", "Date facture"})
        textDataTable.Columns.AddRange(textLines.First().Split(vbTab).Select(Function(column) New DataColumn(column)).ToArray())


        For Each line As String In textLines
            Dim parts As String() = line.Split(vbTab)
            textDataTable.Rows.Add(parts)
        Next
        DataGridView1.DataSource = textDataTable
    End Sub
    Private Sub ImportCSV(filePath As String)
        Dim csvDataTable As New DataTable()

        Using csvReader As New TextFieldParser(filePath)
            csvReader.TextFieldType = FieldType.Delimited
            csvReader.SetDelimiters(",")

            'csvDataTable.Columns.AddRange({"N°ordre de la facture", "N° de facture", "Désignation du bien ou service", "Montant HT", "Montant de la TVA", "Montant TTC", "I.F du fournisseur", "Nom ou Raison sociale du fournisseur", "Taux de la TVA", "Prorata", "Mode de paiement", "Date de paiement", "Date facture"})

            While Not csvReader.EndOfData
                Dim fields As String() = csvReader.ReadFields()
                If csvDataTable.Columns.Count = 0 Then
                    ' Ajouter des colonnes si elles n'existent pas
                    csvDataTable.Columns.AddRange(fields.Select(Function(field) New DataColumn(field)).ToArray())
                Else
                    ' Ajouter une nouvelle ligne de données
                    csvDataTable.Rows.Add(fields)
                End If
            End While
        End Using

        DataGridView1.DataSource = csvDataTable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Afficher la boîte de dialogue pour sauvegarder le fichier
        SaveFileDialog1.ShowDialog()

        ' Vérifier si la DataGridView a une source de données et si c'est un DataTable
        If DataGridView1.DataSource IsNot Nothing AndAlso TypeOf DataGridView1.DataSource Is DataTable Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Fichier XML|*.xml"
            saveFileDialog1.Title = "Sauvegarder le fichier XML"
            saveFileDialog1.FileName = "fichier.xml"
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            ' Afficher la boîte de dialogue de sauvegarde et traiter la sélection de l'utilisateur
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim xmlFilePath As String = saveFileDialog1.FileName
                Dim xmlWriter As New XmlTextWriter(xmlFilePath, System.Text.Encoding.UTF8)
                xmlWriter.WriteStartDocument(True)
                xmlWriter.Formatting = Formatting.Indented
                xmlWriter.Indentation = 2
                xmlWriter.WriteStartElement("DeclarationReleveDeduction")

                ' Ajouter des données fixes spécifiques
                If cmbBoxSoc.SelectedItem IsNot Nothing Then
                    xmlWriter.WriteStartElement("identifiantFiscal")
                    xmlWriter.WriteString(cmbBoxSoc.SelectedItem.ToString())
                    xmlWriter.WriteEndElement()
                End If


                If Not String.IsNullOrEmpty(txtAn.Text) Then
                    xmlWriter.WriteStartElement("annee")
                    xmlWriter.WriteString(txtAn.Text)
                    xmlWriter.WriteEndElement()
                End If

                If cmbBoxPeriode.SelectedItem IsNot Nothing Then
                    xmlWriter.WriteStartElement("periode")
                    xmlWriter.WriteString(cmbBoxPeriode.SelectedItem.ToString())
                    xmlWriter.WriteEndElement()
                End If

                Dim regime As Integer = GetRegimeFromDatabase() 'valeur du régime depuis la base de données
                xmlWriter.WriteStartElement("regime")
                xmlWriter.WriteString(regime.ToString())
                xmlWriter.WriteEndElement()

                Dim dataTable As DataTable = DirectCast(DataGridView1.DataSource, DataTable)
                xmlWriter.WriteStartElement("releveDeductions")
                For Each row As DataRow In dataTable.Rows
                    xmlWriter.WriteStartElement("rd") 'Tag parent pour chaque ligne

                    ' Ajoute des tags spécifiques avant chaque colonne
                    xmlWriter.WriteStartElement("ord")
                    xmlWriter.WriteString(row("N* d'ordre de la facture").ToString())
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("num")
                    xmlWriter.WriteString(row("N° de facture").ToString())
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("des")
                    xmlWriter.WriteString(row("Désignation du bien ou service").ToString())
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("mht")
                    xmlWriter.WriteString(Convert.ToDecimal(row("Montant HT")).ToString("N2"))
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("tva")
                    xmlWriter.WriteString(Convert.ToDecimal(row("Montant de la tva")).ToString("N2"))
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("ttc")
                    xmlWriter.WriteString(Convert.ToDecimal(row("Montant ttc")).ToString("N2"))
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("reF")
                    xmlWriter.WriteStartElement("if")
                    xmlWriter.WriteString(row("I#F du fournisseur").ToString())
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("nom")
                    xmlWriter.WriteString(row("Nom ou Raison sociale du fournisseur").ToString())
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("ice")
                    xmlWriter.WriteString(row("ICE du fournisseur").ToString())
                    xmlWriter.WriteEndElement()
                    xmlWriter.WriteEndElement() 'Fin de reF

                    xmlWriter.WriteStartElement("tx")
                    xmlWriter.WriteString(Convert.ToDecimal(row("Taux de la TVA")).ToString("N2"))
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("prorata")
                    xmlWriter.WriteString(row("Prorata").ToString())
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("mp")
                    xmlWriter.WriteStartElement("id")
                    xmlWriter.WriteString(row("Mode de paiement").ToString())
                    xmlWriter.WriteEndElement()
                    xmlWriter.WriteEndElement() 'Fin de mp

                    xmlWriter.WriteStartElement("dpai")
                    ' xmlWriter.WriteString(row("Date paiement").ToString())
                    Dim datePaiement As Date
                    If Date.TryParse(row("Date paiement").ToString(), datePaiement) Then
                        xmlWriter.WriteString(datePaiement.ToString("yyyy-MM-dd"))
                    End If
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteStartElement("dfac")
                    'xmlWriter.WriteString(row("Date facture").ToString())
                    Dim dateFacture As Date
                    If Date.TryParse(row("Date facture").ToString(), dateFacture) Then
                        xmlWriter.WriteString(dateFacture.ToString("yyyy-MM-dd"))
                    End If
                    xmlWriter.WriteEndElement()

                    xmlWriter.WriteEndElement() 'Fin du tag rd
                Next
                xmlWriter.WriteEndElement() ' Ferme <releveDeductions>

                xmlWriter.WriteEndElement() ' Ferme <DeclarationReleveDeduction>
                xmlWriter.WriteEndDocument()
                xmlWriter.Close()
                MessageBox.Show("Fichier XML enregistré avec succès dans " & xmlFilePath, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Vérifiez vos données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function GetRegimeFromDatabase() As Integer
        Try
            Dim cmd As New SqlCommand("SELECT regime FROM Societe WHERE ifS = @rs ", con)
            cmd.Parameters.AddWithValue("@rs", cmbBoxSoc.SelectedValue)

            Dim regime As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return regime
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la récupération du régime depuis la base de données: " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        Finally
            con.Close()
        End Try
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        excelDataTable.Clear()
    End Sub
    Private Sub cmbBoxPeriode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxPeriode.SelectedIndexChanged
        Try
            Dim selectedRS As String = cmbBoxSoc.SelectedItem.ToString()

            Dim cmd = New SqlCommand("SELECT regime FROM Societe WHERE IfS = " & cmbBoxSoc.SelectedValue & "", con)
            ' Dim query As String = "SELECT regime FROM Societe WHERE IfS = @ifS"
            'Using cmdper As New SqlCommand(query, con)
            'cmdper.Parameters.AddWithValue("@ifS", selectedRS)
            ' Exécutez la commande SQL et obtenez le régime de la société
            Dim regime As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            MsgBox(regime)
            ' Effacer les éléments précédents du cmbBoxPeriode
            cmbBoxPeriode.Items.Clear()

            ' Ajouter les périodes en fonction du régime
            If regime = 1 Then
                cmbBoxPeriode.Items.AddRange({"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
            ElseIf regime = 2 Then
                cmbBoxPeriode.Items.AddRange({"1", "2", "3", "4"})
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ' Chemin du fichier Excel à télécharger
        Dim filePath As String = "C:\Users\DELL-I7\Downloads\Feuille___préparation.xlsx"

        ' Vérifier si le fichier existe
        If File.Exists(filePath) Then
            ' l'emplacement de téléchargement par défaut 
            Dim defaultDownloadPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim downloadFilePath As String = Path.Combine(defaultDownloadPath, "Feuille___préparation.xlsx")

            Try
                ' Copier le fichier vers l'emplacement de téléchargement par défaut
                File.Copy(filePath, downloadFilePath, True)
                MessageBox.Show("Téléchargement terminé. Le fichier a été enregistré sur votre bureau.")

                Process.Start(downloadFilePath)
            Catch ex As Exception
                MessageBox.Show("Une erreur s'est produite lors de la copie du fichier : " & ex.Message)
            End Try
        Else
            ' Afficher un message si le fichier n'existe pas
            MessageBox.Show("Le fichier spécifié est introuvable.")
        End If
    End Sub
End Class