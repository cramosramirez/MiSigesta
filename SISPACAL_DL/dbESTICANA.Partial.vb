Partial Public Class dbESTICANA

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ESTICANA
        lEntidad = CType(aEntidad, ESTICANA)

        'Dim lID As Int32
        'If lEntidad.ID_ESTICANA = 0 _
        '    Or lEntidad.ID_ESTICANA = Nothing Then

        '    lID = CType(Me.ObtenerID(lEntidad), Int32)

        '    If lID = -1 Then Return -1

        '    lEntidad.ID_ESTICANA = lID

        '    Return Agregar(lEntidad)

        'End If

        'Return Actualizar(aEntidad)
        Return ACTUALIZAR_ESTICANA_APP(lEntidad)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        'Dim strSQL As New StringBuilder


        'Dim args(0) As SqlParameter

        'strSQL.Append(Me.QueryInsert(aEntidad, args))

        'Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ACTUALIZAR_ESTICANA_APP(DirectCast(aEntidad, ESTICANA))
    End Function

    Private Function ACTUALIZAR_ESTICANA_APP(ByVal aEntidad As ESTICANA) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        arg = New SqlParameter("@ID_ESTICANA", SqlDbType.Int)
        arg.Value = aEntidad.ID_ESTICANA
        args.Add(arg)
        arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        arg.Value = aEntidad.ACCESLOTE
        args.Add(arg)
        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = aEntidad.ID_ZAFRA
        args.Add(arg)
        arg = New SqlParameter("@FECHA_ROZA", SqlDbType.DateTime)
        arg.Value = IIf(aEntidad.FECHA_ROZA = #12:00:00 AM#, System.Data.SqlTypes.SqlDateTime.Null, aEntidad.FECHA_ROZA)
        args.Add(arg)
        arg = New SqlParameter("@REND_COSECHA", SqlDbType.Decimal)
        arg.Value = aEntidad.REND_COSECHA
        args.Add(arg)
        arg = New SqlParameter("@MZ_ENTREGAR", SqlDbType.Decimal)
        arg.Value = aEntidad.MZ_ENTREGAR
        args.Add(arg)
        arg = New SqlParameter("@TONEL_MZ_ENTREGAR", SqlDbType.Decimal)
        arg.Value = aEntidad.TONEL_MZ_ENTREGAR
        args.Add(arg)
        arg = New SqlParameter("@TONEL_ENTREGAR", SqlDbType.Decimal)
        arg.Value = aEntidad.TONEL_ENTREGAR
        args.Add(arg)
        arg = New SqlParameter("@LBS_ENTREGAR", SqlDbType.Decimal)
        arg.Value = aEntidad.LBS_ENTREGAR
        args.Add(arg)
        arg = New SqlParameter("@VALOR_ENTREGAR", SqlDbType.Decimal)
        arg.Value = aEntidad.VALOR_ENTREGAR
        args.Add(arg)
        arg = New SqlParameter("@MZ_ENTREGADA", SqlDbType.Decimal)
        arg.Value = aEntidad.MZ_ENTREGADA
        args.Add(arg)
        arg = New SqlParameter("@TONEL_MZ_ENTREGADA", SqlDbType.Decimal)
        arg.Value = aEntidad.TONEL_MZ_ENTREGADA
        args.Add(arg)
        arg = New SqlParameter("@TONEL_ENTREGADA", SqlDbType.Decimal)
        arg.Value = aEntidad.TONEL_ENTREGADA
        args.Add(arg)
        arg = New SqlParameter("@LBS_ENTREGADA", SqlDbType.Decimal)
        arg.Value = aEntidad.LBS_ENTREGADA
        args.Add(arg)
        arg = New SqlParameter("@VALOR_ENTREGADA", SqlDbType.Decimal)
        arg.Value = aEntidad.VALOR_ENTREGADA
        args.Add(arg)
        arg = New SqlParameter("@MZ_CENSO", SqlDbType.Decimal)
        arg.Value = aEntidad.MZ_CENSO
        args.Add(arg)
        arg = New SqlParameter("@TONEL_MZ_CENSO", SqlDbType.Decimal)
        arg.Value = aEntidad.TONEL_MZ_CENSO
        args.Add(arg)
        arg = New SqlParameter("@TONEL_CENSO", SqlDbType.Decimal)
        arg.Value = aEntidad.TONEL_CENSO
        args.Add(arg)
        arg = New SqlParameter("@LBS_CENSO", SqlDbType.Decimal)
        arg.Value = aEntidad.LBS_CENSO
        args.Add(arg)
        arg = New SqlParameter("@VALOR_CENSO", SqlDbType.Decimal)
        arg.Value = aEntidad.VALOR_CENSO
        args.Add(arg)
        arg = New SqlParameter("@FIN_LOTE", SqlDbType.Bit)
        arg.Value = aEntidad.FIN_LOTE
        args.Add(arg)
        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = aEntidad.USUARIO_CREA
        args.Add(arg)
        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = aEntidad.FECHA_CREA
        args.Add(arg)
        arg = New SqlParameter("@USUARIO_ACT", SqlDbType.VarChar)
        arg.Value = aEntidad.USUARIO_ACT
        args.Add(arg)
        arg = New SqlParameter("@FECHA_ACT", SqlDbType.DateTime)
        arg.Value = aEntidad.FECHA_ACT
        args.Add(arg)
        arg = New SqlParameter("@CODIAGRON", SqlDbType.VarChar)
        arg.Value = aEntidad.CODIAGRON
        args.Add(arg)
        arg = New SqlParameter("@FECHA_SIEMBRA", SqlDbType.DateTime)
        arg.Value = IIf(aEntidad.FECHA_SIEMBRA = #12:00:00 AM#, System.Data.SqlTypes.SqlDateTime.Null, aEntidad.FECHA_SIEMBRA)
        args.Add(arg)
        arg = New SqlParameter("@ID_TIPO_CANA", SqlDbType.Int)
        arg.Value = IIf(aEntidad.ID_TIPO_CANA = -1, Nothing, aEntidad.ID_TIPO_CANA)
        args.Add(arg)
        arg = New SqlParameter("@ID_TIPO_ROZA", SqlDbType.Int)
        arg.Value = IIf(aEntidad.ID_TIPO_ROZA = -1, Nothing, aEntidad.ID_TIPO_ROZA)
        args.Add(arg)
        arg = New SqlParameter("@ID_TIPO_ALZA", SqlDbType.Int)
        arg.Value = IIf(aEntidad.ID_TIPO_ALZA = -1, Nothing, aEntidad.ID_TIPO_ALZA)
        args.Add(arg)
        arg = New SqlParameter("@ID_TIPO_TRANS", SqlDbType.Int)
        arg.Value = IIf(aEntidad.ID_TIPO_TRANS = -1, Nothing, aEntidad.ID_TIPO_TRANS)
        args.Add(arg)
        arg = New SqlParameter("@FAB_SEMANA", SqlDbType.Int)
        arg.Value = IIf(aEntidad.FAB_SEMANA = -1, Nothing, aEntidad.FAB_SEMANA)
        args.Add(arg)
        arg = New SqlParameter("@FAB_CATORCENA", SqlDbType.Int)
        arg.Value = IIf(aEntidad.FAB_CATORCENA = -1, Nothing, aEntidad.FAB_CATORCENA)
        args.Add(arg)
        arg = New SqlParameter("@FAB_SUBTERCIO", SqlDbType.VarChar)
        arg.Value = IIf(aEntidad.FAB_SUBTERCIO = "", Nothing, aEntidad.FAB_SUBTERCIO)
        args.Add(arg)
        arg = New SqlParameter("@FAB_TERCIO", SqlDbType.Int)
        arg.Value = IIf(aEntidad.FAB_TERCIO = -1, Nothing, aEntidad.FAB_TERCIO)
        args.Add(arg)
        arg = New SqlParameter("@TARIFA_ROZA", SqlDbType.Decimal)
        arg.Value = IIf(aEntidad.TARIFA_ROZA = -1, Nothing, aEntidad.TARIFA_ROZA)
        args.Add(arg)
        arg = New SqlParameter("@TARIFA_ALZA", SqlDbType.Decimal)
        arg.Value = IIf(aEntidad.TARIFA_ALZA = -1, Nothing, aEntidad.TARIFA_ALZA)
        args.Add(arg)
        arg = New SqlParameter("@TARIFA_TRANS", SqlDbType.Decimal)
        arg.Value = IIf(aEntidad.TARIFA_TRANS = -1, Nothing, aEntidad.TARIFA_TRANS)
        args.Add(arg)
        arg = New SqlParameter("@TARIFA_CORTA", SqlDbType.Decimal)
        arg.Value = IIf(aEntidad.TARIFA_CORTA = -1, Nothing, aEntidad.TARIFA_CORTA)
        args.Add(arg)
        arg = New SqlParameter("@TARIFA_LARGA", SqlDbType.Decimal)
        arg.Value = IIf(aEntidad.TARIFA_LARGA = -1, Nothing, aEntidad.TARIFA_LARGA)
        args.Add(arg)
        arg = New SqlParameter("@SALDO_ROZA", SqlDbType.Decimal)
        arg.Value = aEntidad.SALDO_ROZA
        args.Add(arg)
        arg = New SqlParameter("@EDAD_LOTE", SqlDbType.Int)
        arg.Value = aEntidad.EDAD_LOTE
        args.Add(arg)
        arg = New SqlParameter("@SALDO_QUEMA", SqlDbType.Decimal)
        arg.Value = aEntidad.SALDO_QUEMA
        args.Add(arg)
        arg = New SqlParameter("@FECHA_ROZA_DISPO", SqlDbType.DateTime)
        arg.Value = IIf(aEntidad.FECHA_ROZA_DISPO = #12:00:00 AM#, System.Data.SqlTypes.SqlDateTime.Null, aEntidad.FECHA_ROZA_DISPO)
        args.Add(arg)
        arg = New SqlParameter("@TONEL_SALDO_VAR", SqlDbType.Decimal)
        arg.Value = aEntidad.TONEL_SALDO_VAR
        args.Add(arg)
        arg = New SqlParameter("@TONEL_SEMILLA", SqlDbType.Decimal)
        arg.Value = aEntidad.TONEL_SEMILLA
        args.Add(arg)
        arg = New SqlParameter("@FECHA_CIERRE", SqlDbType.DateTime)
        arg.Value = IIf(aEntidad.FECHA_CIERRE = #12:00:00 AM#, System.Data.SqlTypes.SqlDateTime.Null, aEntidad.FECHA_CIERRE)
        args.Add(arg)
        arg = New SqlParameter("@HORAS_GRACIA_ENTREGA", SqlDbType.Int)
        arg.Value = aEntidad.HORAS_GRACIA_ENTREGA
        args.Add(arg)
        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "ACTUALIZAR_ESTICANA_APP", args.ToArray)
    End Function

    Public Function ActualizarReferenciasESTICANA(ByVal ACCESLOTE_OLD As String, ByVal ACCESLOTE_NEW As String) As Int32
        Dim lRet As Int32 = 0
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ACCESLOTE_OLD", SqlDbType.VarChar)
        args(0).Value = ACCESLOTE_OLD

        args(1) = New SqlParameter("@ACCESLOTE_NEW", SqlDbType.VarChar)
        args(1).Value = ACCESLOTE_NEW

        Try
            SqlHelper.ExecuteNonQuery(Me.cnnStr, "ACTUALIZAR_REFERENCIAS_ESTICANA", args)
            Return 1

        Catch ex As Exception
            Return -1
        End Try

        Return lRet
    End Function

    Public Function ActualizarTONELADAS_ENTREGADAS(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As Int32
        Dim lRet As Int32 = 0
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(1).Value = ACCESLOTE

        Try
            SqlHelper.ExecuteNonQuery(Me.cnnStr, "ACTUALIZAR_TONEL_ENTREGADAS", args)
            Return 1

        Catch ex As Exception
            Return -1
        End Try

        Return lRet
    End Function


    Public Function ObtenerUltimaCosechaPorLOTE_FinLote(ByVal ID_MAESTRO As Int32, ByVal ESTADO_LOTE As String, Optional ID_ZAFRA As Int32 = -1) As listaESTICANA

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        strSQL.Append("SELECT TOP 1 LC.* ")
        strSQL.Append("FROM ESTICANA LC, ZAFRA Z ")
        strSQL.Append("WHERE LC.ID_ZAFRA = Z.ID_ZAFRA ")
        strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.ID_MAESTRO = @ID_MAESTRO) ")

        arg = New SqlParameter("@ID_MAESTRO", SqlDbType.Int)
        arg.Value = ID_MAESTRO
        args.Add(arg)

        If ESTADO_LOTE = "A" Then
            arg = New SqlParameter("@FIN_LOTE", SqlDbType.Bit)
            arg.Value = False
            args.Add(arg)
            strSQL.Append("AND LC.FIN_LOTE = @FIN_LOTE ")
        ElseIf ESTADO_LOTE = "C" Then
            arg = New SqlParameter("@FIN_LOTE", SqlDbType.Bit)
            arg.Value = True
            args.Add(arg)
            strSQL.Append("AND LC.FIN_LOTE = @FIN_LOTE ")
        End If
        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            strSQL.Append("AND LC.ID_ZAFRA = @ID_ZAFRA ")
        End If

        strSQL.Append("ORDER BY Z.NOMBRE_ZAFRA DESC ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaESTICANA

        Try
            Do While dr.Read()
                Dim mEntidad As New ESTICANA
                dbAsignarEntidades.AsignarESTICANA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerESTICANAPorLOTE_ZAFRA(ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32) As ESTICANA

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        strSQL.Append("SELECT * ")
        strSQL.Append("FROM ESTICANA ")
        strSQL.Append("WHERE ACCESLOTE = @ACCESLOTE ")
        strSQL.Append("AND ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        arg.Value = ACCESLOTE
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As ESTICANA

        Try
            If dr.Read() Then
                mEntidad = New ESTICANA
                dbAsignarEntidades.AsignarESTICANA(dr, mEntidad)
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


    Public Function ObtenerESTICANAPorMAESTRO_ZAFRA(ByVal ID_MAESTRO As Int32, ByVal ID_ZAFRA As Int32) As ESTICANA

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        strSQL.Append("SELECT LC.* ")
        strSQL.Append("FROM ESTICANA LC, LOTES L ")
        strSQL.Append("WHERE LC.ACCESLOTE = L.ACCESLOTE ")
        strSQL.Append("AND L.ID_MAESTRO = @ID_MAESTRO ")
        strSQL.Append("AND LC.ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ID_MAESTRO", SqlDbType.Int)
        arg.Value = ID_MAESTRO
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As ESTICANA

        Try
            If dr.Read() Then
                mEntidad = New ESTICANA
                dbAsignarEntidades.AsignarESTICANA(dr, mEntidad)
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





    Public Function ObtenerTOTAL_PLAN_COSECHAPorZAFRA(ByVal ID_ZAFRA As Int32) As ESTICANA

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        strSQL.Append("SELECT ")
        strSQL.Append("SUM(MZ_ENTREGAR) AS MZ_ENTREGAR, ")
        strSQL.Append("SUM(TONEL_ENTREGAR) AS TONEL_ENTREGAR, ")
        strSQL.Append("SUM(MZ_ENTREGADA) AS MZ_ENTREGADA, ")
        strSQL.Append("SUM(TONEL_ENTREGADA) AS TONEL_ENTREGADA, ")
        strSQL.Append("SUM(MZ_CENSO) AS MZ_CENSO, ")
        strSQL.Append("SUM(TONEL_CENSO - TONEL_SEMILLA + (-1 * TONEL_SALDO_VAR)) AS TONEL_CENSO, ")
        strSQL.Append("SUM(TONEL_SALDO_VAR) AS TONEL_SALDO_VAR, ")
        strSQL.Append("SUM(TONEL_SEMILLA) AS TONEL_SEMILLA ")
        strSQL.Append("FROM ESTICANA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As ESTICANA

        Try
            If dr.Read() Then
                mEntidad = New ESTICANA
                mEntidad.MZ_ENTREGAR = dr("MZ_ENTREGAR")
                mEntidad.TONEL_ENTREGAR = dr("TONEL_ENTREGAR")
                mEntidad.MZ_ENTREGADA = dr("MZ_ENTREGADA")
                mEntidad.TONEL_ENTREGADA = dr("TONEL_ENTREGADA")
                mEntidad.MZ_CENSO = dr("MZ_CENSO")
                mEntidad.TONEL_CENSO = dr("TONEL_CENSO")
                mEntidad.TONEL_SALDO_VAR = dr("TONEL_SALDO_VAR")
                mEntidad.TONEL_SEMILLA = dr("TONEL_SEMILLA")
            Else
                mEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return mEntidad
    End Function

    Public Function ObtenerREND_COSECHA_UltimaZafra(ByVal ID_MAESTRO As Int32, ByVal ID_ZAFRA As Int32) As Decimal

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter
        Dim lResult As Object
        Dim RendCosecha As Decimal = 0

        strSQL.Append("SELECT TOP 1 LC.REND_COSECHA ")
        strSQL.Append("FROM LOTES L, ESTICANA LC, ZAFRA Z ")
        strSQL.Append("WHERE L.ID_MAESTRO = @ID_MAESTRO ")
        strSQL.Append("AND L.ACCESLOTE = LC.ACCESLOTE ")
        strSQL.Append("AND LC.ID_ZAFRA = Z.ID_ZAFRA ")
        strSQL.Append("AND Z.NOMBRE_ZAFRA < (SELECT Z.NOMBRE_ZAFRA FROM ZAFRA Z WHERE Z.ID_ZAFRA = @ID_ZAFRA) ")
        strSQL.Append("ORDER BY Z.NOMBRE_ZAFRA DESC ")

        arg = New SqlParameter("@ID_MAESTRO", SqlDbType.Int)
        arg.Value = ID_MAESTRO
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        lResult = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If lResult Is Nothing OrElse IsDBNull(lResult) Then
                RendCosecha = 0
            Else
                RendCosecha = CDec(lResult)
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return RendCosecha
    End Function


    Public Function ObtenerREND_COSECHA_SUB_ZONA(ByVal SUB_ZONA As String, ByVal ID_ZAFRA As Int32) As Decimal

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter
        Dim RendCosecha As Decimal = 0

        strSQL.Append("SELECT TOP 1 CASE WHEN  SUM(LC.TONEL_ENTREGADA) = 0 THEN 0 ELSE SUM(LC.REND_COSECHA * LC.TONEL_ENTREGADA)/ SUM(LC.TONEL_ENTREGADA) END AS REND_COSECHA ")
        strSQL.Append("FROM LOTES L, ESTICANA LC, ZAFRA Z ")
        strSQL.Append("WHERE L.ACCESLOTE = LC.ACCESLOTE ")
        strSQL.Append("AND LC.ID_ZAFRA = Z.ID_ZAFRA ")
        strSQL.Append("AND L.SUB_ZONA = @SUB_ZONA ")
        strSQL.Append("AND Z.NOMBRE_ZAFRA < (SELECT Z.NOMBRE_ZAFRA FROM ZAFRA Z WHERE Z.ID_ZAFRA = @ID_ZAFRA) ")
        strSQL.Append("GROUP BY Z.NOMBRE_ZAFRA ")
        strSQL.Append("ORDER BY Z.NOMBRE_ZAFRA DESC ")

        arg = New SqlParameter("@SUB_ZONA", SqlDbType.VarChar)
        arg.Value = SUB_ZONA
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                RendCosecha = CDec(dr(0))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return RendCosecha

    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                             ByVal ZONA As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal NOMBLOTE As String,
                                             ByVal NO_CONTRATO As Int32,
                                             ByVal CODIAGRON As String) As listaESTICANA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM ESTICANA LC ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "LC.ID_ZAFRA = @ID_ZAFRA")
        End If
        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.ZONA = @ZONA) ")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE)")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO)")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND ISNULL(RTRIM(P.NOMBRES),'') + ' ' + ISNULL(RTRIM(P.APELLIDOS),'') LIKE @NOMBRE_PROVEEDOR)")
        End If
        If NOMBLOTE <> "" Then
            arg = New SqlParameter("@NOMBLOTE", SqlDbType.VarChar)
            arg.Value = "%" + NOMBLOTE.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = LC.ACCESLOTE AND ISNULL(RTRIM(L.NOMBLOTE),'') LIKE @NOMBLOTE)")
        End If
        If NO_CONTRATO <> -1 Then
            arg = New SqlParameter("@NO_CONTRATO", SqlDbType.Int)
            arg.Value = NO_CONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, CONTRATO C WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.CODICONTRATO = C.CODICONTRATO AND C.NO_CONTRATO = @NO_CONTRATO)")
        End If
        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Char)
            arg.Value = CODIAGRON
            args.Add(arg)
            AgregarCondicion(strCond, "LC.CODIAGRON = @CODIAGRON")
        End If

        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaESTICANA

        Try
            Do While dr.Read()
                Dim mEntidad As New ESTICANA
                dbAsignarEntidades.AsignarESTICANA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaProforma(ByVal ID_ZAFRA As Int32, ByVal TIPOS_TRANSPORTE As String, ByVal CON_SALDO_ROZA As Boolean) As listaESTICANA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM ESTICANA LC ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "LC.ID_ZAFRA = @ID_ZAFRA")
        End If
        If TIPOS_TRANSPORTE <> "" Then
            Dim listaTIPOS_TRANS As String() = TIPOS_TRANSPORTE.Split(";")
            Dim strIN As New StringBuilder
            If listaTIPOS_TRANS.Length = 1 Then
                strIN.Append("LC.ID_TIPO_TRANS = @ID_TIPOTRANS")
                Dim op As SqlParameter = New SqlParameter("@ID_TIPOTRANS", SqlDbType.Int)
                op.Value = listaTIPOS_TRANS(0)
                args.Add(op)
            Else
                For i As Integer = 0 To listaTIPOS_TRANS.Length - 1
                    If i = 0 Then
                        strIN.Append(" LC.ID_TIPO_TRANS IN(") : strIN.Append(listaTIPOS_TRANS(i).ToString)
                    Else
                        strIN.Append(",") : strIN.Append(listaTIPOS_TRANS(i).ToString)
                    End If
                Next
                strIN.Append(") ")
            End If
            AgregarCondicion(strCond, strIN.ToString)
        End If

        AgregarCondicion(strCond, "LC.SALDO_ROZA > 0 AND NOT LC.FECHA_ROZA_DISPO IS NULL")

        strSQL.Append(strCond.ToString)

        If CON_SALDO_ROZA Then
            strSQL.Append("ORDER BY FECHA_ROZA_DISPO ASC ")
        End If

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaESTICANA

        Try
            Do While dr.Read()
                Dim mEntidad As New ESTICANA
                dbAsignarEntidades.AsignarESTICANA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    Public Function ObtenerEJECUCION_ALZA(ByVal ID_ZAFRA As Int32) As Dictionary(Of String, Dictionary(Of String, Decimal))

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter
        Dim diccMaestro As New Dictionary(Of String, Dictionary(Of String, Decimal))
        Dim diccDetalle As New Dictionary(Of String, Decimal)


        strSQL.AppendLine("SELECT TIPO_COSECHA, ISNULL(SUM(NETOTONEL),0) AS NETOTONEL, ISNULL(SUM(AZUCAR_CALC2),0) AS AZUCAR_CALC2, ISNULL(SUM(AZUCAR_CATORCENA_REAL),0) AS AZUCAR_CATORCENA_REAL ")
        strSQL.AppendLine("FROM( ")
        strSQL.AppendLine("	SELECT ")
        strSQL.AppendLine("		CASE ")
        strSQL.AppendLine("			WHEN CA.ID_TIPO_ALZA IN(27,28,39) THEN 'COSECHADORA' ")
        strSQL.AppendLine("			WHEN CA.ID_TIPO_ALZA IN(29,30,40) THEN 'CARGADORA' ")
        strSQL.AppendLine("			WHEN CA.ID_TIPO_ALZA IN(25,26) THEN 'MANUAL' ")
        strSQL.AppendLine("			ELSE NULL ")
        strSQL.AppendLine("		END AS TIPO_COSECHA, ")
        strSQL.AppendLine("		B.NETOTONEL, A.AZUCAR_CALC2, ISNULL(A.AZUCAR_CATORCENA_REAL,A.AZUCAR_CALC2) AS AZUCAR_CATORCENA_REAL ")
        strSQL.AppendLine("	FROM ENVIO E, BASCULA B, ANALISIS A, CARGADORA CA ")
        strSQL.AppendLine("	WHERE E.ID_ENVIO = B.ID_ENVIO ")
        strSQL.AppendLine("	AND E.ID_ENVIO = A.ID_ENVIO ")
        strSQL.AppendLine("	AND E.ID_CARGADORA = CA.ID_CARGADORA ")
        strSQL.AppendLine("	AND NOT B.NETOTONEL IS NULL	AND NOT A.POL IS NULL ")
        strSQL.AppendLine("	AND E.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.AppendLine(") AS T ")
        strSQL.AppendLine("GROUP BY TIPO_COSECHA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            While dr.Read()
                diccDetalle = New Dictionary(Of String, Decimal)
                diccDetalle.Add("TC", dr(1))
                diccDetalle.Add("LBS_85", dr(2))
                diccDetalle.Add("LBS_REAL", dr(3))
                diccMaestro.Add(dr(0), diccDetalle)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return diccMaestro

    End Function


    Public Function ObtenerEJECUCION_TRANSPORTE(ByVal ID_ZAFRA As Int32) As Dictionary(Of String, Dictionary(Of String, Decimal))

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter
        Dim diccMaestro As New Dictionary(Of String, Dictionary(Of String, Decimal))
        Dim diccDetalle As New Dictionary(Of String, Decimal)


        strSQL.AppendLine(" SELECT TIPO_COSECHA, ISNULL(SUM(NETOTONEL),0) AS NETOTONEL, ISNULL(SUM(AZUCAR_CALC2),0) AS AZUCAR_CALC2, ISNULL(SUM(AZUCAR_CATORCENA_REAL),0) AS AZUCAR_CATORCENA_REAL ")
        strSQL.AppendLine(" FROM(")
        strSQL.AppendLine("	SELECT ")
        strSQL.AppendLine("		CASE TT.ID_TIPOTRANS")
        strSQL.AppendLine("			WHEN 19 THEN 'CAMION' ")
        strSQL.AppendLine("			WHEN 20 THEN 'RASTRA'")
        strSQL.AppendLine("			WHEN 21 THEN '3 EJES'")
        strSQL.AppendLine("			ELSE NULL ")
        strSQL.AppendLine("		END AS TIPO_COSECHA,		")
        strSQL.AppendLine("		B.NETOTONEL, A.AZUCAR_CALC2, ISNULL(A.AZUCAR_CATORCENA_REAL,A.AZUCAR_CALC2) AS AZUCAR_CATORCENA_REAL ")
        strSQL.AppendLine("	FROM ENVIO E, BASCULA B, ANALISIS A, TIPO_TRANSPORTE TT")
        strSQL.AppendLine("	WHERE E.ID_ENVIO = B.ID_ENVIO")
        strSQL.AppendLine("	AND E.ID_ENVIO = A.ID_ENVIO")
        strSQL.AppendLine("	AND E.ID_TIPOTRANS = TT.ID_TIPOTRANS")
        strSQL.AppendLine("	AND NOT B.NETOTONEL IS NULL	AND NOT A.POL IS NULL	")
        strSQL.AppendLine("	AND E.ID_ZAFRA = @ID_ZAFRA")
        strSQL.AppendLine(" ) AS T")
        strSQL.AppendLine(" GROUP BY TIPO_COSECHA")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            While dr.Read()
                diccDetalle = New Dictionary(Of String, Decimal)
                diccDetalle.Add("TC", dr(1))
                diccDetalle.Add("LBS_85", dr(2))
                diccDetalle.Add("LBS_REAL", dr(3))
                diccMaestro.Add(dr(0), diccDetalle)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return diccMaestro

    End Function


    Public Function ObtenerListaPorCONTRATO_ZAFRA(ByVal CODICONTRATO As String, ByVal ID_ZAFRA As Int32) As listaESTICANA

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM ESTICANA LC ")
        strSQL.Append("WHERE LC.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.CODICONTRATO = @CODICONTRATO) ")

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@CODICONTRATO", SqlDbType.VarChar)
        arg.Value = CODICONTRATO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaESTICANA

        Try
            Do While dr.Read()
                Dim mEntidad As New ESTICANA
                dbAsignarEntidades.AsignarESTICANA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaIngresoInventario(ByVal ID_ZAFRA As Int32,
                                             ByVal ZONA As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal NOMBRE_PROVEEDOR As String) As listaESTICANA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM ESTICANA LC ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "LC.ID_ZAFRA = @ID_ZAFRA")
        End If
        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.ZONA = @ZONA) ")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE)")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO)")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = LC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND ISNULL(RTRIM(P.NOMBRES),'') + ' ' + ISNULL(RTRIM(P.APELLIDOS),'') LIKE @NOMBRE_PROVEEDOR)")
        End If

        AgregarCondicion(strCond, "LC.FIN_LOTE = 0")
        AgregarCondicion(strCond, "(SELECT COUNT(1) FROM PLAN_COSECHA P WHERE P.ID_ZAFRA = LC.ID_ZAFRA AND P.ACCESLOTE = LC.ACCESLOTE AND P.CUOTA_DIARIA > 0) > 0")

        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaESTICANA

        Try
            Do While dr.Read()
                Dim mEntidad As New ESTICANA
                dbAsignarEntidades.AsignarESTICANA(dr, mEntidad)
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
