Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaSOLIC_AGRICOLA_PRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SOLIC_AGRICOLA_PRODUCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSOLIC_AGRICOLA_PRODUCTO
    Inherits ucListaBase

    Private mComponente As New cSOLIC_AGRICOLA_PRODUCTO
    Public Event Seleccionado(ByVal ID_SOLIC_AGRI_PROD As Int32)
    Public Event Editando(ByVal ID_SOLIC_AGRI_PROD As Int32)
    Public Event Eliminando(ByVal ID_SOLIC_AGRI_PROD As Int32)

#Region "Propiedades"
    Public Property REFERENCIA() As String
        Get
            Return Me.ViewState("REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("REFERENCIA") = value
        End Set
    End Property

    Public Property ZAFRA() As String
        Get
            Return Me.ViewState("ZAFRA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("ZAFRA") = value
        End Set
    End Property

    Public Property MZ() As Decimal
        Get
            Return Me.hfSolicAgricolaProducto.Get("MZ")
        End Get
        Set(ByVal value As Decimal)
            Me.hfSolicAgricolaProducto.Set("MZ", value)
        End Set
    End Property

    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return Me.hfSolicAgricolaProducto.Get("ID_CUENTA_FINAN")
        End Get
        Set(ByVal value As Int32)
            Me.hfSolicAgricolaProducto.Set("ID_CUENTA_FINAN", value)
        End Set
    End Property

    Public Sub IniciarEdicion()
        dxgvLista.StartEdit(dxgvLista.VisibleStartIndex)
    End Sub

    Public Sub CancelarEdicion()
        dxgvLista.CancelEdit()
    End Sub

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
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = value
            Me.dxgvLista.Columns("Edicion").Visible = Me.PermitirEditarInline
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
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowNewButtonInHeader = value
        End Set
    End Property

    Public Property PermitirAgregar() As Boolean
        Get
            Return Me.ViewState("PermitirAgregar")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregar") = value
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

    Public Property VerID_SOLIC_AGRI_PROD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SOLIC_AGRI_PROD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SOLIC_AGRI_PROD").Visible = Value
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

    Public Property VerCANT_X_MZ() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANT_X_MZ").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANT_X_MZ").Visible = Value
        End Set
    End Property

    Public Property TOTAL_PRODUCTO_VisibleIndex() As Int32
        Get
            Return Me.dxgvLista.Columns("TOTAL_PRODUCTO").VisibleIndex
        End Get
        Set(ByVal Value As Int32)
            Me.dxgvLista.Columns("TOTAL_PRODUCTO").VisibleIndex = Value
        End Set
    End Property

    Public Property TOTAL_PRODUCTO_Caption() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL_PRODUCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL_PRODUCTO").Caption = Value
        End Set
    End Property

    Public WriteOnly Property NOMBRE_PRODUCTO_Width() As Int32
        Set(ByVal Value As Int32)
            Me.dxgvLista.Columns("ID_PRODUCTO").Width = New Unit(Value, UnitType.Pixel)
        End Set
    End Property

    Public Property VerTOTAL_PRODUCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL_PRODUCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL_PRODUCTO").Visible = Value
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

    Public Property VerPRECIO_TOTAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRECIO_TOTAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRECIO_TOTAL").Visible = Value
        End Set
    End Property



    Public Property VerCANT_ADJU() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANT_ADJU").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANT_ADJU").Visible = Value
        End Set
    End Property
    Public Property VerPRECIO_ADJU() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRECIO_ADJU").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRECIO_ADJU").Visible = Value
        End Set
    End Property
    Public Property VerTOTAL_ADJU() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL_ADJU").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL_ADJU").Visible = Value
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

    Public Property HeaderID_SOLIC_AGRI_PROD() As String
        Get
            Return Me.dxgvLista.Columns("ID_SOLIC_AGRI_PROD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SOLIC_AGRI_PROD").Caption = Value
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

    Public Property HeaderCANT_X_MZ() As String
        Get
            Return Me.dxgvLista.Columns("CANT_X_MZ").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CANT_X_MZ").Caption = Value
        End Set
    End Property

    Public Property HeaderTOTAL_PRODUCTO() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL_PRODUCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL_PRODUCTO").Caption = Value
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

    Public Property HeaderPRECIO_TOTAL() As String
        Get
            Return Me.dxgvLista.Columns("PRECIO_TOTAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRECIO_TOTAL").Caption = Value
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_AGRICOLA_PRODUCTO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
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

    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.REFERENCIA = nombreSesion
        Me.odsSolicAgricolaProdCache.SelectParameters("nombreSesion").DefaultValue = nombreSesion
        Me.odsSolicAgricolaProdCache.DataBind()
        Me.dxgvLista.DataSourceID = "odsSolicAgricolaProdCache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarProductosPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As String) As Integer
        Me.odsProductoAgricola.SelectParameters("ID_CUENTA_FINAN").DefaultValue = ID_CUENTA_FINAN
        Me.odsProductoAgricola.SelectParameters("asColumnaOrden").DefaultValue = "NOMBRE_PRODUCTO"
        Me.odsProductoAgricola.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsProductoAgricola.SelectParameters("AgregarVacio").DefaultValue = True
        Me.odsProductoAgricola.DataBind()

        'Dim col As GridViewDataComboBoxColumn = TryCast(dxgvLista.Columns("ID_PRODUCTO"), GridViewDataComboBoxColumn)
        'If col IsNot Nothing Then
        '    col.PropertiesComboBox.DataSourceID = "odsProductoAgricola"
        '    col.PropertiesComboBox.ValueType = GetType(Integer)
        '    col.PropertiesComboBox.TextField = "NOMBRE_PRODUCTO"
        '    col.PropertiesComboBox.ValueField = "ID_PRODUCTO"
        'End If
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_AGRICOLA_PRODUCTO
    ''' filtrado por la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32) As Integer
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("ID_SOLICITUD").DefaultValue = ID_SOLICITUD.ToString()
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSOLIC_AGRICOLA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSOLIC_AGRICOLA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_AGRICOLA_PRODUCTO
    ''' filtrado por la tabla PRODUCTO
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
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
        If Not Me.hfSolicAgricolaProducto.Contains("ConCambios") Then Me.hfSolicAgricolaProducto.Add("ConCambios", 0)

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
                keyValues(i) = grid.GetRowValues(i, "ID_SOLIC_AGRI_PROD")
                keyNames(i) = grid.GetRowValues(i, "ID_SOLICITUD")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
        If Me.hfSolicAgricolaProducto.Get("ConCambios") = 1 Then
            Me.dxgvLista.JSProperties.Clear()
            Me.dxgvLista.JSProperties.Add("cpConCambios", 1)
            Me.hfSolicAgricolaProducto.Set("ConCambios", 0)
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        If Me.PermitirEditarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
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
        dxgvLista.ForceDataRowType(GetType(listaSOLIC_AGRICOLA_PRODUCTO))
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
        If e.CommandArgs.CommandName = "Eliminar" Then
            Dim b As New cSOLIC_AGRICOLA_PRODUCTOcache

            b.Eliminar(e.KeyValue, Me.REFERENCIA)
            Me.dxgvLista.DataBind()
            Me.CargarDatosCache(Me.REFERENCIA)
            RaiseEvent Eliminando(e.KeyValue)
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
                If lbDetalle IsNot Nothing Then lbDetalle.Visible = False
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

    Public Function DevolverSeleccionados() As listaSOLIC_AGRICOLA_PRODUCTO
        Dim mLista As New listaSOLIC_AGRICOLA_PRODUCTO
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_SOLIC_AGRI_PROD")
            Dim lEntidad As New SOLIC_AGRICOLA_PRODUCTO
            lEntidad.ID_SOLIC_AGRI_PROD = llave
            lEntidad.ID_PRODUCTO = CDec(dxgvLista.GetRowValuesByKeyValue(lEntidad.ID_PRODUCTO, "ID_PRODUCTO"))
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function


    'Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
    '    If e.ButtonID = "btnEliminar" Then
    '        Dim lEntidad As SOLIC_AGRICOLA_PRODUCTO = CType(Me.dxgvLista.GetRow(e.VisibleIndex), SOLIC_AGRICOLA_PRODUCTO)

    '        Dim bCache As New cSOLIC_AGRICOLA_PRODUCTOcache

    '        If bCache.Eliminar(lEntidad.ID_SOLIC_AGRI_PROD, lEntidad.REFERENCIA) <> 1 Then
    '            'Si se cometio un error
    '            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
    '        Else
    '            Me.dxgvLista.DataBind()
    '        End If
    '    End If
    'End Sub

    Protected Sub dxgvLista_InitNewRow(sender As Object, e As DevExpress.Web.Data.ASPxDataInitNewRowEventArgs) Handles dxgvLista.InitNewRow
        e.NewValues("REFERENCIA") = Me.REFERENCIA
        e.NewValues("ZAFRA") = Me.ZAFRA
    End Sub

    Protected Sub dxgvLista_RowInserted(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertedEventArgs) Handles dxgvLista.RowInserted
        Me.hfSolicAgricolaProducto.Set("ConCambios", 1)
    End Sub

    Protected Sub dxgvLista_RowUpdated(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatedEventArgs) Handles dxgvLista.RowUpdated
        Me.hfSolicAgricolaProducto.Set("ConCambios", 1)
    End Sub

    Protected Sub dxgvLista_RowDeleting(sender As Object, e As DevExpress.Web.Data.ASPxDataDeletingEventArgs) Handles dxgvLista.RowDeleting
        Me.hfSolicAgricolaProducto.Set("ConCambios", 1)
    End Sub

    Protected Sub dxgvLista_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles dxgvLista.RowInserting
        e.NewValues("REFERENCIA") = Me.REFERENCIA
        e.NewValues("ZAFRA") = Me.ZAFRA
    End Sub

    Private Function ObtenerSubTotal() As Decimal
        Dim subTOTAL As Decimal = 0
        If Session(Me.REFERENCIA) IsNot Nothing Then
            For Each lProducto As SOLIC_AGRICOLA_PRODUCTO In DirectCast(Session(Me.REFERENCIA), listaSOLIC_AGRICOLA_PRODUCTO)
                subTOTAL += lProducto.PRECIO_TOTAL
            Next
        End If
        Return subTOTAL
    End Function

    Protected Sub cpListaSOLIC_AGRICOLA_PRODUCTO_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpListaSOLIC_AGRICOLA_PRODUCTO.Callback
        cpListaSOLIC_AGRICOLA_PRODUCTO.JSProperties.Clear()
        Dim s As String() = e.Parameter.Split(";")
        Select Case s(0)
            Case "TarifaProducto"
                If s(1) IsNot Nothing Then
                    Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(CInt(s(1)))
                    If lProducto IsNot Nothing Then
                        cpListaSOLIC_AGRICOLA_PRODUCTO.JSProperties.Add("cpMensaje", "TarifaProducto")
                        cpListaSOLIC_AGRICOLA_PRODUCTO.JSProperties.Add("cpTarifa", lProducto.PRECIO_UNITARIO.ToString)
                    End If
                End If
        End Select
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NOMBRE_PROVEE" Then
            Dim lEntidad As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(e.GetListSourceFieldValue("ID_PROVEE"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE
        End If
    End Sub
End Class
