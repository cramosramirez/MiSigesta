Partial Public Class dbSOLIC_AGRICOLA_LOTE

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_AGRICOLA_LOTE

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT S.*, L.CODILOTE, L.NOMBLOTE, L.ZONA,")
        strSQL.Append(" (SELECT V.NOM_VARIEDAD FROM VARIEDAD V WHERE V.CODIVARIEDA = L.CODIVARIEDA) AS NOM_VARIEDAD, ")
        strSQL.Append(" (SELECT D.NOMBRE_DEPTO FROM MAESTRO_LOTES ML, DEPARTAMENTO D WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = D.CODI_DEPTO) AS NOMBRE_DEPTO, ")
        strSQL.Append(" (SELECT M.NOMBRE_MUNI FROM MAESTRO_LOTES ML, MUNICIPIO M WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = M.CODI_DEPTO AND ML.CODI_MUNI = M.CODI_MUNI) AS NOMBRE_MUNI, ")
        strSQL.Append(" (SELECT CA.NOMBRE_CANTON FROM MAESTRO_LOTES ML, CANTON CA WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = CA.CODI_DEPTO AND ML.CODI_MUNI = CA.CODI_MUNI AND ML.CODI_CANTON = CA.CODI_CANTON) AS NOMBRE_CANTON ")
        strSQL.Append(" FROM SOLIC_AGRICOLA_LOTE S, LOTES L")
        strSQL.Append(" WHERE S.ACCESLOTE = L.ACCESLOTE AND S.ID_SOLICITUD = @ID_SOLICITUD ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SOLICITUD", SqlDbType.Int)
        args(0).Value = ID_SOLICITUD

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_AGRICOLA_LOTE


        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_AGRICOLA_LOTE
                dbAsignarEntidades.AsignarSOLIC_AGRICOLA_LOTE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODICONTRATO As String, ByVal CODIAGRON As String) As listaSOLIC_AGRICOLA_LOTE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT L.ACCESLOTE, L.CODILOTE, L.NOMBLOTE, L.ZONA, ")
        strSQL.Append(" ISNULL((SELECT LC.MZ_CENSO FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = @ID_ZAFRA),L.AREA) AS MZ_CENSO, ")
        strSQL.Append(" L.CODIVARIEDA, ")
        strSQL.Append(" ISNULL((SELECT LC.TONEL_CENSO FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = @ID_ZAFRA),L.TONEL_TC) AS TONEL_CENSO, ")
        strSQL.Append(" (SELECT D.NOMBRE_DEPTO FROM MAESTRO_LOTES ML, DEPARTAMENTO D WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = D.CODI_DEPTO) AS NOMBRE_DEPTO, ")
        strSQL.Append(" (SELECT M.NOMBRE_MUNI FROM MAESTRO_LOTES ML, MUNICIPIO M WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = M.CODI_DEPTO AND ML.CODI_MUNI = M.CODI_MUNI) AS NOMBRE_MUNI, ")
        strSQL.Append(" (SELECT CA.NOMBRE_CANTON FROM MAESTRO_LOTES ML, CANTON CA WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = CA.CODI_DEPTO AND ML.CODI_MUNI = CA.CODI_MUNI AND ML.CODI_CANTON = CA.CODI_CANTON) AS NOMBRE_CANTON ")
        strSQL.Append(" FROM LOTES L, CONTRATO C, CONTRATO_ZAFRAS CZ ")
        strSQL.Append(" WHERE L.CODICONTRATO = C.CODICONTRATO ")
        strSQL.Append(" AND C.CODICONTRATO = CZ.CODICONTRATO ")


        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            strSQL.Append(" AND CZ.ID_ZAFRA = @ID_ZAFRA ")
        End If

        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.Char)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            strSQL.Append(" AND C.CODIPROVEEDOR = @CODIPROVEEDOR ")
        End If

        If CODICONTRATO <> "" Then
            arg = New SqlParameter("@CODICONTRATO", SqlDbType.Char)
            arg.Value = CODICONTRATO
            args.Add(arg)
            strSQL.Append(" AND C.CODICONTRATO = @CODICONTRATO ")
        End If

        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Char)
            arg.Value = CODIAGRON
            args.Add(arg)
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = CZ.ID_ZAFRA AND LC.CODIAGRON = @CODIAGRON) ")
        End If


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim listaSolic As New listaSOLIC_AGRICOLA_LOTE
        Dim lZafra As New ZAFRA
        Dim bZafra As New dbZAFRA
        Dim i As Int32 = 1
        lZafra.ID_ZAFRA = ID_ZAFRA
        bZafra.Recuperar(lZafra)

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_AGRICOLA_LOTE
                mEntidad.ID_SOLIC_AGRI_LOTE = i
                mEntidad.ID_SOLICITUD = 0
                mEntidad.ID_ZAFRA = ID_ZAFRA
                mEntidad.MZ = dr("MZ_CENSO")
                mEntidad.TONEL_ESTI = dr("TONEL_CENSO")
                mEntidad.RIEGO_APLICADO = False
                mEntidad.ZAFRA = lZafra.NOMBRE_ZAFRA
                mEntidad.ACCESLOTE = dr("ACCESLOTE").ToString
                mEntidad.CODIVARIEDA = dr("CODIVARIEDA")
                listaSolic.Add(mEntidad)
                i += 1
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return listaSolic

    End Function

    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODICONTRATO As String, ByVal CODIAGRON As String, ByVal ESTADO_LOTE As Integer) As listaSOLIC_AGRICOLA_LOTE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT L.ACCESLOTE, L.CODILOTE, L.NOMBLOTE, L.ZONA, ")
        strSQL.Append(" ISNULL((SELECT LC.MZ_CENSO FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = @ID_ZAFRA),L.AREA) AS MZ_CENSO, ")
        strSQL.Append(" L.CODIVARIEDA, ")
        strSQL.Append(" ISNULL((SELECT LC.TONEL_CENSO FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = @ID_ZAFRA),L.TONEL_TC) AS TONEL_CENSO, ")
        strSQL.Append(" (SELECT D.NOMBRE_DEPTO FROM MAESTRO_LOTES ML, DEPARTAMENTO D WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = D.CODI_DEPTO) AS NOMBRE_DEPTO, ")
        strSQL.Append(" (SELECT M.NOMBRE_MUNI FROM MAESTRO_LOTES ML, MUNICIPIO M WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = M.CODI_DEPTO AND ML.CODI_MUNI = M.CODI_MUNI) AS NOMBRE_MUNI, ")
        strSQL.Append(" (SELECT CA.NOMBRE_CANTON FROM MAESTRO_LOTES ML, CANTON CA WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = CA.CODI_DEPTO AND ML.CODI_MUNI = CA.CODI_MUNI AND ML.CODI_CANTON = CA.CODI_CANTON) AS NOMBRE_CANTON ")
        strSQL.Append(" FROM LOTES L, CONTRATO C, CONTRATO_ZAFRAS CZ ")
        strSQL.Append(" WHERE L.CODICONTRATO = C.CODICONTRATO ")
        strSQL.Append(" AND C.CODICONTRATO = CZ.CODICONTRATO ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            strSQL.Append(" AND CZ.ID_ZAFRA = @ID_ZAFRA ")
        End If

        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.Char)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            strSQL.Append(" AND C.CODIPROVEEDOR = @CODIPROVEEDOR ")
        End If

        If CODICONTRATO <> "" Then
            arg = New SqlParameter("@CODICONTRATO", SqlDbType.Char)
            arg.Value = CODICONTRATO
            args.Add(arg)
            strSQL.Append(" AND C.CODICONTRATO = @CODICONTRATO ")
        End If

        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Char)
            arg.Value = CODIAGRON
            args.Add(arg)
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = CZ.ID_ZAFRA AND LC.CODIAGRON = @CODIAGRON) ")
        End If

        If ESTADO_LOTE <> -1 Then
            arg = New SqlParameter("@ESTADO_LOTE", SqlDbType.Bit)
            arg.Value = IIf(ESTADO_LOTE = 1, True, False)
            args.Add(arg)
            strSQL.Append("AND (SELECT COUNT(1) FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = CZ.ID_ZAFRA AND LC.FIN_LOTE = @ESTADO_LOTE) > 0 ")
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim listaSolic As New listaSOLIC_AGRICOLA_LOTE
        Dim lZafra As New ZAFRA
        Dim bZafra As New dbZAFRA
        Dim i As Int32 = 1
        lZafra.ID_ZAFRA = ID_ZAFRA
        bZafra.Recuperar(lZafra)

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_AGRICOLA_LOTE
                mEntidad.ID_SOLIC_AGRI_LOTE = i
                mEntidad.ID_SOLICITUD = 0
                mEntidad.ID_ZAFRA = ID_ZAFRA
                mEntidad.MZ = dr("MZ_CENSO")
                mEntidad.TONEL_ESTI = dr("TONEL_CENSO")
                mEntidad.RIEGO_APLICADO = False
                mEntidad.ZAFRA = lZafra.NOMBRE_ZAFRA
                mEntidad.ACCESLOTE = dr("ACCESLOTE").ToString
                mEntidad.CODIVARIEDA = dr("CODIVARIEDA")
                listaSolic.Add(mEntidad)
                i += 1
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return listaSolic

    End Function
End Class
