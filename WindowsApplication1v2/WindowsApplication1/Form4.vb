Imports Oracle.DataAccess.Client

Public Class Form4

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not (verif3(nommat.Text)) Then
            ouvrircnx()
            Dim x As String = nommat.Text

            Dim query As String = "DELETE FROM matiere where nommat like '" & x & "' "
            Dim cmd As New OracleCommand(query, cnx)


            MessageBox.Show(x, "Supprimé avec succes")

            Try

                cmd.ExecuteNonQuery()

            Catch ex As OracleClient.OracleException
                Console.WriteLine(ex.Message)
            End Try
        Else : MessageBox.Show("Nom matiere inconnue")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles nommat.TextChanged
        If nommat.Text = "" Then MsgBox("veuillez remplir")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class