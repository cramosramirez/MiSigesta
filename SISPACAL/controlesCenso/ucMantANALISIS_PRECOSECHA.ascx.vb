Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantANALISIS_PRECOSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ANALISIS_PRECOSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantANALISIS_PRECOSECHA
    Inherits ucBase


#Region "CargaDatos"

    Private Sub CargarSubZonas()
        Me.odsSubZona.SelectParameters("ZONA").DefaultValue = cbxZONA.Value
        Me.odsSubZona.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsSubZona.SelectParameters("agregarTodos").DefaultValue = False
        Me.cbxSUB_ZONA.DataBind()
    End Sub
#End Region

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ANALISIS_PRECOSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucCriteriosAnalisisPrecosechaLayout.Visible = True
        Me.ucListaANALISIS_PRECOSECHA1.Visible = True
        Me.ucVistaDetalleANALISIS_PRECOSECHA1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ANALISIS_PRECOSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucCriteriosAnalisisPrecosechaLayout.Visible = False
        Me.ucListaANALISIS_PRECOSECHA1.Visible = False
        Me.ucVistaDetalleANALISIS_PRECOSECHA1.Visible = True
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva Orden", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ANALISIS_PRECOSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarANALISIS_PRECOSECHA()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarANALISIS_PRECOSECHA() As Integer
        If Me.ucListaANALISIS_PRECOSECHA1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaANALISIS_PRECOSECHA1_Editando(ByVal ID_ANALISIS_PRE As Int32) Handles ucListaANALISIS_PRECOSECHA1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleANALISIS_PRECOSECHA1.ID_ANALISIS_PRE = ID_ANALISIS_PRE
    End Sub

    Private Sub ucVistaDetalleANALISIS_PRECOSECHA1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleANALISIS_PRECOSECHA1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim noContrato As Integer = -1
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""

                If Me.speCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.speCODIPROVEE.Text))
                If Me.speCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.speCODISOCIO.Text))

                Me.ucListaANALISIS_PRECOSECHA1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, Me.cbxZONA.Value, Me.cbxSUB_ZONA.Value, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text, noContrato, cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario))

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleANALISIS_PRECOSECHA1.LimpiarControles()
                Me.ucVistaDetalleANALISIS_PRECOSECHA1.ID_ANALISIS_PRE = 0

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleANALISIS_PRECOSECHA1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)

                'Mostrar Reporte de Orden de Analisis


                Me.InicializarLista()
                Me.ucListaANALISIS_PRECOSECHA1.DataBind()

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub

    Protected Sub cbxZONA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZONA.ValueChanged
        CargarSubZonas()
    End Sub
End Class
