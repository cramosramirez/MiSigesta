Partial Public Class dbOPCION
    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades filtrada por el USUARIO
    ''' </summary>
    ''' <param name="pUsuario">Usuario.</param>    
    ''' <history>
    ''' 	[cramos]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorUSUARIO(ByVal pUsuario As String, Optional recuperarOcultas As Boolean = False) As listaOPCION
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT O.* FROM OPCION O, OPCION_PERFIL OP")
        strSQL.Append(" WHERE O.ID_OPCION = OP.ID_OPCION")
        strSQL.Append(" AND EXISTS(SELECT 1 FROM USUARIO U WHERE U.USUARIO = @USUARIO AND U.ID_PERFIL = OP.ID_PERFIL)")
        strSQL.Append(" AND O.ACTIVO = 1")
        If Not recuperarOcultas Then
            strSQL.Append(" AND LEFT(O.NOMBRE_OPCION,1) <> '+'")
        End If
        strSQL.Append(" ORDER BY O.ID_OPCION_PADRE, O.ORDEN")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        args(0).Value = pUsuario

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaOPCION

        Try
            Do While dr.Read()
                Dim mEntidad As New OPCION
                dbAsignarEntidades.AsignarOPCION(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function UsuarioTienePermiso(ByVal pUsuario As String, ByVal nombrePagina As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT O.* FROM OPCION O, OPCION_PERFIL OP")
        strSQL.Append(" WHERE O.ID_OPCION = OP.ID_OPCION")
        strSQL.Append(" AND EXISTS(SELECT 1 FROM USUARIO U WHERE U.USUARIO = @USUARIO AND U.ID_PERFIL = OP.ID_PERFIL)")
        strSQL.Append(" AND O.URL LIKE '%' + @NOMBRE_PAGINA + '%' ")
        strSQL.Append(" AND O.ACTIVO = 1")

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        arg.Value = pUsuario
        args.Add(arg)

        arg = New SqlParameter("@NOMBRE_PAGINA", SqlDbType.VarChar)
        arg.Value = nombrePagina
        args.Add(arg)


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim conPermiso As Boolean = False

        Try
            If dr.Read() Then
                conPermiso = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return conPermiso

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal recuperarOcultas As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaOPCION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New OPCION))
        If Not recuperarOcultas Then
            strSQL.Append(" WHERE LEFT(NOMBRE_OPCION,1) <> '+'")
        End If
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaOPCION

        Try
            Do While dr.Read()
                Dim mEntidad As New OPCION
                dbAsignarEntidades.AsignarOPCION(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades filtrada por el USUARIO
    ''' </summary>
    ''' <param name="pIdOpcionPadre">Usuario.</param>    
    ''' <history>
    ''' 	[cramos]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorOPCION_PADRE(ByVal pIdOpcionPadre As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaOPCION
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter
        strSQL.Append(Me.QuerySelect(New OPCION))

        If pIdOpcionPadre >= 0 Then
            strSQL.Append(" WHERE ID_OPCION_PADRE = @ID_OPCION_PADRE")
            args(0) = New SqlParameter("@ID_OPCION_PADRE", SqlDbType.Int)
            args(0).Value = pIdOpcionPadre
        Else
            strSQL.Append(" WHERE ID_OPCION_PADRE IS NULL")
        End If
        strSQL.Append(" ORDER BY ORDEN")


        Dim dr As IDataReader
        If pIdOpcionPadre >= 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaOPCION

        Try
            Do While dr.Read()
                Dim mEntidad As New OPCION
                dbAsignarEntidades.AsignarOPCION(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades filtrada por el USUARIO
    ''' </summary>
    ''' <param name="pIdOpcionPadre">Usuario.</param>    
    ''' <history>
    ''' 	[cramos]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorOPCION_PADRE_PERFIL(ByVal pIdOpcionPadre As Int32, ByVal IdPerfil As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaOPCION
        Dim strSQL As New StringBuilder
        Dim arg As SqlParameter
        Dim args As New List(Of SqlParameter)

        strSQL.Append("SELECT * FROM OPCION P")
        strSQL.Append(" WHERE P.ID_OPCION_PADRE = @ID_OPCION_PADRE")
        strSQL.Append(" AND EXISTS(SELECT 1 FROM OPCION_PERFIL OP WHERE OP.ID_OPCION = P.ID_OPCION AND OP.ID_PERFIL = @ID_PERFIL)")

        arg = New SqlParameter("@ID_OPCION_PADRE", SqlDbType.Int)
        arg.Value = pIdOpcionPadre
        args.Add(arg)

        arg = New SqlParameter("@ID_PERFIL", SqlDbType.Int)
        arg.Value = IdPerfil
        args.Add(arg)

        strSQL.Append(" ORDER BY ORDEN")


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaOPCION

        Try
            Do While dr.Read()
                Dim mEntidad As New OPCION
                dbAsignarEntidades.AsignarOPCION(dr, mEntidad)
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
