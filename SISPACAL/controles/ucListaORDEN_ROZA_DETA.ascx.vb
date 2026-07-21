Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaORDEN_ROZA_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ORDEN_ROZA_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaORDEN_ROZA_DETA
    Inherits ucBase
 
    Private mComponente As New cORDEN_ROZA_DETA
    Public Event Seleccionado(ByVal ID_ORDEN_DETA As Int32) 
    Public Event Editando(ByVal ID_ORDEN_DETA As Int32) 

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

    Public Property VerID_ORDEN_DETA() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_ORDEN() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_PLAN_ENTREGA_CANA() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property HeaderID_ORDEN_DETA() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ORDEN() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_PLAN_ENTREGA_CANA() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_ROZA_DETA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lORDEN_ROZA_DETA As ListaORDEN_ROZA_DETA
        lORDEN_ROZA_DETA = Me.mComponente.ObtenerLista()
        If lORDEN_ROZA_DETA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_ROZA_DETA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_ROZA_DETA
    ''' filtrado por la tabla ORDEN_ROZA_ENCA
    ''' </summary>
    ''' <param name="ID_ORDEN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorORDEN_ROZA_ENCA(ByVal ID_ORDEN As Int32) As Integer
        Dim lORDEN_ROZA_DETA As ListaORDEN_ROZA_DETA
        lORDEN_ROZA_DETA = Me.mComponente.ObtenerListaPorORDEN_ROZA_ENCA(ID_ORDEN)
        If lORDEN_ROZA_DETA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorORDEN_ROZA_ENCA") = True
        Me.ViewState("ID_ORDEN") = ID_ORDEN
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_ROZA_DETA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_ROZA_DETA
    ''' filtrado por la tabla PLAN_ENTREGA_CANA
    ''' </summary>
    ''' <param name="ID_PLAN_ENTREGA_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPLAN_ENTREGA_CANA(ByVal ID_PLAN_ENTREGA_CANA As Int32) As Integer
        Dim lORDEN_ROZA_DETA As ListaORDEN_ROZA_DETA
        lORDEN_ROZA_DETA = Me.mComponente.ObtenerListaPorPLAN_ENTREGA_CANA(ID_PLAN_ENTREGA_CANA)
        If lORDEN_ROZA_DETA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPLAN_ENTREGA_CANA") = True
        Me.ViewState("ID_PLAN_ENTREGA_CANA") = ID_PLAN_ENTREGA_CANA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_ROZA_DETA
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

    Private lDdlORDEN_ROZA_ENCAID_ORDEN As SISPACAL.WebUC.ddlORDEN_ROZA_ENCA
    Private lDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA As SISPACAL.WebUC.ddlPLAN_ENTREGA_CANA

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
            Dim mLabelID_ORDEN_DETA As Label
            mLabelID_ORDEN_DETA = e.Row.FindControl("Label_ID_ORDEN_DETA")
            mLabelID_ORDEN_DETA.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_ORDEN Then
                Dim mDdlORDEN_ROZA_ENCAID_ORDEN As SISPACAL.WebUC.ddlORDEN_ROZA_ENCA
                mDdlORDEN_ROZA_ENCAID_ORDEN = e.Row.FindControl("DdlORDEN_ROZA_ENCAID_ORDEN1")
                If lDdlORDEN_ROZA_ENCAID_ORDEN Is Nothing Then
                    lDdlORDEN_ROZA_ENCAID_ORDEN = New SISPACAL.WebUC.ddlORDEN_ROZA_ENCA
                    lDdlORDEN_ROZA_ENCAID_ORDEN.Recuperar()
                End If
                Dim mORDEN_ROZA_ENCAID_ORDEN As String
                mORDEN_ROZA_ENCAID_ORDEN = CType(e.Row.FindControl("Label_ID_ORDEN1"), Label).Text
                Dim lItem As ListItem = lDdlORDEN_ROZA_ENCAID_ORDEN.Items.FindByValue(mORDEN_ROZA_ENCAID_ORDEN)
                If mORDEN_ROZA_ENCAID_ORDEN <> "" And Not lItem Is Nothing Then
                    mDdlORDEN_ROZA_ENCAID_ORDEN.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlORDEN_ROZA_ENCAID_ORDEN.SelectedValue = mORDEN_ROZA_ENCAID_ORDEN
                End If
            End If
            If Me.VerID_PLAN_ENTREGA_CANA Then
                Dim mDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA As SISPACAL.WebUC.ddlPLAN_ENTREGA_CANA
                mDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA = e.Row.FindControl("DdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA1")
                If lDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA Is Nothing Then
                    lDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA = New SISPACAL.WebUC.ddlPLAN_ENTREGA_CANA
                    lDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.Recuperar()
                End If
                Dim mPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA As String
                mPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA = CType(e.Row.FindControl("Label_ID_PLAN_ENTREGA_CANA1"), Label).Text
                Dim lItem As ListItem = lDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.Items.FindByValue(mPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA)
                If mPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA <> "" And Not lItem Is Nothing Then
                    mDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.SelectedValue = mPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA
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
        If Me.mComponente.EliminarORDEN_ROZA_DETA(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorORDEN_ROZA_ENCA") Then
            Me.CargarDatosPorORDEN_ROZA_ENCA(Me.ViewState("ID_ORDEN"))
            Return
        End If
        If Me.ViewState("PorPLAN_ENTREGA_CANA") Then
            Me.CargarDatosPorPLAN_ENTREGA_CANA(Me.ViewState("ID_PLAN_ENTREGA_CANA"))
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
        If Me.ViewState("PorORDEN_ROZA_ENCA") Then
            Me.CargarDatosPorORDEN_ROZA_ENCA(Me.ViewState("ID_ORDEN"))
            Return
        End If
        If Me.ViewState("PorPLAN_ENTREGA_CANA") Then
            Me.CargarDatosPorPLAN_ENTREGA_CANA(Me.ViewState("ID_PLAN_ENTREGA_CANA"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaORDEN_ROZA_DETA
        Dim mLista As New ListaORDEN_ROZA_DETA
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New ORDEN_ROZA_DETA
                mEntidad.ID_ORDEN_DETA = CInt(CType(mRow.FindControl("Label_ID_ORDEN_DETA"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
