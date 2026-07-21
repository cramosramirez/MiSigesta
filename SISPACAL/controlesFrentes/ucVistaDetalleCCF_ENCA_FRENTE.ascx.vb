Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Partial Class controlesFrentes_ucVistaDetalleCCF_ENCA_FRENTE
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

    Public Property TIPO_PROVEEDOR() As Enumeradores.TipoProveedor
        Get
            If Me.ViewState("TIPO_PROVEEDOR") IsNot Nothing Then
                Return CInt(Me.ViewState("TIPO_PROVEEDOR"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Enumeradores.TipoProveedor)
            Me.ViewState("TIPO_PROVEEDOR") = Value
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
    Private mComponente As New cCCF_ENCA_FRENTE
    Private mEntidad As CCF_ENCA_FRENTE
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
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")

        mEntidad = New CCF_ENCA_FRENTE
        mEntidad.ID_CCF_ENCA = ID_CCF_ENCA

        If mComponente.ObtenerCCF_ENCA_FRENTE(mEntidad) <> 1 Then
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
        'Me.CargarOrdenes(mEntidad.ID_SOLICITUD)
        Me.cbxPROVEEDOR_AGRICOLA.Value = mEntidad.ID_PROVEE
        Me.cbxCONDICION_COMPRA.Value = mEntidad.CONDI_COMPRA
        Me.cbxTIPO_COMPROB.Value = mEntidad.ID_TIPO_COMPROB
        Me.txtNO_COMPROB.Text = mEntidad.NO_CCF
        Me.dteFECHA_COMPROB.Date = mEntidad.FECHA
        'Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(mEntidad.CODIPROVEEDOR)
        'Me.CargarInfoProveedor(mEntidad.CODIPROVEEDOR)
        Me.speDESCTO_PORC.Value = mEntidad.DESCTO_PORC
        Me.speDESCTO_MONTO.Value = mEntidad.DESCTO_MONTO
        Me.txtCTA_CONTABLE.Text = mEntidad.CTA_CONTABLE

        Me.LISTA_CCF_DETA_FRENTE = (New cCCF_DETA_FRENTE).ObtenerListaPorCCF_ENCA_FRENTE(mEntidad.ID_CCF_ENCA)
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaCCF_DETA_FRENTE1.PermitirEditarInline = False
        Me.ucListaCCF_DETA_FRENTE1.PermitirEditarInline2 = False
        Me.ucListaCCF_DETA_FRENTE1.PermitirEliminar = False
        Me.ucListaCCF_DETA_FRENTE1.Visible = True
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaCCF_DETA_FRENTE1.CargarDatosCache(Me.lblREFERENCIA.Text)
            Me.SetearSubTotalIvaTotal()
        End If
    End Sub

    Public Sub SetearSubTotalIvaTotal()

        Dim dSubTOTAL As Decimal = 0
        Dim dDescuento As Decimal = 0
        Dim dSumas As Decimal = 0
        Dim dIva As Decimal = 0
        Dim dTotal As Decimal = 0
        Dim listaProd As listaCCF_DETA_FRENTE = Me.LISTA_CCF_DETA_FRENTE

        If listaProd IsNot Nothing AndAlso listaProd.Count > 0 Then
            For Each lProducto As CCF_DETA_FRENTE In listaProd
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

    Public Property LISTA_CCF_DETA_FRENTE As listaCCF_DETA_FRENTE
        Set(value As listaCCF_DETA_FRENTE)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaCCF_DETA_FRENTE) Else Return New listaCCF_DETA_FRENTE
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
        Me.txtCOD_FRENTE.ClientEnabled = False
        Me.txtNOM_FRENTE.ClientEnabled = False
        Me.cbxCONDICION_COMPRA.ClientEnabled = edicion
        Me.txtCTA_CONTABLE.ClientEnabled = edicion
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
        Me.txtCOD_FRENTE.Value = Nothing
        Me.txtNOM_FRENTE.Text = ""
        Me.txtNIT.Text = ""
        Me.txtNRC.Text = ""
        Me.txtACTIVIDAD.Text = ""
        Me.cbxCONDICION_COMPRA.Value = Nothing

        Me.cbxPRODUCTOdeta.Value = Nothing
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Value = Nothing
        Me.spePRECIO_UNITARIOdeta.Value = Nothing
        Me.speSUB_TOTALdeta.Value = Nothing
        Me.txtCTA_CONTABLE.Text = ""

        Me.LISTA_CCF_DETA_FRENTE = New listaCCF_DETA_FRENTE
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()
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
        Dim listaSolicitud As listaSOLIC_ENCA_FRENTE
        Dim listaDetalle As listaCCF_DETA_FRENTE
        Dim bDocumentoDeta As New cCCF_DETA_FRENTE
        Dim dbUtil As New SISPACAL.DL.dbUtilidades

        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CCF_ENCA_FRENTE
        If Me._nuevo Then
            mEntidad.ID_CCF_ENCA = 0
            mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            mEntidad.FECHA_CREACION = cFechaHora.ObtenerFecha
        Else
            mEntidad = mComponente.ObtenerCCF_ENCA_FRENTE(Me.ID_CCF_ENCA)
        End If

        If Me.cbxZAFRA.Value Is Nothing Then
            Return "* Seleccione la Zafra"
        End If
        If Me.speNUM_SOLICITUD.Text = "" Then
            Return "* Ingrese el Numero de Solicitud"
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

        listaDetalle = Me.LISTA_CCF_DETA_FRENTE
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
            listaSolicitud = (New cSOLIC_ENCA_FRENTE).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.speNUM_SOLICITUD.Value, TIPO_PROVEEDOR, "")
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
            mEntidad.ID_FRENTE = listaSolicitud(0).ID_FRENTE
            mEntidad.COD_FRENTE = listaSolicitud(0).COD_FRENTE
            mEntidad.NOM_FRENTE = listaSolicitud(0).NOM_FRENTE
            mEntidad.ID_TIPO_PROVEEDOR = listaSolicitud(0).ID_TIPO_PROVEEDOR
            mEntidad.SUB_TOTAL = CDec(Me.speSUB_TOTAL.Value)
            mEntidad.DESCTO_PORC = If(Me.speDESCTO_PORC.Value Is Nothing, 0, CDec(Me.speDESCTO_PORC.Value))
            mEntidad.DESCTO_MONTO = CDec(Me.speDESCTO_MONTO.Value)
            mEntidad.SUMAS = CDec(Me.speSUMAS.Value)
            mEntidad.IVA = CDec(speIVA.Value)
            mEntidad.TOTAL = CDec(speTOTAL.Value)
            mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value
            mEntidad.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLA.Value
            mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            mEntidad.CTA_CONTABLE = Me.txtCTA_CONTABLE.Text.Trim


            If mComponente.ActualizarCCF_ENCA_FRENTE(mEntidad) < 0 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If

            For Each lEntidad As CCF_DETA_FRENTE In listaDetalle
                If lEntidad.CANTIDAD > 0 Then
                    lEntidad.ID_CCF_DETA = If(Me._nuevo, 0, lEntidad.ID_CCF_DETA)
                    lEntidad.ID_CCF_ENCA = mEntidad.ID_CCF_ENCA
                    bDocumentoDeta.ActualizarCCF_DETA_FRENTE(lEntidad)
                End If
            Next
        Else
            mEntidad.ID_TIPO_COMPROB = Me.cbxTIPO_COMPROB.Value
            mEntidad.NO_CCF = Me.txtNO_COMPROB.Text
            mEntidad.FECHA = Me.dteFECHA_COMPROB.Date
            mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value

            If mComponente.ActualizarCCF_ENCA_FRENTE(mEntidad) < 0 Then
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

    Protected Sub speCODIPROVEE_ValueChanged(sender As Object, e As EventArgs) Handles txtCOD_FRENTE.ValueChanged
        Me.CargarInfoFrente(txtCOD_FRENTE.Text.Trim.ToUpper)
    End Sub

    Private Sub CargarInfoFrente(ByVal sCOD_FRENTE As String)
        If TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteRoza Then
            Dim lEntidad As PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPorCODIGO(sCOD_FRENTE)
            If lEntidad IsNot Nothing Then
                Me.txtNOM_FRENTE.Text = lEntidad.NOMBRE_PROVEEDOR_ROZA
                Me.txtNIT.Text = lEntidad.NIT
                Me.txtNRC.Text = lEntidad.CREDITO_FISCAL
                Me.txtACTIVIDAD.Text = lEntidad.ACTIVIDAD
            End If
        ElseIf TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteQuerqueo Then
            Dim lista As listaPROVEEDOR_QUERQUEO = (New cPROVEEDOR_QUERQUEO).ObtenerListaPorCODISIS(sCOD_FRENTE)
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                Me.txtNOM_FRENTE.Text = lista(0).NOMBRES + " " + lista(0).APELLIDOS
                Me.txtNIT.Text = lista(0).NIT
                Me.txtNRC.Text = lista(0).NRC
                Me.txtACTIVIDAD.Text = ""
            End If
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
        Dim lCCFDeta As New CCF_DETA_FRENTE
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

        lCCFDeta.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA_FRENTE)
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
        lCCFDeta.REFERENCIA = Me.lblREFERENCIA.Text

        Me.LISTA_CCF_DETA_FRENTE.Add(lCCFDeta)
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

    Private Function ObtenerIdProd(ByVal lista As listaCCF_DETA_FRENTE) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_CCF_DETA > Id Then
                Id = lista(i).ID_CCF_DETA
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub ucListaCCF_DETA1_Eliminando(ID_CCF_DETA As Integer) Handles ucListaCCF_DETA_FRENTE1.Eliminando
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub speNUM_SOLICITUD_ValueChanged(sender As Object, e As EventArgs) Handles speNUM_SOLICITUD.ValueChanged
        Dim listaSolic As listaSOLIC_ENCA_FRENTE

        Me.cbxPROVEEDOR_AGRICOLA.SelectedIndex = -1
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = False

        listaSolic = (New cSOLIC_ENCA_FRENTE).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.speNUM_SOLICITUD.Value, TIPO_PROVEEDOR, "")
        If listaSolic IsNot Nothing AndAlso listaSolic.Count > 0 Then
            If listaSolic(0).ID_ESTADO_SOLIC = Enumeradores.EstadoSolicAgricola.Aceptada Then
                Me.cbxORDEN_COMPRA.ClientEnabled = False
                Me.cbxTIPO_FINANCIAMIENTO.Value = listaSolic(0).ID_CUENTA_FINAN
                Me.cbxPROVEEDOR_AGRICOLA.Value = 4
                Me.txtCOD_FRENTE.Value = listaSolic(0).COD_FRENTE
                Me.txtNOM_FRENTE.Text = listaSolic(0).NOM_FRENTE

                Me.LISTA_CCF_DETA_FRENTE = New listaCCF_DETA_FRENTE

                Dim lstSolicProd As listaSOLIC_DETA_FRENTE = (New cSOLIC_DETA_FRENTE).ObtenerListaPorSOLIC_ENCA_FRENTE(listaSolic(0).ID_SOLICITUD)
                If lstSolicProd IsNot Nothing AndAlso lstSolicProd.Count > 0 Then
                    For Each lEntiSoliProd As SOLIC_DETA_FRENTE In lstSolicProd
                        Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(lEntiSoliProd.ID_PRODUCTO)
                        Dim lDetaCCF As New CCF_DETA_FRENTE
                        lDetaCCF.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA_FRENTE)
                        lDetaCCF.ID_CCF_ENCA = 0
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

                        Me.LISTA_CCF_DETA_FRENTE.Add(lDetaCCF)
                    Next
                    Me.CargarDetalleDocumentoEnca()
                    Me.SetearSubTotalIvaTotal()
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


    Protected Sub speDESCTO_PORC_ValueChanged(sender As Object, e As EventArgs) Handles speDESCTO_PORC.ValueChanged
        Me.SetearSubTotalIvaTotal()
    End Sub


    Private Sub IniciarDetalleCCF_DETA()
        Me.LISTA_CCF_DETA_FRENTE = New listaCCF_DETA_FRENTE


        Dim listaSolic As listaSOLIC_ENCA_FRENTE = (New cSOLIC_ENCA_FRENTE).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.speNUM_SOLICITUD.Value, TIPO_PROVEEDOR, "")
        If listaSolic IsNot Nothing AndAlso listaSolic.Count = 1 Then
            Dim listaSolicProds As listaSOLIC_DETA_FRENTE = (New cSOLIC_DETA_FRENTE).ObtenerListaPorSOLIC_ENCA_FRENTE(listaSolic(0).ID_SOLICITUD)

            Me.txtCOD_FRENTE.Value = listaSolic(0).COD_FRENTE
            Me.txtNOM_FRENTE.Text = listaSolic(0).NOM_FRENTE

            If listaSolicProds IsNot Nothing AndAlso listaSolicProds.Count > 0 Then
                For Each lEntidad As SOLIC_DETA_FRENTE In listaSolicProds
                    Dim lDetaCCF As New CCF_DETA_FRENTE

                    lDetaCCF.ID_CCF_DETA = Me.ObtenerIdProd(Me.LISTA_CCF_DETA_FRENTE)
                    lDetaCCF.ID_CCF_ENCA = 0
                    lDetaCCF.ID_PRODUCTO = lEntidad.ID_PRODUCTO
                    lDetaCCF.NOMBRE_PRODUCTO = lEntidad.NOMBRE_PRODUCTO
                    lDetaCCF.PRESENTACION = lEntidad.PRESENTACION
                    lDetaCCF.CANTIDAD = lEntidad.CANTIDAD
                    lDetaCCF.PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO
                    lDetaCCF.TOTAL = lEntidad.SUB_TOTAL

                    Me.LISTA_CCF_DETA_FRENTE.Add(lDetaCCF)
                Next
            End If
        End If
        Me.SetearSubTotalIvaTotal()
    End Sub

End Class

