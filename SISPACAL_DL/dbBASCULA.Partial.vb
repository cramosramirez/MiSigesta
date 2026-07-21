Partial Public Class dbBASCULA
    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades BASCULA filtrada por Zafra y Boleta.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBOLETA(ByVal pID_ZAFRA As Integer, ByVal pNROBOLETA As Integer) As listaBASCULA
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaENVIO
        Dim lEnvio As New ENVIO
        Dim listaBascula As listaBASCULA

        lCriterios.Add(New Criteria("ID_ZAFRA", "=", pID_ZAFRA, "AND"))
        lCriterios.Add(New Criteria("NROBOLETA", "=", pNROBOLETA, "AND"))
        lEnvio.ID_ZAFRA = pID_ZAFRA
        lEnvio.NROBOLETA = pNROBOLETA
        lista = Me.ObtenerListaPorBusqueda(lEnvio, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            listaBascula = (New dbBASCULA).ObtenerListaPorENVIO(lista(0).ID_ENVIO)
            Return listaBascula
        Else
            Return Nothing
        End If
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades BASCULA filtrada por Zafra y Boleta.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	24/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerToneladasSinCorte() As Decimal
        Dim strSQL As New StringBuilder
        Dim lRet As Object
        strSQL.AppendLine("SELECT SUM(NETOTONEL) ")
        strSQL.AppendLine("FROM BASCULA ")
        strSQL.AppendLine("WHERE NOT FECHA_LEE_TARA IS NULL ")
        strSQL.AppendLine("AND EXISTS(SELECT 1 FROM ENVIO WHERE ENVIO.ID_ENVIO = BASCULA.ID_ENVIO AND ENVIO.CERRADO = 0)")

        lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
        If lRet IsNot Nothing AndAlso IsNumeric(lRet) Then
            Return Convert.ToDecimal(lRet)
        Else
            Return 0
        End If
    End Function

    Public Function ObtenerTONEL_PROMEDIO_RANGO_DIAS_ZAFRA(ByVal ID_ZAFRA As Int32, ByVal ULTIMOS_NUMERO_DIAS As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lDiasZafra As listaDIA_ZAFRA = (New dbDIA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, "DIAZAFRA", "ASC")
        Dim dia1 As Integer
        Dim dia2 As Integer
        Dim lRet As Object

        If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
            If lDiasZafra.Count >= ULTIMOS_NUMERO_DIAS Then
                dia1 = lDiasZafra(lDiasZafra.Count - ULTIMOS_NUMERO_DIAS).DIAZAFRA
                dia2 = lDiasZafra(lDiasZafra.Count - 1).DIAZAFRA
            Else
                dia1 = lDiasZafra(0).DIAZAFRA
                dia2 = lDiasZafra(lDiasZafra.Count - 1).DIAZAFRA
            End If
        Else
            dia1 = 1
            dia2 = 1
        End If

        strSQL.AppendLine("SELECT ISNULL(SUM(NETOTONEL),0) AS NETOTONEL ")
        strSQL.AppendLine("FROM ENVIO E, BASCULA B ")
        strSQL.AppendLine("WHERE E.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.AppendLine("AND E.DIAZAFRA >= @DIA1 AND E.DIAZAFRA <= @DIA2 ")
        strSQL.AppendLine("AND E.ID_ENVIO = B.ID_ENVIO ")
        strSQL.AppendLine("AND E.CERRADO = 1 ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@DIA1", SqlDbType.Int)
        arg.Value = dia1
        args.Add(arg)

        arg = New SqlParameter("@DIA2", SqlDbType.Int)
        arg.Value = dia2
        args.Add(arg)

        lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        If lRet IsNot Nothing AndAlso IsNumeric(lRet) Then
            If Convert.ToDecimal(lRet) = 0 Then
                Return 0
            Else
                Return Math.Round(Convert.ToDecimal(lRet) / Convert.ToDecimal(ULTIMOS_NUMERO_DIAS), 2)
            End If

        Else
            Return 0
        End If
    End Function

    Public Function ObtenerTONEL_ENTREGADA_AL_DIAZAFRA(ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Object
        strSQL.AppendLine("SELECT ISNULL(SUM(NETOTONEL),0) AS NETOTONEL ")
        strSQL.AppendLine("FROM ENVIO E, BASCULA B ")
        strSQL.AppendLine("WHERE E.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.AppendLine("AND E.DIAZAFRA <= @DIAZAFRA ")
        strSQL.AppendLine("AND E.ID_ENVIO = B.ID_ENVIO ")
        strSQL.AppendLine("AND E.CERRADO = 1 ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@DIAZAFRA", SqlDbType.Int)
        arg.Value = DIAZAFRA
        args.Add(arg)

        lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        If lRet IsNot Nothing AndAlso IsNumeric(lRet) Then
            Return Convert.ToDecimal(lRet)
        Else
            Return 0
        End If
    End Function

    Public Function ObtenerTONEL_ENTREGADAPorZAFRA(ByVal ID_ZAFRA As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Object
        strSQL.AppendLine("SELECT ISNULL(SUM(TONEL_ENTREGADA),0) AS TONEL_ENTREGADA ")
        strSQL.AppendLine("FROM LOTES_COSECHA ")
        strSQL.AppendLine("WHERE ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        If lRet IsNot Nothing AndAlso IsNumeric(lRet) Then
            Return Convert.ToDecimal(lRet)
        Else
            Return 0
        End If
    End Function

    Public Function ObtenerTOTAL_TONEL_ENTREGARPorZAFRA(ByVal ID_ZAFRA As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Object
        strSQL.AppendLine("SELECT ISNULL(SUM(TONEL_ENTREGAR),0) AS TONEL_ENTREGAR ")
        strSQL.AppendLine("FROM LOTES_COSECHA ")
        strSQL.AppendLine("WHERE ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        If lRet IsNot Nothing AndAlso IsNumeric(lRet) Then
            Return Convert.ToDecimal(lRet)
        Else
            Return 0
        End If
    End Function
End Class
