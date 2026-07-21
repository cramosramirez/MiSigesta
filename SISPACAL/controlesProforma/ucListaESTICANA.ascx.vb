Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaESTICANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ESTICANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaESTICANA
    Inherits ucListaBase

    Private mComponente As New cESTICANA
    Public Event Seleccionado(ByVal ID_ESTICANA As Int32)
    Public Event Editando(ByVal ID_ESTICANA As Int32)
    Public Event Quemando(ByVal ID_PLAN_COSECHA As Int32)
    Public Event Rozando(ByVal ID_PLAN_COSECHA As Int32)
    Public Event ModiQuema(ByVal ID_PLAN_COSECHA As Int32)
    Public Event EmitiendoProforma(ByVal ID_PLAN_COSECHA As Int32)

#Region "Propiedades"

    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = Value
        End Set
    End Property

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property MostrarUnaPagina As Boolean
        Set(value As Boolean)
            If value Then
                dxgvLista.SettingsPager.Mode = GridViewPagerMode.ShowAllRecords
            Else
                dxgvLista.SettingsPager.Mode = GridViewPagerMode.ShowPager
            End If
        End Set
        Get
            Return (dxgvLista.SettingsPager.Mode = GridViewPagerMode.EndlessPaging)
        End Get
    End Property

    Public Sub SeleccionarTodos()
        dxgvLista.Selection.SelectAll()
    End Sub

    Public Sub QuitarSelecciones()
        dxgvLista.Selection.UnselectAll()
    End Sub

    Public Property MostrarCheckUnaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
            dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly = value
        End Set
        Get
            Return dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly
        End Get
    End Property
    Public Property MostrarCheckVariaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
        End Set
        Get
            Return dxgvLista.Columns("CheckSeleccionar").Visible
        End Get
    End Property

    Public Property PermitirVistaControlQuema() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaControlQuema").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaControlQuema").Visible = Value
        End Set
    End Property

    Public Property PermitirVistaControlModiQuema() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaControlModificacionQuema").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaControlModificacionQuema").Visible = Value
        End Set
    End Property

    Public Property PermitirVistaControlRoza() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaControlRoza").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaControlRoza").Visible = Value
        End Set
    End Property

    Public Property PermitirEmitirProforma() As Boolean
        Get
            Return Me.dxgvLista.Columns("colEmitirProforma").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colEmitirProforma").Visible = Value
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

    Public Property PermitirEditarInline2() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline2")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline2") = value
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = value
            Me.dxgvLista.Columns("Edicion2").Visible = Me.PermitirEditarInline2
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

    Public Property VerID_ESTICANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ESTICANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ESTICANA").Visible = Value
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

    Public Property VerCONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONTRATO").Visible = Value
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

    Public Property VerFECHA_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerREND_COSECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND_COSECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND_COSECHA").Visible = Value
        End Set
    End Property

    Public Property VerMZ_ENTREGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ_ENTREGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ_ENTREGAR").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_MZ_ENTREGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_ENTREGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_MZ_ENTREGAR").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_ENTREGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_ENTREGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_ENTREGAR").Visible = Value
        End Set
    End Property

    Public Property VerLBS_ENTREGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS_ENTREGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS_ENTREGAR").Visible = Value
        End Set
    End Property

    Public Property VerVALOR_ENTREGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("VALOR_ENTREGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("VALOR_ENTREGAR").Visible = Value
        End Set
    End Property

    Public Property VerMZ_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_MZ_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_MZ_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerLBS_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZONA").Visible = Value
        End Set
    End Property

    Public Property VerVALOR_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("VALOR_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("VALOR_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerAREA_CONTRATADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("AREA_CONTRATADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("AREA_CONTRATADA").Visible = Value
        End Set
    End Property
    Public Property VerTONEL_CONTRATADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_CONTRATADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_CONTRATADA").Visible = Value
        End Set
    End Property

    Public Property VerMZ_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ_CENSO").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_MZ_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_MZ_CENSO").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_CENSO").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_SEMILLA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_SEMILLA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_SEMILLA").Visible = Value
        End Set
    End Property

    Public Property VerULTIMO_MADURANTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ULTIMO_MADURANTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ULTIMO_MADURANTE").Visible = Value
        End Set
    End Property

    Public Property VerULTIMA_FECHA_MADURANTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ULTIMA_FECHA_MADURANTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ULTIMA_FECHA_MADURANTE").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_SALDO_VAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_SALDO_VAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_SALDO_VAR").Visible = Value
        End Set
    End Property

    Public Property VerLBS_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS_CENSO").Visible = Value
        End Set
    End Property

    Public Property VerVALOR_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("VALOR_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("VALOR_CENSO").Visible = Value
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

    Public Property VerCODIAGRON() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIAGRON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIAGRON").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_SIEMBRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_SIEMBRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_SIEMBRA").Visible = Value
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

    Public Property VerID_TIPO_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_ALZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_ALZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_ALZA").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_TRANS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_TRANS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_TRANS").Visible = Value
        End Set
    End Property

    Public Property VerFAB_SEMANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FAB_SEMANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FAB_SEMANA").Visible = Value
        End Set
    End Property

    Public Property VerFAB_CATORCENA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FABRICA_CATORCENA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FABRICA_CATORCENA").Visible = Value
        End Set
    End Property

    Public Property VerFAB_SUBTERCIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FAB_SUBTERCIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FAB_SUBTERCIO").Visible = Value
        End Set
    End Property

    Public Property VerFAB_TERCIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FAB_TERCIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FAB_TERCIO").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_ALZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_ALZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_ALZA").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_TRANS() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_TRANS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_TRANS").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_CORTA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_CORTA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_CORTA").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_LARGA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_LARGA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_LARGA").Visible = Value
        End Set
    End Property

    Public Property VerSALDO_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SALDO_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SALDO_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerEDAD_LOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("EDAD_LOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EDAD_LOTE").Visible = Value
        End Set
    End Property

    Public Property VerSALDO_QUEMA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SALDO_QUEMA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SALDO_QUEMA").Visible = Value
        End Set
    End Property

    Public Property HeaderID_ESTICANA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ESTICANA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ESTICANA").Caption = Value
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

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderREND_COSECHA() As String
        Get
            Return Me.dxgvLista.Columns("REND_COSECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND_COSECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ_ENTREGAR() As String
        Get
            Return Me.dxgvLista.Columns("MZ_ENTREGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ_ENTREGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_MZ_ENTREGAR() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_ENTREGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_MZ_ENTREGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_ENTREGAR() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_ENTREGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_ENTREGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS_ENTREGAR() As String
        Get
            Return Me.dxgvLista.Columns("LBS_ENTREGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS_ENTREGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderVALOR_ENTREGAR() As String
        Get
            Return Me.dxgvLista.Columns("VALOR_ENTREGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("VALOR_ENTREGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("MZ_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_MZ_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_MZ_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("LBS_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderVALOR_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("VALOR_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("VALOR_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ_CENSO() As String
        Get
            Return Me.dxgvLista.Columns("MZ_CENSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ_CENSO").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_MZ_CENSO() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_CENSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_MZ_CENSO").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_CENSO() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_CENSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_CENSO").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS_CENSO() As String
        Get
            Return Me.dxgvLista.Columns("LBS_CENSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS_CENSO").Caption = Value
        End Set
    End Property

    Public Property HeaderVALOR_CENSO() As String
        Get
            Return Me.dxgvLista.Columns("VALOR_CENSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("VALOR_CENSO").Caption = Value
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

    Public Property HeaderCODIAGRON() As String
        Get
            Return Me.dxgvLista.Columns("CODIAGRON").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIAGRON").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_SIEMBRA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_SIEMBRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_SIEMBRA").Caption = Value
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

    Public Property HeaderID_TIPO_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_ALZA() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_ALZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_ALZA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_TRANS() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_TRANS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_TRANS").Caption = Value
        End Set
    End Property

    Public Property HeaderFAB_SEMANA() As String
        Get
            Return Me.dxgvLista.Columns("FAB_SEMANA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FAB_SEMANA").Caption = Value
        End Set
    End Property

    Public Property HeaderFAB_CATORCENA() As String
        Get
            Return Me.dxgvLista.Columns("FAB_CATORCENA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FAB_CATORCENA").Caption = Value
        End Set
    End Property

    Public Property HeaderFAB_SUBTERCIO() As String
        Get
            Return Me.dxgvLista.Columns("FAB_SUBTERCIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FAB_SUBTERCIO").Caption = Value
        End Set
    End Property

    Public Property HeaderFAB_TERCIO() As String
        Get
            Return Me.dxgvLista.Columns("FAB_TERCIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FAB_TERCIO").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_ALZA() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_ALZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_ALZA").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_TRANS() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_TRANS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_TRANS").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_CORTA() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_CORTA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_CORTA").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_LARGA() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_LARGA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_LARGA").Caption = Value
        End Set
    End Property

    Public Property HeaderSALDO_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("SALDO_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SALDO_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderEDAD_LOTE() As String
        Get
            Return Me.dxgvLista.Columns("EDAD_LOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EDAD_LOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderSALDO_QUEMA() As String
        Get
            Return Me.dxgvLista.Columns("SALDO_QUEMA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SALDO_QUEMA").Caption = Value
        End Set
    End Property

#End Region

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
    End Sub

    Public WriteOnly Property SeleccionarFila() As Object
        Set(value As Object)
            Dim indice As Int32
            Me.dxgvLista.Selection.SelectRowByKey(value)
            indice = Me.dxgvLista.FindVisibleIndexByKeyValue(value)
            Me.dxgvLista.FocusedRowIndex = indice
        End Set
    End Property


    Public Sub ExportarExcel()
        gridExport.WriteXlsxToResponse(New DevExpress.XtraPrinting.XlsxExportOptionsEx With {.ExportType = DevExpress.Export.ExportType.WYSIWYG})
    End Sub

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
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ESTICANA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal ID_ZAFRA As Int32,
                                             ByVal ZONA As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal NOMBLOTE As String,
                                             ByVal NO_CONTRATO As Int32,
                                             ByVal CODIAGRON As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsListaPorCriterios.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsListaPorCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaPorCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaPorCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorCriterios.SelectParameters("NOMBLOTE").DefaultValue = NOMBLOTE
        Me.odsListaPorCriterios.SelectParameters("NO_CONTRATO").DefaultValue = NO_CONTRATO.ToString
        Me.odsListaPorCriterios.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

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
    Public Function CargarDatosParaIngresoInventario(ByVal ID_ZAFRA As Int32,
                                             ByVal ZONA As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal NOMBRE_PROVEEDOR As String) As Integer
        Me.odsListaParaIngresoInventario.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsListaParaIngresoInventario.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsListaParaIngresoInventario.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaParaIngresoInventario.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaParaIngresoInventario.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaParaIngresoInventario.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaParaIngresoInventario"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorProForma(ByVal ID_ZAFRA As Int32,
                                             ByVal TIPOS_TRANSPORTE As String,
                                             ByVal CON_SALDO_ROZA As Boolean) As Integer
        Me.odsListaProforma.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsListaProforma.SelectParameters("TIPOS_TRANSPORTE").DefaultValue = TIPOS_TRANSPORTE
        Me.odsListaProforma.SelectParameters("CON_SALDO_ROZA").DefaultValue = CON_SALDO_ROZA
        Me.odsListaProforma.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaProforma"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ESTICANA
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLOTES(ByVal ACCESLOTE As String) As Integer
        Me.odsListaPorLOTES.SelectParameters("ACCESLOTE").DefaultValue = ACCESLOTE.ToString()
        Me.odsListaPorLOTES.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorLOTES.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorLOTES.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorLOTES.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorLOTES.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorLOTES"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ESTICANA
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZAFRA(ByVal ID_ZAFRA As Int32) As Integer
        Me.odsListaPorZAFRA.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorZAFRA.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ESTICANA
    ''' filtrado por la tabla AGRONOMO
    ''' </summary>
    ''' <param name="CODIAGRON"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorAGRONOMO(ByVal CODIAGRON As String) As Integer
        Me.odsListaPorAGRONOMO.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON.ToString()
        Me.odsListaPorAGRONOMO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorAGRONOMO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorAGRONOMO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorAGRONOMO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorAGRONOMO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorAGRONOMO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ESTICANA
    ''' filtrado por la tabla TIPOS_GENERALES
    ''' </summary>
    ''' <param name="ID_TIPO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPOS_GENERALES(ByVal ID_TIPO As Int32) As Integer
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("ID_TIPO").DefaultValue = ID_TIPO.ToString()
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPOS_GENERALES.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPOS_GENERALES"
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
                keyValues(i) = grid.GetRowValues(i, "ID_ESTICANA")
                keyNames(i) = grid.GetRowValues(i, "ACCESLOTE")
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
        Me.dxgvLista.Columns("colEditar").Visible = Me.PermitirEditar OrElse Me.PermitirEditarInline
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        End If
        If Me.PermitirEditarInline2 Then
            Me.dxgvLista.Columns("Edicion2").Visible = True
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowNewButtonInHeader = False
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = Me.PermitirEditarInline2
        Else
            Me.dxgvLista.Columns("Edicion2").Visible = False
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "ControlQuema" Then
            RaiseEvent Quemando(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "ControlRoza" Then
            RaiseEvent Rozando(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "EmitirProforma" Then
            RaiseEvent EmitiendoProforma(e.KeyValue)
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
                'lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                'lbDetalle.Visible = False
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

    Public Function DevolverSeleccionados() As listaESTICANA
        Dim mLista As New listaESTICANA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ESTICANA")
            Dim lEntidad As New ESTICANA
            lEntidad.ID_ESTICANA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ESTICANA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ESTICANA)

            If Me.mComponente.EliminarESTICANA(lEntidad.ID_ESTICANA) <> 1 Then
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
        Static accesLote As String
        Static lLote As LOTES
        Static codiProvee As String
        Static codiSocio As String
        Static nombreProveedor As String
        Static codiLote As String
        Static nombLote As String
        Static contrato As String
        Static zona As String
        Static area_contratada As Decimal
        Static tonel_contratada As Decimal
        Static listamadurante As listaSOLIC_APLICA_LOTE
        Dim bAplicaMadurante As New cSOLIC_APLICA_LOTE

        If accesLote <> e.GetListSourceFieldValue("ACCESLOTE") Then
            accesLote = e.GetListSourceFieldValue("ACCESLOTE")
            codiProvee = ""
            codiSocio = ""
            nombreProveedor = ""
            codiLote = ""
            nombLote = ""
            contrato = ""
            zona = ""
            area_contratada = 0
            tonel_contratada = 0

            If e.GetListSourceFieldValue("ACCESLOTE") IsNot Nothing AndAlso Convert.ToBoolean(e.GetListSourceFieldValue("CONTRATADO")) Then
                lLote = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
                If lLote IsNot Nothing Then

                    Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(lLote.CODICONTRATO)
                    If lContrato IsNot Nothing Then contrato = lContrato.NO_CONTRATO.ToString
                    listamadurante = bAplicaMadurante.ObtenerListaPorZAFRA_LOTE_CATEGORIA(e.GetListSourceFieldValue("ID_ZAFRA"), accesLote, Enumeradores.CategoriaProducto.Madurante, "FECHA_APLICA", "DESC")

                    area_contratada = lLote.AREA
                    tonel_contratada = lLote.TONEL_TC
                End If
            End If
        End If
        If e.Column.FieldName = "CODIPROVEE" Then
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            If lProveedor IsNot Nothing Then
                e.Value = CInt(lProveedor.CODIPROVEE).ToString
            End If
        ElseIf e.Column.FieldName = "CODISOCIO" Then
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            If lProveedor IsNot Nothing Then
                If lProveedor.CODISOCIO <> Utilerias.FormatoCODISOCIO(0) Then e.Value = CInt(lProveedor.CODISOCIO).ToString
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            If lProveedor IsNot Nothing Then
                e.Value = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
            End If
        ElseIf e.Column.FieldName = "CONTRATO" Then
            e.Value = contrato
        ElseIf e.Column.FieldName = "ZONA" Then
            If e.GetListSourceFieldValue("ACCESLOTE") IsNot Nothing Then
                Dim lEntidad As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.ZONA
                End If
            Else
                Dim lEntidad As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue(""))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.ZONA
                End If
            End If
        ElseIf e.Column.FieldName = "AREA_CONTRATADA" Then
            e.Value = area_contratada
        ElseIf e.Column.FieldName = "TONEL_CONTRATADA" Then
            e.Value = tonel_contratada
        ElseIf e.Column.FieldName = "FABRICA_CATORCENA" Then
            e.Value = If(e.GetListSourceFieldValue("FAB_CATORCENA") = -1, "", CStr(e.GetListSourceFieldValue("FAB_CATORCENA")))
        ElseIf e.Column.FieldName = "ULTIMO_MADURANTE" Then
            If listamadurante IsNot Nothing AndAlso listamadurante.Count > 0 Then
                e.Value = listamadurante(0).NOMBRE_PRODUCTO
            End If
        ElseIf e.Column.FieldName = "ULTIMA_FECHA_MADURANTE" Then
            If listamadurante IsNot Nothing AndAlso listamadurante.Count > 0 Then
                e.Value = listamadurante(0).FECHA_APLICA.ToString("dd/MM/yyyy")
            End If
        End If
    End Sub

    Protected Sub dxgvLista_RowValidating(sender As Object, e As DevExpress.Web.Data.ASPxDataValidationEventArgs) Handles dxgvLista.RowValidating

        Dim fechaRoza As Date = #12:00:00 AM#
        Dim tcMz As Decimal = 0
        Dim tcSemilla As Decimal = 0
        Dim acceslote As String = ""
        Dim finLote As Boolean = False
        Dim idzafra As Int32 = 0

        For Each column As GridViewColumn In dxgvLista.Columns
            Dim dataColumn As GridViewDataColumn = TryCast(column, GridViewDataColumn)

            If Not dataColumn Is Nothing Then
                Select Case dataColumn.FieldName
                    Case "ID_ZAFRA"
                        idzafra = dxgvLista.GetRowValues(e.VisibleIndex, "ID_ZAFRA")
                    Case "ACCESLOTE"
                        acceslote = dxgvLista.GetRowValues(e.VisibleIndex, "ACCESLOTE")
                    Case "FIN_LOTE"
                        finLote = e.NewValues(dataColumn.FieldName)

                    Case "FECHA_ROZA"
                        If e.NewValues(dataColumn.FieldName) IsNot Nothing Then
                            fechaRoza = e.NewValues(dataColumn.FieldName)
                        End If

                    Case "TONEL_MZ_CENSO"
                        If e.NewValues(dataColumn.FieldName) Is Nothing Then
                            e.Errors(dataColumn) = "Ingrese el rendimiento por manzana"
                        Else
                            tcMz = e.NewValues(dataColumn.FieldName)
                        End If
                    Case "TONEL_SEMILLA"
                        If e.NewValues(dataColumn.FieldName) Is Nothing Then
                            e.Errors(dataColumn) = "Ingrese el valor de semilla"
                        Else
                            tcSemilla = e.NewValues(dataColumn.FieldName)
                        End If
                End Select
            End If
        Next column

        If tcMz > 0 AndAlso fechaRoza = #12:00:00 AM# Then
            e.Errors(dxgvLista.Columns("FECHA_ROZA")) = "Ingrese la fecha de roza"
            Return
        End If
        If fechaRoza <> #12:00:00 AM# Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(idzafra)
            If lZafra IsNot Nothing Then
                If fechaRoza < lZafra.FECHA_INICIO OrElse
                        fechaRoza > lZafra.FECHA_FINAL Then
                    e.Errors(dxgvLista.Columns("FECHA_ROZA")) = "La fecha de roza debe estar comprendida en el periodo de la zafra"
                    Return
                End If
            End If
        End If
        If finLote Then
            'Liquidar saldos de quema y roza
            LiqidarSaldosQuemaRoza(idzafra, acceslote)
        End If
    End Sub

    Private Sub LiqidarSaldosQuemaRoza(ByVal idzafra As Int32, ByVal acceslote As String)
        Dim bControlQuema As New cCONTROL_QUEMA
        Dim lControlQuema As New CONTROL_QUEMA
        Dim listaSaldoQuema As listaCONTROL_QUEMA_SALDO

        Dim bControlRoza As New cCONTROL_ROZA
        Dim lControlRoza As New CONTROL_ROZA
        Dim bControlRozaSaldo As New cCONTROL_ROZA_SALDO
        Dim listaRoza As listaCONTROL_ROZA_SALDO

        listaSaldoQuema = (New cCONTROL_QUEMA_SALDO).ObtenerListaPorCriterios(idzafra, acceslote, Nothing, -1, -1, -1, 0, True)
        If listaSaldoQuema IsNot Nothing AndAlso listaSaldoQuema.Count > 0 Then
            For Each lQuemaSaldo As CONTROL_QUEMA_SALDO In listaSaldoQuema
                If lQuemaSaldo.SALDO > 0 Then
                    lControlQuema = New CONTROL_QUEMA

                    lControlQuema.ID_CONTROL_QUEMA = 0
                    lControlQuema.ID_ZAFRA = idzafra
                    lControlQuema.ACCESLOTE = acceslote
                    lControlQuema.CONCEPTO = "MOVIMIENTO DE LIQUIDACION DE SALDO POR CIERRE LOTE " + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm")
                    lControlQuema.CODIGO_REF = "AJUSTE"
                    lControlQuema.ID_REF = -1
                    lControlQuema.ENTRADAS = 0
                    lControlQuema.SALIDAS = lQuemaSaldo.SALDO
                    lControlQuema.SALDO = 0
                    lControlQuema.QUEMA_PROGRAMADA = lQuemaSaldo.QUEMA_PROGRAMADA
                    lControlQuema.QUEMA_NOPROG = lQuemaSaldo.QUEMA_NOPROG
                    lControlQuema.CANA_VERDE = lQuemaSaldo.CANA_VERDE
                    lControlQuema.FECHA_HORA_QUEMA = lQuemaSaldo.FECHA_HORA_QUEMA
                    lControlQuema.USUARIO_CREA = Me.ObtenerUsuario
                    lControlQuema.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lControlQuema.USUARIO_ACT = Me.ObtenerUsuario
                    lControlQuema.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    lControlQuema.ID_CONTROL_QUEMA_REF = -1
                    lControlQuema.ES_PROYECCION = False
                    lControlQuema.ID_QUEMA_SALDO = lQuemaSaldo.ID_QUEMA_SALDO
                    bControlQuema.ActualizarCONTROL_QUEMA(lControlQuema)
                End If
            Next
        End If

        listaRoza = (New cCONTROL_ROZA_SALDO).ObtenerListaPorCriterios(idzafra, acceslote, -1, -1, -1, "", "", -1, -1, -1, "", -1, 0, -1, -1)
        If listaRoza IsNot Nothing AndAlso listaRoza.Count > 0 Then
            For Each lControlRozaSaldo As CONTROL_ROZA_SALDO In listaRoza
                If lControlRozaSaldo.SALDO > 0 Then
                    lControlRoza.ID_CONTROL_ROZA = 0
                    lControlRoza.ID_ZAFRA = idzafra
                    lControlRoza.ACCESLOTE = acceslote
                    Dim lDiaZafra As DIA_ZAFRA
                    lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(idzafra)
                    If lDiaZafra IsNot Nothing Then lControlRoza.DIAZAFRA = lDiaZafra.DIAZAFRA
                    lControlRoza.FECHA_HORA_QUEMA = lControlRozaSaldo.FECHA_HORA_QUEMA
                    lControlRoza.FECHA_HORA_ROZA = lControlRozaSaldo.FECHA_HORA_ROZA
                    lControlRoza.ID_PROVEEDOR_ROZA = -1
                    lControlRoza.CONCEPTO = "MOVIMIENTO DE LIQUIDACION TOTAL DE SALDO POR CIERRE DE LOTE EN FECHA " + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm")
                    lControlRoza.CODIGO_REF = "AJUSTE"
                    lControlRoza.ID_REF = -1
                    lControlRoza.ENTRADAS = 0
                    lControlRoza.SALIDAS = lControlRozaSaldo.SALDO
                    lControlRoza.SALDO = 0
                    lControlRoza.ID_TIPO_CANA = lControlRozaSaldo.ID_TIPO_CANA
                    lControlRoza.ID_TIPO_ROZA = lControlRozaSaldo.ID_TIPO_ROZA
                    lControlRoza.USUARIO_CREA = Me.ObtenerUsuario
                    lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lControlRoza.USUARIO_ACT = Me.ObtenerUsuario
                    lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    lControlRoza.QUEMA_PROGRAMADA = lControlRozaSaldo.QUEMA_PROGRAMADA
                    lControlRoza.QUEMA_NOPROG = lControlRozaSaldo.QUEMA_NOPROG
                    lControlRoza.CANA_VERDE = lControlRozaSaldo.CANA_VERDE
                    lControlRoza.ID_ROZA_SALDO = lControlRozaSaldo.ID_ROZA_SALDO
                    lControlRoza.ES_PROYECCION = lControlRozaSaldo.ES_PROYECCION
                    bControlRoza.ActualizarCONTROL_ROZA(lControlRoza)
                End If
            Next
        End If
    End Sub
End Class
