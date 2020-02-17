Imports Oracle.DataAccess.Client

Public Class Form16
    Dim vale As Integer
    Dim dispoo As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim cmd2 As New OracleCommand
        
    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select type from matiere where nommat like '" & Form15.ComboBox1.SelectedItem & "'  "
        cmd2.CommandType = CommandType.Text


        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            dr.Read()

            vale = dr.Item("type")




        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try

        cmd2.Connection = getcnx()
        cmd2.CommandText = "select numsall from salle where type like '" & vale & "'  "
        cmd2.CommandType = CommandType.Text


        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            While (dr.Read())
                numsall.Items.Add(dr.Item("numsall"))
            End While

            cmd2.Connection = getcnx()
            cmd2.CommandText = "select * from PROF  "
            cmd2.CommandType = CommandType.Text

            Try
                cmd2.Connection.Open()

                Dim dr2 As OracleDataReader = cmd2.ExecuteReader()

                While (dr2.Read())


                    ComboBox1.Items.Add(dr2.Item("nomprof"))



                End While
            Catch ex As OracleClient.OracleException
                Console.WriteLine(ex.Message)
            End Try


        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numsall.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd3 As New OracleCommand
        
        cmd3.Connection = getcnx()
        cmd3.CommandText = "select dispo from matiere2 where nommat like '" & Form15.ComboBox1.SelectedItem & "' "
        cmd3.CommandType = CommandType.Text

        Try
            cmd3.Connection.Open()

            Dim dr As OracleDataReader = cmd3.ExecuteReader()

            dr.Read()
            dispoo = dr.Item("dispo")


            




        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
        If dispoo <> 0 Then

            If verif4(Form15.ComboBox1.SelectedItem, jou.SelectedItem, numse.SelectedItem, numsall.SelectedItem) Then
                If verifjou(Form15.ComboBox1.SelectedItem, jou.SelectedItem, numse.SelectedItem, numsall.SelectedItem) Then
                    Dim query As String = "insert into seance values('" & Form15.ComboBox1.SelectedItem & "','" & numsall.SelectedItem & "','" & numse.SelectedItem & "','" & jou.SelectedItem & "','" & ComboBox1.SelectedItem & "' )"
                    Dim cmd As New OracleCommand(query)
                    cmd.Connection = getcnx()
                    cmd.CommandType = CommandType.Text
                    MessageBox.Show(Form15.ComboBox1.SelectedItem, "affecté avec succés")

                    Try
                        cmd.Connection.Open()
                        cmd.ExecuteNonQuery()

                    Catch ex As OracleClient.OracleException
                        Console.WriteLine(ex.Message)
                    End Try
                    dispoo = dispoo - 1
                    query = "update matiere2 Set dispo = '" & dispoo & "' where nommat like '" & Form15.ComboBox1.SelectedItem & "' "
                    Dim cmd2 As New OracleCommand(query)
                    cmd2.Connection = getcnx()
                    cmd2.CommandType = CommandType.Text


                    Try
                        cmd2.Connection.Open()
                        cmd2.ExecuteNonQuery()

                    Catch ex As OracleClient.OracleException
                        Console.WriteLine(ex.Message)

                    End Try
                Else : MessageBox.Show("Groupe etudie a cette séance et jour")
                End If
            Else : MessageBox.Show(numsall.SelectedItem, "Salle chargé")


            End If
        Else : MessageBox.Show(Form15.ComboBox1.SelectedItem, "Matiere deja affecté")

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form15.Close()
        Form15.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub numse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numse.SelectedIndexChanged

    End Sub
End Class