Partial Public Class dbSOLIC_APLICACION_PRODUCTO

    Public Function ObtenerListaPorUID_REF(ByVal UID_REFERENCIA As Guid) As listaSOLIC_APLICACION_PRODUCTO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM SOLIC_APLICACION_PRODUCTO WHERE UID_REFERENCIA = @UID_REFERENCIA")


        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_APLICACION_PRODUCTO

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_APLICACION_PRODUCTO
                dbAsignarEntidades.AsignarSOLIC_APLICACION_PRODUCTO(dr, mEntidad)
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
