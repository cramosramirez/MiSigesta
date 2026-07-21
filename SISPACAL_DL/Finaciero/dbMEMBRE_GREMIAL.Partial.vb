Partial Public Class dbMEMBRE_GREMIAL

    Public Function ObtenerNoMembresiaPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NUM_MEMBRE_GREMIAL),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM MEMBRE_GREMIAL ")
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


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_MEMBRE_GREMIAL As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal FECHA As DateTime) As listaMEMBRE_GREMIAL
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM MEMBRE_GREMIAL M ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "M.ID_ZAFRA = @ID_ZAFRA")
        End If
        If NUM_MEMBRE_GREMIAL <> -1 Then
            arg = New SqlParameter("@NUM_MEMBRE_GREMIAL", SqlDbType.Int)
            arg.Value = NUM_MEMBRE_GREMIAL
            args.Add(arg)
            AgregarCondicion(strCond, "M.NUM_MEMBRE_GREMIAL = @NUM_MEMBRE_GREMIAL")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE) ")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO) ")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.Char)
            arg.Value = NOMBRE_PROVEEDOR.ToUpper.Replace(" ", "%")
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND RTRIM(ISNULL(P.NOMBRES,'')) + ' ' + RTRIM(ISNULL(P.APELLIDOS,'')) LIKE '%' + @NOMBRE_PROVEEDOR + '%') ")
        End If
        If FECHA <> Nothing Then
            arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
            arg.Value = FECHA
            args.Add(arg)
            AgregarCondicion(strCond, "M.FECHA = @FECHA")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY M.FECHA ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaMEMBRE_GREMIAL

        Try
            Do While dr.Read()
                Dim mEntidad As New MEMBRE_GREMIAL
                dbAsignarEntidades.AsignarMEMBRE_GREMIAL(dr, mEntidad)
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
