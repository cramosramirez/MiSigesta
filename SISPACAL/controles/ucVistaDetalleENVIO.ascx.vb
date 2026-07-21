Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Collections.Generic

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleENVIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ENVIO
''' </summary>
''' <remarks>
''' ***
''' </remarks>
''' <history>
''' 	[GenApp]	02/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleENVIO
    Inherits ucBase

    Private _ListaLotes As New listaLOTES
 
#Region "Propiedades"

    Private _ID_ENVIO As Int32
    Private _txtPLACA_VEHIC_DropDownExtender As Object

    Public Property ID_ENVIO() As Int32
        Get
            Return Me.txtID_ENVIO.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ENVIO = Value
            Me.txtID_ENVIO.Text = CStr(Value)
            If Me._ID_ENVIO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private Property TIPO_CANA_CON_QUEMA As List(Of Integer)
        Get
            Return Me.ViewState("TIPO_CANA_CON_QUEMA")
        End Get
        Set(value As List(Of Integer))
            Me.ViewState("TIPO_CANA_CON_QUEMA") = value
        End Set
    End Property


    Public Property TIPO_OPERACION As TipoOperacion
        Get
            If Me.ViewState("TIPO_OPERACION") Is Nothing Then
                Return TipoOperacion.Recepcion
            Else
                Return Me.ViewState("TIPO_OPERACION")
            End If
        End Get
        Set(ByVal value As TipoOperacion)
            Me.ViewState("TIPO_OPERACION") = value
            If value = TipoOperacion.Recepcion Then
                Me._ID_ENVIO = 0
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(Me._Enabled)
            ElseIf value = TipoOperacion.Edicion OrElse value = TipoOperacion.Consulta OrElse value = TipoOperacion.EdicionParcialBascula OrElse value = TipoOperacion.Eliminacion OrElse value = TipoOperacion.Anulacion Then
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(False)
            End If
            Me.txtNROBOLETA.Focus()
        End Set
    End Property


    Public Property ID_ZAFRA() As Int32
        Get
            Return Me.ddlZAFRAID_ZAFRA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlZAFRAID_ZAFRA.Items.FindByValue(value) Is Nothing Then
                Me.ddlZAFRAID_ZAFRA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_CATORCENA() As Int32
        Get
            Return Convert.ToInt32(Me.txtCATORCENA_ZAFRA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtCATORCENA_ZAFRA.Text = value.ToString
        End Set
    End Property

    Public Property DIAZAFRA() As Int32
        Get
            If Me.txtDIAZAFRA.Text = "" Then Return -1
            Return CInt(Me.txtDIAZAFRA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtDIAZAFRA.Text = value.ToString()
        End Set
    End Property

    Public Property CODICONTRATO() As String
        Get
            If Me.ViewState("CODICONTRATO") Is Nothing Then
                Return ""
            Else
                Return Me.ViewState("CODICONTRATO")
            End If
        End Get
        Set(ByVal value As String)
            Me.ViewState("CODICONTRATO") = Me.ddlZAFRAID_ZAFRA.SelectedItem.Text & StrDup(4 - value.Length, "0") & value
        End Set
    End Property

    Public Property CODIPROVEEDOR() As String
        Get
            Return Me.txtCODIPROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEEDOR.Text = value
        End Set
    End Property

    Public Property COMPTENVIO() As Int32
        Get
            If Me.txtCOMPTENVIO.Text = "" Then Return -1
            Return CInt(Me.txtCOMPTENVIO.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtCOMPTENVIO.Text = value.ToString()
        End Set
    End Property

    Public Property CODTRANSPORT() As Int32
        Get
            Return Me.txtCODTRANSPORT.Text
        End Get
        Set(ByVal value As Int32)
            Me.txtCODTRANSPORT.Text = value.ToString
        End Set
    End Property

    Public Property PLACAVEHIC() As String
        Get
            Return Me.txtPLACA_VEHIC.Text
        End Get
        Set(ByVal value As String)
            txtPLACA_VEHIC.Text = value
        End Set
    End Property

    Public Property ID_CARGADOR() As Int32
        Get
            If Me.txtID_CARGADOR.Text = "" Then
                Return -1
            Else
                Return Convert.ToInt32(Me.txtID_CARGADOR.Text)
            End If
        End Get
        Set(ByVal value As Int32)
            Me.txtID_CARGADOR.Text = value
        End Set
    End Property

    Public Property ID_TIPO_CANA() As Int32
        Get
            Return Me.ddlTIPO_CANAID_TIPO_CANA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlTIPO_CANAID_TIPO_CANA.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_CANAID_TIPO_CANA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property TIPO_TRANSPORTE() As Int32
        Get
            Return Me.ddlTIPO_TRANSPORTE1.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlTIPO_TRANSPORTE1.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_TRANSPORTE1.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_CARGADORA() As Int32
        Get
            Return Me.txtID_CARGADORA.Text
        End Get
        Set(ByVal value As Int32)
            Me.txtID_CARGADORA.Text = value.ToString
        End Set
    End Property

    Public Property ID_SUPERVISOR() As Int32
        Get
            Return Me.ddlSUPERVISORID_SUPERVISOR.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlSUPERVISORID_SUPERVISOR.Items.FindByValue(value) Is Nothing Then
                Me.ddlSUPERVISORID_SUPERVISOR.SelectedValue = value
            End If
        End Set
    End Property

    Public Property FECHA_QUEMA() As DateTime
        Get
            Return Me.txtFECHA_QUEMA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_QUEMA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property FECHA_CORTA() As DateTime
        Get
            Return Me.txtFECHA_CORTA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_CORTA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property QUEMAPROG() As Boolean
        Get
            Return Me.cbxQUEMAPROG.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxQUEMAPROG.Checked = value
        End Set
    End Property

    Public Property FECHA_CARGA() As DateTime
        Get
            Return Me.txtFECHA_CARGA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_CARGA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property FECHA_PATIO() As DateTime
        Get
            Return Me.txtFECHA_PATIO.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_PATIO.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property NROBOLETA() As Int32
        Get
            If Me.txtNROBOLETA.Text = "" Then Return -1
            Return CInt(Me.txtNROBOLETA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNROBOLETA.Text = value.ToString()
        End Set
    End Property

    Public Property MADURANTE() As Boolean
        Get
            Return Me.cbxMADURANTE.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxMADURANTE.Checked = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cENVIO
    Private mEntidad As ENVIO
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Property txtPLACA_VEHIC_DropDownExtender As Object
        Get
            Return _txtPLACA_VEHIC_DropDownExtender
        End Get
        Set(value As Object)
            _txtPLACA_VEHIC_DropDownExtender = value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ENVIO") Is Nothing Then Me._ID_ENVIO = Me.ViewState("ID_ENVIO")

        If Not IsPostBack Then
            CargarTipoCanaQuemada()
        End If
    End Sub

    Private Sub CargarTipoCanaQuemada()
        Dim lista As New List(Of Integer)
        lista.Add(27)
        lista.Add(43)
        TIPO_CANA_CON_QUEMA = lista
    End Sub

    Private Function EsNumero(ByVal mensaje As String, ByVal valor As String) As Boolean
        If Not IsNumeric(valor) Then
            AsignarMensaje(mensaje, True)
            Return False
        End If
        Return True
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ENVIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lTransportista As TRANSPORTISTA
        Dim lProveedor As PROVEEDOR
        Dim lCargadora As CARGADORA
        Dim lCargador As CARGADOR
        Dim lContrato As CONTRATO

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ENVIO
        mEntidad.ID_ENVIO = ID_ENVIO

        If mComponente.ObtenerENVIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ENVIO.Text = mEntidad.ID_ENVIO.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.txtCATORCENA_ZAFRA.Text = mEntidad.CATORCENA
        Me.txtDIAZAFRA.Text = mEntidad.DIAZAFRA
        Me.txtCOMPTENVIO.Text = mEntidad.COMPTENVIO
        Me.txtCODICONTRATO.Text = mEntidad.CODICONTRATO
        Me.ViewState("CODICONTRATO") = mEntidad.CODICONTRATO
        lContrato = (New cCONTRATO).ObtenerCONTRATO(mEntidad.CODICONTRATO)
        Me.txtCODIPROVEEDOR.Text = mEntidad.CODIPROVEEDOR
        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lContrato.CODIPROVEEDOR)
        Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
        Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(mEntidad.ACCESLOTE)
        If lLote IsNot Nothing AndAlso lContrato IsNot Nothing AndAlso lLote.CODIPROVEEDOR <> lContrato.CODIPROVEEDOR Then
            Dim lSocio As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
            If lSocio IsNot Nothing Then Me.txtNOMPROVEEDOR.Text += ("   SOCIO: " + lSocio.NOMBRES + " " + lSocio.APELLIDOS)
        End If
        Me.txtCODTRANSPORT.Text = mEntidad.CODTRANSPORT
        lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(mEntidad.CODTRANSPORT)
        Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
        Me.txtPLACA_VEHIC.Text = mEntidad.PLACAVEHIC
        RecuperarPlacasPorTransportista(mEntidad.CODTRANSPORT)
        Me.txtNOMBRES_MOTORISTA.Text = mEntidad.NOMBRES_MOTORISTA
        If lstTRANSPORTE.Items.FindByText(mEntidad.PLACAVEHIC) IsNot Nothing Then
            lstTRANSPORTE.Items.FindByText(mEntidad.PLACAVEHIC).Selected = True
            Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(mEntidad.CODTRANSPORT), mEntidad.PLACAVEHIC)
            If lTransporte IsNot Nothing Then
                RecuperarMotoristaPorTransporte(lTransporte.ID_TRANSPORTE)
                If lstMOTORISTA.Items.FindByText(Me.txtNOMBRES_MOTORISTA.Text) IsNot Nothing Then
                    lstMOTORISTA.Items.FindByText(Me.txtNOMBRES_MOTORISTA.Text).Selected = True
                End If
            End If
        End If
        Me.ddlTIPO_TRANSPORTE1.SelectedValue = mEntidad.ID_TIPOTRANS
        Me.txtID_CARGADORA.Text = mEntidad.ID_CARGADORA
        lCargadora = (New cCARGADORA).ObtenerCARGADORA(mEntidad.ID_CARGADORA)
        Me.txtNOMBRE_CARGADORA.Text = lCargadora.NOMBRE
        lCargador = (New cCARGADOR).ObtenerCARGADOR(mEntidad.ID_CARGADOR)
        Me.txtID_CARGADOR.Text = mEntidad.ID_CARGADOR
        If lCargador IsNot Nothing Then Me.txtNOMBRE_CARGADOR.Text = lCargador.NOMBRE_CARGADOR
        CargarTipoTarifaCargadora(mEntidad.ID_CARGADORA)
        If Me.ddlTipoTarifaCargadora.Items.Count > 0 Then Me.ddlTipoTarifaCargadora.SelectedIndex = mEntidad.TIPO_TARIFA_CARGADORA
        If lCargadora.ID_TIPO_CARGADORA = 2 Then
            Me.ddlTIPO_CANAID_TIPO_CANA.RecuperarCanaCorta()
        Else
            Me.ddlTIPO_CANAID_TIPO_CANA.Recuperar()
        End If
        Me.ddlTIPO_CANAID_TIPO_CANA.SelectedValue = mEntidad.ID_TIPO_CANA
        Me.ddlSUPERVISORID_SUPERVISOR.Recuperar()
        Me.ddlSUPERVISORID_SUPERVISOR.SelectedValue = mEntidad.ID_SUPERVISOR
        If TIPO_CANA_CON_QUEMA.Contains(mEntidad.ID_TIPO_CANA) Then
            Me.txtFECHA_QUEMA.Enabled = True
        End If
        Me.txtFECHA_QUEMA.Text = IIf(Not mEntidad.FECHA_QUEMA = Nothing, Format(mEntidad.FECHA_QUEMA, "dd/MM/yyyy hh:mm tt"), "")
        Me.txtFECHA_CORTA.Text = IIf(Not mEntidad.FECHA_CORTA = Nothing, Format(mEntidad.FECHA_CORTA, "dd/MM/yyyy hh:mm tt"), "")
        Me.cbxQUEMAPROG.Checked = mEntidad.QUEMAPROG
        Me.txtFECHA_CARGA.Text = IIf(Not mEntidad.FECHA_CARGA = Nothing, Format(mEntidad.FECHA_CARGA, "dd/MM/yyyy hh:mm tt"), "")
        Me.txtFECHA_PATIO.Text = IIf(Not mEntidad.FECHA_PATIO = Nothing, Format(mEntidad.FECHA_PATIO, "dd/MM/yyyy hh:mm tt"), "")
        Me.txtNROBOLETA.Text = mEntidad.NROBOLETA
        Me.cbxMADURANTE.Checked = mEntidad.MADURANTE
        Me.chkSERVICIO_ROZA.Checked = mEntidad.SERVICIO_ROZA
        Me.chkTRANSPORTE_PROPIO.Checked = mEntidad.TRANSPORTE_PROPIO
        If mEntidad.SERVICIO_ROZA Then
            Me.ddlPROVEEDOR_ROZA1.SelectedValue = mEntidad.ID_PROVEEDOR_ROZA
        End If
        If TIPO_OPERACION = TipoOperacion.Consulta OrElse TIPO_OPERACION = TipoOperacion.EdicionParcialBascula Then
            CargarLote(mEntidad.ACCESLOTE)
        Else
            CargarLotesPorContrato(mEntidad.CODICONTRATO)
        End If
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy hh:mm tt"), "")
    End Sub

    Private Sub CargarLote(ByVal ACCESLOTE As String)
        Dim entLote As LOTES
        _ListaLotes = New listaLOTES

        entLote = (New cLOTES).ObtenerLOTES(ACCESLOTE)
        If entLote IsNot Nothing Then
            _ListaLotes.Add(entLote)
        End If
        grdLotes.DataSource = _ListaLotes
        grdLotes.DataBind()
    End Sub

    Private Sub CargarLotesPorContrato(ByVal CODICONTRATO As String)
        _ListaLotes = (New cLOTES).ObtenerListaPorCONTRATO(CODICONTRATO)
        grdLotes.DataSource = _ListaLotes
        grdLotes.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_ENVIO.Enabled = False
        Me.ddlZAFRAID_ZAFRA.Enabled = TipoOperacion.Consulta
        Me.txtCATORCENA_ZAFRA.Enabled = False
        Me.txtDIAZAFRA.Enabled = False
        Me.txtCODICONTRATO.Enabled = edicion
        Me.txtCODIPROVEEDOR.Enabled = edicion
        Me.txtCODTRANSPORT.Enabled = edicion
        Me.txtNOMPROVEEDOR.Enabled = False
        Me.txtNOMBRE_TRANSPORTISTA.Enabled = False
        Me.txtNOMBRE_CARGADORA.Enabled = False
        Me.ddlTIPO_CANAID_TIPO_CANA.Enabled = edicion
        Me.txtPLACA_VEHIC.Enabled = edicion
        Me.txtPLACA_VEHIC_DropDownExtender.Enabled = edicion
        Me.panelPLACAS.Visible = edicion
        If lstTRANSPORTE.Items.FindByText(Me.txtPLACA_VEHIC.Text) IsNot Nothing AndAlso Me.txtPLACA_VEHIC.Text <> "" Then
            Me.ddlTIPO_TRANSPORTE1.Enabled = (Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Else
            Me.ddlTIPO_TRANSPORTE1.Enabled = edicion
        End If
        Me.txtID_CARGADORA.Enabled = edicion
        Me.ddlSUPERVISORID_SUPERVISOR.Enabled = edicion
        Me.grdLotes.Enabled = edicion
        Me.txtCOMPTENVIO.Enabled = edicion
        Me.txtNOMBRES_MOTORISTA.Enabled = edicion

        Me.panelMOTORISTA.Visible = edicion
        Me.txtID_CARGADOR.Enabled = edicion
        If TIPO_CANA_CON_QUEMA IsNot Nothing AndAlso IsNumeric(ddlTIPO_CANAID_TIPO_CANA.SelectedValue) AndAlso TIPO_CANA_CON_QUEMA.Contains(Convert.ToInt32(ddlTIPO_CANAID_TIPO_CANA.SelectedValue)) Then
            Me.txtFECHA_QUEMA.Enabled = edicion
        Else
            Me.txtFECHA_QUEMA.Enabled = False
        End If
        Me.txtFECHA_CORTA.Enabled = edicion
        Me.cbxQUEMAPROG.Enabled = edicion
        Me.txtFECHA_CARGA.Enabled = edicion
        Me.txtFECHA_PATIO.Enabled = edicion
        Me.ddlSUPERVISORID_SUPERVISOR.Enabled = edicion
        Me.cbxMADURANTE.Enabled = edicion
        Me.chkSERVICIO_ROZA.Enabled = edicion
        If Me.chkSERVICIO_ROZA.Checked AndAlso edicion Then
            Me.ddlPROVEEDOR_ROZA1.Enabled = True
        Else
            Me.ddlPROVEEDOR_ROZA1.Enabled = False
        End If
        Me.chkTRANSPORTE_PROPIO.Enabled = edicion
    End Sub

    Private Sub ConfigurarEncabezado()
        Dim entZafra As New ZAFRA

        Me.ddlZAFRAID_ZAFRA.Recuperar()
        entZafra = (New cZAFRA).ObtenerZafraActiva()

        If entZafra IsNot Nothing Then
            Me.ddlZAFRAID_ZAFRA.SelectedValue = entZafra.ID_ZAFRA
            If Me.TIPO_OPERACION <> TipoOperacion.Consulta Then
                Me.txtCATORCENA_ZAFRA.Text = entZafra.CATORCENA.ToString
                Me.txtDIAZAFRA.Text = entZafra.DIAZAFRA.ToString
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo(Optional configEncabezado As Boolean = True)
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        If configEncabezado Then ConfigurarEncabezado()
        Me.AsignarMensaje("", False, False)
        Me.txtID_ENVIO.Text = "0"
        Me.txtCOMPTENVIO.Text = ""
        Me.txtCODICONTRATO.Text = ""
        Me.lblOtrosContratos.Text = ""
        Me.txtCODIPROVEEDOR.Text = ""
        Me.txtNOMPROVEEDOR.Text = ""
        Me.txtCODTRANSPORT.Text = ""
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.ddlTIPO_TRANSPORTE1.Recuperar(True, False)
        Me.txtID_CARGADORA.Text = ""
        Me.txtNOMBRE_CARGADORA.Text = ""
        Me.txtID_CARGADOR.Text = ""
        Me.txtNOMBRE_CARGADOR.Text = ""
        Me.ddlTIPO_CANAID_TIPO_CANA.Recuperar(True, False)
        Me.ddlTIPO_CANAID_TIPO_CANA.SelectedIndex = 0
        Me.ddlSUPERVISORID_SUPERVISOR.Recuperar(True, False)
        Me.ddlSUPERVISORID_SUPERVISOR.SelectedIndex = 0
        Me.grdLotes.DataSource = _ListaLotes
        Me.grdLotes.DataBind()
        Me.txtPLACA_VEHIC.Text = ""
        Me.txtNOMBRES_MOTORISTA.Text = ""
        Me.lstMOTORISTA.Items.Clear()
        Me.lstTRANSPORTE.Items.Clear()
        Me.ddlTIPO_TRANSPORTE1.Recuperar(True, False)
        Me.txtFECHA_QUEMA.Text = ""
        Me.txtFECHA_CORTA.Text = ""
        Me.cbxQUEMAPROG.Checked = False
        Me.txtFECHA_CARGA.Text = ""
        Me.txtFECHA_PATIO.Text = ""
        Me.txtNROBOLETA.Text = ""
        Me.cbxMADURANTE.Checked = False
        Me.chkSERVICIO_ROZA.Checked = False
        Me.chkTRANSPORTE_PROPIO.Checked = False
        CargarTipoTarifaCargadora(-1)
        Me.ddlTipoTarifaCargadora.Items.Clear()
        Me.ddlPROVEEDOR_ROZA1.Recuperar(True, False)
        Me.ddlPROVEEDOR_ROZA1.SelectedValue = 0
        Me.lblMENSAJE_INFO.Text = ""
        Me.trAnulacion.Visible = False
    End Sub

    Private Sub CargarTipoTarifaCargadora(ByVal ID_CARGADORA As Integer)
        Dim lCargadora As CARGADORA
        Me.ddlTipoTarifaCargadora.Items.Clear()

        Me.ddlTipoTarifaCargadora.Enabled = False
        lCargadora = (New cCARGADORA).ObtenerCARGADORA(ID_CARGADORA)
        If lCargadora IsNot Nothing Then
            If lCargadora.ES_PROPIA Then
                If lCargadora.ID_TIPO_CARGADORA = Enumeradores.TipoCargadora.Cargadora Then
                    Me.ddlTipoTarifaCargadora.Items.Add("CARGA SIN TRIPULACION")
                    Me.ddlTipoTarifaCargadora.Items.Add("CARGA CON TRIPULACION")
                    Me.ddlTipoTarifaCargadora.Enabled = Me._Enabled
                End If
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ENVIO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim alDatos As New ArrayList
        Dim fechaQuema As Date = Nothing
        Dim fechaCorta As DateTime
        Dim fechaCarga As DateTime
        Dim fechaPatio As DateTime
        Dim lotesSelect As List(Of String)
        Dim sRet As String = ""

        mEntidad = New ENVIO
        If Me._nuevo Then
            mEntidad.ID_ENVIO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad.FECHA_ENTRADA = cFechaHora.ObtenerFecha
        Else
            mEntidad = (New cENVIO).ObtenerENVIO(CInt(Me.txtID_ENVIO.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If Me.ddlZAFRAID_ZAFRA.SelectedValue Is Nothing Then
            sError.AppendLine(" * No existe Periodo de Zafra.")
        End If
        If Me.CODICONTRATO = String.Empty OrElse txtCODIPROVEEDOR.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el Contrato.")
        End If
        If Me.txtCOMPTENVIO.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el No. de Comprobante.")
        End If
        If Me.txtNROBOLETA.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el No. de TACO.")
        End If
        lotesSelect = LotesSeleccionados()
        If lotesSelect.Count = 0 AndAlso TIPO_OPERACION <> TipoOperacion.EdicionParcialBascula Then
            sError.AppendLine(" * Seleccione un lote.")
        End If
        If lotesSelect.Count > 1 Then
            sError.AppendLine(" * Ha seleccionado mas de un lote.")
        End If
        If Me.txtCODTRANSPORT.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el codigo de Transportista.")
        End If
        If txtPLACA_VEHIC.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el numero de placa.")
        End If
        If Me.txtNOMBRES_MOTORISTA.Text.Trim = "" OrElse lstMOTORISTA.SelectedValue Is Nothing Then
            sError.AppendLine(" * Seleccione o ingrese el nombre del motorista.")
        End If
        If Me.txtID_CARGADORA.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el codigo de Cargadora.")
        End If
        'If Me.txtID_CARGADORA.Text <> "" Then
        '    Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(Convert.ToInt32(Me.txtID_CARGADORA.Text))
        '    If lCargadora IsNot Nothing Then
        '        If lCargadora.ES_PROPIA AndAlso (Me.txtNOMBRES_MOTORISTA.Text.Trim = "" OrElse lstMOTORISTA.SelectedValue Is Nothing) Then
        '            sError.AppendLine(" * Seleccione el nombre del motorista de la cargadora/cosechadora del ingenio.")
        '        End If
        '    End If
        'End If       
        If ddlTipoTarifaCargadora.Enabled AndAlso ddlTipoTarifaCargadora.SelectedValue Is Nothing Then
            sError.AppendLine(" * Seleccione el tipo de tarifa de cargadora.")
        End If
        If Me.txtID_CARGADOR.Text.Trim = String.Empty OrElse Not Utilerias.EsNumeroEntero(Me.txtID_CARGADOR.Text) Then
            sError.AppendLine(" * Ingrese el codigo de Cargador.")
        End If
        If ddlTIPO_CANAID_TIPO_CANA.SelectedValue Is Nothing OrElse ddlTIPO_CANAID_TIPO_CANA.SelectedValue = 0 Then
            sError.AppendLine(" * Seleccione el tipo de caÃ±a.")
        End If
        If ddlSUPERVISORID_SUPERVISOR.SelectedValue Is Nothing OrElse ddlSUPERVISORID_SUPERVISOR.SelectedValue = 0 Then
            sError.AppendLine(" * Seleccione el supervisor.")
        End If
        If ddlTIPO_TRANSPORTE1.SelectedValue Is Nothing OrElse ddlTIPO_TRANSPORTE1.SelectedValue = 0 Then
            sError.AppendLine(" * Seleccione el tipo de transporte.")
        End If
        If Me.txtFECHA_QUEMA.Text.Trim <> String.Empty OrElse TIPO_CANA_CON_QUEMA.Contains(Convert.ToInt32(ddlTIPO_CANAID_TIPO_CANA.SelectedValue)) Then
            If Me.txtFECHA_QUEMA.Text.Trim = String.Empty Then
                sError.AppendLine(" * Ingrese la fecha de quema.")
            ElseIf Not System.DateTime.TryParse(Me.txtFECHA_QUEMA.Text.Replace(".", ""), _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaQuema) Then
                sError.AppendLine(" * Fecha de quema invalida.")
            End If
        End If
        If Not System.DateTime.TryParse(Me.txtFECHA_CORTA.Text.Replace(".", ""), _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaCorta) Then
            sError.AppendLine(" * Fecha de corta invalida.")
        End If
        If Not System.DateTime.TryParse(Me.txtFECHA_CARGA.Text.Replace(".", ""), _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaCarga) Then
            sError.AppendLine(" * Fecha de carga invalida.")
        End If
        If Not System.DateTime.TryParse(Me.txtFECHA_PATIO.Text.Replace(".", ""), _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaPatio) Then
            sError.AppendLine(" * Fecha de patio invalida.")
        End If

        If Me.txtFECHA_QUEMA.Text.Trim <> String.Empty Then
            If fechaQuema < DateAdd(DateInterval.Day, -30, cFechaHora.ObtenerFechaHora) Then
                sError.AppendLine(" * Fecha de quema no puede ser menor a 30 dias de la fecha de ingreso al sistema.")
            End If
            If fechaQuema > fechaCorta Then
                sError.AppendLine(" * Fecha de quema no puede ser mayor a fecha de corta.")
            End If
            If fechaQuema > Now Then
                sError.AppendLine(" * Fecha de quema no puede ser mayor a la fecha del sistema.")
            End If
        End If
        If fechaCorta > fechaCarga Then
            sError.AppendLine(" * Fecha de corta no puede ser mayor a fecha de carga.")
        End If
        If fechaCorta > Now Then
            sError.AppendLine(" * Fecha de corta no puede ser mayor a la fecha del sistema.")
        End If
        If fechaCarga > fechaPatio Then
            sError.AppendLine(" * Fecha de carga patio no puede ser mayor a fecha de patio.")
        End If
        If fechaPatio > Now Then
            sError.AppendLine(" * Fecha de carga patio no puede ser mayor a la fecha del sistema.")
        End If

        'If Me.txtFECHA_QUEMA.Text.Trim <> String.Empty Then
        '    If DateDiff(DateInterval.Hour, fechaQuema, Now) > 120 Then
        '        sError.AppendLine(" * Fecha de quema no puede ser mayor a 120 horas con respecto a la fecha de ingreso del envio.")
        '    End If
        'ElseIf DateDiff(DateInterval.Hour, fechaCorta, Now) > 120 Then
        '    sError.AppendLine(" * Fecha de corta no puede ser mayor a 120 horas con respecto a la fecha de ingreso del envio.")
        'End If

        If chkSERVICIO_ROZA.Checked Then
            If ddlPROVEEDOR_ROZA1.SelectedValue Is Nothing OrElse ddlPROVEEDOR_ROZA1.SelectedValue = "" OrElse ddlPROVEEDOR_ROZA1.SelectedValue = 0 Then
                sError.AppendLine(" * Seleccione el proveedor de roza.")
            End If
        End If
        If sError.ToString.Length > 0 Then
            Return sError.ToString
        End If
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.CATORCENA = Convert.ToInt32(Me.txtCATORCENA_ZAFRA.Text)
        mEntidad.DIAZAFRA = Convert.ToInt32(Me.txtDIAZAFRA.Text)
        mEntidad.CODICONTRATO = Me.CODICONTRATO
        mEntidad.CODIPROVEEDOR = Me.txtCODIPROVEEDOR.Text
        mEntidad.COMPTENVIO = Convert.ToInt32(Me.txtCOMPTENVIO.Text)
        mEntidad.NROBOLETA = Convert.ToInt32(Me.txtNROBOLETA.Text)
        mEntidad.CODTRANSPORT = Convert.ToInt32(Me.txtCODTRANSPORT.Text)
        mEntidad.PLACAVEHIC = txtPLACA_VEHIC.Text.ToUpper
        If lstMOTORISTA.Items.FindByText(Me.txtNOMBRES_MOTORISTA.Text) IsNot Nothing Then
            Dim lMotorista As MOTORISTA = (New cMOTORISTA).ObtenerListaPorNOMBRES_APELLIDOS(txtNOMBRES_MOTORISTA.Text)
            If lMotorista IsNot Nothing AndAlso lMotorista.ID_MOTORISTA > 0 Then
                mEntidad.NOMBRES_MOTORISTA = Me.txtNOMBRES_MOTORISTA.Text.Trim.ToUpper
                mEntidad.ID_MOTORISTA = lMotorista.ID_MOTORISTA
            Else
                mEntidad.NOMBRES_MOTORISTA = txtNOMBRES_MOTORISTA.Text.Trim.ToUpper
                mEntidad.ID_MOTORISTA = -1
            End If
        Else
            mEntidad.NOMBRES_MOTORISTA = txtNOMBRES_MOTORISTA.Text.Trim.ToUpper
            mEntidad.ID_MOTORISTA = -1
        End If
        mEntidad.ID_TIPO_CANA = Me.ddlTIPO_CANAID_TIPO_CANA.SelectedValue
        mEntidad.ID_TIPOTRANS = Me.ddlTIPO_TRANSPORTE1.SelectedValue
        mEntidad.ID_CARGADORA = Me.txtID_CARGADORA.Text
        If Me.ddlTipoTarifaCargadora.Items.Count > 0 Then
            mEntidad.TIPO_TARIFA_CARGADORA = Me.ddlTipoTarifaCargadora.SelectedIndex
        Else
            mEntidad.TIPO_TARIFA_CARGADORA = -1
        End If
        mEntidad.ID_CARGADOR = Convert.ToInt32(Me.txtID_CARGADOR.Text)
        mEntidad.ID_SUPERVISOR = Me.ddlSUPERVISORID_SUPERVISOR.SelectedValue
        mEntidad.FECHA_QUEMAOld = cFechaHora.ObtenerFechaHora
        mEntidad.FECHA_QUEMA = fechaQuema
        mEntidad.FECHA_CORTA = fechaCorta
        mEntidad.QUEMAPROG = Me.cbxQUEMAPROG.Checked
        mEntidad.FECHA_CARGA = fechaCarga
        mEntidad.FECHA_PATIO = fechaPatio
        mEntidad.MADURANTE = Me.cbxMADURANTE.Checked
        If lotesSelect IsNot Nothing AndAlso lotesSelect.Count > 0 Then mEntidad.ACCESLOTE = lotesSelect(0)
        mEntidad.SERVICIO_ROZA = Me.chkSERVICIO_ROZA.Checked
        If Me.chkSERVICIO_ROZA.Checked Then
            mEntidad.ID_PROVEEDOR_ROZA = ddlPROVEEDOR_ROZA1.SelectedValue
        Else
            mEntidad.ID_PROVEEDOR_ROZA = -1
        End If
        mEntidad.TRANSPORTE_PROPIO = Me.chkTRANSPORTE_PROPIO.Checked
        mEntidad.ANULADO = False
        mEntidad.USUARIO_ANULACION = Nothing

        If TIPO_OPERACION = TipoOperacion.Recepcion Then
            sRet = (New cLOTES_COSECHA).ObtenerAutorizacionEntrega(Me.ddlZAFRAID_ZAFRA.SelectedValue, mEntidad.ACCESLOTE)
            If sRet <> "" Then
                MostrarMensaje(sRet, "Alerta")
                Return ""
            End If
            If Not (New cPLAN_COSECHA).EsEntregaProgramada(Me.ddlZAFRAID_ZAFRA.SelectedValue, mEntidad.ACCESLOTE, cFechaHora.ObtenerFecha) Then
                MostrarMensaje("La entrega de caÃ±a del Lote no ha sido programada para esta zafra.", "Alerta")
                Return ""
            End If
        End If

        If TIPO_OPERACION = TipoOperacion.Edicion Then
            If mComponente.ActualizarENVIOsinValidacion(mEntidad, TipoConcurrencia.Pesimistica) <> 1 Then
                Me.AsignarMensaje("* " + mComponente.sError, True)
                Return "Error al Guardar registro."
            End If
        Else
            If mComponente.ActualizarENVIO(mEntidad) <> 1 Then
                If mComponente.sErrorTecnico = "2601" Then
                    MostrarMensaje(mComponente.sError, "Alerta")
                    Return ""
                End If
                Return mComponente.sError
            End If
        End If

        If TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.EdicionParcialBascula Then
            'Actualizar tipo de transporte si se requiere
            Dim bTransporte As New cTRANSPORTE
            Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(txtCODTRANSPORT.Text), Me.txtPLACA_VEHIC.Text)
            If lTransporte IsNot Nothing Then
                lTransporte.ID_TIPOTRANS = ddlTIPO_TRANSPORTE1.SelectedValue
                lTransporte.USUARIO_ACT = Me.ObtenerUsuario
                lTransporte.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bTransporte.ActualizarTRANSPORTE(lTransporte)
            End If
        End If
        Me.AsignarMensaje("", True, False)
        Me.txtID_ENVIO.Text = mEntidad.ID_ENVIO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.MostrarMensaje("Registro guardado!")
        Return ""
    End Function

    Public Function Eliminar() As String
        Dim bEnvio As New cENVIO
        Dim lRet As Integer

        lRet = bEnvio.EliminarENVIO(CInt(Me.txtID_ENVIO.Text))
        If lRet < 0 Then
            Return "* " + bEnvio.sError
        Else
            Me.MostrarMensaje("Registro eliminado!")
        End If
        Return ""
    End Function

    Public Function Anular() As String
        Dim bEnvio As New cENVIO
        Dim lRet As Integer

        lRet = bEnvio.AnularENVIO(CInt(Me.txtID_ENVIO.Text))
        If lRet < 0 Then
            Return "* " + bEnvio.sError
        Else
            Me.MostrarMensaje("Registro anulado!")
        End If
        Return ""
    End Function

    Private Function LotesSeleccionados() As List(Of String)
        Dim lista As New List(Of String)
        For Each fila As GridViewRow In grdLotes.Rows
            Dim chk As RadioButton = fila.FindControl("rbtnSeleccionar")
            Dim lbl As Label = fila.FindControl("lblACCESLOTE")

            If chk IsNot Nothing Then
                If chk.Checked Then
                    lista.Add(lbl.Text)
                End If
            End If
        Next
        Return lista
    End Function

    Protected Sub txtNROBOLETA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNROBOLETA.TextChanged
        Me.AsignarMensaje("", True, False)
        If TIPO_OPERACION = TipoOperacion.Recepcion Then
            'Verificar que no se utiliza el nÃºmero de boleta para esta zafra
            Dim lista As listaENVIO
            Dim bEnvio As New cENVIO

            If Me.txtNROBOLETA.Text.Trim <> String.Empty Then
                Me.txtNROBOLETA.Text = Me.txtNROBOLETA.Text.Trim
                If Not IsNumeric(Me.txtNROBOLETA.Text) Then
                    Me.txtNROBOLETA.Text = ""
                    Me.txtNROBOLETA.Focus()
                    Exit Sub
                End If
                lista = bEnvio.ObtenerListaPorBOLETA(Me.ddlZAFRAID_ZAFRA.SelectedValue, Convert.ToInt32(Me.txtNROBOLETA.Text))
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    Me.AsignarMensaje(" * El No. de Taco: " + txtNROBOLETA.Text + " ya se encuentra registrado para esta Zafra", True)
                    Me.txtNROBOLETA.Text = ""
                    Me.txtNROBOLETA.Focus()
                    Exit Sub
                End If
            End If
            txtCOMPTENVIO.Focus()

        ElseIf TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.Consulta OrElse TipoOperacion.EdicionParcialBascula OrElse _
             TIPO_OPERACION = TipoOperacion.Eliminacion OrElse TIPO_OPERACION = TipoOperacion.Anulacion Then
            'Recuperar datos del taco
            Dim lista As listaENVIO
            Dim bEnvio As New cENVIO

            If Me.txtNROBOLETA.Text.Trim <> String.Empty Then
                Me.txtNROBOLETA.Text = Me.txtNROBOLETA.Text.Trim
                If Not IsNumeric(Me.txtNROBOLETA.Text) Then
                    Me.txtNROBOLETA.Text = ""
                    Me.txtNROBOLETA.Focus()
                    Exit Sub
                End If
                lista = bEnvio.ObtenerListaPorBOLETA(Me.ddlZAFRAID_ZAFRA.SelectedValue, Convert.ToInt32(Me.txtNROBOLETA.Text))
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    If lista(0).ANULADO Then
                        lblMENSAJE_INFO.Text = "ENVIO ANULADO EN FECHA " + lista(0).FECHA_ANULACION.ToString("dd/MM/yyyy HH:mm")
                        Me.trAnulacion.Visible = True
                    End If

                    Me.Enabled = (TIPO_OPERACION = TipoOperacion.Edicion)
                    Me.ID_ENVIO = lista(0).ID_ENVIO
                    If TIPO_OPERACION = TipoOperacion.EdicionParcialBascula Then
                        Me.chkTRANSPORTE_PROPIO.Enabled = True
                        Me.ddlTIPO_TRANSPORTE1.Enabled = True
                        Me.ddlTIPO_CANAID_TIPO_CANA.Enabled = True
                        If TIPO_CANA_CON_QUEMA IsNot Nothing AndAlso IsNumeric(ddlTIPO_CANAID_TIPO_CANA.SelectedValue) AndAlso TIPO_CANA_CON_QUEMA.Contains(Convert.ToInt32(ddlTIPO_CANAID_TIPO_CANA.SelectedValue)) Then
                            Me.txtFECHA_QUEMA.Enabled = True
                        End If
                    End If
                    Exit Sub
                Else
                    Me.AsignarMensaje(" * El No. de Taco: " + txtNROBOLETA.Text + " no se encuentra registrado para esta Zafra", True)
                    Return
                End If
            End If
            txtCOMPTENVIO.Focus()
        End If
    End Sub

    Protected Sub txtCOMPTENVIO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCOMPTENVIO.TextChanged
        If TIPO_OPERACION = TipoOperacion.Recepcion Then
            'Verificar que no se utiliza el nÃºmero de taco para esta zafra
            Dim lista As listaENVIO
            Dim bEnvio As New cENVIO

            If Me.txtCOMPTENVIO.Text.Trim <> String.Empty Then
                Me.txtCOMPTENVIO.Text = Me.txtCOMPTENVIO.Text.Trim
                If Not IsNumeric(Me.txtCOMPTENVIO.Text) Then
                    Me.txtCOMPTENVIO.Text = ""
                    Me.txtCOMPTENVIO.Focus()
                    Exit Sub
                End If
                lista = bEnvio.ObtenerListaPorCOMPROBANTE(Me.ddlZAFRAID_ZAFRA.SelectedValue, Convert.ToInt32(Me.txtCOMPTENVIO.Text))
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    Me.AsignarMensaje(" * El No. de Comprobante: " + txtCOMPTENVIO.Text + " ya se encuentra registrado para esta Zafra", True)
                    Me.txtCOMPTENVIO.Text = ""
                    Me.txtCOMPTENVIO.Focus()
                    Exit Sub
                End If
            End If
        End If
        txtCODICONTRATO.Focus()
    End Sub

    Protected Sub txtCODICONTRATO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODICONTRATO.TextChanged
        Dim sCodiContrato As String = ""

        If TIPO_OPERACION = TipoOperacion.Recepcion OrElse TIPO_OPERACION = TipoOperacion.Edicion Then
            Me.txtCODIPROVEEDOR.Text = ""
            Me.txtNOMPROVEEDOR.Text = ""
            Me.lblOtrosContratos.Text = ""
            _ListaLotes = New listaLOTES

            If Me.txtCODICONTRATO.Text.Trim <> String.Empty Then
                Me.txtCODICONTRATO.Text = Me.txtCODICONTRATO.Text.Trim
                sCodiContrato = Me.txtCODICONTRATO.Text
                If Not IsNumeric(sCodiContrato) Then
                    Me.txtCODICONTRATO.Text = ""
                    Me.txtCODICONTRATO.Focus()
                    Exit Sub
                End If
                If CLng(sCodiContrato).ToString.Length > 4 Then
                    Me.AsignarMensaje(" * Contrato invalido", True)
                    Me.txtCODICONTRATO.Focus()
                    Exit Sub
                End If
                Me.CODICONTRATO = sCodiContrato

                Dim entContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(Me.CODICONTRATO)
                Dim entProveedor As New PROVEEDOR

                If entContrato IsNot Nothing Then
                    entProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(entContrato.CODIPROVEEDOR)
                    If entProveedor IsNot Nothing Then
                        'Obtener otros contratos
                        Dim sCad As String = ""
                        Dim lContratos As listaCONTRATO = (New cCONTRATO).ObtenerListaPorCriterios(Me.ddlZAFRAID_ZAFRA.SelectedValue, -1, entProveedor.CODIPROVEE, Utilerias.FormatoCODISOCIO(0))
                        If lContratos IsNot Nothing AndAlso lContratos.Count > 0 Then
                            For Each lCon As CONTRATO In lContratos
                                If lCon.CODICONTRATO <> Me.CODICONTRATO Then
                                    If sCad = "" Then sCad += ("Otros Contratos: " + lCon.NO_CONTRATO.ToString) Else sCad += (", " + lCon.NO_CONTRATO.ToString)
                                End If
                            Next
                        End If
                        If Not sCad = "" Then Me.lblOtrosContratos.Text = sCad
                        Me.txtCODIPROVEEDOR.Text = entProveedor.CODIPROVEEDOR
                        Me.txtNOMPROVEEDOR.Text = Trim(entProveedor.NOMBRES.TrimEnd + " " + entProveedor.APELLIDOS.TrimEnd)
                    End If
                    _ListaLotes = (New cLOTES).ObtenerListaPorCONTRATO(entContrato.CODICONTRATO)
                Else
                    AsignarMensaje(" * Contrato no esta registrado", True)
                    Me.txtCODICONTRATO.Text = ""
                    Me.txtCODICONTRATO.Focus()
                    Return
                End If
            End If
            Me.grdLotes.DataSource = _ListaLotes
            Me.grdLotes.DataBind()
        End If
        Me.txtCODIPROVEEDOR.Focus()
    End Sub

    Protected Sub grdLotes_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdLotes.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim entLote As LOTES = CType(e.Row.DataItem, LOTES)

            'Variedad
            Dim entVariedad As VARIEDAD
            Dim lblVARIEDAD As Label = CType(e.Row.FindControl("lblVARIEDAD"), Label)
            entVariedad = (New cVARIEDAD).ObtenerVARIEDAD(entLote.CODIVARIEDA)
            If entVariedad IsNot Nothing Then lblVARIEDAD.Text = entVariedad.NOM_VARIEDAD

            'Lote seleccionado
            Dim rbtnLoteSeleccionado As RadioButton = CType(e.Row.FindControl("rbtnSeleccionar"), CheckBox)
            rbtnLoteSeleccionado.Visible = (TIPO_OPERACION = TipoOperacion.Recepcion OrElse TIPO_OPERACION = TipoOperacion.Edicion)
            If TIPO_OPERACION = TipoOperacion.Edicion Then
                'Seleccionar el lote
                Dim lenvio As ENVIO = (New cENVIO).ObtenerENVIO(Me.ID_ENVIO)
                If lenvio IsNot Nothing Then
                    If lenvio.ACCESLOTE = entLote.ACCESLOTE Then rbtnLoteSeleccionado.Checked = True
                End If
            End If

            'UbicaciÃ³n
            Dim entUbicacion As UBICACION
            Dim lblUBICACION As Label = CType(e.Row.FindControl("lblUBICACION"), Label)
            entUbicacion = (New cUBICACION).ObtenerUBICACION(entLote.CODIUBICACION)
            If entUbicacion IsNot Nothing Then lblUBICACION.Text = entUbicacion.MUNICIPIO.ToString.Trim + ", " + entUbicacion.CANTON.Trim

            'Agronomo
            Dim entAgronomo As AGRONOMO
            Dim lblAGRONOMO As Label = CType(e.Row.FindControl("lblAGRONOMO"), Label)
            entAgronomo = (New cAGRONOMO).ObtenerAGRONOMO(entLote.CODIAGRON)
            If entAgronomo IsNot Nothing Then lblAGRONOMO.Text = entAgronomo.NOMBRE_AGRONOMO & " " & entAgronomo.APELLIDO_AGRONOMO
        End If
    End Sub

    Protected Sub txtCODIPROVEEDOR_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODIPROVEEDOR.TextChanged
        Dim entidad As PROVEEDOR

        txtNOMPROVEEDOR.Text = ""
        txtCODIPROVEEDOR.Text = txtCODIPROVEEDOR.Text.Trim
        If txtCODIPROVEEDOR.Text <> String.Empty Then
            entidad = (New cPROVEEDOR).ObtenerPROVEEDOR(txtCODIPROVEEDOR.Text)
            If entidad IsNot Nothing Then
                txtNOMPROVEEDOR.Text = Trim(entidad.NOMBRES.TrimEnd + " " + entidad.APELLIDOS.TrimEnd)
            Else
                AsignarMensaje(" * CÃ³digo de proveedor no esta registrado", True)
                txtCODIPROVEEDOR.Text = ""
                txtCODIPROVEEDOR.Focus()
            End If
        End If
    End Sub

    Private Sub RecuperarPlacasPorTransportista(ByVal CODTRANSPORT As String)
        Dim lPlacas As listaTRANSPORTE
        lPlacas = (New cTRANSPORTE).ObtenerListaPorTRANSPORTISTA(CODTRANSPORT)
        lstTRANSPORTE.DataSource = lPlacas
        lstTRANSPORTE.DataBind()
    End Sub

    Private Sub RecuperarMotoristaPorTransporte(ByVal ID_TRANSPORTE As String)
        Dim lMotorista As listaMOTORISTA
        lMotorista = (New cMOTORISTA).ObtenerListaPorTRANSPORTE(ID_TRANSPORTE)
        lstMOTORISTA.DataSource = lMotorista
        lstMOTORISTA.DataBind()
    End Sub

    Protected Sub txtCODTRANSPORT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODTRANSPORT.TextChanged
        Dim entidad As TRANSPORTISTA
        RecuperarMotoristaPorTransporte(-1)
        txtNOMBRE_TRANSPORTISTA.Text = ""
        txtCODTRANSPORT.Text = txtCODTRANSPORT.Text.Trim

        RecuperarPlacasPorTransportista(-1)
        If Not IsNumeric(txtCODTRANSPORT.Text) Then
            Me.txtCODTRANSPORT.Text = ""
            Me.txtPLACA_VEHIC.Text = ""
            Me.txtNOMBRES_MOTORISTA.Text = ""
            ddlTIPO_TRANSPORTE1.SelectedValue = 0
            ddlTIPO_TRANSPORTE1.Enabled = True
            Me.txtCODTRANSPORT.Focus()
            Exit Sub
        End If
        entidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Convert.ToInt32(txtCODTRANSPORT.Text))
        If entidad IsNot Nothing Then
            txtNOMBRE_TRANSPORTISTA.Text = Trim(entidad.NOMBRES + " " + entidad.APELLIDOS)
            RecuperarPlacasPorTransportista(Convert.ToDecimal(txtCODTRANSPORT.Text))
            txtPLACA_VEHIC.Text = ""
            Me.txtNOMBRES_MOTORISTA.Text = ""
            txtPLACA_VEHIC.Focus()
        Else
            AsignarMensaje(" * Codigo de transportista no esta registrado", True, True)
            txtCODTRANSPORT.Text = ""
            txtPLACA_VEHIC.Text = ""
            Me.txtNOMBRES_MOTORISTA.Text = ""
            txtCODTRANSPORT.Focus()
        End If
        ddlTIPO_TRANSPORTE1.SelectedValue = 0
        ddlTIPO_TRANSPORTE1.Enabled = True
    End Sub

    Protected Sub txtID_CARGADORA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtID_CARGADORA.TextChanged
        Dim entidad As CARGADORA

        txtNOMBRE_CARGADORA.Text = ""
        txtID_CARGADORA.Text = txtID_CARGADORA.Text.Trim
        Me.CargarTipoTarifaCargadora(-1)
        If txtID_CARGADORA.Text <> String.Empty Then
            If Not IsNumeric(txtID_CARGADORA.Text) Then
                Me.txtID_CARGADORA.Text = ""
                Me.txtID_CARGADORA.Focus()
                Exit Sub
            End If
            entidad = (New cCARGADORA).ObtenerCARGADORA(Convert.ToInt32(txtID_CARGADORA.Text))
            If entidad IsNot Nothing Then
                Me.CargarTipoTarifaCargadora(Convert.ToInt32(txtID_CARGADORA.Text))
                txtNOMBRE_CARGADORA.Text = entidad.NOMBRE
                If entidad.ID_TIPO_CARGADORA = 2 Then
                    Me.ddlTIPO_CANAID_TIPO_CANA.RecuperarCanaCorta()
                Else
                    Me.ddlTIPO_CANAID_TIPO_CANA.Recuperar()
                End If
                If ddlTipoTarifaCargadora.Enabled Then ddlTipoTarifaCargadora.Focus() Else Me.txtID_CARGADOR.Focus()
            Else
                AsignarMensaje(" * Codigo de cargadora no esta registrado", True)
                txtID_CARGADORA.Text = ""
                txtID_CARGADORA.Focus()
            End If
        End If
    End Sub

    Protected Sub rbtnSeleccionar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim opcionSelect As RadioButton = CType(sender, RadioButton)
        Dim fila As GridViewRow = CType(opcionSelect.Parent.Parent, GridViewRow)
        Dim a As Integer = fila.RowIndex
        Dim esEntregaProgramada As Boolean
        Dim sRet As String = ""

        If TIPO_OPERACION = TipoOperacion.Recepcion Then
            If fila.FindControl("lblACCESLOTE") IsNot Nothing Then
                Dim lblACCESLOTE As Label = CType(fila.FindControl("lblACCESLOTE"), Label)
                Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lblACCESLOTE.Text)
                Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(Me.txtCODICONTRATO.Text)

                'Validar que el lote este programado
                esEntregaProgramada = (New cPLAN_COSECHA).EsEntregaProgramada(Me.ddlZAFRAID_ZAFRA.SelectedValue, lblACCESLOTE.Text, cFechaHora.ObtenerFecha)
                sRet = (New cLOTES_COSECHA).ObtenerAutorizacionEntrega(Me.ddlZAFRAID_ZAFRA.SelectedValue, lblACCESLOTE.Text)
                If Not esEntregaProgramada OrElse sRet <> "" Then
                    opcionSelect.Checked = False
                Else
                    'Verificar si el lote es de un proveedor diferente al del contrato
                    If lLote IsNot Nothing Then
                        If lLote.CODIPROVEEDOR <> Me.txtCODIPROVEEDOR.Text AndAlso Me.CODICONTRATO <> "" Then
                            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
                            If lProveedor IsNot Nothing Then
                                Me.txtCODIPROVEEDOR.Text = lLote.CODIPROVEEDOR
                                Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
                            End If
                        End If
                    End If
                End If
            End If
        Else
            If fila.FindControl("lblACCESLOTE") IsNot Nothing Then
                Dim lblACCESLOTE As Label = CType(fila.FindControl("lblACCESLOTE"), Label)
                Dim bLoteCosecha As New cLOTES_COSECHA
                Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lblACCESLOTE.Text)
                Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(Me.txtCODICONTRATO.Text)

                'Verificar si el lote es de un proveedor diferente al del contrato
                If lLote IsNot Nothing Then
                    If lLote.CODIPROVEEDOR <> Me.txtCODIPROVEEDOR.Text AndAlso Me.CODICONTRATO <> "" Then
                        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
                        If lProveedor IsNot Nothing Then
                            Me.txtCODIPROVEEDOR.Text = lLote.CODIPROVEEDOR
                            Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
                        End If
                    End If
                End If
            End If
        End If

        For Each f As GridViewRow In grdLotes.Rows
            If opcionSelect.Checked Then
                If f.RowIndex <> a Then
                    Dim radio As RadioButton = CType(f.FindControl("rbtnSeleccionar"), RadioButton)
                    radio.Checked = False
                End If
            End If
        Next

        If TIPO_OPERACION = TipoOperacion.Recepcion AndAlso sRet <> "" Then
            MostrarMensaje(sRet, "Alerta")
            Return
        End If
        If TIPO_OPERACION = TipoOperacion.Recepcion AndAlso Not esEntregaProgramada Then
            MostrarMensaje("La entrega de cana del Lote no ha sido programada para esta zafra.", "Alerta")
            Return
        End If
    End Sub

    Protected Sub txtPLACA_VEHIC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPLACA_VEHIC.TextChanged
        'Recuperar motorista y tipo de transporte ne base a:
        'CÃ³digo de transportista y Placa
        Dim item As ListItem

        txtPLACA_VEHIC.Text = txtPLACA_VEHIC.Text.Trim
        item = lstTRANSPORTE.Items.FindByText(txtPLACA_VEHIC.Text)
        If item IsNot Nothing Then
            item.Selected = True
            Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(txtCODTRANSPORT.Text), Me.txtPLACA_VEHIC.Text)
            If lTransporte IsNot Nothing Then
                RecuperarMotoristaPorTransporte(lTransporte.ID_TRANSPORTE)
                ddlTIPO_TRANSPORTE1.SelectedValue = lTransporte.ID_TIPOTRANS
                ddlTIPO_TRANSPORTE1.Enabled = False
            Else
                RecuperarMotoristaPorTransporte(-1)
                ddlTIPO_TRANSPORTE1.SelectedValue = 0
                ddlTIPO_TRANSPORTE1.Enabled = True
            End If
        Else
            ddlTIPO_TRANSPORTE1.SelectedValue = 0
            ddlTIPO_TRANSPORTE1.Enabled = True
            RecuperarMotoristaPorTransporte(-1)
        End If
    End Sub

    Protected Sub chkSERVICIO_ROZA_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSERVICIO_ROZA.CheckedChanged
        If chkSERVICIO_ROZA.Checked Then
            Me.ddlPROVEEDOR_ROZA1.Enabled = True
        Else
            Me.ddlPROVEEDOR_ROZA1.SelectedValue = 0
            Me.ddlPROVEEDOR_ROZA1.Enabled = False
        End If

    End Sub

    Protected Sub lstTRANSPORTE_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTRANSPORTE.SelectedIndexChanged
        Me.txtPLACA_VEHIC.Text = lstTRANSPORTE.SelectedValue.ToString
        Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(txtCODTRANSPORT.Text), lstTRANSPORTE.SelectedValue)
        If lTransporte IsNot Nothing Then
            RecuperarMotoristaPorTransporte(lTransporte.ID_TRANSPORTE)
            ddlTIPO_TRANSPORTE1.SelectedValue = lTransporte.ID_TIPOTRANS
            ddlTIPO_TRANSPORTE1.Enabled = False
        Else
            RecuperarMotoristaPorTransporte(-1)
            ddlTIPO_TRANSPORTE1.SelectedValue = 0
            ddlTIPO_TRANSPORTE1.Enabled = True
        End If
    End Sub

    Protected Sub ddlTIPO_CANAID_TIPO_CANA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlTIPO_CANAID_TIPO_CANA.SelectedIndexChanged
        If TIPO_CANA_CON_QUEMA.Contains(Convert.ToInt32(ddlTIPO_CANAID_TIPO_CANA.SelectedValue)) Then
            Me.txtFECHA_QUEMA.Enabled = True
        Else
            Me.txtFECHA_QUEMA.Text = ""
            Me.txtFECHA_QUEMA.Enabled = False
        End If
    End Sub

    Protected Sub txtFECHA_CORTA_TextChanged(sender As Object, e As System.EventArgs) Handles txtFECHA_CORTA.TextChanged
        Dim fechaCorta As Date = Nothing
        Dim fechaEnvio As Date = Nothing

        If System.DateTime.TryParse(Me.txtFECHA_CORTA.Text.Replace(".", ""), _
                   New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaCorta) Then
            If Me._nuevo Then
                fechaEnvio = cFechaHora.ObtenerFechaHora
            Else
                fechaEnvio = (New cENVIO).ObtenerENVIO(CInt(txtID_ENVIO.Text)).FECHA_CREA
            End If
            If DateAndTime.DateDiff(DateInterval.Hour, fechaCorta, fechaEnvio) > 72 Then
                MostrarMensaje("Envio excede 72 horas desde la fecha y hora de corta.", "Alerta")
            End If
        End If
    End Sub

    Protected Sub lstMOTORISTA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lstMOTORISTA.SelectedIndexChanged
        Me.txtNOMBRES_MOTORISTA.Text = lstMOTORISTA.SelectedValue
    End Sub

    Protected Sub txtNOMBRES_MOTORISTA_TextChanged(sender As Object, e As System.EventArgs) Handles txtNOMBRES_MOTORISTA.TextChanged
        Dim item As ListItem

        txtNOMBRES_MOTORISTA.Text = txtNOMBRES_MOTORISTA.Text.Trim.ToUpper
        item = lstMOTORISTA.Items.FindByText(txtNOMBRES_MOTORISTA.Text)
        If item IsNot Nothing Then
            item.Selected = True
        End If
    End Sub

    Protected Sub txtFECHA_QUEMA_TextChanged(sender As Object, e As System.EventArgs) Handles txtFECHA_QUEMA.TextChanged
        Dim fechaQuema As Date = Nothing
        Dim fechaEnvio As Date = Nothing

        If Me.txtFECHA_QUEMA.Text.Trim <> "" Then
            If System.DateTime.TryParse(Me.txtFECHA_QUEMA.Text.Replace(".", ""), _
                   New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaQuema) Then
                If Me._nuevo Then
                    fechaEnvio = cFechaHora.ObtenerFechaHora
                Else
                    fechaEnvio = (New cENVIO).ObtenerENVIO(CInt(txtID_ENVIO.Text)).FECHA_CREA
                End If
                If DateAndTime.DateDiff(DateInterval.Hour, fechaQuema, fechaEnvio) > 120 Then
                    MostrarMensaje("Envio excede 120 horas desde la fecha y hora de quema.", "Alerta")
                End If
            End If
        End If
    End Sub

    Protected Sub txtID_CARGADOR_TextChanged(sender As Object, e As System.EventArgs) Handles txtID_CARGADOR.TextChanged
        Dim entidad As CARGADOR

        txtNOMBRE_CARGADOR.Text = ""
        txtID_CARGADOR.Text = txtID_CARGADOR.Text.Trim
        If txtID_CARGADOR.Text <> String.Empty Then
            If Not IsNumeric(txtID_CARGADOR.Text) Then
                Me.txtID_CARGADOR.Text = ""
                Me.txtID_CARGADOR.Focus()
                Exit Sub
            End If
            entidad = (New cCARGADOR).ObtenerCARGADOR(Convert.ToInt32(txtID_CARGADOR.Text))
            If entidad IsNot Nothing Then
                Me.txtNOMBRE_CARGADOR.Text = entidad.NOMBRE_CARGADOR
            Else
                AsignarMensaje(" * Codigo de cargador no esta registrado", True)
                txtID_CARGADOR.Text = ""
                txtID_CARGADOR.Focus()
            End If
        End If
    End Sub

    Protected Sub ddlZAFRAID_ZAFRA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlZAFRAID_ZAFRA.SelectedIndexChanged
        Dim lNroBoleta As String = Me.txtNROBOLETA.Text
        Me.Nuevo(False)
        Me.txtNROBOLETA.Text = lNroBoleta
        Me.txtNROBOLETA_TextChanged(sender, e)
    End Sub
End Class
