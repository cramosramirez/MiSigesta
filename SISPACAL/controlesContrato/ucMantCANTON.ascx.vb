Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCANTON
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla CANTON
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/07/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCANTON
    Inherits ucBase

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Inicializar()
        End If
    End Sub


    'Protected Sub ucListaCANTON1_Editando(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String) Handles ucListaCANTON1.Editando
    '    Me.InicializarDetalle()
    '    Me.UcVistaDetalleCANTON1.CODI_CANTON = CODI_CANTON
    '    Me.UcVistaDetalleCANTON1.CODI_DEPTO = CODI_DEPTO
    '    Me.UcVistaDetalleCANTON1.CODI_MUNI = CODI_MUNI
    'End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar" Then
            Me.ucListaCANTON1.CargarDatosPorCriterios(Me.ucCriteriosCanton1.CODI_DETO, Me.ucCriteriosCanton1.CODI_MUNI, Me.ucCriteriosCanton1.CODI_CANTON)
        End If
    End Sub
End Class
