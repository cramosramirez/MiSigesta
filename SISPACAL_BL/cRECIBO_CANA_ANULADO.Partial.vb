Partial Public Class cRECIBO_CANA_ANULADO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarRECIBO_CANA_ANULADO(ByVal aEntidad As RECIBO_CANA_ANULADO) As Integer
        Try
            Return Me.ActualizarRECIBO_CANA_ANULADO(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarRECIBO_CANA_ANULADO(ByVal aEntidad As RECIBO_CANA_ANULADO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Dim lRet As Integer
        Dim idEnvio As Decimal = -1
        sError = ""
        Try
            'Verificar si exista el número correlativo de recibo en la numeración de recibos
            If Not (New cRECIBO_CANA_NUMERACION).ExisteNumeroReciboCana(aEntidad.NUMRECIBO_CANA) Then
                sError = "No. de Recibo de Cana no existe como una numeracion de recibo"
                Return -1
            End If

            'Verificar que se ingreso motivo de anulación
            If aEntidad.MOTIVO_ANULACION = String.Empty Then
                sError = "Ingrese el motivo de la anulacion"
                Return -1
            End If

            'Verificar si existe envio que tenga asignado este recibo de caña
            If aEntidad.ID_RECIBO_CANA_ANUL = 0 Then
                Dim lRecibosAnulados As listaRECIBO_CANA_ANULADO
                lRecibosAnulados = Me.ObtenerListaPorNUMRECIBO_CANA(aEntidad.ID_ZAFRA, aEntidad.NUMRECIBO_CANA)
                If lRecibosAnulados IsNot Nothing AndAlso lRecibosAnulados.Count > 0 Then
                    sError = "El No. de Recibo ya esta anulado"
                    Return -1
                End If
            End If

            Dim listaEnvios As listaENVIO = (New cENVIO).ObtenerListaPorRECIBO_CANA(aEntidad.ID_ZAFRA, aEntidad.NUMRECIBO_CANA)
            If listaEnvios IsNot Nothing AndAlso listaEnvios.Count > 0 Then
                Dim bEnvio As New cENVIO
                For i As Integer = 0 To listaEnvios.Count - 1
                    If listaEnvios(i).CERRADO Then
                        sError = "El recibo esta asociado a un envio de dia zafra cerrado. No es posible anularlo."
                        Return -1
                    Else
                        idEnvio = listaEnvios(i).ID_ENVIO
                        listaEnvios(i).NUMRECIBO_CANA = -1
                        listaEnvios(i).USUARIO_ACT = Utilerias.ObtenerUsuario
                        listaEnvios(i).FECHA_ACT = cFechaHora.ObtenerFechaHora
                        lRet = bEnvio.ActualizarENVIO(listaEnvios(i))
                        If lRet <= 0 Then
                            sError = "No fue posible desasociar el envio con boleta No.: " + listaEnvios(i).NROBOLETA.ToString
                            Return -1
                        End If
                    End If
                Next
            End If
            aEntidad.ID_ENVIO = idEnvio
            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return lRet
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarRECIBO_CANA_ANULADO(ByVal ID_RECIBO_CANA_ANUL As Int32, ByVal NUMRECIBO_CANA As Int32, ByVal FECHA_ANULACION As DateTime, ByVal MOTIVO_ANULACION As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New RECIBO_CANA_ANULADO
            lEntidad.ID_RECIBO_CANA_ANUL = ID_RECIBO_CANA_ANUL
            lEntidad.NUMRECIBO_CANA = NUMRECIBO_CANA
            lEntidad.FECHA_ANULACION = FECHA_ANULACION
            lEntidad.MOTIVO_ANULACION = MOTIVO_ANULACION
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarRECIBO_CANA_ANULADO(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades ENVIO filtrada por el Número de Recibo de Caña.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNUMRECIBO_CANA(ByVal pID_ZAFRA As Integer, ByVal pNUMRECIBO_CANA As Integer) As listaRECIBO_CANA_ANULADO
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaRECIBO_CANA_ANULADO
        Dim lRecibo As New RECIBO_CANA_ANULADO

        lCriterios.Add(New Criteria("ID_ZAFRA", "=", pID_ZAFRA, "AND"))
        lCriterios.Add(New Criteria("NUMRECIBO_CANA", "=", pNUMRECIBO_CANA, "AND"))
        lRecibo.ID_ZAFRA = pID_ZAFRA
        lRecibo.NUMRECIBO_CANA = pNUMRECIBO_CANA
        lista = Me.ObtenerListaPorBusqueda(lRecibo, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Return lista
        Else
            Return Nothing
        End If
    End Function
    
End Class
