Partial Public Class dbSOLIC_ENCA_TRANS

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_SOLICITUD As Int32, _
                                             ByVal CODTRANSPORT As Int32, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal NOMBRE_TRANSPORTISTA As String) As listaSOLIC_ENCA_TRANS
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_ENCA_TRANS S ")

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
            AgregarCondicion(strCond, "S.NUM_SOLIC_ZAFRA = @NUM_SOLICITUD")
        End If
        If CODTRANSPORT <> -1 Then
            arg = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
            arg.Value = CODTRANSPORT
            args.Add(arg)
            AgregarCondicion(strCond, "S.CODTRANSPORT = @CODTRANSPORT")
        End If
        If NO_CONTRATO <> -1 Then
            arg = New SqlParameter("@NO_CONTRATO", SqlDbType.Int)
            arg.Value = NO_CONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "(SELECT COUNT(1) FROM CONTRATO_TRANS CT WHERE CT.ID_CONTRA_TRANS = S.ID_CONTRA_TRANS AND CT.ID_ZAFRA = S.ID_ZAFRA AND CT.NO_CONTRATO = @NO_CONTRATO) > 0")
        End If
        If NOMBRE_TRANSPORTISTA <> "" Then
            arg = New SqlParameter("@NOMBRE_TRANSPORTISTA", SqlDbType.Char)
            arg.Value = NOMBRE_TRANSPORTISTA.ToUpper.Replace(" ", "%")
            args.Add(arg)
            AgregarCondicion(strCond, "(SELECT COUNT(1) FROM TRANSPORTISTA P WHERE P.CODTRANSPORT = S.CODTRANSPORT AND RTRIM(ISNULL(P.NOMBRES,'')) + ' ' + RTRIM(ISNULL(P.APELLIDOS,'')) LIKE '%' + @NOMBRE_TRANSPORTISTA + '%') > 0")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY S.FECHA_SOLIC ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaSOLIC_ENCA_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_ENCA_TRANS
                dbAsignarEntidades.AsignarSOLIC_ENCA_TRANS(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerNoSolicPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NUM_SOLIC_ZAFRA),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM SOLIC_ENCA_TRANS ")
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

End Class
