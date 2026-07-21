Imports DevExpress.Web
Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCOMPROB_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla COMPROB_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCOMPROB_ENCA
    Inherits ucListaBase

    Private mComponente As New cCOMPROB_ENCA
    Public Event Seleccionado(ByVal ID_COMPROB_ENCA As Int32)
    Public Event Editando(ByVal ID_COMPROB_ENCA As Int32)
    Public Event Desasociar(ByVal ID_COMPROB_ENCA As Int32)

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

    Public Property VerID_COMPROB_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_COMPROB_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_COMPROB_ENCA").Visible = Value
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

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CATORCENA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CATORCENA").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_PLANILLA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_PLANILLA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_PLANILLA").Visible = Value
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

    Public Property VerSERIE() As Boolean
        Get
            Return Me.dxgvLista.Columns("SERIE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SERIE").Visible = Value
        End Set
    End Property

    Public Property VerNUM_DOCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUM_DOCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUM_DOCTO").Visible = Value
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

    Public Property VerFECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRES").Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APELLIDOS").Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIRECCION").Visible = Value
        End Set
    End Property

    Public Property VerCODI_DEPTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_DEPTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_DEPTO").Visible = Value
        End Set
    End Property

    Public Property VerCODI_MUNI() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_MUNI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_MUNI").Visible = Value
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

    Public Property VerDUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI").Visible = Value
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

    Public Property VerGIRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("GIRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("GIRO").Visible = Value
        End Set
    End Property

    Public Property VerCORREO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CORREO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CORREO").Visible = Value
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

    Public Property VerRENTA() As Boolean
        Get
            Return Me.dxgvLista.Columns("RENTA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RENTA").Visible = Value
        End Set
    End Property

    Public Property VerSUBTOTAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("SUBTOTAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SUBTOTAL").Visible = Value
        End Set
    End Property

    Public Property VerIVA_RETENIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("IVA_RETENIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("IVA_RETENIDO").Visible = Value
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

    Public Property VerID_PLANILLA_COMPROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PLANILLA_COMPROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PLANILLA_COMPROB").Visible = Value
        End Set
    End Property

    Public Property HeaderID_COMPROB_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_COMPROB_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_COMPROB_ENCA").Caption = Value
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

    Public Property HeaderID_CATORCENA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CATORCENA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CATORCENA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_PLANILLA() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_PLANILLA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_PLANILLA").Caption = Value
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

    Public Property HeaderSERIE() As String
        Get
            Return Me.dxgvLista.Columns("SERIE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SERIE").Caption = Value
        End Set
    End Property

    Public Property HeaderNUM_DOCTO() As String
        Get
            Return Me.dxgvLista.Columns("NUM_DOCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUM_DOCTO").Caption = Value
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

    Public Property HeaderFECHA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRES() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRES").Caption = Value
        End Set
    End Property

    Public Property HeaderAPELLIDOS() As String
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("APELLIDOS").Caption = Value
        End Set
    End Property

    Public Property HeaderDIRECCION() As String
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIRECCION").Caption = Value
        End Set
    End Property

    Public Property HeaderCODI_DEPTO() As String
        Get
            Return Me.dxgvLista.Columns("CODI_DEPTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODI_DEPTO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODI_MUNI() As String
        Get
            Return Me.dxgvLista.Columns("CODI_MUNI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODI_MUNI").Caption = Value
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

    Public Property HeaderDUI() As String
        Get
            Return Me.dxgvLista.Columns("DUI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI").Caption = Value
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

    Public Property HeaderGIRO() As String
        Get
            Return Me.dxgvLista.Columns("GIRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("GIRO").Caption = Value
        End Set
    End Property

    Public Property HeaderCORREO() As String
        Get
            Return Me.dxgvLista.Columns("CORREO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CORREO").Caption = Value
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

    Public Property HeaderRENTA() As String
        Get
            Return Me.dxgvLista.Columns("RENTA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RENTA").Caption = Value
        End Set
    End Property

    Public Property HeaderSUBTOTAL() As String
        Get
            Return Me.dxgvLista.Columns("SUBTOTAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SUBTOTAL").Caption = Value
        End Set
    End Property

    Public Property HeaderIVA_RETENIDO() As String
        Get
            Return Me.dxgvLista.Columns("IVA_RETENIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("IVA_RETENIDO").Caption = Value
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

    Public Property HeaderID_PLANILLA_COMPROB() As String
        Get
            Return Me.dxgvLista.Columns("ID_PLANILLA_COMPROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PLANILLA_COMPROB").Caption = Value
        End Set
    End Property

#End Region



    Public Function CargarDatosPorCriterios(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Integer) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_CATORCENA").DefaultValue = ID_CATORCENA.ToString()
        Me.odsListaPorCriterios.SelectParameters("ID_TIPO_PLANILLA").DefaultValue = ID_TIPO_PLANILLA.ToString
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla COMPROB_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
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
    ''' Función que Carga la información de los registros de la tabla COMPROB_ENCA
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
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
    ''' Función que Carga la información de los registros de la tabla COMPROB_ENCA
    ''' filtrado por la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32) As Integer
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("ID_CATORCENA").DefaultValue = ID_CATORCENA.ToString()
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCATORCENA_ZAFRA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCATORCENA_ZAFRA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla COMPROB_ENCA
    ''' filtrado por la tabla TIPO_PLANILLA
    ''' </summary>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32) As Integer
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("ID_TIPO_PLANILLA").DefaultValue = ID_TIPO_PLANILLA.ToString()
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_PLANILLA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_PLANILLA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla COMPROB_ENCA
    ''' filtrado por la tabla TIPO_COMPROB
    ''' </summary>
    ''' <param name="ID_TIPO_COMPROB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
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
    ''' Función que Carga la información de los registros de la tabla COMPROB_ENCA
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String) As Integer
        Me.odsListaPorMUNICIPIO.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorMUNICIPIO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorMUNICIPIO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorMUNICIPIO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorMUNICIPIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorMUNICIPIO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
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
                keyValues(i) = grid.GetRowValues(i, "ID_COMPROB_ENCA")
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
        If e.CommandArgs.CommandName = "Desasociar" Then
            RaiseEvent Desasociar(e.KeyValue)
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaCOMPROB_ENCA
        Dim mLista As New listaCOMPROB_ENCA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_COMPROB_ENCA")
            Dim lEntidad As New COMPROB_ENCA
            lEntidad.ID_COMPROB_ENCA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As COMPROB_ENCA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), COMPROB_ENCA)

            If Me.mComponente.EliminarCOMPROB_ENCA(lEntidad.ID_COMPROB_ENCA) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Private Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NUM_CCF" Then
            Dim lstCredProvee As listaCREFISCAL_PROVEEDOR
            lstCredProvee = (New cCREFISCAL_PROVEEDOR).ObtenerListaPorCOMPROB_ENCA(e.GetListSourceFieldValue("ID_COMPROB_ENCA"))
            If lstCredProvee IsNot Nothing AndAlso lstCredProvee.Count > 0 Then
                e.Value = lstCredProvee(0).NUMERO
            End If
        End If
    End Sub
End Class
