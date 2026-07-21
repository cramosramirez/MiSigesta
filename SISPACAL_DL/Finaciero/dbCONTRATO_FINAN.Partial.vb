Partial Public Class dbCONTRATO_FINAN

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_PROVEEDOR(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String) As listaCONTRATO_FINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT CF.* FROM CONTRATO_FINAN CF ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "CF.ID_ZAFRA = @ID_ZAFRA")
        End If
        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.Char)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM CONTRATO C WHERE C.CODIPROVEEDOR = @CODIPROVEEDOR AND C.CODICONTRATO = CF.CODICONTRATO)")
        End If
        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY CF.CODICONTRATO")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCONTRATO_FINAN

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_FINAN
                dbAsignarEntidades.AsignarCONTRATO_FINAN(dr, mEntidad)
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
    Public Function ObtenerPorZAFRA_CONTRATO(ByVal ID_ZAFRA As Int32, ByVal CODICONTRATO As String) As CONTRATO_FINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT CF.* FROM CONTRATO_FINAN CF ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "CF.ID_ZAFRA = @ID_ZAFRA")
        End If
        If CODICONTRATO <> "" Then
            arg = New SqlParameter("@CODICONTRATO", SqlDbType.Char)
            arg.Value = CODICONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "CF.CODICONTRATO = @CODICONTRATO")
        End If
        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim mEntidad As New CONTRATO_FINAN

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCONTRATO_FINAN(dr, mEntidad)
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
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_PROVEEDOR As String) As listaCONTRATO_FINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT CF.* FROM CONTRATO_FINAN CF ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "CF.ID_ZAFRA = @ID_ZAFRA")
        End If
        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.Char)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM CONTRATO C WHERE C.CODICONTRATO = CF.CODICONTRATO AND C.CODIPROVEEDOR = @CODIPROVEEDOR)")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = NOMBRE_PROVEEDOR
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM CONTRATO C, PROVEEDOR P WHERE C.CODICONTRATO = CF.CODICONTRATO AND C.CODIPROVEEDOR = P.CODIPROVEEDOR AND RTRIM(ISNULL(P.NOMBRES,'')) + ' ' + RTRIM(ISNULL(P.APELLIDOS,'')) LIKE '%' + @NOMBRE_PROVEEDOR + '%' )")
        End If
        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY CF.CODICONTRATO")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCONTRATO_FINAN

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_FINAN
                dbAsignarEntidades.AsignarCONTRATO_FINAN(dr, mEntidad)
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
