Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaSOLIC_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SOLIC_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSOLIC_ENCA_TRANS
    Inherits ucListaBase
 
    Private mComponente As New cSOLIC_ENCA_TRANS
    Public Event Seleccionado(ByVal ID_SOLICITUD As Int32) 
    Public Event Editando(ByVal ID_SOLICITUD As Int32) 

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

    Public Property VerID_CONTRA_TRANS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTRA_TRANS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTRA_TRANS").Visible = Value
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

    Public Property VerCONDI_COMPRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONDI_COMPRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONDI_COMPRA").Visible = Value
        End Set
    End Property

    Public Property VerNUM_SOLIC_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUM_SOLIC_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUM_SOLIC_ZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerCODTRANSPORT() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODTRANSPORT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODTRANSPORT").Visible = Value
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

    Public Property VerID_CONTRA_TRANS_VEHI() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTRA_TRANS_VEHI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTRA_TRANS_VEHI").Visible = Value
        End Set
    End Property

    Public Property VerID_TRANSPORTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TRANSPORTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TRANSPORTE").Visible = Value
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

    Public Property VerID_ESTADO_SOLIC() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_SOLIC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ESTADO_SOLIC").Visible = Value
        End Set
    End Property

    Public Property VerUID_SOLIC_ENCA_TRANS() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_SOLIC_ENCA_TRANS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_SOLIC_ENCA_TRANS").Visible = Value
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

    Public Property HeaderID_CONTRA_TRANS() As String
        Get
            Return Me.dxgvLista.Columns("ID_CONTRA_TRANS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CONTRA_TRANS").Caption = Value
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

    Public Property HeaderCONDI_COMPRA() As String
        Get
            Return Me.dxgvLista.Columns("CONDI_COMPRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CONDI_COMPRA").Caption = Value
        End Set
    End Property

    Public Property HeaderNUM_SOLIC_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("NUM_SOLIC_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUM_SOLIC_ZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODTRANSPORT() As String
        Get
            Return Me.dxgvLista.Columns("CODTRANSPORT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODTRANSPORT").Caption = Value
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

    Public Property HeaderID_CONTRA_TRANS_VEHI() As String
        Get
            Return Me.dxgvLista.Columns("ID_CONTRA_TRANS_VEHI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CONTRA_TRANS_VEHI").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TRANSPORTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_TRANSPORTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TRANSPORTE").Caption = Value
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

    Public Property HeaderID_ESTADO_SOLIC() As String
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_SOLIC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ESTADO_SOLIC").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_SOLIC_ENCA_TRANS() As String
        Get
            Return Me.dxgvLista.Columns("UID_SOLIC_ENCA_TRANS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_SOLIC_ENCA_TRANS").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_ENCA_TRANS
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_ENCA_TRANS
    ''' filtrado por la tabla CUENTA_FINAN
    ''' </summary>
    ''' <param name="ID_CUENTA_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_ENCA_TRANS
    ''' filtrado por la tabla TRANSPORTISTA
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32) As Integer
        Me.odsListaPorTRANSPORTISTA.SelectParameters("CODTRANSPORT").DefaultValue = CODTRANSPORT.ToString()
        Me.odsListaPorTRANSPORTISTA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTRANSPORTISTA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTRANSPORTISTA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTRANSPORTISTA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTRANSPORTISTA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTRANSPORTISTA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_ENCA_TRANS
    ''' filtrado por la tabla ESTADO_SOLIC
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLIC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_SOLIC(ByVal ID_ESTADO_SOLIC As Int32) As Integer
        Me.odsListaPorESTADO_SOLIC.SelectParameters("ID_ESTADO_SOLIC").DefaultValue = ID_ESTADO_SOLIC.ToString()
        Me.odsListaPorESTADO_SOLIC.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorESTADO_SOLIC.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorESTADO_SOLIC.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorESTADO_SOLIC.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorESTADO_SOLIC.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorESTADO_SOLIC"
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

    Public Function DevolverSeleccionados() As listaSOLIC_ENCA_TRANS
        Dim mLista As New listaSOLIC_ENCA_TRANS
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_SOLICITUD")
            Dim lEntidad As New SOLIC_ENCA_TRANS
            lEntidad.ID_SOLICITUD = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As SOLIC_ENCA_TRANS = CType(Me.dxgvLista.GetRow(e.VisibleIndex), SOLIC_ENCA_TRANS)

            lEntidad = (New cSOLIC_ENCA_TRANS).ObtenerSOLIC_ENCA_TRANS(lEntidad.ID_SOLICITUD)
            If lEntidad.ID_ESTADO_SOLIC <> Enumeradores.EstadoSolicAgricola.Pendiente Then
                Me.AsignarMensaje("La Solicitud debe estar en tramite para ser eliminada", False, True, True)
                Return
            End If
            If Me.mComponente.EliminarSOLIC_ENCA_TRANS(lEntidad.ID_SOLICITUD) <> 1 Then
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
        If e.Column.FieldName = "CONDICION_COMPRA" Then
            e.Value = Utilerias.NombreCondicionCompra(CInt(e.GetListSourceFieldValue("CONDI_COMPRA")))
        ElseIf e.Column.FieldName = "NOMBRE_TRANSPORTISTA" Then
            If e.GetListSourceFieldValue("CODTRANSPORT") IsNot Nothing Then
                Dim lEntidad As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(e.GetListSourceFieldValue("CODTRANSPORT"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
                End If
            End If
        ElseIf e.Column.FieldName = "NO_CONTRATO" Then
            If e.GetListSourceFieldValue("ID_CONTRA_TRANS") IsNot Nothing Then
                Dim lEntidad As CONTRATO_TRANS = (New cCONTRATO_TRANS).ObtenerCONTRATO_TRANS(e.GetListSourceFieldValue("ID_CONTRA_TRANS"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NO_CONTRATO
                End If
            End If
        ElseIf e.Column.FieldName = "PROVEEDOR_TRANSPO" Then
            Dim lstSolicProd As listaSOLIC_PROD_TRANS = (New cSOLIC_PROD_TRANS).ObtenerListaPorSOLIC_ENCA_TRANS(e.GetListSourceFieldValue("ID_SOLICITUD"), False, "ID_PROVEE")
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
        ElseIf e.Column.FieldName = "DESCRIP_ESTADO_SOLIC" Then
            If e.GetListSourceFieldValue("ID_ESTADO_SOLIC") IsNot Nothing Then
                Dim lEntidad As ESTADO_SOLIC = (New cESTADO_SOLIC).ObtenerESTADO_SOLIC(e.GetListSourceFieldValue("ID_ESTADO_SOLIC"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.DESCRIP_ESTADO_SOLIC
                End If
            End If
        End If
    End Sub
End Class
