Partial Public Class dbPRODUCTO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal ACTIVO As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPRODUCTO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PRODUCTO))

        If ID_CUENTA_FINAN <> -1 Then
            arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
            arg.Value = ID_CUENTA_FINAN
            args.Add(arg)
            If ID_CUENTA_FINAN = Enumeradores.CuentaFinanciamiento.Madurantes OrElse ID_CUENTA_FINAN = Enumeradores.CuentaFinanciamiento.InhibidoresFloracion Then
                Me.AgregarCondicion(strCondicion, "(ID_CUENTA_FINAN = @ID_CUENTA_FINAN OR ID_CATEGORIA = " + CStr(Enumeradores.CategoriaProducto.Generico) + ")")
            Else
                Me.AgregarCondicion(strCondicion, "ID_CUENTA_FINAN = @ID_CUENTA_FINAN")
            End If
        End If

        If ACTIVO <> -1 Then
            arg = New SqlParameter("@ACTIVO", SqlDbType.Bit)
            arg.Value = If(ACTIVO = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ACTIVO = @ACTIVO")
        End If

        strSQL.Append(strCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listaPRODUCTO

        Try
            Do While dr.Read()
                Dim mEntidad As New PRODUCTO
                dbAsignarEntidades.AsignarPRODUCTO(dr, mEntidad)
                Me.AsignarNOMBRE_PROVEEDOR_AGRICOLA(mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEE As Int32, ByVal ID_CATEGORIA As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal ID_ZAFRA As Int32, ByVal ACTIVO As Int32, ByVal EN_CONSIGNA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC", Optional OcultarGenerico As Boolean = False) As listaPRODUCTO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT * FROM PRODUCTO ")

        If ID_PROVEE <> -1 Then
            arg = New SqlParameter("@ID_PROVEE", SqlDbType.Int)
            arg.Value = ID_PROVEE
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "(ID_PROVEE = @ID_PROVEE OR @ID_PROVEE IN(4, 50))")
        End If

        If ID_CATEGORIA <> -1 Then
            arg = New SqlParameter("@ID_CATEGORIA", SqlDbType.Int)
            arg.Value = ID_CATEGORIA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_CATEGORIA = @ID_CATEGORIA")
        End If

        If ID_CUENTA_FINAN <> -1 Then
            arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
            arg.Value = ID_CUENTA_FINAN
            args.Add(arg)
            If OcultarGenerico Then
                Me.AgregarCondicion(strCondicion, "ID_CUENTA_FINAN = @ID_CUENTA_FINAN")
            Else
                Me.AgregarCondicion(strCondicion, "(ID_CUENTA_FINAN = @ID_CUENTA_FINAN OR (SELECT COUNT(1) FROM CATEGORIA_PROD CP WHERE CP.ID_CATEGORIA = PRODUCTO.ID_CATEGORIA AND CP.NOMBRE_CATEGORIA = 'GENERICO') > 0)")
            End If
        End If

        If ID_ZAFRA <> -1 Then
            Dim dZafra As New dbZAFRA
            Dim lZafra As New ZAFRA

            lZafra.ID_ZAFRA = ID_ZAFRA
            dZafra.Recuperar(lZafra)

            arg = New SqlParameter("@ZAFRA", SqlDbType.VarChar)
            arg.Value = lZafra.NOMBRE_ZAFRA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ZAFRA = @ZAFRA")
        End If

        If ACTIVO <> -1 Then
            arg = New SqlParameter("@ACTIVO", SqlDbType.Bit)
            arg.Value = If(ACTIVO = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ACTIVO = @ACTIVO")
        End If

        If EN_CONSIGNA <> -1 Then
            arg = New SqlParameter("@EN_CONSIGNA", SqlDbType.Bit)
            arg.Value = If(EN_CONSIGNA = 1, True, False)
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "EN_CONSIGNA = @EN_CONSIGNA")
        End If

        strSQL.Append(strCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPRODUCTO

        Try
            Do While dr.Read()
                Dim mEntidad As New PRODUCTO
                dbAsignarEntidades.AsignarPRODUCTO(dr, mEntidad)
                Me.AsignarNOMBRE_PROVEEDOR_AGRICOLA(mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorNOMBRE_PRODUCTO(ByVal NOMBRE_PRODUCTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPRODUCTO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PRODUCTO))

        arg = New SqlParameter("@NOMBRE_PRODUCTO", SqlDbType.VarChar)
        arg.Value = NOMBRE_PRODUCTO.ToUpper.Trim.Replace(" ", "%")
        strSQL.Append("WHERE NOMBRE_PRODUCTO LIKE '%' + @NOMBRE_PRODUCTO + '%' ")
        args.Add(arg)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)

        Dim lista As New listaPRODUCTO

        Try
            Do While dr.Read()
                Dim mEntidad As New PRODUCTO
                dbAsignarEntidades.AsignarPRODUCTO(dr, mEntidad)
                Me.AsignarNOMBRE_PROVEEDOR_AGRICOLA(mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorNOMBRE_PRODUCTO_EXACTO(ByVal NOMBRE_PRODUCTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPRODUCTO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PRODUCTO))

        arg = New SqlParameter("@NOMBRE_PRODUCTO", SqlDbType.VarChar)
        arg.Value = NOMBRE_PRODUCTO.ToUpper.Trim
        strSQL.Append("WHERE NOMBRE_PRODUCTO = @NOMBRE_PRODUCTO ")
        args.Add(arg)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)

        Dim lista As New listaPRODUCTO

        Try
            Do While dr.Read()
                Dim mEntidad As New PRODUCTO
                dbAsignarEntidades.AsignarPRODUCTO(dr, mEntidad)
                Me.AsignarNOMBRE_PROVEEDOR_AGRICOLA(mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Private Sub AsignarNOMBRE_PROVEEDOR_AGRICOLA(ByRef mEntidad As PRODUCTO)
        Dim lRet As Int32 = 0

        If mEntidad IsNot Nothing Then
            Dim lProveeAgri As New PROVEEDOR_AGRICOLA
            lProveeAgri.ID_PROVEE = mEntidad.ID_PROVEE
            lRet = (New dbPROVEEDOR_AGRICOLA).Recuperar(lProveeAgri)
            If lProveeAgri IsNot Nothing Then mEntidad.NOMBRE_PROVEEDOR = lProveeAgri.NOMBRE
        End If
    End Sub

    Public Function ObtenerExistenciaTotal(ByVal ID_PRODUCTO As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Decimal

        strSQL.Append("SELECT ISNULL(SUM(ENT_UNIDAD),0) - ISNULL(SUM(SAL_UNIDAD),0) AS EXISTENCIA ")
        strSQL.Append("FROM KARDEX ")
        strSQL.Append("WHERE ID_PRODUCTO = @ID_PRODUCTO ")

        arg = New SqlParameter("@ID_PRODUCTO", SqlDbType.Int)
        arg.Value = ID_PRODUCTO
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

    Public Function ObtenerExistenciaPorBodega(ByVal ID_BODEGA As Int32, ByVal ID_PRODUCTO As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Decimal

        strSQL.Append("SELECT ISNULL(SUM(ENT_UNIDAD),0) - ISNULL(SUM(SAL_UNIDAD),0) AS EXISTENCIA ")
        strSQL.Append("FROM KARDEX ")
        strSQL.Append("WHERE ID_BODEGA = @ID_BODEGA AND ID_PRODUCTO = @ID_PRODUCTO ")

        arg = New SqlParameter("@ID_BODEGA", SqlDbType.Int)
        arg.Value = ID_BODEGA
        args.Add(arg)

        arg = New SqlParameter("@ID_PRODUCTO", SqlDbType.Int)
        arg.Value = ID_PRODUCTO
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function
End Class
