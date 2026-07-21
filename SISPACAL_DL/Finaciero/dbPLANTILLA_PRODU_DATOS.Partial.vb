Partial Public Class dbPLANTILLA_PRODU_DATOS

    Public Function ObtenerListaAgrupadaProductores(ByVal UID_REFERENCIA As Guid, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_PRODU_DATOS
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        strSQL.Append("SELECT CODIPROVEE, CODIPROVEEDOR, PRODUCTOR, PAGO, MIN(PORC_CANA_PEND) AS PORC_CANA_PEND, MIN(MONTO_CANA_PEND) AS MONTO_CANA_PEND ")
        strSQL.Append("FROM PLANTILLA_PRODU_DATOS ")
        strSQL.Append("WHERE UID_REFERENCIA =  @UID_REFERENCIA ")
        strSQL.Append("GROUP BY CODIPROVEE, CODIPROVEEDOR, PRODUCTOR, PAGO")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPLANTILLA_PRODU_DATOS

        Try
            If ds IsNot Nothing Then
                For i As Int32 = 0 To ds.Tables(0).Rows.Count - 1
                    Dim mEntidad As New PLANTILLA_PRODU_DATOS
                    mEntidad.CODIPROVEEDOR = ds.Tables(0).Rows(i)("CODIPROVEEDOR")
                    mEntidad.PRODUCTOR = ds.Tables(0).Rows(i)("PRODUCTOR")
                    mEntidad.PAGO = ds.Tables(0).Rows(i)("PAGO")
                    mEntidad.PORC_CANA_PEND = ds.Tables(0).Rows(i)("PORC_CANA_PEND")
                    mEntidad.MONTO_CANA_PEND = ds.Tables(0).Rows(i)("MONTO_CANA_PEND")

                    lista.Add(mEntidad)
                Next
            End If
           
        Catch ex As Exception
            Throw ex
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorCriterios(ByVal UID_REFERENCIA As Guid, ByVal CODIPROVEEDOR As String, ByVal CONCEPTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_PRODU_DATOS
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        strSQL.Append("SELECT * FROM PLANTILLA_PRODU_DATOS ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)
        AgregarCondicion(strCond, "UID_REFERENCIA = @UID_REFERENCIA")

        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            AgregarCondicion(strCond, "CODIPROVEEDOR = @CODIPROVEEDOR")
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

        Dim lista As New listaPLANTILLA_PRODU_DATOS

        Try
            While dr.Read
                Dim mEntidad As New PLANTILLA_PRODU_DATOS
                dbAsignarEntidades.AsignarPLANTILLA_PRODU_DATOS(dr, mEntidad)
                lista.Add(mEntidad)
            End While

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerTotalesCantidadesParaPlantilla(ByVal UID_REFERENCIA As Guid, ByVal CODIPROVEEDOR As String, ByVal CONCEPTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        strSQL.Append("SELECT SUM(SALDO_INI) AS SALDO_INI, SUM(INTERES + IVA_INTERES) AS INTERES, SUM(ABONO) AS ABONO, SUM(ABONO_INTERES) AS ABONO_INTERES ")
        strSQL.Append("FROM PLANTILLA_PRODU_DATOS  ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)
        AgregarCondicion(strCond, "UID_REFERENCIA = @UID_REFERENCIA")

        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            AgregarCondicion(strCond, "CODIPROVEEDOR = @CODIPROVEEDOR")
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
        strSQL.Append("L.CODIPROVEEDOR AS CODIGO, L.PRODUCTOR, REPLACE(L.CONCEPTO,CHAR(10),' ') AS CONCEPTO, (SELECT E.NO_COMPROB FROM CREDITO_ENCA E WHERE E.ID_CREDITO_ENCA = L.ID_CREDITO_ENCA) AS NO_COMPROB, (SELECT T.NOMBRE_TIPO FROM CREDITO_ENCA E, TIPO_COMPROB T WHERE E.ID_CREDITO_ENCA = L.ID_CREDITO_ENCA AND T.ID_TIPO_COMPROB = E.ID_TIPO_COMPROB) AS TIPO_COMPROB, ")
        strSQL.Append("L.FECHA_APLIC, L.FECHA_ULTMOV, L.TASAINT, L.TIPO_INTERES, L.SALDO_INI AS SALDO, L.INTERES, L.IVA_INTERES, (L.INTERES + L.IVA_INTERES) AS INTERES_TOTAL, ")
        strSQL.Append("L.ABONO AS DESCUENTO, L.ABONO_INTERES, L.ID_CREDITO_ENCA, '' AS APLICAR ")
        strSQL.Append("FROM PLANTILLA_PRODU_DATOS L, CUENTA_FINAN CF ")
        strSQL.Append("WHERE L.ID_CUENTA_FINAN = CF.ID_CUENTA_FINAN AND L.UID_REFERENCIA = @UID_REFERENCIA ")
        strSQL.Append("ORDER BY L.CODIPROVEE, CF.ORDEN_DESCTO, L.FECHA_APLIC ASC ")

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
