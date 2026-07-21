Partial Public Class dbZAFRA
    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera la entidad ZAFRA que se encuentra ACTIVA.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerZafraActiva() As ZAFRA
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaZAFRA
        Dim lZafra As New ZAFRA

        lCriterios.Add(New Criteria("ACTIVA", "=", True, ""))
        lZafra.ACTIVA = True
        lista = Me.ObtenerListaPorBusqueda(lZafra, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Return lista(0)
        Else
            Return Nothing
        End If
    End Function


    Public Function ObtenerZafraAnterior(ByVal ID_ZAFRA_ACTUAL As Int32) As ZAFRA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT TOP 1 * FROM ZAFRA Z WHERE EXISTS(SELECT 1 FROM ZAFRA X WHERE X.ID_ZAFRA = @ID_ZAFRA_ACTUAL AND X.FECHA_INICIO > Z.FECHA_INICIO) ")
        strSQL.Append("ORDER BY Z.FECHA_INICIO DESC ")


        arg = New SqlParameter("@ID_ZAFRA_ACTUAL", SqlDbType.Int)
        arg.Value = ID_ZAFRA_ACTUAL
        args.Add(arg)


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New ZAFRA

        Try
            If dr.Read() Then
                mEntidad = New ZAFRA
                dbAsignarEntidades.AsignarZAFRA(dr, mEntidad)
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
