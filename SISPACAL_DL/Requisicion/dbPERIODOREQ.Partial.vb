Partial Public Class dbPERIODOREQ
    Public Function ObtenerPeriodoReqActivo() As PERIODOREQ
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaPERIODOREQ
        Dim lPeriodo As New PERIODOREQ

        lCriterios.Add(New Criteria("ACTIVO", "=", True, ""))
        lPeriodo.ACTIVO = True
        lista = Me.ObtenerListaPorBusqueda(lPeriodo, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Return lista(0)
        Else
            Return Nothing
        End If
    End Function


    Public Function ObtenerPERIODOREQ_PorFecha(ByVal FECHA As DateTime) As PERIODOREQ
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PERIODOREQ ")
        strSQL.Append("WHERE @FECHA >= FECHA_INICIO AND @FECHA <= FECHA_FIN")


        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim mEntidad As PERIODOREQ

        Try
            If dr.Read Then
                mEntidad = New PERIODOREQ
                dbAsignarEntidades.AsignarPERIODOREQ(dr, mEntidad)
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
