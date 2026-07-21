Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPROYFIN_ING
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PROYFIN_ING
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPROYFIN_ING
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PROYFIN_ING
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Produccion", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
      
        Me.ucListaPROYFIN_ING1.Visible = True
        Me.ucVistaDetallePROYFIN_ING1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PROYFIN_ING
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Produccion", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)

        Me.ucListaPROYFIN_ING1.Visible = False
        Me.ucVistaDetallePROYFIN_ING1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Nuevo", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Produccion", "Mostrar producción de lotes seleccionados", False, IconoBarra.Emitir, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROYFIN_ING
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarPROYFIN_ING()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarPROYFIN_ING() As Integer
        Dim bProyFin As New cPROYFIN_ING

        bProyFin.PROC_Eliminar_ProyFinan_Lote(Me.ObtenerUsuario)
        If Me.ucListaPROYFIN_ING1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaPROYFIN_ING1_Editando(ByVal ID_PROYFIN_ING As Int32) Handles ucListaPROYFIN_ING1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetallePROYFIN_ING1.ID_PROYFIN_ING = ID_PROYFIN_ING
    End Sub

    Private Sub ucVistaDetallePROYFIN_ING1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetallePROYFIN_ING1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            'Case "Buscar"
            '    Dim noContrato As Integer = -1
            '    Dim CODIPROVEE As String = ""
            '    Dim CODISOCIO As String = ""
            '    If Me.txtCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.txtCODIPROVEE.Text))
            '    If Me.txtCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.txtCODISOCIO.Text))

            '    If Me.txtNO_CONTRATO.Text <> "" Then
            '        noContrato = Me.txtNO_CONTRATO.Value
            '    End If
            '    Me.ucListaCONTRATO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, noContrato, CODIPROVEE, CODISOCIO)

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetallePROYFIN_ING1.LimpiarControles()
                Me.ucVistaDetallePROYFIN_ING1.ID_PROYFIN_ING = 0

            Case "Produccion"
                Me.ucVistaDetallePROYFIN_ING1.CargarProduccionDeLotes()

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetallePROYFIN_ING1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, False, True)
                    Return
                End If
                Me.InicializarLista()
                Me.ucListaPROYFIN_ING1.DataBind()

            Case "Cancelar"
                Me.InicializarLista()

        End Select
    End Sub
End Class
