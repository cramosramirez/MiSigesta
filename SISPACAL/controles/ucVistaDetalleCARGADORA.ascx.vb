Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCARGADORA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CARGADORA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCARGADORA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CARGADORA As Int32
    Public Property ID_CARGADORA() As Int32
        Get
            Return Me.txtID_CARGADORA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CARGADORA = Value
            Me.txtID_CARGADORA.Text = CStr(Value)
            If Me._ID_CARGADORA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE() As String
        Get
            Return Me.txtNOMBRE.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE.Text = value.ToString()
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

    Public Property ES_PROPIA() As Boolean
        Get
            Return Me.cbxES_PROPIA.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxES_PROPIA.Checked = value
        End Set
    End Property

    Public Property ID_PROVEEDOR_CARGA() As Int32
        Get
            Return Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.Items.FindByValue(value) Is Nothing Then
                Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_TIPO_CARGADORA() As Int32
        Get
            Return Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property TARIFA_SIN_TRIPULACION() As Decimal
        Get
            If Me.txtTARIFA_SIN_TRIPULACION.Text ="" Then Return -1
            Return Me.txtTARIFA_SIN_TRIPULACION.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_SIN_TRIPULACION.Text = value.ToString()
        End Set
    End Property

    Public Property TARIFA_CON_TRIPULACION() As Decimal
        Get
            If Me.txtTARIFA_CON_TRIPULACION.Text ="" Then Return -1
            Return Me.txtTARIFA_CON_TRIPULACION.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_CON_TRIPULACION.Text = value.ToString()
        End Set
    End Property

    Public Property TARIFA_NORMAL() As Decimal
        Get
            If Me.txtTARIFA_NORMAL.Text ="" Then Return -1
            Return Me.txtTARIFA_NORMAL.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_NORMAL.Text = value.ToString()
        End Set
    End Property

    Public Property VerID_CARGADORA() As Boolean
        Get
            Return Me.trID_CARGADORA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CARGADORA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE() As Boolean
        Get
            Return Me.trNOMBRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE.Visible = value
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

    Public Property VerES_PROPIA() As Boolean
        Get
            Return Me.trES_PROPIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trES_PROPIA.Visible = value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_CARGA() As Boolean
        Get
            Return Me.trID_PROVEEDOR_CARGA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEEDOR_CARGA.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_CARGADORA() As Boolean
        Get
            Return Me.trID_TIPO_CARGADORA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_CARGADORA.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_SIN_TRIPULACION() As Boolean
        Get
            Return Me.trTARIFA_SIN_TRIPULACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_SIN_TRIPULACION.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_CON_TRIPULACION() As Boolean
        Get
            Return Me.trTARIFA_CON_TRIPULACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_CON_TRIPULACION.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_NORMAL() As Boolean
        Get
            Return Me.trTARIFA_NORMAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_NORMAL.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCARGADORA
    Private mEntidad As CARGADORA
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
        If Not Me.ViewState("ID_CARGADORA") Is Nothing Then Me._ID_CARGADORA = Me.ViewState("ID_CARGADORA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CARGADORA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CARGADORA
        mEntidad.ID_CARGADORA = ID_CARGADORA
 
        If mComponente.ObtenerCARGADORA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CARGADORA.Text = mEntidad.ID_CARGADORA.ToString()
        Me.txtNOMBRE.Text = mEntidad.NOMBRE
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
        Me.cbxES_PROPIA.Checked = mEntidad.ES_PROPIA
        Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.Recuperar()
        Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedValue = mEntidad.ID_PROVEEDOR_CARGA
        Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.Recuperar()
        Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.SelectedValue = mEntidad.ID_TIPO_CARGADORA
        Me.ddlTIPOS_GENERALES1.RecuperarPorTipoCAT(Enumeradores.CAT.TipoCAT.Alza)
        Me.ddlTIPOS_GENERALES1.SelectedValue = mEntidad.ID_TIPO_ALZA
        ConfigurarCamposTarifa(mEntidad.ID_TIPO_CARGADORA, cPROVEEDOR_CARGA.EsIngenio(mEntidad.ID_PROVEEDOR_CARGA))
        If mEntidad.TARIFA_SIN_TRIPULACION <> -1 Then
            Me.txtTARIFA_SIN_TRIPULACION.Text = mEntidad.TARIFA_SIN_TRIPULACION
        Else
            Me.txtTARIFA_SIN_TRIPULACION.Text = ""
        End If
        If mEntidad.TARIFA_CON_TRIPULACION <> -1 Then
            Me.txtTARIFA_CON_TRIPULACION.Text = mEntidad.TARIFA_CON_TRIPULACION
        Else
            Me.txtTARIFA_CON_TRIPULACION.Text = ""
        End If
        If mEntidad.TARIFA_NORMAL <> -1 Then
            Me.txtTARIFA_NORMAL.Text = mEntidad.TARIFA_NORMAL
        Else
            Me.txtTARIFA_NORMAL.Text = ""
        End If
        Me.txtTARIFA_PAGAR_CARGADORA.Text = mEntidad.TARIFA_PAGAR_CARGADORA
        Me.chkPRECALIFI_AUTO.Checked = mEntidad.PRECALIFI_AUTO
        Me.chkACTIVO.Checked = mEntidad.ACTIVO
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_CARGADORA.Enabled = Me._nuevo
        Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.Enabled = edicion
        Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.Enabled = edicion
        Me.ddlTIPOS_GENERALES1.Enabled = edicion
        Me.txtNOMBRE.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
        Me.cbxES_PROPIA.Enabled = edicion
        Me.chkPRECALIFI_AUTO.Enabled = edicion
        Me.chkACTIVO.Enabled = edicion
        Me.ConfigurarCamposTarifa(Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.SelectedValue, cPROVEEDOR_CARGA.EsIngenio(Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedValue))
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.Recuperar()
        Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.Recuperar()
        Me.ddlTIPOS_GENERALES1.RecuperarPorTipoCAT(Enumeradores.CAT.TipoCAT.Alza)
        Me.txtID_CARGADORA.Text = ""
        Me.txtNOMBRE.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
        Me.cbxES_PROPIA.Checked = False
        Me.txtTARIFA_SIN_TRIPULACION.Text = ""
        Me.txtTARIFA_CON_TRIPULACION.Text = ""
        Me.txtTARIFA_NORMAL.Text = ""
        Me.txtTARIFA_PAGAR_CARGADORA.Text = ""
        Me.chkPRECALIFI_AUTO.Checked = False
        Me.chkACTIVO.Checked = False
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CARGADORA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        If Me.txtID_CARGADORA.Text.Trim = "" Then
            AsignarMensaje("Ingrese el Codigo de la Cargadora", True)
            Return "Error"
        End If
        If Not Utilerias.EsNumeroEntero(Me.txtID_CARGADORA.Text.Trim) Then
            AsignarMensaje("Codigo de la Cargadora debe ser un numero entero", True)
            Return "Error"
        End If

        mEntidad = New CARGADORA
        If Me._nuevo Then
            'Verificar si el cÃ³digo ya estÃ¡ asignado
            Dim lEntidad As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(CInt(Me.txtID_CARGADORA.Text.Trim))
            If lEntidad IsNot Nothing Then
                AsignarMensaje("El Codigo asignado ya esta siendo utilizado por otra Cargadora", True)
                Return "Error"
            End If

            mEntidad.ID_CARGADORA = CInt(Me.txtID_CARGADORA.Text.Trim)
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cCARGADORA).ObtenerCARGADORA(CInt(Me.txtID_CARGADORA.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.NOMBRE = Me.txtNOMBRE.Text.Trim.ToUpper
        mEntidad.ID_PROVEEDOR_CARGA = Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedValue
        If cPROVEEDOR_CARGA.EsIngenio(Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedValue) Then
            mEntidad.ES_PROPIA = True
        Else
            mEntidad.ES_PROPIA = False
        End If
        mEntidad.ID_TIPO_CARGADORA = Me.ddlTIPO_CARGADORAID_TIPO_CARGADORA.SelectedValue
        If Me.txtTARIFA_SIN_TRIPULACION.Text = "" Then
            mEntidad.TARIFA_SIN_TRIPULACION = -1
        Else
            mEntidad.TARIFA_SIN_TRIPULACION = Val(Me.txtTARIFA_SIN_TRIPULACION.Text)
        End If
        If Me.txtTARIFA_SIN_TRIPULACION.Text = "" Then
            mEntidad.TARIFA_SIN_TRIPULACION = -1
        Else
            mEntidad.TARIFA_SIN_TRIPULACION = Val(Me.txtTARIFA_SIN_TRIPULACION.Text)
        End If
        If Me.txtTARIFA_CON_TRIPULACION.Text = "" Then
            mEntidad.TARIFA_CON_TRIPULACION = -1
        Else
            mEntidad.TARIFA_CON_TRIPULACION = Val(Me.txtTARIFA_CON_TRIPULACION.Text)
        End If
        If Me.txtTARIFA_NORMAL.Text = "" Then
            mEntidad.TARIFA_NORMAL = -1
        Else
            mEntidad.TARIFA_NORMAL = Val(Me.txtTARIFA_NORMAL.Text)
        End If
        If Me.txtTARIFA_PAGAR_CARGADORA.Text.Trim = "" Then
            mEntidad.TARIFA_PAGAR_CARGADORA = 0
        Else
            mEntidad.TARIFA_PAGAR_CARGADORA = Val(Me.txtTARIFA_PAGAR_CARGADORA.Text)
        End If
        mEntidad.ID_TIPO_ALZA = ddlTIPOS_GENERALES1.SelectedValue
        mEntidad.PRECALIFI_AUTO = chkPRECALIFI_AUTO.Checked
        mEntidad.ACTIVO = chkACTIVO.Checked
        If mComponente.ActualizarCARGADORA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CARGADORA.Text = mEntidad.ID_CARGADORA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub ddlTIPO_CARGADORAID_TIPO_CARGADORA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlTIPO_CARGADORAID_TIPO_CARGADORA.SelectedIndexChanged
        ConfigurarCamposTarifa(ddlTIPO_CARGADORAID_TIPO_CARGADORA.SelectedValue, cPROVEEDOR_CARGA.EsIngenio(Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedValue))
    End Sub

    Private Sub ConfigurarCamposTarifa(ByVal ID_TIPO_CARGA As Integer, ByVal ES_INGENIO As Boolean)
        If ID_TIPO_CARGA = Enumeradores.TipoCargadora.Cargadora Then
            If ES_INGENIO Then
                Me.txtTARIFA_CON_TRIPULACION.Enabled = True
                Me.txtTARIFA_SIN_TRIPULACION.Enabled = True
                If Me.txtTARIFA_CON_TRIPULACION.Text = "" Then Me.txtTARIFA_CON_TRIPULACION.Text = "0.00"
                If Me.txtTARIFA_SIN_TRIPULACION.Text = "" Then Me.txtTARIFA_SIN_TRIPULACION.Text = "0.00"
                Me.txtTARIFA_NORMAL.Text = ""
                Me.txtTARIFA_NORMAL.Enabled = False
                Me.txtTARIFA_PAGAR_CARGADORA.Text = ""
                Me.txtTARIFA_PAGAR_CARGADORA.Enabled = False
            Else
                Me.txtTARIFA_CON_TRIPULACION.Enabled = False
                Me.txtTARIFA_SIN_TRIPULACION.Enabled = False
                Me.txtTARIFA_CON_TRIPULACION.Text = ""
                Me.txtTARIFA_SIN_TRIPULACION.Text = ""
                Me.txtTARIFA_NORMAL.Enabled = True
                Me.txtTARIFA_PAGAR_CARGADORA.Enabled = True
                If Me.txtTARIFA_NORMAL.Text = "" Then Me.txtTARIFA_NORMAL.Text = "0.00"
                If Me.txtTARIFA_PAGAR_CARGADORA.Text = "" Then Me.txtTARIFA_PAGAR_CARGADORA.Text = "0.00"
            End If
        Else
            Me.txtTARIFA_CON_TRIPULACION.Enabled = False
            Me.txtTARIFA_SIN_TRIPULACION.Enabled = False
            Me.txtTARIFA_CON_TRIPULACION.Text = ""
            Me.txtTARIFA_SIN_TRIPULACION.Text = ""
            Me.txtTARIFA_NORMAL.Enabled = True
            Me.txtTARIFA_PAGAR_CARGADORA.Enabled = True
            If Me.txtTARIFA_NORMAL.Text = "" Then Me.txtTARIFA_NORMAL.Text = "0.00"
            If Me.txtTARIFA_PAGAR_CARGADORA.Text = "" Then Me.txtTARIFA_PAGAR_CARGADORA.Text = "0.00"
        End If
    End Sub

    Protected Sub ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedIndexChanged
        ConfigurarCamposTarifa(ddlTIPO_CARGADORAID_TIPO_CARGADORA.SelectedValue, cPROVEEDOR_CARGA.EsIngenio(Me.ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA.SelectedValue))
    End Sub
End Class
