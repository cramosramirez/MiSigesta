Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCATORCENA_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla CATORCENA_ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCATORCENA_ZAFRA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaCATORCENA_ZAFRA1.Visible = True
        Me.ucVistaDetalleCATORCENA_ZAFRA1.Visible = False
        Me.trZAFRA.Visible = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaCATORCENA_ZAFRA1.Visible = False
        Me.ucVistaDetalleCATORCENA_ZAFRA1.Visible = True
        Me.trZAFRA.Visible = False
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Dim lIdZafra As Int32 = -1
            If Me.cbxZAFRA.Value IsNot Nothing Then lIdZafra = cbxZAFRA.Value
            Return Me.ucListaCATORCENA_ZAFRA1.CargarDatosPorZAFRA(lIdZafra)
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina        
        If Not IsPostBack Then
            Me.InicializarLista()

            Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
            If lZafraActiva IsNot Nothing Then
                Me.cbxZAFRA.Value = lZafraActiva.ID_ZAFRA
                Me.CargarDatos()
            End If
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetalleCATORCENA_ZAFRA1.LimpiarControles()
        Me.ucVistaDetalleCATORCENA_ZAFRA1.ID_CATORCENA = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleCATORCENA_ZAFRA1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.AsignarMensaje("El cierre de catorcena se ha efectuado con exito", False, True, True)
    End Sub

    Protected Sub ucListaCATORCENA_ZAFRA1_Editando(ByVal ID_CATORCENA As Int32) Handles ucListaCATORCENA_ZAFRA1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleCATORCENA_ZAFRA1.ID_CATORCENA = ID_CATORCENA
    End Sub

    Private Sub ucVistaDetalleCATORCENA_ZAFRA1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleCATORCENA_ZAFRA1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarDatos()
    End Sub
End Class
