Imports Oracle.DataAccess.Client

Module Module1
    Public cnx As oracleConnection 'type connection
    Public cmd As OracleCommand
    Public dr As OracleDataReader
    Public ex As Exception
    Public rsql As String

    Public Sub ouvrircnx()
        cnx = New OracleConnection("data source =(DESCRIPTION =  (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-I0LT5S9)(PORT = 1521)) (CONNECT_DATA = (service_name= xe)));user id =fifa2020;password=fifa2020;") 'chaine de connection connection string 
        If cnx.State = ConnectionState.Closed Then 'etat de connection
            cnx.Open()


        Else
            MessageBox.Show("erreur de execution" & ex.Message)

        End If

    End Sub
    Public Function getcnx()
        cnx = New OracleConnection("data source =(DESCRIPTION =  (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-I0LT5S9)(PORT = 1521)) (CONNECT_DATA = (service_name= xe)));user id =fifa2020;password=fifa2020;")
        Return cnx
    End Function
    Public Sub fermercnx()
        If cnx.State = ConnectionState.Open Then
            dr.Dispose() 'fermer
            dr.Close()
            cmd.Dispose()
            cnx.Close()
        End If
    End Sub
    Public Function verif(x As String)


        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select nom from utilisateur where nom like '" & x & "'"
        cmd2.CommandType = CommandType.Text

        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            If dr.Read() Then Return False Else Return True

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try





    End Function
    Public Function verif2(x As String, y As String)


        Dim cmd3 As New OracleCommand
        cmd3.Connection = getcnx()
        cmd3.CommandText = "select * from utilisateur where (nom like '" & x & "')and(mdp like '" & y & "')"
        cmd3.CommandType = CommandType.Text

        Try
            cmd3.Connection.Open()

            Dim dr As OracleDataReader = cmd3.ExecuteReader()
            If dr.Read() Then Return True Else Return False

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Function


    Public Function verif3(x As String)

        Dim query As String = "select nommat from matiere where nommat like '" & x & "'"
        Dim cmd2 As New OracleCommand(query,cnx)
        
        Try


            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            If dr.Read() Then Return False Else Return True

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Function
    Public Function verif4(x As String)


        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select numsall from salle  where numsall like '" & x & "'"
        cmd2.CommandType = CommandType.Text

        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            If dr.Read() Then Return True Else Return False

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Function
    Public Function verif4(x As String, jou As String, numse As Integer, numsal As Integer)


        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select numsall,numseance,jour from seance where  numsall like '" & numsal & "' and numseance like '" & numse & "' and jour like '" & jou & "' "
        cmd2.CommandType = CommandType.Text

        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            If dr.Read() Then Return False Else Return True

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try





    End Function
    Public Function verifadmin(x As String, y As String)




        Dim query As String = "select * from ADMINISTRATEUR where ( admin like '" & x & "')and(mdp like '" & y & "')"
        Dim cmd3 As New OracleCommand (query,cnx)

        Try


            Dim dr As OracleDataReader = cmd3.ExecuteReader()
            If dr.Read() Then Return True Else Return False

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try
    End Function
    Public Function verifadmin2(x As String)


        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select admin from ADMINISTRATEUR where admin like '" & x & "'"
        cmd2.CommandType = CommandType.Text

        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            If dr.Read() Then Return False Else Return True

        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try





    End Function
    Public Function verifjou(x As String, jou As String, numse As Integer, numsal As Integer)


        Dim cmd2 As New OracleCommand
        cmd2.Connection = getcnx()
        cmd2.CommandText = "select numsall,numseance,jour from seance where   numseance like '" & numse & "' and jour like '" & jou & "' "
        cmd2.CommandType = CommandType.Text

        Try
            cmd2.Connection.Open()

            Dim dr As OracleDataReader = cmd2.ExecuteReader()
            If dr.Read() Then


                Return False

            Else : Return True
            End If
        Catch ex As OracleClient.OracleException
            Console.WriteLine(ex.Message)
        End Try

    End Function
End Module
