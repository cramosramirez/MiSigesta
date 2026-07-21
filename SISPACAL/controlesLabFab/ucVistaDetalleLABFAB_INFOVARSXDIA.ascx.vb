Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleLABFAB_INFOVARSXDIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla LABFAB_INFOVARSXDIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleLABFAB_INFOVARSXDIA
    Inherits ucBase
 
#Region"Propiedades"

    Public Property ID_ZAFRA As Int32
        Get
            If Me.ViewState("ID_ZAFRA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ZAFRA"))
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_ZAFRA") = value
        End Set
    End Property
    Public Property DIAZAFRA As Int32
        Get
            If Me.ViewState("DIAZAFRA") IsNot Nothing Then
                Return CInt(Me.ViewState("DIAZAFRA"))
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("DIAZAFRA") = value
        End Set
    End Property

    Public Property ID_INFO() As Int32
        Get
            If Me.ViewState("ID_INFO") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_INFO"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_INFO") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
            Me.txtID_INFO.Text = CStr(Value)
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cLABFAB_INFOVARSXDIA
    Private mEntidad As LABFAB_INFOVARSXDIA
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
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla LABFAB_INFOVARSXDIA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New LABFAB_INFOVARSXDIA
        mEntidad.ID_INFO = ID_INFO
 
        If mComponente.ObtenerLABFAB_INFOVARSXDIA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        'Me.txtID_INFOVARSXDIA.Text = mEntidad.ID_INFOVARSXDIA.ToString()
        'Me.ddlLABFAB_INFORMEID_INFO.Recuperar()
        'Me.ddlLABFAB_INFORMEID_INFO.SelectedValue = mEntidad.ID_INFO
        'Me.txtID_INFOVAR.Value = mEntidad.ID_INFOVAR
        'Me.ddlLABFAB_DIAZAFRAID_DIAZAFRA.Recuperar()
        'Me.ddlLABFAB_DIAZAFRAID_DIAZAFRA.SelectedValue = mEntidad.ID_DIAZAFRA
        'Me.txtID_ZAFRA.Value = mEntidad.ID_ZAFRA
        'Me.txtDIAZAFRA.Value = mEntidad.DIAZAFRA
        'Me.txtNOMBRE_VAR.Text = mEntidad.NOMBRE_VAR
        'Me.txtVALOR.Value = mEntidad.VALOR
        'Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        'Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        'Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        'Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        'Me.ddlLABFAB_INFORMEID_INFO.Enabled = edicion
        'Me.ddlLABFAB_DIAZAFRAID_DIAZAFRA.Enabled = edicion
        'Me.txtID_INFOVAR.Enabled = edicion
        'Me.txtID_ZAFRA.Enabled = edicion
        'Me.txtDIAZAFRA.Enabled = edicion
        'Me.txtNOMBRE_VAR.Enabled = edicion
        'Me.txtVALOR.Enabled = edicion
        'Me.txtUSUARIO_CREA.Enabled = edicion
        'Me.deFECHA_CREA.Enabled = edicion
        'Me.txtUSUARIO_ACT.Enabled = edicion
        'Me.deFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        'Me.ddlLABFAB_INFORMEID_INFO.Recuperar()
        'Me.ddlLABFAB_DIAZAFRAID_DIAZAFRA.Recuperar()
        'Me.txtID_INFOVAR.Value = Nothing
        'Me.txtID_ZAFRA.Value = Nothing
        'Me.txtDIAZAFRA.Value = Nothing
        'Me.txtNOMBRE_VAR.Text = ""
        'Me.txtVALOR.Value = Nothing
        'Me.txtUSUARIO_CREA.Text = ""
        'Me.deFECHA_CREA.Value = Nothing
        'Me.txtUSUARIO_ACT.Text = ""
        'Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla LABFAB_INFOVARSXDIA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New LABFAB_INFOVARSXDIA
        If Me._nuevo Then
            mEntidad.ID_INFOVARSXDIA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            'mEntidad = mComponente.OBTE  CInt(Me.txtID_INFOVARSXDIA.Text)            
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        'mEntidad.ID_INFO = Me.ddlLABFAB_INFORMEID_INFO.SelectedValue
        'mEntidad.ID_INFOVAR = Me.txtID_INFOVAR.Value
        'mEntidad.ID_DIAZAFRA = Me.ddlLABFAB_DIAZAFRAID_DIAZAFRA.SelectedValue
        'mEntidad.ID_ZAFRA = Me.txtID_ZAFRA.Value
        'mEntidad.DIAZAFRA = Me.txtDIAZAFRA.Value
        'mEntidad.NOMBRE_VAR = Me.txtNOMBRE_VAR.Text
        'mEntidad.VALOR = Me.txtVALOR.Value
        

        If mComponente.ActualizarLABFAB_INFOVARSXDIA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_INFO.Text = mEntidad.ID_INFO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
