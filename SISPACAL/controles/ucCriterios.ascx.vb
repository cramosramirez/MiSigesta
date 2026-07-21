Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Collections.Generic

Partial Class controles_ucCriterios
    Inherits ucBase


#Region "Visibilidad"

    Private Sub CargarTiposDocumentosLey()
        Me.ddlTipoDocumento.Items.Add("COMPROBANTE DE RETENCION 1% IVA")
        Me.ddlTipoDocumento.Items.Add("COMPROBANTE DE RETENCION - NO CONTRIBUYENTES")
        Me.ddlTipoDocumento.Items.Add("CREDITO FISCAL SERVICIOS DEL INGENIO")
        Me.ddlTipoDocumento.Items.Add("FACTURA POR SERVICIOS DEL INGENIO")
    End Sub

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.trID_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CATORCENA.Visible = value
        End Set
    End Property

    Public Property VerCORTE_CATORCENA() As Boolean
        Get
            Return Me.trCORTE_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCORTE_CATORCENA.Visible = value
        End Set
    End Property

    Public Property VerDETALLE_LA_CABANA() As Boolean
        Get
            Return Me.trDETALLE_LA_CABANA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDETALLE_LA_CABANA.Visible = value
        End Set
    End Property

    Public Property VerDIA_ZAFRA_CORTE() As Boolean
        Get
            Return Me.trDIA_ZAFRA_CORTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIA_ZAFRA_CORTE.Visible = value
        End Set
    End Property

    Public Property VerTIPO_TARIFA_CARGADORA() As Boolean
        Get
            Return Me.trTIPO_TARIFA_CARGADORA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_TARIFA_CARGADORA.Visible = value
        End Set
    End Property

    Public Property VerGRUPO_DESCUENTO() As Boolean
        Get
            Return Me.trGRUPO_DESCUENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trGRUPO_DESCUENTO.Visible = value
        End Set
    End Property

    Public Property VerTIPO_PAGO() As Boolean
        Get
            Return Me.trTIPO_PAGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_PAGO.Visible = value
        End Set
    End Property

    Public Property VerFECHAS_EMISION_FACTURACION() As Boolean
        Get
            Return Me.trFECHAS_EMISION_FACTURACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHAS_EMISION_FACTURACION.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CORTE() As Boolean
        Get
            Return Me.trFECHA_CORTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CORTE.Visible = value
        End Set
    End Property

    Public Property VerFECHA_PROGRAMACION_CORTE() As Boolean
        Get
            Return Me.trFECHA_PROGRAMACION_CORTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_PROGRAMACION_CORTE.Visible = value
        End Set
    End Property

    Public Property VerTIPO_DOCUMENTO() As Boolean
        Get
            Return Me.trTIPO_DOCUMENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_DOCUMENTO.Visible = value
        End Set
    End Property

    Public Property VerRANGO_DIAS_ZAFRA() As Boolean
        Get
            Return Me.trRANGO_DIAS_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRANGO_DIAS_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerRANGO_DIAS_ZAFRA_DESCRIP() As Boolean
        Get
            Return Me.trRANGO_DIAS_ZAFRA_DESCRIP.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRANGO_DIAS_ZAFRA_DESCRIP.Visible = value
        End Set
    End Property


    Public Property VerNO_DOCUMENTO_RET_FAC_CCF() As Boolean
        Get
            Return Me.trNO_DOCUMENTO_RET_FAC_CCF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_DOCUMENTO_RET_FAC_CCF.Visible = value
        End Set
    End Property

    Public Property VerDETALLE_PAGINA() As Boolean
        Get
            Return Me.trDETALLE_PAGINA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDETALLE_PAGINA.Visible = value
        End Set
    End Property

    Public Property VerCODICOOPERATIVA() As Boolean
        Get
            Return Me.trCODICOOPERATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODICOOPERATIVA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ENTRADA() As Boolean
        Get
            Return Me.trFECHA_ENTRADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ENTRADA.Visible = value
        End Set
    End Property

    Public Property VerNROBOLETA() As Boolean
        Get
            Return Me.trNROBOLETA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNROBOLETA.Visible = value
        End Set
    End Property

    Public Property VerCOMPTENVIO() As Boolean
        Get
            Return Me.trCOMPTENVIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCOMPTENVIO.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.trCODIPROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerCODISOCIO() As Boolean
        Get
            Return Me.txtCODISOCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblCODISOCIO.Visible = value
            Me.txtCODISOCIO.Visible = value
        End Set
    End Property

    Public Property VerCODTRANSPORT() As Boolean
        Get
            Return Me.trCODTRANSPORT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODTRANSPORT.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR_ROZA() As Boolean
        Get
            Return Me.trPROVEEDOR_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROVEEDOR_ROZA.Visible = value
        End Set
    End Property

    Public Property VerCODIAGRON() As Boolean
        Get
            Return Me.trCODIAGRON.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIAGRON.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_PLANILLA() As Boolean
        Get
            Return Me.trID_TIPO_PLANILLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_PLANILLA.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR_TRANSPORTISTA() As Boolean
        Get
            Return Me.trCODIPROVEEDOR_TRANSPORTISTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR_TRANSPORTISTA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_PROVEEDOR_TRANSPORTISTA() As Boolean
        Get
            Return Me.trNOMBRE_PROVEEDOR_TRANSPORTISTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_PROVEEDOR_TRANSPORTISTA.Visible = value
        End Set
    End Property

    Public Property VerID_PLAN_CATORCENA() As Boolean
        Get
            Return Me.trID_PLAN_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PLAN_CATORCENA.Visible = value
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

    Public Property VerTIPO_CONTRIBUYENTE() As Boolean
        Get
            Return Me.rdbContribuyente.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.rdbContribuyente.Visible = value
        End Set
    End Property

    Public Property VerID_PLAN_SEMANAL() As Boolean
        Get
            Return Me.trID_PLAN_SEMANAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PLAN_SEMANAL.Visible = value
        End Set
    End Property

    Public Property VerRANGO_COMPENSACION() As Boolean
        Get
            Return Me.trRANGO_COMPENSACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRANGO_COMPENSACION.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INICIAL() As Boolean
        Get
            Return Me.trFECHA_INICIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INICIAL.Visible = value
        End Set
    End Property

    Public Property VerFECHA_FINAL() As Boolean
        Get
            Return Me.trFECHA_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_FINAL.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ENTRADA_INICIAL() As Boolean
        Get
            Return Me.trFECHA_ENTRADA_INICIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ENTRADA_INICIAL.Visible = value
        End Set
    End Property

    Public Property VerORDENAMIENTO() As Boolean
        Get
            Return Me.trORDENAMIENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trORDENAMIENTO.Visible = value
        End Set
    End Property

    Public Property VerES_ANTICIPO() As Boolean
        Get
            Return Me.trES_ANTICIPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trES_ANTICIPO.Visible = value
        End Set
    End Property

    Public Property VerCLASIFICACION() As Boolean
        Get
            Return Me.trCLASIFICACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCLASIFICACION.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ENTRADA_FINAL() As Boolean
        Get
            Return Me.trFECHA_ENTRADA_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ENTRADA_FINAL.Visible = value
        End Set
    End Property


    Public Property VerID_TIPO_PROVEEDOR() As Boolean
        Get
            Return Me.trTIPO_PROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_PROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_CLIENTE() As Boolean
        Get
            Return Me.trCODIGO_CLIENTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_CLIENTE.Visible = value
        End Set
    End Property

    Public Property VerPLACA() As Boolean
        Get
            Return Me.trPLACA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPLACA.Visible = value
        End Set
    End Property

    Public Property VerID_PRODUCTO() As Boolean
        Get
            Return Me.trPRODUCTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPRODUCTO.Visible = value
        End Set
    End Property

    Public Property VerMOSTRAR_FAC_CCF() As Boolean
        Get
            Return Me.trMOSTRAR_FAC_CCF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOSTRAR_FAC_CCF.Visible = value
        End Set
    End Property

    Public Property MostrarCatorcenaActiva As Boolean
        Get
            If Me.ViewState("ID_CATORCENA_ACTIVA") Is Nothing Then
                Return False
            Else
                Return Me.ViewState("ID_CATORCENA_ACTIVA")
            End If
        End Get
        Set(value As Boolean)
            'Me.ddlCATORCENA_ZAFRA1.RecuperarCatorcenaActiva(ddlZAFRAID_ZAFRA.SelectedValue)
            Me.ViewState("ID_CATORCENA_ACTIVA") = value
        End Set
    End Property

    Public Property NombreFechaEntradaInicial As String
        Get
            Return Me.txtFECHA_ENTRADA_INICIAL.Text
        End Get
        Set(ByVal value As String)
            Me.txtFECHA_ENTRADA_INICIAL.Text = value
        End Set
    End Property

#End Region

#Region "Valores en Propiedades"
    Public Property ID_ZAFRA() As Integer
        Get
            If Me.ddlZAFRAID_ZAFRA.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlZAFRAID_ZAFRA.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlZAFRAID_ZAFRA.SelectedValue = value
        End Set
    End Property

    Private _ID_CATORCENA As Integer = 0
    Public Property ID_CATORCENA() As Integer
        Get
            If Me.ddlCATORCENA_ZAFRA1.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlCATORCENA_ZAFRA1.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlCATORCENA_ZAFRA1.SelectedValue = value
            _ID_CATORCENA = value
        End Set
    End Property

    Public ReadOnly Property CORTE_CATORCENA() As String
        Get
            If Me.ddlCORTE_CATORCENA_ZAFRA.Items.Count > 0 Then
                Return Me.ddlCORTE_CATORCENA_ZAFRA.Items(0).Text
            Else
                Return ""
            End If
        End Get
    End Property

    Public ReadOnly Property CATORCENA() As String
        Get
            If Me.ddlCATORCENA_ZAFRA1.Text Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlCATORCENA_ZAFRA1.Text
            End If
        End Get
    End Property

    Public Property ID_PLAN_CATORCENA() As Integer
        Get
            If Me.ddlPLAN_CATORCENA1.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlPLAN_CATORCENA1.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlPLAN_CATORCENA1.SelectedValue = value
        End Set
    End Property

    Public Property TIPO_PAGO() As Integer
        Get
            If Me.ddlTIPO_PAGO.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlTIPO_PAGO.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlTIPO_PAGO.SelectedValue = value
        End Set
    End Property

    Public Property ID_RANGO_COMPE() As Integer
        Get
            If Me.ddlRANGO_COMPENSACION1.SelectedValue Is Nothing Then
                Return -1
            Else
                Return Me.ddlRANGO_COMPENSACION1.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlRANGO_COMPENSACION1.SelectedValue = value
        End Set
    End Property

    Public Property TIPO_DOCUMENTO() As Integer
        Get
            Return Me.ddlTipoDocumento.SelectedIndex + 1
        End Get
        Set(ByVal value As Integer)
            Me.ddlTipoDocumento.SelectedValue = (value - 1)
        End Set
    End Property

    Public Property NO_DOCUMENTO_INICIAL() As String
        Get
            Return Me.txtNO_DOCUMENTO_INICIAL.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtNO_DOCUMENTO_INICIAL.Text = value
        End Set
    End Property

    Public Property DETALLE_POR_PAGINA() As Boolean
        Get
            Return chkDetallePagina.Checked
        End Get
        Set(ByVal value As Boolean)
            chkDetallePagina.Checked = value
        End Set
    End Property

    Public Property DETALLE_LA_CABANA() As Boolean
        Get
            Return chkDetalleLaCabana.Checked
        End Get
        Set(ByVal value As Boolean)
            chkDetalleLaCabana.Checked = value
        End Set
    End Property

    Public Property TIPO_PLANILLA() As Int32
        Get
            Return Me.rblTipoPlanilla.SelectedValue
        End Get
        Set(ByVal value As Int32)
            Me.rblTipoPlanilla.SelectedValue = value
        End Set
    End Property

    Public Property ZONA() As String
        Get
            If Me.ddlZONAS1.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlZONAS1.SelectedValue
            End If
        End Get
        Set(ByVal value As String)
            Me.ddlZONAS1.SelectedValue = value
        End Set
    End Property

    Public Property ID_PLAN_SEMANAL() As Integer
        Get
            If Me.ddlPLAN_SEMANAL1.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlPLAN_SEMANAL1.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlPLAN_SEMANAL1.SelectedValue = value
        End Set
    End Property

    Public ReadOnly Property CAMPO_ORDEN() As String
        Get
            Return Me.ddlCamposOrdenamiento.SelectedValue
        End Get
    End Property
    Public ReadOnly Property TIPO_ORDEN() As String
        Get
            Return Me.ddlTipoOrden.SelectedValue
        End Get
    End Property

    Public Property ES_POSTBACK() As Boolean
        Set(value As Boolean)
            Me.ViewState("es_postback") = value
        End Set
        Get
            If Me.ViewState("es_postback") Is Nothing Then
                Return False
            Else
                Return Me.ViewState("es_postback")
            End If
        End Get
    End Property

    Public ReadOnly Property CLASIFICACION() As String
        Get
            Return Me.ddlClasificacion.SelectedValue
        End Get
    End Property

    Public Property ID_TIPO_PLANILLA() As Integer
        Get
            If Me.ddlTIPO_PLANILLA1.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlTIPO_PLANILLA1.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlTIPO_PLANILLA1.SelectedValue = value
        End Set
    End Property

    Public Property FECHA_CORTE() As Date
        Get
            Dim fecha As Date
            If System.DateTime.TryParse(Me.txtFECHA_CORTE.Text, _
                   New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fecha) Then
                Return fecha
            Else
                Return #12:00:00 AM#
            End If
        End Get
        Set(ByVal value As Date)
            If value <> #12:00:00 AM# Then
                Me.txtFECHA_CORTE.Text = value.ToString("dd/MM/yyyy")
            Else
                Me.txtFECHA_CORTE.Text = ""
            End If
        End Set
    End Property

    Public Property FECHA_ENTRADA() As Date
        Get
            Dim fecha As Date
            If System.DateTime.TryParse(Me.txtFECHA_ENTRADA.Text, _
                   New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fecha) Then
                Return fecha
            Else
                Return #12:00:00 AM#
            End If
        End Get
        Set(ByVal value As Date)
            If value <> #12:00:00 AM# Then
                Me.txtFECHA_ENTRADA.Text = value.ToString("dd/MM/yyyy")
            Else
                Me.txtFECHA_ENTRADA.Text = ""
            End If
        End Set
    End Property

    Public Property FECHA_ENTRADA_INICIAL() As Date
        Get
            Dim fecha As Date
            If System.DateTime.TryParse(Replace(Me.txtFECHA_ENTRADA_INICIAL.Text, ".", ""), _
                   New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fecha) Then
                Return fecha
            Else
                Return #12:00:00 AM#
            End If
        End Get
        Set(ByVal value As Date)
            If value <> #12:00:00 AM# Then
                Me.txtFECHA_ENTRADA_INICIAL.Text = value.ToString("dd/MM/yyyy hh:mm tt")
            Else
                Me.txtFECHA_ENTRADA_INICIAL.Text = ""
            End If
        End Set
    End Property

    Public Property FECHA_ENTRADA_FINAL() As Date
        Get
            Dim fecha As Date
            If System.DateTime.TryParse(Replace(Me.txtFECHA_ENTRADA_FINAL.Text, ".", ""), _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fecha) Then
                Return fecha
            Else
                Return #12:00:00 AM#
            End If
        End Get
        Set(ByVal value As Date)
            If value <> #12:00:00 AM# Then
                Me.txtFECHA_ENTRADA_FINAL.Text = value.ToString("dd/MM/yyyy hh:mm tt")
            Else
                Me.txtFECHA_ENTRADA_FINAL.Text = ""
            End If
        End Set
    End Property

    Public Property FECHA_PROGRAMACION_CORTE_NOMBRE() As String
        Get
            Return lblFECHA_PROGRAMACION_CORTE.Text
        End Get
        Set(ByVal value As String)
            lblFECHA_PROGRAMACION_CORTE.Text = value
        End Set
    End Property

    Public Property FECHA_PROGRAMACION_CORTE() As Date
        Get
            Dim fecha As Date
            If System.DateTime.TryParse(Replace(Me.txtFECHA_PROGRAMACION_CORTE.Text, ".", ""), _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fecha) Then
                Return fecha
            Else
                Return #12:00:00 AM#
            End If
        End Get
        Set(ByVal value As Date)
            If value <> #12:00:00 AM# Then
                Me.txtFECHA_PROGRAMACION_CORTE.Text = value.ToString("dd/MM/yyyy hh:mm tt")
            Else
                Me.txtFECHA_PROGRAMACION_CORTE.Text = ""
            End If
        End Set
    End Property




    Public Property FECHA_INICIAL() As Date
        Get
            Dim fecha As Date
            If System.DateTime.TryParse(Me.txtFECHA_INICIAL.Text, _
                   New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fecha) Then
                Return fecha
            Else
                Return #12:00:00 AM#
            End If
        End Get
        Set(ByVal value As Date)
            If value <> #12:00:00 AM# Then
                Me.txtFECHA_INICIAL.Text = value.ToString("dd/MM/yyyy")
            Else
                Me.txtFECHA_INICIAL.Text = ""
            End If
        End Set
    End Property

    Public Property FECHA_FINAL() As Date
        Get
            Dim fecha As Date
            If System.DateTime.TryParse(Me.txtFECHA_FINAL.Text, _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fecha) Then
                Return fecha
            Else
                Return #12:00:00 AM#
            End If
        End Get
        Set(ByVal value As Date)
            If value <> #12:00:00 AM# Then
                Me.txtFECHA_FINAL.Text = value.ToString("dd/MM/yyyy")
            Else
                Me.txtFECHA_FINAL.Text = ""
            End If
        End Set
    End Property

    Public Property NROBOLETA() As Integer
        Get
            If Me.txtNROBOLETA.Text.Trim = "" Then
                Return -1
            Else
                Return Convert.ToInt32(Me.txtNROBOLETA.Text)
            End If
        End Get
        Set(ByVal value As Integer)
            Me.txtNROBOLETA.Text = value.ToString()
        End Set
    End Property

    Public Property CODIGO_CLIENTE() As String
        Get
            Return Me.txtCODIGO.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtCODIGO.Text = value.ToString()
        End Set
    End Property

    Public Property PLACA() As String
        Get
            Return Me.txtPLACA.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtPLACA.Text = value.ToString()
        End Set
    End Property

    Public Property CODICOOPERATIVA() As String
        Get
            Return Me.txtCODICOOPERATIVA.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtCODICOOPERATIVA.Text = value
        End Set
    End Property

    Public Property FECHA_EMISION_FACTURACION() As Integer
        Get
            Return Me.rbtnFechasEmisionFacturacion.SelectedValue
        End Get
        Set(ByVal value As Integer)
            Me.rbtnFechasEmisionFacturacion.SelectedValue = value
        End Set
    End Property

    Public Property FORMATO_VALES() As Integer
        Get
            Return Me.ddlFormatoCombustible.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            Me.ddlFormatoCombustible.SelectedIndex = value
        End Set
    End Property

    Public Property COMPTENVIO() As Integer
        Get
            If Me.txtCOMPTENVIO.Text.Trim = "" Then
                Return -1
            Else
                Return Convert.ToInt32(Me.txtCOMPTENVIO.Text)
            End If
        End Get
        Set(ByVal value As Integer)
            Me.txtCOMPTENVIO.Text = value.ToString()
        End Set
    End Property

    Public Property CODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return Me.txtCODIPROVEEDOR_TRANSPORTISTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEEDOR_TRANSPORTISTA.Text = value.ToString()
        End Set
    End Property

    Public Property CODIPROVEEDOR() As String
        Get
            Return Me.txtCODIPROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEEDOR.Text = value.ToString()
        End Set
    End Property

    Public Property CODISOCIO() As String
        Get
            Return Me.txtCODISOCIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODISOCIO.Text = value.ToString()
        End Set
    End Property

    Public Property CODTRANSPORT() As String
        Get
            Return Me.txtCODTRANSPORT.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODTRANSPORT.Text = value.ToString()
        End Set
    End Property

    Public Property CODIAGRON() As String
        Get
            Return Me.txtCODIAGRON.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIAGRON.Text = value.ToString()
        End Set
    End Property

    Public Property ES_CONTRIBUYENTE() As Boolean
        Get
            Return Me.rdbContribuyente.SelectedValue
        End Get
        Set(ByVal value As Boolean)
            Me.rdbContribuyente.SelectedValue = value
        End Set
    End Property

    Public Property NOMBRE_PROVEEDOR_TRANSPORTISTA As String
        Get
            Return Me.txtNOMBRE_PROVEEDOR_TRANSPORTISTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROVEEDOR_TRANSPORTISTA.Text = value
        End Set
    End Property

    Public Property ID_TIPO_PROVEEDOR() As Integer
        Get
            If Me.ddlTIPO_PROVEEDOR1.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlTIPO_PROVEEDOR1.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlTIPO_PROVEEDOR1.SelectedValue = value
        End Set
    End Property

    Public Property ID_GRUPO_DESC() As Integer
        Get
            If Me.cbxGRUPO_DESCUENTOS.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxGRUPO_DESCUENTOS.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxGRUPO_DESCUENTOS.Value = value
        End Set
    End Property


    Public Property TIPO_TARIFA_CARGADORA() As Integer
        Get
            Return Me.ddlTipoTarifaCargadora.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            Me.ddlTipoTarifaCargadora.SelectedIndex = value
        End Set
    End Property

    Public Property ID_PRODUCTO() As Integer
        Get
            If Me.ddlPRODUCTO_COMBUSTIBLE1.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlPRODUCTO_COMBUSTIBLE1.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlPRODUCTO_COMBUSTIBLE1.SelectedValue = value
        End Set
    End Property

    Public Property ID_PROVEEDOR_ROZA() As Integer
        Get
            If Me.ddlPROVEEDOR_ROZA1.SelectedValue Is Nothing Then
                Return Nothing
            Else
                Return Me.ddlPROVEEDOR_ROZA1.SelectedValue
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ddlPROVEEDOR_ROZA1.SelectedValue = value
        End Set
    End Property

    Public Property CON_FAC_CCF() As Boolean
        Get
            Return chkMostrarFAC_CCF.Checked
        End Get
        Set(ByVal value As Boolean)
            chkMostrarFAC_CCF.Checked = value
        End Set
    End Property

    Public Property DIA_ZAFRA_CORTE() As Integer
        Get
            Return ddlDIA_ZAFRA_CORTE.SelectedValue
        End Get
        Set(ByVal value As Integer)
            ddlDIA_ZAFRA_CORTE.SelectedValue = value
        End Set
    End Property


    Public Property DIA_ZAFRA_A() As Integer
        Get
            Return ddlDIA_ZAFRA_A.SelectedValue
        End Get
        Set(ByVal value As Integer)
            ddlDIA_ZAFRA_A.SelectedValue = value
        End Set
    End Property

    Public Property DIA_ZAFRA_B() As Integer
        Get
            Return ddlDIA_ZAFRA_B.SelectedValue
        End Get
        Set(ByVal value As Integer)
            ddlDIA_ZAFRA_B.SelectedValue = value
        End Set
    End Property

    Public Property DIA_ZAFRA_INICIAL() As Integer
        Get
            If Me.ddlDIA_ZAFRA_INI.SelectedItem IsNot Nothing AndAlso Utilerias.EsNumeroEntero(Me.ddlDIA_ZAFRA_INI.SelectedItem.Text) Then Return CInt(Me.ddlDIA_ZAFRA_INI.SelectedItem.Text) Else Return 0
        End Get
        Set(ByVal value As Integer)
            ddlDIA_ZAFRA_INI.SelectedValue = ddlDIA_ZAFRA_INI.Items.FindByText(value).Value
        End Set
    End Property

    Public Property DIA_ZAFRA_FINAL() As Integer
        Get
            If Me.ddlDIA_ZAFRA_FIN.SelectedItem IsNot Nothing AndAlso Utilerias.EsNumeroEntero(Me.ddlDIA_ZAFRA_FIN.SelectedItem.Text) Then Return CInt(Me.ddlDIA_ZAFRA_FIN.SelectedItem.Text) Else Return 0
        End Get
        Set(ByVal value As Integer)
            ddlDIA_ZAFRA_FIN.SelectedValue = ddlDIA_ZAFRA_INI.Items.FindByText(value).Value
        End Set
    End Property
#End Region

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        End If
    End Sub

    Public Sub AsignarCamposOrdenamiento(ByVal lista As List(Of CampoOrdenamiento))
        Me.ViewState("CamposOrdenamiento") = lista
        CargarCamposOrdenamiento()
    End Sub

    Public Sub AsignarClasificacion(ByVal lista As List(Of CampoOrdenamiento))
        Me.ViewState("Clasificacion") = lista
        CargarClasificacion()
    End Sub

    Private Sub CargarCamposOrdenamiento()
        If Me.ViewState("CamposOrdenamiento") IsNot Nothing Then
            Me.ddlCamposOrdenamiento.DataValueField = "Campo"
            Me.ddlCamposOrdenamiento.DataTextField = "Descripcion"
            Me.ddlCamposOrdenamiento.DataSource = Me.ViewState("CamposOrdenamiento")
            Me.ddlCamposOrdenamiento.DataBind()
            Me.CargarTipoOrden()
        End If
    End Sub

    Private Sub CargarClasificacion()
        If Me.ViewState("Clasificacion") IsNot Nothing Then
            Me.ddlClasificacion.DataValueField = "Campo"
            Me.ddlClasificacion.DataTextField = "Descripcion"
            Me.ddlClasificacion.DataSource = Me.ViewState("Clasificacion")
            Me.ddlClasificacion.DataBind()
        End If
    End Sub

    Private Sub CargarTipoOrden()

        Dim listaTipoOrden As New List(Of TipoOrden)
        listaTipoOrden.Add(New TipoOrden(SortOrder.Ascending, "Ascendente"))
        listaTipoOrden.Add(New TipoOrden(SortOrder.Descending, "Descendente"))

        Me.ddlTipoOrden.DataValueField = "Valor"
        Me.ddlTipoOrden.DataTextField = "Descripcion"
        Me.ddlTipoOrden.DataSource = listaTipoOrden
        Me.ddlTipoOrden.DataBind()
    End Sub

    Private Sub CargarTipoTarifaCargadora()
        Me.ddlTipoTarifaCargadora.Items.Clear()
        Me.ddlTipoTarifaCargadora.Items.Add("CARGA SIN TRIPULACION")
        Me.ddlTipoTarifaCargadora.Items.Add("CARGA CON TRIPULACION")
    End Sub

    Private Sub CargarFormatoCombustible()
        Me.ddlFormatoCombustible.Items.Clear()
        Me.ddlFormatoCombustible.Items.Add("LISTA DE VALES")
        Me.ddlFormatoCombustible.Items.Add("AGRUPADO POR TIPO PROVEEDOR")
        Me.ddlFormatoCombustible.Items.Add("AGRUPADO POR PRODUCTO")
        Me.ddlFormatoCombustible.Items.Add("AGRUPADO POR PLACA")
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        If lZafra IsNot Nothing Then ddlZAFRAID_ZAFRA.SelectedValue = lZafra.ID_ZAFRA

        If lZafra IsNot Nothing Then
            'Recuperar catorcena por Zafra
            Me.ddlCATORCENA_ZAFRA1.RecuperarPorZAFRA(lZafra.ID_ZAFRA, True, False)
            Me.ddlCORTE_CATORCENA_ZAFRA.RecuperarCatorcenaActiva(ddlZAFRAID_ZAFRA.SelectedValue)
            Me.ddlDIA_ZAFRA_CORTE.RecuperarDiaZafraActivo(ddlZAFRAID_ZAFRA.SelectedValue)
            Dim lCatorcena As CATORCENA_ZAFRA
            lCatorcena = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ddlZAFRAID_ZAFRA.SelectedValue)
            If lCatorcena IsNot Nothing Then Me.ddlCATORCENA_ZAFRA1.SelectedValue = lCatorcena.ID_CATORCENA

            Me.ddlPLAN_CATORCENA1.RecuperarPorZAFRA(lZafra.ID_ZAFRA)
            If Me.ddlPLAN_CATORCENA1.Items.Count > 0 Then Me.ddlPLAN_SEMANAL1.RecuperarPorPLAN_CATORCENA(Me.ddlPLAN_CATORCENA1.SelectedValue, False, True)
            Dim listaDiaZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(lZafra.ID_ZAFRA, False, "FECHA", "DESC")
            If listaDiaZafra IsNot Nothing AndAlso listaDiaZafra.Count > 0 Then
                Me.txtFECHA_CORTE.Text = listaDiaZafra(0).FECHA.ToString("dd/MM/yyyy")
            End If

            Me.ddlPROVEEDOR_ROZA1.Recuperar(False, True)

            Me.ddlDIA_ZAFRA_INI.RecuperarPorZAFRA(ddlZAFRAID_ZAFRA.SelectedValue)
            Me.ddlDIA_ZAFRA_FIN.RecuperarPorZAFRA(ddlZAFRAID_ZAFRA.SelectedValue)
            Me.ddlDIA_ZAFRA_FIN.SelectedIndex = Me.ddlDIA_ZAFRA_FIN.Items.Count - 1

            Me.ddlDIA_ZAFRA_A.RecuperarDiaZafraFechaCierre(ddlZAFRAID_ZAFRA.SelectedValue)
            Me.ddlDIA_ZAFRA_B.RecuperarDiaZafraFechaCierre(ddlZAFRAID_ZAFRA.SelectedValue)
            Me.ddlDIA_ZAFRA_B.SelectedIndex = Me.ddlDIA_ZAFRA_B.Items.Count - 1
        End If
        Me.ddlTIPO_PLANILLA1.Recuperar()
        Me.ddlZONAS1.Recuperar()
        Me.ddlTIPO_PROVEEDOR1.RecuperarParaCombustible(False, False)
        Me.ddlPRODUCTO_COMBUSTIBLE1.Recuperar(False, True)
        Me.CargarTiposDocumentosLey()
        Me.CargarCamposOrdenamiento()
        Me.CargarTipoTarifaCargadora()
        Me.CargarFormatoCombustible()
        Me.CargarClasificacion()
        If _ID_CATORCENA <> 0 Then ddlCATORCENA_ZAFRA1.SelectedValue = _ID_CATORCENA
    End Sub


    Protected Sub ddlZAFRAID_ZAFRA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlZAFRAID_ZAFRA.SelectedIndexChanged
        Dim lZafra As ZAFRA
        Dim lCatorcena As CATORCENA_ZAFRA

        lZafra = (New cZAFRA).ObtenerZAFRA(ddlZAFRAID_ZAFRA.SelectedValue)
        Me.ddlCATORCENA_ZAFRA1.RecuperarPorZAFRA(ddlZAFRAID_ZAFRA.SelectedValue, True, False)
        Me.ddlPLAN_CATORCENA1.RecuperarPorZAFRA(ddlZAFRAID_ZAFRA.SelectedValue)
        Me.ddlCORTE_CATORCENA_ZAFRA.RecuperarCatorcenaActiva(ddlZAFRAID_ZAFRA.SelectedValue)
        lCatorcena = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ddlZAFRAID_ZAFRA.SelectedValue)
        If lCatorcena IsNot Nothing Then Me.ddlCATORCENA_ZAFRA1.SelectedValue = lCatorcena.ID_CATORCENA

        Me.ddlDIA_ZAFRA_INI.RecuperarPorZAFRA(ddlZAFRAID_ZAFRA.SelectedValue)
        Me.ddlDIA_ZAFRA_FIN.RecuperarPorZAFRA(ddlZAFRAID_ZAFRA.SelectedValue)
        Me.ddlDIA_ZAFRA_FIN.SelectedIndex = Me.ddlDIA_ZAFRA_FIN.Items.Count - 1

        If lZafra IsNot Nothing AndAlso Not lZafra.ACTIVA Then
            Me.txtFECHA_INICIAL.Text = Format(lZafra.FECHA_INICIO, "dd/MM/yyyy")
            Me.txtFECHA_FINAL.Text = Format(lZafra.FECHA_FINAL, "dd/MM/yyyy")
        End If
    End Sub

    Protected Sub ddlPLAN_CATORCENA1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlPLAN_CATORCENA1.SelectedIndexChanged
        Me.ddlPLAN_SEMANAL1.RecuperarPorPLAN_CATORCENA(ddlPLAN_CATORCENA1.SelectedValue, False, True)
    End Sub

    Protected Sub ddlCATORCENA_ZAFRA1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlCATORCENA_ZAFRA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub ConfigRangoCompensacion()
        ES_POSTBACK = True
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana Then
            Me.ddlCATORCENA_ZAFRA1.AutoPostBack = True
            Me.trRANGO_COMPENSACION.Visible = True
            If Me.ddlCATORCENA_ZAFRA1.SelectedValue IsNot Nothing Then
                Me.ddlRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(Me.ddlCATORCENA_ZAFRA1.SelectedValue)
            Else
                Me.ddlRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(-1)
            End If
        Else
            Me.ddlCATORCENA_ZAFRA1.AutoPostBack = False
            Me.trRANGO_COMPENSACION.Visible = False
        End If
    End Sub

    Protected Sub ddlTIPO_PLANILLA1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlTIPO_PLANILLA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub
  
    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaProveedor1.Inicializar()
        Me.pcBusquedaProveedor.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODIPROVEEDOR As String) Handles ucBusquedaProveedor1.Aceptar
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)

        If lProveedor IsNot Nothing Then
            Me.txtCODIPROVEEDOR.Text = Utilerias.RecuperarCODIPROVEE(lProveedor.CODIPROVEEDOR)
            Me.txtCODISOCIO.Text = Utilerias.RecuperarCODISOCIO(lProveedor.CODIPROVEEDOR)
        End If
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaProveedor1.Cancelar
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub
End Class
