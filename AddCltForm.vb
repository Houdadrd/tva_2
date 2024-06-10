Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm

Public Class AddCltForm
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
    Private Sub AddCltForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nc = txtNC.Text
        Dim adr = txtAdr.Text
        Dim cin = txtCIN.Text
        Dim tel = txtTel.Text
        Dim em = txtEm.Text
        Dim dNais = DTPDNais.Value

        Dim cmd = New SqlCommand("INSERT INTO client (CIN, NomComplet, Adresse, Tel, email, dateNais) VALUES (@cin, @nc, @adresse, @tel, @em, @dNais)", con)
        cmd.Parameters.AddWithValue("@nc", nc)
        cmd.Parameters.AddWithValue("@cin", cin)
        cmd.Parameters.AddWithValue("@tel", tel)
        cmd.Parameters.AddWithValue("@adresse", adr)
        cmd.Parameters.AddWithValue("@em", em)
        cmd.Parameters.AddWithValue("@dNais", dNais)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Client insérer avec succés")
            ClientForm.Show()
        Catch ex As SqlException
            MessageBox.Show("Une erreur SQL s'est produite : " & ex.Message)  ' More specific message
        End Try
    End Sub
End Class