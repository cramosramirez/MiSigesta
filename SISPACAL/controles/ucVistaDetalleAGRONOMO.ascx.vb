Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleAGRONOMO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla AGRONOMO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleAGRONOMO
    Inherits ucBase
 
#Region"Propiedades"

    Private _CODIAGRON As String
    Public Property CODIAGRON() As String
        Get
            Return Me.txtCODIAGRON.Text
        End Get
        Set(ByVal Value As String)
            Me._CODIAGRON = Value
            Me.txtCODIAGRON.Text = Value
            If Me._CODIAGRON <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property APELLIDO_AGRONOMO() As String
        Get
            Return Me.txtAPELLIDO_AGRONOMO.Text
        End Get
        Set(ByVal value As String)
            Me.txtAPELLIDO_AGRONOMO.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_AGRONOMO() As String
        Get
            Return Me.txtNOMBRE_AGRONOMO.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_AGRONOMO.Text = value.ToString()
        End Set
    End Property

    Public Property TELEF_AGRONOMO() As String
        Get
            Return Me.txtTELEF_AGRONOMO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEF_AGRONOMO.Text = value.ToString()
        End Set
    End Property

    

   
    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cAGRONOMO
    Private mEntidad As AGRONOMO
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
        If Not Me.ViewState("CODIAGRON") Is Nothing Then Me._CODIAGRON = Me.ViewState("CODIAGRON")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla AGRONOMO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New AGRONOMO
        mEntidad.CODIAGRON = CODIAGRON
 
        If mComponente.ObtenerAGRONOMO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtCODIAGRON.Text = mEntidad.CODIAGRON
        Me.txtAPELLIDO_AGRONOMO.Text = mEntidad.APELLIDO_AGRONOMO
        Me.txtNOMBRE_AGRONOMO.Text = mEntidad.NOMBRE_AGRONOMO
        Me.txtTELEF_AGRONOMO.Text = mEntidad.TELEF_AGRONOMO
        If mEntidad.ESTADO_AGRONOMO = 1 Then
            Me.chkACTIVO.Checked = True
        Else
            Me.chkACTIVO.Checked = False
        End If
        chkVerEnContrato.Checked = mEntidad.VER_CONTRATO
        Me.txtUSUARIO_SIGESTA.Text = mEntidad.USUARIO_SIGESTA
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtCODIAGRON.ClientEnabled = _nuevo AndAlso edicion
        Me.txtAPELLIDO_AGRONOMO.ClientEnabled = edicion
        Me.txtNOMBRE_AGRONOMO.ClientEnabled = edicion
        Me.txtTELEF_AGRONOMO.ClientEnabled = edicion
        Me.chkACTIVO.ClientEnabled = edicion
        Me.txtUSUARIO_SIGESTA.ClientEnabled = edicion
        chkVerEnContrato.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtCODIAGRON.Text = ""
        Me.txtAPELLIDO_AGRONOMO.Text = ""
        Me.txtNOMBRE_AGRONOMO.Text = ""
        Me.txtTELEF_AGRONOMO.Text = ""
        Me.chkACTIVO.Checked = True
        Me.txtUSUARIO_SIGESTA.Text = ""
        chkVerEnContrato.Checked = True
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla AGRONOMO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        If Me._nuevo Then
            mEntidad = New AGRONOMO
            mEntidad.CODIAGRON = Me.txtCODIAGRON.Text
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cAGRONOMO).ObtenerAGRONOMO(Me.txtCODIAGRON.Text)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.APELLIDO_AGRONOMO = Me.txtAPELLIDO_AGRONOMO.Text.ToUpper
        mEntidad.NOMBRE_AGRONOMO = Me.txtNOMBRE_AGRONOMO.Text.ToUpper
        mEntidad.TELEF_AGRONOMO = Me.txtTELEF_AGRONOMO.Text
        mEntidad.ZONA = Nothing
        mEntidad.VER_CONTRATO = chkVerEnContrato.Checked
        If chkACTIVO.Checked Then mEntidad.ESTADO_AGRONOMO = 1 Else mEntidad.ESTADO_AGRONOMO = 0
        If Me.txtUSUARIO_SIGESTA.Text.Trim = "" Then
            mEntidad.USUARIO_SIGESTA = Nothing
        Else
            mEntidad.USUARIO_SIGESTA = Me.txtUSUARIO_SIGESTA.Text.Trim
        End If
        If Me._nuevo Then
            If mComponente.AgregarAGRONOMO(mEntidad) <> 1 Then
                Return "Error al Guardar registro. " + mComponente.sError
            End If
        Else
            If mComponente.ActualizarAGRONOMO(mEntidad) <> 1 Then
                Return "Error al Guardar registro. " + mComponente.sError
            End If
        End If
        Me.txtCODIAGRON.Text = mEntidad.CODIAGRON.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
