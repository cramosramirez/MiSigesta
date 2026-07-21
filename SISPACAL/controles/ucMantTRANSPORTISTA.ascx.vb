Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantTRANSPORTISTA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla TRANSPORTISTA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantTRANSPORTISTA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla TRANSPORTISTA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.lblTitulo.Text = "Mantenimiento de Transportistas"
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucVistaDetalleTRANSPORTISTA1.Visible = False
        Me.ucListaTRANSPORTISTA1.Visible = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla TRANSPORTISTA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2014	Created
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
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucListaTRANSPORTISTA1.Visible = False
        Me.ucVistaDetalleTRANSPORTISTA1.Visible = True
    End Sub

    Private Sub InicializarDetalleVista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirSalir = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucListaTRANSPORTISTA1.Visible = False
        Me.ucVistaDetalleTRANSPORTISTA1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla TRANSPORTISTA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarTRANSPORTISTA()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarTRANSPORTISTA() As Integer
        Dim idZafra As Integer = -1
        If Me.cbxZAFRA.Value IsNot Nothing Then idZafra = Convert.ToInt32(Me.cbxZAFRA.Value)
        If Me.ucListaTRANSPORTISTA1.CargarDatosPorZafraContratada(idZafra) <> 1 Then Return -1
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
                    Me.ucVistaDetalleTRANSPORTISTA1.LimpiarControles()
                    Me.ucVistaDetalleTRANSPORTISTA1.CODTRANSPORT = 0
                End If
                If Request.QueryString("op") = 2 Then
                    Me.InicializarDetalleVista()
                    Me.ucVistaDetalleTRANSPORTISTA1.LimpiarControles()
                    Me.ucVistaDetalleTRANSPORTISTA1.CODTRANSPORT = CInt(Request.QueryString("id"))
                End If
            End If
        End If
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo transportista", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarCerrar", "Guardar y cerrar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.InicializarLista()

        'Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        'If lZafra IsNot Nothing Then
        '    Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        'End If
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.ucVistaDetalleTRANSPORTISTA1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaTRANSPORTISTA1_Editando(ByVal CODTRANSPORT As Int32) Handles ucListaTRANSPORTISTA1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleTRANSPORTISTA1.CODTRANSPORT = CODTRANSPORT
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.CargarTRANSPORTISTA()

            Case "Guardar"
                Dim sError As String
                AsignarMensaje("", True, False)
                sError = Me.ucVistaDetalleTRANSPORTISTA1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                Me.ucVistaDetalleTRANSPORTISTA1.CODTRANSPORT = 0
                'Me.InicializarLista()
                Me.ucListaTRANSPORTISTA1.DataBind()
                AsignarMensaje("Datos del Transportista se han guardado", False, True, True)

            Case "GuardarCerrar"
                Dim sError As String
                AsignarMensaje("", True, False)
                sError = Me.ucVistaDetalleTRANSPORTISTA1.Actualizar()
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
                Me.ucVistaDetalleTRANSPORTISTA1.LimpiarControles()
                Me.ucVistaDetalleTRANSPORTISTA1.CODTRANSPORT = 0

            Case "Cancelar"
                Me.InicializarLista()

            Case "Exportar"
                Me.ucListaTRANSPORTISTA1.ExportarExcel()
        End Select
    End Sub
End Class
