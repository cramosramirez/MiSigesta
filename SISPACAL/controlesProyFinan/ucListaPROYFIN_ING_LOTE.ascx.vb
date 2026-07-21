Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.Drawing
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPROYFIN_ING_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PROYFIN_ING_LOTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPROYFIN_ING_LOTE
    Inherits ucListaBase

    Private mComponente As New cPROYFIN_ING_LOTE
    Public Event Seleccionado(ByVal ID_PROYFIN_ING_LOTE As Int32)
    Public Event Editando(ByVal ID_PROYFIN_ING_LOTE As Int32)

#Region "Propiedades"

    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = Value
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

    Public Property PermitirEditarInline2() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline2")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline2") = value
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = value
            Me.dxgvLista.Columns("Edicion2").Visible = value
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

    Public Property VerID_PROYFIN_ING_LOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROYFIN_ING_LOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROYFIN_ING_LOTE").Visible = Value
        End Set
    End Property

    Public Property VerID_PROYFIN_ING() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROYFIN_ING").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROYFIN_ING").Visible = Value
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

    Public Property VerNO_CONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_CONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_CONTRATO").Visible = Value
        End Set
    End Property

    Public Property VerCICLO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CICLO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CICLO").Visible = Value
        End Set
    End Property

    Public Property VerCICLO1() As Boolean
        Get
            Return Me.dxgvLista.Columns("CICLO1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CICLO1").Visible = Value
        End Set
    End Property

    Public Property VerMZ1() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ1").Visible = Value
        End Set
    End Property

    Public Property VerTC_MZ1() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_MZ1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_MZ1").Visible = Value
        End Set
    End Property

    Public Property VerTC1() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC1").Visible = Value
        End Set
    End Property

    Public Property VerREND1() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND1").Visible = Value
        End Set
    End Property

    Public Property VerLBS1() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS1").Visible = Value
        End Set
    End Property

    Public Property VerCICLO2() As Boolean
        Get
            Return Me.dxgvLista.Columns("CICLO2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CICLO2").Visible = Value
        End Set
    End Property

    Public Property VerMZ2() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ2").Visible = Value
        End Set
    End Property

    Public Property VerTC_MZ2() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_MZ2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_MZ2").Visible = Value
        End Set
    End Property

    Public Property VerTC2() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC2").Visible = Value
        End Set
    End Property

    Public Property VerREND2() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND2").Visible = Value
        End Set
    End Property

    Public Property VerLBS2() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS2").Visible = Value
        End Set
    End Property

    Public Property VerCICLO3() As Boolean
        Get
            Return Me.dxgvLista.Columns("CICLO3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CICLO3").Visible = Value
        End Set
    End Property

    Public Property VerMZ3() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ3").Visible = Value
        End Set
    End Property

    Public Property VerTC_MZ3() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_MZ3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_MZ3").Visible = Value
        End Set
    End Property

    Public Property VerTC3() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC3").Visible = Value
        End Set
    End Property

    Public Property VerREND3() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND3").Visible = Value
        End Set
    End Property

    Public Property VerLBS3() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS3").Visible = Value
        End Set
    End Property

    Public Property VerCICLO4() As Boolean
        Get
            Return Me.dxgvLista.Columns("CICLO4").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CICLO4").Visible = Value
        End Set
    End Property

    Public Property VerMZ4() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ4").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ4").Visible = Value
        End Set
    End Property

    Public Property VerTC_MZ4() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_MZ4").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_MZ4").Visible = Value
        End Set
    End Property

    Public Property VerTC4() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC4").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC4").Visible = Value
        End Set
    End Property

    Public Property VerREND4() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND4").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND4").Visible = Value
        End Set
    End Property

    Public Property VerLBS4() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS4").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS4").Visible = Value
        End Set
    End Property

    Public Property VerCICLO5() As Boolean
        Get
            Return Me.dxgvLista.Columns("CICLO5").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CICLO5").Visible = Value
        End Set
    End Property

    Public Property VerMZ5() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ5").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ5").Visible = Value
        End Set
    End Property

    Public Property VerTC_MZ5() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_MZ5").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_MZ5").Visible = Value
        End Set
    End Property

    Public Property VerTC5() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC5").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC5").Visible = Value
        End Set
    End Property

    Public Property VerREND5() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND5").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND5").Visible = Value
        End Set
    End Property

    Public Property VerLBS5() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS5").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS5").Visible = Value
        End Set
    End Property

    Public Property VerCICLO6() As Boolean
        Get
            Return Me.dxgvLista.Columns("CICLO6").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CICLO6").Visible = Value
        End Set
    End Property

    Public Property VerMZ6() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ6").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ6").Visible = Value
        End Set
    End Property

    Public Property VerTC_MZ6() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_MZ6").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_MZ6").Visible = Value
        End Set
    End Property

    Public Property VerTC6() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC6").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC6").Visible = Value
        End Set
    End Property

    Public Property VerREND6() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND6").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND6").Visible = Value
        End Set
    End Property

    Public Property VerLBS6() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS6").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS6").Visible = Value
        End Set
    End Property

    Public Property VerCICLO7() As Boolean
        Get
            Return Me.dxgvLista.Columns("CICLO7").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CICLO7").Visible = Value
        End Set
    End Property

    Public Property VerMZ7() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ7").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ7").Visible = Value
        End Set
    End Property

    Public Property VerTC_MZ7() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC_MZ7").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC_MZ7").Visible = Value
        End Set
    End Property

    Public Property VerTC7() As Boolean
        Get
            Return Me.dxgvLista.Columns("TC7").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TC7").Visible = Value
        End Set
    End Property

    Public Property VerREND7() As Boolean
        Get
            Return Me.dxgvLista.Columns("REND7").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REND7").Visible = Value
        End Set
    End Property

    Public Property VerLBS7() As Boolean
        Get
            Return Me.dxgvLista.Columns("LBS7").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LBS7").Visible = Value
        End Set
    End Property

    Public Property HeaderID_PROYFIN_ING_LOTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROYFIN_ING_LOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROYFIN_ING_LOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PROYFIN_ING() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROYFIN_ING").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROYFIN_ING").Caption = Value
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

    Public Property HeaderNO_CONTRATO() As String
        Get
            Return Me.dxgvLista.Columns("NO_CONTRATO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_CONTRATO").Caption = Value
        End Set
    End Property

    Public Property HeaderCICLO() As String
        Get
            Return Me.dxgvLista.Columns("CICLO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CICLO").Caption = Value
        End Set
    End Property

    Public Property HeaderCICLO1() As String
        Get
            Return Me.dxgvLista.Columns("CICLO1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CICLO1").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ1() As String
        Get
            Return Me.dxgvLista.Columns("MZ1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ1").Caption = Value
        End Set
    End Property

    Public Property HeaderTC_MZ1() As String
        Get
            Return Me.dxgvLista.Columns("TC_MZ1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC_MZ1").Caption = Value
        End Set
    End Property

    Public Property HeaderTC1() As String
        Get
            Return Me.dxgvLista.Columns("TC1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC1").Caption = Value
        End Set
    End Property

    Public Property HeaderREND1() As String
        Get
            Return Me.dxgvLista.Columns("REND1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND1").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS1() As String
        Get
            Return Me.dxgvLista.Columns("LBS1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS1").Caption = Value
        End Set
    End Property

    Public Property HeaderCICLO2() As String
        Get
            Return Me.dxgvLista.Columns("CICLO2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CICLO2").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ2() As String
        Get
            Return Me.dxgvLista.Columns("MZ2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ2").Caption = Value
        End Set
    End Property

    Public Property HeaderTC_MZ2() As String
        Get
            Return Me.dxgvLista.Columns("TC_MZ2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC_MZ2").Caption = Value
        End Set
    End Property

    Public Property HeaderTC2() As String
        Get
            Return Me.dxgvLista.Columns("TC2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC2").Caption = Value
        End Set
    End Property

    Public Property HeaderREND2() As String
        Get
            Return Me.dxgvLista.Columns("REND2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND2").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS2() As String
        Get
            Return Me.dxgvLista.Columns("LBS2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS2").Caption = Value
        End Set
    End Property

    Public Property HeaderCICLO3() As String
        Get
            Return Me.dxgvLista.Columns("CICLO3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CICLO3").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ3() As String
        Get
            Return Me.dxgvLista.Columns("MZ3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ3").Caption = Value
        End Set
    End Property

    Public Property HeaderTC_MZ3() As String
        Get
            Return Me.dxgvLista.Columns("TC_MZ3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC_MZ3").Caption = Value
        End Set
    End Property

    Public Property HeaderTC3() As String
        Get
            Return Me.dxgvLista.Columns("TC3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC3").Caption = Value
        End Set
    End Property

    Public Property HeaderREND3() As String
        Get
            Return Me.dxgvLista.Columns("REND3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND3").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS3() As String
        Get
            Return Me.dxgvLista.Columns("LBS3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS3").Caption = Value
        End Set
    End Property

    Public Property HeaderCICLO4() As String
        Get
            Return Me.dxgvLista.Columns("CICLO4").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CICLO4").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ4() As String
        Get
            Return Me.dxgvLista.Columns("MZ4").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ4").Caption = Value
        End Set
    End Property

    Public Property HeaderTC_MZ4() As String
        Get
            Return Me.dxgvLista.Columns("TC_MZ4").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC_MZ4").Caption = Value
        End Set
    End Property

    Public Property HeaderTC4() As String
        Get
            Return Me.dxgvLista.Columns("TC4").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC4").Caption = Value
        End Set
    End Property

    Public Property HeaderREND4() As String
        Get
            Return Me.dxgvLista.Columns("REND4").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND4").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS4() As String
        Get
            Return Me.dxgvLista.Columns("LBS4").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS4").Caption = Value
        End Set
    End Property

    Public Property HeaderCICLO5() As String
        Get
            Return Me.dxgvLista.Columns("CICLO5").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CICLO5").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ5() As String
        Get
            Return Me.dxgvLista.Columns("MZ5").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ5").Caption = Value
        End Set
    End Property

    Public Property HeaderTC_MZ5() As String
        Get
            Return Me.dxgvLista.Columns("TC_MZ5").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC_MZ5").Caption = Value
        End Set
    End Property

    Public Property HeaderTC5() As String
        Get
            Return Me.dxgvLista.Columns("TC5").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC5").Caption = Value
        End Set
    End Property

    Public Property HeaderREND5() As String
        Get
            Return Me.dxgvLista.Columns("REND5").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND5").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS5() As String
        Get
            Return Me.dxgvLista.Columns("LBS5").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS5").Caption = Value
        End Set
    End Property

    Public Property HeaderCICLO6() As String
        Get
            Return Me.dxgvLista.Columns("CICLO6").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CICLO6").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ6() As String
        Get
            Return Me.dxgvLista.Columns("MZ6").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ6").Caption = Value
        End Set
    End Property

    Public Property HeaderTC_MZ6() As String
        Get
            Return Me.dxgvLista.Columns("TC_MZ6").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC_MZ6").Caption = Value
        End Set
    End Property

    Public Property HeaderTC6() As String
        Get
            Return Me.dxgvLista.Columns("TC6").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC6").Caption = Value
        End Set
    End Property

    Public Property HeaderREND6() As String
        Get
            Return Me.dxgvLista.Columns("REND6").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND6").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS6() As String
        Get
            Return Me.dxgvLista.Columns("LBS6").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS6").Caption = Value
        End Set
    End Property

    Public Property HeaderCICLO7() As String
        Get
            Return Me.dxgvLista.Columns("CICLO7").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CICLO7").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ7() As String
        Get
            Return Me.dxgvLista.Columns("MZ7").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ7").Caption = Value
        End Set
    End Property

    Public Property HeaderTC_MZ7() As String
        Get
            Return Me.dxgvLista.Columns("TC_MZ7").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC_MZ7").Caption = Value
        End Set
    End Property

    Public Property HeaderTC7() As String
        Get
            Return Me.dxgvLista.Columns("TC7").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TC7").Caption = Value
        End Set
    End Property

    Public Property HeaderREND7() As String
        Get
            Return Me.dxgvLista.Columns("REND7").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REND7").Caption = Value
        End Set
    End Property

    Public Property HeaderLBS7() As String
        Get
            Return Me.dxgvLista.Columns("LBS7").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LBS7").Caption = Value
        End Set
    End Property

#End Region

    Public Property MostrarCheckVariaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
        End Set
        Get
            Return dxgvLista.Columns("CheckSeleccionar").Visible
        End Get
    End Property

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
    End Sub

    Public Sub ExportarExcel()
        gridExport.WriteXlsxToResponse(New DevExpress.XtraPrinting.XlsxExportOptionsEx With {.ExportType = DevExpress.Export.ExportType.WYSIWYG})
    End Sub

    Public Sub AplicarEstilo()
        For i As Integer = 1 To 7 Step 2
            Me.dxgvLista.Columns("G" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")
            Me.dxgvLista.Columns("G" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")
            Me.dxgvLista.Columns("G" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")
            Me.dxgvLista.Columns("G" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")

            Me.dxgvLista.Columns("MZ" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")
            Me.dxgvLista.Columns("TC_MZ" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")
            Me.dxgvLista.Columns("TC" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")
            Me.dxgvLista.Columns("REND" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")
            Me.dxgvLista.Columns("LBS" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#f2f2f2")
        Next

        For i As Integer = 1 To 7
            Me.dxgvLista.Columns("CICLO" + i.ToString).HeaderStyle.BackColor = ColorTranslator.FromHtml("#c5e0b2")
            Me.dxgvLista.Columns("CICLO" + i.ToString).HeaderStyle.Font.Bold = True
            Me.dxgvLista.Columns("CICLO" + i.ToString).CellStyle.BackColor = ColorTranslator.FromHtml("#c5e0b2")
            Me.dxgvLista.Columns("CICLO" + i.ToString).CellStyle.Font.Bold = True
            Me.dxgvLista.Columns("CICLO" + i.ToString).CellStyle.HorizontalAlign = HorizontalAlign.Center
        Next

        For i As Integer = 1 To 7
            Me.dxgvLista.Columns("MZ" + i.ToString).HeaderStyle.Font.Bold = True
            Me.dxgvLista.Columns("TC_MZ" + i.ToString).HeaderStyle.Font.Bold = True
            Me.dxgvLista.Columns("TC" + i.ToString).HeaderStyle.Font.Bold = True
            Me.dxgvLista.Columns("REND" + i.ToString).HeaderStyle.Font.Bold = True
            Me.dxgvLista.Columns("LBS" + i.ToString).HeaderStyle.Font.Bold = True
        Next
    End Sub

    Public Sub AsignarEncabezadoColumnas(ByVal idZafraInicial As Integer)
        Dim lstZafras As New List(Of String)
        Dim lZafra As ZAFRA
        Dim bZafra As New cZAFRA
        Dim idZafra As Integer = idZafraInicial - 1

        If idZafraInicial > -1 Then
            For i As Integer = 0 To 6
                idZafra += 1
                lZafra = bZafra.ObtenerZAFRA(idZafra)
                If lZafra IsNot Nothing Then
                    Me.dxgvLista.Columns("G" + CStr(i + 1)).Caption = "ZAFRA " + lZafra.NOMBRE_ZAFRA
                End If
            Next
        Else
            For i As Integer = 0 To 6
                Me.dxgvLista.Columns("G" + CStr(i + 1)).Caption = " "
            Next
        End If
    End Sub
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROYFIN_ING_LOTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROYFIN_ING_LOTE
    ''' filtrado por la tabla PROYFIN_ING
    ''' </summary>
    ''' <param name="ID_PROYFIN_ING"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROYFIN_ING(ByVal ID_PROYFIN_ING As Int32) As Integer
        Me.odsListaPorPROYFIN_ING.SelectParameters("ID_PROYFIN_ING").DefaultValue = ID_PROYFIN_ING.ToString()
        Me.odsListaPorPROYFIN_ING.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROYFIN_ING.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROYFIN_ING.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROYFIN_ING.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROYFIN_ING"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROYFIN_ING_LOTE
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLOTES(ByVal ACCESLOTE As String) As Integer
        Me.odsListaPorLOTES.SelectParameters("ACCESLOTE").DefaultValue = ACCESLOTE.ToString()
        Me.odsListaPorLOTES.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorLOTES.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorLOTES.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorLOTES.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorLOTES"
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
                keyValues(i) = grid.GetRowValues(i, "ID_PROYFIN_ING_LOTE")
                keyNames(i) = grid.GetRowValues(i, "ID_PROYFIN_ING")
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
        Me.dxgvLista.Columns("colEditar").Visible = Me.PermitirEditar OrElse Me.PermitirEditarInline
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        End If
        If Me.PermitirEditarInline2 Then
            Me.dxgvLista.Columns("Edicion2").Visible = True
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowNewButtonInHeader = False
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = True
        Else
            Me.dxgvLista.Columns("Edicion2").Visible = False
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

    Public Function DevolverSeleccionados() As listaPROYFIN_ING_LOTE
        Dim mLista As New listaPROYFIN_ING_LOTE
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_PROYFIN_ING_LOTE")
            Dim bEntidad As New cPROYFIN_ING_LOTE
            Dim lEntidad As PROYFIN_ING_LOTE = bEntidad.ObtenerPROYFIN_ING_LOTE(llave)
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PROYFIN_ING_LOTE = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PROYFIN_ING_LOTE)

            If Me.mComponente.EliminarPROYFIN_ING_LOTE(lEntidad.ID_PROYFIN_ING_LOTE) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "CODILOTE" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                e.Value = lLote.CODILOTE
            End If
        ElseIf e.Column.FieldName = "NOMBLOTE" Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))
            If lLote IsNot Nothing Then
                e.Value = lLote.NOMBLOTE
            End If
        End If
    End Sub

    Private totalTC As Decimal
    Private totalLBS As Decimal
    Private totalLibras As Decimal
    Protected Sub dxgvLista_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles dxgvLista.CustomSummaryCalculate
        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
            Dim s As String = TryCast(e.Item, ASPxSummaryItem).FieldName

            If s.Contains("REND") Then
                totalTC = 0
                totalLBS = 0
            ElseIf s.Contains("LBS") Then
                totalLibras = 0
            End If
        End If
        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
            Dim s As String = TryCast(e.Item, ASPxSummaryItem).FieldName

            If s.Contains("REND") Then
                If e.GetValue("REND" + Right(s, 1)) > 0 Then
                    totalTC += Convert.ToDecimal(e.GetValue("TC" + Right(s, 1)))
                    totalLBS += Convert.ToDecimal(e.GetValue("LBS" + Right(s, 1)))
                End If
            ElseIf s.Contains("LBS") Then
                totalLibras += Convert.ToDecimal(e.GetValue("LBS" + Right(s, 1)))
            End If
        End If
        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then
            Dim s As String = TryCast(e.Item, ASPxSummaryItem).FieldName

            If s.Contains("REND") Then
                If totalTC > 0 Then
                    e.TotalValue = Math.Round(totalLBS / totalTC, 2)
                Else
                    e.TotalValue = 0
                End If
            ElseIf s.Contains("LBS") Then
                If totalLibras > 0 Then
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                    If lZafra IsNot Nothing Then
                        e.TotalValue = Math.Round(lZafra.PRECIO_LIBRA_AZUCAR * totalLibras, 2)
                    Else
                        e.TotalValue = 0
                    End If
                Else
                    e.TotalValue = 0
                End If
            End If
        End If
    End Sub
End Class
