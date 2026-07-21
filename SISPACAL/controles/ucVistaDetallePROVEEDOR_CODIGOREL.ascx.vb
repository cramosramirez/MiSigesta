Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePROVEEDOR_CODIGOREL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROVEEDOR_CODIGOREL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROVEEDOR_CODIGOREL
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PROVEE_CODIGOREL As Int32
    Public Property ID_PROVEE_CODIGOREL() As Int32
        Get
            Return Me.txtID_PROVEE_CODIGOREL.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PROVEE_CODIGOREL = Value
            Me.txtID_PROVEE_CODIGOREL.Text = CStr(Value)
            If Me._ID_PROVEE_CODIGOREL > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CODIPROVEEDOR() As String
        Get
            Return Me.ddlPROVEEDORCODIPROVEEDOR.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlPROVEEDORCODIPROVEEDOR.Items.FindByValue(value) Is Nothing Then
                Me.ddlPROVEEDORCODIPROVEEDOR.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CODIPROVEEDOR_REL() As String
        Get
            Return Me.ddlPROVEEDORCODIPROVEEDOR_REL.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlPROVEEDORCODIPROVEEDOR_REL.Items.FindByValue(value) Is Nothing Then
                Me.ddlPROVEEDORCODIPROVEEDOR_REL.SelectedValue = value
            End If
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

    Public Property VerID_PROVEE_CODIGOREL() As Boolean
        Get
            Return Me.trID_PROVEE_CODIGOREL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEE_CODIGOREL.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.trCODIPROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR_REL() As Boolean
        Get
            Return Me.trCODIPROVEEDOR_REL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR_REL.Visible = value
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
    Private mComponente As New cPROVEEDOR_CODIGOREL
    Private mEntidad As PROVEEDOR_CODIGOREL
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
        If Not Me.ViewState("ID_PROVEE_CODIGOREL") Is Nothing Then Me._ID_PROVEE_CODIGOREL = Me.ViewState("ID_PROVEE_CODIGOREL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PROVEEDOR_CODIGOREL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PROVEEDOR_CODIGOREL
        mEntidad.ID_PROVEE_CODIGOREL = ID_PROVEE_CODIGOREL
 
        If mComponente.ObtenerPROVEEDOR_CODIGOREL(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PROVEE_CODIGOREL.Text = mEntidad.ID_PROVEE_CODIGOREL.ToString()
        Me.ddlPROVEEDORCODIPROVEEDOR.Recuperar()
        Me.ddlPROVEEDORCODIPROVEEDOR.SelectedValue = mEntidad.CODIPROVEEDOR
        Me.ddlPROVEEDORCODIPROVEEDOR_REL.Recuperar()
        Me.ddlPROVEEDORCODIPROVEEDOR_REL.SelectedValue = mEntidad.CODIPROVEEDOR_REL
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
    ''' 	[GenApp]	26/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlPROVEEDORCODIPROVEEDOR.Enabled = edicion
        Me.ddlPROVEEDORCODIPROVEEDOR_REL.Enabled = edicion
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
    ''' 	[GenApp]	26/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlPROVEEDORCODIPROVEEDOR.Recuperar()
        Me.ddlPROVEEDORCODIPROVEEDOR_REL.Recuperar()
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PROVEEDOR_CODIGOREL
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PROVEEDOR_CODIGOREL
        If Me._nuevo Then
            mEntidad.ID_PROVEE_CODIGOREL = 0
        Else
            mEntidad.ID_PROVEE_CODIGOREL = CInt(Me.txtID_PROVEE_CODIGOREL.Text)
        End If
        mEntidad.CODIPROVEEDOR = Me.ddlPROVEEDORCODIPROVEEDOR.SelectedValue
        mEntidad.CODIPROVEEDOR_REL = Me.ddlPROVEEDORCODIPROVEEDOR_REL.SelectedValue
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarPROVEEDOR_CODIGOREL(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PROVEE_CODIGOREL.Text = mEntidad.ID_PROVEE_CODIGOREL.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
