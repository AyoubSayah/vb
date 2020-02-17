Imports Oracle.DataAccess.Client

Public Class Form3

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim m As Integer
        If tp.Checked Then
            i = 1
        Else : i = 0
        End If
        Dim h As Integer
        Dim ok As Boolean = True
        If ((nommat.Text = "") Or (coff.Text = "")) Then
            MsgBox("veuiller remplir ou verifier le coef ")
        Else
            If (Not (IsNumeric(coff.Text))) Then
                MsgBox("valeur non numerique")
            ElseIf ((coff.Text < 0) Or (coff.Text > 7)) Then
                MsgBox("verifier coef")
            Else
                If h1.Checked Then
                    h = 10.5
                    m = 1

                ElseIf h2.Checked Then
                    h = 21
                    m = 1

                ElseIf h3.Checked Then
                    h = 42
                    m = 2
                Else
                    MsgBox("check please")
                    ok = False

                End If
                If ok Then
                    If verif3(nommat.Text) Then

                        Dim x As String = nommat.Text
                        Dim y As String = coff.Text

                        Dim query As String = "insert into matiere values('" & x & "','" & h & "','" & y & "','" & i & "' )"
                        Dim cmd As New OracleCommand(query,cnx)


                        MessageBox.Show(x, "ajouté avec succés")

                        Try

                            cmd.ExecuteNonQuery()

                        Catch ex As OracleClient.OracleException
                            Console.WriteLine(ex.Message)
                        End Try
                       
                        query = "insert into matiere2 values('" & x & "','" & m & "' )"
                        Dim cmd2 As New OracleCommand(query)
                        cmd2.Connection = getcnx()
                        cmd2.CommandType = CommandType.Text


                        Try
                            cmd2.Connection.Open()
                            cmd2.ExecuteNonQuery()

                        Catch ex As OracleClient.OracleException
                            Console.WriteLine(ex.Message)
                        End Try
                    Else : MessageBox.Show("deja ajouté")
                        
                    End If
                End If


                'Else ajout base de donné 
            End If
        End If



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles h1.CheckedChanged

    End Sub

    Private Sub h2_CheckedChanged(sender As Object, e As EventArgs) Handles h2.CheckedChanged

    End Sub

    Private Sub nommat_TextChanged(sender As Object, e As EventArgs) Handles nommat.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class