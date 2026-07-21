Partial Public Class dbCREDITO_ENCA

    Public Function ObtenerListaPorUID_REFERENCIA(ByVal UID_REFERENCIA As Guid) As listaCREDITO_ENCA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM CREDITO_ENCA E ")
        strSQL.Append("WHERE UID_REFERENCIA = @UID_REFERENCIA ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCREDITO_ENCA

        Try
            While dr.Read
                Dim mEntidad As New CREDITO_ENCA
                dbAsignarEntidades.AsignarCREDITO_ENCA(dr, mEntidad)
                lista.Add(mEntidad)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function PROC_Actualizar_Intereses_Productores(ByVal CODIPROVEEDOR As String, _
                                                          ByVal ID_CREDITO_ENCA As Int32) As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@ID_CREDITO_ENCA", SqlDbType.Int)
        arg.Value = ID_CREDITO_ENCA
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "ACTUALIZAR_INTERES_PRODUCTORES", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function fObtenerPlazoInteres(ByVal ID_CREDITO_ENCA As Int32, ByVal FECHA As DateTime) As Int32
        Dim lResult As Int32 = 0
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_CREDITO_ENCA", SqlDbType.Int)
        arg.Value = ID_CREDITO_ENCA
        args.Add(arg)

        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, "SELECT dbo.fObtenerPlazoInteres(@ID_CREDITO_ENCA, @FECHA) AS DIAS_PLAZO", args.ToArray)
            Return lResult

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
