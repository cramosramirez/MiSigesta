Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPLANILLA_BASE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PLANILLA_BASE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPLANILLA_BASE
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"

    Public Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        'Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo Contrato", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()

        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafraActiva.ID_ZAFRA
            Me.CargarDatos()
        End If
    End Sub
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PLANILLA_BASE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        'Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)

        Me.trZAFRA.Visible = True
        Me.ucListaPLANILLA_BASE1.Visible = True
        Me.ucVistaDetallePLANILLA_BASE1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PLANILLA_BASE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        'Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.trZAFRA.Visible = False
        Me.ucListaPLANILLA_BASE1.Visible = False
        Me.ucVistaDetallePLANILLA_BASE1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLANILLA_BASE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Dim lIdZafra As Int32 = -1
            If Me.cbxZAFRA.Value IsNot Nothing Then lIdZafra = cbxZAFRA.Value
            Return Me.ucListaPLANILLA_BASE1.CargarDatosPorZAFRA(lIdZafra)
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaPLANILLA_BASE1_Editando(ByVal ID_PLANILLA_BASE As Int32) Handles ucListaPLANILLA_BASE1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetallePLANILLA_BASE1.ID_PLANILLA_BASE = ID_PLANILLA_BASE
    End Sub

    Private Sub ucVistaDetallePLANILLA_BASE1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetallePLANILLA_BASE1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                If Me.cbxZAFRA.Value Is Nothing Then
                    Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                    Return
                End If
                If Me.cbxTIPO_PLANILLA.Value Is Nothing Then
                    Me.AsignarMensaje("Seleccione un tipo de planilla", False, True, True)
                    Return
                End If
                Me.ucListaPLANILLA_BASE1.CargarDatosPorZAFRA_TIPO_PLANILLA(Me.cbxZAFRA.Value, Me.cbxTIPO_PLANILLA.Value)

            Case "Agregar"
               

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetallePLANILLA_BASE1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaPLANILLA_BASE1.DataBind()


            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub
End Class
