Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleVARIEDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla VARIEDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleVARIEDAD
    Inherits ucBase
 
#Region"Propiedades"

    Private _CODIVARIEDA As String
    Public Property CODIVARIEDA() As String
        Get
            Return Me.txtCODIVARIEDA.Text
        End Get
        Set(ByVal Value As String)
            Me._CODIVARIEDA = Value
            Me.txtCODIVARIEDA.Text = Value
            If Me._CODIVARIEDA <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOM_VARIEDAD() As String
        Get
            Return Me.txtNOM_VARIEDAD.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOM_VARIEDAD.Text = value.ToString()
        End Set
    End Property

    Public Property DESCRP_VARIEDAD() As String
        Get
            Return Me.txtDESCRP_VARIEDAD.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRP_VARIEDAD.Text = value.ToString()
        End Set
    End Property

    Public Property USER_CREA() As Int32
        Get
            If Me.txtUSER_CREA.Text ="" Then Return -1
            Return CInt(Me.txtUSER_CREA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtUSER_CREA.Text = value.ToString()
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

    Public Property USER_ACT() As Int32
        Get
            If Me.txtUSER_ACT.Text ="" Then Return -1
            Return CInt(Me.txtUSER_ACT.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtUSER_ACT.Text = value.ToString()
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

    Public Property VerCODIVARIEDA() As Boolean
        Get
            Return Me.trCODIVARIEDA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIVARIEDA.Visible = value
        End Set
    End Property

    Public Property VerNOM_VARIEDAD() As Boolean
        Get
            Return Me.trNOM_VARIEDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOM_VARIEDAD.Visible = value
        End Set
    End Property

    Public Property VerDESCRP_VARIEDAD() As Boolean
        Get
            Return Me.trDESCRP_VARIEDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRP_VARIEDAD.Visible = value
        End Set
    End Property

    Public Property VerUSER_CREA() As Boolean
        Get
            Return Me.trUSER_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSER_CREA.Visible = value
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

    Public Property VerUSER_ACT() As Boolean
        Get
            Return Me.trUSER_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSER_ACT.Visible = value
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
    Private mComponente As New cVARIEDAD
    Private mEntidad As VARIEDAD
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
        If Not Me.ViewState("CODIVARIEDA") Is Nothing Then Me._CODIVARIEDA = Me.ViewState("CODIVARIEDA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla VARIEDAD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New VARIEDAD
        mEntidad.CODIVARIEDA = CODIVARIEDA
 
        If mComponente.ObtenerVARIEDAD(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtCODIVARIEDA.Text = mEntidad.CODIVARIEDA
        Me.txtNOM_VARIEDAD.Text = mEntidad.NOM_VARIEDAD
        Me.txtDESCRP_VARIEDAD.Text = mEntidad.DESCRP_VARIEDAD
        Me.txtUSER_CREA.Text = mEntidad.USER_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSER_ACT.Text = mEntidad.USER_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOM_VARIEDAD.Enabled = edicion
        Me.txtDESCRP_VARIEDAD.Enabled = edicion
        Me.txtUSER_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSER_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOM_VARIEDAD.Text = ""
        Me.txtDESCRP_VARIEDAD.Text = ""
        Me.txtUSER_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSER_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla VARIEDAD
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New VARIEDAD
        If Me.txtCODIVARIEDA.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Codivarieda que sea valido", True, True)
            Return "Error"
        End If
            mEntidad.CODIVARIEDA = Me.txtCODIVARIEDA.Text
        mEntidad.NOM_VARIEDAD = Me.txtNOM_VARIEDAD.Text
        mEntidad.DESCRP_VARIEDAD = Me.txtDESCRP_VARIEDAD.Text
        mEntidad.USER_CREA = Val(Me.txtUSER_CREA.Text)
        If Me.txtFECHA_CREA.Text <> "" Then mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USER_ACT = Val(Me.txtUSER_ACT.Text)
        If Me.txtFECHA_ACT.Text <> "" Then mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If Me._nuevo Then
            If mComponente.AgregarVARIEDAD(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarVARIEDAD(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtCODIVARIEDA.Text = mEntidad.CODIVARIEDA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
