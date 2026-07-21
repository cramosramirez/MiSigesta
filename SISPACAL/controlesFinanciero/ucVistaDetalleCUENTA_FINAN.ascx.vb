Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCUENTA_FINAN
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CUENTA_FINAN
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCUENTA_FINAN
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CUENTA_FINAN As Int32
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return Me.txtID_CUENTA_FINAN.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CUENTA_FINAN = Value
            Me.txtID_CUENTA_FINAN.Text = CStr(Value)
            If Me._ID_CUENTA_FINAN > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CODIGO_CUENTA() As String
        Get
            Return Me.txtCODIGO_CUENTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIGO_CUENTA.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_CUENTA() As String
        Get
            Return Me.txtNOMBRE_CUENTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_CUENTA.Text = value.ToString()
        End Set
    End Property

    Public Property DESCRIP_CUENTA() As String
        Get
            Return Me.txtDESCRIP_CUENTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRIP_CUENTA.Text = value.ToString()
        End Set
    End Property

    Public Property TIPO_FTO() As Int32
        Get
            If Me.txtTIPO_FTO.Value Is Nothing Then Return -1
            Return CInt(Me.txtTIPO_FTO.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtTIPO_FTO.Value = value
        End Set
    End Property

    Public Property APLICA_SOLIC_AGRICOLA() As Boolean
        Get
            Return Me.cbxAPLICA_SOLIC_AGRICOLA.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxAPLICA_SOLIC_AGRICOLA.Checked = value
        End Set
    End Property

    Public Property APLICA_ANALIS_FTO() As Boolean
        Get
            Return Me.cbxAPLICA_ANALIS_FTO.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxAPLICA_ANALIS_FTO.Checked = value
        End Set
    End Property

    Public Property APLICA_FACTURACION() As Boolean
        Get
            Return Me.cbxAPLICA_FACTURACION.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxAPLICA_FACTURACION.Checked = value
        End Set
    End Property

    Public Property APLICA_INTERES() As Boolean
        Get
            Return Me.cbxAPLICA_INTERES.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxAPLICA_INTERES.Checked = value
        End Set
    End Property

    Public Property APLICA_EMISION_CHEQ() As Boolean
        Get
            Return Me.cbxAPLICA_EMISION_CHEQ.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxAPLICA_EMISION_CHEQ.Checked = value
        End Set
    End Property

    Public Property APLICA_DESCTO_PLA() As Boolean
        Get
            Return Me.cbxAPLICA_DESCTO_PLA.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxAPLICA_DESCTO_PLA.Checked = value
        End Set
    End Property

    Public Property PORC_SUBSIDIO() As Decimal
        Get
            If Me.txtPORC_SUBSIDIO.Value Is Nothing Then Return -1
            Return Me.txtPORC_SUBSIDIO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_SUBSIDIO.Value = value
        End Set
    End Property

    Public Property ZAFRA() As String
        Get
            Return Me.txtZAFRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtZAFRA.Text = value.ToString()
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
            Return Me.deFECHA_CREA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CREA.Value = value
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

    Public Property VerID_CUENTA_FINAN() As Boolean
        Get
            Return Me.trID_CUENTA_FINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CUENTA_FINAN.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_CUENTA() As Boolean
        Get
            Return Me.trCODIGO_CUENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_CUENTA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_CUENTA() As Boolean
        Get
            Return Me.trNOMBRE_CUENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_CUENTA.Visible = value
        End Set
    End Property

    Public Property VerDESCRIP_CUENTA() As Boolean
        Get
            Return Me.trDESCRIP_CUENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIP_CUENTA.Visible = value
        End Set
    End Property

    Public Property VerTIPO_FTO() As Boolean
        Get
            Return Me.trTIPO_FTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_FTO.Visible = value
        End Set
    End Property

    Public Property VerAPLICA_SOLIC_AGRICOLA() As Boolean
        Get
            Return Me.trAPLICA_SOLIC_AGRICOLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPLICA_SOLIC_AGRICOLA.Visible = value
        End Set
    End Property

    Public Property VerAPLICA_ANALIS_FTO() As Boolean
        Get
            Return Me.trAPLICA_ANALIS_FTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPLICA_ANALIS_FTO.Visible = value
        End Set
    End Property

    Public Property VerAPLICA_FACTURACION() As Boolean
        Get
            Return Me.trAPLICA_FACTURACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPLICA_FACTURACION.Visible = value
        End Set
    End Property

    Public Property VerAPLICA_INTERES() As Boolean
        Get
            Return Me.trAPLICA_INTERES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPLICA_INTERES.Visible = value
        End Set
    End Property

    Public Property VerAPLICA_EMISION_CHEQ() As Boolean
        Get
            Return Me.trAPLICA_EMISION_CHEQ.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPLICA_EMISION_CHEQ.Visible = value
        End Set
    End Property

    Public Property VerAPLICA_DESCTO_PLA() As Boolean
        Get
            Return Me.trAPLICA_DESCTO_PLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPLICA_DESCTO_PLA.Visible = value
        End Set
    End Property

    Public Property VerPORC_SUBSIDIO() As Boolean
        Get
            Return Me.trPORC_SUBSIDIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_SUBSIDIO.Visible = value
        End Set
    End Property

    Public Property VerZAFRA() As Boolean
        Get
            Return Me.trZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZAFRA.Visible = value
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
    Private mComponente As New cCUENTA_FINAN
    Private mEntidad As CUENTA_FINAN
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
        If Not Me.ViewState("ID_CUENTA_FINAN") Is Nothing Then Me._ID_CUENTA_FINAN = Me.ViewState("ID_CUENTA_FINAN")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CUENTA_FINAN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CUENTA_FINAN
        mEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
 
        If mComponente.ObtenerCUENTA_FINAN(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CUENTA_FINAN.Text = mEntidad.ID_CUENTA_FINAN.ToString()
        Me.txtCODIGO_CUENTA.Text = mEntidad.CODIGO_CUENTA
        Me.txtNOMBRE_CUENTA.Text = mEntidad.NOMBRE_CUENTA
        Me.txtDESCRIP_CUENTA.Text = mEntidad.DESCRIP_CUENTA
        Me.txtTIPO_FTO.Value = mEntidad.TIPO_FTO
        Me.cbxAPLICA_SOLIC_AGRICOLA.Checked = mEntidad.APLICA_SOLIC_AGRICOLA
        Me.cbxAPLICA_ANALIS_FTO.Checked = mEntidad.APLICA_ANALIS_FTO
        Me.cbxAPLICA_FACTURACION.Checked = mEntidad.APLICA_FACTURACION
        Me.cbxAPLICA_INTERES.Checked = mEntidad.APLICA_INTERES
        Me.cbxAPLICA_EMISION_CHEQ.Checked = mEntidad.APLICA_EMISION_CHEQ
        Me.cbxAPLICA_DESCTO_PLA.Checked = mEntidad.APLICA_DESCTO_PLA
        Me.txtPORC_SUBSIDIO.Value = mEntidad.PORC_SUBSIDIO
        Me.txtZAFRA.Text = mEntidad.ZAFRA
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtCODIGO_CUENTA.Enabled = edicion
        Me.txtNOMBRE_CUENTA.Enabled = edicion
        Me.txtDESCRIP_CUENTA.Enabled = edicion
        Me.txtTIPO_FTO.Enabled = edicion
        Me.cbxAPLICA_SOLIC_AGRICOLA.Enabled = edicion
        Me.cbxAPLICA_ANALIS_FTO.Enabled = edicion
        Me.cbxAPLICA_FACTURACION.Enabled = edicion
        Me.cbxAPLICA_INTERES.Enabled = edicion
        Me.cbxAPLICA_EMISION_CHEQ.Enabled = edicion
        Me.cbxAPLICA_DESCTO_PLA.Enabled = edicion
        Me.txtPORC_SUBSIDIO.Enabled = edicion
        Me.txtZAFRA.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtCODIGO_CUENTA.Text = ""
        Me.txtNOMBRE_CUENTA.Text = ""
        Me.txtDESCRIP_CUENTA.Text = ""
        Me.txtTIPO_FTO.Value = Nothing
        Me.cbxAPLICA_SOLIC_AGRICOLA.Checked = False
        Me.cbxAPLICA_ANALIS_FTO.Checked = False
        Me.cbxAPLICA_FACTURACION.Checked = False
        Me.cbxAPLICA_INTERES.Checked = False
        Me.cbxAPLICA_EMISION_CHEQ.Checked = False
        Me.cbxAPLICA_DESCTO_PLA.Checked = False
        Me.txtPORC_SUBSIDIO.Value = Nothing
        Me.txtZAFRA.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CUENTA_FINAN
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CUENTA_FINAN
        If Me._nuevo Then
            mEntidad.ID_CUENTA_FINAN = 0
        Else
            mEntidad.ID_CUENTA_FINAN = CInt(Me.txtID_CUENTA_FINAN.Text)
        End If
        mEntidad.CODIGO_CUENTA = Me.txtCODIGO_CUENTA.Text
        mEntidad.NOMBRE_CUENTA = Me.txtNOMBRE_CUENTA.Text
        mEntidad.DESCRIP_CUENTA = Me.txtDESCRIP_CUENTA.Text
        mEntidad.TIPO_FTO = Me.txtTIPO_FTO.Value
        mEntidad.APLICA_SOLIC_AGRICOLA = Me.cbxAPLICA_SOLIC_AGRICOLA.Checked
        mEntidad.APLICA_ANALIS_FTO = Me.cbxAPLICA_ANALIS_FTO.Checked
        mEntidad.APLICA_FACTURACION = Me.cbxAPLICA_FACTURACION.Checked
        mEntidad.APLICA_INTERES = Me.cbxAPLICA_INTERES.Checked
        mEntidad.APLICA_EMISION_CHEQ = Me.cbxAPLICA_EMISION_CHEQ.Checked
        mEntidad.APLICA_DESCTO_PLA = Me.cbxAPLICA_DESCTO_PLA.Checked
        mEntidad.PORC_SUBSIDIO = Me.txtPORC_SUBSIDIO.Value
        mEntidad.ZAFRA = Me.txtZAFRA.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarCUENTA_FINAN(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CUENTA_FINAN.Text = mEntidad.ID_CUENTA_FINAN.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
