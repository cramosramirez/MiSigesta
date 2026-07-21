Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePERIODOREQ
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PERIODOREQ
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePERIODOREQ
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PERIODOREQ As Int32
    Public Property ID_PERIODOREQ() As Int32
        Get
            Return Me.txtID_PERIODOREQ.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PERIODOREQ = Value
            Me.txtID_PERIODOREQ.Text = CStr(Value)
            If Me._ID_PERIODOREQ > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property DESCRIP_PERIODO() As String
        Get
            Return Me.txtDESCRIP_PERIODO.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRIP_PERIODO.Text = value.ToString()
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

    Public Property USUARIO_CREACION() As String
        Get
            Return Me.txtUSUARIO_CREACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CREACION.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CREACION() As DateTime
        Get
            Return Me.deFECHA_CREACION.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CREACION.Value = value
        End Set
    End Property

    Public Property USUARIO_CIERRE() As String
        Get
            Return Me.txtUSUARIO_CIERRE.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CIERRE.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CIERRE() As DateTime
        Get
            Return Me.deFECHA_CIERRE.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CIERRE.Value = value
        End Set
    End Property

    Public Property VerID_PERIODOREQ() As Boolean
        Get
            Return Me.trID_PERIODOREQ.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PERIODOREQ.Visible = value
        End Set
    End Property

    Public Property VerDESCRIP_PERIODO() As Boolean
        Get
            Return Me.trDESCRIP_PERIODO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIP_PERIODO.Visible = value
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

    Public Property VerUSUARIO_CREACION() As Boolean
        Get
            Return Me.trUSUARIO_CREACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CREACION.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CREACION() As Boolean
        Get
            Return Me.trFECHA_CREACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CREACION.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_CIERRE() As Boolean
        Get
            Return Me.trUSUARIO_CIERRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CIERRE.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CIERRE() As Boolean
        Get
            Return Me.trFECHA_CIERRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CIERRE.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPERIODOREQ
    Private mEntidad As PERIODOREQ
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
        If Not Me.ViewState("ID_PERIODOREQ") Is Nothing Then Me._ID_PERIODOREQ = Me.ViewState("ID_PERIODOREQ")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PERIODOREQ
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PERIODOREQ
        mEntidad.ID_PERIODOREQ = ID_PERIODOREQ
 
        If mComponente.ObtenerPERIODOREQ(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PERIODOREQ.Text = mEntidad.ID_PERIODOREQ.ToString()
        Me.txtDESCRIP_PERIODO.Text = mEntidad.DESCRIP_PERIODO
        Me.cbxACTIVO.Checked = mEntidad.ACTIVO
        Me.txtUSUARIO_CREACION.Text = mEntidad.USUARIO_CREACION
        Me.deFECHA_CREACION.Value = mEntidad.FECHA_CREACION
        Me.txtUSUARIO_CIERRE.Text = mEntidad.USUARIO_CIERRE
        Me.deFECHA_CIERRE.Value = mEntidad.FECHA_CIERRE
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtDESCRIP_PERIODO.Enabled = edicion
        Me.cbxACTIVO.Enabled = edicion
        Me.txtUSUARIO_CREACION.Enabled = edicion
        Me.deFECHA_CREACION.Enabled = edicion
        Me.txtUSUARIO_CIERRE.Enabled = edicion
        Me.deFECHA_CIERRE.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtDESCRIP_PERIODO.Text = ""
        Me.cbxACTIVO.Checked = False
        Me.txtUSUARIO_CREACION.Text = ""
        Me.deFECHA_CREACION.Value = Nothing
        Me.txtUSUARIO_CIERRE.Text = ""
        Me.deFECHA_CIERRE.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PERIODOREQ
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PERIODOREQ
        If Me._nuevo Then
            mEntidad.ID_PERIODOREQ = 0
        Else
            mEntidad.ID_PERIODOREQ = CInt(Me.txtID_PERIODOREQ.Text)
        End If
        mEntidad.DESCRIP_PERIODO = Me.txtDESCRIP_PERIODO.Text
        mEntidad.ACTIVO = Me.cbxACTIVO.Checked
        mEntidad.USUARIO_CREACION = Me.txtUSUARIO_CREACION.Text
        mEntidad.FECHA_CREACION = Me.deFECHA_CREACION.Value
        mEntidad.USUARIO_CIERRE = Me.txtUSUARIO_CIERRE.Text
        mEntidad.FECHA_CIERRE = Me.deFECHA_CIERRE.Value

        If mComponente.ActualizarPERIODOREQ(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PERIODOREQ.Text = mEntidad.ID_PERIODOREQ.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
