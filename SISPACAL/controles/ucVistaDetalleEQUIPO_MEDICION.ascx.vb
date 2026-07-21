Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleEQUIPO_MEDICION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla EQUIPO_MEDICION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleEQUIPO_MEDICION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_EQUIPO As Int32
    Public Property ID_EQUIPO() As Int32
        Get
            Return Me.txtID_EQUIPO.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_EQUIPO = Value
            Me.txtID_EQUIPO.Text = CStr(Value)
            If Me._ID_EQUIPO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_EQUIPO() As String
        Get
            Return Me.txtNOMBRE_EQUIPO.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_EQUIPO.Text = value.ToString()
        End Set
    End Property

    Public Property PUERTO() As String
        Get
            Return Me.txtPUERTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtPUERTO.Text = value.ToString()
        End Set
    End Property

    Public Property BITS_POR_SEGUNDO() As Decimal
        Get
            If Me.txtBITS_POR_SEGUNDO.Text ="" Then Return -1
            Return Me.txtBITS_POR_SEGUNDO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtBITS_POR_SEGUNDO.Text = value.ToString()
        End Set
    End Property

    Public Property BITS_DATOS() As Decimal
        Get
            If Me.txtBITS_DATOS.Text ="" Then Return -1
            Return Me.txtBITS_DATOS.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtBITS_DATOS.Text = value.ToString()
        End Set
    End Property

    Public Property PARIDAD() As String
        Get
            Return Me.txtPARIDAD.Text
        End Get
        Set(ByVal value As String)
            Me.txtPARIDAD.Text = value.ToString()
        End Set
    End Property

    Public Property BITS_PARADA() As Decimal
        Get
            If Me.txtBITS_PARADA.Text ="" Then Return -1
            Return Me.txtBITS_PARADA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtBITS_PARADA.Text = value.ToString()
        End Set
    End Property

    Public Property CONTROL_FLUJO() As String
        Get
            Return Me.txtCONTROL_FLUJO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCONTROL_FLUJO.Text = value.ToString()
        End Set
    End Property

    Public Property HABILITADO() As Boolean
        Get
            Return Me.cbxHABILITADO.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxHABILITADO.Checked = value
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
            Return Me.txtFECHA_CREA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_CREA.Text = value.ToString("dd/MM/yyyy")
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
            Return Me.txtFECHA_ACT.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ACT.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property VerID_EQUIPO() As Boolean
        Get
            Return Me.trID_EQUIPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_EQUIPO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_EQUIPO() As Boolean
        Get
            Return Me.trNOMBRE_EQUIPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_EQUIPO.Visible = value
        End Set
    End Property

    Public Property VerPUERTO() As Boolean
        Get
            Return Me.trPUERTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPUERTO.Visible = value
        End Set
    End Property

    Public Property VerBITS_POR_SEGUNDO() As Boolean
        Get
            Return Me.trBITS_POR_SEGUNDO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBITS_POR_SEGUNDO.Visible = value
        End Set
    End Property

    Public Property VerBITS_DATOS() As Boolean
        Get
            Return Me.trBITS_DATOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBITS_DATOS.Visible = value
        End Set
    End Property

    Public Property VerPARIDAD() As Boolean
        Get
            Return Me.trPARIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARIDAD.Visible = value
        End Set
    End Property

    Public Property VerBITS_PARADA() As Boolean
        Get
            Return Me.trBITS_PARADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBITS_PARADA.Visible = value
        End Set
    End Property

    Public Property VerCONTROL_FLUJO() As Boolean
        Get
            Return Me.trCONTROL_FLUJO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONTROL_FLUJO.Visible = value
        End Set
    End Property

    Public Property VerHABILITADO() As Boolean
        Get
            Return Me.trHABILITADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trHABILITADO.Visible = value
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

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cEQUIPO_MEDICION
    Private mEntidad As EQUIPO_MEDICION
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
        If Not Me.ViewState("ID_EQUIPO") Is Nothing Then Me._ID_EQUIPO = Me.ViewState("ID_EQUIPO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla EQUIPO_MEDICION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New EQUIPO_MEDICION
        mEntidad.ID_EQUIPO = ID_EQUIPO
 
        If mComponente.ObtenerEQUIPO_MEDICION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_EQUIPO.Text = mEntidad.ID_EQUIPO.ToString()
        Me.txtNOMBRE_EQUIPO.Text = mEntidad.NOMBRE_EQUIPO
        Me.txtPUERTO.Text = mEntidad.PUERTO
        Me.txtBITS_POR_SEGUNDO.Text = mEntidad.BITS_POR_SEGUNDO
        Me.txtBITS_DATOS.Text = mEntidad.BITS_DATOS
        Me.txtPARIDAD.Text = mEntidad.PARIDAD
        Me.txtBITS_PARADA.Text = mEntidad.BITS_PARADA
        Me.txtCONTROL_FLUJO.Text = mEntidad.CONTROL_FLUJO
        Me.cbxHABILITADO.Checked = mEntidad.HABILITADO
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE_EQUIPO.Enabled = edicion
        Me.txtPUERTO.Enabled = edicion
        Me.txtBITS_POR_SEGUNDO.Enabled = edicion
        Me.txtBITS_DATOS.Enabled = edicion
        Me.txtPARIDAD.Enabled = edicion
        Me.txtBITS_PARADA.Enabled = edicion
        Me.txtCONTROL_FLUJO.Enabled = edicion
        Me.cbxHABILITADO.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOMBRE_EQUIPO.Text = ""
        Me.txtPUERTO.Text = ""
        Me.txtBITS_POR_SEGUNDO.Text = ""
        Me.txtBITS_DATOS.Text = ""
        Me.txtPARIDAD.Text = ""
        Me.txtBITS_PARADA.Text = ""
        Me.txtCONTROL_FLUJO.Text = ""
        Me.cbxHABILITADO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla EQUIPO_MEDICION
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New EQUIPO_MEDICION
        If Me._nuevo Then
            mEntidad.ID_EQUIPO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cEQUIPO_MEDICION).ObtenerEQUIPO_MEDICION(CInt(Me.txtID_EQUIPO.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.NOMBRE_EQUIPO = Me.txtNOMBRE_EQUIPO.Text
        mEntidad.PUERTO = Me.txtPUERTO.Text
        mEntidad.BITS_POR_SEGUNDO = Val(Me.txtBITS_POR_SEGUNDO.Text)
        mEntidad.BITS_DATOS = Val(Me.txtBITS_DATOS.Text)
        mEntidad.PARIDAD = Me.txtPARIDAD.Text
        mEntidad.BITS_PARADA = Val(Me.txtBITS_PARADA.Text)
        mEntidad.CONTROL_FLUJO = Me.txtCONTROL_FLUJO.Text
        mEntidad.HABILITADO = Me.cbxHABILITADO.Checked

        If mComponente.ActualizarEQUIPO_MEDICION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_EQUIPO.Text = mEntidad.ID_EQUIPO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
