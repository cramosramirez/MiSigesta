Partial Public Class dbCARGADORA_ASIGNADA
    Public Function ObtenerListaPorZAFRA_CARGADORA(ByVal ID_ZAFRA As Int32, ByVal ID_CARGADORA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCARGADORA_ASIGNADA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CARGADORA_ASIGNADA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA AND ID_CARGADORA = @ID_CARGADORA")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If


        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_CARGADORA", SqlDbType.Int)
        arg.Value = ID_CARGADORA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCARGADORA_ASIGNADA

        Try
            Do While dr.Read()
                Dim mEntidad As New CARGADORA_ASIGNADA
                dbAsignarEntidades.AsignarCARGADORA_ASIGNADA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerCARGADORA_ASIGNADA(ByVal ID_ZAFRA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_CARGADOR As Int32) As CARGADORA_ASIGNADA
        Dim aEntidad As New CARGADORA_ASIGNADA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CARGADORA_ASIGNADA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA AND ID_CARGADORA = @ID_CARGADORA AND ID_CARGADOR = @ID_CARGADOR")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_CARGADORA", SqlDbType.Int)
        arg.Value = ID_CARGADORA
        args.Add(arg)

        arg = New SqlParameter("@ID_CARGADOR", SqlDbType.Int)
        arg.Value = ID_CARGADOR
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCARGADORA_ASIGNADA(dr, CType(aEntidad, CARGADORA_ASIGNADA))
            Else
                aEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return aEntidad

    End Function
End Class
