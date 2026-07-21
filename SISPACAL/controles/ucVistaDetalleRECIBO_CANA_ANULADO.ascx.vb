Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleRECIBO_CANA_ANULADO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla RECIBO_CANA_ANULADO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleRECIBO_CANA_ANULADO
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_RECIBO_CANA_ANUL As Int32
    Public Property ID_RECIBO_CANA_ANUL() As Int32
        Get
            Return Me.txtID_RECIBO_CANA_ANUL.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_RECIBO_CANA_ANUL = Value
            Me.txtID_RECIBO_CANA_ANUL.Text = CStr(Value)
            If Me._ID_RECIBO_CANA_ANUL > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NUMRECIBO_CANA() As Int32
        Get
            If Me.txtNUMRECIBO_CANA.Text ="" Then Return -1
            Return CInt(Me.txtNUMRECIBO_CANA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNUMRECIBO_CANA.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_ANULACION() As DateTime
        Get
            Return Me.txtFECHA_ANULACION.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ANULACION.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property MOTIVO_ANULACION() As String
        Get
            Return Me.txtMOTIVO_ANULACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtMOTIVO_ANULACION.Text = value.ToString()
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

    Public Property ID_ZAFRA() As Int32
        Get
            Return Me.ddlZAFRAID_ZAFRA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlZAFRAID_ZAFRA.Items.FindByValue(value) Is Nothing Then
                Me.ddlZAFRAID_ZAFRA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_ENVIO() As Int32
        Get
            Return Me.ddlENVIOID_ENVIO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlENVIOID_ENVIO.Items.FindByValue(value) Is Nothing Then
                Me.ddlENVIOID_ENVIO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property VerID_RECIBO_CANA_ANUL() As Boolean
        Get
            Return Me.trID_RECIBO_CANA_ANUL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_RECIBO_CANA_ANUL.Visible = value
        End Set
    End Property

    Public Property VerNUMRECIBO_CANA() As Boolean
        Get
            Return Me.trNUMRECIBO_CANA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUMRECIBO_CANA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ANULACION() As Boolean
        Get
            Return Me.trFECHA_ANULACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ANULACION.Visible = value
        End Set
    End Property

    Public Property VerMOTIVO_ANULACION() As Boolean
        Get
            Return Me.trMOTIVO_ANULACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOTIVO_ANULACION.Visible = value
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

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerID_ENVIO() As Boolean
        Get
            Return Me.trID_ENVIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ENVIO.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cRECIBO_CANA_ANULADO
    Private mEntidad As RECIBO_CANA_ANULADO
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
        If Not Me.ViewState("ID_RECIBO_CANA_ANUL") Is Nothing Then Me._ID_RECIBO_CANA_ANUL = Me.ViewState("ID_RECIBO_CANA_ANUL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla RECIBO_CANA_ANULADO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New RECIBO_CANA_ANULADO
        mEntidad.ID_RECIBO_CANA_ANUL = ID_RECIBO_CANA_ANUL
 
        If mComponente.ObtenerRECIBO_CANA_ANULADO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_RECIBO_CANA_ANUL.Text = mEntidad.ID_RECIBO_CANA_ANUL.ToString()
        Me.txtNUMRECIBO_CANA.Text = mEntidad.NUMRECIBO_CANA
        Me.txtFECHA_ANULACION.Text = IIf(Not mEntidad.FECHA_ANULACION = Nothing, Format(mEntidad.FECHA_ANULACION, "dd/MM/yyyy"), "")
        Me.txtMOTIVO_ANULACION.Text = mEntidad.MOTIVO_ANULACION
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.ddlENVIOID_ENVIO.Recuperar()
        Me.ddlENVIOID_ENVIO.SelectedValue = mEntidad.ID_ENVIO
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = False
        Me.ddlENVIOID_ENVIO.Enabled = edicion
        Me.txtNUMRECIBO_CANA.Enabled = edicion
        Me.txtFECHA_ANULACION.Enabled = edicion
        Me.txtMOTIVO_ANULACION.Enabled = edicion
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
    ''' 	[GenApp]	07/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.RecuperarZafraActiva()
        'Me.ddlENVIOID_ENVIO.Recuperar()
        Me.txtNUMRECIBO_CANA.Text = ""
        Me.txtFECHA_ANULACION.Text = ""
        Me.txtMOTIVO_ANULACION.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla RECIBO_CANA_ANULADO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New RECIBO_CANA_ANULADO

        If Me._nuevo Then
            If Not Utilerias.EsNumeroEntero(Me.txtNUMRECIBO_CANA.Text) Then
                AsignarMensaje("* No. de Recibo de Cana debe ser un numero entero", True)
                Return "Error"
            End If

            mEntidad.ID_RECIBO_CANA_ANUL = 0
            mEntidad.FECHA_ANULACION = cFechaHora.ObtenerFecha
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cRECIBO_CANA_ANULADO).ObtenerRECIBO_CANA_ANULADO(CInt(Me.txtID_RECIBO_CANA_ANUL.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.NUMRECIBO_CANA = Convert.ToInt32(Me.txtNUMRECIBO_CANA.Text)
        mEntidad.MOTIVO_ANULACION = Me.txtMOTIVO_ANULACION.Text.Trim.ToUpper
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.ID_ENVIO = -1

        If mComponente.ActualizarRECIBO_CANA_ANULADO(mEntidad) < 1 Then
            Me.AsignarMensaje("* " + mComponente.sError, True, False)
            Return "Error al Guardar registro"
        End If
        Me.AsignarMensaje("", True, False)
        Me.txtID_RECIBO_CANA_ANUL.Text = mEntidad.ID_RECIBO_CANA_ANUL.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
