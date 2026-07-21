Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaDOCUMENTO_ENTRADA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla DOCUMENTO_ENTRADA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaDOCUMENTO_ENTRADA_ENCA
    Inherits ucListaBase
 
    Private mComponente As New cDOCUMENTO_ENTRADA_ENCA
    Public Event Seleccionado(ByVal ID_DOCENTRA_ENCA As Int32) 
    Public Event Editando(ByVal ID_DOCENTRA_ENCA As Int32) 

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

    Public Property VerID_DOCENTRA_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_DOCENTRA_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_DOCENTRA_ENCA").Visible = Value
        End Set
    End Property

    Public Property VerID_BODEGA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_BODEGA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_BODEGA").Visible = Value
        End Set
    End Property

    Public Property VerNO_DOCUMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_DOCUMENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_DOCUMENTO").Visible = Value
        End Set
    End Property

    Public Property VerFEC_DOCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FEC_DOCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FEC_DOCTO").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_MOVTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_MOVTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_MOVTO").Visible = Value
        End Set
    End Property

    Public Property VerUID_DOCUMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_DOCUMENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_DOCUMENTO").Visible = Value
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

    Public Property VerVistaPreviaReporte() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaPrevia").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaPrevia").Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROVEE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROVEE").Visible = Value
        End Set
    End Property

    Public Property VerFORMA_ENTREGA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FORMA_ENTREGA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FORMA_ENTREGA").Visible = Value
        End Set
    End Property

    Public Property VerID_ORDEN() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ORDEN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ORDEN").Visible = Value
        End Set
    End Property

    Public Property VerNO_COMPROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_COMPROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_COMPROB").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_COMPROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_COMPROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_COMPROB").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_COMPROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_COMPROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_COMPROB").Visible = Value
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

    Public Property HeaderID_DOCENTRA_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_DOCENTRA_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_DOCENTRA_ENCA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_BODEGA() As String
        Get
            Return Me.dxgvLista.Columns("ID_BODEGA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_BODEGA").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_DOCUMENTO() As String
        Get
            Return Me.dxgvLista.Columns("NO_DOCUMENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_DOCUMENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderFEC_DOCTO() As String
        Get
            Return Me.dxgvLista.Columns("FEC_DOCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FEC_DOCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_MOVTO() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_MOVTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_MOVTO").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_DOCUMENTO() As String
        Get
            Return Me.dxgvLista.Columns("UID_DOCUMENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_DOCUMENTO").Caption = Value
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

    Public Property HeaderID_PROVEE() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROVEE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROVEE").Caption = Value
        End Set
    End Property

    Public Property HeaderFORMA_ENTREGA() As String
        Get
            Return Me.dxgvLista.Columns("FORMA_ENTREGA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FORMA_ENTREGA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ORDEN() As String
        Get
            Return Me.dxgvLista.Columns("ID_ORDEN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ORDEN").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_COMPROB() As String
        Get
            Return Me.dxgvLista.Columns("NO_COMPROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_COMPROB").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_COMPROB() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_COMPROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_COMPROB").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_COMPROB() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_COMPROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_COMPROB").Caption = Value
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

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' filtrado por la tabla BODEGA
    ''' </summary>
    ''' <param name="ID_BODEGA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorBODEGA(ByVal ID_BODEGA As Int32) As Integer
        Me.odsListaPorBODEGA.SelectParameters("ID_BODEGA").DefaultValue = ID_BODEGA.ToString()
        Me.odsListaPorBODEGA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorBODEGA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorBODEGA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorBODEGA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorBODEGA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorBODEGA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' filtrado por la tabla TIPO_MOVTO
    ''' </summary>
    ''' <param name="ID_TIPO_MOVTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_MOVTO(ByVal ID_TIPO_MOVTO As Int32) As Integer
        Me.odsListaPorTIPO_MOVTO.SelectParameters("ID_TIPO_MOVTO").DefaultValue = ID_TIPO_MOVTO.ToString()
        Me.odsListaPorTIPO_MOVTO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPO_MOVTO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_MOVTO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_MOVTO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_MOVTO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_MOVTO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' filtrado por la tabla PROVEEDOR_AGRICOLA
    ''' </summary>
    ''' <param name="ID_PROVEE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AGRICOLA(ByVal ID_PROVEE As Int32) As Integer
        Me.odsListaPorPROVEEDOR_AGRICOLA.SelectParameters("ID_PROVEE").DefaultValue = ID_PROVEE.ToString()
        Me.odsListaPorPROVEEDOR_AGRICOLA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR_AGRICOLA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR_AGRICOLA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_AGRICOLA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_AGRICOLA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR_AGRICOLA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' filtrado por la tabla ORDEN_COMPRA_AGRI
    ''' </summary>
    ''' <param name="ID_ORDEN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorORDEN_COMPRA_AGRI(ByVal ID_ORDEN As Int32) As Integer
        Me.odsListaPorORDEN_COMPRA_AGRI.SelectParameters("ID_ORDEN").DefaultValue = ID_ORDEN.ToString()
        Me.odsListaPorORDEN_COMPRA_AGRI.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorORDEN_COMPRA_AGRI.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorORDEN_COMPRA_AGRI.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorORDEN_COMPRA_AGRI.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorORDEN_COMPRA_AGRI.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorORDEN_COMPRA_AGRI"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' filtrado por la tabla TIPO_COMPROB
    ''' </summary>
    ''' <param name="ID_TIPO_COMPROB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_COMPROB(ByVal ID_TIPO_COMPROB As Int32) As Integer
        Me.odsListaPorTIPO_COMPROB.SelectParameters("ID_TIPO_COMPROB").DefaultValue = ID_TIPO_COMPROB.ToString()
        Me.odsListaPorTIPO_COMPROB.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPO_COMPROB.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_COMPROB.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_COMPROB.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_COMPROB.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_COMPROB"
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
                keyValues(i) = grid.GetRowValues(i, "ID_DOCENTRA_ENCA")
                keyNames(i) = grid.GetRowValues(i, "ID_BODEGA")
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
            'If Not Me.PermitirEditar Then
            '    Dim lbDetalle As LinkButton
            '    lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
            '    lbDetalle.Visible = False
            'End If
            'If Me.PermitirSeleccionar Then
            '    Dim lbSeleccionar As LinkButton
            '    lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
            '    lbSeleccionar.Visible = True
            '    lbSeleccionar.Text = Me.TextoSeleccionar
            '    lbSeleccionar.CommandName = Me.ComandoSeleccionar
            '    If lbSeleccionar.CommandName = "Check" Then
            '        lbSeleccionar.Visible = False
            '    End If
            'End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaDOCUMENTO_ENTRADA_ENCA
        Dim mLista As New listaDOCUMENTO_ENTRADA_ENCA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_DOCENTRA_ENCA")
            Dim lEntidad As New DOCUMENTO_ENTRADA_ENCA
            lEntidad.ID_DOCENTRA_ENCA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As DOCUMENTO_ENTRADA_ENCA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), DOCUMENTO_ENTRADA_ENCA)

            Me.mComponente.EliminarDOCUMENTO_ENTRADA_ENCA(lEntidad.ID_DOCENTRA_ENCA)
            Me.dxgvLista.DataBind()
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lEntidad As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(e.GetListSourceFieldValue("ID_PROVEE"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        ElseIf e.Column.FieldName = "CODI_ORDEN" Then
            Dim lEntidad As ORDEN_COMPRA_AGRI = (New cORDEN_COMPRA_AGRI).ObtenerORDEN_COMPRA_AGRI(e.GetListSourceFieldValue("ID_ORDEN"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.CODI_ORDEN
            End If
        ElseIf e.Column.FieldName = "NOMBRE_TIPO" Then
            Dim lEntidad As TIPO_COMPROB = (New cTIPO_COMPROB).ObtenerTIPO_COMPROB(e.GetListSourceFieldValue("ID_TIPO_COMPROB"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE_TIPO
            End If
        ElseIf e.Column.FieldName = "NOMBRE_TIPO_MOVTO" Then
            Dim lEntidad As TIPO_MOVTO = (New cTIPO_MOVTO).ObtenerTIPO_MOVTO(e.GetListSourceFieldValue("ID_TIPO_MOVTO"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE_TIPO_MOVTO
            End If
        End If
    End Sub
End Class
