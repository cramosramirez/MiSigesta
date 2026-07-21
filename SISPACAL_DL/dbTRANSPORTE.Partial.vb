Partial Public Class dbTRANSPORTE
    Public Function ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(ByVal CODTRANSPORT As Int32, ByVal PLACA As String) As TRANSPORTE
        Dim mEntidad As New TRANSPORTE
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM TRANSPORTE ")
        strSQL.Append("WHERE CODTRANSPORT =  @CODTRANSPORT AND PLACA = @PLACA ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
        args(0).Value = CODTRANSPORT

        args(1) = New SqlParameter("@PLACA", SqlDbType.VarChar)
        args(1).Value = PLACA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMOTORISTA_VEHICULO

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarTRANSPORTE(dr, mEntidad)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function
End Class
