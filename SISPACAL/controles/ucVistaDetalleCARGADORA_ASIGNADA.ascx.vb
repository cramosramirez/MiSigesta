Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCARGADORA_ASIGNADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CARGADORA_ASIGNADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCARGADORA_ASIGNADA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CARGADORA_ASIG As Int32
    Public Property ID_CARGADORA_ASIG() As Int32
        Get
            Return Me.txtID_CARGADORA_ASIG.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CARGADORA_ASIG = Value
            Me.txtID_CARGADORA_ASIG.Text = CStr(Value)
            If Me._ID_CARGADORA_ASIG > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_CARGADORA() As Int32
        Get
            Return Me.ddlCARGADORAID_CARGADORA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCARGADORAID_CARGADORA.Items.FindByValue(value) Is Nothing Then
                Me.ddlCARGADORAID_CARGADORA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_CARGADOR() As Int32
        Get
            Return Me.ddlCARGADORID_CARGADOR.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCARGADORID_CARGADOR.Items.FindByValue(value) Is Nothing Then
                Me.ddlCARGADORID_CARGADOR.SelectedValue = value
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

    Public Property VerID_CARGADORA_ASIG() As Boolean
        Get
            Return Me.trID_CARGADORA_ASIG.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CARGADORA_ASIG.Visible = value
        End Set
    End Property

    Public Property VerID_CARGADORA() As Boolean
        Get
            Return Me.trID_CARGADORA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CARGADORA.Visible = value
        End Set
    End Property

    Public Property VerID_CARGADOR() As Boolean
        Get
            Return Me.trID_CARGADOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CARGADOR.Visible = value
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
    Private mComponente As New cCARGADORA_ASIGNADA
    Private mEntidad As CARGADORA_ASIGNADA
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
        If Not Me.ViewState("ID_CARGADORA_ASIG") Is Nothing Then Me._ID_CARGADORA_ASIG = Me.ViewState("ID_CARGADORA_ASIG")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CARGADORA_ASIGNADA
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
        mEntidad = New CARGADORA_ASIGNADA
        mEntidad.ID_CARGADORA_ASIG = ID_CARGADORA_ASIG
 
        If mComponente.ObtenerCARGADORA_ASIGNADA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CARGADORA_ASIG.Text = mEntidad.ID_CARGADORA_ASIG.ToString()
        Me.ddlCARGADORAID_CARGADORA.Recuperar()
        Me.ddlCARGADORAID_CARGADORA.SelectedValue = mEntidad.ID_CARGADORA
        Me.ddlCARGADORID_CARGADOR.Recuperar()
        Me.ddlCARGADORID_CARGADOR.SelectedValue = mEntidad.ID_CARGADOR
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
        Me.ddlCARGADORAID_CARGADORA.Enabled = edicion
        Me.ddlCARGADORID_CARGADOR.Enabled = edicion
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
        Me.ddlCARGADORAID_CARGADORA.Recuperar()
        Me.ddlCARGADORID_CARGADOR.Recuperar()
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CARGADORA_ASIGNADA
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

        If ddlCARGADORAID_CARGADORA.SelectedValue Is Nothing OrElse ddlCARGADORAID_CARGADORA.SelectedValue = "" Then
            AsignarMensaje("* Seleccione una cargadora", True)
            Return "Error"
        End If
        If ddlCARGADORID_CARGADOR.SelectedValue Is Nothing OrElse ddlCARGADORID_CARGADOR.SelectedValue = "" Then
            AsignarMensaje("* Seleccione un cargador", True)
            Return "Error"
        End If


        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CARGADORA_ASIGNADA
        If Me._nuevo Then
            'Verificar si ya existe la asignaciÃ³n de la cargadora
            Dim lCargadoraAsignada As listaCARGADORA_ASIGNADA = (New cCARGADORA_ASIGNADA).ObtenerListaPorCARGADOR(ddlCARGADORID_CARGADOR.SelectedValue)
            For i As Integer = 0 To lCargadoraAsignada.Count - 1
                If lCargadoraAsignada(i).ID_CARGADORA = ddlCARGADORAID_CARGADORA.SelectedValue Then
                    Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(lCargadoraAsignada(i).ID_CARGADORA)
                    AsignarMensaje("* Cargador ya tiene asignada la cargadora: " + lCargadora.NOMBRE, True)
                    Return "Error"
                End If
            Next

            mEntidad.ID_CARGADORA_ASIG = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            'Verificar si ya existe la asignaciÃ³n de la cargadora
            Dim lCargadoraAsignada As listaCARGADORA_ASIGNADA = (New cCARGADORA_ASIGNADA).ObtenerListaPorCARGADOR(ddlCARGADORID_CARGADOR.SelectedValue)
            For i As Integer = 0 To lCargadoraAsignada.Count - 1
                If lCargadoraAsignada(i).ID_CARGADORA = ddlCARGADORAID_CARGADORA.SelectedValue AndAlso lCargadoraAsignada(i).ID_CARGADORA_ASIG <> CInt(Me.txtID_CARGADORA_ASIG.Text) Then
                    Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(lCargadoraAsignada(i).ID_CARGADORA)
                    AsignarMensaje("* Cargador ya tiene asignada la cargadora: " + lCargadora.NOMBRE, True)
                    Return "Error"
                End If
            Next

            mEntidad = (New cCARGADORA_ASIGNADA).ObtenerCARGADORA_ASIGNADA(CInt(Me.txtID_CARGADORA_ASIG.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_CARGADORA = Me.ddlCARGADORAID_CARGADORA.SelectedValue
        mEntidad.ID_CARGADOR = Me.ddlCARGADORID_CARGADOR.SelectedValue

        If mComponente.ActualizarCARGADORA_ASIGNADA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CARGADORA_ASIG.Text = mEntidad.ID_CARGADORA_ASIG.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
