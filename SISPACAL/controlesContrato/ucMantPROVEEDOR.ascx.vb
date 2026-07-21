Imports System.Data
Imports System.IO
Imports DevExpress.Web
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPROVEEDOR
    Inherits ucBase


    Public Property MostrarProveedoresConContrato As Boolean
        Get
            If Me.ViewState("MostrarProveedoresConContrato") Is Nothing Then
                Return False
            End If
            Return CBool(Me.ViewState("MostrarProveedoresConContrato"))
        End Get
        Set(value As Boolean)
            Me.ViewState("MostrarProveedoresConContrato") = value
        End Set
    End Property
#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        If Me.MostrarProveedoresConContrato Then
            Me.lblTitulo.Text = "Mantenimiento de Productores con contrato"
        Else
            Me.lblTitulo.Text = "Mantenimiento de Productores y Socios"
        End If
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Socio", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", True)
        Me.ucCriteriosProveedor1.Visible = True
        Me.ucListaPROVEEDOR1.Visible = True
        Me.ucVistaDetallePROVEEDOR1.Visible = False
        Me.ucVistaDetalleSOCIO1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Socio", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", False)
        Me.ucCriteriosProveedor1.Visible = False
        Me.ucListaPROVEEDOR1.Visible = False
        Me.ucVistaDetallePROVEEDOR1.Visible = True
    End Sub

    Private Sub InicializarDetalleSocio()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Socio", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", False)
        Me.ucCriteriosProveedor1.Visible = False
        Me.ucListaPROVEEDOR1.Visible = False
        Me.ucVistaDetalleSOCIO1.Visible = True
    End Sub

    Private Sub InicializarDetalleVistaSocio()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirSalir = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Socio", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", True)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", False)
        Me.ucCriteriosProveedor1.Visible = False
        Me.ucListaPROVEEDOR1.Visible = False
        Me.ucVistaDetalleSOCIO1.Visible = True
    End Sub

    Private Sub InicializarDetalleVista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirSalir = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Socio", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", True)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", False)
        Me.ucCriteriosProveedor1.Visible = False
        Me.ucListaPROVEEDOR1.Visible = False
        Me.ucVistaDetallePROVEEDOR1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo proveedor", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Socio", "Ingresar nuevo socio", False, IconoBarra.Socio, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarCerrar", "Guardar y cerrar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarExcel", "Exportar productores", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarPROVEEDOR()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarPROVEEDOR() As Integer
        If Me.ucListaPROVEEDOR1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()

            If Request.QueryString("op") IsNot Nothing Then
                If Request.QueryString("op") = 1 Then
                    Me.InicializarDetalleVista()
                    Me.ucVistaDetallePROVEEDOR1.LimpiarControles()
                    Me.ucVistaDetallePROVEEDOR1.CODIPROVEEDOR = ""
                End If
                If Request.QueryString("op") = 2 Then
                    Me.InicializarDetalleVistaSocio()
                    Me.ucVistaDetalleSOCIO1.LimpiarControles()
                    Me.ucVistaDetalleSOCIO1.CODIPROVEEDOR = ""
                End If
            End If
        End If
    End Sub

    Protected Sub ucListaPROVEEDOR1_Editando(ByVal CODIPROVEEDOR As String) Handles ucListaPROVEEDOR1.Editando
        Dim lEntidad As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)
        If lEntidad IsNot Nothing Then
            If lEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
                Me.InicializarDetalle()
                Me.ucVistaDetallePROVEEDOR1.CODIPROVEEDOR = CODIPROVEEDOR
            Else
                Me.InicializarDetalleSocio()
                Me.ucVistaDetalleSOCIO1.CODIPROVEEDOR = CODIPROVEEDOR
            End If
        End If
    End Sub

    Private Sub ucVistaDetallePROVEEDOR1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetallePROVEEDOR1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Me.AsignarMensaje("", True, False)
        Select Case CommandName
            Case "Buscar"
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""
                If Me.ucCriteriosProveedor1.CODIPROVEE.Trim <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.ucCriteriosProveedor1.CODIPROVEE))
                If Me.ucCriteriosProveedor1.CODISOCIO.Trim <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.ucCriteriosProveedor1.CODISOCIO))
                Me.ucListaPROVEEDOR1.CargarDatosPorCriteriosPostback(CODIPROVEE,
                                                                 CODISOCIO,
                                                                 Me.ucCriteriosProveedor1.APELLIDOS,
                                                                 Me.ucCriteriosProveedor1.NOMBRES,
                                                                 Me.ucCriteriosProveedor1.DUI,
                                                                 Me.ucCriteriosProveedor1.NIT,
                                                                 Me.ucCriteriosProveedor1.NRC,
                                                                 Me.ucCriteriosProveedor1.ZAFRA,
                                                                 Me.MostrarProveedoresConContrato)


            Case "Guardar"
                Dim sError As String
                If Me.ucVistaDetallePROVEEDOR1.Visible Then
                    sError = Me.ucVistaDetallePROVEEDOR1.Actualizar()
                    If sError <> "" Then
                        AsignarMensaje(sError, True, False)
                        Return
                    End If
                ElseIf Me.ucVistaDetalleSOCIO1.Visible Then
                    sError = Me.ucVistaDetalleSOCIO1.Actualizar()
                    If sError <> "" Then
                        AsignarMensaje(sError, True, False)
                        Return
                    End If
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaPROVEEDOR1.DataBind()

            Case "GenerarExcel"
                If Me.ucCriteriosProveedor1.ZAFRA = -1 Then
                    AsignarMensaje("Seleccione una zafra", False, True, False)
                    Return
                End If
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ucCriteriosProveedor1.ZAFRA)
                Dim strNombreArchivo As String = ""
                Dim strZafra As String = ""

                If lZafra IsNot Nothing Then
                    strZafra = "ZAFRA " + lZafra.NOMBRE_ZAFRA
                End If
                If Me.MostrarProveedoresConContrato Then strNombreArchivo = "Productores con contrato " Else strNombreArchivo = "Productores y socios "

                Dim dt As DataTable = (New cPROVEEDOR).ReporteExcelConsultaProductoresPorZafra(Me.ucCriteriosProveedor1.ZAFRA, Me.MostrarProveedoresConContrato)
                Me.ExportToExcel(dt, Trim(strNombreArchivo & strZafra) & " " & Now.ToString("dd/MM/yyyy hh.mm.ss") & ".xls")

            Case "GuardarCerrar"
                Dim sError As String = ""
                If Me.ucVistaDetallePROVEEDOR1.Visible Then
                    sError = Me.ucVistaDetallePROVEEDOR1.Actualizar()
                ElseIf Me.ucVistaDetalleSOCIO1.Visible Then
                    sError = Me.ucVistaDetalleSOCIO1.Actualizar()
                End If
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
                Me.ucVistaDetallePROVEEDOR1.LimpiarControles()
                Me.ucVistaDetallePROVEEDOR1.CODIPROVEEDOR = ""

            Case "Socio"
                Me.InicializarDetalleSocio()
                Me.ucVistaDetalleSOCIO1.LimpiarControles()
                Me.ucVistaDetalleSOCIO1.CODIPROVEEDOR = ""

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub

    Private Sub ExportToExcel(ByVal dt As DataTable, ByVal nombreArchivo As String)
        If dt IsNot Nothing Then
            dxgvLista.DataSource = dt
            dxgvLista.DataBind()
            gridExport.WriteXlsxToResponse(nombreArchivo, True, New DevExpress.XtraPrinting.XlsxExportOptionsEx With {.ExportType = DevExpress.Export.ExportType.DataAware})
        End If

    End Sub
End Class
