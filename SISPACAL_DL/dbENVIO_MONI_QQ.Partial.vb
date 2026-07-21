Partial Public Class dbENVIO_MONI_QQ


    Public Function SP_SERVICIO_MONITOR_QUERQUEO(ByVal OPCION As String,
                                                   ByVal CODIPROVEEDOR As String,
                                                   ByVal ID_ENVIO As Integer,
                                                   ByVal ID_MONITOR As Integer,
                                                   ByVal ID_PROVEE_QQ As Integer) As List(Of Dictionary(Of Integer, String))
        Dim lRet As New List(Of Dictionary(Of Integer, String))
        Dim item As New Dictionary(Of Integer, String)
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@OPCION", SqlDbType.VarChar)
        arg.Value = OPCION
        args.Add(arg)

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@ID_ENVIO", SqlDbType.Int)
        arg.Value = ID_ENVIO
        args.Add(arg)

        arg = New SqlParameter("@ID_MONITOR", SqlDbType.Int)
        arg.Value = ID_MONITOR
        args.Add(arg)

        arg = New SqlParameter("@ID_PROVEE_QQ", SqlDbType.Int)
        arg.Value = ID_PROVEE_QQ
        args.Add(arg)

        Dim dr As IDataReader

        Try
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "SP_SERVICIO_MONITOR_QUERQUEO", args.ToArray)
            Do While dr.Read()
                item.Add(Convert.ToInt32(dr(0)), dr(1).ToString)
                lRet.Add(item)
            Loop

            Return lRet

        Catch ex As Exception
            Throw ex
        Finally
            If dr IsNot Nothing Then dr.Close()
        End Try

        Return lRet
    End Function
End Class
