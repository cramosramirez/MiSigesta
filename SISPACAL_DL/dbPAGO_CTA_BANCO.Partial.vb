Partial Public Class dbPAGO_CTA_BANCO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal ES_CONTRIBUYENTE As Int32, ByVal MOSTRAR_POR As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC", Optional CODIBANCO As Integer = -1) As listaPAGO_CTA_BANCO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT ")
        strSQL.Append("CASE WHEN PG.ID_TIPO_PLANILLA = 2 THEN PG.CODIPROVEEDOR_TRANSPORTISTA ELSE dbo.QuitarFormatoCODIPROVEEDOR(PG.CODIPROVEEDOR_TRANSPORTISTA) END AS CODIGO_SINFTO, ")
        strSQL.Append("PG.*, ")
        strSQL.Append("CASE WHEN PG.ID_TIPO_PLANILLA = 2 THEN (SELECT RTRIM(T.APELLIDOS) AS APELLIDOS FROM TRANSPORTISTA T WHERE T.CODTRANSPORT = PG.CODIPROVEEDOR_TRANSPORTISTA) ELSE (SELECT RTRIM(P.APELLIDOS) AS APELLIDOS FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = PG.CODIPROVEEDOR_TRANSPORTISTA) END AS APELLIDOS ")
        strSQL.Append("FROM PAGO_CTA_BANCO PG ")

        If ID_CATORCENA <> -1 Then
            arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            arg.Value = ID_CATORCENA
            args.Add(arg)
            AgregarCondicion(strCond, "PG.ID_CATORCENA = @ID_CATORCENA")
        End If
        If ID_TIPO_PLANILLA <> -1 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strCond, "PG.ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA")
        End If
        If CODIBANCO <> -1 Then
            arg = New SqlParameter("@CODIBANCO", SqlDbType.Int)
            arg.Value = CODIBANCO
            args.Add(arg)
            AgregarCondicion(strCond, "PG.CODIBANCO = @CODIBANCO")
        End If
        If ES_CONTRIBUYENTE <> -1 Then
            arg = New SqlParameter("@ES_CONTRIBUYENTE", SqlDbType.Bit)
            arg.Value = If(ES_CONTRIBUYENTE = 1, True, False)
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PLANILLA P WHERE P.ID_CATORCENA = PG.ID_CATORCENA AND P.CODIPROVEEDOR_TRANSPORTISTA = PG.CODIPROVEEDOR_TRANSPORTISTA AND P.ID_TIPO_PLANILLA = PG.ID_TIPO_PLANILLA AND P.ES_CONTRIBUYENTE = @ES_CONTRIBUYENTE)")
        End If
        If MOSTRAR_POR <> -1 Then
            arg = New SqlParameter("@MOSTRAR_POR", SqlDbType.Int)
            arg.Value = MOSTRAR_POR
            args.Add(arg)
            AgregarCondicion(strCond, "( (@MOSTRAR_POR = -1) OR (ENTREGO_CCF = 0 AND @MOSTRAR_POR = 0) OR (ENTREGO_CCF = 1 AND FECHA_GENPAGO IS NULL AND @MOSTRAR_POR = 1) OR (NOT FECHA_GENPAGO IS NULL AND @MOSTRAR_POR = 2) )")
        End If

        strSQL.Append(strCond.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaPAGO_CTA_BANCO

        Try
            Do While dr.Read()
                Dim mEntidad As New PAGO_CTA_BANCO
                dbAsignarEntidades.AsignarPAGO_CTA_BANCO(dr, mEntidad)
                mEntidad.CODIGO_SINFTO = CInt(dr("CODIGO_SINFTO"))
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
