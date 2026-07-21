Partial Public Class dbTIPO_COMPROB

    Public Function ObtenerListaVerRegistro(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaTIPO_COMPROB
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM TIPO_COMPROB WHERE VER_REGISTRO = 1")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If



        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaTIPO_COMPROB

        Try
            Do While dr.Read()
                Dim mEntidad As New TIPO_COMPROB
                dbAsignarEntidades.AsignarTIPO_COMPROB(dr, mEntidad)
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
