Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCCF_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CCF_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	27/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCCF_ENCA_TRANS
    Inherits ucBase

#Region "Propiedades"

    Private _ID_CCF_TRANS As Int32
    Public Property ID_CCF_TRANS() As Int32
        Get
            If Me.ViewState("ID_CCF_TRANS") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_CCF_TRANS"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_CCF_TRANS") = Value
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

    Public Property SUB_TOTAL() As Decimal
        Get
            If Me.speSUB_TOTAL.Text.Trim = "" Then
                Return 0
            End If
            Return Convert.ToDecimal(Me.speSUB_TOTAL.Value)
        End Get
        Set(ByVal value As Decimal)
            Me.speSUB_TOTAL.Value = value
        End Set
    End Property
    Public Property IVA() As Decimal
        Get
            If Me.speIVA.Text.Trim = "" Then
                Return 0
            End If
            Return Convert.ToDecimal(Me.speIVA.Value)
        End Get
        Set(ByVal value As Decimal)
            Me.speIVA.Value = value
        End Set
    End Property
    Public Property TOTAL() As Decimal
        Get
            If Me.speTOTAL.Text.Trim = "" Then
                Return 0
            End If
            Return Convert.ToDecimal(Me.speTOTAL.Value)
        End Get
        Set(ByVal value As Decimal)
            Me.speTOTAL.Value = value
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCCF_ENCA_TRANS
    Private mEntidad As CCF_ENCA_TRANS
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

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_CCF_TRANS") Is Nothing Then Me._ID_CCF_TRANS = Me.ViewState("ID_CCF_TRANS")
        Me.CargarProductos()
        Me.SetearSubTotalIvaTotal()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CCF_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lSolicitud As SOLIC_ENCA_TRANS
        Dim lProveedorAgri As PROVEEDOR_AGRICOLA

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")

        mEntidad = New CCF_ENCA_TRANS
        mEntidad.ID_CCF_TRANS = ID_CCF_TRANS

        If mComponente.ObtenerCCF_ENCA_TRANS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CCF_TRANS.Text = mEntidad.ID_CCF_TRANS.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA

        Me.speNUM_SOLICITUD.Value = Nothing
        If mEntidad.ID_SOLICITUD <> -1 Then
            lSolicitud = (New cSOLIC_ENCA_TRANS).ObtenerSOLIC_ENCA_TRANS(mEntidad.ID_SOLICITUD)
            If lSolicitud IsNot Nothing Then
                Me.speNUM_SOLICITUD.Value = lSolicitud.NUM_SOLIC_ZAFRA
            End If
        End If
        Me.cbxTIPO_FINANCIAMIENTO.Value = mEntidad.ID_CUENTA_FINAN
        Me.cbxPROVEEDOR_AGRICOLA.Value = mEntidad.ID_PROVEE
        lProveedorAgri = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(mEntidad.ID_PROVEE)
        If lProveedorAgri IsNot Nothing AndAlso Utilerias.EsDADA_Y_CIA(lProveedorAgri.NOMBRE) Then
            Me.trCESC.Visible = True
        Else
            Me.trCESC.Visible = False
        End If
        Me.cbxCONDICION_COMPRA.Value = mEntidad.CONDI_COMPRA
        Me.cbxTIPO_COMPROB.Value = mEntidad.ID_TIPO_COMPROB
        Me.txtNO_COMPROB.Text = mEntidad.NO_CCF
        Me.dteFECHA_COMPROB.Date = mEntidad.FECHA
        Me.speCODTRANSPORT.Value = mEntidad.CODTRANSPORT
        Me.CargarInfoTransportista(mEntidad.CODTRANSPORT)
        Me.speDESCTO_PORC.Value = mEntidad.DESCTO_PORC
        Me.speDESCTO_MONTO.Value = mEntidad.DESCTO_MONTO
        Me.speCESC.Value = mEntidad.CESC
        Me.LISTA_CCF_DETA_TRANS = (New cCCF_DETA_TRANS).ObtenerListaPorCCF_ENCA_TRANS(mEntidad.ID_CCF_TRANS)
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaCCF_DETA_TRANS1.PermitirEditarInline = False
        Me.ucListaCCF_DETA_TRANS1.PermitirEditarInline2 = False
        Me.ucListaCCF_DETA_TRANS1.PermitirEliminar = False
        Me.ucListaCCF_DETA_TRANS1.Visible = True
    End Sub


    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaCCF_DETA_TRANS1.CargarDatosCache(Me.lblREFERENCIA.Text)
            Me.SetearSubTotalIvaTotal()
        End If
    End Sub

    Public Sub SetearSubTotalIvaTotal()

        Dim dSubTOTAL As Decimal = 0
        Dim dDescuento As Decimal = 0
        Dim dSumas As Decimal = 0
        Dim dSumaAplicaCESC As Decimal = 0
        Dim dCESC As Decimal = 0
        Dim dIva As Decimal = 0
        Dim dTotal As Decimal = 0
        Dim listaProd As listaCCF_DETA_TRANS = Me.LISTA_CCF_DETA_TRANS
        Dim lEntidad As PRODUCTO


        If listaProd IsNot Nothing AndAlso listaProd.Count > 0 Then
            For Each lProducto As CCF_DETA_TRANS In listaProd
                dSubTOTAL += lProducto.TOTAL

                lEntidad = (New cPRODUCTO).ObtenerPRODUCTO(lProducto.ID_PRODUCTO)
                If lEntidad IsNot Nothing AndAlso lEntidad.APLICA_CESC Then
                    dSumaAplicaCESC += lProducto.TOTAL
                End If
            Next
        End If
        dSubTOTAL = Math.Round(dSubTOTAL, 2)
        dCESC = Math.Round(dSumaAplicaCESC * Utilerias.ImpuestoCESC, 2)
        'dCESC = If(Me.speCESC.Value = Nothing, CDec(0), Math.Round(CDec(Me.speCESC.Value), 5))
        dDescuento = Math.Round(dSubTOTAL * If(Me.speDESCTO_PORC.Value = Nothing, CDec(0), CDec(Me.speDESCTO_PORC.Value) / CDec(100)), 2)
        dSumas = dSubTOTAL - dDescuento
        dIva = Math.Round(dSumas * Utilerias.TasaIva, 2)
        dTotal = Math.Round(dSumas, 2) + dIva + dCESC

        Me.speSUB_TOTAL.Value = dSubTOTAL
        Me.speDESCTO_MONTO.Value = dDescuento
        Me.speSUMAS.Value = dSumas
        Me.speCESC.Value = dCESC
        Me.speIVA.Value = dIva
        Me.speTOTAL.Value = dTotal
    End Sub

    Public Property LISTA_CCF_DETA_TRANS As listaCCF_DETA_TRANS
        Set(value As listaCCF_DETA_TRANS)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaCCF_DETA_TRANS) Else Return New listaCCF_DETA_TRANS
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_CCF_TRANS.ClientEnabled = False
        Me.cbxZAFRA.ClientEnabled = False
        Me.speNUM_SOLICITUD.ClientEnabled = _nuevo
        Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = _nuevo
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = _nuevo
        Me.cbxTIPO_COMPROB.ClientEnabled = edicion
        Me.txtNO_COMPROB.ClientEnabled = edicion
        Me.dteFECHA_COMPROB.ClientEnabled = edicion
        Me.speCODTRANSPORT.ClientEnabled = _nuevo
        Me.txtNOMBRE_TRANSPORTISTA.ClientEnabled = False
        Me.cbxCONDICION_COMPRA.ClientEnabled = edicion
        Me.trPRODUCTO_AGRICOLA_DETA1.Visible = _nuevo
        Me.trPRODUCTO_AGRICOLA_DETA2.Visible = _nuevo
        Me.ucListaCCF_DETA_TRANS1.PermitirEditar = _nuevo
        Me.ucListaCCF_DETA_TRANS1.PermitirEditarInline = _nuevo
        Me.ucListaCCF_DETA_TRANS1.PermitirEditarInline2 = _nuevo
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.speNUM_SOLICITUD.Value = Nothing
        Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
        Me.cbxPROVEEDOR_AGRICOLA.Value = Nothing
        Me.cbxTIPO_COMPROB.Value = Nothing
        Me.txtNO_COMPROB.Text = ""
        Me.dteFECHA_COMPROB.Value = Nothing
        Me.speCODTRANSPORT.Value = Nothing
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.txtNIT.Text = ""
        Me.txtNRC.Text = ""
        Me.cbxCONDICION_COMPRA.Value = Nothing

        Me.cbxPRODUCTOdeta.Value = Nothing
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Value = Nothing
        Me.spePRECIO_UNITARIOdeta.Value = Nothing
        Me.speSUB_TOTALdeta.Value = Nothing

        Me.LISTA_CCF_DETA_TRANS = New listaCCF_DETA_TRANS
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()
        trCESC.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CCF_ENCA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim listaSolicitud As listaSOLIC_ENCA_TRANS
        Dim listaDetalle As listaCCF_DETA_TRANS
        Dim bDocumentoDeta As New cCCF_DETA_TRANS
        Dim dbUtil As New SISPACAL.DL.dbUtilidades

        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CCF_ENCA_TRANS
        If Me._nuevo Then
            mEntidad.ID_CCF_TRANS = 0
            mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            mEntidad.FECHA_CREACION = cFechaHora.ObtenerFecha
        Else
            mEntidad = mComponente.ObtenerCCF_ENCA_TRANS(Me.ID_CCF_TRANS)
        End If

        If Me.cbxZAFRA.Value Is Nothing Then
            Return "* Seleccione la Zafra"
        End If
        If Me.speNUM_SOLICITUD.Text = "" Then
            Return "* Ingrese el Numero de Solicitud"
        End If
        If Me.cbxPROVEEDOR_AGRICOLA.Value Is Nothing Then
            Return "* Seleccione el Proveedor"
        End If
        If Me.cbxTIPO_FINANCIAMIENTO.Value Is Nothing Then
            Return "* Seleccione el Tipo de Financiamiento"
        End If
        If Me.cbxTIPO_COMPROB.Value Is Nothing Then
            Return "* Seleccione el Tipo de Comprobante"
        End If
        If Me.txtNO_COMPROB.Text = "" Then
            Return "* Ingrese el No. de Comprobante"
        End If
        If Me.dteFECHA_COMPROB.Value Is Nothing Then
            Return "* Ingrese la Fecha del Comprobante"
        End If
        If Me.cbxCONDICION_COMPRA.Value Is Nothing Then
            Return "* Seleccione la Condicion de Compra"
        End If

        listaDetalle = Me.LISTA_CCF_DETA_TRANS
        If listaDetalle Is Nothing OrElse listaDetalle.Count = 0 Then
            Return "* No se encontro detalle de productos en el comprobante"
        End If
        Dim dCantidad As Decimal = 0
        Dim dTotal As Decimal = 0
        For j As Int32 = 0 To listaDetalle.Count - 1
            If listaDetalle(j).CANTIDAD > 0 Then
                dCantidad += listaDetalle(j).CANTIDAD
                dTotal += listaDetalle(j).TOTAL
            End If
        Next
        If dCantidad = 0 Then
            Return "* No se encontro cantidad de productos facturados"
        End If

        If Me._nuevo Then
            mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
            listaSolicitud = (New cSOLIC_ENCA_TRANS).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.speNUM_SOLICITUD.Value, -1, -1, "")
            If listaSolicitud IsNot Nothing AndAlso listaSolicitud.Count > 0 Then
                mEntidad.ID_SOLICITUD = listaSolicitud(0).ID_SOLICITUD
                mEntidad.ID_CUENTA_FINAN = listaSolicitud(0).ID_CUENTA_FINAN
            Else
                Return "* No se encontro la solicitud N°: " + Me.speNUM_SOLICITUD.Text + " de la Zafra: " + Me.cbxZAFRA.Text
            End If
            mEntidad.ID_CUENTA_FINAN = Me.cbxTIPO_FINANCIAMIENTO.Value
            mEntidad.ID_TIPO_COMPROB = Me.cbxTIPO_COMPROB.Value
            mEntidad.UID_CCF = Guid.NewGuid
            mEntidad.NO_CCF = Me.txtNO_COMPROB.Text
            mEntidad.FECHA = Me.dteFECHA_COMPROB.Date
            mEntidad.CODTRANSPORT = listaSolicitud(0).CODTRANSPORT
            mEntidad.SUB_TOTAL = CDec(Me.speSUB_TOTAL.Value)
            mEntidad.DESCTO_PORC = If(Me.speDESCTO_PORC.Value Is Nothing, 0, CDec(Me.speDESCTO_PORC.Value))
            mEntidad.DESCTO_MONTO = CDec(Me.speDESCTO_MONTO.Value)
            mEntidad.SUMAS = CDec(Me.speSUMAS.Value)
            mEntidad.CESC = CDec(Me.speCESC.Value)
            mEntidad.IVA = CDec(speIVA.Value)
            mEntidad.TOTAL = CDec(speTOTAL.Value)
            mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value
            mEntidad.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLA.Value

            If mComponente.ActualizarCCF_ENCA_TRANS(mEntidad) < 0 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If

            For Each lEntidad As CCF_DETA_TRANS In listaDetalle
                If lEntidad.CANTIDAD > 0 Then
                    lEntidad.ID_CCF_DETA_TRANS = If(Me._nuevo, 0, lEntidad.ID_CCF_DETA_TRANS)
                    lEntidad.ID_CCF_TRANS = mEntidad.ID_CCF_TRANS
                    bDocumentoDeta.ActualizarCCF_DETA_TRANS(lEntidad)
                End If
            Next
        Else
            mEntidad.ID_TIPO_COMPROB = Me.cbxTIPO_COMPROB.Value
            mEntidad.NO_CCF = Me.txtNO_COMPROB.Text
            mEntidad.FECHA = Me.dteFECHA_COMPROB.Date
            mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value
            mEntidad.SUB_TOTAL = CDec(Me.speSUB_TOTAL.Value)
            mEntidad.DESCTO_PORC = If(Me.speDESCTO_PORC.Value Is Nothing, 0, CDec(Me.speDESCTO_PORC.Value))
            mEntidad.DESCTO_MONTO = CDec(Me.speDESCTO_MONTO.Value)
            mEntidad.SUMAS = CDec(Me.speSUMAS.Value)
            mEntidad.CESC = CDec(Me.speCESC.Value)
            mEntidad.IVA = CDec(speIVA.Value)
            mEntidad.TOTAL = CDec(speTOTAL.Value)

            If mComponente.ActualizarCCF_ENCA_TRANS(mEntidad) < 0 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If

            For Each lEntidad As CCF_DETA_TRANS In listaDetalle
                If lEntidad.CANTIDAD > 0 Then
                    lEntidad.ID_CCF_DETA_TRANS = If(Me._nuevo, 0, lEntidad.ID_CCF_DETA_TRANS)
                    lEntidad.ID_CCF_TRANS = mEntidad.ID_CCF_TRANS
                    bDocumentoDeta.ActualizarCCF_DETA_TRANS(lEntidad)
                End If
            Next
        End If

        Me.txtID_CCF_TRANS.Text = mEntidad.ID_CCF_TRANS.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub speCODIPROVEE_ValueChanged(sender As Object, e As EventArgs) Handles speCODTRANSPORT.ValueChanged
        Me.CargarInfoTransportista(speCODTRANSPORT.Value)
    End Sub

    Private Sub CargarInfoTransportista(ByVal sCODTRANSPORT As String)
        Dim lTransportista As TRANSPORTISTA
        lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(sCODTRANSPORT)
        If lTransportista IsNot Nothing Then
            Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
            Me.txtNIT.Text = lTransportista.NIT
            Me.txtNRC.Text = lTransportista.CREDITO_FISCAL
        Else
            Me.txtNOMBRE_TRANSPORTISTA.Text = ""
            Me.txtNIT.Text = ""
            Me.txtNRC.Text = ""
        End If
    End Sub

    Private Sub CargarProductos()
        Dim idCuentaFinan As Int32 = 0
        Dim lista As listaPRODUCTO

        If Me.cbxTIPO_FINANCIAMIENTO.Value IsNot Nothing Then idCuentaFinan = Me.cbxTIPO_FINANCIAMIENTO.Value
        lista = (New cPRODUCTO).ObtenerListaPorCriterios(-1, -1, idCuentaFinan, -1, 1, -1, "NOMBRE_PRODUCTO")
        If Not (lista IsNot Nothing AndAlso lista.Count > 0) Then
            lista = New listaPRODUCTO
        End If
        Me.cbxPRODUCTOdeta.DataSource = lista
        Me.cbxPRODUCTOdeta.DataBind()
    End Sub

    Protected Sub cbxPRODUCTOdeta_ValueChanged(sender As Object, e As EventArgs) Handles cbxPRODUCTOdeta.ValueChanged
        If Me.cbxPRODUCTOdeta.Value IsNot Nothing AndAlso Me.cbxPRODUCTOdeta.SelectedIndex >= 0 Then
            Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(Me.cbxPRODUCTOdeta.Value)
            If lProducto IsNot Nothing Then
                Me.txtPRESENTACIONdeta.Text = lProducto.PRESENTACION
                Me.spePRECIO_UNITARIOdeta.Value = lProducto.PRECIO_UNITARIO
            End If
        End If
        Me.CalcularSubTotal()
        Me.txtPRESENTACIONdeta.Focus()
    End Sub

    Private Sub CalcularSubTotal()
        Me.speSUB_TOTALdeta.Value = Me.speCANTIDADdeta.Value * Me.spePRECIO_UNITARIOdeta.Value
    End Sub

    Protected Sub spePRECIO_UNITARIOdeta_ValueChanged(sender As Object, e As EventArgs) Handles spePRECIO_UNITARIOdeta.ValueChanged
        Me.CalcularSubTotal()
        Me.btnAgregarProducto.Focus()
    End Sub

    Protected Sub speCANTIDADdeta_ValueChanged(sender As Object, e As EventArgs) Handles speCANTIDADdeta.ValueChanged
        Me.CalcularSubTotal()
        Me.spePRECIO_UNITARIOdeta.Focus()
    End Sub

    Protected Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim lCCFDeta As New CCF_DETA_TRANS
        Dim lProducto As PRODUCTO

        If Me.cbxPRODUCTOdeta.Text = "" Then
            Me.AsignarMensaje("* Seleccione o Ingrese el Producto", True, False)
            Return
        End If
        If Me.speCANTIDADdeta.Value = 0 Then
            Me.AsignarMensaje("* Ingrese la Cantidad de Producto", True, False)
            Return
        End If
        If Me.spePRECIO_UNITARIOdeta.Value Is Nothing Then
            Me.AsignarMensaje("* Ingrese el Precio Unitario del Producto", True, False)
            Return
        End If

        lCCFDeta.ID_CCF_DETA_TRANS = Me.ObtenerIdProd(Me.LISTA_CCF_DETA_TRANS)
        lCCFDeta.ID_CCF_TRANS = 0
        lCCFDeta.ID_PRODUCTO = If(Me.cbxPRODUCTOdeta.SelectedIndex >= 0, Me.cbxPRODUCTOdeta.Value, -1)
        If lCCFDeta.ID_PRODUCTO <> -1 Then
            lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lCCFDeta.ID_PRODUCTO)
            If lProducto IsNot Nothing Then
                lCCFDeta.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
            End If
        Else
            lCCFDeta.NOMBRE_PRODUCTO = Me.cbxPRODUCTOdeta.Text.ToUpper
        End If
        lCCFDeta.CANTIDAD = Me.speCANTIDADdeta.Value
        lCCFDeta.PRECIO_UNITARIO = Me.spePRECIO_UNITARIOdeta.Value
        lCCFDeta.TOTAL = Me.speSUB_TOTALdeta.Value
        lCCFDeta.PRESENTACION = Me.txtPRESENTACIONdeta.Text.ToUpper
        lCCFDeta.REFERENCIA = Me.lblREFERENCIA.Text

        Me.LISTA_CCF_DETA_TRANS.Add(lCCFDeta)
        Me.CargarDetalleDocumentoEnca()
        Me.AsignarMensaje("", True, False)

        Me.cbxPRODUCTOdeta.SelectedIndex = -1
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Text = ""
        Me.spePRECIO_UNITARIOdeta.Text = ""
        Me.speSUB_TOTALdeta.Text = ""
        Me.cbxPRODUCTOdeta.Focus()
        Me.SetearSubTotalIvaTotal()
    End Sub

    Private Function ObtenerIdProd(ByVal lista As listaCCF_DETA_TRANS) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_CCF_DETA_TRANS > Id Then
                Id = lista(i).ID_CCF_DETA_TRANS
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub ucListaCCF_DETA_TRANS1_Eliminando(ID_CCF_DETA As Integer) Handles ucListaCCF_DETA_TRANS1.Eliminando
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub speNUM_SOLICITUD_ValueChanged(sender As Object, e As EventArgs) Handles speNUM_SOLICITUD.ValueChanged
        Dim listaSolic As listaSOLIC_ENCA_TRANS
        Dim lTransportista As TRANSPORTISTA
      
        Me.cbxPROVEEDOR_AGRICOLA.SelectedIndex = -1

        listaSolic = (New cSOLIC_ENCA_TRANS).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.speNUM_SOLICITUD.Value, -1, -1, "")
        If listaSolic IsNot Nothing AndAlso listaSolic.Count > 0 Then
            If listaSolic(0).ID_ESTADO_SOLIC = Enumeradores.EstadoSolicAgricola.Aceptada Then
                lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(listaSolic(0).CODTRANSPORT)

                Me.cbxTIPO_FINANCIAMIENTO.Value = listaSolic(0).ID_CUENTA_FINAN
                Me.speCODTRANSPORT.Value = listaSolic(0).CODTRANSPORT
                Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
                Me.txtNIT.Text = lTransportista.NIT
                Me.txtNRC.Text = lTransportista.CREDITO_FISCAL
                Me.speCESC.Value = listaSolic(0).CESC
                Me.LISTA_CCF_DETA_TRANS = New listaCCF_DETA_TRANS

                Dim lstSolicProd As listaSOLIC_PROD_TRANS = (New cSOLIC_PROD_TRANS).ObtenerListaPorSOLIC_ENCA_TRANS(listaSolic(0).ID_SOLICITUD)
                If lstSolicProd IsNot Nothing AndAlso lstSolicProd.Count > 0 Then

                    Me.cbxPROVEEDOR_AGRICOLA.Value = lstSolicProd(0).ID_PROVEE

                    For Each lEntiSoliProd As SOLIC_PROD_TRANS In lstSolicProd
                        Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(lEntiSoliProd.ID_PRODUCTO)
                        Dim lDetaCCF As New CCF_DETA_TRANS
                        lDetaCCF.ID_CCF_DETA_TRANS = Me.ObtenerIdProd(Me.LISTA_CCF_DETA_TRANS)
                        lDetaCCF.ID_CCF_TRANS = 0
                        lDetaCCF.ID_PRODUCTO = lEntiSoliProd.ID_PRODUCTO
                        lDetaCCF.NOMBRE_PRODUCTO = lEntiSoliProd.NOMBRE_PRODUCTO
                        lDetaCCF.PRESENTACION = lEntiSoliProd.PRESENTACION
                        lDetaCCF.CANTIDAD = lEntiSoliProd.CANTIDAD
                        lDetaCCF.PRECIO_UNITARIO = lEntiSoliProd.PRECIO_UNITARIO
                        lDetaCCF.TOTAL = lEntiSoliProd.SUB_TOTAL
                        If lProducto IsNot Nothing Then
                            Me.speDESCTO_PORC.Value = lProducto.PORC_SUBSIDIO
                        Else
                            Me.speDESCTO_PORC.Value = 0
                        End If
                        Me.LISTA_CCF_DETA_TRANS.Add(lDetaCCF)
                    Next
                    Me.CargarDetalleDocumentoEnca()
                    Me.SetearSubTotalIvaTotal()
                End If

                Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = False
                Me.speCODTRANSPORT.ClientEnabled = False
                cbxPROVEEDOR_AGRICOLA_ValueChanged(sender, e)
            Else
                Me.AsignarMensaje("La solicitud No. " + Me.speNUM_SOLICITUD.Value.ToString + " no se encuentra ACEPTADA por finanzas", False, True, True)
                Me.speNUM_SOLICITUD.Value = Nothing
                Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
                Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = True
                Me.speCODTRANSPORT.Value = Nothing
                Me.speCODTRANSPORT.ClientEnabled = True
                Me.txtNOMBRE_TRANSPORTISTA.Text = ""
            End If
        Else
            Me.AsignarMensaje("La solicitud No. " + Me.speNUM_SOLICITUD.Value.ToString + " no existe en la zafra " + Me.cbxZAFRA.Text, False, True, True)
            Me.speNUM_SOLICITUD.Value = Nothing
            Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
            Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = True
            Me.speCODTRANSPORT.Value = Nothing
            Me.speCODTRANSPORT.ClientEnabled = True
            Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        End If
    End Sub

    Protected Sub speDESCTO_PORC_ValueChanged(sender As Object, e As EventArgs) Handles speDESCTO_PORC.ValueChanged, speCESC.ValueChanged
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub cbxPROVEEDOR_AGRICOLA_ValueChanged(sender As Object, e As EventArgs) Handles cbxPROVEEDOR_AGRICOLA.ValueChanged
        If cbxPROVEEDOR_AGRICOLA.Value IsNot Nothing AndAlso Utilerias.EsDADA_Y_CIA(cbxPROVEEDOR_AGRICOLA.Text) Then
            trCESC.Visible = True
        Else
            trCESC.Visible = False
        End If
    End Sub

    Protected Sub speNUM_SOLICITUD_NumberChanged(sender As Object, e As EventArgs) Handles speNUM_SOLICITUD.NumberChanged

    End Sub
End Class
