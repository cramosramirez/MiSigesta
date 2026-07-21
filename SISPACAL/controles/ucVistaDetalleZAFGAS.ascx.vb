Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleZAFGAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ZAFGAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleZAFGAS
    Inherits ucBase
 
#Region"Propiedades"

    Private _MEDIO As String
    Public Property MEDIO() As String
        Get
            Return Me.txtMEDIO.Text
        End Get
        Set(ByVal Value As String)
            Me._MEDIO = Value
            Me.txtMEDIO.Text = Value
            If Me._MEDIO <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property EFICIENCIA() As Decimal
        Get
            If Me.txtEFICIENCIA.Text ="" Then Return -1
            Return Me.txtEFICIENCIA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtEFICIENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property CAPACIDAD() As Decimal
        Get
            If Me.txtCAPACIDAD.Text ="" Then Return -1
            Return Me.txtCAPACIDAD.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtCAPACIDAD.Text = value.ToString()
        End Set
    End Property

    Public Property GASBASE() As Decimal
        Get
            If Me.txtGASBASE.Text ="" Then Return -1
            Return Me.txtGASBASE.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtGASBASE.Text = value.ToString()
        End Set
    End Property

    Public Property GASPRECIO() As Decimal
        Get
            If Me.txtGASPRECIO.Text ="" Then Return -1
            Return Me.txtGASPRECIO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtGASPRECIO.Text = value.ToString()
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

    Public Property VerMEDIO() As Boolean
        Get
            Return Me.trMEDIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMEDIO.Visible = value
        End Set
    End Property

    Public Property VerEFICIENCIA() As Boolean
        Get
            Return Me.trEFICIENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEFICIENCIA.Visible = value
        End Set
    End Property

    Public Property VerCAPACIDAD() As Boolean
        Get
            Return Me.trCAPACIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCAPACIDAD.Visible = value
        End Set
    End Property

    Public Property VerGASBASE() As Boolean
        Get
            Return Me.trGASBASE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trGASBASE.Visible = value
        End Set
    End Property

    Public Property VerGASPRECIO() As Boolean
        Get
            Return Me.trGASPRECIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trGASPRECIO.Visible = value
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
    Private mComponente As New cZAFGAS
    Private mEntidad As ZAFGAS
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
        If Not Me.ViewState("MEDIO") Is Nothing Then Me._MEDIO = Me.ViewState("MEDIO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ZAFGAS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ZAFGAS
        mEntidad.MEDIO = MEDIO
 
        If mComponente.ObtenerZAFGAS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtMEDIO.Text = mEntidad.MEDIO
        Me.txtEFICIENCIA.Text = mEntidad.EFICIENCIA
        Me.txtCAPACIDAD.Text = mEntidad.CAPACIDAD
        Me.txtGASBASE.Text = mEntidad.GASBASE
        Me.txtGASPRECIO.Text = mEntidad.GASPRECIO
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
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtEFICIENCIA.Enabled = edicion
        Me.txtCAPACIDAD.Enabled = edicion
        Me.txtGASBASE.Enabled = edicion
        Me.txtGASPRECIO.Enabled = edicion
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
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtEFICIENCIA.Text = ""
        Me.txtCAPACIDAD.Text = ""
        Me.txtGASBASE.Text = ""
        Me.txtGASPRECIO.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ZAFGAS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ZAFGAS
        If Me.txtMEDIO.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Medio que sea valido", True, True)
            Return "Error"
        End If
        mEntidad = (New cZAFGAS).ObtenerZAFGAS(Me.txtMEDIO.Text)
        If mEntidad Is Nothing Then
            Me._nuevo = True
            mEntidad = New ZAFGAS
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.MEDIO = Me.txtMEDIO.Text
        mEntidad.EFICIENCIA = Val(Me.txtEFICIENCIA.Text)
        mEntidad.CAPACIDAD = Val(Me.txtCAPACIDAD.Text)
        mEntidad.GASBASE = Val(Me.txtGASBASE.Text)
        mEntidad.GASPRECIO = Val(Me.txtGASPRECIO.Text)
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        If Me._nuevo Then
            If mComponente.AgregarZAFGAS(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarZAFGAS(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtMEDIO.Text = mEntidad.MEDIO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
