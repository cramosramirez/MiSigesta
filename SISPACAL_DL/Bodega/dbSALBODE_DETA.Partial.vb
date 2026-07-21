Partial Public Class dbSALBODE_DETA


    Public Function ObtenerListaPRODUCTOS_SOLIC_CONSIGNACION(ByVal ID_ZAFRA As Int32, _
                                                     ByVal FECHA_INI As String, _
                                                     ByVal FECHA_FIN As String, _
                                                     ByVal NUM_SOLICITUD As Int32, _
                                                     ByVal NUM_SALBODE As Int32, _
                                                     ByVal CODIPROVEEDOR As String, _
                                                     ByVal ID_PROVEE As Int32, _
                                                     ByVal ID_CUENTA_FINAN As Int32, _
                                                     ByVal ID_ESTADO As Int32) As listaSALBODE_DETA
        Dim lResult As Int32 = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@FECHA_INI", SqlDbType.DateTime)
        If String.IsNullOrEmpty(FECHA_INI) Then arg.Value = Nothing Else arg.Value = New DateTime(Strings.Right(FECHA_INI, 4), FECHA_INI.Substring(3, 2), Strings.Left(FECHA_INI, 2))
        args.Add(arg)

        arg = New SqlParameter("@FECHA_FIN", SqlDbType.DateTime)
        If String.IsNullOrEmpty(FECHA_FIN) Then arg.Value = Nothing Else arg.Value = New DateTime(Strings.Right(FECHA_FIN, 4), FECHA_FIN.Substring(3, 2), Strings.Left(FECHA_FIN, 2))
        args.Add(arg)

        arg = New SqlParameter("@NUM_SOLICITUD", SqlDbType.Int)
        arg.Value = NUM_SOLICITUD
        args.Add(arg)

        arg = New SqlParameter("@NUM_SALBODE", SqlDbType.Int)
        arg.Value = NUM_SALBODE
        args.Add(arg)

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = IIf(String.IsNullOrEmpty(CODIPROVEEDOR), "", CODIPROVEEDOR)
        args.Add(arg)

        arg = New SqlParameter("@ID_PROVEE", SqlDbType.Int)
        arg.Value = ID_PROVEE
        args.Add(arg)

        arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
        arg.Value = ID_CUENTA_FINAN
        args.Add(arg)

        arg = New SqlParameter("@ID_ESTADO", SqlDbType.Int)
        arg.Value = ID_ESTADO
        args.Add(arg)


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "PRODUCTOS_SOLIC_CONSIGNACION", args.ToArray)


        Dim lista As New listaSALBODE_DETA

        Try
            Do While dr.Read()
                Dim mEntidad As New SALBODE_DETA
                dbAsignarEntidades.AsignarSALBODE_DETA(dr, mEntidad)
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
