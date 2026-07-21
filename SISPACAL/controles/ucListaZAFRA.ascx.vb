Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/11/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaZAFRA
    Inherits ucListaBase
 
    Private mComponente As New cZAFRA
    Public Event Seleccionado(ByVal ID_ZAFRA As Int32) 
    Public Event Editando(ByVal ID_ZAFRA As Int32) 

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

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_ZAFRA").Visible = Value
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

    Public Property VerCATORCENA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CATORCENA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CATORCENA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INICIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INICIO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_FINAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_FINAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_FINAL").Visible = Value
        End Set
    End Property

    Public Property VerPOL() As Boolean
        Get
            Return Me.dxgvLista.Columns("POL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("POL").Visible = Value
        End Set
    End Property

    Public Property VerHUMEDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("HUMEDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HUMEDAD").Visible = Value
        End Set
    End Property

    Public Property VerPUREZA_MIEL() As Boolean
        Get
            Return Me.dxgvLista.Columns("PUREZA_MIEL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PUREZA_MIEL").Visible = Value
        End Set
    End Property

    Public Property VerEFICIENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("EFICIENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EFICIENCIA").Visible = Value
        End Set
    End Property

    Public Property VerPRECIO_LIBRA_AZUCAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRECIO_LIBRA_AZUCAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRECIO_LIBRA_AZUCAR").Visible = Value
        End Set
    End Property

    Public Property VerCONSTANTE_A() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONSTANTE_A").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONSTANTE_A").Visible = Value
        End Set
    End Property

    Public Property VerCONSTANTE_B() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONSTANTE_B").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONSTANTE_B").Visible = Value
        End Set
    End Property

    Public Property VerCONSTANTE_D() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONSTANTE_D").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONSTANTE_D").Visible = Value
        End Set
    End Property

    Public Property VerCONSTANTE_E() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONSTANTE_E").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONSTANTE_E").Visible = Value
        End Set
    End Property

    Public Property VerULTFECHA_CIERRE_DIARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ULTFECHA_CIERRE_DIARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ULTFECHA_CIERRE_DIARIO").Visible = Value
        End Set
    End Property

    Public Property VerACTIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACTIVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACTIVA").Visible = Value
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

    Public Property VerDISPO_INVE_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISPO_INVE_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISPO_INVE_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerREND_MODFINAN() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND_MODFINAN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND_MODFINAN").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_ROZA_MODFINAN() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_ROZA_MODFINAN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_ROZA_MODFINAN").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_ALZA_MODFINAN() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_ALZA_MODFINAN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_ALZA_MODFINAN").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_QUERQUEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_QUERQUEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_QUERQUEO").Visible = Value
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

    Public Property HeaderNOMBRE_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_ZAFRA").Caption = Value
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

    Public Property HeaderCATORCENA() As String
        Get
            Return Me.dxgvLista.Columns("CATORCENA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CATORCENA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INICIO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INICIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INICIO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_FINAL() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_FINAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_FINAL").Caption = Value
        End Set
    End Property

    Public Property HeaderPOL() As String
        Get
            Return Me.dxgvLista.Columns("POL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("POL").Caption = Value
        End Set
    End Property

    Public Property HeaderHUMEDAD() As String
        Get
            Return Me.dxgvLista.Columns("HUMEDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("HUMEDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderPUREZA_MIEL() As String
        Get
            Return Me.dxgvLista.Columns("PUREZA_MIEL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PUREZA_MIEL").Caption = Value
        End Set
    End Property

    Public Property HeaderEFICIENCIA() As String
        Get
            Return Me.dxgvLista.Columns("EFICIENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EFICIENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderPRECIO_LIBRA_AZUCAR() As String
        Get
            Return Me.dxgvLista.Columns("PRECIO_LIBRA_AZUCAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRECIO_LIBRA_AZUCAR").Caption = Value
        End Set
    End Property

    Public Property HeaderCONSTANTE_A() As String
        Get
            Return Me.dxgvLista.Columns("CONSTANTE_A").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CONSTANTE_A").Caption = Value
        End Set
    End Property

    Public Property HeaderCONSTANTE_B() As String
        Get
            Return Me.dxgvLista.Columns("CONSTANTE_B").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CONSTANTE_B").Caption = Value
        End Set
    End Property

    Public Property HeaderCONSTANTE_D() As String
        Get
            Return Me.dxgvLista.Columns("CONSTANTE_D").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CONSTANTE_D").Caption = Value
        End Set
    End Property

    Public Property HeaderCONSTANTE_E() As String
        Get
            Return Me.dxgvLista.Columns("CONSTANTE_E").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CONSTANTE_E").Caption = Value
        End Set
    End Property

    Public Property HeaderULTFECHA_CIERRE_DIARIO() As String
        Get
            Return Me.dxgvLista.Columns("ULTFECHA_CIERRE_DIARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ULTFECHA_CIERRE_DIARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderACTIVA() As String
        Get
            Return Me.dxgvLista.Columns("ACTIVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACTIVA").Caption = Value
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

    Public Property HeaderDISPO_INVE_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("DISPO_INVE_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISPO_INVE_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderREND_MODFINAN() As String
        Get
            Return Me.dxgvLista.Columns("REND_MODFINAN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND_MODFINAN").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_ROZA_MODFINAN() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_ROZA_MODFINAN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_ROZA_MODFINAN").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_ALZA_MODFINAN() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_ALZA_MODFINAN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_ALZA_MODFINAN").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_QUERQUEO() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_QUERQUEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_QUERQUEO").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ZAFRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
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
                keyValues(i) = grid.GetRowValues(i, "ID_ZAFRA")
                keyNames(i) = grid.GetRowValues(i, "NOMBRE_ZAFRA")
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

    Public Function DevolverSeleccionados() As listaZAFRA
        Dim mLista As New listaZAFRA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ZAFRA")
            Dim lEntidad As New ZAFRA
            lEntidad.ID_ZAFRA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ZAFRA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ZAFRA)

            If Me.mComponente.EliminarZAFRA(lEntidad.ID_ZAFRA) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

End Class
