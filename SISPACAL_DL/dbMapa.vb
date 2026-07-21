Imports System.Text

Public Class dbMapa
    Inherits dbBase

#Region "Métodos clase base"
    Public Overrides Function Actualizar(aEntidad As EL.entidadBase) As Integer
        Return -1
    End Function

    Public Overrides Function Agregar(aEntidad As EL.entidadBase) As Integer
        Return -1
    End Function

    Public Overrides Function Eliminar(aEntidad As EL.entidadBase) As Integer
        Return -1
    End Function

    Public Overrides Function ObtenerID(aEntidad As EL.entidadBase) As Object
        Return Nothing
    End Function

    Public Overrides Function Recuperar(aEntidad As EL.entidadBase) As Integer
        Return -1
    End Function
#End Region

    Public Function ObtenerDataSetPorCriterios2(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal CODIPROVEE As String, _
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, _
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

    Public Function ObtenerListaPorUBICACION_GEOGRAFICA(ByVal ANIOZAFRA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal ZONA As String, Optional CON_ENTREGA_CANA As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT L.* FROM LOTES L, MAESTRO_LOTES M ")
        strSQL.Append("WHERE L.ID_MAESTRO = M.ID_MAESTRO AND L.ANIOZAFRA = @ANIOZAFRA ")

        arg = New SqlParameter("@ANIOZAFRA", SqlDbType.VarChar)
        arg.Value = ANIOZAFRA
        args.Add(arg)

        If CODI_DEPTO IsNot Nothing AndAlso CODI_DEPTO <> "" Then
            strSQL.Append("AND M.CODI_DEPTO = @CODI_DEPTO ")
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO
            args.Add(arg)
        End If

        If CODI_MUNI IsNot Nothing AndAlso CODI_MUNI <> "" Then
            strSQL.Append("AND M.CODI_MUNI = @CODI_MUNI ")
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
            arg.Value = CODI_MUNI
            args.Add(arg)
        End If

        If ZONA IsNot Nothing AndAlso ZONA <> "" Then
            strSQL.Append(" AND M.ZONA = @ZONA ")
            arg = New SqlParameter("@ZONA", SqlDbType.VarChar)
            arg.Value = ZONA
            args.Add(arg)
        End If

        If CON_ENTREGA_CANA Then
            strSQL.Append(" AND EXISTS(SELECT 1 FROM ENVIO E WHERE E.ACCESLOTE = L.ACCESLOTE) ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaLOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES
                dbAsignarEntidades.AsignarLOTES(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerPorcentajeCanaQuemada(ByVal ID_ZAFRA As Integer, ByVal NOMBRE_DEPTO As String, ByVal NOMBRE_MUNI As String, ByVal CANTON As String, ByVal ZONA As String) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SUM(B.NETOTONEL) AS TONEL, E.ID_TIPO_CANA, TC.NOMBRE_CANA  ")
        strSQL.Append("FROM ENVIO E, BASCULA B, TIPO_CANA TC ")
        strSQL.Append("WHERE E.ID_ENVIO = B.ID_ENVIO ")
        strSQL.Append("AND E.ID_TIPO_CANA = TC.ID_TIPO_CANA ")
        strSQL.Append("AND E.ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        If NOMBRE_DEPTO <> "" Then
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES L, UBICACION U WHERE L.ACCESLOTE = E.ACCESLOTE AND L.CODIUBICACION = U.CODIUBICACION AND U.DEPARTAMENTO = @NOMBRE_DEPTO) ")
            arg = New SqlParameter("@NOMBRE_DEPTO", SqlDbType.VarChar)
            arg.Value = NOMBRE_DEPTO
            args.Add(arg)
        End If

        If NOMBRE_MUNI <> "" Then
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES L, UBICACION U WHERE L.ACCESLOTE = E.ACCESLOTE AND L.CODIUBICACION = U.CODIUBICACION AND U.MUNICIPIO = @NOMBRE_MUNI) ")
            arg = New SqlParameter("@NOMBRE_MUNI", SqlDbType.VarChar)
            arg.Value = NOMBRE_MUNI
            args.Add(arg)
        End If

        If CANTON <> "" Then
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES L, UBICACION U WHERE L.ACCESLOTE = E.ACCESLOTE AND L.CODIUBICACION = U.CODIUBICACION AND U.CANTON = @CANTON) ")
            arg = New SqlParameter("@CANTON", SqlDbType.VarChar)
            arg.Value = CANTON
            args.Add(arg)
        End If

        If ZONA <> "" Then
            strSQL.Append("AND EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = E.ACCESLOTE AND L.ZONA = @ZONA) ")
            arg = New SqlParameter("@ZONA", SqlDbType.VarChar)
            arg.Value = ZONA
            args.Add(arg)
        End If

        strSQL.Append("GROUP BY E.ID_TIPO_CANA, TC.NOMBRE_CANA")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaLOTES
        Dim canaTotal As Decimal = 0
        Dim canaQuemada As Decimal = 0
        Dim lRet As Decimal = 0

        Try
            Do While dr.Read()
                If dr("ID_TIPO_CANA") = 27 OrElse dr("ID_TIPO_CANA") = 43 Then
                    canaQuemada += dr("TONEL")
                End If
                canaTotal += dr("TONEL")
            Loop
            If canaTotal > 0 Then
                lRet = Math.Round(canaQuemada / canaTotal, 0)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet

    End Function


    Public Function ObtenerInfoContratadoEntregado(ByVal ID_CENSO As Int32, _
                                                        ByVal CODI_DEPTO As String, _
                                                        ByVal CODI_MUNI As String, _
                                                        ByVal CODI_CANTON As String, _
                                                        ByVal ZONA As String, _
                                                        ByVal SUB_ZONA As String) As Dictionary(Of String, Object)
        Dim dicc As New Dictionary(Of String, Object)
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.AppendLine(" SELECT	COUNT(DISTINCT CODIPROVEEDOR) AS CANEROS,")
        strSQL.AppendLine("		COUNT(DISTINCT CODICONTRATO) AS CONTRATOS,")
        strSQL.AppendLine("		COUNT(DISTINCT ID_MAESTRO) AS LOTES,")
        strSQL.AppendLine("		SUM(AREA) AS MZ_CONTRATADO,")
        strSQL.AppendLine("		CASE WHEN SUM(AREA)>0 THEN ROUND(SUM(TONEL_TC)/SUM(AREA),2) ELSE 0 END AS TC_MZ_CONTRATADO,")
        strSQL.AppendLine("		SUM(TONEL_TC) AS TONEL_CONTRATADO,")
        strSQL.AppendLine("		SUM(MZ_CENSO) AS MZ_CENSO,")
        strSQL.AppendLine("		CASE WHEN SUM(MZ_CENSO)>0 THEN ROUND(SUM(TONEL_CENSO)/SUM(MZ_CENSO),2) ELSE 0 END AS TC_MZ_CENSO,")
        strSQL.AppendLine("		SUM(TONEL_CENSO) AS TONEL_CENSO,")
        strSQL.AppendLine("		SUM(MZ_ENTREGADA) AS MZ_ENTREGADO,")
        strSQL.AppendLine("		CASE WHEN SUM(MZ_ENTREGADA)>0 THEN ROUND(SUM(TONEL_ENTREGADA)/SUM(MZ_ENTREGADA),2) ELSE 0 END AS TC_MZ_ENTREGADO,")
        strSQL.AppendLine("		SUM(TONEL_ENTREGADA) AS TONEL_ENTREGADO		")
        strSQL.AppendLine(" FROM (")
        strSQL.AppendLine("	SELECT ")
        strSQL.AppendLine("		L.CODIPROVEEDOR,")
        strSQL.AppendLine("		L.CODICONTRATO,")
        strSQL.AppendLine("		L.ID_MAESTRO,")
        strSQL.AppendLine("		L.AREA,		")
        strSQL.AppendLine("		L.TONEL_TC,	")
        strSQL.AppendLine("		CL.MZ_CENSO,	")
        strSQL.AppendLine("		CL.TONEL_CENSO, ")
        strSQL.AppendLine("		CL.MZ_ENTREGADA,		")
        strSQL.AppendLine("		CL.TONEL_ENTREGADA")
        strSQL.AppendLine("	FROM LOTES L, MAESTRO_LOTES M, CENSO_LOTES CL ")

        AgregarCondicion(strCondicion, " L.ID_MAESTRO = M.ID_MAESTRO ")
        AgregarCondicion(strCondicion, " L.ACCESLOTE = CL.ACCESLOTE ")


        If ID_CENSO <> -1 Then
            arg = New SqlParameter("@ID_CENSO", SqlDbType.Int)
            arg.Value = ID_CENSO
            args.Add(arg)
            AgregarCondicion(strCondicion, " CL.ID_CENSO = @ID_CENSO ")
        End If
        If CODI_DEPTO IsNot Nothing AndAlso CODI_DEPTO <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_DEPTO = @CODI_DEPTO ")
        End If
        If CODI_MUNI IsNot Nothing AndAlso CODI_MUNI <> "" Then
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
            arg.Value = CODI_MUNI
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_MUNI = @CODI_MUNI ")
        End If
        If CODI_CANTON IsNot Nothing AndAlso CODI_CANTON <> "" Then
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.VarChar)
            arg.Value = CODI_CANTON
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_CANTON = @CODI_CANTON ")
        End If
        strSQL.Append(strCondicion.ToString)
        strSQL.AppendLine(") T")

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Try
            If dr.Read() Then
                dicc.Add("CANEROS", dr("CANEROS"))
                dicc.Add("CONTRATOS", dr("CONTRATOS"))
                dicc.Add("LOTES", dr("LOTES"))
                dicc.Add("MZ_CONTRATADO", dr("MZ_CONTRATADO"))
                dicc.Add("TC_MZ_CONTRATADO", dr("TC_MZ_CONTRATADO"))
                dicc.Add("TONEL_CONTRATADO", dr("TONEL_CONTRATADO"))

                dicc.Add("MZ_CENSO", dr("MZ_CENSO"))
                dicc.Add("TC_MZ_CENSO", dr("TC_MZ_CENSO"))
                dicc.Add("TONEL_CENSO", dr("TONEL_CENSO"))

                dicc.Add("MZ_ENTREGADO", dr("MZ_ENTREGADO"))
                dicc.Add("TC_MZ_ENTREGADO", dr("TC_MZ_ENTREGADO"))
                dicc.Add("TONEL_ENTREGADO", dr("TONEL_ENTREGADO"))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return dicc
    End Function


    Public Function ObtenerDataSetEntregaPorCatorcena(ByVal NOMBRE_ZAFRA As String, _
                                                      ByVal CODI_DEPTO As String, _
                                                      ByVal CODI_MUNI As String, _
                                                      ByVal CODI_CANTON As String, _
                                                      ByVal ZONA As String, _
                                                      ByVal SUB_ZONA As String) As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT MC.NO_CATORCENA, SUM(MC.NETOTONEL) AS NETOTONEL ")
        strSQL.Append("FROM MOV_CATORCENA MC, ENVIO E, LOTES L, MAESTRO_LOTES M ")

        AgregarCondicion(strCondicion, " MC.ID_ENVIO = E.ID_ENVIO ")
        AgregarCondicion(strCondicion, " E.ACCESLOTE = L.ACCESLOTE ")
        AgregarCondicion(strCondicion, " L.ID_MAESTRO = M.ID_MAESTRO ")

        If NOMBRE_ZAFRA IsNot Nothing AndAlso NOMBRE_ZAFRA <> "" Then
            arg = New SqlParameter("@ANIOZAFRA", SqlDbType.VarChar)
            arg.Value = NOMBRE_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCondicion, " L.ANIOZAFRA = @ANIOZAFRA ")
        End If
        If CODI_DEPTO IsNot Nothing AndAlso CODI_DEPTO <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_DEPTO = @CODI_DEPTO ")
        End If
        If CODI_MUNI IsNot Nothing AndAlso CODI_MUNI <> "" Then
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
            arg.Value = CODI_MUNI
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_MUNI = @CODI_MUNI ")
        End If
        If CODI_CANTON IsNot Nothing AndAlso CODI_CANTON <> "" Then
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.VarChar)
            arg.Value = CODI_CANTON
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_CANTON = @CODI_CANTON ")
        End If
        strSQL.Append(strCondicion.ToString)

        strSQL.Append("GROUP BY MC.NO_CATORCENA ")

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

    Public Function ObtenerDataSetRendimientoPorCatorcena(ByVal NOMBRE_ZAFRA As String, _
                                                      ByVal CODI_DEPTO As String, _
                                                      ByVal CODI_MUNI As String, _
                                                      ByVal CODI_CANTON As String, _
                                                      ByVal ZONA As String, _
                                                      ByVal SUB_ZONA As String) As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT MC.NO_CATORCENA, ROUND(SUM(MC.AZUCAR_CATORCENA_REAL)/SUM(MC.NETOTONEL),2) AS RENDIMIENTO ")
        strSQL.Append("FROM MOV_CATORCENA MC, ENVIO E, LOTES L, MAESTRO_LOTES M ")

        AgregarCondicion(strCondicion, " MC.ID_ENVIO = E.ID_ENVIO ")
        AgregarCondicion(strCondicion, " E.ACCESLOTE = L.ACCESLOTE ")
        AgregarCondicion(strCondicion, " L.ID_MAESTRO = M.ID_MAESTRO ")

        If NOMBRE_ZAFRA IsNot Nothing AndAlso NOMBRE_ZAFRA <> "" Then
            arg = New SqlParameter("@ANIOZAFRA", SqlDbType.VarChar)
            arg.Value = NOMBRE_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCondicion, " L.ANIOZAFRA = @ANIOZAFRA ")
        End If
        If CODI_DEPTO IsNot Nothing AndAlso CODI_DEPTO <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_DEPTO = @CODI_DEPTO ")
        End If
        If CODI_MUNI IsNot Nothing AndAlso CODI_MUNI <> "" Then
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
            arg.Value = CODI_MUNI
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_MUNI = @CODI_MUNI ")
        End If
        If CODI_CANTON IsNot Nothing AndAlso CODI_CANTON <> "" Then
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.VarChar)
            arg.Value = CODI_CANTON
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_CANTON = @CODI_CANTON ")
        End If
        strSQL.Append(strCondicion.ToString)

        strSQL.Append("GROUP BY MC.NO_CATORCENA ")

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


    Public Function ObtenerDataSetRendimientoPorTercio(ByVal ID_ZAFRA As String, _
                                                      ByVal CODI_DEPTO As String, _
                                                      ByVal CODI_MUNI As String, _
                                                      ByVal CODI_CANTON As String, _
                                                      ByVal ZONA As String, _
                                                      ByVal SUB_ZONA As String) As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT ISNULL(LC.FAB_TERCIO,1) AS TERCIO, ROUND(SUM(MC.AZUCAR_CATORCENA_REAL)/SUM(MC.NETOTONEL),2) AS RENDIMIENTO ")
        strSQL.Append("FROM MOV_CATORCENA MC, ENVIO E, LOTES L, MAESTRO_LOTES M, LOTES_COSECHA LC  ")

        AgregarCondicion(strCondicion, " MC.ID_ENVIO = E.ID_ENVIO ")
        AgregarCondicion(strCondicion, " E.ACCESLOTE = L.ACCESLOTE ")
        AgregarCondicion(strCondicion, " L.ID_MAESTRO = M.ID_MAESTRO ")
        AgregarCondicion(strCondicion, " L.ACCESLOTE = LC.ACCESLOTE ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCondicion, " MC.ID_ZAFRA = @ID_ZAFRA AND LC.ID_ZAFRA = @ID_ZAFRA")
        End If
        If CODI_DEPTO IsNot Nothing AndAlso CODI_DEPTO <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_DEPTO = @CODI_DEPTO ")
        End If
        If CODI_MUNI IsNot Nothing AndAlso CODI_MUNI <> "" Then
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
            arg.Value = CODI_MUNI
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_MUNI = @CODI_MUNI ")
        End If
        If CODI_CANTON IsNot Nothing AndAlso CODI_CANTON <> "" Then
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.VarChar)
            arg.Value = CODI_CANTON
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_CANTON = @CODI_CANTON ")
        End If
        strSQL.Append(strCondicion.ToString)

        strSQL.Append("GROUP BY LC.FAB_TERCIO ")

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


    Public Function ObtenerDataSetEntregaPorTercio(ByVal ID_ZAFRA As String, _
                                                      ByVal CODI_DEPTO As String, _
                                                      ByVal CODI_MUNI As String, _
                                                      ByVal CODI_CANTON As String, _
                                                      ByVal ZONA As String, _
                                                      ByVal SUB_ZONA As String) As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT ISNULL(LC.FAB_TERCIO,1) AS TERCIO, SUM(MC.NETOTONEL) AS NETOTONEL ")
        strSQL.Append("FROM MOV_CATORCENA MC, ENVIO E, LOTES L, MAESTRO_LOTES M, LOTES_COSECHA LC  ")

        AgregarCondicion(strCondicion, " MC.ID_ENVIO = E.ID_ENVIO ")
        AgregarCondicion(strCondicion, " E.ACCESLOTE = L.ACCESLOTE ")
        AgregarCondicion(strCondicion, " L.ID_MAESTRO = M.ID_MAESTRO ")
        AgregarCondicion(strCondicion, " L.ACCESLOTE = LC.ACCESLOTE ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCondicion, " MC.ID_ZAFRA = @ID_ZAFRA AND LC.ID_ZAFRA = @ID_ZAFRA")
        End If
        If CODI_DEPTO IsNot Nothing AndAlso CODI_DEPTO <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
            arg.Value = CODI_DEPTO
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_DEPTO = @CODI_DEPTO ")
        End If
        If CODI_MUNI IsNot Nothing AndAlso CODI_MUNI <> "" Then
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
            arg.Value = CODI_MUNI
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_MUNI = @CODI_MUNI ")
        End If
        If CODI_CANTON IsNot Nothing AndAlso CODI_CANTON <> "" Then
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.VarChar)
            arg.Value = CODI_CANTON
            args.Add(arg)
            AgregarCondicion(strCondicion, " M.CODI_CANTON = @CODI_CANTON ")
        End If
        strSQL.Append(strCondicion.ToString)

        strSQL.Append("GROUP BY LC.FAB_TERCIO ")

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

End Class
