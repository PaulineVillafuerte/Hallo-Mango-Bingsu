Imports MySql.Data.MySqlClient

Module Module1
    Public myadocon, conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdread As MySqlDataReader
    Public db_server = "'localhost'" 'Server Name
    Public db_uid = "'root'" 'User ID
    Public db_pwd = "''" 'Password
    Public db_name = "'hallomangodb'" 'Database Name
    Public strconn As String = "server =" & db_server & ";uid =" & db_uid & ";password =" & db_pwd & ";database =" & db_name & ""

    Public Sub readquery(ByVal sql As String)
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdread = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module