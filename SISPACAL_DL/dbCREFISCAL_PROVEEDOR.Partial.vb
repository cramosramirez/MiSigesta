Partial Public Class dbCREFISCAL_PROVEEDOR

    Public Function ObtenerDatosUltimoCCF(ByVal CODIGO As String, ByVal ID_TIPO_PROVEEDOR As Integer) As DataSet
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@CODIGO", SqlDbType.VarChar)
        arg.Value = CODIGO
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PROVEEDOR", SqlDbType.Int)
        arg.Value = ID_TIPO_PROVEEDOR
        args.Add(arg)

        Dim ds As DataSet

        Try
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.StoredProcedure, "OBTENER_DATOS_CCF_ASOCIADO_CR", args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
End Class
