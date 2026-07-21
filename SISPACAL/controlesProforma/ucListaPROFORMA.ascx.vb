Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPROFORMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PROFORMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPROFORMA
    Inherits ucListaBase
 
    Private mComponente As New cPROFORMA
    Public Event Seleccionado(ByVal ID_PROFORMA As Int32) 
    Public Event Editando(ByVal ID_PROFORMA As Int32) 

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            If Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowPager Then
                Return True
            End If
            Return False
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowPager
            Else
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowAllRecords
            End If
        End Set
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirSeleccionar As Boolean = False
    Public Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Eliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Eliminar").Visible = Value
        End Set
    End Property

    Public Property PermitirAgrupar() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowGroupPanel
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowGroupPanel = Value
        End Set
    End Property

    Public Property PermitirFilaDeFiltro() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = value
        End Set
    End Property

    Public Property PermitirFiltroEnEncabezado() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowHeaderFilterButton
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowHeaderFilterButton = value
        End Set
    End Property

    Public Property PermitirEditarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline") = value
        End Set
    End Property

    Public Property PermitirVistaPrevia() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaPrevia").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaPrevia").Visible = Value
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
        End Set
    End Property

    Public Property PermitirAgregarInline() As Boolean
        Get
            Return Me.ViewState("PermitirAgregarInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregarInline") = value
        End Set
    End Property

    Public Property PermitirRowHotTrack() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.EnableRowHotTrack
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.EnableRowHotTrack = value
        End Set
    End Property

    Public Property PermitirFocoEnFilas() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.AllowFocusedRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.AllowFocusedRow = value
        End Set
    End Property

    Public Property PermitirSeleccionParaCombo() As Boolean
        Get
            Return Me.ViewState("PermitirSeleccionParaCombo")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirSeleccionParaCombo") = value
        End Set
    End Property

    Public Property NombreComboCliente() As String
        Get
            Return Me.ViewState("NombreComboCliente")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NombreComboCliente") = value
        End Set
    End Property

    Private _TextoSeleccionar As String = "Seleccionar"
    Public Property TextoSeleccionar() As String
        Get
            Return _TextoSeleccionar
        End Get
        Set(ByVal Value As String)
            _TextoSeleccionar = Value
            If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me.ViewState.Remove("TextoSeleccionar")
            Me.ViewState.Add("TextoSeleccionar", Value)
        End Set
    End Property

    Private _ComandoSeleccionar As String = "Select"
    Public Property ComandoSeleccionar() As String
        Get
            Return _ComandoSeleccionar
        End Get
        Set(ByVal Value As String)
            _ComandoSeleccionar = Value
            If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me.ViewState.Remove("ComandoSeleccionar")
            Me.ViewState.Add("ComandoSeleccionar", Value)
        End Set
    End Property

    Public Property TextoHeaderSeleccionar() As String
        Get
            Return Me.dxgvLista.Columns("Seleccionar").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("Seleccionar").Caption = Value
        End Set
    End Property

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerID_PROFORMA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROFORMA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROFORMA").Visible = Value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerDIAZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIAZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIAZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerNOPROFORMA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOPROFORMA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOPROFORMA").Visible = Value
        End Set
    End Property

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODICONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODICONTRATO").Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACCESLOTE").Visible = Value
        End Set
    End Property

    Public Property VerCODTRANSPORT() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODTRANSPORT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODTRANSPORT").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES_MOTORISTA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRES_MOTORISTA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRES_MOTORISTA").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_CANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_CANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_CANA").Visible = Value
        End Set
    End Property

    Public Property VerID_CARGADORA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CARGADORA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CARGADORA").Visible = Value
        End Set
    End Property

    Public Property VerID_SUPERVISOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SUPERVISOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SUPERVISOR").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_QUEMA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_QUEMA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_QUEMA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CORTA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CORTA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CORTA").Visible = Value
        End Set
    End Property

    Public Property VerQUEMAPROG() As Boolean
        Get
            Return Me.dxgvLista.Columns("QUEMAPROG").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("QUEMAPROG").Visible = Value
        End Set
    End Property

    Public Property VerQUEMANOPROG() As Boolean
        Get
            Return Me.dxgvLista.Columns("QUEMANOPROG").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("QUEMANOPROG").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CARGA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CARGA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CARGA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_PATIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_PATIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_PATIO").Visible = Value
        End Set
    End Property

    Public Property VerID_PRODUCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PRODUCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PRODUCTO").Visible = Value
        End Set
    End Property

    Public Property VerFIN_LOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("FIN_LOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FIN_LOTE").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ENTRADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ENTRADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ENTRADA").Visible = Value
        End Set
    End Property

    Public Property VerPLACAVEHIC() As Boolean
        Get
            Return Me.dxgvLista.Columns("PLACAVEHIC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PLACAVEHIC").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPOTRANS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPOTRANS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPOTRANS").Visible = Value
        End Set
    End Property

    Public Property VerSERVICIO_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SERVICIO_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SERVICIO_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerTRANSPORTE_PROPIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TRANSPORTE_PROPIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TRANSPORTE_PROPIO").Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROVEEDOR_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerID_CARGADOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CARGADOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CARGADOR").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_TARIFA_CARGADORA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_TARIFA_CARGADORA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_TARIFA_CARGADORA").Visible = Value
        End Set
    End Property

    Public Property VerID_MOTORISTA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_MOTORISTA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_MOTORISTA").Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACIONES() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACIONES").Visible = Value
        End Set
    End Property

    Public Property VerID_ENVIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ENVIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ENVIO").Visible = Value
        End Set
    End Property

    Public Property VerESTADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTADO").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CREA").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_ACT").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ACT").Visible = Value
        End Set
    End Property

    Public Property HeaderID_PROFORMA() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROFORMA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROFORMA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderDIAZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("DIAZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIAZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderNOPROFORMA() As String
        Get
            Return Me.dxgvLista.Columns("NOPROFORMA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOPROFORMA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODICONTRATO() As String
        Get
            Return Me.dxgvLista.Columns("CODICONTRATO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODICONTRATO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEEDOR() As String
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Caption = Value
        End Set
    End Property

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACCESLOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderCODTRANSPORT() As String
        Get
            Return Me.dxgvLista.Columns("CODTRANSPORT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODTRANSPORT").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRES_MOTORISTA() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRES_MOTORISTA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRES_MOTORISTA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_CANA() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_CANA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_CANA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CARGADORA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CARGADORA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CARGADORA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SUPERVISOR() As String
        Get
            Return Me.dxgvLista.Columns("ID_SUPERVISOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SUPERVISOR").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_QUEMA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_QUEMA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_QUEMA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CORTA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CORTA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CORTA").Caption = Value
        End Set
    End Property

    Public Property HeaderQUEMAPROG() As String
        Get
            Return Me.dxgvLista.Columns("QUEMAPROG").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("QUEMAPROG").Caption = Value
        End Set
    End Property

    Public Property HeaderQUEMANOPROG() As String
        Get
            Return Me.dxgvLista.Columns("QUEMANOPROG").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("QUEMANOPROG").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CARGA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CARGA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CARGA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_PATIO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_PATIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_PATIO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PRODUCTO() As String
        Get
            Return Me.dxgvLista.Columns("ID_PRODUCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PRODUCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderFIN_LOTE() As String
        Get
            Return Me.dxgvLista.Columns("FIN_LOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FIN_LOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ENTRADA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ENTRADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ENTRADA").Caption = Value
        End Set
    End Property

    Public Property HeaderPLACAVEHIC() As String
        Get
            Return Me.dxgvLista.Columns("PLACAVEHIC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PLACAVEHIC").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPOTRANS() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPOTRANS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPOTRANS").Caption = Value
        End Set
    End Property

    Public Property HeaderSERVICIO_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("SERVICIO_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SERVICIO_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderTRANSPORTE_PROPIO() As String
        Get
            Return Me.dxgvLista.Columns("TRANSPORTE_PROPIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TRANSPORTE_PROPIO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PROVEEDOR_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROVEEDOR_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CARGADOR() As String
        Get
            Return Me.dxgvLista.Columns("ID_CARGADOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CARGADOR").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_TARIFA_CARGADORA() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_TARIFA_CARGADORA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_TARIFA_CARGADORA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_MOTORISTA() As String
        Get
            Return Me.dxgvLista.Columns("ID_MOTORISTA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_MOTORISTA").Caption = Value
        End Set
    End Property

    Public Property HeaderOBSERVACIONES() As String
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OBSERVACIONES").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ENVIO() As String
        Get
            Return Me.dxgvLista.Columns("ID_ENVIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ENVIO").Caption = Value
        End Set
    End Property

    Public Property HeaderESTADO() As String
        Get
            Return Me.dxgvLista.Columns("ESTADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ESTADO").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ACT").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZAFRA(ByVal ID_ZAFRA As Int32) As Integer
        Me.odsListaPorZAFRA.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorZAFRA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorZAFRA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorZAFRA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorZAFRA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZAFRA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla TIPO_CANA
    ''' </summary>
    ''' <param name="ID_TIPO_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_CANA(ByVal ID_TIPO_CANA As Int32) As Integer
        Me.odsListaPorTIPO_CANA.SelectParameters("ID_TIPO_CANA").DefaultValue = ID_TIPO_CANA.ToString()
        Me.odsListaPorTIPO_CANA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_CANA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_CANA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_CANA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_CANA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla CARGADORA
    ''' </summary>
    ''' <param name="ID_CARGADORA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCARGADORA(ByVal ID_CARGADORA As Int32) As Integer
        Me.odsListaPorCARGADORA.SelectParameters("ID_CARGADORA").DefaultValue = ID_CARGADORA.ToString()
        Me.odsListaPorCARGADORA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCARGADORA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCARGADORA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCARGADORA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCARGADORA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla SUPERVISOR
    ''' </summary>
    ''' <param name="ID_SUPERVISOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSUPERVISOR(ByVal ID_SUPERVISOR As Int32) As Integer
        Me.odsListaPorSUPERVISOR.SelectParameters("ID_SUPERVISOR").DefaultValue = ID_SUPERVISOR.ToString()
        Me.odsListaPorSUPERVISOR.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSUPERVISOR.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSUPERVISOR.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSUPERVISOR.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSUPERVISOR"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla PRODUCTO
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPRODUCTO(ByVal ID_PRODUCTO As Int32) As Integer
        Me.odsListaPorPRODUCTO.SelectParameters("ID_PRODUCTO").DefaultValue = ID_PRODUCTO.ToString()
        Me.odsListaPorPRODUCTO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPRODUCTO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPRODUCTO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPRODUCTO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPRODUCTO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla TIPO_TRANSPORTE
    ''' </summary>
    ''' <param name="ID_TIPOTRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_TRANSPORTE(ByVal ID_TIPOTRANS As Int32) As Integer
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("ID_TIPOTRANS").DefaultValue = ID_TIPOTRANS.ToString()
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_TRANSPORTE.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_TRANSPORTE"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla PROVEEDOR_ROZA
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_ROZA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32) As Integer
        Me.odsListaPorPROVEEDOR_ROZA.SelectParameters("ID_PROVEEDOR_ROZA").DefaultValue = ID_PROVEEDOR_ROZA.ToString()
        Me.odsListaPorPROVEEDOR_ROZA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR_ROZA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_ROZA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_ROZA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR_ROZA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla CARGADOR
    ''' </summary>
    ''' <param name="ID_CARGADOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCARGADOR(ByVal ID_CARGADOR As Int32) As Integer
        Me.odsListaPorCARGADOR.SelectParameters("ID_CARGADOR").DefaultValue = ID_CARGADOR.ToString()
        Me.odsListaPorCARGADOR.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCARGADOR.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCARGADOR.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCARGADOR.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCARGADOR"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROFORMA
    ''' filtrado por la tabla ENVIO
    ''' </summary>
    ''' <param name="ID_ENVIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorENVIO(ByVal ID_ENVIO As Int32) As Integer
        Me.odsListaPorENVIO.SelectParameters("ID_ENVIO").DefaultValue = ID_ENVIO.ToString()
        Me.odsListaPorENVIO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorENVIO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorENVIO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorENVIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorENVIO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "ID_PROFORMA")
                keyNames(i) = grid.GetRowValues(i, "ID_ZAFRA")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.GridViewRowType.EditForm Then
            'Dim btnGuardar As DevExpress.Web.ASPxButton
            'Dim btnCancelar As DevExpress.Web.ASPxButton
            'btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            'btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            'btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.EmptyDataRow Then
            'Dim btnAgregar As DevExpress.Web.ASPxButton
            'btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            'btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnAgregar.Visible = Me.PermitirAgregarInline
            'Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
            'lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            'lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.Data Then
            If Not Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar Then
                Dim lbSeleccionar As LinkButton
                lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                lbSeleccionar.Visible = True
                lbSeleccionar.Text = Me.TextoSeleccionar
                lbSeleccionar.CommandName = Me.ComandoSeleccionar
                If lbSeleccionar.CommandName = "Check" Then
                    lbSeleccionar.Visible = False
                End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaPROFORMA
        Dim mLista As New listaPROFORMA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_PROFORMA")
            Dim lEntidad As New PROFORMA
            lEntidad.ID_PROFORMA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PROFORMA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PROFORMA)

            If Me.mComponente.EliminarPROFORMA(lEntidad.ID_PROFORMA) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NOMBRE_ZAFRA" Then
            Dim lEntidad As ZAFRA = (New cZAFRA).ObtenerZAFRA(e.GetListSourceFieldValue("ID_ZAFRA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_ZAFRA
        ElseIf e.Column.FieldName = "CODIPROVEE" Then
             e.Value = Utilerias.RecuperarCODIPROVEE(e.GetListSourceFieldValue("CODIPROVEEDOR"))
        ElseIf e.Column.FieldName = "CODISOCIO" Then
            e.Value = Utilerias.RecuperarCODISOCIO(e.GetListSourceFieldValue("CODIPROVEEDOR"))
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lEntidad As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
        ElseIf e.Column.FieldName = "CODILOTE" Then
            Dim lEntidad As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.CODILOTE
        ElseIf e.Column.FieldName = "NOMLOTE" Then
            Dim lEntidad As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBLOTE
        ElseIf e.Column.FieldName = "NOMBRE_ESTADO" Then
            Select Case CStr(e.GetListSourceFieldValue("ESTADO"))
                Case Enumeradores.EstadoProforma.Anulado
                    e.Value = "ANULADO"
                Case Enumeradores.EstadoProforma.ConEnvio
                    e.Value = "EN ENVIO DE CAÑA"
                Case Enumeradores.EstadoProforma.Rueda
                    e.Value = "EN RUEDA"
                Case Enumeradores.EstadoProforma.Tara
                    e.Value = "CON TARA"
                Case Enumeradores.EstadoProforma.Patio
                    e.Value = "EN PATIO"
                Case Enumeradores.EstadoProforma.Transito
                    e.Value = "EN TRANSITO"
            End Select
        ElseIf e.Column.FieldName = "NROBOLETA" Then
            If e.GetListSourceFieldValue("ID_ENVIO") <> -1 Then
                Dim lEntidad As ENVIO = (New cENVIO).ObtenerENVIO(e.GetListSourceFieldValue("ID_ENVIO"))
                If lEntidad IsNot Nothing Then e.Value = lEntidad.NROBOLETA.ToString
            End If
        End If
    End Sub
End Class
