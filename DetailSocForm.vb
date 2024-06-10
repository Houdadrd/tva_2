﻿Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DetailSocForm
    Dim con As SqlConnection
    Sub Connexion()
        Try
            con = New SqlConnection("initial catalog=dec_tva ; data source=DESKTOP-HDVAAHA\SQLEXPRESS ; integrated security=true")
            con.Open()
        Catch ex As Exception
            MsgBox("Erreur" + ex.Message)
        End Try
    End Sub
    Public Sub New(identifiantFiscal As String, raisonSociale As String, adresse As String, ville As String, typeActivitee As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajouter une initialisation quelconque après l'appel InitializeComponent().
        txtIF.Text = identifiantFiscal
        txtRS.Text = raisonSociale
        txtAdr.Text = adresse
        txtV.Text = ville
        txtAct.Text = typeActivitee

        ' Charger des détails supplémentaires depuis la base de données
        LoadAdditionalDetails(identifiantFiscal)
    End Sub
    Private Sub DetailSocForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
    End Sub
    Private Sub LoadAdditionalDetails(identifiantFiscal As String)
        Try
            If con Is Nothing OrElse con.State = ConnectionState.Closed Then
                Connexion()
            End If

            Dim query As String = "SELECT periode, regime, telephone FROM Societe WHERE IfS = @ifs"
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@ifs", identifiantFiscal)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Remplir les TextBoxes avec les valeurs de la base de données
                        txtRgm.Text = reader("regime").ToString()
                        txtPrd.Text = reader("periode").ToString()
                        txtTel.Text = reader("telephone").ToString()
                    Else
                        MessageBox.Show("Aucune information supplémentaire trouvée pour cette société.", "Information manquante")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'accès à la base de données : " & ex.Message, "Erreur")
        End Try
    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Hide()
    End Sub
End Class