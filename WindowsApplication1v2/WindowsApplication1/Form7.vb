Imports Oracle.DataAccess.Client


Public Class Form7

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((user.Text = "") Or (mdp1.Text = "") Or (mdp2.Text = "")) Then
            MsgBox("veuiller remplir ")
        ElseIf (mdp1.Text <> mdp2.Text) Then
            MsgBox("Mot de passe non identique")
        ElseIf (mdp1.Text.Length < 8) Then
            MsgBox("mot de passe faible")

       


        ElseIf verif(user.Text) Then
            : ouvrircnx()
            Dim x As String = user.Text
            Dim y As String = mdp1.Text
            Dim query As String = "insert into utilisateur values('" & x & "','" & y & "')"
            Dim cmd As New OracleCommand(query)
            cmd.Connection = getcnx()
            cmd.CommandType = CommandType.Text
            MessageBox.Show(x, "ajouté avec succés")

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()

            Catch ex As OracleClient.OracleException
                Console.WriteLine(ex.Message)
            End Try
        Else : MessageBox.Show("deja ajouté")
        End If



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Form1.Show()
        Me.Hide()

    End Sub
End Class