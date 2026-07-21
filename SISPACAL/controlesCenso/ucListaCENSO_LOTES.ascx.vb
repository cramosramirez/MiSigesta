Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCENSO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CENSO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCENSO_LOTES
    Inherits ucListaBase
 
    Private mComponente As New cCENSO_LOTES
    Public Event Seleccionado(ByVal ID_CENSO_LOTES As Int32) 
    Public Event Editando(ByVal ID_CENSO_LOTES As Int32) 



#Region "ConfiguraciÃ³n Callback"

    Private Sub CargarDatosGenericos()
        If Me.hfListaCENSO_LOTES.Contains("Metodo") Then
            Select Case Me.hfListaCENSO_LOTES("Metodo")
                Case "CargarDatosPorZAFRA_ZONA_CENSO"
                    Me.CargarDatosPorZAFRA_ZONA_CENSO()
            End Select
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        Me.CargarDatosGenericos()

        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub

    Public Sub CargarDatosPorZAFRA_ZONA_CENSO(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal ID_CENSO As Integer)
        Me.hfListaCENSO_LOTES.Clear()
        Me.hfListaCENSO_LOTES.Add("Metodo", "CargarDatosPorZAFRA_ZONA_CENSO")
        Me.hfListaCENSO_LOTES.Add("p1", ID_ZAFRA)
        Me.hfListaCENSO_LOTES.Add("p2", ZONA)
        Me.hfListaCENSO_LOTES.Add("p3", ID_CENSO)
        Me.CargarDatosPorZAFRA_ZONA_CENSO()
    End Sub

    Public Function CargarDatosPorZAFRA_ZONA_CENSO() As Integer
        Me.odsListaPorZAFRA_ZONA_CENSO.SelectParameters("ID_ZAFRA").DefaultValue = Me.hfListaCENSO_LOTES("p1")
        Me.odsListaPorZAFRA_ZONA_CENSO.SelectParameters("ZONA").DefaultValue = Me.hfListaCENSO_LOTES("p2")
        Me.odsListaPorZAFRA_ZONA_CENSO.SelectParameters("ID_CENSO").DefaultValue = Me.hfListaCENSO_LOTES("p3")
        Me.odsListaPorZAFRA_ZONA_CENSO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorZAFRA_ZONA_CENSO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorZAFRA_ZONA_CENSO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZAFRA_ZONA_CENSO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private newValues As OrderedDictionary
    Protected Sub dxgvLista_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        Me.newValues = e.NewValues
        PopulateNewValues()
    End Sub

    Private Sub PopulateNewValues()
        Dim formLayout As ASPxFormLayout = CType(dxgvLista.FindEditFormTemplateControl("formLayout"), ASPxFormLayout)
        formLayout.ForEach(AddressOf ProcessItem)
    End Sub

    Private Sub ProcessItem(ByVal item As LayoutItemBase)
        Dim layoutItem As LayoutItem = TryCast(item, LayoutItem)
        If layoutItem IsNot Nothing Then
            Dim editBase As ASPxEditBase = TryCast(layoutItem.GetNestedControl(), ASPxEditBase)
            If editBase IsNot Nothing Then
                Me.newValues(layoutItem.FieldName) = editBase.Value
            End If
        End If
    End Sub
    
#End Region

#Region "Propiedades"

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

    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = value
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

    Public Property VerID_CENSO_LOTES() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CENSO_LOTES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CENSO_LOTES").Visible = Value
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

    Public Property VerFECHA_VERIFICACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_VERIFICACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_VERIFICACION").Visible = Value
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

    Public Property VerVALOR_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("VALOR_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("VALOR_ENTREGADA").Visible = Value
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

    Public Property VerID_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CENSO").Visible = Value
        End Set
    End Property

    Public Property VerID_MOTIVO_VARIACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_MOTIVO_VARIACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_MOTIVO_VARIACION").Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACION").Visible = Value
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

    Public Property HeaderID_CENSO_LOTES() As String
        Get
            Return Me.dxgvLista.Columns("ID_CENSO_LOTES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CENSO_LOTES").Caption = Value
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

    Public Property HeaderFECHA_VERIFICACION() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_VERIFICACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_VERIFICACION").Caption = Value
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

    Public Property HeaderID_CENSO() As String
        Get
            Return Me.dxgvLista.Columns("ID_CENSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CENSO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_MOTIVO_VARIACION() As String
        Get
            Return Me.dxgvLista.Columns("ID_MOTIVO_VARIACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_MOTIVO_VARIACION").Caption = Value
        End Set
    End Property

    Public Property HeaderOBSERVACION() As String
        Get
            Return Me.dxgvLista.Columns("OBSERVACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OBSERVACION").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CENSO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CENSO_LOTES
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CENSO_LOTES
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CENSO_LOTES
    ''' filtrado por la tabla CENSO
    ''' </summary>
    ''' <param name="ID_CENSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCENSO(ByVal ID_CENSO As Int32) As Integer
        Me.odsListaPorCENSO.SelectParameters("ID_CENSO").DefaultValue = ID_CENSO.ToString()
        Me.odsListaPorCENSO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCENSO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCENSO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCENSO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCENSO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CENSO_LOTES
    ''' filtrado por la tabla MOTIVO_VARIACION
    ''' </summary>
    ''' <param name="ID_MOTIVO_VARIACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMOTIVO_VARIACION(ByVal ID_MOTIVO_VARIACION As Int32) As Integer
        Me.odsListaPorMOTIVO_VARIACION.SelectParameters("ID_MOTIVO_VARIACION").DefaultValue = ID_MOTIVO_VARIACION.ToString()
        Me.odsListaPorMOTIVO_VARIACION.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorMOTIVO_VARIACION.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorMOTIVO_VARIACION.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorMOTIVO_VARIACION.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorMOTIVO_VARIACION"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function




    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "ID_CENSO_LOTES")
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
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowNewButton = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowDeleteButton = Me.PermitirEliminarInline
        Else
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowNewButton = False
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = False
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowDeleteButton = False
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
            RaiseEvent Editando(e.CommandArgs.CommandArgument)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.GridViewRowType.EditForm Then
            Dim btnGuardar As DevExpress.Web.ASPxButton
            Dim btnCancelar As DevExpress.Web.ASPxButton
            btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
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

    Public Function DevolverSeleccionados() As listaCENSO_LOTES
        Dim mLista As New listaCENSO_LOTES
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_CENSO_LOTES")
            Dim lEntidad As New CENSO_LOTES
            lEntidad.ID_CENSO_LOTES = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CENSO_LOTES = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CENSO_LOTES)

            If Me.mComponente.EliminarCENSO_LOTES(lEntidad.ID_CENSO_LOTES) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        Static mEntidadLote As LOTES
        Static mEntidadProveedor As PROVEEDOR
        Static sAccesLote As String
        If e.IsGetData Then
            If sAccesLote = "" OrElse sAccesLote <> CStr(e.GetListSourceFieldValue("ACCESLOTE").ToString) Then
                mEntidadLote = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE").ToString)
                If mEntidadLote IsNot Nothing Then
                    mEntidadProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidadLote.CODIPROVEEDOR)
                End If
                sAccesLote = e.GetListSourceFieldValue("ACCESLOTE").ToString
            End If
            If e.Column.FieldName = "CORRELATIVO" Then
                e.Value = e.ListSourceRowIndex + 1
            ElseIf e.Column.FieldName = "CODIPROVEE" Then
                If mEntidadProveedor IsNot Nothing Then e.Value = Convert.ToInt32(mEntidadProveedor.CODIPROVEE)
            ElseIf e.Column.FieldName = "CODISOCIO" Then
                If mEntidadProveedor IsNot Nothing AndAlso Convert.ToInt32(mEntidadProveedor.CODISOCIO) > 0 Then
                    e.Value = Convert.ToInt32(mEntidadProveedor.CODISOCIO)
                End If
            ElseIf e.Column.FieldName = "NOMBREPROVEEDOR" Then
                If mEntidadProveedor IsNot Nothing Then e.Value = mEntidadProveedor.NOMBRES.Trim + " " + mEntidadProveedor.APELLIDOS.Trim
            ElseIf e.Column.FieldName = "CONTRATO" Then
                If mEntidadLote IsNot Nothing Then e.Value = Utilerias.CODICONTRATOsinFormato(mEntidadLote.CODICONTRATO).ToString
            ElseIf e.Column.FieldName = "CODLOTE" Then
                If mEntidadLote IsNot Nothing Then e.Value = mEntidadLote.CODILOTE
            ElseIf e.Column.FieldName = "NOMBLOTE" Then
                If mEntidadLote IsNot Nothing Then e.Value = mEntidadLote.NOMBLOTE
            End If
        End If
    End Sub

    
End Class
