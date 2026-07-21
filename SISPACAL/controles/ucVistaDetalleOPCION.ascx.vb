Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleOPCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla OPCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/12/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleOPCION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_OPCION As Int32
    Public Property ID_OPCION() As Int32
        Get
            Return Me.txtID_OPCION.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_OPCION = Value
            Me.txtID_OPCION.Text = CStr(Value)
            If Me._ID_OPCION > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_OPCION() As String
        Get
            Return Me.txtNOMBRE_OPCION.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_OPCION.Text = value.ToString()
        End Set
    End Property

    Public Property ORDEN() As Int32
        Get
            If Me.txtORDEN.Value Is Nothing Then Return -1
            Return CInt(Me.txtORDEN.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtORDEN.Value = value
        End Set
    End Property

    Public Property URL() As String
        Get
            Return Me.txtURL.Text
        End Get
        Set(ByVal value As String)
            Me.txtURL.Text = value.ToString()
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

    Public Property ID_OPCION_PADRE() As Int32
        Get
            Return Me.ddlOPCIONID_OPCION_PADRE.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlOPCIONID_OPCION_PADRE.Items.FindByValue(value) Is Nothing Then
                Me.ddlOPCIONID_OPCION_PADRE.SelectedValue = value
            End If
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

    Public Property VerID_OPCION() As Boolean
        Get
            Return Me.trID_OPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_OPCION.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_OPCION() As Boolean
        Get
            Return Me.trNOMBRE_OPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_OPCION.Visible = value
        End Set
    End Property

    Public Property VerORDEN() As Boolean
        Get
            Return Me.trORDEN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trORDEN.Visible = value
        End Set
    End Property

    Public Property VerURL() As Boolean
        Get
            Return Me.trURL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trURL.Visible = value
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

    Public Property VerID_OPCION_PADRE() As Boolean
        Get
            Return Me.trID_OPCION_PADRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_OPCION_PADRE.Visible = value
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
    Private mComponente As New cOPCION
    Private mEntidad As OPCION
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
        If Not Me.ViewState("ID_OPCION") Is Nothing Then Me._ID_OPCION = Me.ViewState("ID_OPCION")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla OPCION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New OPCION
        mEntidad.ID_OPCION = ID_OPCION
 
        If mComponente.ObtenerOPCION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_OPCION.Text = mEntidad.ID_OPCION.ToString()
        Me.txtNOMBRE_OPCION.Text = mEntidad.NOMBRE_OPCION
        Me.txtORDEN.Value = mEntidad.ORDEN
        Me.txtURL.Text = mEntidad.URL
        Me.cbxACTIVO.Checked = mEntidad.ACTIVO
        Me.ddlOPCIONID_OPCION_PADRE.Recuperar()
        Me.ddlOPCIONID_OPCION_PADRE.SelectedValue = mEntidad.ID_OPCION_PADRE
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
    ''' 	[GenApp]	18/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlOPCIONID_OPCION_PADRE.Enabled = edicion
        Me.txtNOMBRE_OPCION.Enabled = edicion
        Me.txtORDEN.Enabled = edicion
        Me.txtURL.Enabled = edicion
        Me.cbxACTIVO.Enabled = edicion
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
    ''' 	[GenApp]	18/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlOPCIONID_OPCION_PADRE.Recuperar()
        Me.txtNOMBRE_OPCION.Text = ""
        Me.txtORDEN.Value = Nothing
        Me.txtURL.Text = ""
        Me.cbxACTIVO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla OPCION
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New OPCION
        If Me._nuevo Then
            mEntidad.ID_OPCION = 0
        Else
            mEntidad.ID_OPCION = CInt(Me.txtID_OPCION.Text)
        End If
        mEntidad.NOMBRE_OPCION = Me.txtNOMBRE_OPCION.Text
        mEntidad.ORDEN = Me.txtORDEN.Value
        mEntidad.URL = Me.txtURL.Text
        mEntidad.ACTIVO = Me.cbxACTIVO.Checked
        mEntidad.ID_OPCION_PADRE = Me.ddlOPCIONID_OPCION_PADRE.SelectedValue
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarOPCION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_OPCION.Text = mEntidad.ID_OPCION.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
