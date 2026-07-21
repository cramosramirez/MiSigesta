Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/11/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleZAFRA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ZAFRA As Int32
    Public Property ID_ZAFRA() As Int32
        Get
            Return Me.txtID_ZAFRA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ZAFRA = Value
            Me.txtID_ZAFRA.Text = CStr(Value)
            If Me._ID_ZAFRA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_ZAFRA() As String
        Get
            Return Me.txtNOMBRE_ZAFRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_ZAFRA.Text = value.ToString()
        End Set
    End Property

    Public Property DIAZAFRA() As Int32
        Get
            If Me.txtDIAZAFRA.Value Is Nothing Then Return -1
            Return CInt(Me.txtDIAZAFRA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtDIAZAFRA.Value = value
        End Set
    End Property

    Public Property CATORCENA() As Int32
        Get
            If Me.txtCATORCENA.Value Is Nothing Then Return -1
            Return CInt(Me.txtCATORCENA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtCATORCENA.Value = value
        End Set
    End Property

    Public Property FECHA_INICIO() As DateTime
        Get
            Return Me.deFECHA_INICIO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_INICIO.Value = value
        End Set
    End Property

    Public Property FECHA_FINAL() As DateTime
        Get
            Return Me.deFECHA_FINAL.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_FINAL.Value = value
        End Set
    End Property

    Public Property POL() As Decimal
        Get
            If Me.txtPOL.Value Is Nothing Then Return -1
            Return Me.txtPOL.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPOL.Value = value
        End Set
    End Property

    Public Property HUMEDAD() As Decimal
        Get
            If Me.txtHUMEDAD.Value Is Nothing Then Return -1
            Return Me.txtHUMEDAD.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtHUMEDAD.Value = value
        End Set
    End Property

    Public Property PUREZA_MIEL() As Decimal
        Get
            If Me.txtPUREZA_MIEL.Value Is Nothing Then Return -1
            Return Me.txtPUREZA_MIEL.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPUREZA_MIEL.Value = value
        End Set
    End Property

    Public Property EFICIENCIA() As Decimal
        Get
            If Me.txtEFICIENCIA.Value Is Nothing Then Return -1
            Return Me.txtEFICIENCIA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEFICIENCIA.Value = value
        End Set
    End Property

    Public Property PRECIO_LIBRA_AZUCAR() As Decimal
        Get
            If Me.txtPRECIO_LIBRA_AZUCAR.Value Is Nothing Then Return -1
            Return Me.txtPRECIO_LIBRA_AZUCAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPRECIO_LIBRA_AZUCAR.Value = value
        End Set
    End Property

    Public Property CONSTANTE_A() As Decimal
        Get
            If Me.txtCONSTANTE_A.Value Is Nothing Then Return -1
            Return Me.txtCONSTANTE_A.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCONSTANTE_A.Value = value
        End Set
    End Property

    Public Property CONSTANTE_B() As Decimal
        Get
            If Me.txtCONSTANTE_B.Value Is Nothing Then Return -1
            Return Me.txtCONSTANTE_B.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCONSTANTE_B.Value = value
        End Set
    End Property

    Public Property CONSTANTE_D() As Decimal
        Get
            If Me.txtCONSTANTE_D.Value Is Nothing Then Return -1
            Return Me.txtCONSTANTE_D.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCONSTANTE_D.Value = value
        End Set
    End Property

    Public Property CONSTANTE_E() As Decimal
        Get
            If Me.txtCONSTANTE_E.Value Is Nothing Then Return -1
            Return Me.txtCONSTANTE_E.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCONSTANTE_E.Value = value
        End Set
    End Property

    Public Property ULTFECHA_CIERRE_DIARIO() As DateTime
        Get
            Return Me.deULTFECHA_CIERRE_DIARIO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deULTFECHA_CIERRE_DIARIO.Value = value
        End Set
    End Property

    Public Property ACTIVA() As Boolean
        Get
            Return Me.cbxACTIVA.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxACTIVA.Checked = value
        End Set
    End Property

    Public Property USUARIO_CREA() As String
        Get
            Return Me.txtUSUARIO_CREA.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CREA.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CREA() As DateTime
        Get
            Return Me.deFECHA_CREA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CREA.Value = value
        End Set
    End Property

    Public Property USUARIO_ACT() As String
        Get
            Return Me.txtUSUARIO_ACT.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_ACT.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_ACT() As DateTime
        Get
            Return Me.deFECHA_ACT.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_ACT.Value = value
        End Set
    End Property

    Public Property DISPO_INVE_ROZA() As Decimal
        Get
            If Me.txtDISPO_INVE_ROZA.Value Is Nothing Then Return -1
            Return Me.txtDISPO_INVE_ROZA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtDISPO_INVE_ROZA.Value = value
        End Set
    End Property

    Public Property REND_MODFINAN() As Decimal
        Get
            If Me.txtREND_MODFINAN.Value Is Nothing Then Return -1
            Return Me.txtREND_MODFINAN.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtREND_MODFINAN.Value = value
        End Set
    End Property

    Public Property TARIFA_ROZA_MODFINAN() As Decimal
        Get
            If Me.txtTARIFA_ROZA_MODFINAN.Value Is Nothing Then Return -1
            Return Me.txtTARIFA_ROZA_MODFINAN.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_ROZA_MODFINAN.Value = value
        End Set
    End Property

    Public Property TARIFA_ALZA_MODFINAN() As Decimal
        Get
            If Me.txtTARIFA_ALZA_MODFINAN.Value Is Nothing Then Return -1
            Return Me.txtTARIFA_ALZA_MODFINAN.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_ALZA_MODFINAN.Value = value
        End Set
    End Property

    Public Property TARIFA_QUERQUEO() As Decimal
        Get
            If Me.txtTARIFA_QUERQUEO.Value Is Nothing Then Return -1
            Return Me.txtTARIFA_QUERQUEO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_QUERQUEO.Value = value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_ZAFRA() As Boolean
        Get
            Return Me.trNOMBRE_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerDIAZAFRA() As Boolean
        Get
            Return Me.trDIAZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIAZAFRA.Visible = value
        End Set
    End Property

    Public Property VerCATORCENA() As Boolean
        Get
            Return Me.trCATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCATORCENA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.trFECHA_INICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INICIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_FINAL() As Boolean
        Get
            Return Me.trFECHA_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_FINAL.Visible = value
        End Set
    End Property

    Public Property VerPOL() As Boolean
        Get
            Return Me.trPOL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPOL.Visible = value
        End Set
    End Property

    Public Property VerHUMEDAD() As Boolean
        Get
            Return Me.trHUMEDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trHUMEDAD.Visible = value
        End Set
    End Property

    Public Property VerPUREZA_MIEL() As Boolean
        Get
            Return Me.trPUREZA_MIEL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPUREZA_MIEL.Visible = value
        End Set
    End Property

    Public Property VerEFICIENCIA() As Boolean
        Get
            Return Me.trEFICIENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEFICIENCIA.Visible = value
        End Set
    End Property

    Public Property VerPRECIO_LIBRA_AZUCAR() As Boolean
        Get
            Return Me.trPRECIO_LIBRA_AZUCAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPRECIO_LIBRA_AZUCAR.Visible = value
        End Set
    End Property

    Public Property VerCONSTANTE_A() As Boolean
        Get
            Return Me.trCONSTANTE_A.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONSTANTE_A.Visible = value
        End Set
    End Property

    Public Property VerCONSTANTE_B() As Boolean
        Get
            Return Me.trCONSTANTE_B.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONSTANTE_B.Visible = value
        End Set
    End Property

    Public Property VerCONSTANTE_D() As Boolean
        Get
            Return Me.trCONSTANTE_D.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONSTANTE_D.Visible = value
        End Set
    End Property

    Public Property VerCONSTANTE_E() As Boolean
        Get
            Return Me.trCONSTANTE_E.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONSTANTE_E.Visible = value
        End Set
    End Property

    Public Property VerULTFECHA_CIERRE_DIARIO() As Boolean
        Get
            Return Me.trULTFECHA_CIERRE_DIARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trULTFECHA_CIERRE_DIARIO.Visible = value
        End Set
    End Property

    Public Property VerACTIVA() As Boolean
        Get
            Return Me.trACTIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACTIVA.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.trUSUARIO_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CREA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.trFECHA_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CREA.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.trUSUARIO_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_ACT.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.trFECHA_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ACT.Visible = value
        End Set
    End Property

    Public Property VerDISPO_INVE_ROZA() As Boolean
        Get
            Return Me.trDISPO_INVE_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDISPO_INVE_ROZA.Visible = value
        End Set
    End Property

    Public Property VerREND_MODFINAN() As Boolean
        Get
            Return Me.trREND_MODFINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trREND_MODFINAN.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_ROZA_MODFINAN() As Boolean
        Get
            Return Me.trTARIFA_ROZA_MODFINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_ROZA_MODFINAN.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_ALZA_MODFINAN() As Boolean
        Get
            Return Me.trTARIFA_ALZA_MODFINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_ALZA_MODFINAN.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_QUERQUEO() As Boolean
        Get
            Return Me.trTARIFA_QUERQUEO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_QUERQUEO.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cZAFRA
    Private mEntidad As ZAFRA
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ZAFRA") Is Nothing Then Me._ID_ZAFRA = Me.ViewState("ID_ZAFRA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ZAFRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ZAFRA
        mEntidad.ID_ZAFRA = ID_ZAFRA
 
        If mComponente.ObtenerZAFRA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ZAFRA.Text = mEntidad.ID_ZAFRA.ToString()
        Me.txtNOMBRE_ZAFRA.Text = mEntidad.NOMBRE_ZAFRA
        Me.txtDIAZAFRA.Value = mEntidad.DIAZAFRA
        Me.txtCATORCENA.Value = mEntidad.CATORCENA
        Me.deFECHA_INICIO.Value = mEntidad.FECHA_INICIO
        Me.deFECHA_FINAL.Value = mEntidad.FECHA_FINAL
        Me.txtPOL.Value = mEntidad.POL
        Me.txtHUMEDAD.Value = mEntidad.HUMEDAD
        Me.txtPUREZA_MIEL.Value = mEntidad.PUREZA_MIEL
        Me.txtEFICIENCIA.Value = mEntidad.EFICIENCIA
        Me.txtPRECIO_LIBRA_AZUCAR.Value = mEntidad.PRECIO_LIBRA_AZUCAR
        Me.txtCONSTANTE_A.Value = mEntidad.CONSTANTE_A
        Me.txtCONSTANTE_B.Value = mEntidad.CONSTANTE_B
        Me.txtCONSTANTE_D.Value = mEntidad.CONSTANTE_D
        Me.txtCONSTANTE_E.Value = mEntidad.CONSTANTE_E
        Me.deULTFECHA_CIERRE_DIARIO.Value = mEntidad.ULTFECHA_CIERRE_DIARIO
        Me.cbxACTIVA.Checked = mEntidad.ACTIVA
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT
        Me.txtDISPO_INVE_ROZA.Value = mEntidad.DISPO_INVE_ROZA
        Me.txtREND_MODFINAN.Value = mEntidad.REND_MODFINAN
        Me.txtTARIFA_ROZA_MODFINAN.Value = mEntidad.TARIFA_ROZA_MODFINAN
        Me.txtTARIFA_ALZA_MODFINAN.Value = mEntidad.TARIFA_ALZA_MODFINAN
        Me.txtTARIFA_QUERQUEO.Value = mEntidad.TARIFA_QUERQUEO
        Me.txtPUREZA_AZUCAR.Value = mEntidad.PUREZA_AZUCAR
        Me.chkPOLBRIX_SIMU.Checked = mEntidad.CAPTURA_POL_BRIX_SIMULTANEA
        Me.txtVIP_UNIDAD_TRADICIONAL.Value = mEntidad.VIP_UNIDAD_TRADICIONAL
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE_ZAFRA.Enabled = edicion
        Me.txtDIAZAFRA.Enabled = edicion
        Me.txtCATORCENA.Enabled = edicion
        Me.deFECHA_INICIO.Enabled = edicion
        Me.deFECHA_FINAL.Enabled = edicion
        Me.txtPOL.Enabled = edicion
        Me.txtHUMEDAD.Enabled = edicion
        Me.txtPUREZA_MIEL.Enabled = edicion
        Me.txtEFICIENCIA.Enabled = edicion
        Me.txtPRECIO_LIBRA_AZUCAR.Enabled = edicion
        Me.txtCONSTANTE_A.Enabled = edicion
        Me.txtCONSTANTE_B.Enabled = edicion
        Me.txtCONSTANTE_D.Enabled = edicion
        Me.txtCONSTANTE_E.Enabled = edicion
        Me.deULTFECHA_CIERRE_DIARIO.Enabled = edicion
        Me.cbxACTIVA.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.deFECHA_ACT.Enabled = edicion
        Me.txtDISPO_INVE_ROZA.Enabled = edicion
        Me.txtREND_MODFINAN.Enabled = edicion
        Me.txtTARIFA_ROZA_MODFINAN.Enabled = edicion
        Me.txtTARIFA_ALZA_MODFINAN.Enabled = edicion
        Me.txtTARIFA_QUERQUEO.Enabled = edicion
        Me.txtPUREZA_AZUCAR.Enabled = edicion
        Me.chkPOLBRIX_SIMU.ClientEnabled = edicion
        Me.txtVIP_UNIDAD_TRADICIONAL.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOMBRE_ZAFRA.Text = ""
        Me.txtDIAZAFRA.Value = Nothing
        Me.txtCATORCENA.Value = Nothing
        Me.deFECHA_INICIO.Value = Nothing
        Me.deFECHA_FINAL.Value = Nothing
        Me.txtPOL.Value = Nothing
        Me.txtHUMEDAD.Value = Nothing
        Me.txtPUREZA_MIEL.Value = Nothing
        Me.txtEFICIENCIA.Value = Nothing
        Me.txtPRECIO_LIBRA_AZUCAR.Value = Nothing
        Me.txtCONSTANTE_A.Value = Nothing
        Me.txtCONSTANTE_B.Value = Nothing
        Me.txtCONSTANTE_D.Value = Nothing
        Me.txtCONSTANTE_E.Value = Nothing
        Me.deULTFECHA_CIERRE_DIARIO.Value = Nothing
        Me.cbxACTIVA.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
        Me.txtDISPO_INVE_ROZA.Value = Nothing
        Me.txtREND_MODFINAN.Value = Nothing
        Me.txtTARIFA_ROZA_MODFINAN.Value = Nothing
        Me.txtTARIFA_ALZA_MODFINAN.Value = Nothing
        Me.txtTARIFA_QUERQUEO.Value = Nothing
        Me.txtPUREZA_AZUCAR.Value = Nothing
        Me.chkPOLBRIX_SIMU.Checked = False
        Me.txtVIP_UNIDAD_TRADICIONAL.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ZAFRA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ZAFRA
        If Me._nuevo Then
            mEntidad.ID_ZAFRA = 0
            mEntidad.USUARIO_CREA = ObtenerUsuario()
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = ObtenerUsuario()
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerZAFRA(CInt(Me.txtID_ZAFRA.Text))
            mEntidad.USUARIO_ACT = ObtenerUsuario()
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If

        If mEntidad.ID_ZAFRA = 0 Then
            mEntidad.NOMBRE_ZAFRA = Me.txtNOMBRE_ZAFRA.Text
            mEntidad.DIAZAFRA = Me.txtDIAZAFRA.Value
            mEntidad.CATORCENA = Me.txtCATORCENA.Value
            mEntidad.FECHA_INICIO = Me.deFECHA_INICIO.Value
            mEntidad.FECHA_FINAL = Me.deFECHA_FINAL.Value
            mEntidad.ULTFECHA_CIERRE_DIARIO = Me.deULTFECHA_CIERRE_DIARIO.Value
            mEntidad.ACTIVA = Me.cbxACTIVA.Checked
        End If
        mEntidad.POL = Me.txtPOL.Value
        mEntidad.HUMEDAD = Me.txtHUMEDAD.Value
        mEntidad.PUREZA_MIEL = Me.txtPUREZA_MIEL.Value
        mEntidad.EFICIENCIA = Me.txtEFICIENCIA.Value
        mEntidad.PRECIO_LIBRA_AZUCAR = Me.txtPRECIO_LIBRA_AZUCAR.Value
        mEntidad.CONSTANTE_A = Me.txtCONSTANTE_A.Value
        mEntidad.CONSTANTE_B = Me.txtCONSTANTE_B.Value
        mEntidad.CONSTANTE_D = Me.txtCONSTANTE_D.Value
        mEntidad.CONSTANTE_E = Me.txtCONSTANTE_E.Value
        mEntidad.DISPO_INVE_ROZA = Me.txtDISPO_INVE_ROZA.Value
        mEntidad.REND_MODFINAN = Me.txtREND_MODFINAN.Value
        mEntidad.TARIFA_ROZA_MODFINAN = Me.txtTARIFA_ROZA_MODFINAN.Value
        mEntidad.TARIFA_ALZA_MODFINAN = Me.txtTARIFA_ALZA_MODFINAN.Value
        mEntidad.TARIFA_QUERQUEO = Me.txtTARIFA_QUERQUEO.Value
        mEntidad.PUREZA_AZUCAR = Me.txtPUREZA_AZUCAR.Value
        mEntidad.CAPTURA_POL_BRIX_SIMULTANEA = Me.chkPOLBRIX_SIMU.Checked
        mEntidad.VIP_UNIDAD_TRADICIONAL = Me.txtVIP_UNIDAD_TRADICIONAL.Value

        If mComponente.ActualizarZAFRA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ZAFRA.Text = mEntidad.ID_ZAFRA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
