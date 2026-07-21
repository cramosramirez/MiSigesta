Partial Public Class dbPROVEEDOR_ROZA

    Public Function ObtenerListaPorTIPO_ROZA(ByVal ID_TIPO_ROZA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_ROZA
        Dim strSQL As New StringBuilder
        Dim agregar As Boolean = False
        strSQL.Append(Me.QuerySelect(New PROVEEDOR_ROZA))
        strSQL.Append(" WHERE ID_TIPO_ROZA = @ID_TIPO_ROZA AND ACTIVO = 1 ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_ROZA", SqlDbType.Int)
        args(0).Value = ID_TIPO_ROZA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROVEEDOR_ROZA

        Try
            If (ID_TIPO_ROZA = Enumeradores.CAT.TipoRoza.RozaCosechadoraJiboa OrElse
                ID_TIPO_ROZA = Enumeradores.CAT.TipoRoza.RozaCosechadoraParticular OrElse
                ID_TIPO_ROZA = Enumeradores.CAT.TipoRoza.RozaCosechadoraProductor) Then
                Dim lProveedoresRoza As listaPROVEEDOR_ROZA = (New dbPROVEEDOR_ROZA).ObtenerListaPorID
                If lProveedoresRoza IsNot Nothing AndAlso lProveedoresRoza.Count > 0 Then
                    For i As Int32 = 0 To lProveedoresRoza.Count - 1
                        If lProveedoresRoza(i).NOMBRE_PROVEEDOR_ROZA.StartsWith("RZ100") Then
                            lista.Add(lProveedoresRoza(i))
                        End If
                    Next
                End If
            Else
                Do While dr.Read()
                    Dim mEntidad As New PROVEEDOR_ROZA
                    dbAsignarEntidades.AsignarPROVEEDOR_ROZA(dr, mEntidad)
                    lista.Add(mEntidad)
                Loop
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorPROFORMA_CONTROL_ROZA_SALDO(ByVal ID_PROFORMA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_ROZA
        Dim strSQL As New StringBuilder
        Dim agregar As Boolean = False
        strSQL.Append("SELECT * FROM PROVEEDOR_ROZA P ")
        strSQL.Append("WHERE P.ACTIVO = 1 AND EXISTS( ")
        strSQL.Append("     SELECT J.ID_PROVEEDOR_ROZA ")
        strSQL.Append("     FROM ( ")
        strSQL.Append("             SELECT C.ID_PROVEEDOR_ROZA FROM CONTROL_ROZA C ")
        strSQL.Append("             WHERE NOT C.ID_PROVEEDOR_ROZA IS NULL AND (SELECT COUNT(1) FROM CONTROL_ROZA R WHERE R.ID_REF = @ID_PROFORMA AND R.ID_ROZA_SALDO = C.ID_ROZA_SALDO ) > 0 ")
        strSQL.Append("         ) J ")
        strSQL.Append("     WHERE J.ID_PROVEEDOR_ROZA = P.ID_PROVEEDOR_ROZA ")
        strSQL.Append("     ) ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PROFORMA", SqlDbType.Int)
        args(0).Value = ID_PROFORMA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROVEEDOR_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_ROZA
                dbAsignarEntidades.AsignarPROVEEDOR_ROZA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorREPORTE_ROZA_INJIBOA_RELA(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CATORCENA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_ROZA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim agregar As Boolean = False
        strSQL.Append("SELECT * FROM PROVEEDOR_ROZA P ")
        strSQL.Append("WHERE ( ")
        strSQL.Append("     SELECT COUNT(1) ")
        strSQL.Append("     FROM ENVIO E, ENVIO_ROZA_PS S ")
        strSQL.Append("     WHERE E.ID_ENVIO = S.ID_ENVIO ")
        strSQL.Append("     AND S.ID_PROVEEDOR_ROZA_S = P.ID_PROVEEDOR_ROZA ")
        strSQL.Append("     AND E.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("     AND E.CODIPROVEEDOR = @CODIPROVEEDOR ")
        strSQL.Append("     AND E.ID_TIPO_ROZA IN(20,21) ")
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

        Dim lista As New listaPROVEEDOR_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_ROZA
                dbAsignarEntidades.AsignarPROVEEDOR_ROZA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerPorCODIGO(ByVal CODIGO As String) As PROVEEDOR_ROZA
        Dim strSQL As New StringBuilder
        Dim agregar As Boolean = False
        strSQL.Append(" SELECT TOP 1 * FROM PROVEEDOR_ROZA ")
        strSQL.Append(" WHERE CODIGO = @CODIGO AND ACTIVO = 1 ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIGO", SqlDbType.VarChar)
        args(0).Value = CODIGO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New PROVEEDOR_ROZA

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarPROVEEDOR_ROZA(dr, mEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function

End Class
