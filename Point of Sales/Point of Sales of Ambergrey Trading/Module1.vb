Imports MySql.Data.MySqlClient


Module Module1

    Public conn As New MySqlConnection
    Public com As New MySqlCommand
    Public adapter As New MySqlDataAdapter


    Sub openConn()
        conn.ConnectionString = "server=localhost; username=root; password=; database=ambergrey_trading; Convert Zero Datetime=True"
        conn.Open()
    End Sub

End Module
