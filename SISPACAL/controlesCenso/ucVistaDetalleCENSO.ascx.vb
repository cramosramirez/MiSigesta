Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCENSO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CENSO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCENSO
    Inherits ucBase

#Region "Propiedades"


    Public Property ID_ZAFRA As Int32
        Get
            If Me.ViewState("ID_ZAFRA") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_ZAFRA"))
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_ZAFRA") = value
        End Set
    End Property

    Private _ID_CENSO As Int32
    Public Property ID_CENSO() As Int32
        Get
            Return Me.txtID_CENSO.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CENSO = Value
            Me.txtID_CENSO.Text = CStr(Value)
            If Me._ID_CENSO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCENSO
    Private mEntidad As CENSO
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
        If Not Me.ViewState("ID_CENSO") Is Nothing Then Me._ID_CENSO = Me.ViewState("ID_CENSO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CENSO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lZafra As ZAFRA
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CENSO
        mEntidad.ID_CENSO = ID_CENSO

        If mComponente.ObtenerCENSO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CENSO.Text = mEntidad.ID_CENSO.ToString()
        lZafra = (New cZAFRA).ObtenerZAFRA(mEntidad.ID_ZAFRA)
        If lZafra IsNot Nothing Then
            Me.txtZAFRA.Text = lZafra.NOMBRE_ZAFRA
        End If
        Me.dteFECHA_CENSO.Date = mEntidad.FECHA_CENSO
        Me.txtNOMBRE_CENSO.Text = mEntidad.NOMBRE_CENSO
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_CENSO.ClientVisible = False
        Me.txtZAFRA.ClientEnabled = False
        Me.dteFECHA_CENSO.ClientEnabled = edicion
        Me.txtNOMBRE_CENSO.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Dim lZafra As ZAFRA
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        lZafra = (New cZAFRA).ObtenerZAFRA(Me.ID_ZAFRA)
        If lZafra IsNot Nothing Then Me.txtZAFRA.Text = lZafra.NOMBRE_ZAFRA Else txtZAFRA.Text = ""
        Me.dteFECHA_CENSO.Value = cFechaHora.ObtenerFecha
        Me.txtNOMBRE_CENSO.Text = ""
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CENSO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim lCensos As listaCENSO
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        If Me.ID_ZAFRA = -1 Then
            Return "* Zafra no valida"
        End If
        If Me.dteFECHA_CENSO.Value Is Nothing Then
            Return "* Fecha del censo obligatoria"
        End If
        If Me.txtNOMBRE_CENSO.Text = "" Then
            Return "* Nombre del censo obligatorio"
        End If
        lCensos = (New cCENSO).ObtenerListaPorFECHA(Me.dteFECHA_CENSO.Date)
        If lCensos IsNot Nothing AndAlso lCensos.Count > 0 Then
            Return "* Ya existe censo con fecha: " + Me.dteFECHA_CENSO.ToString("dd/MM/yyyy")
        End If

        mEntidad = New CENSO
        If Me._nuevo Then
            mEntidad.ID_CENSO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cCENSO).ObtenerCENSO(CInt(Me.txtID_CENSO.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_ZAFRA = Me.ID_ZAFRA
        mEntidad.FECHA_CENSO = Me.dteFECHA_CENSO.Date
        mEntidad.NOMBRE_CENSO = Me.txtNOMBRE_CENSO.Text.Trim.ToUpper

        If mComponente.ActualizarCENSO(mEntidad) <= 0 Then
            Return "* Error al Guardar registro. " + mComponente.sError
        End If
        Me.txtID_CENSO.Text = mEntidad.ID_CENSO.ToString()
        Me._nuevo = False

        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function


End Class
