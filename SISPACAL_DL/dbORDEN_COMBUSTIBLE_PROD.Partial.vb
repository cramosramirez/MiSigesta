Partial Public Class dbORDEN_COMBUSTIBLE_PROD
    Public Function EliminarPorORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Integer) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append("DELETE FROM ORDEN_COMBUSTIBLE_PROD WHERE ID_ORDEN_COMBUS = @ID_ORDEN_COMBUS")
        args(0) = New SqlParameter("@ID_ORDEN_COMBUS", SqlDbType.Int)
        args(0).Value = ID_ORDEN_COMBUS

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
End Class
