Partial Public Class dbPLANTILLA_TRANS_DATOS

    Public Function ObtenerListaAgrupadaProductores(ByVal UID_REFERENCIA As Guid, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_TRANS_DATOS
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        strSQL.Append("SELECT DISTINCT CODTRANSPORT, TRANSPORTISTA, PAGO FROM PLANTILLA_TRANS_DATOS WHERE UID_REFERENCIA =  @UID_REFERENCIA ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPLANTILLA_TRANS_DATOS

        Try
            If ds IsNot Nothing Then
                For i As Int32 = 0 To ds.Tables(0).Rows.Count - 1
                    Dim mEntidad As New PLANTILLA_TRANS_DATOS
                    mEntidad.CODTRANSPORT = ds.Tables(0).Rows(i)("CODTRANSPORT")
                    mEntidad.TRANSPORTISTA = ds.Tables(0).Rows(i)("TRANSPORTISTA")
                    mEntidad.PAGO = ds.Tables(0).Rows(i)("PAGO")
                    lista.Add(mEntidad)
                Next
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorCriterios(ByVal UID_REFERENCIA As Guid, ByVal CODTRANSPORT As Int32, ByVal CONCEPTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_TRANS_DATOS
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        strSQL.Append("SELECT * FROM PLANTILLA_TRANS_DATOS ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)
        AgregarCondicion(strCond, "UID_REFERENCIA = @UID_REFERENCIA")

        If CODTRANSPORT <> "" Then
            arg = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
            arg.Value = CODTRANSPORT
            args.Add(arg)
            AgregarCondicion(strCond, "CODTRANSPORT = @CODTRANSPORT")
        End If

        If CONCEPTO <> "" Then
            arg = New SqlParameter("@CONCEPTO", SqlDbType.VarChar)
            arg.Value = CONCEPTO
            args.Add(arg)
            AgregarCondicion(strCond, "CONCEPTO = @CONCEPTO")
        End If

        strSQL.Append(strCond.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPLANTILLA_TRANS_DATOS

        Try
            While dr.Read
                Dim mEntidad As New PLANTILLA_TRANS_DATOS
                dbAsignarEntidades.AsignarPLANTILLA_TRANS_DATOS(dr, mEntidad)
                lista.Add(mEntidad)
            End While

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerTotalesCantidadesParaPlantilla(ByVal UID_REFERENCIA As Guid, ByVal CODTRANSPORT As Int32, ByVal CONCEPTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        strSQL.Append("SELECT SUM(SALDO_INI) AS SALDO_INI, SUM(INTERES + IVA_INTERES) AS INTERES, SUM(ABONO) AS ABONO, SUM(ABONO_INTERES) AS ABONO_INTERES ")
        strSQL.Append("FROM PLANTILLA_TRANS_DATOS  ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)
        AgregarCondicion(strCond, "UID_REFERENCIA = @UID_REFERENCIA")

        If CODTRANSPORT <> -1 Then
            arg = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
            arg.Value = CODTRANSPORT
            args.Add(arg)
            AgregarCondicion(strCond, "CODTRANSPORT = @CODTRANSPORT")
        End If

        If CONCEPTO <> "" Then
            arg = New SqlParameter("@CONCEPTO", SqlDbType.VarChar)
            arg.Value = CONCEPTO
            args.Add(arg)
            AgregarCondicion(strCond, "CONCEPTO = @CONCEPTO")
        End If

        strSQL.Append(strCond.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If
        Dim ds As DataSet

        Try
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDetalleParaPlantilla(ByVal UID_REFERENCIA As Guid) As DataSet
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        strSQL.Append("SELECT ")
        strSQL.Append("L.CODTRANSPORT AS CODIGO, L.TRANSPORTISTA, REPLACE(L.CONCEPTO,CHAR(10),' ') AS CONCEPTO, E.NO_COMPROB, (SELECT T.NOMBRE_TIPO FROM TIPO_COMPROB T WHERE T.ID_TIPO_COMPROB = E.ID_TIPO_COMPROB) AS TIPO_COMPROB, ")
        strSQL.Append("L.FECHA_APLIC, L.FECHA_ULTMOV, L.TASAINT, L.TIPO_INTERES, L.SALDO_INI AS SALDO, L.INTERES, L.IVA_INTERES, (L.INTERES + L.IVA_INTERES) AS INTERES_TOTAL, ")
        strSQL.Append("L.ABONO AS DESCUENTO, L.ABONO_INTERES, L.ID_CREDITO_ENCA, L.NO_CATORCENA_VTO AS CATORCENA_VENCIMIENTO, '' AS APLICAR ")
        strSQL.Append("FROM PLANTILLA_TRANS_DATOS L, CREDITO_ENCA_TRANS E, CUENTA_FINAN CF ")
        strSQL.Append("WHERE L.ID_CREDITO_ENCA = E.ID_CREDITO_ENCA AND E.ID_CUENTA_FINAN = CF.ID_CUENTA_FINAN AND L.UID_REFERENCIA = @UID_REFERENCIA ")
        strSQL.Append("ORDER BY L.CODTRANSPORT, CF.ORDEN_DESCTO, E.FECHA_APLIC ASC ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        Dim ds As DataSet

        Try
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

End Class
