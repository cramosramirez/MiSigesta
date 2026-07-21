Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleDIA_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla DIA_ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleDIA_ZAFRA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_DIA_ZAFRA As Int32
    Public Property ID_DIA_ZAFRA() As Int32
        Get
            Return Me.txtID_DIA_ZAFRA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_DIA_ZAFRA = Value
            Me.txtID_DIA_ZAFRA.Text = CStr(Value)
            If Me._ID_DIA_ZAFRA > 0 Then
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

    Public Property DIAZAFRA() As Int32
        Get
            If Me.txtDIAZAFRA.Text ="" Then Return -1
            Return CInt(Me.txtDIAZAFRA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtDIAZAFRA.Text = value.ToString()
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
            If Me.txtEFICIENCIA_REAL.Text ="" Then Return -1
            Return Me.txtEFICIENCIA_REAL.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtEFICIENCIA_REAL.Text = value.ToString()
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

    Public Property VerID_DIA_ZAFRA() As Boolean
        Get
            Return Me.trID_DIA_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_DIA_ZAFRA.Visible = value
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

    Public Property VerDIAZAFRA() As Boolean
        Get
            Return Me.trDIAZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIAZAFRA.Visible = value
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

    Public Property VerEFICIENCIA_REAL() As Boolean
        Get
            Return Me.trEFICIENCIA_REAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEFICIENCIA_REAL.Visible = value
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
    Private mComponente As New cDIA_ZAFRA
    Private mEntidad As DIA_ZAFRA
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
        If Not Me.ViewState("ID_DIA_ZAFRA") Is Nothing Then Me._ID_DIA_ZAFRA = Me.ViewState("ID_DIA_ZAFRA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla DIA_ZAFRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New DIA_ZAFRA
        mEntidad.ID_DIA_ZAFRA = ID_DIA_ZAFRA
 
        If mComponente.ObtenerDIA_ZAFRA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_DIA_ZAFRA.Text = mEntidad.ID_DIA_ZAFRA.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.txtDIAZAFRA.Text = mEntidad.DIAZAFRA
        Me.txtAZUCAR_PRODUCIDA.Text = mEntidad.AZUCAR_PRODUCIDA
        Me.txtAZUCAR_CALC1.Text = mEntidad.AZUCAR_CALC1
        Me.txtEFICIENCIA_REAL.Text = mEntidad.EFICIENCIA_REAL
        Me.txtUSUARIO_CIERRE.Text = mEntidad.USUARIO_CIERRE
        Me.txtFECHA_CIERRE.Text = IIf(Not mEntidad.FECHA_CIERRE = Nothing, Format(mEntidad.FECHA_CIERRE, "dd/MM/yyyy"), "")
        'Me.txtHORA_CIERRE.Text = IIf(Not mEntidad.HORA_CIERRE = Nothing, Format(mEntidad.HORA_CIERRE, "hh:mm tt"), "")
        Me.dteFECHA.Date = mEntidad.FECHA
        Me.dteHORACIERRE.Date = mEntidad.HORA_CIERRE
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = False
        Me.txtDIAZAFRA.Enabled = False
        Me.txtAZUCAR_PRODUCIDA.Enabled = False
        Me.txtAZUCAR_CALC1.Enabled = False
        Me.txtEFICIENCIA_REAL.Enabled = False
        Me.txtUSUARIO_CIERRE.Enabled = edicion
        Me.txtFECHA_CIERRE.Enabled = edicion
        'Me.txtHORA_CIERRE.Enabled = edicion
        Me.dteHORACIERRE.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim fechaUltimoCierre As Date
        Dim fecHoraCierre As Date

        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.RecuperarZafraActiva()
        If lZafra IsNot Nothing Then
            Me.txtDIAZAFRA.Text = lZafra.DIAZAFRA.ToString
            fechaUltimoCierre = System.DateTime.Parse(lZafra.FECHA_ACT.ToString("dd/MM/yyyy"), New System.Globalization.CultureInfo("fr-FR", True), _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

            Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(lZafra.ID_ZAFRA, False, "FECHA", "DESC")
            If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
                Me.dteFECHA.Date = lDiasZafra(0).FECHA.AddDays(1)
                fecHoraCierre = lDiasZafra(0).FECHA_CIERRE.AddDays(1)
            Else
                Me.dteFECHA.Date = lZafra.FECHA_INICIO
                fecHoraCierre = lZafra.FECHA_INICIO.AddDays(1)
            End If
            Me.dteHORACIERRE.Date = New DateTime(fecHoraCierre.Year, fecHoraCierre.Month, fecHoraCierre.Day, 6, 0, 0)
        End If
        VerAZUCAR_CALC1 = False
        VerEFICIENCIA_REAL = False
        Me.txtAZUCAR_PRODUCIDA.Text = ""
        Me.txtAZUCAR_CALC1.Text = ""
        Me.txtEFICIENCIA_REAL.Text = ""
        Me.txtUSUARIO_CIERRE.Text = ""
        Me.txtFECHA_CIERRE.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla DIA_ZAFRA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim fHoraCierre As DateTime
        mEntidad = New DIA_ZAFRA

        If Me.dteFECHA.Value = Nothing Then
            Me.AsignarMensaje("Ingrese la fecha del dia zafra.", True)
            Return "Error"
        End If

        If Me.dteHORACIERRE.Value = Nothing Then
            Me.AsignarMensaje("Ingrese la hora de cierre.", True)
            Me.dteHORACIERRE.Focus()
            Return "Error"
        End If

        If Me._nuevo Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ddlZAFRAID_ZAFRA.SelectedValue)
            Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(lZafra.ID_ZAFRA, False, "FECHA", "DESC")

            mEntidad.ID_DIA_ZAFRA = 0
            mEntidad.USUARIO_CIERRE = Me.ObtenerUsuario
            mEntidad.FECHA_CIERRE = cFechaHora.ObtenerFechaHora
            mEntidad.FECHA = dteFECHA.Date
            If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
                For i As Int32 = 0 To lDiasZafra.Count - 1
                    If lDiasZafra(i).FECHA = Me.dteFECHA.Date Then
                        Me.AsignarMensaje("* La fecha del dia zafra ya se ejecuto.", True)
                        Return "Error"
                        Exit For
                    End If
                Next
            End If
        Else
            mEntidad = (New cDIA_ZAFRA).ObtenerDIA_ZAFRA(CInt(Me.txtID_DIA_ZAFRA.Text))
        End If
        mEntidad.AZUCAR_PRODUCIDA = -1
        mEntidad.EFICIENCIA_REAL = -1
        mEntidad.ID_ZAFRA = ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.DIAZAFRA = Convert.ToInt32(Me.txtDIAZAFRA.Text)
        fHoraCierre = Me.dteHORACIERRE.Date
        mEntidad.HORA_CIERRE = New DateTime(fHoraCierre.Year, fHoraCierre.Month, fHoraCierre.Day, fHoraCierre.Hour, fHoraCierre.Minute, 0)

        If mComponente.ActualizarDIA_ZAFRA(mEntidad) = -1 Then
            Me.AsignarMensaje("Error al Guardar registro. " + mComponente.sError, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_DIA_ZAFRA.Text = mEntidad.ID_DIA_ZAFRA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
