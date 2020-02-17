Public Class Form17

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((user1.Text = "") Or (mdp.Text = "")) Then
            MsgBox("Veuiller remplir ")

        Else
            ouvrircnx()
            If verifadmin(user1.Text, mdp.Text) Then
                MsgBox("Connexion avec succes")
                Form6.Show()
                Me.Hide()


            Else
                MsgBox("Nom et mot de passe introuvable")
                user1.Text = ""
                mdp.Text = ""

            End If

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ft.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ((user1.Text = "") Or (mdp.Text = "")) Then
            MsgBox("Veuiller remplir ")
        Else


            ouvrircnx()
            If verifadmin(user1.Text, mdp.Text) Then
                MsgBox("Connexion avec succes")
                Form18.Show()
                Me.Hide()


            Else
                MsgBox("Nom et mot de passe introuvable")
                user1.Text = ""
                mdp.Text = ""

            End If
        End If
    End Sub
End Class