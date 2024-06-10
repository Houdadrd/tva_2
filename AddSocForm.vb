Imports System.Data.SqlClient

Public Class AddSocForm
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ifs = txtIF.Text
        Dim rs = txtRS.Text
        Dim adr = txtAdr.Text
        Dim rgm As Integer = Convert.ToInt32(txtRgm.Text)
        Dim vl = txtV.Text
        Dim typeAc = txtAct.Text

        Dim cmd = New SqlCommand("INSERT INTO Societe (IfS, RaisonSocial, regime, adresse, ville, type_activitee) VALUES (@IfS, @RaisonSocial, @regime, @adresse, @ville, @type_activitee)", con)
        cmd.Parameters.AddWithValue("@IfS", ifs)
        cmd.Parameters.AddWithValue("@RaisonSocial", rs)
        cmd.Parameters.AddWithValue("@regime", rgm)
        cmd.Parameters.AddWithValue("@adresse", adr)
        cmd.Parameters.AddWithValue("@ville", vl)
        cmd.Parameters.AddWithValue("@type_activitee", typeAc)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Société insérer avec succés")
            SocForm.Show()
        Catch ex As SqlException
            MessageBox.Show("Une erreur SQL s'est produite : " & ex.Message)  ' More specific message
        End Try
    End Sub
    Private Sub AddSocForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
    End Sub
End Class