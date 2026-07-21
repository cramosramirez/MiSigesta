Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleUSUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleUSUARIO
    Inherits ucBase
 
#Region"Propiedades"

    Private _USUARIO As String
    Public Property USUARIO() As String
        Get
            Return Me.txtUSUARIO.Text
        End Get
        Set(ByVal Value As String)
            Me._USUARIO = Value
            Me.txtUSUARIO.Text = Value
            If Me._USUARIO <> "" Then
                If Me.hfUsuario.Contains("Nuevo") Then Me.hfUsuario.Add("Nuevo", 0) Else Me.hfUsuario("Nuevo") = 0
                Me.CargarDatos()
            Else
                If Me.hfUsuario.Contains("Nuevo") Then Me.hfUsuario.Add("Nuevo", 1) Else Me.hfUsuario("Nuevo") = 1
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_PERFIL() As Int32
        Get
            Return Me.cbxPERFIL.Value
        End Get
        Set(ByVal value As Int32)
            cbxPERFIL.Value = value
        End Set
    End Property

    Public Property NOMBRE_USUARIO() As String
        Get
            Return Me.txtNOMBRE_USUARIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_USUARIO.Text = value.ToString()
        End Set
    End Property

    Public Property EMAIL() As String
        Get
            Return Me.txtEMAIL.Text
        End Get
        Set(ByVal value As String)
            Me.txtEMAIL.Text = value.ToString()
        End Set
    End Property

    Public Property CLAVE() As String
        Get
            Return Me.txtCLAVE.Text
        End Get
        Set(ByVal value As String)
            Me.txtCLAVE.Text = value.ToString()
        End Set
    End Property

    Public Property ACTIVO() As Boolean
        Get
            Return Me.chkActivo.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkActivo.Checked = value
        End Set
    End Property

    Public Property BLOQUEADO() As Boolean
        Get
            Return Me.chkBloqueado.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkBloqueado.Checked = value
        End Set
    End Property


    Public Property FECHA_ULTACCESO() As DateTime
        Get
            Return Me.dteFECHA_ULT_ACCESO.Text
        End Get
        Set(ByVal value As DateTime)
            Me.dteFECHA_ULT_ACCESO.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

   
    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cUSUARIO
    Private mEntidad As USUARIO
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
        If Not Me.ViewState("USUARIO") Is Nothing Then Me._USUARIO = Me.ViewState("USUARIO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla USUARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New USUARIO
        mEntidad.USUARIO = USUARIO
 
        If mComponente.ObtenerUSUARIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtUSUARIO.Text = mEntidad.USUARIO
        Me.cbxPERFIL.Value = mEntidad.ID_PERFIL
        Me.txtNOMBRE_USUARIO.Text = mEntidad.NOMBRE
        Me.txtEMAIL.Text = mEntidad.EMAIL
        Me.chkActivo.Checked = mEntidad.ACTIVO
        Me.chkBloqueado.Checked = mEntidad.BLOQUEADO
        Me.dteFECHA_ULT_ACCESO.Value = mEntidad.FECHA_ULTACCESO
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtUSUARIO.ClientEnabled = Me._nuevo
        Me.cbxPERFIL.ClientEnabled = edicion
        Me.txtNOMBRE_USUARIO.ClientEnabled = edicion
        Me.txtEMAIL.ClientEnabled = edicion
        Me.txtCLAVE.ClientEnabled = edicion
        Me.chkActivo.ClientEnabled = edicion
        Me.chkBloqueado.ClientEnabled = edicion
        Me.dteFECHA_ULT_ACCESO.ClientEnabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxPERFIL.Text = ""
        Me.txtNOMBRE_USUARIO.Text = ""
        Me.txtEMAIL.Text = ""
        Me.txtCLAVE.Text = ""
        Me.chkActivo.Checked = False
        Me.chkBloqueado.Checked = False
        Me.dteFECHA_ULT_ACCESO.Value = Nothing
        Me.chkActivo.Checked = True
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla USUARIO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New USUARIO
        If Me._nuevo Then
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad.CLAVE = Me.txtCLAVE.Text
        Else
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad = (New cUSUARIO).ObtenerUSUARIO(Me.txtUSUARIO.Text)
            If Me.txtCLAVE.Text <> "121131313131" Then
                mEntidad.CLAVE = Me.txtCLAVE.Text
            End If
        End If
        mEntidad.USUARIO = Me.txtUSUARIO.Text
        mEntidad.ID_PERFIL = Me.cbxPERFIL.Value
        mEntidad.NOMBRE = Me.txtNOMBRE_USUARIO.Text
        mEntidad.EMAIL = Me.txtEMAIL.Text
        mEntidad.ACTIVO = Me.chkActivo.Checked
        mEntidad.BLOQUEADO = Me.chkBloqueado.Checked

        If Me._nuevo Then
            If mComponente.AgregarUSUARIO(mEntidad) <> 1 Then
                Return "Error al Guardar registro. " + mComponente.sError
            End If
        Else
            If mComponente.ActualizarUSUARIO(mEntidad) <> 1 Then
                Return "Error al Guardar registro. " + mComponente.sError
            End If
        End If
        Me.txtUSUARIO.Text = mEntidad.USUARIO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
