Partial Public Class dbORDEN_COMBUSTIBLE

    Public Function CantidadCoincidencias(ByVal ID_ZAFRA As Int32, _
                                             ByVal ID_PROVEEDOR_COMBUS As Int32, _
                                             ByVal CODIGO As Int32, _
                                             ByVal ID_TIPO_PROVEEDOR As Int32, _
                                             ByVal FECHA_EMISION As DateTime, _
                                             ByVal PLACA As String, _
                                             ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Integer
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT ISNULL(T.CANTIDAD,0) AS CANTIDAD ")
        strSQL.Append("FROM ( ")
        strSQL.Append(" SELECT COUNT(ID_ZAFRA) AS CANTIDAD ")
        strSQL.Append(" FROM ORDEN_COMBUSTIBLE ")
        strSQL.Append(" GROUP BY ID_ZAFRA, ID_PROVEEDOR_COMBUS, CODIGO, ID_TIPO_PROVEEDOR, ")
        strSQL.Append("     FECHA_EMISION, PLACA, USUARIO_CREA,")
        strSQL.Append("	    DAY(FECHA_CREA), MONTH(FECHA_CREA), ")
        strSQL.Append("	    YEAR(FECHA_CREA), {fn HOUR(FECHA_CREA)}, ")
        strSQL.Append("	    {fn MINUTE(FECHA_CREA)}, {fn SECOND(FECHA_CREA)} ")
        strSQL.Append(" HAVING ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("     AND ID_PROVEEDOR_COMBUS = @ID_PROVEEDOR_COMBUS ")
        strSQL.Append("     AND CODIGO = @CODIGO ")
        strSQL.Append("     AND ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR ")
        strSQL.Append("     AND FECHA_EMISION = @FECHA_EMISION ")
        strSQL.Append("     AND PLACA = @PLACA ")
        strSQL.Append("     AND USUARIO_CREA = @USUARIO_CREA ")
        strSQL.Append("     AND DAY(FECHA_CREA) = @DIA ")
        strSQL.Append("     AND MONTH(FECHA_CREA) = @MES ")
        strSQL.Append("     AND YEAR(FECHA_CREA) = @ANNIO ")
        strSQL.Append("     AND {fn HOUR(FECHA_CREA)} = @HORA ")
        strSQL.Append("     AND {fn MINUTE(FECHA_CREA)} = @MINUTO ")
        strSQL.Append("     AND {fn SECOND(FECHA_CREA)} = @SEGUNDO ")
        strSQL.Append(") T ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_PROVEEDOR_COMBUS", SqlDbType.Int)
        arg.Value = ID_PROVEEDOR_COMBUS
        args.Add(arg)

        arg = New SqlParameter("@CODIGO", SqlDbType.Int)
        arg.Value = CODIGO
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PROVEEDOR", SqlDbType.Int)
        arg.Value = ID_TIPO_PROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@FECHA_EMISION", SqlDbType.DateTime)
        arg.Value = FECHA_EMISION
        args.Add(arg)

        arg = New SqlParameter("@PLACA", SqlDbType.VarChar)
        arg.Value = PLACA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)

        arg = New SqlParameter("@DIA", SqlDbType.Int)
        arg.Value = FECHA_CREA.Day
        args.Add(arg)

        arg = New SqlParameter("@MES", SqlDbType.Int)
        arg.Value = FECHA_CREA.Month
        args.Add(arg)

        arg = New SqlParameter("@ANNIO", SqlDbType.Int)
        arg.Value = FECHA_CREA.Year
        args.Add(arg)

        arg = New SqlParameter("@HORA", SqlDbType.Int)
        arg.Value = CInt(FECHA_CREA.ToString("HH"))
        args.Add(arg)

        arg = New SqlParameter("@MINUTO", SqlDbType.Int)
        arg.Value = FECHA_CREA.Minute
        args.Add(arg)

        arg = New SqlParameter("@SEGUNDO", SqlDbType.Int)
        arg.Value = FECHA_CREA.Second
        args.Add(arg)

        Dim lCantidad As Integer

        Try
            lCantidad = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
            Return lCantidad

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerUltimosRegistrosPorUsuario(ByVal USUARIO As String, ByVal NUM_REGISTROS As Integer) As listaORDEN_COMBUSTIBLE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT TOP " + NUM_REGISTROS.ToString + " * ")
        strSQL.Append("FROM ORDEN_COMBUSTIBLE ")
        strSQL.Append("WHERE USUARIO_CREA = @USUARIO ")
        strSQL.Append("ORDER BY FECHA_CREA DESC ")

        arg = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        arg.Value = USUARIO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaORDEN_COMBUSTIBLE

        Try
            Do While dr.Read()
                Dim mEntidad As New ORDEN_COMBUSTIBLE
                dbAsignarEntidades.AsignarORDEN_COMBUSTIBLE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Object

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT isnull(max(ID_ORDEN_COMBUS),0) + 1 ")
        strSQL.AppendLine(" FROM ORDEN_COMBUSTIBLE")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerUltimosRegistrosPorTransportista(ByVal CODTRANSPORT As String, ByVal NUM_REGISTROS As Integer) As listaORDEN_COMBUSTIBLE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT TOP " + NUM_REGISTROS.ToString + " * ")
        strSQL.Append("FROM ORDEN_COMBUSTIBLE ")
        strSQL.Append("WHERE CODIGO = @CODTRANSPORT AND ID_TIPO_PROVEEDOR = 2 ")
        strSQL.Append("ORDER BY FECHA_EMISION DESC ")

        arg = New SqlParameter("@CODTRANSPORT", SqlDbType.VarChar)
        arg.Value = CODTRANSPORT
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaORDEN_COMBUSTIBLE

        Try
            Do While dr.Read()
                Dim mEntidad As New ORDEN_COMBUSTIBLE
                dbAsignarEntidades.AsignarORDEN_COMBUSTIBLE(dr, mEntidad)
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
