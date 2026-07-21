Partial Public Class dbPRE_ANALISIS_ENCA

    Public Function PROC_Generar_Pre_Analisis_Finan(ByVal ID_ZAFRA As Int32, ByVal ID_ZAFRA2 As Int32, ByVal CODIPROVEEDOR As String, ByVal CONTRATOS As String,
                                                    ByVal UID_REF As String, ByVal FECHA As Date, ByVal USUARIO_CREA As String,
                                                    Optional ByVal MONTO_SOLICITADO As Decimal = 0, Optional ByVal MONTO_SOLICITADO2 As Decimal = 0, Optional TIPO_MONTO_SOLICITADO As String = "",
                                                    Optional ByVal UID_DOCUMENTO As String = "") As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim command As New SqlCommand

        arg = New SqlParameter("@ID_ZAFRA_INI", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA_FIN", SqlDbType.Int)
        arg.Value = ID_ZAFRA2
        args.Add(arg)

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@CONTRATOS", SqlDbType.VarChar)
        arg.Value = CONTRATOS
        args.Add(arg)

        arg = New SqlParameter("@UID_REF", SqlDbType.VarChar)
        arg.Value = UID_REF
        args.Add(arg)

        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)

        arg = New SqlParameter("@MONTO_SOLICITADO", SqlDbType.Decimal)
        arg.Value = MONTO_SOLICITADO
        args.Add(arg)

        arg = New SqlParameter("@MONTO_SOLICITADO2", SqlDbType.Decimal)
        arg.Value = MONTO_SOLICITADO2
        args.Add(arg)

        arg = New SqlParameter("@TIPO_MONTO_SOLICITADO", SqlDbType.VarChar)
        arg.Value = TIPO_MONTO_SOLICITADO
        args.Add(arg)

        arg = New SqlParameter("@UID_DOCUMENTO", SqlDbType.VarChar)
        arg.Value = UID_DOCUMENTO
        args.Add(arg)

        Try
            Command.Connection = New SqlConnection(Me.cnnStr)
            Command.Connection.Open()
            Command.CommandType = CommandType.StoredProcedure
            command.CommandText = "GENERAR_PRE_ANALISIS_FINAN"
            command.CommandTimeout = 900000
            Command.Parameters.AddRange(args.ToArray)
            command.ExecuteNonQuery()
            'lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_PRE_ANALISIS_FINAN", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function PROC_Generar_Analisis_Financiero_proyectado(ByVal ID_ZAFRA As Int32, ByVal ID_ZAFRA2 As Int32, ByVal CODIPROVEEDOR As String, ByVal CONTRATOS As String,
                                                    ByVal UID_REF As String, ByVal FECHA As Date, ByVal USUARIO_CREA As String,
                                                    Optional ByVal MONTO_SOLICITADO As Decimal = 0, Optional ByVal MONTO_SOLICITADO2 As Decimal = 0, Optional TIPO_MONTO_SOLICITADO As String = "",
                                                    Optional ByVal UID_DOCUMENTO As String = "") As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim command As New SqlCommand

        arg = New SqlParameter("@ID_ZAFRA_INI", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA_FIN", SqlDbType.Int)
        arg.Value = ID_ZAFRA2
        args.Add(arg)

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@CONTRATOS", SqlDbType.VarChar)
        arg.Value = CONTRATOS
        args.Add(arg)

        arg = New SqlParameter("@UID_REF", SqlDbType.VarChar)
        arg.Value = UID_REF
        args.Add(arg)

        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)

        arg = New SqlParameter("@MONTO_SOLICITADO", SqlDbType.Decimal)
        arg.Value = MONTO_SOLICITADO
        args.Add(arg)

        arg = New SqlParameter("@MONTO_SOLICITADO2", SqlDbType.Decimal)
        arg.Value = MONTO_SOLICITADO2
        args.Add(arg)

        arg = New SqlParameter("@TIPO_MONTO_SOLICITADO", SqlDbType.VarChar)
        arg.Value = TIPO_MONTO_SOLICITADO
        args.Add(arg)

        arg = New SqlParameter("@UID_DOCUMENTO", SqlDbType.VarChar)
        arg.Value = UID_DOCUMENTO
        args.Add(arg)


        Try
            command.Connection = New SqlConnection(Me.cnnStr)
            command.Connection.Open()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "GENERAR_ANALISIS_FINAN_PROYECTADO"
            command.CommandTimeout = 900000
            command.Parameters.AddRange(args.ToArray)
            command.ExecuteNonQuery()

            'lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_ANALISIS_FINAN_PROYECTADO", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        Finally
            If command.Connection.State = ConnectionState.Open Then
                command.Connection.Close()
            End If
            command = Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUID_REF(ByVal UID_REF As String) As listaPRE_ANALISIS_ENCA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PRE_ANALISIS_ENCA))
        strSQL.Append(" WHERE UID_REF = @UID_REF ")


        arg = New SqlParameter("@UID_REF", SqlDbType.VarChar)
        arg.Value = UID_REF
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPRE_ANALISIS_ENCA

        Try
            While dr.Read
                Dim mEntidad As New PRE_ANALISIS_ENCA
                dbAsignarEntidades.AsignarPRE_ANALISIS_ENCA(dr, mEntidad)
                lista.Add(mEntidad)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ReporteExcelFinancieroProductores(ByVal ID_ZAFRA As Integer) As DataTable
        Dim ds As New DS_SIFAG
        Dim adapter As New DS_SIFAGTableAdapters.REPORTE_EXCEL_FINANPRODTableAdapter

        adapter.FillPorCriterios(ds.REPORTE_EXCEL_FINANPROD, ID_ZAFRA)

        Return ds.REPORTE_EXCEL_FINANPROD.Copy

    End Function

End Class
