Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPLAN_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PLAN_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPLAN_COSECHA
    Inherits ucListaBase

    Private mComponente As New cPLAN_COSECHA
    Public Event Seleccionado(ByVal ID_PLAN_COSECHA As Int32)
    Public Event Editando(ByVal ID_PLAN_COSECHA As Int32)
    Public Event Quemando(ByVal ID_PLAN_COSECHA As Int32)
    Public Event Rozando(ByVal ID_PLAN_COSECHA As Int32)
    Public Event ModiQuema(ByVal ID_PLAN_COSECHA As Int32)
    Public Event EmitiendoProforma(ByVal ID_PLAN_COSECHA As Int32)

#Region "Propiedades"

    Public Property Habilitar As Boolean
        Get
            Return Me.dxgvLista.Enabled
        End Get
        Set(value As Boolean)
            Me.dxgvLista.Enabled = value
        End Set
    End Property
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

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = Value
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

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
    End Sub

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

    Public Property VerID_PLAN_COSECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PLAN_COSECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PLAN_COSECHA").Visible = Value
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

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACCESLOTE").Visible = Value
        End Set
    End Property

    Public Property VerMZ_SALDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ_SALDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ_SALDO").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_SALDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_SALDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_SALDO").Visible = Value
        End Set
    End Property

    Public Property VerMZ_COSECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ_COSECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ_COSECHA").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_MZ_COSECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_COSECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_MZ_COSECHA").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_COSECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_COSECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_COSECHA").Visible = Value
        End Set
    End Property

    Public Property VerCUOTA_DIARIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CUOTA_DIARIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CUOTA_DIARIA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INI_COSECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INI_COSECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INI_COSECHA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_FIN_COSECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_FIN_COSECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_FIN_COSECHA").Visible = Value
        End Set
    End Property

    Public Property VerTOTAL_SEMANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL_SEMANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL_SEMANA").Visible = Value
        End Set
    End Property

    Public Property VerQUEMA_PROGRAMADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("QUEMA_PROGRAMADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("QUEMA_PROGRAMADA").Visible = Value
        End Set
    End Property

    Public Property VerQUEMA_NO_PROGRAMADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("QUEMA_NO_PROGRAMADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("QUEMA_NO_PROGRAMADA").Visible = Value
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

    Public Property VerZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZONA").Visible = Value
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

    Public Property VerCATORCENA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CATORCENA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CATORCENA").Visible = Value
        End Set
    End Property

    Public Property VerSEMANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SEMANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SEMANA").Visible = Value
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

    Public Property VerSALDO_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SALDO_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SALDO_ROZA").Visible = Value
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

    Public Property VerID_TIPOTRANS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPOTRANS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPOTRANS").Visible = Value
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

    Public Property HeaderID_PLAN_COSECHA() As String
        Get
            Return Me.dxgvLista.Columns("ID_PLAN_COSECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PLAN_COSECHA").Caption = Value
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

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACCESLOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ_SALDO() As String
        Get
            Return Me.dxgvLista.Columns("MZ_SALDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ_SALDO").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_SALDO() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_SALDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_SALDO").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ_COSECHA() As String
        Get
            Return Me.dxgvLista.Columns("MZ_COSECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ_COSECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_MZ_COSECHA() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_COSECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_MZ_COSECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_COSECHA() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_COSECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_COSECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderCUOTA_DIARIA() As String
        Get
            Return Me.dxgvLista.Columns("CUOTA_DIARIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CUOTA_DIARIA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INI_COSECHA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INI_COSECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INI_COSECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_FIN_COSECHA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_FIN_COSECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_FIN_COSECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderTOTAL_SEMANA() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL_SEMANA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL_SEMANA").Caption = Value
        End Set
    End Property

    Public Property HeaderQUEMA_PROGRAMADA() As String
        Get
            Return Me.dxgvLista.Columns("QUEMA_PROGRAMADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("QUEMA_PROGRAMADA").Caption = Value
        End Set
    End Property

    Public Property HeaderQUEMA_NO_PROGRAMADA() As String
        Get
            Return Me.dxgvLista.Columns("QUEMA_NO_PROGRAMADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("QUEMA_NO_PROGRAMADA").Caption = Value
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

    Public Property HeaderID_CARGADORA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CARGADORA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CARGADORA").Caption = Value
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

    Public Property HeaderID_TIPOTRANS() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPOTRANS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPOTRANS").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_COSECHA
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_COSECHA
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_COSECHA
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLOTES(ByVal ACCESLOTE As String) As Integer
        Me.odsListaPorLOTES.SelectParameters("ACCESLOTE").DefaultValue = ACCESLOTE.ToString()
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

    Public Function CargarDatosPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal SUB_ZONA As String, _
                                             ByVal CATORCENA As Int32, _
                                             ByVal SEMANA As Int32, _
                                             ByVal FECHA_INI As Object, _
                                             ByVal FECHA_FIN As Object, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal CODIAGRON As String, _
                                             ByVal TIPOS_TRANSPORTE As String, _
                                             ByVal CON_SALDO_ROZA As Boolean, _
                                             ByVal FIN_LOTE As Int32, _
                                             ByVal CON_CUOTA_DIARIA As Boolean) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorCriterios.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsListaPorCriterios.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.odsListaPorCriterios.SelectParameters("CATORCENA").DefaultValue = CATORCENA
        Me.odsListaPorCriterios.SelectParameters("SEMANA").DefaultValue = SEMANA
        Me.odsListaPorCriterios.SelectParameters("FECHA_INI").DefaultValue = FECHA_INI
        Me.odsListaPorCriterios.SelectParameters("FECHA_FIN").DefaultValue = FECHA_FIN
        Me.odsListaPorCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaPorCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaPorCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorCriterios.SelectParameters("NO_CONTRATO").DefaultValue = NO_CONTRATO
        Me.odsListaPorCriterios.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON
        Me.odsListaPorCriterios.SelectParameters("TIPOS_TRANSPORTE").DefaultValue = TIPOS_TRANSPORTE
        Me.odsListaPorCriterios.SelectParameters("CON_SALDO_ROZA").DefaultValue = CON_SALDO_ROZA
        Me.odsListaPorCriterios.SelectParameters("FIN_LOTE").DefaultValue = FIN_LOTE
        Me.odsListaPorCriterios.SelectParameters("CON_CUOTA_DIARIA").DefaultValue = CON_CUOTA_DIARIA
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosParaProforma(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal SUB_ZONA As String, _
                                             ByVal CATORCENA As Int32, _
                                             ByVal SEMANA As Int32, _
                                             ByVal FECHA_INI As Object, _
                                             ByVal FECHA_FIN As Object, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal CODIAGRON As String, _
                                             ByVal TIPOS_TRANSPORTE As String, _
                                             ByVal CON_SALDO_ROZA As Boolean, _
                                             ByVal FIN_LOTE As Int32, _
                                             ByVal FECHA_PROFORMA As DateTime) As Integer
        Me.odsListaParaProforma.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaParaProforma.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsListaParaProforma.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.odsListaParaProforma.SelectParameters("CATORCENA").DefaultValue = CATORCENA
        Me.odsListaParaProforma.SelectParameters("SEMANA").DefaultValue = SEMANA
        Me.odsListaParaProforma.SelectParameters("FECHA_INI").DefaultValue = FECHA_INI
        Me.odsListaParaProforma.SelectParameters("FECHA_FIN").DefaultValue = FECHA_FIN
        Me.odsListaParaProforma.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaParaProforma.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaParaProforma.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaParaProforma.SelectParameters("NO_CONTRATO").DefaultValue = NO_CONTRATO
        Me.odsListaParaProforma.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON
        Me.odsListaParaProforma.SelectParameters("TIPOS_TRANSPORTE").DefaultValue = TIPOS_TRANSPORTE
        Me.odsListaParaProforma.SelectParameters("CON_SALDO_ROZA").DefaultValue = CON_SALDO_ROZA
        Me.odsListaParaProforma.SelectParameters("FIN_LOTE").DefaultValue = FIN_LOTE
        Me.odsListaParaProforma.SelectParameters("FECHA_PROFORMA").DefaultValue = FECHA_PROFORMA
        Me.odsListaParaProforma.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaParaProforma"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_COSECHA
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
                keyValues(i) = grid.GetRowValues(i, "ID_PLAN_COSECHA")
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
        Me.dxgvLista.Columns("colEditar").Visible = Me.PermitirEditar OrElse Me.PermitirEditarInline
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
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
            If Me.PermitirEmitirProforma Then
                Dim imgProforma As ImageButton
                imgProforma = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEmitirProforma")
                If imgProforma IsNot Nothing Then
                    If CDbl(dxgvLista.GetRowValues(e.VisibleIndex, "SALDO_ROZA")) <= 0 Then
                        imgProforma.Visible = False
                    End If
                End If
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

    Public Function DevolverSeleccionados() As listaPLAN_COSECHA
        Dim mLista As New listaPLAN_COSECHA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_PLAN_COSECHA")
            Dim lEntidad As PLAN_COSECHA = (New cPLAN_COSECHA).ObtenerPLAN_COSECHA(llave)
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PLAN_COSECHA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PLAN_COSECHA)

            If Me.mComponente.EliminarPLAN_COSECHA(lEntidad.ID_PLAN_COSECHA) <> 1 Then
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
        If e.Column.FieldName = "CODIPROVEE" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                Dim lContrato As CONTRATO
                Dim lProveedor As PROVEEDOR
                lContrato = (New cCONTRATO).ObtenerCONTRATO(lLote.CODICONTRATO)
                lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lContrato.CODIPROVEEDOR)
                e.Value = CInt(lProveedor.CODIPROVEE)
            End If
        ElseIf e.Column.FieldName = "CODISOCIO" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                Dim lContrato As CONTRATO
                Dim lProveedor As PROVEEDOR
                lContrato = (New cCONTRATO).ObtenerCONTRATO(lLote.CODICONTRATO)
                lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lContrato.CODIPROVEEDOR)
                If lProveedor.CODISOCIO <> Utilerias.FormatoCODISOCIO(0) Then e.Value = CInt(lProveedor.CODISOCIO)
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                Dim lProveedor As PROVEEDOR
                lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
                If lProveedor IsNot Nothing Then e.Value = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
            End If
        ElseIf e.Column.FieldName = "ZONA" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then e.Value = lLote.ZONA
        ElseIf e.Column.FieldName = "CODILOTE" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then e.Value = lLote.CODILOTE
        ElseIf e.Column.FieldName = "NOMBLOTE" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then e.Value = lLote.NOMBLOTE
        ElseIf e.Column.FieldName = "SALDO_ROZA" Then
            If e.GetListSourceFieldValue("ID_ZAFRA") IsNot Nothing AndAlso e.GetListSourceFieldValue("ACCESLOTE") IsNot Nothing Then
                Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(e.GetListSourceFieldValue("ACCESLOTE"), CInt(e.GetListSourceFieldValue("ID_ZAFRA")))
                If lLoteCosecha IsNot Nothing Then
                    e.Value = lLoteCosecha.SALDO_ROZA
                End If
            End If
        ElseIf e.Column.FieldName = "SALDO_QUEMA" Then
            If e.GetListSourceFieldValue("ID_ZAFRA") IsNot Nothing AndAlso e.GetListSourceFieldValue("ACCESLOTE") IsNot Nothing Then
                Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(e.GetListSourceFieldValue("ACCESLOTE"), CInt(e.GetListSourceFieldValue("ID_ZAFRA")))
                If lLoteCosecha IsNot Nothing Then
                    e.Value = lLoteCosecha.SALDO_QUEMA
                End If
            End If
        End If
    End Sub
End Class
