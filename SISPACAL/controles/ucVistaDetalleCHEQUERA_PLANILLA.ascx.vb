Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCHEQUERA_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CHEQUERA_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCHEQUERA_PLANILLA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CHEQUERA As Int32
    Public Property ID_CHEQUERA() As Int32
        Get
            Return Me.txtID_CHEQUERA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CHEQUERA = Value
            Me.txtID_CHEQUERA.Text = CStr(Value)
            If Me._ID_CHEQUERA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_CUENTA() As Int32
        Get
            Return Me.ddlCUENTA_BANCARIAID_CUENTA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCUENTA_BANCARIAID_CUENTA.Items.FindByValue(value) Is Nothing Then
                Me.ddlCUENTA_BANCARIAID_CUENTA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property SERIE() As String
        Get
            Return Me.txtSERIE.Text
        End Get
        Set(ByVal value As String)
            Me.txtSERIE.Text = value.ToString()
        End Set
    End Property

    Public Property NO_CHEQUE_INICIAL() As Int32
        Get
            If Me.txtNO_CHEQUE_INICIAL.Text ="" Then Return -1
            Return CInt(Me.txtNO_CHEQUE_INICIAL.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_CHEQUE_INICIAL.Text = value.ToString()
        End Set
    End Property

    Public Property NO_CHEQUE_FINAL() As Int32
        Get
            If Me.txtNO_CHEQUE_FINAL.Text ="" Then Return -1
            Return CInt(Me.txtNO_CHEQUE_FINAL.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_CHEQUE_FINAL.Text = value.ToString()
        End Set
    End Property

    Public Property ULT_CHEQUE_ASIGNADO() As Int32
        Get
            If Me.txtULT_CHEQUE_ASIGNADO.Text ="" Then Return -1
            Return CInt(Me.txtULT_CHEQUE_ASIGNADO.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtULT_CHEQUE_ASIGNADO.Text = value.ToString()
        End Set
    End Property

    Public Property ACTIVO() As Boolean
        Get
            Return Me.cbxACTIVO.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxACTIVO.Checked = value
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

    Public Property VerID_CHEQUERA() As Boolean
        Get
            Return Me.trID_CHEQUERA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CHEQUERA.Visible = value
        End Set
    End Property

    Public Property VerID_CUENTA() As Boolean
        Get
            Return Me.trID_CUENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CUENTA.Visible = value
        End Set
    End Property

    Public Property VerSERIE() As Boolean
        Get
            Return Me.trSERIE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSERIE.Visible = value
        End Set
    End Property

    Public Property VerNO_CHEQUE_INICIAL() As Boolean
        Get
            Return Me.trNO_CHEQUE_INICIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_CHEQUE_INICIAL.Visible = value
        End Set
    End Property

    Public Property VerNO_CHEQUE_FINAL() As Boolean
        Get
            Return Me.trNO_CHEQUE_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_CHEQUE_FINAL.Visible = value
        End Set
    End Property

    Public Property VerULT_CHEQUE_ASIGNADO() As Boolean
        Get
            Return Me.trULT_CHEQUE_ASIGNADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trULT_CHEQUE_ASIGNADO.Visible = value
        End Set
    End Property

    Public Property VerACTIVO() As Boolean
        Get
            Return Me.trACTIVO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACTIVO.Visible = value
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
    Private mComponente As New cCHEQUERA_PLANILLA
    Private mEntidad As CHEQUERA_PLANILLA
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
        If Not Me.ViewState("ID_CHEQUERA") Is Nothing Then Me._ID_CHEQUERA = Me.ViewState("ID_CHEQUERA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CHEQUERA_PLANILLA
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
        mEntidad = New CHEQUERA_PLANILLA
        mEntidad.ID_CHEQUERA = ID_CHEQUERA
 
        If mComponente.ObtenerCHEQUERA_PLANILLA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CHEQUERA.Text = mEntidad.ID_CHEQUERA.ToString()
        Me.ddlCUENTA_BANCARIAID_CUENTA.Recuperar()
        Me.ddlCUENTA_BANCARIAID_CUENTA.SelectedValue = mEntidad.ID_CUENTA
        Me.txtSERIE.Text = mEntidad.SERIE
        Me.txtNO_CHEQUE_INICIAL.Text = mEntidad.NO_CHEQUE_INICIAL
        Me.txtNO_CHEQUE_FINAL.Text = mEntidad.NO_CHEQUE_FINAL
        If mEntidad.ULT_CHEQUE_ASIGNADO = -1 Then Me.txtULT_CHEQUE_ASIGNADO.Text = "" Else Me.txtULT_CHEQUE_ASIGNADO.Text = mEntidad.ULT_CHEQUE_ASIGNADO
        Me.cbxACTIVO.Checked = mEntidad.ACTIVO
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
        Me.ddlCUENTA_BANCARIAID_CUENTA.Enabled = edicion
        Me.txtSERIE.Enabled = edicion
        Me.txtNO_CHEQUE_INICIAL.Enabled = edicion
        Me.txtNO_CHEQUE_FINAL.Enabled = edicion
        Me.txtULT_CHEQUE_ASIGNADO.Enabled = Not Me._nuevo
        Me.cbxACTIVO.Enabled = edicion
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
        Me.ddlCUENTA_BANCARIAID_CUENTA.Recuperar()
        Me.txtSERIE.Text = ""
        Me.txtNO_CHEQUE_INICIAL.Text = ""
        Me.txtNO_CHEQUE_FINAL.Text = ""
        Me.txtULT_CHEQUE_ASIGNADO.Text = ""
        Me.cbxACTIVO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CHEQUERA_PLANILLA
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
        mEntidad = New CHEQUERA_PLANILLA

        If Not Utilerias.EsNumeroEntero(Me.txtNO_CHEQUE_INICIAL.Text) Then
            AsignarMensaje("El numero inicial debe ser un numero entero", True)
            Return "Error"
        End If
        If Not Utilerias.EsNumeroEntero(Me.txtNO_CHEQUE_FINAL.Text) Then
            AsignarMensaje("El numero final debe ser un numero entero", True)
            Return "Error"
        End If

        If Me._nuevo Then
            mEntidad.ID_CHEQUERA = 0
            mEntidad.ULT_CHEQUE_ASIGNADO = -1
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cCHEQUERA_PLANILLA).ObtenerCHEQUERA_PLANILLA(CInt(Me.txtID_CHEQUERA.Text))
            If Me.txtULT_CHEQUE_ASIGNADO.Text.Trim <> "" Then
                If Not Utilerias.EsNumeroEntero(Me.txtULT_CHEQUE_ASIGNADO.Text) Then
                    AsignarMensaje("El ultimo numero asignado debe ser un numero entero", True)
                    Return "Error"
                End If
                If Convert.ToInt32(Me.txtULT_CHEQUE_ASIGNADO.Text) > Convert.ToInt32(Me.txtNO_CHEQUE_FINAL) OrElse _
                   Convert.ToInt32(Me.txtULT_CHEQUE_ASIGNADO.Text) < Convert.ToInt32(Me.txtNO_CHEQUE_INICIAL) Then
                    AsignarMensaje("El ultimo numero asignado esta fuera del rango de numeracion", True)
                    Return "Error"
                End If
                mEntidad.ULT_CHEQUE_ASIGNADO = Val(Me.txtULT_CHEQUE_ASIGNADO.Text)
            Else
                mEntidad.ULT_CHEQUE_ASIGNADO = -1
            End If
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_CUENTA = Me.ddlCUENTA_BANCARIAID_CUENTA.SelectedValue
        mEntidad.SERIE = Me.txtSERIE.Text.Trim.ToUpper
        mEntidad.NO_CHEQUE_INICIAL = Convert.ToInt32(Me.txtNO_CHEQUE_INICIAL.Text)
        mEntidad.NO_CHEQUE_FINAL = Convert.ToInt32(Me.txtNO_CHEQUE_FINAL.Text)
        mEntidad.ACTIVO = Me.cbxACTIVO.Checked

        If mComponente.ActualizarCHEQUERA_PLANILLA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CHEQUERA.Text = mEntidad.ID_CHEQUERA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
