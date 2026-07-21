Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleREQDETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla REQDETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleREQDETA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_REQDETA As Int32
    Public Property ID_REQDETA() As Int32
        Get
            Return Me.txtID_REQDETA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_REQDETA = Value
            Me.txtID_REQDETA.Text = CStr(Value)
            If Me._ID_REQDETA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_REQENCA() As Int32
        Get
            Return Me.ddlREQENCAID_REQENCA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlREQENCAID_REQENCA.Items.FindByValue(value) Is Nothing Then
                Me.ddlREQENCAID_REQENCA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CODIGO() As String
        Get
            Return Me.txtCODIGO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIGO.Text = value.ToString()
        End Set
    End Property

    Public Property CANTIDAD() As String
        Get
            Return Me.txtCANTIDAD.Text
        End Get
        Set(ByVal value As String)
            Me.txtCANTIDAD.Text = value.ToString()
        End Set
    End Property

    Public Property UNIDAD() As String
        Get
            Return Me.txtUNIDAD.Text
        End Get
        Set(ByVal value As String)
            Me.txtUNIDAD.Text = value.ToString()
        End Set
    End Property

    Public Property DESCRIPCION() As String
        Get
            Return Me.txtDESCRIPCION.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRIPCION.Text = value.ToString()
        End Set
    End Property

    Public Property OBSERVACION() As String
        Get
            Return Me.txtOBSERVACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtOBSERVACION.Text = value.ToString()
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

    Public Property VerID_REQDETA() As Boolean
        Get
            Return Me.trID_REQDETA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_REQDETA.Visible = value
        End Set
    End Property

    Public Property VerID_REQENCA() As Boolean
        Get
            Return Me.trID_REQENCA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_REQENCA.Visible = value
        End Set
    End Property

    Public Property VerCODIGO() As Boolean
        Get
            Return Me.trCODIGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO.Visible = value
        End Set
    End Property

    Public Property VerCANTIDAD() As Boolean
        Get
            Return Me.trCANTIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCANTIDAD.Visible = value
        End Set
    End Property

    Public Property VerUNIDAD() As Boolean
        Get
            Return Me.trUNIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUNIDAD.Visible = value
        End Set
    End Property

    Public Property VerDESCRIPCION() As Boolean
        Get
            Return Me.trDESCRIPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIPCION.Visible = value
        End Set
    End Property

    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me.trOBSERVACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOBSERVACION.Visible = value
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
    Private mComponente As New cREQDETA
    Private mEntidad As REQDETA
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
        If Not Me.ViewState("ID_REQDETA") Is Nothing Then Me._ID_REQDETA = Me.ViewState("ID_REQDETA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla REQDETA
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
        mEntidad = New REQDETA
        mEntidad.ID_REQDETA = ID_REQDETA
 
        If mComponente.ObtenerREQDETA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_REQDETA.Text = mEntidad.ID_REQDETA.ToString()
        Me.ddlREQENCAID_REQENCA.Recuperar()
        Me.ddlREQENCAID_REQENCA.SelectedValue = mEntidad.ID_REQENCA
        Me.txtCODIGO.Text = mEntidad.CODIGO
        Me.txtCANTIDAD.Text = mEntidad.CANTIDAD
        Me.txtUNIDAD.Text = mEntidad.UNIDAD
        Me.txtDESCRIPCION.Text = mEntidad.DESCRIPCION
        Me.txtOBSERVACION.Text = mEntidad.OBSERVACION
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
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlREQENCAID_REQENCA.Enabled = edicion
        Me.txtCODIGO.Enabled = edicion
        Me.txtCANTIDAD.Enabled = edicion
        Me.txtUNIDAD.Enabled = edicion
        Me.txtDESCRIPCION.Enabled = edicion
        Me.txtOBSERVACION.Enabled = edicion
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
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlREQENCAID_REQENCA.Recuperar()
        Me.txtCODIGO.Text = ""
        Me.txtCANTIDAD.Text = ""
        Me.txtUNIDAD.Text = ""
        Me.txtDESCRIPCION.Text = ""
        Me.txtOBSERVACION.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla REQDETA
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
        mEntidad = New REQDETA
        If Me._nuevo Then
            mEntidad.ID_REQDETA = 0
        Else
            mEntidad.ID_REQDETA = CInt(Me.txtID_REQDETA.Text)
        End If
        mEntidad.ID_REQENCA = Me.ddlREQENCAID_REQENCA.SelectedValue
        mEntidad.CODIGO = Me.txtCODIGO.Text
        mEntidad.CANTIDAD = Me.txtCANTIDAD.Text
        mEntidad.UNIDAD = Me.txtUNIDAD.Text
        mEntidad.DESCRIPCION = Me.txtDESCRIPCION.Text
        mEntidad.OBSERVACION = Me.txtOBSERVACION.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarREQDETA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_REQDETA.Text = mEntidad.ID_REQDETA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
