Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaREQENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla REQENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaREQENCA
    Inherits ucListaBase

    Private mComponente As New cREQENCA
    Public Event Seleccionado(ByVal ID_REQENCA As Int32)
    Public Event Editando(ByVal ID_REQENCA As Int32)

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

    Public Property VerID_REQENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_REQENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_REQENCA").Visible = Value
        End Set
    End Property

    Public Property VerID_PERIODOREQ() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PERIODOREQ").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PERIODOREQ").Visible = Value
        End Set
    End Property

    Public Property VerID_SECCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SECCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SECCION").Visible = Value
        End Set
    End Property

    Public Property VerID_SOLICITANTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITANTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SOLICITANTE").Visible = Value
        End Set
    End Property

    Public Property VerNO_REQ() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_REQ").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_REQ").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_EMISION() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_EMISION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_EMISION").Visible = Value
        End Set
    End Property

    Public Property VerNO_REQ_PH() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_REQ_PH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_REQ_PH").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_REQ_PH() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_REQ_PH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_REQ_PH").Visible = Value
        End Set
    End Property

    Public Property VerNO_ORDEN_PH() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_ORDEN_PH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_ORDEN_PH").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ORDEN_PH() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ORDEN_PH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ORDEN_PH").Visible = Value
        End Set
    End Property

    Public Property VerTOTAL_ORDEN_PH() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL_ORDEN_PH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL_ORDEN_PH").Visible = Value
        End Set
    End Property

    Public Property VerAFECTO_ORDEN_PH() As Boolean
        Get
            Return Me.dxgvLista.Columns("AFECTO_ORDEN_PH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("AFECTO_ORDEN_PH").Visible = Value
        End Set
    End Property

    Public Property VerIVA_ORDEN_PH() As Boolean
        Get
            Return Me.dxgvLista.Columns("IVA_ORDEN_PH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("IVA_ORDEN_PH").Visible = Value
        End Set
    End Property

    Public Property VerNO_INGRESO_ALM() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_INGRESO_ALM").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_INGRESO_ALM").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INGRESO_ALM() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INGRESO_ALM").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INGRESO_ALM").Visible = Value
        End Set
    End Property

    Public Property VerNO_QUEDAN() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_QUEDAN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_QUEDAN").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_QUEDAN() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_QUEDAN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_QUEDAN").Visible = Value
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

    Public Property VerUSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("USO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USO").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_APROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_APROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_APROB").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_APROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_APROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_APROB").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_NOAPROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_NOAPROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_NOAPROB").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_NOAPROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_NOAPROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_NOAPROB").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ANUL() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_ANUL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_ANUL").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ANUL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ANUL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ANUL").Visible = Value
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

    Public Property HeaderID_REQENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_REQENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_REQENCA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PERIODOREQ() As String
        Get
            Return Me.dxgvLista.Columns("ID_PERIODOREQ").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PERIODOREQ").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SECCION() As String
        Get
            Return Me.dxgvLista.Columns("ID_SECCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SECCION").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SOLICITANTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITANTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SOLICITANTE").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_REQ() As String
        Get
            Return Me.dxgvLista.Columns("NO_REQ").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_REQ").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_EMISION() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_EMISION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_EMISION").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_REQ_PH() As String
        Get
            Return Me.dxgvLista.Columns("NO_REQ_PH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_REQ_PH").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_REQ_PH() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_REQ_PH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_REQ_PH").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_ORDEN_PH() As String
        Get
            Return Me.dxgvLista.Columns("NO_ORDEN_PH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_ORDEN_PH").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ORDEN_PH() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ORDEN_PH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ORDEN_PH").Caption = Value
        End Set
    End Property

    Public Property HeaderTOTAL_ORDEN_PH() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL_ORDEN_PH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL_ORDEN_PH").Caption = Value
        End Set
    End Property

    Public Property HeaderAFECTO_ORDEN_PH() As String
        Get
            Return Me.dxgvLista.Columns("AFECTO_ORDEN_PH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("AFECTO_ORDEN_PH").Caption = Value
        End Set
    End Property

    Public Property HeaderIVA_ORDEN_PH() As String
        Get
            Return Me.dxgvLista.Columns("IVA_ORDEN_PH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("IVA_ORDEN_PH").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_INGRESO_ALM() As String
        Get
            Return Me.dxgvLista.Columns("NO_INGRESO_ALM").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_INGRESO_ALM").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INGRESO_ALM() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INGRESO_ALM").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INGRESO_ALM").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_QUEDAN() As String
        Get
            Return Me.dxgvLista.Columns("NO_QUEDAN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_QUEDAN").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_QUEDAN() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_QUEDAN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_QUEDAN").Caption = Value
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

    Public Property HeaderUSO() As String
        Get
            Return Me.dxgvLista.Columns("USO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USO").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_APROB() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_APROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_APROB").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_APROB() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_APROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_APROB").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_NOAPROB() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_NOAPROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_NOAPROB").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_NOAPROB() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_NOAPROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_NOAPROB").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ANUL() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_ANUL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_ANUL").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ANUL() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ANUL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ANUL").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla REQENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla REQENCA
    ''' filtrado por la tabla PERIODOREQ
    ''' </summary>
    ''' <param name="ID_PERIODOREQ"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPERIODOREQ(ByVal ID_PERIODOREQ As Int32) As Integer
        Me.odsListaPorPERIODOREQ.SelectParameters("ID_PERIODOREQ").DefaultValue = ID_PERIODOREQ.ToString()
        Me.odsListaPorPERIODOREQ.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorPERIODOREQ.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPERIODOREQ.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPERIODOREQ.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPERIODOREQ.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPERIODOREQ"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorCriterios(ByVal ID_PERIODOREQ As Int32, ByVal NO_REQ As Int32, ByVal CODI_REQ As String, ByVal ID_SECCION As Int32, ByVal ID_SOLICITANTE As Int32, ByVal ID_REQETAPA As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_PERIODOREQ").DefaultValue = ID_PERIODOREQ
        Me.odsListaPorCriterios.SelectParameters("NO_REQ").DefaultValue = NO_REQ
        Me.odsListaPorCriterios.SelectParameters("CODI_REQ").DefaultValue = CODI_REQ
        Me.odsListaPorCriterios.SelectParameters("ID_SECCION").DefaultValue = ID_SECCION
        Me.odsListaPorCriterios.SelectParameters("ID_SOLICITANTE").DefaultValue = ID_SOLICITANTE
        Me.odsListaPorCriterios.SelectParameters("ID_REQETAPA").DefaultValue = ID_REQETAPA
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla REQENCA
    ''' filtrado por la tabla SECCION
    ''' </summary>
    ''' <param name="ID_SECCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSECCION(ByVal ID_SECCION As Int32) As Integer
        Me.odsListaPorSECCION.SelectParameters("ID_SECCION").DefaultValue = ID_SECCION.ToString()
        Me.odsListaPorSECCION.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorSECCION.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSECCION.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSECCION.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSECCION.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSECCION"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla REQENCA
    ''' filtrado por la tabla SOLICITANTE
    ''' </summary>
    ''' <param name="ID_SOLICITANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLICITANTE(ByVal ID_SOLICITANTE As Int32) As Integer
        Me.odsListaPorSOLICITANTE.SelectParameters("ID_SOLICITANTE").DefaultValue = ID_SOLICITANTE.ToString()
        Me.odsListaPorSOLICITANTE.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorSOLICITANTE.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSOLICITANTE.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSOLICITANTE.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSOLICITANTE.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSOLICITANTE"
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
                keyValues(i) = grid.GetRowValues(i, "ID_REQENCA")
                keyNames(i) = grid.GetRowValues(i, "ID_PERIODOREQ")
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

    Public Function DevolverSeleccionados() As listaREQENCA
        Dim mLista As New listaREQENCA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_REQENCA")
            Dim lEntidad As New REQENCA
            lEntidad.ID_REQENCA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As REQENCA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), REQENCA)

            If Me.mComponente.EliminarREQENCA(lEntidad.ID_REQENCA) <> 1 Then
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
        If e.Column.FieldName = "PERIODO" Then
            Dim lPeriodo As PERIODOREQ = (New cPERIODOREQ).ObtenerPERIODOREQ(e.GetListSourceFieldValue("ID_PERIODOREQ"))
            If lPeriodo IsNot Nothing Then
                e.Value = lPeriodo.DESCRIP_PERIODO
            End If
        ElseIf e.Column.FieldName = "AREA_DEPTO" Then
            Dim lSeccion As SECCION = (New cSECCION).ObtenerSECCION(e.GetListSourceFieldValue("ID_SECCION"))
            If lSeccion IsNot Nothing Then
                e.Value = lSeccion.NOMBRE_SECCION
            End If
        ElseIf e.Column.FieldName = "SOLICITANTE" Then
            Dim lSolicitante As SOLICITANTE = (New cSOLICITANTE).ObtenerSOLICITANTE(e.GetListSourceFieldValue("ID_SOLICITANTE"))
            If lSolicitante IsNot Nothing Then
                e.Value = lSolicitante.NOMBRE_SOLICITANTE
            End If
        ElseIf e.Column.FieldName = "ETAPA" Then
            Dim lEntidad As REQETAPA = (New cREQETAPA).ObtenerREQETAPA(e.GetListSourceFieldValue("ID_REQETAPA"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOM_REQETAPA
            End If
        ElseIf e.Column.FieldName = "FECHA_INGRESO_ESTIMADA" Then
            Dim lFecha As DateTime = e.GetListSourceFieldValue("FECHA_INGRESO_EST")
            If lFecha <> #12:00:00 AM# Then
                e.Value = lFecha.ToString("dd/MM/yyyy")
            End If
        ElseIf e.Column.FieldName = "FECHA_MAX_DE_SUMINISTRO" Then
            Dim lFecha As DateTime = e.GetListSourceFieldValue("FECHA_MAX_SUMIN")
            If lFecha <> #12:00:00 AM# Then
                e.Value = lFecha.ToString("dd/MM/yyyy")
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROPOSITO" Then
            Dim iProposito As Int32 = e.GetListSourceFieldValue("PROPOSITO")
            Select Case iProposito
                Case 1
                    e.Value = "REPARACION"
                Case 2
                    e.Value = "INVERSION"
                Case 3
                    e.Value = "PROVISION"
            End Select
        End If
    End Sub
End Class
