Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSOLIC_OIP_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_OIP_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_OIP_TRANS
    Inherits ucBase

#Region "Propiedades"

    Private _ID_OIP_TRANS As Int32
    Public Property ID_OIP_TRANS() As Int32
        Get
            Return Me.txtID_OIP_TRANS.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_OIP_TRANS = Value
            Me.txtID_OIP_TRANS.Text = CStr(Value)
            If Me._ID_OIP_TRANS > 0 Then
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
    Private mComponente As New cSOLIC_OIP_TRANS
    Private mEntidad As SOLIC_OIP_TRANS
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
        If Not Me.ViewState("ID_OIP_TRANS") Is Nothing Then Me._ID_OIP_TRANS = Me.ViewState("ID_OIP_TRANS")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SOLIC_OPI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lTransportista As TRANSPORTISTA
        Dim listaContratos As New List(Of String)

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_OIP_TRANS
        mEntidad.ID_OIP_TRANS = ID_OIP_TRANS

        If mComponente.ObtenerSOLIC_OIP_TRANS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(mEntidad.CODTRANSPORT)
        Me.txtID_OIP_TRANS.Text = mEntidad.ID_OIP_TRANS.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.txtNUM_OIP_ZAFRA.Text = mEntidad.NUM_OIP_ZAFRA
        Me.txtCODTRANSPORT.Text = mEntidad.CODTRANSPORT
        If lTransportista IsNot Nothing Then
            Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
        End If
        Me.dteFECHA.Date = mEntidad.FECHA
        Me.cbxCODIBANCO.Value = mEntidad.CODIBANCO
        Me.speMONTO.Value = mEntidad.MONTO
        Me.speCUOTA_CORTE.Value = mEntidad.CUOTA_CORTE
        Me.spePORC_DESCTO.Value = mEntidad.PORC_DESC
        Me.spePORC_DESCTO_PLA.Value = mEntidad.PORC_DESCEFECTIVO
        Me.chkAceptada.Checked = mEntidad.ES_ACEPTADA
    End Sub



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = Me._nuevo
        Me.txtCODTRANSPORT.ClientEnabled = Me._nuevo
        Me.txtNOMBRE_TRANSPORTISTA.ClientEnabled = False
        Me.dteFECHA.ClientEnabled = Me._nuevo OrElse edicion
        Me.txtNUM_OIP_ZAFRA.ClientEnabled = False
        Me.cbxCODIBANCO.ClientEnabled = Me._nuevo OrElse edicion
        Me.speMONTO.ClientEnabled = Me._nuevo OrElse edicion
        Me.speCUOTA_CORTE.ClientEnabled = Me._nuevo OrElse edicion
        Me.spePORC_DESCTO.ClientEnabled = Me._nuevo OrElse edicion
        Me.spePORC_DESCTO_PLA.ClientEnabled = Not Me._nuevo
        Me.chkAceptada.ClientEnabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.txtCODTRANSPORT.Text = ""
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.dteFECHA.Value = Nothing
        Me.txtNUM_OIP_ZAFRA.Text = ""
        Me.cbxCODIBANCO.Value = Nothing
        Me.speMONTO.Value = Nothing
        Me.speCUOTA_CORTE.Value = Nothing
        Me.spePORC_DESCTO.Value = Nothing
        Me.spePORC_DESCTO_PLA.Value = Nothing
        Me.chkAceptada.ClientEnabled = False
        Me.chkAceptada.Checked = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLIC_OPI
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New SOLIC_OIP_TRANS
        If Me._nuevo Then
            mEntidad.ID_OIP_TRANS = 0
            mEntidad.NUM_OIP_ZAFRA = 0
            mEntidad.UID_OIP_TRANS = Guid.NewGuid
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cSOLIC_OIP_TRANS).ObtenerSOLIC_OIP_TRANS(CInt(Me.txtID_OIP_TRANS.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If cbxZAFRA.Text = "" Then
            Return "Seleccione la zafra"
        End If
        If txtCODTRANSPORT.Text = "" Then
            Return "Ingrese el codigo de transportista"
        End If
        If cbxCODIBANCO.Text = "" Then
            Return "Seleccione el Banco"
        End If
        If Me.spePORC_DESCTO.Value Is Nothing OrElse Me.spePORC_DESCTO.Value <= 0 Then
            Return "Ingrese el porcentaje a descontar sobre entregas"
        End If
        If Me.speCUOTA_CORTE.Value Is Nothing OrElse Me.speCUOTA_CORTE.Value <= 0 Then
            Return "Ingrese la cuota a descontar teorica"
        End If
        If Me.spePORC_DESCTO.Value Is Nothing OrElse Me.spePORC_DESCTO.Value > 100 Then
            Return "El porcentaje a descontar sobre entregas no puede ser mayor al 100%"
        End If

        'Verificar que el transportista posea contrato para la zafra de la OIP
        Dim lContratos As listaCONTRATO_TRANS = (New cCONTRATO_TRANS).ObtenerListaPorTRANSPORTISTA(Me.txtCODTRANSPORT.Value)
        Dim poseeContrato As Boolean = False
        If lContratos IsNot Nothing AndAlso lContratos.Count > 0 Then
            For i As Int32 = 0 To lContratos.Count - 1
                If lContratos(i).ID_ZAFRA = Me.cbxZAFRA.Value Then
                    poseeContrato = True
                    Exit For
                End If
            Next
        End If
        If Not poseeContrato Then
            Return "El transportista debe poseer contrato para la zafra " + Me.cbxZAFRA.Text
        End If

        mEntidad.ID_ZAFRA = cbxZAFRA.Value
        mEntidad.CODTRANSPORT = Me.txtCODTRANSPORT.Value
        mEntidad.FECHA = Me.dteFECHA.Value
        mEntidad.CODIBANCO = Me.cbxCODIBANCO.Value
        mEntidad.MONTO = Me.speMONTO.Value
        mEntidad.CUOTA_CORTE = Me.speCUOTA_CORTE.Value
        mEntidad.PORC_DESC = Me.spePORC_DESCTO.Value
        mEntidad.PORC_DESCEFECTIVO = Me.spePORC_DESCTO_PLA.Value

        If mComponente.ActualizarSOLIC_OIP_TRANS(mEntidad) <> 1 Then
            Return "Error al Guardar registro."
        End If

        If Me._nuevo Then ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarOPI_TRANS(" + mEntidad.ID_OIP_TRANS.ToString + ")", True)

        Me.txtID_OIP_TRANS.Text = mEntidad.ID_OIP_TRANS.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Public Function AceptarOIP() As String
        Dim bContratoProvision As New cCONTRATO_CTAS_PROVI
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        sError = Me.Actualizar
        If sError <> "" Then Return sError

        mEntidad = New SOLIC_OIP_TRANS
        mEntidad = (New cSOLIC_OIP_TRANS).ObtenerSOLIC_OIP_TRANS(CInt(Me.txtID_OIP_TRANS.Text))
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        mEntidad.PORC_DESCEFECTIVO = Me.spePORC_DESCTO_PLA.Value
        mEntidad.ES_ACEPTADA = True

        If mComponente.ActualizarSOLIC_OIP_TRANS(mEntidad) <> 1 Then
            Return "Error al Guardar registro."
        End If
        Return ""
    End Function

    Protected Sub txtCODTRANSPORT_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODTRANSPORT.ValueChanged
        Me.ObtenerTransportista()
    End Sub

    Private Sub ObtenerTransportista()
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        If Me.txtCODTRANSPORT.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.txtCODTRANSPORT.Text) Then
            Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Me.txtCODTRANSPORT.Value)
            If lTransportista IsNot Nothing Then
                Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
            End If
        End If
    End Sub
End Class
