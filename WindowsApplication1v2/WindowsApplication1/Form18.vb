Imports Oracle.DataAccess.Client

Public Class Form18

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form17.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((user.Text = "") Or (mdp1.Text = "") Or (mdp2.Text = "")) Then
            MsgBox("veuiller remplir ")
        ElseIf (mdp1.Text <> mdp2.Text) Then
            MsgBox("Mot de passe non identique")
        ElseIf (mdp1.Text.Length < 8) Then
            MsgBox("mot de passe faible")




        ElseIf verifadmin2(user.Text) Then
            : ouvrircnx()
            Dim x As String = user.Text
            Dim y As String = mdp1.Text
            Dim query As String = "insert into ADMINISTRATEUR values('" & x & "','" & y & "')"
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
End Class