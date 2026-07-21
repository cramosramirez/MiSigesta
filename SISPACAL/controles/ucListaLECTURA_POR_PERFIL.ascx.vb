Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaLECTURA_POR_PERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla LECTURA_POR_PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaLECTURA_POR_PERFIL
    Inherits ucBase
 
    Private mComponente As New cLECTURA_POR_PERFIL
    Public Event Seleccionado(ByVal ID_LECTURA_PERFIL As Int32) 
    Public Event Editando(ByVal ID_LECTURA_PERFIL As Int32) 

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

    Public Property VerID_LECTURA_PERFIL() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_PERFIL() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_LECTURA() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property HeaderID_LECTURA_PERFIL() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_PERFIL() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_LECTURA() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LECTURA_POR_PERFIL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lLECTURA_POR_PERFIL As ListaLECTURA_POR_PERFIL
        lLECTURA_POR_PERFIL = Me.mComponente.ObtenerLista()
        If lLECTURA_POR_PERFIL is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lLECTURA_POR_PERFIL
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LECTURA_POR_PERFIL
    ''' filtrado por la tabla PERFIL
    ''' </summary>
    ''' <param name="ID_PERFIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPERFIL(ByVal ID_PERFIL As Int32) As Integer
        Dim lLECTURA_POR_PERFIL As ListaLECTURA_POR_PERFIL
        lLECTURA_POR_PERFIL = Me.mComponente.ObtenerListaPorPERFIL(ID_PERFIL)
        If lLECTURA_POR_PERFIL is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPERFIL") = True
        Me.ViewState("ID_PERFIL") = ID_PERFIL
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lLECTURA_POR_PERFIL
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LECTURA_POR_PERFIL
    ''' filtrado por la tabla TIPO_LECTURA
    ''' </summary>
    ''' <param name="ID_TIPO_LECTURA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_LECTURA(ByVal ID_TIPO_LECTURA As Int32) As Integer
        Dim lLECTURA_POR_PERFIL As ListaLECTURA_POR_PERFIL
        lLECTURA_POR_PERFIL = Me.mComponente.ObtenerListaPorTIPO_LECTURA(ID_TIPO_LECTURA)
        If lLECTURA_POR_PERFIL is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorTIPO_LECTURA") = True
        Me.ViewState("ID_TIPO_LECTURA") = ID_TIPO_LECTURA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lLECTURA_POR_PERFIL
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

    Private lDdlPERFILID_PERFIL As SISPACAL.WebUC.ddlPERFIL
    Private lDdlTIPO_LECTURAID_TIPO_LECTURA As SISPACAL.WebUC.ddlTIPO_LECTURA

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
            Dim mLabelID_LECTURA_PERFIL As Label
            mLabelID_LECTURA_PERFIL = e.Row.FindControl("Label_ID_LECTURA_PERFIL")
            mLabelID_LECTURA_PERFIL.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_PERFIL Then
                Dim mDdlPERFILID_PERFIL As SISPACAL.WebUC.ddlPERFIL
                mDdlPERFILID_PERFIL = e.Row.FindControl("DdlPERFILID_PERFIL1")
                If lDdlPERFILID_PERFIL Is Nothing Then
                    lDdlPERFILID_PERFIL = New SISPACAL.WebUC.ddlPERFIL
                    lDdlPERFILID_PERFIL.Recuperar()
                End If
                Dim mPERFILID_PERFIL As String
                mPERFILID_PERFIL = CType(e.Row.FindControl("Label_ID_PERFIL1"), Label).Text
                Dim lItem As ListItem = lDdlPERFILID_PERFIL.Items.FindByValue(mPERFILID_PERFIL)
                If mPERFILID_PERFIL <> "" And Not lItem Is Nothing Then
                    mDdlPERFILID_PERFIL.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlPERFILID_PERFIL.SelectedValue = mPERFILID_PERFIL
                End If
            End If
            If Me.VerID_TIPO_LECTURA Then
                Dim mDdlTIPO_LECTURAID_TIPO_LECTURA As SISPACAL.WebUC.ddlTIPO_LECTURA
                mDdlTIPO_LECTURAID_TIPO_LECTURA = e.Row.FindControl("DdlTIPO_LECTURAID_TIPO_LECTURA1")
                If lDdlTIPO_LECTURAID_TIPO_LECTURA Is Nothing Then
                    lDdlTIPO_LECTURAID_TIPO_LECTURA = New SISPACAL.WebUC.ddlTIPO_LECTURA
                    lDdlTIPO_LECTURAID_TIPO_LECTURA.Recuperar()
                End If
                Dim mTIPO_LECTURAID_TIPO_LECTURA As String
                mTIPO_LECTURAID_TIPO_LECTURA = CType(e.Row.FindControl("Label_ID_TIPO_LECTURA1"), Label).Text
                Dim lItem As ListItem = lDdlTIPO_LECTURAID_TIPO_LECTURA.Items.FindByValue(mTIPO_LECTURAID_TIPO_LECTURA)
                If mTIPO_LECTURAID_TIPO_LECTURA <> "" And Not lItem Is Nothing Then
                    mDdlTIPO_LECTURAID_TIPO_LECTURA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlTIPO_LECTURAID_TIPO_LECTURA.SelectedValue = mTIPO_LECTURAID_TIPO_LECTURA
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
        If Me.mComponente.EliminarLECTURA_POR_PERFIL(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorPERFIL") Then
            Me.CargarDatosPorPERFIL(Me.ViewState("ID_PERFIL"))
            Return
        End If
        If Me.ViewState("PorTIPO_LECTURA") Then
            Me.CargarDatosPorTIPO_LECTURA(Me.ViewState("ID_TIPO_LECTURA"))
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
        If Me.ViewState("PorPERFIL") Then
            Me.CargarDatosPorPERFIL(Me.ViewState("ID_PERFIL"))
            Return
        End If
        If Me.ViewState("PorTIPO_LECTURA") Then
            Me.CargarDatosPorTIPO_LECTURA(Me.ViewState("ID_TIPO_LECTURA"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaLECTURA_POR_PERFIL
        Dim mLista As New ListaLECTURA_POR_PERFIL
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New LECTURA_POR_PERFIL
                mEntidad.ID_LECTURA_PERFIL = CInt(CType(mRow.FindControl("Label_ID_LECTURA_PERFIL"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
