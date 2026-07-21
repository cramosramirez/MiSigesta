Partial Public Class dbPRE_ANALISIS_ENCA_TRANS

    Public Function PROC_Generar_Pre_Analisis_Finan_Trans(ByVal ID_ZAFRA As Int32, ByVal CODTRANSPORT As Int32, _
                                                    ByVal UID_REF As String, ByVal FECHA As Date, ByVal USUARIO_CREA As String, _
                                                    Optional ByVal MONTO_SOLICITADO As Decimal = 0, Optional TIPO_MONTO_SOLICITADO As String = "", _
                                                    Optional ByVal UID_DOCUMENTO As String = "") As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
        arg.Value = CODTRANSPORT
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

        arg = New SqlParameter("@TIPO_MONTO_SOLICITADO", SqlDbType.VarChar)
        arg.Value = TIPO_MONTO_SOLICITADO
        args.Add(arg)

        arg = New SqlParameter("@UID_DOCUMENTO", SqlDbType.VarChar)
        arg.Value = UID_DOCUMENTO
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_PRE_ANALISIS_FINAN_TRANS", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUID_REF(ByVal UID_REF As String) As listaPRE_ANALISIS_ENCA_TRANS
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PRE_ANALISIS_ENCA_TRANS))
        strSQL.Append(" WHERE UID_REF = @UID_REF ")


        arg = New SqlParameter("@UID_REF", SqlDbType.VarChar)
        arg.Value = UID_REF
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPRE_ANALISIS_ENCA_TRANS

        Try
            While dr.Read
                Dim mEntidad As New PRE_ANALISIS_ENCA_TRANS
                dbAsignarEntidades.AsignarPRE_ANALISIS_ENCA_TRANS(dr, mEntidad)
                lista.Add(mEntidad)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

End Class
