Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleMEMBRE_GREMIAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla MEMBRE_GREMIAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleMEMBRE_GREMIAL
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_MEMBRE_GREMIAL As Int32
    Public Property ID_MEMBRE_GREMIAL() As Int32
        Get
            Return Me.txtID_MEMBRE_GREMIAL.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_MEMBRE_GREMIAL = Value
            Me.txtID_MEMBRE_GREMIAL.Text = CStr(Value)
            If Me._ID_MEMBRE_GREMIAL > 0 Then
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
    Private mComponente As New cMEMBRE_GREMIAL
    Private mEntidad As MEMBRE_GREMIAL
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
        If Not Me.ViewState("ID_MEMBRE_GREMIAL") Is Nothing Then Me._ID_MEMBRE_GREMIAL = Me.ViewState("ID_MEMBRE_GREMIAL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla MEMBRE_GREMIAL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lProveedor As PROVEEDOR

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New MEMBRE_GREMIAL
        mEntidad.ID_MEMBRE_GREMIAL = ID_MEMBRE_GREMIAL

        If mComponente.ObtenerMEMBRE_GREMIAL(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
        Me.txtID_MEMBRE_GREMIAL.Text = mEntidad.ID_MEMBRE_GREMIAL.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.txtCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(mEntidad.CODIPROVEEDOR)
        If lProveedor IsNot Nothing Then
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.cbxTIPO_FINANCIAMIENTO.Value = mEntidad.ID_GREMIAL
        Me.txtNUM_MEMBRE_GREMIAL.Text = mEntidad.NUM_MEMBRE_GREMIAL
        Me.speMONTO_X_TC.Value = mEntidad.MONTO_X_TC
        Me.dteFECHA.Value = mEntidad.FECHA
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
       Me.cbxZAFRA.ClientEnabled = False
        Me.txtCODIPROVEE.ClientEnabled = Me._nuevo
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.dteFECHA.ClientEnabled = Me._nuevo
        Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = Me._nuevo
        Me.txtNUM_MEMBRE_GREMIAL.ClientEnabled = False
        Me.speMONTO_X_TC.ClientEnabled = Me._nuevo
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.txtCODIPROVEE.Text = ""
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
        Me.dteFECHA.Value = Nothing
        Me.txtNUM_MEMBRE_GREMIAL.Text = ""
        Me.speMONTO_X_TC.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla MEMBRE_GREMIAL
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New MEMBRE_GREMIAL
        If Me._nuevo Then
            mEntidad.ID_MEMBRE_GREMIAL = 0
            mEntidad.NUM_MEMBRE_GREMIAL = 0
            mEntidad.UID_MEMBRE_CONTRATO = Guid.NewGuid
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cMEMBRE_GREMIAL).ObtenerMEMBRE_GREMIAL(CInt(Me.txtID_MEMBRE_GREMIAL.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If cbxZAFRA.Text = "" Then
            Return "Seleccione la zafra"
        End If
        If txtCODIPROVEE.Text = "" Then
            Return "Ingrese el codigo de proveedor"
        End If
        If Me.speMONTO_X_TC.Value Is Nothing OrElse Me.speMONTO_X_TC.Value = 0 Then
            Return "El Monto por TC no puede ser cero"
        End If
        mEntidad.CODIPROVEEDOR = Utilerias.FormatearCODIPROVEEDOR(Me.txtCODIPROVEE.Value)
        mEntidad.FECHA = Me.dteFECHA.Value
        mEntidad.ID_GREMIAL = Me.cbxTIPO_FINANCIAMIENTO.Value
        mEntidad.MONTO_X_TC = Me.speMONTO_X_TC.Value
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.ZAFRA = Me.cbxZAFRA.Text

        If mComponente.ActualizarMEMBRE_GREMIAL(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_MEMBRE_GREMIAL.Text = mEntidad.ID_MEMBRE_GREMIAL.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub txtCODIPROVEE_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE.ValueChanged
        Me.ObtenerProveedor()
    End Sub

    Private Sub ObtenerProveedor()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If Me.txtCODIPROVEE.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.txtCODIPROVEE.Text) Then
            Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text) + Utilerias.FormatoCODISOCIO(0)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
            If lProveedor IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                Me.dteFECHA.Value = Nothing
                Me.speMONTO_X_TC.Value = Nothing
            End If
        End If
    End Sub

End Class
