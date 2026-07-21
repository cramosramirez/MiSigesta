Partial Public Class dbDIA_ZAFRA
    Public Function ObtenerPorFECHA(ByVal FECHA As DateTime) As DIA_ZAFRA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim listadoDiasZafra As New listaDIA_ZAFRA
        strSQL.Append("SELECT * FROM DIA_ZAFRA ")
        strSQL.Append("WHERE FECHA = @FECHA")

        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        Dim aEntidad As New DIA_ZAFRA
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                aEntidad = New DIA_ZAFRA
                dbAsignarEntidades.AsignarDIA_ZAFRA(dr, aEntidad)
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

    Public Function ObtenerPorZAFRA_DIA(ByVal ID_ZAFRA As Integer, ByVal DIAZAFRA As Integer) As DIA_ZAFRA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim listadoDiasZafra As New listaDIA_ZAFRA
        strSQL.Append("SELECT * FROM DIA_ZAFRA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA AND DIAZAFRA = @DIAZAFRA")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@DIAZAFRA", SqlDbType.Int)
        arg.Value = DIAZAFRA
        args.Add(arg)

        Dim aEntidad As New DIA_ZAFRA
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarDIA_ZAFRA(dr, aEntidad)
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

    Public Function AplicarAjusteRendimiento(ByVal ID_ZAFRA As Integer, ByVal DIA_ZAFRA As Integer) As Integer

        Me.AplicarConfiguracionCompatibilidad()


        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@DIA_ZAFRA", SqlDbType.Int)
        arg.Value = DIA_ZAFRA
        args.Add(arg)


        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "APLICAR_AJUSTE_REND", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function AplicarConfiguracionCompatibilidad() As Integer

        Dim lResult As Integer = -1
        Dim conexion As New SqlConnectionStringBuilder

        Try
            conexion.ConnectionString = Me.cnnStr
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, "ALTER DATABASE " + conexion.InitialCatalog + " SET COMPATIBILITY_LEVEL = 110")
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
