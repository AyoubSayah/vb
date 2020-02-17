Imports Oracle.DataAccess.Client

Public Class Form15

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "select nommat from matiere2 where dispo =1 or dispo=2 "
        Dim cmd2 As New OracleCommand(query, cnx)




        Try


            Dim dr As OracleDataReader = cmd2.ExecuteReader()

            While (dr.Read())


                ComboBox1.Items.Add(dr.Item("nommat"))



            End While
        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form16.Show()
        Me.Hide()



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Close()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class