Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROVEEDOR
    Inherits ucBase
#Region "CargaCatalogos"

    'Private Sub ObtenerProveedor()
    '    Me.txtNOMBRE_PROVEEDOR.Text = ""
    '    If Me.txtCODIPROVEE_ML.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.txtCODIPROVEE_ML.Text) Then
    '        If Me.txtCODISOCIO_ML.Text = "" Then
    '            Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE_ML.Text) + Utilerias.FormatoCODISOCIO(0)
    '            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
    '            If lProveedor IsNot Nothing Then
    '                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
    '            End If
    '        Else
    '            Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE_ML.Text) + Utilerias.FormatoCODISOCIO(Me.txtCODISOCIO_ML.Text)
    '            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
    '            If lProveedor IsNot Nothing Then
    '                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
    '            End If
    '        End If
    '    End If
    'End Sub

    Public Property NombreFormLayoutCliente() As String
        Get
            Return Me.ucVistaDetallePROVEEDORLayout.ClientInstanceName
        End Get
        Set(ByVal value As String)
            Me.ucVistaDetallePROVEEDORLayout.ClientInstanceName = value
        End Set
    End Property

    'Public Property VisibleEnCliente As Boolean
    '    Set(value As Boolean)
    '        Dim gl As LayoutGroup = Me.ucVistaDetallePROVEEDORLayout.FindItemOrGroupByName("lgVistaDetalleMAESTRO_LOTES")
    '        If gl IsNot Nothing Then
    '            gl.ClientVisible = value
    '        End If
    '    End Set
    '    Get
    '        Dim gl As LayoutGroup = Me.ucVistaDetallePROVEEDORLayout.FindItemOrGroupByName("lgVistaDetalleMAESTRO_LOTES")
    '        If gl IsNot Nothing Then Return gl.ClientVisible
    '        Return True
    '    End Get
    'End Property
    'Private Sub CargarMunicipios()
    '    Me.odsMunicipio.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO_V.Value
    '    Me.odsMunicipio.SelectParameters("agregarVacio").DefaultValue = True
    '    Me.odsMunicipio.SelectParameters("agregarTodos").DefaultValue = False
    '    Me.odsMunicipio.SelectParameters("conPresencia").DefaultValue = False
    '    Me.cbxMUNICIPIO_V.DataBind()
    '    Me.cbxMUNICIPIO_V.Focus()
    'End Sub
#End Region
#Region "Propiedades"

    Private _CODIPROVEEDOR As String
    Public Property CODIPROVEEDOR() As String
        Get
            Return Me.txtCODIPROVEEDOR_V.Text
        End Get
        Set(ByVal Value As String)
            Me._CODIPROVEEDOR = Value
            Me.txtCODIPROVEEDOR_V.Text = Value
            If Me._CODIPROVEEDOR <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CODIPROVEE() As String
        Get
            Return Me.txtCODIPROVEE_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEE_V.Text = value.ToString()
        End Set
    End Property

    Public Property APELLIDOS() As String
        Get
            Return Me.txtAPELLIDOS_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtAPELLIDOS_V.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRES() As String
        Get
            Return Me.txtNOMBRES_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRES_V.Text = value.ToString()
        End Set
    End Property

    'Public Property EDAD() As String
    '    Get
    '        Return Me.txtEDAD.Text
    '    End Get
    '    Set(ByVal value As String)
    '        Me.txtEDAD.Text = value.ToString()
    '    End Set
    'End Property

    Public Property DIRECCION() As String
        Get
            Return Me.txtDIRECCION_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtDIRECCION_V.Text = value.ToString()
        End Set
    End Property

    Public Property TELEFONO() As String
        Get
            Return Me.txtTELEFONO_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONO_V.Text = value.ToString()
        End Set
    End Property

    Public Property CELULAR() As String
        Get
            Return Me.txtCELULAR_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtCELULAR_V.Text = value.ToString()
        End Set
    End Property

    Public Property DUI() As String
        Get
            Return Me.txtDUI_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtDUI_V.Text = value.ToString()
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.txtNIT_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtNIT_V.Text = value.ToString()
        End Set
    End Property

    Public Property CREDITFISCAL() As String
        Get
            Return Me.txtEDAD_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtEDAD_V.Text = value.ToString()
        End Set
    End Property

    Public Property PROFESION() As String
        Get
            Return Me.txtPROFESION_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtPROFESION_V.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRENIT() As String
        Get
            Return Me.txtNOMBRENIT_V.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRENIT_V.Text = value.ToString()
        End Set
    End Property
    Public Property ID_TIPO_PERSONA() As Integer
        Get
            Return Me.cbxTIPO_PERSONA_V.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxTIPO_PERSONA_V.Text = value
        End Set
    End Property
    Public Property CODI_DEPTO() As Integer
        Get
            Return Me.cbxDEPARTAMENTO_V.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxDEPARTAMENTO_V.Value = value
        End Set
    End Property
    Public Property CODI_MUNICIPIO() As Integer
        Get
            Return Me.cbxMUNICIPIO_V.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxMUNICIPIO_V.Value = value
        End Set
    End Property


    'Public Property APODERADO() As String
    '    Get
    '        Return Me.txtAPODERADO_V.Text
    '    End Get
    '    Set(ByVal value As String)
    '        Me.txtAPODERADO.Text = value.ToString()
    '    End Set
    'End Property

    'Public Property DUI_APODERADO() As String
    '    Get
    '        Return Me.txtDUI_APODERADO.Text
    '    End Get
    '    Set(ByVal value As String)
    '        Me.txtDUI_APODERADO.Text = value.ToString()
    '    End Set
    'End Property

    'Public Property NIT_APODERADO() As String
    '    Get
    '        Return Me.txtNIT_APODERADO.Text
    '    End Get
    '    Set(ByVal value As String)
    '        Me.txtNIT_APODERADO.Text = value.ToString()
    '    End Set
    'End Property

    'Public Property USER_CREA() As Int32
    '    Get
    '        If Me.txtUSER_CREA.Value Is Nothing Then Return -1
    '        Return CInt(Me.txtUSER_CREA.Value)
    '    End Get
    '    Set(ByVal value As Int32)
    '        Me.txtUSER_CREA.Value = value
    '    End Set
    'End Property

    'Public Property FECHA_CREA() As DateTime
    '    Get
    '        Return Me.deFECHA_CREA.Value
    '    End Get
    '    Set(ByVal value As DateTime)
    '        Me.deFECHA_CREA.Value = value
    '    End Set
    'End Property

    'Public Property USER_ACT() As Int32
    '    Get
    '        If Me.txtUSER_ACT.Value Is Nothing Then Return -1
    '        Return CInt(Me.txtUSER_ACT.Value)
    '    End Get
    '    Set(ByVal value As Int32)
    '        Me.txtUSER_ACT.Value = value
    '    End Set
    'End Property

    'Public Property FECHA_ACT() As DateTime
    '    Get
    '        Return Me.deFECHA_ACT.Value
    '    End Get
    '    Set(ByVal value As DateTime)
    '        Me.deFECHA_ACT.Value = value
    '    End Set
    'End Property

    Public Property FECHA_NAC() As DateTime
        Get
            Return Me.dteFECHA_NACIMIENTO_V.Value
        End Get
        Set(ByVal value As DateTime)
            Me.dteFECHA_NACIMIENTO_V.Value = value
        End Set
    End Property

    Public Property TIPO_CONTRIBUYENTE() As Int32
        Get
            If Me.rdbTIPO_CONTRIBUYENTE_V.Value Is Nothing Then Return -1
            Return CInt(Me.rdbTIPO_CONTRIBUYENTE_V.Value)
        End Get
        Set(ByVal value As Int32)
            Me.rdbTIPO_CONTRIBUYENTE_V.Value = value
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPROVEEDOR
    Private mEntidad As PROVEEDOR
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

    Public Property VisibleEnCliente As Boolean
        Set(value As Boolean)
            Dim gl As LayoutGroup = Me.ucVistaDetallePROVEEDORLayout.FindItemOrGroupByName("lgVistaDetallePROVEEDOR")
            If gl IsNot Nothing Then
                gl.ClientVisible = value
            End If
        End Set
        Get
            Dim gl As LayoutGroup = Me.ucVistaDetallePROVEEDORLayout.FindItemOrGroupByName("lgVistaDetallePROVEEDOR")
            If gl IsNot Nothing Then Return gl.ClientVisible
            Return True
        End Get
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            If Me.hfucVistaDetallePROVEEDOR.Contains("nuevo") Then
                Me.hfucVistaDetallePROVEEDOR("nuevo") = False
            Else
                Me.hfucVistaDetallePROVEEDOR.Add("nuevo", False)
            End If
        End If
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("CODIPROVEEDOR") Is Nothing Then Me._CODIPROVEEDOR = Me.ViewState("CODIPROVEEDOR")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        Me.hfucVistaDetallePROVEEDOR("nuevo") = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PROVEEDOR
        mEntidad.CODIPROVEEDOR = CODIPROVEEDOR

        If mComponente.ObtenerPROVEEDOR(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        Me.txtCODIPROVEEDOR_V.Text = mEntidad.CODIPROVEEDOR

        Me.txtCODIPROVEE_V.Text = mEntidad.CODIPROVEE
        Me.txtAPELLIDOS_V.Text = mEntidad.APELLIDOS.Trim
        Me.txtNOMBRES_V.Text = mEntidad.NOMBRES.Trim
        Me.txtDIRECCION_V.Text = mEntidad.DIRECCION.Trim
        Me.txtTELEFONO_V.Text = mEntidad.TELEFONO.Trim
        Me.txtCELULAR_V.Text = mEntidad.CELULAR.Trim
        Me.txtDUI_V.Text = mEntidad.DUI.Trim
        Me.txtNIT_V.Text = mEntidad.NIT.Trim

        Me.txtNOMBRE_REPRESENTANTE_V.Text = mEntidad.APODERADO
        Me.txtDUI_REPRESENTANTE_V.Text = mEntidad.DUI_APODERADO.Trim
        Me.txtNIT_REPRESENTANTE_V.Text = mEntidad.NIT_APODERADO

        Me.txtEDAD_V.Text = mEntidad.EDAD.Trim
        Me.txtPROFESION_V.Text = mEntidad.PROFESION.Trim
        Me.txtNOMBRENIT_V.Text = mEntidad.NOMBRENIT.Trim
        Me.rdbTIPO_CONTRIBUYENTE_V.Value = mEntidad.TIPO_CONTRIBUYENTE
        Me.txtNRC_V.Text = mEntidad.CREDITFISCAL
        Me.txtACTIVIDAD.Text = mEntidad.ACTIVIDAD
        Me.dteFECHA_NACIMIENTO_V.Date = mEntidad.FECHA_NAC

        Me.cbxTIPO_PERSONA_V.Value = mEntidad.ID_TIPO_PERSONA
        Me.cbxDEPARTAMENTO_V.Value = mEntidad.CODI_DEPTO
        Me.CargarMunicipios()
        Me.cbxMUNICIPIO_V.Value = mEntidad.CODI_MUNI
        Me.txtCorreo_V.Value = mEntidad.CORREO



        If mEntidad.FECHA_NAC <> #12:00:00 AM# Then
            Me.txtEDAD_V.Text = Utilerias.ObtenerEdad(mEntidad.FECHA_NAC, cFechaHora.ObtenerFecha)
        Else
            Me.txtEDAD_V.Text = ""
        End If
        If mEntidad.CODIBANCO = -1 Then
            Me.cbxBANCO_PAGO_CTA.SelectedIndex = -1
        Else
            Me.cbxBANCO_PAGO_CTA.Value = mEntidad.CODIBANCO
        End If
        Me.txtNUM_CUENTA.Text = mEntidad.NUM_CUENTA
        Me.chkES_CTA_CORRIENTE.Checked = mEntidad.ES_CTA_CORRIENTE
        Me.ConfigurarTipoPersona()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtCODIPROVEE_V.ClientEnabled = Me.hfucVistaDetallePROVEEDOR("nuevo") AndAlso edicion
        Me.cbxTIPO_PERSONA_V.ClientEnabled = Me._nuevo
        If Me.cbxTIPO_PERSONA_V.Value = Nothing Then
            Me.txtDUI_V.ClientEnabled = False
            Me.txtNIT_V.ClientEnabled = False
            Me.txtNOMBRES_V.ClientEnabled = edicion
            Me.txtAPELLIDOS_V.ClientEnabled = False
        ElseIf Me.cbxTIPO_PERSONA_V.Value = TipoPersona.Natural Then
            Me.txtDUI_V.ClientEnabled = edicion
            Me.txtNIT_V.ClientEnabled = edicion
            Me.txtNOMBRES_V.ClientEnabled = edicion
            Me.txtAPELLIDOS_V.ClientEnabled = edicion
        ElseIf Me.cbxTIPO_PERSONA_V.Value = TipoPersona.Juridica Then
            Me.txtDUI_V.ClientEnabled = False
            Me.txtNIT_V.ClientEnabled = edicion
            Me.txtNOMBRES_V.ClientEnabled = edicion
            Me.txtAPELLIDOS_V.ClientEnabled = False
        End If
        Me.txtDIRECCION_V.ClientEnabled = edicion
        Me.txtTELEFONO_V.ClientEnabled = edicion
        Me.txtCELULAR_V.ClientEnabled = edicion
        Me.txtNOMBRE_REPRESENTANTE_V.ClientEnabled = edicion
        Me.txtDUI_REPRESENTANTE_V.ClientEnabled = edicion
        Me.txtNIT_REPRESENTANTE_V.ClientEnabled = edicion
        Me.txtEDAD_V.ClientEnabled = False
        Me.txtPROFESION_V.ClientEnabled = edicion
        Me.txtNOMBRENIT_V.ClientEnabled = edicion
        If Me.rdbTIPO_CONTRIBUYENTE_V.Value = 1 OrElse Me.rdbTIPO_CONTRIBUYENTE_V.Value = 2 Then
            Me.txtNRC_V.ClientEnabled = edicion
            Me.txtACTIVIDAD.ClientEnabled = edicion
        Else
            Me.txtNRC_V.ClientEnabled = False
            Me.txtACTIVIDAD.ClientEnabled = False
        End If
        Me.dteFECHA_NACIMIENTO_V.ClientEnabled = edicion
        Me.cbxBANCO_PAGO_CTA.ClientEnabled = edicion
        Me.txtNUM_CUENTA.ClientEnabled = edicion
        Me.chkES_CTA_CORRIENTE.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        Me.hfucVistaDetallePROVEEDOR("nuevo") = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")

        Dim bProveedor As New cPROVEEDOR

        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtCODIPROVEEDOR_V.Text = ""
        Me.txtCODIPROVEE_V.Value = bProveedor.ObtenerCorrelativoProveedor
        Me.txtAPELLIDOS_V.Text = ""
        Me.txtNOMBRES_V.Text = ""
        Me.txtDIRECCION_V.Text = ""
        Me.txtTELEFONO_V.Text = ""
        Me.txtCELULAR_V.Text = ""
        Me.txtDUI_V.Text = ""
        Me.txtNIT_V.Text = ""
        Me.txtNOMBRE_REPRESENTANTE_V.Text = ""
        Me.txtDUI_REPRESENTANTE_V.Text = ""
        Me.txtNIT_REPRESENTANTE_V.Text = ""
        Me.txtEDAD_V.Text = ""
        Me.txtPROFESION_V.Text = ""
        Me.txtNOMBRENIT_V.Text = ""
        Me.rdbTIPO_CONTRIBUYENTE_V.Value = Nothing
        Me.dteFECHA_NACIMIENTO_V.Value = Nothing
        Me.cbxBANCO_PAGO_CTA.Value = Nothing
        Me.txtNUM_CUENTA.Text = ""
        Me.chkES_CTA_CORRIENTE.Checked = False
        Me.cbxTIPO_PERSONA_V.Value = ""
        Me.cbxDEPARTAMENTO_V.Value = ""
        Me.cbxMUNICIPIO_V.Value = ""
        Me.txtCORREO_V.Text = ""
        Me.txtNRC_V.Text = ""
        Me.txtACTIVIDAD.Text = ""
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PROVEEDOR
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lEntidad As PROVEEDOR

        mEntidad = New PROVEEDOR
        If Me._nuevo Then
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            If Me.txtCODIPROVEE_V.Text = "" Then
                Return "Ingrese el Codigo de Proveedor"
            Else
                mEntidad.CODIPROVEE = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE_V.Value)
            End If
            mEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0)
            mEntidad.CODIPROVEEDOR = mEntidad.CODIPROVEE + mEntidad.CODISOCIO
            lEntidad = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
            If lEntidad IsNot Nothing Then
                Return "Codigo de proveedor/socio ya esta asignado a otro proveedor"
            End If
        Else
            mEntidad = mComponente.ObtenerPROVEEDOR(Me.txtCODIPROVEEDOR_V.Text)
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If Me.txtNRC_V.Text.Trim <> "" AndAlso Me.txtACTIVIDAD.Text.Trim = "" Then
            Return "Ingrese la actividad economica primaria"
        End If

        If Me.cbxBANCO_PAGO_CTA.Value IsNot Nothing AndAlso Me.txtNUM_CUENTA.Text.Trim = "" Then
            Return "Ingrese el No de Cuenta bancaria"
        End If
        If Me.cbxBANCO_PAGO_CTA.Value Is Nothing AndAlso Me.txtNUM_CUENTA.Text.Trim <> "" Then
            Return "Seleccione el Banco del pago a cuenta"
        End If
        
        mEntidad.APELLIDOS = Me.txtAPELLIDOS_V.Text.Trim.ToUpper
        mEntidad.NOMBRES = Me.txtNOMBRES_V.Text.Trim.ToUpper
        mEntidad.EDAD = Me.txtEDAD_V.Text
        mEntidad.DIRECCION = Me.txtDIRECCION_V.Text.ToUpper
        mEntidad.TELEFONO = Me.txtTELEFONO_V.Text.ToUpper
        mEntidad.CELULAR = Me.txtCELULAR_V.Text.ToUpper
        mEntidad.DUI = Me.txtDUI_V.Text
        mEntidad.NIT = Me.txtNIT_V.Text
        mEntidad.FECHA_NAC = Me.dteFECHA_NACIMIENTO_V.Date

        If (Me.txtNOMBRE_REPRESENTANTE_V.Text <> "" AndAlso Me.txtDUI_REPRESENTANTE_V.Text = "") Then
            Return "Ingrese el DUI del Representante Legal"
        End If

        If Me.txtNOMBRE_REPRESENTANTE_V.Text = "" AndAlso (Me.txtDUI_REPRESENTANTE_V.Text <> "" OrElse Me.txtNIT_REPRESENTANTE_V.Text <> "") Then
            Return "Ingrese el Nombre del Representante Legal"
        End If


        mEntidad.ACTIVIDAD = Me.txtACTIVIDAD.Text.Trim.ToUpper
        mEntidad.PROFESION = Me.txtPROFESION_V.Text.ToUpper
        mEntidad.NOMBRENIT = Me.txtNOMBRENIT_V.Text.ToUpper
        mEntidad.TIPO_CONTRIBUYENTE = Me.rdbTIPO_CONTRIBUYENTE_V.Value
        mEntidad.CREDITFISCAL = Me.txtNRC_V.Text

        mEntidad.APODERADO = Me.txtNOMBRE_REPRESENTANTE_V.Text.ToUpper
        mEntidad.DUI_APODERADO = Me.txtDUI_REPRESENTANTE_V.Text.ToUpper
        mEntidad.NIT_APODERADO = Me.txtNIT_REPRESENTANTE_V.Text.ToUpper

        If Me.cbxBANCO_PAGO_CTA.Value IsNot Nothing Then
            mEntidad.CODIBANCO = Me.cbxBANCO_PAGO_CTA.Value
        Else
            mEntidad.CODIBANCO = -1
        End If

        mEntidad.NUM_CUENTA = Me.txtNUM_CUENTA.Text.Trim
        mEntidad.ES_CTA_CORRIENTE = Me.chkES_CTA_CORRIENTE.Checked

        mEntidad.CODI_DEPTO = Me.cbxDEPARTAMENTO_V.Value
        mEntidad.CODI_MUNI = Me.cbxMUNICIPIO_V.Value
        mEntidad.CORREO = Me.txtCorreo_V.Value
        mEntidad.ID_TIPO_PERSONA = Me.cbxTIPO_PERSONA_V.Value

        If (Me.rdbTIPO_CONTRIBUYENTE_V.Value = 1 OrElse Me.rdbTIPO_CONTRIBUYENTE_V.Value = 2) AndAlso (Me.txtNRC_V.Value Is Nothing OrElse Me.txtNRC_V.Value = "") Then
            Return "Ingrese el Numero de Registro de Contribuyente"
        End If

        If Me._nuevo Then
            If mComponente.AgregarPROVEEDOR(mEntidad) <> 1 Then
                Return "Error al Guardar registro. " + mComponente.sError
            End If
        Else
            If mComponente.ActualizarPROVEEDOR(mEntidad) <> 1 Then
                Return "Error al Guardar registro. " + mComponente.sError
            End If
        End If

        Me.txtCODIPROVEEDOR_V.Text = mEntidad.CODIPROVEEDOR.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub rdbTIPO_CONTRIBUYENTE_V_ValueChanged(sender As Object, e As System.EventArgs) Handles rdbTIPO_CONTRIBUYENTE_V.ValueChanged
        If rdbTIPO_CONTRIBUYENTE_V.Value = 0 Then
            Me.txtNRC_V.Text = ""
            Me.txtACTIVIDAD.Text = ""
            Me.txtNRC_V.ClientEnabled = False
            Me.txtACTIVIDAD.ClientEnabled = False
        Else
            Me.txtNRC_V.ClientEnabled = True
            Me.txtACTIVIDAD.ClientEnabled = True
        End If
    End Sub
    Protected Sub cbxTIPO_PERSONA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTIPO_PERSONA_V.SelectedIndexChanged
        Me.ConfigurarTipoPersona()
    End Sub

    Private Sub ConfigurarTipoPersona()
        If Me.cbxTIPO_PERSONA_V.Value = TipoPersona.Natural Then
            Me.txtDUI_V.ClientEnabled = True
            Me.txtNIT_V.ClientEnabled = True
            Me.txtAPELLIDOS_V.ClientEnabled = True
            'Me.txtNIT_V.Text = ""
        ElseIf Me.cbxTIPO_PERSONA_V.Value = TipoPersona.Juridica Then
            Me.txtDUI_V.Text = ""
            Me.txtDUI_V.ClientEnabled = False
            Me.txtNIT_V.ClientEnabled = True
            Me.txtAPELLIDOS_V.Text = ""
            Me.txtAPELLIDOS_V.ClientEnabled = False
        End If
    End Sub
    Private Sub CargarMunicipios()
        Me.odsMunicipio.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO_V.Value
        Me.odsMunicipio.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsMunicipio.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsMunicipio.SelectParameters("conPresencia").DefaultValue = False
        Me.cbxMUNICIPIO_V.DataBind()
        Me.cbxMUNICIPIO_V.Focus()
    End Sub

    'Protected Sub txtDUI_ValueChanged(sender As Object, e As EventArgs) Handles txtDUI_V.ValueChanged
    '    If Me.txtDUI_V.Text.Length = 9 Then
    '        Me.txtNIT_V.Text = Utilerias.RellenarIzquierda(Me.txtDUI_V.Text.Trim, 14, "0")
    '    Else
    '        Me.txtNIT_V.Text = ""
    '    End If
    'End Sub
    Protected Sub cbxDEPARTAMENTO_V_ValueChanged(sender As Object, e As EventArgs) Handles cbxDEPARTAMENTO_V.ValueChanged
        Me.CargarMunicipios()
    End Sub
End Class
