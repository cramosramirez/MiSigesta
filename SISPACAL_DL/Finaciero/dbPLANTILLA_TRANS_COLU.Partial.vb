Partial Public Class dbPLANTILLA_TRANS_COLU

    Public Function ObtenerListaPorUID(ByVal UID_REFERENCIA As Guid, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_TRANS_COLU
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        strSQL.Append("SELECT * FROM PLANTILLA_TRANS_COLU WHERE UID_REFERENCIA = @UID_REFERENCIA ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPLANTILLA_TRANS_COLU

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANTILLA_TRANS_COLU
                dbAsignarEntidades.AsignarPLANTILLA_TRANS_COLU(dr, mEntidad)

                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function PROC_Generar_Data_Plantilla_Descto_Transportista(ByVal ID_ZAFRA As Int32, _
                                                                 ByVal ID_CATORCENA As Int32, _
                                                                 ByVal ID_TIPO_PLANILLA As Int32, _
                                                                 ByVal UID_REFERENCIA As Guid, _
                                                                 ByVal USUARIO_CREA As String, _
                                                                 ByVal FECHA_CALC_INTERES As DateTime) As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        args.Add(arg)

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)

        arg = New SqlParameter("@FECHA_CALC_INTERES", SqlDbType.DateTime)
        arg.Value = FECHA_CALC_INTERES
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_DATA_PLANTILLA_DESCTO_TRANS", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
