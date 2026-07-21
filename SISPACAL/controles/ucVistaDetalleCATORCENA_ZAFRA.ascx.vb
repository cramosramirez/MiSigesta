Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCATORCENA_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CATORCENA_ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCATORCENA_ZAFRA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CATORCENA As Int32
    Public Property ID_CATORCENA() As Int32
        Get
            Return Me.txtID_CATORCENA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CATORCENA = Value
            Me.txtID_CATORCENA.Text = CStr(Value)
            If Me._ID_CATORCENA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
            If VerFECHA_PAGO Then Me.txtFECHA_PAGO.Focus()
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

    Public Property CATORCENA() As Int32
        Get
            If Me.txtCATORCENA.Text ="" Then Return -1
            Return CInt(Me.txtCATORCENA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtCATORCENA.Text = value.ToString()
        End Set
    End Property

    Public Property AZUCAR_PRODUCIDA() As Decimal
        Get
            If Me.txtAZUCAR_PRODUCIDA.Text ="" Then Return -1
            Return Me.txtAZUCAR_PRODUCIDA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtAZUCAR_PRODUCIDA.Text = value.ToString()
        End Set
    End Property

    Public Property AZUCAR_CALC1() As Decimal
        Get
            If Me.txtAZUCAR_CALC1.Text ="" Then Return -1
            Return Me.txtAZUCAR_CALC1.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtAZUCAR_CALC1.Text = value.ToString()
        End Set
    End Property

    Public Property EFICIENCIA_REAL() As Decimal
        Get
            If Me.txtEFICIENCIA_REAL.Text = "" Then Return -1
            Return Me.txtEFICIENCIA_REAL.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtEFICIENCIA_REAL.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_INICIO() As DateTime
        Get
            Return Me.txtFECHA_INICIO.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_INICIO.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property FECHA_FIN() As DateTime
        Get
            Return Me.txtFECHA_FIN.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_FIN.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property USUARIO_CIERRE() As String
        Get
            Return Me.txtUSUARIO_CIERRE.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CIERRE.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CIERRE() As DateTime
        Get
            Return Me.txtFECHA_CIERRE.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_CIERRE.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.trID_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CATORCENA.Visible = value
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

    Public Property VerCATORCENA() As Boolean
        Get
            Return Me.trCATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCATORCENA.Visible = value
        End Set
    End Property

    Public Property VerAZUCAR_PRODUCIDA() As Boolean
        Get
            Return Me.trAZUCAR_PRODUCIDA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAZUCAR_PRODUCIDA.Visible = value
        End Set
    End Property

    Public Property VerAZUCAR_CALC1() As Boolean
        Get
            Return Me.trAZUCAR_CALC1.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAZUCAR_CALC1.Visible = value
        End Set
    End Property

    Public Property VerFECHA_PAGO() As Boolean
        Get
            Return Me.trFECHA_PAGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_PAGO.Visible = value
        End Set
    End Property

    Public Property VerEFICIANCIA_REAL() As Boolean
        Get
            Return Me.trEFICIANCIA_REAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEFICIANCIA_REAL.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.trFECHA_INICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INICIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me.trFECHA_FIN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_FIN.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_CIERRE() As Boolean
        Get
            Return Me.trUSUARIO_CIERRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CIERRE.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CIERRE() As Boolean
        Get
            Return Me.trFECHA_CIERRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CIERRE.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCATORCENA_ZAFRA
    Private mEntidad As CATORCENA_ZAFRA
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
        If Not Me.ViewState("ID_CATORCENA") Is Nothing Then Me._ID_CATORCENA = Me.ViewState("ID_CATORCENA")
        VerAZUCAR_CALC1 = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CATORCENA_ZAFRA
        mEntidad.ID_CATORCENA = ID_CATORCENA

        If mComponente.ObtenerCATORCENA_ZAFRA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CATORCENA.Text = mEntidad.ID_CATORCENA.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.txtCATORCENA.Text = mEntidad.CATORCENA
        Me.txtAZUCAR_PRODUCIDA.Text = (mEntidad.AZUCAR_PRODUCIDA).ToString("#,###,##0.00")
        Me.txtAZUCAR_CALC1.Text = mEntidad.AZUCAR_CALC1
        Me.txtEFICIENCIA_REAL.Text = mEntidad.EFICIENCIA_REAL
        Me.txtFECHA_INICIO.Text = IIf(Not mEntidad.FECHA_INICIO = Nothing, Format(mEntidad.FECHA_INICIO, "dd/MM/yyyy"), "")
        Me.txtFECHA_FIN.Text = IIf(Not mEntidad.FECHA_FIN = Nothing, Format(mEntidad.FECHA_FIN, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_CIERRE.Text = mEntidad.USUARIO_CIERRE
        Me.txtFECHA_CIERRE.Text = IIf(Not mEntidad.FECHA_CIERRE = Nothing, Format(mEntidad.FECHA_CIERRE, "dd/MM/yyyy"), "")
        Me.txtFECHA_PAGO.Text = IIf(Not mEntidad.FECHA_PAGO = Nothing AndAlso mEntidad.FECHA_PAGO <> #12:00:00 AM#, Format(mEntidad.FECHA_PAGO, "dd/MM/yyyy"), "")
        Me.trDIAZAFRA.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = False
        Me.txtCATORCENA.Enabled = False
        Me.txtAZUCAR_PRODUCIDA.Enabled = Me._nuevo
        Me.txtAZUCAR_CALC1.Enabled = False
        Me.txtEFICIENCIA_REAL.Enabled = Me._nuevo
        Me.txtFECHA_INICIO.Enabled = False
        Me.txtFECHA_FIN.Enabled = False
        Me.txtUSUARIO_CIERRE.Enabled = edicion
        Me.txtFECHA_CIERRE.Enabled = edicion
        Me.txtFECHA_PAGO.Enabled = False
        Me.trFECHA_PAGO.Visible = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.RecuperarZafraActiva()
        If lZafra IsNot Nothing Then
            Me.txtCATORCENA.Text = lZafra.CATORCENA.ToString

            'Obtener la producción de azúcar en base a eficiencia del 85% de la catorcena actual

        End If
        Me.txtAZUCAR_PRODUCIDA.Text = ""
        Me.txtAZUCAR_CALC1.Text = ""
        Me.txtEFICIENCIA_REAL.Text = ""
        Me.txtFECHA_INICIO.Text = ""
        Me.txtFECHA_FIN.Text = ""
        Me.txtUSUARIO_CIERRE.Text = ""
        Me.txtFECHA_CIERRE.Text = ""
        Me.txtDIA_ZAFRA.Text = ""



    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim fechaPago As Date
        Dim lDiaZafra As New DIA_ZAFRA

        If Me.txtEFICIENCIA_REAL.Text.Trim <> "" AndAlso Not IsNumeric(Me.txtEFICIENCIA_REAL.Text) Then
            AsignarMensaje("* La eficiencia real debe ser un valor numerico", True)
            Return "Error"
        End If
        If Me.txtEFICIENCIA_REAL.Text.Trim <> "" AndAlso Convert.ToDecimal(Me.txtEFICIENCIA_REAL.Text) >= 1 Then
            AsignarMensaje("* La eficiencia real debe ser menor que 1", True)
            Return "Error"
        End If
        If Not IsNumeric(Me.txtAZUCAR_PRODUCIDA.Text) Then
            AsignarMensaje("* La produccion debe ser un valor numerico", True)
            Return "Error"
        End If

        mEntidad = New CATORCENA_ZAFRA
        If Me._nuevo Then

            If Not Utilerias.EsNumeroEntero(Me.txtDIA_ZAFRA.Text) Then
                AsignarMensaje("* El dia zafra de cierre debe ser un valor numerico", True)
                Return "Error"
            End If

            'Verificar que existe dia zafra
            lDiaZafra = (New cDIA_ZAFRA).ObtenerPorZAFRA_DIA(Me.ddlZAFRAID_ZAFRA.SelectedValue, CInt(Me.txtDIA_ZAFRA.Text))
            If lDiaZafra Is Nothing Then
                AsignarMensaje("* El dia zafra de cierre no existe para esta zafra", True)
                Return "Error"
            End If

            mEntidad.ID_CATORCENA = 0
            mEntidad.USUARIO_CIERRE = Me.ObtenerUsuario
            mEntidad.FECHA_CIERRE = cFechaHora.ObtenerFechaHora
            mEntidad.FECHA_PAGO = #12:00:00 AM#
            If Me.txtEFICIENCIA_REAL.Text.Trim <> "" Then
                mEntidad.EFICIENCIA_REAL = Convert.ToDecimal(Me.txtEFICIENCIA_REAL.Text.Trim)
            Else
                mEntidad.EFICIENCIA_REAL = 0
            End If
            mEntidad.FECHA_CIERRE = lDiaZafra.HORA_CIERRE
            mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
            mEntidad.CATORCENA = Convert.ToInt32(Me.txtCATORCENA.Text)
            mEntidad.AZUCAR_PRODUCIDA = Convert.ToDecimal(Me.txtAZUCAR_PRODUCIDA.Text)
            mEntidad.FECHA_FIN = lDiaZafra.FECHA
        Else
            mEntidad = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(CInt(Me.txtID_CATORCENA.Text))
            If Not System.DateTime.TryParse(Me.txtFECHA_PAGO.Text, _
                   New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaPago) Then
                Me.AsignarMensaje("* Fecha de Pago no vÃ¡lida", True, True)
                Return "Error al Guardar registro."
            End If
            If fechaPago < cFechaHora.ObtenerFecha Then
                Me.AsignarMensaje("* Fecha de Pago no puede ser menor a la fecha del sistema", True, True)
                Return "Error al Guardar registro."
            End If
            mEntidad.FECHA_PAGO = fechaPago
        End If

        If mComponente.ActualizarCATORCENA_ZAFRA(mEntidad) = -1 Then
            Me.AsignarMensaje("* " + mComponente.sError, True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CATORCENA.Text = mEntidad.ID_CATORCENA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
