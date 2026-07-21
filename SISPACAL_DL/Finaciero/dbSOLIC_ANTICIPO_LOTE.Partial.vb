Partial Public Class dbSOLIC_ANTICIPO_LOTE

    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String) As listaSOLIC_ANTICIPO_LOTE
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


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim listaSolic As New listaSOLIC_ANTICIPO_LOTE
        Dim lZafra As New ZAFRA
        Dim bZafra As New dbZAFRA
        Dim i As Int32 = 1
        lZafra.ID_ZAFRA = ID_ZAFRA
        bZafra.Recuperar(lZafra)

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_ANTICIPO_LOTE
                mEntidad.ID_SOLI_LOTE = i
                mEntidad.ID_ANTICIPO = 0
                mEntidad.ID_ZAFRA = ID_ZAFRA
                mEntidad.MZ = dr("MZ_CENSO")
                mEntidad.TONEL_ESTI = dr("TONEL_CENSO")
                mEntidad.ACCESLOTE = dr("ACCESLOTE").ToString
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
