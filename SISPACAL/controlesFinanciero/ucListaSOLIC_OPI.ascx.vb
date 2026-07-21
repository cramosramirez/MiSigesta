Imports SISPACAL.BL
Imports SISPACAL.EL

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaSOLIC_OPI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SOLIC_OPI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSOLIC_OPI
    Inherits ucListaBase

    Private mComponente As New cSOLIC_OPI
    Public Event Seleccionado(ByVal ID_OPI As Int32)
    Public Event Editando(ByVal ID_OPI As Int32)

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

    Public Property PermitirVistaPrevia() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaPrevia").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaPrevia").Visible = Value
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

    Public Property PermitirAnalisisFinanciero() As Boolean
        Get
            Return Me.dxgvLista.Columns("colAnalisisFinanciero").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colAnalisisFinanciero").Visible = Value
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

    Public Property VerID_OPI() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_OPI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_OPI").Visible = Value
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

    Public Property VerNUM_OPI() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUM_OPI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUM_OPI").Visible = Value
        End Set
    End Property

    Public Property VerCORR_OPI() As Boolean
        Get
            Return Me.dxgvLista.Columns("CORR_OPI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CORR_OPI").Visible = Value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA").Visible = Value
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

    Public Property VerCODIBANCO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIBANCO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIBANCO").Visible = Value
        End Set
    End Property

    Public Property VerMONTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO").Visible = Value
        End Set
    End Property

    Public Property VerPORC_DESCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PORC_DESCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PORC_DESCTO").Visible = Value
        End Set
    End Property

    Public Property VerDESCRIP_LOTES() As Boolean
        Get
            Return Me.dxgvLista.Columns("DESCRIP_LOTES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DESCRIP_LOTES").Visible = Value
        End Set
    End Property

    Public Property VerUBICACION_LOTES() As Boolean
        Get
            Return Me.dxgvLista.Columns("UBICACION_LOTES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UBICACION_LOTES").Visible = Value
        End Set
    End Property

    Public Property VerUID_OPI_CONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_OPI_CONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_OPI_CONTRATO").Visible = Value
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

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ZAFRA").Visible = Value
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

    Public Property HeaderID_OPI() As String
        Get
            Return Me.dxgvLista.Columns("ID_OPI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_OPI").Caption = Value
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

    Public Property HeaderNUM_OPI() As String
        Get
            Return Me.dxgvLista.Columns("NUM_OPI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUM_OPI").Caption = Value
        End Set
    End Property

    Public Property HeaderCORR_OPI() As String
        Get
            Return Me.dxgvLista.Columns("CORR_OPI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CORR_OPI").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA").Caption = Value
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

    Public Property HeaderCODIBANCO() As String
        Get
            Return Me.dxgvLista.Columns("CODIBANCO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIBANCO").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO").Caption = Value
        End Set
    End Property

    Public Property HeaderPORC_DESCTO() As String
        Get
            Return Me.dxgvLista.Columns("PORC_DESCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PORC_DESCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderDESCRIP_LOTES() As String
        Get
            Return Me.dxgvLista.Columns("DESCRIP_LOTES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DESCRIP_LOTES").Caption = Value
        End Set
    End Property

    Public Property HeaderUBICACION_LOTES() As String
        Get
            Return Me.dxgvLista.Columns("UBICACION_LOTES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UBICACION_LOTES").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_OPI_CONTRATO() As String
        Get
            Return Me.dxgvLista.Columns("UID_OPI_CONTRATO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_OPI_CONTRATO").Caption = Value
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

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ZAFRA").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_OPI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_OPI
    ''' filtrado por la tabla PROVEEDOR
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR(ByVal CODIPROVEEDOR As String) As Integer
        Me.odsListaPorPROVEEDOR.SelectParameters("CODIPROVEEDOR").DefaultValue = CODIPROVEEDOR.ToString()
        Me.odsListaPorPROVEEDOR.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_OPI
    ''' filtrado por la tabla CONTRATO
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO(ByVal CODICONTRATO As String) As Integer
        Me.odsListaPorCONTRATO.SelectParameters("CODICONTRATO").DefaultValue = CODICONTRATO.ToString()
        Me.odsListaPorCONTRATO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCONTRATO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONTRATO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_OPI
    ''' filtrado por la tabla BANCOS
    ''' </summary>
    ''' <param name="CODIBANCO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorBANCOS(ByVal CODIBANCO As Int32) As Integer
        Me.odsListaPorBANCOS.SelectParameters("CODIBANCO").DefaultValue = CODIBANCO.ToString()
        Me.odsListaPorBANCOS.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorBANCOS.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorBANCOS.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorBANCOS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorBANCOS"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_OPI
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
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

    Public Function CargarDatosPoCriterios(ByVal ID_ZAFRA As Int32, _
                                            ByVal CORR_OPI As Int32, _
                                            ByVal CODIPROVEE As String, _
                                            ByVal CODISOCIO As String, _
                                            ByVal NOMBRE_PROVEEDOR As String, _
                                            ByVal FECHA As DateTime) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorCriterios.SelectParameters("CORR_OPI").DefaultValue = CORR_OPI.ToString()
        Me.odsListaPorCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaPorCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaPorCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorCriterios.SelectParameters("FECHA").DefaultValue = IIf(FECHA = Nothing, Nothing, FECHA)
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
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
                keyValues(i) = grid.GetRowValues(i, "ID_OPI")
                keyNames(i) = grid.GetRowValues(i, "CODIPROVEEDOR")
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

    Public Function DevolverSeleccionados() As listaSOLIC_OPI
        Dim mLista As New listaSOLIC_OPI
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_OPI")
            Dim lEntidad As New SOLIC_OPI
            lEntidad.ID_OPI = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As SOLIC_OPI = CType(Me.dxgvLista.GetRow(e.VisibleIndex), SOLIC_OPI)

            If Me.mComponente.EliminarSOLIC_OPI(lEntidad.ID_OPI) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "CODIPROVEE" Then
            If e.GetListSourceFieldValue("CODIPROVEEDOR") IsNot Nothing Then
                e.Value = Utilerias.RecuperarCODIPROVEE(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            End If
        ElseIf e.Column.FieldName = "ESTADO_NOMBRE" Then
            If e.GetListSourceFieldValue("ID_ESTADO") IsNot Nothing Then
                e.Value = Utilerias.NombreEstadoSolicAgricola(CInt(e.GetListSourceFieldValue("ID_ESTADO")))
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            If e.GetListSourceFieldValue("CODIPROVEEDOR") IsNot Nothing Then
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
                If lProveedor IsNot Nothing Then
                    e.Value = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                End If
            End If
        ElseIf e.Column.FieldName = "NOMBRE_BANCO" Then
            If e.GetListSourceFieldValue("CODIBANCO") IsNot Nothing Then
                Dim lBanco As BANCOS = (New cBANCOS).ObtenerBANCOS(e.GetListSourceFieldValue("CODIBANCO"))
                If lBanco IsNot Nothing Then
                    e.Value = lBanco.NOMBRE_BANCO
                End If
            End If
        End If
    End Sub
End Class
