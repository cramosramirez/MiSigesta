Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaLOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaLOTES
    Inherits ucListaBase
 
    Private mComponente As New cLOTES
    Public Event Seleccionado(ByVal ACCESLOTE As String) 
    Public Event Editando(ByVal ACCESLOTE As String) 

#Region "Propiedades"
    Public Property Habilitar As Boolean
        Get
            Return Me.dxgvLista.Enabled
        End Get
        Set(value As Boolean)
            Me.dxgvLista.Enabled = value
        End Set
    End Property
    Public WriteOnly Property SeleccionarFila() As Object
        Set(value As Object)
            Dim indice As Int32
            Me.dxgvLista.Selection.SelectRowByKey(value)
            indice = Me.dxgvLista.FindVisibleIndexByKeyValue(value)
            Me.dxgvLista.FocusedRowIndex = indice
        End Set
    End Property

    Public Property MostrarCheckUnaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
            dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly = value
        End Set
        Get
            Return dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly
        End Get
    End Property
    Public Property MostrarCheckVariaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
        End Set
        Get
            Return dxgvLista.Columns("CheckSeleccionar").Visible
        End Get
    End Property

    Public Property CallbackPlanCosecha() As Boolean
        Get
            If Not Me.ViewState("CallbackPlanCosecha") Is Nothing Then
                Return Me.ViewState("CallbackPlanCosecha")
            Else
                Return False
            End If
        End Get
        Set(ByVal Value As Boolean)
            If Not Me.ViewState("CallbackPlanCosecha") Is Nothing Then Me.ViewState.Remove("CallbackPlanCosecha")
            Me.ViewState.Add("CallbackPlanCosecha", Value)
        End Set
    End Property

    Public Property MostrarCheckTodos() As Boolean
        Get
            If Not Me.ViewState("MostrarCheckTodos") Is Nothing Then
                Return Me.ViewState("MostrarCheckTodos")
            Else
                Return False
            End If
        End Get
        Set(ByVal Value As Boolean)
            If Not Me.ViewState("MostrarCheckTodos") Is Nothing Then Me.ViewState.Remove("MostrarCheckTodos")
            Me.ViewState.Add("MostrarCheckTodos", Value)
        End Set
    End Property
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

    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = Value
        End Set
    End Property

    Public Property TipoEdicion() As Integer
        Get
            Return Me.dxgvLista.SettingsEditing.Mode
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsEditing.Mode = Value
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


    Public Property ID_ZAFRA() As Int32
        Get
            Return Me.ViewState("ID_ZAFRA")
        End Get
        Set(ByVal Value As Int32)
            If Not Me.ViewState("ID_ZAFRA") Is Nothing Then Me.ViewState.Remove("ID_ZAFRA")
            Me.ViewState.Add("ID_ZAFRA", Value)
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

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACCESLOTE").Visible = Value
        End Set
    End Property

    Public Property VerANIOZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ANIOZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ANIOZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerCONTRATO_TRASPASO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONTRATO_TRASPASO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONTRATO_TRASPASO").Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerCODILOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODILOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODILOTE").Visible = Value
        End Set
    End Property

    Public Property VerCODIAGRON() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIAGRON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIAGRON").Visible = Value
        End Set
    End Property

    Public Property VerCANTON() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_CANTON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_CANTON").Visible = Value
        End Set
    End Property

    Public Property VerCODIVARIEDA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIVARIEDA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIVARIEDA").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_CANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_CANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_CANA").Visible = Value
        End Set
    End Property
    Public Property VerTIPO_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_ROZA").Visible = Value
        End Set
    End Property
    Public Property VerTIPO_ALZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_ALZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_ALZA").Visible = Value
        End Set
    End Property
    Public Property VerTIPO_TRANS() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_TRANS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_TRANS").Visible = Value
        End Set
    End Property


    Public Property VerRIESGO_PIEDRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("RIESGO_PIEDRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RIESGO_PIEDRA").Visible = Value
        End Set
    End Property
    Public Property VerREPARA_ACCESO() As Boolean
        Get
            Return Me.dxgvLista.Columns("REPARA_ACCESO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REPARA_ACCESO").Visible = Value
        End Set
    End Property
    Public Property VerSIN_ACCESO_PROPIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SIN_ACCESO_PROPIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SIN_ACCESO_PROPIO").Visible = Value
        End Set
    End Property

    Public Property VerCODIUBICACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIUBICACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIUBICACION").Visible = Value
        End Set
    End Property

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODICONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODICONTRATO").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_TECNICO_ASIGNADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIAGRON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIAGRON").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_TECNICO_ASIGNADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_AGRONOMO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_AGRONOMO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBLOTE").Visible = Value
        End Set
    End Property

    Public Property VerNO_CONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_CONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_CONTRATO").Visible = Value
        End Set
    End Property

    Public Property VerAREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("AREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("AREA").Visible = Value
        End Set
    End Property

    Public Property VerAREA_CANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("AREA_CANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("AREA_CANA").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DERECHO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DERECHO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DERECHO").Visible = Value
        End Set
    End Property

    Public Property VerTONELADAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONELADAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONELADAS").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_TC() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_TC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_TC").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_CALC() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_CALC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_CALC").Visible = Value
        End Set
    End Property


    Public Property VerMZ_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ_CENSO").Visible = Value
        End Set
    End Property
    Public Property VerTONEL_MZ_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_MZ_CENSO").Visible = Value
        End Set
    End Property
    Public Property VerTONEL_CENSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_CENSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_CENSO").Visible = Value
        End Set
    End Property


    Public Property VerZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZONA").Visible = Value
        End Set
    End Property


    Public Property VerEDITAR_LOTE_MAESTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("colEditarLoteMaestro").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colEditarLoteMaestro").Visible = Value
        End Set
    End Property

    Public Property VerEDAD_LOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("EDAD_LOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EDAD_LOTE").Visible = Value
        End Set
    End Property

    Public Property VerFFCHPROXENT() As Boolean
        Get
            Return Me.dxgvLista.Columns("FFCHPROXENT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FFCHPROXENT").Visible = Value
        End Set
    End Property

    Public Property VerTONXENTREGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONXENTREGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONXENTREGAR").Visible = Value
        End Set
    End Property

    Public Property VerENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerCODISOCIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODISOCIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODISOCIO").Visible = Value
        End Set
    End Property

    Public Property VerCODISOCIO_NUMERICO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODISOCIO_NUMERICO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODISOCIO_NUMERICO").Visible = Value
        End Set
    End Property

    Public Property VerUSER_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USER_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USER_CREA").Visible = Value
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

    Public Property VerUSER_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("USER_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USER_ACT").Visible = Value
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

    Public Property VerFin_lote() As Boolean
        Get
            Return Me.dxgvLista.Columns("fin_lote").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("fin_lote").Visible = Value
        End Set
    End Property

    Public Property VerREND_CONTRATADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND_CONTRATADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND_CONTRATADO").Visible = Value
        End Set
    End Property

    Public Property VerLBS_CONTRATADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS_CONTRATADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS_CONTRATADO").Visible = Value
        End Set
    End Property

    Public Property VerVALOR_CONTRATADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("VALOR_CONTRATADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("VALOR_CONTRATADO").Visible = Value
        End Set
    End Property

    Public Property VerREND_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerMZ_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_MZ_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_MZ_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerTONEL_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONEL_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONEL_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerLBS_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerVALOR_ENTREGADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("VALOR_ENTREGADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("VALOR_ENTREGADA").Visible = Value
        End Set
    End Property

    Public Property VerCUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("CUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CUI").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_SOCIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_SOCIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_SOCIO").Visible = Value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ZAFRA").Visible = Value
        End Set
    End Property

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACCESLOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderANIOZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ANIOZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ANIOZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEEDOR() As String
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Caption = Value
        End Set
    End Property

    Public Property HeaderCODILOTE() As String
        Get
            Return Me.dxgvLista.Columns("CODILOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODILOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIAGRON() As String
        Get
            Return Me.dxgvLista.Columns("CODIAGRON").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIAGRON").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIVARIEDA() As String
        Get
            Return Me.dxgvLista.Columns("CODIVARIEDA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIVARIEDA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIUBICACION() As String
        Get
            Return Me.dxgvLista.Columns("CODIUBICACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIUBICACION").Caption = Value
        End Set
    End Property

    Public Property HeaderCODICONTRATO() As String
        Get
            Return Me.dxgvLista.Columns("CODICONTRATO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODICONTRATO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBLOTE() As String
        Get
            Return Me.dxgvLista.Columns("NOMBLOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBLOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderAREA() As String
        Get
            Return Me.dxgvLista.Columns("AREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("AREA").Caption = Value
        End Set
    End Property

    Public Property HeaderTONELADAS() As String
        Get
            Return Me.dxgvLista.Columns("TONELADAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONELADAS").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_TC() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_TC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_TC").Caption = Value
        End Set
    End Property

    Public Property HeaderZONA() As String
        Get
            Return Me.dxgvLista.Columns("ZONA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ZONA").Caption = Value
        End Set
    End Property

    Public Property HeaderEDAD_LOTE() As String
        Get
            Return Me.dxgvLista.Columns("EDAD_LOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EDAD_LOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderFFCHPROXENT() As String
        Get
            Return Me.dxgvLista.Columns("FFCHPROXENT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FFCHPROXENT").Caption = Value
        End Set
    End Property

    Public Property HeaderTONXENTREGAR() As String
        Get
            Return Me.dxgvLista.Columns("TONXENTREGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONXENTREGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderUSER_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USER_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USER_CREA").Caption = Value
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

    Public Property HeaderUSER_ACT() As String
        Get
            Return Me.dxgvLista.Columns("USER_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USER_ACT").Caption = Value
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

    Public Property HeaderFin_lote() As String
        Get
            Return Me.dxgvLista.Columns("fin_lote").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("fin_lote").Caption = Value
        End Set
    End Property

    Public Property HeaderREND_CONTRATADO() As String
        Get
            Return Me.dxgvLista.Columns("REND_CONTRATADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND_CONTRATADO").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS_CONTRATADO() As String
        Get
            Return Me.dxgvLista.Columns("LBS_CONTRATADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS_CONTRATADO").Caption = Value
        End Set
    End Property

    Public Property HeaderVALOR_CONTRATADO() As String
        Get
            Return Me.dxgvLista.Columns("VALOR_CONTRATADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("VALOR_CONTRATADO").Caption = Value
        End Set
    End Property

    Public Property HeaderREND_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("REND_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("MZ_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_MZ_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_MZ_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_MZ_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderTONEL_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("TONEL_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONEL_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("LBS_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderVALOR_ENTREGADA() As String
        Get
            Return Me.dxgvLista.Columns("VALOR_ENTREGADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("VALOR_ENTREGADA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_LOTE() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_LOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_LOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ZAFRA").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
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

    Public Function CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODIAGRON As String) As Integer
        Me.odsZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO.SelectParameters("CODIPROVEEDOR").DefaultValue = CODIPROVEEDOR
        Me.odsZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON
        Me.odsZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO.DataBind()
        Me.dxgvLista.DataSourceID = "odsZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODIAGRON As String) As Integer
        Me.odsZAFRA_CONTRATADA_PROVEEDOR.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsZAFRA_CONTRATADA_PROVEEDOR.SelectParameters("CODIPROVEEDOR").DefaultValue = CODIPROVEEDOR
        Me.odsZAFRA_CONTRATADA_PROVEEDOR.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON
        Me.odsZAFRA_CONTRATADA_PROVEEDOR.DataBind()
        Me.dxgvLista.DataSourceID = "odsZAFRA_CONTRATADA_PROVEEDOR"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function




    Public Function CargarDatosPorZAFRA_NO_CONTRATO(ByVal ID_ZAFRA As Int32, ByVal NO_CONTRATO As Int32) As Integer
        Me.odsListaPorZAFRA_NO_CONTRATO.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsListaPorZAFRA_NO_CONTRATO.SelectParameters("NO_CONTRATO").DefaultValue = NO_CONTRATO
        Me.odsListaPorZAFRA_NO_CONTRATO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZAFRA_NO_CONTRATO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES
    ''' filtrado por la tabla PROVEEDOR
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR(ByVal CODIPROVEEDOR As String) As Integer
        Me.odsListaPorPROVEEDOR.SelectParameters("CODIPROVEEDOR").DefaultValue = CODIPROVEEDOR.ToString()
        Me.odsListaPorPROVEEDOR.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.odsLotesCache.SelectParameters("nombreSesion").DefaultValue = nombreSesion
        Me.odsLotesCache.DataBind()
        Me.dxgvLista.DataSourceID = "odsLotesCache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES
    ''' filtrado por la tabla AGRONOMO
    ''' </summary>
    ''' <param name="CODIAGRON"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorAGRONOMO(ByVal CODIAGRON As String) As Integer
        Me.odsListaPorAGRONOMO.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON.ToString()
        Me.odsListaPorAGRONOMO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorAGRONOMO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorAGRONOMO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorAGRONOMO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorAGRONOMO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorAGRONOMO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES
    ''' filtrado por la tabla VARIEDAD
    ''' </summary>
    ''' <param name="CODIVARIEDA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorVARIEDAD(ByVal CODIVARIEDA As String) As Integer
        Me.odsListaPorVARIEDAD.SelectParameters("CODIVARIEDA").DefaultValue = CODIVARIEDA.ToString()
        Me.odsListaPorVARIEDAD.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorVARIEDAD.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorVARIEDAD.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorVARIEDAD.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorVARIEDAD.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorVARIEDAD"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorCriterios2(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                                              ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, _
                                              ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String) As Integer
        Me.odsListaPorCriterios2.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorCriterios2.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsListaPorCriterios2.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.odsListaPorCriterios2.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsListaPorCriterios2.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsListaPorCriterios2.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsListaPorCriterios2.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaPorCriterios2.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaPorCriterios2.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorCriterios2.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios2"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES
    ''' filtrado por la tabla UBICACION
    ''' </summary>
    ''' <param name="CODIUBICACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorUBICACION(ByVal CODIUBICACION As String) As Integer
        Me.odsListaPorUBICACION.SelectParameters("CODIUBICACION").DefaultValue = CODIUBICACION.ToString()
        Me.odsListaPorUBICACION.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorUBICACION.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorUBICACION.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorUBICACION.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorUBICACION.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorUBICACION"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES
    ''' filtrado por la tabla CONTRATO
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO(ByVal CODICONTRATO As String) As Integer
        Me.odsListaPorCONTRATO.SelectParameters("CODICONTRATO").DefaultValue = CODICONTRATO.ToString()
        Me.odsListaPorCONTRATO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorCONTRATO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCONTRATO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONTRATO"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES
    ''' filtrado por la tabla MAESTRO_LOTES
    ''' </summary>
    ''' <param name="CODIGO_LOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMAESTRO_LOTES(ByVal CODIGO_LOTE As String) As Integer
        Me.odsListaPorMAESTRO_LOTES.SelectParameters("CODIGO_LOTE").DefaultValue = CODIGO_LOTE.ToString()
        Me.odsListaPorMAESTRO_LOTES.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorMAESTRO_LOTES.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorMAESTRO_LOTES.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorMAESTRO_LOTES.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorMAESTRO_LOTES.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorMAESTRO_LOTES"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZAFRA(ByVal ID_ZAFRA As Int32) As Integer
        Me.odsListaPorZAFRA.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorZAFRA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorZAFRA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorZAFRA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorZAFRA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorZAFRA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZAFRA"
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
        e.Properties("cpVisibleRowCount") = TryCast(sender, ASPxGridView).VisibleRowCount
        e.Properties("cpVisibleCheckTodos") = Me.MostrarCheckTodos
        e.Properties("cpPlanCosechaCallback") = Me.CallbackPlanCosecha
        'If Me.PermitirSeleccionParaCombo Then
        Dim grid As DevExpress.Web.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView)
        Dim keyNames(grid.VisibleRowCount - 1) As Object
        Dim keyValues(grid.VisibleRowCount - 1) As Object
        Dim keyMaestroLote(grid.VisibleRowCount - 1) As Object
        For i As Integer = 0 To grid.VisibleRowCount - 1
            keyValues(i) = grid.GetRowValues(i, "ACCESLOTE")
            keyNames(i) = grid.GetRowValues(i, "ANIOZAFRA")
            keyMaestroLote(i) = grid.GetRowValues(i, "ID_MAESTRO")
        Next i
        e.Properties("cpKeyValues") = keyValues
        e.Properties("cpKeyNames") = keyNames
        e.Properties("cpKeyMaestroLotes") = keyMaestroLote
        e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        'End If
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

    Public Property DataSource As listaLOTES
        Set(value As listaLOTES)
            Me.dxgvLista.DataSource = value
        End Set
        Get
            If Me.dxgvLista.DataSource Is Nothing Then Return New listaLOTES Else Return CType(Me.dxgvLista.DataSource, listaLOTES)
        End Get
    End Property

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
            Dim btnAgregar As DevExpress.Web.ASPxButton
            btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            'btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnAgregar.Visible = Me.PermitirAgregarInline
            Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
            lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            'lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.Data Then
            If Not Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                'lbDetalle.Visible = False
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

    Public Function DevolverSeleccionados() As listaLOTES
        Dim mLista As New listaLOTES
        For Each llave As String In Me.dxgvLista.GetSelectedFieldValues("ACCESLOTE")
            Dim lEntidad As New LOTES
            lEntidad.ACCESLOTE = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
    End Sub

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As LOTES = CType(Me.dxgvLista.GetRow(e.VisibleIndex), LOTES)

            If Me.mComponente.EliminarLOTES(lEntidad.ACCESLOTE) <> 1 Then
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
        Select Case e.Column.FieldName
            Case "NO_CONTRATO"
                If e.GetListSourceFieldValue("CODICONTRATO") IsNot Nothing Then
                    Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(e.GetListSourceFieldValue("CODICONTRATO"))
                    If lContrato IsNot Nothing Then e.Value = lContrato.NO_CONTRATO
                End If
            Case "CUI"
                Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue("ID_MAESTRO"))
                If lMaestro IsNot Nothing Then
                    e.Value = lMaestro.CUI
                End If
            Case "NOM_VARIEDAD"
                If e.GetListSourceFieldValue("CODIVARIEDA") IsNot Nothing AndAlso e.GetListSourceFieldValue("CODIVARIEDA") <> "" Then
                    Dim lVariedad As VARIEDAD = (New cVARIEDAD).ObtenerVARIEDAD(e.GetListSourceFieldValue("CODIVARIEDA"))
                    e.Value = lVariedad.NOM_VARIEDAD
                End If
            Case "NOMBRE_CANTON"
                If e.GetListSourceFieldValue("ID_MAESTRO") IsNot Nothing Then
                    Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue("ID_MAESTRO"))
                    Dim lCanton As CANTON = (New cCANTON).ObtenerCANTON(lMaestro.CODI_CANTON, lMaestro.CODI_DEPTO, lMaestro.CODI_MUNI)
                    e.Value = lCanton.NOMBRE_CANTON
                End If
            Case "CODISOCIO_NUMERICO"
                If e.GetListSourceFieldValue("CODISOCIO") IsNot Nothing AndAlso e.GetListSourceFieldValue("CODISOCIO") <> Utilerias.FormatoCODISOCIO(0) Then
                    e.Value = CStr(CInt(e.GetListSourceFieldValue("CODISOCIO")))
                End If
            Case "NOMBRE_SOCIO"
                If e.GetListSourceFieldValue("CODIPROVEEDOR") IsNot Nothing AndAlso e.GetListSourceFieldValue("CODIPROVEEDOR") <> "" Then
                    Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
                    e.Value = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                End If
            Case "NOMBRE_AGRONOMO"
                If Me.ViewState("ID_ZAFRA") IsNot Nothing Then
                    Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(e.GetListSourceFieldValue("ACCESLOTE"), Me.ViewState("ID_ZAFRA"))
                    If lLoteCosecha IsNot Nothing Then
                        Dim lAgronomo As AGRONOMO = (New cAGRONOMO).ObtenerAGRONOMO(lLoteCosecha.CODIAGRON)
                        If lAgronomo IsNot Nothing Then e.Value = lAgronomo.NOMBRE_AGRONOMO.Trim + " " + lAgronomo.APELLIDO_AGRONOMO.Trim
                    Else
                        Dim lLotes As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
                        If lLotes IsNot Nothing Then
                            Dim lAgronomo As AGRONOMO = (New cAGRONOMO).ObtenerAGRONOMO(lLotes.CODIAGRON)
                            If lAgronomo IsNot Nothing Then e.Value = lAgronomo.NOMBRE_AGRONOMO.Trim + " " + lAgronomo.APELLIDO_AGRONOMO.Trim
                        End If
                    End If
                End If
            Case "CONTRATO_TRASPASO"
                If e.GetListSourceFieldValue("ID_LOTE_TRASPASO") IsNot Nothing AndAlso e.GetListSourceFieldValue("ID_LOTE_TRASPASO") > 0 Then
                    Dim lLoteTraspaso As LOTES_TRASPASO = (New cLOTES_TRASPASO).ObtenerLOTES_TRASPASO(CInt(e.GetListSourceFieldValue("ID_LOTE_TRASPASO")))
                    If lLoteTraspaso IsNot Nothing Then
                        Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(lLoteTraspaso.CODICONTRATO)
                        If lContrato IsNot Nothing Then e.Value = lContrato.NO_CONTRATO.ToString
                    End If
                End If
            Case "TIPO_CANA"
                Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue("ID_MAESTRO"))
                If lMaestro IsNot Nothing Then
                    Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(lMaestro.ID_TIPO_CANA)
                    e.Value = If(lEntidad IsNot Nothing, lEntidad.NOM_TIPO, "")
                End If
            Case "TIPO_ROZA"
                Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue("ID_MAESTRO"))
                If lMaestro IsNot Nothing Then
                    Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(lMaestro.ID_TIPO_ROZA)
                    e.Value = If(lEntidad IsNot Nothing, lEntidad.NOM_TIPO, "")
                End If
            Case "TIPO_ALZA"
                Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue("ID_MAESTRO"))
                If lMaestro IsNot Nothing Then
                    Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(lMaestro.ID_TIPO_ALZA)
                    e.Value = If(lEntidad IsNot Nothing, lEntidad.NOM_TIPO, "")
                End If
            Case "TIPO_TRANS"
                Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue("ID_MAESTRO"))
                If lMaestro IsNot Nothing Then
                    Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(lMaestro.ID_TIPO_TRANS)
                    e.Value = If(lEntidad IsNot Nothing, lEntidad.NOM_TIPO, "")
                End If
            Case "MZ_CENSO"
                If Me.ViewState("ID_ZAFRA") IsNot Nothing Then
                    Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(e.GetListSourceFieldValue("ACCESLOTE"), Me.ViewState("ID_ZAFRA"))
                    If lLoteCosecha IsNot Nothing Then
                        e.Value = lLoteCosecha.MZ_CENSO
                    End If
                End If
            Case "TONEL_MZ_CENSO"
                If Me.ViewState("ID_ZAFRA") IsNot Nothing Then
                    Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(e.GetListSourceFieldValue("ACCESLOTE"), Me.ViewState("ID_ZAFRA"))
                    If lLoteCosecha IsNot Nothing Then
                        e.Value = lLoteCosecha.TONEL_MZ_CENSO
                    End If
                End If
            Case "TONEL_CENSO"
                If Me.ViewState("ID_ZAFRA") IsNot Nothing Then
                    Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(e.GetListSourceFieldValue("ACCESLOTE"), Me.ViewState("ID_ZAFRA"))
                    If lLoteCosecha IsNot Nothing Then
                        e.Value = lLoteCosecha.TONEL_CENSO
                    End If
                End If
            Case "HACIENDA"
                Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue("ID_MAESTRO"))
                If lMaestro IsNot Nothing Then
                    e.Value = lMaestro.HACIENDA
                End If
        End Select
    End Sub

    Protected Sub chkTodo_Init(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chkTodo As ASPxCheckBox = TryCast(sender, ASPxCheckBox)
        Dim grd As ASPxGridView = TryCast(chkTodo.NamingContainer, GridViewHeaderTemplateContainer).Grid
        chkTodo.Checked = (grd.Selection.Count = grd.VisibleRowCount) AndAlso grd.VisibleRowCount > 0
    End Sub

    Public Function GetCheckBoxVisible() As Boolean
        Return MostrarCheckTodos
    End Function

    Public Sub QuitarFiltros()
        Me.dxgvLista.ClearSort()
        Me.dxgvLista.FilterExpression = ""
        Me.dxgvLista.PageIndex = 0
    End Sub

    Protected Sub dxgvLista_HtmlRowPrepared(sender As Object, e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowPrepared
        If e.RowType = GridViewRowType.Data Then
            If Convert.ToInt32(e.GetValue("ID_LOTE_TRASPASO")) > 0 Then
                e.Row.ForeColor = Drawing.Color.Red
            End If
        End If
    End Sub
End Class
