Imports Oracle.DataAccess.Client

Public Class Form10

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select * from seance "
        cmd2.CommandType = CommandType.Text

        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            While (dr.Read())
                If dr.Item("jour") = "LUNDI" Then
                    If dr.Item("numseance") = 1 Then
                        Label31.BackColor = Color.Red
                        Label31.Text = "  " & dr.Item("nommat") & vbCrLf & "   " & "Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 2 Then
                        Label2.BackColor = Color.Red
                        Label2.Text = "  " & dr.Item("nommat") & vbCrLf & "   " & "Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 3 Then
                        Label3.BackColor = Color.Red
                        Label3.Text = "  " & dr.Item("nommat") & vbCrLf & "   " & "Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 4 Then
                        Label4.BackColor = Color.Red
                        Label4.Text = "  " & dr.Item("nommat") & vbCrLf & "   " & "Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 5 Then
                        Label5.BackColor = Color.Red
                        Label5.Text = "  " & dr.Item("nommat") & vbCrLf & "   " & "Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 6 Then
                        Label6.BackColor = Color.Red
                        Label6.Text = "  " & dr.Item("nommat") & vbCrLf & "   " & "Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    End If
                ElseIf dr.Item("jour") = "MARDI" Then
                    If dr.Item("numseance") = 1 Then
                        Label7.BackColor = Color.Red
                        Label7.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 2 Then
                        Label8.BackColor = Color.Red
                        Label8.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 3 Then
                        Label9.BackColor = Color.Red
                        Label9.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 4 Then
                        Label10.BackColor = Color.Red
                        Label10.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 5 Then
                        Label11.BackColor = Color.Red
                        Label11.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 6 Then
                        Label12.BackColor = Color.Red
                        Label12.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    End If
                ElseIf dr.Item("jour") = "MERCREDI" Then
                    If dr.Item("numseance") = 1 Then
                        Label13.BackColor = Color.Red
                        Label13.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 2 Then
                        Label14.BackColor = Color.Red
                        Label14.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 3 Then
                        Label15.BackColor = Color.Red
                        Label15.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 4 Then
                        Label16.BackColor = Color.Red
                        Label16.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 5 Then
                        Label17.BackColor = Color.Red
                        Label17.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 6 Then
                        Label18.BackColor = Color.Red
                        Label18.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    End If
                ElseIf dr.Item("jour") = "JEUDI" Then
                    If dr.Item("numseance") = 1 Then
                        Label19.BackColor = Color.Red
                        Label19.Text = "  " & dr.Item("nommat") & vbCrLf & "  Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 2 Then
                        Label20.BackColor = Color.Red
                        Label20.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 3 Then
                        Label21.BackColor = Color.Red
                        Label21.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 4 Then
                        Label22.BackColor = Color.Red
                        Label22.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 5 Then
                        Label23.BackColor = Color.Red
                        Label23.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 6 Then
                        Label24.BackColor = Color.Red
                        Label24.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    End If
                ElseIf dr.Item("jour") = "VENDREDI" Then
                    If dr.Item("numseance") = 1 Then
                        Label25.BackColor = Color.Red
                        Label25.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 2 Then
                        Label26.BackColor = Color.Red
                        Label26.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 3 Then
                        Label27.BackColor = Color.Red
                        Label27.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 4 Then
                        Label28.BackColor = Color.Red
                        Label28.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 5 Then
                        Label29.BackColor = Color.Red
                        Label29.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    ElseIf dr.Item("numseance") = 6 Then
                        Label30.BackColor = Color.Red
                        Label30.Text = "  " & dr.Item("nommat") & vbCrLf & "   Numsall " & dr.Item("numsall") & vbCrLf & "  " & (dr.Item("Nomprof"))
                    End If

                End If



            End While





        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Form1.verifiadmoruser = 1 Then
            menu2.Show()
            Me.Hide()
        Else : Form6.Show()
            Me.Hide()
        End If
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub
End Class