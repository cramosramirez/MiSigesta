Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleRECIBO_CANA_NUMERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla RECIBO_CANA_NUMERACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleRECIBO_CANA_NUMERACION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_RECIBO_CANA_NUM As Int32
    Public Property ID_RECIBO_CANA_NUM() As Int32
        Get
            Return Me.txtID_RECIBO_CANA_NUM.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_RECIBO_CANA_NUM = Value
            Me.txtID_RECIBO_CANA_NUM.Text = CStr(Value)
            If Me._ID_RECIBO_CANA_NUM > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NUM_INICIAL() As Int32
        Get
            If Me.txtNUM_INICIAL.Text ="" Then Return -1
            Return CInt(Me.txtNUM_INICIAL.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNUM_INICIAL.Text = value.ToString()
        End Set
    End Property

    Public Property NUM_FINAL() As Int32
        Get
            If Me.txtNUM_FINAL.Text ="" Then Return -1
            Return CInt(Me.txtNUM_FINAL.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNUM_FINAL.Text = value.ToString()
        End Set
    End Property

    Public Property ULT_NUM_ASIGNADO() As Int32
        Get
            If Me.txtULT_NUM_ASIGNADO.Text ="" Then Return -1
            Return CInt(Me.txtULT_NUM_ASIGNADO.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtULT_NUM_ASIGNADO.Text = value.ToString()
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

    Public Property VerID_RECIBO_CANA_NUM() As Boolean
        Get
            Return Me.trID_RECIBO_CANA_NUM.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_RECIBO_CANA_NUM.Visible = value
        End Set
    End Property

    Public Property VerNUM_INICIAL() As Boolean
        Get
            Return Me.trNUM_INICIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUM_INICIAL.Visible = value
        End Set
    End Property

    Public Property VerNUM_FINAL() As Boolean
        Get
            Return Me.trNUM_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUM_FINAL.Visible = value
        End Set
    End Property

    Public Property VerULT_NUM_ASIGNADO() As Boolean
        Get
            Return Me.trULT_NUM_ASIGNADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trULT_NUM_ASIGNADO.Visible = value
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
    Private mComponente As New cRECIBO_CANA_NUMERACION
    Private mEntidad As RECIBO_CANA_NUMERACION
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
        If Not Me.ViewState("ID_RECIBO_CANA_NUM") Is Nothing Then Me._ID_RECIBO_CANA_NUM = Me.ViewState("ID_RECIBO_CANA_NUM")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla RECIBO_CANA_NUMERACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New RECIBO_CANA_NUMERACION
        mEntidad.ID_RECIBO_CANA_NUM = ID_RECIBO_CANA_NUM
 
        If mComponente.ObtenerRECIBO_CANA_NUMERACION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_RECIBO_CANA_NUM.Text = mEntidad.ID_RECIBO_CANA_NUM.ToString()
        Me.txtNUM_INICIAL.Text = mEntidad.NUM_INICIAL
        Me.txtNUM_FINAL.Text = mEntidad.NUM_FINAL
        If mEntidad.ULT_NUM_ASIGNADO = -1 Then
            Me.txtULT_NUM_ASIGNADO.Text = ""
        Else
            Me.txtULT_NUM_ASIGNADO.Text = mEntidad.ULT_NUM_ASIGNADO
        End If
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
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNUM_INICIAL.Enabled = edicion
        Me.txtNUM_FINAL.Enabled = edicion
        Me.txtULT_NUM_ASIGNADO.Enabled = False
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
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNUM_INICIAL.Text = ""
        Me.txtNUM_FINAL.Text = ""
        Me.txtULT_NUM_ASIGNADO.Text = ""
        Me.cbxACTIVO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla RECIBO_CANA_NUMERACION
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        If Not Utilerias.EsNumeroEntero(Me.txtNUM_INICIAL.Text) Then
            AsignarMensaje("* Numero inicial no valido", True)
            Return "Error"
        End If
        If Not Utilerias.EsNumeroEntero(Me.txtNUM_FINAL.Text) Then
            AsignarMensaje("* Numero final no valido", True)
            Return "Error"
        End If
        If Convert.ToInt32(Me.txtNUM_INICIAL.Text) >= Convert.ToInt32(Me.txtNUM_FINAL.Text) Then
            AsignarMensaje("* Numero inicial no puede ser mayor o igual al numero final", True)
            Return "Error"
        End If
        If Me.txtULT_NUM_ASIGNADO.Text <> "" AndAlso Not Utilerias.EsNumeroEntero(Me.txtULT_NUM_ASIGNADO.Text) Then
            AsignarMensaje("* Ultimo numero asignado no valido", True)
            Return "Error"
        End If
        If Me.txtULT_NUM_ASIGNADO.Text <> "" AndAlso Convert.ToInt32(Me.txtNUM_INICIAL.Text) > Convert.ToInt32(Me.txtULT_NUM_ASIGNADO.Text) Then
            AsignarMensaje("* Numero inicial no puede ser mayor al ultimo numero asignado", True)
            Return "Error"
        End If
        If Me.txtULT_NUM_ASIGNADO.Text <> "" AndAlso Convert.ToInt32(Me.txtNUM_FINAL.Text) < Convert.ToInt32(Me.txtULT_NUM_ASIGNADO.Text) Then
            AsignarMensaje("* Numero final no puede ser menor al ultimo numero asignado", True)
            Return "Error"
        End If

        mEntidad = New RECIBO_CANA_NUMERACION
        If Me._nuevo Then
            mEntidad.ID_RECIBO_CANA_NUM = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad.ULT_NUM_ASIGNADO = -1
        Else
            mEntidad = (New cRECIBO_CANA_NUMERACION).ObtenerRECIBO_CANA_NUMERACION(CInt(Me.txtID_RECIBO_CANA_NUM.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.NUM_INICIAL = Convert.ToInt32(Me.txtNUM_INICIAL.Text)
        mEntidad.NUM_FINAL = Convert.ToInt32(Me.txtNUM_FINAL.Text)

        mEntidad.ACTIVO = Me.cbxACTIVO.Checked
        If mComponente.ActualizarRECIBO_CANA_NUMERACION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_RECIBO_CANA_NUM.Text = mEntidad.ID_RECIBO_CANA_NUM.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
