Imports System.Data
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantBASE_PROVEEDORES_MH
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla BASE_PROVEEDORES_MH
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantBASE_PROVEEDORES_MH
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla BASE_PROVEEDORES_MH
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", True)
        Me.ucListaBASE_PROVEEDORES_MH1.Visible = True
        Me.ucVistaDetalleBASE_PROVEEDORES_MH1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla BASE_PROVEEDORES_MH
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", False)
        Me.ucListaBASE_PROVEEDORES_MH1.Visible = False
        Me.ucVistaDetalleBASE_PROVEEDORES_MH1.Visible = True
    End Sub
    Private Sub InicializarDetalleVista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirSalir = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", True)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", False)
        Me.ucListaBASE_PROVEEDORES_MH1.Visible = False
        Me.ucVistaDetalleBASE_PROVEEDORES_MH1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva persona", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarCerrar", "Guardar y cerrar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarExcel", "Exportar personas naturales/juridicas", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla BASE_PROVEEDORES_MH
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarBASE_PROVEEDORES_MH()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarBASE_PROVEEDORES_MH() As Integer
        If Me.ucListaBASE_PROVEEDORES_MH1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()

            If Request.QueryString("op") IsNot Nothing AndAlso Request.QueryString("op") = 1 Then
                Me.InicializarDetalleVista()
                Me.ucVistaDetalleBASE_PROVEEDORES_MH1.LimpiarControles()
                Me.ucVistaDetalleBASE_PROVEEDORES_MH1.ID_BASE_PROVEE = 0
            End If
        End If
    End Sub



    Protected Sub ucListaBASE_PROVEEDORES_MH1_Editando(ByVal ID_BASE_PROVEE As Int32) Handles ucListaBASE_PROVEEDORES_MH1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleBASE_PROVEEDORES_MH1.ID_BASE_PROVEE = ID_BASE_PROVEE
    End Sub
    Private Sub ExportToExcel(ByVal dt As DataTable, ByVal nombreArchivo As String)
        'If dt IsNot Nothing Then
        '    dxgvLista.DataSource = dt
        '    dxgvLista.DataBind()
        '    gridExport.WriteXlsxToResponse(nombreArchivo, True, New DevExpress.XtraPrinting.XlsxExportOptionsEx With {.ExportType = DevExpress.Export.ExportType.DataAware})
        'End If
    End Sub

    Private Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Me.AsignarMensaje("", True, False)
        Select Case CommandName
            Case "Buscar"
                Me.CargarBASE_PROVEEDORES_MH()

            Case "Guardar"
                Dim sError As String

                sError = Me.ucVistaDetalleBASE_PROVEEDORES_MH1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaBASE_PROVEEDORES_MH1.DataBind()

            Case "GenerarExcel"
                Me.ucListaBASE_PROVEEDORES_MH1.ExportarExcel()

            Case "GuardarCerrar"
                Dim sError As String = ""
                sError = Me.ucVistaDetalleBASE_PROVEEDORES_MH1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                Dim strscript As String = "<script language=javascript>window.top.close();</script>"
                If Not Page.ClientScript.IsStartupScriptRegistered("clientScript") Then
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "clientScript", strscript)
                End If

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleBASE_PROVEEDORES_MH1.LimpiarControles()
                Me.ucVistaDetalleBASE_PROVEEDORES_MH1.ID_BASE_PROVEE = 0

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub
End Class
