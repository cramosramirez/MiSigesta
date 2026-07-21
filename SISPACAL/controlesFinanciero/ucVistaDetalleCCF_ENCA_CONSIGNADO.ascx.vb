Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesFinanciero_ucVistaDetalleCCF_ENCA_CONSIGNADO
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
            Me.lblREFERENCIA_SALBODE.Text = Guid.NewGuid.ToString
            Me.lblREFERENCIA_SALBODE_SELECT.Text = Guid.NewGuid.ToString
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
        If lblREFERENCIA_SALBODE.Text <> "" Then
            If Session(lblREFERENCIA_SALBODE.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA_SALBODE.Text)
            End If
        End If
        If lblREFERENCIA_SALBODE_SELECT.Text <> "" Then
            If Session(lblREFERENCIA_SALBODE_SELECT.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA_SALBODE_SELECT.Text)
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

        Me.cbxTIPO_FINANCIAMIENTO.Value = mEntidad.ID_CUENTA_FINAN
        Me.cbxPROVEEDOR_AGRICOLA.Value = mEntidad.ID_PROVEE
        Me.cbxCONDICION_COMPRA.Value = mEntidad.CONDI_COMPRA
        Me.cbxTIPO_COMPROB.Value = mEntidad.ID_TIPO_COMPROB
        Me.txtNO_COMPROB.Text = mEntidad.NO_CCF
        Me.dteFECHA_COMPROB.Date = mEntidad.FECHA
        Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(mEntidad.CODIPROVEEDOR)
        Me.CargarInfoProveedor(mEntidad.CODIPROVEEDOR)
        Me.speDESCTO_PORC.Value = mEntidad.DESCTO_PORC
        Me.speDESCTO_MONTO.Value = mEntidad.DESCTO_MONTO
        Me.LISTA_CCF_DETA = (New cCCF_DETA).ObtenerListaPorCCF_ENCA(mEntidad.ID_CCF_ENCA)
        Me.LISTA_CCF_DETA_SALBODE = (New cCCF_DETA_SALBODE).ObtenerListaPorCCF_ENCA(mEntidad.ID_CCF_ENCA)
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaCCF_DETA1.PermitirEditarInline = False
        Me.ucListaCCF_DETA1.PermitirEditarInline2 = False
        Me.ucListaCCF_DETA1.PermitirEliminar = False
        Me.ucListaCCF_DETA1.Visible = True
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaCCF_DETA1.CargarDatosCache(Me.lblREFERENCIA.Text)
            Me.SetearSubTotalIvaTotal()
        End If
    End Sub

    Public Sub CargarDetalleCCF_DETA_SALBODE()
        If Me.lblREFERENCIA_SALBODE.Text <> "" Then
            Me.ucListaCCF_DETA_SALBODE1.CargarDatosCache(Me.lblREFERENCIA_SALBODE.Text)
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


        If listaProd IsNot Nothing AndAlso listaProd.Count > 0 Then
            For Each lProducto As CCF_DETA In listaProd
                dSubTOTAL += lProducto.TOTAL
            Next
        End If
        dSubTOTAL = Math.Round(dSubTOTAL, 2)
        dDescuento = Math.Round(dSubTOTAL * If(Me.speDESCTO_PORC.Value = Nothing, CDec(0), CDec(Me.speDESCTO_PORC.Value) / CDec(100)), 2)
        dSumas = dSubTOTAL - dDescuento
        dIva = Math.Round(dSumas * Utilerias.TasaIva, 2)
        dTotal = Math.Round(dSumas, 2) + dIva

        Me.speSUB_TOTAL.Value = dSubTOTAL
        Me.speDESCTO_MONTO.Value = dDescuento
        Me.speSUMAS.Value = dSumas
        Me.speIVA.Value = dIva
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

    Public Property LISTA_CCF_DETA_SALBODE As listaCCF_DETA_SALBODE
        Set(value As listaCCF_DETA_SALBODE)
            Session(Me.lblREFERENCIA_SALBODE.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA_SALBODE.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA_SALBODE.Text), listaCCF_DETA_SALBODE) Else Return New listaCCF_DETA_SALBODE
        End Get
    End Property

    Public Property LISTA_CCF_DETA_SALBODE_SELECT As listaCCF_DETA_SALBODE
        Set(value As listaCCF_DETA_SALBODE)
            Session(Me.lblREFERENCIA_SALBODE_SELECT.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA_SALBODE_SELECT.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA_SALBODE_SELECT.Text), listaCCF_DETA_SALBODE) Else Return New listaCCF_DETA_SALBODE
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
        Me.cbxZAFRA.ClientEnabled = Me._nuevo
        Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = Me._nuevo
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = Me._nuevo
        Me.cbxTIPO_COMPROB.ClientEnabled = edicion
        Me.txtNO_COMPROB.ClientEnabled = edicion
        Me.dteFECHA_COMPROB.ClientEnabled = edicion
        Me.speCODIPROVEE.ClientEnabled = Me._nuevo
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.cbxCONDICION_COMPRA.ClientEnabled = edicion
        Me.trPRODUCTO_AGRICOLA_DETA1.Visible = False
        Me.trPRODUCTO_AGRICOLA_DETA2.Visible = False
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
        Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
        Me.cbxPROVEEDOR_AGRICOLA.Value = Nothing
        Me.cbxTIPO_COMPROB.Value = Nothing
        Me.txtNO_COMPROB.Text = ""
        Me.dteFECHA_COMPROB.Value = Nothing
        Me.speCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.cbxCONDICION_COMPRA.Value = Nothing

        Me.cbxPRODUCTOdeta.Value = Nothing
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Value = Nothing
        Me.spePRECIO_UNITARIOdeta.Value = Nothing
        Me.speSUB_TOTALdeta.Value = Nothing

        Me.LISTA_CCF_DETA = New listaCCF_DETA
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()

        Select Case Me.CONCEPTO_CCF
            Case Enumeradores.CCFConcepto.AplicacionVuelo
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
        Dim listaDetalle As listaCCF_DETA
        Dim listaSalBode As listaCCF_DETA_SALBODE
        Dim bDocumentoDeta As New cCCF_DETA
        Dim bDocumentoDetaSalBode As New cCCF_DETA_SALBODE
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
        listaSalBode = Me.LISTA_CCF_DETA_SALBODE_SELECT
        If listaDetalle Is Nothing OrElse listaDetalle.Count = 0 Then
            Return "* No se encontro detalle de productos en el comprobante"
        End If
        If listaSalBode Is Nothing OrElse listaSalBode.Count = 0 Then
            Return "* No se encontro detalle de solicitudes de producto en el comprobante"
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
            mEntidad.ID_SOLICITUD = -1
            mEntidad.ID_ORDEN = -1
            mEntidad.ID_CUENTA_FINAN = Me.cbxTIPO_FINANCIAMIENTO.Value
            mEntidad.ID_TIPO_COMPROB = Me.cbxTIPO_COMPROB.Value
            mEntidad.UID_REFERENCIA_CCF = Guid.NewGuid
            mEntidad.NO_CCF = Me.txtNO_COMPROB.Text
            mEntidad.FECHA = Me.dteFECHA_COMPROB.Date
            mEntidad.CODIPROVEEDOR = Utilerias.FormatearCODIPROVEEDOR(speCODIPROVEE.Value)
            mEntidad.SUB_TOTAL = CDec(Me.speSUB_TOTAL.Value)
            mEntidad.DESCTO_PORC = If(Me.speDESCTO_PORC.Value Is Nothing, 0, CDec(Me.speDESCTO_PORC.Value))
            mEntidad.DESCTO_MONTO = CDec(Me.speDESCTO_MONTO.Value)
            mEntidad.SUMAS = CDec(Me.speSUMAS.Value)
            mEntidad.IVA = CDec(speIVA.Value)
            mEntidad.TOTAL = CDec(speTOTAL.Value)
            mEntidad.TOTAL_LETRAS = dbUtil.ConvertirNumeroaLetras(CDec(speTOTAL.Value), "DOLARES")
            mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value
            mEntidad.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLA.Value
            mEntidad.CONCEPTO_CCF = Me.CONCEPTO_CCF

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

            If listaSalBode IsNot Nothing AndAlso listaSalBode.Count > 0 Then
                For Each lEntidad As CCF_DETA_SALBODE In listaSalBode
                    If lEntidad.CANTIDAD_CCF > 0 Then
                        lEntidad.ID_CCF_DETA_SAL = If(Me._nuevo, 0, lEntidad.ID_CCF_DETA_SAL)
                        lEntidad.ID_CCF_ENCA = mEntidad.ID_CCF_ENCA
                        bDocumentoDetaSalBode.ActualizarCCF_DETA_SALBODE(lEntidad)
                    End If
                Next
            End If
        Else
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
        Else
            Me.txtNOMBRE_PROVEEDOR.Text = ""
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

    Protected Sub speDESCTO_PORC_ValueChanged(sender As Object, e As EventArgs) Handles speDESCTO_PORC.ValueChanged
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub btnProductosPendientesFact_Click(sender As Object, e As EventArgs) Handles btnProductosPendientesFact.Click
        Dim sCodiProveedor As String = ""
        Dim idProvee As Int32 = -1

        If Me.cbxPROVEEDOR_AGRICOLA.Value Is Nothing OrElse Me.cbxPROVEEDOR_AGRICOLA.Value = 0 Then
            Me.AsignarMensaje("Seleccione la casa comercial", False, True, True)
            Return
        End If
        If Me.speCODIPROVEE.Value Is Nothing OrElse Me.speCODIPROVEE.Value = 0 Then
            Me.AsignarMensaje("Ingrese el codigo de proveedor", False, True, True)
            Return
        End If

        sCodiProveedor = Utilerias.FormatearCODIPROVEEDOR(Me.speCODIPROVEE.Value)
        idProvee = Me.cbxPROVEEDOR_AGRICOLA.Value
        Me.LISTA_CCF_DETA_SALBODE = (New cCCF_DETA_SALBODE).ObtenerListaPendienteFacturar(sCodiProveedor, idProvee)
        Me.CargarDetalleCCF_DETA_SALBODE()
        Me.pcCCF_DETA_SALBODE.ShowOnPageLoad = True
    End Sub

    Private Sub AgregarActualizarEnDetalle(ByRef lista As listaCCF_DETA, ByVal lEntidadAdd As CCF_DETA)
        If lista IsNot Nothing Then
            Dim bExiste As Boolean = False

            For i As Int32 = 0 To lista.Count - 1
                If lista(i).ID_PRODUCTO = lEntidadAdd.ID_PRODUCTO Then
                    lista(i).CANTIDAD += lEntidadAdd.CANTIDAD
                    lista(i).TOTAL = Math.Round(lista(i).CANTIDAD * lista(i).PRECIO_UNITARIO, 2)
                    bExiste = True
                    Exit For
                End If
            Next

            If Not bExiste Then
                lista.Add(lEntidadAdd)
            End If
        End If
    End Sub

    Protected Sub btnAceptarFact_Click(sender As Object, e As EventArgs) Handles btnAceptarFact.Click
        Me.LISTA_CCF_DETA_SALBODE_SELECT = Me.ucListaCCF_DETA_SALBODE1.DevolverSeleccionados
        Dim lista As listaCCF_DETA_SALBODE
        Dim listaIdProd As New List(Of Int32)

        lista = Me.LISTA_CCF_DETA_SALBODE_SELECT
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For Each lEntidad As CCF_DETA_SALBODE In lista
                If Not listaIdProd.Contains(lEntidad.ID_PRODUCTO) Then listaIdProd.Add(lEntidad.ID_PRODUCTO)
            Next

            Me.LISTA_CCF_DETA = New listaCCF_DETA
            For j As Int32 = 0 To listaIdProd.Count - 1
                For Each lEntidad As CCF_DETA_SALBODE In lista
                    If lEntidad.ID_PRODUCTO = listaIdProd(j) Then
                        Dim lCCFDeta As New CCF_DETA
                        lCCFDeta.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA)
                        lCCFDeta.ID_CCF_ENCA = 0
                        lCCFDeta.ID_PRODUCTO = lEntidad.ID_PRODUCTO
                        lCCFDeta.NOMBRE_PRODUCTO = lEntidad.NOMBRE_PRODUCTO
                        lCCFDeta.CANTIDAD = lEntidad.CANTIDAD_CCF
                        lCCFDeta.PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO_CCF
                        lCCFDeta.TOTAL = lEntidad.TOTAL_CCF
                        lCCFDeta.PRESENTACION = lEntidad.PRESENTACION
                        lCCFDeta.UNIDAD = ""
                        lCCFDeta.REFERENCIA = Me.lblREFERENCIA.Text

                        AgregarActualizarEnDetalle(Me.LISTA_CCF_DETA, lCCFDeta)
                    End If
                Next
            Next
            Me.CargarDetalleDocumentoEnca()
            Me.pcCCF_DETA_SALBODE.ShowOnPageLoad = False
        Else
            AsignarMensaje("Seleccione los productos a facturar", False, True, True)
            Return
        End If
    End Sub
End Class
