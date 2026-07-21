Partial Public Class dbSOLIC_APLICA_LOTE
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_APLICA_LOTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_APLICA_LOTE))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        args(1).Value = ACCESLOTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_APLICA_LOTE

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_APLICA_LOTE
                dbAsignarEntidades.AsignarSOLIC_APLICA_LOTE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorZAFRA_LOTE_NO_GENERICO(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_APLICA_LOTE

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_APLICA_LOTE S ")
        strSQL.Append("WHERE S.ID_ZAFRA = @ID_ZAFRA AND S.ACCESLOTE = @ACCESLOTE AND (SELECT COUNT(1) FROM PRODUCTO P WHERE P.ID_PRODUCTO = S.ID_PRODUCTO AND P.ID_CATEGORIA <> " & CStr(Enumeradores.CategoriaProducto.Generico) & ") > 0 ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        args(1).Value = ACCESLOTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_APLICA_LOTE

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_APLICA_LOTE
                dbAsignarEntidades.AsignarSOLIC_APLICA_LOTE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorZAFRA_LOTE_CATEGORIA(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal ID_CATEGORIA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_APLICA_LOTE

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_APLICA_LOTE S ")
        strSQL.Append("WHERE S.ID_ZAFRA = @ID_ZAFRA AND S.ACCESLOTE = @ACCESLOTE AND (SELECT COUNT(1) FROM PRODUCTO P WHERE P.ID_PRODUCTO = S.ID_PRODUCTO AND P.ID_CATEGORIA = " & CStr(ID_CATEGORIA) & ") > 0 ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        args(1).Value = ACCESLOTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_APLICA_LOTE

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_APLICA_LOTE
                dbAsignarEntidades.AsignarSOLIC_APLICA_LOTE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal NUM_SOLICITUD As Int32, ByVal CODIPROVEEDOR As String, ByVal ZONA As String, ByVal ID_CUENTA_FINAN As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_APLICA_LOTE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_APLICA_LOTE S ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            Me.AgregarCondicion(strCond, "S.ID_ZAFRA = @ID_ZAFRA")
        End If

        If ACCESLOTE <> "" Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
            arg.Value = ACCESLOTE
            args.Add(arg)
            Me.AgregarCondicion(strCond, "S.ACCESLOTE = @ACCESLOTE")
        End If

        If NUM_SOLICITUD <> -1 Then
            arg = New SqlParameter("@NUM_SOLICITUD", SqlDbType.Int)
            arg.Value = NUM_SOLICITUD
            args.Add(arg)
            Me.AgregarCondicion(strCond, "(SELECT COUNT(1) FROM SOLIC_AGRICOLA G WHERE G.ID_SOLICITUD = S.ID_SOLICITUD AND G.NUM_SOLICITUD = @NUM_SOLICITUD) > 0")
        End If

        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            Me.AgregarCondicion(strCond, "(SELECT COUNT(1) FROM SOLIC_AGRICOLA A WHERE A.ID_SOLICITUD = S.ID_SOLICITUD AND A.CODIPROVEEDOR = @CODIPROVEEDOR)>0")
        End If

        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.VarChar)
            arg.Value = ZONA
            args.Add(arg)
            Me.AgregarCondicion(strCond, "(SELECT COUNT(1) FROM LOTES L WHERE L.ACCESLOTE = S.ACCESLOTE AND L.ZONA = @ZONA) > 0")
        End If

        If ID_CUENTA_FINAN <> -1 Then
            arg = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
            arg.Value = ID_CUENTA_FINAN
            args.Add(arg)
            Me.AgregarCondicion(strCond, "(SELECT COUNT(1) FROM SOLIC_AGRICOLA G WHERE G.ID_SOLICITUD = S.ID_SOLICITUD AND G.ID_CUENTA_FINAN = @ID_CUENTA_FINAN) > 0")
        End If

        strSQL.Append(strCond.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaSOLIC_APLICA_LOTE

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_APLICA_LOTE
                dbAsignarEntidades.AsignarSOLIC_APLICA_LOTE(dr, mEntidad)
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
