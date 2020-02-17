Public Class menu2

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form10.Show()
        Me.Hide()
       
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()
        Form1.ProgressBar1.Value = Form1.ProgressBar1.Minimum
        Form1.user1.Text = ""
        Form1.mdp.Text = ""
        Form1.verifiadmoruser = 0

    End Sub
End Class