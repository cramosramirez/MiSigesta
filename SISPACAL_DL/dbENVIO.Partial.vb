Partial Public Class dbENVIO
    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades ENVIO filtrada por el Número de Comprobante de Envío.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCOMPROBANTE(ByVal pID_ZAFRA As Integer, ByVal pCOMPTENVIO As Integer) As listaENVIO
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaENVIO
        Dim lEnvio As New ENVIO

        lCriterios.Add(New Criteria("ID_ZAFRA", "=", pID_ZAFRA, "AND"))
        lCriterios.Add(New Criteria("COMPTENVIO", "=", pCOMPTENVIO, "AND"))
        lEnvio.ID_ZAFRA = pID_ZAFRA
        lEnvio.COMPTENVIO = pCOMPTENVIO
        lista = Me.ObtenerListaPorBusqueda(lEnvio, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Return lista
        Else
            Return Nothing
        End If
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades ENVIO filtrada por el Número de Boleta.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBOLETA(ByVal pID_ZAFRA As Integer, ByVal pNROBOLETA As Integer) As listaENVIO
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaENVIO
        Dim lEnvio As New ENVIO

        lCriterios.Add(New Criteria("ID_ZAFRA", "=", pID_ZAFRA, "AND"))
        lCriterios.Add(New Criteria("NROBOLETA", "=", pNROBOLETA, "AND"))
        lEnvio.ID_ZAFRA = pID_ZAFRA
        lEnvio.NROBOLETA = pNROBOLETA
        lista = Me.ObtenerListaPorBusqueda(lEnvio, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Return lista
        Else
            Return Nothing
        End If
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades ENVIO filtrada por el Número de Recibo de Caña.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Integer, ByVal CATORCENA As Integer, ByVal CODTRANSPORT As Integer, _
                                            ByVal CODIPROVEEDOR As String, ByVal PLACAVEHIC As String, ByVal TRANSPORTE_PROPIO As Integer, Optional ByVal CON_RECIBO_CAÑA As Boolean = True) As listaENVIO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.AppendLine("SELECT * ")
        strSQL.AppendLine("FROM ENVIO ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCondicion, "ID_ZAFRA = @ID_ZAFRA")
        End If
        If CATORCENA <> -1 Then
            arg = New SqlParameter("@CATORCENA", SqlDbType.Int)
            arg.Value = CATORCENA
            args.Add(arg)
            AgregarCondicion(strCondicion, "CATORCENA = @CATORCENA")
        End If
        If CODTRANSPORT <> -1 Then
            arg = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
            arg.Value = CODTRANSPORT
            args.Add(arg)
            AgregarCondicion(strCondicion, "CODTRANSPORT = @CODTRANSPORT")
        End If
        If CODIPROVEEDOR <> "" Then
            arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
            arg.Value = CODIPROVEEDOR
            args.Add(arg)
            AgregarCondicion(strCondicion, "CODIPROVEEDOR = @CODIPROVEEDOR")
        End If
        If PLACAVEHIC <> "" Then
            arg = New SqlParameter("@PLACAVEHIC", SqlDbType.VarChar)
            arg.Value = PLACAVEHIC
            args.Add(arg)
            AgregarCondicion(strCondicion, "PLACAVEHIC = @PLACAVEHIC")
        End If
        If TRANSPORTE_PROPIO <> -1 Then
            arg = New SqlParameter("@TRANSPORTE_PROPIO", SqlDbType.Bit)
            If TRANSPORTE_PROPIO = 1 Then
                arg.Value = True
            Else
                arg.Value = False
            End If
            args.Add(arg)
            AgregarCondicion(strCondicion, "TRANSPORTE_PROPIO = @TRANSPORTE_PROPIO")
        End If
        If CON_RECIBO_CAÑA Then
            AgregarCondicion(strCondicion, "NOT NUMRECIBO_CANA IS NULL")
        End If
        strSQL.AppendLine(strCondicion.ToString)
        strSQL.Append(" ORDER BY FECHA_ENTRADA DESC")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaENVIO
        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' Función que recupera una lista de entidades ENVIO filtrada por el Número de Recibo de Caña.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZAFRA_CATORCENA(ByVal ID_ZAFRA As Integer, ByVal CATORCENA As Integer) As listaENVIO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.AppendLine("SELECT * ")
        strSQL.AppendLine("FROM ENVIO ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCondicion, "ID_ZAFRA = @ID_ZAFRA")
        End If
        If CATORCENA <> -1 Then
            arg = New SqlParameter("@CATORCENA", SqlDbType.Int)
            arg.Value = CATORCENA
            args.Add(arg)
            AgregarCondicion(strCondicion, "CATORCENA = @CATORCENA")
        End If

        AgregarCondicion(strCondicion, "CERRADO = 1")

        strSQL.AppendLine(strCondicion.ToString)
        strSQL.Append(" ORDER BY FECHA_ENTRADA DESC")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaENVIO
        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' Función que recupera una lista de entidades ENVIO filtrada por el Número de Recibo de Caña.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorRECIBO_CANA(ByVal pID_ZAFRA As Integer, ByVal pNUMRECIBO_CANA As Integer) As listaENVIO
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaENVIO
        Dim lEnvio As New ENVIO

        lCriterios.Add(New Criteria("ID_ZAFRA", "=", pID_ZAFRA, "AND"))
        lCriterios.Add(New Criteria("NUMRECIBO_CANA", "=", pNUMRECIBO_CANA, "AND"))
        lEnvio.ID_ZAFRA = pID_ZAFRA
        lEnvio.NUMRECIBO_CANA = pNUMRECIBO_CANA
        lista = Me.ObtenerListaPorBusqueda(lEnvio, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Return lista
        Else
            Return Nothing
        End If
    End Function

    Public Function EliminarENVIOenCascada(ByVal ID_ENVIO As Integer) As String
        Dim lRet As Int32 = 0
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ENVIO", SqlDbType.Int)
        arg.Value = ID_ENVIO
        args.Add(arg)

        Try
            Dim dr As IDataReader
            Dim resultado As String = "-1|No se obtuvieron datos"

            dr = SqlHelper.ExecuteReader(Me.cnnStr, "ELIMINAR_ENVIO_CASCADA", args.ToArray)

            If dr.Read() Then
                resultado = Convert.ToString(dr(0)) + "|" + Convert.ToString(dr(1))
            End If

            Return resultado

        Catch ex As Exception
            Return "-1|" + ex.Message.ToString
        End Try


    End Function
End Class
