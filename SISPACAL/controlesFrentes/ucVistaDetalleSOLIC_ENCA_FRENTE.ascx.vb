Imports DevExpress.Web
Imports SISPACAL.BL
Imports SISPACAL.EL
Partial Class controlesFrentes_ucVistaDetalleSOLIC_ENCA_FRENTE
    Inherits ucBase

#Region "Propiedades"

    Private _ID_SOLICITUD As Int32

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
    Private mComponente As New cSOLIC_ENCA_FRENTE
    Private mEntidad As SOLIC_ENCA_FRENTE
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
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SOLIC_ENCA_FRENTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_ENCA_FRENTE
        mEntidad.ID_SOLICITUD = ID_SOLICITUD

        If mComponente.ObtenerSOLIC_ENCA_FRENTE(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtNUM_SOLIC_ZAFRA.Text = mEntidad.NUM_SOLIC_ZAFRA.ToString
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.cbxTIPO_FINANCIAMIENTO.Value = mEntidad.ID_CUENTA_FINAN

        Me.txtCOD_FRENTE.Value = mEntidad.COD_FRENTE
        Me.txtNOMBRE_FRENTE.Text = mEntidad.NOM_FRENTE
        Me.txtACTIVIDAD.Text = mEntidad.ACTIVIDAD


        Me.dteFECHA_SOLIC.Date = mEntidad.FECHA_SOLIC
        Me.cbxESTADO_SOLIC.Value = mEntidad.ID_ESTADO_SOLIC
        Me.speCUOTA_X_CORTE.Value = mEntidad.CUOTA_X_CORTE
        'Me.cbxCONDICION_COMPRA.Value = mEntidad.CONDI_COMPRA
        Me.LISTA_SOLIC_DETA_FRENTE = (New cSOLIC_DETA_FRENTE).ObtenerListaPorSOLIC_ENCA_FRENTE(mEntidad.ID_SOLICITUD)

        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()
    End Sub


    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaSOLIC_DETA_FRENTE1.CargarDatosCache(Me.lblREFERENCIA.Text)
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
        Dim listaProd As listaSOLIC_DETA_FRENTE = Me.LISTA_SOLIC_DETA_FRENTE

        If listaProd IsNot Nothing AndAlso listaProd.Count > 0 Then
            For Each lProducto As SOLIC_DETA_FRENTE In listaProd
                dSubTOTAL += lProducto.SUB_TOTAL
            Next
        End If
        dSubTOTAL = Math.Round(dSubTOTAL, 2)
        dSumas = dSubTOTAL
        dIva = Math.Round(dSumas * Utilerias.TasaIva, 2)
        dTotal = Math.Round(dSumas, 2) + dIva

        Me.speSUB_TOTAL.Value = dSubTOTAL
        Me.speSUMAS.Value = dSumas
        Me.speIVA.Value = dIva
        Me.speTOTAL.Value = dTotal
    End Sub

    Public Property LISTA_SOLIC_DETA_FRENTE As listaSOLIC_DETA_FRENTE
        Set(value As listaSOLIC_DETA_FRENTE)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaSOLIC_DETA_FRENTE) Else Return New listaSOLIC_DETA_FRENTE
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
        Me.txtCOD_FRENTE.ClientEnabled = _nuevo
        Me.txtNOMBRE_FRENTE.ClientEnabled = False
        Me.txtACTIVIDAD.ClientEnabled = _nuevo
        Me.dteFECHA_SOLIC.ClientEnabled = False
        Me.cbxESTADO_SOLIC.ClientEnabled = False
        Me.speCUOTA_X_CORTE.ClientEnabled = edicion
        'Me.cbxCONDICION_COMPRA.ClientEnabled = _nuevo
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
        Me.txtCOD_FRENTE.Value = Nothing
        Me.txtNOMBRE_FRENTE.Text = ""
        Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
        Me.cbxESTADO_SOLIC.Value = 1
        'Me.cbxCONDICION_COMPRA.Value = Nothing
        Me.txtNUM_SOLIC_ZAFRA.Value = Nothing
        If Me.TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteRoza Then
            Me.txtACTIVIDAD.Text = "SERVICIO DE FRENTE DE ROZA"
        Else
            Me.txtACTIVIDAD.Text = "SERVICIO DE FRENTE DE QUERQUEO"
        End If
        Me.dteFECHA_SOLIC.Date = cFechaHora.ObtenerFecha
        Me.speSUB_TOTAL.Value = Nothing
        Me.speIVA.Value = Nothing
        Me.speTOTAL.Value = Nothing
        Me.LISTA_SOLIC_DETA_FRENTE = New listaSOLIC_DETA_FRENTE
        Me.CargarDetalleDocumentoEnca()

        'Me.cbxCONDICION_COMPRA.SelectedIndex = 0
        Me.cbxPROVEEDOR_AGRICOLAdeta.Text = ""
        Me.cbxPRODUCTOdeta.SelectedIndex = -1
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Text = ""
        Me.spePRECIO_UNITARIOdeta.Text = ""
        Me.speSUB_TOTALdeta.Text = ""
        Me.speCUOTA_X_CORTE.Value = 0
        Me.cbxPRODUCTOdeta.Focus()
    End Sub

    Private Sub CargarInfoFrente(ByVal COD_FRENTE As String)
        Me.lblID_FRENTE.Text = ""
        Me.txtNOMBRE_FRENTE.Text = ""

        If Me.TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteRoza Then
            Dim lEntidad As PROVEEDOR_ROZA
            lEntidad = (New cPROVEEDOR_ROZA).ObtenerPorCODIGO(COD_FRENTE)
            If lEntidad IsNot Nothing Then
                Me.lblID_FRENTE.Text = lEntidad.ID_PROVEEDOR_ROZA.ToString
                Me.txtNOMBRE_FRENTE.Text = Trim(Replace(lEntidad.NOMBRE_PROVEEDOR_ROZA, txtCOD_FRENTE.Text.ToUpper, ""))
                Me.txtNOMBRE_FRENTE.Text = Trim(Replace(Me.txtNOMBRE_FRENTE.Text, "-", ""))
                Me.txtACTIVIDAD.Text = lEntidad.ACTIVIDAD
            End If
        ElseIf Me.TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteQuerqueo Then
            Dim listaProveeQQ As listaPROVEEDOR_QUERQUEO
            listaProveeQQ = (New cPROVEEDOR_QUERQUEO).ObtenerListaPorCODISIS(COD_FRENTE)
            If listaProveeQQ IsNot Nothing AndAlso listaProveeQQ.Count > 0 Then
                Me.lblID_FRENTE.Text = listaProveeQQ(0).ID_PROVEE_QQ.ToString
                Me.txtNOMBRE_FRENTE.Text = listaProveeQQ(0).NOMBRES + " " + listaProveeQQ(0).APELLIDOS
                Me.txtACTIVIDAD.Text = "CULTIVO DE CAÑA"
            End If
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
        'If Me.cbxCONDICION_COMPRA.Value IsNot Nothing AndAlso Me.cbxCONDICION_COMPRA.Value = 3 Then enConsigna = 1

        lista = (New cPRODUCTO).ObtenerListaPorCriterios(idProveedor, -1, idCuentaFinan, -1, 1, -1, "NOMBRE_PRODUCTO", "ASC", True)
        If Not (lista IsNot Nothing AndAlso lista.Count > 0) Then
            lista = New listaPRODUCTO
        End If

        Me.cbxPRODUCTOdeta.DataSource = lista
        Me.cbxPRODUCTOdeta.DataBind()
        If Me.cbxPRODUCTOdeta.Items.FindByValue(idProducto) IsNot Nothing Then Me.cbxPRODUCTOdeta.Value = idProducto
    End Sub

    Public Function Aceptar() As String
        Dim bSolic As New cSOLIC_ENCA_FRENTE
        Dim mEntidad As SOLIC_ENCA_FRENTE
        Dim lRet As Int32 = 0
        Dim sError As New StringBuilder

        If Me.speCUOTA_X_CORTE.Value Is Nothing OrElse Convert.ToDecimal(Me.speCUOTA_X_CORTE.Value) = 0 Then
            Return "* Ingrese la cuota a descontar por corte"
        End If
        If Convert.ToDecimal(Me.speCUOTA_X_CORTE.Value) > Convert.ToDecimal(Me.speTOTAL.Value) Then
            Return "* La a descontar por corte no puede ser mayor al monto total de la solicitud"
        End If

        mEntidad = (New cSOLIC_ENCA_FRENTE).ObtenerSOLIC_ENCA_FRENTE(Me.ID_SOLICITUD)
        mEntidad.ID_ESTADO_SOLIC = 2
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        bSolic.ActualizarSOLIC_ENCA_FRENTE(mEntidad)

        Me.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLIC_ENCA_FRENTE
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
        Dim lDetalle As listaSOLIC_DETA_FRENTE = Me.LISTA_SOLIC_DETA_FRENTE
        Dim bSolicProd As New cSOLIC_DETA_FRENTE

        mEntidad = New SOLIC_ENCA_FRENTE
        If Me._nuevo Then
            mEntidad.ID_SOLICITUD = 0
            mEntidad.NUM_SOLIC_ZAFRA = 0
            mEntidad.UID_SOLIC_ENCA_FRENTE = Guid.NewGuid

            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerSOLIC_ENCA_FRENTE(Me.ID_SOLICITUD)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If

        If Me.cbxZAFRA.Value Is Nothing Then
            Return "* Seleccione la Zafra"
        End If
        If Me.cbxTIPO_FINANCIAMIENTO.Value Is Nothing Then
            Return "* Seleccione el Tipo de Financiamiento"
        End If
        If Me.txtCOD_FRENTE.Value Is Nothing Then
            Return "* Ingrese el codigo de frente"
        End If
        If Me.lblID_FRENTE.Text = "" Then
            Return "* Ingrese el frente"
        End If
        'If Me.cbxCONDICION_COMPRA.Value Is Nothing Then
        '    Return "* Seleccione la Condicion de Compra"
        'End If
        If lDetalle Is Nothing OrElse (lDetalle IsNot Nothing AndAlso lDetalle.Count = 0) Then
            Return "* Ingrese el detalle de productos"
        End If
        If Me.speCUOTA_X_CORTE.Value IsNot Nothing AndAlso Convert.ToDecimal(Me.speCUOTA_X_CORTE.Value) > Convert.ToDecimal(Me.speTOTAL.Value) Then
            Return "* La cuota a descontar por corte no puede ser mayor al monto total de la solicitud"
        End If

        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.ID_CUENTA_FINAN = Me.cbxTIPO_FINANCIAMIENTO.Value
        mEntidad.ID_TIPO_PROVEEDOR = Me.TIPO_PROVEEDOR
        'mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value
        mEntidad.ID_FRENTE = Convert.ToInt32(Me.lblID_FRENTE.Text)
        mEntidad.COD_FRENTE = Me.txtCOD_FRENTE.Value.ToString.Trim.ToUpper
        mEntidad.NOM_FRENTE = Me.txtNOMBRE_FRENTE.Text.ToUpper
        mEntidad.ACTIVIDAD = Me.txtACTIVIDAD.Text.Trim.ToUpper
        mEntidad.FECHA_SOLIC = Me.dteFECHA_SOLIC.Date
        mEntidad.SUB_TOTAL = Me.speSUB_TOTAL.Value
        mEntidad.IVA = Me.speIVA.Value
        mEntidad.TOTAL = Me.speTOTAL.Value
        mEntidad.ID_ESTADO_SOLIC = Me.cbxESTADO_SOLIC.Value
        mEntidad.OBSERVACIONES = ""
        If Me.speCUOTA_X_CORTE.Value IsNot Nothing Then
            mEntidad.CUOTA_X_CORTE = Convert.ToDecimal(Me.speCUOTA_X_CORTE.Value)
        Else
            mEntidad.CUOTA_X_CORTE = 0
        End If
        lZafra = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value)
        mEntidad.ZAFRA = lZafra.NOMBRE_ZAFRA


        If mEntidad.ID_ESTADO_SOLIC = Enumeradores.EstadoSolicAgricola.Pendiente Then
            ' **************************************************************
            ' ACTUALIZAR ENCABEZADO DE LA SOLICITUD
            ' **************************************************************
            If mComponente.ActualizarSOLIC_ENCA_FRENTE(mEntidad) < 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If

            ' **************************************************************
            ' ACTUALIZAR DETALLE DE PRODUCTOS DE LA SOLICITUD
            ' **************************************************************

            'Eliminar detalle por si existe previamente
            bSolicProd.EliminarSOLIC_DETA_FRENTE_Por_ID_SOLICITUD(mEntidad.ID_SOLICITUD)

            If lDetalle IsNot Nothing AndAlso lDetalle.Count > 0 Then
                For i = 0 To lDetalle.Count - 1
                    Dim lSoliProd As SOLIC_DETA_FRENTE = lDetalle(i)
                    lSoliProd.ID_SOLIC_DETA = 0
                    lSoliProd.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                    bSolicProd.ActualizarSOLIC_DETA_FRENTE(lSoliProd)
                Next
            End If
        End If

        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarSolicFrente(" + mEntidad.ID_SOLICITUD.ToString + ")", True)

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
        Dim lEntidad As New SOLIC_DETA_FRENTE
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
        If Me.LISTA_SOLIC_DETA_FRENTE IsNot Nothing AndAlso Me.LISTA_SOLIC_DETA_FRENTE.Count > 0 AndAlso Me.cbxPRODUCTOdeta.Value IsNot Nothing Then
            lProducto = (New cPRODUCTO).ObtenerPRODUCTO(Me.cbxPRODUCTOdeta.Value)
            If lProducto IsNot Nothing Then
                Dim lista As listaSOLIC_DETA_FRENTE = Me.LISTA_SOLIC_DETA_FRENTE
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

        lEntidad.ID_SOLIC_DETA = Me.ObtenerIdProd(Me.LISTA_SOLIC_DETA_FRENTE)
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

        Me.LISTA_SOLIC_DETA_FRENTE.Add(lEntidad)
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

    Private Function ObtenerIdProd(ByVal lista As listaSOLIC_DETA_FRENTE) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_SOLIC_DETA > Id Then
                Id = lista(i).ID_SOLIC_DETA
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub ucListaSOLIC_PROD_TRANS1_Eliminando(ID_SOLIC_PROD_TRANS As Integer) Handles ucListaSOLIC_DETA_FRENTE1.Eliminando
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub txtCOD_FRENTE_ValueChanged(sender As Object, e As EventArgs) Handles txtCOD_FRENTE.ValueChanged
        Me.CargarInfoFrente(txtCOD_FRENTE.Value)
    End Sub

    Protected Sub cpVistaDetalleSOLIC_PROD_TRANS_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpVistaDetalleSOLIC_DETA_FRENTE.Callback
        Me.SetearSubTotalIvaTotal()
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
