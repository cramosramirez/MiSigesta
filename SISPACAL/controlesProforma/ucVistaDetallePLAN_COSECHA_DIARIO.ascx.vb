Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePLAN_COSECHA_DIARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PLAN_COSECHA_DIARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePLAN_COSECHA_DIARIO
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PLAN_COSECHA_DIARIO As Int32
    Public Property ID_PLAN_COSECHA_DIARIO() As Int32
        Get
            Return Me.txtID_PLAN_COSECHA_DIARIO.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PLAN_COSECHA_DIARIO = Value
            Me.txtID_PLAN_COSECHA_DIARIO.Text = CStr(Value)
            If Me._ID_PLAN_COSECHA_DIARIO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property FECHA() As DateTime
        Get
            Return Me.deFECHA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA.Value = value
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

    Public Property ACCESLOTE() As String
        Get
            Return Me.ddlLOTESACCESLOTE.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlLOTESACCESLOTE.Items.FindByValue(value) Is Nothing Then
                Me.ddlLOTESACCESLOTE.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ZONA() As String
        Get
            Return Me.txtZONA.Text
        End Get
        Set(ByVal value As String)
            Me.txtZONA.Text = value.ToString()
        End Set
    End Property

    Public Property CODILOTE() As String
        Get
            Return Me.txtCODILOTE.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODILOTE.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBLOTE() As String
        Get
            Return Me.txtNOMBLOTE.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBLOTE.Text = value.ToString()
        End Set
    End Property

    Public Property CODIPROVEE() As String
        Get
            Return Me.txtCODIPROVEE.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEE.Text = value.ToString()
        End Set
    End Property

    Public Property CCODISOCIO() As String
        Get
            Return Me.txtCCODISOCIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCCODISOCIO.Text = value.ToString()
        End Set
    End Property

    Public Property PROVEEDOR() As String
        Get
            Return Me.txtPROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtPROVEEDOR.Text = value.ToString()
        End Set
    End Property

    Public Property ROZA_ANTERIOR() As Decimal
        Get
            If Me.txtROZA_ANTERIOR.Value Is Nothing Then Return -1
            Return Me.txtROZA_ANTERIOR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtROZA_ANTERIOR.Value = value
        End Set
    End Property

    Public Property ROZA_DIA() As Decimal
        Get
            If Me.txtROZA_DIA.Value Is Nothing Then Return -1
            Return Me.txtROZA_DIA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtROZA_DIA.Value = value
        End Set
    End Property

    Public Property ROZA_PROYECTADA() As Decimal
        Get
            If Me.txtROZA_PROYECTADA.Value Is Nothing Then Return -1
            Return Me.txtROZA_PROYECTADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtROZA_PROYECTADA.Value = value
        End Set
    End Property

    Public Property AUTORIZADO() As Boolean
        Get
            Return Me.cbxAUTORIZADO.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxAUTORIZADO.Checked = value
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

    Public Property VerID_PLAN_COSECHA_DIARIO() As Boolean
        Get
            Return Me.trID_PLAN_COSECHA_DIARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PLAN_COSECHA_DIARIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.trFECHA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA.Visible = value
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

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.trACCESLOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACCESLOTE.Visible = value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.trZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZONA.Visible = value
        End Set
    End Property

    Public Property VerCODILOTE() As Boolean
        Get
            Return Me.trCODILOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODILOTE.Visible = value
        End Set
    End Property

    Public Property VerNOMBLOTE() As Boolean
        Get
            Return Me.trNOMBLOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBLOTE.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEE() As Boolean
        Get
            Return Me.trCODIPROVEE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEE.Visible = value
        End Set
    End Property

    Public Property VerCCODISOCIO() As Boolean
        Get
            Return Me.trCCODISOCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCCODISOCIO.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR() As Boolean
        Get
            Return Me.trPROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerROZA_ANTERIOR() As Boolean
        Get
            Return Me.trROZA_ANTERIOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trROZA_ANTERIOR.Visible = value
        End Set
    End Property

    Public Property VerROZA_DIA() As Boolean
        Get
            Return Me.trROZA_DIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trROZA_DIA.Visible = value
        End Set
    End Property

    Public Property VerROZA_PROYECTADA() As Boolean
        Get
            Return Me.trROZA_PROYECTADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trROZA_PROYECTADA.Visible = value
        End Set
    End Property

    Public Property VerAUTORIZADO() As Boolean
        Get
            Return Me.trAUTORIZADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAUTORIZADO.Visible = value
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
    Private mComponente As New cPLAN_COSECHA_DIARIO
    Private mEntidad As PLAN_COSECHA_DIARIO
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
        If Not Me.ViewState("ID_PLAN_COSECHA_DIARIO") Is Nothing Then Me._ID_PLAN_COSECHA_DIARIO = Me.ViewState("ID_PLAN_COSECHA_DIARIO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PLAN_COSECHA_DIARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PLAN_COSECHA_DIARIO
        mEntidad.ID_PLAN_COSECHA_DIARIO = ID_PLAN_COSECHA_DIARIO
 
        If mComponente.ObtenerPLAN_COSECHA_DIARIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PLAN_COSECHA_DIARIO.Text = mEntidad.ID_PLAN_COSECHA_DIARIO.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.ddlLOTESACCESLOTE.Recuperar()
        Me.ddlLOTESACCESLOTE.SelectedValue = mEntidad.ACCESLOTE
        Me.txtZONA.Text = mEntidad.ZONA
        Me.txtCODILOTE.Text = mEntidad.CODILOTE
        Me.txtNOMBLOTE.Text = mEntidad.NOMBLOTE
        Me.txtCODIPROVEE.Text = mEntidad.CODIPROVEE
        Me.txtCCODISOCIO.Text = mEntidad.CCODISOCIO
        Me.txtPROVEEDOR.Text = mEntidad.PROVEEDOR
        Me.txtROZA_PROYECTADA.Value = mEntidad.ROZA_PROYECTADA
        Me.cbxAUTORIZADO.Checked = mEntidad.AUTORIZADO
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
    ''' 	[GenApp]	16/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.ddlLOTESACCESLOTE.Enabled = edicion
        Me.deFECHA.Enabled = edicion
        Me.txtZONA.Enabled = edicion
        Me.txtCODILOTE.Enabled = edicion
        Me.txtNOMBLOTE.Enabled = edicion
        Me.txtCODIPROVEE.Enabled = edicion
        Me.txtCCODISOCIO.Enabled = edicion
        Me.txtPROVEEDOR.Enabled = edicion
        Me.txtROZA_ANTERIOR.Enabled = edicion
        Me.txtROZA_DIA.Enabled = edicion
        Me.txtROZA_PROYECTADA.Enabled = edicion
        Me.cbxAUTORIZADO.Enabled = edicion
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
    ''' 	[GenApp]	16/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlLOTESACCESLOTE.Recuperar()
        Me.deFECHA.Value = Nothing
        Me.txtZONA.Text = ""
        Me.txtCODILOTE.Text = ""
        Me.txtNOMBLOTE.Text = ""
        Me.txtCODIPROVEE.Text = ""
        Me.txtCCODISOCIO.Text = ""
        Me.txtPROVEEDOR.Text = ""
        Me.txtROZA_ANTERIOR.Value = Nothing
        Me.txtROZA_DIA.Value = Nothing
        Me.txtROZA_PROYECTADA.Value = Nothing
        Me.cbxAUTORIZADO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PLAN_COSECHA_DIARIO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PLAN_COSECHA_DIARIO
        If Me._nuevo Then
            mEntidad.ID_PLAN_COSECHA_DIARIO = 0
        Else
            mEntidad.ID_PLAN_COSECHA_DIARIO = CInt(Me.txtID_PLAN_COSECHA_DIARIO.Text)
        End If

        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.ACCESLOTE = Me.ddlLOTESACCESLOTE.SelectedValue
        mEntidad.ZONA = Me.txtZONA.Text
        mEntidad.CODILOTE = Me.txtCODILOTE.Text
        mEntidad.NOMBLOTE = Me.txtNOMBLOTE.Text
        mEntidad.CODIPROVEE = Me.txtCODIPROVEE.Text
        mEntidad.CCODISOCIO = Me.txtCCODISOCIO.Text
        mEntidad.PROVEEDOR = Me.txtPROVEEDOR.Text
        mEntidad.ROZA_PROYECTADA = Me.txtROZA_PROYECTADA.Value
        mEntidad.AUTORIZADO = Me.cbxAUTORIZADO.Checked
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarPLAN_COSECHA_DIARIO(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PLAN_COSECHA_DIARIO.Text = mEntidad.ID_PLAN_COSECHA_DIARIO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
