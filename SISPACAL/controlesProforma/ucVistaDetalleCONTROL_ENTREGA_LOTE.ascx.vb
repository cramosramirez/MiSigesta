Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTROL_ENTREGA_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTROL_ENTREGA_LOTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTROL_ENTREGA_LOTE
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CTRL_ENTREGA_LOTE As Int32
    Public Property ID_CTRL_ENTREGA_LOTE() As Int32
        Get
            Return Me.txtID_CTRL_ENTREGA_LOTE.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CTRL_ENTREGA_LOTE = Value
            Me.txtID_CTRL_ENTREGA_LOTE.Text = CStr(Value)
            If Me._ID_CTRL_ENTREGA_LOTE > 0 Then
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

    Public Property DIAZAFRA() As Int32
        Get
            If Me.txtDIAZAFRA.Value Is Nothing Then Return -1
            Return CInt(Me.txtDIAZAFRA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtDIAZAFRA.Value = value
        End Set
    End Property

    Public Property CONCEPTO() As String
        Get
            Return Me.txtCONCEPTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCONCEPTO.Text = value.ToString()
        End Set
    End Property

    Public Property CODIGO_REF() As String
        Get
            Return Me.txtCODIGO_REF.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIGO_REF.Text = value.ToString()
        End Set
    End Property

    Public Property ID_REF() As Int32
        Get
            If Me.txtID_REF.Value Is Nothing Then Return -1
            Return CInt(Me.txtID_REF.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtID_REF.Value = value
        End Set
    End Property

    Public Property INICIAL() As Decimal
        Get
            If Me.txtINICIAL.Value Is Nothing Then Return -1
            Return Me.txtINICIAL.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtINICIAL.Value = value
        End Set
    End Property

    Public Property SALIDAS() As Decimal
        Get
            If Me.txtSALIDAS.Value Is Nothing Then Return -1
            Return Me.txtSALIDAS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSALIDAS.Value = value
        End Set
    End Property

    Public Property SALDO() As Decimal
        Get
            If Me.txtSALDO.Value Is Nothing Then Return -1
            Return Me.txtSALDO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSALDO.Value = value
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

    Public Property VerID_CTRL_ENTREGA_LOTE() As Boolean
        Get
            Return Me.trID_CTRL_ENTREGA_LOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CTRL_ENTREGA_LOTE.Visible = value
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

    Public Property VerDIAZAFRA() As Boolean
        Get
            Return Me.trDIAZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIAZAFRA.Visible = value
        End Set
    End Property

    Public Property VerCONCEPTO() As Boolean
        Get
            Return Me.trCONCEPTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONCEPTO.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_REF() As Boolean
        Get
            Return Me.trCODIGO_REF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_REF.Visible = value
        End Set
    End Property

    Public Property VerID_REF() As Boolean
        Get
            Return Me.trID_REF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_REF.Visible = value
        End Set
    End Property

    Public Property VerINICIAL() As Boolean
        Get
            Return Me.trINICIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trINICIAL.Visible = value
        End Set
    End Property

    Public Property VerSALIDAS() As Boolean
        Get
            Return Me.trSALIDAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSALIDAS.Visible = value
        End Set
    End Property

    Public Property VerSALDO() As Boolean
        Get
            Return Me.trSALDO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSALDO.Visible = value
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
    Private mComponente As New cCONTROL_ENTREGA_LOTE
    Private mEntidad As CONTROL_ENTREGA_LOTE
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
        If Not Me.ViewState("ID_CTRL_ENTREGA_LOTE") Is Nothing Then Me._ID_CTRL_ENTREGA_LOTE = Me.ViewState("ID_CTRL_ENTREGA_LOTE")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTROL_ENTREGA_LOTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CONTROL_ENTREGA_LOTE
        mEntidad.ID_CTRL_ENTREGA_LOTE = ID_CTRL_ENTREGA_LOTE
 
        If mComponente.ObtenerCONTROL_ENTREGA_LOTE(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CTRL_ENTREGA_LOTE.Text = mEntidad.ID_CTRL_ENTREGA_LOTE.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.ddlLOTESACCESLOTE.Recuperar()
        Me.ddlLOTESACCESLOTE.SelectedValue = mEntidad.ACCESLOTE
        Me.txtDIAZAFRA.Value = mEntidad.DIAZAFRA
        Me.txtCONCEPTO.Text = mEntidad.CONCEPTO
        Me.txtCODIGO_REF.Text = mEntidad.CODIGO_REF
        Me.txtID_REF.Value = mEntidad.ID_REF
        Me.txtINICIAL.Value = mEntidad.INICIAL
        Me.txtSALIDAS.Value = mEntidad.SALIDAS
        Me.txtSALDO.Value = mEntidad.SALDO
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.ddlLOTESACCESLOTE.Enabled = edicion
        Me.txtDIAZAFRA.Enabled = edicion
        Me.txtCONCEPTO.Enabled = edicion
        Me.txtCODIGO_REF.Enabled = edicion
        Me.txtID_REF.Enabled = edicion
        Me.txtINICIAL.Enabled = edicion
        Me.txtSALIDAS.Enabled = edicion
        Me.txtSALDO.Enabled = edicion
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlLOTESACCESLOTE.Recuperar()
        Me.txtDIAZAFRA.Value = Nothing
        Me.txtCONCEPTO.Text = ""
        Me.txtCODIGO_REF.Text = ""
        Me.txtID_REF.Value = Nothing
        Me.txtINICIAL.Value = Nothing
        Me.txtSALIDAS.Value = Nothing
        Me.txtSALDO.Value = Nothing
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTROL_ENTREGA_LOTE
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CONTROL_ENTREGA_LOTE
        If Me._nuevo Then
            mEntidad.ID_CTRL_ENTREGA_LOTE = 0
        Else
            mEntidad.ID_CTRL_ENTREGA_LOTE = CInt(Me.txtID_CTRL_ENTREGA_LOTE.Text)
        End If
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.ACCESLOTE = Me.ddlLOTESACCESLOTE.SelectedValue
        mEntidad.DIAZAFRA = Me.txtDIAZAFRA.Value
        mEntidad.CONCEPTO = Me.txtCONCEPTO.Text
        mEntidad.CODIGO_REF = Me.txtCODIGO_REF.Text
        mEntidad.ID_REF = Me.txtID_REF.Value
        mEntidad.INICIAL = Me.txtINICIAL.Value
        mEntidad.SALIDAS = Me.txtSALIDAS.Value
        mEntidad.SALDO = Me.txtSALDO.Value
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarCONTROL_ENTREGA_LOTE(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CTRL_ENTREGA_LOTE.Text = mEntidad.ID_CTRL_ENTREGA_LOTE.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
