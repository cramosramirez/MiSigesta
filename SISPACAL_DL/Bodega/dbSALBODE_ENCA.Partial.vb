Partial Public Class dbSALBODE_ENCA

    Public Function PROC_Generar_SalBodega(ByVal ID_ZAFRA As Int32, ByVal USUARIO As String, ByVal SOLICITUDES As String, ByVal RETIRO_PROD As Boolean, ByRef Mensaje As String) As Int32
        Dim lResult As Int32 = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        arg.Value = USUARIO
        args.Add(arg)

        arg = New SqlParameter("@SOLICITUDES", SqlDbType.VarChar)
        arg.Value = SOLICITUDES
        args.Add(arg)

        arg = New SqlParameter("@RETIRO_PROD", SqlDbType.Bit)
        arg.Value = RETIRO_PROD
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "PROC_GENERAR_SALBODEGA", args.ToArray)

        Try
            If dr.Read Then
                lResult = CInt(dr("ID_SALBODE_ENCA"))
                Mensaje = CStr(dr("ERROR"))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lResult
    End Function

    Public Function ObtenerListaSIN_DOCUMENTO_SALIDA(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSALBODE_ENCA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SALBODE_ENCA))
        strSQL.Append(" WHERE (SELECT COUNT(1) FROM DOCUMENTO_SALIDA_ENCA D WHERE D.ID_SALBODE_ENCA = SALBODE_ENCA.ID_SALBODE_ENCA) = 0 ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSALBODE_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New SALBODE_ENCA
                dbAsignarEntidades.AsignarSALBODE_ENCA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerListaCON_DOCUMENTO_SALIDA(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSALBODE_ENCA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SALBODE_ENCA))
        strSQL.Append(" WHERE (SELECT COUNT(1) FROM DOCUMENTO_SALIDA_ENCA D WHERE D.ID_SALBODE_ENCA = SALBODE_ENCA.ID_SALBODE_ENCA) > 0 ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSALBODE_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New SALBODE_ENCA
                dbAsignarEntidades.AsignarSALBODE_ENCA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function PROC_Calcular_Entrega_Producto(ByVal ID_SALBODE_ENCA As Int32, ByVal ID_PRODUCTO As Int32) As Dictionary(Of String, Decimal)
        Dim lResult As New Dictionary(Of String, Decimal)
        Dim dValor As Decimal = 0
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_SALBODE_ENCA", SqlDbType.Int)
        arg.Value = ID_SALBODE_ENCA
        args.Add(arg)

        arg = New SqlParameter("@ID_PRODUCTO", SqlDbType.Int)
        arg.Value = ID_PRODUCTO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "PROC_CALCULAR_ENTREGA_PRODUCTO", args.ToArray)

        Try
            If dr.Read Then
                lResult.Add("SALIDA", Convert.ToDecimal(dr(0)))
                lResult.Add("DEVOLUCION", Convert.ToDecimal(dr(1)))
                lResult.Add("ENTREGA", Convert.ToDecimal(dr(2)))
            Else
                lResult = Nothing
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lResult
    End Function
End Class
