Imports SISPACAL.EL
Imports SISPACAL.BL

Partial Class controlesBodega_ucCriteriosBodega
    Inherits System.Web.UI.UserControl

    'Esta es una prueba de cambio para el brach develop

    Protected Sub cbxPERIODO_ValueChanged(sender As Object, e As EventArgs) Handles cbxPERIODO.ValueChanged
        Me.dteFECHA_INICIAL.Value = Nothing
        Me.dteFECHA_FINAL.Value = Nothing
        If Me.cbxPERIODO.Value = 1 Then
            Me.dteFECHA_INICIAL.ClientEnabled = False
            Me.dteFECHA_FINAL.ClientEnabled = False
        Else
            Dim hoy As Date = cFechaHora.ObtenerFecha
            Dim f1 As Date
            Dim f2 As Date

            f1 = New DateTime(hoy.Year, hoy.Month, 1)
            f2 = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, f1))
            Me.dteFECHA_INICIAL.ClientEnabled = True
            Me.dteFECHA_FINAL.ClientEnabled = True
            Me.dteFECHA_INICIAL.Date = f1
            Me.dteFECHA_FINAL.Date = f2
        End If
    End Sub

    Public Property ZONA() As String
        Get
            If Me.cbxZONA.Value Is Nothing Then Return ""
            Return Me.cbxZONA.Value
        End Get
        Set(ByVal value As String)
            Me.cbxZONA.Value = value.ToString()
        End Set
    End Property

    Public Property VerPROVEEDOR_AGRICOLA_CREDITO_TRANS() As Boolean
        Get
            Return Me.trPROVEEDOR_AGRICOLA_CREDITO_TRANS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROVEEDOR_AGRICOLA_CREDITO_TRANS.Visible = value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.trZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZONA.Visible = value
        End Set
    End Property

    Public Property VerZAFRA As Boolean
        Get
            Return Me.trZAFRA.Visible
        End Get
        Set(value As Boolean)
            Me.trZAFRA.Visible = value
        End Set
    End Property

    Public Property VerRESUMEN_POR_OPERADOR As Boolean
        Get
            Return Me.trRESUMEN_POR_OPERADOR.Visible
        End Get
        Set(value As Boolean)
            Me.trRESUMEN_POR_OPERADOR.Visible = value
        End Set
    End Property

    Public Property VerFECHA As Boolean
        Get
            Return Me.trFECHA.Visible
        End Get
        Set(value As Boolean)
            Me.trFECHA.Visible = value
        End Set
    End Property

    Public Property VerDETALLE As Boolean
        Get
            Return Me.trES_DETALLE.Visible
        End Get
        Set(value As Boolean)
            Me.trES_DETALLE.Visible = value
        End Set
    End Property

    Public Property FECHA() As Date
        Get
            If Me.dteFECHA.Value Is Nothing Then
                Return Nothing
            Else
                Return Me.dteFECHA.Date
            End If
        End Get
        Set(ByVal value As Date)
            Me.dteFECHA.Date = value
        End Set
    End Property

    Public Property ID_CATORCENA() As Integer
        Get
            If Me.cbxCATORCENA_ZAFRA.Value Is Nothing Then
                Return -1
            Else
                Return CInt(Me.cbxCATORCENA_ZAFRA.Value)
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxCATORCENA_ZAFRA.Value = value
        End Set
    End Property

    Public Property VerTIPO_PLANILLA As Boolean
        Get
            Return Me.trTIPO_PLANILLA.Visible
        End Get
        Set(value As Boolean)
            Me.trTIPO_PLANILLA.Visible = value
        End Set
    End Property

    Public Property VerTIPO_PLANILLA_FRENTES As Boolean
        Get
            Return Me.trTIPO_PLANILLA_FRENTES.Visible
        End Get
        Set(value As Boolean)
            Me.trTIPO_PLANILLA_FRENTES.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR As Boolean
        Get
            Return Me.trPROVEEDOR.Visible
        End Get
        Set(value As Boolean)
            Me.trPROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerTOTAL As Boolean
        Get
            Return Me.trTOTAL.Visible
        End Get
        Set(value As Boolean)
            Me.trTOTAL.Visible = value
        End Set
    End Property

    Public Property VerTRANSPORTISTA As Boolean
        Get
            Return Me.trTRANSPORTISTA.Visible
        End Get
        Set(value As Boolean)
            Me.trTRANSPORTISTA.Visible = value
        End Set
    End Property

    Public Property VerCUENTA_FINANCIAMIENTO As Boolean
        Get
            Return Me.trCUENTA_FINANCIAMIENTO.Visible
        End Get
        Set(value As Boolean)
            Me.trCUENTA_FINANCIAMIENTO.Visible = value
        End Set
    End Property

    Public Property VerCUENTA_FINANCIAMIENTO_TRANS As Boolean
        Get
            Return Me.trCUENTA_FINANCIAMIENTO_TRANS.Visible
        End Get
        Set(value As Boolean)
            Me.trCUENTA_FINANCIAMIENTO_TRANS.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR_AGRICOLA As Boolean
        Get
            Return Me.trPROVEEDOR_AGRICOLA.Visible
        End Get
        Set(value As Boolean)
            Me.trPROVEEDOR_AGRICOLA.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR_AGRICOLA_BANCOS As Boolean
        Get
            Return Me.trPROVEEDOR_AGRICOLA_BANCOS.Visible
        End Get
        Set(value As Boolean)
            Me.trPROVEEDOR_AGRICOLA_BANCOS.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR_VUELO As Boolean
        Get
            Return Me.trPROVEEDOR_VUELO.Visible
        End Get
        Set(value As Boolean)
            Me.trPROVEEDOR_VUELO.Visible = value
        End Set
    End Property

    Public Property VerBODEGA As Boolean
        Get
            Return Me.trBODEGA.Visible
        End Get
        Set(value As Boolean)
            Me.trBODEGA.Visible = value
        End Set
    End Property

    Public Property VerCATORCENA As Boolean
        Get
            Return Me.trCATORCENA.Visible
        End Get
        Set(value As Boolean)
            Me.trCATORCENA.Visible = value
        End Set
    End Property

    Public Property VerPRODUCTO As Boolean
        Get
            Return Me.trPRODUCTO.Visible
        End Get
        Set(value As Boolean)
            Me.trPRODUCTO.Visible = value
        End Set
    End Property

    Public Property VerPERIODO As Boolean
        Get
            Return Me.trPERIODO.Visible
        End Get
        Set(value As Boolean)
            Me.trPERIODO.Visible = value
        End Set
    End Property

    Public Property VerOCULTAR_SIN_SALDO As Boolean
        Get
            Return Me.trOCULTAR_PROVEE_SINSALDO.Visible
        End Get
        Set(value As Boolean)
            Me.trOCULTAR_PROVEE_SINSALDO.Visible = value
        End Set
    End Property

    Public Property VerPERIODO_RANGO As Boolean
        Get
            Return VerPERIODO
        End Get
        Set(value As Boolean)
            VerPERIODO = value
            If value Then
                Me.cbxPERIODO.Value = 2
                Me.cbxPERIODO.ClientEnabled = False
                cbxPERIODO_ValueChanged(Me, New System.EventArgs)
            Else
                Me.cbxPERIODO.Value = Nothing
                Me.cbxPERIODO.ClientEnabled = True
            End If
        End Set
    End Property

    Public Property ID_BODEGA As Int32
        Get
            If Me.cbxBODEGA.Value IsNot Nothing Then
                Return CInt(Me.cbxBODEGA.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxBODEGA.Value = value
        End Set
    End Property

    Public Property ID_TIPO_PLANILLA As Int32
        Get
            If Me.cbxTIPO_PLANILLA.Value IsNot Nothing Then
                Return CInt(Me.cbxTIPO_PLANILLA.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxTIPO_PLANILLA.Value = value
        End Set
    End Property

    Public Property ID_TIPO_PLANILLA_FRENTES As Int32
        Get
            If Me.cbxTIPO_PLANILLA_FRENTES.Value IsNot Nothing Then
                Return CInt(Me.cbxTIPO_PLANILLA_FRENTES.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxTIPO_PLANILLA_FRENTES.Value = value
        End Set
    End Property

    Public Property ID_CUENTA_FINAN As Int32
        Get
            If Me.cbxCUENTA_FINANCIAMIENTO.Value IsNot Nothing Then
                Return CInt(Me.cbxCUENTA_FINANCIAMIENTO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxCUENTA_FINANCIAMIENTO.Value = value
        End Set
    End Property

    Public Property ID_CUENTA_FINAN_TRANS As Int32
        Get
            If Me.cbxCUENTA_FINANCIAMIENTO_TRANS.Value IsNot Nothing Then
                Return CInt(Me.cbxCUENTA_FINANCIAMIENTO_TRANS.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxCUENTA_FINANCIAMIENTO_TRANS.Value = value
        End Set
    End Property

    Public Property ID_PRODUCTO As Int32
        Get
            If Me.cbxPRODUCTO.Value IsNot Nothing Then
                Return CInt(Me.cbxPRODUCTO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxPRODUCTO.Value = value
        End Set
    End Property

    Public Property ID_ZAFRA As Int32
        Get
            If Me.cbxZAFRA.Value IsNot Nothing Then
                Return CInt(Me.cbxZAFRA.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxZAFRA.Value = value
        End Set
    End Property

    Public Property ES_TOTAL As Boolean
        Get
            Return chkMostrarTotal.Checked
        End Get
        Set(value As Boolean)
            Me.chkMostrarTotal.Checked = value
        End Set
    End Property

    Public Property ES_DETALLE As Integer
        Get
            If Me.chkES_DETALLE.Checked Then
                Return 1
            Else
                Return 0
            End If
        End Get
        Set(value As Integer)
            If value = 1 Then
                Me.chkES_DETALLE.Checked = True
            Else
                Me.chkES_DETALLE.Checked = False
            End If
        End Set
    End Property

    Public Property ES_OCULTAR_SIN_SALDO As Integer
        Get
            If Me.chkOCULTAR_PROVEE_SINSALDO.Checked Then
                Return 1
            Else
                Return 0
            End If
        End Get
        Set(value As Integer)
            If value = 1 Then
                Me.chkOCULTAR_PROVEE_SINSALDO.Checked = True
            Else
                Me.chkOCULTAR_PROVEE_SINSALDO.Checked = False
            End If
        End Set
    End Property

    Public Property ES_RESUMEN_POR_OPERADOR As Integer
        Get
            If Me.chkResumenPorOperador.Checked Then
                Return 1
            Else
                Return 0
            End If
        End Get
        Set(value As Integer)
            If value = 1 Then
                Me.chkResumenPorOperador.Checked = True
            Else
                Me.chkResumenPorOperador.Checked = False
            End If
        End Set
    End Property

    Public Property APLICA_PARA_SOLICITUD_AGRICOLA As Boolean
        Get
            Return Me.odsCuentaFinan.SelectParameters("APLICA_SOLIC_AGRICOLA").DefaultValue
        End Get
        Set(value As Boolean)
            Me.odsCuentaFinan.SelectParameters("APLICA_SOLIC_AGRICOLA").DefaultValue = value
        End Set
    End Property

    Public Property APLICA_SOLO_CASA_COMERCIAL As Boolean
        Get
            Return Me.odsProveedorAgricola.SelectParameters("ES_CASA_COMER").DefaultValue
        End Get
        Set(value As Boolean)
            Me.odsProveedorAgricola.SelectParameters("ES_CASA_COMER").DefaultValue = value
        End Set
    End Property

    Public Property ID_PROVEEDOR_AGRICOLA As Int32
        Get
            If Me.cbxPROVEEDOR_AGRICOLA.Value IsNot Nothing Then
                Return CInt(Me.cbxPROVEEDOR_AGRICOLA.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxPROVEEDOR_AGRICOLA.Value = value
        End Set
    End Property

    Public Property ID_PROVEEDOR_AGRICOLA_CREDITO_TRANS As Int32
        Get
            If Me.cbxPROVEEDOR_AGRICOLA_CREDITO_TRANS.Value IsNot Nothing Then
                Return CInt(Me.cbxPROVEEDOR_AGRICOLA_CREDITO_TRANS.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxPROVEEDOR_AGRICOLA_CREDITO_TRANS.Value = value
        End Set
    End Property

    Public Property ID_PROVEEDOR_AGRICOLA_BANCOS As Int32
        Get
            If Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Text.Trim <> "" Then
                If Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Text.Contains("[") Then
                    Dim posIni As Integer = Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Text.IndexOf("[")
                    Dim posFin As Integer = Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Text.IndexOf("]")
                    Dim cad As String = Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Text.Substring(posIni + 1, posFin - posIni - 1)
                    Return Convert.ToInt32(cad)
                Else
                    Return CInt(Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Value)
                End If
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Value = value
        End Set
    End Property

    Public ReadOnly Property ES_BANCO As Boolean
        Get
            If Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Text.Trim <> "" Then
                If Me.cbxPROVEEDOR_AGRICOLA_BANCOS.Text.Contains("[") Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Get
    End Property

    Public Property ID_PROVEEDOR_VUELO As Int32
        Get
            If Me.cbxPROVEEDOR_VUELO.Value IsNot Nothing Then
                Return CInt(Me.cbxPROVEEDOR_VUELO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxPROVEEDOR_VUELO.Value = value
        End Set
    End Property

    Public Property CODIPROVEEDOR As String
        Get
            If Not Me.speCODIPROVEE.Text = "" Then
                Return Utilerias.FormatearCODIPROVEEDOR(Me.speCODIPROVEE.Value)
            Else
                Return ""
            End If
        End Get
        Set(value As String)
            Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(value)
        End Set
    End Property

    Public Property CODTRANSPORT As Int32
        Get
            If Me.speCODTRANSPORT.Value IsNot Nothing Then
                Return CInt(Me.speCODTRANSPORT.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.speCODTRANSPORT.Value = value
        End Set
    End Property

    Public Property PERIODO As Int32
        Get
            If Me.cbxPERIODO.Value IsNot Nothing Then
                Return CInt(Me.cbxPERIODO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxPERIODO.Value = value
        End Set
    End Property

    Public ReadOnly Property FECHA_INICIAL As String
        Get
            If Me.dteFECHA_INICIAL.Value <> #12:00:00 AM# Then
                Return Me.dteFECHA_INICIAL.Date.ToString("dd/MM/yyyy")
            Else
                Return ""
            End If
        End Get
    End Property

    Public ReadOnly Property FECHA_FINAL As String
        Get
            If Me.dteFECHA_FINAL.Value <> #12:00:00 AM# Then
                Return Me.dteFECHA_FINAL.Date.ToString("dd/MM/yyyy")
            Else
                Return ""
            End If
        End Get
    End Property

    Private Sub CargarProductos()
        Dim lista As listaPRODUCTO

        lista = (New cPRODUCTO).ObtenerListaPorCriterios(-1, -1, -1, -1, 1, 1, "NOMBRE_PRODUCTO")
        If Not (lista IsNot Nothing AndAlso lista.Count > 0) Then
            lista = New listaPRODUCTO
        End If
        Me.cbxPRODUCTO.DataSource = lista
        Me.cbxPRODUCTO.DataBind()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
            If lZafra IsNot Nothing Then Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Me.CargarCatorcenas()
        End If
        Me.CargarProductos()
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaProveedor1.Inicializar()
        Me.pcBusquedaProveedor.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODIPROVEEDOR As String) Handles ucBusquedaProveedor1.Aceptar
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)

        If lProveedor IsNot Nothing Then
            Me.speCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(lProveedor.CODIPROVEEDOR)
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaProveedor1.Cancelar
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Public Property PorCorte_y_PorFechas As Boolean
        Get
            If Me.ViewState("PorCorte_y_PorFechas") IsNot Nothing Then
                Return CBool(Me.ViewState("PorCorte_y_PorFechas"))
            Else
                Return False
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("PorCorte_y_PorFechas") = value
        End Set
    End Property

    Private Sub CargarCatorcenas()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value)
        Dim lista As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, False, "CATORCENA", "DESC")
        If lista Is Nothing Then lista = New listaCATORCENA_ZAFRA
        For i As Int32 = 0 To lista.Count - 1
            lista(i).USUARIO_CIERRE = lista(i).CATORCENA.ToString
        Next
        If PorCorte_y_PorFechas Then
            Dim lCatorcena As New CATORCENA_ZAFRA
            lCatorcena.ID_CATORCENA = -1
            lCatorcena.USUARIO_CIERRE = "[POR PERIODO]"
            lista.Insertar(lista.Count, lCatorcena)
        End If
        Me.cbxCATORCENA_ZAFRA.DataSource = lista
        Me.cbxCATORCENA_ZAFRA.DataBind()
        If Me.cbxCATORCENA_ZAFRA.Items.Count > 0 Then Me.cbxCATORCENA_ZAFRA.SelectedIndex = 0
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarCatorcenas()
    End Sub

    Protected Sub speCODTRANSPORT_NumberChanged(sender As Object, e As EventArgs) Handles speCODTRANSPORT.NumberChanged
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        If speCODTRANSPORT.Value IsNot Nothing Then
            Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(speCODTRANSPORT.Value)
            If lTransportista IsNot Nothing Then Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
        End If
    End Sub
End Class
