Imports Oracle.DataAccess.Client

Public Class Form8

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ouvrircnx()
        Dim i As Integer = 0
        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select numsall,type from salle order by numsall "
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Form1.verifiadmoruser = 1 Then
            menu2.Show()
            Me.Hide()
        Else : Form6.Show()
            Me.Hide()
        End If
        ListBox1.Items.Clear()



    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class