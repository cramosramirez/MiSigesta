Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCENSO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CENSO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCENSO_LOTES
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CENSO_LOTES As Int32
    Public Property ID_CENSO_LOTES() As Int32
        Get
            Return Me.txtID_CENSO_LOTES.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CENSO_LOTES = Value
            Me.txtID_CENSO_LOTES.Text = CStr(Value)
            If Me._ID_CENSO_LOTES > 0 Then
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

    Public Property FECHA_VERIFICACION() As DateTime
        Get
            Return Me.deFECHA_VERIFICACION.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_VERIFICACION.Value = value
        End Set
    End Property

    Public Property MZ_ENTREGAR() As Decimal
        Get
            If Me.txtMZ_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtMZ_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMZ_ENTREGAR.Value = value
        End Set
    End Property

    Public Property TONEL_MZ_ENTREGAR() As Decimal
        Get
            If Me.txtTONEL_MZ_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtTONEL_MZ_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_MZ_ENTREGAR.Value = value
        End Set
    End Property

    Public Property TONEL_ENTREGAR() As Decimal
        Get
            If Me.txtTONEL_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtTONEL_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_ENTREGAR.Value = value
        End Set
    End Property

    Public Property LBS_ENTREGAR() As Decimal
        Get
            If Me.txtLBS_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtLBS_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_ENTREGAR.Value = value
        End Set
    End Property

    Public Property VALOR_ENTREGAR() As Decimal
        Get
            If Me.txtVALOR_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtVALOR_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_ENTREGAR.Value = value
        End Set
    End Property

    Public Property MZ_ENTREGADA() As Decimal
        Get
            If Me.txtMZ_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtMZ_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMZ_ENTREGADA.Value = value
        End Set
    End Property

    Public Property TONEL_MZ_ENTREGADA() As Decimal
        Get
            If Me.txtTONEL_MZ_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtTONEL_MZ_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_MZ_ENTREGADA.Value = value
        End Set
    End Property

    Public Property TONEL_ENTREGADA() As Decimal
        Get
            If Me.txtTONEL_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtTONEL_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_ENTREGADA.Value = value
        End Set
    End Property

    Public Property LBS_ENTREGADA() As Decimal
        Get
            If Me.txtLBS_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtLBS_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_ENTREGADA.Value = value
        End Set
    End Property

    Public Property VALOR_ENTREGADA() As Decimal
        Get
            If Me.txtVALOR_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtVALOR_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_ENTREGADA.Value = value
        End Set
    End Property

    Public Property MZ_CENSO() As Decimal
        Get
            If Me.txtMZ_CENSO.Value Is Nothing Then Return -1
            Return Me.txtMZ_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMZ_CENSO.Value = value
        End Set
    End Property

    Public Property TONEL_MZ_CENSO() As Decimal
        Get
            If Me.txtTONEL_MZ_CENSO.Value Is Nothing Then Return -1
            Return Me.txtTONEL_MZ_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_MZ_CENSO.Value = value
        End Set
    End Property

    Public Property TONEL_CENSO() As Decimal
        Get
            If Me.txtTONEL_CENSO.Value Is Nothing Then Return -1
            Return Me.txtTONEL_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_CENSO.Value = value
        End Set
    End Property

    Public Property LBS_CENSO() As Decimal
        Get
            If Me.txtLBS_CENSO.Value Is Nothing Then Return -1
            Return Me.txtLBS_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_CENSO.Value = value
        End Set
    End Property

    Public Property VALOR_CENSO() As Decimal
        Get
            If Me.txtVALOR_CENSO.Value Is Nothing Then Return -1
            Return Me.txtVALOR_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_CENSO.Value = value
        End Set
    End Property

    Public Property ID_CENSO() As Int32
        Get
            Return Me.ddlCENSOID_CENSO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCENSOID_CENSO.Items.FindByValue(value) Is Nothing Then
                Me.ddlCENSOID_CENSO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_MOTIVO_VARIACION() As Int32
        Get
            Return Me.ddlMOTIVO_VARIACIONID_MOTIVO_VARIACION.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlMOTIVO_VARIACIONID_MOTIVO_VARIACION.Items.FindByValue(value) Is Nothing Then
                Me.ddlMOTIVO_VARIACIONID_MOTIVO_VARIACION.SelectedValue = value
            End If
        End Set
    End Property

    Public Property OBSERVACION() As String
        Get
            Return Me.txtOBSERVACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtOBSERVACION.Text = value.ToString()
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

    Public Property VerID_CENSO_LOTES() As Boolean
        Get
            Return Me.trID_CENSO_LOTES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CENSO_LOTES.Visible = value
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

    Public Property VerFECHA_VERIFICACION() As Boolean
        Get
            Return Me.trFECHA_VERIFICACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_VERIFICACION.Visible = value
        End Set
    End Property

    Public Property VerMZ_ENTREGAR() As Boolean
        Get
            Return Me.trMZ_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMZ_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerTONEL_MZ_ENTREGAR() As Boolean
        Get
            Return Me.trTONEL_MZ_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_MZ_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerTONEL_ENTREGAR() As Boolean
        Get
            Return Me.trTONEL_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerLBS_ENTREGAR() As Boolean
        Get
            Return Me.trLBS_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerVALOR_ENTREGAR() As Boolean
        Get
            Return Me.trVALOR_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerMZ_ENTREGADA() As Boolean
        Get
            Return Me.trMZ_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMZ_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerTONEL_MZ_ENTREGADA() As Boolean
        Get
            Return Me.trTONEL_MZ_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_MZ_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerTONEL_ENTREGADA() As Boolean
        Get
            Return Me.trTONEL_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerLBS_ENTREGADA() As Boolean
        Get
            Return Me.trLBS_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerVALOR_ENTREGADA() As Boolean
        Get
            Return Me.trVALOR_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerMZ_CENSO() As Boolean
        Get
            Return Me.trMZ_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMZ_CENSO.Visible = value
        End Set
    End Property

    Public Property VerTONEL_MZ_CENSO() As Boolean
        Get
            Return Me.trTONEL_MZ_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_MZ_CENSO.Visible = value
        End Set
    End Property

    Public Property VerTONEL_CENSO() As Boolean
        Get
            Return Me.trTONEL_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_CENSO.Visible = value
        End Set
    End Property

    Public Property VerLBS_CENSO() As Boolean
        Get
            Return Me.trLBS_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_CENSO.Visible = value
        End Set
    End Property

    Public Property VerVALOR_CENSO() As Boolean
        Get
            Return Me.trVALOR_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_CENSO.Visible = value
        End Set
    End Property

    Public Property VerID_CENSO() As Boolean
        Get
            Return Me.trID_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CENSO.Visible = value
        End Set
    End Property

    Public Property VerID_MOTIVO_VARIACION() As Boolean
        Get
            Return Me.trID_MOTIVO_VARIACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_MOTIVO_VARIACION.Visible = value
        End Set
    End Property

    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me.trOBSERVACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOBSERVACION.Visible = value
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
    Private mComponente As New cCENSO_LOTES
    Private mEntidad As CENSO_LOTES
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
        If Not Me.ViewState("ID_CENSO_LOTES") Is Nothing Then Me._ID_CENSO_LOTES = Me.ViewState("ID_CENSO_LOTES")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CENSO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CENSO_LOTES
        mEntidad.ID_CENSO_LOTES = ID_CENSO_LOTES
 
        If mComponente.ObtenerCENSO_LOTES(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CENSO_LOTES.Text = mEntidad.ID_CENSO_LOTES.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.ddlLOTESACCESLOTE.Recuperar()
        Me.ddlLOTESACCESLOTE.SelectedValue = mEntidad.ACCESLOTE
        Me.deFECHA_VERIFICACION.Value = mEntidad.FECHA_VERIFICACION
        Me.txtMZ_ENTREGAR.Value = mEntidad.MZ_ENTREGAR
        Me.txtTONEL_MZ_ENTREGAR.Value = mEntidad.TONEL_MZ_ENTREGAR
        Me.txtTONEL_ENTREGAR.Value = mEntidad.TONEL_ENTREGAR
        Me.txtLBS_ENTREGAR.Value = mEntidad.LBS_ENTREGAR
        Me.txtVALOR_ENTREGAR.Value = mEntidad.VALOR_ENTREGAR
        Me.txtMZ_ENTREGADA.Value = mEntidad.MZ_ENTREGADA
        Me.txtTONEL_MZ_ENTREGADA.Value = mEntidad.TONEL_MZ_ENTREGADA
        Me.txtTONEL_ENTREGADA.Value = mEntidad.TONEL_ENTREGADA
        Me.txtLBS_ENTREGADA.Value = mEntidad.LBS_ENTREGADA
        Me.txtVALOR_ENTREGADA.Value = mEntidad.VALOR_ENTREGADA
        Me.txtMZ_CENSO.Value = mEntidad.MZ_CENSO
        Me.txtTONEL_MZ_CENSO.Value = mEntidad.TONEL_MZ_CENSO
        Me.txtTONEL_CENSO.Value = mEntidad.TONEL_CENSO
        Me.txtLBS_CENSO.Value = mEntidad.LBS_CENSO
        Me.txtVALOR_CENSO.Value = mEntidad.VALOR_CENSO
        Me.ddlCENSOID_CENSO.Recuperar()
        Me.ddlCENSOID_CENSO.SelectedValue = mEntidad.ID_CENSO
        Me.ddlMOTIVO_VARIACIONID_MOTIVO_VARIACION.Recuperar()
        Me.ddlMOTIVO_VARIACIONID_MOTIVO_VARIACION.SelectedValue = mEntidad.ID_MOTIVO_VARIACION
        Me.txtOBSERVACION.Text = mEntidad.OBSERVACION
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.ddlLOTESACCESLOTE.Enabled = edicion
        Me.ddlCENSOID_CENSO.Enabled = edicion
        Me.ddlMOTIVO_VARIACIONID_MOTIVO_VARIACION.Enabled = edicion
        Me.deFECHA_VERIFICACION.Enabled = edicion
        Me.txtMZ_ENTREGAR.Enabled = edicion
        Me.txtTONEL_MZ_ENTREGAR.Enabled = edicion
        Me.txtTONEL_ENTREGAR.Enabled = edicion
        Me.txtLBS_ENTREGAR.Enabled = edicion
        Me.txtVALOR_ENTREGAR.Enabled = edicion
        Me.txtMZ_ENTREGADA.Enabled = edicion
        Me.txtTONEL_MZ_ENTREGADA.Enabled = edicion
        Me.txtTONEL_ENTREGADA.Enabled = edicion
        Me.txtLBS_ENTREGADA.Enabled = edicion
        Me.txtVALOR_ENTREGADA.Enabled = edicion
        Me.txtMZ_CENSO.Enabled = edicion
        Me.txtTONEL_MZ_CENSO.Enabled = edicion
        Me.txtTONEL_CENSO.Enabled = edicion
        Me.txtLBS_CENSO.Enabled = edicion
        Me.txtVALOR_CENSO.Enabled = edicion
        Me.txtOBSERVACION.Enabled = edicion
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlLOTESACCESLOTE.Recuperar()
        Me.ddlCENSOID_CENSO.Recuperar()
        Me.ddlMOTIVO_VARIACIONID_MOTIVO_VARIACION.Recuperar()
        Me.deFECHA_VERIFICACION.Value = Nothing
        Me.txtMZ_ENTREGAR.Value = Nothing
        Me.txtTONEL_MZ_ENTREGAR.Value = Nothing
        Me.txtTONEL_ENTREGAR.Value = Nothing
        Me.txtLBS_ENTREGAR.Value = Nothing
        Me.txtVALOR_ENTREGAR.Value = Nothing
        Me.txtMZ_ENTREGADA.Value = Nothing
        Me.txtTONEL_MZ_ENTREGADA.Value = Nothing
        Me.txtTONEL_ENTREGADA.Value = Nothing
        Me.txtLBS_ENTREGADA.Value = Nothing
        Me.txtVALOR_ENTREGADA.Value = Nothing
        Me.txtMZ_CENSO.Value = Nothing
        Me.txtTONEL_MZ_CENSO.Value = Nothing
        Me.txtTONEL_CENSO.Value = Nothing
        Me.txtLBS_CENSO.Value = Nothing
        Me.txtVALOR_CENSO.Value = Nothing
        Me.txtOBSERVACION.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CENSO_LOTES
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CENSO_LOTES
        If Me._nuevo Then
            mEntidad.ID_CENSO_LOTES = 0
        Else
            mEntidad.ID_CENSO_LOTES = CInt(Me.txtID_CENSO_LOTES.Text)
        End If
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.ACCESLOTE = Me.ddlLOTESACCESLOTE.SelectedValue
        mEntidad.FECHA_VERIFICACION = Me.deFECHA_VERIFICACION.Value
        mEntidad.MZ_ENTREGAR = Me.txtMZ_ENTREGAR.Value
        mEntidad.TONEL_MZ_ENTREGAR = Me.txtTONEL_MZ_ENTREGAR.Value
        mEntidad.TONEL_ENTREGAR = Me.txtTONEL_ENTREGAR.Value
        mEntidad.LBS_ENTREGAR = Me.txtLBS_ENTREGAR.Value
        mEntidad.VALOR_ENTREGAR = Me.txtVALOR_ENTREGAR.Value
        mEntidad.MZ_ENTREGADA = Me.txtMZ_ENTREGADA.Value
        mEntidad.TONEL_MZ_ENTREGADA = Me.txtTONEL_MZ_ENTREGADA.Value
        mEntidad.TONEL_ENTREGADA = Me.txtTONEL_ENTREGADA.Value
        mEntidad.LBS_ENTREGADA = Me.txtLBS_ENTREGADA.Value
        mEntidad.VALOR_ENTREGADA = Me.txtVALOR_ENTREGADA.Value
        mEntidad.MZ_CENSO = Me.txtMZ_CENSO.Value
        mEntidad.TONEL_MZ_CENSO = Me.txtTONEL_MZ_CENSO.Value
        mEntidad.TONEL_CENSO = Me.txtTONEL_CENSO.Value
        mEntidad.LBS_CENSO = Me.txtLBS_CENSO.Value
        mEntidad.VALOR_CENSO = Me.txtVALOR_CENSO.Value
        mEntidad.ID_CENSO = Me.ddlCENSOID_CENSO.SelectedValue
        mEntidad.ID_MOTIVO_VARIACION = Me.ddlMOTIVO_VARIACIONID_MOTIVO_VARIACION.SelectedValue
        mEntidad.OBSERVACION = Me.txtOBSERVACION.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarCENSO_LOTES(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CENSO_LOTES.Text = mEntidad.ID_CENSO_LOTES.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
