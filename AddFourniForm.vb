Imports System.Data.SqlClient

Public Class AddFourniForm
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
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        Dim nc = txtNC.Text
        Dim adr = txtAdr.Text
        Dim ifF = txtIF.Text
        Dim ice = txtICE.Text
        Dim tel = txtTel.Text
        Dim em = txtEm.Text

        ' Use parameterized query to prevent SQL injection
        Dim cmd = New SqlCommand("INSERT INTO Fournisseur (IFFourni, nom, ICE,adresse, tel, email) VALUES (@if,@nc,@ice, @adr, @tel, @em)", con)
        cmd.Parameters.AddWithValue("@nc", nc)
        cmd.Parameters.AddWithValue("@if", ifF)
        cmd.Parameters.AddWithValue("@ice", ice)
        cmd.Parameters.AddWithValue("@tel", tel)
        cmd.Parameters.AddWithValue("@adr", adr)
        cmd.Parameters.AddWithValue("@em", em)

        Try
            cmd.ExecuteNonQuery()
            FourniForm.Show()

        Catch ex As SqlException
            MessageBox.Show("Une erreur SQL s'est produite : " & ex.Message)  ' More specific message
        End Try
    End Sub

    Private Sub AddFourniForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()

    End Sub
End Class