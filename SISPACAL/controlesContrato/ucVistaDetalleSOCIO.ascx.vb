Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

Partial Class controlesContrato_ucVistaDetalleSOCIO
    Inherits ucBase


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
            Dim gl As LayoutGroup = Me.ucVistaDetalleSOCIOLayout.FindItemOrGroupByName("lgVistaDetalleSOCIO")
            If gl IsNot Nothing Then
                gl.ClientVisible = value
            End If
        End Set
        Get
            Dim gl As LayoutGroup = Me.ucVistaDetalleSOCIOLayout.FindItemOrGroupByName("lgVistaDetalleSOCIO")
            If gl IsNot Nothing Then Return gl.ClientVisible
            Return True
        End Get
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            If Me.hfucVistaDetalleSOCIO.Contains("nuevo") Then
                Me.hfucVistaDetalleSOCIO("nuevo") = False
            Else
                Me.hfucVistaDetalleSOCIO.Add("nuevo", False)
            End If
        End If
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("CODIPROVEEDOR") Is Nothing Then Me._CODIPROVEEDOR = Me.ViewState("CODIPROVEEDOR")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        Me.hfucVistaDetalleSOCIO("nuevo") = False
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
        Me.txtEDAD_V.Text = mEntidad.EDAD.Trim
        Me.txtPROFESION_V.Text = mEntidad.PROFESION.Trim
        Me.txtNOMBRENIT_V.Text = mEntidad.NOMBRENIT.Trim
        Me.rdbTIPO_CONTRIBUYENTE_V.Value = mEntidad.TIPO_CONTRIBUYENTE
        Me.txtNRC_V.Text = mEntidad.CREDITFISCAL
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtCODIPROVEE_V.ClientEnabled = Me.hfucVistaDetalleSOCIO("nuevo") AndAlso edicion
        Me.txtCODISOCIO_V.ClientEnabled = Me.hfucVistaDetalleSOCIO("nuevo") AndAlso edicion
        Me.txtAPELLIDOS_V.ClientEnabled = edicion
        Me.txtNOMBRES_V.ClientEnabled = edicion
        Me.txtDIRECCION_V.ClientEnabled = False
        Me.txtDIRECCION_V.ClientEnabled = edicion
        Me.txtTELEFONO_V.ClientEnabled = edicion
        Me.txtCELULAR_V.ClientEnabled = edicion
        Me.txtDUI_V.ClientEnabled = edicion
        Me.txtNIT_V.ClientEnabled = edicion
        Me.txtEDAD_V.ClientEnabled = False
        Me.txtPROFESION_V.ClientEnabled = edicion
        Me.txtNOMBRENIT_V.ClientEnabled = edicion
        If Me.rdbTIPO_CONTRIBUYENTE_V.Value = 1 OrElse Me.rdbTIPO_CONTRIBUYENTE_V.Value = 2 Then
            Me.txtNRC_V.ClientEnabled = edicion
        Else
            Me.txtNRC_V.ClientEnabled = False
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        Me.hfucVistaDetalleSOCIO("nuevo") = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtCODIPROVEEDOR_V.Text = ""
        Me.txtCODIPROVEE_V.Text = ""
        Me.txtCODISOCIO_V.Text = ""
        Me.txtAPELLIDOS_V.Text = ""
        Me.txtNOMBRES_V.Text = ""
        Me.txtDIRECCION_V.Text = ""
        Me.txtDIRECCION_V.Text = ""
        Me.txtTELEFONO_V.Text = ""
        Me.txtCELULAR_V.Text = ""
        Me.txtDUI_V.Text = ""
        Me.txtNIT_V.Text = ""
        Me.txtEDAD_V.Text = ""
        Me.txtPROFESION_V.Text = ""
        Me.txtNOMBRENIT_V.Text = ""
        Me.rdbTIPO_CONTRIBUYENTE_V.Value = Nothing
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla PROVEEDOR
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
            mEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(Me.txtCODISOCIO_V.Value)
            mEntidad.CODIPROVEEDOR = mEntidad.CODIPROVEE + mEntidad.CODISOCIO
            lEntidad = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
            If lEntidad IsNot Nothing Then
                Return "Codigo de socio ya esta asignado a otro socio"
            End If
        Else
            mEntidad = mComponente.ObtenerPROVEEDOR(Me.txtCODIPROVEEDOR_V.Text)
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.APELLIDOS = Me.txtAPELLIDOS_V.Text.ToUpper
        mEntidad.NOMBRES = Me.txtNOMBRES_V.Text.ToUpper
        mEntidad.EDAD = Me.txtEDAD_V.Text
        mEntidad.DIRECCION = Me.txtDIRECCION_V.Text.ToUpper
        mEntidad.TELEFONO = Me.txtTELEFONO_V.Text.ToUpper
        mEntidad.CELULAR = Me.txtCELULAR_V.Text.ToUpper
        mEntidad.DUI = Me.txtDUI_V.Text
        mEntidad.DUI_APODERADO = ""
        mEntidad.NIT = Me.txtNIT_V.Text
        mEntidad.NIT_APODERADO = ""
        mEntidad.CREDITFISCAL = Me.txtEDAD_V.Text
        mEntidad.PROFESION = Me.txtPROFESION_V.Text.ToUpper
        mEntidad.NOMBRENIT = Me.txtNOMBRENIT_V.Text.ToUpper
        mEntidad.TIPO_CONTRIBUYENTE = Me.rdbTIPO_CONTRIBUYENTE_V.Value
        mEntidad.CODIBANCO = -1
        mEntidad.NUM_CUENTA = ""
        mEntidad.ES_CTA_CORRIENTE = False
        mEntidad.ID_TIPO_PERSONA = -1

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
End Class
