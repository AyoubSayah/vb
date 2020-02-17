








Public Class Form1
    Public verifiadmoruser As Integer


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((user1.Text = "") Or (mdp.Text = "")) Then
            MsgBox("Veuiller remplir ")


        Else

            Timer2.Enabled = True







            If (ProgressBar1.Maximum) Then
                ouvrircnx()
                If verif2(user1.Text, mdp.Text) Then
                    MsgBox("Connexion avec succes")
                    verifiadmoruser = 1
                    menu2.Show()
                    Me.Hide()
                Else
                    MsgBox("Nom et mot de passe introuvable")
                    user1.Text = ""
                    mdp.Text = ""
                    ProgressBar1.Value = ProgressBar1.Minimum
                End If


            End If
        End If



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles user1.TextChanged


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Value = ProgressBar1.Minimum
        Form7.Show()

        Me.Hide()
    End Sub


    Private Sub ProgressBar1_Click_1(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer2.Enabled = False
        Else
            ProgressBar1.Value = ProgressBar1.Value + 20
        End If
    End Sub


    Private Sub Labelbl24_Click(sender As Object, e As EventArgs) Handles Labelbl24.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ft.Show()
        Me.Hide()
    End Sub
End Class
