Partial Public Class cENVIO

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
    ''' 	[GenApp]	15/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarENVIO(ByVal aEntidad As ENVIO) As Integer
        Try
            Return Me.ActualizarENVIO(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Integer, ByVal CATORCENA As Integer, ByVal CODTRANSPORT As Integer, _
                                            ByVal CODIPROVEEDOR As String, ByVal PLACAVEHIC As String, ByVal TRANSPORTE_PROPIO As Integer, Optional CON_RECIBO_CAÑA As Boolean = True) As listaENVIO
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, CATORCENA, CODTRANSPORT, CODIPROVEEDOR, PLACAVEHIC, TRANSPORTE_PROPIO, CON_RECIBO_CAÑA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorZAFRA_CATORCENA(ByVal ID_ZAFRA As Integer, ByVal CATORCENA As Integer) As listaENVIO
        Try
            Return mDb.ObtenerListaPorZAFRA_CATORCENA(ID_ZAFRA, CATORCENA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	15/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarENVIO(ByVal aEntidad As ENVIO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim entregarLote As Boolean = (aEntidad.ID_ENVIO = 0 AndAlso aEntidad.ACCESLOTE <> String.Empty)
            Dim lRet As Integer
            Dim esNuevo As Boolean = (aEntidad.ID_ENVIO = 0)
            Dim cambioEnRecibo As Boolean = False
            Dim bLotesCosecha As New cLOTES_COSECHA

            'Validaciones
            If Not esNuevo Then
                Dim lEnvioAntesAct As ENVIO = (New cENVIO).ObtenerENVIO(aEntidad.ID_ENVIO)
                If lEnvioAntesAct.CERRADO Then
                    Me.sError = "El envio pertenece a un corte cerrado. No es posible modificarlo."
                    Return -1
                End If
                If lEnvioAntesAct.ANULADO Then
                    Me.sError = "Envio fue anulado en fecha " + lEnvioAntesAct.FECHA_ANULACION.ToString("dd/MM/yyyy HH:mm")
                    Return -1
                End If
                If lEnvioAntesAct.DIAZAFRA <> aEntidad.DIAZAFRA OrElse lEnvioAntesAct.CATORCENA <> aEntidad.CATORCENA Then
                    aEntidad.DIAZAFRA = lEnvioAntesAct.DIAZAFRA
                    aEntidad.CATORCENA = lEnvioAntesAct.CATORCENA
                End If
                If lEnvioAntesAct.NUMRECIBO_CANA > 0 AndAlso aEntidad.NUMRECIBO_CANA > 0 Then
                    Me.sError = "El envio esta asociado al Recibo No. " + lEnvioAntesAct.NUMRECIBO_CANA.ToString + " anule el recibo antes de corregir el envio."
                    Return -1
                End If
                If lEnvioAntesAct.NUMRECIBO_CANA <> aEntidad.NUMRECIBO_CANA Then
                    cambioEnRecibo = True
                End If
            Else
                Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                If lZafraActiva IsNot Nothing Then
                    aEntidad.DIAZAFRA = lZafraActiva.DIAZAFRA
                    aEntidad.CATORCENA = lZafraActiva.CATORCENA
                End If
            End If

            lRet = Me.ActualizarENVIOsinValidacion(aEntidad, TipoConcurrencia.Pesimistica)

            If cambioEnRecibo Then
                bLotesCosecha.ActualizarTONELADAS_ENTREGADAS(aEntidad.ID_ZAFRA, aEntidad.ACCESLOTE) 
            End If

            Return lRet

        Catch ex As Exception
            If ex.Message.Contains("IDX_ENVIO01") Then
                Me.sError = "El envio N° " + aEntidad.COMPTENVIO.ToString + " ha sido registrado"
                Me.sErrorTecnico = "2601"
            Else
                Me.sError = ex.Message
            End If
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarENVIOsinValidacion(ByVal aEntidad As ENVIO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim esNuevo As Boolean = (aEntidad.ID_ENVIO = 0)
            Dim actualizarLoteCosecha As Boolean = False
            Dim lEnvioAntesAct As ENVIO
            Dim lRet As Int32 = 0

            'Validaciones
            If Not esNuevo Then
                lEnvioAntesAct = (New cENVIO).ObtenerENVIO(aEntidad.ID_ENVIO)

                If lEnvioAntesAct.ANULADO Then
                    Me.sError = "Envio fue anulado en fecha " + lEnvioAntesAct.FECHA_ANULACION.ToString("dd/MM/yyyy HH:mm")
                    Return -1
                End If

                If lEnvioAntesAct.DIAZAFRA <> aEntidad.DIAZAFRA OrElse lEnvioAntesAct.CATORCENA <> aEntidad.CATORCENA Then
                    aEntidad.DIAZAFRA = lEnvioAntesAct.DIAZAFRA
                    aEntidad.CATORCENA = lEnvioAntesAct.CATORCENA
                End If
            Else
                Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                If lZafraActiva IsNot Nothing Then
                    aEntidad.DIAZAFRA = lZafraActiva.DIAZAFRA
                    aEntidad.CATORCENA = lZafraActiva.CATORCENA
                End If
            End If


            lRet = mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)

            'If lRet > 0 AndAlso Not esNuevo AndAlso lEnvioAntesAct.NUMRECIBO_CANA <> aEntidad.NUMRECIBO_CANA AndAlso aEntidad.NUMRECIBO_CANA > 0 Then
            '    Dim bBascula As New cBASCULA
            '    Dim lstBascula As listaBASCULA = (New cBASCULA).ObtenerListaPorENVIO(aEntidad.ID_ENVIO)
            '    If lstBascula IsNot Nothing AndAlso lstBascula.Count > 0 Then
            '        lRet = bBascula.ActualizarBASCULA(
            '    End If
            'End If
            Return lRet

        Catch ex As Exception
            If ex.Message.Contains("IDX_ENVIO01") Then
                Me.sError = "El envio N° " + aEntidad.COMPTENVIO.ToString + " ha sido registrado"
                Me.sErrorTecnico = "2601"
            Else
                Me.sError = ex.Message
            End If
            ExceptionManager.Publish(ex)
            Return -1
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
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarENVIO(ByVal ID_ENVIO As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal CATORCENA As Int32, ByVal CODICONTRATO As String, ByVal CODIPROVEEDOR As String, ByVal COMPTENVIO As Int32, ByVal ACCESLOTE As String, ByVal CODTRANSPORT As Int32, ByVal NOMBRES_MOTORISTA As String, ByVal ID_TIPO_CANA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_SUPERVISOR As Int32, ByVal FECHA_QUEMA As DateTime, ByVal FECHA_CORTA As DateTime, ByVal QUEMAPROG As Boolean, ByVal FECHA_CARGA As DateTime, ByVal FECHA_PATIO As DateTime, ByVal NROBOLETA As Int32, ByVal MADURANTE As Boolean, ByVal CERRADO As Boolean, ByVal FECHA_ENTRADA As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal PLACAVEHIC As String, ByVal ID_TIPOTRANS As Int32, ByVal SERVICIO_ROZA As Boolean, ByVal TRANSPORTE_PROPIO As Boolean, ByVal ID_PROVEEDOR_ROZA As Int32, ByVal ID_CARGADOR As Int32, ByVal NUMRECIBO_CANA As Int32, ByVal TIPO_TARIFA_CARGADORA As Int32, ByVal ID_MOTORISTA As Int32, _
                                    ByVal ANULADO As Boolean, ByVal USUARIO_ANULACION As String, ByVal FECHA_ANULACION As DateTime, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32) As Integer
        Try
            Dim lEntidad As New ENVIO
            lEntidad.ID_ENVIO = ID_ENVIO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.CATORCENA = CATORCENA
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.COMPTENVIO = COMPTENVIO
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.NOMBRES_MOTORISTA = NOMBRES_MOTORISTA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_SUPERVISOR = ID_SUPERVISOR
            lEntidad.FECHA_QUEMA = FECHA_QUEMA
            lEntidad.FECHA_CORTA = FECHA_CORTA
            lEntidad.QUEMAPROG = QUEMAPROG
            lEntidad.FECHA_CARGA = FECHA_CARGA
            lEntidad.FECHA_PATIO = FECHA_PATIO
            lEntidad.NROBOLETA = NROBOLETA
            lEntidad.MADURANTE = MADURANTE
            lEntidad.CERRADO = CERRADO
            lEntidad.FECHA_ENTRADA = FECHA_ENTRADA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.PLACAVEHIC = PLACAVEHIC
            lEntidad.ID_TIPOTRANS = ID_TIPOTRANS
            lEntidad.SERVICIO_ROZA = SERVICIO_ROZA
            lEntidad.TRANSPORTE_PROPIO = TRANSPORTE_PROPIO
            lEntidad.ID_PROVEEDOR_ROZA = ID_PROVEEDOR_ROZA
            lEntidad.ID_CARGADOR = ID_CARGADOR
            lEntidad.NUMRECIBO_CANA = NUMRECIBO_CANA
            lEntidad.TIPO_TARIFA_CARGADORA = TIPO_TARIFA_CARGADORA
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.ANULADO = ANULADO
            lEntidad.USUARIO_ANULACION = USUARIO_ANULACION
            lEntidad.FECHA_ANULACION = FECHA_ANULACION
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            Return Me.ActualizarENVIO(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades ENVIO filtrada por N° de Comprobante.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCOMPROBANTE(ByVal pID_ZAFRA As Integer, ByVal pCOMPTENVIO As Integer) As listaENVIO
        Try
            Return mDb.ObtenerListaPorCOMPROBANTE(pID_ZAFRA, pCOMPTENVIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
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
        Try
            Return mDb.ObtenerListaPorBOLETA(pID_ZAFRA, pNROBOLETA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    Public Function ObtenerListaPorRECIBO_CANA(ByVal pID_ZAFRA As Integer, ByVal pNUMRECIBO_CANA As Integer) As listaENVIO
        Try
            Return mDb.ObtenerListaPorRECIBO_CANA(pID_ZAFRA, pNUMRECIBO_CANA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ENVIO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ENVIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarENVIO(ByVal ID_ENVIO As Int32) As Integer
        Try
            mEntidad.ID_ENVIO = ID_ENVIO
            Return Me.EliminarENVIO(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function EliminarENVIOenCascada(ByVal ID_ENVIO As Integer) As String
        Try
            Return mDb.EliminarENVIOenCascada(ID_ENVIO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return "-1|" + ex.Message
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ENVIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="ID_ENVIO">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function AnularENVIO(ByVal ID_ENVIO As Int32) As Integer
        Try
            Dim lEnvio As ENVIO = Me.ObtenerENVIO(ID_ENVIO)
            Dim lstBascula As listaBASCULA
            Dim bAnalisis As New cANALISIS
            Dim bBascula As New cBASCULA
            Dim sBoleta As String
            Dim sComprobante As String
            Dim strResp As String
            Dim arreglo() As String

            If lEnvio IsNot Nothing Then
                sBoleta = lEnvio.NROBOLETA.ToString
                sComprobante = lEnvio.COMPTENVIO.ToString
                lstBascula = bBascula.ObtenerListaPorENVIO(lEnvio.ID_ENVIO)

                If lEnvio.ANULADO Then
                    Me.sError = "Envio fue anulado en fecha " + lEnvio.FECHA_ANULACION.ToString("dd/MM/yyyy HH:mm")
                    Return -1
                End If
                If lEnvio.CERRADO Then
                    Me.sError = "Envio no puede anularse debido a que pertenece a un dia cerrado"
                    Return -1
                End If
                If lEnvio.NUMRECIBO_CANA >= 0 Then
                    Me.sError = "Envio no puede anularse debido a que tiene recibo de pesa emitido"
                    Return -1
                End If
                If lstBascula IsNot Nothing AndAlso lstBascula.Count > 0 AndAlso lstBascula(0).NETOTONEL > 0 Then
                    Me.sError = "Envio no puede anularse debido a que tiene peso tara capturado"
                    Return -1
                End If

                lEnvio.ANULADO = True
                lEnvio.USUARIO_ANULACION = Utilerias.ObtenerUsuario
                lEnvio.FECHA_ANULACION = cFechaHora.ObtenerFechaHora
            Else
                Me.sError = "Envio no existe"
                Return -1
            End If

            'No se elimina el análisis ya que queda como constancia del porque se anuló el envío

            'Eliminar bascula
            If lstBascula IsNot Nothing AndAlso lstBascula.Count > 0 Then
                bBascula.EliminarBASCULA(lstBascula(0).ID_BASCULA)
            End If

            'Anular proforma
            Dim listaProformas As listaPROFORMA = (New cPROFORMA).ObtenerListaPorENVIO(lEnvio.ID_ENVIO)
            Dim bProforma As New cPROFORMA
            If listaProformas IsNot Nothing AndAlso listaProformas.Count > 0 Then
                For i As Int32 = 0 To listaProformas.Count - 1
                    listaProformas(i).ESTADO = Enumeradores.EstadoProforma.Anulado
                    listaProformas(i).FECHA_ANUL = cFechaHora.ObtenerFechaHora
                    listaProformas(i).USUARIO_ANUL = Utilerias.ObtenerUsuario
                    listaProformas(i).OBSERVA_ANUL = "ANULACION DE PROFORMA POR ANULACION DE ENVIO CON Boleta N° " + sBoleta + _
                        ", Comprobante N° " + sComprobante
                    listaProformas(i).ID_ENVIO = -1
                    bProforma.ActualizarPROFORMA(listaProformas(i))
                Next
            End If

            strResp = mDb.EliminarENVIOenCascada(lEnvio.ID_ENVIO)
            arreglo = strResp.Split("|")
            If arreglo(0) = "0" Then
                Return 1
            Else
                Me.sError = arreglo(1)
                Return -1
            End If

        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ENVIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarENVIO(ByVal aEntidad As ENVIO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lEnvio As ENVIO = Me.ObtenerENVIO(aEntidad.ID_ENVIO)
            Dim bAnalisis As New cANALISIS
            Dim bBascula As New cBASCULA
            Dim sBoleta As String
            Dim sComprobante As String
            Dim strResp As String
            Dim arreglo() As String

            If lEnvio IsNot Nothing Then
                sBoleta = lEnvio.NROBOLETA.ToString
                sComprobante = lEnvio.COMPTENVIO.ToString
                If lEnvio.CERRADO Then
                    Me.sError = "Envio no puede eliminarse debido a que pertenece a un dia cerrado"
                    Return -1
                End If
                If lEnvio.ANULADO Then
                    Me.sError = "Envio no puede eliminarse porque fue anulado en fecha " + lEnvio.FECHA_ANULACION.ToString("dd/MM/yyyy HH:mm")
                    Return -1
                End If
            Else
                Me.sError = "Envio no existe"
                Return -1
            End If


            'Anular proforma
            Dim listaProformas As listaPROFORMA = (New cPROFORMA).ObtenerListaPorENVIO(lEnvio.ID_ENVIO)
            Dim bProforma As New cPROFORMA
            If listaProformas IsNot Nothing AndAlso listaProformas.Count > 0 Then
                For i As Int32 = 0 To listaProformas.Count - 1
                    listaProformas(i).ESTADO = Enumeradores.EstadoProforma.Anulado
                    listaProformas(i).FECHA_ANUL = cFechaHora.ObtenerFechaHora
                    listaProformas(i).USUARIO_ANUL = Utilerias.ObtenerUsuario
                    listaProformas(i).OBSERVA_ANUL = "ANULACION DE PROFORMA POR ANULACION DE ENVIO CON Boleta N° " + sBoleta + _
                        ", Comprobante N° " + sComprobante
                    listaProformas(i).ID_ENVIO = -1
                    bProforma.ActualizarPROFORMA(listaProformas(i))
                Next
            End If

            strResp = mDb.EliminarENVIOenCascada(lEnvio.ID_ENVIO)
            arreglo = strResp.Split("|")
            If arreglo(0) = "0" Then
                Return 1
            Else
                Me.sError = arreglo(1)
                Return -1
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
