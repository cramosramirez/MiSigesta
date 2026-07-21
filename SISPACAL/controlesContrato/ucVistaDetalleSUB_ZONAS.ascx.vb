Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSUB_ZONAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SUB_ZONAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSUB_ZONAS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ZONA As String
    Public Property ZONA() As String
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As String)
            Me._ZONA = Value
        End Set
    End Property

    Private _SUB_ZONA As String
    Public Property SUB_ZONA() As String
        Get
            Return Me.txtSUB_ZONA.Text
        End Get
        Set(ByVal Value As String)
            Me._SUB_ZONA = Value
            Me.txtSUB_ZONA.Text = Value
            If Me._SUB_ZONA <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property DESCRIP_SUB_ZONA() As String
        Get
            Return Me.txtDESCRIP_SUB_ZONA.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRIP_SUB_ZONA.Text = value.ToString()
        End Set
    End Property

    Public Property NO_SUB_ZONA() As Int32
        Get
            If Me.txtNO_SUB_ZONA.Value Is Nothing Then Return -1
            Return CInt(Me.txtNO_SUB_ZONA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_SUB_ZONA.Value = value
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

    Public Property VerZONA() As Boolean
        Get
            Return Me.trZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZONA.Visible = value
        End Set
    End Property

    Public Property VerSUB_ZONA() As Boolean
        Get
            Return Me.trSUB_ZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSUB_ZONA.Visible = value
        End Set
    End Property

    Public Property VerDESCRIP_SUB_ZONA() As Boolean
        Get
            Return Me.trDESCRIP_SUB_ZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIP_SUB_ZONA.Visible = value
        End Set
    End Property

    Public Property VerNO_SUB_ZONA() As Boolean
        Get
            Return Me.trNO_SUB_ZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_SUB_ZONA.Visible = value
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
    Private mComponente As New cSUB_ZONAS
    Private mEntidad As SUB_ZONAS
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
        If Not Me.ViewState("ZONA") Is Nothing Then Me._ZONA = Me.ViewState("ZONA")
        If Not Me.ViewState("SUB_ZONA") Is Nothing Then Me._SUB_ZONA = Me.ViewState("SUB_ZONA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SUB_ZONAS
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

        Dim sError As New String("")
        mEntidad = New SUB_ZONAS
        mEntidad.ZONA = ZONA
        mEntidad.SUB_ZONA = SUB_ZONA
 
        If mComponente.ObtenerSUB_ZONAS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.ddlZONASZONA.Recuperar()
        Me.ddlZONASZONA.SelectedValue = mEntidad.ZONA
        Me.txtSUB_ZONA.Text = mEntidad.SUB_ZONA
        Me.txtDESCRIP_SUB_ZONA.Text = mEntidad.DESCRIP_SUB_ZONA
        Me.txtNO_SUB_ZONA.Value = mEntidad.NO_SUB_ZONA
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT
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
        Me.txtDESCRIP_SUB_ZONA.Enabled = edicion
        Me.txtNO_SUB_ZONA.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.deFECHA_ACT.Enabled = edicion
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
        Me.ddlZONASZONA.Recuperar()
        Me.ddlZONASZONA.SelectedValue = Me.ZONA
        Me.txtDESCRIP_SUB_ZONA.Text = ""
        Me.txtNO_SUB_ZONA.Value = Nothing
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SUB_ZONAS
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
        Dim alDatos As New ArrayList
        mEntidad = New SUB_ZONAS
        If Me.txtSUB_ZONA.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Sub zona que sea valido", True, True)
            Return "Error"
        End If
        mEntidad.ZONA = Me.ddlZONASZONA.SelectedValue
            mEntidad.SUB_ZONA = Me.txtSUB_ZONA.Text
        mEntidad.DESCRIP_SUB_ZONA = Me.txtDESCRIP_SUB_ZONA.Text
        mEntidad.NO_SUB_ZONA = Me.txtNO_SUB_ZONA.Value
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If Me._nuevo Then
            If mComponente.AgregarSUB_ZONAS(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarSUB_ZONAS(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtSUB_ZONA.Text = mEntidad.SUB_ZONA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
