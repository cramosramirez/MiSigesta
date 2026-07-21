Partial Public Class dbRECIBO_CANA_NUMERACION

    Public Function ObtenerReciboCanaActivo() As RECIBO_CANA_NUMERACION
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter
        Dim aEntidad As New RECIBO_CANA_NUMERACION

        strSQL.Append(Me.QuerySelect(aEntidad))
        strSQL.Append("WHERE ACTIVO = 1")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarRECIBO_CANA_NUMERACION(dr, CType(aEntidad, RECIBO_CANA_NUMERACION))
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

    Public Function ExisteNumeroReciboCana(ByVal NUMRECIBO_CANA As Integer) As Boolean
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter
        Dim aEntidad As New RECIBO_CANA_NUMERACION
        Dim lRet As Boolean = False

        strSQL.Append(Me.QuerySelect(aEntidad))
        strSQL.Append(" WHERE NUM_INICIAL <= @NUMRECIBO_CANA AND NUM_FINAL >= @NUMRECIBO_CANA AND ACTIVO = 1")

        args(0) = New SqlParameter("@NUMRECIBO_CANA", SqlDbType.Int)
        args(0).Value = NUMRECIBO_CANA
        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                lRet = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function

    Public Function ExisteAsignacionNumeroReciboCana(ByVal ID_ZAFRA As Integer, ByVal NUMRECIBO_CANA As Integer) As Boolean
        Dim strSQL As New StringBuilder
        Dim args(1) As SqlParameter
        Dim aEntidad As New RECIBO_CANA_NUMERACION
        Dim lRet As Boolean = False

        strSQL.Append(" SELECT 1 FROM ENVIO ")
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA AND NUMRECIBO_CANA = @NUMRECIBO_CANA")

        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@NUMRECIBO_CANA", SqlDbType.Int)
        args(1).Value = NUMRECIBO_CANA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                lRet = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function
End Class
