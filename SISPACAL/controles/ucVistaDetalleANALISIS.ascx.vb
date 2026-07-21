Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleANALISIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ANALISIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleANALISIS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ANALISIS As Int32
    Public Property ID_ANALISIS() As Int32
        Get
            Return Convert.ToInt32(Me.txtID_ANALISIS.Text)
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ANALISIS = Value
            Me.txtID_ANALISIS.Text = CStr(Value)
            If Me._ID_ANALISIS > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property TIPO_OPERACION As TipoOperacion
        Get
            If Me.ViewState("TIPO_OPERACION") Is Nothing Then
                Return TipoOperacion.Recepcion
            Else
                Return Me.ViewState("TIPO_OPERACION")
            End If
        End Get
        Set(ByVal value As TipoOperacion)
            Me.ViewState("TIPO_OPERACION") = value
            If value = TipoOperacion.Edicion OrElse value = TipoOperacion.Consulta Then
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(False)
            End If
            Me.txtNROBOLETA.Focus()
        End Set
    End Property

    Public Property BAGAZO_BRUTO() As Decimal
        Get
            If Me.txtBAGAZO_BRUTO.Text ="" Then Return -1
            Return Me.txtBAGAZO_BRUTO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtBAGAZO_BRUTO.Text = value.ToString()
        End Set
    End Property

    Public Property BAGAZO_NETO() As Decimal
        Get
            If Me.txtBAGAZO_NETO.Text ="" Then Return -1
            Return Me.txtBAGAZO_NETO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtBAGAZO_NETO.Text = value.ToString()
        End Set
    End Property

    Public Property POL() As Decimal
        Get
            If Me.txtPOL.Text ="" Then Return -1
            Return Me.txtPOL.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPOL.Text = value.ToString()
        End Set
    End Property

    Public Property BRIX() As Decimal
        Get
            If Me.txtBRIX.Text ="" Then Return -1
            Return Me.txtBRIX.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtBRIX.Text = value.ToString()
        End Set
    End Property

    Public Property MOSTRAR_RENDIMIENTOS As Boolean
        Get
            If Me.ViewState("MOSTRAR_RENDIMIENTOS") IsNot Nothing Then
                Return True
            Else
                Return Me.ViewState("MOSTRAR_RENDIMIENTOS")
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("MOSTRAR_RENDIMIENTOS") = value
        End Set
    End Property



    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cANALISIS
    Private mEntidad As ANALISIS
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

    Public Property ControlFoco As Object
        Get
            If Session("ControlFoco") IsNot Nothing Then
                Return Session("ControlFoco")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Object)
            Session("ControlFoco") = value
        End Set
    End Property


#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ANALISIS") Is Nothing Then Me._ID_ANALISIS = Me.ViewState("ID_ANALISIS")

        If Not IsPostBack Then
            Dim cPerfil As New cPERFIL
            Dim lPerfil As PERFIL = cPerfil.ObtenerPERFILPorUsuario(Me.ObtenerUsuario)

            If lPerfil IsNot Nothing AndAlso lPerfil.NOMBRE_PERFIL = "Administrador" Then
                Me.tblRESULTADO_FORMULAS.Visible = True
            Else
                Me.tblRESULTADO_FORMULAS.Visible = False
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ANALISIS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ANALISIS
        mEntidad.ID_ANALISIS = ID_ANALISIS
        If mComponente.ObtenerANALISIS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        Dim listaDatosLab As listaDATOS_LABORATORIO
        Dim lEnvio As ENVIO = (New cENVIO).ObtenerENVIO(mEntidad.ID_ENVIO)
        If lEnvio IsNot Nothing Then
            ddlZAFRAID_ZAFRA.Recuperar()
            ddlZAFRAID_ZAFRA.SelectedValue = lEnvio.ID_ZAFRA
            txtCATORCENA_ZAFRA.Text = lEnvio.CATORCENA.ToString
            txtDIAZAFRA.Text = lEnvio.DIAZAFRA.ToString
        End If
        txtID_ANALISIS.Text = mEntidad.ID_ANALISIS
        txtID_ENVIO.Text = mEntidad.ID_ENVIO
        If mEntidad.BAGAZO_BRUTO <> -1 Then txtBAGAZO_BRUTO.Text = mEntidad.BAGAZO_BRUTO.ToString("#,##0.00") Else txtBAGAZO_BRUTO.Text = ""
        If mEntidad.BAGAZO_NETO <> -1 Then txtBAGAZO_NETO.Text = mEntidad.BAGAZO_NETO.ToString("#,##0.00") Else txtBAGAZO_NETO.Text = ""
        If mEntidad.POL <> -1 Then txtPOL.Text = mEntidad.POL.ToString("#,##0.00") Else txtPOL.Text = ""
        If mEntidad.POL_LECTURA <> -1 Then txtPOL_LECTURA.Text = mEntidad.POL_LECTURA.ToString("#,##0.00") Else txtPOL_LECTURA.Text = ""
        If mEntidad.BRIX <> -1 Then txtBRIX.Text = mEntidad.BRIX.ToString("#,##0.00") Else txtBRIX.Text = ""

        If mEntidad.FIBRA_CANA <> -1 Then lblFIBRA_CANA.Text = mEntidad.FIBRA_CANA.ToString("#,##0.000000") Else lblFIBRA_CANA.Text = ""
        If mEntidad.JUGO_CANA <> -1 Then lblJUGO_CANA.Text = mEntidad.JUGO_CANA.ToString("#,##0.000000") Else lblJUGO_CANA.Text = ""
        If mEntidad.POL_CANA <> -1 Then lblPOL_CANA.Text = mEntidad.POL_CANA.ToString("#,##0.000000") Else lblPOL_CANA.Text = ""
        If mEntidad.PUREZA_JUGO <> -1 Then lblPUREZA_JUGO.Text = mEntidad.PUREZA_JUGO.ToString("#,##0.000000") Else lblPUREZA_JUGO.Text = ""
        If mEntidad.PUREZA_AZUCAR <> -1 Then lblPUREZA_AZUCAR.Text = mEntidad.PUREZA_AZUCAR.ToString("#,##0.000000") Else lblPUREZA_AZUCAR.Text = ""
        If mEntidad.SJM <> -1 Then lblSJM.Text = mEntidad.SJM.ToString("#,##0.000000") Else lblSJM.Text = ""
        If mEntidad.HUMEDAD <> -1 Then lblHUMEDAD.Text = mEntidad.HUMEDAD.ToString("#,##0.000000") Else lblHUMEDAD.Text = ""
        If mEntidad.RENDIA_CALC1 <> -1 Then lblRENDIA_CALC1.Text = mEntidad.RENDIA_CALC1.ToString("#,##0.00") Else lblRENDIA_CALC1.Text = ""
        If mEntidad.RENDIA_CALC2 <> -1 Then lblRENDIA_CALC2.Text = mEntidad.RENDIA_CALC2.ToString("#,##0.00") Else lblRENDIA_CALC2.Text = ""
        If mEntidad.PH <> -1 Then txtPH.Text = mEntidad.PH.ToString("#,##0.00") Else txtPH.Text = ""
        If mEntidad.AZUCAR_REDUCTORES <> -1 Then lblAZUCAR_REDUCTORES.Text = mEntidad.AZUCAR_REDUCTORES.ToString("#,##0.00") Else lblAZUCAR_REDUCTORES.Text = ""

        'Me.txtUSUARIO_LEE_BAGAZO_BRUTO.Text = mEntidad.USUARIO_LEE_BAGAZO_BRUTO
        'Me.txtFECHA_LEE_BAGAZO_BRUTO.Text = IIf(Not mEntidad.FECHA_LEE_BAGAZO_BRUTO = Nothing, Format(mEntidad.FECHA_LEE_BAGAZO_BRUTO, "dd/MM/yyyy"), "")
        'Me.txtUSUARIO_LEE_BAGAZO_TARA.Text = mEntidad.USUARIO_LEE_BAGAZO_TARA
        'Me.txtFECHA_LEE_BAGAZO_TARA.Text = IIf(Not mEntidad.FECHA_LEE_BAGAZO_TARA = Nothing, Format(mEntidad.FECHA_LEE_BAGAZO_TARA, "dd/MM/yyyy"), "")
        'Me.txtUSUARIO_LEE_POL.Text = mEntidad.USUARIO_LEE_POL
        'Me.txtFECHA_LEE_POL.Text = IIf(Not mEntidad.FECHA_LEE_POL = Nothing, Format(mEntidad.FECHA_LEE_POL, "dd/MM/yyyy"), "")
        'Me.txtUSUARIO_LEE_BRIX.Text = mEntidad.USUARIO_LEE_BRIX
        'Me.txtFECHA_LEE_BRIX.Text = IIf(Not mEntidad.FECHA_LEE_BRIX = Nothing, Format(mEntidad.FECHA_LEE_BRIX, "dd/MM/yyyy"), "")

        listaDatosLab = (New cDATOS_LABORATORIO).ObtenerListaPorANALISIS(mEntidad.ID_ANALISIS)
        If listaDatosLab IsNot Nothing AndAlso listaDatosLab.Count > 0 Then
            Dim lDatosLab As DATOS_LABORATORIO = listaDatosLab(0)

            If lDatosLab.ABSORVANCIA <> -1 Then txtABSORVANCIA.Text = lDatosLab.ABSORVANCIA.ToString("#,##0.000") Else txtABSORVANCIA.Text = ""
            If lDatosLab.DEXTRANA <> -1 Then txtDEXTRANA.Text = lDatosLab.DEXTRANA.ToString("#,##0.00") Else txtDEXTRANA.Text = ""
            txtANALISTA.Text = lDatosLab.ANALISTA
            If lDatosLab.LBS_MUESTRA <> -1 Then txtLBS_MUESTRA.Text = lDatosLab.LBS_MUESTRA.ToString("#,##0.00") Else txtLBS_MUESTRA.Text = ""
            If lDatosLab.LBS_PUNTAS_TIERNA <> -1 Then txtLBS_PUNTAS_TIERNA.Text = lDatosLab.LBS_PUNTAS_TIERNA.ToString("#,##0.00") Else txtLBS_PUNTAS_TIERNA.Text = ""
            If lDatosLab.LBS_CANA_SECA <> -1 Then txtLBS_CANA_SECA.Text = lDatosLab.LBS_CANA_SECA.ToString("#,##0.00") Else txtLBS_CANA_SECA.Text = ""
            If lDatosLab.LBS_MAMONES <> -1 Then txtLBS_MAMONES.Text = lDatosLab.LBS_MAMONES.ToString("#,##0.00") Else txtLBS_MAMONES.Text = ""
            If lDatosLab.LBS_BAJERA <> -1 Then txtLBS_BAJERA.Text = lDatosLab.LBS_BAJERA.ToString("#,##0.00") Else txtLBS_BAJERA.Text = ""
            If lDatosLab.LBS_TIERRA_RAICES <> -1 Then txtLBS_TIERRA_RAICES.Text = lDatosLab.LBS_TIERRA_RAICES.ToString("#,##0.00") Else txtLBS_TIERRA_RAICES.Text = ""
            If lDatosLab.LBS_PIEDRA <> -1 Then txtLBS_PIEDRA.Text = lDatosLab.LBS_PIEDRA.ToString("#,##0.00") Else txtLBS_PIEDRA.Text = ""
            If lDatosLab.LBS_CANA_LIMPIA <> -1 Then txtLBS_CANA_LIMPIA.Text = lDatosLab.LBS_CANA_LIMPIA.ToString("#,##0.00") Else txtLBS_CANA_LIMPIA.Text = ""
            If lDatosLab.PORC_MATERIA_EXTRA <> -1 Then txtPORC_MATERIA_EXTRA.Text = lDatosLab.PORC_MATERIA_EXTRA.ToString("#,##0.00") Else txtPORC_MATERIA_EXTRA.Text = ""
            txtOBSERVACION.Text = lDatosLab.OBSERVACION
            If lDatosLab.PORC_PUNTAS_TIERNA <> -1 Then txtPORC_PUNTAS_TIERNA.Text = lDatosLab.PORC_PUNTAS_TIERNA.ToString("#,##0.00") Else txtPORC_PUNTAS_TIERNA.Text = ""
            If lDatosLab.PORC_CANA_SECA <> -1 Then txtPORC_CANA_SECA.Text = lDatosLab.PORC_CANA_SECA.ToString("#,##0.00") Else txtPORC_CANA_SECA.Text = ""
            If lDatosLab.PORC_MAMONES <> -1 Then txtPORC_MAMONES.Text = lDatosLab.PORC_MAMONES.ToString("#,##0.00") Else txtPORC_MAMONES.Text = ""
            If lDatosLab.PORC_BAJERA <> -1 Then txtPORC_BAJERA.Text = lDatosLab.PORC_BAJERA.ToString("#,##0.00") Else txtPORC_BAJERA.Text = ""
            If lDatosLab.PORC_TIERRA_RAICES <> -1 Then txtPORC_TIERRA_RAICES.Text = lDatosLab.PORC_TIERRA_RAICES.ToString("#,##0.00") Else txtPORC_TIERRA_RAICES.Text = ""
            If lDatosLab.PORC_PIEDRA <> -1 Then txtPORC_PIEDRA.Text = lDatosLab.PORC_PIEDRA.ToString("#,##0.00") Else txtPORC_PIEDRA.Text = ""
            If lDatosLab.PORC_CANA_LIMPIA <> -1 Then txtPORC_CANA_LIMPIA.Text = lDatosLab.PORC_CANA_LIMPIA.ToString("#,##0.00") Else txtPORC_CANA_LIMPIA.Text = ""
            If lDatosLab.ACIDEZ <> -1 Then txtACIDEZ.Text = lDatosLab.ACIDEZ.ToString("#,##0.00") Else txtACIDEZ.Text = ""
            If lDatosLab.REDUCTORES <> -1 Then txtREDUCTORES.Text = lDatosLab.REDUCTORES.ToString("#,##0.00") Else txtREDUCTORES.Text = ""
        End If

        'Ocultar/Mostrar Rendimientos
        Me.lblEtiqRENDIA_CALC1.Visible = MOSTRAR_RENDIMIENTOS
        Me.lblRENDIA_CALC1.Visible = MOSTRAR_RENDIMIENTOS
        Me.lblEtiqRENDIA_CALC2.Visible = MOSTRAR_RENDIMIENTOS
        Me.lblRENDIA_CALC2.Visible = MOSTRAR_RENDIMIENTOS
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        ddlZAFRAID_ZAFRA.Enabled = (Me.TIPO_OPERACION = TipoOperacion.Consulta)
        txtCATORCENA_ZAFRA.Enabled = False
        txtDIAZAFRA.Enabled = False
        txtID_ANALISIS.Enabled = False
        txtBAGAZO_BRUTO.Enabled = edicion
        txtBAGAZO_NETO.Enabled = edicion
        txtPOL.Enabled = False
        txtPOL_LECTURA.Enabled = edicion
        txtBRIX.Enabled = edicion
        txtPH.Enabled = edicion
        txtABSORVANCIA.Enabled = edicion
        txtANALISTA.Enabled = edicion
        txtLBS_MUESTRA.Enabled = edicion
        txtLBS_PUNTAS_TIERNA.Enabled = edicion
        txtLBS_CANA_SECA.Enabled = edicion
        txtLBS_MAMONES.Enabled = edicion
        txtLBS_BAJERA.Enabled = edicion
        txtLBS_TIERRA_RAICES.Enabled = edicion
        txtLBS_PIEDRA.Enabled = edicion
        txtLBS_CANA_LIMPIA.Enabled = False
        txtACIDEZ.Enabled = edicion
        txtREDUCTORES.Enabled = edicion
        txtOBSERVACION.Enabled = edicion
        txtDEXTRANA.Enabled = False
        txtPORC_MATERIA_EXTRA.Enabled = False
        txtPORC_PUNTAS_TIERNA.Enabled = False
        txtPORC_CANA_SECA.Enabled = False
        txtPORC_MAMONES.Enabled = False
        txtPORC_BAJERA.Enabled = False
        txtPORC_TIERRA_RAICES.Enabled = False
        txtPORC_PIEDRA.Enabled = False
        txtPORC_CANA_LIMPIA.Enabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo(Optional ConfigEncabezado As Boolean = True)
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.AsignarMensaje("", False, False)
        txtID_ANALISIS.Text = ""
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing AndAlso ConfigEncabezado Then
            ddlZAFRAID_ZAFRA.Recuperar()
            Me.ddlZAFRAID_ZAFRA.SelectedValue = lZafra.ID_ZAFRA
        End If
        txtCATORCENA_ZAFRA.Text = ""
        txtDIAZAFRA.Text = ""
        txtBAGAZO_BRUTO.Text = ""
        txtBAGAZO_NETO.Text = ""
        txtPOL.Text = ""
        txtBRIX.Text = ""
        txtPH.Text = ""
        txtABSORVANCIA.Text = ""
        txtANALISTA.Text = ""
        txtLBS_MUESTRA.Text = ""
        txtLBS_PUNTAS_TIERNA.Text = ""
        txtLBS_CANA_SECA.Text = ""
        txtLBS_MAMONES.Text = ""
        txtLBS_BAJERA.Text = ""
        txtLBS_TIERRA_RAICES.Text = ""
        txtLBS_PIEDRA.Text = ""
        txtLBS_CANA_LIMPIA.Text = ""
        txtACIDEZ.Text = ""
        txtREDUCTORES.Text = ""
        txtOBSERVACION.Text = ""
        txtDEXTRANA.Text = ""
        txtPORC_MATERIA_EXTRA.Text = ""
        txtPORC_PUNTAS_TIERNA.Text = ""
        txtPORC_CANA_SECA.Text = ""
        txtPORC_MAMONES.Text = ""
        txtPORC_BAJERA.Text = ""
        txtPORC_TIERRA_RAICES.Text = ""
        txtPORC_PIEDRA.Text = ""
        txtPORC_CANA_LIMPIA.Text = ""

        lblFIBRA_CANA.Text = ""
        lblJUGO_CANA.Text = ""
        lblPOL_CANA.Text = ""
        lblPUREZA_JUGO.Text = ""
        lblPUREZA_AZUCAR.Text = ""
        lblSJM.Text = ""
        lblHUMEDAD.Text = ""
        lblRENDIA_CALC1.Text = ""
        lblRENDIA_CALC2.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ANALISIS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ANALISIS
        If Me._nuevo Then
            mEntidad.ID_ANALISIS = 0
            mEntidad.USUARIO_LEE_BAGAZO_BRUTO = Nothing
            mEntidad.USUARIO_LEE_BAGAZO_TARA = Nothing
            mEntidad.USUARIO_LEE_POL = Nothing
            mEntidad.USUARIO_LEE_BRIX = Nothing
            mEntidad.FECHA_LEE_BAGAZO_BRUTO = #12:00:00 AM#
            mEntidad.FECHA_LEE_BAGAZO_TARA = #12:00:00 AM#
            mEntidad.FECHA_LEE_POL = #12:00:00 AM#
            mEntidad.FECHA_LEE_BRIX = #12:00:00 AM#
        Else
            mEntidad = (New cANALISIS).ObtenerANALISIS(CInt(Me.txtID_ANALISIS.Text))
        End If
        mEntidad.ID_ENVIO = Me.txtID_ENVIO.Text
        If Me.txtBAGAZO_BRUTO.Text <> String.Empty Then mEntidad.BAGAZO_BRUTO = Convert.ToDecimal(Me.txtBAGAZO_BRUTO.Text) Else mEntidad.BAGAZO_BRUTO = -1
        If Me.txtBAGAZO_NETO.Text <> String.Empty Then mEntidad.BAGAZO_NETO = Convert.ToDecimal(Me.txtBAGAZO_NETO.Text) Else mEntidad.BAGAZO_NETO = -1
        If Me.txtPOL.Text <> String.Empty Then mEntidad.POL = Convert.ToDecimal(Me.txtPOL.Text) Else mEntidad.POL = -1
        If Me.txtPOL_LECTURA.Text <> String.Empty Then mEntidad.POL_LECTURA = Convert.ToDecimal(Me.txtPOL_LECTURA.Text) Else mEntidad.POL_LECTURA = -1
        If Me.txtBRIX.Text <> String.Empty Then mEntidad.BRIX = Convert.ToDecimal(Me.txtBRIX.Text)
        If Me.txtPH.Text <> String.Empty Then mEntidad.PH = Convert.ToDecimal(Me.txtPH.Text)

        Dim listaDatosLab As listaDATOS_LABORATORIO = (New cDATOS_LABORATORIO).ObtenerListaPorANALISIS(mEntidad.ID_ANALISIS)
        Dim lDatosLab As New DATOS_LABORATORIO
        Dim bDatosLab As New cDATOS_LABORATORIO

        If listaDatosLab IsNot Nothing AndAlso listaDatosLab.Count > 0 Then
            lDatosLab = listaDatosLab(0)
            lDatosLab.USUARIO_ACT = Me.ObtenerUsuario
            lDatosLab.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            lDatosLab.ID_DATOS_LAB = 0
            lDatosLab.USUARIO_CREA = Me.ObtenerUsuario
            lDatosLab.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lDatosLab.USUARIO_ACT = Me.ObtenerUsuario
            lDatosLab.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If

        If mEntidad.USUARIO_LEE_BAGAZO_BRUTO = "" Then mEntidad.USUARIO_LEE_BAGAZO_BRUTO = Me.ObtenerUsuario
        If mEntidad.FECHA_LEE_BAGAZO_BRUTO = #12:00:00 AM# Then mEntidad.FECHA_LEE_BAGAZO_BRUTO = cFechaHora.ObtenerFechaHora
        If mEntidad.USUARIO_LEE_BAGAZO_TARA = "" Then mEntidad.USUARIO_LEE_BAGAZO_TARA = Me.ObtenerUsuario
        If mEntidad.FECHA_LEE_BAGAZO_TARA = #12:00:00 AM# Then mEntidad.FECHA_LEE_BAGAZO_TARA = cFechaHora.ObtenerFechaHora

        If mComponente.ActualizarANALISIS(mEntidad) < 1 Then
            Me.AsignarMensaje("Error al Guardar registro. " + mComponente.sError, True)
            Return "Error al Guardar registro."
        End If

        If txtANALISTA.Text = String.Empty AndAlso _
            txtLBS_MUESTRA.Text = String.Empty AndAlso _
            txtLBS_PUNTAS_TIERNA.Text = String.Empty AndAlso _
            txtLBS_CANA_SECA.Text = String.Empty AndAlso _
            txtLBS_MAMONES.Text = String.Empty AndAlso _
            txtLBS_BAJERA.Text = String.Empty AndAlso _
            txtLBS_TIERRA_RAICES.Text = String.Empty AndAlso _
            txtLBS_PIEDRA.Text = String.Empty AndAlso _
            txtLBS_CANA_LIMPIA.Text = String.Empty AndAlso _
            txtOBSERVACION.Text = String.Empty AndAlso _
            txtACIDEZ.Text = String.Empty AndAlso _
            txtREDUCTORES.Text = String.Empty AndAlso _
            txtDEXTRANA.Text = String.Empty AndAlso _
            txtPH.Text = String.Empty Then

            If lDatosLab.ID_DATOS_LAB > 0 Then bDatosLab.EliminarDATOS_LABORATORIO(lDatosLab.ID_DATOS_LAB)
        Else
            lDatosLab.ID_ANALISIS = mEntidad.ID_ANALISIS
            lDatosLab.ANALISTA = Me.txtANALISTA.Text.Trim.ToUpper
            If Me.txtLBS_MUESTRA.Text <> String.Empty Then lDatosLab.LBS_MUESTRA = Convert.ToDecimal(Me.txtLBS_MUESTRA.Text) Else lDatosLab.LBS_MUESTRA = -1
            If Me.txtLBS_PUNTAS_TIERNA.Text <> String.Empty Then lDatosLab.LBS_PUNTAS_TIERNA = Convert.ToDecimal(Me.txtLBS_PUNTAS_TIERNA.Text) Else lDatosLab.LBS_PUNTAS_TIERNA = -1
            If Me.txtLBS_CANA_SECA.Text <> String.Empty Then lDatosLab.LBS_CANA_SECA = Convert.ToDecimal(Me.txtLBS_CANA_SECA.Text) Else lDatosLab.LBS_CANA_SECA = -1
            If Me.txtLBS_MAMONES.Text <> String.Empty Then lDatosLab.LBS_MAMONES = Convert.ToDecimal(Me.txtLBS_MAMONES.Text) Else lDatosLab.LBS_MAMONES = -1
            If Me.txtLBS_BAJERA.Text <> String.Empty Then lDatosLab.LBS_BAJERA = Convert.ToDecimal(Me.txtLBS_BAJERA.Text) Else lDatosLab.LBS_BAJERA = -1
            If Me.txtLBS_TIERRA_RAICES.Text <> String.Empty Then lDatosLab.LBS_TIERRA_RAICES = Convert.ToDecimal(Me.txtLBS_TIERRA_RAICES.Text) Else lDatosLab.LBS_TIERRA_RAICES = -1
            If Me.txtLBS_PIEDRA.Text <> String.Empty Then lDatosLab.LBS_PIEDRA = Convert.ToDecimal(Me.txtLBS_PIEDRA.Text) Else lDatosLab.LBS_PIEDRA = -1
            If Me.txtLBS_CANA_LIMPIA.Text <> String.Empty Then lDatosLab.LBS_CANA_LIMPIA = Convert.ToDecimal(Me.txtLBS_CANA_LIMPIA.Text) Else lDatosLab.LBS_CANA_LIMPIA = -1
            lDatosLab.OBSERVACION = Me.txtOBSERVACION.Text
            If Me.txtPORC_PUNTAS_TIERNA.Text <> String.Empty Then lDatosLab.PORC_PUNTAS_TIERNA = Convert.ToDecimal(Me.txtPORC_PUNTAS_TIERNA.Text) Else lDatosLab.PORC_PUNTAS_TIERNA = -1
            If Me.txtPORC_CANA_SECA.Text <> String.Empty Then lDatosLab.PORC_CANA_SECA = Convert.ToDecimal(Me.txtPORC_CANA_SECA.Text) Else lDatosLab.PORC_CANA_SECA = -1
            If Me.txtPORC_MAMONES.Text <> String.Empty Then lDatosLab.PORC_MAMONES = Convert.ToDecimal(Me.txtPORC_MAMONES.Text) Else lDatosLab.PORC_MAMONES = -1
            If Me.txtPORC_BAJERA.Text <> String.Empty Then lDatosLab.PORC_BAJERA = Convert.ToDecimal(Me.txtPORC_BAJERA.Text) Else lDatosLab.PORC_BAJERA = -1
            If Me.txtPORC_TIERRA_RAICES.Text <> String.Empty Then lDatosLab.PORC_TIERRA_RAICES = Convert.ToDecimal(Me.txtPORC_TIERRA_RAICES.Text) Else lDatosLab.PORC_TIERRA_RAICES = -1
            If Me.txtPORC_PIEDRA.Text <> String.Empty Then lDatosLab.PORC_PIEDRA = Convert.ToDecimal(Me.txtPORC_PIEDRA.Text) Else lDatosLab.PORC_PIEDRA = -1
            If Me.txtPORC_CANA_LIMPIA.Text <> String.Empty Then lDatosLab.PORC_CANA_LIMPIA = Convert.ToDecimal(Me.txtPORC_CANA_LIMPIA.Text) Else lDatosLab.PORC_CANA_LIMPIA = -1
            If Me.txtPORC_MATERIA_EXTRA.Text <> String.Empty Then lDatosLab.PORC_MATERIA_EXTRA = Convert.ToDecimal(Me.txtPORC_MATERIA_EXTRA.Text) Else lDatosLab.PORC_MATERIA_EXTRA = -1
            If Me.txtABSORVANCIA.Text <> String.Empty Then lDatosLab.ABSORVANCIA = Convert.ToDecimal(Me.txtABSORVANCIA.Text) Else lDatosLab.ABSORVANCIA = -1
            If Me.txtDEXTRANA.Text <> String.Empty Then lDatosLab.DEXTRANA = Convert.ToDecimal(Me.txtDEXTRANA.Text) Else lDatosLab.DEXTRANA = -1
            If Me.txtACIDEZ.Text <> String.Empty Then lDatosLab.ACIDEZ = Convert.ToDecimal(Me.txtACIDEZ.Text) Else lDatosLab.ACIDEZ = -1
            If Me.txtREDUCTORES.Text <> String.Empty Then lDatosLab.REDUCTORES = Convert.ToDecimal(Me.txtREDUCTORES.Text) Else lDatosLab.REDUCTORES = -1

            bDatosLab.ActualizarDATOS_LABORATORIO(lDatosLab)
        End If

        Me.txtID_ANALISIS.Text = mEntidad.ID_ANALISIS.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.MostrarMensaje("Registro guardado!")
        Return ""
    End Function

    Protected Sub txtBAGAZO_BRUTO_TextChanged(sender As Object, e As System.EventArgs) Handles txtBAGAZO_BRUTO.TextChanged, _
            txtBAGAZO_NETO.TextChanged, txtPOL_LECTURA.TextChanged, txtBRIX.TextChanged, txtPH.TextChanged, _
            txtABSORVANCIA.TextChanged, txtDEXTRANA.TextChanged, txtLBS_MUESTRA.TextChanged, txtLBS_PUNTAS_TIERNA.TextChanged, _
            txtLBS_CANA_SECA.TextChanged, txtLBS_MAMONES.TextChanged, txtLBS_BAJERA.TextChanged, txtLBS_TIERRA_RAICES.TextChanged, _
            txtLBS_PIEDRA.TextChanged, txtLBS_CANA_LIMPIA.TextChanged, txtACIDEZ.TextChanged, txtREDUCTORES.TextChanged
        Dim texto As TextBox = CType(sender, TextBox)
        texto.Text = texto.Text.Trim
        If Not IsNumeric(texto.Text) Then
            texto.Text = ""
            texto.Focus()
            Me.AsignarMensaje("* Digite un valor numerico", True)
            Exit Sub
        End If
        texto.Text = Convert.ToDecimal(texto.Text).ToString("#,##0.00")
        If texto.ID = "txtPOL_LECTURA" OrElse texto.ID = "txtBRIX" Then
            If txtPOL_LECTURA.Text <> String.Empty AndAlso txtBRIX.Text Then
                Dim brix As Decimal = Convert.ToDecimal(txtBRIX.Text)
                Dim polLectura As Decimal = Convert.ToDecimal(Me.txtPOL_LECTURA.Text)
                Dim polCorregido As Decimal = 0
                Dim densidad As Decimal = 0
                Dim pesoesp As Decimal = 0

                densidad = Convert.ToInt32(Math.Round(brix, 0)) * 10 + 1
                pesoesp = (New cAJUSTE_POL).ObtenerAJUSTE_POL(densidad).PESOESP
                polCorregido = (Convert.ToDecimal(polLectura) * 26D) / (99.718D * pesoesp)
                polCorregido = Math.Round(polCorregido, 2)

                txtPOL.Text = polCorregido.ToString("#,##0.00")
            Else
                txtPOL.Text = ""
            End If
        End If
        Me.EstablecerMateriaExtrana()
    End Sub

    Private Sub EstablecerMateriaExtrana()
        If txtLBS_MUESTRA.Text = "" Then
            txtPORC_PUNTAS_TIERNA.Text = ""
            txtPORC_CANA_SECA.Text = ""
            txtPORC_MAMONES.Text = ""
            txtPORC_BAJERA.Text = ""
            txtPORC_TIERRA_RAICES.Text = ""
            txtPORC_PIEDRA.Text = ""
            txtPORC_CANA_LIMPIA.Text = ""
            txtPORC_MATERIA_EXTRA.Text = ""
        Else
            Dim porcMateriaExtrana As Decimal = 0
            Dim totalMateriaExtrana As Decimal = 0
            Dim lbsMuestra As Decimal = Convert.ToDecimal(txtLBS_MUESTRA.Text)
            Dim valor As Decimal = 0

            If txtLBS_PUNTAS_TIERNA.Text = "" Then
                txtPORC_PUNTAS_TIERNA.Text = ""
            Else
                totalMateriaExtrana += Convert.ToDecimal(txtLBS_PUNTAS_TIERNA.Text)
                valor = Math.Round(Convert.ToDecimal(txtLBS_PUNTAS_TIERNA.Text) / lbsMuestra, 2) * 100
                porcMateriaExtrana += valor
                txtPORC_PUNTAS_TIERNA.Text = valor.ToString("#,##0.00")
            End If
            If txtLBS_CANA_SECA.Text = "" Then
                txtPORC_CANA_SECA.Text = ""
            Else
                totalMateriaExtrana += Convert.ToDecimal(txtLBS_CANA_SECA.Text)
                valor = Math.Round(Convert.ToDecimal(txtLBS_CANA_SECA.Text) / lbsMuestra, 2) * 100
                porcMateriaExtrana += valor
                txtPORC_CANA_SECA.Text = valor.ToString("#,##0.00")
            End If
            If txtLBS_MAMONES.Text = "" Then
                txtPORC_MAMONES.Text = ""
            Else
                totalMateriaExtrana += Convert.ToDecimal(txtLBS_MAMONES.Text)
                valor = Math.Round(Convert.ToDecimal(txtLBS_MAMONES.Text) / lbsMuestra, 2) * 100
                porcMateriaExtrana += valor
                txtPORC_MAMONES.Text = valor.ToString("#,##0.00")
            End If
            If txtLBS_BAJERA.Text = "" Then
                txtPORC_BAJERA.Text = ""
            Else
                totalMateriaExtrana += Convert.ToDecimal(txtLBS_BAJERA.Text)
                valor = Math.Round(Convert.ToDecimal(txtLBS_BAJERA.Text) / lbsMuestra, 2) * 100
                porcMateriaExtrana += valor
                txtPORC_BAJERA.Text = valor.ToString("#,##0.00")
            End If
            If txtLBS_TIERRA_RAICES.Text = "" Then
                txtPORC_TIERRA_RAICES.Text = ""
            Else
                totalMateriaExtrana += Convert.ToDecimal(txtLBS_TIERRA_RAICES.Text)
                valor = Math.Round(Convert.ToDecimal(txtLBS_TIERRA_RAICES.Text) / lbsMuestra, 2) * 100
                porcMateriaExtrana += valor
                txtPORC_TIERRA_RAICES.Text = valor.ToString("#,##0.00")
            End If
            If txtLBS_PIEDRA.Text = "" Then
                txtPORC_PIEDRA.Text = ""
            Else
                totalMateriaExtrana += Convert.ToDecimal(txtLBS_PIEDRA.Text)
                valor = Math.Round(Convert.ToDecimal(txtLBS_PIEDRA.Text) / lbsMuestra, 2) * 100
                porcMateriaExtrana += valor
                txtPORC_PIEDRA.Text = valor.ToString("#,##0.00")
            End If

            txtLBS_CANA_LIMPIA.Text = (Convert.ToDecimal(txtLBS_MUESTRA.Text) - totalMateriaExtrana).ToString("#,##0.00")
            txtPORC_MATERIA_EXTRA.Text = porcMateriaExtrana.ToString("#,##0.00")
            txtPORC_CANA_LIMPIA.Text = (100 - porcMateriaExtrana).ToString("#,##0.00")
        End If
    End Sub

    Protected Sub txtNROBOLETA_TextChanged(sender As Object, e As System.EventArgs) Handles txtNROBOLETA.TextChanged
        If TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.Consulta Then
            'Recuperar datos del taco
            Dim lista As listaANALISIS
            Dim bAnalisis As New cANALISIS
            Dim lEnvios As listaENVIO

            If Me.txtNROBOLETA.Text.Trim <> String.Empty Then
                Me.txtNROBOLETA.Text = Me.txtNROBOLETA.Text.Trim
                If Not IsNumeric(Me.txtNROBOLETA.Text) Then
                    Me.txtNROBOLETA.Text = ""
                    Me.txtNROBOLETA.Focus()
                    Exit Sub
                End If
                Me.Enabled = (TIPO_OPERACION = TipoOperacion.Edicion)
                lista = bAnalisis.ObtenerListaPorBOLETA(Me.ddlZAFRAID_ZAFRA.SelectedValue, Convert.ToInt32(Me.txtNROBOLETA.Text))
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    'If lista(0).BAGAZO_BRUTO = -1 OrElse lista(0).BAGAZO_BRUTO = -1 Then
                    '    Me.AsignarMensaje(" * El No. de Taco no tiene asociado peso bagazo", True)
                    '    Me.LimpiarControles()
                    '    txtBAGAZO_BRUTO.Focus()
                    '    Exit Sub
                    'End If
                    Me.ID_ANALISIS = lista(0).ID_ANALISIS
                Else
                    'Me.AsignarMensaje(" * El No. de Taco no tiene asociado peso bagazo", True)
                    'Me.LimpiarControles()
                    'txtBAGAZO_BRUTO.Focus()
                    'Exit Sub
                    
                    lEnvios = (New cENVIO).ObtenerListaPorBOLETA(Me.ddlZAFRAID_ZAFRA.SelectedValue, Convert.ToInt32(Me.txtNROBOLETA.Text))
                    If lEnvios IsNot Nothing AndAlso lEnvios.Count > 0 Then
                        Dim lanalisis As New ANALISIS

                        lanalisis.ID_ENVIO = lEnvios(0).ID_ENVIO
                        bAnalisis.ActualizarANALISIS(lanalisis)
                        Me.ID_ANALISIS = lanalisis.ID_ANALISIS
                        Exit Sub

                        'Me.txtID_ENVIO.Text = lEnvios(0).ID_ENVIO.ToString
                        'Me.txtCATORCENA_ZAFRA.Text = lEnvios(0).CATORCENA.ToString
                        'Me.txtDIAZAFRA.Text = lEnvios(0).DIAZAFRA.ToString
                        'Me.HabilitarEdicion(Me._Enabled)
                    Else
                        Me.AsignarMensaje(" * El No. de Taco no tiene asociado peso bagazo", True)
                        Me.LimpiarControles()
                    End If
                    Return
                End If
            End If
            txtBAGAZO_BRUTO.Focus()
        End If
    End Sub

    Protected Sub ddlZAFRAID_ZAFRA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlZAFRAID_ZAFRA.SelectedIndexChanged
        Dim lNroBoleta As String = Me.txtNROBOLETA.Text
        Me.Nuevo(False)
        Me.txtNROBOLETA.Text = lNroBoleta
        Me.txtNROBOLETA_TextChanged(sender, e)
    End Sub
End Class
