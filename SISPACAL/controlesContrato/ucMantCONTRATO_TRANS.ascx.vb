Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCONTRATO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla CONTRATO_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCONTRATO_TRANS
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CONTRATO_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("CrearTransportista", False)
        Me.ucBarraNavegacion1.VerOpcion("EditarTransportista", False)
        Me.ucBarraNavegacion1.VerOpcion("Actualizar", False)

        Me.ucListaCONTRATO_TRANS1.Visible = True
        'Me.ucVistaDetalleCONTRATO_TRANS1.LimpiarSesion()
        Me.ucVistaDetalleCONTRATO_TRANS1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CONTRATO_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("CrearTransportista", True)
        Me.ucBarraNavegacion1.VerOpcion("EditarTransportista", True)
        Me.ucBarraNavegacion1.VerOpcion("Actualizar", True)

        Me.ucListaCONTRATO_TRANS1.Visible = False
        Me.ucVistaDetalleCONTRATO_TRANS1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo Contrato", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("CrearTransportista", "Nuevo Transportista", False, IconoBarra.Proveedor, "onclick", "e.processOnServer=false;CrearTransportista()", True)
        Me.ucBarraNavegacion1.CrearOpcion("EditarTransportista", "Editar Transportista", False, IconoBarra.Editar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Actualizar", "Actualizar", False, IconoBarra.Actualizar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarCONTRATO_TRANS()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarCONTRATO_TRANS() As Integer
        If Me.ucListaCONTRATO_TRANS1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaCONTRATO_TRANS1_Editando(ByVal ID_CONTRA_TRANS As Int32) Handles ucListaCONTRATO_TRANS1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleCONTRATO_TRANS1.ID_CONTRA_TRANS = ID_CONTRA_TRANS
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
                Me.ucVistaDetalleCONTRATO_TRANS1.LimpiarControles()
                Me.ucVistaDetalleCONTRATO_TRANS1.ID_CONTRA_TRANS = 0

            Case "Exportar"
                Me.ucListaCONTRATO_TRANS1.ExportarExcel()

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleCONTRATO_TRANS1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaCONTRATO_TRANS1.DataBind()

            Case "Cancelar"
                Me.InicializarLista()

            Case "EditarTransportista"
                If ucVistaDetalleCONTRATO_TRANS1.CODTRANSPORT > 0 Then
                    ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "EditarTransportista(" + ucVistaDetalleCONTRATO_TRANS1.CODTRANSPORT.ToString + ")", True)
                Else
                    AsignarMensaje("* Ingrese el Codigo de transportista", False, True, True)
                End If

            Case "Actualizar"
                Me.ucVistaDetalleCONTRATO_TRANS1.CargarInfoTransportista(Me.ucVistaDetalleCONTRATO_TRANS1.CODTRANSPORT)
        End Select
    End Sub
End Class
