Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCCF_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CCF_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCCF_ENCA
    Inherits ucListaBase
 
    Private mComponente As New cCCF_ENCA
    Public Event Seleccionado(ByVal ID_CCF_ENCA As Int32) 
    Public Event Editando(ByVal ID_CCF_ENCA As Int32) 

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

    Public Property VerID_CCF_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CCF_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CCF_ENCA").Visible = Value
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

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SOLICITUD").Visible = Value
        End Set
    End Property

    Public Property VerID_CUENTA_FINAN() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CUENTA_FINAN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CUENTA_FINAN").Visible = Value
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

    Public Property VerNO_CCF() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_CCF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_CCF").Visible = Value
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

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Visible = Value
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

    Public Property VerDESCTO_PORC() As Boolean
        Get
            Return Me.dxgvLista.Columns("DESCTO_PORC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DESCTO_PORC").Visible = Value
        End Set
    End Property

    Public Property VerDESCTO_MONTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("DESCTO_MONTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DESCTO_MONTO").Visible = Value
        End Set
    End Property

    Public Property VerSUMAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("SUMAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SUMAS").Visible = Value
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

    Public Property VerTOTAL_LETRAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL_LETRAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL_LETRAS").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREACION").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CREACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CREACION").Visible = Value
        End Set
    End Property

    Public Property HeaderID_CCF_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CCF_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CCF_ENCA").Caption = Value
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

    Public Property HeaderID_SOLICITUD() As String
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SOLICITUD").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CUENTA_FINAN() As String
        Get
            Return Me.dxgvLista.Columns("ID_CUENTA_FINAN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CUENTA_FINAN").Caption = Value
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

    Public Property HeaderNO_CCF() As String
        Get
            Return Me.dxgvLista.Columns("NO_CCF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_CCF").Caption = Value
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

    Public Property HeaderCODIPROVEEDOR() As String
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Caption = Value
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

    Public Property HeaderDESCTO_PORC() As String
        Get
            Return Me.dxgvLista.Columns("DESCTO_PORC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DESCTO_PORC").Caption = Value
        End Set
    End Property

    Public Property HeaderDESCTO_MONTO() As String
        Get
            Return Me.dxgvLista.Columns("DESCTO_MONTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DESCTO_MONTO").Caption = Value
        End Set
    End Property

    Public Property HeaderSUMAS() As String
        Get
            Return Me.dxgvLista.Columns("SUMAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SUMAS").Caption = Value
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

    Public Property HeaderTOTAL_LETRAS() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL_LETRAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL_LETRAS").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREACION() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREACION").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREACION() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CREACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CREACION").Caption = Value
        End Set
    End Property

#End Region

    Public Sub ExportarExcel()
        gridExport.WriteXlsxToResponse(New DevExpress.XtraPrinting.XlsxExportOptionsEx With {.ExportType = DevExpress.Export.ExportType.WYSIWYG})
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
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

    Public Function CargarDatosPorCONCEPTO_CCF(ByVal CONCEPTO_CCF As Int32) As Integer
        Me.odsListaPorCONCEPTO_CCF.SelectParameters("CONCEPTO_CCF").DefaultValue = CONCEPTO_CCF.ToString
        Me.odsListaPorCONCEPTO_CCF.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONCEPTO_CCF"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_ENCA
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_ENCA
    ''' filtrado por la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32) As Integer
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("ID_SOLICITUD").DefaultValue = ID_SOLICITUD.ToString()
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_ENCA
    ''' filtrado por la tabla CUENTA_FINAN
    ''' </summary>
    ''' <param name="ID_CUENTA_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32) As Integer
        Me.odsListaPorCUENTA_FINAN.SelectParameters("ID_CUENTA_FINAN").DefaultValue = ID_CUENTA_FINAN.ToString()
        Me.odsListaPorCUENTA_FINAN.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorCUENTA_FINAN.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCUENTA_FINAN.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCUENTA_FINAN.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCUENTA_FINAN.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCUENTA_FINAN"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_ENCA
    ''' filtrado por la tabla TIPO_COMPROB
    ''' </summary>
    ''' <param name="ID_TIPO_COMPROB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_ENCA
    ''' filtrado por la tabla PROVEEDOR
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
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
                keyValues(i) = grid.GetRowValues(i, "ID_CCF_ENCA")
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

    Public Function DevolverSeleccionados() As listaCCF_ENCA
        Dim mLista As New listaCCF_ENCA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_CCF_ENCA")
            Dim lEntidad As New CCF_ENCA
            lEntidad.ID_CCF_ENCA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CCF_ENCA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CCF_ENCA)

            If Me.mComponente.EliminarCCF_ENCA(lEntidad.ID_CCF_ENCA) <> 1 Then
                'Si se cometio un error
                dxgvLista.JSProperties.Add("cpMensaje", "Error al Eliminar Registro: " + Me.mComponente.sError)
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
        If e.Column.FieldName = "NOMBRE_ZAFRA" Then
            Dim lEntidad As ZAFRA = (New cZAFRA).ObtenerZAFRA(e.GetListSourceFieldValue("ID_ZAFRA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_ZAFRA
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" AndAlso e.GetListSourceFieldValue("CODIPROVEEDOR") <> "" Then
            Dim lEntidad As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
        ElseIf e.Column.FieldName = "CODIPROVEE" Then
            e.Value = Utilerias.RecuperarCODIPROVEE(e.GetListSourceFieldValue("CODIPROVEEDOR"))
        ElseIf e.Column.FieldName = "NUM_SOLICITUD" Then
            Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(e.GetListSourceFieldValue("ID_SOLICITUD"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NUM_SOLICITUD
        ElseIf e.Column.FieldName = "NO_ORDEN" Then
            Dim lEntidad As ORDEN_COMPRA_AGRI = (New cORDEN_COMPRA_AGRI).ObtenerORDEN_COMPRA_AGRI(e.GetListSourceFieldValue("ID_ORDEN"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.CODI_ORDEN
        ElseIf e.Column.FieldName = "TIPO_COMPROB" Then
            Dim lEntidad As TIPO_COMPROB = (New cTIPO_COMPROB).ObtenerTIPO_COMPROB(e.GetListSourceFieldValue("ID_TIPO_COMPROB"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_TIPO
        ElseIf e.Column.FieldName = "NOMBRE_CONDI_COMPRA" Then
            e.Value = Utilerias.NombreCondicionCompra(e.GetListSourceFieldValue("CONDI_COMPRA"))
        ElseIf e.Column.FieldName = "NOMBRE_PROVEE_AGRICOLA" Then
            Dim lEntidad As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(e.GetListSourceFieldValue("ID_PROVEE"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        End If
    End Sub
End Class
