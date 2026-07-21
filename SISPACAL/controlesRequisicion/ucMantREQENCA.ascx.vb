Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantREQENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla REQENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantREQENCA
    Inherits ucBase

    Private _etapaRequisicion As EtapaRequisicion
    Public Property ETAPA_SIGUIENTE As EtapaRequisicion
        Get
            Return _etapaRequisicion
        End Get
        Set(ByVal value As EtapaRequisicion)
            _etapaRequisicion = value
        End Set
    End Property

    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("VistaPrevia", False)
        Me.ucCriteriosReqEncaLayout.Visible = False
        Me.ucListaREQENCA1.Visible = True
        Me.ucVistaDetalleREQENCA1.Visible = False
    End Sub

    Private Sub InicializarDetalle(Optional editarEmision As Boolean = False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        If Not editarEmision Then Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        If ETAPA_SIGUIENTE <> EtapaRequisicion.Emitida Then
            Me.ucBarraNavegacion1.VerOpcion("VistaPrevia", False)
        End If
        Me.ucCriteriosReqEncaLayout.Visible = False
        Me.ucListaREQENCA1.Visible = False
        Me.ucVistaDetalleREQENCA1.Visible = True
    End Sub

    Private Sub Inicializar()
        Dim lPeriodo As PERIODOREQ = (New cPERIODOREQ).ObtenerPeriodoReqActivo
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucVistaDetalleREQENCA1.ETAPA_SIGUIENTE = ETAPA_SIGUIENTE
        Select Case ETAPA_SIGUIENTE
            Case EtapaRequisicion.Todas
                lblTitulo.Text = "Lista de Solicitudes"
                Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva Solicitud", False, IconoBarra.Generar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Emitir Solicitud", False, IconoBarra.Guardar, "", "", True)

            Case EtapaRequisicion.Aprobada
                lblTitulo.Text = "Lista de Solicitudes pendientes de Evaluar"
                Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Evaluar Solicitud", False, IconoBarra.Guardar, "", "", True)

            Case EtapaRequisicion.RequisicionAsignada
                lblTitulo.Text = "Lista de Solicitudes pendientes de asignar Requisición"
                Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Asignar Requisicion", False, IconoBarra.Guardar, "", "", True)

            Case EtapaRequisicion.CotizacionSolicitada
                lblTitulo.Text = "Lista de Solicitudes pendientes de solicitar Cotizacion"
                Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Solicitar Cotizacion", False, IconoBarra.Guardar, "", "", True)

            Case EtapaRequisicion.OrdenCompraAsignada
                lblTitulo.Text = "Lista de Solicitudes pendientes de asignar Orden de Compra"
                Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Asignar Orden de Compra", False, IconoBarra.Guardar, "", "", True)

            Case EtapaRequisicion.IngresoAlmacen
                lblTitulo.Text = "Lista de Solicitudes pendientes de ingresar a Almacen"
                Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Registrar en Almacen", False, IconoBarra.Guardar, "", "", True)

            Case EtapaRequisicion.QuedanAsignado
                lblTitulo.Text = "Lista de Solicitudes pendientes de asignar Quedan"
                Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Asignar Quedan", False, IconoBarra.Guardar, "", "", True)

            Case EtapaRequisicion.Finalizado
                lblTitulo.Text = "Lista de Solicitudes pendientes de asignar Cheque"
                Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Asignar Cheque", False, IconoBarra.Guardar, "", "", True)
        End Select


        Me.ucBarraNavegacion1.CrearOpcion("VistaPrevia", "Ver Solicitud", False, IconoBarra.VistaPrevia, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        If ETAPA_SIGUIENTE <> EtapaRequisicion.Emitida Then
            Me.ucBarraNavegacion1.VerOpcion("VistaPrevia", False)
        End If
        Me.ucBarraNavegacion1.CargarOpciones()

        If lPeriodo IsNot Nothing Then
            Me.cbxPERIODO.Value = lPeriodo.ID_PERIODOREQ
            Dim etapaActual As EtapaRequisicion

            Select Case ETAPA_SIGUIENTE
                Case EtapaRequisicion.Todas
                    etapaActual = EtapaRequisicion.Todas
                Case EtapaRequisicion.Aprobada
                    etapaActual = EtapaRequisicion.Emitida
                Case EtapaRequisicion.RequisicionAsignada
                    etapaActual = EtapaRequisicion.Aprobada
                Case EtapaRequisicion.CotizacionSolicitada
                    etapaActual = EtapaRequisicion.RequisicionAsignada
                Case EtapaRequisicion.OrdenCompraAsignada
                    etapaActual = EtapaRequisicion.CotizacionSolicitada
                Case EtapaRequisicion.IngresoAlmacen
                    etapaActual = EtapaRequisicion.OrdenCompraAsignada
                Case EtapaRequisicion.QuedanAsignado
                    etapaActual = EtapaRequisicion.IngresoAlmacen
                Case EtapaRequisicion.Finalizado
                    etapaActual = EtapaRequisicion.QuedanAsignado
            End Select
            Me.ucListaREQENCA1.CargarDatosPorCriterios(lPeriodo.ID_PERIODOREQ, -1, "", -1, -1, etapaActual)
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaREQENCA1_Editando(ID_REQENCA As Integer) Handles ucListaREQENCA1.Editando
        If ETAPA_SIGUIENTE = EtapaRequisicion.Todas Then Me.InicializarDetalle(True) Else Me.InicializarDetalle()
        Me.ucBarraNavegacion1.VerOpcion("VistaPrevia", True)
        Me.ucVistaDetalleREQENCA1.ID_REQENCA = ID_REQENCA
    End Sub

    Protected Sub ucListaREQENCA1_Procesando(ID_REQENCA As Integer) Handles ucVistaDetalleREQENCA1.Procesando
        Me.ucVistaDetalleREQENCA1.LimpiarControles()
        Me.ucVistaDetalleREQENCA1.ID_REQENCA = 0
        Me.InicializarLista()
        Me.ucListaREQENCA1.DataBind()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim noReq As Integer = -1
                If Me.txtNUM_SOLICITUD.Text <> "" Then noReq = Me.txtNUM_SOLICITUD.Value
                'Me.ucListaREQENCA1.CargarDatosPorCriterios(Me.cbxPERIODO.Value, noReq, -1, -1)

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleREQENCA1.LimpiarControles()
                Me.ucVistaDetalleREQENCA1.ID_REQENCA = 0

            Case "VistaPrevia"
                Me.ucVistaDetalleREQENCA1.VerSolicitud()
               
            Case "Guardar"
                Me.ucVistaDetalleREQENCA1.Procesar()

            Case "Cancelar"
                Me.AsignarMensaje("", True, False)
                Me.ucVistaDetalleREQENCA1.LimpiarControles()
                Me.ucVistaDetalleREQENCA1.ID_REQENCA = 0
                Me.InicializarLista()
                Me.ucListaREQENCA1.DataBind()
        End Select
    End Sub
End Class
