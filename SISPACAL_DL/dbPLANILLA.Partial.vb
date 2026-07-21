Partial Public Class dbPLANILLA


    Public Function PROC_GenerarCOMPROBANTES(ByVal ID_PLANILLA_BASE As Int32, ByVal ID_COMPROB_NUME As Int32, ByVal NO_DOCTO As Int32, ByVal TIPO As Int32, ByVal ES_CONTRIBUYENTE As Int32, ByVal USUARIO As String, ByVal ID_COMPROB_CONCE As Int32, ByVal FECHA_EMISION As DateTime) As String
        Dim lResult As String = ""
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_PLANILLA_BASE", SqlDbType.Int)
        arg.Value = ID_PLANILLA_BASE
        args.Add(arg)

        arg = New SqlParameter("@ID_COMPROB_NUME", SqlDbType.Int)
        arg.Value = ID_COMPROB_NUME
        args.Add(arg)

        arg = New SqlParameter("@NO_DOCTO", SqlDbType.Int)
        arg.Value = NO_DOCTO
        args.Add(arg)

        arg = New SqlParameter("@TIPO", SqlDbType.Int)
        arg.Value = TIPO
        args.Add(arg)

        arg = New SqlParameter("@ES_CONTRIBUYENTE", SqlDbType.Bit)
        arg.Value = IIf(ES_CONTRIBUYENTE = 1, True, False)
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO
        args.Add(arg)

        arg = New SqlParameter("@ID_COMPROB_CONCE", SqlDbType.Int)
        arg.Value = ID_COMPROB_CONCE
        args.Add(arg)

        arg = New SqlParameter("@FECHA_EMISION", SqlDbType.DateTime)
        arg.Value = FECHA_EMISION
        args.Add(arg)

        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_COMPROB_PLANILLA", args.ToArray)

        Try
            Do While dr.Read()
                lResult = dr(0)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lResult
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerContratosLotesPorCATORCENA_PROVEEDOR(ByVal ID_CATORCENA As Integer, ByVal CODIPROVEEDOR As String, ByVal POR_LOTE As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Dim ds As New DataSet
            Dim args(1) As SqlParameter
            Dim strSQL As New StringBuilder
            If Not POR_LOTE Then
                strSQL.Append("SELECT CODICONTRATO, '' AS ACCESLOTE, '' AS CODILOTE, '' AS NOMBLOTE, ")
                strSQL.Append("SUM(NETOTONEL) AS NETOTONEL, SUM(PAGO_CATORCENA_REAL) AS PAGO_CATORCENA ")
                strSQL.Append("FROM MOV_DIARIO ")
                strSQL.Append("WHERE ID_CATORCENA = @ID_CATORCENA ")
                strSQL.Append("AND CODIPROVEEDOR = @CODIPROVEEDOR ")
            Else
                strSQL.Append("SELECT CODICONTRATO, ACCESLOTE, CODILOTE, NOMBLOTE ")
                strSQL.Append("SUM(NETOTONEL) AS NETOTONEL, SUM(PAGO_CATORCENA_REAL) AS PAGO_CATORCENA ")
                strSQL.Append("FROM MOV_DIARIO ")
                strSQL.Append("WHERE ID_CATORCENA = @ID_CATORCENA ")
                strSQL.Append("AND CODIPROVEEDOR = @CODIPROVEEDOR ")
            End If
            If asColumnaOrden <> "" Then
                strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
            End If

            args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            args(0).Value = ID_CATORCENA

            args(1) = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
            args(1).Value = CODIPROVEEDOR

            Dim tables(0) As String
            tables(0) = New String("CONTRATO_LOTES".ToCharArray())

            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString, args)
            Return ds

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena una lista de entidades filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="NOMBRE_PROVEE_TRANS"></param>
    ''' <param name="ES_CONTRIBUYENTE"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCRITERIOS(ByVal ID_CATORCENA As Integer, _
                                            ByVal ID_TIPO_PLANILLA As Integer, _
                                            ByVal CODIPROVEEDOR_TRANSPORTISTA As String, _
                                            ByVal NOMBRE_PROVEE_TRANS As String, _
                                            ByVal ES_CONTRIBUYENTE As Boolean, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaPLANILLA

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.Append("SELECT * FROM PLANILLA ")

        If ID_CATORCENA > 0 Then
            arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            arg.Value = ID_CATORCENA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " ID_CATORCENA = @ID_CATORCENA ")
        End If

        If ID_TIPO_PLANILLA > 0 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        End If

        If CODIPROVEEDOR_TRANSPORTISTA <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR_TRANSPORTISTA", SqlDbType.VarChar)
            arg.Value = CODIPROVEEDOR_TRANSPORTISTA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " CODIPROVEEDOR_TRANSPORTISTA = @CODIPROVEEDOR_TRANSPORTISTA ")
        End If

        If NOMBRE_PROVEE_TRANS <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEE_TRANS", SqlDbType.VarChar)
            arg.Value = NOMBRE_PROVEE_TRANS
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " NOMBRE_PROVEE_TRANS LIKE '%' + @NOMBRE_PROVEE_TRANS + '%' ")
        End If

        arg = New SqlParameter("@ES_CONTRIBUYENTE", SqlDbType.Bit)
        arg.Value = IIf(ES_CONTRIBUYENTE, 1, 0)
        args.Add(arg)
        AgregarCondicion(strSQLCondicion, " ES_CONTRIBUYENTE = @ES_CONTRIBUYENTE ")

        strSQL.AppendLine(strSQLCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    Public Function ObtenerListaPorCRITERIOS(ByVal ID_CATORCENA As Integer,
                                           ByVal ID_TIPO_PLANILLA As Integer,
                                           ByVal CODIPROVEEDOR_TRANSPORTISTA As String,
                                           ByVal NOMBRE_PROVEE_TRANS As String,
                                           Optional ByVal asColumnaOrden As String = "",
                                           Optional ByVal asTipoOrden As String = "ASC") As listaPLANILLA

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.Append("SELECT * FROM PLANILLA ")

        If ID_CATORCENA > 0 Then
            arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            arg.Value = ID_CATORCENA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " ID_CATORCENA = @ID_CATORCENA ")
        End If

        If ID_TIPO_PLANILLA > 0 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        End If

        If CODIPROVEEDOR_TRANSPORTISTA <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR_TRANSPORTISTA", SqlDbType.VarChar)
            arg.Value = CODIPROVEEDOR_TRANSPORTISTA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " CODIPROVEEDOR_TRANSPORTISTA = @CODIPROVEEDOR_TRANSPORTISTA ")
        End If

        If NOMBRE_PROVEE_TRANS <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEE_TRANS", SqlDbType.VarChar)
            arg.Value = NOMBRE_PROVEE_TRANS
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " NOMBRE_PROVEE_TRANS LIKE '%' + @NOMBRE_PROVEE_TRANS + '%' ")
        End If

        strSQL.AppendLine(strSQLCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerPlanilla(ByVal ID_CATORCENA As Integer,
                                           ByVal ID_TIPO_PLANILLA As Integer,
                                           ByVal CODIPROVEEDOR_TRANSPORTISTA As String,
                                           ByVal NOMBRE_PROVEE_TRANS As String,
                                           Optional ByVal asColumnaOrden As String = "",
                                           Optional ByVal asTipoOrden As String = "ASC") As listaPLANILLA

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.Append("SELECT * FROM PLANILLA ")

        If ID_CATORCENA > 0 Then
            arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            arg.Value = ID_CATORCENA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " ID_CATORCENA = @ID_CATORCENA ")
        End If

        If ID_TIPO_PLANILLA > 0 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        End If

        If CODIPROVEEDOR_TRANSPORTISTA <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR_TRANSPORTISTA", SqlDbType.VarChar)
            arg.Value = CODIPROVEEDOR_TRANSPORTISTA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " CODIPROVEEDOR_TRANSPORTISTA = @CODIPROVEEDOR_TRANSPORTISTA ")
        End If

        If NOMBRE_PROVEE_TRANS <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEE_TRANS", SqlDbType.VarChar)
            arg.Value = NOMBRE_PROVEE_TRANS
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " NOMBRE_PROVEE_TRANS LIKE '%' + @NOMBRE_PROVEE_TRANS + '%' ")
        End If

        strSQL.AppendLine(strSQLCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function



    Public Function ObtenerPlanilla(ByVal ID_CATORCENA As Integer,
                                           ByVal ID_TIPO_PLANILLA As Integer,
                                           ByVal CODIPROVEEDOR_TRANSPORTISTA As String,
                                           Optional ByVal asColumnaOrden As String = "",
                                           Optional ByVal asTipoOrden As String = "ASC") As PLANILLA

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim lEntidad As New PLANILLA

        strSQL.Append("SELECT * FROM PLANILLA ")

        If ID_CATORCENA > 0 Then
            arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            arg.Value = ID_CATORCENA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " ID_CATORCENA = @ID_CATORCENA ")
        End If

        If ID_TIPO_PLANILLA > 0 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        End If

        If CODIPROVEEDOR_TRANSPORTISTA <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR_TRANSPORTISTA", SqlDbType.VarChar)
            arg.Value = CODIPROVEEDOR_TRANSPORTISTA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " CODIPROVEEDOR_TRANSPORTISTA = @CODIPROVEEDOR_TRANSPORTISTA ")
        End If

        strSQL.AppendLine(strSQLCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)



        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarPLANILLA(dr, lEntidad)
            Else
                lEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lEntidad
    End Function
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena una lista de entidades filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>   
    ''' <param name="ES_CONTRIBUYENTE"></param> 
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaChequesPendientesEmitir(ByVal ID_CATORCENA As Integer, _
                                            ByVal ID_TIPO_PLANILLA As Integer, _
                                            ByVal ES_CONTRIBUYENTE As Integer, _
                                            ByVal NO_CHEQUE_INICIAL As Integer, _
                                            Optional ID_RANGO_COMPE As Int32 = -1) As listaPLANILLA

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim s As String

        strSQL.Append("SELECT ")
        strSQL.Append("CASE WHEN P.ID_TIPO_PLANILLA IN(1,5,6,7,8,10,11) THEN CAST(dbo.QuitarFormatoCODIPROVEEDOR(P.CODIPROVEEDOR_TRANSPORTISTA) AS INT) ")
        strSQL.Append("     WHEN P.ID_TIPO_PLANILLA IN(2) THEN CAST(P.CODIPROVEEDOR_TRANSPORTISTA AS INT) ")
        strSQL.Append("     WHEN P.ID_TIPO_PLANILLA IN(3,12,13,14) THEN CAST(REPLACE(REPLACE(P.CODIPROVEEDOR_TRANSPORTISTA,'RZ',''),'QR','') AS INT) ")
        strSQL.Append("     ELSE CAST(P.CODIPROVEEDOR_TRANSPORTISTA AS INT) ")
        strSQL.Append("END AS CODIGO_FORMATEADO, ")
        strSQL.Append("* ")
        strSQL.Append("FROM PLANILLA P ")

        If ID_CATORCENA > 0 Then
            arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            arg.Value = ID_CATORCENA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " P.ID_CATORCENA = @ID_CATORCENA ")
        End If

        If ID_TIPO_PLANILLA > 0 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " P.ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        End If

        If ES_CONTRIBUYENTE <> -1 Then
            arg = New SqlParameter("@ES_CONTRIBUYENTE", SqlDbType.Bit)
            arg.Value = ES_CONTRIBUYENTE
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " P.ES_CONTRIBUYENTE = @ES_CONTRIBUYENTE ")
        End If

        If ID_RANGO_COMPE <> -1 Then
            arg = New SqlParameter("@ID_RANGO_COMPE", SqlDbType.Int)
            arg.Value = ID_RANGO_COMPE
            args.Add(arg)
            s = " (EXISTS(SELECT 1 FROM RANGO_COMPENSACION R WHERE R.ID_CATORCENA = P.ID_CATORCENA AND R.ID_RANGO_COMPE = @ID_RANGO_COMPE AND R.VALOR_UNIT_PAGO = P.VALOR_UNIT_PAGO) OR @ID_RANGO_COMPE = -1) "
            AgregarCondicion(strSQLCondicion, s)
        End If

        AgregarCondicion(strSQLCondicion, " P.NO_CHEQUE IS NULL AND P.CODIPROVEEDOR_TRANSPORTISTA NOT IN('RZ36','QR036') ")

        s = " (SELECT COUNT(1) FROM PAGO_CTA_BANCO CTA WHERE CTA.ID_CATORCENA = P.ID_CATORCENA AND CTA.ID_TIPO_PLANILLA = P.ID_TIPO_PLANILLA AND CTA.CODIPROVEEDOR_TRANSPORTISTA = P.CODIPROVEEDOR_TRANSPORTISTA AND CTA.ENTREGO_CCF = 1) = 0 "
        AgregarCondicion(strSQLCondicion, s)

        strSQL.AppendLine(strSQLCondicion.ToString)

        strSQL.Append(" ORDER BY 1 ")

        Dim lista As New listaPLANILLA
        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
                mEntidad.CODIGO_FORMATEADO = Convert.ToInt32(dr("CODIGO_FORMATEADO"))
                mEntidad.NO_CHEQUE = NO_CHEQUE_INICIAL
                NO_CHEQUE_INICIAL += 1
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
    ''' Función que llena una lista de entidades filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>   
    ''' <param name="ES_CONTRIBUYENTE"></param> 
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaChequesPlanilla(ByVal ID_CATORCENA As Integer, _
                                            ByVal ID_TIPO_PLANILLA As Integer, _
                                            ByVal ES_CONTRIBUYENTE As Integer, _
                                            Optional ID_RANGO_COMPE As Int32 = -1) As listaPLANILLA

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.Append("SELECT CASE  WHEN P.ID_TIPO_PLANILLA NOT IN(2,3,4) THEN CAST(dbo.QuitarFormatoCODIPROVEEDOR(P.CODIPROVEEDOR_TRANSPORTISTA) AS INT) ELSE CAST(P.CODIPROVEEDOR_TRANSPORTISTA AS INT) END AS CODIGO_FORMATEADO, ")
        strSQL.Append("* ")
        strSQL.Append("FROM PLANILLA P ")

        If ID_CATORCENA > 0 Then
            arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            arg.Value = ID_CATORCENA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " P.ID_CATORCENA = @ID_CATORCENA ")
        End If

        If ID_TIPO_PLANILLA > 0 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " P.ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        End If

        If ES_CONTRIBUYENTE <> -1 Then
            arg = New SqlParameter("@ES_CONTRIBUYENTE", SqlDbType.Bit)
            arg.Value = ES_CONTRIBUYENTE
            args.Add(arg)
            AgregarCondicion(strSQLCondicion, " P.ES_CONTRIBUYENTE = @ES_CONTRIBUYENTE ")
        End If

        If ID_RANGO_COMPE <> -1 Then
            arg = New SqlParameter("@ID_RANGO_COMPE", SqlDbType.Int)
            arg.Value = ID_RANGO_COMPE
            args.Add(arg)
            Dim s As String
            s = " (EXISTS(SELECT 1 FROM RANGO_COMPENSACION R WHERE R.ID_CATORCENA = P.ID_CATORCENA AND R.ID_RANGO_COMPE = @ID_RANGO_COMPE AND R.VALOR_UNIT_PAGO = P.VALOR_UNIT_PAGO) OR @ID_RANGO_COMPE = -1) "
            AgregarCondicion(strSQLCondicion, s)
        End If


        AgregarCondicion(strSQLCondicion, " NOT P.NO_CHEQUE IS NULL AND P.CODIPROVEEDOR_TRANSPORTISTA NOT IN('RZ36','QR036') ")

        strSQL.AppendLine(strSQLCondicion.ToString)

        strSQL.Append(" ORDER BY 1 ")


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
                mEntidad.CODIGO_FORMATEADO = Convert.ToInt32(dr("CODIGO_FORMATEADO"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function EmitirCheques(ByVal ID_CATORCENA As Integer, _
                 ByVal ID_TIPO_PLANILLA As Integer, _
                 ByVal ES_CONTRIBUYENTE As Integer, _
                 ByVal ID_CUENTA As Integer, _
                 ByVal ID_CHEQUERA As Integer, _
                 ByVal PRIMER_CHEQUE As Integer, _
                 ByVal ULTIMO_CHEQUE As Integer, _
                 ByVal USUARIO_CREA As String, _
                 ByVal FECHA_CREA As DateTime, ByRef MENSAJE As String, ByVal ID_RANGO_COMPE As Int32) As Integer

        Dim dr As IDataReader
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        Dim cn As New SqlConnection(Me.cnnStr)
        cn.Open()
        Dim cmd As New SqlCommand("EMISION_CHEQUES_PLANILLA", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 1000

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@ES_CONTRIBUYENTE", SqlDbType.Int)
        arg.Value = ES_CONTRIBUYENTE
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@ID_CUENTA", SqlDbType.Int)
        arg.Value = ID_CUENTA
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@ID_CHEQUERA", SqlDbType.Int)
        arg.Value = ID_CHEQUERA
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@PRIMER_CHEQUE", SqlDbType.Int)
        arg.Value = PRIMER_CHEQUE
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@ULTIMO_CHEQUE", SqlDbType.Int)
        arg.Value = ULTIMO_CHEQUE
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = FECHA_CREA
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@ID_RANGO_COMPE", SqlDbType.Int)
        arg.Value = ID_RANGO_COMPE
        cmd.Parameters.Add(arg)


        dr = cmd.ExecuteReader()
        'dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "EMISION_CHEQUES_PLANILLA", args.ToArray)

        Try
            If dr.Read Then
                lResult = dr(0)
                If dr(0) = -1 Then
                    MENSAJE = dr(1)
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
            cn.Close()
            cn = Nothing
        End Try
        Return lResult
    End Function


    Public Function GenerarPlanilla(ByVal ID_ZAFRA As Integer, _
                 ByVal ID_CATORCENA As Integer, _
                 ByVal USUARIO_CREA As String, _
                 ByVal FECHA_CREA As Date) As Integer

        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)

        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = FECHA_CREA
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_PLANILLA_CATORCENA", args.ToArray)
        Catch ex As Exception
            Throw ex
        End Try
        Return lResult
    End Function

    Public Function AnularChequesPlanilla(ByVal ID_CATORCENA As Integer, _
                 ByVal ID_TIPO_PLANILLA As Integer, _
                 ByVal ES_CONTRIBUYENTE As Integer, _
                 ByVal CHEQUE_INICIAL As Integer, _
                 ByVal CHEQUE_FINAL As Integer, _
                 ByVal ID_RANGO_COMPE As Int32) As Integer

        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter


        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        args.Add(arg)

        arg = New SqlParameter("@ES_CONTRIBUYENTE", SqlDbType.Int)
        arg.Value = ES_CONTRIBUYENTE
        args.Add(arg)

        arg = New SqlParameter("@CHEQUE_INICIAL", SqlDbType.Int)
        arg.Value = CHEQUE_INICIAL
        args.Add(arg)

        arg = New SqlParameter("@CHEQUE_FINAL", SqlDbType.Int)
        arg.Value = CHEQUE_FINAL
        args.Add(arg)

        arg = New SqlParameter("@ID_RANGO_COMPE", SqlDbType.Int)
        arg.Value = ID_RANGO_COMPE
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "ANULACION_CHEQUES_PLANILLA", args.ToArray)
        Catch ex As Exception
            Throw ex
        End Try
        Return lResult
    End Function

    Public Function ObtenerPorCATORCENA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Integer) As listaPLANILLA
        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PLANILLA ")
        strSQL.Append("WHERE ID_CATORCENA = @ID_CATORCENA ")
        strSQL.Append("AND ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        strSQL.Append("ORDER BY CAST(CODIPROVEEDOR_TRANSPORTISTA AS INT)")

        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA

        args(1) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.VarChar)
        args(1).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function GenerarPlanillaAnticipoCaneros(ByVal ID_ZAFRA As Integer, ByVal ID_CATORCENA As Integer, ByVal NO_ANTICIPO As Integer, ByVal VALOR_ANTICIPO As Decimal, ByVal CONCEPTO As String) As Integer
        Dim dbFechaH As New dbFechaHora
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lRet As Integer

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@NO_ANTICIPO", SqlDbType.Int)
        arg.Value = NO_ANTICIPO
        args.Add(arg)

        arg = New SqlParameter("@VALOR_ANTICIPO", SqlDbType.Decimal)
        arg.Value = VALOR_ANTICIPO
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = Utilerias.ObtenerUsuario
        args.Add(arg)

        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = dbFechaH.ObtenerFechaHora
        args.Add(arg)

        arg = New SqlParameter("@CONCEPTO", SqlDbType.VarChar)
        arg.Value = CONCEPTO
        args.Add(arg)

        Try
            Dim cn As New SqlConnection(Me.cnnStr)
            cn.Open()
            Dim cmd As New SqlCommand("GENERAR_PLANILLA_ANTICIPO", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddRange(args.ToArray)
            cmd.CommandTimeout = 900000
            lRet = cmd.ExecuteNonQuery()
            cn.Close()

            'lRet = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_PLANILLA_ANTICIPO", args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

    Public Function GenerarPlanillaComplementoValorFinal(ByVal ID_ZAFRA As Integer, ByVal VALOR_FINAL_PAGO As Decimal) As Integer
        Dim dbFechaH As New dbFechaHora
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lRet As Integer

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@VALOR_FINAL_PAGO", SqlDbType.Decimal)
        arg.Value = VALOR_FINAL_PAGO
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = Utilerias.ObtenerUsuario
        args.Add(arg)

        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = dbFechaH.ObtenerFechaHora
        args.Add(arg)

        Try
            Dim cn As New SqlConnection(Me.cnnStr)
            cn.Open()
            Dim cmd As New SqlCommand("GENERAR_PLANILLA_COMPLEMENTO_VALOR_FINAL", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddRange(args.ToArray)
            cmd.CommandTimeout = 900000
            lRet = cmd.ExecuteNonQuery()
            cn.Close()

            'lRet = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_PLANILLA_COMPLEMENTO_VALOR_FINAL", args.ToArray)

        Catch ex As Exception
            Throw ex

        End Try

        Return lRet
    End Function
End Class


