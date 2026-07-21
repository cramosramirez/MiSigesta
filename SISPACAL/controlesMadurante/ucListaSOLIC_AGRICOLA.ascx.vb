Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web
Imports System.Data
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaSOLIC_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SOLIC_AGRICOLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSOLIC_AGRICOLA
    Inherits ucListaBase

    Private mComponente As New cSOLIC_AGRICOLA
    Public Event Seleccionado(ByVal ID_SOLICITUD As Int32)
    Public Event Editando(ByVal ID_SOLICITUD As Int32)
    Public Event GenerandoOrden(ByVal ID_SOLICITUD As Int32)

#Region "Propiedades"

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

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
    End Sub

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

    Public Property PermitirVistaPrevia() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaPrevia").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaPrevia").Visible = Value
        End Set
    End Property

    Public Property PermitirVistaAplicaciones() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaAplicacion").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaAplicacion").Visible = Value
        End Set
    End Property

    Public Property PermitirAnalisisFinanciero() As Boolean
        Get
            Return Me.dxgvLista.Columns("colAnalisisFinanciero").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colAnalisisFinanciero").Visible = Value
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

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SOLICITUD").Visible = Value
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

    Public Property VerNUM_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUM_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUM_SOLICITUD").Visible = Value
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

    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerACTIVIDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACTIVIDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACTIVIDAD").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_SOLIC() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_SOLIC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_SOLIC").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_APLICA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_APLICA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_APLICA").Visible = Value
        End Set
    End Property

    Public Property VerDUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI").Visible = Value
        End Set
    End Property

    Public Property VerNIT() As Boolean
        Get
            Return Me.dxgvLista.Columns("NIT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NIT").Visible = Value
        End Set
    End Property

    Public Property VerNRC() As Boolean
        Get
            Return Me.dxgvLista.Columns("NRC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NRC").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_CONTRIBUYENTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_CONTRIBUYENTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_CONTRIBUYENTE").Visible = Value
        End Set
    End Property

    Public Property VerSUB_TOTAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("SUB_TOTAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SUB_TOTAL").Visible = Value
        End Set
    End Property

    Public Property VerIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("IVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("IVA").Visible = Value
        End Set
    End Property

    Public Property VerTOTAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL").Visible = Value
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

    Public Property VerOBSERVACIONES() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACIONES").Visible = Value
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

    Public Property VerZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZAFRA").Visible = Value
        End Set
    End Property

    Public Property HeaderID_SOLICITUD() As String
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SOLICITUD").Caption = Value
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

    Public Property HeaderNUM_SOLICITUD() As String
        Get
            Return Me.dxgvLista.Columns("NUM_SOLICITUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUM_SOLICITUD").Caption = Value
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

    Public Property HeaderNOMBRE_PROVEEDOR() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Caption = Value
        End Set
    End Property

    Public Property HeaderACTIVIDAD() As String
        Get
            Return Me.dxgvLista.Columns("ACTIVIDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACTIVIDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_SOLIC() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_SOLIC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_SOLIC").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_APLICA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_APLICA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_APLICA").Caption = Value
        End Set
    End Property

    Public Property HeaderDUI() As String
        Get
            Return Me.dxgvLista.Columns("DUI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI").Caption = Value
        End Set
    End Property

    Public Property HeaderNIT() As String
        Get
            Return Me.dxgvLista.Columns("NIT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NIT").Caption = Value
        End Set
    End Property

    Public Property HeaderNRC() As String
        Get
            Return Me.dxgvLista.Columns("NRC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NRC").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_CONTRIBUYENTE() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_CONTRIBUYENTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_CONTRIBUYENTE").Caption = Value
        End Set
    End Property

    Public Property HeaderSUB_TOTAL() As String
        Get
            Return Me.dxgvLista.Columns("SUB_TOTAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SUB_TOTAL").Caption = Value
        End Set
    End Property

    Public Property HeaderIVA() As String
        Get
            Return Me.dxgvLista.Columns("IVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("IVA").Caption = Value
        End Set
    End Property

    Public Property HeaderTOTAL() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL").Caption = Value
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

    Public Property HeaderOBSERVACIONES() As String
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OBSERVACIONES").Caption = Value
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

    Public Property HeaderZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ZAFRA").Caption = Value
        End Set
    End Property

#End Region

    Public Sub ExportarExcel()
        gridExport.WriteXlsxToResponse(New DevExpress.XtraPrinting.XlsxExportOptionsEx With {.ExportType = DevExpress.Export.ExportType.WYSIWYG})
    End Sub

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
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_AGRICOLA
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
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
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPoCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_SOLICITUD As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NOMBLOTE As String, _
                                             ByVal FECHA_SOLICITUD As DateTime, _
                                             ByVal FECHA_APLICA As DateTime, _
                                             ByVal CODIAGRON As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorCriterios.SelectParameters("NUM_SOLICITUD").DefaultValue = NUM_SOLICITUD.ToString()
        Me.odsListaPorCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaPorCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaPorCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorCriterios.SelectParameters("NOMBLOTE").DefaultValue = NOMBLOTE
        Me.odsListaPorCriterios.SelectParameters("FECHA_SOLICITUD").DefaultValue = IIf(FECHA_SOLICITUD = Nothing, Nothing, FECHA_SOLICITUD)
        Me.odsListaPorCriterios.SelectParameters("FECHA_APLICA").DefaultValue = IIf(FECHA_APLICA = Nothing, Nothing, FECHA_APLICA)
        Me.odsListaPorCriterios.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_AGRICOLA
    ''' filtrado por la tabla PROVEEDOR
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR(ByVal CODIPROVEEDOR As String) As Integer
        Me.odsListaPorPROVEEDOR.SelectParameters("CODIPROVEEDOR").DefaultValue = CODIPROVEEDOR.ToString()
        Me.odsListaPorPROVEEDOR.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR"
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
                keyValues(i) = grid.GetRowValues(i, "ID_SOLICITUD")
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
        If e.CommandArgs.CommandName = "GenerarOrdenCompra" Then
            RaiseEvent GenerandoOrden(e.KeyValue)
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

    Public Function DevolverSeleccionados() As listaSOLIC_AGRICOLA
        Dim mLista As New listaSOLIC_AGRICOLA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_SOLICITUD")
            Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(llave)
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As SOLIC_AGRICOLA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), SOLIC_AGRICOLA)

            If Me.mComponente.EliminarSOLIC_AGRICOLA(lEntidad.ID_SOLICITUD) <> 1 Then
                'Si se cometio un error
                dxgvLista.JSProperties.Add("cpMensaje", "Error al Eliminar Registro: " + Me.mComponente.sError)
            Else
                dxgvLista.JSProperties.Add("cpMensaje", "El registro ha sido eliminado")
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "Eliminar Solicitud"
        ElseIf e.ButtonID = "btnAnalisisFinanciero" AndAlso e.CellType = GridViewTableCommandCellType.Data Then
            'Dim grd As ASPxGridView = DirectCast(sender, ASPxGridView)
            'Dim lEntidad As SOLIC_AGRICOLA = TryCast(grd.GetRow(e.VisibleIndex), SOLIC_AGRICOLA)
            'If lEntidad IsNot Nothing AndAlso lEntidad.ESTADO = EstadoSolicAgricola.Validada Then
            '    e.Visible = DevExpress.Utils.DefaultBoolean.True
            'Else
            '    e.Visible = DevExpress.Utils.DefaultBoolean.False
            'End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "CODIPROVEE" Then
            If e.GetListSourceFieldValue("CODIPROVEEDOR") IsNot Nothing Then
                e.Value = Utilerias.RecuperarCODIPROVEE(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            End If
        ElseIf e.Column.FieldName = "CODISOCIO" Then
            If e.GetListSourceFieldValue("CODIPROVEEDOR") IsNot Nothing Then
                e.Value = Utilerias.RecuperarCODISOCIO(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            End If
        ElseIf e.Column.FieldName = "NOMBRE_TIPO_CONTRIBUYENTE" Then
            If e.GetListSourceFieldValue("CODIPROVEEDOR") IsNot Nothing Then
                Dim lEntidad As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
                If lEntidad IsNot Nothing Then
                    e.Value = Utilerias.NombreTipoContribuyente(lEntidad.TIPO_CONTRIBUYENTE)
                End If
            End If
        ElseIf e.Column.FieldName = "CONDICION_COMPRA" Then
            e.Value = Utilerias.NombreCondicionCompra(CInt(e.GetListSourceFieldValue("CONDI_COMPRA")))
        ElseIf e.Column.FieldName = "ESTADO_NOMBRE" Then
            If e.GetListSourceFieldValue("ESTADO") IsNot Nothing Then
                e.Value = Utilerias.NombreEstadoSolicAgricola(CInt(e.GetListSourceFieldValue("ESTADO")))
            End If
        ElseIf e.Column.FieldName = "CASA_COMERCIAL" Then
            Dim lstSolicProd As listaSOLIC_AGRICOLA_PRODUCTO = (New cSOLIC_AGRICOLA_PRODUCTO).ObtenerListaPorSOLIC_AGRICOLA(e.GetListSourceFieldValue("ID_SOLICITUD"), False, "ID_PROVEE")
            Dim idProvee As Int32 = -1
            Dim str As New StringBuilder

            If lstSolicProd IsNot Nothing AndAlso lstSolicProd.Count > 0 Then
                For i As Int32 = 0 To lstSolicProd.Count - 1
                    If lstSolicProd(i).ID_PROVEE <> idProvee Then
                        Dim lProveeAgri As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(lstSolicProd(i).ID_PROVEE)
                        If lProveeAgri IsNot Nothing Then
                            If idProvee = -1 Then str.Append(lProveeAgri.NOMBRE) Else str.Append(", " + lProveeAgri.NOMBRE)
                        End If
                        idProvee = lstSolicProd(i).ID_PROVEE
                    End If
                Next
            End If
            e.Value = str.ToString

        ElseIf e.Column.FieldName = "NOMBRE_CUENTA" Then
            If e.GetListSourceFieldValue("ID_CUENTA_FINAN") IsNot Nothing Then
                Dim lCuentaFinan As CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(e.GetListSourceFieldValue("ID_CUENTA_FINAN"))
                If lCuentaFinan IsNot Nothing Then
                    e.Value = lCuentaFinan.NOMBRE_CUENTA
                End If
            End If
        End If
    End Sub
End Class
