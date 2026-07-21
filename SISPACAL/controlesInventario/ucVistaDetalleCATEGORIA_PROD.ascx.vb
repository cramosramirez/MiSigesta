Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCATEGORIA_PROD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CATEGORIA_PROD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCATEGORIA_PROD
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CATEGORIA As Int32
    Public Property ID_CATEGORIA() As Int32
        Get
            Return Me.txtID_CATEGORIA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CATEGORIA = Value
            Me.txtID_CATEGORIA.Text = CStr(Value)
            If Me._ID_CATEGORIA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_CATEGORIA() As String
        Get
            Return Me.txtNOMBRE_CATEGORIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_CATEGORIA.Text = value.ToString()
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

    Public Property ZAFRA() As String
        Get
            Return Me.txtZAFRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtZAFRA.Text = value.ToString()
        End Set
    End Property

    Public Property VerID_CATEGORIA() As Boolean
        Get
            Return Me.trID_CATEGORIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CATEGORIA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_CATEGORIA() As Boolean
        Get
            Return Me.trNOMBRE_CATEGORIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_CATEGORIA.Visible = value
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

    Public Property VerZAFRA() As Boolean
        Get
            Return Me.trZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZAFRA.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCATEGORIA_PROD
    Private mEntidad As CATEGORIA_PROD
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
        If Not Me.ViewState("ID_CATEGORIA") Is Nothing Then Me._ID_CATEGORIA = Me.ViewState("ID_CATEGORIA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CATEGORIA_PROD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CATEGORIA_PROD
        mEntidad.ID_CATEGORIA = ID_CATEGORIA
 
        If mComponente.ObtenerCATEGORIA_PROD(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CATEGORIA.Text = mEntidad.ID_CATEGORIA.ToString()
        Me.txtNOMBRE_CATEGORIA.Text = mEntidad.NOMBRE_CATEGORIA
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT
        Me.txtZAFRA.Text = mEntidad.ZAFRA
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE_CATEGORIA.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.deFECHA_ACT.Enabled = edicion
        Me.txtZAFRA.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOMBRE_CATEGORIA.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
        Me.txtZAFRA.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CATEGORIA_PROD
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CATEGORIA_PROD
        If Me._nuevo Then
            mEntidad.ID_CATEGORIA = 0
        Else
            mEntidad.ID_CATEGORIA = CInt(Me.txtID_CATEGORIA.Text)
        End If
        mEntidad.NOMBRE_CATEGORIA = Me.txtNOMBRE_CATEGORIA.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value
        mEntidad.ZAFRA = Me.txtZAFRA.Text

        If mComponente.ActualizarCATEGORIA_PROD(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CATEGORIA.Text = mEntidad.ID_CATEGORIA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
