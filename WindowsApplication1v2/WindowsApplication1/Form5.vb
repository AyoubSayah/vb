Imports Oracle.DataAccess.Client

Public Class Form5

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If verif4(nsall.Text) Then
            : ouvrircnx()
            Dim x As String = nsall.Text

            Dim query As String = "DELETE FROM salle where numsall like '" & x & "' "
            Dim cmd As New OracleCommand(query)
            cmd.Connection = getcnx()
            cmd.CommandType = CommandType.Text
            MessageBox.Show(x, "Supprimer avec succés")

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()

            Catch ex As OracleClient.OracleException
                Console.WriteLine(ex.Message)
            End Try
        Else : MessageBox.Show("Numéro salle inconnu")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class