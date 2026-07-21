Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantESTICANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ESTICANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantESTICANA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ESTICANA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.lblTitulo.Text = "ESTICAÑA ACTUAL"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("ControlRoza", True)
        Me.ucBarraNavegacion1.VerOpcion("ControlQuema", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucCriteriosLotesCosecha.Visible = True
        Me.ucListaESTICANA1.Visible = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ESTICANA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalleRoza()
        Me.lblTitulo.Text = "Control de Roza"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("ControlRoza", False)
        Me.ucBarraNavegacion1.VerOpcion("ControlQuema", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucCriteriosLotesCosecha.Visible = False
        Me.ucListaESTICANA1.Visible = False
    End Sub

    Private Sub InicializarDetalleQuema()
        Me.lblTitulo.Text = "Control de Quema"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("ControlRoza", False)
        Me.ucBarraNavegacion1.VerOpcion("ControlQuema", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucCriteriosLotesCosecha.Visible = False
        Me.ucListaESTICANA1.Visible = False
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim codiAgron As String = cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario)
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        'Me.ucBarraNavegacion1.CrearOpcion("ControlQuema", "Control de Quema", False, IconoBarra.Programar, "", "", True)
        'Me.ucBarraNavegacion1.CrearOpcion("ControlRoza", "Control de Roza", False, IconoBarra.Reporte, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Regresar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        'If IsNumeric(cbxZAFRA.Value) Then Me.ucListaESTICANA1.CargarDatosPorCriterios(CInt(cbxZAFRA.Value), "", "", "", "", "", -1, codiAgron)
        If codiAgron <> "" Then
            Me.cbxAGRONOMO.Value = codiAgron
            Me.cbxAGRONOMO.ClientEnabled = False
        Else
            Me.cbxAGRONOMO.Value = ""
            Me.cbxAGRONOMO.ClientEnabled = True
        End If
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ESTICANA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarESTICANA()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarESTICANA() As Integer
        If Me.ucListaESTICANA1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Public Property ID_ESTICANA As Int32
        Get
            If Me.ViewState("ID_ESTICANA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ESTICANA"))
            Else
                Return (-1)
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_ESTICANA") = value
        End Set
    End Property


    Private Sub CargarDatosCriterios()
        Dim ID_ZAFRA As Int32 = -1
        Dim CODIPROVEE As String = ""
        Dim CODISOCIO As String = ""
        Dim NOMBRE_PROVEEDOR As String = ""
        Dim NOMBLOTE As String = ""
        Dim CODIAGRON As String = ""
        Dim NO_CONTRATO As Int32 = -1

        If Me.cbxZAFRA.Value IsNot Nothing Then ID_ZAFRA = cbxZAFRA.Value
        If Me.speCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.speCODIPROVEE.Text))
        If Me.speCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.speCODISOCIO.Text))
        If Me.speNO_CONTRATO.Text <> "" Then NO_CONTRATO = Me.speNO_CONTRATO.Value
        If Me.txtNOMBRE_PROVEEDOR.Value IsNot Nothing Then NOMBRE_PROVEEDOR = Me.txtNOMBRE_PROVEEDOR.Value
        If Me.txtNOMBLOTE.Value IsNot Nothing Then NOMBLOTE = Me.txtNOMBLOTE.Value
        If Me.cbxAGRONOMO.Value IsNot Nothing Then CODIAGRON = Me.cbxAGRONOMO.Value
        Me.ucListaESTICANA1.CargarDatosPorCriterios(ID_ZAFRA, Me.cbxZONA.Value, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NOMBLOTE, NO_CONTRATO, CODIAGRON)
        If Session("ucMantESTICANA_ID_ESTICANA") IsNot Nothing AndAlso IsNumeric(Session("ucMantESTICANA_ID_ESTICANA")) Then
            Me.ucListaESTICANA1.SeleccionarFila = Session("ucMantESTICANA_ID_ESTICANA")
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Session("ucMantESTICANA_ID_ESTICANA") = Nothing
                Me.ucListaESTICANA1.QuitarSeleccion()
                Me.CargarDatosCriterios()

            Case "Exportar"
                Me.ucListaESTICANA1.ExportarExcel()

            Case "Guardar"
                Dim sError As String = ""
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                Else
                    AsignarMensaje("", True, False)
                    Me.ucListaESTICANA1.DataBind()
                    Return
                End If

            Case "Cancelar"
                Me.CargarDatosCriterios()
                Me.InicializarLista()
        End Select
    End Sub

    Private Sub HabilitarEsticana(ByVal modo As Boolean)
        Me.speCODIPROVEEpop.ClientEnabled = False
        Me.speCODISOCIOpop.ClientEnabled = False
        Me.txtNOMBRE_PROVEEDORpop.ClientEnabled = False
        Me.txtCODILOTEpop.ClientEnabled = False
        Me.txtNOMBLOTEpop.ClientEnabled = False
        Me.speMZ_COSECHApop.ClientEnabled = modo
        Me.speTC_MZ_COSECHApop.ClientEnabled = False
        Me.speTC_COSECHApop.ClientEnabled = modo
        Me.speTC_SEMILLApop.ClientEnabled = modo
        Me.speTC_ENTREGADApop.ClientEnabled = False
        Me.speTC_VARIACIONpop.ClientEnabled = False
        Me.speTC_ENTREGARpop.ClientEnabled = False
        Me.chkFIN_LOTEpop.ClientEnabled = modo
        If Not modo AndAlso Me.dteFECHA_CIERRE.Value = #12:00:00 AM# Then
            Me.dteFECHA_CIERRE.ClientEnabled = True
        Else
            Me.dteFECHA_CIERRE.ClientEnabled = False
        End If
        Me.speHORAS_GRACIA_ENTREGA.ClientEnabled = Not modo
        Me.btnAceptar.ClientEnabled = True
    End Sub

    Protected Sub ucListaESTICANA1_Editando(ID_ESTICANA As Integer) Handles ucListaESTICANA1.Editando
        Dim lLoteCosecha As ESTICANA = (New cESTICANA).ObtenerESTICANA(ID_ESTICANA)
        Me.lblpcError.Text = ""
        Me.txtTitulopop.Text = "ESTICANA DETERMINADO AL " + cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy")
        Me.speCODIPROVEEpop.Value = Nothing
        Me.speCODISOCIOpop.Value = Nothing
        Me.txtNOMBRE_PROVEEDORpop.Value = Nothing
        Me.speMZ_COSECHApop.Value = Nothing
        Me.speTC_MZ_COSECHApop.Value = Nothing
        Me.speTC_COSECHApop.Value = Nothing
        Me.speTC_SEMILLApop.Value = Nothing
        Me.speTC_ENTREGADApop.Value = Nothing
        Me.speTC_VARIACIONpop.Value = Nothing
        Me.speTC_ENTREGARpop.Value = Nothing
        Me.dteFECHA_CIERRE.Value = Nothing
        Me.speHORAS_GRACIA_ENTREGA.Value = 0
        If lLoteCosecha IsNot Nothing Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lLoteCosecha.ACCESLOTE)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
            If lProveedor IsNot Nothing Then
                Me.speCODIPROVEEpop.Value = CInt(lProveedor.CODIPROVEE)
                If lProveedor.CODISOCIO <> Utilerias.FormatoCODISOCIO(0) Then
                    Me.speCODISOCIOpop.Value = CInt(lProveedor.CODISOCIO)
                End If
                Me.txtNOMBRE_PROVEEDORpop.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
            End If
            Me.txtCODILOTEpop.Text = lLote.CODILOTE
            Me.txtNOMBLOTEpop.Text = lLote.NOMBLOTE
            Me.speMZ_COSECHApop.Value = lLoteCosecha.MZ_CENSO
            Me.speTC_MZ_COSECHApop.Value = lLoteCosecha.TONEL_MZ_CENSO
            Me.speTC_COSECHApop.Value = lLoteCosecha.TONEL_CENSO
            Me.speTC_SEMILLApop.Value = lLoteCosecha.TONEL_SEMILLA
            Me.speTC_ENTREGADApop.Value = lLoteCosecha.TONEL_ENTREGADA
            Me.speTC_VARIACIONpop.Value = lLoteCosecha.TONEL_SALDO_VAR
            Me.speTC_ENTREGARpop.Value = lLoteCosecha.TONEL_ENTREGAR
            Me.chkFIN_LOTEpop.Checked = lLoteCosecha.FIN_LOTE
            Me.dteFECHA_CIERRE.Value = lLoteCosecha.FECHA_CIERRE
            Me.speHORAS_GRACIA_ENTREGA.Value = lLoteCosecha.HORAS_GRACIA_ENTREGA
            If lLoteCosecha.FIN_LOTE Then HabilitarEsticana(False) Else HabilitarEsticana(True)
            Me.pcEsticana.ShowOnPageLoad = True
            Me.ID_ESTICANA = ID_ESTICANA
        End If
    End Sub

    Private Sub CalcularTCEntregar()
        Me.lblpcError.Text = ""
        Dim lMZCosecha As Decimal = Me.speMZ_COSECHApop.Value
        Dim lTCCosecha As Decimal = Me.speTC_COSECHApop.Value
        Dim lTCVariacion As Decimal = 0
        Dim lTCEntregar As Decimal = 0

        If lMZCosecha = 0 Then Me.speTC_MZ_COSECHApop.Value = 0 Else Me.speTC_MZ_COSECHApop.Value = Math.Round(lTCCosecha / lMZCosecha, 2)
        If Me.chkFIN_LOTEpop.Checked Then
            lTCVariacion = lTCCosecha - CDec(Me.speTC_SEMILLApop.Value) - CDec(Me.speTC_ENTREGADApop.Value)
            lTCEntregar = 0
        Else
            lTCVariacion = 0
            lTCEntregar = lTCCosecha - CDec(Me.speTC_SEMILLApop.Value) - CDec(Me.speTC_ENTREGADApop.Value)
        End If
        Me.speTC_VARIACIONpop.Value = lTCVariacion
        Me.speTC_ENTREGARpop.Value = lTCEntregar
        If Me.speTC_ENTREGADApop.Value Is Nothing Then Me.speTC_ENTREGADApop.Value = 0
    End Sub

    Protected Sub speMZ_COSECHApop_ValueChanged(sender As Object, e As System.EventArgs) Handles speMZ_COSECHApop.ValueChanged
        Me.CalcularTCEntregar()
    End Sub

    Protected Sub speTC_COSECHApop_ValueChanged(sender As Object, e As System.EventArgs) Handles speTC_COSECHApop.ValueChanged
        Me.CalcularTCEntregar()
    End Sub

    Protected Sub speTC_SEMILLApop_ValueChanged(sender As Object, e As System.EventArgs) Handles speTC_SEMILLApop.ValueChanged
        Me.CalcularTCEntregar()
    End Sub

    Protected Sub chkFIN_LOTEpop_ValueChanged(sender As Object, e As System.EventArgs) Handles chkFIN_LOTEpop.ValueChanged
        Me.CalcularTCEntregar()
        Me.ConfigFechaCierre()
    End Sub

    Private Sub ConfigFechaCierre()
        If chkFIN_LOTEpop.Checked Then
            Me.dteFECHA_CIERRE.ClientEnabled = True
            Me.speHORAS_GRACIA_ENTREGA.ClientEnabled = True
        Else
            Me.dteFECHA_CIERRE.ClientEnabled = False
            Me.speHORAS_GRACIA_ENTREGA.ClientEnabled = False
            Me.dteFECHA_CIERRE.Value = Nothing
            Me.speHORAS_GRACIA_ENTREGA.Value = 0
        End If
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As System.EventArgs) Handles btnAceptar.Click
        If Me.ID_ESTICANA <> -1 Then
            Dim lLoteCosecha As ESTICANA = (New cESTICANA).ObtenerESTICANA(Me.ID_ESTICANA)
            Dim bLoteCosecha As New cESTICANA

            If lLoteCosecha IsNot Nothing Then
                If Me.chkFIN_LOTEpop.Checked Then
                    If Me.dteFECHA_CIERRE.Value = #12:00:00 AM# Then
                        Me.lblpcError.Text = "Ingrese la Fecha/Hora de Cierre"
                        Return
                    End If
                    If Me.chkFIN_LOTEpop.ClientEnabled AndAlso Me.dteFECHA_CIERRE.Date > cFechaHora.ObtenerFechaHora Then
                        Me.lblpcError.Text = "La Fecha/Hora de Cierre no puede ser mayor que la fecha/hora actual"
                        Return
                    End If
                    If Me.chkFIN_LOTEpop.ClientEnabled AndAlso Me.dteFECHA_CIERRE.Date < cFechaHora.ObtenerFechaHora AndAlso
                        DateDiff(DateInterval.Day, Me.dteFECHA_CIERRE.Date, cFechaHora.ObtenerFechaHora) > 10 Then
                        Me.lblpcError.Text = "La Fecha/Hora de Cierre no puede ser menor a diez dias"
                        Return
                    End If
                End If

                lLoteCosecha.MZ_CENSO = Me.speMZ_COSECHApop.Value
                lLoteCosecha.TONEL_MZ_CENSO = Me.speTC_MZ_COSECHApop.Value
                lLoteCosecha.TONEL_CENSO = Me.speTC_COSECHApop.Value
                lLoteCosecha.TONEL_SEMILLA = Me.speTC_SEMILLApop.Value
                lLoteCosecha.FIN_LOTE = Me.chkFIN_LOTEpop.Checked

                If lLoteCosecha.FIN_LOTE Then
                    lLoteCosecha.TONEL_SALDO_VAR = lLoteCosecha.TONEL_CENSO - CDec(Me.speTC_SEMILLApop.Value) - lLoteCosecha.TONEL_ENTREGADA
                    lLoteCosecha.MZ_ENTREGAR = 0
                    lLoteCosecha.TONEL_MZ_ENTREGAR = 0
                    lLoteCosecha.TONEL_ENTREGAR = 0
                    lLoteCosecha.FECHA_CIERRE = Me.dteFECHA_CIERRE.Date
                    lLoteCosecha.HORAS_GRACIA_ENTREGA = Me.speHORAS_GRACIA_ENTREGA.Value
                Else
                    lLoteCosecha.TONEL_SALDO_VAR = 0
                    lLoteCosecha.TONEL_ENTREGAR = lLoteCosecha.TONEL_CENSO - CDec(Me.speTC_SEMILLApop.Value) - lLoteCosecha.TONEL_ENTREGADA
                    If lLoteCosecha.TONEL_ENTREGAR = 0 Then
                        lLoteCosecha.TONEL_MZ_ENTREGAR = 0
                    Else
                        lLoteCosecha.TONEL_MZ_ENTREGAR = IIf(lLoteCosecha.TONEL_MZ_CENSO = 0, 0, Math.Round(lLoteCosecha.TONEL_ENTREGAR / lLoteCosecha.TONEL_MZ_CENSO, 2))
                    End If
                    lLoteCosecha.MZ_ENTREGAR = IIf(lLoteCosecha.TONEL_MZ_ENTREGAR = 0, 0, Math.Round(lLoteCosecha.TONEL_ENTREGAR / lLoteCosecha.TONEL_MZ_ENTREGAR, 2))
                    lLoteCosecha.HORAS_GRACIA_ENTREGA = 0
                End If

                If bLoteCosecha.ActualizarESTICANA(lLoteCosecha) < 0 Then
                    Me.lblpcError.Text = bLoteCosecha.sError
                    Return
                End If

                If lLoteCosecha.FIN_LOTE Then
                    'Liquidar inventarios
                    'LiquidarSaldoQuema(lLoteCosecha.ID_ESTICANA)
                End If
                Me.pcEsticana.ShowOnPageLoad = False
                Me.ucListaESTICANA1.DataBind()
            End If
        End If
    End Sub


End Class
