Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePROVEEDOR_CARGA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROVEEDOR_CARGA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROVEEDOR_CARGA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PROVEEDOR_CARGA As Int32
    Public Property ID_PROVEEDOR_CARGA() As Int32
        Get
            Return Me.txtID_PROVEEDOR_CARGA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PROVEEDOR_CARGA = Value
            Me.txtID_PROVEEDOR_CARGA.Text = CStr(Value)
            If Me._ID_PROVEEDOR_CARGA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_PROVEEDOR_CARGA() As String
        Get
            Return Me.txtNOMBRE_PROVEEDOR_CARGA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROVEEDOR_CARGA.Text = value.ToString()
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.txtNIT.Text
        End Get
        Set(ByVal value As String)
            Me.txtNIT.Text = value.ToString()
        End Set
    End Property

    Public Property DUI() As String
        Get
            Return Me.txtDUI.Text
        End Get
        Set(ByVal value As String)
            Me.txtDUI.Text = value.ToString()
        End Set
    End Property

    Public Property CREDITO_FISCAL() As String
        Get
            Return Me.txtCREDITO_FISCAL.Text
        End Get
        Set(ByVal value As String)
            Me.txtCREDITO_FISCAL.Text = value.ToString()
        End Set
    End Property

    Public Property ES_CONTRIBUYENTE() As Boolean
        Get
            Return Me.cbxES_CONTRIBUYENTE.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxES_CONTRIBUYENTE.Checked = value
        End Set
    End Property

    Public Property ES_INGENIO() As Boolean
        Get
            Return Me.cbxES_INGENIO.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxES_INGENIO.Checked = value
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

    Public Property VerID_PROVEEDOR_CARGA() As Boolean
        Get
            Return Me.trID_PROVEEDOR_CARGA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEEDOR_CARGA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_PROVEEDOR_CARGA() As Boolean
        Get
            Return Me.trNOMBRE_PROVEEDOR_CARGA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_PROVEEDOR_CARGA.Visible = value
        End Set
    End Property

    Public Property VerNIT() As Boolean
        Get
            Return Me.trNIT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNIT.Visible = value
        End Set
    End Property

    Public Property VerDUI() As Boolean
        Get
            Return Me.trDUI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDUI.Visible = value
        End Set
    End Property

    Public Property VerCREDITO_FISCAL() As Boolean
        Get
            Return Me.trCREDITO_FISCAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCREDITO_FISCAL.Visible = value
        End Set
    End Property

    Public Property VerES_CONTRIBUYENTE() As Boolean
        Get
            Return Me.trES_CONTRIBUYENTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trES_CONTRIBUYENTE.Visible = value
        End Set
    End Property

    Public Property VerES_INGENIO() As Boolean
        Get
            Return Me.trES_INGENIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trES_INGENIO.Visible = value
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
    Private mComponente As New cPROVEEDOR_CARGA
    Private mEntidad As PROVEEDOR_CARGA
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
        If Not Me.ViewState("ID_PROVEEDOR_CARGA") Is Nothing Then Me._ID_PROVEEDOR_CARGA = Me.ViewState("ID_PROVEEDOR_CARGA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PROVEEDOR_CARGA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PROVEEDOR_CARGA
        mEntidad.ID_PROVEEDOR_CARGA = ID_PROVEEDOR_CARGA
 
        If mComponente.ObtenerPROVEEDOR_CARGA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PROVEEDOR_CARGA.Text = mEntidad.ID_PROVEEDOR_CARGA.ToString()
        Me.txtNOMBRE_PROVEEDOR_CARGA.Text = mEntidad.NOMBRE_PROVEEDOR_CARGA
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtCREDITO_FISCAL.Text = mEntidad.CREDITO_FISCAL
        Me.cbxES_CONTRIBUYENTE.Checked = mEntidad.ES_CONTRIBUYENTE
        Me.cbxES_INGENIO.Checked = mEntidad.ES_INGENIO
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")

        Me.txtDIRECCION.Text = mEntidad.DIRECCION
        Me.txtTELEFONO.Text = mEntidad.TELEFONO
        Me.txtACTIVIDAD.Text = mEntidad.ACTIVIDAD
        Me.txtCORREO.Text = mEntidad.CORREO
        Me.txtCODIGO.Text = mEntidad.CODIGO
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE_PROVEEDOR_CARGA.Enabled = edicion
        Me.txtNIT.Enabled = edicion
        Me.txtDUI.Enabled = edicion
        Me.txtCREDITO_FISCAL.Enabled = edicion
        Me.cbxES_CONTRIBUYENTE.Enabled = edicion
        Me.cbxES_INGENIO.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
        Me.txtDIRECCION.Enabled = edicion
        Me.txtTELEFONO.Enabled = edicion
        Me.txtACTIVIDAD.Enabled = edicion
        Me.txtCORREO.Enabled = edicion
        Me.txtCODIGO.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOMBRE_PROVEEDOR_CARGA.Text = ""
        Me.txtNIT.Text = ""
        Me.txtDUI.Text = ""
        Me.txtCREDITO_FISCAL.Text = ""
        Me.cbxES_CONTRIBUYENTE.Checked = False
        Me.cbxES_INGENIO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""

        Me.txtDIRECCION.Text = ""
        Me.txtTELEFONO.Text = ""
        Me.txtACTIVIDAD.Text = ""
        Me.txtCORREO.Text = ""
        Me.txtCODIGO.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PROVEEDOR_CARGA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PROVEEDOR_CARGA
        If Me._nuevo Then
            mEntidad.ID_PROVEEDOR_CARGA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cPROVEEDOR_CARGA).ObtenerPROVEEDOR_CARGA(CInt(Me.txtID_PROVEEDOR_CARGA.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.NOMBRE_PROVEEDOR_CARGA = Me.txtNOMBRE_PROVEEDOR_CARGA.Text
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.DUI = Me.txtDUI.Text
        mEntidad.CREDITO_FISCAL = Me.txtCREDITO_FISCAL.Text
        mEntidad.ES_CONTRIBUYENTE = Me.cbxES_CONTRIBUYENTE.Checked
        mEntidad.ES_INGENIO = Me.cbxES_INGENIO.Checked

        mEntidad.DIRECCION = Me.txtDIRECCION.Text.Trim.ToUpper
        mEntidad.TELEFONO = Me.txtTELEFONO.Text.Trim
        mEntidad.ACTIVIDAD = Me.txtACTIVIDAD.Text.Trim.ToUpper
        mEntidad.CORREO = Me.txtCORREO.Text.Trim.ToLower
        mEntidad.CODIGO = Me.txtCODIGO.Text

        If mComponente.ActualizarPROVEEDOR_CARGA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PROVEEDOR_CARGA.Text = mEntidad.ID_PROVEEDOR_CARGA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class

