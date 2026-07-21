Partial Public Class dbMONITOR_CAL

    Public Function ObtenerListaPorCODISIS(ByVal CODISIS As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaMONITOR_CAL

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM MONITOR_CAL ")
        strSQL.Append("WHERE CODISIS = @CODISIS ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODISIS", SqlDbType.VarChar)
        args(0).Value = CODISIS.Trim.ToUpper

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMONITOR_CAL

        Try
            Do While dr.Read()
                Dim mEntidad As New MONITOR_CAL
                dbAsignarEntidades.AsignarMONITOR_CAL(dr, mEntidad)
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
