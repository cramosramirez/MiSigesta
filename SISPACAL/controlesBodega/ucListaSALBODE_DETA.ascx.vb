Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaSALBODE_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SALBODE_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/08/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSALBODE_DETA
    Inherits ucListaBase

    Private mComponente As New cSALBODE_DETA
    Public Event Seleccionado(ByVal ID_SALBODE_DETA As Int32)
    Public Event Editando(ByVal ID_SALBODE_DETA As Int32)

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

    Public Property REFERENCIA() As String
        Get
            Return Me.ViewState("REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("REFERENCIA") = value
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

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
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

    Public Property VerID_SALBODE_DETA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SALBODE_DETA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SALBODE_DETA").Visible = Value
        End Set
    End Property

    Public Property VerID_SALBODE_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SALBODE_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SALBODE_ENCA").Visible = Value
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

    Public Property VerID_PRODUCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PRODUCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PRODUCTO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_PRODUCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Visible = Value
        End Set
    End Property

    Public Property VerUNIDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("UNIDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UNIDAD").Visible = Value
        End Set
    End Property

    Public Property VerCANT_ANULADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANT_ANULADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANT_ANULADA").Visible = Value
        End Set
    End Property
    Public Property VerESTADO_SOLIC_AGRICOLA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTADO_SOLIC_AGRICOLA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTADO_SOLIC_AGRICOLA").Visible = Value
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
    Public Property VerNO_DOCUMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_DOCUMENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_DOCUMENTO").Visible = Value
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
    Public Property VerFECHA_SOLIC() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_SOLIC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_SOLIC").Visible = Value
        End Set
    End Property



    Public Property VerPRESENTACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRESENTACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRESENTACION").Visible = Value
        End Set
    End Property

    Public Property VerCANTIDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANTIDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANTIDAD").Visible = Value
        End Set
    End Property

    Public Property VerPRECIO_UNITARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRECIO_UNITARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRECIO_UNITARIO").Visible = Value
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

    Public Property VerCANT_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANT_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANT_ENTREGADA").Visible = Value
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

    Public Property HeaderID_SALBODE_DETA() As String
        Get
            Return Me.dxgvLista.Columns("ID_SALBODE_DETA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SALBODE_DETA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SALBODE_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_SALBODE_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SALBODE_ENCA").Caption = Value
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

    Public Property HeaderID_PRODUCTO() As String
        Get
            Return Me.dxgvLista.Columns("ID_PRODUCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PRODUCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_PRODUCTO() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderUNIDAD() As String
        Get
            Return Me.dxgvLista.Columns("UNIDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UNIDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderPRESENTACION() As String
        Get
            Return Me.dxgvLista.Columns("PRESENTACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRESENTACION").Caption = Value
        End Set
    End Property

    Public Property HeaderCANTIDAD() As String
        Get
            Return Me.dxgvLista.Columns("CANTIDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CANTIDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderPRECIO_UNITARIO() As String
        Get
            Return Me.dxgvLista.Columns("PRECIO_UNITARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRECIO_UNITARIO").Caption = Value
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

    Public Property HeaderCANT_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("CANT_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CANT_ENTREGADA").Caption = Value
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

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
    End Sub

    Public Sub ExportarExcel()
        gridExport.WriteXlsxToResponse(New DevExpress.XtraPrinting.XlsxExportOptionsEx With {.ExportType = DevExpress.Export.ExportType.WYSIWYG})
    End Sub

    Public Function CargarDatosPorCriterios(ByVal ID_ZAFRA As Int32, _
                                            ByVal FECHA_INI As String, _
                                            ByVal FECHA_FIN As String, _
                                            ByVal NUM_SOLICITUD As Int32, _
                                            ByVal NUM_SALBODE As Int32, _
                                            ByVal CODIPROVEEDOR As String, _
                                            ByVal ID_PROVEE As Int32, _
                                            ByVal ID_CUENTA_FINAN As Int32, _
                                            ByVal ID_ESTADO As Int32) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorCriterios.SelectParameters("FECHA_INI").DefaultValue = FECHA_INI.ToString
        Me.odsListaPorCriterios.SelectParameters("FECHA_FIN").DefaultValue = FECHA_FIN.ToString
        Me.odsListaPorCriterios.SelectParameters("NUM_SOLICITUD").DefaultValue = NUM_SOLICITUD.ToString
        Me.odsListaPorCriterios.SelectParameters("NUM_SALBODE").DefaultValue = NUM_SALBODE.ToString
        Me.odsListaPorCriterios.SelectParameters("CODIPROVEEDOR").DefaultValue = CODIPROVEEDOR
        Me.odsListaPorCriterios.SelectParameters("ID_PROVEE").DefaultValue = ID_PROVEE.ToString
        Me.odsListaPorCriterios.SelectParameters("ID_CUENTA_FINAN").DefaultValue = ID_CUENTA_FINAN.ToString
        Me.odsListaPorCriterios.SelectParameters("ID_ESTADO").DefaultValue = ID_ESTADO.ToString
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.REFERENCIA = nombreSesion
        Me.odsSALBODE_DETAcache.SelectParameters("nombreSesion_ucListaSALBODE_DETA").DefaultValue = nombreSesion
        Me.odsSALBODE_DETAcache.DataBind()
        Me.dxgvLista.DataSourceID = "odsSALBODE_DETAcache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SALBODE_DETA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/08/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SALBODE_DETA
    ''' filtrado por la tabla SALBODE_ENCA
    ''' </summary>
    ''' <param name="ID_SALBODE_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/08/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSALBODE_ENCA(ByVal ID_SALBODE_ENCA As Int32) As Integer
        Me.odsListaPorSALBODE_ENCA.SelectParameters("ID_SALBODE_ENCA").DefaultValue = ID_SALBODE_ENCA.ToString()
        Me.odsListaPorSALBODE_ENCA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSALBODE_ENCA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSALBODE_ENCA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSALBODE_ENCA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSALBODE_ENCA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SALBODE_DETA
    ''' filtrado por la tabla PRODUCTO
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/08/2017	Created
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
                keyValues(i) = grid.GetRowValues(i, "ID_SALBODE_DETA")
                keyNames(i) = grid.GetRowValues(i, "ID_SALBODE_ENCA")
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
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowNewButtonInHeader = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        Else
            Me.dxgvLista.Columns("Edicion").Visible = False
        End If
        If Me.PermitirEditarInline2 Then
            Me.dxgvLista.Columns("Edicion2").Visible = True
            Me.dxgvLista.Columns("Eliminar").Visible = PermitirEliminarInline
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowNewButtonInHeader = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Eliminar"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        Else
            Me.dxgvLista.Columns("Edicion2").Visible = False
        End If
        If Me.PermitirEditarInline Or Me.PermitirEditarInline2 Then
            Me.dxgvLista.SettingsEditing.Mode = DevExpress.Web.GridViewEditingMode.Inline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
        dxgvLista.ForceDataRowType(GetType(listaSALBODE_DETA))
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
                'Dim lbDetalle As LinkButton
                'lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                'lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar Then
                'Dim lbSeleccionar As LinkButton
                'lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                'lbSeleccionar.Visible = True
                'lbSeleccionar.Text = Me.TextoSeleccionar
                'lbSeleccionar.CommandName = Me.ComandoSeleccionar
                'If lbSeleccionar.CommandName = "Check" Then
                '    lbSeleccionar.Visible = False
                'End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaSALBODE_DETA
        Dim mLista As New listaSALBODE_DETA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_SALBODE_DETA")
            Dim lEntidad As SALBODE_DETA = (New cSALBODE_DETA).ObtenerSALBODE_DETA(llave)
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As SALBODE_DETA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), SALBODE_DETA)

            If Me.mComponente.EliminarSALBODE_DETA(lEntidad.ID_SALBODE_DETA) <> 1 Then
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

    Protected Sub dxgvLista_InitNewRow(sender As Object, e As DevExpress.Web.Data.ASPxDataInitNewRowEventArgs) Handles dxgvLista.InitNewRow
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles dxgvLista.RowInserting
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NUM_SOLICITUD" Then
            Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(e.GetListSourceFieldValue("ID_SOLICITUD"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NUM_SOLICITUD.ToString
        ElseIf e.Column.FieldName = "CODI_PROVEE" Then
            Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(e.GetListSourceFieldValue("ID_SOLICITUD"))
            If lEntidad IsNot Nothing Then
                e.Value = Utilerias.RecuperarCODIPROVEE(lEntidad.CODIPROVEEDOR)
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(e.GetListSourceFieldValue("ID_SOLICITUD"))
            If lEntidad IsNot Nothing Then
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lEntidad.CODIPROVEEDOR)
                If lProveedor IsNot Nothing Then
                    e.Value = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                End If
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR_AGRICOLA" Then
            Dim lEntidad As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(e.GetListSourceFieldValue("ID_PRODUCTO"))
            If lEntidad IsNot Nothing Then
                Dim lProveeAgri As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(lEntidad.ID_PROVEE)
                If lProveeAgri IsNot Nothing Then
                    e.Value = lProveeAgri.NOMBRE
                End If
            End If
        ElseIf e.Column.FieldName = "ESTADO" Then
            e.Value = Utilerias.NombreEstadoSolicAgricola(e.GetListSourceFieldValue("ID_ESTADO"))
        ElseIf e.Column.FieldName = "NO_DOCUMENTO" Then
            Dim lEntidad As SALBODE_ENCA = (New cSALBODE_ENCA).ObtenerSALBODE_ENCA(e.GetListSourceFieldValue("ID_SALBODE_ENCA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NO_DOCUMENTO
        ElseIf e.Column.FieldName = "FECHA" Then
            Dim lEntidad As SALBODE_ENCA = (New cSALBODE_ENCA).ObtenerSALBODE_ENCA(e.GetListSourceFieldValue("ID_SALBODE_ENCA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.FECHA
        ElseIf e.Column.FieldName = "ESTADO_SOLIC_AGRICOLA" Then
            Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(e.GetListSourceFieldValue("ID_SOLICITUD"))
            If lEntidad IsNot Nothing Then
                e.Value = Utilerias.NombreEstadoSolicAgricola(lEntidad.ESTADO)
            End If
        ElseIf e.Column.FieldName = "FECHA_SOLIC" Then
            Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(e.GetListSourceFieldValue("ID_SOLICITUD"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.FECHA_SOLIC
        ElseIf e.Column.FieldName = "CANT_DEVUELTA" Then
            Dim dicCantEntregadaCalc As Dictionary(Of String, Decimal) = (New cSALBODE_ENCA).PROC_Calcular_Entrega_Producto(e.GetListSourceFieldValue("ID_SALBODE_ENCA"), e.GetListSourceFieldValue("ID_PRODUCTO"))
            e.Value = dicCantEntregadaCalc("DEVOLUCION")
        End If
    End Sub

    Protected Sub dxgvLista_RowValidating(sender As Object, e As DevExpress.Web.Data.ASPxDataValidationEventArgs) Handles dxgvLista.RowValidating
        Dim idSalBodeEnca As Int32 = 0
        Dim idSalBodeDeta As Int32 = 0
        Dim idSolic As Int32 = 0
        Dim idProducto As Int32 = 0
        Dim cant As Decimal = 0
        Dim cantAnulada As Decimal = 0
        Dim cantEntregada As Decimal = 0
        Dim lSolic As SOLIC_AGRICOLA
        Dim listaDoctoSalida As listaDOCUMENTO_SALIDA_ENCA

        For Each column As GridViewColumn In dxgvLista.Columns
            Dim dataColumn As GridViewDataColumn = TryCast(column, GridViewDataColumn)

            If Not dataColumn Is Nothing Then
                Select Case dataColumn.FieldName
                    Case "ID_SALBODE_ENCA"
                        idSalBodeEnca = dxgvLista.GetRowValues(e.VisibleIndex, "ID_SALBODE_ENCA")
                    Case "ID_SALBODE_DETA"
                        idSalBodeDeta = dxgvLista.GetRowValues(e.VisibleIndex, "ID_SALBODE_DETA")
                    Case "ID_SOLICITUD"
                        idSolic = dxgvLista.GetRowValues(e.VisibleIndex, "ID_SOLICITUD")
                    Case "ID_PRODUCTO"
                        idProducto = dxgvLista.GetRowValues(e.VisibleIndex, "ID_PRODUCTO")
                    Case "CANTIDAD"
                        cant = dxgvLista.GetRowValues(e.VisibleIndex, "CANTIDAD")
                    Case "CANT_ENTREGADA"
                        If e.NewValues(dataColumn.FieldName) Is Nothing Then
                            e.Errors(dataColumn) = "Ingrese la cantidad entregada"
                        Else
                            cantEntregada = e.NewValues(dataColumn.FieldName)
                        End If
                    Case "CANT_ANULADA"
                        If e.NewValues(dataColumn.FieldName) Is Nothing Then
                            e.Errors(dataColumn) = "Ingrese la cantidad anulada"
                        Else
                            cantAnulada = e.NewValues(dataColumn.FieldName)
                        End If
                End Select
            End If
        Next column

        'Verificar si esta anulada la solicitud
        lSolic = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(idSolic)
        If lSolic IsNot Nothing AndAlso lSolic.ESTADO = Enumeradores.EstadoSolicAgricola.Anulada Then
            e.Errors(dxgvLista.Columns("CANT_ENTREGADA")) = "La información no puede guardarse debido a que la solicitud agricola esta ANULADA"
            Return
        End If

        'Verificar que la cantidad anulada mas la entregada no sea mayor que la cantidad solicitada
        If cant < (cantEntregada + cantAnulada) Then
            e.Errors(dxgvLista.Columns("CANT_ENTREGADA")) = "La cantidad anulada mas la entregada no pueden ser mayor que la cantidad solicitada"
            Return
        End If

        If cantEntregada > 0 Then
            listaDoctoSalida = (New cDOCUMENTO_SALIDA_ENCA).ObtenerListaPorSALBODE_ENCA(idSalBodeEnca)
            If listaDoctoSalida Is Nothing OrElse listaDoctoSalida.Count = 0 Then
                e.Errors(dxgvLista.Columns("CANT_ENTREGADA")) = "No se pueden registrar las entregas ya que la solicitud no tiene relacionada un Documento de Salida de Bodega"
                Return
            End If
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowPrepared(sender As Object, e As ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowPrepared
        If e.RowType <> GridViewRowType.Data Then Return
        Dim idSolic As Integer = Convert.ToInt32(e.GetValue("ID_SOLICITUD"))
        Dim idEstado As Integer = Convert.ToInt32(e.GetValue("ID_ESTADO"))
        Dim lSolic As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(idSolic)

        If lSolic IsNot Nothing AndAlso lSolic.ESTADO = EstadoSolicAgricola.Anulada Then
            e.Row.ForeColor = System.Drawing.Color.Red
        End If
        If idEstado = EstadoSolicAgricola.Finalizada Then
            e.Row.BackColor = Drawing.Color.LightCyan
        End If
    End Sub
End Class
