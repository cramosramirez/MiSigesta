Partial Public Class dbPROVEEDOR
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal CODIPROVEE As String, ByVal CODISOCIO As String,
                                             ByVal APELLIDOS As String, ByVal NOMBRES As String,
                                             ByVal DUI As String,
                                             ByVal NIT As String,
                                             ByVal CREDITFISCAL As String,
                                             ByVal ID_ZAFRA_CONTRATADA As Integer,
                                             Optional soloProveedoresConContrato As Boolean = False) As listaPROVEEDOR
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM PROVEEDOR P ")

        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "P.CODIPROVEE = @CODIPROVEE")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "P.CODISOCIO = @CODISOCIO")
        End If
        If APELLIDOS <> "" Then
            arg = New SqlParameter("@APELLIDOS", SqlDbType.Char)
            arg.Value = APELLIDOS.ToUpper
            args.Add(arg)
            AgregarCondicion(strCond, "P.APELLIDOS LIKE '%' + @APELLIDOS + '%'")
        End If
        If NOMBRES <> "" Then
            arg = New SqlParameter("@NOMBRES", SqlDbType.Char)
            arg.Value = NOMBRES.ToUpper
            args.Add(arg)
            AgregarCondicion(strCond, "P.NOMBRES LIKE '%' + @NOMBRES + '%'")
        End If
        If DUI <> "" Then
            arg = New SqlParameter("@DUI", SqlDbType.Char)
            arg.Value = DUI
            args.Add(arg)
            AgregarCondicion(strCond, "P.DUI = @DUI")
        End If
        If NIT <> "" Then
            arg = New SqlParameter("@NIT", SqlDbType.Char)
            arg.Value = NIT
            args.Add(arg)
            AgregarCondicion(strCond, "P.NIT = @NIT")
        End If
        If CREDITFISCAL <> "" Then
            arg = New SqlParameter("@CREDITFISCAL", SqlDbType.Char)
            arg.Value = CREDITFISCAL
            args.Add(arg)
            AgregarCondicion(strCond, "P.CREDITFISCAL = @CREDITFISCAL")
        End If
        If ID_ZAFRA_CONTRATADA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA_CONTRATADA
            args.Add(arg)
            Dim s As New StringBuilder
            s.Append("( ")
            s.Append("SELECT COUNT(1) FROM LOTES L, CONTRATO_ZAFRAS CZ ")
            s.Append("WHERE L.CODIPROVEEDOR = P.CODIPROVEEDOR ")
            s.Append("AND L.CODICONTRATO = CZ.CODICONTRATO AND CZ.ID_ZAFRA = @ID_ZAFRA ")
            s.Append(") > 0 ")
            AgregarCondicion(strCond, s.ToString)
        End If
        If soloProveedoresConContrato Then
            Dim s As New StringBuilder
            s.Append("( ")
            s.Append("SELECT COUNT(1) FROM CONTRATO C WHERE C.CODIPROVEEDOR = P.CODIPROVEEDOR ")
            s.Append(") > 0 ")
            AgregarCondicion(strCond, s.ToString)
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY CAST(dbo.QuitarFormatoCODIPROVEE(CODIPROVEE) AS INT)")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR
                dbAsignarEntidades.AsignarPROVEEDOR(dr, mEntidad)
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
    Public Function ObtenerListaPorNombreCompleto(ByVal NOMBRE_PROVEEDOR As String) As listaPROVEEDOR
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM PROVEEDOR ")

        arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.NVarChar)
        arg.Value = "%" & Replace(NOMBRE_PROVEEDOR.ToUpper, " ", "%") & "%"
        args.Add(arg)
        AgregarCondicion(strCond, "RTRIM(ISNULL(NOMBRES,'')) + ' ' + RTRIM(ISNULL(APELLIDOS,'')) LIKE @NOMBRE_PROVEEDOR")

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY APELLIDOS ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR
                dbAsignarEntidades.AsignarPROVEEDOR(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerCorrelativoProveedor() As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(CAST(dbo.QuitarFormatoCODIPROVEEDOR(CODIPROVEEDOR) AS INT)),0) + 1 FROM PROVEEDOR P ")

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

    Public Function ReporteExcelConsultaProductoresPorZafra(ByVal ID_ZAFRA As Integer, ByVal conContrato As Boolean) As DataTable
        Dim ds As New DS_SIFAG
        Dim adapter As New DS_SIFAGTableAdapters.EXCEL_CONSULTA_PROVEEDORES_POR_ZAFRATableAdapter

        adapter.FillPorCriterios(ds.EXCEL_CONSULTA_PROVEEDORES_POR_ZAFRA, ID_ZAFRA, conContrato)

        Return ds.EXCEL_CONSULTA_PROVEEDORES_POR_ZAFRA.Copy

    End Function
End Class
