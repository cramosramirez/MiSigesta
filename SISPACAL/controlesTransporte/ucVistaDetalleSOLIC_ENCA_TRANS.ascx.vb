Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSOLIC_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_ENCA_TRANS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_SOLICITUD As Int32
    Public Property ID_SOLICITUD() As Int32
        Get
            If Me.ViewState("ID_SOLICITUD") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_SOLICITUD"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_SOLICITUD") = Value
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
    Private mComponente As New cSOLIC_ENCA_TRANS
    Private mEntidad As SOLIC_ENCA_TRANS
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
        If Not Me.ViewState("ID_SOLICITUD") Is Nothing Then Me._ID_SOLICITUD = Me.ViewState("ID_SOLICITUD")
        Me.CargarProveedorAgricola()
        Me.CargarProductos()
        Me.SetearSubTotalIvaTotal()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SOLIC_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lTransportista As TRANSPORTISTA
        Dim lContrato As CONTRATO_TRANS
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_ENCA_TRANS
        mEntidad.ID_SOLICITUD = ID_SOLICITUD
 
        If mComponente.ObtenerSOLIC_ENCA_TRANS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtNUM_SOLIC_ZAFRA.Text = mEntidad.NUM_SOLIC_ZAFRA.ToString
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.cbxTIPO_FINANCIAMIENTO.Value = mEntidad.ID_CUENTA_FINAN

        Me.txtCODTRANSPORT.Value = mEntidad.CODTRANSPORT
        lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Me.txtCODTRANSPORT.Value)
        Me.txtNOMBRE_TRANSPORTISTA.Text = If(lTransportista IsNot Nothing, lTransportista.NOMBRES + " " + lTransportista.APELLIDOS, "")
        Me.txtACTIVIDAD.Text = mEntidad.ACTIVIDAD

        Me.CargarContratos()
        Me.cbxCONTRATO_TRANS.Value = mEntidad.ID_CONTRA_TRANS

        lContrato = (New cCONTRATO_TRANS).ObtenerCONTRATO_TRANS(mEntidad.ID_CONTRA_TRANS)
        Me.dteFECHA_SOLIC.Date = mEntidad.FECHA_SOLIC
        Me.cbxESTADO_SOLIC.Value = mEntidad.ID_ESTADO_SOLIC
        Me.cbxCONDICION_COMPRA.Value = mEntidad.CONDI_COMPRA
        Me.speCESC.Value = mEntidad.CESC
        Me.LISTA_SOLIC_PROD_TRANS = (New cSOLIC_PROD_TRANS).ObtenerListaPorSOLIC_ENCA_TRANS(mEntidad.ID_SOLICITUD)
        Me.MostrarOcultarCESC()
        
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()
    End Sub

    Private Sub MostrarOcultarCESC()
        Me.trCESC.Visible = False
        If LISTA_SOLIC_PROD_TRANS IsNot Nothing AndAlso LISTA_SOLIC_PROD_TRANS.Count > 0 Then
            For i As Integer = 0 To LISTA_SOLIC_PROD_TRANS.Count - 1
                Dim lProveedorAgri As PROVEEDOR_AGRICOLA
                lProveedorAgri = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(LISTA_SOLIC_PROD_TRANS(i).ID_PROVEE)
                If lProveedorAgri IsNot Nothing AndAlso Utilerias.EsDADA_Y_CIA(lProveedorAgri.NOMBRE) Then
                    Me.trCESC.Visible = True
                End If
            Next
        End If
    End Sub

    Public Sub CargarContratos()
        Dim lista As listaCONTRATO_TRANS
        lista = (New cCONTRATO_TRANS).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, -1, CInt(Me.txtCODTRANSPORT.Value))
        If lista Is Nothing Then lista = New listaCONTRATO_TRANS
        Me.cbxCONTRATO_TRANS.DataSource = lista
        Me.cbxCONTRATO_TRANS.DataBind()
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaSOLIC_PROD_TRANS1.CargarDatosCache(Me.lblREFERENCIA.Text)
            Me.SetearSubTotalIvaTotal()
        End If
    End Sub

    Public Sub SetearSubTotalIvaTotal()
        Dim dSubTOTAL As Decimal = 0
        Dim dDescuento As Decimal = 0
        Dim dSumas As Decimal = 0
        Dim dSumaAplicaCESC As Decimal = 0
        Dim dIva As Decimal = 0
        Dim dTotal As Decimal = 0
        Dim dCESC As Decimal = 0
        Dim listaProd As listaSOLIC_PROD_TRANS = Me.LISTA_SOLIC_PROD_TRANS
        Dim lEntidad As PRODUCTO

        If listaProd IsNot Nothing AndAlso listaProd.Count > 0 Then
            For Each lProducto As SOLIC_PROD_TRANS In listaProd
                dSubTOTAL += lProducto.SUB_TOTAL

                lEntidad = (New cPRODUCTO).ObtenerPRODUCTO(lProducto.ID_PRODUCTO)
                If lEntidad IsNot Nothing AndAlso lEntidad.APLICA_CESC Then
                    dSumaAplicaCESC += lProducto.SUB_TOTAL
                End If
            Next
        End If
        dSubTOTAL = Math.Round(dSubTOTAL, 2)
        dCESC = Math.Round(dSumaAplicaCESC * Utilerias.ImpuestoCESC, 2)
        'dCESC = If(Me.speCESC.Value = Nothing, CDec(0), Math.Round(CDec(Me.speCESC.Value), 5))
        dSumas = dSubTOTAL
        dIva = Math.Round(dSumas * Utilerias.TasaIva, 2)
        dTotal = Math.Round(dSumas, 2) + dIva + dCESC

        Me.speSUB_TOTAL.Value = dSubTOTAL
        Me.speSUMAS.Value = dSumas
        Me.speCESC.Value = dCESC
        Me.speIVA.Value = dIva
        Me.speTOTAL.Value = dTotal
    End Sub

    Public Property LISTA_SOLIC_PROD_TRANS As listaSOLIC_PROD_TRANS
        Set(value As listaSOLIC_PROD_TRANS)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaSOLIC_PROD_TRANS) Else Return New listaSOLIC_PROD_TRANS
        End Get
    End Property
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = Me._nuevo
        Me.txtNUM_SOLIC_ZAFRA.ClientEnabled = _nuevo
        Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = _nuevo
        Me.txtCODTRANSPORT.ClientEnabled = _nuevo
        Me.txtNOMBRE_TRANSPORTISTA.ClientEnabled = False
        Me.txtACTIVIDAD.ClientEnabled = _nuevo
        Me.cbxCONTRATO_TRANS.ClientEnabled = _nuevo
        Me.dteFECHA_SOLIC.ClientEnabled = False
        Me.cbxESTADO_SOLIC.ClientEnabled = False
        Me.cbxCONDICION_COMPRA.ClientEnabled = _nuevo
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        Me.txtCODTRANSPORT.Value = Nothing
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
        Me.cbxCONTRATO_TRANS.Value = Nothing
        Me.cbxESTADO_SOLIC.Value = 1
        Me.cbxCONDICION_COMPRA.Value = Nothing
        Me.txtNUM_SOLIC_ZAFRA.Value = Nothing
        Me.txtACTIVIDAD.Text = "SERVICIO DE TRANSPORTE DE CARGA"
        Me.dteFECHA_SOLIC.Date = cFechaHora.ObtenerFecha
        Me.speSUB_TOTAL.Value = Nothing
        Me.speIVA.Value = Nothing
        Me.speTOTAL.Value = Nothing
        Me.LISTA_SOLIC_PROD_TRANS = New listaSOLIC_PROD_TRANS
        Me.CargarDetalleDocumentoEnca()

        Me.cbxCONDICION_COMPRA.SelectedIndex = 0
        Me.cbxPROVEEDOR_AGRICOLAdeta.Text = ""
        Me.cbxPRODUCTOdeta.SelectedIndex = -1
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Text = ""
        Me.spePRECIO_UNITARIOdeta.Text = ""
        Me.speSUB_TOTALdeta.Text = ""
        Me.cbxPRODUCTOdeta.Focus()
        Me.trCESC.Visible = False
    End Sub

    Private Sub CargarInfoTransportista(ByVal sCODTRANSPORT As Int32)
        Dim lEntidad As TRANSPORTISTA

        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.cbxCONTRATO_TRANS.Text = ""

        lEntidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(sCODTRANSPORT)
        If lEntidad IsNot Nothing Then
            Me.txtNOMBRE_TRANSPORTISTA.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
        End If
    End Sub

    Private Sub CargarProveedorAgricola()
        Dim idProveedorSelecc As Int32
        Dim idCuentaFinan As Int32 = -2
        Dim lista As listaPROVEEDOR_AGRICOLA

        If Me.cbxPROVEEDOR_AGRICOLAdeta.Value IsNot Nothing AndAlso Me.cbxPROVEEDOR_AGRICOLAdeta.Value > 0 Then idProveedorSelecc = CInt(Me.cbxPROVEEDOR_AGRICOLAdeta.Value)
        If Me.cbxTIPO_FINANCIAMIENTO.Value IsNot Nothing AndAlso Me.cbxTIPO_FINANCIAMIENTO.Value > 0 Then idCuentaFinan = CInt(Me.cbxTIPO_FINANCIAMIENTO.Value)
        lista = (New cPROVEEDOR_AGRICOLA).ObtenerListaPorCUENTA_FINAN(idCuentaFinan, "NOMBRE")
        If Not (lista IsNot Nothing AndAlso lista.Count > 0) Then
            lista = New listaPROVEEDOR_AGRICOLA
        End If

        Me.cbxPROVEEDOR_AGRICOLAdeta.DataSource = lista
        Me.cbxPROVEEDOR_AGRICOLAdeta.DataBind()
        If Me.cbxPROVEEDOR_AGRICOLAdeta.Items.FindByValue(idProveedorSelecc) IsNot Nothing Then Me.cbxPROVEEDOR_AGRICOLAdeta.Value = idProveedorSelecc
    End Sub

    Private Sub CargarProductos()
        Dim idProveedor As Int32 = 0
        Dim idCuentaFinan As Int32 = 0
        Dim enConsigna As Int32 = -1
        Dim idProducto As Int32 = -1
        Dim lista As listaPRODUCTO

        If Me.cbxPRODUCTOdeta.Value IsNot Nothing AndAlso IsNumeric(cbxPRODUCTOdeta.Value) AndAlso cbxPRODUCTOdeta.Value > 0 Then idProducto = CInt(cbxPRODUCTOdeta.Value)
        If Me.cbxPROVEEDOR_AGRICOLAdeta.Value IsNot Nothing Then idProveedor = Me.cbxPROVEEDOR_AGRICOLAdeta.Value
        If Me.cbxTIPO_FINANCIAMIENTO.Value IsNot Nothing Then idCuentaFinan = Me.cbxTIPO_FINANCIAMIENTO.Value
        If Me.cbxCONDICION_COMPRA.Value IsNot Nothing AndAlso Me.cbxCONDICION_COMPRA.Value = 3 Then enConsigna = 1

        lista = (New cPRODUCTO).ObtenerListaPorCriterios(idProveedor, -1, idCuentaFinan, -1, 1, -1, "NOMBRE_PRODUCTO", "ASC", True)
        If Not (lista IsNot Nothing AndAlso lista.Count > 0) Then
            lista = New listaPRODUCTO
        End If

        Me.cbxPRODUCTOdeta.DataSource = lista
        Me.cbxPRODUCTOdeta.DataBind()
        If Me.cbxPRODUCTOdeta.Items.FindByValue(idProducto) IsNot Nothing Then Me.cbxPRODUCTOdeta.Value = idProducto
    End Sub

    Public Function Aceptar() As String
        Dim bSolic As New cSOLIC_ENCA_TRANS
        Dim mEntidad As SOLIC_ENCA_TRANS
        Dim lRet As Int32 = 0
        Dim sError As New StringBuilder

        mEntidad = (New cSOLIC_ENCA_TRANS).ObtenerSOLIC_ENCA_TRANS(Me.ID_SOLICITUD)
        mEntidad.ID_ESTADO_SOLIC = 2
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        bSolic.ActualizarSOLIC_ENCA_TRANS(mEntidad)

        Me.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLIC_ENCA_TRANS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lZafra As ZAFRA
        Dim lEntidadContraVehi As CONTRATO_TRANS_VEHI
        Dim lDetalle As listaSOLIC_PROD_TRANS = Me.LISTA_SOLIC_PROD_TRANS
        Dim bSolicProd As New cSOLIC_PROD_TRANS

        mEntidad = New SOLIC_ENCA_TRANS
        If Me._nuevo Then
            mEntidad.ID_SOLICITUD = 0
            mEntidad.NUM_SOLIC_ZAFRA = 0
            mEntidad.UID_SOLIC_ENCA_TRANS = Guid.NewGuid

            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerSOLIC_ENCA_TRANS(Me.ID_SOLICITUD)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            Return ""
        End If

        If Me.cbxZAFRA.Value Is Nothing Then
            Return "* Seleccione la Zafra"
        End If
        If Me.cbxTIPO_FINANCIAMIENTO.Value Is Nothing Then
            Return "* Seleccione el Tipo de Financiamiento"
        End If
        If Me.txtCODTRANSPORT.Value Is Nothing Then
            Return "* Ingrese el codigo de transportista"
        End If
        If Me.cbxCONTRATO_TRANS.Value Is Nothing Then
            Return "* Seleccione el contrato"
        End If
        If Me.cbxCONDICION_COMPRA.Value Is Nothing Then
            Return "* Seleccione la Condicion de Compra"
        End If
        If lDetalle Is Nothing OrElse (lDetalle IsNot Nothing AndAlso lDetalle.Count = 0) Then
            Return "* Ingrese el detalle de productos"
        End If

        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.ID_CONTRA_TRANS = Me.cbxCONTRATO_TRANS.Value
        mEntidad.ID_CUENTA_FINAN = Me.cbxTIPO_FINANCIAMIENTO.Value
        mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value
        mEntidad.CODTRANSPORT = Me.txtCODTRANSPORT.Value
        mEntidad.ACTIVIDAD = Me.txtACTIVIDAD.Text.Trim.ToUpper
        mEntidad.FECHA_SOLIC = Me.dteFECHA_SOLIC.Date
        mEntidad.ID_CONTRA_TRANS_VEHI = -1
        mEntidad.ID_TRANSPORTE = -1
        mEntidad.SUB_TOTAL = Me.speSUB_TOTAL.Value
        mEntidad.IVA = Me.speIVA.Value
        mEntidad.TOTAL = Me.speTOTAL.Value
        mEntidad.ID_ESTADO_SOLIC = Me.cbxESTADO_SOLIC.Value
        mEntidad.OBSERVACIONES = ""
        mEntidad.CESC = CDec(Me.speCESC.Value)

        lZafra = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value)
        mEntidad.ZAFRA = lZafra.NOMBRE_ZAFRA

        If mComponente.ActualizarSOLIC_ENCA_TRANS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If

        If lDetalle IsNot Nothing AndAlso lDetalle.Count > 0 Then
            For i = 0 To lDetalle.Count - 1
                Dim lSoliProd As SOLIC_PROD_TRANS = lDetalle(i)
                lSoliProd.ID_SOLIC_PROD_TRANS = 0
                lSoliProd.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                bSolicProd.ActualizarSOLIC_PROD_TRANS(lSoliProd)
            Next
        End If

        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarSolicTransporte(" + mEntidad.ID_SOLICITUD.ToString + ")", True)

        Me.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub cbxPRODUCTOdeta_ValueChanged(sender As Object, e As EventArgs) Handles cbxPRODUCTOdeta.ValueChanged
        Me.ProductoSeleccionado()
    End Sub

    Private Sub ProductoSeleccionado()
        If Me.cbxPRODUCTOdeta.Value IsNot Nothing AndAlso Me.cbxPRODUCTOdeta.SelectedIndex >= 0 Then
            Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(Me.cbxPRODUCTOdeta.Value)
            Me.txtPRESENTACIONdeta.Text = lProducto.PRESENTACION
            Me.spePRECIO_UNITARIOdeta.Value = lProducto.PRECIO_UNITARIO
        End If
        Me.CalcularSubTotal()
        Me.spePRECIO_UNITARIOdeta.Focus()
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
        Dim lEntidad As New SOLIC_PROD_TRANS
        Dim lProducto As PRODUCTO

        Me.AsignarMensaje("", True, False)

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

        'Validar que no se ingrese producto/servicio de diferente cuenta de financiamiento
        If Me.LISTA_SOLIC_PROD_TRANS IsNot Nothing AndAlso Me.LISTA_SOLIC_PROD_TRANS.Count > 0 AndAlso Me.cbxPRODUCTOdeta.Value IsNot Nothing Then
            lProducto = (New cPRODUCTO).ObtenerPRODUCTO(Me.cbxPRODUCTOdeta.Value)
            If lProducto IsNot Nothing Then
                Dim lista As listaSOLIC_PROD_TRANS = Me.LISTA_SOLIC_PROD_TRANS
                Dim lProdDeta As PRODUCTO

                For i As Int32 = 0 To lista.Count - 1
                    lProdDeta = (New cPRODUCTO).ObtenerPRODUCTO(lista(i).ID_PRODUCTO)
                    If lProdDeta.ID_CUENTA_FINAN <> lProducto.ID_CUENTA_FINAN Then
                        Me.AsignarMensaje("* Solo puede agregar productos de un tipo de financiamiento", True, False)
                        Return
                    End If
                Next
            End If
        End If

        lEntidad.ID_SOLIC_PROD_TRANS = Me.ObtenerIdProd(Me.LISTA_SOLIC_PROD_TRANS)
        lEntidad.ID_SOLICITUD = 0
        lEntidad.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLAdeta.Value
        lEntidad.ID_PRODUCTO = If(Me.cbxPRODUCTOdeta.SelectedIndex >= 0, Me.cbxPRODUCTOdeta.Value, -1)
        If lEntidad.ID_PRODUCTO <> -1 Then
            lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lEntidad.ID_PRODUCTO)
            If lProducto IsNot Nothing Then
                lEntidad.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
            End If
        Else
            lEntidad.NOMBRE_PRODUCTO = Me.cbxPRODUCTOdeta.Text.ToUpper
        End If
        lEntidad.CANTIDAD = Me.speCANTIDADdeta.Value
        lEntidad.PRECIO_UNITARIO = Me.spePRECIO_UNITARIOdeta.Value
        lEntidad.SUB_TOTAL = Me.speSUB_TOTALdeta.Value
        lEntidad.PRESENTACION = Me.txtPRESENTACIONdeta.Text.ToUpper
        lEntidad.REFERENCIA = Me.lblREFERENCIA.Text

        Me.LISTA_SOLIC_PROD_TRANS.Add(lEntidad)
        Me.CargarDetalleDocumentoEnca()
        Me.AsignarMensaje("", True, False)

        Me.cbxPRODUCTOdeta.SelectedIndex = -1
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Text = ""
        Me.spePRECIO_UNITARIOdeta.Text = ""
        Me.speSUB_TOTALdeta.Text = ""
        Me.cbxPRODUCTOdeta.Focus()
        Me.SetearSubTotalIvaTotal()
        Me.MostrarOcultarCESC()
        Me.MostrarOcultarCESC()
    End Sub

    Private Function ObtenerIdProd(ByVal lista As listaSOLIC_PROD_TRANS) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_SOLIC_PROD_TRANS > Id Then
                Id = lista(i).ID_SOLIC_PROD_TRANS
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub ucListaSOLIC_PROD_TRANS1_Eliminando(ID_SOLIC_PROD_TRANS As Integer) Handles ucListaSOLIC_PROD_TRANS1.Eliminando
        Me.SetearSubTotalIvaTotal()
        Me.MostrarOcultarCESC()
    End Sub

    Protected Sub txtCODTRANSPORT_ValueChanged(sender As Object, e As EventArgs) Handles txtCODTRANSPORT.ValueChanged
        Me.CargarInfoTransportista(txtCODTRANSPORT.Value)
        Me.CargarContratos()
        If Me.cbxCONTRATO_TRANS.Items.Count > 0 Then Me.cbxCONTRATO_TRANS.SelectedIndex = 0
    End Sub

    Protected Sub cpVistaDetalleSOLIC_PROD_TRANS_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpVistaDetalleSOLIC_PROD_TRANS.Callback
        Me.SetearSubTotalIvaTotal()
        Me.MostrarOcultarCESC()
    End Sub

    Protected Sub cbxTIPO_FINANCIAMIENTO_ValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_FINANCIAMIENTO.ValueChanged
        CargarProveedorAgricola()
        Me.cbxPRODUCTOdeta.Value = Nothing
        Me.speCANTIDADdeta.Value = Nothing
        Me.spePRECIO_UNITARIOdeta.Value = Nothing

        If Me.cbxPROVEEDOR_AGRICOLAdeta.Items.Count > 0 Then
            Me.cbxPROVEEDOR_AGRICOLAdeta.SelectedIndex = 0
            Me.CargarProductos()
            If Me.cbxPRODUCTOdeta.Items.Count = 1 Then
                Me.cbxPRODUCTOdeta.SelectedIndex = 0
                Me.ProductoSeleccionado()
            End If
        End If
    End Sub

    Protected Sub cbxPROVEEDOR_AGRICOLAdeta_ValueChanged(sender As Object, e As EventArgs) Handles cbxPROVEEDOR_AGRICOLAdeta.ValueChanged
        Me.CargarProductos()
        Me.cbxPRODUCTOdeta.Focus()
    End Sub
End Class
