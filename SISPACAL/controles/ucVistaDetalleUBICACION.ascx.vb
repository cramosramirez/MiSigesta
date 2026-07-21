Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleUBICACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla UBICACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleUBICACION
    Inherits ucBase
 
#Region"Propiedades"

    Private _CODIUBICACION As String
    Public Property CODIUBICACION() As String
        Get
            Return Me.txtCODIUBICACION.Text
        End Get
        Set(ByVal Value As String)
            Me._CODIUBICACION = Value
            Me.txtCODIUBICACION.Text = Value
            If Me._CODIUBICACION <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CODITARIFA() As String
        Get
            Return Me.ddlTARIFACODITARIFA.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlTARIFACODITARIFA.Items.FindByValue(value) Is Nothing Then
                Me.ddlTARIFACODITARIFA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property DEPARTAMENTO() As String
        Get
            Return Me.txtDEPARTAMENTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtDEPARTAMENTO.Text = value.ToString()
        End Set
    End Property

    Public Property MUNICIPIO() As String
        Get
            Return Me.txtMUNICIPIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtMUNICIPIO.Text = value.ToString()
        End Set
    End Property

    Public Property CANTON() As String
        Get
            Return Me.txtCANTON.Text
        End Get
        Set(ByVal value As String)
            Me.txtCANTON.Text = value.ToString()
        End Set
    End Property

    Public Property KILOMETRO() As Decimal
        Get
            If Me.txtKILOMETRO.Text ="" Then Return -1
            Return Me.txtKILOMETRO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtKILOMETRO.Text = value.ToString()
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

    Public Property VerCODIUBICACION() As Boolean
        Get
            Return Me.trCODIUBICACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIUBICACION.Visible = value
        End Set
    End Property

    Public Property VerCODITARIFA() As Boolean
        Get
            Return Me.trCODITARIFA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODITARIFA.Visible = value
        End Set
    End Property

    Public Property VerDEPARTAMENTO() As Boolean
        Get
            Return Me.trDEPARTAMENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDEPARTAMENTO.Visible = value
        End Set
    End Property

    Public Property VerMUNICIPIO() As Boolean
        Get
            Return Me.trMUNICIPIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMUNICIPIO.Visible = value
        End Set
    End Property

    Public Property VerCANTON() As Boolean
        Get
            Return Me.trCANTON.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCANTON.Visible = value
        End Set
    End Property

    Public Property VerKILOMETRO() As Boolean
        Get
            Return Me.trKILOMETRO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trKILOMETRO.Visible = value
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
    Private mComponente As New cUBICACION
    Private mEntidad As UBICACION
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
        If Not Me.ViewState("CODIUBICACION") Is Nothing Then Me._CODIUBICACION = Me.ViewState("CODIUBICACION")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla UBICACION
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
        mEntidad = New UBICACION
        mEntidad.CODIUBICACION = CODIUBICACION
 
        If mComponente.ObtenerUBICACION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtCODIUBICACION.Text = mEntidad.CODIUBICACION
        Me.ddlTARIFACODITARIFA.Recuperar()
        Me.ddlTARIFACODITARIFA.SelectedValue = mEntidad.CODITARIFA
        Me.txtDEPARTAMENTO.Text = mEntidad.DEPARTAMENTO
        Me.txtMUNICIPIO.Text = mEntidad.MUNICIPIO
        Me.txtCANTON.Text = mEntidad.CANTON
        Me.txtKILOMETRO.Text = mEntidad.KILOMETRO
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
        Me.ddlTARIFACODITARIFA.Enabled = edicion
        Me.txtDEPARTAMENTO.Enabled = edicion
        Me.txtMUNICIPIO.Enabled = edicion
        Me.txtCANTON.Enabled = edicion
        Me.txtKILOMETRO.Enabled = edicion
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
        Me.ddlTARIFACODITARIFA.Recuperar()
        Me.txtDEPARTAMENTO.Text = ""
        Me.txtMUNICIPIO.Text = ""
        Me.txtCANTON.Text = ""
        Me.txtKILOMETRO.Text = ""
        Me.txtUSER_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSER_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla UBICACION
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
        mEntidad = New UBICACION
        If Me.txtCODIUBICACION.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Codiubicacion que sea valido", True, True)
            Return "Error"
        End If
            mEntidad.CODIUBICACION = Me.txtCODIUBICACION.Text
        mEntidad.CODITARIFA = Me.ddlTARIFACODITARIFA.SelectedValue
        mEntidad.DEPARTAMENTO = Me.txtDEPARTAMENTO.Text
        mEntidad.MUNICIPIO = Me.txtMUNICIPIO.Text
        mEntidad.CANTON = Me.txtCANTON.Text
        mEntidad.KILOMETRO = Val(Me.txtKILOMETRO.Text)
        mEntidad.USER_CREA = Val(Me.txtUSER_CREA.Text)
        If Me.txtFECHA_CREA.Text <> "" Then mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USER_ACT = Val(Me.txtUSER_ACT.Text)
        If Me.txtFECHA_ACT.Text <> "" Then mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If Me._nuevo Then
            If mComponente.AgregarUBICACION(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarUBICACION(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtCODIUBICACION.Text = mEntidad.CODIUBICACION.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
