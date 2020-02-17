Public Class Form13

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If verif4(sall.Text) Then
            Form14.Show()
            Me.Hide()

        Else

            MsgBox("verifier numero salle")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class