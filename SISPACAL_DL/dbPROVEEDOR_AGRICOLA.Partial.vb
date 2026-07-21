Partial Public Class dbPROVEEDOR_AGRICOLA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorTIPO_PROVEEDOR(ByVal ES_PROVEE_VUELO As Int32, ByVal ES_CASA_COMER As Int32, ByVal ID_CUENTA_FINAN As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT G.* FROM PROVEEDOR_AGRICOLA G ")


        If ES_PROVEE_VUELO = 1 Then
            arg = New SqlParameter("@ES_PROVEE_VUELO", SqlDbType.Bit)
            arg.Value = True
            args.Add(arg)
            AgregarCondicion(strCond, " G.ES_PROVEE_VUELO = @ES_PROVEE_VUELO ")
        End If

        If ES_CASA_COMER = 1 Then
            arg = New SqlParameter("@ES_CASA_COMER", SqlDbType.Bit)
            arg.Value = True
            args.Add(arg)
            AgregarCondicion(strCond, " G.ES_CASA_COMER = @ES_CASA_COMER ")
        End If

        If ID_CUENTA_FINAN <> -1 Then
            arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
            arg.Value = ID_CUENTA_FINAN
            args.Add(arg)
            AgregarCondicion(strCond, " ( (SELECT COUNT(1) FROM PRODUCTO P WHERE P.ACTIVO = 1 AND P.ID_PROVEE = G.ID_PROVEE AND P.ID_CUENTA_FINAN = @ID_CUENTA_FINAN) > 0 " +
                             "OR (SELECT COUNT(1) FROM PRODUCTO P WHERE P.ACTIVO = 1 AND P.ID_PROVEE = G.ID_PROVEE AND P.ID_CUENTA_FINAN = " + CStr(Enumeradores.CuentaFinanciamiento.Generico) + ") > 0 ) ")
        End If

        strSQL.Append(strCond.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR_AGRICOLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AGRICOLA
                dbAsignarEntidades.AsignarPROVEEDOR_AGRICOLA(dr, mEntidad)
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
    Public Function ObtenerListaPROVEEDOR_BANCOS(ByVal ES_PROVEE_VUELO As Boolean, ByVal ES_CASA_COMER As Boolean, ByVal ID_CUENTA_FINAN As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM PROVEEDOR_AGRICOLA ")
        strSQL.Append("WHERE ES_PROVEE_VUELO = @ES_PROVEE_VUELO AND ES_CASA_COMER = @ES_CASA_COMER ")

        arg = New SqlParameter("@ES_PROVEE_VUELO", SqlDbType.Bit)
        arg.Value = ES_PROVEE_VUELO
        args.Add(arg)

        arg = New SqlParameter("@ES_CASA_COMER", SqlDbType.Bit)
        arg.Value = ES_CASA_COMER
        args.Add(arg)

        If ID_CUENTA_FINAN <> -1 Then
            arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
            arg.Value = ID_CUENTA_FINAN
            args.Add(arg)
            strSQL.Append("AND ( (SELECT COUNT(1) FROM PRODUCTO P WHERE P.ACTIVO = 1 AND P.ID_PROVEE = PROVEEDOR_AGRICOLA.ID_PROVEE AND P.ID_CUENTA_FINAN = @ID_CUENTA_FINAN) > 0 ")
            strSQL.Append("OR (SELECT COUNT(1) FROM PRODUCTO P WHERE P.ACTIVO = 1 AND P.ID_PROVEE = PROVEEDOR_AGRICOLA.ID_PROVEE AND P.ID_CUENTA_FINAN = " + CStr(Enumeradores.CuentaFinanciamiento.Generico) + ") > 0 ) ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR_AGRICOLA
        Dim lProveeAgri As New PROVEEDOR_AGRICOLA

        lProveeAgri.ID_PROVEE = -1
        lProveeAgri.NOMBRE = ""
        lista.Add(lProveeAgri)


        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AGRICOLA
                dbAsignarEntidades.AsignarPROVEEDOR_AGRICOLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

            Dim lBancos As listaBANCOS = (New dbBANCOS).ObtenerListaConOIP
            Dim lProvee As New PROVEEDOR_AGRICOLA
            Dim k = 1000
            If lBancos IsNot Nothing AndAlso lBancos.Count > 0 Then
                For Each lEntidad As BANCOS In lBancos
                    lProvee = New PROVEEDOR_AGRICOLA
                    lProvee.ID_PROVEE = k
                    lProvee.NOMBRE = lEntidad.NOMBRE_BANCO + " [" + lEntidad.CODIBANCO.ToString + "]"
                    k += 1
                    lista.Add(lProvee)
                Next
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM PROVEEDOR_AGRICOLA ")
        If ID_CUENTA_FINAN <> -1 Then
            arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
            arg.Value = ID_CUENTA_FINAN
            args.Add(arg)
            strSQL.Append("WHERE (SELECT COUNT(1) FROM PRODUCTO P WHERE P.ACTIVO = 1 AND P.ID_PROVEE = PROVEEDOR_AGRICOLA.ID_PROVEE AND P.ID_CUENTA_FINAN = @ID_CUENTA_FINAN) > 0 ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR_AGRICOLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AGRICOLA
                dbAsignarEntidades.AsignarPROVEEDOR_AGRICOLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaTransporte(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM PROVEEDOR_AGRICOLA P ")
        strSQL.Append("WHERE (SELECT COUNT(1) FROM PRODUCTO) > 0 ")

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR_AGRICOLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AGRICOLA
                dbAsignarEntidades.AsignarPROVEEDOR_AGRICOLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaTransporteCreditoEncaTrans(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT DISTINCT P.* ")
        strSQL.Append("FROM CREDITO_ENCA_TRANS E, PROVEEDOR_AGRICOLA P ")
        strSQL.Append("WHERE E.ID_PROVEE = P.ID_PROVEE ")

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROVEEDOR_AGRICOLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AGRICOLA
                dbAsignarEntidades.AsignarPROVEEDOR_AGRICOLA(dr, mEntidad)
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
