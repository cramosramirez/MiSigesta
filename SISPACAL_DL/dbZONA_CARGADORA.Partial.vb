Partial Public Class dbZONA_CARGADORA
    Public Function ObtenerListaPorZAFRA_ZONA(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaZONA_CARGADORA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ZONA_CARGADORA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA AND ZONA = @ZONA")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If


        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ZONA", SqlDbType.Char)
        arg.Value = ZONA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaZONA_CARGADORA

        Try
            Do While dr.Read()
                Dim mEntidad As New ZONA_CARGADORA
                dbAsignarEntidades.AsignarZONA_CARGADORA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerZONA_CARGADORA(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal ID_CARGADORA As Int32) As ZONA_CARGADORA
        Dim aEntidad As New ZONA_CARGADORA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ZONA_CARGADORA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA AND ZONA = @ZONA AND ID_CARGADORA = @ID_CARGADORA")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ZONA", SqlDbType.Char)
        arg.Value = ZONA
        args.Add(arg)

        arg = New SqlParameter("@ID_CARGADORA", SqlDbType.Int)
        arg.Value = ID_CARGADORA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarZONA_CARGADORA(dr, CType(aEntidad, ZONA_CARGADORA))
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
