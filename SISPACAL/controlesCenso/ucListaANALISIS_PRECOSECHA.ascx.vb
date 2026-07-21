Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaANALISIS_PRECOSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ANALISIS_PRECOSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaANALISIS_PRECOSECHA
    Inherits ucListaBase
 
    Private mComponente As New cANALISIS_PRECOSECHA
    Public Event Seleccionado(ByVal ID_ANALISIS_PRE As Int32) 
    Public Event Editando(ByVal ID_ANALISIS_PRE As Int32) 

#Region"Propiedades"
    
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

    Public Property PermitirVistaPrevia() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaPrevia").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaPrevia").Visible = Value
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

    Public Property VerID_ANALISIS_PRE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ANALISIS_PRE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ANALISIS_PRE").Visible = Value
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

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerNO_ANALISIS() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_ANALISIS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_ANALISIS").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_MUESTRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_MUESTRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_MUESTRA").Visible = Value
        End Set
    End Property

    Public Property VerNO_MUESTRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_MUESTRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_MUESTRA").Visible = Value
        End Set
    End Property

    Public Property VerAREA_MUESTRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("AREA_MUESTRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("AREA_MUESTRA").Visible = Value
        End Set
    End Property

    Public Property VerBAGAZO_BRUTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("BAGAZO_BRUTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BAGAZO_BRUTO").Visible = Value
        End Set
    End Property

    Public Property VerBAGAZO_NETO() As Boolean
        Get
            Return Me.dxgvLista.Columns("BAGAZO_NETO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BAGAZO_NETO").Visible = Value
        End Set
    End Property

    Public Property VerPOL() As Boolean
        Get
            Return Me.dxgvLista.Columns("POL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("POL").Visible = Value
        End Set
    End Property

    Public Property VerBRIX() As Boolean
        Get
            Return Me.dxgvLista.Columns("BRIX").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BRIX").Visible = Value
        End Set
    End Property

    Public Property VerFIBRA_CANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FIBRA_CANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FIBRA_CANA").Visible = Value
        End Set
    End Property

    Public Property VerHUMEDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("HUMEDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HUMEDAD").Visible = Value
        End Set
    End Property

    Public Property VerPOL_JUGO() As Boolean
        Get
            Return Me.dxgvLista.Columns("POL_JUGO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("POL_JUGO").Visible = Value
        End Set
    End Property

    Public Property VerJUGO_CANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("JUGO_CANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("JUGO_CANA").Visible = Value
        End Set
    End Property

    Public Property VerPOL_CANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("POL_CANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("POL_CANA").Visible = Value
        End Set
    End Property

    Public Property VerPUREZA_JUGO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PUREZA_JUGO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PUREZA_JUGO").Visible = Value
        End Set
    End Property

    Public Property VerPUREZA_AZUCAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("PUREZA_AZUCAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PUREZA_AZUCAR").Visible = Value
        End Set
    End Property

    Public Property VerSJM() As Boolean
        Get
            Return Me.dxgvLista.Columns("SJM").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SJM").Visible = Value
        End Set
    End Property

    Public Property VerRENDIA_CALC1() As Boolean
        Get
            Return Me.dxgvLista.Columns("RENDIA_CALC1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RENDIA_CALC1").Visible = Value
        End Set
    End Property

    Public Property VerRENDIA_CALC2() As Boolean
        Get
            Return Me.dxgvLista.Columns("RENDIA_CALC2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RENDIA_CALC2").Visible = Value
        End Set
    End Property

    Public Property VerPOL_LECTURA() As Boolean
        Get
            Return Me.dxgvLista.Columns("POL_LECTURA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("POL_LECTURA").Visible = Value
        End Set
    End Property

    Public Property VerPH() As Boolean
        Get
            Return Me.dxgvLista.Columns("PH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PH").Visible = Value
        End Set
    End Property

    Public Property VerAZUCAR_REDUCTORES() As Boolean
        Get
            Return Me.dxgvLista.Columns("AZUCAR_REDUCTORES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("AZUCAR_REDUCTORES").Visible = Value
        End Set
    End Property

    Public Property VerALMIDON_JUGO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ALMIDON_JUGO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ALMIDON_JUGO").Visible = Value
        End Set
    End Property

    Public Property VerACIDEZ_JUGO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACIDEZ_JUGO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACIDEZ_JUGO").Visible = Value
        End Set
    End Property

    Public Property VerABSORVANCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ABSORVANCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ABSORVANCIA").Visible = Value
        End Set
    End Property

    Public Property VerDEXTRANA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DEXTRANA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DEXTRANA").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_LEE_BAGAZO_BRUTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_LEE_BAGAZO_BRUTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_LEE_BAGAZO_BRUTO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_LEE_BAGAZO_BRUTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_LEE_BAGAZO_BRUTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_LEE_BAGAZO_BRUTO").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_LEE_BAGAZO_TARA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_LEE_BAGAZO_TARA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_LEE_BAGAZO_TARA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_LEE_BAGAZO_TARA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_LEE_BAGAZO_TARA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_LEE_BAGAZO_TARA").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_LEE_POL() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_LEE_POL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_LEE_POL").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_LEE_POL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_LEE_POL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_LEE_POL").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_LEE_BRIX() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_LEE_BRIX").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_LEE_BRIX").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_LEE_BRIX() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_LEE_BRIX").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_LEE_BRIX").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREA").Visible = Value
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

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_ACT").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CT() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CT").Visible = Value
        End Set
    End Property

    Public Property HeaderID_ANALISIS_PRE() As String
        Get
            Return Me.dxgvLista.Columns("ID_ANALISIS_PRE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ANALISIS_PRE").Caption = Value
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

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_ANALISIS() As String
        Get
            Return Me.dxgvLista.Columns("NO_ANALISIS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_ANALISIS").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_MUESTRA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_MUESTRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_MUESTRA").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_MUESTRA() As String
        Get
            Return Me.dxgvLista.Columns("NO_MUESTRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_MUESTRA").Caption = Value
        End Set
    End Property

    Public Property HeaderAREA_MUESTRA() As String
        Get
            Return Me.dxgvLista.Columns("AREA_MUESTRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("AREA_MUESTRA").Caption = Value
        End Set
    End Property

    Public Property HeaderBAGAZO_BRUTO() As String
        Get
            Return Me.dxgvLista.Columns("BAGAZO_BRUTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BAGAZO_BRUTO").Caption = Value
        End Set
    End Property

    Public Property HeaderBAGAZO_NETO() As String
        Get
            Return Me.dxgvLista.Columns("BAGAZO_NETO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BAGAZO_NETO").Caption = Value
        End Set
    End Property

    Public Property HeaderPOL() As String
        Get
            Return Me.dxgvLista.Columns("POL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("POL").Caption = Value
        End Set
    End Property

    Public Property HeaderBRIX() As String
        Get
            Return Me.dxgvLista.Columns("BRIX").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BRIX").Caption = Value
        End Set
    End Property

    Public Property HeaderFIBRA_CANA() As String
        Get
            Return Me.dxgvLista.Columns("FIBRA_CANA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FIBRA_CANA").Caption = Value
        End Set
    End Property

    Public Property HeaderHUMEDAD() As String
        Get
            Return Me.dxgvLista.Columns("HUMEDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("HUMEDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderPOL_JUGO() As String
        Get
            Return Me.dxgvLista.Columns("POL_JUGO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("POL_JUGO").Caption = Value
        End Set
    End Property

    Public Property HeaderJUGO_CANA() As String
        Get
            Return Me.dxgvLista.Columns("JUGO_CANA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("JUGO_CANA").Caption = Value
        End Set
    End Property

    Public Property HeaderPOL_CANA() As String
        Get
            Return Me.dxgvLista.Columns("POL_CANA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("POL_CANA").Caption = Value
        End Set
    End Property

    Public Property HeaderPUREZA_JUGO() As String
        Get
            Return Me.dxgvLista.Columns("PUREZA_JUGO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PUREZA_JUGO").Caption = Value
        End Set
    End Property

    Public Property HeaderPUREZA_AZUCAR() As String
        Get
            Return Me.dxgvLista.Columns("PUREZA_AZUCAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PUREZA_AZUCAR").Caption = Value
        End Set
    End Property

    Public Property HeaderSJM() As String
        Get
            Return Me.dxgvLista.Columns("SJM").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SJM").Caption = Value
        End Set
    End Property

    Public Property HeaderRENDIA_CALC1() As String
        Get
            Return Me.dxgvLista.Columns("RENDIA_CALC1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RENDIA_CALC1").Caption = Value
        End Set
    End Property

    Public Property HeaderRENDIA_CALC2() As String
        Get
            Return Me.dxgvLista.Columns("RENDIA_CALC2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RENDIA_CALC2").Caption = Value
        End Set
    End Property

    Public Property HeaderPOL_LECTURA() As String
        Get
            Return Me.dxgvLista.Columns("POL_LECTURA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("POL_LECTURA").Caption = Value
        End Set
    End Property

    Public Property HeaderPH() As String
        Get
            Return Me.dxgvLista.Columns("PH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PH").Caption = Value
        End Set
    End Property

    Public Property HeaderAZUCAR_REDUCTORES() As String
        Get
            Return Me.dxgvLista.Columns("AZUCAR_REDUCTORES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("AZUCAR_REDUCTORES").Caption = Value
        End Set
    End Property

    Public Property HeaderALMIDON_JUGO() As String
        Get
            Return Me.dxgvLista.Columns("ALMIDON_JUGO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ALMIDON_JUGO").Caption = Value
        End Set
    End Property

    Public Property HeaderACIDEZ_JUGO() As String
        Get
            Return Me.dxgvLista.Columns("ACIDEZ_JUGO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACIDEZ_JUGO").Caption = Value
        End Set
    End Property

    Public Property HeaderABSORVANCIA() As String
        Get
            Return Me.dxgvLista.Columns("ABSORVANCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ABSORVANCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderDEXTRANA() As String
        Get
            Return Me.dxgvLista.Columns("DEXTRANA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DEXTRANA").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_LEE_BAGAZO_BRUTO() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_LEE_BAGAZO_BRUTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_LEE_BAGAZO_BRUTO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_LEE_BAGAZO_BRUTO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_LEE_BAGAZO_BRUTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_LEE_BAGAZO_BRUTO").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_LEE_BAGAZO_TARA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_LEE_BAGAZO_TARA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_LEE_BAGAZO_TARA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_LEE_BAGAZO_TARA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_LEE_BAGAZO_TARA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_LEE_BAGAZO_TARA").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_LEE_POL() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_LEE_POL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_LEE_POL").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_LEE_POL() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_LEE_POL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_LEE_POL").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_LEE_BRIX() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_LEE_BRIX").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_LEE_BRIX").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_LEE_BRIX() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_LEE_BRIX").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_LEE_BRIX").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREA").Caption = Value
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

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CT() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CT").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ANALISIS_PRECOSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorCriterios(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                                            ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, _
                                            ByVal NO_CONTRATO As Int32, ByVal CODIAGRON As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsListaPorCriterios.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsListaPorCriterios.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.odsListaPorCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaPorCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaPorCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorCriterios.SelectParameters("NO_CONTRATO").DefaultValue = NO_CONTRATO
        Me.odsListaPorCriterios.SelectParameters("CODIAGRON").DefaultValue = CODIAGRON
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
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
                keyValues(i) = grid.GetRowValues(i, "ID_ANALISIS_PRE")
                keyNames(i) = grid.GetRowValues(i, "ACCESLOTE")
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
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.CommandArgs.CommandArgument)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        'If e.RowType = DevExpress.Web.GridViewRowType.EditForm Then
        '    Dim btnGuardar As DevExpress.Web.ASPxButton
        '    Dim btnCancelar As DevExpress.Web.ASPxButton
        '    btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
        '    btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
        '    btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        '    btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        'End If
        'If e.RowType = DevExpress.Web.GridViewRowType.EmptyDataRow Then
        '    Dim btnAgregar As DevExpress.Web.ASPxButton
        '    btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
        '    btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        '    btnAgregar.Visible = Me.PermitirAgregarInline
        '    Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
        '    lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
        '    lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        'End If
        If e.RowType = DevExpress.Web.GridViewRowType.Data Then
            If Not Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                lbDetalle.Visible = False
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

    Public Function DevolverSeleccionados() As listaANALISIS_PRECOSECHA
        Dim mLista As New listaANALISIS_PRECOSECHA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ANALISIS_PRE")
            Dim lEntidad As New ANALISIS_PRECOSECHA
            lEntidad.ID_ANALISIS_PRE = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        dxgvLista.JSProperties.Clear()
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ANALISIS_PRECOSECHA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ANALISIS_PRECOSECHA)

            If Me.mComponente.EliminarANALISIS_PRECOSECHA(lEntidad.ID_ANALISIS_PRE) <> 1 Then
                'Si se cometio un error
                dxgvLista.JSProperties.Add("cpMensaje", "Error al Eliminar Registro: " + Me.mComponente.sError)
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
        Dim lEntidadLote As LOTES
        lEntidadLote = (New cLOTES).ObtenerLOTES(e.GetListSourceFieldValue("ACCESLOTE"))

        If lEntidadLote IsNot Nothing Then
            If e.Column.FieldName = "ZONA" Then
                e.Value = lEntidadLote.ZONA
            ElseIf e.Column.FieldName = "SUB_ZONA" Then
                e.Value = lEntidadLote.SUB_ZONA
            ElseIf e.Column.FieldName = "CODIPROVEE" Then
                Dim lProvee As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lEntidadLote.CODIPROVEEDOR)
                If lProvee IsNot Nothing Then
                    e.Value = lProvee.CODIPROVEE
                End If
            ElseIf e.Column.FieldName = "CODISOCIO" Then
                Dim lProvee As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lEntidadLote.CODIPROVEEDOR)
                If lProvee IsNot Nothing Then
                    e.Value = lProvee.CODISOCIO
                End If
            ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
                Dim lProvee As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lEntidadLote.CODIPROVEEDOR)
                If lProvee IsNot Nothing Then
                    e.Value = lProvee.NOMBRES + " " + lProvee.APELLIDOS
                End If
            ElseIf e.Column.FieldName = "CODILOTE" Then
                e.Value = lEntidadLote.CODILOTE
            ElseIf e.Column.FieldName = "NOMBLOTE" Then
                e.Value = lEntidadLote.NOMBLOTE
            ElseIf e.Column.FieldName = "CODI_SUBLOTE" Then
                Dim lSubLote As SUBLOTES = (New cSUBLOTES).ObtenerSUBLOTES(CInt(e.GetListSourceFieldValue("ID_SUBLOTES")))
                If lSubLote IsNot Nothing Then
                    e.Value = lSubLote.CODIGO
                End If
            ElseIf e.Column.FieldName = "NOMBRE_SUBLOTE" Then
                Dim lSubLote As SUBLOTES = (New cSUBLOTES).ObtenerSUBLOTES(CInt(e.GetListSourceFieldValue("ID_SUBLOTES")))
                If lSubLote IsNot Nothing Then
                    e.Value = lSubLote.NOMBRE_PORCION
                End If
            End If
        End If
    End Sub
End Class
