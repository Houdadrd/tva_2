Imports System.Data.SqlClient

Public Class InscriForm
    Dim con As SqlConnection
    Sub Connexion()
        Try
            con = New SqlConnection("initial catalog=dec_tva ; data source=DESKTOP-HDVAAHA\SQLEXPRESS ; integrated security=true")
            con.Open()
        Catch ex As Exception
            MsgBox("Erreur" + ex.Message)
        End Try
    End Sub

    Sub CmbBox()
        Dim cmd = New SqlCommand("select idUser,roles from Utilisateur", con)
        Dim dr = cmd.ExecuteReader()
        Dim T As New DataTable
        T.Load(dr)
        CmbStatus.ValueMember = "idUser"
        CmbStatus.DisplayMember = "roles"
        CmbStatus.DataSource = T
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtmotPasse.Text
        Dim roles As String = CmbStatus.Text

        Dim cmd = New SqlCommand("insert into utilisateur (nomUtilisateur, motDePasse, roles) values(@Username, @Password,@Role)", con)
        cmd.Parameters.AddWithValue("@Username", username)
        cmd.Parameters.AddWithValue("@Password", password)
        cmd.Parameters.AddWithValue("@Role", roles)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Utilisateur enregistré avec succé")
            MenuAdminForm.Show()
        Catch ex As Exception
            MsgBox("erreur" + ex.Message)
        End Try
    End Sub

    Private Sub InscriForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
        CmbBox()
    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
        MenuAdminForm.Show()
    End Sub
End Class