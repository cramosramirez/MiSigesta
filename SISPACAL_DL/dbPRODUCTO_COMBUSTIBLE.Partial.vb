Partial Public Class dbPRODUCTO_COMBUSTIBLE
    Public Function ObtenerPorNOMBRE_PRODUCTO(ByVal NOMBRE_PRODUCTO As String) As PRODUCTO_COMBUSTIBLE
        NOMBRE_PRODUCTO = NOMBRE_PRODUCTO.ToUpper
        Dim mEntidad As New PRODUCTO_COMBUSTIBLE
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM PRODUCTO_COMBUSTIBLE ")
        strSQL.Append("WHERE UPPER(NOMBRE_PRODUCTO) =  @NOMBRE_PRODUCTO ")

        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter
        arg = New SqlParameter("@NOMBRE_PRODUCTO", SqlDbType.VarChar)
        arg.Value = NOMBRE_PRODUCTO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarPRODUCTO_COMBUSTIBLE(dr, mEntidad)
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
End Class
