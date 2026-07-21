Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCONTROL_ROZA_SALDO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CONTROL_ROZA_SALDO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/12/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCONTROL_ROZA_SALDO
    Inherits ucListaBase
 
    Private mComponente As New cCONTROL_ROZA_SALDO
    Public Event Seleccionado(ByVal ID_ROZA_SALDO As Int32) 
    Public Event Editando(ByVal ID_ROZA_SALDO As Int32)
    Public Event ModificarFechaQuema(ByVal ID_ROZA_SALDO As Int32)
    Public Event ModificarTCRoza(ByVal ID_ROZA_SALDO As Int32)
    Public Event IncrementarSaldo(ByVal ID_ROZA_SALDO As Int32)

#Region "Propiedades"

    Public Property VerIncrementoSaldo() As Boolean
        Get
            Return Me.dxgvLista.Columns("colIncrementoSaldo").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colIncrementoSaldo").Visible = Value
        End Set
    End Property

    Public Property VerModificacionFechaQuema() As Boolean
        Get
            Return Me.dxgvLista.Columns("colModificacionFechaQuema").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colModificacionFechaQuema").Visible = Value
        End Set
    End Property

    Public Property VerModificacionTCRoza() As Boolean
        Get
            Return Me.dxgvLista.Columns("colModificacionTCRoza").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colModificacionTCRoza").Visible = Value
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

    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = Value
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

    Public Property VerID_ROZA_SALDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ROZA_SALDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ROZA_SALDO").Visible = Value
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


    Public Property VerCODI_PROVEE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_PROVEE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_PROVEE").Visible = Value
        End Set
    End Property
    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible = Value
        End Set
    End Property
    Public Property VerCODILOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODILOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODILOTE").Visible = Value
        End Set
    End Property
    Public Property VerNOMBLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBLOTE").Visible = Value
        End Set
    End Property
    Public Property VerFECHA_HORA_QUEMA_PROY() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_HORA_QUEMA_PROY2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_HORA_QUEMA_PROY2").Visible = Value
        End Set
    End Property
    Public Property VerFECHA_HORA_ROZA_PROY() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_HORA_ROZA_PROY").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_HORA_ROZA_PROY").Visible = Value
        End Set
    End Property
    Public Property VerFECHA_HORA_QUEMA_REAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_HORA_QUEMA_REAL2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_HORA_QUEMA_REAL2").Visible = Value
        End Set
    End Property
    Public Property VerFECHA_HORA_ROZA_REAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_HORA_ROZA_REAL2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_HORA_ROZA_REAL2").Visible = Value
        End Set
    End Property
    Public Property VerTC_PROY() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_PROY").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_PROY").Visible = Value
        End Set
    End Property
    Public Property VerTC_REAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_REAL2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_REAL2").Visible = Value
        End Set
    End Property

    Public Property VerHORAS_QUEMA() As Boolean
        Get
            Return Me.dxgvLista.Columns("HORAS_QUEMA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HORAS_QUEMA").Visible = Value
        End Set
    End Property
    Public Property VerHORAS_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("HORAS_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HORAS_ROZA").Visible = Value
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

    Public Property VerFECHA_HORA_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_HORA_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_HORA_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_HORA_QUEMA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_HORA_QUEMA_CALC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_HORA_QUEMA_CALC").Visible = Value
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

    Public Property VerQUEMA_NOPROG() As Boolean
        Get
            Return Me.dxgvLista.Columns("QUEMA_NOPROG").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("QUEMA_NOPROG").Visible = Value
        End Set
    End Property

    Public Property VerCANA_VERDE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANA_VERDE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANA_VERDE").Visible = Value
        End Set
    End Property

    Public Property VerENTRADAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ENTRADAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ENTRADAS").Visible = Value
        End Set
    End Property

    Public Property VerSALIDAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("SALIDAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SALIDAS").Visible = Value
        End Set
    End Property

    Public Property VerSALDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SALDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SALDO").Visible = Value
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

    Public Property HeaderID_ROZA_SALDO() As String
        Get
            Return Me.dxgvLista.Columns("ID_ROZA_SALDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ROZA_SALDO").Caption = Value
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

    Public Property HeaderID_PROVEEDOR_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROVEEDOR_ROZA").Caption = Value
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

    Public Property HeaderFECHA_HORA_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_HORA_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_HORA_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_HORA_QUEMA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_HORA_QUEMA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_HORA_QUEMA").Caption = Value
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

    Public Property HeaderQUEMA_NOPROG() As String
        Get
            Return Me.dxgvLista.Columns("QUEMA_NOPROG").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("QUEMA_NOPROG").Caption = Value
        End Set
    End Property

    Public Property HeaderCANA_VERDE() As String
        Get
            Return Me.dxgvLista.Columns("CANA_VERDE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CANA_VERDE").Caption = Value
        End Set
    End Property

    Public Property HeaderENTRADAS() As String
        Get
            Return Me.dxgvLista.Columns("ENTRADAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ENTRADAS").Caption = Value
        End Set
    End Property

    Public Property HeaderSALIDAS() As String
        Get
            Return Me.dxgvLista.Columns("SALIDAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SALIDAS").Caption = Value
        End Set
    End Property

    Public Property HeaderSALDO() As String
        Get
            Return Me.dxgvLista.Columns("SALDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SALDO").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTROL_ROZA_SALDO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/12/2015	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTROL_ROZA_SALDO
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/12/2015	Created
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


    Public Function CargarDatosPorCriterios(ByVal ID_ZAFRA As Int32,
                                            ByVal ACCESLOTE As String,
                                            ByVal ID_PROVEEDOR_ROZA As Int32,
                                            ByVal ID_TIPO_CANA As Int32,
                                            ByVal ID_TIPO_ROZA As Int32,
                                            ByVal FECHA_HORA_QUEMA As String,
                                            ByVal FECHA_HORA_ROZA As String,
                                            ByVal QUEMA_PROGRAMADA As Int32,
                                            ByVal QUEMA_NOPROG As Int32,
                                            ByVal CANA_VERDE As Int32,
                                            ByVal CODIGO_REF As String,
                                            ByVal ID_REF As Int32,
                                            ByVal ES_PROYECCION As Int32,
                                            ByVal TIPO_SALDO As Int32,
                                            ByVal ES_QUERQUEO As Int32,
                                            ByVal ID_SUBLOTES As Int32) As Integer

        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorCriterios.SelectParameters("ACCESLOTE").DefaultValue = ACCESLOTE
        Me.odsListaPorCriterios.SelectParameters("ID_PROVEEDOR_ROZA").DefaultValue = ID_PROVEEDOR_ROZA.ToString
        Me.odsListaPorCriterios.SelectParameters("ID_TIPO_CANA").DefaultValue = ID_TIPO_CANA.ToString()
        Me.odsListaPorCriterios.SelectParameters("ID_TIPO_ROZA").DefaultValue = ID_TIPO_ROZA.ToString
        Me.odsListaPorCriterios.SelectParameters("FECHA_HORA_QUEMA").DefaultValue = FECHA_HORA_QUEMA
        Me.odsListaPorCriterios.SelectParameters("FECHA_HORA_ROZA").DefaultValue = FECHA_HORA_ROZA
        Me.odsListaPorCriterios.SelectParameters("QUEMA_PROGRAMADA").DefaultValue = QUEMA_PROGRAMADA.ToString
        Me.odsListaPorCriterios.SelectParameters("QUEMA_NOPROG").DefaultValue = QUEMA_NOPROG.ToString
        Me.odsListaPorCriterios.SelectParameters("CANA_VERDE").DefaultValue = CANA_VERDE.ToString
        Me.odsListaPorCriterios.SelectParameters("CODIGO_REF").DefaultValue = CODIGO_REF
        Me.odsListaPorCriterios.SelectParameters("ID_REF").DefaultValue = ID_REF.ToString
        Me.odsListaPorCriterios.SelectParameters("ES_PROYECCION").DefaultValue = ES_PROYECCION.ToString
        Me.odsListaPorCriterios.SelectParameters("TIPO_SALDO").DefaultValue = TIPO_SALDO
        Me.odsListaPorCriterios.SelectParameters("ES_QUERQUEO").DefaultValue = ES_QUERQUEO
        Me.odsListaPorCriterios.SelectParameters("ID_SUBLOTES").DefaultValue = ID_SUBLOTES
        Me.odsListaPorCriterios.SelectParameters("asColumnaOrden").DefaultValue = "ID_TIPO_CANA"
        Me.odsListaPorCriterios.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    Public Function CargarDatosPorCriteriosLiquidacion(ByVal ID_ZAFRA As Int32, _
                                            ByVal NO_CATORCENA As Int32, _
                                            ByVal CODIPROVEE As String, _
                                            ByVal CODISOCIO As String, _
                                            ByVal NOMBRE_PROVEEDOR As String, _
                                            ByVal NOMBRE_LOTE As String, _
                                            ByVal ES_PROYECCION As Int32, _
                                            ByVal TIPO_SALDO As Int32, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As Integer
        Me.odsListaPorLiquidacion.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString
        Me.odsListaPorLiquidacion.SelectParameters("NO_CATORCENA").DefaultValue = NO_CATORCENA.ToString
        Me.odsListaPorLiquidacion.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaPorLiquidacion.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaPorLiquidacion.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorLiquidacion.SelectParameters("NOMBRE_LOTE").DefaultValue = NOMBRE_LOTE
        Me.odsListaPorLiquidacion.SelectParameters("ES_PROYECCION").DefaultValue = ES_PROYECCION
        Me.odsListaPorLiquidacion.SelectParameters("TIPO_SALDO").DefaultValue = TIPO_SALDO.ToString
        Me.odsListaPorLiquidacion.SelectParameters("asColumnaOrden").DefaultValue = asColumnaOrden
        Me.odsListaPorLiquidacion.SelectParameters("asTipoOrden").DefaultValue = asTipoOrden
        Me.odsListaPorLiquidacion.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorLiquidacion"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTROL_ROZA_SALDO
    ''' filtrado por la tabla PROVEEDOR_ROZA
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_ROZA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/12/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32) As Integer
        Me.odsListaPorPROVEEDOR_ROZA.SelectParameters("ID_PROVEEDOR_ROZA").DefaultValue = ID_PROVEEDOR_ROZA.ToString()
        Me.odsListaPorPROVEEDOR_ROZA.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTROL_ROZA_SALDO
    ''' filtrado por la tabla TIPOS_GENERALES
    ''' </summary>
    ''' <param name="ID_TIPO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/12/2015	Created
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
                keyValues(i) = grid.GetRowValues(i, "ID_ROZA_SALDO")
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
        If e.CommandArgs.CommandName = "ModificarFechaQuema" Then
            RaiseEvent ModificarFechaQuema(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "ModificarTCRoza" Then
            RaiseEvent ModificarTCRoza(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "IncrementarSaldo" Then
            RaiseEvent IncrementarSaldo(e.KeyValue)
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
                'lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar Then
                Dim lbSeleccionar As LinkButton
                lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                lbSeleccionar.Visible = True
                lbSeleccionar.Text = Me.TextoSeleccionar
                lbSeleccionar.CommandName = Me.ComandoSeleccionar
                If lbSeleccionar.CommandName = "Check" Then
                    'lbSeleccionar.Visible = False
                End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaCONTROL_ROZA_SALDO
        Dim mLista As New listaCONTROL_ROZA_SALDO
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ROZA_SALDO")
            Dim lEntidad As New CONTROL_ROZA_SALDO
            lEntidad = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(llave)
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
    End Sub

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CONTROL_ROZA_SALDO = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CONTROL_ROZA_SALDO)

            If Me.mComponente.EliminarCONTROL_ROZA_SALDO(lEntidad.ID_ROZA_SALDO) <> 1 Then
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
        If e.Column.FieldName = "TIPO_CANA" Then
            Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(e.GetListSourceFieldValue("ID_TIPO_CANA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOM_TIPO
        ElseIf e.Column.FieldName = "CODI_PROVEE" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
                If lProveedor IsNot Nothing Then e.Value = lProveedor.CODIPROVEE
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
                If lProveedor IsNot Nothing Then e.Value = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
            End If
        ElseIf e.Column.FieldName = "CODILOTE" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                e.Value = lLote.CODILOTE
            End If
        ElseIf e.Column.FieldName = "NOMBLOTE" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                e.Value = lLote.NOMBLOTE
            End If
        ElseIf e.Column.FieldName = "TIPO_ROZA" Then
            Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(e.GetListSourceFieldValue("ID_TIPO_ROZA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOM_TIPO
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR_ROZA" Then
            Dim sFrenteRoza As String = (New cCONTROL_ROZA_SALDO).ObtenerListaPROVEEDOR_ROZA(e.GetListSourceFieldValue("ID_ROZA_SALDO"))
            e.Value = If(sFrenteRoza = "", "NO APLICA", sFrenteRoza)
        ElseIf e.Column.FieldName = "HORAS_QUEMA" Then
            Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(e.GetListSourceFieldValue("ACCESLOTE"), e.GetListSourceFieldValue("ID_ZAFRA"))
            If lLoteCosecha IsNot Nothing AndAlso lLoteCosecha.SALDO_QUEMA > 0 Then
                Dim lista As Dictionary(Of String, Int32) = (New cCONTROL_ROZA_SALDO).ObtenerHorasQuemaRozaTranscurridas(e.GetListSourceFieldValue("ID_ROZA_SALDO"))
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    e.Value = lista("HORAS_QUEMA")
                End If
            End If
        ElseIf e.Column.FieldName = "FECHA_HORA_QUEMA_CALC" Then
            If e.GetListSourceFieldValue("FECHA_HORA_QUEMA") <> #12:00:00 AM# Then
                e.Value = CDate(e.GetListSourceFieldValue("FECHA_HORA_QUEMA")).ToString("dd/MM/yyyy HH:mm")
            End If
        ElseIf e.Column.FieldName = "PROVEEDOR_QUERQUEO" Then
            If e.GetListSourceFieldValue("ID_PROVEE_QQ") > 0 Then
                Dim lEntidad As PROVEEDOR_QUERQUEO = (New cPROVEEDOR_QUERQUEO).ObtenerPROVEEDOR_QUERQUEO(CInt(e.GetListSourceFieldValue("ID_PROVEE_QQ")))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.CODISIS + "-" + lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
                End If
            End If
        ElseIf e.Column.FieldName = "HORAS_ROZA" Then
            Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(e.GetListSourceFieldValue("ACCESLOTE"), e.GetListSourceFieldValue("ID_ZAFRA"))
            If lLoteCosecha IsNot Nothing AndAlso lLoteCosecha.SALDO_ROZA > 0 Then
                Dim lista As Dictionary(Of String, Int32) = (New cCONTROL_ROZA_SALDO).ObtenerHorasQuemaRozaTranscurridas(e.GetListSourceFieldValue("ID_ROZA_SALDO"))
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    e.Value = lista("HORAS_ROZA")
                End If
            End If
        ElseIf e.Column.FieldName = "FECHA_HORA_QUEMA_PROY2" AndAlso e.GetListSourceFieldValue("FECHA_HORA_QUEMA_PROY") <> Nothing Then
            e.Value = CDate(e.GetListSourceFieldValue("FECHA_HORA_QUEMA_PROY")).ToString("dd/MM/yyyy HH:mm")
        ElseIf e.Column.FieldName = "FECHA_HORA_QUEMA_REAL2" AndAlso e.GetListSourceFieldValue("FECHA_HORA_QUEMA_REAL") <> Nothing Then
            e.Value = CDate(e.GetListSourceFieldValue("FECHA_HORA_QUEMA_REAL")).ToString("dd/MM/yyyy HH:mm")
        ElseIf e.Column.FieldName = "TC_REAL2" AndAlso e.GetListSourceFieldValue("TC_REAL") <> -1 Then
            e.Value = CDec(e.GetListSourceFieldValue("TC_REAL")).ToString("#,##0.00")
        ElseIf e.Column.FieldName = "PORCION" Then
            Dim lEntidad As SUBLOTES = (New cSUBLOTES).ObtenerSUBLOTES(e.GetListSourceFieldValue("ID_SUBLOTES"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.CODIGO + "   " + lEntidad.NOMBRE_PORCION
        End If
    End Sub

End Class
