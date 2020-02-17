Imports Oracle.DataAccess.Client

Public Class Form14

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select numsall,type from salle  where numsall like '" & Form13.sall.Text & "' order by numsall  "
        cmd2.CommandType = CommandType.Text

        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            Dim typee As String
            While (dr.Read())
                If dr.Item("type") = 0 Then


                    typee = "salle normal"
                Else : typee = "salle travaux pratique"
                End If
                ListBox1.Items.Add("Numéro salle :" & dr.Item("numsall") & "   Type  : " & typee)
            End While
        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ok As Integer
        If ((tp.Checked) And (nrml.Checked)) Then
            MsgBox("Choisir une seule type")
            ok = 3
        ElseIf tp.Checked Then
            ok = 1
        ElseIf nrml.Checked Then
            ok = 0
        End If
        If ((ok = 1) Or (ok = 0)) Then
            Dim query As String = "update salle Set type = '" & ok & "' where numsall like '" & Form13.sall.Text & "'"
            Dim cmd As New OracleCommand(query)
            cmd.Connection = getcnx()
            cmd.CommandType = CommandType.Text
            MessageBox.Show(Form13.sall.Text, "Modifier avec succés")

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()

            Catch ex As OracleClient.OracleException
                Console.WriteLine(ex.Message)

            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form13.Show()
        Me.Hide()
    End Sub

    Private Sub tp_CheckedChanged(sender As Object, e As EventArgs) Handles tp.CheckedChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class