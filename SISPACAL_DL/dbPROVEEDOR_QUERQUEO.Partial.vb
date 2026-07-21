Partial Public Class dbPROVEEDOR_QUERQUEO


    Public Function ObtenerListaPorCODISIS(ByVal CODISIS As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_QUERQUEO

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM PROVEEDOR_QUERQUEO ")
        strSQL.Append("WHERE CODISIS = @CODISIS ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODISIS", SqlDbType.VarChar)
        args(0).Value = CODISIS.Trim.ToUpper

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROVEEDOR_QUERQUEO

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_QUERQUEO
                dbAsignarEntidades.AsignarPROVEEDOR_QUERQUEO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorREPORTE_QUERQUEO_INJIBOA_RELA(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CATORCENA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_QUERQUEO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim agregar As Boolean = False
        strSQL.Append("SELECT * FROM PROVEEDOR_QUERQUEO P ")
        strSQL.Append("WHERE ( ")
        strSQL.Append("     SELECT COUNT(1) ")
        strSQL.Append("     FROM ENVIO E, ENVIO_MONI_QQ S ")
        strSQL.Append("     WHERE E.ID_ENVIO = S.ID_ENVIO ")
        strSQL.Append("     AND S.ID_PROVEE_QQ = P.ID_PROVEE_QQ ")
        strSQL.Append("     AND E.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("     AND E.CODIPROVEEDOR = @CODIPROVEEDOR ")
        strSQL.Append("     AND (E.CATORCENA = @CATORCENA OR @CATORCENA = -1) ")
        strSQL.Append(" ) > 0 ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@CATORCENA", SqlDbType.Int)
        arg.Value = CATORCENA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR_QUERQUEO

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_QUERQUEO
                dbAsignarEntidades.AsignarPROVEEDOR_QUERQUEO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaCombo() As listaPROVEEDOR_QUERQUEO
        Dim lista As listaPROVEEDOR_QUERQUEO = Me.ObtenerListaPorID("ID_PROVEE_QQ")
        Dim lProveeQuerqueo As New PROVEEDOR_QUERQUEO

        If lista Is Nothing Then lista = New listaPROVEEDOR_QUERQUEO
        lProveeQuerqueo.ID_PROVEE_QQ = -1
        lProveeQuerqueo.CODISIS = ""
        lProveeQuerqueo.NOMBRES = "(NO APLICA)"
        lProveeQuerqueo.APELLIDOS = ""

        lista.Insertar(0, lProveeQuerqueo)

        Return lista
    End Function

End Class
