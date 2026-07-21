Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.Data
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleDESCUENTOS_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla DESCUENTOS_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleDESCUENTOS_PLANILLA
    Inherits ucBase

    Private ds As New DataSet
 
#Region "Propiedades"

    Public Property ID_CATORCENA As Integer
        Get
            If Me.ViewState("ID_CATORCENA") Is Nothing Then
                Return Nothing
            Else
                Return Me.ViewState("ID_CATORCENA")
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("ID_CATORCENA") = value
        End Set
    End Property
    Public Property CODIPROVEEDOR_TRANSPORTISTA As String
        Get
            If Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA") Is Nothing Then
                Return Nothing
            Else
                Return Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA")
            End If
        End Get
        Set(value As String)
            Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA") = value
        End Set
    End Property
    Public Property ID_TIPO_PLANILLA As Integer
        Get
            If Me.ViewState("ID_TIPO_PLANILLA") Is Nothing Then
                Return Nothing
            Else
                Return Me.ViewState("ID_TIPO_PLANILLA")
            End If
        End Get
        Set(value As Integer)
            Me.ViewState("ID_TIPO_PLANILLA") = value
        End Set
    End Property


    Private _ID_DESCUENTO_PLANILLA As Int32
    Public Property ID_DESCUENTO_PLANILLA() As Int32
        Get
            Return Me.txtID_DESCUENTO_PLANILLA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_DESCUENTO_PLANILLA = Value
            Me.txtID_DESCUENTO_PLANILLA.Text = CStr(Value)
            If Me._ID_DESCUENTO_PLANILLA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_TIPO_DESCTO() As Int32
        Get
            Return Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_APLICACION_DESCTO() As Int32
        Get
            Return Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.Items.FindByValue(value) Is Nothing Then
                Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property MONTO_DESCUENTO() As Decimal
        Get
            If Me.txtMONTO_DESCUENTO.Text = "" Then Return -1
            Return Me.txtMONTO_DESCUENTO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtMONTO_DESCUENTO.Text = value.ToString()
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cDESCUENTOS_PLANILLA
    Private mEntidad As DESCUENTOS_PLANILLA
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
        If Not Me.ViewState("ID_DESCUENTO_PLANILLA") Is Nothing Then Me._ID_DESCUENTO_PLANILLA = Me.ViewState("ID_DESCUENTO_PLANILLA")

    End Sub

    Private Function EsNumero(ByVal mensaje As String, ByVal valor As String) As Boolean
        If Not IsNumeric(valor) Then
            AsignarMensaje(mensaje, True)
            Return False
        End If
        Return True
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla DESCUENTOS_PLANILLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New DESCUENTOS_PLANILLA
        mEntidad.ID_DESCUENTO_PLANILLA = ID_DESCUENTO_PLANILLA
 
        If mComponente.ObtenerDESCUENTOS_PLANILLA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_DESCUENTO_PLANILLA.Text = mEntidad.ID_DESCUENTO_PLANILLA.ToString()
        Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.Recuperar()
        Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.SelectedValue = mEntidad.ID_TIPO_DESCTO
        Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.Recuperar()
        Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.SelectedValue = mEntidad.ID_APLICACION_DESCTO
        Me.txtMONTO_DESCUENTO.Text = mEntidad.MONTO_DESCUENTO
    End Sub

    Public Sub IniciarDescuentos(ByVal ID_CATORCENA As Integer, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Integer)
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)

        Me.ID_CATORCENA = ID_CATORCENA
        Me.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
        Me.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA

        If lCatorcena IsNot Nothing Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(lCatorcena.ID_ZAFRA)
            Me.lblNO_CATORCENA.Text = lCatorcena.CATORCENA.ToString
            If lZafra IsNot Nothing Then
                Me.lblZAFRA.Text = lZafra.NOMBRE_ZAFRA
            End If

            Dim lPlanilla As PLANILLA = (New cPLANILLA).ObtenerPLANILLA(ID_CATORCENA, CODIPROVEEDOR_TRANSPORTISTA, ID_TIPO_PLANILLA)
            If lPlanilla IsNot Nothing Then
                lblCODIPROVEEDOR_TRANSPORTISTA.Text = lPlanilla.CODIPROVEEDOR_TRANSPORTISTA
                lblNOMBRE.Text = lPlanilla.NOMBRE_PROVEE_TRANS
            End If
        End If

        Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.Recuperar()
        Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.Recuperar()
        Me.txtMONTO_DESCUENTO.Text = ""
        Me.ucListaDESCUENTOS_PLANILLA1.CargarDatosPorPLANILLA(ID_CATORCENA, CODIPROVEEDOR_TRANSPORTISTA, ID_TIPO_PLANILLA)
        HabilitarEdicion(True)
    End Sub

 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_DESCUENTO_PLANILLA.Enabled = False
        Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.Enabled = edicion
        Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.Enabled = edicion
        Me.txtMONTO_DESCUENTO.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.AsignarMensaje("", False, False)
        Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.Recuperar(True, False)
        Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.Recuperar(True, False)
        Me.txtMONTO_DESCUENTO.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla DESCUENTOS_PLANILLA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim alDatos As New ArrayList
        mEntidad = New DESCUENTOS_PLANILLA
        If Me._nuevo Then
            mEntidad.ID_DESCUENTO_PLANILLA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad.ID_DESCUENTO_PLANILLA = CInt(Me.txtID_DESCUENTO_PLANILLA.Text)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If ddlTIPO_DESCUENTOID_TIPO_DESCTO.SelectedValue Is Nothing OrElse ddlTIPO_DESCUENTOID_TIPO_DESCTO.SelectedValue = 0 Then
            sError.AppendLine(" * Seleccione el tipo de descuento.<br>")
        End If
        If Not IsNumeric(Me.txtMONTO_DESCUENTO.Text) Then
            sError.AppendLine(" * Monto de descuento no valido.<br>")
        End If
        'If ddlAPLICACION_DESCTOID_APLICACION_DESCTO.SelectedValue Is Nothing OrElse ddlTIPO_DESCUENTOID_TIPO_DESCTO.SelectedValue = 0 Then
        '    sError.AppendLine(" * Seleccione en que se aplicara el descuento.<br>")
        'End If
        If sError.ToString.Length > 0 Then
            AsignarMensaje(sError.ToString, True)
            Return sError.ToString
        End If
        mEntidad.ID_CATORCENA = Me.ID_CATORCENA
        mEntidad.CODIPROVEEDOR_TRANSPORTISTA = Me.CODIPROVEEDOR_TRANSPORTISTA
        mEntidad.ID_TIPO_PLANILLA = Me.ID_TIPO_PLANILLA
        mEntidad.ID_TIPO_DESCTO = Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.SelectedValue
        mEntidad.ID_APLICACION_DESCTO = 1
        mEntidad.CODIBANCO = -1
        If mEntidad.ID_TIPO_DESCTO = 3 Then
            mEntidad.IVA = Math.Round(Math.Round(Convert.ToDecimal(Me.txtMONTO_DESCUENTO.Text) / 1.13, 2) * 0.13, 2)
            mEntidad.MONTO_DESCUENTO = Convert.ToDecimal(Me.txtMONTO_DESCUENTO.Text) - mEntidad.IVA
        Else
            mEntidad.MONTO_DESCUENTO = Math.Round(Convert.ToDecimal(Me.txtMONTO_DESCUENTO.Text), 2)
            mEntidad.IVA = 0
        End If

        If mComponente.ActualizarDESCUENTOS_PLANILLA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_DESCUENTO_PLANILLA.Text = 0
        Me.ddlTIPO_DESCUENTOID_TIPO_DESCTO.Recuperar()
        Me.ddlAPLICACION_DESCTOID_APLICACION_DESCTO.Recuperar()
        Me.txtMONTO_DESCUENTO.Text = ""
        Me.ucListaDESCUENTOS_PLANILLA1.CargarDatosPorPLANILLA(ID_CATORCENA, CODIPROVEEDOR_TRANSPORTISTA, ID_TIPO_PLANILLA)
        Return ""
        'Me.txtID_DESCUENTO_PLANILLA.Text = mEntidad.ID_DESCUENTO_PLANILLA.ToString()
        'Me._nuevo = False
        'If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        'Me.ViewState.Add("nuevo", Me._nuevo)
    End Function
End Class
