Imports System.Data.OleDb
Module Module1
    Public con As New oledbconnection("provider=msdaora;user id=sis;password=sis")

    Sub main()

        Try
            con.Open()
            Dim f As New Form1()
            f.ShowDialog()
        Catch Ex As Exception
            MsgBox("Error: " & Ex.Message)
        End Try
    End Sub

    Public Function GetNextRcptNo() As Integer
        Dim cmd As New OleDbCommand("select  nvl(max(rcptno),0) + 1 from payments", con)
        Return cmd.ExecuteScalar()

    End Function

End Module
