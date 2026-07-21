Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaDESCUENTOS_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla DESCUENTOS_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaDESCUENTOS_PLANILLA
    Inherits ucBase
 
    Private mComponente As New cDESCUENTOS_PLANILLA
    Public Event Seleccionado(ByVal ID_DESCUENTO_PLANILLA As Int32) 
    Public Event Editando(ByVal ID_DESCUENTO_PLANILLA As Int32) 

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

    Public Property VerID_DESCUENTO_PLANILLA() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR_TRANSPORTISTA() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_PLANILLA() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_DESCTO() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerID_APLICACION_DESCTO() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerMONTO_DESCUENTO() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property HeaderID_DESCUENTO_PLANILLA() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_CATORCENA() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_PLANILLA() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_DESCTO() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_APLICACION_DESCTO() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderMONTO_DESCUENTO() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DESCUENTOS_PLANILLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lDESCUENTOS_PLANILLA As ListaDESCUENTOS_PLANILLA
        lDESCUENTOS_PLANILLA = Me.mComponente.ObtenerLista()
        If lDESCUENTOS_PLANILLA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDESCUENTOS_PLANILLA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DESCUENTOS_PLANILLA
    ''' filtrado por la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32) As Integer
        Dim lDESCUENTOS_PLANILLA As ListaDESCUENTOS_PLANILLA
        lDESCUENTOS_PLANILLA = Me.mComponente.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA)
        If lDESCUENTOS_PLANILLA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCATORCENA_ZAFRA") = True
        Me.ViewState("ID_CATORCENA") = ID_CATORCENA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDESCUENTOS_PLANILLA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DESCUENTOS_PLANILLA
    ''' filtrado por la tabla PLANILLA
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32) As Integer
        Dim lDESCUENTOS_PLANILLA As ListaDESCUENTOS_PLANILLA
        lDESCUENTOS_PLANILLA = Me.mComponente.ObtenerListaPorPLANILLA(ID_CATORCENA, CODIPROVEEDOR_TRANSPORTISTA, ID_TIPO_PLANILLA)
        If lDESCUENTOS_PLANILLA is Nothing Then
            'Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPLANILLA") = True
        Me.ViewState("ID_CATORCENA") = ID_CATORCENA
        Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA") = CODIPROVEEDOR_TRANSPORTISTA
        Me.ViewState("ID_TIPO_PLANILLA") = ID_TIPO_PLANILLA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDESCUENTOS_PLANILLA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DESCUENTOS_PLANILLA
    ''' filtrado por la tabla TIPO_PLANILLA
    ''' </summary>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32) As Integer
        Dim lDESCUENTOS_PLANILLA As ListaDESCUENTOS_PLANILLA
        lDESCUENTOS_PLANILLA = Me.mComponente.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA)
        If lDESCUENTOS_PLANILLA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorTIPO_PLANILLA") = True
        Me.ViewState("ID_TIPO_PLANILLA") = ID_TIPO_PLANILLA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDESCUENTOS_PLANILLA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DESCUENTOS_PLANILLA
    ''' filtrado por la tabla TIPO_DESCUENTO
    ''' </summary>
    ''' <param name="ID_TIPO_DESCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_DESCUENTO(ByVal ID_TIPO_DESCTO As Int32) As Integer
        Dim lDESCUENTOS_PLANILLA As ListaDESCUENTOS_PLANILLA
        lDESCUENTOS_PLANILLA = Me.mComponente.ObtenerListaPorTIPO_DESCUENTO(ID_TIPO_DESCTO)
        If lDESCUENTOS_PLANILLA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorTIPO_DESCUENTO") = True
        Me.ViewState("ID_TIPO_DESCTO") = ID_TIPO_DESCTO
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDESCUENTOS_PLANILLA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DESCUENTOS_PLANILLA
    ''' filtrado por la tabla APLICACION_DESCTO
    ''' </summary>
    ''' <param name="ID_APLICACION_DESCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorAPLICACION_DESCTO(ByVal ID_APLICACION_DESCTO As Int32) As Integer
        Dim lDESCUENTOS_PLANILLA As ListaDESCUENTOS_PLANILLA
        lDESCUENTOS_PLANILLA = Me.mComponente.ObtenerListaPorAPLICACION_DESCTO(ID_APLICACION_DESCTO)
        If lDESCUENTOS_PLANILLA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorAPLICACION_DESCTO") = True
        Me.ViewState("ID_APLICACION_DESCTO") = ID_APLICACION_DESCTO
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDESCUENTOS_PLANILLA
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

    Private lDdlCATORCENA_ZAFRAID_CATORCENA As SISPACAL.WebUC.ddlCATORCENA_ZAFRA
    Private lDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA As SISPACAL.WebUC.ddlPLANILLA
    Private lDdlTIPO_PLANILLAID_TIPO_PLANILLA As SISPACAL.WebUC.ddlTIPO_PLANILLA
    Private lDdlTIPO_DESCUENTOID_TIPO_DESCTO As SISPACAL.WebUC.ddlTIPO_DESCUENTO
    Private lDdlAPLICACION_DESCTOID_APLICACION_DESCTO As SISPACAL.WebUC.ddlAPLICACION_DESCTO

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
            Dim mLabelID_DESCUENTO_PLANILLA As Label
            mLabelID_DESCUENTO_PLANILLA = e.Row.FindControl("Label_ID_DESCUENTO_PLANILLA")
            mLabelID_DESCUENTO_PLANILLA.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
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
            If Me.VerCODIPROVEEDOR_TRANSPORTISTA Then
                Dim mDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA As SISPACAL.WebUC.ddlPLANILLA
                mDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA = e.Row.FindControl("DdlPLANILLACODIPROVEEDOR_TRANSPORTISTA1")
            Dim mLabelID_CATORCENA As Label
            mLabelID_CATORCENA = e.Row.FindControl("Label_ID_CATORCENA1")
            Dim mLabelID_TIPO_PLANILLA As Label
            mLabelID_TIPO_PLANILLA = e.Row.FindControl("Label_ID_TIPO_PLANILLA1")
                If lDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA Is Nothing Then
                    lDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA = New SISPACAL.WebUC.ddlPLANILLA
                    lDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA.Recuperar(CInt(mLabelID_CATORCENA.Text), CInt(mLabelID_TIPO_PLANILLA.Text))
                End If
                Dim mPLANILLACODIPROVEEDOR_TRANSPORTISTA As String
                mPLANILLACODIPROVEEDOR_TRANSPORTISTA = CType(e.Row.FindControl("Label_CODIPROVEEDOR_TRANSPORTISTA1"), Label).Text
                Dim lItem As ListItem = lDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA.Items.FindByValue(mPLANILLACODIPROVEEDOR_TRANSPORTISTA)
                If mPLANILLACODIPROVEEDOR_TRANSPORTISTA <> "" And Not lItem Is Nothing Then
                    mDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlPLANILLACODIPROVEEDOR_TRANSPORTISTA.SelectedValue = mPLANILLACODIPROVEEDOR_TRANSPORTISTA
                End If
            End If
            If Me.VerID_TIPO_PLANILLA Then
                Dim mDdlTIPO_PLANILLAID_TIPO_PLANILLA As SISPACAL.WebUC.ddlTIPO_PLANILLA
                mDdlTIPO_PLANILLAID_TIPO_PLANILLA = e.Row.FindControl("DdlTIPO_PLANILLAID_TIPO_PLANILLA1")
                If lDdlTIPO_PLANILLAID_TIPO_PLANILLA Is Nothing Then
                    lDdlTIPO_PLANILLAID_TIPO_PLANILLA = New SISPACAL.WebUC.ddlTIPO_PLANILLA
                    lDdlTIPO_PLANILLAID_TIPO_PLANILLA.Recuperar()
                End If
                Dim mTIPO_PLANILLAID_TIPO_PLANILLA As String
                mTIPO_PLANILLAID_TIPO_PLANILLA = CType(e.Row.FindControl("Label_ID_TIPO_PLANILLA1"), Label).Text
                Dim lItem As ListItem = lDdlTIPO_PLANILLAID_TIPO_PLANILLA.Items.FindByValue(mTIPO_PLANILLAID_TIPO_PLANILLA)
                If mTIPO_PLANILLAID_TIPO_PLANILLA <> "" And Not lItem Is Nothing Then
                    mDdlTIPO_PLANILLAID_TIPO_PLANILLA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue = mTIPO_PLANILLAID_TIPO_PLANILLA
                End If
            End If
            If Me.VerID_TIPO_DESCTO Then
                Dim mDdlTIPO_DESCUENTOID_TIPO_DESCTO As SISPACAL.WebUC.ddlTIPO_DESCUENTO
                mDdlTIPO_DESCUENTOID_TIPO_DESCTO = e.Row.FindControl("DdlTIPO_DESCUENTOID_TIPO_DESCTO1")
                If lDdlTIPO_DESCUENTOID_TIPO_DESCTO Is Nothing Then
                    lDdlTIPO_DESCUENTOID_TIPO_DESCTO = New SISPACAL.WebUC.ddlTIPO_DESCUENTO
                    lDdlTIPO_DESCUENTOID_TIPO_DESCTO.Recuperar()
                End If
                Dim mTIPO_DESCUENTOID_TIPO_DESCTO As String
                mTIPO_DESCUENTOID_TIPO_DESCTO = CType(e.Row.FindControl("Label_ID_TIPO_DESCTO1"), Label).Text
                Dim lItem As ListItem = lDdlTIPO_DESCUENTOID_TIPO_DESCTO.Items.FindByValue(mTIPO_DESCUENTOID_TIPO_DESCTO)
                If mTIPO_DESCUENTOID_TIPO_DESCTO <> "" And Not lItem Is Nothing Then
                    mDdlTIPO_DESCUENTOID_TIPO_DESCTO.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlTIPO_DESCUENTOID_TIPO_DESCTO.SelectedValue = mTIPO_DESCUENTOID_TIPO_DESCTO
                End If
            End If
            If Me.VerID_APLICACION_DESCTO Then
                Dim mDdlAPLICACION_DESCTOID_APLICACION_DESCTO As SISPACAL.WebUC.ddlAPLICACION_DESCTO
                mDdlAPLICACION_DESCTOID_APLICACION_DESCTO = e.Row.FindControl("DdlAPLICACION_DESCTOID_APLICACION_DESCTO1")
                If lDdlAPLICACION_DESCTOID_APLICACION_DESCTO Is Nothing Then
                    lDdlAPLICACION_DESCTOID_APLICACION_DESCTO = New SISPACAL.WebUC.ddlAPLICACION_DESCTO
                    lDdlAPLICACION_DESCTOID_APLICACION_DESCTO.Recuperar()
                End If
                Dim mAPLICACION_DESCTOID_APLICACION_DESCTO As String
                mAPLICACION_DESCTOID_APLICACION_DESCTO = CType(e.Row.FindControl("Label_ID_APLICACION_DESCTO1"), Label).Text
                Dim lItem As ListItem = lDdlAPLICACION_DESCTOID_APLICACION_DESCTO.Items.FindByValue(mAPLICACION_DESCTOID_APLICACION_DESCTO)
                If mAPLICACION_DESCTOID_APLICACION_DESCTO <> "" And Not lItem Is Nothing Then
                    mDdlAPLICACION_DESCTOID_APLICACION_DESCTO.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlAPLICACION_DESCTOID_APLICACION_DESCTO.SelectedValue = mAPLICACION_DESCTOID_APLICACION_DESCTO
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
        If Me.mComponente.EliminarDESCUENTOS_PLANILLA(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorCATORCENA_ZAFRA") Then
            Me.CargarDatosPorCATORCENA_ZAFRA(Me.ViewState("ID_CATORCENA"))
            Return
        End If
        If Me.ViewState("PorPLANILLA") Then
            Me.CargarDatosPorPLANILLA(Me.ViewState("ID_CATORCENA"), Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA"), Me.ViewState("ID_TIPO_PLANILLA"))
            Return
        End If
        If Me.ViewState("PorTIPO_PLANILLA") Then
            Me.CargarDatosPorTIPO_PLANILLA(Me.ViewState("ID_TIPO_PLANILLA"))
            Return
        End If
        If Me.ViewState("PorTIPO_DESCUENTO") Then
            Me.CargarDatosPorTIPO_DESCUENTO(Me.ViewState("ID_TIPO_DESCTO"))
            Return
        End If
        If Me.ViewState("PorAPLICACION_DESCTO") Then
            Me.CargarDatosPorAPLICACION_DESCTO(Me.ViewState("ID_APLICACION_DESCTO"))
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
        If Me.ViewState("PorCATORCENA_ZAFRA") Then
            Me.CargarDatosPorCATORCENA_ZAFRA(Me.ViewState("ID_CATORCENA"))
            Return
        End If
        If Me.ViewState("PorPLANILLA") Then
            Me.CargarDatosPorPLANILLA(Me.ViewState("ID_CATORCENA"), Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA"), Me.ViewState("ID_TIPO_PLANILLA"))
            Return
        End If
        If Me.ViewState("PorTIPO_PLANILLA") Then
            Me.CargarDatosPorTIPO_PLANILLA(Me.ViewState("ID_TIPO_PLANILLA"))
            Return
        End If
        If Me.ViewState("PorTIPO_DESCUENTO") Then
            Me.CargarDatosPorTIPO_DESCUENTO(Me.ViewState("ID_TIPO_DESCTO"))
            Return
        End If
        If Me.ViewState("PorAPLICACION_DESCTO") Then
            Me.CargarDatosPorAPLICACION_DESCTO(Me.ViewState("ID_APLICACION_DESCTO"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaDESCUENTOS_PLANILLA
        Dim mLista As New ListaDESCUENTOS_PLANILLA
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New DESCUENTOS_PLANILLA
                mEntidad.ID_DESCUENTO_PLANILLA = CInt(CType(mRow.FindControl("Label_ID_DESCUENTO_PLANILLA"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
