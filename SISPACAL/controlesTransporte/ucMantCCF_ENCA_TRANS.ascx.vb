Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCCF_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla CCF_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	27/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCCF_ENCA_TRANS
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CCF_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	27/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------   
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.lblTitulo.Text = "Facturación de Insumos para transporte"
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucListaCCF_ENCA_TRANS1.Visible = True
        Me.ucVistaDetalleCCF_ENCA_TRANS1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CCF_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	27/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(Optional editarEmision As Boolean = False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", Not editarEmision)
        Me.ucListaCCF_ENCA_TRANS1.Visible = False
        Me.ucVistaDetalleCCF_ENCA_TRANS1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Nuevo CCF/Factura", False, IconoBarra.Agregar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.CargarDatos()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	27/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarCCF_ENCA_TRANS()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarCCF_ENCA_TRANS() As Integer
        If Me.ucListaCCF_ENCA_TRANS1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub
    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.ucVistaDetalleCCF_ENCA_TRANS1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaCCF_ENCA_TRANS1_Editando(ByVal ID_CCF_TRANS As Int32) Handles ucListaCCF_ENCA_TRANS1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleCCF_ENCA_TRANS1.ID_CCF_TRANS = ID_CCF_TRANS
    End Sub

    Private Sub ucVistaDetalleCCF_ENCA_TRANS1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleCCF_ENCA_TRANS1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName

            Case "Agregar"
                Me.ucVistaDetalleCCF_ENCA_TRANS1.LimpiarControles()
                Me.ucVistaDetalleCCF_ENCA_TRANS1.LimpiarSesion()
                Me.ucVistaDetalleCCF_ENCA_TRANS1.ID_CCF_TRANS = 0
                Me.InicializarDetalle()

            Case "Exportar"
                Me.ucListaCCF_ENCA_TRANS1.ExportarExcel()

            Case "Guardar"
                Dim lRet As String

                lRet = Me.ucVistaDetalleCCF_ENCA_TRANS1.Actualizar
                If lRet <> "" Then
                    Me.AsignarMensaje(lRet, True, False)
                    Exit Sub
                End If
                Me.ucVistaDetalleCCF_ENCA_TRANS1.LimpiarControles()
                Me.ucVistaDetalleCCF_ENCA_TRANS1.LimpiarSesion()
                Me.ucVistaDetalleCCF_ENCA_TRANS1.ID_CCF_TRANS = 0
                Me.InicializarLista()
                Me.ucListaCCF_ENCA_TRANS1.DataBind()
                Me.AsignarMensaje("Se ha registrado la Facturacion", False, True, True)

                Me.AsignarMensaje("", True, False)

            Case "Cancelar"
                Me.AsignarMensaje("", True, False)
                Me.ucVistaDetalleCCF_ENCA_TRANS1.LimpiarControles()
                Me.ucVistaDetalleCCF_ENCA_TRANS1.LimpiarSesion()
                Me.ucVistaDetalleCCF_ENCA_TRANS1.ID_CCF_TRANS = 0
                Me.InicializarLista()
                Me.ucListaCCF_ENCA_TRANS1.DataBind()
        End Select
    End Sub

    Protected Sub cpMantCCF_ENCA_TRANS_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMantCCF_ENCA_TRANS.Callback
        Me.ucVistaDetalleCCF_ENCA_TRANS1.SetearSubTotalIvaTotal()
    End Sub
End Class
