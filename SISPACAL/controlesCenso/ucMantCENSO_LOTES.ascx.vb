Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCENSO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla CENSO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCENSO_LOTES
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CENSO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        'Me.ucBarraNavegacion1.Navegacion = False
        'Me.ucBarraNavegacion1.PermitirAgregar = True
        'Me.ucBarraNavegacion1.PermitirEditar = False
        'Me.ucBarraNavegacion1.PermitirGuardar = False
        'Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaCENSO_LOTES1.Visible = True
        'Me.UcVistaDetalleCENSO_LOTES1.Visible = False
        'If Me.CargarDatos() <> 1 Then
        '    Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        'End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CENSO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaCENSO_LOTES1.Visible = False
        'Me.UcVistaDetalleCENSO_LOTES1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CENSO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarCENSO_LOTES()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarCENSO_LOTES() As Integer
        If Me.ucListaCENSO_LOTES1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", True, IconoBarra.Buscar, "onclick", "e.processOnServer=false;CargarMapa();", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    'Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
    '    Me.InicializarDetalle()
    '    Me.ucVistaDetalleCENSO_LOTES1.LimpiarControles()
    '    Me.ucVistaDetalleCENSO_LOTES1.ID_CENSO_LOTES = 0
    'End Sub

    'Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
    '    Me.InicializarLista()
    'End Sub

    'Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
    '    Dim sError As String
    '    sError = Me.ucVistaDetalleCENSO_LOTES1.Actualizar()
    '    If sError <> "" Then
    '        Return
    '    End If
    '    Me.InicializarLista()
    'End Sub

    Protected Sub ucListaCENSO_LOTES1_Editando(ByVal ID_CENSO_LOTES As Int32) Handles ucListaCENSO_LOTES1.Editando
        Me.InicializarDetalle()
        'Me.ucVistaDetalleCENSO_LOTES1.ID_CENSO_LOTES = ID_CENSO_LOTES
    End Sub

    'Private Sub ucVistaDetalleCENSO_LOTES1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleCENSO_LOTES1.ErrorEvent
    '    'Mostrar mensaje de error contenido en errorMessage
    '    Me.AsignarMensaje(errorMessage, True, True)
    'End Sub

    Public Sub CargarCensos(ByVal ID_ZAFRA As Integer)
        Me.odsCenso.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsCenso.SelectParameters("recuperarHijas").DefaultValue = False
        Me.odsCenso.SelectParameters("recuperarForaneas").DefaultValue = False
        Me.odsCenso.SelectParameters("asColumnaOrden").DefaultValue = "FECHA_CENSO"
        Me.odsCenso.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.cbxCENSO.DataBind()
        If Me.cbxCENSO.Items.Count > 0 Then
            Me.cbxCENSO.Value = Me.cbxCENSO.Items(0)
        End If
    End Sub

    Protected Sub cpMantCENSO_LOTES_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMantCENSO_LOTES.Callback
        Dim parametros As String() = e.Parameter.Split(";")
        Select Case parametros(0)
            Case "CargarLotes"
                Me.ucListaCENSO_LOTES1.CargarDatosPorZAFRA_ZONA_CENSO(Me.cbxZAFRA.Value, Me.cbxZONA.Value, Me.cbxCENSO.Value)
        End Select
    End Sub

    Protected Sub cbxCENSO_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cbxCENSO.Callback
        Me.CargarCensos(e.Parameter)
    End Sub

    Protected Sub cbxCENSO_DataBound(sender As Object, e As System.EventArgs) Handles cbxCENSO.DataBound
        Dim censos As ASPxComboBox = CType(sender, ASPxComboBox)
        If censos IsNot Nothing Then
            For Each item As ListEditItem In censos.Items
                If IsDate(item.Text) Then item.Text = Format(CDate(item.Text), "dd/MM/yyyy")
            Next
        End If
    End Sub
End Class
