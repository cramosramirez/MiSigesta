Partial Public Class dbCONTROL_QUEMA_SALDO


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                            ByVal ACCESLOTE As String,
                                            ByVal FECHA_HORA_QUEMA As Object,
                                            ByVal QUEMA_PROGRAMADA As Int32,
                                            ByVal QUEMA_NOPROG As Int32,
                                            ByVal CANA_VERDE As Int32,
                                            ByVal ES_PROYECCION As Int32,
                                            ByVal CON_SALDO As Boolean,
                                            Optional ID_SUBLOTES As Int32 = -1,
                                            Optional ByVal asColumnaOrden As String = "",
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_QUEMA_SALDO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder

        strSQL.Append(Me.QuerySelect(New CONTROL_QUEMA_SALDO))

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
        If FECHA_HORA_QUEMA IsNot Nothing AndAlso IsDate(FECHA_HORA_QUEMA) Then
            arg = New SqlParameter("@FECHA_HORA_QUEMA", SqlDbType.DateTime)
            arg.Value = FECHA_HORA_QUEMA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "FECHA_HORA_QUEMA = @FECHA_HORA_QUEMA")
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
        If ID_SUBLOTES <> -1 Then
            arg = New SqlParameter("@ID_SUBLOTES", SqlDbType.Int)
            arg.Value = ID_SUBLOTES
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_SUBLOTES = @ID_SUBLOTES")
        End If
        If CON_SALDO Then
            Me.AgregarCondicion(strCondicion, "SALDO <> 0")
        End If

        strSQL.Append(strCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCONTROL_QUEMA_SALDO

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_QUEMA_SALDO
                dbAsignarEntidades.AsignarCONTROL_QUEMA_SALDO(dr, mEntidad)
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
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_QUEMA_SALDO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder

        strSQL.Append("SELECT (SELECT P.NOMBRES + P.APELLIDOS FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = CQ.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR) AS NOMBRE_PROVEEDOR, ")
        strSQL.Append("(SELECT L.NOMBLOTE FROM LOTES L WHERE L.ACCESLOTE = CQ.ACCESLOTE) AS NOMBRE_LOTE, ")
        strSQL.Append("CQ.* ")
        strSQL.Append("FROM CONTROL_QUEMA_SALDO CQ ")

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
        If TIPO_SALDO > -1 Then
            If TIPO_SALDO = 1 Then
                Me.AgregarCondicion(strCondicion, "SALDO > 0")
            End If
            If TIPO_SALDO = 2 Then
                Me.AgregarCondicion(strCondicion, "SALDO = 0")
            End If
        End If

        Me.AgregarCondicion(strCondicion, "(FECHA_HORA_QUEMA_REAL IS NULL OR TC_REAL IS NULL)")

        strSQL.Append(strCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By 1, 2")
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCONTROL_QUEMA_SALDO

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_QUEMA_SALDO
                dbAsignarEntidades.AsignarCONTROL_QUEMA_SALDO(dr, mEntidad)
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
