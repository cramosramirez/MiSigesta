Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaORDEN_COMBUSTIBLE_AUTORIZACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/02/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaORDEN_COMBUSTIBLE_AUTORIZACION
    Inherits ucBase
 
    Private mComponente As New cORDEN_COMBUSTIBLE_AUTORIZACION
    Public Event Seleccionado(ByVal ID_ORDEN_COMBUS_AUTO As Int32) 
    Public Event Editando(ByVal ID_ORDEN_COMBUS_AUTO As Int32) 

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

    Public Property VerID_ORDEN_COMBUS_AUTO() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_PROVEEDOR() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerID_ORDEN_COMBUS() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerAUTORIZACION_APLICADA() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property HeaderID_ORDEN_COMBUS_AUTO() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_PROVEEDOR() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ORDEN_COMBUS() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAUTORIZACION_APLICADA() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lORDEN_COMBUSTIBLE_AUTORIZACION As ListaORDEN_COMBUSTIBLE_AUTORIZACION
        lORDEN_COMBUSTIBLE_AUTORIZACION = Me.mComponente.ObtenerLista()
        If lORDEN_COMBUSTIBLE_AUTORIZACION is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_COMBUSTIBLE_AUTORIZACION
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
    ''' filtrado por la tabla TIPO_PROVEEDOR
    ''' </summary>
    ''' <param name="ID_TIPO_PROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32) As Integer
        Dim lORDEN_COMBUSTIBLE_AUTORIZACION As ListaORDEN_COMBUSTIBLE_AUTORIZACION
        lORDEN_COMBUSTIBLE_AUTORIZACION = Me.mComponente.ObtenerListaPorTIPO_PROVEEDOR(ID_TIPO_PROVEEDOR)
        If lORDEN_COMBUSTIBLE_AUTORIZACION is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorTIPO_PROVEEDOR") = True
        Me.ViewState("ID_TIPO_PROVEEDOR") = ID_TIPO_PROVEEDOR
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_COMBUSTIBLE_AUTORIZACION
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
    ''' filtrado por la tabla ORDEN_COMBUSTIBLE
    ''' </summary>
    ''' <param name="ID_ORDEN_COMBUS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32) As Integer
        Dim lORDEN_COMBUSTIBLE_AUTORIZACION As ListaORDEN_COMBUSTIBLE_AUTORIZACION
        lORDEN_COMBUSTIBLE_AUTORIZACION = Me.mComponente.ObtenerListaPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)
        If lORDEN_COMBUSTIBLE_AUTORIZACION is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorORDEN_COMBUSTIBLE") = True
        Me.ViewState("ID_ORDEN_COMBUS") = ID_ORDEN_COMBUS
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lORDEN_COMBUSTIBLE_AUTORIZACION
        Me.gvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me._PermitirEliminar = Me.ViewState("PermitirEliminar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub

    Private lDdlTIPO_PROVEEDORID_TIPO_PROVEEDOR As SISPACAL.WebUC.ddlTIPO_PROVEEDOR
    Private lDdlORDEN_COMBUSTIBLEID_ORDEN_COMBUS As SISPACAL.WebUC.ddlORDEN_COMBUSTIBLE

    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(CInt(e.CommandArgument))
        End If
    End Sub

    Protected Sub gvLista_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLista.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If Me.PermitirEliminar Then 
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton1"), LinkButton)
                a.Attributes.Add("onclick", "if(!window.confirm('¿Esta seguro de Eliminar el Registro?')){return false;}")
            End If
            Dim lbDetalle As LinkButton 
            lbDetalle = e.Row.FindControl("LinkButtonDetalle") 
            Dim mLabelID_ORDEN_COMBUS_AUTO As Label
            mLabelID_ORDEN_COMBUS_AUTO = e.Row.FindControl("Label_ID_ORDEN_COMBUS_AUTO")
            mLabelID_ORDEN_COMBUS_AUTO.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
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

            Dim Label_NOMBRE_PROVEEDOR As Label
            Label_NOMBRE_PROVEEDOR = e.Row.FindControl("Label_NOMBRE_PROVEEDOR")
            If Label_NOMBRE_PROVEEDOR IsNot Nothing Then
                Dim lCodigo As Integer = Convert.ToInt32(e.Row.Cells(2).Text)
                Dim lTipoProveedor As Integer = Convert.ToInt32(CType(e.Row.FindControl("Label_ID_TIPO_PROVEEDOR1"), Label).Text)
                Select Case lTipoProveedor
                    Case Enumeradores.TipoProveedor.Cañero
                        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodigo)
                        If lProveedor IsNot Nothing Then Label_NOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
                    Case Enumeradores.TipoProveedor.Transportista
                        Dim lProveedor As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(lCodigo)
                        If lProveedor IsNot Nothing Then Label_NOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
                End Select
            End If

            If Me.VerID_ORDEN_COMBUS Then
                Dim Label_ID_ORDEN_COMBUS1 As Label
                Label_ID_ORDEN_COMBUS1 = e.Row.FindControl("Label_ID_ORDEN_COMBUS1")
                If Label_ID_ORDEN_COMBUS1 IsNot Nothing AndAlso Label_ID_ORDEN_COMBUS1.Text = "-1" Then
                    Label_ID_ORDEN_COMBUS1.Text = ""
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
        If Me.mComponente.EliminarORDEN_COMBUSTIBLE_AUTORIZACION(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorTIPO_PROVEEDOR") Then
            Me.CargarDatosPorTIPO_PROVEEDOR(Me.ViewState("ID_TIPO_PROVEEDOR"))
            Return
        End If
        If Me.ViewState("PorORDEN_COMBUSTIBLE") Then
            Me.CargarDatosPorORDEN_COMBUSTIBLE(Me.ViewState("ID_ORDEN_COMBUS"))
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
        If Me.ViewState("PorTIPO_PROVEEDOR") Then
            Me.CargarDatosPorTIPO_PROVEEDOR(Me.ViewState("ID_TIPO_PROVEEDOR"))
            Return
        End If
        If Me.ViewState("PorORDEN_COMBUSTIBLE") Then
            Me.CargarDatosPorORDEN_COMBUSTIBLE(Me.ViewState("ID_ORDEN_COMBUS"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaORDEN_COMBUSTIBLE_AUTORIZACION
        Dim mLista As New ListaORDEN_COMBUSTIBLE_AUTORIZACION
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New ORDEN_COMBUSTIBLE_AUTORIZACION
                mEntidad.ID_ORDEN_COMBUS_AUTO = CInt(CType(mRow.FindControl("Label_ID_ORDEN_COMBUS_AUTO"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
