Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleOPCION_PERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla OPCION_PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleOPCION_PERFIL
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_OPCION_PERFIL As Int32
    Public Property ID_OPCION_PERFIL() As Int32
        Get
            Return Me.txtID_OPCION_PERFIL.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_OPCION_PERFIL = Value
            Me.txtID_OPCION_PERFIL.Text = CStr(Value)
            If Me._ID_OPCION_PERFIL > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_PERFIL() As Int32
        Get
            Return Me.ddlPERFILID_PERFIL.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlPERFILID_PERFIL.Items.FindByValue(value) Is Nothing Then
                Me.ddlPERFILID_PERFIL.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_OPCION() As Int32
        Get
            Return Me.ddlOPCIONID_OPCION.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlOPCIONID_OPCION.Items.FindByValue(value) Is Nothing Then
                Me.ddlOPCIONID_OPCION.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ACTIVO() As Boolean
        Get
            Return Me.cbxACTIVO.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxACTIVO.Checked = value
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

    Public Property VerID_OPCION_PERFIL() As Boolean
        Get
            Return Me.trID_OPCION_PERFIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_OPCION_PERFIL.Visible = value
        End Set
    End Property

    Public Property VerID_PERFIL() As Boolean
        Get
            Return Me.trID_PERFIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PERFIL.Visible = value
        End Set
    End Property

    Public Property VerID_OPCION() As Boolean
        Get
            Return Me.trID_OPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_OPCION.Visible = value
        End Set
    End Property

    Public Property VerACTIVO() As Boolean
        Get
            Return Me.trACTIVO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACTIVO.Visible = value
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
    Private mComponente As New cOPCION_PERFIL
    Private mEntidad As OPCION_PERFIL
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
        If Not Me.ViewState("ID_OPCION_PERFIL") Is Nothing Then Me._ID_OPCION_PERFIL = Me.ViewState("ID_OPCION_PERFIL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla OPCION_PERFIL
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
        mEntidad = New OPCION_PERFIL
        mEntidad.ID_OPCION_PERFIL = ID_OPCION_PERFIL
 
        If mComponente.ObtenerOPCION_PERFIL(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_OPCION_PERFIL.Text = mEntidad.ID_OPCION_PERFIL.ToString()
        Me.ddlPERFILID_PERFIL.Recuperar()
        Me.ddlPERFILID_PERFIL.SelectedValue = mEntidad.ID_PERFIL
        Me.ddlOPCIONID_OPCION.Recuperar()
        Me.ddlOPCIONID_OPCION.SelectedValue = mEntidad.ID_OPCION
        Me.cbxACTIVO.Checked = mEntidad.ACTIVO
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
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlPERFILID_PERFIL.Enabled = edicion
        Me.ddlOPCIONID_OPCION.Enabled = edicion
        Me.cbxACTIVO.Enabled = edicion
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
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlPERFILID_PERFIL.Recuperar()
        Me.ddlOPCIONID_OPCION.Recuperar()
        Me.cbxACTIVO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla OPCION_PERFIL
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
        mEntidad = New OPCION_PERFIL
        If Me._nuevo Then
            mEntidad.ID_OPCION_PERFIL = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad.ID_OPCION_PERFIL = CInt(Me.txtID_OPCION_PERFIL.Text)
            mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
            mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True), _
                    System.Globalization.DateTimeStyles.NoCurrentDateDefault)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_PERFIL = Me.ddlPERFILID_PERFIL.SelectedValue
        mEntidad.ID_OPCION = Me.ddlOPCIONID_OPCION.SelectedValue
        mEntidad.ACTIVO = Me.cbxACTIVO.Checked

        If mComponente.ActualizarOPCION_PERFIL(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_OPCION_PERFIL.Text = mEntidad.ID_OPCION_PERFIL.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
