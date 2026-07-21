Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPLAN_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PLAN_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPLAN_COSECHA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"

    Private Sub CargarSubZonas()
        Me.odsSubZona.SelectParameters("ZONA").DefaultValue = cbxZONA.Value
        Me.odsSubZona.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsSubZona.SelectParameters("agregarTodos").DefaultValue = False
        Me.cbxSUB_ZONA.DataBind()
    End Sub

    Private Sub CargarCatorcenas()
        Dim noCatorcenaPropuesta As Int32 = (New cPLAN_COSECHA).ObtenerUltimaCatorcenaPropuesta(Me.cbxZAFRA.Value)
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerCatorcenasPorZAFRA_TIPO_CICLO(Me.cbxZAFRA.Value, 2)
        If lista Is Nothing Then lista = New List(Of Int32)
        Me.cbxCATORCENA.DataSource = lista
        Me.cbxCATORCENA.DataBind()
        If noCatorcenaPropuesta > 0 Then
            If Me.cbxCATORCENA.Items.FindByValue(noCatorcenaPropuesta) IsNot Nothing Then
                Me.cbxCATORCENA.SelectedItem = Me.cbxCATORCENA.Items.FindByValue(noCatorcenaPropuesta)
            End If
        End If
    End Sub

    Private Sub CargarSemanas()
        Dim listaCad As New List(Of String)
        Dim _Catorcena As Int32 = -1
        If Me.cbxCATORCENA.Text <> "" Then _Catorcena = CInt(Me.cbxCATORCENA.Text)
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerSemanasPorZAFRA_TIPO_CICLO_CATORCENA(Me.cbxZAFRA.Value, 2, _Catorcena)
        If lista Is Nothing Then lista = New List(Of Int32)

        listaCad.Add("[Todas]")
        For Each s As Int32 In lista
            listaCad.Add(s.ToString)
        Next
        Me.cbxSEMANA.DataSource = listaCad
        Me.cbxSEMANA.DataBind()
        If cbxSEMANA.Items.Count > 0 Then cbxSEMANA.SelectedItem = cbxSEMANA.Items.FindByValue("[Todas]")
    End Sub


    Private Sub CargarCatorcenasPopup()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lCatorcenas As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(lZafraActiva.ID_ZAFRA, False, False, "CATORCENA", "DESC")
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerCatorcenasPorZAFRA_TIPO_CICLO(lZafraActiva.ID_ZAFRA, 2)
        If lista Is Nothing Then lista = New List(Of Int32)
        Me.cbxCATORCENApopup.DataSource = lista
        Me.cbxCATORCENApopup.DataBind()
        If lCatorcenas IsNot Nothing AndAlso lCatorcenas.Count > 0 Then
            If Me.cbxCATORCENApopup.Items.FindByValue(lCatorcenas(0).CATORCENA) IsNot Nothing Then
                Me.cbxCATORCENApopup.SelectedItem = Me.cbxCATORCENApopup.Items.FindByValue(lCatorcenas(0).CATORCENA)
            End If
        End If
    End Sub

    Private Sub CargarSemanasPopup()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim listaCad As New List(Of String)
        Dim _Catorcena As Int32 = -1
        If Me.cbxCATORCENApopup.Text <> "" Then _Catorcena = CInt(Me.cbxCATORCENApopup.Text)
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerSemanasPorZAFRA_TIPO_CICLO_CATORCENA(lZafraActiva.ID_ZAFRA, 2, _Catorcena)
        If lista Is Nothing Then lista = New List(Of Int32)

        listaCad.Add("[Todas]")
        For Each s As Int32 In lista
            listaCad.Add(s.ToString)
        Next
        Me.cbxSEMANApopup.DataSource = listaCad
        Me.cbxSEMANApopup.DataBind()
        If cbxSEMANApopup.Items.Count > 0 Then cbxSEMANApopup.SelectedItem = cbxSEMANApopup.Items.FindByValue("[Todas]")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PLAN_COSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.lblTitulo.Text = "Plan de Cosecha Catorcenal"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("OrdenRoza", True)
        'Me.ucBarraNavegacion1.VerOpcion("GenerarPropuesta", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucCriteriosPlanPrecosechaLayout.Visible = True
        Me.ucListaPLAN_COSECHA1.Visible = True
        Me.ucVistaDetallePLAN_COSECHA1.Visible = False
        Me.ucVistaDetalleCONTROL_ROZA1.Visible = False
        Me.ucVistaDetalleCONTROL_QUEMA1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PLAN_COSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.lblTitulo.Text = "Ingresando/Modificando Plan de Cosecha de un Lote"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("OrdenRoza", False)
        'Me.ucBarraNavegacion1.VerOpcion("GenerarPropuesta", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucCriteriosPlanPrecosechaLayout.Visible = False
        Me.ucListaPLAN_COSECHA1.Visible = False
        Me.ucVistaDetallePLAN_COSECHA1.Visible = True
    End Sub

    Public Property ID_ZAFRA_ACTUAL As Int32
        Get
            If Me.ViewState("ID_ZAFRA") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_ZAFRA"))
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_ZAFRA") = value
        End Set
    End Property

    Private Sub CargarFechasCatorcena()
        Dim lFechas As listaCICLO_PERIODO
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim semana As Int32 = -1
        If Me.cbxSEMANApopup.Value IsNot Nothing AndAlso IsNumeric(Me.cbxSEMANApopup.Value) Then
            semana = CInt(Me.cbxSEMANApopup.Value)
        End If
        lFechas = (New cCICLO_PERIODO).ObtenerListaPorCriterios(lZafraActiva.ID_ZAFRA, 2, Me.cbxCATORCENApopup.Value, semana, Nothing, "FECHA")

        Me.dteFECHA_INI_CATORCENA.Value = Nothing
        Me.dteFECHA_FIN_CATORCENA.Value = Nothing

        If lFechas IsNot Nothing AndAlso lFechas.Count > 0 Then
            Me.dteFECHA_INI_CATORCENA.Date = lFechas(0).FECHA
            Me.dteFECHA_FIN_CATORCENA.Date = lFechas(lFechas.Count - 1).FECHA
        End If
    End Sub

    Private Sub InicializarRozaDia()
        Me.lblTitulo.Text = "Ingresando Roza del Dia"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("OrdenRoza", False)
        Me.ucBarraNavegacion1.VerOpcion("ControlRoza", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucCriteriosPlanPrecosechaLayout.Visible = False
        Me.ucListaPLAN_COSECHA1.Visible = False
        Me.ucVistaDetalleCONTROL_ROZA1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_COSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarPLAN_COSECHA()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarPLAN_COSECHA() As Integer
        If Me.ucListaPLAN_COSECHA1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim codiAgron As String = cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario)
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo plan", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("OrdenRoza", "Emitir Orden de Roza", False, IconoBarra.Reporte, "", "", True)
        'Me.ucBarraNavegacion1.CrearOpcion("GenerarPropuesta", "Generar propuesta", False, IconoBarra.Programar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Regresar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        If codiAgron <> "" Then
            Me.cbxAGRONOMO.Value = codiAgron
            Me.cbxAGRONOMO.ClientEnabled = False
        Else
            Me.cbxAGRONOMO.Value = ""
            Me.cbxAGRONOMO.ClientEnabled = True
        End If
        Me.CargarCatorcenas()
        Me.CargarSemanas()
        Me.ucListaPLAN_COSECHA1.CargarDatosPorCriterios(lZafra.ID_ZAFRA, "", "", Me.cbxCATORCENA.Value, -1, Nothing, Nothing, "", "", "", -1, "", "", False, -1, False)
    End Sub

    Protected Sub ucListaPLAN_COSECHA1_Editando(ByVal ID_PLAN_COSECHA As Int32) Handles ucListaPLAN_COSECHA1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetallePLAN_COSECHA1.ID_PLAN_COSECHA = ID_PLAN_COSECHA
    End Sub

    Private Sub ucVistaDetallePLAN_COSECHA1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetallePLAN_COSECHA1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim ID_ZAFRA As Int32 = -1
                Dim FECHA_INI As Object = Nothing
                Dim FECHA_FIN As Object = Nothing
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""
                Dim NO_CONTRATO As Int32 = -1
                Dim SEMANA As Int32 = -1
                
                If Me.cbxZAFRA.Value IsNot Nothing Then ID_ZAFRA = cbxZAFRA.Value
                If dteFechaDel.Text <> "" Then FECHA_INI = dteFechaDel.Date
                If dteFechaAl.Text <> "" Then FECHA_FIN = dteFechaAl.Date
                If Me.speCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.speCODIPROVEE.Text))
                If Me.speCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.speCODISOCIO.Text))
                If Me.speNO_CONTRATO.Text <> "" Then NO_CONTRATO = Me.speNO_CONTRATO.Value
                If Me.cbxSEMANA.Value IsNot Nothing AndAlso IsNumeric(Me.cbxSEMANA.Value) Then
                    SEMANA = CInt(Me.cbxSEMANA.Value)
                End If
                Me.ucListaPLAN_COSECHA1.QuitarSeleccion()
                Me.ucListaPLAN_COSECHA1.CargarDatosPorCriterios(ID_ZAFRA, Me.cbxZONA.Value, Me.cbxSUB_ZONA.Value, Me.cbxCATORCENA.Value, SEMANA, FECHA_INI, FECHA_FIN, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text, NO_CONTRATO, Me.cbxAGRONOMO.Value, "", False, -1, False)

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetallePLAN_COSECHA1.LimpiarControles()
                Me.ucVistaDetallePLAN_COSECHA1.ID_PLAN_COSECHA = 0

            Case "OrdenRoza"
                Dim lPlanCosechaLotes As listaPLAN_COSECHA
                Dim bFiltroOrden As New cFILTRO_ORDEN_ROZA
                Dim sFecha As New StringBuilder
                Dim sSeparador As String = "F"
                Dim fecha As DateTime

                lPlanCosechaLotes = ucListaPLAN_COSECHA1.DevolverSeleccionados

                If lPlanCosechaLotes.Count = 0 Then
                    AsignarMensaje("Marque los Lotes del Plan de Cosecha para generar la Orden de Roza", False, True, True)
                    Return
                End If

                fecha = Now
                fecha = New DateTime(fecha.Year, fecha.Month, fecha.Day, fecha.Hour, fecha.Minute, fecha.Second)
                sFecha.Append(fecha.Year.ToString) : sFecha.Append(sSeparador)
                sFecha.Append(fecha.Month.ToString) : sFecha.Append(sSeparador)
                sFecha.Append(fecha.Day.ToString) : sFecha.Append(sSeparador)
                sFecha.Append(fecha.Hour.ToString) : sFecha.Append(sSeparador)
                sFecha.Append(fecha.Minute.ToString) : sFecha.Append(sSeparador)
                sFecha.Append(fecha.Second.ToString)

                'Eliminar filtros anteriores de plan de cosecha
                bFiltroOrden.EliminarFiltroPorUsuarioFecha(Me.ObtenerUsuario, DateAdd(DateInterval.Minute, -30, fecha))

                For Each lPlanLote As PLAN_COSECHA In lPlanCosechaLotes
                    Dim lFiltro As New FILTRO_ORDEN_ROZA
                    lFiltro.ID_FILTRO_ORDEN_ROZA = 0
                    lFiltro.USUARIO_CREA = Me.ObtenerUsuario
                    lFiltro.FECHA_CREA = fecha
                    lFiltro.ID_PLAN_COSECHA = lPlanLote.ID_PLAN_COSECHA
                    bFiltroOrden.ActualizarFILTRO_ORDEN_ROZA(lFiltro)
                Next

                'Invocar a la pagina del reporte
                ucListaPLAN_COSECHA1.QuitarSeleccion()
                AsignarMensaje("Orden de Roza emitida con exito", False, True, True)
                ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarOrdenRoza(" + Me.cbxZAFRA.Value.ToString + ",'" + Me.ObtenerUsuario + "','" + sFecha.ToString + "')", True)


            Case "GenerarPropuesta"
                Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                If lZafraActiva IsNot Nothing Then
                    Me.ID_ZAFRA_ACTUAL = lZafraActiva.ID_ZAFRA
                Else
                    Me.ID_ZAFRA_ACTUAL = -1
                End If
                Me.lblpcError.Text = ""
                Me.CargarCatorcenasPopup()
                Me.CargarSemanasPopup()
                Me.CargarFechasCatorcena()
                Me.pcGenerarPropuesta.ShowOnPageLoad = True

            Case "Guardar"
                Dim sError As String = ""
                If ucVistaDetallePLAN_COSECHA1.Visible Then
                    sError = Me.ucVistaDetallePLAN_COSECHA1.Actualizar()
                ElseIf ucVistaDetalleCONTROL_ROZA1.Visible Then
                    sError = Me.ucVistaDetalleCONTROL_ROZA1.Actualizar()
                ElseIf ucVistaDetalleCONTROL_QUEMA1.Visible Then
                    sError = Me.ucVistaDetalleCONTROL_QUEMA1.Actualizar()
                End If
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                Else
                    Me.ucListaPLAN_COSECHA1.DataBind()
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaPLAN_COSECHA1.DataBind()

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub

    Protected Sub cbxZONA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZONA.ValueChanged
        CargarSubZonas()
    End Sub

    Protected Sub cpMantPLAN_COSECHA_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMantPLAN_COSECHA.Callback
        Dim parametros As String() = e.Parameter.Split(";")
        Me.cpMantPLAN_COSECHA.JSProperties.Clear()
        Me.cpMantPLAN_COSECHA.JSProperties.Add("cpOpcion", parametros(0))
        Select Case parametros(0)
            Case "ObtenerSaldosLote"
                Me.ucVistaDetallePLAN_COSECHA1.ObtenerSaldoLote()
        End Select
    End Sub

    Protected Sub cbxCATORCENA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxCATORCENA.ValueChanged
        Me.CargarSemanas()
    End Sub

    Protected Sub btnGenerar_Click(sender As Object, e As System.EventArgs) Handles btnGenerar.Click
        Dim lRet As Int32 = 0
        Dim lSemana As Int32 = -1
        Dim bPlanCosecha As New cPLAN_COSECHA

        If Me.cbxCATORCENApopup.Text = "" Then
            Me.lblpcError.Text = "Seleccione una Catorcena"
            Return
        End If
        If Me.dteFECHA_INI_CATORCENA.Value Is Nothing Then
            Me.lblpcError.Text = "Ingrese la fecha de inicio de catorcena"
            Return
        End If
        If Me.dteFECHA_FIN_CATORCENA.Value Is Nothing Then
            Me.lblpcError.Text = "Ingrese la fecha de fin de catorcena"
            Return
        End If
        If Me.dteFECHA_INI_CATORCENA.Date > Me.dteFECHA_FIN_CATORCENA.Date Then
            Me.lblpcError.Text = "La fecha de inicio no puede ser mayor que la fecha de finalizacion"
            Return
        End If
        If Me.cbxSEMANApopup.Value IsNot Nothing AndAlso IsNumeric(Me.cbxSEMANApopup.Value) Then
            lSemana = CInt(Me.cbxSEMANApopup.Value)
        End If

        lRet = bPlanCosecha.GenerarPropuestaCosechaCatorcenal(Me.ID_ZAFRA_ACTUAL, _
                                                              CInt(Me.cbxCATORCENApopup.Value), _
                                                              lSemana, _
                                                              Me.ObtenerUsuario, cFechaHora.ObtenerFechaHora)
        If lRet <> 1 Then
            Me.lblpcError.Text = "Error: " + bPlanCosecha.sError
            Return
        Else
            Me.pcGenerarPropuesta.ShowOnPageLoad = False
            Me.AsignarMensaje("La propuesta para la catorcena " + Me.cbxCATORCENApopup.Text + " se genero con exito", False, True, True)
            Me.CargarCatorcenas()
            Me.ucBarraNavegacion1_OpcionSeleccionada("Buscar")
            Me.ucListaPLAN_COSECHA1.DataBind()
        End If
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarCatorcenas()
    End Sub

    Protected Sub cbxSEMANApopup_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxSEMANApopup.ValueChanged
        Me.CargarFechasCatorcena()
    End Sub

    Protected Sub cbxCATORCENApopup_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxCATORCENApopup.ValueChanged
        Me.CargarSemanasPopup()
        Me.CargarFechasCatorcena()
    End Sub

    Protected Sub ucListaPLAN_COSECHA1_Rozando(ID_PLAN_COSECHA As Integer) Handles ucListaPLAN_COSECHA1.Rozando
        Dim lPlanCosecha As PLAN_COSECHA = (New cPLAN_COSECHA).ObtenerPLAN_COSECHA(ID_PLAN_COSECHA)
        Dim lLotesCosecha As LOTES_COSECHA

        If lPlanCosecha IsNot Nothing Then
            lLotesCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lPlanCosecha.ACCESLOTE, lPlanCosecha.ID_ZAFRA)
            If lLotesCosecha IsNot Nothing Then
                Session("ucMantPLAN_COSECHA_ID_LOTES_COSECHA") = lLotesCosecha.ID_LOTES_COSECHA
                Me.InicializarDetalleRoza()
                Me.ucVistaDetalleCONTROL_ROZA1.ID_LOTES_COSECHA = lLotesCosecha.ID_LOTES_COSECHA
                Return
            End If
        End If
        Me.AsignarMensaje("No se logro acceder al control de roza", False, True)
    End Sub

    Protected Sub ucListaPLAN_COSECHA1_Quemando(ID_PLAN_COSECHA As Integer) Handles ucListaPLAN_COSECHA1.Quemando
        Dim lPlanCosecha As PLAN_COSECHA = (New cPLAN_COSECHA).ObtenerPLAN_COSECHA(ID_PLAN_COSECHA)
        Dim lLotesCosecha As LOTES_COSECHA

        If lPlanCosecha IsNot Nothing Then
            lLotesCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lPlanCosecha.ACCESLOTE, lPlanCosecha.ID_ZAFRA)
            If lLotesCosecha IsNot Nothing Then
                Session("ucMantPLAN_COSECHA_ID_LOTES_COSECHA") = lLotesCosecha.ID_LOTES_COSECHA
                Me.InicializarDetalleQuema()
                Me.ucVistaDetalleCONTROL_QUEMA1.ID_LOTES_COSECHA = lLotesCosecha.ID_LOTES_COSECHA
                Return
            End If
        End If
        Me.AsignarMensaje("No se logro acceder al control de quema", False, True)
    End Sub

    Private Sub InicializarDetalleRoza()
        Me.lblTitulo.Text = "Control de Roza"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("OrdenRoza", False)
        'Me.ucBarraNavegacion1.VerOpcion("GenerarPropuesta", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        'Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucCriteriosPlanPrecosechaLayout.Visible = False
        Me.ucListaPLAN_COSECHA1.Visible = False
        Me.ucVistaDetallePLAN_COSECHA1.Visible = False
        Me.ucVistaDetalleCONTROL_QUEMA1.Visible = False
        Me.ucVistaDetalleCONTROL_ROZA1.Visible = True
    End Sub

    Private Sub InicializarDetalleQuema()
        Me.lblTitulo.Text = "Control de Quema"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("OrdenRoza", False)
        'Me.ucBarraNavegacion1.VerOpcion("GenerarPropuesta", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        'Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucCriteriosPlanPrecosechaLayout.Visible = False
        Me.ucListaPLAN_COSECHA1.Visible = False
        Me.ucVistaDetallePLAN_COSECHA1.Visible = False
        Me.ucVistaDetalleCONTROL_QUEMA1.Visible = True
        Me.ucVistaDetalleCONTROL_ROZA1.Visible = False
    End Sub
End Class
