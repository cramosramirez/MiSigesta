Partial Public Class dbDOCUMENTO_ENTRADA_ENCA

    Public Function ObtenerPorInfoCOMPROBANTE(ByVal ID_PROVEE As Int32, ByVal ID_TIPO_COMPROB As Int32, ByVal FECHA_COMPROB As DateTime, ByVal NO_COMPROB As String) As DOCUMENTO_ENTRADA_ENCA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        strSQL.Append(" WHERE ID_PROVEE = @ID_PROVEE AND FECHA_COMPROB = @FECHA_COMPROB AND NO_COMPROB = @NO_COMPROB ")


        arg = New SqlParameter("@ID_PROVEE", SqlDbType.Int)
        arg.Value = ID_PROVEE
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_COMPROB", SqlDbType.Int)
        arg.Value = ID_TIPO_COMPROB
        args.Add(arg)

        arg = New SqlParameter("@NO_COMPROB", SqlDbType.VarChar)
        arg.Value = NO_COMPROB
        args.Add(arg)

        arg = New SqlParameter("@FECHA_COMPROB", SqlDbType.DateTime)
        arg.Value = FECHA_COMPROB
        args.Add(arg)


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA

        Try
            If dr.Read Then
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
            Else
                mEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad
    End Function

    Public Function ObtenerNoDocumentoPorBodega() As Int32
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NO_DOCUMENTO),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM DOCUMENTO_ENTRADA_ENCA")

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

    Public Function ObtenerCantidadDevueltaProductoDoctoSalida(ByVal ID_DOCSAL_ENCA As Int32, ByVal ID_PRODUCTO As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Decimal

        strSQL.Append("SELECT ISNULL(SUM(D.CANTIDAD),0) AS CANTIDAD_DEVUELTA ")
        strSQL.Append("FROM DOCUMENTO_ENTRADA_ENCA E, DOCUMENTO_ENTRADA_DETA D ")
        strSQL.Append("WHERE E.ID_DOCENTRA_ENCA = D.ID_DOCENTRA_ENCA AND E.ID_DOCSAL_ENCA = @ID_DOCSAL_ENCA AND D.ID_PRODUCTO = @ID_PRODUCTO ")

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
