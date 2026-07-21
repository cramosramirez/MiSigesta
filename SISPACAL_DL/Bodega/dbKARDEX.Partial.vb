Partial Public Class dbKARDEX

    Public Function ObtenerKARDEX_UltimoMovtoID_PRODUCTO(ByVal ID_BODEGA As Int32, ByVal ID_PRODUCTO As Int32) As KARDEX
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT TOP 1 * FROM KARDEX WHERE ID_BODEGA = @ID_BODEGA AND ID_PRODUCTO = @ID_PRODUCTO ORDER BY ID_KARDEX DESC ")

        arg = New SqlParameter("@ID_BODEGA", SqlDbType.Int)
        arg.Value = ID_BODEGA
        args.Add(arg)

        arg = New SqlParameter("@ID_PRODUCTO", SqlDbType.Int)
        arg.Value = ID_PRODUCTO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New KARDEX

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarKARDEX(dr, mEntidad)
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
