Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleREQENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla REQENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleREQENCA
    Inherits ucBase

    Public Event Procesando(ByVal ID_REQENCA As Int32)

#Region "Propiedades"

    Public Property ETAPA_SIGUIENTE As EtapaRequisicion
        Get
            If Me.ViewState("ID_REQETAPA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_REQETAPA"))
            Else
                Return EtapaRequisicion.Todas
            End If
        End Get
        Set(ByVal value As EtapaRequisicion)
            Me.ViewState("ID_REQETAPA") = value
            Me.LimpiarControles()
            Me.ID_REQENCA = 0
        End Set
    End Property

    Public Property LISTA_REQDETA As listaREQDETA
        Set(value As listaREQDETA)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaREQDETA) Else Return New listaREQDETA
        End Get
    End Property

    Private _ID_REQENCA As Int32
    Public Property ID_REQENCA() As Int32
        Get
            If Me.ViewState("ID_REQENCA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_REQENCA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_REQENCA") = Value
            Me.lblREFERENCIA.Text = Now.ToString("dd/MM/yyyy HH:mm:ss zzz")
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
    End Sub

    Public Property ID_PERIODOREQ() As Int32
        Get
            Return Me.cbxID_PERIODOREQ.Value
        End Get
        Set(ByVal value As Int32)
            If Not Me.cbxID_PERIODOREQ.Items.FindByValue(value) Is Nothing Then
                Me.cbxID_PERIODOREQ.Value = value
            End If
        End Set
    End Property

    Public Property ID_SECCION() As Int32
        Get
            Return Me.cbxID_SECCION.Value
        End Get
        Set(ByVal value As Int32)
            If Not Me.cbxID_SECCION.Items.FindByValue(value) Is Nothing Then
                Me.cbxID_SECCION.Value = value
            End If
        End Set
    End Property

    Public Property ID_SOLICITANTE() As Int32
        Get
            Return Me.cbxID_SOLICITANTE.Value
        End Get
        Set(ByVal value As Int32)
            If Not Me.cbxID_SOLICITANTE.Items.FindByValue(value) Is Nothing Then
                Me.cbxID_SOLICITANTE.Value = value
            End If
        End Set
    End Property

    Public Property NO_REQ() As Int32
        Get
            If Me.txtCODI_REQ.Value Is Nothing Then Return -1
            Return CInt(Me.txtCODI_REQ.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtCODI_REQ.Value = value
        End Set
    End Property

    Public Property FECHA_EMISION() As DateTime
        Get
            Return Me.dteFECHA_EMISION.Date
        End Get
        Set(ByVal value As DateTime)
            Me.dteFECHA_EMISION.Date = value
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cREQENCA
    Private mEntidad As REQENCA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_REQENCA") Is Nothing Then Me._ID_REQENCA = Me.ViewState("ID_REQENCA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla REQENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = mComponente.ObtenerREQENCA(ID_REQENCA)

        If mEntidad Is Nothing Then
            Me.AsignarMensaje("* No. de Solicitud " + ID_REQENCA.ToString + " no existe para el periodo actual", True, False)
            Me.ID_REQENCA = 0
            Return
        End If
        Me.txtID_REQENCA.Text = mEntidad.ID_REQENCA.ToString()
        Me.cbxID_PERIODOREQ.Value = mEntidad.ID_PERIODOREQ
        Me.cbxID_SECCION.Value = mEntidad.ID_SECCION
        Me.cbxID_SOLICITANTE.Value = mEntidad.ID_SOLICITANTE
        Me.cbxID_REQETAPA.Value = mEntidad.ID_REQETAPA
        Me.txtCODI_REQ.Value = mEntidad.CODI_REQ
        Me.dteFECHA_EMISION.Value = mEntidad.FECHA_EMISION
        Me.LISTA_REQDETA = (New cREQDETA).ObtenerListaPorREQENCA(ID_REQENCA)
        Me.CargarDetalleSolicitud()
        Me.LimpiarInfoEtapas()
        Me.cbxID_PERIODOREQ.Value = mEntidad.ID_REQETAPA
        Me.txtSECCION.Text = mEntidad.SECCION
        Me.txtEQUIPO.Text = mEntidad.EQUIPO
        Me.cbxPROPOSITO.Value = mEntidad.PROPOSITO
        Me.cbxCOMPRA_LOCAL.Value = mEntidad.COMPRA_LOCAL
        Me.dteFECHA_MAX_SUMIN.Date = mEntidad.FECHA_MAX_SUMIN
        'Me.txtUSO.Text = mEntidad.USO

        If mEntidad.FECHA_APROB <> #12:00:00 AM# Then
            Me.infoAprobacionFecha.Text = mEntidad.FECHA_APROB.ToString("dd/MM/yyyy")
            Me.trInfoAprob.Visible = True
            Me.InfoEtapas.Visible = True
        End If
        If mEntidad.FECHA_REQ_PH <> #12:00:00 AM# Then
            Me.trInfoEtapaRequisicion.Visible = True
            Me.infoRequiNo.Text = mEntidad.NO_REQ_PH
            Me.infoRequiFecha.Text = mEntidad.FECHA_REQ_PH.ToString("dd/MM/yyyy")
            Me.trInfoReq.Visible = True
            Me.InfoEtapas.Visible = True
        End If
        If mEntidad.FECHA_RECIBOREQ <> #12:00:00 AM# Then
            Me.trInfoEtapaSolicitudCotizacion.Visible = True
            Me.infoCotiFECHA_RECIBOREQ.Text = mEntidad.FECHA_RECIBOREQ.ToString("dd/MM/yyyy")
            Me.infoCotiPROVEE_INVITADOS.Text = mEntidad.PROVEE_INVITADOS
            Me.trInfoReq.Visible = True
            Me.InfoEtapas.Visible = True
            Me.trInfoCotizacion.Visible = True
        End If
        If mEntidad.FECHA_ORDEN_PH <> #12:00:00 AM# Then
            Me.trInfoEtapaOC.Visible = True
            Me.infoOrdenNo.Text = mEntidad.NO_ORDEN_PH
            Me.infoOrdenFecha.Text = mEntidad.FECHA_ORDEN_PH.ToString("dd/MM/yyyy")
            Me.infoOrdenTotal.Text = mEntidad.TOTAL_ORDEN_PH.ToString("#,##0.00")
            Me.infoOrdenTipo.Text = If(mEntidad.ORDEN_LOCAL, "LOCAL", "EXTRANJERA")
            Me.infoOrdenFechaEstIngreso.Text = mEntidad.FECHA_ESTI_INGRESO_ORDEN.ToString("dd/MM/yyyy")
            Me.infoOrdenProveeAdj.Text = mEntidad.PROVEE_ADJUDICADO_ORDEN
            Me.trInfoOrden1.Visible = True
            Me.trInfoOrden2.Visible = True
            Me.trInfoOrden3.Visible = True
            Me.InfoEtapas.Visible = True
        End If
        If mEntidad.FECHA_INGRESO_ALM <> #12:00:00 AM# Then
            Me.trInfoEtapaIngresoAlmacen.Visible = True
            Me.infoIngAlmNo.Text = mEntidad.NO_INGRESO_ALM
            Me.infoIngAlmFecha.Text = mEntidad.FECHA_INGRESO_ALM.ToString("dd/MM/yyyy")
            Me.infoIngAlmTotal.Text = mEntidad.TOTAL_INGRESO_ALM.ToString("#,##0.00")
            Me.infoIngAlmNoDocto.Text = mEntidad.NO_DOCCOMPRA_ALM
            Me.infoIngAlmTipoDocto.Text = If(mEntidad.TIPO_DOCCOMPRA_ALM = 1, "CCF", "POLIZA")

            Me.trInfoIngAlm1.Visible = True
            Me.trInfoIngAlm2.Visible = True
            Me.InfoEtapas.Visible = True
        End If
        If mEntidad.FECHA_QUEDAN <> #12:00:00 AM# Then
            Me.trEtapaInfoQuedan.Visible = True
            Me.infoQuedanNo.Text = mEntidad.NO_QUEDAN
            Me.infoQuedanFecha.Text = mEntidad.FECHA_QUEDAN.ToString("dd/MM/yyyy")
            Me.infoQuedanTotal.Text = mEntidad.TOTAL_QUEDAN.ToString("#,##0.00")
            Me.trInfoQuedan.Visible = True
            Me.InfoEtapas.Visible = True
        End If
        If mEntidad.FECHA_CHQ <> #12:00:00 AM# Then
            Me.trEtapaInfoCheque.Visible = True
            Me.infoChequeNo.Text = mEntidad.NO_CHEQUE_CHQ
            Me.infoChequeBanco.Text = mEntidad.BANCO_CHQ
            Me.infoChequeFecha.Text = mEntidad.FECHA_CHQ.ToString("dd/MM/yyyy")
            Me.infoChequeMonto.Text = mEntidad.MONTO_CHQ.ToString("#,##0.00")
            Me.trInfoCheque1.Visible = True
            Me.trInfoCheque2.Visible = True
            Me.InfoEtapas.Visible = True
        End If
    End Sub

    Private Sub LimpiarInfoEtapas()
        Me.infoAprobacionFecha.Text = ""
        Me.trInfoAprob.Visible = False
        Me.infoRequiNo.Text = ""
        Me.infoRequiFecha.Text = ""
        Me.trInfoReq.Visible = False
        Me.infoOrdenNo.Text = ""
        Me.infoOrdenFecha.Text = ""
        Me.infoOrdenTotal.Text = ""
        Me.infoOrdenTipo.Text = ""
        Me.infoOrdenProveeAdj.Text = ""
        Me.infoOrdenFechaEstIngreso.Text = ""
        Me.trInfoOrden1.Visible = False
        Me.trInfoOrden1.Visible = False
        Me.infoIngAlmNo.Text = ""
        Me.infoIngAlmFecha.Text = ""
        Me.infoIngAlmTotal.Text = ""
        Me.trInfoIngAlm1.Visible = False
        Me.trInfoIngAlm2.Visible = False
        Me.infoQuedanNo.Text = ""
        Me.infoQuedanFecha.Text = ""
        Me.infoQuedanTotal.Text = ""
        Me.trInfoCheque1.Visible = False
        Me.trInfoQuedan.Visible = False
        Me.InfoEtapas.Visible = False
        Me.lblFechaReferencia.Text = "FECHA:"
        Me.trInfoCotizacion.Visible = False
        Me.infoCotiFECHA_RECIBOREQ.Text = ""
        Me.infoCotiPROVEE_INVITADOS.Text = ""
        Me.trInfoCheque1.Visible = True
        Me.trInfoCheque2.Visible = True
        Me.infoChequeNo.Text = ""
        Me.infoChequeBanco.Text = ""
        Me.infoChequeFecha.Text = ""
        Me.infoChequeMonto.Text = ""
        Me.trInfoEtapaRequisicion.Visible = False
        Me.trInfoEtapaSolicitudCotizacion.Visible = False
        Me.trInfoEtapaOC.Visible = False
        Me.trInfoEtapaIngresoAlmacen.Visible = False
        Me.trEtapaInfoQuedan.Visible = False
        Me.trEtapaInfoCheque.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        If ETAPA_SIGUIENTE = EtapaRequisicion.Todas Then
            Me.txtCODI_REQ.ClientEnabled = False
            Me.cbxID_REQETAPA.ClientEnabled = False
            Me.cbxID_PERIODOREQ.ClientEnabled = False
            Me.dteFECHA_EMISION.ClientEnabled = False
            Me.cbxID_SECCION.ClientEnabled = Me._nuevo
            Me.cbxID_SOLICITANTE.ClientEnabled = Me._nuevo
            Me.txtSECCION.ClientEnabled = Me._nuevo
            Me.txtEQUIPO.ClientEnabled = Me._nuevo
            Me.cbxPROPOSITO.ClientEnabled = Me._nuevo
            Me.cbxCOMPRA_LOCAL.ClientEnabled = Me._nuevo
            Me.dteFECHA_MAX_SUMIN.ClientEnabled = Me._nuevo

            Me.ucListaREQDETA1.PermitirAgregarInline = Me._nuevo 'Me._nuevo AndAlso edicion
            Me.ucListaREQDETA1.PermitirEditarInline = Me._nuevo 'Me._nuevo AndAlso edicion
            Me.ucListaREQDETA1.PermitirEliminarInline = Me._nuevo
            Me.ucListaREQDETA1.PermitirEliminar = Me._nuevo
            Me.ucListaREQDETA1.PermitirEditarInline2 = False
            If Me._nuevo Then Me.ucListaREQDETA1.IniciarEdicion() Else Me.ucListaREQDETA1.CancelarEdicion()
        Else
            Me.txtCODI_REQ.ClientEnabled = False
            Me.cbxID_REQETAPA.ClientEnabled = False
            Me.cbxID_PERIODOREQ.ClientEnabled = False
            Me.dteFECHA_EMISION.ClientEnabled = False
            Me.cbxID_SECCION.ClientEnabled = False
            Me.cbxID_SOLICITANTE.ClientEnabled = False
            Me.txtSECCION.ClientEnabled = False
            Me.txtEQUIPO.ClientEnabled = False
            Me.cbxPROPOSITO.ClientEnabled = False
            Me.cbxCOMPRA_LOCAL.ClientEnabled = False
            Me.dteFECHA_MAX_SUMIN.ClientEnabled = False

            Me.ucListaREQDETA1.CancelarEdicion()
            Me.ucListaREQDETA1.PermitirEditarInline = False
            Me.ucListaREQDETA1.PermitirEditarInline2 = False
            Me.ucListaREQDETA1.PermitirEliminarInline = False
            Me.ucListaREQDETA1.PermitirEliminar = False
            Me.txtCODI_REQ.Focus()
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Dim lPeriodo As PERIODOREQ = (New cPERIODOREQ).ObtenerPeriodoReqActivo
        If lPeriodo IsNot Nothing Then
            Me.cbxID_PERIODOREQ.Value = lPeriodo.ID_PERIODOREQ
        End If
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtCODI_REQ.Text = ""
        If ETAPA_SIGUIENTE = EtapaRequisicion.Todas Then
            Me.cbxID_REQETAPA.Value = EtapaRequisicion.Emitida
            Me.dteFECHA_EMISION.Date = cFechaHora.ObtenerFecha
            Me.LISTA_REQDETA = New listaREQDETA

            Dim lEntidad As New REQDETA
            lEntidad.ID_REQDETA = 1
            lEntidad.ID_REQENCA = -1
            lEntidad.REFERENCIA = Me.lblREFERENCIA.Text
            Me.LISTA_REQDETA.Add(lEntidad)
            Me.CargarDetalleSolicitud()
        Else
            Me.cbxID_REQETAPA.Value = ""
            Me.dteFECHA_EMISION.Value = Nothing
            Me.LISTA_REQDETA = (New cREQDETA).ObtenerListaPorREQENCA(ID_REQENCA)
            Me.CargarDetalleSolicitud()
        End If
        Me.cbxID_SECCION.Value = ""
        Me.cbxID_SOLICITANTE.Value = ""
        Me.txtSECCION.Text = ""
        Me.txtEQUIPO.Text = ""
        Me.cbxPROPOSITO.Value = Nothing
        Me.cbxCOMPRA_LOCAL.Value = Nothing

        Me.LimpiarInfoEtapas()
    End Sub

    Public Sub CargarDetalleSolicitud()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaREQDETA1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Public Function Procesar() As String
        Dim lEntidad As REQENCA
        Me.LimpiarCamposPopup()

        Select Case ETAPA_SIGUIENTE
            Case EtapaRequisicion.Todas
                Return Me.Actualizar

            Case EtapaRequisicion.Aprobada
                Me.pcProcesarSolicitud.HeaderText = "Evaluando Solicitud"
                lEntidad = mComponente.ObtenerREQENCA(Me.ID_REQENCA)
                If lEntidad IsNot Nothing Then
                    If lEntidad.ID_REQETAPA <> EtapaRequisicion.Emitida Then
                        Return "* La solicitud ya fue evaluada"
                    End If
                End If
                Me.trOpcion.Visible = True
                Me.trFechaReferencia.Visible = True
                Me.pcProcesarSolicitud.ShowOnPageLoad = True

            Case EtapaRequisicion.RequisicionAsignada
                Me.pcProcesarSolicitud.HeaderText = "Asignando Requisición"
                lEntidad = mComponente.ObtenerREQENCA(Me.ID_REQENCA)
                If lEntidad IsNot Nothing Then
                    If lEntidad.ID_REQETAPA <> EtapaRequisicion.Aprobada Then
                        Return "* La solicitud no esta aprobada"
                    End If
                    If lEntidad.ID_REQETAPA = EtapaRequisicion.RequisicionAsignada Then
                        Return "* La solicitud ya tiene asignada una Requisicion"
                    End If
                End If
                Me.lblNumReferencia.Text = "N° DE REQUISICIÓN:"
                Me.trNumReferencia.Visible = True
                Me.trFechaReferencia.Visible = True
                Me.pcProcesarSolicitud.ShowOnPageLoad = True

            Case EtapaRequisicion.CotizacionSolicitada
                Me.pcProcesarSolicitud.HeaderText = "Solicitando Cotizacion"
                lEntidad = mComponente.ObtenerREQENCA(Me.ID_REQENCA)
                If lEntidad IsNot Nothing Then
                    If lEntidad.ID_REQETAPA <> EtapaRequisicion.RequisicionAsignada Then
                        Return "* La solicitud no tiene asignada Requisicion"
                    End If
                    If lEntidad.ID_REQETAPA = EtapaRequisicion.CotizacionSolicitada Then
                        Return "* La solicitud ya tiene Solicitada una Cotización"
                    End If
                End If
                Me.lblNumReferencia.Text = ""
                Me.trNumReferencia.Visible = False
                Me.trFechaReferencia.Visible = True
                Me.lblFechaReferencia.Text = "FECHA RECIBO REQUISICION:"
                Me.trProveedoresInvitados.Visible = True
                Me.pcProcesarSolicitud.ShowOnPageLoad = True

            Case EtapaRequisicion.OrdenCompraAsignada
                Me.pcProcesarSolicitud.HeaderText = "Asignando Orden de Compra"
                lEntidad = mComponente.ObtenerREQENCA(Me.ID_REQENCA)
                If lEntidad IsNot Nothing Then
                    If lEntidad.ID_REQETAPA <> EtapaRequisicion.CotizacionSolicitada Then
                        Return "* La solicitud no iene cotizacion solicitada"
                    End If
                    If lEntidad.ID_REQETAPA = EtapaRequisicion.OrdenCompraAsignada Then
                        Return "* La solicitud ya tiene asignada Orden de compra"
                    End If
                End If
                Me.lblNumReferencia.Text = "N° DE ORDEN:"
                Me.trNumReferencia.Visible = True
                Me.trFechaReferencia.Visible = True
                Me.trTotal_SIVA.Visible = True
                Me.trTotal_CIVA.Visible = True
                Me.trTotal_IVA.Visible = True
                Me.trTipoCompra.Visible = True
                Me.trFechaEstIngreso.Visible = True
                Me.trProveedorAdjudicado.Visible = True
                Me.pcProcesarSolicitud.ShowOnPageLoad = True

            Case EtapaRequisicion.IngresoAlmacen
                Me.pcProcesarSolicitud.HeaderText = "Ingreso en Almacen"
                lEntidad = mComponente.ObtenerREQENCA(Me.ID_REQENCA)
                If lEntidad IsNot Nothing Then
                    If lEntidad.ID_REQETAPA <> EtapaRequisicion.OrdenCompraAsignada Then
                        Return "* La solicitud no tiene Orden de Compra Asignada"
                    End If
                    If lEntidad.ID_REQETAPA = EtapaRequisicion.IngresoAlmacen Then
                        Return "* La solicitud ya tiene Ingreso en Almacen"
                    End If
                End If
                Me.lblNumReferencia.Text = "N° DE INGRESO:"
                Me.trNumReferencia.Visible = True
                Me.trFechaReferencia.Visible = True
                Me.trTotal_SIVA.Visible = True
                Me.trTotal_CIVA.Visible = True
                Me.trTotal_IVA.Visible = True
                Me.trDoctoCompra1.Visible = True
                Me.trDoctoCompra2.Visible = True
                Me.trDoctoCompra3.Visible = True
                Me.pcProcesarSolicitud.ShowOnPageLoad = True

            Case EtapaRequisicion.QuedanAsignado
                Me.pcProcesarSolicitud.HeaderText = "Asignando Quedan"
                lEntidad = mComponente.ObtenerREQENCA(Me.ID_REQENCA)
                If lEntidad IsNot Nothing Then
                    If lEntidad.ID_REQETAPA <> EtapaRequisicion.IngresoAlmacen Then
                        Return "* La solicitud no tiene asignada Orden de Compra"
                    End If
                    If lEntidad.ID_REQETAPA = EtapaRequisicion.QuedanAsignado Then
                        Return "* La solicitud ya tiene asignado Quedan"
                    End If
                End If
                Me.lblNumReferencia.Text = "N° DE QUEDAN:"
                Me.trNumReferencia.Visible = True
                Me.trFechaReferencia.Visible = True
                Me.trTotal_SIVA.Visible = True
                Me.trTotal_CIVA.Visible = True
                Me.trTotal_IVA.Visible = True
                Me.pcProcesarSolicitud.ShowOnPageLoad = True

            Case EtapaRequisicion.Finalizado
                Me.pcProcesarSolicitud.HeaderText = "Asignando Cheque"
                lEntidad = mComponente.ObtenerREQENCA(Me.ID_REQENCA)
                If lEntidad IsNot Nothing Then
                    If lEntidad.ID_REQETAPA <> EtapaRequisicion.QuedanAsignado Then
                        Return "* La solicitud no tiene asignado Quedan"
                    End If
                    If lEntidad.ID_REQETAPA = EtapaRequisicion.Finalizado Then
                        Return "* La solicitud ya tiene asignado Cheque"
                    End If
                End If
                Me.lblNumReferencia.Text = "N° DE CHEQUE:"
                Me.trNumReferencia.Visible = True
                Me.trChequeBANCO.Visible = True
                Me.trChequeFECHA.Visible = True
                Me.trChequeMONTO.Visible = True
                Me.pcProcesarSolicitud.ShowOnPageLoad = True
        End Select

        Return ""
    End Function

    Private Sub LimpiarCamposPopup()
        Me.lblpcError.Text = ""
        Me.rblAprobar.Value = Nothing
        Me.dteFechaReferencia.Text = ""
        Me.dteFechaReferencia.Value = Nothing
        Me.txtNumReferencia.Text = ""
        Me.speTotal.Value = 0
        Me.speTotalSinIva.Value = 0
        Me.speTotalIva.Value = 0
        Me.rblTipoCompra.Value = Nothing
        Me.dteFechaEstimadaIngreso.Value = Nothing
        Me.txtNoDoctoCompra.Text = ""
        Me.cbxTipoDoctoCompra.Value = Nothing
        Me.txtProveedorAdjudicado.Text = ""
        Me.txtBANCO_CHQ.Text = ""
        Me.dteFECHA_CHQ.Value = Nothing
        Me.speMONTO_CHQ.Value = Nothing
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla REQENCA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim bReqDeta As New cREQDETA

        mEntidad = New REQENCA
        If Me._nuevo Then
            If Me.cbxID_PERIODOREQ.Value Is Nothing Then
                Return "* Seleccione un periodo"
            End If
            If Me.cbxID_SECCION.Value Is Nothing Then
                Return "* Seleccione una seccion"
            End If
            If Me.cbxID_SOLICITANTE.Value Is Nothing Then
                Return "* Seleccione el solicitante"
            End If
            If Me.cbxCOMPRA_LOCAL.Value Is Nothing Then
                Return "* Seleccione el tipo de compra"
            End If
            If Me.dteFECHA_MAX_SUMIN.Date = #12:00:00 AM# Then
                Return "* Ingrese la fecha maxima de suministro"
            End If
            mEntidad.ID_REQENCA = 0
            mEntidad.ID_PERIODOREQ = Me.cbxID_PERIODOREQ.Value
            mEntidad.ID_SECCION = Me.cbxID_SECCION.Value
            mEntidad.ID_SOLICITANTE = Me.cbxID_SOLICITANTE.Value
            mEntidad.FECHA_EMISION = cFechaHora.ObtenerFecha
            mEntidad.USO = ""
            mEntidad.SECCION = Me.txtSECCION.Text.Trim.ToUpper
            mEntidad.EQUIPO = Me.txtEQUIPO.Text.Trim.ToUpper
            mEntidad.PROPOSITO = Me.cbxPROPOSITO.Value
            mEntidad.COMPRA_LOCAL = Me.cbxCOMPRA_LOCAL.Value
            mEntidad.FECHA_MAX_SUMIN = Me.dteFECHA_MAX_SUMIN.Date

            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFecha

            mEntidad.ID_REQETAPA = EtapaRequisicion.Emitida
            mEntidad.NO_REQ_PH = Nothing
            mEntidad.FECHA_REQ_PH = Nothing
            mEntidad.NO_ORDEN_PH = Nothing
            mEntidad.FECHA_ORDEN_PH = Nothing
            mEntidad.TOTAL_ORDEN_PH = -1
            mEntidad.AFECTO_ORDEN_PH = -1
            mEntidad.IVA_ORDEN_PH = -1
            mEntidad.NO_INGRESO_ALM = Nothing
            mEntidad.FECHA_INGRESO_ALM = Nothing
            mEntidad.NO_QUEDAN = Nothing
            mEntidad.FECHA_QUEDAN = Nothing

            mEntidad.FECHA_RECIBOREQ = Nothing
            mEntidad.PROVEE_INVITADOS = Nothing
            mEntidad.PROVEE_ADJUDICADO_ORDEN = Nothing
            mEntidad.FECHA_ESTI_INGRESO_ORDEN = Nothing
            mEntidad.TIPO_DOCCOMPRA_ALM = -1
            mEntidad.NO_DOCCOMPRA_ALM = Nothing
            mEntidad.NO_CHEQUE_CHQ = Nothing
            mEntidad.BANCO_CHQ = Nothing
            mEntidad.FECHA_CHQ = Nothing
            mEntidad.MONTO_CHQ = -1

            mEntidad.USUARIO_APROB = Nothing
            mEntidad.FECHA_APROB = Nothing
            mEntidad.USUARIO_NOAPROB = Nothing
            mEntidad.FECHA_NOAPROB = Nothing
            mEntidad.USUARIO_ANUL = Nothing
            mEntidad.FECHA_ANUL = Nothing
            mEntidad.FECHA_APROB = Nothing

            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cREQENCA).ObtenerREQENCA(Me.ID_REQENCA)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If

        If Me.LISTA_REQDETA.Count = 0 OrElse _
            (Me.LISTA_REQDETA.Count = 1 AndAlso Me.LISTA_REQDETA(0).ID_REQENCA = -1) Then
            Return "* Ingrese detalle de la solicitud"
        End If

        If mComponente.ActualizarREQENCA(mEntidad) <= -1 Then
            Return "* Error al Guardar registro: " + mComponente.sError
        End If

        '*************************************
        'Detalle de Solicitud 
        '*************************************
        Dim lReqDeta As REQDETA
        For Each lEntidad As REQDETA In Me.LISTA_REQDETA
            If Me._nuevo Then
                lReqDeta = New REQDETA
                lReqDeta.ID_REQDETA = 0
                lReqDeta.ID_REQENCA = mEntidad.ID_REQENCA
                lReqDeta.CODIGO = lEntidad.CODIGO
                lReqDeta.CANTIDAD = lEntidad.CANTIDAD
                lReqDeta.UNIDAD = lEntidad.UNIDAD
                lReqDeta.DESCRIPCION = lEntidad.DESCRIPCION
                lReqDeta.OBSERVACION = lEntidad.OBSERVACION
                lReqDeta.USUARIO_CREA = Me.ObtenerUsuario
                lReqDeta.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lReqDeta.USUARIO_ACT = Me.ObtenerUsuario
                lReqDeta.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bReqDeta.ActualizarREQDETA(lReqDeta)
            End If
        Next

        Me.AsignarMensaje("La solicitud fue emitida con exito", False, True, True)
        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarSolicitudRequisicion(" + mEntidad.ID_REQENCA.ToString + ")", True)

        Me.LimpiarControles()
        Me.ID_REQENCA = 0
        Return ""
    End Function

    Protected Sub txtCODI_REQ_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODI_REQ.ValueChanged
        Dim lista As listaREQENCA

        lista = (New cREQENCA).ObtenerListaPorCriterios(Me.cbxID_PERIODOREQ.Value, -1, Me.txtCODI_REQ.Value, -1, -1, "")
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Me.ID_REQENCA = lista(0).ID_REQENCA
        Else
            Me.AsignarMensaje("* No. de Solicitud " + Me.txtCODI_REQ.Text + " no existe para el periodo actual", True, False)
        End If
    End Sub

    Public Function VerSolicitud() As String
        Dim lEntidad As REQENCA

        lEntidad = mComponente.ObtenerREQENCA(ID_REQENCA)
        If lEntidad IsNot Nothing Then
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarSolicitudRequisicion(" + lEntidad.ID_REQENCA.ToString + ")", True)
        End If

        Return ""
    End Function

    Protected Sub btnAceptar_Click(sender As Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim lEntidad As REQENCA
        lEntidad = mComponente.ObtenerREQENCA(Me.ID_REQENCA)

        If lEntidad IsNot Nothing Then
            Select Case ETAPA_SIGUIENTE
                Case EtapaRequisicion.Aprobada
                    If Me.dteFechaReferencia.Date < lEntidad.FECHA_EMISION Then
                        Me.lblpcError.Text = "Fecha de evaluacion no puede ser menor a la fecha de emision"
                        Return
                    End If
                    If rblAprobar.Value Then
                        lEntidad.ID_REQETAPA = EtapaRequisicion.Aprobada
                        lEntidad.FECHA_APROB = Me.dteFechaReferencia.Date
                        lEntidad.USUARIO_APROB = Me.ObtenerUsuario
                    Else
                        lEntidad.ID_REQETAPA = EtapaRequisicion.Rechazada
                        lEntidad.FECHA_NOAPROB = Me.dteFechaReferencia.Date
                        lEntidad.USUARIO_NOAPROB = Me.ObtenerUsuario
                    End If

                Case EtapaRequisicion.RequisicionAsignada
                    If Me.dteFechaReferencia.Date < lEntidad.FECHA_APROB Then
                        Me.lblpcError.Text = "Fecha de requisicion no puede ser menor a la fecha de aprobacion"
                        Return
                    End If
                    lEntidad.ID_REQETAPA = EtapaRequisicion.RequisicionAsignada
                    lEntidad.NO_REQ_PH = Me.txtNumReferencia.Text
                    lEntidad.FECHA_REQ_PH = Me.dteFechaReferencia.Date

                Case EtapaRequisicion.CotizacionSolicitada
                    If Me.dteFechaReferencia.Date < lEntidad.FECHA_APROB Then
                        Me.lblpcError.Text = "Fecha de solicitud de cotizacion no puede ser menor a la fecha de requisicion"
                        Return
                    End If
                    If Me.txtPROVEE_INVITADOS.Text.Trim = "" Then
                        Me.lblpcError.Text = "Ingrese los proveedores invitados"
                        Return
                    End If
                    lEntidad.ID_REQETAPA = EtapaRequisicion.CotizacionSolicitada
                    lEntidad.FECHA_RECIBOREQ = Me.dteFechaReferencia.Date
                    lEntidad.PROVEE_INVITADOS = Me.txtPROVEE_INVITADOS.Text.Trim.ToUpper

                Case EtapaRequisicion.OrdenCompraAsignada
                    If Me.dteFechaReferencia.Date < lEntidad.FECHA_RECIBOREQ Then
                        Me.lblpcError.Text = "Fecha de orden de compra no puede ser menor a la fecha de solicitud de cotizacion"
                        Return
                    End If
                    If Me.dteFechaEstimadaIngreso.Date < Me.dteFechaReferencia.Date Then
                        Me.lblpcError.Text = "Fecha estimada de ingreso debe ser mayor o igual a la fecha de la Orden"
                        Return
                    End If
                    lEntidad.ID_REQETAPA = EtapaRequisicion.OrdenCompraAsignada
                    lEntidad.NO_ORDEN_PH = Me.txtNumReferencia.Text
                    lEntidad.FECHA_ORDEN_PH = Me.dteFechaReferencia.Date
                    lEntidad.AFECTO_ORDEN_PH = Me.speTotalSinIva.Value
                    lEntidad.IVA_ORDEN_PH = Me.speTotalIva.Value
                    lEntidad.TOTAL_ORDEN_PH = Me.speTotal.Value
                    lEntidad.ORDEN_LOCAL = rblTipoCompra.Value
                    lEntidad.FECHA_ESTI_INGRESO_ORDEN = Me.dteFechaEstimadaIngreso.Date
                    lEntidad.PROVEE_ADJUDICADO_ORDEN = Me.txtProveedorAdjudicado.Text.Trim.ToUpper


                Case EtapaRequisicion.IngresoAlmacen
                    If Me.dteFechaReferencia.Date < lEntidad.FECHA_ORDEN_PH Then
                        Me.lblpcError.Text = "Fecha de ingreso al almacen no puede ser menor a la fecha de la orden de compra"
                        Return
                    End If
                    lEntidad.ID_REQETAPA = EtapaRequisicion.IngresoAlmacen
                    lEntidad.NO_INGRESO_ALM = Me.txtNumReferencia.Text
                    lEntidad.FECHA_INGRESO_ALM = Me.dteFechaReferencia.Date
                    lEntidad.AFECTO_INGRESO_ALM = Me.speTotalSinIva.Value
                    lEntidad.IVA_INGRESO_ALM = Me.speTotalIva.Value
                    lEntidad.TOTAL_INGRESO_ALM = Me.speTotal.Value
                    lEntidad.NO_DOCCOMPRA_ALM = Me.txtNoDoctoCompra.Text
                    lEntidad.TIPO_DOCCOMPRA_ALM = Me.cbxTipoDoctoCompra.Value

                Case EtapaRequisicion.QuedanAsignado
                    If Me.dteFechaReferencia.Date < lEntidad.FECHA_ORDEN_PH Then
                        Me.lblpcError.Text = "Fecha de quedan no puede ser menor a la fecha de ingreso al almacen"
                        Return
                    End If
                    lEntidad.ID_REQETAPA = EtapaRequisicion.QuedanAsignado
                    lEntidad.NO_QUEDAN = Me.txtNumReferencia.Text
                    lEntidad.FECHA_QUEDAN = Me.dteFechaReferencia.Date
                    lEntidad.AFECTO_QUEDAN = Me.speTotalSinIva.Value
                    lEntidad.IVA_QUEDAN = Me.speTotalIva.Value
                    lEntidad.TOTAL_QUEDAN = Me.speTotal.Value

                Case EtapaRequisicion.Finalizado
                    If Me.dteFECHA_CHQ.Date < lEntidad.FECHA_QUEDAN Then
                        Me.lblpcError.Text = "Fecha de cheque no puede ser menor a la fecha de ingreso al almacen"
                        Return
                    End If
                    lEntidad.ID_REQETAPA = EtapaRequisicion.Finalizado
                    lEntidad.NO_CHEQUE_CHQ = Me.txtNumReferencia.Text
                    lEntidad.BANCO_CHQ = Me.txtBANCO_CHQ.Text.Trim.ToUpper
                    lEntidad.FECHA_CHQ = Me.dteFECHA_CHQ.Date
                    lEntidad.MONTO_CHQ = Me.speMONTO_CHQ.Value
            End Select

            lEntidad.USUARIO_ACT = Me.ObtenerUsuario
            lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            If mComponente.ActualizarREQENCA(lEntidad) <= -1 Then
                Me.lblpcError.Text = "Error al actualizar la Solicitud: " + mComponente.sError
                Return
            End If
            Me.pcProcesarSolicitud.ShowOnPageLoad = False
        End If

        Me.pcProcesarSolicitud.ShowOnPageLoad = False
        Me.LimpiarControles()
        Me.ID_REQENCA = 0
        RaiseEvent Procesando(lEntidad.ID_REQENCA)
    End Sub

    Protected Sub AsignarTotal(sender As Object, e As System.EventArgs) Handles speTotalSinIva.ValueChanged, speTotalIva.ValueChanged
        If IsNumeric(speTotalSinIva.Value) AndAlso IsNumeric(speTotalIva.Value) Then
            speTotal.Value = speTotalSinIva.Value + speTotalIva.Value
        Else
            speTotal.Value = 0
        End If
    End Sub
End Class
