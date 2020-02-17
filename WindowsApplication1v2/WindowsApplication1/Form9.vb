Imports Oracle.DataAccess.Client

Public Class Form9
    Dim typee As String

    Private Property dt As DataTable

    Private Property d2 As OracleDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ouvrircnx()


        
        Dim query As String = "select nommat,nbh,coeff,type from matiere  "
        Dim cmd2 As New OracleCommand(query, cnx)
        Try


            dr = cmd2.ExecuteReader()
            d2 = cmd2.ExecuteReader()

            dt = New DataTable
            If d2.HasRows Then
                dt.Load(d2)
                DataGridView1.DataSource = dt

            End If

            While (dr.Read())

                If dr.Item("type") = 0 Then


                    typee = "Cours"
                Else : typee = "Traveaux Pratique"
                End If

                ListBox1.Items.Add("Nom matiere : " & dr.Item("nommat") & "  Nombre d'heure en semestre : " & dr.Item("nbh") & " Coefficient : " & dr.Item("coeff") & "  Type  : " & typee)
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells("NOMMAT").Value.ToString
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class