Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleORDEN_COMBUSTIBLE_NUMERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ORDEN_COMBUSTIBLE_NUMERACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleORDEN_COMBUSTIBLE_NUMERACION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ORDEN_COMBUSTIBLE_NUM As Int32
    Public Property ID_ORDEN_COMBUSTIBLE_NUM() As Int32
        Get
            Return Me.txtID_ORDEN_COMBUSTIBLE_NUM.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ORDEN_COMBUSTIBLE_NUM = Value
            Me.txtID_ORDEN_COMBUSTIBLE_NUM.Text = CStr(Value)
            If Me._ID_ORDEN_COMBUSTIBLE_NUM > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ZAFRA() As Int32
        Get
            Return Me.ddlZAFRAID_ZAFRA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlZAFRAID_ZAFRA.Items.FindByValue(value) Is Nothing Then
                Me.ddlZAFRAID_ZAFRA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property SERIE_ORDEN_COMBUSTIBLE() As String
        Get
            Return Me.txtSERIE_ORDEN_COMBUSTIBLE.Text
        End Get
        Set(ByVal value As String)
            Me.txtSERIE_ORDEN_COMBUSTIBLE.Text = value.ToString()
        End Set
    End Property

    Public Property NO_INICIAL() As Int32
        Get
            If Me.txtNO_INICIAL.Text ="" Then Return -1
            Return CInt(Me.txtNO_INICIAL.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_INICIAL.Text = value.ToString()
        End Set
    End Property

    Public Property NO_FINAL() As Int32
        Get
            If Me.txtNO_FINAL.Text ="" Then Return -1
            Return CInt(Me.txtNO_FINAL.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_FINAL.Text = value.ToString()
        End Set
    End Property

    Public Property ULT_NUM_ASIGNADO() As Int32
        Get
            If Me.txtULT_NUM_ASIGNADO.Text ="" Then Return -1
            Return CInt(Me.txtULT_NUM_ASIGNADO.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtULT_NUM_ASIGNADO.Text = value.ToString()
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

    Public Property VerID_ORDEN_COMBUSTIBLE_NUM() As Boolean
        Get
            Return Me.trID_ORDEN_COMBUSTIBLE_NUM.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ORDEN_COMBUSTIBLE_NUM.Visible = value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerSERIE_ORDEN_COMBUSTIBLE() As Boolean
        Get
            Return Me.trSERIE_ORDEN_COMBUSTIBLE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSERIE_ORDEN_COMBUSTIBLE.Visible = value
        End Set
    End Property

    Public Property VerNO_INICIAL() As Boolean
        Get
            Return Me.trNO_INICIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_INICIAL.Visible = value
        End Set
    End Property

    Public Property VerNO_FINAL() As Boolean
        Get
            Return Me.trNO_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_FINAL.Visible = value
        End Set
    End Property

    Public Property VerULT_NUM_ASIGNADO() As Boolean
        Get
            Return Me.trULT_NUM_ASIGNADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trULT_NUM_ASIGNADO.Visible = value
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
    Private mComponente As New cORDEN_COMBUSTIBLE_NUMERACION
    Private mEntidad As ORDEN_COMBUSTIBLE_NUMERACION
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
        If Not Me.ViewState("ID_ORDEN_COMBUSTIBLE_NUM") Is Nothing Then Me._ID_ORDEN_COMBUSTIBLE_NUM = Me.ViewState("ID_ORDEN_COMBUSTIBLE_NUM")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ORDEN_COMBUSTIBLE_NUMERACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ORDEN_COMBUSTIBLE_NUMERACION
        mEntidad.ID_ORDEN_COMBUSTIBLE_NUM = ID_ORDEN_COMBUSTIBLE_NUM
 
        If mComponente.ObtenerORDEN_COMBUSTIBLE_NUMERACION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ORDEN_COMBUSTIBLE_NUM.Text = mEntidad.ID_ORDEN_COMBUSTIBLE_NUM.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.txtSERIE_ORDEN_COMBUSTIBLE.Text = mEntidad.SERIE_ORDEN_COMBUSTIBLE
        Me.txtNO_INICIAL.Text = mEntidad.NO_INICIAL
        Me.txtNO_FINAL.Text = mEntidad.NO_FINAL
        Me.txtULT_NUM_ASIGNADO.Text = mEntidad.ULT_NUM_ASIGNADO
        Me.cbxES_INGENIO.Checked = mEntidad.ES_INGENIO
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.txtSERIE_ORDEN_COMBUSTIBLE.Enabled = edicion
        Me.txtNO_INICIAL.Enabled = edicion
        Me.txtNO_FINAL.Enabled = edicion
        Me.txtULT_NUM_ASIGNADO.Enabled = edicion
        Me.cbxES_INGENIO.Enabled = edicion
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.txtSERIE_ORDEN_COMBUSTIBLE.Text = ""
        Me.txtNO_INICIAL.Text = ""
        Me.txtNO_FINAL.Text = ""
        Me.txtULT_NUM_ASIGNADO.Text = ""
        Me.cbxES_INGENIO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ORDEN_COMBUSTIBLE_NUMERACION
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ORDEN_COMBUSTIBLE_NUMERACION
        If Me._nuevo Then
            mEntidad.ID_ORDEN_COMBUSTIBLE_NUM = 0
        Else
            mEntidad.ID_ORDEN_COMBUSTIBLE_NUM = CInt(Me.txtID_ORDEN_COMBUSTIBLE_NUM.Text)
        End If
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.SERIE_ORDEN_COMBUSTIBLE = Me.txtSERIE_ORDEN_COMBUSTIBLE.Text
        mEntidad.NO_INICIAL = Val(Me.txtNO_INICIAL.Text)
        mEntidad.NO_FINAL = Val(Me.txtNO_FINAL.Text)
        mEntidad.ULT_NUM_ASIGNADO = Val(Me.txtULT_NUM_ASIGNADO.Text)
        mEntidad.ES_INGENIO = Me.cbxES_INGENIO.Checked
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarORDEN_COMBUSTIBLE_NUMERACION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ORDEN_COMBUSTIBLE_NUM.Text = mEntidad.ID_ORDEN_COMBUSTIBLE_NUM.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
