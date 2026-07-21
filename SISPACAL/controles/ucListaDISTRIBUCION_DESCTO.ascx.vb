Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaDISTRIBUCION_DESCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla DISTRIBUCION_DESCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaDISTRIBUCION_DESCTO
    Inherits ucBase
 
    Private mComponente As New cDISTRIBUCION_DESCTO
    Public Event Seleccionado(ByVal ID_DISTRIB_DESCTO As Int32) 
    Public Event Editando(ByVal ID_DISTRIB_DESCTO As Int32) 

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

    Public Property VerID_DISTRIB_DESCTO() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerID_DESCUENTO_PLANILLA() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerMONTO_DESCUENTO() As Boolean
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

    Public Property HeaderID_DISTRIB_DESCTO() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODICONTRATO() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_DESCUENTO_PLANILLA() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderMONTO_DESCUENTO() As String
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DISTRIBUCION_DESCTO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lDISTRIBUCION_DESCTO As ListaDISTRIBUCION_DESCTO
        lDISTRIBUCION_DESCTO = Me.mComponente.ObtenerLista()
        If lDISTRIBUCION_DESCTO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDISTRIBUCION_DESCTO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DISTRIBUCION_DESCTO
    ''' filtrado por la tabla CONTRATO
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO(ByVal CODICONTRATO As String) As Integer
        Dim lDISTRIBUCION_DESCTO As ListaDISTRIBUCION_DESCTO
        lDISTRIBUCION_DESCTO = Me.mComponente.ObtenerListaPorCONTRATO(CODICONTRATO)
        If lDISTRIBUCION_DESCTO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCONTRATO") = True
        Me.ViewState("CODICONTRATO") = CODICONTRATO
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDISTRIBUCION_DESCTO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DISTRIBUCION_DESCTO
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLOTES(ByVal ACCESLOTE As String) As Integer
        Dim lDISTRIBUCION_DESCTO As ListaDISTRIBUCION_DESCTO
        lDISTRIBUCION_DESCTO = Me.mComponente.ObtenerListaPorLOTES(ACCESLOTE)
        If lDISTRIBUCION_DESCTO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorLOTES") = True
        Me.ViewState("ACCESLOTE") = ACCESLOTE
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDISTRIBUCION_DESCTO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DISTRIBUCION_DESCTO
    ''' filtrado por la tabla DESCUENTOS_PLANILLA
    ''' </summary>
    ''' <param name="ID_DESCUENTO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDESCUENTOS_PLANILLA(ByVal ID_DESCUENTO_PLANILLA As Int32) As Integer
        Dim lDISTRIBUCION_DESCTO As ListaDISTRIBUCION_DESCTO
        lDISTRIBUCION_DESCTO = Me.mComponente.ObtenerListaPorDESCUENTOS_PLANILLA(ID_DESCUENTO_PLANILLA)
        If lDISTRIBUCION_DESCTO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorDESCUENTOS_PLANILLA") = True
        Me.ViewState("ID_DESCUENTO_PLANILLA") = ID_DESCUENTO_PLANILLA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lDISTRIBUCION_DESCTO
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

    Private lDdlCONTRATOCODICONTRATO As SISPACAL.WebUC.ddlCONTRATO
    Private lDdlLOTESACCESLOTE As SISPACAL.WebUC.ddlLOTES
    Private lDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA As SISPACAL.WebUC.ddlDESCUENTOS_PLANILLA

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
            Dim mLabelID_DISTRIB_DESCTO As Label
            mLabelID_DISTRIB_DESCTO = e.Row.FindControl("Label_ID_DISTRIB_DESCTO")
            mLabelID_DISTRIB_DESCTO.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerCODICONTRATO Then
                Dim mDdlCONTRATOCODICONTRATO As SISPACAL.WebUC.ddlCONTRATO
                mDdlCONTRATOCODICONTRATO = e.Row.FindControl("DdlCONTRATOCODICONTRATO1")
                If lDdlCONTRATOCODICONTRATO Is Nothing Then
                    lDdlCONTRATOCODICONTRATO = New SISPACAL.WebUC.ddlCONTRATO
                    lDdlCONTRATOCODICONTRATO.Recuperar()
                End If
                Dim mCONTRATOCODICONTRATO As String
                mCONTRATOCODICONTRATO = CType(e.Row.FindControl("Label_CODICONTRATO1"), Label).Text
                Dim lItem As ListItem = lDdlCONTRATOCODICONTRATO.Items.FindByValue(mCONTRATOCODICONTRATO)
                If mCONTRATOCODICONTRATO <> "" And Not lItem Is Nothing Then
                    mDdlCONTRATOCODICONTRATO.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlCONTRATOCODICONTRATO.SelectedValue = mCONTRATOCODICONTRATO
                End If
            End If
            If Me.VerACCESLOTE Then
                Dim mDdlLOTESACCESLOTE As SISPACAL.WebUC.ddlLOTES
                mDdlLOTESACCESLOTE = e.Row.FindControl("DdlLOTESACCESLOTE1")
                If lDdlLOTESACCESLOTE Is Nothing Then
                    lDdlLOTESACCESLOTE = New SISPACAL.WebUC.ddlLOTES
                    lDdlLOTESACCESLOTE.Recuperar()
                End If
                Dim mLOTESACCESLOTE As String
                mLOTESACCESLOTE = CType(e.Row.FindControl("Label_ACCESLOTE1"), Label).Text
                Dim lItem As ListItem = lDdlLOTESACCESLOTE.Items.FindByValue(mLOTESACCESLOTE)
                If mLOTESACCESLOTE <> "" And Not lItem Is Nothing Then
                    mDdlLOTESACCESLOTE.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlLOTESACCESLOTE.SelectedValue = mLOTESACCESLOTE
                End If
            End If
            If Me.VerID_DESCUENTO_PLANILLA Then
                Dim mDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA As SISPACAL.WebUC.ddlDESCUENTOS_PLANILLA
                mDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA = e.Row.FindControl("DdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA1")
                If lDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA Is Nothing Then
                    lDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA = New SISPACAL.WebUC.ddlDESCUENTOS_PLANILLA
                    lDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA.Recuperar()
                End If
                Dim mDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA As String
                mDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA = CType(e.Row.FindControl("Label_ID_DESCUENTO_PLANILLA1"), Label).Text
                Dim lItem As ListItem = lDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA.Items.FindByValue(mDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA)
                If mDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA <> "" And Not lItem Is Nothing Then
                    mDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA.SelectedValue = mDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA
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
        If Me.mComponente.EliminarDISTRIBUCION_DESCTO(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorCONTRATO") Then
            Me.CargarDatosPorCONTRATO(Me.ViewState("CODICONTRATO"))
            Return
        End If
        If Me.ViewState("PorLOTES") Then
            Me.CargarDatosPorLOTES(Me.ViewState("ACCESLOTE"))
            Return
        End If
        If Me.ViewState("PorDESCUENTOS_PLANILLA") Then
            Me.CargarDatosPorDESCUENTOS_PLANILLA(Me.ViewState("ID_DESCUENTO_PLANILLA"))
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
        If Me.ViewState("PorCONTRATO") Then
            Me.CargarDatosPorCONTRATO(Me.ViewState("CODICONTRATO"))
            Return
        End If
        If Me.ViewState("PorLOTES") Then
            Me.CargarDatosPorLOTES(Me.ViewState("ACCESLOTE"))
            Return
        End If
        If Me.ViewState("PorDESCUENTOS_PLANILLA") Then
            Me.CargarDatosPorDESCUENTOS_PLANILLA(Me.ViewState("ID_DESCUENTO_PLANILLA"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaDISTRIBUCION_DESCTO
        Dim mLista As New ListaDISTRIBUCION_DESCTO
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New DISTRIBUCION_DESCTO
                mEntidad.ID_DISTRIB_DESCTO = CInt(CType(mRow.FindControl("Label_ID_DISTRIB_DESCTO"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
