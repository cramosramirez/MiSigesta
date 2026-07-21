Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaENVIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ENVIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaENVIO
    Inherits ucBase
 
    Private mComponente As New cENVIO
    Public Event Seleccionado(ByVal ID_ENVIO As Int32) 
    Public Event Editando(ByVal ID_ENVIO As Int32) 

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

    Public Property VerID_ENVIO() As Boolean
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

    Public Property VerDIAZAFRA() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerCATORCENA() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerCOMPTENVIO() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerCODTRANSPORT() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES_MOTORISTA() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDOS_MOTORISTA() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_CANA() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property VerID_CARGADORA() As Boolean
        Get
            Return Me.gvLista.Columns(13).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(13).Visible = Value
        End Set
    End Property

    Public Property VerID_SUPERVISOR() As Boolean
        Get
            Return Me.gvLista.Columns(14).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(14).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_QUEMA() As Boolean
        Get
            Return Me.gvLista.Columns(15).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(15).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CORTA() As Boolean
        Get
            Return Me.gvLista.Columns(16).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(16).Visible = Value
        End Set
    End Property

    Public Property VerQUEMAPROG() As Boolean
        Get
            Return Me.gvLista.Columns(17).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(17).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CARGA() As Boolean
        Get
            Return Me.gvLista.Columns(18).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(18).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_PATIO() As Boolean
        Get
            Return Me.gvLista.Columns(19).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(19).Visible = Value
        End Set
    End Property

    Public Property VerNROBOLETA() As Boolean
        Get
            Return Me.gvLista.Columns(20).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(20).Visible = Value
        End Set
    End Property

    Public Property VerMADURANTE() As Boolean
        Get
            Return Me.gvLista.Columns(21).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(21).Visible = Value
        End Set
    End Property

    Public Property VerCERRADO() As Boolean
        Get
            Return Me.gvLista.Columns(22).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(22).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ENTRADA() As Boolean
        Get
            Return Me.gvLista.Columns(23).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(23).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(24).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(24).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(25).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(25).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(26).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(26).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(27).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(27).Visible = Value
        End Set
    End Property

    Public Property VerPLACAVEHIC() As Boolean
        Get
            Return Me.gvLista.Columns(28).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(28).Visible = Value
        End Set
    End Property

    Public Property VerID_TIPOTRANS() As Boolean
        Get
            Return Me.gvLista.Columns(29).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(29).Visible = Value
        End Set
    End Property

    Public Property VerSERVICIO_ROZA() As Boolean
        Get
            Return Me.gvLista.Columns(30).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(30).Visible = Value
        End Set
    End Property

    Public Property VerTRANSPORTE_PROPIO() As Boolean
        Get
            Return Me.gvLista.Columns(31).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(31).Visible = Value
        End Set
    End Property

    Public Property VerTIPO_SERV_ROZA() As Boolean
        Get
            Return Me.gvLista.Columns(32).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(32).Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_ROZA() As Boolean
        Get
            Return Me.gvLista.Columns(33).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(33).Visible = Value
        End Set
    End Property

    Public Property VerID_CARGADOR() As Boolean
        Get
            Return Me.gvLista.Columns(34).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(34).Visible = Value
        End Set
    End Property

    Public Property VerNUMRECIBO_CANA() As Boolean
        Get
            Return Me.gvLista.Columns(35).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(35).Visible = Value
        End Set
    End Property

    Public Property HeaderID_ENVIO() As String
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

    Public Property HeaderDIAZAFRA() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCATORCENA() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODICONTRATO() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEEDOR() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCOMPTENVIO() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODTRANSPORT() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRES_MOTORISTA() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAPELLIDOS_MOTORISTA() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_CANA() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_CARGADORA() As String
        Get
            Return Me.gvLista.Columns(13).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(13).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_SUPERVISOR() As String
        Get
            Return Me.gvLista.Columns(14).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(14).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_QUEMA() As String
        Get
            Return Me.gvLista.Columns(15).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(15).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CORTA() As String
        Get
            Return Me.gvLista.Columns(16).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(16).HeaderText = Value
        End Set
    End Property

    Public Property HeaderQUEMAPROG() As String
        Get
            Return Me.gvLista.Columns(17).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(17).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CARGA() As String
        Get
            Return Me.gvLista.Columns(18).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(18).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_PATIO() As String
        Get
            Return Me.gvLista.Columns(19).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(19).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNROBOLETA() As String
        Get
            Return Me.gvLista.Columns(20).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(20).HeaderText = Value
        End Set
    End Property

    Public Property HeaderMADURANTE() As String
        Get
            Return Me.gvLista.Columns(21).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(21).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCERRADO() As String
        Get
            Return Me.gvLista.Columns(22).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(22).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ENTRADA() As String
        Get
            Return Me.gvLista.Columns(23).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(23).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.gvLista.Columns(24).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(24).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.gvLista.Columns(25).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(25).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.gvLista.Columns(26).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(26).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.gvLista.Columns(27).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(27).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPLACAVEHIC() As String
        Get
            Return Me.gvLista.Columns(28).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(28).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TIPOTRANS() As String
        Get
            Return Me.gvLista.Columns(29).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(29).HeaderText = Value
        End Set
    End Property

    Public Property HeaderSERVICIO_ROZA() As String
        Get
            Return Me.gvLista.Columns(30).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(30).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTRANSPORTE_PROPIO() As String
        Get
            Return Me.gvLista.Columns(31).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(31).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIPO_SERV_ROZA() As String
        Get
            Return Me.gvLista.Columns(32).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(32).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_PROVEEDOR_ROZA() As String
        Get
            Return Me.gvLista.Columns(33).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(33).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_CARGADOR() As String
        Get
            Return Me.gvLista.Columns(34).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(34).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNUMRECIBO_CANA() As String
        Get
            Return Me.gvLista.Columns(35).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(35).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerLista()
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZAFRA(ByVal ID_ZAFRA As Int32) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorZAFRA(ID_ZAFRA)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorZAFRA") = True
        Me.ViewState("ID_ZAFRA") = ID_ZAFRA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla CONTRATO
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO(ByVal CODICONTRATO As String) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorCONTRATO(CODICONTRATO)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCONTRATO") = True
        Me.ViewState("CODICONTRATO") = CODICONTRATO
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla PROVEEDOR
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR(ByVal CODIPROVEEDOR As String) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPROVEEDOR") = True
        Me.ViewState("CODIPROVEEDOR") = CODIPROVEEDOR
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLOTES(ByVal ACCESLOTE As String) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorLOTES(ACCESLOTE)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorLOTES") = True
        Me.ViewState("ACCESLOTE") = ACCESLOTE
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla TRANSPORTISTA
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorTRANSPORTISTA(CODTRANSPORT)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorTRANSPORTISTA") = True
        Me.ViewState("CODTRANSPORT") = CODTRANSPORT
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla TIPO_CANA
    ''' </summary>
    ''' <param name="ID_TIPO_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_CANA(ByVal ID_TIPO_CANA As Int32) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorTIPO_CANA(ID_TIPO_CANA)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorTIPO_CANA") = True
        Me.ViewState("ID_TIPO_CANA") = ID_TIPO_CANA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla CARGADORA
    ''' </summary>
    ''' <param name="ID_CARGADORA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCARGADORA(ByVal ID_CARGADORA As Int32) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorCARGADORA(ID_CARGADORA)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCARGADORA") = True
        Me.ViewState("ID_CARGADORA") = ID_CARGADORA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla SUPERVISOR
    ''' </summary>
    ''' <param name="ID_SUPERVISOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSUPERVISOR(ByVal ID_SUPERVISOR As Int32) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorSUPERVISOR(ID_SUPERVISOR)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorSUPERVISOR") = True
        Me.ViewState("ID_SUPERVISOR") = ID_SUPERVISOR
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla PROVEEDOR_ROZA
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_ROZA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorPROVEEDOR_ROZA(ID_PROVEEDOR_ROZA)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPROVEEDOR_ROZA") = True
        Me.ViewState("ID_PROVEEDOR_ROZA") = ID_PROVEEDOR_ROZA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' filtrado por la tabla CARGADOR
    ''' </summary>
    ''' <param name="ID_CARGADOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCARGADOR(ByVal ID_CARGADOR As Int32) As Integer
        Dim lENVIO As ListaENVIO
        lENVIO = Me.mComponente.ObtenerListaPorCARGADOR(ID_CARGADOR)
        If lENVIO is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCARGADOR") = True
        Me.ViewState("ID_CARGADOR") = ID_CARGADOR
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lENVIO
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
    Private lDdlCONTRATOCODICONTRATO As SISPACAL.WebUC.ddlCONTRATO
    Private lDdlPROVEEDORCODIPROVEEDOR As SISPACAL.WebUC.ddlPROVEEDOR
    Private lDdlLOTESACCESLOTE As SISPACAL.WebUC.ddlLOTES
    Private lDdlTRANSPORTISTACODTRANSPORT As SISPACAL.WebUC.ddlTRANSPORTISTA
    Private lDdlTIPO_CANAID_TIPO_CANA As SISPACAL.WebUC.ddlTIPO_CANA
    Private lDdlCARGADORAID_CARGADORA As SISPACAL.WebUC.ddlCARGADORA
    Private lDdlSUPERVISORID_SUPERVISOR As SISPACAL.WebUC.ddlSUPERVISOR
    Private lDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA As SISPACAL.WebUC.ddlPROVEEDOR_ROZA
    Private lDdlCARGADORID_CARGADOR As SISPACAL.WebUC.ddlCARGADOR

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
            Dim mLabelID_ENVIO As Label
            mLabelID_ENVIO = e.Row.FindControl("Label_ID_ENVIO")
            mLabelID_ENVIO.Visible = Not Me.PermitirEditar
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
            If Me.VerCODIPROVEEDOR Then
                Dim mDdlPROVEEDORCODIPROVEEDOR As SISPACAL.WebUC.ddlPROVEEDOR
                mDdlPROVEEDORCODIPROVEEDOR = e.Row.FindControl("DdlPROVEEDORCODIPROVEEDOR1")
                If lDdlPROVEEDORCODIPROVEEDOR Is Nothing Then
                    lDdlPROVEEDORCODIPROVEEDOR = New SISPACAL.WebUC.ddlPROVEEDOR
                    lDdlPROVEEDORCODIPROVEEDOR.Recuperar()
                End If
                Dim mPROVEEDORCODIPROVEEDOR As String
                mPROVEEDORCODIPROVEEDOR = CType(e.Row.FindControl("Label_CODIPROVEEDOR1"), Label).Text
                Dim lItem As ListItem = lDdlPROVEEDORCODIPROVEEDOR.Items.FindByValue(mPROVEEDORCODIPROVEEDOR)
                If mPROVEEDORCODIPROVEEDOR <> "" And Not lItem Is Nothing Then
                    mDdlPROVEEDORCODIPROVEEDOR.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlPROVEEDORCODIPROVEEDOR.SelectedValue = mPROVEEDORCODIPROVEEDOR
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
            If Me.VerCODTRANSPORT Then
                Dim mDdlTRANSPORTISTACODTRANSPORT As SISPACAL.WebUC.ddlTRANSPORTISTA
                mDdlTRANSPORTISTACODTRANSPORT = e.Row.FindControl("DdlTRANSPORTISTACODTRANSPORT1")
                If lDdlTRANSPORTISTACODTRANSPORT Is Nothing Then
                    lDdlTRANSPORTISTACODTRANSPORT = New SISPACAL.WebUC.ddlTRANSPORTISTA
                    lDdlTRANSPORTISTACODTRANSPORT.Recuperar()
                End If
                Dim mTRANSPORTISTACODTRANSPORT As String
                mTRANSPORTISTACODTRANSPORT = CType(e.Row.FindControl("Label_CODTRANSPORT1"), Label).Text
                Dim lItem As ListItem = lDdlTRANSPORTISTACODTRANSPORT.Items.FindByValue(mTRANSPORTISTACODTRANSPORT)
                If mTRANSPORTISTACODTRANSPORT <> "" And Not lItem Is Nothing Then
                    mDdlTRANSPORTISTACODTRANSPORT.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlTRANSPORTISTACODTRANSPORT.SelectedValue = mTRANSPORTISTACODTRANSPORT
                End If
            End If
            If Me.VerID_TIPO_CANA Then
                Dim mDdlTIPO_CANAID_TIPO_CANA As SISPACAL.WebUC.ddlTIPO_CANA
                mDdlTIPO_CANAID_TIPO_CANA = e.Row.FindControl("DdlTIPO_CANAID_TIPO_CANA1")
                If lDdlTIPO_CANAID_TIPO_CANA Is Nothing Then
                    lDdlTIPO_CANAID_TIPO_CANA = New SISPACAL.WebUC.ddlTIPO_CANA
                    lDdlTIPO_CANAID_TIPO_CANA.Recuperar()
                End If
                Dim mTIPO_CANAID_TIPO_CANA As String
                mTIPO_CANAID_TIPO_CANA = CType(e.Row.FindControl("Label_ID_TIPO_CANA1"), Label).Text
                Dim lItem As ListItem = lDdlTIPO_CANAID_TIPO_CANA.Items.FindByValue(mTIPO_CANAID_TIPO_CANA)
                If mTIPO_CANAID_TIPO_CANA <> "" And Not lItem Is Nothing Then
                    mDdlTIPO_CANAID_TIPO_CANA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlTIPO_CANAID_TIPO_CANA.SelectedValue = mTIPO_CANAID_TIPO_CANA
                End If
            End If
            If Me.VerID_CARGADORA Then
                Dim mDdlCARGADORAID_CARGADORA As SISPACAL.WebUC.ddlCARGADORA
                mDdlCARGADORAID_CARGADORA = e.Row.FindControl("DdlCARGADORAID_CARGADORA1")
                If lDdlCARGADORAID_CARGADORA Is Nothing Then
                    lDdlCARGADORAID_CARGADORA = New SISPACAL.WebUC.ddlCARGADORA
                    lDdlCARGADORAID_CARGADORA.Recuperar()
                End If
                Dim mCARGADORAID_CARGADORA As String
                mCARGADORAID_CARGADORA = CType(e.Row.FindControl("Label_ID_CARGADORA1"), Label).Text
                Dim lItem As ListItem = lDdlCARGADORAID_CARGADORA.Items.FindByValue(mCARGADORAID_CARGADORA)
                If mCARGADORAID_CARGADORA <> "" And Not lItem Is Nothing Then
                    mDdlCARGADORAID_CARGADORA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlCARGADORAID_CARGADORA.SelectedValue = mCARGADORAID_CARGADORA
                End If
            End If
            If Me.VerID_SUPERVISOR Then
                Dim mDdlSUPERVISORID_SUPERVISOR As SISPACAL.WebUC.ddlSUPERVISOR
                mDdlSUPERVISORID_SUPERVISOR = e.Row.FindControl("DdlSUPERVISORID_SUPERVISOR1")
                If lDdlSUPERVISORID_SUPERVISOR Is Nothing Then
                    lDdlSUPERVISORID_SUPERVISOR = New SISPACAL.WebUC.ddlSUPERVISOR
                    lDdlSUPERVISORID_SUPERVISOR.Recuperar()
                End If
                Dim mSUPERVISORID_SUPERVISOR As String
                mSUPERVISORID_SUPERVISOR = CType(e.Row.FindControl("Label_ID_SUPERVISOR1"), Label).Text
                Dim lItem As ListItem = lDdlSUPERVISORID_SUPERVISOR.Items.FindByValue(mSUPERVISORID_SUPERVISOR)
                If mSUPERVISORID_SUPERVISOR <> "" And Not lItem Is Nothing Then
                    mDdlSUPERVISORID_SUPERVISOR.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlSUPERVISORID_SUPERVISOR.SelectedValue = mSUPERVISORID_SUPERVISOR
                End If
            End If
            If Me.VerID_PROVEEDOR_ROZA Then
                Dim mDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA As SISPACAL.WebUC.ddlPROVEEDOR_ROZA
                mDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA = e.Row.FindControl("DdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA1")
                If lDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA Is Nothing Then
                    lDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA = New SISPACAL.WebUC.ddlPROVEEDOR_ROZA
                    lDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.Recuperar()
                End If
                Dim mPROVEEDOR_ROZAID_PROVEEDOR_ROZA As String
                mPROVEEDOR_ROZAID_PROVEEDOR_ROZA = CType(e.Row.FindControl("Label_ID_PROVEEDOR_ROZA1"), Label).Text
                Dim lItem As ListItem = lDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.Items.FindByValue(mPROVEEDOR_ROZAID_PROVEEDOR_ROZA)
                If mPROVEEDOR_ROZAID_PROVEEDOR_ROZA <> "" And Not lItem Is Nothing Then
                    mDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.SelectedValue = mPROVEEDOR_ROZAID_PROVEEDOR_ROZA
                End If
            End If
            If Me.VerID_CARGADOR Then
                Dim mDdlCARGADORID_CARGADOR As SISPACAL.WebUC.ddlCARGADOR
                mDdlCARGADORID_CARGADOR = e.Row.FindControl("DdlCARGADORID_CARGADOR1")
                If lDdlCARGADORID_CARGADOR Is Nothing Then
                    lDdlCARGADORID_CARGADOR = New SISPACAL.WebUC.ddlCARGADOR
                    lDdlCARGADORID_CARGADOR.Recuperar()
                End If
                Dim mCARGADORID_CARGADOR As String
                mCARGADORID_CARGADOR = CType(e.Row.FindControl("Label_ID_CARGADOR1"), Label).Text
                Dim lItem As ListItem = lDdlCARGADORID_CARGADOR.Items.FindByValue(mCARGADORID_CARGADOR)
                If mCARGADORID_CARGADOR <> "" And Not lItem Is Nothing Then
                    mDdlCARGADORID_CARGADOR.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlCARGADORID_CARGADOR.SelectedValue = mCARGADORID_CARGADOR
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
        If Me.mComponente.EliminarENVIO(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorZAFRA") Then
            Me.CargarDatosPorZAFRA(Me.ViewState("ID_ZAFRA"))
            Return
        End If
        If Me.ViewState("PorCONTRATO") Then
            Me.CargarDatosPorCONTRATO(Me.ViewState("CODICONTRATO"))
            Return
        End If
        If Me.ViewState("PorPROVEEDOR") Then
            Me.CargarDatosPorPROVEEDOR(Me.ViewState("CODIPROVEEDOR"))
            Return
        End If
        If Me.ViewState("PorLOTES") Then
            Me.CargarDatosPorLOTES(Me.ViewState("ACCESLOTE"))
            Return
        End If
        If Me.ViewState("PorTRANSPORTISTA") Then
            Me.CargarDatosPorTRANSPORTISTA(Me.ViewState("CODTRANSPORT"))
            Return
        End If
        If Me.ViewState("PorTIPO_CANA") Then
            Me.CargarDatosPorTIPO_CANA(Me.ViewState("ID_TIPO_CANA"))
            Return
        End If
        If Me.ViewState("PorCARGADORA") Then
            Me.CargarDatosPorCARGADORA(Me.ViewState("ID_CARGADORA"))
            Return
        End If
        If Me.ViewState("PorSUPERVISOR") Then
            Me.CargarDatosPorSUPERVISOR(Me.ViewState("ID_SUPERVISOR"))
            Return
        End If
        If Me.ViewState("PorPROVEEDOR_ROZA") Then
            Me.CargarDatosPorPROVEEDOR_ROZA(Me.ViewState("ID_PROVEEDOR_ROZA"))
            Return
        End If
        If Me.ViewState("PorCARGADOR") Then
            Me.CargarDatosPorCARGADOR(Me.ViewState("ID_CARGADOR"))
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
        If Me.ViewState("PorCONTRATO") Then
            Me.CargarDatosPorCONTRATO(Me.ViewState("CODICONTRATO"))
            Return
        End If
        If Me.ViewState("PorPROVEEDOR") Then
            Me.CargarDatosPorPROVEEDOR(Me.ViewState("CODIPROVEEDOR"))
            Return
        End If
        If Me.ViewState("PorLOTES") Then
            Me.CargarDatosPorLOTES(Me.ViewState("ACCESLOTE"))
            Return
        End If
        If Me.ViewState("PorTRANSPORTISTA") Then
            Me.CargarDatosPorTRANSPORTISTA(Me.ViewState("CODTRANSPORT"))
            Return
        End If
        If Me.ViewState("PorTIPO_CANA") Then
            Me.CargarDatosPorTIPO_CANA(Me.ViewState("ID_TIPO_CANA"))
            Return
        End If
        If Me.ViewState("PorCARGADORA") Then
            Me.CargarDatosPorCARGADORA(Me.ViewState("ID_CARGADORA"))
            Return
        End If
        If Me.ViewState("PorSUPERVISOR") Then
            Me.CargarDatosPorSUPERVISOR(Me.ViewState("ID_SUPERVISOR"))
            Return
        End If
        If Me.ViewState("PorPROVEEDOR_ROZA") Then
            Me.CargarDatosPorPROVEEDOR_ROZA(Me.ViewState("ID_PROVEEDOR_ROZA"))
            Return
        End If
        If Me.ViewState("PorCARGADOR") Then
            Me.CargarDatosPorCARGADOR(Me.ViewState("ID_CARGADOR"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaENVIO
        Dim mLista As New ListaENVIO
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New ENVIO
                mEntidad.ID_ENVIO = CInt(CType(mRow.FindControl("Label_ID_ENVIO"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
