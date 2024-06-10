Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class DetailsCltForm
    ' Private DTPDNais DateTimePicker

    Dim con As SqlConnection
    Sub Connexion()
        Try
            con = New SqlConnection("initial catalog=dec_tva ; data source=DESKTOP-HDVAAHA\SQLEXPRESS ; integrated security=true")
            con.Open()
        Catch ex As Exception
            MsgBox("Erreur" + ex.Message)
        End Try
    End Sub
    Public Sub New(CIN As String, NomComplet As String, adresse As String, Tel As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajouter une initialisation quelconque après l'appel InitializeComponent().
        txtNC.Text = NomComplet
        txtCIN.Text = CIN
        txtAdr.Text = adresse
        txtTel.Text = Tel

        ' Charger des détails supplémentaires depuis la base de données
        LoadAdditionalDetails(CIN)
    End Sub
    Private Sub LoadAdditionalDetails(CIN As String)
        Try
            If con Is Nothing OrElse con.State = ConnectionState.Closed Then
                Connexion()
            End If

            Dim query As String = "SELECT email, dateNais FROM Client WHERE CIN = @cin"
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@cin", CIN)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Remplir les TextBoxes avec les valeurs de la base de données
                        txtEm.Text = reader("email").ToString()
                        DTPDNais.Value = reader("dateNais").ToString()
                    Else
                        MessageBox.Show("Aucune information supplémentaire trouvée pour cet client.", "Information manquante")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'accès à la base de données : " & ex.Message, "Erreur")
        End Try
    End Sub
    Private Sub DetailsCltForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()

    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Hide()
    End Sub

    Private Sub DTPDNais_ValueChanged(sender As Object, e As EventArgs) Handles DTPDNais.ValueChanged

    End Sub

    Private Sub DTPDNais_Validating(sender As Object, e As CancelEventArgs) Handles DTPDNais.Validating
        Dim selectedDate = DTPDNais.Value.Date
        Dim currentDate = DateTime.Now.Date

        If selectedDate > currentDate Then
            MsgBox("La date sélectionnée est supérieure à la date d'aujourd'hui.")
        End If
    End Sub
End Class