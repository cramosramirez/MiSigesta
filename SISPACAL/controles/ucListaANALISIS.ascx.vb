Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaANALISIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ANALISIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaANALISIS
    Inherits ucBase
 
    Private mComponente As New cANALISIS
    Public Event Seleccionado(ByVal ID_ANALISIS As Int32) 
    Public Event Editando(ByVal ID_ANALISIS As Int32) 

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

    Public Property VerID_ANALISIS() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_ENVIO() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerBAGAZO_BRUTO() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerBAGAZO_NETO() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerPOL() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerBRIX() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerFIBRA_CANA() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerHUMEDAD() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerPOL_JUGO() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerJUGO_CANA() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerPOL_CANA() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerPUREZA_JUGO() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property VerPUREZA_AZUCAR() As Boolean
        Get
            Return Me.gvLista.Columns(13).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(13).Visible = Value
        End Set
    End Property

    Public Property VerSJM() As Boolean
        Get
            Return Me.gvLista.Columns(14).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(14).Visible = Value
        End Set
    End Property

    Public Property VerRENDIA_CALC1() As Boolean
        Get
            Return Me.gvLista.Columns(15).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(15).Visible = Value
        End Set
    End Property

    Public Property VerRENDIA_CALC2() As Boolean
        Get
            Return Me.gvLista.Columns(16).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(16).Visible = Value
        End Set
    End Property

    Public Property VerRENDIA_REAL() As Boolean
        Get
            Return Me.gvLista.Columns(17).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(17).Visible = Value
        End Set
    End Property

    Public Property VerRENCATORCENA_REAL() As Boolean
        Get
            Return Me.gvLista.Columns(18).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(18).Visible = Value
        End Set
    End Property

    Public Property VerAZUCAR_CALC1() As Boolean
        Get
            Return Me.gvLista.Columns(19).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(19).Visible = Value
        End Set
    End Property

    Public Property VerAZUCAR_CALC2() As Boolean
        Get
            Return Me.gvLista.Columns(20).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(20).Visible = Value
        End Set
    End Property

    Public Property VerAZUCAR_REAL() As Boolean
        Get
            Return Me.gvLista.Columns(21).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(21).Visible = Value
        End Set
    End Property

    Public Property VerAZUCAR_CATORCENA_REAL() As Boolean
        Get
            Return Me.gvLista.Columns(22).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(22).Visible = Value
        End Set
    End Property

    Public Property VerPAGO_INI_CALC() As Boolean
        Get
            Return Me.gvLista.Columns(23).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(23).Visible = Value
        End Set
    End Property

    Public Property VerPAGO_INI_REAL() As Boolean
        Get
            Return Me.gvLista.Columns(24).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(24).Visible = Value
        End Set
    End Property

    Public Property VerPAGO_CATORCENA_REAL() As Boolean
        Get
            Return Me.gvLista.Columns(25).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(25).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_LEE_BAGAZO_BRUTO() As Boolean
        Get
            Return Me.gvLista.Columns(26).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(26).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_LEE_BAGAZO_BRUTO() As Boolean
        Get
            Return Me.gvLista.Columns(27).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(27).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_LEE_BAGAZO_TARA() As Boolean
        Get
            Return Me.gvLista.Columns(28).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(28).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_LEE_BAGAZO_TARA() As Boolean
        Get
            Return Me.gvLista.Columns(29).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(29).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_LEE_POL() As Boolean
        Get
            Return Me.gvLista.Columns(30).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(30).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_LEE_POL() As Boolean
        Get
            Return Me.gvLista.Columns(31).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(31).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_LEE_BRIX() As Boolean
        Get
            Return Me.gvLista.Columns(32).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(32).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_LEE_BRIX() As Boolean
        Get
            Return Me.gvLista.Columns(33).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(33).Visible = Value
        End Set
    End Property

    Public Property VerPOL_LECTURA() As Boolean
        Get
            Return Me.gvLista.Columns(34).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(34).Visible = Value
        End Set
    End Property

    Public Property VerPH() As Boolean
        Get
            Return Me.gvLista.Columns(35).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(35).Visible = Value
        End Set
    End Property

    Public Property VerAZUCAR_REDUCTORES() As Boolean
        Get
            Return Me.gvLista.Columns(36).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(36).Visible = Value
        End Set
    End Property

    Public Property HeaderID_ANALISIS() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ENVIO() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderBAGAZO_BRUTO() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderBAGAZO_NETO() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPOL() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderBRIX() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFIBRA_CANA() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderHUMEDAD() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPOL_JUGO() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderJUGO_CANA() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPOL_CANA() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPUREZA_JUGO() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPUREZA_AZUCAR() As String
        Get
            Return Me.gvLista.Columns(13).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(13).HeaderText = Value
        End Set
    End Property

    Public Property HeaderSJM() As String
        Get
            Return Me.gvLista.Columns(14).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(14).HeaderText = Value
        End Set
    End Property

    Public Property HeaderRENDIA_CALC1() As String
        Get
            Return Me.gvLista.Columns(15).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(15).HeaderText = Value
        End Set
    End Property

    Public Property HeaderRENDIA_CALC2() As String
        Get
            Return Me.gvLista.Columns(16).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(16).HeaderText = Value
        End Set
    End Property

    Public Property HeaderRENDIA_REAL() As String
        Get
            Return Me.gvLista.Columns(17).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(17).HeaderText = Value
        End Set
    End Property

    Public Property HeaderRENCATORCENA_REAL() As String
        Get
            Return Me.gvLista.Columns(18).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(18).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAZUCAR_CALC1() As String
        Get
            Return Me.gvLista.Columns(19).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(19).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAZUCAR_CALC2() As String
        Get
            Return Me.gvLista.Columns(20).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(20).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAZUCAR_REAL() As String
        Get
            Return Me.gvLista.Columns(21).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(21).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAZUCAR_CATORCENA_REAL() As String
        Get
            Return Me.gvLista.Columns(22).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(22).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPAGO_INI_CALC() As String
        Get
            Return Me.gvLista.Columns(23).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(23).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPAGO_INI_REAL() As String
        Get
            Return Me.gvLista.Columns(24).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(24).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPAGO_CATORCENA_REAL() As String
        Get
            Return Me.gvLista.Columns(25).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(25).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_LEE_BAGAZO_BRUTO() As String
        Get
            Return Me.gvLista.Columns(26).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(26).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_LEE_BAGAZO_BRUTO() As String
        Get
            Return Me.gvLista.Columns(27).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(27).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_LEE_BAGAZO_TARA() As String
        Get
            Return Me.gvLista.Columns(28).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(28).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_LEE_BAGAZO_TARA() As String
        Get
            Return Me.gvLista.Columns(29).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(29).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_LEE_POL() As String
        Get
            Return Me.gvLista.Columns(30).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(30).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_LEE_POL() As String
        Get
            Return Me.gvLista.Columns(31).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(31).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_LEE_BRIX() As String
        Get
            Return Me.gvLista.Columns(32).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(32).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_LEE_BRIX() As String
        Get
            Return Me.gvLista.Columns(33).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(33).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPOL_LECTURA() As String
        Get
            Return Me.gvLista.Columns(34).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(34).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPH() As String
        Get
            Return Me.gvLista.Columns(35).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(35).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAZUCAR_REDUCTORES() As String
        Get
            Return Me.gvLista.Columns(36).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(36).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ANALISIS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lANALISIS As ListaANALISIS
        lANALISIS = Me.mComponente.ObtenerLista()
        If lANALISIS is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lANALISIS
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ANALISIS
    ''' filtrado por la tabla ENVIO
    ''' </summary>
    ''' <param name="ID_ENVIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorENVIO(ByVal ID_ENVIO As Int32) As Integer
        Dim lANALISIS As ListaANALISIS
        lANALISIS = Me.mComponente.ObtenerListaPorENVIO(ID_ENVIO)
        If lANALISIS is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorENVIO") = True
        Me.ViewState("ID_ENVIO") = ID_ENVIO
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lANALISIS
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

    Private lDdlENVIOID_ENVIO As SISPACAL.WebUC.ddlENVIO

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
            Dim mLabelID_ANALISIS As Label
            mLabelID_ANALISIS = e.Row.FindControl("Label_ID_ANALISIS")
            mLabelID_ANALISIS.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_ENVIO Then
                Dim mDdlENVIOID_ENVIO As SISPACAL.WebUC.ddlENVIO
                mDdlENVIOID_ENVIO = e.Row.FindControl("DdlENVIOID_ENVIO1")
                If lDdlENVIOID_ENVIO Is Nothing Then
                    lDdlENVIOID_ENVIO = New SISPACAL.WebUC.ddlENVIO
                    lDdlENVIOID_ENVIO.Recuperar()
                End If
                Dim mENVIOID_ENVIO As String
                mENVIOID_ENVIO = CType(e.Row.FindControl("Label_ID_ENVIO1"), Label).Text
                Dim lItem As ListItem = lDdlENVIOID_ENVIO.Items.FindByValue(mENVIOID_ENVIO)
                If mENVIOID_ENVIO <> "" And Not lItem Is Nothing Then
                    mDdlENVIOID_ENVIO.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlENVIOID_ENVIO.SelectedValue = mENVIOID_ENVIO
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
        If Me.mComponente.EliminarANALISIS(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorENVIO") Then
            Me.CargarDatosPorENVIO(Me.ViewState("ID_ENVIO"))
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
        If Me.ViewState("PorENVIO") Then
            Me.CargarDatosPorENVIO(Me.ViewState("ID_ENVIO"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaANALISIS
        Dim mLista As New ListaANALISIS
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New ANALISIS
                mEntidad.ID_ANALISIS = CInt(CType(mRow.FindControl("Label_ID_ANALISIS"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
