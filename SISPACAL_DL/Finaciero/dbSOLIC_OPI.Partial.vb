Partial Public Class dbSOLIC_OPI

    Public Function ObtenerNoOPIPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NUM_OPI_ZAFRA),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM SOLIC_OPI ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA AND NUM_OPI_ZAFRA <> 49")

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

    Public Function ObtenerNoOPIPorZafraProveedor(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NUM_OPI_ZAFRA),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM SOLIC_OPI ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA AND CODIPROVEEDOR = @CODIPROVEEDOR ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
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
                                             ByVal CORR_OPI As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal FECHA As DateTime) As listaSOLIC_OPI
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_OPI S ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "S.ID_ZAFRA = @ID_ZAFRA")
        End If
        If CORR_OPI <> -1 Then
            arg = New SqlParameter("@CORR_OPI", SqlDbType.Int)
            arg.Value = CORR_OPI
            args.Add(arg)
            AgregarCondicion(strCond, "S.CORR_OPI = @CORR_OPI")
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
        If FECHA <> Nothing Then
            arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
            arg.Value = FECHA
            args.Add(arg)
            AgregarCondicion(strCond, "S.FECHA = @FECHA")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY S.FECHA ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaSOLIC_OPI

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_OPI
                dbAsignarEntidades.AsignarSOLIC_OPI(dr, mEntidad)
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
