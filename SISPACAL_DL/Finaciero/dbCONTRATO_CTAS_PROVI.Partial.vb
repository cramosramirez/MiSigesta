Partial Public Class dbCONTRATO_CTAS_PROVI

    Public Function ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(ByVal ID_CUENTA_FINAN As Int32, ByVal UID_SOLICITUD As Guid) As CONTRATO_CTAS_PROVI
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_CTAS_PROVI))
        strSQL.Append(" WHERE ID_CUENTA_FINAN = @ID_CUENTA_FINAN AND UID_SOLICITUD = @UID_SOLICITUD ")


        arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
        arg.Value = ID_CUENTA_FINAN
        args.Add(arg)

        arg = New SqlParameter("@UID_SOLICITUD", SqlDbType.UniqueIdentifier)
        arg.Value = UID_SOLICITUD
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New CONTRATO_CTAS_PROVI

        Try
            If dr.Read Then
                dbAsignarEntidades.AsignarCONTRATO_CTAS_PROVI(dr, mEntidad)
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

    Public Function ObtenerListaPorUID(ByVal UID_SOLICITUD As Guid) As listaCONTRATO_CTAS_PROVI
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_CTAS_PROVI))
        strSQL.Append(" WHERE UID_SOLICITUD = @UID_SOLICITUD ")


        arg = New SqlParameter("@UID_SOLICITUD", SqlDbType.UniqueIdentifier)
        arg.Value = UID_SOLICITUD
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCONTRATO_CTAS_PROVI

        Try
            While dr.Read
                Dim mEntidad As New CONTRATO_CTAS_PROVI
                dbAsignarEntidades.AsignarCONTRATO_CTAS_PROVI(dr, mEntidad)
                lista.Add(mEntidad)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal TIPO_CONTRIBUYENTE As Int32, ByVal CODIPROVEEDOR As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, ByVal ID_CUENTA_FINAN As Int32) As listaCONTRATO_CTAS_PROVI
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT CP.* FROM CONTRATO_CTAS_PROVI CP, SOLIC_AGRICOLA S ")

        AgregarCondicion(strCond, "CP.UID_SOLICITUD = S.UID_SOLIC_AGRICOLA")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "CP.ID_ZAFRA = @ID_ZAFRA")
        End If
        If TIPO_CONTRIBUYENTE <> -1 Then
            arg = New SqlParameter("@TIPO_CONTRIBUYENTE", SqlDbType.Int)
            arg.Value = TIPO_CONTRIBUYENTE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE S.CODIPROVEEDOR = P.CODIPROVEEDOR AND P.TIPO_CONTRIBUYENTE = @TIPO_CONTRIBUYENTE)")
        End If
        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.Char)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            AgregarCondicion(strCond, "S.CODIPROVEEDOR = @CODIPROVEEDOR)")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE S.CODIPROVEEDOR = P.CODIPROVEEDOR AND ISNULL(RTRIM(P.NOMBRES),'') + ' ' + ISNULL(RTRIM(P.APELLIDOS),'') LIKE @NOMBRE_PROVEEDOR)")
        End If
        If ID_CUENTA_FINAN <> -1 Then
            arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
            arg.Value = ID_CUENTA_FINAN
            args.Add(arg)
            AgregarCondicion(strCond, "CP.ID_CUENTA_FINAN = @ID_CUENTA_FINAN")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY S.CODIPROVEEDOR ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCONTRATO_CTAS_PROVI

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_CTAS_PROVI
                dbAsignarEntidades.AsignarCONTRATO_CTAS_PROVI(dr, mEntidad)
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
