Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleLABFAB_INFOVAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla LABFAB_INFOVAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleLABFAB_INFOVAR
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_INFOVAR As Int32
    Public Property ID_INFOVAR() As Int32
        Get
            Return Me.txtID_INFOVAR.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_INFOVAR = Value
            Me.txtID_INFOVAR.Text = CStr(Value)
            If Me._ID_INFOVAR > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_INFO() As Int32
        Get
            Return Me.ddlLABFAB_INFORMEID_INFO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlLABFAB_INFORMEID_INFO.Items.FindByValue(value) Is Nothing Then
                Me.ddlLABFAB_INFORMEID_INFO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_TIPOVAR() As Int32
        Get
            Return Me.ddlLABFAB_TIPOVARID_TIPOVAR.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlLABFAB_TIPOVARID_TIPOVAR.Items.FindByValue(value) Is Nothing Then
                Me.ddlLABFAB_TIPOVARID_TIPOVAR.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_CATEG() As Int32
        Get
            Return Me.ddlLABFAB_CATEGORIAID_CATEG.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlLABFAB_CATEGORIAID_CATEG.Items.FindByValue(value) Is Nothing Then
                Me.ddlLABFAB_CATEGORIAID_CATEG.SelectedValue = value
            End If
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

    Public Property NOMBRE_INFOVAR() As String
        Get
            Return Me.txtNOMBRE_INFOVAR.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_INFOVAR.Text = value.ToString()
        End Set
    End Property

    Public Property DESCRIP_VAR() As String
        Get
            Return Me.txtDESCRIP_VAR.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRIP_VAR.Text = value.ToString()
        End Set
    End Property

    Public Property ID_ANALISIS_REF() As Int32
        Get
            If Me.txtID_ANALISIS_REF.Value Is Nothing Then Return -1
            Return CInt(Me.txtID_ANALISIS_REF.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtID_ANALISIS_REF.Value = value
        End Set
    End Property

    Public Property ID_INFOVAR_REF() As Int32
        Get
            If Me.txtID_INFOVAR_REF.Value Is Nothing Then Return -1
            Return CInt(Me.txtID_INFOVAR_REF.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtID_INFOVAR_REF.Value = value
        End Set
    End Property

    Public Property SQLREPO() As String
        Get
            Return Me.txtSQLREPO.Text
        End Get
        Set(ByVal value As String)
            Me.txtSQLREPO.Text = value.ToString()
        End Set
    End Property

    Public Property VerID_INFOVAR() As Boolean
        Get
            Return Me.trID_INFOVAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_INFOVAR.Visible = value
        End Set
    End Property

    Public Property VerID_INFO() As Boolean
        Get
            Return Me.trID_INFO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_INFO.Visible = value
        End Set
    End Property

    Public Property VerID_TIPOVAR() As Boolean
        Get
            Return Me.trID_TIPOVAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPOVAR.Visible = value
        End Set
    End Property

    Public Property VerID_CATEG() As Boolean
        Get
            Return Me.trID_CATEG.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CATEG.Visible = value
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

    Public Property VerNOMBRE_INFOVAR() As Boolean
        Get
            Return Me.trNOMBRE_INFOVAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_INFOVAR.Visible = value
        End Set
    End Property

    Public Property VerDESCRIP_VAR() As Boolean
        Get
            Return Me.trDESCRIP_VAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIP_VAR.Visible = value
        End Set
    End Property

    Public Property VerID_ANALISIS_REF() As Boolean
        Get
            Return Me.trID_ANALISIS_REF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ANALISIS_REF.Visible = value
        End Set
    End Property

    Public Property VerID_INFOVAR_REF() As Boolean
        Get
            Return Me.trID_INFOVAR_REF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_INFOVAR_REF.Visible = value
        End Set
    End Property

    Public Property VerSQLREPO() As Boolean
        Get
            Return Me.trSQLREPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSQLREPO.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cLABFAB_INFOVAR
    Private mEntidad As LABFAB_INFOVAR
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
        If Not Me.ViewState("ID_INFOVAR") Is Nothing Then Me._ID_INFOVAR = Me.ViewState("ID_INFOVAR")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla LABFAB_INFOVAR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New LABFAB_INFOVAR
        mEntidad.ID_INFOVAR = ID_INFOVAR
 
        If mComponente.ObtenerLABFAB_INFOVAR(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_INFOVAR.Text = mEntidad.ID_INFOVAR.ToString()
        Me.ddlLABFAB_INFORMEID_INFO.Recuperar()
        Me.ddlLABFAB_INFORMEID_INFO.SelectedValue = mEntidad.ID_INFO
        Me.ddlLABFAB_TIPOVARID_TIPOVAR.Recuperar()
        Me.ddlLABFAB_TIPOVARID_TIPOVAR.SelectedValue = mEntidad.ID_TIPOVAR
        Me.ddlLABFAB_CATEGORIAID_CATEG.Recuperar()
        Me.ddlLABFAB_CATEGORIAID_CATEG.SelectedValue = mEntidad.ID_CATEG
        Me.txtORDEN.Value = mEntidad.ORDEN
        Me.txtNOMBRE_INFOVAR.Text = mEntidad.NOMBRE_INFOVAR
        Me.txtDESCRIP_VAR.Text = mEntidad.DESCRIP_VAR
        Me.txtID_ANALISIS_REF.Value = mEntidad.ID_ANALISIS_REF
        Me.txtID_INFOVAR_REF.Value = mEntidad.ID_INFOVAR_REF
        Me.txtSQLREPO.Text = mEntidad.SQLREPO
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlLABFAB_INFORMEID_INFO.Enabled = edicion
        Me.ddlLABFAB_TIPOVARID_TIPOVAR.Enabled = edicion
        Me.ddlLABFAB_CATEGORIAID_CATEG.Enabled = edicion
        Me.txtORDEN.Enabled = edicion
        Me.txtNOMBRE_INFOVAR.Enabled = edicion
        Me.txtDESCRIP_VAR.Enabled = edicion
        Me.txtID_ANALISIS_REF.Enabled = edicion
        Me.txtID_INFOVAR_REF.Enabled = edicion
        Me.txtSQLREPO.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlLABFAB_INFORMEID_INFO.Recuperar()
        Me.ddlLABFAB_TIPOVARID_TIPOVAR.Recuperar()
        Me.ddlLABFAB_CATEGORIAID_CATEG.Recuperar()
        Me.txtORDEN.Value = Nothing
        Me.txtNOMBRE_INFOVAR.Text = ""
        Me.txtDESCRIP_VAR.Text = ""
        Me.txtID_ANALISIS_REF.Value = Nothing
        Me.txtID_INFOVAR_REF.Value = Nothing
        Me.txtSQLREPO.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla LABFAB_INFOVAR
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New LABFAB_INFOVAR
        If Me._nuevo Then
            mEntidad.ID_INFOVAR = 0
        Else
            mEntidad.ID_INFOVAR = CInt(Me.txtID_INFOVAR.Text)
        End If
        mEntidad.ID_INFO = Me.ddlLABFAB_INFORMEID_INFO.SelectedValue
        mEntidad.ID_TIPOVAR = Me.ddlLABFAB_TIPOVARID_TIPOVAR.SelectedValue
        mEntidad.ID_CATEG = Me.ddlLABFAB_CATEGORIAID_CATEG.SelectedValue
        mEntidad.ORDEN = Me.txtORDEN.Value
        mEntidad.NOMBRE_INFOVAR = Me.txtNOMBRE_INFOVAR.Text
        mEntidad.DESCRIP_VAR = Me.txtDESCRIP_VAR.Text
        mEntidad.ID_ANALISIS_REF = Me.txtID_ANALISIS_REF.Value
        mEntidad.ID_INFOVAR_REF = Me.txtID_INFOVAR_REF.Value
        mEntidad.SQLREPO = Me.txtSQLREPO.Text

        If mComponente.ActualizarLABFAB_INFOVAR(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_INFOVAR.Text = mEntidad.ID_INFOVAR.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
