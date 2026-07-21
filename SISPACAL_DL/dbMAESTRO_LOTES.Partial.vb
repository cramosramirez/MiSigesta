Partial Public Class dbMAESTRO_LOTES

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE CODIPROVEEDOR = @CODIPROVEEDOR ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        args(0).Value = CODIPROVEEDOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    Public Function ObtenerListaPorCriterios(ByVal ZONA As String, ByVal SUB_ZONA As String,
                                             ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String,
                                             ByVal CODI_CANTON As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal CODICONTRATO As Integer,
                                             ByVal NOMBRE_PROVEEDOR As String) As listaMAESTRO_LOTES
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT M.* FROM MAESTRO_LOTES M ")

        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "M.ZONA = @ZONA")
        End If
        If SUB_ZONA <> "" Then
            arg = New SqlParameter("@SUB_ZONA", SqlDbType.Char)
            arg.Value = SUB_ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "M.SUB_ZONA = @SUB_ZONA")
        End If
        If CODI_DEPTO <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.Char)
            arg.Value = CODI_DEPTO
            args.Add(arg)
            AgregarCondicion(strCond, "M.CODI_DEPTO = @CODI_DEPTO")
        End If
        If CODI_MUNI <> "" Then
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.Char)
            arg.Value = CODI_MUNI
            args.Add(arg)
            AgregarCondicion(strCond, "M.CODI_MUNI = @CODI_MUNI")
        End If
        If CODI_CANTON <> "" Then
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.Char)
            arg.Value = CODI_CANTON
            args.Add(arg)
            AgregarCondicion(strCond, "M.CODI_CANTON = @CODI_CANTON")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE)")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO)")
        End If
        If CODICONTRATO <> -1 Then
            arg = New SqlParameter("@CODICONTRATO", SqlDbType.Int)
            arg.Value = CODICONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "M.CODICONTRATO = @CODICONTRATO")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND ISNULL(RTRIM(P.NOMBRES),'') + ' ' + ISNULL(RTRIM(P.APELLIDOS),'') LIKE @NOMBRE_PROVEEDOR)")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY M.CUI")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    Public Function ObtenerListaPorCriteriosZafra(ByVal ZONA As String, ByVal SUB_ZONA As String,
                                             ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String,
                                             ByVal CODI_CANTON As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal CODICONTRATO As Integer,
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal ID_ZAFRA_CONTRATO As Integer) As listaMAESTRO_LOTES
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT M.* FROM MAESTRO_LOTES M ")

        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "M.ZONA = @ZONA")
        End If
        If SUB_ZONA <> "" Then
            arg = New SqlParameter("@SUB_ZONA", SqlDbType.Char)
            arg.Value = SUB_ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "M.SUB_ZONA = @SUB_ZONA")
        End If
        If CODI_DEPTO <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.Char)
            arg.Value = CODI_DEPTO
            args.Add(arg)
            AgregarCondicion(strCond, "M.CODI_DEPTO = @CODI_DEPTO")
        End If
        If CODI_MUNI <> "" Then
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.Char)
            arg.Value = CODI_MUNI
            args.Add(arg)
            AgregarCondicion(strCond, "M.CODI_MUNI = @CODI_MUNI")
        End If
        If CODI_CANTON <> "" Then
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.Char)
            arg.Value = CODI_CANTON
            args.Add(arg)
            AgregarCondicion(strCond, "M.CODI_CANTON = @CODI_CANTON")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE)")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO)")
        End If
        If CODICONTRATO <> -1 Then
            arg = New SqlParameter("@CODICONTRATO", SqlDbType.Int)
            arg.Value = CODICONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "M.CODICONTRATO = @CODICONTRATO")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND ISNULL(RTRIM(P.NOMBRES),'') + ' ' + ISNULL(RTRIM(P.APELLIDOS),'') LIKE @NOMBRE_PROVEEDOR)")
        End If
        If ID_ZAFRA_CONTRATO <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA_CONTRATO", SqlDbType.VarChar)
            arg.Value = ID_ZAFRA_CONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "(SELECT COUNT(1) FROM LOTES L, CONTRATO_ZAFRAS CZ WHERE L.ID_MAESTRO = M.ID_MAESTRO AND L.CODICONTRATO = CZ.CODICONTRATO AND CZ.ID_ZAFRA = @ID_ZAFRA_CONTRATO) > 0")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY M.CUI")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerCorrelativoPorCanton(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT ISNULL(MAX(CAST(CORRELATIVO AS INT)),0) + 1 FROM MAESTRO_LOTES ")
        strSQL.Append("WHERE CODI_DEPTO = @CODI_DEPTO AND CODI_MUNI = @CODI_MUNI AND CODI_CANTON = @CODI_CANTON ")


        arg = New SqlParameter("@CODI_DEPTO", SqlDbType.Char)
        arg.Value = CODI_DEPTO
        args.Add(arg)

        arg = New SqlParameter("@CODI_MUNI", SqlDbType.Char)
        arg.Value = CODI_MUNI
        args.Add(arg)

        arg = New SqlParameter("@CODI_CANTON", SqlDbType.Char)
        arg.Value = CODI_CANTON
        args.Add(arg)


        Dim lRet As Int32 = 1
        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                lRet = CInt(dr(0))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCODIPROVEE(ByVal CODIPROVEE As String) As listaMAESTRO_LOTES
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT M.* FROM MAESTRO_LOTES M ")
        strSQL.Append("WHERE EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = M.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE) ")
        strSQL.Append("ORDER BY M.CODILOTE_COMER")

        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerRangoFlete(ByVal KMS As Decimal) As DataSet
        Dim connection As New SqlConnection
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim arg As SqlParameter
        Dim ds As New DataSet

        Try

            connection = New SqlConnection(Me.cnnStr)
            connection.Open()
            command = New SqlCommand()
            command.Connection = connection
            command.CommandText = "OBTENER_RANGO_FLETE"
            command.CommandType = CommandType.StoredProcedure
            command.CommandTimeout = 90000000

            arg = New SqlParameter("@KMS", KMS)
            command.Parameters.Add(arg)

            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()


        Catch ex As Exception
            Throw ex
        Finally
            command.Dispose()
            connection.Close()
        End Try

        Return ds

    End Function
End Class
