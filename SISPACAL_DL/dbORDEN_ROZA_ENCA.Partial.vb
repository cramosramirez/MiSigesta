Partial Public Class dbORDEN_ROZA_ENCA

    Public Function ObtenerProximoID_GENERACION() As Object
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT isnull(max(ID_GENERACION),0) + 1 ")
        strSQL.AppendLine(" FROM ORDEN_ROZA_ENCA ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    Public Function ObtenerProximoCORRELATIVO() As Object
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT isnull(max(CORRELATIVO),0) + 1 ")
        strSQL.AppendLine(" FROM ORDEN_ROZA_ENCA ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function
End Class
