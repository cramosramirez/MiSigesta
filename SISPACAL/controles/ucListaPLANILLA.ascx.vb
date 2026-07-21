Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPLANILLA
    Inherits ucBase
 
    Private mComponente As New cPLANILLA
    Public Event Seleccionado(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32) 
    Public Event Editando(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32) 

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

    Private _ID_CATORCENA As Int32
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value 
            If Not Me.ViewState("ID_CATORCENA") Is Nothing Then Me.ViewState.Remove("ID_CATORCENA")
            Me.ViewState.Add("ID_CATORCENA", Value)
        End Set
    End Property

    Private _ID_TIPO_PLANILLA As Int32
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLA = Value 
            If Not Me.ViewState("ID_TIPO_PLANILLA") Is Nothing Then Me.ViewState.Remove("ID_TIPO_PLANILLA")
            Me.ViewState.Add("ID_TIPO_PLANILLA", Value)
        End Set
    End Property

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR_TRANSPORTISTA() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_PLANILLA() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_ZAFRA() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEE() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerCODISOCIO() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerCANT_RECIBOS() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerTONEL_CANA_ENTREGADA() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerAZUCAR_CATORCENA_REAL() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerVALOR() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerIVA() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerVALOR_BRUTO() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerRENTA() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property VerRETENCION_IVA() As Boolean
        Get
            Return Me.gvLista.Columns(13).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(13).Visible = Value
        End Set
    End Property

    Public Property VerRoza() As Boolean
        Get
            Return Me.gvLista.Columns(14).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(14).Visible = Value
        End Set
    End Property

    Public Property VerCarga() As Boolean
        Get
            Return Me.gvLista.Columns(15).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(15).Visible = Value
        End Set
    End Property

    Public Property VerDESC_FLETE() As Boolean
        Get
            Return Me.gvLista.Columns(16).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(16).Visible = Value
        End Set
    End Property

    Public Property VerDescAdicionales() As Boolean
        Get
            Return Me.gvLista.Columns(17).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(17).Visible = Value
        End Set
    End Property

    Public Property VerDESC_CARGA() As Boolean
        Get
            Return Me.gvLista.Columns(18).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(18).Visible = Value
        End Set
    End Property

    Public Property VerDESC_CARGA_CONTRA() As Boolean
        Get
            Return Me.gvLista.Columns(19).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(19).Visible = Value
        End Set
    End Property

    Public Property VerDESC_BANCOS() As Boolean
        Get
            Return Me.gvLista.Columns(20).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(20).Visible = Value
        End Set
    End Property

    Public Property VerDESC_COMBUSTIBLE() As Boolean
        Get
            Return Me.gvLista.Columns(21).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(21).Visible = Value
        End Set
    End Property

    Public Property VerDESC_ANTICIPO() As Boolean
        Get
            Return Me.gvLista.Columns(22).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(22).Visible = Value
        End Set
    End Property

    Public Property VerDESC_INTERES() As Boolean
        Get
            Return Me.gvLista.Columns(23).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(23).Visible = Value
        End Set
    End Property

    Public Property VerDESC_AGROQUIMICO() As Boolean
        Get
            Return Me.gvLista.Columns(24).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(24).Visible = Value
        End Set
    End Property

    Public Property VerDESC_SEGURO() As Boolean
        Get
            Return Me.gvLista.Columns(25).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(25).Visible = Value
        End Set
    End Property

    Public Property VerDESC_RESPUESTOS() As Boolean
        Get
            Return Me.gvLista.Columns(26).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(26).Visible = Value
        End Set
    End Property

    Public Property VerDESC_OTROS() As Boolean
        Get
            Return Me.gvLista.Columns(27).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(27).Visible = Value
        End Set
    End Property

    Public Property VerPAGO_NETO() As Boolean
        Get
            Return Me.gvLista.Columns(28).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(28).Visible = Value
        End Set
    End Property

    Public Property VerES_CONTRIBUYENTE() As Boolean
        Get
            Return Me.gvLista.Columns(29).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(29).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(30).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(30).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(31).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(31).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(32).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(32).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(33).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(33).Visible = Value
        End Set
    End Property

    Public Property VerDESC_SERVICIO_ROZA() As Boolean
        Get
            Return Me.gvLista.Columns(34).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(34).Visible = Value
        End Set
    End Property

    Public Property VerDESC_ROZA_SIN_TRIPULACION() As Boolean
        Get
            Return Me.gvLista.Columns(35).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(35).Visible = Value
        End Set
    End Property

    Public Property VerDESC_ROZA_CON_TRIPULACION() As Boolean
        Get
            Return Me.gvLista.Columns(36).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(36).Visible = Value
        End Set
    End Property

    Public Property HeaderID_CATORCENA() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_PLANILLA() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_ZAFRA() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEE() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODISOCIO() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRES() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAPELLIDOS() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCANT_RECIBOS() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTONEL_CANA_ENTREGADA() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAZUCAR_CATORCENA_REAL() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderVALOR() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

    Public Property HeaderIVA() As String
        Get
            Return Me.gvLista.Columns(13).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(13).HeaderText = Value
        End Set
    End Property

    Public Property HeaderVALOR_BRUTO() As String
        Get
            Return Me.gvLista.Columns(14).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(14).HeaderText = Value
        End Set
    End Property

    Public Property HeaderRENTA() As String
        Get
            Return Me.gvLista.Columns(15).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(15).HeaderText = Value
        End Set
    End Property

    Public Property HeaderRETENCION_IVA() As String
        Get
            Return Me.gvLista.Columns(16).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(16).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_FLETE() As String
        Get
            Return Me.gvLista.Columns(17).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(17).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_CARGA() As String
        Get
            Return Me.gvLista.Columns(18).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(18).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_CARGA_CONTRA() As String
        Get
            Return Me.gvLista.Columns(19).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(19).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_BANCOS() As String
        Get
            Return Me.gvLista.Columns(20).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(20).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_COMBUSTIBLE() As String
        Get
            Return Me.gvLista.Columns(21).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(21).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_ANTICIPO() As String
        Get
            Return Me.gvLista.Columns(22).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(22).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_INTERES() As String
        Get
            Return Me.gvLista.Columns(23).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(23).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_AGROQUIMICO() As String
        Get
            Return Me.gvLista.Columns(24).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(24).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_SEGURO() As String
        Get
            Return Me.gvLista.Columns(25).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(25).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_RESPUESTOS() As String
        Get
            Return Me.gvLista.Columns(26).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(26).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_OTROS() As String
        Get
            Return Me.gvLista.Columns(27).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(27).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPAGO_NETO() As String
        Get
            Return Me.gvLista.Columns(28).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(28).HeaderText = Value
        End Set
    End Property

    Public Property HeaderES_CONTRIBUYENTE() As String
        Get
            Return Me.gvLista.Columns(29).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(29).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.gvLista.Columns(30).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(30).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.gvLista.Columns(31).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(31).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.gvLista.Columns(32).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(32).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.gvLista.Columns(33).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(33).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_SERVICIO_ROZA() As String
        Get
            Return Me.gvLista.Columns(34).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(34).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_ROZA_SIN_TRIPULACION() As String
        Get
            Return Me.gvLista.Columns(35).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(35).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDESC_ROZA_CON_TRIPULACION() As String
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLANILLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lPLANILLA As ListaPLANILLA
        lPLANILLA = Me.mComponente.ObtenerLista(ID_CATORCENA, ID_TIPO_PLANILLA)
        If lPLANILLA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lPLANILLA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLANILLA
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
        Dim lPLANILLA As ListaPLANILLA
        lPLANILLA = Me.mComponente.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA)
        If lPLANILLA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCATORCENA_ZAFRA") = True
        Me.ViewState("ID_CATORCENA") = ID_CATORCENA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lPLANILLA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLANILLA
    ''' filtrado por la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCRITERIOS(ByVal ID_CATORCENA As Integer, _
                                            ByVal ID_TIPO_PLANILLA As Integer, _
                                            ByVal CODIPROVEEDOR_TRANSPORTISTA As String, _
                                            ByVal NOMBRE_PROVEE_TRANS As String, _
                                            ByVal ES_CONTRIBUYENTE As Boolean, _
                                            Optional ByVal asColumnaOrden As String = "NOMBRE_PROVEE_TRANS", _
                                            Optional ByVal asTipoOrden As String = "ASC") As Integer
        Dim lPLANILLA As listaPLANILLA
        lPLANILLA = Me.mComponente.ObtenerListaPorCRITERIOS(ID_CATORCENA, ID_TIPO_PLANILLA, CODIPROVEEDOR_TRANSPORTISTA, NOMBRE_PROVEE_TRANS, ES_CONTRIBUYENTE, asColumnaOrden, asTipoOrden)
        If lPLANILLA Is Nothing Then
            'Me.gvLista.Visible = False
            'Return -1
        End If
        Me.ViewState("PorCRITERIOS") = True
        Me.ViewState("ID_CATORCENA") = ID_CATORCENA
        Me.ViewState("ID_TIPO_PLANILLA") = ID_TIPO_PLANILLA
        Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA") = CODIPROVEEDOR_TRANSPORTISTA
        Me.ViewState("NOMBRE_PROVEE_TRANS") = NOMBRE_PROVEE_TRANS
        Me.ViewState("ES_CONTRIBUYENTE") = ES_CONTRIBUYENTE
        Me.ViewState("asColumnaOrden") = asColumnaOrden
        Me.ViewState("asTipoOrden") = asTipoOrden
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lPLANILLA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLANILLA
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
        Dim lPLANILLA As ListaPLANILLA
        lPLANILLA = Me.mComponente.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA)
        If lPLANILLA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorTIPO_PLANILLA") = True
        Me.ViewState("ID_TIPO_PLANILLA") = ID_TIPO_PLANILLA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lPLANILLA
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
        If Not Me.ViewState("ID_CATORCENA") Is Nothing Then Me._ID_CATORCENA = Me.ViewState("ID_CATORCENA")
        If Not Me.ViewState("ID_TIPO_PLANILLA") Is Nothing Then Me._ID_TIPO_PLANILLA = Me.ViewState("ID_TIPO_PLANILLA")
    End Sub


    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(ID_CATORCENA, e.CommandArgument, ID_TIPO_PLANILLA)
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
            Dim mLabelCODIPROVEEDOR_TRANSPORTISTA As Label
            mLabelCODIPROVEEDOR_TRANSPORTISTA = e.Row.FindControl("Label_CODIPROVEEDOR_TRANSPORTISTA")
            mLabelCODIPROVEEDOR_TRANSPORTISTA.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.PermitirSeleccionar Then
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton_Seleccionar"), LinkButton)
                a.Text = Me.TextoSeleccionar
                a.CommandName = Me.ComandoSeleccionar
                If a.CommandName = "Check" Then
                    CType(e.Row.FindControl("CheckBox_Seleccionar"), CheckBox).Visible = True
                    a.Visible = False
                End If
            End If

            Dim lPlanilla As PLANILLA = CType(e.Row.DataItem, PLANILLA)
            Dim lblTOTAL_DESC_ROZA As Label = CType(e.Row.FindControl("lblTOTAL_DESC_ROZA"), Label)
            Dim lblTOTAL_DESC_CARGA As Label = CType(e.Row.FindControl("lblTOTAL_DESC_CARGA"), Label)
            Dim lblTOTAL_DESC_ADICIONALES As Label = CType(e.Row.FindControl("lblTOTAL_DESC_ADICIONALES"), Label)

            If lblTOTAL_DESC_ROZA IsNot Nothing Then lblTOTAL_DESC_ROZA.Text = (lPlanilla.DESC_SERVICIO_ROZA).ToString("n2")
            If lblTOTAL_DESC_CARGA IsNot Nothing Then lblTOTAL_DESC_CARGA.Text = (lPlanilla.DESC_CARGA + lPlanilla.DESC_CARGA_CONTRA).ToString("n2")
            If lblTOTAL_DESC_ADICIONALES IsNot Nothing Then lblTOTAL_DESC_ADICIONALES.Text = (lPlanilla.DESC_BANCOS + lPlanilla.DESC_COMBUSTIBLE + lPlanilla.DESC_ANTICIPO + _
                    lPlanilla.DESC_INTERES + lPlanilla.DESC_AGROQUIMICO + lPlanilla.DESC_SEGURO + lPlanilla.DESC_RESPUESTOS + lPlanilla.DESC_OTROS).ToString("n2")
        End If
    End Sub
 
    Private Sub gvLista_RowDeleting(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLista.RowDeleting
        If Me.mComponente.EliminarPLANILLA(ID_CATORCENA, ID_TIPO_PLANILLA, CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorCATORCENA_ZAFRA") Then
            Me.CargarDatosPorCATORCENA_ZAFRA(Me.ViewState("ID_CATORCENA"))
            Return
        End If
        If Me.ViewState("PorTIPO_PLANILLA") Then
            Me.CargarDatosPorTIPO_PLANILLA(Me.ViewState("ID_TIPO_PLANILLA"))
            Return
        End If
            If Me.CargarDatos() <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        End If
    End Sub
 
    Private Sub gvLista_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvLista.SelectedIndexChanging
        RaiseEvent Seleccionado(ID_CATORCENA, ID_TIPO_PLANILLA, CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip)
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        If Me.ViewState("PorCATORCENA_ZAFRA") Then
            Me.CargarDatosPorCATORCENA_ZAFRA(Me.ViewState("ID_CATORCENA"))
            Return
        End If
        If Me.ViewState("PorTIPO_PLANILLA") Then
            Me.CargarDatosPorTIPO_PLANILLA(Me.ViewState("ID_TIPO_PLANILLA"))
            Return
        End If
        If Me.ViewState("PorCRITERIOS") Then
            Me.CargarDatosPorCRITERIOS(Me.ViewState("ID_CATORCENA"), Me.ViewState("ID_TIPO_PLANILLA"), Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA"), Me.ViewState("NOMBRE_PROVEEDOR_TRANSPORTISTA"), Me.ViewState("ES_CONTRIBUYENTE"), Me.ViewState("asColumnaOrden"), Me.ViewState("asTipoOrden"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaPLANILLA
        Dim mLista As New ListaPLANILLA
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New PLANILLA
                mEntidad.ID_CATORCENA = Me.ID_CATORCENA
                mEntidad.CODIPROVEEDOR_TRANSPORTISTA = CInt(CType(mRow.FindControl("Label_CODIPROVEEDOR_TRANSPORTISTA"), Label).Text)
                mEntidad.ID_TIPO_PLANILLA = Me.ID_TIPO_PLANILLA
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
