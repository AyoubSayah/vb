Public Class Form11


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If verif3(nommat.Text) Then
            MsgBox("verifier le nom matiere")
        Else
            Form12.Show()
            Me.Hide()

        End If

    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub nommat_TextChanged(sender As Object, e As EventArgs) Handles nommat.TextChanged

    End Sub
End Class