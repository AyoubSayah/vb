Imports Oracle.DataAccess.Client

Public Class Form12
    Public val As String = Form11.nommat.Text


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd2 As New OracleCommand
        Dim typee As String
       
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select nommat,nbh,coeff,type from matiere where nommat like '" & val & "' "
        cmd2.CommandType = CommandType.Text

        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()

            While (dr.Read())
                If dr.Item("type") = 0 Then


                    typee = " Cours"
                Else : typee = " Travaux pratique"
                End If


                ListBox1.Items.Add("Nom matiere : " & dr.Item("nommat") & " Nombre d'heure en semestre : " & dr.Item("nbh") & " Coefficient : " & dr.Item("coeff") & "  Type :  " & typee)
            End While
        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim h As Double = 0
        Dim ok As Integer = 3
        If ((tp.Checked) And (nrml.Checked)) Then
            MsgBox("choisir une seule type")
            ok = 3
        ElseIf tp.Checked Then
            ok = 1
        ElseIf nrml.Checked Then
            ok = 0
        End If

        If h1.Checked Then
            h = 10.5
        ElseIf h2.Checked Then
            h = 21
        ElseIf h3.Checked Then
            h = 42
        End If
        If (Not (h = 0) And (Not (coff.Text = "")) And (ok <> 3)) Then
            If ((coff.Text <= 0) Or (coff.Text > 7)) Then
                MsgBox("verifier coef")
            Else
                Dim query As String = "update matiere Set nbh = '" & h & "',coeff = '" & coff.Text & "',type= '" & ok & "'  where nommat like '" & val & "' "
                Dim cmd As New OracleCommand(query, cnx)


                MessageBox.Show(val, "Modifier avec succés")

                Try

                    cmd.ExecuteNonQuery()

                Catch ex As OracleClient.OracleException
                    Console.WriteLine(ex.Message)

                End Try
            End If
        ElseIf ((Not (h = 0)) And (Not (coff.Text = ""))) Then
            If ((coff.Text <= 0) Or (coff.Text > 7)) Then
                MsgBox("Verifier coeficient")
            Else
                Dim query As String = "update matiere Set nbh = '" & h & "',coeff = '" & coff.Text & "'  where nommat like '" & val & "' "
                Dim cmd As New OracleCommand(query)
                cmd.Connection = getcnx()
                cmd.CommandType = CommandType.Text
                MessageBox.Show(val, "modifier avec succés")

                Try
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()

                Catch ex As OracleClient.OracleException
                    Console.WriteLine(ex.Message)

                End Try
            End If
        ElseIf (Not (coff.Text = "")) And (ok <> 3) Then
            If ((coff.Text <= 0) Or (coff.Text > 7)) Then
                MsgBox("verifier coef")
            Else
                Dim query As String = "update matiere Set coeff = '" & coff.Text & "',type= '" & ok & "'  where nommat like '" & val & "' "
                Dim cmd As New OracleCommand(query)
                cmd.Connection = getcnx()
                cmd.CommandType = CommandType.Text
                MessageBox.Show(val, "modifier avec succés")

                Try
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()

                Catch ex As OracleClient.OracleException
                    Console.WriteLine(ex.Message)

                End Try
            End If
        ElseIf (Not (h = 0) And (ok <> 3)) Then


            Dim query As String = "update matiere Set nbh = '" & h & "',type= '" & ok & "'  where nommat like '" & val & "' "
            Dim cmd As New OracleCommand(query)
            cmd.Connection = getcnx()
            cmd.CommandType = CommandType.Text
            MessageBox.Show(val, "modifier avec succés")

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()

            Catch ex As OracleClient.OracleException
                Console.WriteLine(ex.Message)

            End Try

        ElseIf Not (h = 0) Then
            Dim query As String = "update matiere Set nbh = '" & h & "' where nommat like '" & val & "'"
            Dim cmd As New OracleCommand(query)
            cmd.Connection = getcnx()
            cmd.CommandType = CommandType.Text
            MessageBox.Show(val, " nombre de heure emodifier avec succés")

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()

            Catch ex As OracleClient.OracleException
                Console.WriteLine(ex.Message)

            End Try
        ElseIf (Not (coff.Text = "")) Then
            If ((coff.Text <= 0) Or (coff.Text > 7)) Then
                MsgBox("verifier coef")
            Else
                Dim query As String = "update matiere Set coeff = '" & coff.Text & "' where nommat like '" & val & "'"
                Dim cmd As New OracleCommand(query)
                cmd.Connection = getcnx()
                cmd.CommandType = CommandType.Text
                MessageBox.Show(val, " coeff modifier avec succés")

                Try
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()

                Catch ex As OracleClient.OracleException
                    Console.WriteLine(ex.Message)

                End Try

        End If
        ElseIf (ok <> 3) Then
        Dim query As String = "update matiere Set type = '" & ok & "' where nommat like '" & val & "'"
        Dim cmd As New OracleCommand(query)
        cmd.Connection = getcnx()
        cmd.CommandType = CommandType.Text
        MessageBox.Show(val, " nombre de heure emodifier avec succés")

        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)

        End Try

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub h3_CheckedChanged(sender As Object, e As EventArgs) Handles h3.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub tp_CheckedChanged(sender As Object, e As EventArgs) Handles tp.CheckedChanged

    End Sub

    Private Sub nrml_CheckedChanged(sender As Object, e As EventArgs) Handles nrml.CheckedChanged

    End Sub

    Private Sub h2_CheckedChanged(sender As Object, e As EventArgs) Handles h2.CheckedChanged

    End Sub
End Class