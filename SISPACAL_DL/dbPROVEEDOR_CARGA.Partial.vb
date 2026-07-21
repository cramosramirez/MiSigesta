Partial Public Class dbPROVEEDOR_CARGA
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_CARGA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim agregar As Boolean = False
        strSQL.Append("SELECT * FROM PROVEEDOR_CARGA P ")
        strSQL.Append("WHERE ( ")
        strSQL.Append("     SELECT COUNT(1) ")
        strSQL.Append("     FROM ENVIO E, CARGADORA C ")
        strSQL.Append("     WHERE E.ID_CARGADORA = C.ID_CARGADORA ")
        strSQL.Append("     AND C.ID_PROVEEDOR_CARGA = P.ID_PROVEEDOR_CARGA ")
        strSQL.Append("     AND E.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append(" ) > 0 ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR_CARGA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_CARGA
                dbAsignarEntidades.AsignarPROVEEDOR_CARGA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
End Class
