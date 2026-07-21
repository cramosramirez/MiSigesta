Partial Public Class dbCONTROL_ROZA_SALDO

    Public Function ObtenerListaPROVEEDOR_ROZA(ByVal ID_ROZA_SALDO As Int32) As String
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim cad As New StringBuilder
        strSQL.Append("SELECT DISTINCT P.NOMBRE_PROVEEDOR_ROZA FROM CONTROL_ROZA CR, PROVEEDOR_ROZA P WHERE ID_ROZA_SALDO = @ID_ROZA_SALDO AND CR.ID_PROVEEDOR_ROZA = P.ID_PROVEEDOR_ROZA ORDER BY 1 ")

        arg = New SqlParameter("@ID_ROZA_SALDO", SqlDbType.Int)
        arg.Value = ID_ROZA_SALDO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            Do While dr.Read()
                cad.Append(dr(0).ToString + ", ")
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return cad.ToString

    End Function

    Public Function ObtenerHorasQuemaRozaTranscurridas(ByVal ID_ROZA_SALDO As Int32) As Dictionary(Of String, Int32)
        Dim dFechora As New dbFechaHora
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim fechaHora As DateTime = dFechora.ObtenerFechaHora

        strSQL.Append("SELECT  ")
        strSQL.Append("ISNULL(DATEDIFF(hour,MIN(R.FECHA_HORA_QUEMA),@FECHORA_ACTUAL),0) AS HORAS_QUEMA, ")
        strSQL.Append("ISNULL(DATEDIFF(hour,MIN(R.FECHA_HORA_ROZA),@FECHORA_ACTUAL),0) AS HORAS_ROZA ")
        strSQL.Append("FROM CONTROL_ROZA_SALDO S, CONTROL_ROZA R  ")
        strSQL.Append("WHERE S.ID_ROZA_SALDO = R.ID_ROZA_SALDO ")
        strSQL.Append("AND S.ID_ROZA_SALDO = @ID_ROZA_SALDO ")
        strSQL.Append("AND S.SALDO > 0 ")


        arg = New SqlParameter("@ID_ROZA_SALDO", SqlDbType.Int)
        arg.Value = ID_ROZA_SALDO
        args.Add(arg)
       
        arg = New SqlParameter("@FECHORA_ACTUAL", SqlDbType.DateTime)
        arg.Value = fechaHora
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New Dictionary(Of String, Int32)

        Try
            If dr.Read() Then
                lista.Add("HORAS_QUEMA", dr("HORAS_QUEMA"))
                lista.Add("HORAS_ROZA", dr("HORAS_ROZA"))
            Else
                lista = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    Public Function ObtenerSaldoTipoQuemaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Dictionary(Of String, Decimal)
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.AppendLine("SELECT  ")
        strSQL.AppendLine("ISNULL((SELECT SUM(SALDO) FROM CONTROL_ROZA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND QUEMA_PROGRAMADA = 1),0) AS QUEMA_PROGRAMADA, ")
        strSQL.AppendLine("ISNULL((SELECT SUM(SALDO) FROM CONTROL_ROZA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND QUEMA_NOPROG = 1),0) AS QUEMA_NOPROG, ")
        strSQL.AppendLine("ISNULL((SELECT SUM(SALDO) FROM CONTROL_ROZA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND CANA_VERDE = 1),0) AS CANA_VERDE ")


        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
        End If
        If ACCESLOTE <> "" Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
            arg.Value = ACCESLOTE
            args.Add(arg)
        End If
        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New Dictionary(Of String, Decimal)

        Try
            If dr.Read() Then
                lista.Add("QUEMA_PROGRAMADA", dr("QUEMA_PROGRAMADA"))
                lista.Add("QUEMA_NOPROG", dr("QUEMA_NOPROG"))
                lista.Add("CANA_VERDE", dr("CANA_VERDE"))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                            ByVal ACCESLOTE As String,
                                            ByVal ID_PROVEEDOR_ROZA As Int32,
                                            ByVal ID_TIPO_CANA As Int32,
                                            ByVal ID_TIPO_ROZA As Int32,
                                            ByVal FECHA_HORA_QUEMA As String,
                                            ByVal FECHA_HORA_ROZA As String,
                                            ByVal QUEMA_PROGRAMADA As Int32,
                                            ByVal QUEMA_NOPROG As Int32,
                                            ByVal CANA_VERDE As Int32,
                                            ByVal CODIGO_REF As String,
                                            ByVal ID_REF As Int32,
                                            ByVal ES_PROYECCION As Int32,
                                            ByVal TIPO_SALDO As Int32,
                                            ByVal ES_QUERQUEO As Int32,
                                            Optional ID_SUBLOTES As Int32 = -1,
                                            Optional ByVal asColumnaOrden As String = "",
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_ROZA_SALDO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder

        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA_SALDO))

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_ZAFRA = @ID_ZAFRA")
        End If
        If ACCESLOTE <> "" AndAlso ACCESLOTE <> Nothing Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
            arg.Value = ACCESLOTE
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ACCESLOTE = @ACCESLOTE")
        End If
        If ID_PROVEEDOR_ROZA <> -1 Then
            arg = New SqlParameter("@ID_PROVEEDOR_ROZA", SqlDbType.Int)
            arg.Value = ID_PROVEEDOR_ROZA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_PROVEEDOR_ROZA = @ID_PROVEEDOR_ROZA")
        End If
        If ID_TIPO_CANA <> -1 Then
            arg = New SqlParameter("@ID_TIPO_CANA", SqlDbType.Int)
            arg.Value = ID_TIPO_CANA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_TIPO_CANA = @ID_TIPO_CANA")
        End If
        If ID_TIPO_ROZA <> -1 Then
            arg = New SqlParameter("@ID_TIPO_ROZA", SqlDbType.Int)
            arg.Value = ID_TIPO_ROZA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_TIPO_ROZA = @ID_TIPO_ROZA")
        End If
        If FECHA_HORA_QUEMA <> "" Then
            If FECHA_HORA_QUEMA = "-" Then
                Me.AgregarCondicion(strCondicion, "FECHA_HORA_QUEMA IS NULL")
            Else
                arg = New SqlParameter("@FECHA_HORA_QUEMA", SqlDbType.DateTime)
                arg.Value = New DateTime(FECHA_HORA_QUEMA.Substring(6, 4), FECHA_HORA_QUEMA.Substring(3, 2), FECHA_HORA_QUEMA.Substring(0, 2), FECHA_HORA_QUEMA.Substring(11, 2), FECHA_HORA_QUEMA.Substring(14, 2), 0)
                args.Add(arg)
                Me.AgregarCondicion(strCondicion, "FECHA_HORA_QUEMA = @FECHA_HORA_QUEMA")
            End If
        End If
        If FECHA_HORA_ROZA <> "" Then
            arg = New SqlParameter("@FECHA_HORA_ROZA", SqlDbType.DateTime)
            arg.Value = New DateTime(FECHA_HORA_ROZA.Substring(6, 4), FECHA_HORA_ROZA.Substring(3, 2), FECHA_HORA_ROZA.Substring(0, 2), FECHA_HORA_ROZA.Substring(11, 2), FECHA_HORA_ROZA.Substring(14, 2), 0)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "FECHA_HORA_ROZA = @FECHA_HORA_ROZA")
        End If
        If QUEMA_PROGRAMADA <> -1 Then
            arg = New SqlParameter("@QUEMA_PROGRAMADA", SqlDbType.Bit)
            arg.Value = If(QUEMA_PROGRAMADA = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "QUEMA_PROGRAMADA = @QUEMA_PROGRAMADA")
        End If
        If QUEMA_NOPROG <> -1 Then
            arg = New SqlParameter("@QUEMA_NOPROG", SqlDbType.Bit)
            arg.Value = If(QUEMA_NOPROG = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "QUEMA_NOPROG = @QUEMA_NOPROG")
        End If
        If CANA_VERDE <> -1 Then
            arg = New SqlParameter("@CANA_VERDE", SqlDbType.Bit)
            arg.Value = If(CANA_VERDE = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "CANA_VERDE = @CANA_VERDE")
        End If
        If ES_PROYECCION <> -1 Then
            arg = New SqlParameter("@ES_PROYECCION", SqlDbType.Bit)
            arg.Value = If(ES_PROYECCION = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ES_PROYECCION = @ES_PROYECCION")
        End If
        If ES_QUERQUEO <> -1 Then
            arg = New SqlParameter("@ES_QUERQUEO", SqlDbType.Bit)
            arg.Value = If(ES_QUERQUEO = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ES_QUERQUEO = @ES_QUERQUEO")
        End If
        If CODIGO_REF <> "" AndAlso CODIGO_REF <> Nothing Then
            arg = New SqlParameter("@CODIGO_REF", SqlDbType.VarChar)
            arg.Value = CODIGO_REF
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "CODIGO_REF = @CODIGO_REF")
        End If
        If ID_REF <> -1 Then
            arg = New SqlParameter("@ID_REF", SqlDbType.Int)
            arg.Value = ID_REF
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_REF = @ID_REF")
        End If
        If TIPO_SALDO <> 0 Then
            If TIPO_SALDO = 1 Then
                Me.AgregarCondicion(strCondicion, "SALDO <> 0")
            ElseIf TIPO_SALDO = 2 Then
                Me.AgregarCondicion(strCondicion, "SALDO > 0")
            End If
        End If
        If ID_SUBLOTES <> -1 Then
            arg = New SqlParameter("@ID_SUBLOTES", SqlDbType.Int)
            arg.Value = ID_SUBLOTES
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_SUBLOTES = @ID_SUBLOTES")
        End If

        strSQL.Append(strCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY FECHA_HORA_ROZA DESC")
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCONTROL_ROZA_SALDO

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA_SALDO
                dbAsignarEntidades.AsignarCONTROL_ROZA_SALDO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function



    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosLiquidacion(ByVal ID_ZAFRA As Int32, _
                                            ByVal NO_CATORCENA As Int32, _
                                            ByVal CODIPROVEE As String, _
                                            ByVal CODISOCIO As String, _
                                            ByVal NOMBRE_PROVEEDOR As String, _
                                            ByVal NOMBRE_LOTE As String, _
                                            ByVal ES_PROYECCION As Int32, _
                                            ByVal TIPO_SALDO As Int32, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_ROZA_SALDO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder

        strSQL.Append("SELECT (SELECT P.NOMBRES + P.APELLIDOS FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = CQ.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR) AS NOMBRE_PROVEEDOR, ")
        strSQL.Append("(SELECT L.NOMBLOTE FROM LOTES L WHERE L.ACCESLOTE = CQ.ACCESLOTE) AS NOMBRE_LOTE, ")
        strSQL.Append("CQ.* ")
        strSQL.Append("FROM CONTROL_ROZA_SALDO CQ ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_ZAFRA = @ID_ZAFRA")
        End If
        If NO_CATORCENA <> -1 Then
            arg = New SqlParameter("@NO_CATORCENA", SqlDbType.Int)
            arg.Value = NO_CATORCENA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "(SELECT COUNT(1) FROM PLAN_COSECHA PC WHERE PC.ID_ZAFRA = CQ.ID_ZAFRA AND PC.ACCESLOTE = CQ.ACCESLOTE AND PC.CATORCENA = @NO_CATORCENA) > 0")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
            arg.Value = CODIPROVEE
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "(SELECT COUNT(1) FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = CQ.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE) > 0")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.VarChar)
            arg.Value = CODISOCIO
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "(SELECT COUNT(1) FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = CQ.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO) > 0")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + Replace(NOMBRE_PROVEEDOR, " ", "%") + "%"
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "(SELECT COUNT(1) FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = CQ.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND RTRIM(P.NOMBRES) + ' ' RTRIM(P.APELLIDOS) LIKE @NOMBRE_PROVEEDOR) > 0")
        End If
        If NOMBRE_LOTE <> "" Then
            arg = New SqlParameter("@NOMBRE_LOTE", SqlDbType.VarChar)
            arg.Value = "%" + Replace(NOMBRE_LOTE, " ", "%") + "%"
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "(SELECT COUNT(1) FROM LOTES L WHERE L.ACCESLOTE = CQ.ACCESLOTE AND L.NOMBLOTE LIKE @NOMBRE_LOTE) > 0")
        End If
        If ES_PROYECCION <> -1 Then
            arg = New SqlParameter("@ES_PROYECCION", SqlDbType.Bit)
            arg.Value = If(ES_PROYECCION = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ES_PROYECCION = @ES_PROYECCION")
        End If
        If TIPO_SALDO <> -1 Then
            If TIPO_SALDO = 1 Then
                Me.AgregarCondicion(strCondicion, "SALDO <> 0")
            End If
            If TIPO_SALDO = 2 Then
                Me.AgregarCondicion(strCondicion, "SALDO > 0")
            End If
        End If

        Me.AgregarCondicion(strCondicion, "(TC_REAL IS NULL)")

        strSQL.Append(strCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By 1, 2")
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCONTROL_ROZA_SALDO

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA_SALDO
                dbAsignarEntidades.AsignarCONTROL_ROZA_SALDO(dr, mEntidad)
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
