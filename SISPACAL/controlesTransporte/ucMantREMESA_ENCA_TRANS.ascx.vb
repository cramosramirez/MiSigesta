Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantREMESA_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla REMESA_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantREMESA_ENCA_TRANS
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla REMESA_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.lblTitulo.Text = "Remesa Bancaria"
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucListaREMESA_ENCA_TRANS1.Visible = True
        Me.ucVistaDetalleREMESA_ENCA_TRANS1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla REMESA_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(Optional editarEmision As Boolean = False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", Not editarEmision)
        Me.ucListaREMESA_ENCA_TRANS1.Visible = False
        Me.ucVistaDetalleREMESA_ENCA_trans1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Nueva Remesa", False, IconoBarra.Agregar, "", "", True)
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla REMESA_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarREMESA_ENCA_TRANS()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarREMESA_ENCA_TRANS() As Integer
        If Me.ucListaREMESA_ENCA_TRANS1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaREMESA_ENCA_TRANS1_Editando(ByVal ID_REMESA_ENCA As Int32) Handles ucListaREMESA_ENCA_TRANS1.Editando
        Me.InicializarDetalle(True)
        Me.UcVistaDetalleREMESA_ENCA_TRANS1.ID_REMESA_ENCA = ID_REMESA_ENCA
    End Sub

    Private Sub ucVistaDetalleREMESA_ENCA_TRANS1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleREMESA_ENCA_TRANS1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName

            Case "Agregar"
                Me.ucVistaDetalleREMESA_ENCA_TRANS1.LimpiarControles()
                Me.ucVistaDetalleREMESA_ENCA_TRANS1.ID_REMESA_ENCA = 0
                Me.InicializarDetalle()

            Case "Exportar"
                Me.ucListaREMESA_ENCA_TRANS1.ExportarExcel()

            Case "Guardar"
                Dim lRet As String

                lRet = Me.ucVistaDetalleREMESA_ENCA_TRANS1.Actualizar
                If lRet <> "" Then
                    Me.AsignarMensaje(lRet, True, False)
                    Exit Sub
                End If
                Me.ucVistaDetalleREMESA_ENCA_TRANS1.LimpiarControles()
                Me.ucVistaDetalleREMESA_ENCA_TRANS1.ID_REMESA_ENCA = 0
                Me.InicializarLista()
                Me.ucListaREMESA_ENCA_TRANS1.DataBind()
                Me.AsignarMensaje("Se ha registrado la Remesa", False, True, True)

                Me.AsignarMensaje("", True, False)

            Case "Cancelar"
                Me.AsignarMensaje("", True, False)
                Me.ucVistaDetalleREMESA_ENCA_TRANS1.LimpiarControles()
                Me.ucVistaDetalleREMESA_ENCA_TRANS1.ID_REMESA_ENCA = 0
                Me.InicializarLista()
                Me.ucListaREMESA_ENCA_TRANS1.DataBind()
        End Select
    End Sub

    Protected Sub cpMantREMESA_ENCA_TRANS_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMantREMESA_ENCA_TRANS.Callback
        Me.ucVistaDetalleREMESA_ENCA_TRANS1.SetearSubTotalIvaTotal()
    End Sub
End Class
