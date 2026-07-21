Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaORDEN_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ORDEN_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaORDEN_COMBUSTIBLE
    Inherits ucBase
 
    Private mComponente As New cORDEN_COMBUSTIBLE
    Public Event Seleccionado(ByVal ID_ORDEN_COMBUS As Int32) 
    Public Event Editando(ByVal ID_ORDEN_COMBUS As Int32) 

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.gvLista.ShowFooter
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.ShowFooter = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            Return Me.gvLista.AllowPaging
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.AllowPaging = Value
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
            Me.gvLista.Columns(0).Visible = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Private _PermitirEliminar As Boolean = True
    Public Property PermitirEliminar() As Boolean
        Get
            Return _PermitirEliminar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEliminar = Value
            Me.gvLista.Columns(Me.gvLista.Columns.Count - 1).Visible = Value
            If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me.ViewState.Remove("PermitirEliminar")
            Me.ViewState.Add("PermitirEliminar", Value)
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
            Return Me.gvLista.Columns(0).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(0).HeaderText = Value
        End Set
    End Property

    Public Property VerID_ORDEN_COMBUS() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_COMBUS() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerID_TRANSPORTE() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerID_MOTORISTA() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_EMISION() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES_MOTORISTA() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDOS_MOTORISTA() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerPLACA() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_DESPACHO() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerNO_FACTURA_CCF() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(13).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(13).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(14).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(14).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(15).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(15).Visible = Value
        End Set
    End Property

    Public Property VerDUI() As Boolean
        Get
            Return Me.gvLista.Columns(16).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(16).Visible = Value
        End Set
    End Property

    Public Property VerLICENCIA() As Boolean
        Get
            Return Me.gvLista.Columns(17).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(17).Visible = Value
        End Set
    End Property

    Public Property VerESTADO() As Boolean
        Get
            Return Me.gvLista.Columns(18).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(18).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ANULACION() As Boolean
        Get
            Return Me.gvLista.Columns(19).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(19).Visible = Value
        End Set
    End Property

    Public Property VerMOTIVO_ANULACION() As Boolean
        Get
            Return Me.gvLista.Columns(20).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(20).Visible = Value
        End Set
    End Property

    Public Property VerNO_ORDEN() As Boolean
        Get
            Return Me.gvLista.Columns(21).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(21).Visible = Value
        End Set
    End Property

    Public Property VerID_ORDEN_COMBUSTIBLE_NUM() As Boolean
        Get
            Return Me.gvLista.Columns(22).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(22).Visible = Value
        End Set
    End Property

    Public Property VerTOTAL() As Boolean
        Get
            Return Me.gvLista.Columns(23).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(23).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO() As Boolean
        Get
            Return Me.gvLista.Columns(24).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(24).Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_PROVEEDOR() As Boolean
        Get
            Return Me.gvLista.Columns(25).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(25).Visible = Value
        End Set
    End Property

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.gvLista.Columns(26).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(26).Visible = Value
        End Set
    End Property

    Public Property HeaderID_ORDEN_COMBUS() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_PROVEEDOR_COMBUS() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TRANSPORTE() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_MOTORISTA() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_EMISION() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRES_MOTORISTA() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAPELLIDOS_MOTORISTA() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPLACA() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_DESPACHO() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNO_FACTURA_CCF() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.gvLista.Columns(13).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(13).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.gvLista.Columns(14).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(14).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.gvLista.Columns(15).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(15).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDUI() As String
        Get
            Return Me.gvLista.Columns(16).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(16).HeaderText = Value
        End Set
    End Property

    Public Property HeaderLICENCIA() As String
        Get
            Return Me.gvLista.Columns(17).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(17).HeaderText = Value
        End Set
    End Property

    Public Property HeaderESTADO() As String
        Get
            Return Me.gvLista.Columns(18).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(18).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ANULACION() As String
        Get
            Return Me.gvLista.Columns(19).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(19).HeaderText = Value
        End Set
    End Property

    Public Property HeaderMOTIVO_ANULACION() As String
        Get
            Return Me.gvLista.Columns(20).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(20).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNO_ORDEN() As String
        Get
            Return Me.gvLista.Columns(21).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(21).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ORDEN_COMBUSTIBLE_NUM() As String
        Get
            Return Me.gvLista.Columns(22).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(22).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTOTAL() As String
        Get
            Return Me.gvLista.Columns(23).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(23).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO() As String
        Get
            Return Me.gvLista.Columns(24).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(24).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_PROVEEDOR() As String
        Get
            Return Me.gvLista.Columns(25).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(25).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_CATORCENA() As String
        Get
            Return Me.gvLista.Columns(26).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(26).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_COMBUSTIBLE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lORDEN_COMBUSTIBLE As ListaORDEN_COMBUSTIBLE
        lORDEN_COMBUSTIBLE = Me.mComponente.ObtenerLista()
        If lORDEN_COMBUSTIBLE is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_COMBUSTIBLE
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_COMBUSTIBLE
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZAFRA(ByVal ID_ZAFRA As Int32) As Integer
        Dim lORDEN_COMBUSTIBLE As ListaORDEN_COMBUSTIBLE
        lORDEN_COMBUSTIBLE = Me.mComponente.ObtenerListaPorZAFRA(ID_ZAFRA)
        If lORDEN_COMBUSTIBLE is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorZAFRA") = True
        Me.ViewState("ID_ZAFRA") = ID_ZAFRA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_COMBUSTIBLE
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_COMBUSTIBLE
    ''' filtrado por la tabla PROVEEDOR_COMBUSTIBLE
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_COMBUS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_COMBUSTIBLE(ByVal ID_PROVEEDOR_COMBUS As Int32) As Integer
        Dim lORDEN_COMBUSTIBLE As ListaORDEN_COMBUSTIBLE
        lORDEN_COMBUSTIBLE = Me.mComponente.ObtenerListaPorPROVEEDOR_COMBUSTIBLE(ID_PROVEEDOR_COMBUS)
        If lORDEN_COMBUSTIBLE is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPROVEEDOR_COMBUSTIBLE") = True
        Me.ViewState("ID_PROVEEDOR_COMBUS") = ID_PROVEEDOR_COMBUS
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_COMBUSTIBLE
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_COMBUSTIBLE
    ''' filtrado por la tabla TIPO_PROVEEDOR
    ''' </summary>
    ''' <param name="ID_TIPO_PROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32) As Integer
        Dim lORDEN_COMBUSTIBLE As ListaORDEN_COMBUSTIBLE
        lORDEN_COMBUSTIBLE = Me.mComponente.ObtenerListaPorTIPO_PROVEEDOR(ID_TIPO_PROVEEDOR)
        If lORDEN_COMBUSTIBLE is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorTIPO_PROVEEDOR") = True
        Me.ViewState("ID_TIPO_PROVEEDOR") = ID_TIPO_PROVEEDOR
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_COMBUSTIBLE
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_COMBUSTIBLE
    ''' filtrado por la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32) As Integer
        Dim lORDEN_COMBUSTIBLE As ListaORDEN_COMBUSTIBLE
        lORDEN_COMBUSTIBLE = Me.mComponente.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA)
        If lORDEN_COMBUSTIBLE is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCATORCENA_ZAFRA") = True
        Me.ViewState("ID_CATORCENA") = ID_CATORCENA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_COMBUSTIBLE
        Me.gvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me._PermitirEliminar = Me.ViewState("PermitirEliminar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub

    Private lDdlZAFRAID_ZAFRA As SISPACAL.WebUC.ddlZAFRA
    Private lDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS As SISPACAL.WebUC.ddlPROVEEDOR_COMBUSTIBLE
    Private lDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR As SISPACAL.WebUC.ddlTIPO_PROVEEDOR
    Private lDdlCATORCENA_ZAFRAID_CATORCENA As SISPACAL.WebUC.ddlCATORCENA_ZAFRA

    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(CInt(e.CommandArgument))
        End If
    End Sub

    Protected Sub gvLista_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLista.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If Me.PermitirEliminar Then 
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton1"), LinkButton)
                a.Attributes.Add("onclick", "if(!window.confirm('Â¿Esta seguro de Eliminar el Registro?')){return false;}")
            End If
            Dim lbDetalle As LinkButton 
            lbDetalle = e.Row.FindControl("LinkButtonDetalle") 
            Dim mLabelID_ORDEN_COMBUS As Label
            mLabelID_ORDEN_COMBUS = e.Row.FindControl("Label_ID_ORDEN_COMBUS")
            mLabelID_ORDEN_COMBUS.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_ZAFRA Then
                Dim mDdlZAFRAID_ZAFRA As SISPACAL.WebUC.ddlZAFRA
                mDdlZAFRAID_ZAFRA = e.Row.FindControl("DdlZAFRAID_ZAFRA1")
                If lDdlZAFRAID_ZAFRA Is Nothing Then
                    lDdlZAFRAID_ZAFRA = New SISPACAL.WebUC.ddlZAFRA
                    lDdlZAFRAID_ZAFRA.Recuperar()
                End If
                Dim mZAFRAID_ZAFRA As String
                mZAFRAID_ZAFRA = CType(e.Row.FindControl("Label_ID_ZAFRA1"), Label).Text
                Dim lItem As ListItem = lDdlZAFRAID_ZAFRA.Items.FindByValue(mZAFRAID_ZAFRA)
                If mZAFRAID_ZAFRA <> "" And Not lItem Is Nothing Then
                    mDdlZAFRAID_ZAFRA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlZAFRAID_ZAFRA.SelectedValue = mZAFRAID_ZAFRA
                End If
            End If
            If Me.VerID_PROVEEDOR_COMBUS Then
                Dim mDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS As SISPACAL.WebUC.ddlPROVEEDOR_COMBUSTIBLE
                mDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS = e.Row.FindControl("DdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS1")
                If lDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS Is Nothing Then
                    lDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS = New SISPACAL.WebUC.ddlPROVEEDOR_COMBUSTIBLE
                    lDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS.Recuperar()
                End If
                Dim mPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS As String
                mPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS = CType(e.Row.FindControl("Label_ID_PROVEEDOR_COMBUS1"), Label).Text
                Dim lItem As ListItem = lDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS.Items.FindByValue(mPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS)
                If mPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS <> "" And Not lItem Is Nothing Then
                    mDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS.SelectedValue = mPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS
                End If
            End If
            If Me.VerID_TIPO_PROVEEDOR Then
                Dim mDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR As SISPACAL.WebUC.ddlTIPO_PROVEEDOR
                mDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR = e.Row.FindControl("DdlTIPO_PROVEEDORID_TIPO_PROVEEDOR1")
                If lDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR Is Nothing Then
                    lDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR = New SISPACAL.WebUC.ddlTIPO_PROVEEDOR
                    lDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR.Recuperar()
                End If
                Dim mTIPO_PROVEEDORID_TIPO_PROVEEDOR As String
                mTIPO_PROVEEDORID_TIPO_PROVEEDOR = CType(e.Row.FindControl("Label_ID_TIPO_PROVEEDOR1"), Label).Text
                Dim lItem As ListItem = lDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR.Items.FindByValue(mTIPO_PROVEEDORID_TIPO_PROVEEDOR)
                If mTIPO_PROVEEDORID_TIPO_PROVEEDOR <> "" And Not lItem Is Nothing Then
                    mDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue = mTIPO_PROVEEDORID_TIPO_PROVEEDOR
                End If
            End If
            If Me.VerID_CATORCENA Then
                Dim mDdlCATORCENA_ZAFRAID_CATORCENA As SISPACAL.WebUC.ddlCATORCENA_ZAFRA
                mDdlCATORCENA_ZAFRAID_CATORCENA = e.Row.FindControl("DdlCATORCENA_ZAFRAID_CATORCENA1")
                If lDdlCATORCENA_ZAFRAID_CATORCENA Is Nothing Then
                    lDdlCATORCENA_ZAFRAID_CATORCENA = New SISPACAL.WebUC.ddlCATORCENA_ZAFRA
                    lDdlCATORCENA_ZAFRAID_CATORCENA.Recuperar()
                End If
                Dim mCATORCENA_ZAFRAID_CATORCENA As String
                mCATORCENA_ZAFRAID_CATORCENA = CType(e.Row.FindControl("Label_ID_CATORCENA1"), Label).Text
                Dim lItem As ListItem = lDdlCATORCENA_ZAFRAID_CATORCENA.Items.FindByValue(mCATORCENA_ZAFRAID_CATORCENA)
                If mCATORCENA_ZAFRAID_CATORCENA <> "" And Not lItem Is Nothing Then
                    mDdlCATORCENA_ZAFRAID_CATORCENA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlCATORCENA_ZAFRAID_CATORCENA.SelectedValue = mCATORCENA_ZAFRAID_CATORCENA
                End If
            End If
            If Me.PermitirSeleccionar Then
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton_Seleccionar"), LinkButton)
                a.Text = Me.TextoSeleccionar
                a.CommandName = Me.ComandoSeleccionar
                If a.CommandName = "Check" Then
                    CType(e.Row.FindControl("CheckBox_Seleccionar"), CheckBox).Visible = True
                    a.Visible = False
                End If
            End If

        End If
    End Sub
 
    Private Sub gvLista_RowDeleting(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLista.RowDeleting
        If Me.mComponente.EliminarORDEN_COMBUSTIBLE(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorZAFRA") Then
            Me.CargarDatosPorZAFRA(Me.ViewState("ID_ZAFRA"))
            Return
        End If
        If Me.ViewState("PorPROVEEDOR_COMBUSTIBLE") Then
            Me.CargarDatosPorPROVEEDOR_COMBUSTIBLE(Me.ViewState("ID_PROVEEDOR_COMBUS"))
            Return
        End If
        If Me.ViewState("PorTIPO_PROVEEDOR") Then
            Me.CargarDatosPorTIPO_PROVEEDOR(Me.ViewState("ID_TIPO_PROVEEDOR"))
            Return
        End If
        If Me.ViewState("PorCATORCENA_ZAFRA") Then
            Me.CargarDatosPorCATORCENA_ZAFRA(Me.ViewState("ID_CATORCENA"))
            Return
        End If
            If Me.CargarDatos() <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        End If
    End Sub
 
    Private Sub gvLista_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvLista.SelectedIndexChanging
        RaiseEvent Seleccionado(CInt(CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip))
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        If Me.ViewState("PorZAFRA") Then
            Me.CargarDatosPorZAFRA(Me.ViewState("ID_ZAFRA"))
            Return
        End If
        If Me.ViewState("PorPROVEEDOR_COMBUSTIBLE") Then
            Me.CargarDatosPorPROVEEDOR_COMBUSTIBLE(Me.ViewState("ID_PROVEEDOR_COMBUS"))
            Return
        End If
        If Me.ViewState("PorTIPO_PROVEEDOR") Then
            Me.CargarDatosPorTIPO_PROVEEDOR(Me.ViewState("ID_TIPO_PROVEEDOR"))
            Return
        End If
        If Me.ViewState("PorCATORCENA_ZAFRA") Then
            Me.CargarDatosPorCATORCENA_ZAFRA(Me.ViewState("ID_CATORCENA"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaORDEN_COMBUSTIBLE
        Dim mLista As New ListaORDEN_COMBUSTIBLE
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New ORDEN_COMBUSTIBLE
                mEntidad.ID_ORDEN_COMBUS = CInt(CType(mRow.FindControl("Label_ID_ORDEN_COMBUS"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
