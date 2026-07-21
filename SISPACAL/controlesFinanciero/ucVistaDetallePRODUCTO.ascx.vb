Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PRODUCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/06/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controlesFinanciero_ucVistaDetallePRODUCTO
    Inherits ucBase

#Region "Propiedades"

    Private _ID_PRODUCTO As Int32
    Public Property ID_PRODUCTO() As Int32
        Get
            Return Me.txtID_PRODUCTO.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PRODUCTO = Value
            Me.txtID_PRODUCTO.Text = CStr(Value)
            If Me._ID_PRODUCTO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPRODUCTO
    Private mEntidad As PRODUCTO
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
        If Not Me.ViewState("ID_PRODUCTO") Is Nothing Then Me._ID_PRODUCTO = Me.ViewState("ID_PRODUCTO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PRODUCTO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PRODUCTO
        mEntidad.ID_PRODUCTO = ID_PRODUCTO

        If mComponente.ObtenerPRODUCTO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PRODUCTO.Text = mEntidad.ID_PRODUCTO.ToString()
        If mEntidad.ID_PROVEE = -1 Then
            Me.cbxPROVEEDOR_AGRICOLA.Value = Nothing
        Else
            Me.cbxPROVEEDOR_AGRICOLA.Value = mEntidad.ID_PROVEE
        End If
        Me.txtNOMBRE_PRODUCTO.Text = mEntidad.NOMBRE_PRODUCTO
        Me.cbxCATEGORIA_PROD.Value = mEntidad.ID_CATEGORIA
        If mEntidad.ID_UNIDAD <= 0 Then
            Me.cbxUNIDAD_MEDIDA.SelectedIndex = -1
        Else
            Me.cbxUNIDAD_MEDIDA.Value = mEntidad.ID_UNIDAD
        End If
        Me.spePRECIO_UNITARIO.Value = mEntidad.PRECIO_UNITARIO
        Me.speVENTSEMA_INI.Value = If(mEntidad.VENTSEMA_INI = -1, Nothing, mEntidad.VENTSEMA_INI)
        Me.speVENTSEMA_FIN.Value = If(mEntidad.VENTSEMA_FIN = -1, Nothing, mEntidad.VENTSEMA_FIN)
        Me.txtNOMBRE_COMERCIAL.Text = If(mEntidad.NOMBRE_COMERCIAL = "", mEntidad.NOMBRE_PRODUCTO, mEntidad.NOMBRE_COMERCIAL)
        Me.cbxCUENTA_FINAN.Value = mEntidad.ID_CUENTA_FINAN
        Me.txtPRESENTACION.Text = mEntidad.PRESENTACION
        Me.spePORC_SUBSIDIO.Value = If(mEntidad.PORC_SUBSIDIO = -1, 0, mEntidad.PORC_SUBSIDIO)
        Me.chkEN_CONSIGNA.Value = mEntidad.EN_CONSIGNA
        Me.chkACTIVO.Checked = mEntidad.ACTIVO
        Me.speEXISTENCIA.Value = mEntidad.EXISTENCIA
        Me.chkAPLICA_CESC.Checked = mEntidad.APLICA_CESC
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_PRODUCTO.ClientEnabled = False
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = _nuevo
        Me.txtNOMBRE_PRODUCTO.ClientEnabled = _nuevo OrElse edicion
        Me.cbxCATEGORIA_PROD.ClientEnabled = _nuevo
        Me.cbxUNIDAD_MEDIDA.ClientEnabled = _nuevo OrElse edicion
        Me.spePRECIO_UNITARIO.ClientEnabled = _nuevo OrElse edicion
        Me.speVENTSEMA_INI.ClientEnabled = _nuevo OrElse edicion
        Me.speVENTSEMA_FIN.ClientEnabled = _nuevo OrElse edicion
        Me.txtNOMBRE_COMERCIAL.ClientEnabled = _nuevo OrElse edicion
        Me.cbxCUENTA_FINAN.ClientEnabled = _nuevo
        Me.txtPRESENTACION.ClientEnabled = _nuevo OrElse edicion
        Me.spePORC_SUBSIDIO.ClientEnabled = _nuevo OrElse edicion
        Me.chkEN_CONSIGNA.ClientEnabled = _nuevo OrElse edicion
        Me.chkACTIVO.ClientEnabled = _nuevo OrElse edicion
        Me.speEXISTENCIA.ClientEnabled = False
        Me.chkAPLICA_CESC.ClientEnabled = _nuevo OrElse edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtID_PRODUCTO.Text = ""
        Me.cbxPROVEEDOR_AGRICOLA.Value = Nothing
        Me.txtNOMBRE_PRODUCTO.Text = ""
        Me.cbxCATEGORIA_PROD.Value = Nothing
        Me.cbxUNIDAD_MEDIDA.Value = Nothing
        Me.spePRECIO_UNITARIO.Value = Nothing
        Me.speVENTSEMA_INI.Value = Nothing
        Me.speVENTSEMA_FIN.Value = Nothing
        Me.txtNOMBRE_COMERCIAL.Text = ""
        Me.cbxCUENTA_FINAN.Value = Nothing
        Me.txtPRESENTACION.Text = ""
        Me.spePORC_SUBSIDIO.Value = Nothing
        Me.chkEN_CONSIGNA.Checked = False
        Me.chkACTIVO.Checked = True
        Me.speEXISTENCIA.Value = Nothing
        Me.chkAPLICA_CESC.Checked = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PRODUCTO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        mEntidad = New PRODUCTO
        If Me._nuevo Then
            mEntidad.ID_PRODUCTO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFecha
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFecha
            If lZafra IsNot Nothing Then
                mEntidad.ZAFRA = lZafra.NOMBRE_ZAFRA
                mEntidad.ID_ZAFRA = lZafra.ID_ZAFRA
            End If
            mEntidad.EXISTENCIA = 0
        Else
            mEntidad = mComponente.ObtenerPRODUCTO(CInt(Me.txtID_PRODUCTO.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFecha
        End If

        If Me.txtNOMBRE_PRODUCTO.Text.Trim = "" Then
            Return "Ingrese el nombre del producto"
        End If
        If Me.cbxPROVEEDOR_AGRICOLA.Value Is Nothing AndAlso Me._nuevo Then
            Return "Seleccione el Proveedor agricola al que pertenece el producto"
        End If
        If Me.cbxCATEGORIA_PROD.Value Is Nothing Then
            Return "Seleccione la Categoria a la que pertenece el producto"
        End If
        If Me.cbxUNIDAD_MEDIDA.Value Is Nothing Then
            Return "Seleccione la Unidad de Medida"
        End If
        If Me.cbxCUENTA_FINAN.Value Is Nothing Then
            Return "Seleccione la cuenta de financiamiento"
        End If
        If Me.spePORC_SUBSIDIO.Value Is Nothing Then
            Return "Ingrese el Porcentaje (%) de subsidio"
        End If

        mEntidad.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLA.Value
        mEntidad.NOMBRE_PRODUCTO = Me.txtNOMBRE_PRODUCTO.Text.ToUpper.Trim
        mEntidad.ID_CATEGORIA = Me.cbxCATEGORIA_PROD.Value
        mEntidad.ID_UNIDAD = Me.cbxUNIDAD_MEDIDA.Value
        mEntidad.PRECIO_UNITARIO = Me.spePRECIO_UNITARIO.Value

        mEntidad.VENTSEMA_INI = Me.speVENTSEMA_INI.Value
        mEntidad.VENTSEMA_FIN = Me.speVENTSEMA_FIN.Value
        mEntidad.NOMBRE_COMERCIAL = Me.txtNOMBRE_COMERCIAL.Text.ToUpper.Trim
        mEntidad.ID_CUENTA_FINAN = Me.cbxCUENTA_FINAN.Value
        mEntidad.PRESENTACION = Me.txtPRESENTACION.Text.ToUpper.Trim
        mEntidad.PORC_SUBSIDIO = CDec(Me.spePORC_SUBSIDIO.Value)
        mEntidad.EN_CONSIGNA = Me.chkEN_CONSIGNA.Checked
        mEntidad.ACTIVO = Me.chkACTIVO.Checked
        mEntidad.APLICA_CESC = Me.chkAPLICA_CESC.Checked

        If mComponente.ActualizarPRODUCTO(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PRODUCTO.Text = mEntidad.ID_PRODUCTO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
