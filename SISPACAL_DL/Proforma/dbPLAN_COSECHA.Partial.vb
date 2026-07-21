Partial Public Class dbPLAN_COSECHA


    Public Function EsEntregaProgramada(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String, _
                                             ByVal FECHA As DateTime) As Boolean
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Boolean = False

        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PLAN_COSECHA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("AND ACCESLOTE = @ACCESLOTE ")
        strSQL.Append("AND FECHA_INI_COSECHA <= @FECHA ")


        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        arg.Value = ACCESLOTE
        args.Add(arg)

        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaPLAN_COSECHA

        Try
            If dr.Read() Then
                lRet = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function


    Public Function ObtenerUltimaCatorcenaPropuesta(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(CATORCENA),0) AS CATORCENA ")
        strSQL.Append("FROM PLAN_COSECHA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")


        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                lRet = dr(0)
            Else
                lRet = -1
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal SUB_ZONA As String, _
                                             ByVal CATORCENA As Int32, _
                                             ByVal SEMANA As Int32, _
                                             ByVal FECHA_INI As Object, _
                                             ByVal FECHA_FIN As Object, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal CODIAGRON As String, _
                                             ByVal TIPOS_TRANSPORTE As String, _
                                             ByVal CON_SALDO_ROZA As Boolean, _
                                             ByVal FIN_LOTE As Int32, _
                                             Optional CON_CUOTA_DIARIA As Boolean = False) As listaPLAN_COSECHA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM ( ")
        strSQL.Append("     SELECT ")
        strSQL.Append("     CASE ")
        strSQL.Append("         WHEN PC.QUEMA_NO_PROGRAMADA = 1 THEN PC.FECHA_QUEMA_NOPROG ")
        strSQL.Append("         WHEN PC.QUEMA_PROGRAMADA = 1 THEN PC.FECHA_REAL_QUEMA ")
        strSQL.Append("         ELSE NULL ")
        strSQL.Append("         END AS FECHA_QUEMA, ")
        strSQL.Append("     PC.* FROM PLAN_COSECHA PC ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "PC.ID_ZAFRA = @ID_ZAFRA")
        End If
        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.ZONA = @ZONA) ")
        End If
        If CATORCENA <> -1 Then
            arg = New SqlParameter("@CATORCENA", SqlDbType.Int)
            arg.Value = CATORCENA
            args.Add(arg)
            AgregarCondicion(strCond, "PC.CATORCENA = @CATORCENA")
        End If
        If SEMANA <> -1 Then
            arg = New SqlParameter("@SEMANA", SqlDbType.Int)
            arg.Value = SEMANA
            args.Add(arg)
            AgregarCondicion(strCond, "PC.SEMANA = @SEMANA")
        End If
        If CON_CUOTA_DIARIA Then
            AgregarCondicion(strCond, "PC.CUOTA_DIARIA > 0")
        End If
        If SUB_ZONA <> "" Then
            arg = New SqlParameter("@SUB_ZONA", SqlDbType.Char)
            arg.Value = SUB_ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.SUB_ZONA = @SUB_ZONA) ")
        End If


        If TIPOS_TRANSPORTE <> "" Then
            Dim listaTIPOS_TRANS As String() = TIPOS_TRANSPORTE.Split(";")
            Dim strIN As New StringBuilder
            If listaTIPOS_TRANS.Length = 1 Then
                strIN.Append("PC.ID_TIPOTRANS = @ID_TIPOTRANS")
                Dim op As SqlParameter = New SqlParameter("@ID_TIPOTRANS", SqlDbType.Int)
                op.Value = listaTIPOS_TRANS(0)
                args.Add(op)
            Else
                For i As Integer = 0 To listaTIPOS_TRANS.Length - 1
                    If i = 0 Then
                        strIN.Append(" PC.ID_TIPOTRANS IN(") : strIN.Append(listaTIPOS_TRANS(i).ToString)
                    Else
                        strIN.Append(",") : strIN.Append(listaTIPOS_TRANS(i).ToString)
                    End If
                Next
                strIN.Append(") ")
            End If
            AgregarCondicion(strCond, strIN.ToString)
        End If
        If FECHA_INI <> #12:00:00 AM# AndAlso FECHA_FIN <> #12:00:00 AM# Then
            arg = New SqlParameter("@FECHA_INI_COSECHA", SqlDbType.DateTime)
            arg.Value = CDate(FECHA_INI)
            args.Add(arg)
            arg = New SqlParameter("@FECHA_FIN_COSECHA", SqlDbType.DateTime)
            arg.Value = CDate(FECHA_FIN)
            args.Add(arg)
            AgregarCondicion(strCond, "PC.FECHA_INI_COSECHA >= @FECHA_INI_COSECHA AND PC.FECHA_FIN_COSECHA <= @FECHA_FIN_COSECHA")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE)")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO)")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND ISNULL(RTRIM(P.NOMBRES),'') + ' ' + ISNULL(RTRIM(P.APELLIDOS),'') LIKE @NOMBRE_PROVEEDOR)")
        End If
        If NO_CONTRATO <> -1 Then
            arg = New SqlParameter("@NO_CONTRATO", SqlDbType.Int)
            arg.Value = NO_CONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, CONTRATO C WHERE L.CODICONTRATO = C.CODICONTRATO AND C.NO_CONTRATO = @NO_CONTRATO)")
        End If
        If FIN_LOTE <> -1 Then
            arg = New SqlParameter("@FIN_LOTE", SqlDbType.Bit)
            arg.Value = FIN_LOTE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = PC.ACCESLOTE AND LC.ID_ZAFRA = PC.ID_ZAFRA AND LC.FIN_LOTE = @FIN_LOTE) ")
        End If
        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Char)
            arg.Value = CODIAGRON
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = PC.ACCESLOTE AND LC.ID_ZAFRA = PC.ID_ZAFRA AND LC.CODIAGRON = @CODIAGRON) ")
        End If
        If CON_SALDO_ROZA Then
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = PC.ACCESLOTE AND LC.ID_ZAFRA = PC.ID_ZAFRA AND LC.SALDO_ROZA > 0) ")
        End If


        strSQL.Append(strCond.ToString)
        strSQL.Append(") T ")

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaPLAN_COSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLAN_COSECHA
                dbAsignarEntidades.AsignarPLAN_COSECHA(dr, mEntidad)
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
    Public Function ObtenerListaParaProforma(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal SUB_ZONA As String, _
                                             ByVal CATORCENA As Int32, _
                                             ByVal SEMANA As Int32, _
                                             ByVal FECHA_INI As Object, _
                                             ByVal FECHA_FIN As Object, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal CODIAGRON As String, _
                                             ByVal TIPOS_TRANSPORTE As String, _
                                             ByVal CON_SALDO_ROZA As Boolean, _
                                             ByVal FIN_LOTE As Int32, _
                                             ByVal FECHA_PROFORMA As DateTime) As listaPLAN_COSECHA
        Dim listaVal As New List(Of String)
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM ( ")
        strSQL.Append("     SELECT ")
        strSQL.Append("     CASE ")
        strSQL.Append("         WHEN PC.QUEMA_NO_PROGRAMADA = 1 THEN PC.FECHA_QUEMA_NOPROG ")
        strSQL.Append("         WHEN PC.QUEMA_PROGRAMADA = 1 THEN PC.FECHA_REAL_QUEMA ")
        strSQL.Append("         ELSE NULL ")
        strSQL.Append("         END AS FECHA_QUEMA, ")
        strSQL.Append("     PC.* FROM PLAN_COSECHA PC ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "PC.ID_ZAFRA = @ID_ZAFRA")
        End If
        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.ZONA = @ZONA) ")
        End If
        If CATORCENA <> -1 Then
            arg = New SqlParameter("@CATORCENA", SqlDbType.Int)
            arg.Value = CATORCENA
            args.Add(arg)
            AgregarCondicion(strCond, "PC.CATORCENA = @CATORCENA")
        End If
        If SEMANA <> -1 Then
            arg = New SqlParameter("@SEMANA", SqlDbType.Int)
            arg.Value = SEMANA
            args.Add(arg)
            AgregarCondicion(strCond, "PC.SEMANA = @SEMANA")
        End If
        If SUB_ZONA <> "" Then
            arg = New SqlParameter("@SUB_ZONA", SqlDbType.Char)
            arg.Value = SUB_ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.SUB_ZONA = @SUB_ZONA) ")
        End If

        If TIPOS_TRANSPORTE <> "" Then
            Dim listaTIPOS_TRANS As String() = TIPOS_TRANSPORTE.Split(";")
            Dim strIN As New StringBuilder
            If listaTIPOS_TRANS.Length = 1 Then
                strIN.Append("PC.ID_TIPOTRANS = @ID_TIPOTRANS")
                Dim op As SqlParameter = New SqlParameter("@ID_TIPOTRANS", SqlDbType.Int)
                op.Value = listaTIPOS_TRANS(0)
                args.Add(op)
            Else
                For i As Integer = 0 To listaTIPOS_TRANS.Length - 1
                    If i = 0 Then
                        strIN.Append(" PC.ID_TIPOTRANS IN(") : strIN.Append(listaTIPOS_TRANS(i).ToString)
                    Else
                        strIN.Append(",") : strIN.Append(listaTIPOS_TRANS(i).ToString)
                    End If
                Next
                strIN.Append(") ")
            End If
            AgregarCondicion(strCond, strIN.ToString)
        End If
        If FECHA_INI <> #12:00:00 AM# AndAlso FECHA_FIN <> #12:00:00 AM# Then
            arg = New SqlParameter("@FECHA_INI_COSECHA", SqlDbType.DateTime)
            arg.Value = CDate(FECHA_INI)
            args.Add(arg)
            arg = New SqlParameter("@FECHA_FIN_COSECHA", SqlDbType.DateTime)
            arg.Value = CDate(FECHA_FIN)
            args.Add(arg)
            AgregarCondicion(strCond, "PC.FECHA_INI_COSECHA >= @FECHA_INI_COSECHA AND PC.FECHA_FIN_COSECHA <= @FECHA_FIN_COSECHA")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE)")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO)")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, PROVEEDOR P WHERE L.ACCESLOTE = PC.ACCESLOTE AND L.CODIPROVEEDOR = P.CODIPROVEEDOR AND ISNULL(RTRIM(P.NOMBRES),'') + ' ' + ISNULL(RTRIM(P.APELLIDOS),'') LIKE @NOMBRE_PROVEEDOR)")
        End If
        If NO_CONTRATO <> -1 Then
            arg = New SqlParameter("@NO_CONTRATO", SqlDbType.Int)
            arg.Value = NO_CONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, CONTRATO C WHERE L.CODICONTRATO = C.CODICONTRATO AND C.NO_CONTRATO = @NO_CONTRATO)")
        End If
        If FIN_LOTE <> -1 Then
            arg = New SqlParameter("@FIN_LOTE", SqlDbType.Bit)
            arg.Value = FIN_LOTE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = PC.ACCESLOTE AND LC.ID_ZAFRA = PC.ID_ZAFRA AND LC.FIN_LOTE = @FIN_LOTE) ")
        End If
        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Char)
            arg.Value = CODIAGRON
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = PC.ACCESLOTE AND LC.ID_ZAFRA = PC.ID_ZAFRA AND LC.CODIAGRON = @CODIAGRON) ")
        End If
        If CON_SALDO_ROZA Then
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = PC.ACCESLOTE AND LC.ID_ZAFRA = PC.ID_ZAFRA AND LC.SALDO_ROZA > 0) ")
        End If
        'If FECHA_PROFORMA <> #12:00:00 AM# Then
        '    arg = New SqlParameter("@FECHA_PROFORMA", SqlDbType.DateTime)
        '    arg.Value = FECHA_PROFORMA
        '    args.Add(arg)
        '    AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PLAN_COSECHA_DIARIO PD, (SELECT PDC.ID_PLAN_COSECHA_DIARIO, (SELECT MAX(CATORCENA) AS CATORCENA FROM PLAN_COSECHA CS WHERE CS.ID_ZAFRA = PDC.ID_ZAFRA AND CS.ACCESLOTE = PDC.ACCESLOTE) AS CATORCENA FROM PLAN_COSECHA_DIARIO PDC WHERE PDC.FECHA = @FECHA_PROFORMA) AS T WHERE PD.ID_PLAN_COSECHA_DIARIO = T.ID_PLAN_COSECHA_DIARIO AND T.CATORCENA = PC.CATORCENA AND PD.ACCESLOTE = PC.ACCESLOTE AND PD.ID_ZAFRA = PC.ID_ZAFRA AND PD.AUTORIZADO = 1 AND PD.FECHA = @FECHA_PROFORMA)")
        'End If


        strSQL.Append(strCond.ToString)
        strSQL.Append(") T ")

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaPLAN_COSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLAN_COSECHA
                dbAsignarEntidades.AsignarPLAN_COSECHA(dr, mEntidad)
                If Not listaVal.Contains(mEntidad.ID_ZAFRA.ToString + mEntidad.ACCESLOTE) Then
                    lista.Add(mEntidad)
                    listaVal.Add(mEntidad.ID_ZAFRA.ToString + mEntidad.ACCESLOTE)
                End If
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    Public Function GenerarPropuestaCosechaCatorcenal(ByVal ID_ZAFRA As Int32, ByVal CATORCENA As Int32, _
                                                      ByVal SEMANA As INT32, _
                                                      ByVal USUARIO_CREA As String, FECHA_CREA As DateTime) As Int32
        Dim lRet As Int32 = 0
        Dim args(4) As SqlParameter

        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@CATORCENA", SqlDbType.Int)
        args(1).Value = CATORCENA

        args(2) = New SqlParameter("@SEMANA", SqlDbType.Int)
        args(2).Value = SEMANA

        args(3) = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        args(3).Value = USUARIO_CREA

        args(4) = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        args(4).Value = FECHA_CREA

        Try
            SqlHelper.ExecuteNonQuery(Me.cnnStr, "GENERAR_PROPUESTA_COSECHA_CATORCENAL", args)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function


    Public Function EliminarProgramacionCosechaRepetidaLote(ByVal ID_ZAFRA As Int32, ByVal CATORCENA As Int32, ByVal ACCESLOTE As String) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@CATORCENA", SqlDbType.Int)
        arg.Value = CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char, 21)
        arg.Value = ACCESLOTE
        args.Add(arg)

        Try

            SqlHelper.ExecuteNonQuery(Me.cnnStr, "ELIMINAR_PROGRAMACION_COSECHA_POR_LOTE", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try

        Return 1
    End Function
End Class
