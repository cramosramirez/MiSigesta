Partial Public Class dbLOTES_LG

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <param name="ID_PLAN_SEMANAL"></param>
    ''' <param name="CODIPROVEE"></param>
    ''' <param name="CODISOCIO"></param>
    ''' <param name="NOMBRE_PROVEEDOR"></param>
    ''' <param name="INCLUIR_LOTES_NO_PROGRAMADOS"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorCriterios1(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal ID_PLAN_SEMANAL As Integer, ByVal CODIPROVEE As String,
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, ByVal INCLUIR_LOTES_NO_PROGRAMADOS As Boolean,
                                               Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim tieneWhere As Boolean = False
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM( ")
        strSQL.Append("     SELECT ")
        strSQL.Append("     LOTES_LG.ACCESLOTE, LOTES_LG.CODILOTE, RTRIM(LOTES_LG.NOMBLOTE) AS NOMBLOTE, LOTES_LG.AREA, LOTES_LG.TONELADAS, LOTES_LG.TONEL_TC, LOTES_LG.ZONA, ")

        strSQL.Append("     ISNULL(( ")
        strSQL.Append("         SELECT SUM(PE.TONEL_PROGRAMADA) ")
        strSQL.Append("         FROM PLAN_ENTREGA_CANA PE, PLAN_SEMANAL PS, PLAN_CATORCENA PC ")
        strSQL.Append("         WHERE PE.ID_PLAN_SEMANAL = PS.ID_PLAN_SEMANAL ")
        strSQL.Append("             AND PS.ID_PLAN_CATORCENA = PC.ID_PLAN_CATORCENA ")
        strSQL.Append("             AND PE.ACCESLOTE = LOTES_LG.ACCESLOTE ")
        strSQL.Append("             AND EXISTS(SELECT 1 FROM PLAN_SEMANAL P, PLAN_CATORCENA C WHERE P.ID_PLAN_CATORCENA = C.ID_PLAN_CATORCENA AND P.ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL AND C.ID_ZAFRA = PC.ID_ZAFRA) ")
        strSQL.Append("     ),0) AS TONELADAS_PROGRAMADAS, ")
        strSQL.Append("     ISNULL((SELECT SUM(B.NETOTONEL) FROM ENVIO E, BASCULA B WHERE E.ID_ENVIO = B.ID_ENVIO AND E.ACCESLOTE = LOTES_LG.ACCESLOTE),0) AS TONELADAS_ENTREGADAS, ")
        strSQL.Append("     (SELECT PE.ID_PLAN_ENTREGA_CANA FROM PLAN_ENTREGA_CANA PE WHERE PE.ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL AND PE.ACCESLOTE = LOTES_LG.ACCESLOTE AND EXISTS(SELECT 1 FROM ORDEN_ROZA_DETA OD WHERE OD.ID_PLAN_ENTREGA_CANA = PE.ID_PLAN_ENTREGA_CANA ) ) AS ID_PLAN_ENTREGA_CANA, ")
        strSQL.Append("     LOTES_LG.EDAD_LOTE, LOTES_LG.CODIVARIEDA, VARIEDAD.NOM_VARIEDAD, LOTES_LG.CODIUBICACION, UBICACION.CANTON, ")
        strSQL.Append("     PROVEEDOR.CODIPROVEE, PROVEEDOR.CODISOCIO, RTRIM(PROVEEDOR.NOMBRES) + ' ' + RTRIM(PROVEEDOR.APELLIDOS) AS NOMBRE_PROVEEDOR, PROVEEDOR.CODIPROVEEDOR ")
        strSQL.Append("     FROM LOTES_LG INNER JOIN VARIEDAD ON LOTES_LG.CODIVARIEDA = VARIEDAD.CODIVARIEDA ")
        strSQL.Append("     INNER JOIN UBICACION ON LOTES_LG.CODIUBICACION = UBICACION.CODIUBICACION ")
        strSQL.Append("     INNER JOIN PROVEEDOR ON LOTES_LG.CODIPROVEEDOR = PROVEEDOR.CODIPROVEEDOR ")

        arg = New SqlParameter("@ID_PLAN_SEMANAL", SqlDbType.Int)
        arg.Value = ID_PLAN_SEMANAL
        args.Add(arg)

        If NOMBRE_ZAFRA IsNot Nothing AndAlso NOMBRE_ZAFRA <> "" Then
            arg = New SqlParameter("@NOMBRE_ZAFRA", SqlDbType.VarChar)
            arg.Value = NOMBRE_ZAFRA
            args.Add(arg)
            strSQL.Append(" WHERE LOTES.ANIOZAFRA = @NOMBRE_ZAFRA ")
            tieneWhere = True
        End If
        If Not INCLUIR_LOTES_NO_PROGRAMADOS AndAlso ID_PLAN_SEMANAL <> -1 Then
            strSQL.Append(IIf(tieneWhere, " AND ", " WHERE ") & " EXISTS(SELECT 1 FROM PLAN_ENTREGA_CANA EC WHERE EC.ACCESLOTE = LOTES.ACCESLOTE AND EC.ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL) ")
        End If
        strSQL.Append(") T ")

        If ZONA IsNot Nothing AndAlso ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.VarChar)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.ZONA = @ZONA ")
        End If
        If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODIPROVEE, 6)
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.CODIPROVEE = @CODIPROVEE ")
        End If
        If CODISOCIO IsNot Nothing AndAlso CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODISOCIO, 4)
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.CODISOCIO = @CODISOCIO ")
        End If

        strSQL.Append(strCondicion.ToString)

        strSQL.Append("ORDER BY CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, CODILOTE")

        Dim ds As DataSet

        If args.Count = 0 Then
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Try
            Return ds
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function ObtenerDataSetIngresoCenso(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal ID_PLAN_SEMANAL As Integer, ByVal CODIPROVEE As String,
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, ByVal INCLUIR_LOTES_NO_PROGRAMADOS As Boolean,
                                               Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim tieneWhere As Boolean = False
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM( ")
        strSQL.Append("     SELECT ")
        strSQL.Append("     LOTES.ACCESLOTE, LOTES.CODILOTE, RTRIM(LOTES.NOMBLOTE) AS NOMBLOTE, LOTES.AREA, LOTES.TONELADAS, LOTES.TONEL_TC, LOTES.ZONA, ")

        strSQL.Append("     ISNULL(( ")
        strSQL.Append("         SELECT SUM(PE.TONEL_PROGRAMADA) ")
        strSQL.Append("         FROM PLAN_ENTREGA_CANA PE, PLAN_SEMANAL PS, PLAN_CATORCENA PC ")
        strSQL.Append("         WHERE PE.ID_PLAN_SEMANAL = PS.ID_PLAN_SEMANAL ")
        strSQL.Append("             AND PS.ID_PLAN_CATORCENA = PC.ID_PLAN_CATORCENA ")
        strSQL.Append("             AND PE.ACCESLOTE = LOTES.ACCESLOTE ")
        strSQL.Append("             AND EXISTS(SELECT 1 FROM PLAN_SEMANAL P, PLAN_CATORCENA C WHERE P.ID_PLAN_CATORCENA = C.ID_PLAN_CATORCENA AND P.ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL AND C.ID_ZAFRA = PC.ID_ZAFRA) ")
        strSQL.Append("     ),0) AS TONELADAS_PROGRAMADAS, ")
        strSQL.Append("     ISNULL((SELECT SUM(B.NETOTONEL) FROM ENVIO E, BASCULA B WHERE E.ID_ENVIO = B.ID_ENVIO AND E.ACCESLOTE = LOTES.ACCESLOTE),0) AS TONELADAS_ENTREGADAS, ")
        strSQL.Append("     (SELECT PE.ID_PLAN_ENTREGA_CANA FROM PLAN_ENTREGA_CANA PE WHERE PE.ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL AND PE.ACCESLOTE = LOTES.ACCESLOTE AND EXISTS(SELECT 1 FROM ORDEN_ROZA_DETA OD WHERE OD.ID_PLAN_ENTREGA_CANA = PE.ID_PLAN_ENTREGA_CANA ) ) AS ID_PLAN_ENTREGA_CANA, ")
        strSQL.Append("     LOTES.EDAD_LOTE, LOTES.CODIVARIEDA, VARIEDAD.NOM_VARIEDAD, LOTES.CODIUBICACION, UBICACION.CANTON, ")
        strSQL.Append("     PROVEEDOR.CODIPROVEE, PROVEEDOR.CODISOCIO, RTRIM(PROVEEDOR.NOMBRES) + ' ' + RTRIM(PROVEEDOR.APELLIDOS) AS NOMBRE_PROVEEDOR, PROVEEDOR.CODIPROVEEDOR ")
        strSQL.Append("     FROM LOTES INNER JOIN VARIEDAD ON LOTES.CODIVARIEDA = VARIEDAD.CODIVARIEDA ")
        strSQL.Append("     INNER JOIN UBICACION ON LOTES.CODIUBICACION = UBICACION.CODIUBICACION ")
        strSQL.Append("     INNER JOIN PROVEEDOR ON LOTES.CODIPROVEEDOR = PROVEEDOR.CODIPROVEEDOR ")

        arg = New SqlParameter("@ID_PLAN_SEMANAL", SqlDbType.Int)
        arg.Value = ID_PLAN_SEMANAL
        args.Add(arg)

        If NOMBRE_ZAFRA IsNot Nothing AndAlso NOMBRE_ZAFRA <> "" Then
            arg = New SqlParameter("@NOMBRE_ZAFRA", SqlDbType.VarChar)
            arg.Value = NOMBRE_ZAFRA
            args.Add(arg)
            strSQL.Append(" WHERE LOTES.ANIOZAFRA = @NOMBRE_ZAFRA ")
            tieneWhere = True
        End If
        If Not INCLUIR_LOTES_NO_PROGRAMADOS AndAlso ID_PLAN_SEMANAL <> -1 Then
            strSQL.Append(IIf(tieneWhere, " AND ", " WHERE ") & " EXISTS(SELECT 1 FROM PLAN_ENTREGA_CANA EC WHERE EC.ACCESLOTE = LOTES.ACCESLOTE AND EC.ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL) ")
        End If
        strSQL.Append(") T ")

        If ZONA IsNot Nothing AndAlso ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.VarChar)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.ZONA = @ZONA ")
        End If
        If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODIPROVEE, 6)
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.CODIPROVEE = @CODIPROVEE ")
        End If
        If CODISOCIO IsNot Nothing AndAlso CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODISOCIO, 4)
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.CODISOCIO = @CODISOCIO ")
        End If

        strSQL.Append(strCondicion.ToString)

        strSQL.Append("ORDER BY CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, CODILOTE")

        Dim ds As DataSet

        If args.Count = 0 Then
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Try
            Return ds
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <param name="CODIPROVEE"></param>
    ''' <param name="CODISOCIO"></param>
    ''' <param name="NOMBRE_PROVEEDOR"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorCriterios2(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal CODIPROVEE As String,
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String,
                                               Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT T.* ")
        strSQL.Append("FROM( ")
        strSQL.Append("     SELECT ")
        strSQL.Append("         (SELECT TR.ROZA FROM TARIFA_ROZA TR WHERE TR.ACCESLOTE = LOTES.ACCESLOTE) AS ROZA, ")
        strSQL.Append("     LOTES.ACCESLOTE, LOTES.CODILOTE, RTRIM(LOTES.NOMBLOTE) AS NOMBLOTE, PROVEEDOR.CODIPROVEE, PROVEEDOR.CODISOCIO, ")
        strSQL.Append("     RTRIM(PROVEEDOR.NOMBRES) + ' ' + RTRIM(PROVEEDOR.APELLIDOS) AS NOMBRE_PROVEEDOR, LOTES.CODICONTRATO, LOTES.AREA, LOTES.ZONA, ")
        strSQL.Append("     LOTES.TONELADAS ")
        strSQL.Append("     FROM PROVEEDOR INNER JOIN ")
        strSQL.Append("     LOTES ON PROVEEDOR.CODIPROVEEDOR = LOTES.CODIPROVEEDOR ")
        If NOMBRE_ZAFRA IsNot Nothing AndAlso NOMBRE_ZAFRA <> "" Then
            arg = New SqlParameter("@NOMBRE_ZAFRA", SqlDbType.VarChar)
            arg.Value = NOMBRE_ZAFRA
            args.Add(arg)
            strSQL.Append(" WHERE LOTES.ANIOZAFRA = @NOMBRE_ZAFRA ")
        End If
        strSQL.Append(") T ")

        If ZONA IsNot Nothing AndAlso ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.VarChar)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.ZONA = @ZONA ")
        End If
        If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODIPROVEE, 6)
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.CODIPROVEE = @CODIPROVEE ")
        End If
        If CODISOCIO IsNot Nothing AndAlso CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODISOCIO, 4)
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.CODISOCIO = @CODISOCIO ")
        End If
        If NOMBRE_PROVEEDOR IsNot Nothing AndAlso NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = NOMBRE_PROVEEDOR.ToUpper
            args.Add(arg)
            AgregarCondicion(strCondicion, " T.NOMBRE_PROVEEDOR LIKE '%' + @NOMBRE_PROVEEDOR + '%' ")
        End If

        strSQL.Append(strCondicion.ToString)

        strSQL.Append("ORDER BY CODIPROVEE, CODISOCIO, CODILOTE")

        Dim ds As DataSet

        If args.Count = 0 Then
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Try
            Return ds
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <param name="ID_PLAN_SEMANAL"></param>
    ''' <param name="CODIPROVEE"></param>
    ''' <param name="CODISOCIO"></param>
    ''' <param name="NOMBRE_PROVEEDOR"></param>
    ''' <param name="INCLUIR_LOTES_NO_PROGRAMADOS"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal ID_PLAN_SEMANAL As Integer, ByVal CODIPROVEE As String,
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, ByVal INCLUIR_LOTES_NO_PROGRAMADOS As Boolean,
                                               Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES_LG
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim tieneWhere As Boolean = False
        Dim aEntidad As LOTES_LG
        Dim listadoLotes As New listaLOTES_LG
        strSQL.Append("     SELECT LOTES_LG.*, PROVEEDOR.CODIPROVEE, PROVEEDOR.CODISOCIO, PROVEEDOR.NOMBRES + ' ' + PROVEEDOR.APELLIDOS AS PROVEEDOR, LOTES.NOMBLOTE ")
        strSQL.Append("     FROM PROVEEDOR INNER JOIN ")
        strSQL.Append("     LOTES_LG ON PROVEEDOR.CODIPROVEEDOR = LOTES.CODIPROVEEDOR ")

        If NOMBRE_ZAFRA IsNot Nothing AndAlso NOMBRE_ZAFRA <> "" Then
            arg = New SqlParameter("@NOMBRE_ZAFRA", SqlDbType.VarChar)
            arg.Value = NOMBRE_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCondicion, " LOTES.ANIOZAFRA = @NOMBRE_ZAFRA ")
        End If
        If Not INCLUIR_LOTES_NO_PROGRAMADOS AndAlso ID_PLAN_SEMANAL <> -1 Then
            arg = New SqlParameter("@ID_PLAN_SEMANAL", SqlDbType.Int)
            arg.Value = ID_PLAN_SEMANAL
            args.Add(arg)
            AgregarCondicion(strCondicion, " EXISTS(SELECT 1 FROM PLAN_ENTREGA_CANA EC WHERE EC.ACCESLOTE = LOTES.ACCESLOTE AND EC.ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL) ")
        End If
        If ZONA IsNot Nothing AndAlso ZONA.Trim <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.VarChar)
            arg.Value = ZONA.Trim
            args.Add(arg)
            AgregarCondicion(strCondicion, " LOTES_LG.ZONA = @ZONA ")
        End If
        If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODIPROVEE, 6)
            args.Add(arg)
            AgregarCondicion(strCondicion, " PROVEEDOR.CODIPROVEE = @CODIPROVEE ")
        End If
        If CODISOCIO IsNot Nothing AndAlso CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODISOCIO, 4)
            args.Add(arg)
            AgregarCondicion(strCondicion, " PROVEEDOR.CODISOCIO = @CODISOCIO ")
        End If
        If NOMBRE_PROVEEDOR IsNot Nothing AndAlso NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = NOMBRE_PROVEEDOR.ToUpper
            args.Add(arg)
            AgregarCondicion(strCondicion, " PROVEEDOR.NOMBRES + ' ' + PROVEEDOR.APELLIDOS LIKE '%' + @NOMBRE_PROVEEDOR + '%' ")
        End If

        strSQL.Append(strCondicion.ToString)

        strSQL.Append("ORDER BY CODIPROVEE, CODISOCIO, CODILOTE")

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Try
            While dr.Read()
                aEntidad = New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, aEntidad)
                Dim strDescrip As New StringBuilder
                strDescrip.Append(aEntidad.CODILOTE)
                strDescrip.Append(" - ")
                strDescrip.Append(dr("NOMBLOTE"))
                strDescrip.Append(" - CLIENTE: ")
                strDescrip.Append(dr("PROVEEDOR").ToString)
                aEntidad.DESCRIPCION = strDescrip.ToString
                listadoLotes.Add(aEntidad)
            End While
        Catch ex As Exception
            Throw ex
        End Try

        Return listadoLotes
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros.
    ''' </summary>  
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios2(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String,
                                              ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String,
                                              ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String) As listaLOTES_LG
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim tieneWhere As Boolean = False
        Dim aEntidad As LOTES_LG
        Dim listadoLotes As New listaLOTES_LG
        strSQL.Append("SELECT L.* ")
        strSQL.Append("FROM LOTES L, PROVEEDOR P ")
        strSQL.Append("WHERE L.CODIPROVEEDOR = P.CODIPROVEEDOR ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            strSQL.Append(" AND EXISTS(SELECT 1 FROM CONTRATO_ZAFRAS CZ WHERE CZ.CODICONTRATO = L.CODICONTRATO AND CZ.ID_ZAFRA = @ID_ZAFRA)")
        End If
        If ZONA IsNot Nothing AndAlso ZONA.Trim <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.VarChar)
            arg.Value = ZONA.Trim
            args.Add(arg)
            strSQL.Append(" AND L.ZONA = @ZONA")
        End If
        If CODI_CANTON IsNot Nothing AndAlso CODI_CANTON.Trim <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO.Trim
            args.Add(arg)
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
            arg.Value = CODI_MUNI.Trim
            args.Add(arg)
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.VarChar)
            arg.Value = CODI_CANTON.Trim
            args.Add(arg)
            strSQL.Append(" AND EXISTS(SELECT 1 FROM MAESTRO_LOTES ML WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = @CODI_DEPTO AND ML.CODI_MUNI = @CODI_MUNI AND ML.CODI_CANTON = @CODI_CANTON)")
        ElseIf CODI_MUNI IsNot Nothing AndAlso CODI_MUNI.Trim <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO.Trim
            args.Add(arg)
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
            arg.Value = CODI_MUNI.Trim
            args.Add(arg)
            strSQL.Append(" AND EXISTS(SELECT 1 FROM MAESTRO_LOTES ML WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = @CODI_DEPTO AND ML.CODI_MUNI = @CODI_MUNI)")
        ElseIf CODI_DEPTO IsNot Nothing AndAlso CODI_DEPTO.Trim <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO.Trim
            args.Add(arg)
            strSQL.Append(" AND EXISTS(SELECT 1 FROM MAESTRO_LOTES ML WHERE ML.ID_MAESTRO = L.ID_MAESTRO AND ML.CODI_DEPTO = @CODI_DEPTO)")
        End If
        If CODIPROVEE IsNot Nothing AndAlso CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODIPROVEE, 6)
            args.Add(arg)
            strSQL.Append(" AND P.CODIPROVEE = @CODIPROVEE")
        End If
        If CODISOCIO IsNot Nothing AndAlso CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.VarChar)
            arg.Value = Utilerias.RellenarIzquierda(CODISOCIO, 4)
            args.Add(arg)
            strSQL.Append(" AND PROVEEDOR.CODISOCIO = @CODISOCIO")
        End If
        If NOMBRE_PROVEEDOR IsNot Nothing AndAlso NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = NOMBRE_PROVEEDOR.ToUpper
            args.Add(arg)
            strSQL.Append(" AND RTRIM(ISNULL(P.NOMBRES,'')) + ' ' + RTRIM(ISNULL(P.APELLIDOS,'')) LIKE '%' + @NOMBRE_PROVEEDOR + '%'")
        End If
        strSQL.Append(" ORDER BY L.ZONA, L.SUB_ZONA")

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Try
            While dr.Read()
                aEntidad = New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, aEntidad)
                listadoLotes.Add(aEntidad)
            End While
        Catch ex As Exception
            Throw ex
        End Try

        Return listadoLotes
    End Function

    Public Function AsignarAgronomo(ByVal ACCESLOTE As String, ByVal CODIAGRON As String) As Integer
        Dim lRet As Integer = 0
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE LOTES_LG SET CODIAGRON = @CODIAGRON WHERE ACCESLOTE = @ACCESLOTE ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@CODIAGRON", SqlDbType.VarChar)
        args(0).Value = CODIAGRON

        args(1) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(1).Value = ACCESLOTE

        Try
            lRet = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Catch ex As Exception
            Throw ex

        End Try

        Return lRet

    End Function

    Public Function ObtenerListaPorANIOZAFRA_PROVEEDOR(ByVal ANIOZAFRA As String, ByVal CODIPROVEEDOR As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        strSQL.Append(" WHERE ANIOZAFRA = @ANIOZAFRA ")
        strSQL.Append(" AND CODIPROVEEDOR = @CODIPROVEEDOR ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ANIOZAFRA", SqlDbType.VarChar)
        args(0).Value = ANIOZAFRA

        args(1) = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        args(1).Value = CODIPROVEEDOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorZAFRA_NO_CONTRATO(ByVal ID_ZAFRA As Int32, ByVal NO_CONTRATO As Int32, Optional ByVal asColumnaOrden As String = "C.NO_CONTRATO, L.CODILOTE", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES_LG
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT L.* FROM LOTES L, CONTRATO C, CONTRATO_ZAFRAS CZ ")
        strSQL.Append(" WHERE L.CODICONTRATO = C.CODICONTRATO ")
        strSQL.Append(" AND C.CODICONTRATO = CZ.CODICONTRATO ")
        strSQL.Append(" AND CZ.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append(" AND C.NO_CONTRATO = @NO_CONTRATO ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@NO_CONTRATO", SqlDbType.Int)
        arg.Value = NO_CONTRATO
        args.Add(arg)


        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODIAGRON As String, Optional ByVal asColumnaOrden As String = "L.CODIPROVEEDOR, L.CODILOTE", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES_LG
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT L.* FROM LOTES L, CONTRATO C, CONTRATO_ZAFRAS CZ ")
        strSQL.Append(" WHERE L.CODICONTRATO = C.CODICONTRATO ")
        strSQL.Append(" AND C.CODICONTRATO = CZ.CODICONTRATO ")
        strSQL.Append(" AND CZ.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append(" AND C.CODIPROVEEDOR = @CODIPROVEEDOR ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.Char)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)



        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Char)
            arg.Value = CODIAGRON
            args.Add(arg)
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = CZ.ID_ZAFRA AND LC.CODIAGRON = @CODIAGRON) ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODIAGRON As String, Optional ByVal asColumnaOrden As String = "L.CODIPROVEEDOR, L.CODILOTE", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES_LG
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT L.* FROM LOTES_LG L, CONTRATO_LG C, CONTRATO_ZAFRAS_LG CZ ")
        strSQL.Append(" WHERE L.CODICONTRATO = C.CODICONTRATO ")
        strSQL.Append(" AND C.CODICONTRATO = CZ.CODICONTRATO ")
        strSQL.Append(" AND CZ.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append(" AND L.CODIPROVEEDOR = @CODIPROVEEDOR ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.Char)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        If CODIAGRON <> "" Then
            arg = New SqlParameter("@CODIAGRON", SqlDbType.Char)
            arg.Value = CODIAGRON
            args.Add(arg)
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES_COSECHA LC WHERE LC.ACCESLOTE = L.ACCESLOTE AND LC.ID_ZAFRA = CZ.ID_ZAFRA AND LC.CODIAGRON = @CODIAGRON) ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerTonelLibrasEntregadasPorZafraLote(ByVal ID_ZAFRA As Integer, ByVal ACCESLOTE As String) As Dictionary(Of String, Decimal)
        Dim dic As New Dictionary(Of String, Decimal)
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT SUM(B.NETOTONEL) AS NETOTONEL, SUM(A.AZUCAR_CATORCENA_REAL) AS AZUCAR_CATORCENA_REAL, ROUND(SUM(A.AZUCAR_CATORCENA_REAL)/SUM(B.NETOTONEL),4) AS RENDIMIENTO, SUM(PAGO_CATORCENA_REAL) AS PAGO ")
        strSQL.Append("FROM  ENVIO E, ANALISIS A, BASCULA B, ZAFRA Z ")
        strSQL.Append("WHERE E.ID_ENVIO = A.ID_ENVIO ")
        strSQL.Append("AND E.ID_ENVIO = B.ID_ENVIO ")
        strSQL.Append("AND E.ID_ZAFRA = Z.ID_ZAFRA ")
        strSQL.Append("AND E.ACCESLOTE = @ACCESLOTE ")
        strSQL.Append("AND Z.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("AND E.CATORCENA <= (SELECT MAX(C.CATORCENA) FROM CATORCENA_ZAFRA C WHERE C.ID_ZAFRA = Z.ID_ZAFRA) ")
        strSQL.Append("AND NOT B.NETOTONEL IS NULL AND NOT A.AZUCAR_CATORCENA_REAL IS NULL ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        arg.Value = ACCESLOTE
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                dic.Add("Toneladas", CDec(dr(0)))
                dic.Add("Libras", CDec(dr(1)))
                dic.Add("Rendimiento", CDec(dr(2)))
                dic.Add("Pago", CDec(dr(3)))
            Else
                dic = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return dic
    End Function

    Public Function ObtenerTonelLibrasEntregadasPorZafraLoteFechaTara(ByVal ID_ZAFRA As Integer, ByVal ACCESLOTE As String, ByVal FECHA_LEE_TARA As DateTime) As Dictionary(Of String, Decimal)
        Dim dic As New Dictionary(Of String, Decimal)
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT SUM(B.NETOTONEL) AS NETOTONEL, SUM(A.AZUCAR_CATORCENA_REAL) AS AZUCAR_CATORCENA_REAL, ROUND(SUM(A.AZUCAR_CATORCENA_REAL)/SUM(B.NETOTONEL),4) AS RENDIMIENTO, SUM(PAGO_CATORCENA_REAL) AS PAGO ")
        strSQL.Append("FROM  ENVIO E, ANALISIS A, BASCULA B, ZAFRA Z ")
        strSQL.Append("WHERE E.ID_ENVIO = A.ID_ENVIO ")
        strSQL.Append("AND E.ID_ENVIO = B.ID_ENVIO ")
        strSQL.Append("AND E.ID_ZAFRA = Z.ID_ZAFRA ")
        strSQL.Append("AND E.ACCESLOTE = @ACCESLOTE ")
        strSQL.Append("AND Z.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("AND B.FECHA_LEE_TARA <= @FECHA_LEE_TARA ")
        strSQL.Append("AND NOT B.NETOTONEL IS NULL ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        arg.Value = ACCESLOTE
        args.Add(arg)

        arg = New SqlParameter("@FECHA_LEE_TARA", SqlDbType.DateTime)
        arg.Value = FECHA_LEE_TARA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                dic.Add("Toneladas", CDec(dr(0)))
                dic.Add("Libras", CDec(dr(1)))
                dic.Add("Rendimiento", CDec(dr(2)))
                dic.Add("Pago", CDec(dr(3)))
            Else
                dic = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return dic
    End Function


    Public Function ObtenerListaPorZAFRA_MAESTRO_LOTES(ByVal ID_ZAFRA As Integer, ByVal ID_MAESTRO As Int32, Optional CODICONTRATO_NOINCLUIR As String = "") As listaLOTES_LG
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT L.* FROM LOTES_LG L ")
        strSQL.Append(" WHERE L.ID_MAESTRO = @ID_MAESTRO ")
        strSQL.Append(" AND (SELECT COUNT(1) FROM CONTRATO_ZAFRAS_LG CZ WHERE CZ.CODICONTRATO = L.CODICONTRATO AND CZ.ID_ZAFRA = @ID_ZAFRA) > 0")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_MAESTRO", SqlDbType.Int)
        arg.Value = ID_MAESTRO
        args.Add(arg)

        If CODICONTRATO_NOINCLUIR <> "" Then
            arg = New SqlParameter("@NO_CONTRATO_NOINCLUIR", SqlDbType.Char)
            arg.Value = CODICONTRATO_NOINCLUIR
            args.Add(arg)
            strSQL.Append(" AND L.CODICONTRATO <> @NO_CONTRATO_NOINCLUIR ")
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As LOTES_LG
        lEntidad = CType(aEntidad, LOTES_LG)

        If lEntidad.ACCESLOTE = "" Then
            Dim lMaestro As New MAESTRO_LOTES
            lMaestro.ID_MAESTRO = lEntidad.ID_MAESTRO
            Dim dMaestro As New dbMAESTRO_LOTES
            dMaestro.Recuperar(lMaestro)
            lEntidad.ACCESLOTE = lEntidad.ANIOZAFRA + lMaestro.CUI
            Return Agregar(lEntidad)
        End If

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


End Class
