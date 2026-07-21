Partial Public Class dbCUENTA_PROVEEDOR

    Public Function ObtenerDataSetPorTipoProveedor(ByVal ID_TIPO_PROVEEDOR As Integer, ByVal CODIPROVEE As String, ByVal CODISOCIO As String) As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim tieneWhere As Boolean = False

        If ID_TIPO_PROVEEDOR <> -1 Then
            arg = New SqlParameter("@ID_TIPO_PROVEEDOR", SqlDbType.Int)
            arg.Value = ID_TIPO_PROVEEDOR
            args.Add(arg)
        End If

        Select Case ID_TIPO_PROVEEDOR
            Case Enumeradores.TipoProveedor.Cañero
                strSQL.Append("SELECT CODIPROVEEDOR AS CODIGO, RTRIM(ISNULL(NOMBRES,'')) + ' ' + RTRIM(ISNULL(APELLIDOS,'')) AS NOMBRE_COMPLETO, (SELECT CP.CUENTA FROM CUENTA_PROVEEDOR CP WHERE CP.ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR AND CP.CODIGO = PROVEEDOR.CODIPROVEEDOR) AS CUENTA FROM PROVEEDOR ")
                If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
                    arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
                    arg.Value = Utilerias.RellenarIzquierda(CODIPROVEE, 6)
                    args.Add(arg)
                    strSQL.Append("WHERE CODIPROVEE = @CODIPROVEE ")

                    If CODISOCIO IsNot Nothing AndAlso CODISOCIO <> "" Then
                        arg = New SqlParameter("@CODISOCIO", SqlDbType.VarChar)
                        arg.Value = Utilerias.RellenarIzquierda(CODISOCIO, 4)
                        args.Add(arg)
                        strSQL.Append("AND CODISOCIO = @CODISOCIO ")
                    End If
                End If

            Case Enumeradores.TipoProveedor.Transportista
                strSQL.Append("SELECT CODTRANSPORT AS CODIGO, RTRIM(ISNULL(NOMBRES,'')) + ' ' + RTRIM(ISNULL(APELLIDOS,'')) AS NOMBRE_COMPLETO, (SELECT CP.CUENTA FROM CUENTA_PROVEEDOR CP WHERE CP.ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR AND CP.CODIGO = TRANSPORTISTA.CODTRANSPORT) AS CUENTA FROM TRANSPORTISTA ")
                If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
                    arg = New SqlParameter("@CODIPROVEE", SqlDbType.Int)
                    arg.Value = CInt(CODIPROVEE)
                    args.Add(arg)
                    strSQL.Append("WHERE CODTRANSPORT = @CODIPROVEE ")
                End If

            Case Enumeradores.TipoProveedor.FrenteRoza
                strSQL.Append("SELECT CODIGO, LTRIM(REPLACE( REPLACE(NOMBRE_PROVEEDOR_ROZA,CODIGO,'') ,'-','')) AS NOMBRE_COMPLETO, (SELECT CP.CUENTA FROM CUENTA_PROVEEDOR CP WHERE CP.ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR AND CP.CODIGO = PROVEEDOR_ROZA.CODIGO) AS CUENTA FROM PROVEEDOR_ROZA ")
                If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
                    arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
                    arg.Value = CODIPROVEE
                    args.Add(arg)
                    strSQL.Append("WHERE CODIGO = @CODIPROVEE ")
                End If
            Case Enumeradores.TipoProveedor.Cargador
                strSQL.Append("SELECT CODIGO, NOMBRE_PROVEEDOR_CARGA AS NOMBRE_COMPLETO, (SELECT CP.CUENTA FROM CUENTA_PROVEEDOR CP WHERE CP.ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR AND CP.CODIGO = PROVEEDOR_CARGA.CODIGO) AS CUENTA FROM PROVEEDOR_CARGA ")
                If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
                    arg = New SqlParameter("@CODIPROVEE", SqlDbType.Int)
                    arg.Value = CInt(CODIPROVEE)
                    args.Add(arg)
                    strSQL.Append("WHERE CODIGO = @CODIPROVEE ")
                End If
            Case Enumeradores.TipoProveedor.FrenteQuerqueo
                strSQL.Append("SELECT CODISIS AS CODIGO, NOMBRES + ' ' + APELLIDOS AS NOMBRE_COMPLETO, (SELECT CP.CUENTA FROM CUENTA_PROVEEDOR CP WHERE CP.ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR AND CP.CODIGO = PROVEEDOR_QUERQUEO.CODISIS) AS CUENTA FROM PROVEEDOR_QUERQUEO ")
                If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
                    arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
                    arg.Value = CODIPROVEE
                    args.Add(arg)
                    strSQL.Append("WHERE CODISIS = @CODIPROVEE ")
                End If
        End Select

        strSQL.Append(strCondicion.ToString)

        Dim ds As DataSet

        If args.Count = 0 Then
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Try
            Return ds
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
