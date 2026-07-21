Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleORDEN_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ORDEN_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/10/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleORDEN_COMBUSTIBLEV2
    Inherits ucBase

#Region "Propiedades"

    Public Property ID_ORDEN_COMBUS() As Int32
        Get
            If Me.ViewState("ID_ORDEN_COMBUS") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ORDEN_COMBUS"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_ORDEN_COMBUS") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
    End Sub

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cORDEN_COMBUSTIBLE
    Private mEntidad As ORDEN_COMBUSTIBLE
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

    Public Property TIPO_OPERACION As TipoOperacion
        Get
            If Me.ViewState("TIPO_OPERACION") Is Nothing Then
                Return TipoOperacion.Emision
            Else
                Return Me.ViewState("TIPO_OPERACION")
            End If
        End Get
        Set(ByVal value As TipoOperacion)
            Me.ViewState("TIPO_OPERACION") = value
            If value = TipoOperacion.Emision Then
                Me.ID_ORDEN_COMBUS = 0
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(Me._Enabled)
            ElseIf value = TipoOperacion.Facturacion Then
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(False)
            ElseIf value = TipoOperacion.Anulacion Then
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(False)
            End If
        End Set
    End Property

    Public Property CODTRANSPORT As Integer
        Get
            If Me.ViewState("CODTRANSPORT") Is Nothing Then
                Return 0
            Else
                Return CInt(Me.ViewState("CODTRANSPORT"))
            End If
        End Get
        Set(value As Integer)
            Me.ViewState("CODTRANSPORT") = value
        End Set
    End Property

#End Region


    Public Property LISTA_ORDEN_COMBUSTIBLE_PROD As listaORDEN_COMBUSTIBLE_PROD
        Set(value As listaORDEN_COMBUSTIBLE_PROD)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaORDEN_COMBUSTIBLE_PROD) Else Return New listaORDEN_COMBUSTIBLE_PROD
        End Get
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ORDEN_COMBUSTIBLE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lTransportista As TRANSPORTISTA
        Dim lTransporte As TRANSPORTE
        Dim lMotorista As MOTORISTA

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ORDEN_COMBUSTIBLE
        mEntidad.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS

        If mComponente.ObtenerORDEN_COMBUSTIBLE(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.txtID_ORDEN_COMBUS.Text = mEntidad.ID_ORDEN_COMBUS.ToString()

        lMotorista = (New cMOTORISTA).ObtenerMOTORISTA(mEntidad.ID_MOTORISTA)
        lTransporte = (New cTRANSPORTE).ObtenerTRANSPORTE(mEntidad.ID_TRANSPORTE)

        If lTransporte IsNot Nothing Then
            lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(lTransporte.CODTRANSPORT)
        End If

        Me.rbtlTIPO_PROVEEDOR.Value = mEntidad.ID_TIPO_PROVEEDOR

        If mEntidad.ID_TIPO_PROVEEDOR = TipoProveedor.Transportista Then
            If lTransportista IsNot Nothing Then
                Me.CODTRANSPORT = lTransporte.CODTRANSPORT
                Me.txtCODIGO_CLIENTE.Text = mEntidad.ID_TRANSPORTE
                Me.txtNOMBRE_CLIENTE.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
                Me.txtNIT.Text = lTransportista.NIT
                Me.txtNRC.Text = lTransportista.CREDITO_FISCAL
            End If
        Else
            txtCODIGO_CLIENTE.Text = mEntidad.ID_MOTORISTA_VEHI
            txtNOMBRE_CLIENTE.Text = lMotorista.NOMBRES + " " + lMotorista.APELLIDOS
        End If
        Me.CargarPlacasPorTransportista()
        If mEntidad.ID_TRANSPORTE <> -1 Then
            Me.cbxPLACAVEHIC.Value = mEntidad.ID_TRANSPORTE
        Else
            Me.cbxPLACAVEHIC.Text = mEntidad.PLACA
        End If
        If mEntidad.ID_SECCION <> -1 Then
            Me.cbxSECCION.Value = mEntidad.ID_SECCION
        Else
            Me.cbxSECCION.Value = Nothing
        End If

        Me.cbxMOTORISTA.Value = mEntidad.ID_MOTORISTA
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtLICENCIA.Text = mEntidad.LICENCIA
        Me.txtOBSERVACIONES.Text = mEntidad.OBSERVACION

        If Me.TIPO_OPERACION = TipoOperacion.Facturacion OrElse Me.TIPO_OPERACION = TipoOperacion.Anulacion Then
            If mEntidad.FECHA_DESPACHO <> #12:00:00 AM# Then Me.dteFECHA_DESPACHO.Date = mEntidad.FECHA_DESPACHO
            Me.txtTOTAL_FACTURA.Text = mEntidad.TOTAL
            If mEntidad.NO_FACTURA_CCF <> "" AndAlso mEntidad.NO_FACTURA_CCF <> Nothing Then Me.txtNO_FACTURA_CCF.Text = mEntidad.NO_FACTURA_CCF
            If Me.mEntidad.MOTIVO_ANULACION <> "" Then
                Me.txtMOTIVO_ANULACION.Text = mEntidad.MOTIVO_ANULACION
            End If
        End If
        Me.LISTA_ORDEN_COMBUSTIBLE_PROD = (New cORDEN_COMBUSTIBLE_PROD).ObtenerListaPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaORDEN_COMBUSTIBLE_PROD1.PermitirEditarInline = False
        Me.ucListaORDEN_COMBUSTIBLE_PROD1.PermitirEditarInline2 = False
        Me.ucListaORDEN_COMBUSTIBLE_PROD1.PermitirEliminar = False
        Me.ucListaORDEN_COMBUSTIBLE_PROD1.Visible = True
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaORDEN_COMBUSTIBLE_PROD1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Private Sub CargarPlacasPorTransportista()
        Dim lPlacas As listaTRANSPORTE

        lPlacas = (New cTRANSPORTE).ObtenerListaPorTRANSPORTISTA(Me.CODTRANSPORT)
        If lPlacas Is Nothing Then lPlacas = New listaTRANSPORTE

        Me.cbxPLACAVEHIC.DataSource = lPlacas
        Me.cbxPLACAVEHIC.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = False
        Me.txtID_ORDEN_COMBUS.ClientEnabled = (TIPO_OPERACION <> TipoOperacion.Emision)
        Me.cbxZAFRA.ClientEnabled = False
        Me.rbtlTIPO_PROVEEDOR.ClientEnabled = Me._nuevo AndAlso (TIPO_OPERACION = TipoOperacion.Emision)
        Me.txtCODIGO_CLIENTE.ClientEnabled = Me._nuevo AndAlso (TIPO_OPERACION = TipoOperacion.Emision)
        Me.txtNOMBRE_CLIENTE.ClientEnabled = False
        Me.cbxPLACAVEHIC.ClientEnabled = Me._nuevo AndAlso (TIPO_OPERACION = TipoOperacion.Emision)
        Me.cbxSECCION.ClientEnabled = Me._nuevo AndAlso (TIPO_OPERACION = TipoOperacion.Emision)
        Me.txtNIT.ClientEnabled = False
        Me.txtNRC.ClientEnabled = False
        Me.cbxMOTORISTA.ClientEnabled = Me._nuevo AndAlso (TIPO_OPERACION = TipoOperacion.Emision)
        Me.txtDUI.ClientEnabled = False
        Me.txtLICENCIA.ClientEnabled = False
        Me.txtNO_FACTURA_CCF.ClientEnabled = False
        Me.dteFECHA_DESPACHO.ClientEnabled = False
        Me.txtTOTAL_FACTURA.ClientEnabled = False
        Me.txtOBSERVACIONES.ClientEnabled = Me._nuevo AndAlso (TIPO_OPERACION = TipoOperacion.Emision)
        Me.speTOTAL.ClientEnabled = False

        Me.trFACTURA1.Visible = (TIPO_OPERACION <> TipoOperacion.Emision)
        Me.trFACTURA2.Visible = (TIPO_OPERACION <> TipoOperacion.Emision)
        Me.trNUEVO_PRODUCTO1.Visible = (TIPO_OPERACION = TipoOperacion.Emision)
        Me.trNUEVO_PRODUCTO2.Visible = (TIPO_OPERACION = TipoOperacion.Emision)
        Me.trMOTIVO_ANULACION.Visible = (TIPO_OPERACION = TipoOperacion.Anulacion)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo(Optional ConSeleccion As Boolean = True)
        AsignarMensaje("", True, False)
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing Then Me.cbxZAFRA.Value = lZafraActiva.ID_ZAFRA
        Me.txtID_ORDEN_COMBUS.Text = ""
        If ConSeleccion Then Me.rbtlTIPO_PROVEEDOR.Value = 5
        Me.txtCODIGO_CLIENTE.Text = ""
        Me.txtNOMBRE_CLIENTE.Text = ""
        Me.cbxPLACAVEHIC.Value = Nothing
        Me.cbxSECCION.Value = Nothing
        Me.txtNIT.Text = ""
        Me.txtNRC.Text = ""
        Me.cbxMOTORISTA.Value = Nothing
        Me.txtDUI.Text = ""
        Me.txtLICENCIA.Text = ""
        Me.txtOBSERVACIONES.Text = ""
        Me.txtNO_FACTURA_CCF.Text = ""
        Me.dteFECHA_DESPACHO.Value = Nothing
        Me.txtTOTAL_FACTURA.Text = ""
        Me.txtMOTIVO_ANULACION.Text = ""

        Me.SeleccionarDiesel()
        Me.speCANTIDAD.Value = Nothing
        Me.spePRECION_UNITARIO.Value = Nothing
        Me.speTOTAL.Value = Nothing
        Me.SeleccionarDiesel()
        Me.LISTA_ORDEN_COMBUSTIBLE_PROD = New listaORDEN_COMBUSTIBLE_PROD
        Me.CargarDetalleDocumentoEnca()
        Me.txtCODIGO_CLIENTE.Focus()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ORDEN_COMBUSTIBLE
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim alDatos As New ArrayList
        Dim fechaDespacho As DateTime
        Dim lRet As Integer

        mEntidad = New ORDEN_COMBUSTIBLE
        If Me._nuevo Then
            mEntidad.ID_ORDEN_COMBUS = 0
        Else
            mEntidad.ID_ORDEN_COMBUS = CInt(Me.txtID_ORDEN_COMBUS.Text)
        End If

        mEntidad = New ORDEN_COMBUSTIBLE
        If Me._nuevo Then
            mEntidad.ID_ORDEN_COMBUS = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerORDEN_COMBUSTIBLE(CInt(Me.txtID_ORDEN_COMBUS.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If TIPO_OPERACION = TipoOperacion.Anulacion AndAlso mEntidad.ESTADO = "A" Then
            sError.AppendLine(" * Orden ya se encuentra anulada")
        End If
        If Me.cbxZAFRA.Value Is Nothing Then
            sError.AppendLine(" * No existe Periodo de Zafra")
        End If
        If cbxSECCION.ClientEnabled AndAlso cbxSECCION.Value Is Nothing Then
            sError.AppendLine(" * Seleccione la seccion")
        End If
        If Me.txtCODIGO_CLIENTE.Text.Trim = String.Empty AndAlso TIPO_OPERACION <> TipoOperacion.Anulacion Then
            sError.AppendLine(" * Ingrese el codigo de cliente")
        End If
        If rbtlTIPO_PROVEEDOR.Value = TipoProveedor.Transportista AndAlso cbxPLACAVEHIC.Text = "" Then
            sError.AppendLine(" * Ingrese el numero de placa")
        End If
        If rbtlTIPO_PROVEEDOR.Value = TipoProveedor.Transportista AndAlso Me.cbxMOTORISTA.Text.Trim = "" Then
            sError.AppendLine(" * Seleccione o ingrese el nombre del motorista")
        End If
        If Me.txtDUI.Text.Trim <> "" AndAlso Me.txtDUI.Text.Trim.Length < 9 Then
            sError.AppendLine(" * DUI no valido")
        End If
        'If Me.txtLICENCIA.Text.Trim = "" Then
        '    sError.AppendLine(" * Ingrese numero de LICENCIA.")
        'End If
        If TIPO_OPERACION = TipoOperacion.Emision Then
            If LISTA_ORDEN_COMBUSTIBLE_PROD.Count = 0 Then
                sError.AppendLine(" * Ingrese el detalle de la Orden")
            End If
        End If
        If TIPO_OPERACION = TipoOperacion.Facturacion Then
            If txtNO_FACTURA_CCF.Text.Trim = "" Then
                sError.AppendLine(" * Ingrese No. de Factura")
            End If
            If dteFECHA_DESPACHO.Value Is Nothing Then
                sError.AppendLine(" * Ingrese la Fecha de despacho")
            End If
            If LISTA_ORDEN_COMBUSTIBLE_PROD.Count = 0 Then
                sError.AppendLine(" * Ingrese el detalle de la Orden")
            End If
            If Not IsNumeric(Me.txtTOTAL_FACTURA.Text) Then
                sError.AppendLine(" * Monto de la orden debe ser numerico")
            End If
        End If
        If TIPO_OPERACION = TipoOperacion.Anulacion Then
            If Me.txtMOTIVO_ANULACION.Text.Trim = "" Then
                sError.AppendLine(" * Ingrese motivo de la anulacion.<br>")
            End If
        End If
        If sError.ToString.Length > 0 Then
            AsignarMensaje(sError.ToString, True, False)
            Return sError.ToString
        End If

        If TIPO_OPERACION = TipoOperacion.Emision Then
            Dim dblTotal As Decimal = 0

            mEntidad.ID_ZAFRA = cbxZAFRA.Value
            mEntidad.ID_PROVEEDOR_COMBUS = 1
            mEntidad.ID_TIPO_PROVEEDOR = rbtlTIPO_PROVEEDOR.Value
            If Me.rbtlTIPO_PROVEEDOR.Value = TipoProveedor.Motorista Then
                mEntidad.CODIGO = Me.CODTRANSPORT
                mEntidad.ID_MOTORISTA_VEHI = CInt(txtCODIGO_CLIENTE.Text)
            Else
                mEntidad.CODIGO = txtCODIGO_CLIENTE.Text
                mEntidad.ID_MOTORISTA_VEHI = -1
            End If
            mEntidad.FECHA_EMISION = cFechaHora.ObtenerFecha
            mEntidad.PLACA = cbxPLACAVEHIC.Text.Trim.ToUpper
            If rbtlTIPO_PROVEEDOR.Value = TipoProveedor.Transportista Then
                Dim bTransporte As New cTRANSPORTE
                Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(txtCODIGO_CLIENTE.Text), Me.cbxPLACAVEHIC.Text)
                If lTransporte IsNot Nothing AndAlso lTransporte.ID_TRANSPORTE > 0 Then
                    mEntidad.ID_TRANSPORTE = lTransporte.ID_TRANSPORTE
                Else
                    mEntidad.ID_TRANSPORTE = -1
                End If
            Else
                mEntidad.ID_TRANSPORTE = Me.cbxPLACAVEHIC.Value
            End If

            If Me.cbxMOTORISTA.Value Is Nothing OrElse Not IsNumeric(Me.cbxMOTORISTA.Value) Then
                mEntidad.NOMBRES_MOTORISTA = cbxMOTORISTA.Text.Trim.ToUpper
                mEntidad.ID_MOTORISTA = -1
            Else
                Dim lMotorista As MOTORISTA = (New cMOTORISTA).ObtenerMOTORISTA(cbxMOTORISTA.Value)
                If lMotorista IsNot Nothing Then
                    mEntidad.NOMBRES_MOTORISTA = lMotorista.NOMBRES + " " + lMotorista.APELLIDOS
                    mEntidad.ID_MOTORISTA = Me.cbxMOTORISTA.Value
                Else
                    mEntidad.ID_MOTORISTA = -1
                End If
            End If
            If Me.txtDUI.Text.Length = 9 OrElse Me.txtDUI.Text.Length = 10 Then
                mEntidad.DUI = Replace(Me.txtDUI.Text, "-", "")
            Else
                mEntidad.DUI = Nothing
            End If
            If Me.txtLICENCIA.Text.Trim <> "" Then
                mEntidad.LICENCIA = Replace(Me.txtLICENCIA.Text, "-", "")
            Else
                mEntidad.LICENCIA = Nothing
            End If
            If Me.txtNIT.Text.Length = 17 Then
                mEntidad.NIT = Replace(Me.txtNIT.Text, "-", "")
            Else
                mEntidad.NIT = Nothing
            End If
            If Me.txtNRC.Text.Trim <> "" Then
                mEntidad.NRC = Me.txtNRC.Text
            Else
                mEntidad.NRC = Nothing
            End If
            If Me.rbtlTIPO_PROVEEDOR.Value = TipoProveedor.Transportista AndAlso Me.txtCODIGO_CLIENTE.Text = "300" Then
                mEntidad.ID_SECCION = Me.cbxSECCION.Value
            Else
                mEntidad.ID_SECCION = -1
            End If
            mEntidad.OBSERVACION = If(Me.txtOBSERVACIONES.Text.Trim <> "", Me.txtOBSERVACIONES.Text.Trim.ToUpper, Nothing)
            mEntidad.APELLIDOS_MOTORISTA = ""
            mEntidad.ESTADO = "E"
            mEntidad.FECHA_DESPACHO = #12:00:00 AM#
            mEntidad.NO_FACTURA_CCF = Nothing
            mEntidad.FECHA_ANULACION = #12:00:00 AM#
            mEntidad.MOTIVO_ANULACION = Nothing
            If LISTA_ORDEN_COMBUSTIBLE_PROD IsNot Nothing AndAlso LISTA_ORDEN_COMBUSTIBLE_PROD.Count > 0 Then
                For Each entidad As ORDEN_COMBUSTIBLE_PROD In LISTA_ORDEN_COMBUSTIBLE_PROD
                    dblTotal += entidad.CANTIDAD * entidad.PRECIO_VENTA
                Next
            End If
            mEntidad.TOTAL = dblTotal
            mEntidad.ID_CATORCENA = -1
            mEntidad.ID_ORDEN_COMBUSTIBLE_NUM = -1
        ElseIf TIPO_OPERACION = TipoOperacion.Facturacion Then
            mEntidad.ESTADO = "F"
            mEntidad.FECHA_DESPACHO = dteFECHA_DESPACHO.Date
            mEntidad.NO_FACTURA_CCF = txtNO_FACTURA_CCF.Text
            mEntidad.FECHA_ANULACION = #12:00:00 AM#
            mEntidad.MOTIVO_ANULACION = Nothing
            mEntidad.TOTAL = CDec(Me.txtTOTAL_FACTURA.Value)
        ElseIf TIPO_OPERACION = TipoOperacion.Anulacion Then
            mEntidad.ESTADO = "A"
            mEntidad.FECHA_ANULACION = cFechaHora.ObtenerFechaHora
            mEntidad.MOTIVO_ANULACION = Me.txtMOTIVO_ANULACION.Text.Trim.ToUpper
        End If


        lRet = mComponente.ActualizarORDEN_COMBUSTIBLE(mEntidad, TipoConcurrencia.Pesimistica)
        If lRet = -2 Then
            AsignarMensaje(mComponente.sError, True, False)
            Return "Error al Guardar registro."
        End If
        If lRet = -7 Then
            Me._nuevo = False
            If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
            Me.ViewState.Add("nuevo", Me._nuevo)
            Return ""
        End If
        If lRet <> 1 Then
            Me.AsignarMensaje("* " + mComponente.sError, True)
            Return "Error al Guardar registro."
        Else
            If TIPO_OPERACION = TipoOperacion.Emision OrElse TIPO_OPERACION = TipoOperacion.Facturacion Then
                GuardarDetalle(mEntidad.ID_ORDEN_COMBUS)
            End If
        End If
        Me.txtID_ORDEN_COMBUS.Text = mEntidad.ID_ORDEN_COMBUS.ToString()

        Select Case TIPO_OPERACION
            Case TipoOperacion.Emision
                Me.AsignarMensaje("Orden emitida con exito", False, True, True)
                ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarOrdenCombustible(" + mEntidad.ID_ORDEN_COMBUS.ToString + ")", True)

            Case TipoOperacion.Facturacion
                Me.AsignarMensaje("Orden facturada con exito", False, True, True)
            Case TipoOperacion.Anulacion
                Me.AsignarMensaje("Orden anulada con exito", False, True, True)
        End Select

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Private Sub GuardarDetalle(ByVal ID_ORDEN_COMBUS As Integer)
        Dim bOrdenCombustibleProd As New cORDEN_COMBUSTIBLE_PROD
        Dim lOrdenCombustibleProd As ORDEN_COMBUSTIBLE_PROD
        Dim lista As listaORDEN_COMBUSTIBLE_PROD

        lista = LISTA_ORDEN_COMBUSTIBLE_PROD
        bOrdenCombustibleProd.EliminarPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For Each entidad As ORDEN_COMBUSTIBLE_PROD In lista
                lOrdenCombustibleProd = New ORDEN_COMBUSTIBLE_PROD
                lOrdenCombustibleProd.ID_ORDEN_COMBUSTIBLE_PROD = 0
                lOrdenCombustibleProd.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
                lOrdenCombustibleProd.ID_PRODUCTO = entidad.ID_PRODUCTO
                lOrdenCombustibleProd.CANTIDAD = entidad.CANTIDAD
                lOrdenCombustibleProd.PRECIO_VENTA = entidad.PRECIO_VENTA
                lOrdenCombustibleProd.NOMBRE_PRODUCTO = entidad.NOMBRE_PRODUCTO
                lOrdenCombustibleProd.USUARIO_CREA = Me.ObtenerUsuario
                lOrdenCombustibleProd.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lOrdenCombustibleProd.USUARIO_ACT = Me.ObtenerUsuario
                lOrdenCombustibleProd.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bOrdenCombustibleProd.ActualizarORDEN_COMBUSTIBLE_PROD(lOrdenCombustibleProd)
            Next

        End If
    End Sub

    Protected Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim lProdComb As New ORDEN_COMBUSTIBLE_PROD
        Dim lProducto As PRODUCTO_COMBUSTIBLE

        If Me.txtCODIGO_CLIENTE.Text.Trim = String.Empty Then
            Me.AsignarMensaje("* Ingrese el codigo de cliente", True, False)
            Return
        End If
        If Me.cbxPLACAVEHIC.Value Is Nothing Then
            Me.AsignarMensaje("* Seleccione la placa", True, False)
            Return
        End If
        If Me.cbxPRODUCTO.Value Is Nothing Then
            Me.AsignarMensaje("* Seleccione o Ingrese el Producto", True, False)
            Return
        End If
        If Me.speCANTIDAD.Value = 0 Then
            Me.AsignarMensaje("* Ingrese la Cantidad de Producto", True, False)
            Return
        End If
        If Me.spePRECION_UNITARIO.Value Is Nothing Then
            Me.AsignarMensaje("* Ingrese el Precio Unitario del Producto", True, False)
            Return
        End If
        If (Me.cbxPRODUCTO.Value = 1 OrElse Me.cbxPRODUCTO.Value = 2) AndAlso cbxPLACAVEHIC.Value IsNot Nothing Then
            If Me.ObtenerCantidadMaximaCombustible > 0 AndAlso Me.ObtenerCantidadMaximaCombustible < Me.speCANTIDAD.Value Then
                Me.AsignarMensaje("* La cantidad del producto es mayor a la cantidad autorizada de " + CStr(Me.ObtenerCantidadMaximaCombustible) + " glns.", True, False)
                Return
            End If
        End If

        lProdComb.ID_ORDEN_COMBUSTIBLE_PROD = Me.ObtenerIdProd(Me.LISTA_ORDEN_COMBUSTIBLE_PROD)
        lProdComb.ID_ORDEN_COMBUS = 0
        lProdComb.ID_PRODUCTO = Me.cbxPRODUCTO.Value
        If lProdComb.ID_PRODUCTO <> -1 Then
            lProducto = (New cPRODUCTO_COMBUSTIBLE).ObtenerPRODUCTO_COMBUSTIBLE(lProdComb.ID_PRODUCTO)
            If lProducto IsNot Nothing Then
                lProdComb.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO.ToUpper
            End If
        Else
            lProdComb.NOMBRE_PRODUCTO = Me.cbxPRODUCTO.Text.ToUpper
        End If
        lProdComb.CANTIDAD = Me.speCANTIDAD.Value
        lProdComb.PRECIO_VENTA = Me.spePRECION_UNITARIO.Value
        lProdComb.TOTAL = Me.speTOTAL.Value
        lProdComb.REFERENCIA = Me.lblREFERENCIA.Text

        Me.LISTA_ORDEN_COMBUSTIBLE_PROD.Add(lProdComb)
        Me.CargarDetalleDocumentoEnca()
        Me.AsignarMensaje("", True, False)

        Me.cbxPRODUCTO.Value = Nothing
        Me.speCANTIDAD.Text = ""
        Me.spePRECION_UNITARIO.Value = Nothing
        Me.speTOTAL.Text = ""
        Me.cbxPRODUCTO.Focus()
    End Sub

    Private Sub SeleccionarDiesel()
        Me.cbxPRODUCTO.Value = 1
        Me.spePRECION_UNITARIO.Value = ObtenerPrecioProducto(1)
        Me.TotalDetalle()
    End Sub

    Private Function ObtenerIdProd(ByVal lista As listaORDEN_COMBUSTIBLE_PROD) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_ORDEN_COMBUSTIBLE_PROD > Id Then
                Id = lista(i).ID_ORDEN_COMBUSTIBLE_PROD
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub txtCODIGO_CLIENTE_ValueChanged(sender As Object, e As EventArgs) Handles txtCODIGO_CLIENTE.ValueChanged
        Me.AsignarMensaje("", True, False)
        txtNOMBRE_CLIENTE.Text = ""
        txtCODIGO_CLIENTE.Text = txtCODIGO_CLIENTE.Text.Trim
        cbxSECCION.SelectedIndex = -1
        cbxSECCION.ClientEnabled = False
        Me.cbxPLACAVEHIC.ClientEnabled = True
        Me.cbxMOTORISTA.ClientEnabled = True
        Me.CODTRANSPORT = -1
        Me.CargarPlacasPorTransportista()

        If Not Utilerias.EsNumeroEntero(txtCODIGO_CLIENTE.Text) Then
            Me.txtCODIGO_CLIENTE.Text = ""
            Me.txtNOMBRE_CLIENTE.Text = ""
            Me.CargarPlacasPorTransportista()
            Me.cbxPLACAVEHIC.Value = Nothing
            Me.cbxMOTORISTA.Value = Nothing
            Me.txtDUI.Text = ""
            Me.txtLICENCIA.Text = ""
            Me.txtNIT.Text = ""
            Me.txtNRC.Text = ""
            Me.txtCODIGO_CLIENTE.Focus()
            Exit Sub
        End If
        txtCODIGO_CLIENTE.Text = CInt(txtCODIGO_CLIENTE.Text)
        If rbtlTIPO_PROVEEDOR.Value = Enumeradores.TipoProveedor.Transportista Then
            Dim entidad As TRANSPORTISTA
            entidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Convert.ToInt32(txtCODIGO_CLIENTE.Text))
            If entidad IsNot Nothing Then
                txtNOMBRE_CLIENTE.Text = Trim(entidad.NOMBRES + " " + entidad.APELLIDOS)
                Me.CODTRANSPORT = entidad.CODTRANSPORT
                Me.CargarPlacasPorTransportista()
                cbxPLACAVEHIC.Value = Nothing
                Me.cbxMOTORISTA.Value = Nothing
                Me.txtNIT.Enabled = Not (Me.txtCODIGO_CLIENTE.Text = "300")
                Me.txtNRC.Enabled = Not (Me.txtCODIGO_CLIENTE.Text = "300")

                Me.txtNIT.Text = Utilerias.FormatearNIT(entidad.NIT)
                Me.txtNRC.Text = entidad.CREDITO_FISCAL

                Me.txtNIT.Enabled = (Me.txtNIT.Text = "")
                Me.txtNRC.Enabled = (Me.txtNRC.Text = "")
                Me.cbxSECCION.ClientEnabled = (Me.txtCODIGO_CLIENTE.Text = "300")
                cbxPLACAVEHIC.Focus()
            Else
                AsignarMensaje(" * Codigo de transportista no esta registrado", True, False)
                txtCODIGO_CLIENTE.Text = ""
                cbxPLACAVEHIC.Value = Nothing
                Me.cbxMOTORISTA.Value = Nothing
                txtCODIGO_CLIENTE.Focus()
            End If
        ElseIf rbtlTIPO_PROVEEDOR.Value = Enumeradores.TipoProveedor.Motorista Then
            Dim lMotoristaVehi As MOTORISTA_VEHICULO
            Dim lMotorista As MOTORISTA

            lMotoristaVehi = (New cMOTORISTA_VEHICULO).ObtenerMOTORISTA_VEHICULO(Convert.ToInt32(txtCODIGO_CLIENTE.Text))
            If lMotoristaVehi IsNot Nothing Then
                If Not lMotoristaVehi.ACTIVO Then
                    AsignarMensaje(" * Motorista esta inactivo en el sistema", True, False)
                    Return
                ElseIf lMotoristaVehi.CASTIGADO Then
                    AsignarMensaje(" * Motorista se encuentra castigado", True, False)
                    Return
                End If

                lMotorista = (New cMOTORISTA).ObtenerMOTORISTA(lMotoristaVehi.ID_MOTORISTA)
                txtNOMBRE_CLIENTE.Text = Trim(lMotorista.NOMBRES + " " + lMotorista.APELLIDOS)
                txtDUI.Text = lMotorista.DUI
                txtLICENCIA.Text = lMotorista.LICENCIA

                Dim lTransporte As TRANSPORTE
                lTransporte = (New cTRANSPORTE).ObtenerTRANSPORTE(Convert.ToInt32(lMotoristaVehi.ID_TRANSPORTE))
                If lTransporte IsNot Nothing Then
                    Dim lTransportista As TRANSPORTISTA
                    lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(lTransporte.CODTRANSPORT)
                    If lTransportista IsNot Nothing Then
                        Me.CODTRANSPORT = lTransportista.CODTRANSPORT
                        Me.CargarPlacasPorTransportista()
                        If Me.cbxPLACAVEHIC.Items.Count > 0 Then
                            Me.cbxPLACAVEHIC.Value = lTransporte.ID_TRANSPORTE
                            If Me.ObtenerCantidadMaximaCombustible > 0 Then Me.speCANTIDAD.Value = Me.ObtenerCantidadMaximaCombustible
                            Me.TotalDetalle()
                        End If
                        Me.cbxMOTORISTA.Value = lMotorista.ID_MOTORISTA
                        Me.txtNIT.Enabled = Not (Me.txtCODIGO_CLIENTE.Text = "300")
                        Me.txtNRC.Enabled = Not (Me.txtCODIGO_CLIENTE.Text = "300")
                        Me.txtNIT.Text = Utilerias.FormatearNIT(lTransportista.NIT)
                        Me.txtNRC.Text = lTransportista.CREDITO_FISCAL
                        Me.txtNIT.Enabled = (Me.txtNIT.Text = "")
                        Me.txtNRC.Enabled = (Me.txtNRC.Text = "")
                        Me.cbxSECCION.ClientEnabled = (Me.txtCODIGO_CLIENTE.Text = "300")
                        Me.cbxPLACAVEHIC.ClientEnabled = False
                        Me.cbxMOTORISTA.ClientEnabled = False
                    End If
                End If
            Else
                AsignarMensaje(" * Codigo de motorista no esta registrado", True, False)
                txtCODIGO_CLIENTE.Text = ""
                cbxPLACAVEHIC.Value = ""
                Me.cbxMOTORISTA.Value = Nothing
                txtCODIGO_CLIENTE.Focus()
            End If
        End If
    End Sub

    Protected Sub rbtlTIPO_PROVEEDOR_ValueChanged(sender As Object, e As EventArgs) Handles rbtlTIPO_PROVEEDOR.ValueChanged
        Me.Nuevo(False)
    End Sub

    Private Sub RecuperarDocumentosMotorista()
        Me.txtDUI.Text = ""
        Me.txtLICENCIA.Text = ""
        If Me.cbxMOTORISTA.Value IsNot Nothing AndAlso IsNumeric(Me.cbxMOTORISTA.Value) Then
            Dim lMotorista As MOTORISTA = (New cMOTORISTA).ObtenerMOTORISTA(Me.cbxMOTORISTA.Value)
            If lMotorista IsNot Nothing Then
                Me.txtDUI.Text = lMotorista.DUI
                If lMotorista.LICENCIA.Trim.Length <> 14 Then
                    Me.txtLICENCIA.Text = Utilerias.RellenarIzquierda(lMotorista.LICENCIA.Trim, 14, "0")
                Else
                    Me.txtLICENCIA.Text = lMotorista.LICENCIA
                End If

            End If
        End If
    End Sub

    Protected Sub cbxMOTORISTA_ValueChanged(sender As Object, e As EventArgs) Handles cbxMOTORISTA.ValueChanged
        Me.RecuperarDocumentosMotorista()
    End Sub

    Private Function ObtenerCantidadMaximaCombustible() As Decimal
        Dim lProductoTipo As PRODUCTO_TIPO_TRANS

        If Me.rbtlTIPO_PROVEEDOR.Value = 5 AndAlso Me.cbxPLACAVEHIC.SelectedItem IsNot Nothing AndAlso (Me.cbxPRODUCTO.Value = 1 OrElse Me.cbxPRODUCTO.Value = 2) Then
            lProductoTipo = (New cPRODUCTO_TIPO_TRANS).ObtenerPorTRANSPORTE(Me.cbxPLACAVEHIC.Value)
            If lProductoTipo IsNot Nothing Then
                Return lProductoTipo.CANTIDAD_AUTO
            End If
            Return 0
        Else
            Return 0
        End If
    End Function

    Private Function ObtenerPrecioProducto(ByVal ID_PRODUCTO As Int32) As Decimal
        Dim lProducto As PRODUCTO_COMBUSTIBLE = (New cPRODUCTO_COMBUSTIBLE).ObtenerPRODUCTO_COMBUSTIBLE(ID_PRODUCTO)
        If lProducto IsNot Nothing Then
            Return lProducto.PRECIO_VENTA
        End If
        Return 0
    End Function

    Protected Sub cbxPLACAVEHIC_ValueChanged(sender As Object, e As EventArgs) Handles cbxPLACAVEHIC.ValueChanged
        If Me.ObtenerCantidadMaximaCombustible > 0 Then Me.speCANTIDAD.Value = Me.ObtenerCantidadMaximaCombustible
        Me.TotalDetalle()
    End Sub

    Protected Sub cbxPRODUCTO_ValueChanged(sender As Object, e As EventArgs) Handles cbxPRODUCTO.ValueChanged
        If Me.ObtenerCantidadMaximaCombustible > 0 Then Me.speCANTIDAD.Value = Me.ObtenerCantidadMaximaCombustible Else Me.speCANTIDAD.Value = Nothing
        If cbxPRODUCTO.Value IsNot Nothing AndAlso IsNumeric(cbxPRODUCTO.Value) Then
            Me.spePRECION_UNITARIO.Value = ObtenerPrecioProducto(Me.cbxPRODUCTO.Value)
        End If
        Me.speCANTIDAD.Focus()
    End Sub

    Protected Sub speCANTIDAD_ValueChanged(sender As Object, e As EventArgs) Handles speCANTIDAD.ValueChanged
        TotalDetalle()
        Me.spePRECION_UNITARIO.Focus()
    End Sub

    Protected Sub spePRECION_UNITARIO_ValueChanged(sender As Object, e As EventArgs) Handles spePRECION_UNITARIO.ValueChanged
        TotalDetalle()
        Me.btnAgregarProducto.Focus()
    End Sub

    Private Sub TotalDetalle()
        Dim dTotal As Decimal = 0
        Dim dCantidad As Decimal = 0
        Dim dPrecioUnitario As Decimal = 0

        If IsNumeric(Me.speCANTIDAD.Value) AndAlso IsNumeric(Me.spePRECION_UNITARIO.Value) Then
            dCantidad = Convert.ToDecimal(Me.speCANTIDAD.Value)
            dPrecioUnitario = Convert.ToDecimal(Me.spePRECION_UNITARIO.Value)
            Me.speTOTAL.Value = Math.Round(dCantidad * dPrecioUnitario, 2)
        End If
    End Sub

    Protected Sub txtID_ORDEN_COMBUS_ValueChanged(sender As Object, e As EventArgs) Handles txtID_ORDEN_COMBUS.ValueChanged
        If TIPO_OPERACION = TipoOperacion.Facturacion OrElse TIPO_OPERACION = TipoOperacion.Anulacion Then
            Dim lOrdenCombustible As ORDEN_COMBUSTIBLE
            Dim bOrdenCombustible As New cORDEN_COMBUSTIBLE

            bOrdenCombustible.ActualizarPorLoteORDEN_COMSUSTIBLE()

            If Me.txtID_ORDEN_COMBUS.Text.Trim <> String.Empty Then
                Me.txtID_ORDEN_COMBUS.Text = Me.txtID_ORDEN_COMBUS.Text.Trim
                If Not IsNumeric(Me.txtID_ORDEN_COMBUS.Text) Then
                    Me.Enabled = False
                    Me.ID_ORDEN_COMBUS = 0
                    Me.txtID_ORDEN_COMBUS.Text = ""
                    Me.txtID_ORDEN_COMBUS.Focus()
                    Exit Sub
                End If
                lOrdenCombustible = bOrdenCombustible.ObtenerORDEN_COMBUSTIBLE(Convert.ToInt32(Me.txtID_ORDEN_COMBUS.Text))
                If lOrdenCombustible IsNot Nothing Then
                    If TIPO_OPERACION = TipoOperacion.Facturacion AndAlso lOrdenCombustible.ESTADO = "A" Then
                        Me.txtID_ORDEN_COMBUS.Text = ""
                        AsignarMensaje("La orden ha sido anulada. Consultela en la opcion Anulacion", False, True, True)
                        Return
                    End If
                    Me.Enabled = False
                    Me.ID_ORDEN_COMBUS = lOrdenCombustible.ID_ORDEN_COMBUS
                    If TIPO_OPERACION = TipoOperacion.Facturacion AndAlso lOrdenCombustible.ESTADO = "E" Then
                        Me.txtNO_FACTURA_CCF.ClientEnabled = True
                        Me.dteFECHA_DESPACHO.ClientEnabled = True
                        Me.speTOTAL.ClientEnabled = True
                    ElseIf TIPO_OPERACION = TipoOperacion.Anulacion Then
                        Me.trFACTURA1.Visible = (lOrdenCombustible.NO_FACTURA_CCF <> "")
                        Me.trFACTURA2.Visible = (lOrdenCombustible.NO_FACTURA_CCF <> "")
                        Me.txtMOTIVO_ANULACION.ClientEnabled = (lOrdenCombustible.ESTADO <> "A")
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub cbxMOTORISTA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMOTORISTA.SelectedIndexChanged

    End Sub
End Class
