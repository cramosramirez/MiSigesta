Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPLANILLA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PLANILLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.lblTitulo.Text = "Descuentos de Catorcena"
        Me.ucCriterios1.Visible = True
        Me.ucCriterios1.VerID_ZAFRA = True
        Me.ucCriterios1.VerID_CATORCENA = True
        Me.ucCriterios1.VerID_TIPO_PLANILLA = True
        Me.ucCriterios1.VerCODIPROVEEDOR_TRANSPORTISTA = True
        Me.ucCriterios1.VerNOMBRE_PROVEEDOR_TRANSPORTISTA = True

        Me.ucListaPLANILLA1.Visible = True
        Me.ucVistaDetallePLANILLA1.Visible = False
        Me.ucVistaDetalleDESCUENTOS_PLANILLA1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PLANILLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaPLANILLA1.Visible = False
        Me.ucVistaDetallePLANILLA1.Visible = True
    End Sub


    Private Sub InicializarDescuento()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("GuardarDescuento", "Guardar Descuento", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("CancelarDescuento", "Cancelar Descuento", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarDescuento", True)
        Me.ucBarraNavegacion1.VerOpcion("CancelarDescuento", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucCriterios1.Visible = False
        Me.ucListaPLANILLA1.Visible = False
        Me.ucVistaDetalleDESCUENTOS_PLANILLA1.Visible = True
    End Sub
#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetallePLANILLA1.LimpiarControles()
        'Me.ucVistaDetallePLANILLA1.ID_CATORCENA = CInt(Me.ddlCATORCENA_ZAFRAID_CATORCENA.SelectedValue)
        'Me.ucVistaDetallePLANILLA1.ID_TIPO_PLANILLA = CInt(Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue)
        Me.ucVistaDetallePLANILLA1.CODIPROVEEDOR_TRANSPORTISTA = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetallePLANILLA1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaPLANILLA1_Editando(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32) Handles ucListaPLANILLA1.Editando
        '   Se ingresarÃ¡ descuento en lugar de editar el registro
        Me.InicializarDescuento()
        Me.ucVistaDetalleDESCUENTOS_PLANILLA1.IniciarDescuentos(ID_CATORCENA, CODIPROVEEDOR_TRANSPORTISTA, ID_TIPO_PLANILLA)
    End Sub

    Private Sub ucVistaDetallePLANILLA1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetallePLANILLA1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                If Me.ucCriterios1.ID_TIPO_PLANILLA = 1 Then
                    Me.ucListaPLANILLA1.VerCANT_RECIBOS = False
                    Me.ucListaPLANILLA1.VerAZUCAR_CATORCENA_REAL = True
                    Me.ucListaPLANILLA1.VerRoza = True
                    Me.ucListaPLANILLA1.VerCarga = True
                    Me.ucListaPLANILLA1.VerDESC_FLETE = True
                    If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                        Me.ucListaPLANILLA1.VerRENTA = False
                    Else
                        Me.ucListaPLANILLA1.VerRENTA = True
                    End If
                End If
                If Me.ucCriterios1.ID_TIPO_PLANILLA = 2 Then
                    Me.ucListaPLANILLA1.VerCANT_RECIBOS = True
                    Me.ucListaPLANILLA1.VerAZUCAR_CATORCENA_REAL = False
                    Me.ucListaPLANILLA1.VerRoza = False
                    Me.ucListaPLANILLA1.VerCarga = False
                    Me.ucListaPLANILLA1.VerDESC_FLETE = False
                    If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                        Me.ucListaPLANILLA1.VerRENTA = False
                    Else
                        Me.ucListaPLANILLA1.VerRENTA = True
                    End If
                End If
                Me.ucListaPLANILLA1.CargarDatosPorCRITERIOS(Me.ucCriterios1.ID_CATORCENA, _
                                                            Me.ucCriterios1.ID_TIPO_PLANILLA, _
                                                            Me.ucCriterios1.CODIPROVEEDOR_TRANSPORTISTA, _
                                                            Me.ucCriterios1.NOMBRE_PROVEEDOR_TRANSPORTISTA, _
                                                            Me.ucCriterios1.ES_CONTRIBUYENTE)
            Case "GuardarDescuento"
                Me.ucVistaDetalleDESCUENTOS_PLANILLA1.Actualizar()
                Me.ucListaPLANILLA1.CargarDatosPorCRITERIOS(Me.ucCriterios1.ID_CATORCENA, _
                                                            Me.ucCriterios1.ID_TIPO_PLANILLA, _
                                                            Me.ucCriterios1.CODIPROVEEDOR_TRANSPORTISTA, _
                                                            Me.ucCriterios1.NOMBRE_PROVEEDOR_TRANSPORTISTA, _
                                                            Me.ucCriterios1.ES_CONTRIBUYENTE)

            Case "CancelarDescuento"
                Me.InicializarLista()
        End Select
        
    End Sub
End Class
