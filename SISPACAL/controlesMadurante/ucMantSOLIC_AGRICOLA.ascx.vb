Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantSOLIC_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SOLIC_AGRICOLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSOLIC_AGRICOLA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.Label1.Text = "Mantenimiento de Solicitudes Agricolas"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("DialogoGenerarRetiro", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarAplicacion", False)
        Me.ucBarraNavegacion1.VerOpcion("Aceptar", False)
        Me.ucBarraNavegacion1.VerOpcion("GenerarOrdenCompra", False)
        Me.ucBarraNavegacion1.VerOpcion("Validar", False)
        Me.ucBarraNavegacion1.VerOpcion("Aprobar", False)
        Me.ucBarraNavegacion1.VerOpcion("Aplicar", False)
        Me.ucBarraNavegacion1.VerOpcion("Anular", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucCriteriosSolicAgricolaLayout.Visible = True
        Me.ucListaSOLIC_AGRICOLA1.Visible = True
        Me.ucVistaDetalleSOLIC_AGRICOLA1.Visible = False
    End Sub


    Private Sub InicializarDetalleOrdenCompra()
        Me.Label1.Text = "Generación de Orden de Compra"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("DialogoGenerarRetiro", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarAplicacion", False)
        Me.ucBarraNavegacion1.VerOpcion("Aceptar", False)
        Me.ucBarraNavegacion1.VerOpcion("Anular", False)
        Me.ucBarraNavegacion1.VerOpcion("GenerarOrdenCompra", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucCriteriosSolicAgricolaLayout.Visible = False
        Me.ucListaSOLIC_AGRICOLA1.Visible = False
        Me.ucVistaDetalleSOLIC_AGRICOLA1.Visible = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(ByVal estado As Int32)
        Me.Label1.Text = "Modificación de Solicitud Agricola"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("DialogoGenerarRetiro", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", estado = -1 OrElse estado = EstadoSolicAgricola.Pendiente)
        Me.ucBarraNavegacion1.VerOpcion("GuardarAplicacion", (estado = EstadoSolicAgricola.Pendiente OrElse estado = EstadoSolicAgricola.Aceptada))
        Me.ucBarraNavegacion1.VerOpcion("Aceptar", estado = EstadoSolicAgricola.Pendiente)
        Me.ucBarraNavegacion1.VerOpcion("Anular", estado = EstadoSolicAgricola.Pendiente OrElse estado = EstadoSolicAgricola.Aceptada)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucCriteriosSolicAgricolaLayout.Visible = False
        Me.ucListaSOLIC_AGRICOLA1.Visible = False
        Me.ucVistaDetalleSOLIC_AGRICOLA1.Visible = True
    End Sub


    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva Solicitud", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("DialogoGenerarRetiro", "Generar Retiro de Productos Consignados", False, IconoBarra.Reporte, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarAplicacion", "Producto aplicado", True, "~\imagenes\helicoptero2.png", "", "", False)
        Me.ucBarraNavegacion1.CrearOpcion("Aceptar", "Aceptar Solicitud", True, IconoBarra.Aplicar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarOrdenCompra", "Generar Orden de Compra", True, "~\imagenes\generar.png", "", "", False)
        Me.ucBarraNavegacion1.CrearOpcion("Validar", "Validar Solicitud", True, IconoBarra.Validar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Aprobar", "Aprobar Solicitud", True, IconoBarra.Aprobar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Aplicar", "Aplicar datos finales de Vuelo", True, IconoBarra.Aplicar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Anular", "Anular Solicitud", False, IconoBarra.Anular, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarCerrar", "Guardar y cerrar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarSOLIC_AGRICOLA()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarSOLIC_AGRICOLA() As Integer
        If Me.ucListaSOLIC_AGRICOLA1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()

            If Request.QueryString("op") IsNot Nothing Then
                If Request.QueryString("op") = 1 Then
                    'Me.InicializarDetalle()
                    Me.ucVistaDetalleSOLIC_AGRICOLA1.LimpiarControles()
                    Me.ucVistaDetalleSOLIC_AGRICOLA1.ID_SOLICITUD = 0
                End If
            End If
        End If
    End Sub

    Protected Sub ucListaSOLIC_AGRICOLA1_Editando(ByVal ID_SOLICITUD As Int32) Handles ucListaSOLIC_AGRICOLA1.Editando
        Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(ID_SOLICITUD)
        Me.InicializarDetalle(lEntidad.ESTADO)
        Me.ucVistaDetalleSOLIC_AGRICOLA1.ID_SOLICITUD = ID_SOLICITUD
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim NUM_SOLICITUD As Integer = -1
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""
                Dim FECHA_SOLIC As DateTime = Nothing
                Dim FECHA_APLICA As DateTime = Nothing

                If txtNUM_SOLICITUD.Text <> "" Then NUM_SOLICITUD = CInt(txtNUM_SOLICITUD.Value)
                If Me.txtCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.txtCODIPROVEE.Text))
                If Me.txtCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.txtCODISOCIO.Text))
                If Me.dteFECHA_SOLIC.Value IsNot Nothing AndAlso IsDate(Me.dteFECHA_SOLIC.Value) Then FECHA_SOLIC = Me.dteFECHA_SOLIC.Date
                If Me.dteFECHA_APLICA.Value IsNot Nothing AndAlso IsDate(Me.dteFECHA_APLICA.Value) Then FECHA_APLICA = Me.dteFECHA_APLICA.Date

                Me.ucListaSOLIC_AGRICOLA1.CargarDatosPoCriterios(Me.cbxZAFRA.Value, NUM_SOLICITUD, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text, Me.txtNOMBLOTE.Text, FECHA_SOLIC, FECHA_APLICA, cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario))

            Case "Exportar"
                Me.ucListaSOLIC_AGRICOLA1.ExportarExcel()

            Case "Agregar"
                Me.InicializarDetalle(-1)
                Me.ucVistaDetalleSOLIC_AGRICOLA1.LimpiarControles()
                Me.ucVistaDetalleSOLIC_AGRICOLA1.ID_SOLICITUD = 0

            Case "DialogoGenerarRetiro"
                Dim lstSolicitudes As listaSOLIC_AGRICOLA
                lstSolicitudes = ucListaSOLIC_AGRICOLA1.DevolverSeleccionados

                If lstSolicitudes.Count = 0 Then
                    AsignarMensaje("Marque las Solicitudes a incluir en la Solicitud de Retiro de Productos en Consignacion", False, True, True)
                    Return
                End If
                For Each lEntidad As SOLIC_AGRICOLA In lstSolicitudes
                    Dim lSolic As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(lEntidad.ID_SOLICITUD)
                    If lSolic IsNot Nothing AndAlso lSolic.CONDI_COMPRA <> CondicionCompra.Consignacion Then
                        AsignarMensaje("Todas las Solicitudes deben ser de condicion de compra: CONSIGNACION", False, True, True)
                        Return
                    End If
                Next
                Me.rblRetiro.Value = 1
                Me.popupRetiro.ShowOnPageLoad = True

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_AGRICOLA1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La Solicitud Agricola se guardo con exito.", False, True, True)
                Me.ucListaSOLIC_AGRICOLA1.DataBind()
                Me.ucVistaDetalleSOLIC_AGRICOLA1.LimpiarControles()
                Me.ucVistaDetalleSOLIC_AGRICOLA1.ID_SOLICITUD = 0
                Return

            Case "GenerarOrdenCompra"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_AGRICOLA1.GenerarOrdenCompra()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La Orden de Compra se genero con exito.", False, True, True)
                Me.ucListaSOLIC_AGRICOLA1.DataBind()
                Me.InicializarLista()
                Return

            Case "GuardarAplicacion"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_AGRICOLA1.AplicarProducto()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La Aplicacion de Producto Agricola se guardo con exito.", False, True, True)
                Me.ucListaSOLIC_AGRICOLA1.DataBind()
                Me.InicializarLista()
                Return

            Case "Aceptar"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_AGRICOLA1.Aceptar
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La Solicitud de Producto Agricola ha sido aceptada.", False, True, True)
                Me.ucListaSOLIC_AGRICOLA1.DataBind()
                Me.InicializarLista()
                Return

            Case "Anular"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_AGRICOLA1.Anular
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La Solicitud de Producto Agricola ha sido anulada.", False, True, True)
                Me.ucListaSOLIC_AGRICOLA1.DataBind()
                Me.InicializarLista()
                Return

            Case "GuardarCerrar"
                Dim sError As String = ""
                sError = Me.ucVistaDetalleSOLIC_AGRICOLA1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                Dim strscript As String = "<script language=javascript>window.top.close();</script>"
                If Not Page.ClientScript.IsStartupScriptRegistered("clientScript") Then
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "clientScript", strscript)
                End If

            Case "Cancelar"
                AsignarMensaje("", True, False)
                Me.InicializarLista()
        End Select
    End Sub

    Private Sub GenerarRetiro()
        Dim lstSolicitudes As listaSOLIC_AGRICOLA
        Dim sNumeros As New StringBuilder
        Dim bSalBodeEnca As New cSALBODE_ENCA
        Dim IdSalida As Int32 = 0
        Dim EsRetiroProd As Boolean = (Me.rblRetiro.Value = 2)

        lstSolicitudes = ucListaSOLIC_AGRICOLA1.DevolverSeleccionados

        If lstSolicitudes.Count = 0 Then
            AsignarMensaje("Marque las Solicitudes a incluir en la Solicitud de Retiro de Productos en Consignacion", False, True, True)
            Return
        End If

        For i As Int32 = 0 To lstSolicitudes.Count - 1
            sNumeros.Append(lstSolicitudes(i).ID_SOLICITUD.ToString)
            sNumeros.Append(";")
        Next

        If EsRetiroProd Then
            'Validar que las solicitudes sean de un solo productor
            Dim sCodi As String = ""
            For Each lEntidad As SOLIC_AGRICOLA In lstSolicitudes
                Dim lSolic As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(lEntidad.ID_SOLICITUD)
                If sCodi = "" Then sCodi = lSolic.CODIPROVEEDOR
                If sCodi <> lSolic.CODIPROVEEDOR Then
                    AsignarMensaje("No se puede generar la Solicitud para retiro por parte de un productor debido a que las solicitudes seleccionadas son de diferentes productores", False, True, True)
                    Return
                End If
            Next
        End If

        IdSalida = bSalBodeEnca.PROC_Generar_SalBodega(Me.cbxZAFRA.Value, Me.ObtenerUsuario, sNumeros.ToString, EsRetiroProd)
        If IdSalida = -1 Then
            AsignarMensaje(bSalBodeEnca.sError, False, True, True)
            Return
        End If

        'Invocar a la pagina del reporte
        Me.popupRetiro.ShowOnPageLoad = False
        ucListaSOLIC_AGRICOLA1.QuitarSeleccion()
        AsignarMensaje("Solicitud de retiro emitida con exito", False, True, True)
        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarSoliRetiroProductosConsignados(" + IdSalida.ToString + ")", True)
    End Sub

    Protected Sub ucListaSOLIC_AGRICOLA1_GenerandoOrden(ID_SOLICITUD As Integer) Handles ucListaSOLIC_AGRICOLA1.GenerandoOrden
        Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(ID_SOLICITUD)

        If lEntidad.CONDI_COMPRA = CondicionCompra.Consignacion Then
            Me.AsignarMensaje("No se puede generar una Orden de Compra de una Solicitud de Producto en Consignacion. Genere una Solicitud de Retiro para esta Solicitud", False, True, True)
            Return
        End If
        Me.InicializarDetalleOrdenCompra()
        Me.ucVistaDetalleSOLIC_AGRICOLA1.GENERAR_ORDEN_COMPRA = True
        Me.ucVistaDetalleSOLIC_AGRICOLA1.ID_SOLICITUD = ID_SOLICITUD
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.GenerarRetiro()
    End Sub
End Class
