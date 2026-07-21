Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCONTRATO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CONTRATO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCONTRATO_LG
    Inherits ucListaBase

    Private mComponente As New cCONTRATO_LG
    Public Event Seleccionado(ByVal CODICONTRATO As String)
    Public Event Editando(ByVal CODICONTRATO As String)

#Region "Propiedades"

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

    Public Property PermitirVistaPrevia() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaPrevia").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaPrevia").Visible = Value
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

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODICONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODICONTRATO").Visible = Value
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

    Public Property VerANIOZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ANIOZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ANIOZAFRA").Visible = Value
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

    Public Property VerFECHA_CONTRATOCB() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CONTRATOCB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CONTRATOCB").Visible = Value
        End Set
    End Property

    Public Property VerESTADO_CONTRATOCB() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTADO_CONTRATOCB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTADO_CONTRATOCB").Visible = Value
        End Set
    End Property

    Public Property VerFINANCOADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FINANCOADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FINANCOADO").Visible = Value
        End Set
    End Property

    Public Property VerFINAN_NUMERO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FINAN_NUMERO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FINAN_NUMERO").Visible = Value
        End Set
    End Property

    Public Property VerPROPIETARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PROPIETARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PROPIETARIO").Visible = Value
        End Set
    End Property

    Public Property VerARRENDATARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ARRENDATARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ARRENDATARIO").Visible = Value
        End Set
    End Property

    Public Property VerASIGNATARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ASIGNATARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ASIGNATARIO").Visible = Value
        End Set
    End Property

    Public Property VerTOTALMZ_CONTRATOCB() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTALMZ_CONTRATOCB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTALMZ_CONTRATOCB").Visible = Value
        End Set
    End Property

    Public Property VerTONELADAS_CONTRATOCB() As Boolean
        Get
            Return Me.dxgvLista.Columns("TONELADAS_CONTRATOCB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TONELADAS_CONTRATOCB").Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACIONES_CONTRATOCB() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES_CONTRATOCB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACIONES_CONTRATOCB").Visible = Value
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

    Public Property VerCOSECHA_REAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("COSECHA_REAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COSECHA_REAL").Visible = Value
        End Set
    End Property

    Public Property VerNO_REGISTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_REGISTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_REGISTRO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_REGISTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_REGISTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_REGISTRO").Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APELLIDOS").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRES").Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIRECCION").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO").Visible = Value
        End Set
    End Property

    Public Property VerCELULAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("CELULAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CELULAR").Visible = Value
        End Set
    End Property

    Public Property VerDUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI").Visible = Value
        End Set
    End Property

    Public Property VerNIT() As Boolean
        Get
            Return Me.dxgvLista.Columns("NIT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NIT").Visible = Value
        End Set
    End Property

    Public Property VerCREDITFISCAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("CREDITFISCAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CREDITFISCAL").Visible = Value
        End Set
    End Property

    Public Property VerAPODERADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("APODERADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APODERADO").Visible = Value
        End Set
    End Property

    Public Property VerDUI_APODERADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI_APODERADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI_APODERADO").Visible = Value
        End Set
    End Property

    Public Property VerNIT_APODERADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NIT_APODERADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NIT_APODERADO").Visible = Value
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

    Public Property HeaderCODICONTRATO() As String
        Get
            Return Me.dxgvLista.Columns("CODICONTRATO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODICONTRATO").Caption = Value
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

    Public Property HeaderFECHA_CONTRATOCB() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CONTRATOCB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CONTRATOCB").Caption = Value
        End Set
    End Property

    Public Property HeaderESTADO_CONTRATOCB() As String
        Get
            Return Me.dxgvLista.Columns("ESTADO_CONTRATOCB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ESTADO_CONTRATOCB").Caption = Value
        End Set
    End Property

    Public Property HeaderFINANCOADO() As String
        Get
            Return Me.dxgvLista.Columns("FINANCOADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FINANCOADO").Caption = Value
        End Set
    End Property

    Public Property HeaderFINAN_NUMERO() As String
        Get
            Return Me.dxgvLista.Columns("FINAN_NUMERO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FINAN_NUMERO").Caption = Value
        End Set
    End Property

    Public Property HeaderPROPIETARIO() As String
        Get
            Return Me.dxgvLista.Columns("PROPIETARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PROPIETARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderARRENDATARIO() As String
        Get
            Return Me.dxgvLista.Columns("ARRENDATARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ARRENDATARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderASIGNATARIO() As String
        Get
            Return Me.dxgvLista.Columns("ASIGNATARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ASIGNATARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderTOTALMZ_CONTRATOCB() As String
        Get
            Return Me.dxgvLista.Columns("TOTALMZ_CONTRATOCB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTALMZ_CONTRATOCB").Caption = Value
        End Set
    End Property

    Public Property HeaderTONELADAS_CONTRATOCB() As String
        Get
            Return Me.dxgvLista.Columns("TONELADAS_CONTRATOCB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TONELADAS_CONTRATOCB").Caption = Value
        End Set
    End Property

    Public Property HeaderOBSERVACIONES_CONTRATOCB() As String
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES_CONTRATOCB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OBSERVACIONES_CONTRATOCB").Caption = Value
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

    Public Property HeaderCOSECHA_REAL() As String
        Get
            Return Me.dxgvLista.Columns("COSECHA_REAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COSECHA_REAL").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_REGISTRO() As String
        Get
            Return Me.dxgvLista.Columns("NO_REGISTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_REGISTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_REGISTRO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_REGISTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_REGISTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderAPELLIDOS() As String
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("APELLIDOS").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRES() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRES").Caption = Value
        End Set
    End Property

    Public Property HeaderDIRECCION() As String
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIRECCION").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO").Caption = Value
        End Set
    End Property

    Public Property HeaderCELULAR() As String
        Get
            Return Me.dxgvLista.Columns("CELULAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CELULAR").Caption = Value
        End Set
    End Property

    Public Property HeaderDUI() As String
        Get
            Return Me.dxgvLista.Columns("DUI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI").Caption = Value
        End Set
    End Property

    Public Property HeaderNIT() As String
        Get
            Return Me.dxgvLista.Columns("NIT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NIT").Caption = Value
        End Set
    End Property

    Public Property HeaderCREDITFISCAL() As String
        Get
            Return Me.dxgvLista.Columns("CREDITFISCAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CREDITFISCAL").Caption = Value
        End Set
    End Property

    Public Property HeaderAPODERADO() As String
        Get
            Return Me.dxgvLista.Columns("APODERADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("APODERADO").Caption = Value
        End Set
    End Property

    Public Property HeaderDUI_APODERADO() As String
        Get
            Return Me.dxgvLista.Columns("DUI_APODERADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI_APODERADO").Caption = Value
        End Set
    End Property

    Public Property HeaderNIT_APODERADO() As String
        Get
            Return Me.dxgvLista.Columns("NIT_APODERADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NIT_APODERADO").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO
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


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal ID_ZAFRA As Int32,
                                             ByVal NO_CONTRATO As Int32,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String) As Integer
        Me.odsCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsCriterios.SelectParameters("NO_CONTRATO").DefaultValue = NO_CONTRATO
        Me.odsCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO
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
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "CODICONTRATO")
                keyNames(i) = grid.GetRowValues(i, "ANIOZAFRA")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
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
        If Me.PermitirEditar Then
            Me.dxgvLista.Columns("Editar").Visible = True
        Else
            Me.dxgvLista.Columns("Editar").Visible = False
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

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.GridViewRowType.EditForm Then
            Dim btnGuardar As DevExpress.Web.ASPxButton
            Dim btnCancelar As DevExpress.Web.ASPxButton
            btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
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
                Dim lbDetalle As ImageButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                If lbDetalle IsNot Nothing Then lbDetalle.Visible = False
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

    Public Function DevolverSeleccionados() As listaCONTRATO_LG
        Dim mLista As New listaCONTRATO_LG
        For Each llave As String In Me.dxgvLista.GetSelectedFieldValues("CODICONTRATO")
            Dim lEntidad As CONTRATO_LG = mComponente.ObtenerCONTRATO_LG(llave)
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Public Sub SeleccionarRegistros(ByVal p As List(Of String))
        Me.dxgvLista.Selection.UnselectAll()
        If p IsNot Nothing AndAlso p.Count > 0 Then
            For i As Int32 = 0 To p.Count - 1
                Me.dxgvLista.Selection.SelectRowByKey(p(i))
            Next
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        dxgvLista.JSProperties.Clear()
        If e.ButtonID = "btnEditar" Then
            Dim lEntidad As CONTRATO_LG = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CONTRATO_LG)
            RaiseEvent Editando(lEntidad.CODICONTRATO)
        End If
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CONTRATO_LG = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CONTRATO_LG)
            Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva()

            Dim lContratosZafra As listaCONTRATO_ZAFRAS_LG = (New cCONTRATO_ZAFRAS_LG).ObtenerListaPorCONTRATO_LG(lEntidad.CODICONTRATO)
            If lContratosZafra IsNot Nothing AndAlso lContratosZafra.Count > 0 Then
                For i As Int32 = 0 To lContratosZafra.Count - 1
                    If lContratosZafra(i).ID_ZAFRA < lZafraActiva.ID_ZAFRA Then
                        dxgvLista.JSProperties.Add("cpMensaje", "No es posible eliminar Contratos de Zafras anteriores")
                        Return
                    End If
                Next
            End If
            If Me.mComponente.EliminarCONTRATO_LG(lEntidad.CODICONTRATO) <> 1 Then
                'Si se cometio un error
                dxgvLista.JSProperties.Add("cpMensaje", "Error al Eliminar Registro: " + Me.mComponente.sError)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        Select Case e.Column.FieldName
            Case "NOMBRE_ZAFRA"
                If e.GetListSourceFieldValue("ID_ZAFRA") IsNot Nothing Then
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(e.GetListSourceFieldValue("ID_ZAFRA"))
                    e.Value = lZafra.NOMBRE_ZAFRA
                End If
            Case "CODIPROVEE"
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
                If lProveedor IsNot Nothing Then
                    e.Value = CInt(lProveedor.CODIPROVEE)
                End If
            Case "CODISOCIO"
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
                If lProveedor IsNot Nothing Then
                    If Utilerias.EsNumeroEntero(lProveedor.CODISOCIO) AndAlso CInt(lProveedor.CODISOCIO) > 0 Then
                        e.Value = CInt(lProveedor.CODISOCIO)
                    End If
                End If
        End Select
    End Sub

End Class
