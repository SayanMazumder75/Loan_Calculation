Imports System.Data.SqlClient

Public Class dbConnection

    Dim con As New SqlConnection()

    Public Function conn()
        con = New SqlConnection("Data Source=SAYAN\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=TRUE;User Id=SAYAN\sayan; Password=;")
        con.Open()
    End Function


    Public Function InsertData(ByVal sayan As String)
        conn()
        Dim cmd As SqlCommand = New SqlCommand(sayan, con)
        cmd.ExecuteNonQuery()

    End Function


    Public Function viewData(sayan As String) As DataSet

        conn()
        Dim data As DataSet = New DataSet()
        Dim cmd As SqlCommand = New SqlCommand(sayan, con)
        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter(cmd)
        dataAdapter.Fill(data)
        Return data

    End Function

End Class
