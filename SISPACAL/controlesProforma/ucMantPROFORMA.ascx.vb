Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPROFORMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PROFORMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPROFORMA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PROFORMA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Anular", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucCriteriosRegistroProforma.Visible = True
        Me.ucListaPROFORMA1.Visible = True
        Me.ucEnvioProforma1.Visible = False
        Me.CargarDatos()
    End Sub

    Private _tipo_operacion As TipoOperacion
    Public Property TIPO_OPERACION As TipoOperacion
        Get
            Return _tipo_operacion
        End Get
        Set(ByVal value As TipoOperacion)
            _tipo_operacion = value
        End Set
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PROFORMA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Anular", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucListaPROFORMA1.Visible = False
        Me.ucEnvioProforma1.Visible = True
        Me.ucCriteriosRegistroProforma.Visible = False
    End Sub

    Public Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Select Case TIPO_OPERACION
            Case TipoOperacion.AnulacionProforma
                lblTitulo.Text = "Anulación de Proforma de Envío"
                Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("Anular", "Anular Proforma", False, IconoBarra.Anular, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
                Me.ucBarraNavegacion1.VerOpcion("Anular", True)
                Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
            Case TipoOperacion.ConsultaProforma
                lblTitulo.Text = "Consulta de Proforma de Envío"
                Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
                Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        End Select
        If lZafra IsNot Nothing Then Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        Me.ucEnvioProforma1.TIPO_OPERACION = TIPO_OPERACION
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.InicializarLista()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarPROFORMA()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarPROFORMA() As Integer
        If Me.ucListaPROFORMA1.CargarDatosPorZAFRA(Me.cbxZAFRA.Value) <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucListaPROFORMA1_Editando(ByVal ID_PROFORMA As Int32) Handles ucListaPROFORMA1.Editando
        Me.InicializarDetalle()
        Me.ucEnvioProforma1.ID_PROFORMA = ID_PROFORMA
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.CargarDatos()

            Case "Anular"
                Dim sError As String = ""

                sError = Me.ucEnvioProforma1.AnularProforma()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                Else
                    Me.ucListaPROFORMA1.DataBind()
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()

            Case "Cancelar"
                AsignarMensaje("", True, False)
                Me.InicializarLista()
        End Select
    End Sub
End Class
