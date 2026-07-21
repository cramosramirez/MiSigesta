Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCCF_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CCF_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCCF_ENCA
    Inherits ucBase

#Region "Propiedades"

    Private _ID_CCF_ENCA As Int32
    Public Property ID_CCF_ENCA() As Int32
        Get
            If Me.ViewState("ID_CCF_ENCA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_CCF_ENCA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_CCF_ENCA") = Value
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

    Public Property CONCEPTO_CCF As Enumeradores.CCFConcepto
        Get
            If Me.ViewState("CCFConcepto") IsNot Nothing Then
                Return CInt(Me.ViewState("CCFConcepto"))
            Else
                Return Enumeradores.CCFConcepto.Ninguno
            End If
        End Get
        Set(value As Enumeradores.CCFConcepto)
            Me.ViewState("CCFConcepto") = value
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
    Private mComponente As New cCCF_ENCA
    Private mEntidad As CCF_ENCA
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
        If Not Me.ViewState("ID_CCF_ENCA") Is Nothing Then Me._ID_CCF_ENCA = Me.ViewState("ID_CCF_ENCA")
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
        Dim lSolicitud As SOLIC_AGRICOLA
        Dim lOrdenCompra As ORDEN_COMPRA_AGRI

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")

        mEntidad = New CCF_ENCA
        mEntidad.ID_CCF_ENCA = ID_CCF_ENCA

        If mComponente.ObtenerCCF_ENCA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CCF_ENCA.Text = mEntidad.ID_CCF_ENCA.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA

        Me.speNUM_SOLICITUD.Value = Nothing
        If mEntidad.ID_SOLICITUD <> -1 Then
            lSolicitud = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(mEntidad.ID_SOLICITUD)
            If lSolicitud IsNot Nothing Then
                Me.speNUM_SOLICITUD.Value = lSolicitud.NUM_SOLICITUD
            End If
        End If
        Me.cbxTIPO_FINANCIAMIENTO.Value = mEntidad.ID_CUENTA_FINAN
        Me.CargarOrdenes(mEntidad.ID_SOLICITUD)
        Me.cbxORDEN_COMPRA.Value = mEntidad.ID_ORDEN
        Me.cbxPROVEEDOR_AGRICOLA.Value = mEntidad.ID_PROVEE
        Me.cbxCONDICION_COMPRA.Value = mEntidad.CONDI_COMPRA
        Me.cbxTIPO_COMPROB.Value = mEntidad.ID_TIPO_COMPROB
        Me.txtNO_COMPROB.Text = mEntidad.NO_CCF
        Me.dteFECHA_COMPROB.Date = mEntidad.FECHA
        Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(mEntidad.CODIPROVEEDOR)
        Me.CargarInfoProveedor(mEntidad.CODIPROVEEDOR)
        Me.speDESCTO_PORC.Value = mEntidad.DESCTO_PORC
        Me.speDESCTO_MONTO.Value = mEntidad.DESCTO_MONTO
        Me.speFOVIAL_COTRANS.Value = mEntidad.FOVIAL_COTRANS

        Me.LISTA_CCF_DETA = (New cCCF_DETA).ObtenerListaPorCCF_ENCA(mEntidad.ID_CCF_ENCA)
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaCCF_DETA1.PermitirEditarInline = False
        Me.ucListaCCF_DETA1.PermitirEditarInline2 = False
        Me.ucListaCCF_DETA1.PermitirEliminar = False
        Me.ucListaCCF_DETA1.Visible = True
        If mEntidad.USUARIO_CREACION = "7030" Then
            Me.chk70_30.Checked = True
        Else
            Me.chk70_30.Checked = False
        End If
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaCCF_DETA1.CargarDatosCache(Me.lblREFERENCIA.Text)
            Me.SetearSubTotalIvaTotal()
        End If
    End Sub

    Public Sub SetearSubTotalIvaTotal()

        Dim dSubTOTAL As Decimal = 0
        Dim dDescuento As Decimal = 0
        Dim dSumas As Decimal = 0
        Dim dIva As Decimal = 0
        Dim dTotal As Decimal = 0
        Dim listaProd As listaCCF_DETA = Me.LISTA_CCF_DETA
        Dim CantidadGalones As Decimal = 0

        If listaProd IsNot Nothing AndAlso listaProd.Count > 0 Then
            For Each lProducto As CCF_DETA In listaProd
                dSubTOTAL += lProducto.TOTAL
                If lProducto.NOMBRE_PRODUCTO.ToUpper.Contains("COMBUSTIBLE") Then CantidadGalones += lProducto.CANTIDAD
            Next
        End If
        dSubTOTAL = Math.Round(dSubTOTAL, 2)
        dDescuento = Math.Round(dSubTOTAL * If(Me.speDESCTO_PORC.Value = Nothing, CDec(0), CDec(Me.speDESCTO_PORC.Value) / CDec(100)), 2)
        dSumas = dSubTOTAL - dDescuento
        dIva = Math.Round(dSumas * Utilerias.TasaIva, 2)
        dTotal = Math.Round(dSumas, 2) + dIva + Math.Round(CantidadGalones * Enumeradores.ImpuestoGasolina.Fovial, 2) + _
               Math.Round(CantidadGalones * Enumeradores.ImpuestoGasolina.Cotrans, 2)

        Me.speSUB_TOTAL.Value = dSubTOTAL
        Me.speDESCTO_MONTO.Value = dDescuento
        Me.speSUMAS.Value = dSumas
        Me.speIVA.Value = dIva
        Me.speFOVIAL_COTRANS.Value = Math.Round(CantidadGalones * Enumeradores.ImpuestoGasolina.Fovial, 2) + _
               Math.Round(CantidadGalones * Enumeradores.ImpuestoGasolina.Cotrans, 2)
        Me.speTOTAL.Value = dTotal
    End Sub

    Public Property LISTA_CCF_DETA As listaCCF_DETA
        Set(value As listaCCF_DETA)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaCCF_DETA) Else Return New listaCCF_DETA
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
        Me.txtID_CCF_ENCA.ClientEnabled = False
        Me.cbxZAFRA.ClientEnabled = _nuevo
        Me.speNUM_SOLICITUD.ClientEnabled = _nuevo
        If (Me.CONCEPTO_CCF = Enumeradores.CCFConcepto.AplicacionVuelo) Then
            Me.cbxORDEN_COMPRA.ClientEnabled = False
        Else
            Me.cbxORDEN_COMPRA.ClientEnabled = _nuevo
        End If
        Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = False
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = False
        Me.cbxTIPO_COMPROB.ClientEnabled = edicion
        Me.txtNO_COMPROB.ClientEnabled = edicion
        Me.dteFECHA_COMPROB.ClientEnabled = edicion
        Me.speCODIPROVEE.ClientEnabled = False
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.cbxCONDICION_COMPRA.ClientEnabled = edicion
        Me.chk70_30.ClientEnabled = edicion
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
        Me.cbxORDEN_COMPRA.Value = Nothing
        Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
        Me.cbxPROVEEDOR_AGRICOLA.Value = Nothing
        Me.cbxTIPO_COMPROB.Value = Nothing
        Me.txtNO_COMPROB.Text = ""
        Me.dteFECHA_COMPROB.Value = Nothing
        Me.speCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtNIT.Text = ""
        Me.txtNRC.Text = ""
        Me.txtACTIVIDAD.Text = ""
        Me.cbxCONDICION_COMPRA.Value = Nothing

        Me.cbxPRODUCTOdeta.Value = Nothing
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Value = Nothing
        Me.spePRECIO_UNITARIOdeta.Value = Nothing
        Me.speSUB_TOTALdeta.Value = Nothing
        Me.speFOVIAL_COTRANS.Value = Nothing
        Me.chk70_30.Checked = False

        Me.LISTA_CCF_DETA = New listaCCF_DETA
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()

        Select Case Me.CONCEPTO_CCF
            Case Enumeradores.CCFConcepto.AplicacionVuelo
                Me.cbxORDEN_COMPRA.SelectedIndex = -1
                Me.cbxPROVEEDOR_AGRICOLA.Value = 4
        End Select
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
        Dim listaSolicitud As listaSOLIC_AGRICOLA
        Dim listaDetalle As listaCCF_DETA
        Dim bDocumentoDeta As New cCCF_DETA
        Dim dbUtil As New SISPACAL.DL.dbUtilidades

        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CCF_ENCA
        If Me._nuevo Then
            mEntidad.ID_CCF_ENCA = 0
            mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            mEntidad.FECHA_CREACION = cFechaHora.ObtenerFecha
        Else
            mEntidad = mComponente.ObtenerCCF_ENCA(Me.ID_CCF_ENCA)
        End If

        If Me.cbxZAFRA.Value Is Nothing Then
            Return "* Seleccione la Zafra"
        End If
        If Me.speNUM_SOLICITUD.Text = "" Then
            Return "* Ingrese el Numero de Solicitud"
        End If
        If Me.cbxORDEN_COMPRA.ClientEnabled AndAlso Me.cbxORDEN_COMPRA.Value Is Nothing Then
            Return "* Seleccione la Orden de Compra"
        End If
        If Me.cbxPROVEEDOR_AGRICOLA.Value Is Nothing Then
            Return "* Seleccione el Proveedor/Casa Comercial"
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

        listaDetalle = Me.LISTA_CCF_DETA
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
            listaSolicitud = (New cSOLIC_AGRICOLA).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.speNUM_SOLICITUD.Value, "", "", "", "", Nothing, Nothing, "")
            If listaSolicitud IsNot Nothing AndAlso listaSolicitud.Count > 0 Then
                mEntidad.ID_SOLICITUD = listaSolicitud(0).ID_SOLICITUD
                mEntidad.ID_CUENTA_FINAN = listaSolicitud(0).ID_CUENTA_FINAN
            Else
                Return "* No se encontro la solicitud N°: " + Me.speNUM_SOLICITUD.Text + " de la Zafra: " + Me.cbxZAFRA.Text
            End If
            If Me.cbxORDEN_COMPRA.ClientEnabled Then
                mEntidad.ID_ORDEN = Me.cbxORDEN_COMPRA.Value
            Else
                mEntidad.ID_ORDEN = -1
            End If
            mEntidad.ID_CUENTA_FINAN = Me.cbxTIPO_FINANCIAMIENTO.Value
            mEntidad.ID_TIPO_COMPROB = Me.cbxTIPO_COMPROB.Value
            mEntidad.UID_REFERENCIA_CCF = Guid.NewGuid
            mEntidad.NO_CCF = Me.txtNO_COMPROB.Text
            mEntidad.FECHA = Me.dteFECHA_COMPROB.Date
            mEntidad.CODIPROVEEDOR = listaSolicitud(0).CODIPROVEEDOR
            mEntidad.SUB_TOTAL = CDec(Me.speSUB_TOTAL.Value)
            mEntidad.DESCTO_PORC = If(Me.speDESCTO_PORC.Value Is Nothing, 0, CDec(Me.speDESCTO_PORC.Value))
            mEntidad.DESCTO_MONTO = CDec(Me.speDESCTO_MONTO.Value)
            mEntidad.SUMAS = CDec(Me.speSUMAS.Value)
            mEntidad.IVA = CDec(speIVA.Value)
            mEntidad.TOTAL = CDec(speTOTAL.Value)
            mEntidad.FOVIAL_COTRANS = CDec(speFOVIAL_COTRANS.Value)
            mEntidad.TOTAL_LETRAS = dbUtil.ConvertirNumeroaLetras(CDec(speTOTAL.Value), "DOLARES")
            mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value
            mEntidad.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLA.Value
            mEntidad.CONCEPTO_CCF = Me.CONCEPTO_CCF
            If Me.chk70_30.Checked Then
                mEntidad.USUARIO_CREACION = "7030"
            Else
                mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            End If

            If mComponente.ActualizarCCF_ENCA(mEntidad) < 0 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If

            For Each lEntidad As CCF_DETA In listaDetalle
                If lEntidad.CANTIDAD > 0 Then
                    lEntidad.ID_CCF_DETA = If(Me._nuevo, 0, lEntidad.ID_CCF_DETA)
                    lEntidad.ID_CCF_ENCA = mEntidad.ID_CCF_ENCA
                    bDocumentoDeta.ActualizarCCF_DETA(lEntidad)
                End If
            Next
        Else
            If Me.chk70_30.Checked Then
                mEntidad.USUARIO_CREACION = "7030"
            Else
                mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            End If
            mEntidad.ID_TIPO_COMPROB = Me.cbxTIPO_COMPROB.Value
            mEntidad.NO_CCF = Me.txtNO_COMPROB.Text
            mEntidad.FECHA = Me.dteFECHA_COMPROB.Date
            mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value

            If mComponente.ActualizarCCF_ENCA(mEntidad) < 0 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If

        Me.txtID_CCF_ENCA.Text = mEntidad.ID_CCF_ENCA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub speCODIPROVEE_ValueChanged(sender As Object, e As EventArgs) Handles speCODIPROVEE.ValueChanged
        Me.CargarInfoProveedor(Utilerias.FormatearCODIPROVEEDOR(speCODIPROVEE.Value))
    End Sub

    Private Sub CargarInfoProveedor(ByVal sCODIPROVEEDOR As String)
        Dim lProveedor As PROVEEDOR
        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(sCODIPROVEEDOR)
        If lProveedor IsNot Nothing Then
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
            Me.txtNIT.Text = lProveedor.NIT
            Me.txtNRC.Text = lProveedor.CREDITFISCAL
            Me.txtACTIVIDAD.Text = lProveedor.ACTIVIDAD
        Else
            Me.txtNOMBRE_PROVEEDOR.Text = ""
            Me.txtNIT.Text = ""
            Me.txtNRC.Text = ""
            Me.txtACTIVIDAD.Text = ""
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
        Dim lCCFDeta As New CCF_DETA
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

        lCCFDeta.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA)
        lCCFDeta.ID_CCF_ENCA = 0
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
        lCCFDeta.UNIDAD = ""
        lCCFDeta.REFERENCIA = Me.lblREFERENCIA.Text

        Me.LISTA_CCF_DETA.Add(lCCFDeta)
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

    Private Function ObtenerIdProd(ByVal lista As listaCCF_DETA) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_CCF_DETA > Id Then
                Id = lista(i).ID_CCF_DETA
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub ucListaCCF_DETA1_Eliminando(ID_CCF_DETA As Integer) Handles ucListaCCF_DETA1.Eliminando
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub speNUM_SOLICITUD_ValueChanged(sender As Object, e As EventArgs) Handles speNUM_SOLICITUD.ValueChanged
        Dim listaSolic As listaSOLIC_AGRICOLA

        Me.cbxORDEN_COMPRA.DataSource = New listaORDEN_COMPRA_AGRI
        Me.cbxORDEN_COMPRA.DataBind()
        Me.cbxORDEN_COMPRA.SelectedIndex = -1
        Me.cbxPROVEEDOR_AGRICOLA.SelectedIndex = -1
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = False

        listaSolic = (New cSOLIC_AGRICOLA).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.speNUM_SOLICITUD.Value, "", "", "", "", Nothing, Nothing, "")
        If listaSolic IsNot Nothing AndAlso listaSolic.Count > 0 Then
            If listaSolic(0).ESTADO = Enumeradores.EstadoSolicAgricola.Aceptada Then
                If Me.CONCEPTO_CCF = Enumeradores.CCFConcepto.AplicacionVuelo Then
                    'Verificar que exista aplicación de vuelo para esta solicitud
                    Dim lSolicAplicaVuelo As listaSOLIC_APLICACION_VUELO = (New cSOLIC_APLICACION_VUELO).ObtenerListaPorSOLIC_AGRICOLA(listaSolic(0).ID_SOLICITUD)
                    If lSolicAplicaVuelo IsNot Nothing AndAlso lSolicAplicaVuelo.Count > 0 Then

                        If listaSolic(0).ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes Then
                            Me.cbxTIPO_FINANCIAMIENTO.Value = CInt(CuentaFinanciamiento.VuelosAereosMadurantes)
                        Else
                            Me.cbxTIPO_FINANCIAMIENTO.Value = CInt(CuentaFinanciamiento.VuelosAereosInhibidores)
                        End If
                        Me.cbxPROVEEDOR_AGRICOLA.Value = 4
                        Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(listaSolic(0).CODIPROVEEDOR)
                        Me.txtNOMBRE_PROVEEDOR.Text = listaSolic(0).NOMBRE_PROVEEDOR

                        Me.LISTA_CCF_DETA = New listaCCF_DETA

                        Dim lstProducto As listaPRODUCTO = (New cPRODUCTO).ObtenerListaPorNOMBRE_PRODUCTO("SERVICIO DE RIEGO (MZ)")
                        If lstProducto IsNot Nothing AndAlso lstProducto.Count > 0 Then
                            Dim lDetaCCF As New CCF_DETA
                            lDetaCCF.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA)
                            lDetaCCF.ID_CCF_ENCA = 0
                            lDetaCCF.ID_PRODUCTO = lstProducto(0).ID_PRODUCTO
                            lDetaCCF.NOMBRE_PRODUCTO = lstProducto(0).NOMBRE_PRODUCTO
                            lDetaCCF.UNIDAD = ""
                            lDetaCCF.PRESENTACION = lstProducto(0).PRESENTACION
                            lDetaCCF.CANTIDAD = lSolicAplicaVuelo(0).MZ_HORAS_VUELO
                            lDetaCCF.PRECIO_UNITARIO = Math.Round(lSolicAplicaVuelo(0).PRECIO_UNIT_VUELO + If(lSolicAplicaVuelo(0).PRECIO_UNIT_AGUA = -1, 0, lSolicAplicaVuelo(0).PRECIO_UNIT_AGUA), 4)
                            lDetaCCF.TOTAL = Math.Round(lDetaCCF.CANTIDAD * lDetaCCF.PRECIO_UNITARIO, 2)

                            Me.speDESCTO_PORC.Value = lstProducto(0).PORC_SUBSIDIO
                            Me.LISTA_CCF_DETA.Add(lDetaCCF)
                            Me.CargarDetalleDocumentoEnca()
                        End If
                        Me.SetearSubTotalIvaTotal()
                    Else
                        Me.AsignarMensaje("La solicitud No. " + Me.speNUM_SOLICITUD.Value.ToString + " no posee aplicacion de vuelo", False, True, True)
                        Me.speNUM_SOLICITUD.Value = Nothing
                    End If
                ElseIf (listaSolic(0).ID_CUENTA_FINAN = CuentaFinanciamiento.Talonario OrElse listaSolic(0).ID_CUENTA_FINAN = CuentaFinanciamiento.CanaSemilla OrElse _
                        listaSolic(0).ID_CUENTA_FINAN = CuentaFinanciamiento.HerramientasEPP OrElse listaSolic(0).ID_CUENTA_FINAN = CuentaFinanciamiento.ServicioMaquinariaAgricola) Then
                    'Talonario / Caña Semilla / Herramientas y EPP / Servicio de Maquinaria / Foliares
                    Me.cbxORDEN_COMPRA.ClientEnabled = False
                    Me.cbxTIPO_FINANCIAMIENTO.Value = listaSolic(0).ID_CUENTA_FINAN
                    Me.cbxPROVEEDOR_AGRICOLA.Value = 4
                    Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(listaSolic(0).CODIPROVEEDOR)
                    Me.txtNOMBRE_PROVEEDOR.Text = listaSolic(0).NOMBRE_PROVEEDOR

                    Me.LISTA_CCF_DETA = New listaCCF_DETA

                    Dim lstSolicProd As listaSOLIC_AGRICOLA_PRODUCTO = (New cSOLIC_AGRICOLA_PRODUCTO).ObtenerListaPorSOLIC_AGRICOLA(listaSolic(0).ID_SOLICITUD)
                    If lstSolicProd IsNot Nothing AndAlso lstSolicProd.Count > 0 Then
                        For Each lEntiSoliProd As SOLIC_AGRICOLA_PRODUCTO In lstSolicProd
                            Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(lEntiSoliProd.ID_PRODUCTO)
                            Dim lDetaCCF As New CCF_DETA
                            lDetaCCF.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA)
                            lDetaCCF.ID_CCF_ENCA = 0
                            lDetaCCF.ID_PRODUCTO = lEntiSoliProd.ID_PRODUCTO
                            lDetaCCF.NOMBRE_PRODUCTO = lEntiSoliProd.NOMBRE_PRODUCTO
                            lDetaCCF.UNIDAD = ""
                            lDetaCCF.PRESENTACION = lEntiSoliProd.PRESENTACION
                            lDetaCCF.CANTIDAD = lEntiSoliProd.TOTAL_PRODUCTO
                            lDetaCCF.PRECIO_UNITARIO = lEntiSoliProd.PRECIO_UNITARIO
                            lDetaCCF.TOTAL = lEntiSoliProd.PRECIO_TOTAL
                            If lProducto IsNot Nothing Then
                                Me.speDESCTO_PORC.Value = lProducto.PORC_SUBSIDIO
                            Else
                                Me.speDESCTO_PORC.Value = 0
                            End If

                            Me.LISTA_CCF_DETA.Add(lDetaCCF)
                        Next
                        Me.CargarDetalleDocumentoEnca()
                        Me.SetearSubTotalIvaTotal()
                    End If
                Else
                    Me.CargarOrdenes(listaSolic(0).ID_SOLICITUD)
                End If

            Else
                Me.AsignarMensaje("La solicitud No. " + Me.speNUM_SOLICITUD.Value.ToString + " no se encuentra ACEPTADA por finanzas", False, True, True)
                Me.speNUM_SOLICITUD.Value = Nothing
            End If
        Else
            Me.AsignarMensaje("La solicitud No. " + Me.speNUM_SOLICITUD.Value.ToString + " no existe en la zafra " + Me.cbxZAFRA.Text, False, True, True)
            Me.speNUM_SOLICITUD.Value = Nothing
        End If
    End Sub

    Private Sub CargarOrdenes(ByVal ID_SOLICITUD As Int32)
        Dim lEntidadSolic As SOLIC_AGRICOLA
        Dim listaOrdenes As New listaORDEN_COMPRA_AGRI
        Dim lCtaFinan As CUENTA_FINAN
        Dim lOrdenVacia As New ORDEN_COMPRA_AGRI

        Me.speCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.cbxCONDICION_COMPRA.SelectedIndex = -1
        Me.cbxTIPO_FINANCIAMIENTO.SelectedIndex = -1
        Me.speDESCTO_PORC.Value = Nothing

        lEntidadSolic = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(ID_SOLICITUD)
        If lEntidadSolic IsNot Nothing Then
            listaOrdenes = (New cORDEN_COMPRA_AGRI).ObtenerListaPorSOLIC_AGRICOLA(ID_SOLICITUD, False, False, "CODI_ORDEN")

            lCtaFinan = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(lEntidadSolic.ID_CUENTA_FINAN)
            If lCtaFinan IsNot Nothing Then
                Me.cbxTIPO_FINANCIAMIENTO.Value = lCtaFinan.ID_CUENTA_FINAN
                Me.speDESCTO_PORC.Value = lCtaFinan.PORC_SUBSIDIO
            End If

            If listaOrdenes IsNot Nothing AndAlso listaOrdenes.Count > 0 Then
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(listaOrdenes(0).CODIPROVEEDOR)

                Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(listaOrdenes(0).CODIPROVEEDOR)
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                Me.cbxCONDICION_COMPRA.Value = listaOrdenes(0).CONDI_COMPRA
            Else
                listaOrdenes = New listaORDEN_COMPRA_AGRI
            End If
        End If

        lOrdenVacia.ID_ORDEN = -1
        lOrdenVacia.CODI_ORDEN = "(SIN ORDEN)"
        listaOrdenes.Insertar(0, lOrdenVacia)
        Me.cbxORDEN_COMPRA.DataSource = listaOrdenes
        Me.cbxORDEN_COMPRA.DataBind()
        Me.cbxORDEN_COMPRA.SelectedIndex = -1
        Me.cbxPROVEEDOR_AGRICOLA.SelectedIndex = -1
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = False
    End Sub

    Protected Sub speDESCTO_PORC_ValueChanged(sender As Object, e As EventArgs) Handles speDESCTO_PORC.ValueChanged
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub cbxORDEN_COMPRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxORDEN_COMPRA.ValueChanged
        Me.LISTA_CCF_DETA = New listaCCF_DETA

        Me.cbxPROVEEDOR_AGRICOLA.SelectedIndex = -1
        If Me.cbxORDEN_COMPRA.Value IsNot Nothing Then
            If Me.cbxORDEN_COMPRA.Value = -1 Then
                Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = True
                Me.cbxPROVEEDOR_AGRICOLA.SelectedIndex = -1
            Else
                Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = False
                Dim lOrden As ORDEN_COMPRA_AGRI = (New cORDEN_COMPRA_AGRI).ObtenerORDEN_COMPRA_AGRI(Me.cbxORDEN_COMPRA.Value)
                If lOrden IsNot Nothing Then
                    Me.cbxPROVEEDOR_AGRICOLA.Value = lOrden.ID_PROVEE
                End If
            End If
            Me.IniciarDetalleCCF_DETA()
            Me.CargarDetalleDocumentoEnca()
        End If
    End Sub


    Private Sub IniciarDetalleCCF_DETA()
        Me.LISTA_CCF_DETA = New listaCCF_DETA
        If Me.cbxORDEN_COMPRA.Value IsNot Nothing Then
            Dim listaOrdenDeta As listaORDEN_DETA_AGRI = (New cORDEN_DETA_AGRI).ObtenerListaPorORDEN_COMPRA_AGRI(Me.cbxORDEN_COMPRA.Value)
            If listaOrdenDeta IsNot Nothing AndAlso listaOrdenDeta.Count > 0 Then
                For Each lEntidad As ORDEN_DETA_AGRI In listaOrdenDeta
                    Dim lDetaCCF As New CCF_DETA

                    lDetaCCF.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA)
                    lDetaCCF.ID_CCF_ENCA = 0
                    lDetaCCF.ID_PRODUCTO = lEntidad.ID_PRODUCTO
                    lDetaCCF.NOMBRE_PRODUCTO = lEntidad.NOMBRE_PRODUCTO
                    lDetaCCF.UNIDAD = lEntidad.UNIDAD
                    lDetaCCF.PRESENTACION = lEntidad.PRESENTACION
                    lDetaCCF.CANTIDAD = lEntidad.CANTIDAD
                    lDetaCCF.PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO
                    lDetaCCF.TOTAL = lEntidad.TOTAL

                    Me.LISTA_CCF_DETA.Add(lDetaCCF)
                Next
            Else
                Dim listaSolic As listaSOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.speNUM_SOLICITUD.Value, "", "", "", "", Nothing, Nothing, "")
                If listaSolic IsNot Nothing AndAlso listaSolic.Count = 1 Then
                    Dim listaSolicProds As listaSOLIC_AGRICOLA_PRODUCTO = (New cSOLIC_AGRICOLA_PRODUCTO).ObtenerListaPorSOLIC_AGRICOLA(listaSolic(0).ID_SOLICITUD)

                    Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(listaSolic(0).CODIPROVEEDOR)
                    Me.txtNOMBRE_PROVEEDOR.Text = listaSolic(0).NOMBRE_PROVEEDOR

                    If listaSolicProds IsNot Nothing AndAlso listaSolicProds.Count > 0 Then
                        For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO In listaSolicProds
                            Dim lDetaCCF As New CCF_DETA

                            lDetaCCF.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA)
                            lDetaCCF.ID_CCF_ENCA = 0
                            lDetaCCF.ID_PRODUCTO = lEntidad.ID_PRODUCTO
                            lDetaCCF.NOMBRE_PRODUCTO = lEntidad.NOMBRE_PRODUCTO
                            lDetaCCF.UNIDAD = lEntidad.UNIDAD
                            lDetaCCF.PRESENTACION = lEntidad.PRESENTACION
                            lDetaCCF.CANTIDAD = lEntidad.TOTAL_PRODUCTO
                            lDetaCCF.PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO
                            lDetaCCF.TOTAL = lEntidad.PRECIO_TOTAL

                            Me.LISTA_CCF_DETA.Add(lDetaCCF)
                        Next
                    End If
                End If
            End If
        End If
        Me.SetearSubTotalIvaTotal()
    End Sub

End Class
