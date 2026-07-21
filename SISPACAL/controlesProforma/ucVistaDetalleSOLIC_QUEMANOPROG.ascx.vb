Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSOLIC_QUEMANOPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_QUEMANOPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_QUEMANOPROG
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_SOLIC_QUEMANOPROG As Int32
    Public Property ID_SOLIC_QUEMANOPROG() As Int32
        Get
            Return Me.txtID_SOLIC_QUEMANOPROG.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_SOLIC_QUEMANOPROG = Value
            Me.txtID_SOLIC_QUEMANOPROG.Text = CStr(Value)
            If Me._ID_SOLIC_QUEMANOPROG > 0 Then
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
    Private mComponente As New cSOLIC_QUEMANOPROG
    Private mEntidad As SOLIC_QUEMANOPROG
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
        If Not Me.ViewState("ID_SOLIC_QUEMANOPROG") Is Nothing Then Me._ID_SOLIC_QUEMANOPROG = Me.ViewState("ID_SOLIC_QUEMANOPROG")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SOLIC_QUEMANOPROG
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_QUEMANOPROG
        mEntidad.ID_SOLIC_QUEMANOPROG = ID_SOLIC_QUEMANOPROG

        If mComponente.ObtenerSOLIC_QUEMANOPROG(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_SOLIC_QUEMANOPROG.Text = mEntidad.ID_SOLIC_QUEMANOPROG.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.dteFECHA_SOLIC.Date = mEntidad.FECHA_SOLIC
        Me.txtNO_SOLICITUD.Value = mEntidad.NO_SOLICITUD
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
        If lProveedor IsNot Nothing Then
            Me.txtCODIPROVEE.Value = CInt(lProveedor.CODIPROVEE)
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.dteFECHA_HORA_QUEMA.Date = mEntidad.FECHA_HORA_QUEMA
        Me.txtAREA.Value = mEntidad.AREA
        Me.txtTONEL.Value = mEntidad.TONEL
        Me.rblTIPO_QUEMA.Value = mEntidad.TIPO_QUEMA.Trim
        Me.chkBRECHAS.Checked = mEntidad.BRECHAS
        Me.chkRONDAS.Checked = mEntidad.RONDAS
        Me.chkVIGILANCIA.Checked = mEntidad.VIGILANCIA
        Me.chkMADURANTE.Checked = mEntidad.MADURANTE
        If mEntidad.FECHA_APLICA = Nothing Then Me.dteFECHA_APLICACION.Date = mEntidad.FECHA_APLICA Else Me.dteFECHA_APLICACION.Value = Nothing
        Me.chkPREMUESTRA.Checked = mEntidad.PRE_MUESTRA
        Me.rblCON_DENUNCIA.Value = mEntidad.CON_DENUNCIA
        Me.txtOBSERVACIONES.Text = mEntidad.OBSERVACIONES
        Me.ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR(mEntidad.ID_ZAFRA, mEntidad.CODIPROVEEDOR, "")
        Me.ucListaLOTES1.SeleccionarFila = mEntidad.ACCESLOTE

        'Pendiente datos de la quema no programada real
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = False
        Me.dteFECHA_SOLIC.ClientEnabled = False
        Me.txtNO_SOLICITUD.ClientEnabled = False
        Me.txtCODIPROVEE.ClientEnabled = edicion
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = edicion
        Me.dteFECHA_HORA_QUEMA.ClientEnabled = edicion
        Me.txtAREA.ClientEnabled = edicion
        Me.txtTONEL.ClientEnabled = edicion
        Me.rblTIPO_QUEMA.ClientEnabled = edicion
        Me.chkBRECHAS.ClientEnabled = edicion
        Me.chkRONDAS.ClientEnabled = edicion
        Me.chkVIGILANCIA.ClientEnabled = edicion
        Me.chkMADURANTE.ClientEnabled = False
        Me.dteFECHA_APLICACION.ClientEnabled = False
        Me.chkPREMUESTRA.ClientEnabled = False
        Me.rblCON_DENUNCIA.ClientEnabled = edicion
        Me.txtOBSERVACIONES.ClientEnabled = edicion
        Me.dteFECHA_HORA_QUEMA_REAL.ClientEnabled = edicion
        Me.txtMZ_REAL.ClientEnabled = edicion
        Me.txtTONEL_REAL.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafraActiva.ID_ZAFRA
        End If
        Me.dteFECHA_SOLIC.Date = cFechaHora.ObtenerFecha
        Me.txtNO_SOLICITUD.Value = Nothing
        Me.txtCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.dteFECHA_HORA_QUEMA.Value = Nothing
        Me.txtAREA.Value = Nothing
        Me.txtTONEL.Value = Nothing
        Me.rblTIPO_QUEMA.Value = Nothing
        Me.chkBRECHAS.Checked = False
        Me.chkRONDAS.Checked = False
        Me.chkVIGILANCIA.Checked = False
        Me.chkMADURANTE.Checked = False
        Me.dteFECHA_APLICACION.Value = Nothing
        Me.chkPREMUESTRA.Checked = False
        Me.rblCON_DENUNCIA.Value = Nothing
        Me.txtOBSERVACIONES.Text = ""
        Me.dteFECHA_HORA_QUEMA_REAL.Value = Nothing
        Me.txtMZ_REAL.Value = Nothing
        Me.txtTONEL_REAL.Value = Nothing
        Me.ucListaLOTES1.CargarDatosPorPROVEEDOR("")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLIC_QUEMANOPROG
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lLotes As listaLOTES
        Dim lLoteCosecha As LOTES_COSECHA

        mEntidad = New SOLIC_QUEMANOPROG
        If Me._nuevo Then
            mEntidad.ID_SOLIC_QUEMANOPROG = 0
        Else
            mEntidad = (New cSOLIC_QUEMANOPROG).ObtenerSOLIC_QUEMANOPROG(CInt(Me.txtID_SOLIC_QUEMANOPROG.Text))
        End If

        lLotes = Me.ucListaLOTES1.DevolverSeleccionados
        If lLotes Is Nothing OrElse lLotes.Count = 0 Then
            Return "* Seleccione un lote"
        End If

        lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lLotes(0).ACCESLOTE, Me.cbxZAFRA.Value)

        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.ACCESLOTE = lLotes(0).ACCESLOTE
        mEntidad.FECHA_SOLIC = Me.dteFECHA_SOLIC.Value
        mEntidad.CODIPROVEEDOR = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Value) + Utilerias.FormatoCODISOCIO(0)
        mEntidad.ZONA = lLotes(0).ZONA
        mEntidad.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_QUEMA.Value
        mEntidad.AREA = Me.txtAREA.Value
        mEntidad.TONEL = Me.txtTONEL.Value
        mEntidad.TIPO_QUEMA = Me.rblTIPO_QUEMA.Value
        mEntidad.CODIVARIEDA = lLotes(0).CODIVARIEDA
        mEntidad.BRECHAS = Me.chkBRECHAS.Checked
        mEntidad.RONDAS = Me.chkRONDAS.Checked
        mEntidad.VIGILANCIA = Me.chkVIGILANCIA.Checked
        mEntidad.MADURANTE = Me.chkMADURANTE.Checked
        mEntidad.FECHA_APLICA = Me.dteFECHA_APLICACION.Value
        mEntidad.PRE_MUESTRA = Me.chkPREMUESTRA.Checked
        If lLoteCosecha IsNot Nothing Then mEntidad.FECHA_ROZA = lLoteCosecha.FECHA_ROZA Else mEntidad.FECHA_ROZA = #12:00:00 AM#

        'mEntidad.FECHA_INI_VENTANA = Me.deFECHA_INI_VENTANA.Value
        'mEntidad.FECHA_FIN_VENTANA = Me.deFECHA_FIN_VENTANA.Value
        mEntidad.OBSERVACIONES = Me.txtOBSERVACIONES.Text
        'mEntidad.CODIAGRON = Me.txtCODIAGRON.Text
        mEntidad.CON_DENUNCIA = Me.rblCON_DENUNCIA.Value
        mEntidad.ZAFRA = Me.cbxZAFRA.Text
        mEntidad.USUARIO_CREA = Me.ObtenerUsuario
        mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        If mComponente.ActualizarSOLIC_QUEMANOPROG(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_SOLIC_QUEMANOPROG.Text = mEntidad.ID_SOLIC_QUEMANOPROG.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub txtCODIPROVEE_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE.ValueChanged
        Me.CargarProveedor()
    End Sub

    Private Sub CargarProveedor()
        Dim codiProveedor As String = ""
        Dim lEntidad As PROVEEDOR

        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If txtCODIPROVEE.Value IsNot Nothing Then
            codiProveedor = Utilerias.FormatoCODIPROVEE(txtCODIPROVEE.Value) + Utilerias.FormatoCODISOCIO(0)
            lEntidad = (New cPROVEEDOR).ObtenerPROVEEDOR(codiProveedor)
            If lEntidad IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            End If
            Me.ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(Me.cbxZAFRA.Value, codiProveedor, "")
        Else
            Me.ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(0, "", "")
        End If
    End Sub
End Class
