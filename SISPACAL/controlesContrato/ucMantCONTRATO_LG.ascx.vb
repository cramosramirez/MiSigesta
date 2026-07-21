Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCONTRATO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla CONTRATO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCONTRATO_LG
    Inherits ucBase


    Private _tipo_operacion As TipoOperacionContrato
    Public Property TIPO_OPERACION As TipoOperacionContrato
        Get
            Return _tipo_operacion
        End Get
        Set(ByVal value As TipoOperacionContrato)
            _tipo_operacion = value
        End Set
    End Property

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CONTRATO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------


    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)

        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("CrearProveedor", False)
        Me.ucBarraNavegacion1.VerOpcion("CrearSocio", False)
        Me.ucBarraNavegacion1.VerOpcion("CrearLote", False)
        Me.ucBarraNavegacion1.VerOpcion("TraspasarLote", False)
        Me.ucBarraNavegacion1.VerOpcion("Actualizar", False)
        Me.ucBarraNavegacion1.VerOpcion("Habilitar", False)

        Me.ucCriteriosLotesLayout.Visible = True
        Me.ucListaCONTRATO_LG1.Visible = True
        Me.ucVistaDetalleCONTRATO_LG1.LimpiarSesion()
        Me.ucVistaDetalleCONTRATO_LG1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CONTRATO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    ''' 

    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("CrearProveedor", True)
        Me.ucBarraNavegacion1.VerOpcion("CrearSocio", True)
        Me.ucBarraNavegacion1.VerOpcion("CrearLote", True)
        Me.ucBarraNavegacion1.VerOpcion("TraspasarLote", True)
        Me.ucBarraNavegacion1.VerOpcion("Actualizar", True)
        Me.ucBarraNavegacion1.VerOpcion("Habilitar", False)

        Me.ucCriteriosLotesLayout.Visible = False
        Me.ucListaCONTRATO_LG1.Visible = False
        Me.ucVistaDetalleCONTRATO_LG1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarCONTRATO()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarCONTRATO() As Integer
        If Me.ucListaCONTRATO_LG1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucVistaDetalleCONTRATO_LG1.TIPO_OPERACION = Me.TIPO_OPERACION
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo Contrato", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("CrearProveedor", "Ingresar nuevo Proveedor", False, IconoBarra.Proveedor, "onclick", "e.processOnServer=false;CrearProveedor()", True)
        Me.ucBarraNavegacion1.CrearOpcion("CrearSocio", "Ingresar nuevo socio", False, IconoBarra.Socio, "onclick", "e.processOnServer=false;CrearSocio()", True)
        Me.ucBarraNavegacion1.CrearOpcion("CrearLote", "Ingresar nuevo Lote", False, IconoBarra.Lote, "onclick", "e.processOnServer=false;CrearLote()", True)
        Me.ucBarraNavegacion1.CrearOpcion("TraspasarLote", "Traspasar Lote de Contrato", False, "people_team_16x16", "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Habilitar", "Habilitar contrato para ejecución", False, "miscellaneous_design_16x16", "", "", True)
        Select Case TIPO_OPERACION
            Case TipoOperacionContrato.Ingreso
                Me.lblTitulo.Text = "Mantenimiento de Contratos Legales"

            Case TipoOperacionContrato.Consulta
                Me.lblTitulo.Text = "Consulta de Contratos Legales"
        End Select
        Me.ucBarraNavegacion1.CrearOpcion("Actualizar", "Actualizar lotes", False, IconoBarra.Actualizar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.CargarZafras()
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaCONTRATO_LG1_Editando(ByVal CODICONTRATO As String) Handles ucListaCONTRATO_LG1.Editando
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        Me.InicializarDetalle()
        Me.ucBarraNavegacion1.VerOpcion("Habilitar", True)
        Me.ucVistaDetalleCONTRATO_LG1.CODICONTRATO = CODICONTRATO
        Me.SetearAREA_TCXAREA()
        If lZafra IsNot Nothing Then
            If lZafra.ID_ZAFRA <> Me.ucVistaDetalleCONTRATO_LG1.ID_ZAFRA Then
                'Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
                Me.ucBarraNavegacion1.VerOpcion("CrearProveedor", False)
                Me.ucBarraNavegacion1.VerOpcion("CrearSocio", False)
                Me.ucBarraNavegacion1.VerOpcion("CrearLote", False)
                Me.ucBarraNavegacion1.VerOpcion("Actualizar", True)
            End If
        End If
    End Sub

    Private Sub ucVistaDetalleCONTRATO1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleCONTRATO_LG1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Private Sub CargarZafras()
        Dim lZafra As ZAFRA
        Dim lZafras As New listaZAFRA


        lZafra = (New cZAFRA).ObtenerZafraActiva
        lZafras = (New cZAFRA).ObtenerLista
        Me.cbxZAFRAadd.DataSource = lZafras
        Me.cbxZAFRAadd.DataBind()
        If Me.cbxZAFRAadd.Items.Count > 0 AndAlso lZafra IsNot Nothing Then Me.cbxZAFRAadd.Value = lZafra.ID_ZAFRA
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim noContrato As Integer = -1
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""
                If Me.txtCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.txtCODIPROVEE.Text))
                If Me.txtCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.txtCODISOCIO.Text))

                If Me.txtNO_CONTRATO.Text <> "" Then
                    noContrato = Me.txtNO_CONTRATO.Value
                End If
                Me.ucListaCONTRATO_LG1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, noContrato, CODIPROVEE, CODISOCIO)

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleCONTRATO_LG1.LimpiarControles()
                Me.ucVistaDetalleCONTRATO_LG1.CODICONTRATO = ""

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleCONTRATO_LG1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaCONTRATO_LG1.DataBind()

            Case "TraspasarLote"
                Dim lResult As String = Me.ucVistaDetalleCONTRATO_LG1.ElegirLoteContratado
                AsignarMensaje(lResult, True, False)

            Case "Cancelar"
                Me.InicializarLista()

            Case "Actualizar"
                Me.ucVistaDetalleCONTRATO_LG1.RefrescarDetalleLotes()

            Case "Habilitar"
                Dim sError As String
                sError = Me.ucVistaDetalleCONTRATO_LG1.HabilitarContratoEjecucion(Me.ucVistaDetalleCONTRATO_LG1.CODICONTRATO)
                If sError <> "" Then
                    AsignarMensaje(sError, False, True)
                    Return
                Else
                    AsignarMensaje("Se ha realizado la habilitación de ejecucion del contrato", False, True)
                    Return
                End If
        End Select
    End Sub

    Protected Sub cpMantCONTRATO_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMantCONTRATO_LG.Callback
        Dim parametros As String() = e.Parameter.Split(";")
        Me.cpMantCONTRATO_LG.JSProperties.Clear()
        Me.cpMantCONTRATO_LG.JSProperties.Add("cpOpcion", parametros(0))

        Select Case parametros(0)
            Case "TotalizarMZ_TONEL"
                Me.ucVistaDetalleCONTRATO_LG1.SetearAREA_TCXAREA()
        End Select
    End Sub

    Private Sub SetearAREA_TCXAREA()
        Dim MZ As Decimal = 0
        Dim TC As Decimal = 0
        Dim TC_X_AREA As Decimal = 0
        For Each lLotes As LOTES_LG In Me.ucVistaDetalleCONTRATO_LG1.LISTA_LOTES_LG
            MZ += lLotes.AREA
            TC += lLotes.TONELADAS
            TC_X_AREA += (lLotes.AREA * lLotes.TONELADAS)
        Next
        Me.ucVistaDetalleCONTRATO_LG1.AREA_CULTIVADA = MZ
        Me.ucVistaDetalleCONTRATO_LG1.TONEL_X_AREA = TC_X_AREA
    End Sub
End Class
