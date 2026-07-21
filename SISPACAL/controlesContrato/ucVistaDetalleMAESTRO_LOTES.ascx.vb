Imports System.Data
Imports DevExpress.Web
Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleMAESTRO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla MAESTRO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleMAESTRO_LOTES
    Inherits ucBase

    Public Event SeleccionadoCanton(ByVal cadCODICANTON As String)

#Region "CargaCatalogos"

    Private Sub ObtenerProveedor()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If Me.txtCODIPROVEE_ML.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.txtCODIPROVEE_ML.Text) Then
            If Me.txtCODISOCIO_ML.Text = "" Then
                Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE_ML.Text) + Utilerias.FormatoCODISOCIO(0)
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
                If lProveedor IsNot Nothing Then
                    Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                End If
            Else
                Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE_ML.Text) + Utilerias.FormatoCODISOCIO(Me.txtCODISOCIO_ML.Text)
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
                If lProveedor IsNot Nothing Then
                    Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                End If
            End If
        End If
    End Sub

    Public Property NombreFormLayoutCliente() As String
        Get
            Return Me.ucVistaDetalleMAESTRO_LOTESLayout.ClientInstanceName
        End Get
        Set(ByVal value As String)
            Me.ucVistaDetalleMAESTRO_LOTESLayout.ClientInstanceName = value
        End Set
    End Property

    Public Property VisibleEnCliente As Boolean
        Set(value As Boolean)
            Dim gl As LayoutGroup = Me.ucVistaDetalleMAESTRO_LOTESLayout.FindItemOrGroupByName("lgVistaDetalleMAESTRO_LOTES")
            If gl IsNot Nothing Then
                gl.ClientVisible = value
            End If
        End Set
        Get
            Dim gl As LayoutGroup = Me.ucVistaDetalleMAESTRO_LOTESLayout.FindItemOrGroupByName("lgVistaDetalleMAESTRO_LOTES")
            If gl IsNot Nothing Then Return gl.ClientVisible
            Return True
        End Get
    End Property


    Private Sub CargarMunicipios()
        Me.odsMunicipio.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO_ML.Value
        Me.odsMunicipio.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsMunicipio.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsMunicipio.SelectParameters("conPresencia").DefaultValue = False
        Me.cbxMUNICIPIO_ML.DataBind()
        Me.cbxMUNICIPIO_ML.Focus()
    End Sub

    Private Sub CargarCantones()
        Me.odsCanton.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO_ML.Value
        Me.odsCanton.SelectParameters("CODI_MUNI").DefaultValue = cbxMUNICIPIO_ML.Value
        Me.odsCanton.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsCanton.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsCanton.SelectParameters("conPresencia").DefaultValue = False
        Me.cbxCANTON_ML.DataBind()
        Me.cbxCANTON_ML.Focus()
    End Sub

    Private Sub CargarTipoRoza()
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Roza, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If cbxTIPO_CANA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.RozaEnTipoCana(CInt(cbxTIPO_CANA.Value))
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxTIPO_ROZA.DataSource = lDestino
        Me.cbxTIPO_ROZA.DataBind()
        Me.cbxTIPO_ROZA.Text = ""
    End Sub

    Private Sub CargarTipoAlza()
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Alza, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If cbxTIPO_CANA.Value IsNot Nothing AndAlso cbxTIPO_ROZA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.AlzaEnTipoCana(CInt(cbxTIPO_CANA.Value), CInt(cbxTIPO_ROZA.Value))
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxTIPO_ALZA.DataSource = lDestino
        Me.cbxTIPO_ALZA.DataBind()
        Me.cbxTIPO_ALZA.Text = ""
    End Sub

    Private Sub CargarTipoTransporte()
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Transporte, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If cbxTIPO_CANA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.TransporteEnTipoCana(CInt(cbxTIPO_CANA.Value))
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxTIPO_TRANS.DataSource = lDestino
        Me.cbxTIPO_TRANS.DataBind()
        Me.cbxTIPO_TRANS.Text = ""
    End Sub
#End Region

    Protected Sub cbxDEPARTAMENTO_ML_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxDEPARTAMENTO_ML.SelectedIndexChanged
        CargarMunicipios()
    End Sub

    Protected Sub cbxMUNICIPIO_ML_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxMUNICIPIO_ML.SelectedIndexChanged
        CargarCantones()
    End Sub

    Protected Sub cbxCANTON_ML_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxCANTON_ML.ValueChanged
        If cbxCANTON_ML.Value IsNot Nothing Then
            Dim lCanton As CANTON
            lCanton = (New cCANTON).ObtenerCANTON(cbxCANTON_ML.Value, Me.cbxDEPARTAMENTO_ML.Value, Me.cbxMUNICIPIO_ML.Value)
            If lCanton IsNot Nothing Then
                Me.txtZONA_ML.Text = lCanton.ZONA
                Me.txtSUB_ZONA_ML.Text = lCanton.SUB_ZONA
                RaiseEvent SeleccionadoCanton(lCanton.CODI_DEPTO + ";" + lCanton.CODI_MUNI + ";" + lCanton.CODI_CANTON)
            End If
        Else
            Me.txtZONA_ML.Text = ""
            Me.txtSUB_ZONA_ML.Text = ""
        End If
    End Sub


    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_MAESTRO") Is Nothing Then Me._ID_MAESTRO = Me.ViewState("ID_MAESTRO")
    End Sub

#Region "Propiedades"

    Private _ID_MAESTRO As Integer
    Public Property ID_MAESTRO() As Integer
        Get
            Return Me.txtID_MAESTRO.Text
        End Get
        Set(ByVal value As Integer)
            Me._ID_MAESTRO = value
            Me.txtID_MAESTRO.Text = CStr(value)
            If Me._ID_MAESTRO <> 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property


    Public Property TabActivo() As Int32
        Get
            Return Me.ASPxPageControl1.ActiveTabIndex
        End Get
        Set(ByVal value As Int32)
            Me.ASPxPageControl1.ActiveTabIndex = value
        End Set
    End Property


    Public Property CODI_DEPTO() As String
        Get
            Return Me.cbxDEPARTAMENTO_ML.Value
        End Get
        Set(ByVal value As String)
            If Not Me.cbxDEPARTAMENTO_ML.Items.FindByValue(value) Is Nothing Then
                Me.cbxDEPARTAMENTO_ML.Value = value
            End If
        End Set
    End Property

    Public Property CODI_MUNI() As String
        Get
            Return Me.cbxMUNICIPIO_ML.Value
        End Get
        Set(ByVal value As String)
            If Not Me.cbxMUNICIPIO_ML.Items.FindByValue(value) Is Nothing Then
                Me.cbxMUNICIPIO_ML.Value = value
            End If
        End Set
    End Property

    Public Property CODI_CANTON() As String
        Get
            Return Me.cbxCANTON_ML.Value
        End Get
        Set(ByVal value As String)
            If Not Me.cbxCANTON_ML.Items.FindByValue(value) Is Nothing Then
                Me.cbxCANTON_ML.Value = value
            End If
        End Set
    End Property

    Public Property CODIPROVEE() As String
        Get
            If Me.txtCODIPROVEE_ML.Value Is Nothing Then
                Return ""
            End If
            Return txtCODIPROVEE_ML.Text
        End Get
        Set(ByVal value As String)
            txtCODIPROVEE_ML.Text = value
        End Set
    End Property

    Public Property CODISOCIO() As String
        Get
            If Me.txtCODISOCIO_ML.Value Is Nothing Then
                Return ""
            End If
            Return txtCODISOCIO_ML.Text
        End Get
        Set(ByVal value As String)
            txtCODISOCIO_ML.Text = value
        End Set
    End Property

    Public Property ZONA() As String
        Get
            Return Me.txtZONA_ML.Text
        End Get
        Set(ByVal value As String)
            Me.txtZONA_ML.Text = value
            Me.hfucVistaDetalleMAESTRO_LOTES("ZONA") = value
        End Set
    End Property

    Public Property SUB_ZONA() As String
        Get
            Return Me.txtSUB_ZONA_ML.Value
        End Get
        Set(ByVal value As String)
            Me.txtSUB_ZONA_ML.Text = value
            Me.hfucVistaDetalleMAESTRO_LOTES("SUB_ZONA") = value
        End Set
    End Property

    Public Property NOMBRE_COMER() As String
        Get
            Return Me.txtNOMBRE_COMER.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_COMER.Text = value.ToString()
        End Set
    End Property

    Public Property CODILOTE_COMER() As String
        Get
            Return Me.txtCODILOTE_COMER.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODILOTE_COMER.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return Me.txtNOMBRE_PROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROVEEDOR.Text = value
            Me.hfucVistaDetalleMAESTRO_LOTES("NOMBRE_PROVEEDOR") = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private _IdLotesCosecha As Int32 = -1
    Private mComponente As New cMAESTRO_LOTES
    Private mEntidad As MAESTRO_LOTES
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla MAESTRO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim lProveedor As PROVEEDOR
        Dim sError As New String("")
        mEntidad = New MAESTRO_LOTES
        mEntidad.ID_MAESTRO = ID_MAESTRO


        If mComponente.ObtenerMAESTRO_LOTES(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.cbxDEPARTAMENTO_ML.Value = mEntidad.CODI_DEPTO
        Me.CargarMunicipios()
        Me.cbxMUNICIPIO_ML.Value = mEntidad.CODI_MUNI
        Me.CargarCantones()
        Me.cbxCANTON_ML.Value = mEntidad.CODI_CANTON
        Me.txtID_MAESTRO.Text = mEntidad.ID_MAESTRO
        Me.txtZONA_ML.Text = mEntidad.ZONA
        Me.txtSUB_ZONA_ML.Text = mEntidad.SUB_ZONA
        Me.txtCUI.Text = mEntidad.CUI
        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
        Me.txtCODIPROVEE_ML.Value = CLng(lProveedor.CODIPROVEE)
        If lProveedor.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
            Me.txtCODISOCIO_ML.Value = Nothing
        Else
            Me.txtCODISOCIO_ML.Value = CLng(lProveedor.CODISOCIO)
        End If
        Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
        Me.txtNOMBRE_COMER.Text = mEntidad.NOMBRE_COMER
        Me.txtHACIENDA.Text = mEntidad.HACIENDA
        Me.txtCODILOTE_COMER.Text = mEntidad.CODILOTE_COMER
        Me.cbxTIPO_DERECHO.Value = mEntidad.TIPO_DERECHO
        If mEntidad.MZ_CULTIVADA = -1 Then Me.txtMZ_CULTIVADA.Text = "" Else Me.txtMZ_CULTIVADA.Text = mEntidad.MZ_CULTIVADA
        Me.cbxVARIEDAD_ML.Value = mEntidad.CODIVARIEDA
        If mEntidad.ID_COMPOR = -1 Then Me.cbxCOMPORTAMIENTO_ML.Value = Nothing Else Me.cbxCOMPORTAMIENTO_ML.Value = mEntidad.ID_COMPOR
        Me.cbxTIPO_SUELO_ML.Value = mEntidad.COD_TIPO_SUELO
        If mEntidad.ID_COND_SIEMBRA = -1 Then Me.cbxCONDICION_SIEMBRA_ML.Value = Nothing Else Me.cbxCONDICION_SIEMBRA_ML.Value = mEntidad.ID_COND_SIEMBRA
        If mEntidad.ID_NIVEL_HUMEDAD = -1 Then Me.cbxNIVEL_HUMEDAD_ML.Value = Nothing Else Me.cbxNIVEL_HUMEDAD_ML.Value = mEntidad.ID_NIVEL_HUMEDAD
        If mEntidad.NO_CORTE = -1 Then Me.txtNO_CORTE.Text = "" Else Me.txtNO_CORTE.Text = mEntidad.NO_CORTE
        If mEntidad.MSNM = -1 Then Me.txtMSNM.Text = "" Else Me.txtMSNM.Text = mEntidad.MSNM
        If mEntidad.KM_CARRETERA = -1 Then Me.txtKMS_CARRETERA.Text = "" Else Me.txtKMS_CARRETERA.Text = mEntidad.KM_CARRETERA
        If mEntidad.KM_TIERRA = -1 Then Me.txtKMS_TIERRA.Text = "" Else Me.txtKMS_TIERRA.Text = mEntidad.KM_TIERRA
        Me.chkRIESGO_PIEDRA.Checked = mEntidad.RIESGO_PIEDRA
        Me.chkREPARA_ACCESO.Checked = mEntidad.REPARA_ACCESO
        Me.chkSIN_ACCESO_PROPIO.Checked = mEntidad.SIN_ACCESO_PROPIO
        Me.dteFECHA_SIEMBRA_ML.Date = mEntidad.FECHA_SIEMBRA
        Me.dteFECHA_CORTE_ML.Date = mEntidad.FECHA_CORTE
        If mEntidad.PROD_TC = -1 Then Me.txtPROD_TC.Text = "" Else Me.txtPROD_TC.Text = mEntidad.PROD_TC
        If mEntidad.PROD_LB = -1 Then Me.txtPROD_LBS.Text = "" Else Me.txtPROD_LBS.Text = mEntidad.PROD_LB
        If mEntidad.FACTOR_DESPOBLA = -1 Then Me.txtPORC_DESPOBLACION.Text = "" Else Me.txtPORC_DESPOBLACION.Text = mEntidad.FACTOR_DESPOBLA
        Me.cbxAGRONOMO.Value = mEntidad.CODIAGRON
        If mEntidad.ID_TIPO_CANA <> -1 Then Me.cbxTIPO_CANA.Value = mEntidad.ID_TIPO_CANA
        Me.CargarTipoRoza()
        If mEntidad.ID_TIPO_ROZA <> -1 Then Me.cbxTIPO_ROZA.Value = mEntidad.ID_TIPO_ROZA
        Me.CargarTipoAlza()
        If mEntidad.ID_TIPO_ALZA <> -1 Then Me.cbxTIPO_ALZA.Value = mEntidad.ID_TIPO_ALZA
        Me.CargarTipoTransporte()
        If mEntidad.ID_TIPO_TRANS <> -1 Then Me.cbxTIPO_TRANS.Value = mEntidad.ID_TIPO_TRANS
        If mEntidad.TARIFA_ROZA <> -1D Then Me.speTARIFA_ROZA.Value = mEntidad.TARIFA_ROZA Else Me.speTARIFA_ROZA.Value = 0
        If mEntidad.TARIFA_ALZA <> -1D Then Me.speTARIFA_ALZA.Value = mEntidad.TARIFA_ALZA Else Me.speTARIFA_ALZA.Value = 0
        If mEntidad.TARIFA_TRANS <> -1D Then Me.speTARIFA_TRANS.Value = mEntidad.TARIFA_TRANS Else Me.speTARIFA_TRANS.Value = 0
        If mEntidad.TARIFA_CORTA <> -1D Then Me.speTARIFA_CORTA.Value = mEntidad.TARIFA_CORTA Else Me.speTARIFA_CORTA.Value = 0
        If mEntidad.TARIFA_LARGA <> -1D Then Me.speTARIFA_LARGA.Value = mEntidad.TARIFA_LARGA Else Me.speTARIFA_LARGA.Value = 0
        If mEntidad.TARIFA_LARGA_T3S3 <> -1D Then Me.speTARIFA_LARGA_T3S3.Value = mEntidad.TARIFA_LARGA_T3S3 Else Me.speTARIFA_LARGA_T3S3.Value = 0


        'Obtener informaciÃ³n de LOTES_COSECHA para el lote actual donde FIN_LOTE sea False
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If Not Me.ViewState("IdLotesCosecha") Is Nothing Then Me.ViewState.Remove("IdLotesCosecha")

        Dim lLotesCosecha As listaLOTES_COSECHA = (New cLOTES_COSECHA).ObtenerUltimaCosechaPorLOTE_FinLote(mEntidad.ID_MAESTRO, "", lZafraActiva.ID_ZAFRA)
        If lLotesCosecha IsNot Nothing AndAlso lLotesCosecha.Count > 0 Then
            Me.speMZ_ENTREGAR.Value = lLotesCosecha(0).MZ_ENTREGAR
            Me.speTONEL_MZ_ENTREGAR.Value = lLotesCosecha(0).TONEL_MZ_ENTREGAR
            Me.speTONEL_ENTREGAR.Value = lLotesCosecha(0).TONEL_ENTREGAR
            Me.cbxAGRONOMO.Value = lLotesCosecha(0).CODIAGRON
            Me._IdLotesCosecha = lLotesCosecha(0).ID_LOTES_COSECHA
            Me.ViewState.Add("IdLotesCosecha", Me._IdLotesCosecha)
            Dim g As DevExpress.Web.LayoutItemBase = Me.frlCosecha.FindItemOrGroupByName("gbInformacionCosecha")
            If g IsNot Nothing Then
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(lLotesCosecha(0).ID_ZAFRA)
                g.Caption = "Informacion de Cosecha de la Zafra " + lZafra.NOMBRE_ZAFRA
                g.ShowCaption = DevExpress.Utils.DefaultBoolean.True
            End If
        Else
            'Obtener informaciÃ³n de la Ãºltima zafra en la que se contrato
            lLotesCosecha = (New cLOTES_COSECHA).ObtenerUltimaCosechaPorLOTE_FinLote(mEntidad.ID_MAESTRO, "C")
            If lLotesCosecha IsNot Nothing AndAlso lLotesCosecha.Count > 0 Then
                Me.speMZ_ENTREGAR.Value = lLotesCosecha(0).MZ_ENTREGAR
                Me.speTONEL_MZ_ENTREGAR.Value = lLotesCosecha(0).TONEL_MZ_ENTREGAR
                Me.speTONEL_ENTREGAR.Value = lLotesCosecha(0).TONEL_ENTREGAR

                Dim g As DevExpress.Web.LayoutItemBase = Me.frlCosecha.FindItemOrGroupByName("gbInformacionCosecha")
                If g IsNot Nothing Then
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(lLotesCosecha(0).ID_ZAFRA)
                    g.Caption = "Informacion de Cosecha de la Zafra " + lZafra.NOMBRE_ZAFRA
                    g.ShowCaption = DevExpress.Utils.DefaultBoolean.True
                End If
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Dim lPerfil As PERFIL = (New cPERFIL).ObtenerPERFILPorUsuario(Me.ObtenerUsuario)
        Dim esAdmin As Boolean = False

        If lPerfil IsNot Nothing AndAlso (lPerfil.NOMBRE_PERFIL.ToLower = "administrador" OrElse
            Me.ObtenerUsuario.ToLower = "ricardo" OrElse Me.ObtenerUsuario.ToLower = "alexandra") Then esAdmin = True

        Me.txtCUI.Enabled = False
        Me.cbxDEPARTAMENTO_ML.Enabled = edicion
        Me.cbxMUNICIPIO_ML.Enabled = edicion
        Me.cbxCANTON_ML.Enabled = edicion
        Me.txtZONA_ML.Enabled = edicion
        Me.txtSUB_ZONA_ML.Enabled = edicion
        Me.txtCODIPROVEE_ML.Enabled = Me._nuevo OrElse esAdmin
        Me.txtCODISOCIO_ML.Enabled = Me._nuevo OrElse esAdmin
        Me.txtNOMBRE_PROVEEDOR.Enabled = False
        Me.txtHACIENDA.Enabled = edicion
        Me.txtNOMBRE_COMER.Enabled = edicion
        Me.txtCODILOTE_COMER.Enabled = edicion
        Me.txtMZ_CULTIVADA.Enabled = edicion
        Me.cbxVARIEDAD_ML.Enabled = edicion
        Me.cbxCOMPORTAMIENTO_ML.Enabled = edicion
        Me.cbxTIPO_SUELO_ML.Enabled = edicion
        Me.cbxCONDICION_SIEMBRA_ML.Enabled = edicion
        Me.cbxNIVEL_HUMEDAD_ML.Enabled = edicion
        Me.txtNO_CORTE.Enabled = edicion
        Me.txtMSNM.Enabled = edicion
        Me.txtKMS_CARRETERA.Enabled = edicion
        Me.txtKMS_TIERRA.Enabled = edicion
        Me.chkRIESGO_PIEDRA.Enabled = edicion
        Me.chkREPARA_ACCESO.Enabled = edicion
        Me.chkSIN_ACCESO_PROPIO.Enabled = edicion
        Me.dteFECHA_SIEMBRA_ML.Enabled = edicion
        Me.dteFECHA_CORTE_ML.Enabled = edicion
        Me.txtPROD_TC.Enabled = edicion
        Me.txtPROD_LBS.Enabled = edicion
        Me.txtPORC_DESPOBLACION.Enabled = edicion
        Me.cbxTIPO_DERECHO.Enabled = edicion
        Me.speMZ_ENTREGAR.Enabled = Not Me._nuevo AndAlso edicion
        Me.speTONEL_MZ_ENTREGAR.Enabled = Not Me._nuevo AndAlso edicion
        Me.speTONEL_ENTREGAR.Enabled = False
        Me.cbxTIPO_ROZA.Enabled = edicion
        Me.cbxTIPO_ALZA.Enabled = edicion
        Me.cbxTIPO_TRANS.Enabled = edicion
        Me.speMZ_ENTREGAR.Enabled = edicion AndAlso Me._IdLotesCosecha > 0
        Me.speTONEL_MZ_ENTREGAR.Enabled = edicion AndAlso Me._IdLotesCosecha > 0
        Me.speTONEL_ENTREGAR.Enabled = False
        Me.speTARIFA_TRANS.Enabled = edicion
        Me.speTARIFA_CORTA.Enabled = edicion
        Me.speTARIFA_LARGA.Enabled = edicion
        Me.speTARIFA_LARGA_T3S3.Enabled = edicion
        Me.ASPxPageControl1.ActiveTabIndex = 0
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtCUI.Text = ""
        Me.cbxDEPARTAMENTO_ML.SelectedIndex = -1
        Me.cbxMUNICIPIO_ML.SelectedIndex = -1
        Me.cbxCANTON_ML.SelectedIndex = -1
        Me.txtZONA_ML.Text = ""
        Me.txtSUB_ZONA_ML.Text = ""
        Me.txtCODIPROVEE_ML.Text = ""
        Me.txtCODISOCIO_ML.Text = ""
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtHACIENDA.Text = ""
        Me.txtNOMBRE_COMER.Text = ""
        Me.txtCODILOTE_COMER.Text = ""
        Me.txtMZ_CULTIVADA.Text = ""
        Me.cbxVARIEDAD_ML.Value = Nothing
        Me.cbxCOMPORTAMIENTO_ML.SelectedIndex = -1
        Me.cbxTIPO_SUELO_ML.SelectedIndex = -1
        Me.cbxCONDICION_SIEMBRA_ML.SelectedIndex = -1
        Me.cbxNIVEL_HUMEDAD_ML.SelectedIndex = -1
        Me.txtNO_CORTE.Text = ""
        Me.txtMSNM.Text = ""
        Me.txtKMS_CARRETERA.Text = ""
        Me.txtKMS_TIERRA.Text = ""
        Me.chkRIESGO_PIEDRA.Checked = False
        Me.chkREPARA_ACCESO.Checked = False
        Me.chkSIN_ACCESO_PROPIO.Checked = False
        Me.dteFECHA_SIEMBRA_ML.Value = Nothing
        Me.dteFECHA_CORTE_ML.Value = Nothing
        Me.txtPROD_TC.Text = ""
        Me.txtPROD_LBS.Text = ""
        Me.txtPORC_DESPOBLACION.Text = ""
        Me.cbxTIPO_DERECHO.Value = Nothing
        Me.speTARIFA_TRANS.Value = Nothing
        Me.speTARIFA_CORTA.Value = Nothing
        Me.speTARIFA_LARGA.Value = Nothing
        Me.speTARIFA_LARGA_T3S3.Value = Nothing
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla MAESTRO_LOTES
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim lRet As Int32
        Dim alDatos As New ArrayList
        Dim lZona As ZONAS
        mEntidad = New MAESTRO_LOTES

        If Me._nuevo Then
            mEntidad.ID_MAESTRO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad.ID_SUBLOTES = -1
            mEntidad.ESTADO = "A"
        Else
            mEntidad = mComponente.ObtenerMAESTRO_LOTES(CInt(Me.txtID_MAESTRO.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.CODI_DEPTO = Me.cbxDEPARTAMENTO_ML.Value
        mEntidad.CODI_MUNI = Me.cbxMUNICIPIO_ML.Value
        mEntidad.CODI_CANTON = Me.cbxCANTON_ML.Value

        If Me.txtSUB_ZONA_ML.Text = "" Then
            Return "No se ha asignado SUB ZONA"
        End If
        If Me.txtZONA_ML.Text = "" Then
            Return "No se ha asignado ZONA"
        End If
        lZona = (New cZONAS).ObtenerZONAS(Me.txtZONA_ML.Text)
        If lZona Is Nothing Then
            Return "No existe la ZONA asignada"
        Else
            Dim lSubZona As SUB_ZONAS = (New cSUB_ZONAS).ObtenerSUB_ZONAS(lZona.ZONA, Me.txtSUB_ZONA_ML.Text)
            If lSubZona Is Nothing Then
                Return "No existe la SUB ZONA asignada"
            End If
        End If
        mEntidad.ZONA = Me.txtZONA_ML.Text
        If Not IsNumeric(txtCODISOCIO_ML.Value) Then
            mEntidad.CODIPROVEEDOR = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE_ML.Value) + Utilerias.FormatoCODISOCIO(0)
        Else
            mEntidad.CODIPROVEEDOR = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE_ML.Value) + Utilerias.FormatoCODISOCIO(txtCODISOCIO_ML.Value)
        End If
        mEntidad.SUB_ZONA = Me.txtSUB_ZONA_ML.Value
        mEntidad.NOMBRE_COMER = Me.txtNOMBRE_COMER.Text.Trim.ToUpper
        mEntidad.CODILOTE_COMER = Me.txtCODILOTE_COMER.Text.Trim.ToUpper
        mEntidad.TIPO_DERECHO = Me.cbxTIPO_DERECHO.Value
        mEntidad.MZ_CULTIVADA = Me.txtMZ_CULTIVADA.Text
        mEntidad.CODIVARIEDA = Me.cbxVARIEDAD_ML.Value
        mEntidad.HACIENDA = Me.txtHACIENDA.Text.Trim.ToUpper
        If Me.cbxCOMPORTAMIENTO_ML.Value = 0 Then mEntidad.ID_COMPOR = -1 Else mEntidad.ID_COMPOR = Me.cbxCOMPORTAMIENTO_ML.Value
        mEntidad.COD_TIPO_SUELO = Me.cbxTIPO_SUELO_ML.Value
        If Me.cbxCONDICION_SIEMBRA_ML.Value = 0 Then mEntidad.ID_COND_SIEMBRA = -1 Else mEntidad.ID_COND_SIEMBRA = Me.cbxCONDICION_SIEMBRA_ML.Value
        If Me.cbxNIVEL_HUMEDAD_ML.Value = 0 Then mEntidad.ID_NIVEL_HUMEDAD = -1 Else mEntidad.ID_NIVEL_HUMEDAD = Me.cbxNIVEL_HUMEDAD_ML.Value
        mEntidad.NO_CORTE = Me.txtNO_CORTE.Value
        If Me.txtMSNM.Text = "" Then mEntidad.MSNM = -1 Else mEntidad.MSNM = Me.txtMSNM.Value
        If Me.txtKMS_CARRETERA.Text = "" Then mEntidad.KM_CARRETERA = 0 Else mEntidad.KM_CARRETERA = Me.txtKMS_CARRETERA.Value
        If Me.txtKMS_TIERRA.Text = "" Then mEntidad.KM_TIERRA = 0 Else mEntidad.KM_TIERRA = Me.txtKMS_TIERRA.Value
        mEntidad.RIESGO_PIEDRA = chkRIESGO_PIEDRA.Checked
        mEntidad.REPARA_ACCESO = Me.chkREPARA_ACCESO.Checked
        mEntidad.SIN_ACCESO_PROPIO = Me.chkSIN_ACCESO_PROPIO.Checked
        mEntidad.FECHA_SIEMBRA = dteFECHA_SIEMBRA_ML.Date
        mEntidad.FECHA_CORTE = dteFECHA_CORTE_ML.Date
        If Me.txtPROD_TC.Text = "" Then mEntidad.PROD_TC = -1 Else mEntidad.PROD_TC = Me.txtPROD_TC.Value
        If Me.txtPROD_LBS.Text = "" Then mEntidad.PROD_LB = -1 Else mEntidad.PROD_LB = Me.txtPROD_LBS.Value
        If Me.txtPORC_DESPOBLACION.Text = "" Then mEntidad.FACTOR_DESPOBLA = -1 Else mEntidad.FACTOR_DESPOBLA = Me.txtPORC_DESPOBLACION.Value
        mEntidad.CODICONTRATO = -1
        If Me.cbxAGRONOMO.Value Is Nothing OrElse Me.cbxAGRONOMO.Value = "" Then
            Return "Asigne el Tecnico encargado del Lote"
        End If
        mEntidad.CODIAGRON = Me.cbxAGRONOMO.Value
        mEntidad.ID_TIPO_CANA = Me.cbxTIPO_CANA.Value
        mEntidad.ID_TIPO_ROZA = Me.cbxTIPO_ROZA.Value
        mEntidad.ID_TIPO_ALZA = Me.cbxTIPO_ALZA.Value
        mEntidad.ID_TIPO_TRANS = Me.cbxTIPO_TRANS.Value


        If dteFECHA_SIEMBRA_ML.Value Is Nothing Then
            Me.ASPxPageControl1.ActiveTabIndex = 1
            Return "Ingrese la fecha de siembra"
        End If
        If dteFECHA_CORTE_ML.Value Is Nothing Then
            Me.ASPxPageControl1.ActiveTabIndex = 1
            Return "Ingrese la fecha de roza"
        End If
        If speMZ_ENTREGAR.Enabled AndAlso speMZ_ENTREGAR.Text = "" Then
            Me.ASPxPageControl1.ActiveTabIndex = 1
            Return "Ingrese las MZ a entregar"
        End If
        If speTONEL_MZ_ENTREGAR.Enabled AndAlso speTONEL_MZ_ENTREGAR.Text = "" Then
            Me.ASPxPageControl1.ActiveTabIndex = 1
            Return "Ingrese las TC/MZ a entregar"
        End If

        If cbxTIPO_CANA.Value Is Nothing OrElse cbxTIPO_CANA.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese el Tipo de Cana"
            mEntidad.ID_TIPO_CANA = -1
        Else
            mEntidad.ID_TIPO_CANA = cbxTIPO_CANA.Value
        End If
        If cbxTIPO_ROZA.Value Is Nothing OrElse cbxTIPO_ROZA.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese el Tipo de Roza"
            mEntidad.ID_TIPO_ROZA = -1
        Else
            mEntidad.ID_TIPO_ROZA = cbxTIPO_ROZA.Value
        End If
        If cbxTIPO_ALZA.Value Is Nothing OrElse cbxTIPO_ALZA.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese el Tipo de Alza"
            mEntidad.ID_TIPO_ALZA = -1
        Else
            mEntidad.ID_TIPO_ALZA = cbxTIPO_ALZA.Value
        End If
        If cbxTIPO_TRANS.Value Is Nothing OrElse cbxTIPO_TRANS.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese el Tipo de Transporte"
            mEntidad.ID_TIPO_TRANS = -1
        Else
            mEntidad.ID_TIPO_TRANS = cbxTIPO_TRANS.Value
        End If

        If speTARIFA_ROZA.Value Is Nothing OrElse speTARIFA_ROZA.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese la Tarifa de Roza"
            mEntidad.TARIFA_ROZA = -1
        Else
            mEntidad.TARIFA_ROZA = speTARIFA_ROZA.Value
        End If
        If speTARIFA_ALZA.Value Is Nothing OrElse speTARIFA_ALZA.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese la Tarifa de Alza"
            mEntidad.TARIFA_ALZA = -1
        Else
            mEntidad.TARIFA_ALZA = speTARIFA_ALZA.Value
        End If
        If speTARIFA_TRANS.Value Is Nothing OrElse speTARIFA_TRANS.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese la Tarifa de Transporte"
            mEntidad.TARIFA_TRANS = -1
        Else
            mEntidad.TARIFA_TRANS = speTARIFA_TRANS.Value
        End If
        If speTARIFA_CORTA.Value Is Nothing OrElse speTARIFA_CORTA.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese la Tarifa Corta de Transporte"
            mEntidad.TARIFA_CORTA = -1
        Else
            mEntidad.TARIFA_CORTA = speTARIFA_CORTA.Value
        End If
        If speTARIFA_LARGA.Value Is Nothing OrElse speTARIFA_LARGA.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese la Tarifa Larga de Transporte"
            mEntidad.TARIFA_LARGA = -1
        Else
            mEntidad.TARIFA_LARGA = speTARIFA_LARGA.Value
        End If
        If speTARIFA_LARGA_T3S3.Value Is Nothing OrElse speTARIFA_LARGA_T3S3.Value = 0 Then
            'Me.ASPxPageControl1.ActiveTabIndex = 2
            'Return "Ingrese la Tarifa Larga de Transporte"
            mEntidad.TARIFA_LARGA_T3S3 = -1
        Else
            mEntidad.TARIFA_LARGA_T3S3 = speTARIFA_LARGA_T3S3.Value
        End If

        If mComponente.ActualizarMAESTRO_LOTES(mEntidad) <> 1 Then
            Return "Error al Guardar registro: " + mComponente.sError
        End If
        If Me.ViewState("IdLotesCosecha") IsNot Nothing AndAlso Me.ViewState("IdLotesCosecha") > 0 Then
            Dim bLotesCosecha As New cLOTES_COSECHA
            Dim lLotesCosecha As LOTES_COSECHA = bLotesCosecha.ObtenerLOTES_COSECHA(Me.ViewState("IdLotesCosecha"))
            If lLotesCosecha IsNot Nothing Then
                lLotesCosecha.FECHA_ROZA = dteFECHA_CORTE_ML.Date
                lLotesCosecha.FECHA_SIEMBRA = dteFECHA_SIEMBRA_ML.Date
                lLotesCosecha.EDAD_LOTE = mEntidad.NO_CORTE
                lLotesCosecha.CODIAGRON = Me.cbxAGRONOMO.Value
                lLotesCosecha.ID_TIPO_CANA = mEntidad.ID_TIPO_CANA
                lLotesCosecha.ID_TIPO_ROZA = mEntidad.ID_TIPO_ROZA
                lLotesCosecha.ID_TIPO_ALZA = mEntidad.ID_TIPO_ALZA
                lLotesCosecha.ID_TIPO_TRANS = mEntidad.ID_TIPO_TRANS
                lLotesCosecha.TARIFA_ROZA = mEntidad.TARIFA_ROZA
                lLotesCosecha.TARIFA_ALZA = mEntidad.TARIFA_ALZA
                lLotesCosecha.TARIFA_TRANS = mEntidad.TARIFA_TRANS
                lLotesCosecha.TARIFA_CORTA = mEntidad.TARIFA_CORTA
                lLotesCosecha.TARIFA_LARGA = mEntidad.TARIFA_LARGA
                lRet = bLotesCosecha.ActualizarLOTES_COSECHA(lLotesCosecha)
                If lRet < 0 Then
                    Return bLotesCosecha.sError
                End If
            End If
        End If

        Me.txtCUI.Text = mEntidad.CUI.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub txtCODIPROVEE_ML_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE_ML.ValueChanged
        Me.ObtenerProveedor()
    End Sub

    Protected Sub txtCODISOCIO_ML_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODISOCIO_ML.ValueChanged
        Me.ObtenerProveedor()
    End Sub

    Protected Sub cbxTIPO_CANA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxTIPO_CANA.ValueChanged
        Me.CargarTipoRoza()
        Me.CargarTipoAlza()
        Me.CargarTipoTransporte()
    End Sub

    Protected Sub cbxTIPO_ROZA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxTIPO_ROZA.ValueChanged
        Me.CargarTipoAlza()
    End Sub

    Private Sub CalcularToneladas()
        Dim lTonel As Decimal = 0
        If speMZ_ENTREGAR.Text <> "" AndAlso speTONEL_MZ_ENTREGAR.Text <> "" Then
            lTonel = CDec(speMZ_ENTREGAR.Value) * CDec(speTONEL_MZ_ENTREGAR.Value)
        End If
        Me.speTONEL_ENTREGAR.Value = lTonel
    End Sub

    Protected Sub speMZ_ENTREGAR_ValueChanged(sender As Object, e As System.EventArgs) Handles speMZ_ENTREGAR.ValueChanged
        Me.CalcularToneladas()
    End Sub

    Protected Sub speTONEL_MZ_ENTREGAR_ValueChanged(sender As Object, e As System.EventArgs) Handles speTONEL_MZ_ENTREGAR.ValueChanged
        Me.CalcularToneladas()
    End Sub

    Private Sub txtKMS_CARRETERA_ValueChanged(sender As Object, e As EventArgs) Handles txtKMS_CARRETERA.ValueChanged
        Dim kms As Decimal = 0

        If txtKMS_CARRETERA.Value IsNot Nothing Then
            kms = Convert.ToDecimal(txtKMS_CARRETERA.Value)
        End If
        AsignarTarifaFlete(kms)
    End Sub

    Private Sub AsignarTarifaFlete(ByVal kms As Decimal)
        Dim bMaestro As New cMAESTRO_LOTES
        Dim ds As DataSet

        ds = bMaestro.ObtenerRangoFlete(kms)
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            Me.speTARIFA_CORTA.Value = ds.Tables(0).Rows(0)("TARIFA_COSECHA")
            Me.speTARIFA_LARGA.Value = ds.Tables(0).Rows(0)("TARIFA_LARGA_CAMION")
            Me.speTARIFA_LARGA_T3S3.Value = ds.Tables(0).Rows(0)("TARIFA_LARGA_T3S3")
        Else
            Me.speTARIFA_CORTA.Value = 0
            Me.speTARIFA_LARGA.Value = 0
            Me.speTARIFA_LARGA_T3S3.Value = 0
        End If
    End Sub
End Class
