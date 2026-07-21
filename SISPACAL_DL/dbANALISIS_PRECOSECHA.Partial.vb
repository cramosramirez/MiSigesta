Partial Public Class dbANALISIS_PRECOSECHA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                                            ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, _
                                            ByVal NO_CONTRATO As Int32, ByVal CODIAGRON As String) As listaANALISIS_PRECOSECHA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT A.* ")
        strSQL.Append("FROM ANALISIS_PRECOSECHA A, LOTES L, CONTRATO C, CONTRATO_ZAFRAS CZ ")
        strSQL.Append("WHERE A.ACCESLOTE = L.ACCESLOTE ")
        strSQL.Append("AND L.CODICONTRATO = C.CODICONTRATO ")
        strSQL.Append("AND C.CODICONTRATO = CZ.CODICONTRATO ")
        strSQL.Append("AND CZ.ID_ZAFRA = A.ID_ZAFRA ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            strSQL.Append("AND A.ID_ZAFRA = @ID_ZAFRA ")
        End If
        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            strSQL.Append("AND L.ZONA = @ZONA ")
        End If
        If SUB_ZONA <> "" Then
            arg = New SqlParameter("@SUB_ZONA", SqlDbType.Char)
            arg.Value = SUB_ZONA
            args.Add(arg)
            strSQL.Append("AND L.SUB_ZONA = @SUB_ZONA ")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            strSQL.Append("AND EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = L.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE) ")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            strSQL.Append("AND EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = L.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO) ")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.Char)
            arg.Value = NOMBRE_PROVEEDOR.ToUpper
            args.Add(arg)
            strSQL.Append("AND EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = L.CODIPROVEEDOR AND RTRIM(ISNULL(P.NOMBRES,'')) + ' ' + RTRIM(ISNULL(P.APELLIDOS,'')) LIKE '%' + @NOMBRE_PROVEEDOR + '%') ")
        End If
        If NO_CONTRATO <> -1 Then
            arg = New SqlParameter("@NO_CONTRATO", SqlDbType.Int)
            arg.Value = NO_CONTRATO
            args.Add(arg)
            strSQL.Append("AND C.NO_CONTRATO = @NO_CONTRATO ")
        End If
        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Int)
            arg.Value = CODIAGRON
            args.Add(arg)
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = CZ.ID_ZAFRA AND LC.CODIAGRON = @CODIAGRON) ")
        End If

        strSQL.Append("ORDER BY A.FECHA_MUESTRA DESC")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaANALISIS_PRECOSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New ANALISIS_PRECOSECHA
                dbAsignarEntidades.AsignarANALISIS_PRECOSECHA(dr, mEntidad)
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
    Public Function ObtenerPorZAFRA_NO_ANALISIS(ByVal ID_ZAFRA As Int32, NO_ANALISIS As Int32) As ANALISIS_PRECOSECHA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM ANALISIS_PRECOSECHA ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, " ID_ZAFRA = @ID_ZAFRA ")
        End If
        If NO_ANALISIS <> -1 Then
            arg = New SqlParameter("@NO_ANALISIS", SqlDbType.Int)
            arg.Value = NO_ANALISIS
            args.Add(arg)
            AgregarCondicion(strCond, " NO_ANALISIS = @NO_ANALISIS ")
        End If
        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim mEntidad As New ANALISIS_PRECOSECHA

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarANALISIS_PRECOSECHA(dr, mEntidad)
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

    Public Function ObtenerNoAnalisisPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NO_ANALISIS),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM ANALISIS_PRECOSECHA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

    Public Function ObtenerNoMuestraPorZafraLote(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NO_MUESTRA),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM ANALISIS_PRECOSECHA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("AND ACCESLOTE = @ACCESLOTE ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        arg.Value = ACCESLOTE
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

End Class
