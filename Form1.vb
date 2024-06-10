Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Sub Connexion()
        Try
            con = New SqlConnection("initial catalog=dec_tva ; data source=DESKTOP-HDVAAHA\SQLEXPRESS ; integrated security=true")
            con.Open()
        Catch ex As Exception
            MsgBox("Erreur" + ex.Message)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Connexion()

        Dim username As String = txtUsername.Text
        Dim password As String = txtmotPasse.Text

        SeLoger(username, password)
    End Sub
    Function SeLoger(Username As String, Password As String) As Boolean
        Dim cmd As New SqlCommand("SELECT roles FROM utilisateur WHERE nomUtilisateur = @Username AND motDePasse = @Password", con)

        cmd.Parameters.AddWithValue("@Username", Username)
        cmd.Parameters.AddWithValue("@Password", Password)

        Dim resultat As SqlDataReader = cmd.ExecuteReader()

        If resultat.Read() Then
            Dim role As String = resultat(0) ' Récupérer la valeur du champ <role>

            Select Case role.ToLower()
                Case "administrateur"
                    MenuAdminForm.Show()
                    Me.Hide()
                    Return True
                Case "UtilisateurStandard"
                    '  MenuForm.Show()
                    MsgBox("Connexion réussie en tant qu'utilisateur standard")
                    Return True
                Case "lecteur"
                    MsgBox("Connexion réussie en tant que lecteur")
                    Return True
                Case Else
                    MsgBox("Rôle inconnu : " & role)
                    Return False
            End Select
        Else
            MsgBox("Nom d'utilisateur ou mot de passe incorrect.")
            Return False
        End If

        Return False
    End Function

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Hide()
    End Sub
End Class
