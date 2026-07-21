Partial Public Class dbSOLIC_AGRICOLA

    Public Function ObtenerNoSolicitudPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NUM_SOLICITUD),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM SOLIC_AGRICOLA ")
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


    Public Function ObtenerPorUID(ByVal UID_SOLIC_AGRICOLA As Guid) As SOLIC_AGRICOLA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_AGRICOLA))
        strSQL.Append(" WHERE UID_SOLIC_AGRICOLA = @UID_SOLIC_AGRICOLA ")


        arg = New SqlParameter("@UID_SOLIC_AGRICOLA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_SOLIC_AGRICOLA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New SOLIC_AGRICOLA

        Try
            If dr.Read Then
                dbAsignarEntidades.AsignarSOLIC_AGRICOLA(dr, mEntidad)
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


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_SOLICITUD As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NOMBLOTE As String, _
                                             ByVal FECHA_SOLICITUD As DateTime, _
                                             ByVal FECHA_APLICA As DateTime, _
                                             ByVal CODIAGRON As String) As listaSOLIC_AGRICOLA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_AGRICOLA S ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "S.ID_ZAFRA = @ID_ZAFRA")
        End If
        If NUM_SOLICITUD <> -1 Then
            arg = New SqlParameter("@NUM_SOLICITUD", SqlDbType.Int)
            arg.Value = NUM_SOLICITUD
            args.Add(arg)
            AgregarCondicion(strCond, "S.NUM_SOLICITUD = @NUM_SOLICITUD")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = S.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE) ")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = S.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO) ")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.Char)
            arg.Value = NOMBRE_PROVEEDOR.ToUpper.Replace(" ", "%")
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = S.CODIPROVEEDOR AND RTRIM(ISNULL(P.NOMBRES,'')) + ' ' + RTRIM(ISNULL(P.APELLIDOS,'')) LIKE '%' + @NOMBRE_PROVEEDOR + '%') ")
        End If
        If NOMBLOTE <> "" Then
            arg = New SqlParameter("@NOMBLOTE", SqlDbType.Char)
            arg.Value = NOMBLOTE.ToUpper.Replace(" ", "%")
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L, SOLIC_AGRICOLA_LOTE SL WHERE SL.ID_SOLICITUD = S.ID_SOLICITUD AND L.ACCESLOTE = SL.ACCESLOTE AND L.NOMBLOTE LIKE '%' + @NOMBLOTE + '%')")
        End If
        If FECHA_SOLICITUD <> Nothing Then
            arg = New SqlParameter("@FECHA_SOLIC", SqlDbType.DateTime)
            arg.Value = FECHA_SOLICITUD
            args.Add(arg)
            AgregarCondicion(strCond, "S.FECHA_SOLIC = @FECHA_SOLIC")
        End If
        If FECHA_APLICA <> Nothing Then
            arg = New SqlParameter("@FECHA_APLICA", SqlDbType.DateTime)
            arg.Value = FECHA_APLICA
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM SOLIC_APLICA_LOTE A WHERE A.ID_SOLICITUD = S.ID_SOLICITUD AND A.FECHA_APLICA = @FECHA_APLICA)")
        End If
        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Int)
            arg.Value = CODIAGRON
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM SOLIC_AGRICOLA_LOTE SL, LOTES_COSECHA LC WHERE S.ID_SOLICITUD = SL.ID_SOLICITUD AND SL.ACCESLOTE = LC.ACCESLOTE AND LC.ID_ZAFRA = SL.ID_ZAFRA AND LC.CODIAGRON = @CODIAGRON) ")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY S.FECHA_SOLIC ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaSOLIC_AGRICOLA

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_AGRICOLA
                dbAsignarEntidades.AsignarSOLIC_AGRICOLA(dr, mEntidad)
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
