Partial Public Class dbDOCUMENTO_SALIDA_ENCA

    Public Function ObtenerCantidadProductoDoctoSalida(ByVal ID_DOCSAL_ENCA As Int32, ByVal ID_PRODUCTO As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Decimal

        strSQL.Append("SELECT ISNULL(SUM(D.CANTIDAD),0) AS CANTIDAD_DEVUELTA ")
        strSQL.Append("FROM DOCUMENTO_SALIDA_ENCA E, DOCUMENTO_SALIDA_DETA D ")
        strSQL.Append("WHERE E.ID_DOCSAL_ENCA = D.ID_DOCSAL_ENCA AND E.ID_DOCSAL_ENCA = @ID_DOCSAL_ENCA AND D.ID_PRODUCTO = @ID_PRODUCTO ")

        arg = New SqlParameter("@ID_DOCSAL_ENCA", SqlDbType.Int)
        arg.Value = ID_DOCSAL_ENCA
        args.Add(arg)

        arg = New SqlParameter("@ID_PRODUCTO", SqlDbType.Int)
        arg.Value = ID_PRODUCTO
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

End Class
