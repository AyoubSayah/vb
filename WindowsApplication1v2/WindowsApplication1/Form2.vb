Imports Oracle.DataAccess.Client

Public Class Form2

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ouvrircnx()
        Dim ok As Integer
        If tp.Checked Then


            ok = 1
        Else : ok = 0
        End If
        Dim query As String = "insert into SAlle values(yo.NEXTVAL,'" & ok & "')"
        Dim cmd As New OracleCommand(query)
        cmd.Connection = getcnx()
        cmd.CommandType = CommandType.Text
        MessageBox.Show("ajouté avec succés")

        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            Dim cmd2 As New OracleCommand
            cmd2.Connection = getcnx()
            cmd2.CommandText = "select max(numsall) from salle "
            cmd2.CommandType = CommandType.Text

            Try
                cmd2.Connection.Open()

                Dim dr As OracleDataReader = cmd2.ExecuteReader()
                dr.Read()
                sa.Text = dr.Item(0)

            Catch ex As OracleClient.OracleException
                Console.WriteLine(ex.Message)
            End Try

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tp_CheckedChanged(sender As Object, e As EventArgs) Handles tp.CheckedChanged

    End Sub

    Private Sub sa_TextChanged(sender As Object, e As EventArgs) Handles sa.TextChanged

    End Sub
End Class