Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCHEQUE_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CHEQUE_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCHEQUE_PLANILLA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CHEQUE_PLANILLA As Int32
    Public Property ID_CHEQUE_PLANILLA() As Int32
        Get
            Return Me.txtID_CHEQUE_PLANILLA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CHEQUE_PLANILLA = Value
            Me.txtID_CHEQUE_PLANILLA.Text = CStr(Value)
            If Me._ID_CHEQUE_PLANILLA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_CHEQUERA() As Int32
        Get
            Return Me.ddlCHEQUERA_PLANILLAID_CHEQUERA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCHEQUERA_PLANILLAID_CHEQUERA.Items.FindByValue(value) Is Nothing Then
                Me.ddlCHEQUERA_PLANILLAID_CHEQUERA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property NO_CHEQUE() As Int32
        Get
            If Me.txtNO_CHEQUE.Text ="" Then Return -1
            Return CInt(Me.txtNO_CHEQUE.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_CHEQUE.Text = value.ToString()
        End Set
    End Property

    Public Property MONTO_CHEQUE() As Decimal
        Get
            If Me.txtMONTO_CHEQUE.Text ="" Then Return -1
            Return Me.txtMONTO_CHEQUE.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtMONTO_CHEQUE.Text = value.ToString()
        End Set
    End Property

    Public Property CANTIDAD_LETRAS() As String
        Get
            Return Me.txtCANTIDAD_LETRAS.Text
        End Get
        Set(ByVal value As String)
            Me.txtCANTIDAD_LETRAS.Text = value.ToString()
        End Set
    End Property

    Public Property TITULAR_CHEQUE() As String
        Get
            Return Me.txtTITULAR_CHEQUE.Text
        End Get
        Set(ByVal value As String)
            Me.txtTITULAR_CHEQUE.Text = value.ToString()
        End Set
    End Property

    Public Property ESTADO() As String
        Get
            Return Me.txtESTADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtESTADO.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_EMISION() As DateTime
        Get
            Return Me.txtFECHA_EMISION.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_EMISION.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property FECHA_ANULACION() As DateTime
        Get
            Return Me.txtFECHA_ANULACION.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ANULACION.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property MOTIVO_ANULACION() As String
        Get
            Return Me.txtMOTIVO_ANULACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtMOTIVO_ANULACION.Text = value.ToString()
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

    Public Property VerID_CHEQUE_PLANILLA() As Boolean
        Get
            Return Me.trID_CHEQUE_PLANILLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CHEQUE_PLANILLA.Visible = value
        End Set
    End Property

    Public Property VerID_CHEQUERA() As Boolean
        Get
            Return Me.trID_CHEQUERA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CHEQUERA.Visible = value
        End Set
    End Property

    Public Property VerNO_CHEQUE() As Boolean
        Get
            Return Me.trNO_CHEQUE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_CHEQUE.Visible = value
        End Set
    End Property

    Public Property VerMONTO_CHEQUE() As Boolean
        Get
            Return Me.trMONTO_CHEQUE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_CHEQUE.Visible = value
        End Set
    End Property

    Public Property VerCANTIDAD_LETRAS() As Boolean
        Get
            Return Me.trCANTIDAD_LETRAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCANTIDAD_LETRAS.Visible = value
        End Set
    End Property

    Public Property VerTITULAR_CHEQUE() As Boolean
        Get
            Return Me.trTITULAR_CHEQUE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTITULAR_CHEQUE.Visible = value
        End Set
    End Property

    Public Property VerESTADO() As Boolean
        Get
            Return Me.trESTADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESTADO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_EMISION() As Boolean
        Get
            Return Me.trFECHA_EMISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_EMISION.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ANULACION() As Boolean
        Get
            Return Me.trFECHA_ANULACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ANULACION.Visible = value
        End Set
    End Property

    Public Property VerMOTIVO_ANULACION() As Boolean
        Get
            Return Me.trMOTIVO_ANULACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOTIVO_ANULACION.Visible = value
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
    Private mComponente As New cCHEQUE_PLANILLA
    Private mEntidad As CHEQUE_PLANILLA
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
        If Not Me.ViewState("ID_CHEQUE_PLANILLA") Is Nothing Then Me._ID_CHEQUE_PLANILLA = Me.ViewState("ID_CHEQUE_PLANILLA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CHEQUE_PLANILLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CHEQUE_PLANILLA
        mEntidad.ID_CHEQUE_PLANILLA = ID_CHEQUE_PLANILLA
 
        If mComponente.ObtenerCHEQUE_PLANILLA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CHEQUE_PLANILLA.Text = mEntidad.ID_CHEQUE_PLANILLA.ToString()
        Me.ddlCHEQUERA_PLANILLAID_CHEQUERA.Recuperar()
        Me.ddlCHEQUERA_PLANILLAID_CHEQUERA.SelectedValue = mEntidad.ID_CHEQUERA
        Me.txtNO_CHEQUE.Text = mEntidad.NO_CHEQUE
        Me.txtMONTO_CHEQUE.Text = mEntidad.MONTO_CHEQUE
        Me.txtCANTIDAD_LETRAS.Text = mEntidad.CANTIDAD_LETRAS
        Me.txtTITULAR_CHEQUE.Text = mEntidad.TITULAR_CHEQUE
        Me.txtESTADO.Text = mEntidad.ESTADO
        Me.txtFECHA_EMISION.Text = IIf(Not mEntidad.FECHA_EMISION = Nothing, Format(mEntidad.FECHA_EMISION, "dd/MM/yyyy"), "")
        Me.txtFECHA_ANULACION.Text = IIf(Not mEntidad.FECHA_ANULACION = Nothing, Format(mEntidad.FECHA_ANULACION, "dd/MM/yyyy"), "")
        Me.txtMOTIVO_ANULACION.Text = mEntidad.MOTIVO_ANULACION
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
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlCHEQUERA_PLANILLAID_CHEQUERA.Enabled = edicion
        Me.txtNO_CHEQUE.Enabled = edicion
        Me.txtMONTO_CHEQUE.Enabled = edicion
        Me.txtCANTIDAD_LETRAS.Enabled = edicion
        Me.txtTITULAR_CHEQUE.Enabled = edicion
        Me.txtESTADO.Enabled = edicion
        Me.txtFECHA_EMISION.Enabled = edicion
        Me.txtFECHA_ANULACION.Enabled = edicion
        Me.txtMOTIVO_ANULACION.Enabled = edicion
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
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlCHEQUERA_PLANILLAID_CHEQUERA.Recuperar()
        Me.txtNO_CHEQUE.Text = ""
        Me.txtMONTO_CHEQUE.Text = ""
        Me.txtCANTIDAD_LETRAS.Text = ""
        Me.txtTITULAR_CHEQUE.Text = ""
        Me.txtESTADO.Text = ""
        Me.txtFECHA_EMISION.Text = ""
        Me.txtFECHA_ANULACION.Text = ""
        Me.txtMOTIVO_ANULACION.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CHEQUE_PLANILLA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CHEQUE_PLANILLA
        If Me._nuevo Then
            mEntidad.ID_CHEQUE_PLANILLA = 0
        Else
            mEntidad.ID_CHEQUE_PLANILLA = CInt(Me.txtID_CHEQUE_PLANILLA.Text)
        End If
        mEntidad.ID_CHEQUERA = Me.ddlCHEQUERA_PLANILLAID_CHEQUERA.SelectedValue
        mEntidad.NO_CHEQUE = Val(Me.txtNO_CHEQUE.Text)
        mEntidad.MONTO_CHEQUE = Val(Me.txtMONTO_CHEQUE.Text)
        mEntidad.CANTIDAD_LETRAS = Me.txtCANTIDAD_LETRAS.Text
        mEntidad.TITULAR_CHEQUE = Me.txtTITULAR_CHEQUE.Text
        mEntidad.ESTADO = Me.txtESTADO.Text
        If Me.txtFECHA_EMISION.Text <> "" Then mEntidad.FECHA_EMISION = System.DateTime.Parse(Me.txtFECHA_EMISION.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        If Me.txtFECHA_ANULACION.Text <> "" Then mEntidad.FECHA_ANULACION = System.DateTime.Parse(Me.txtFECHA_ANULACION.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.MOTIVO_ANULACION = Me.txtMOTIVO_ANULACION.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarCHEQUE_PLANILLA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CHEQUE_PLANILLA.Text = mEntidad.ID_CHEQUE_PLANILLA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
