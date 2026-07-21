Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Collections.Generic
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data

Partial Class controles_ucVistaDetalleORDEN_COMBUSTIBLE
    Inherits ucBase

    Private dsDetalle As DataSet
    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cORDEN_COMBUSTIBLE
    Private mEntidad As ORDEN_COMBUSTIBLE
    Public Event ErrorEvent(ByVal errorMessage As String)

#Region "Propiedades"

    Private _ID_ORDEN_COMBUS As Int32
    Public Property ID_ORDEN_COMBUS() As Int32
        Get
            Return Me.txtID_ORDEN_COMBUS.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ORDEN_COMBUS = Value
            If Value = 0 Then Me.txtID_ORDEN_COMBUS.Text = "" Else Me.txtID_ORDEN_COMBUS.Text = CStr(Value)
            If Me._ID_ORDEN_COMBUS > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    public Property OrdenDetalle As DataSet
        Get
            If Me.ViewState("OrdenDetalle") Is Nothing Then
                Me.ViewState("OrdenDetalle") = dsDetalle
            End If
            Return Me.ViewState("OrdenDetalle")
        End Get
        Set(value As DataSet)
            Me.ViewState("OrdenDetalle") = value
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
                Me._ID_ORDEN_COMBUS = 0
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
            Me.txtCODIGO.Focus()
        End Set
    End Property

    Private Sub CargarProductos()
        Dim lProductos As listaPRODUCTO_COMBUSTIBLE
        lProductos = (New cPRODUCTO_COMBUSTIBLE).ObtenerLista(False, "NOMBRE_PRODUCTO")
        lstPRODUCTOS.DataSource = lProductos
        lstPRODUCTOS.DataBind()
    End Sub

    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_ORDEN_COMBUS.Enabled = (TIPO_OPERACION <> TipoOperacion.Emision)
        Me.ddlZAFRAID_ZAFRA.Enabled = False
        Me.ddlPROVEEDOR_COMBUSTIBLE1.Enabled = edicion
        Me.ddlTIPO_PROVEEDOR1.Enabled = edicion
        Me.txtCODIGO.Enabled = edicion
        Me.txtSOCIO.Enabled = edicion
        Me.txtNOMBRE_CLIENTE.Enabled = False
        Me.txtPLACA_VEHIC.Enabled = edicion
        Me.txtPLACA_VEHIC_DropDownExtender.Enabled = edicion
        Me.panelPLACAS.Visible = edicion
        Me.ddlSECCION1.Enabled = False
        Me.txtOBSERVACION.Enabled = edicion

        Me.cbxMOTORISTA.ClientEnabled = edicion

        Me.txtDUI.Enabled = edicion
        Me.txtLICENCIA.Enabled = edicion
        Me.txtNIT.Enabled = edicion
        Me.txtNRC.Enabled = edicion

        Me.txtFECHA_DESPACHO.Enabled = (edicion AndAlso TIPO_OPERACION = TipoOperacion.Facturacion)
        Me.txtNO_FACTURA_CCF.Enabled = (edicion AndAlso TIPO_OPERACION = TipoOperacion.Facturacion)
        Me.txtTOTAL.Enabled = (edicion AndAlso TIPO_OPERACION = TipoOperacion.Facturacion)
        Me.txtCANTIDAD.Enabled = (edicion OrElse TIPO_OPERACION = TipoOperacion.Facturacion)
        Me.txtPRECIO_UNITARIO.Enabled = (edicion OrElse TIPO_OPERACION = TipoOperacion.Facturacion)
        Me.divFactura.Visible = (TIPO_OPERACION = TipoOperacion.Facturacion)
        Me.txtMOTIVO_ANULACION.Enabled = edicion
        Me.divAnulacion.Visible = (TIPO_OPERACION = TipoOperacion.Anulacion)
    End Sub

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

    Private Sub ConfigurarEncabezado()
        Dim entZafra As New ZAFRA

        Me.ddlZAFRAID_ZAFRA.Recuperar()
        entZafra = (New cZAFRA).ObtenerZafraActiva()

        If entZafra IsNot Nothing Then
            Me.ddlZAFRAID_ZAFRA.SelectedValue = entZafra.ID_ZAFRA
        End If
    End Sub

    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        ConfigurarEncabezado()
        Me.ddlPROVEEDOR_COMBUSTIBLE1.Recuperar()
        Me.ddlTIPO_PROVEEDOR1.RecuperarParaCombustible()
        Me.ddlSECCION1.RecuperarListaParaOrdenCombustible(True, False)
        Me.ddlSECCION1.Enabled = False
        Me.txtSOCIO.Text = ""
        Me.txtSOCIO.Visible = (Me.ddlTIPO_PROVEEDOR1.SelectedValue = TipoProveedor.Cañero)
        Me.AsignarMensaje("", False, False)
        Me.txtID_ORDEN_COMBUS.Text = ""
        Me.txtCODIGO.Text = ""
        Me.txtNOMBRE_CLIENTE.Text = ""
        Me.txtPLACA_VEHIC.Text = ""
        Me.cbxMOTORISTA.Value = Nothing
        Me.lstTRANSPORTE.Items.Clear()
        Me.txtNO_FACTURA_CCF.Text = ""
        Me.txtTOTAL.Text = ""
        Me.txtFECHA_DESPACHO.Text = ""
        Me.txtCANTIDAD.Text = ""
        Me.txtPRECIO_UNITARIO.Text = ""
        Me.txtMOTIVO_ANULACION.Text = ""
        Me.lblTOTAL.Text = "0.00"
        Me.grdDetalle.Enabled = True
        Me.btnAgregar.Text = "Agregar"
        Me.txtNIT.Text = ""
        Me.txtNRC.Text = ""
        Me.txtOBSERVACION.Text = ""
        InicializarDetalle()
    End Sub

    Private Sub RecuperarPlacasPorTransportista(ByVal CODTRANSPORT As String)
        Dim lPlacas As listaTRANSPORTE
        lPlacas = (New cTRANSPORTE).ObtenerListaPorTRANSPORTISTA(CODTRANSPORT)
        lstTRANSPORTE.DataSource = lPlacas
        lstTRANSPORTE.DataBind()
    End Sub
    
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ENVIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

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
        Me.txtID_ORDEN_COMBUS.Text = mEntidad.ID_ORDEN_COMBUS.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.ddlPROVEEDOR_COMBUSTIBLE1.Recuperar()
        Me.ddlPROVEEDOR_COMBUSTIBLE1.SelectedValue = mEntidad.ID_PROVEEDOR_COMBUS
        If mEntidad.ID_SECCION <> -1 Then
            Me.ddlSECCION1.RecuperarListaParaOrdenCombustible(True, False)
            Me.ddlSECCION1.SelectedValue = mEntidad.ID_SECCION
        End If
        Me.ddlTIPO_PROVEEDOR1.SelectedValue = mEntidad.ID_TIPO_PROVEEDOR
        If mEntidad.ID_TIPO_PROVEEDOR = TipoProveedor.Cañero Then
            Dim lProveedor As PROVEEDOR
            Me.txtCODIGO.Text = CInt(Left(mEntidad.CODIGO, 6))
            If CInt(Right(mEntidad.CODIGO, 4)) > 0 Then
                Me.txtSOCIO.Text = CInt(Right(mEntidad.CODIGO, 4))
            Else
                Me.txtSOCIO.Text = " "
            End If
            Me.txtSOCIO.Visible = True
            lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIGO)
            Me.txtNOMBRE_CLIENTE.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS
        Else
            Dim lTransportista As TRANSPORTISTA
            Me.txtCODIGO.Text = mEntidad.CODIGO
            lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(mEntidad.CODIGO)
            Me.txtNOMBRE_CLIENTE.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
        End If
        Me.txtPLACA_VEHIC.Text = mEntidad.PLACA
        If mEntidad.ID_TIPO_PROVEEDOR = TipoProveedor.Transportista Then
            RecuperarPlacasPorTransportista(mEntidad.CODIGO)
            'If lstTRANSPORTE.Items.FindByText(mEntidad.PLACA) IsNot Nothing Then
            '    lstTRANSPORTE.Items.FindByText(mEntidad.PLACA).Selected = True
            '    Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(mEntidad.CODIGO), mEntidad.PLACA)
            '    If lTransporte IsNot Nothing Then
            '        RecuperarMotoristaPorTransporte(lTransporte.ID_TRANSPORTE)
            '        If lstMOTORISTA.Items.FindByText(Me.txtNOMBRES_MOTORISTA.Text) IsNot Nothing Then
            '            lstMOTORISTA.Items.FindByText(Me.txtNOMBRES_MOTORISTA.Text).Selected = True
            '        End If
            '    End If
            'End If
        End If
        If Me.cbxMOTORISTA.Items.FindByValue(mEntidad.ID_MOTORISTA) IsNot Nothing Then
            Me.cbxMOTORISTA.SelectedItem = Me.cbxMOTORISTA.Items.FindByValue(mEntidad.ID_MOTORISTA)
        Else
            Me.cbxMOTORISTA.Text = mEntidad.NOMBRES_MOTORISTA
        End If
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtLICENCIA.Text = mEntidad.LICENCIA
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtNRC.Text = mEntidad.NRC
        Me.txtOBSERVACION.Text = mEntidad.OBSERVACION

        Dim listaProductos As listaORDEN_COMBUSTIBLE_PROD = (New cORDEN_COMBUSTIBLE_PROD).ObtenerListaPorORDEN_COMBUSTIBLE(mEntidad.ID_ORDEN_COMBUS)
        If listaProductos IsNot Nothing AndAlso listaProductos.Count > 0 Then
            For Each lProducto As ORDEN_COMBUSTIBLE_PROD In listaProductos
                Dim dr As DataRow = OrdenDetalle.Tables(0).NewRow
                dr("ID_PRODUCTO") = lProducto.ID_PRODUCTO
                dr("PRODUCTO") = (New cPRODUCTO_COMBUSTIBLE).ObtenerPRODUCTO_COMBUSTIBLE(lProducto.ID_PRODUCTO).NOMBRE_PRODUCTO
                dr("CANTIDAD") = lProducto.CANTIDAD
                dr("PRECIO_VENTA") = lProducto.PRECIO_VENTA
                dr("TOTAL") = Math.Round(lProducto.CANTIDAD * lProducto.PRECIO_VENTA, 2)
                dr("ID_ORDEN_COMBUSTIBLE_PROD") = lProducto.ID_ORDEN_COMBUSTIBLE_PROD

                OrdenDetalle.Tables(0).Rows.Add(dr)
            Next
            grdDetalle.DataSource = Me.OrdenDetalle
            grdDetalle.DataBind()
        End If

        If Me.TIPO_OPERACION = TipoOperacion.Facturacion OrElse Me.TIPO_OPERACION = TipoOperacion.Anulacion Then
            If mEntidad.FECHA_DESPACHO <> #12:00:00 AM# Then Me.txtFECHA_DESPACHO.Text = mEntidad.FECHA_DESPACHO.ToString("dd/MM/yyyy")
            Me.txtTOTAL.Text = mEntidad.TOTAL.ToString("#,##0.00")
            If mEntidad.NO_FACTURA_CCF <> "" AndAlso mEntidad.NO_FACTURA_CCF <> Nothing Then Me.txtNO_FACTURA_CCF.Text = mEntidad.NO_FACTURA_CCF
            If Me.mEntidad.MOTIVO_ANULACION <> "" Then
                Me.txtMOTIVO_ANULACION.Text = mEntidad.MOTIVO_ANULACION
            End If
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ORDEN_COMBUS") Is Nothing Then Me.ID_ORDEN_COMBUS = Me.ViewState("ID_ORDEN_COMBUS")
        If Not IsPostBack Then
            CargarProductos()
            InicializarDetalle()
        End If
    End Sub

    Private Sub InicializarDetalle()
        Dim dt As New DataTable("detalle")
        dt.Columns.Add("ID_PRODUCTO", System.Type.GetType("System.Int32"))
        dt.Columns.Add("PRODUCTO", System.Type.GetType("System.String"))
        dt.Columns.Add("CANTIDAD", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("PRECIO_VENTA", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("TOTAL", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("ID_ORDEN_COMBUSTIBLE_PROD", System.Type.GetType("System.Int32"))
        dsDetalle = New DataSet
        dsDetalle.Tables.Add(dt)
        Me.OrdenDetalle = dsDetalle
        Me.grdDetalle.DataSource = Me.OrdenDetalle
        Me.grdDetalle.DataBind()
    End Sub

    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim alDatos As New ArrayList
        Dim fechaDespacho As DateTime
        Dim lRet As Integer

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
            sError.AppendLine(" * Orden ya se encuentra anulada.<br>")
        End If
        If Me.ddlZAFRAID_ZAFRA.SelectedValue Is Nothing Then
            sError.AppendLine(" * No existe Periodo de Zafra.<br>")
        End If
        If ddlPROVEEDOR_COMBUSTIBLE1.SelectedValue Is Nothing Then
            sError.AppendLine(" * Seleccione el proveedor de combustible.<br>")
        End If
        If ddlSECCION1.Enabled AndAlso ddlSECCION1.SelectedValue = -1 Then
            sError.AppendLine(" * Seleccione la seccion.<br>")
        End If
        If Me.txtCODIGO.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el codigo de cliente.<br>")
        End If
        If ddlTIPO_PROVEEDOR1.SelectedValue = TipoProveedor.Transportista AndAlso txtPLACA_VEHIC.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el numero de placa.<br>")
        End If
        If ddlTIPO_PROVEEDOR1.SelectedValue = TipoProveedor.Transportista AndAlso Me.cbxMOTORISTA.Text.Trim = "" Then
            sError.AppendLine(" * Seleccione o ingrese el nombre del motorista.<br>")
        End If
        If Me.txtDUI.Text.Trim <> "" AndAlso Me.txtDUI.Text.Trim.Length < 9 Then
            sError.AppendLine(" * DUI no valido.<br>")
        End If
        'If Me.txtLICENCIA.Text.Trim = "" Then
        '    sError.AppendLine(" * Ingrese numero de LICENCIA.<br>")
        'End If
        If TIPO_OPERACION = TipoOperacion.Emision Then
            If OrdenDetalle.Tables(0).Rows.Count = 0 Then
                sError.AppendLine(" * Ingrese el detalle de la Orden.<br>")
            End If
        End If
        If TIPO_OPERACION = TipoOperacion.Facturacion Then
            If txtNO_FACTURA_CCF.Text.Trim = "" Then
                sError.AppendLine(" * Ingrese No. de Factura.<br>")
            End If
            If Not System.DateTime.TryParse(Me.txtFECHA_DESPACHO.Text, _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaDespacho) Then
                sError.AppendLine(" * Fecha de despacho invalida.<br>")
            End If
            If OrdenDetalle.Tables(0).Rows.Count = 0 Then
                sError.AppendLine(" * Ingrese el detalle de la Orden.<br>")
            End If
            If Not IsNumeric(Me.txtTOTAL.Text) Then
                sError.AppendLine(" * Monto de la orden debe ser numerico.<br>")
            End If
        End If
        If TIPO_OPERACION = TipoOperacion.Anulacion Then
            If Me.txtMOTIVO_ANULACION.Text.Trim = "" Then
                sError.AppendLine(" * Ingrese motivo de la anulacion.<br>")
            End If
        End If
        If sError.ToString.Length > 0 Then
            AsignarMensaje(sError.ToString, True)
            Return sError.ToString
        End If
        mEntidad.ID_ZAFRA = ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.ID_PROVEEDOR_COMBUS = ddlPROVEEDOR_COMBUSTIBLE1.SelectedValue
        mEntidad.ID_TIPO_PROVEEDOR = ddlTIPO_PROVEEDOR1.SelectedValue
        If Me.ddlTIPO_PROVEEDOR1.SelectedValue = TipoProveedor.Cañero Then
            mEntidad.CODIGO = Utilerias.FormatoCODIPROVEE(txtCODIGO.Text.Trim) + Utilerias.FormatoCODISOCIO(txtSOCIO.Text.Trim)
        Else
            mEntidad.CODIGO = txtCODIGO.Text
        End If
        mEntidad.FECHA_EMISION = cFechaHora.ObtenerFecha
        mEntidad.PLACA = txtPLACA_VEHIC.Text.ToUpper
        If ddlTIPO_PROVEEDOR1.SelectedValue = TipoProveedor.Transportista Then
            Dim bTransporte As New cTRANSPORTE
            Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(txtCODIGO.Text), Me.txtPLACA_VEHIC.Text)
            If lTransporte IsNot Nothing AndAlso lTransporte.ID_TRANSPORTE > 0 Then
                mEntidad.ID_TRANSPORTE = lTransporte.ID_TRANSPORTE
            Else
                mEntidad.ID_TRANSPORTE = -1
            End If
        Else
            mEntidad.ID_TRANSPORTE = -1
        End If

        If Me.cbxMOTORISTA.Value Is Nothing Then
            mEntidad.NOMBRES_MOTORISTA = cbxMOTORISTA.Text.Trim.ToUpper
            mEntidad.ID_MOTORISTA = -1
        Else
            mEntidad.NOMBRES_MOTORISTA = cbxMOTORISTA.Text.Trim.ToUpper
            If Me.cbxMOTORISTA.Value IsNot Nothing AndAlso IsNumeric(Me.cbxMOTORISTA.Value) Then
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
        If Me.ddlTIPO_PROVEEDOR1.SelectedValue = TipoProveedor.Transportista AndAlso Me.txtCODIGO.Text = "300" Then
            mEntidad.ID_SECCION = Me.ddlSECCION1.SelectedValue
        Else
            mEntidad.ID_SECCION = -1
        End If
        mEntidad.OBSERVACION = If(Me.txtOBSERVACION.Text.Trim <> "", Me.txtOBSERVACION.Text.Trim.ToUpper, Nothing)

        mEntidad.APELLIDOS_MOTORISTA = ""
        If TIPO_OPERACION = TipoOperacion.Emision Then
            Dim dblTotal As Decimal = 0
            mEntidad.ESTADO = "E"
            mEntidad.FECHA_DESPACHO = #12:00:00 AM#
            mEntidad.NO_FACTURA_CCF = Nothing
            mEntidad.FECHA_ANULACION = #12:00:00 AM#
            mEntidad.MOTIVO_ANULACION = Nothing
            For Each fila As DataRow In OrdenDetalle.Tables(0).Rows
                dblTotal += fila("CANTIDAD") * fila("PRECIO_VENTA")
            Next
            mEntidad.TOTAL = dblTotal
            mEntidad.ID_CATORCENA = -1
            mEntidad.ID_ORDEN_COMBUSTIBLE_NUM = -1
        ElseIf TIPO_OPERACION = TipoOperacion.Facturacion Then
            mEntidad.ESTADO = "F"
            mEntidad.FECHA_DESPACHO = fechaDespacho
            mEntidad.NO_FACTURA_CCF = txtNO_FACTURA_CCF.Text
            mEntidad.FECHA_ANULACION = #12:00:00 AM#
            mEntidad.MOTIVO_ANULACION = Nothing
            mEntidad.TOTAL = CDec(Me.txtTOTAL.Text)
        ElseIf TIPO_OPERACION = TipoOperacion.Anulacion Then
            mEntidad.ESTADO = "A"
            mEntidad.FECHA_ANULACION = cFechaHora.ObtenerFechaHora
            mEntidad.MOTIVO_ANULACION = Me.txtMOTIVO_ANULACION.Text.Trim.ToUpper
        End If
        mEntidad.ID_MOTORISTA_VEHI = -1

        lRet = mComponente.ActualizarORDEN_COMBUSTIBLE(mEntidad, TipoConcurrencia.Pesimistica)
        If lRet = -2 Then
            MostrarMensaje(mComponente.sError, "Advertencia")
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
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Select Case TIPO_OPERACION
            Case TipoOperacion.Emision
                Me.MostrarMensaje("Orden emitida con exito")
                ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarOrdenCombustible(" + mEntidad.ID_ORDEN_COMBUS.ToString + ")", True)

            Case TipoOperacion.Facturacion
                Me.MostrarMensaje("Orden facturada con exito")
            Case TipoOperacion.Anulacion
                Me.MostrarMensaje("Orden anulada con exito")
        End Select

        Return ""
    End Function

    Private Sub GuardarDetalle(ByVal ID_ORDEN_COMBUS As Integer)
        Dim bOrdenCombustibleProd As New cORDEN_COMBUSTIBLE_PROD
        Dim lOrdenCombustibleProd As ORDEN_COMBUSTIBLE_PROD

        bOrdenCombustibleProd.EliminarPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)

        For Each fila As DataRow In OrdenDetalle.Tables(0).Rows
            lOrdenCombustibleProd = New ORDEN_COMBUSTIBLE_PROD
            lOrdenCombustibleProd.ID_ORDEN_COMBUSTIBLE_PROD = 0
            lOrdenCombustibleProd.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
            lOrdenCombustibleProd.ID_PRODUCTO = fila("ID_PRODUCTO")
            lOrdenCombustibleProd.CANTIDAD = fila("CANTIDAD")
            lOrdenCombustibleProd.PRECIO_VENTA = fila("PRECIO_VENTA")
            lOrdenCombustibleProd.USUARIO_CREA = Me.ObtenerUsuario
            lOrdenCombustibleProd.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lOrdenCombustibleProd.USUARIO_ACT = Me.ObtenerUsuario
            lOrdenCombustibleProd.FECHA_ACT = cFechaHora.ObtenerFechaHora
            bOrdenCombustibleProd.ActualizarORDEN_COMBUSTIBLE_PROD(lOrdenCombustibleProd)
        Next
    End Sub

    Public Sub Totalizar()
        Dim dTotal As Decimal = 0
        Dim dCantidad As Decimal = 0
        Dim dPrecioUnitario As Decimal = 0

        If IsNumeric(Me.txtCANTIDAD.Text) AndAlso IsNumeric(Me.txtPRECIO_UNITARIO.Text) Then
            dCantidad = Convert.ToDecimal(Me.txtCANTIDAD.Text)
            dPrecioUnitario = Convert.ToDecimal(Me.txtPRECIO_UNITARIO.Text)
            dTotal = Math.Round(dCantidad * dPrecioUnitario, 2)
        End If
        Me.lblTOTAL.Text = dTotal.ToString("#,##0.00")
    End Sub

    Protected Sub txtCODIGO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODIGO.TextChanged

        txtNOMBRE_CLIENTE.Text = ""
        txtCODIGO.Text = txtCODIGO.Text.Trim
        ddlSECCION1.SelectedIndex = -1
        ddlSECCION1.Enabled = False
        RecuperarPlacasPorTransportista(-1)
        If Not Utilerias.EsNumeroEntero(txtCODIGO.Text) Then
            Me.txtCODIGO.Text = ""
            Me.txtNOMBRE_CLIENTE.Text = ""
            Me.RecuperarPlacasPorTransportista(-1)
            Me.txtPLACA_VEHIC.Text = ""
            Me.cbxMOTORISTA.Value = Nothing
            Me.txtDUI.Text = ""
            Me.txtLICENCIA.Text = ""
            Me.txtNIT.Text = ""
            Me.txtNRC.Text = ""
            Me.txtCODIGO.Focus()
            Exit Sub
        End If
        txtCODIGO.Text = CInt(txtCODIGO.Text)
        If ddlTIPO_PROVEEDOR1.SelectedValue = Enumeradores.TipoProveedor.Transportista Then
            Dim entidad As TRANSPORTISTA
            entidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Convert.ToInt32(txtCODIGO.Text))
            If entidad IsNot Nothing Then
                txtNOMBRE_CLIENTE.Text = Trim(entidad.NOMBRES + " " + entidad.APELLIDOS)
                RecuperarPlacasPorTransportista(Convert.ToDecimal(txtCODIGO.Text))
                txtPLACA_VEHIC.Text = ""
                Me.cbxMOTORISTA.Value = Nothing
                Me.txtNIT.Enabled = Not (Me.txtCODIGO.Text = "300")
                Me.txtNRC.Enabled = Not (Me.txtCODIGO.Text = "300")

                Me.txtNIT.Text = Utilerias.FormatearNIT(entidad.NIT)
                Me.txtNRC.Text = entidad.CREDITO_FISCAL

                Me.txtNIT.Enabled = (Me.txtNIT.Text = "")
                Me.txtNRC.Enabled = (Me.txtNRC.Text = "")
                Me.ddlSECCION1.Enabled = (Me.txtCODIGO.Text = "300")
                txtPLACA_VEHIC.Focus()
            Else
                AsignarMensaje(" * Codigo de transportista no esta registrado", True, True)
                txtCODIGO.Text = ""
                txtPLACA_VEHIC.Text = ""
                Me.cbxMOTORISTA.Value = Nothing
                txtCODIGO.Focus()
            End If
        ElseIf ddlTIPO_PROVEEDOR1.SelectedValue = Enumeradores.TipoProveedor.Motorista Then
            Dim lMotoristaVehi As MOTORISTA_VEHICULO
            Dim lMotorista As MOTORISTA

            lMotoristaVehi = (New cMOTORISTA_VEHICULO).ObtenerMOTORISTA_VEHICULO(Convert.ToInt32(txtCODIGO.Text))
            If lMotoristaVehi IsNot Nothing Then
                If lMotoristaVehi.ACTIVO = False Then
                    AsignarMensaje(" * Motorista esta inactivo en el sistema", True, True)
                    Return
                ElseIf lMotoristaVehi.CASTIGADO = False Then
                    AsignarMensaje(" * Motorista esta se encuentra castigado", True, True)
                    Return
                End If

                lMotorista = (New cMOTORISTA).ObtenerMOTORISTA(lMotoristaVehi.ID_MOTORISTA)
                txtNOMBRE_CLIENTE.Text = Trim(lMotorista.NOMBRES + " " + lMotorista.APELLIDOS)

                Dim lTransporte As TRANSPORTE
                lTransporte = (New cTRANSPORTE).ObtenerTRANSPORTE(Convert.ToInt32(lMotoristaVehi.ID_TRANSPORTE))
                If lTransporte IsNot Nothing Then
                    Dim lTransportista As TRANSPORTISTA
                    lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(lTransporte.CODTRANSPORT)
                    If lTransportista IsNot Nothing Then
                        RecuperarPlacasPorTransportista(Convert.ToDecimal(txtCODIGO.Text))
                        txtPLACA_VEHIC.Text = ""
                        Me.cbxMOTORISTA.Value = Nothing
                        Me.txtNIT.Enabled = Not (Me.txtCODIGO.Text = "300")
                        Me.txtNRC.Enabled = Not (Me.txtCODIGO.Text = "300")

                        Me.txtNIT.Text = Utilerias.FormatearNIT(lTransportista.NIT)
                        Me.txtNRC.Text = lTransportista.CREDITO_FISCAL

                        Me.txtNIT.Enabled = (Me.txtNIT.Text = "")
                        Me.txtNRC.Enabled = (Me.txtNRC.Text = "")
                        Me.ddlSECCION1.Enabled = (Me.txtCODIGO.Text = "300")
                        txtPLACA_VEHIC.Focus()
                    End If
                End If
            Else
                AsignarMensaje(" * Codigo de motorista no esta registrado", True, True)
                txtCODIGO.Text = ""
                txtPLACA_VEHIC.Text = ""
                Me.cbxMOTORISTA.Value = Nothing
                txtCODIGO.Focus()
            End If
        End If
    End Sub

    Private Sub ObtenerCliente()
        Me.txtCODIGO.Text = Me.txtCODIGO.Text.Trim
        Me.txtSOCIO.Text = Me.txtSOCIO.Text.Trim

        Me.txtNOMBRE_CLIENTE.Text = ""
        Me.RecuperarPlacasPorTransportista(-1)
        Me.txtPLACA_VEHIC.Text = ""
        Me.cbxMOTORISTA.Value = Nothing
        Me.txtDUI.Text = ""
        Me.txtLICENCIA.Text = ""

        If Not Utilerias.EsNumeroEntero(txtCODIGO.Text) Then
            Me.txtCODIGO.Text = ""
            Me.txtSOCIO.Text = ""
            Me.txtCODIGO.Focus()
            Exit Sub
        End If
        txtCODIGO.Text = CInt(txtCODIGO.Text)
        If ddlTIPO_PROVEEDOR1.SelectedValue = Enumeradores.TipoProveedor.Transportista Then
            Dim entidad As TRANSPORTISTA
            entidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Convert.ToInt32(txtCODIGO.Text))
            If entidad IsNot Nothing Then
                txtNOMBRE_CLIENTE.Text = Trim(entidad.NOMBRES + " " + entidad.APELLIDOS)
                RecuperarPlacasPorTransportista(Convert.ToDecimal(txtCODIGO.Text))
                txtPLACA_VEHIC.Text = ""
                Me.cbxMOTORISTA.Value = Nothing
                txtPLACA_VEHIC.Focus()
            Else
                AsignarMensaje(" * Codigo de transportista no esta registrado", True, True)
                txtCODIGO.Text = ""
                txtPLACA_VEHIC.Text = ""
                Me.cbxMOTORISTA.Value = Nothing
                txtCODIGO.Focus()
            End If
        ElseIf ddlTIPO_PROVEEDOR1.SelectedValue = Enumeradores.TipoProveedor.Cañero Then
            Dim entidad As PROVEEDOR
            Dim codiProveedor As String

            If Not Utilerias.EsNumeroEntero(txtSOCIO.Text) Then
                Me.txtSOCIO.Text = ""
            End If
            codiProveedor = Utilerias.FormatoCODIPROVEE(txtCODIGO.Text) + Utilerias.FormatoCODISOCIO(txtSOCIO.Text)

            entidad = (New cPROVEEDOR).ObtenerPROVEEDOR(codiProveedor)
            If entidad IsNot Nothing Then
                txtNOMBRE_CLIENTE.Text = entidad.NOMBRES.Trim + " " + entidad.APELLIDOS.Trim
                txtPLACA_VEHIC.Focus()
            Else
                AsignarMensaje(" * Codigo de cañero no esta registrado", True, True)
                txtCODIGO.Focus()
            End If
        End If
    End Sub

    Protected Sub txtPLACA_VEHIC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPLACA_VEHIC.TextChanged
        'Recuperar motorista y tipo de transporte ne base a:
        'Código de transportista y Placa
        Dim item As ListItem

        txtPLACA_VEHIC.Text = txtPLACA_VEHIC.Text.Trim
        item = lstTRANSPORTE.Items.FindByText(txtPLACA_VEHIC.Text)
        If item IsNot Nothing Then
            item.Selected = True
        End If
    End Sub

    Protected Sub lstTRANSPORTE_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTRANSPORTE.SelectedIndexChanged
        Me.txtPLACA_VEHIC.Text = lstTRANSPORTE.SelectedValue.ToString
        Me.cbxMOTORISTA.Value = Nothing
        Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(txtCODIGO.Text), lstTRANSPORTE.SelectedValue)
        RecuperarDocumentosMotorista()
    End Sub


    Private Sub RecuperarDocumentosMotorista()
        Me.txtDUI.Text = ""
        Me.txtLICENCIA.Text = ""
        If Me.cbxMOTORISTA.Value IsNot Nothing AndAlso IsNumeric(Me.cbxMOTORISTA.Value) Then
            Dim lMotorista As MOTORISTA = (New cMOTORISTA).ObtenerMOTORISTA(Me.cbxMOTORISTA.Value)
            If lMotorista IsNot Nothing Then
                Me.txtDUI.Text = lMotorista.DUI
                Me.txtLICENCIA.Text = lMotorista.LICENCIA
            End If
        End If
    End Sub

    Protected Sub txtCANTIDAD_TextChanged(sender As Object, e As System.EventArgs) Handles txtCANTIDAD.TextChanged
        Totalizar()
        txtPRECIO_UNITARIO.Focus()
    End Sub

    Protected Sub txtPRECIO_UNITARIO_TextChanged(sender As Object, e As System.EventArgs) Handles txtPRECIO_UNITARIO.TextChanged
        Totalizar()
        lblTOTAL.Focus()
    End Sub

    Protected Sub txtID_ORDEN_COMBUS_TextChanged(sender As Object, e As System.EventArgs) Handles txtID_ORDEN_COMBUS.TextChanged
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
                    'If lOrdenCombustible.USUARIO_CREA <> Me.ObtenerUsuario Then
                    '    Me.txtID_ORDEN_COMBUS.Text = ""
                    '    MostrarMensaje("Solo el usuario que creo la Orden puede consultarla", "Alerta")
                    '    Return
                    'End If
                    If TIPO_OPERACION = TipoOperacion.Facturacion AndAlso lOrdenCombustible.ESTADO = "A" Then
                        Me.txtID_ORDEN_COMBUS.Text = ""
                        MostrarMensaje("La orden ha sido anulada. Consultela en la opcion Anulacion", "Alerta")
                        Return
                    End If
                    Me.Enabled = False
                    Me.ID_ORDEN_COMBUS = lOrdenCombustible.ID_ORDEN_COMBUS
                    If TIPO_OPERACION = TipoOperacion.Facturacion AndAlso lOrdenCombustible.ESTADO = "E" Then
                        Me.txtNO_FACTURA_CCF.Enabled = True
                        Me.txtFECHA_DESPACHO.Enabled = True
                        Me.txtTOTAL.Enabled = True
                        Me.txtCANTIDAD.Enabled = True
                        Me.txtPRECIO_UNITARIO.Enabled = True
                    ElseIf TIPO_OPERACION = TipoOperacion.Facturacion AndAlso lOrdenCombustible.ESTADO = "F" Then
                        divFactura.Visible = True
                        grdDetalle.Enabled = False
                    ElseIf TIPO_OPERACION = TipoOperacion.Anulacion Then
                        divFactura.Visible = (lOrdenCombustible.NO_FACTURA_CCF <> "")
                        grdDetalle.Enabled = False
                        Me.txtMOTIVO_ANULACION.Enabled = (lOrdenCombustible.ESTADO <> "A")
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub lstPRODUCTOS_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lstPRODUCTOS.SelectedIndexChanged
        Me.txtID_PRODUCTO.Text = lstPRODUCTOS.SelectedValue
        Dim lProducto As PRODUCTO_COMBUSTIBLE = (New cPRODUCTO_COMBUSTIBLE).ObtenerPorNOMBRE_PRODUCTO(Me.txtID_PRODUCTO.Text)
        If lProducto IsNot Nothing Then
            Me.txtPRECIO_UNITARIO.Text = lProducto.PRECIO_VENTA.ToString
            Me.txtPRECIO_UNITARIO.Focus()
        End If
        Totalizar()
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As System.EventArgs) Handles btnAgregar.Click
        If txtCANTIDAD.Text.Trim = "" Then
            AsignarMensaje(" * Ingrese cantidad de producto.")
            Return
        ElseIf Not IsNumeric(txtCANTIDAD.Text) Then
            AsignarMensaje(" * Cantidad debe ser un numero.")
            Return
        ElseIf txtPRECIO_UNITARIO.Text.Trim = "" Then
            AsignarMensaje(" * Ingrese precio unitario del producto.")
            Return
        ElseIf Not IsNumeric(txtPRECIO_UNITARIO.Text) Then
            AsignarMensaje(" * Precio unitario debe ser un numero.")
            Return
        ElseIf IsNumeric(lblTOTAL.Text) AndAlso Convert.ToDecimal(lblTOTAL.Text) = 0D Then
            AsignarMensaje(" * Total no puede ser cero.")
            Return
        End If

        Dim lProducto As PRODUCTO_COMBUSTIBLE = (New cPRODUCTO_COMBUSTIBLE).ObtenerPorNOMBRE_PRODUCTO(Me.txtID_PRODUCTO.Text)
        If lProducto IsNot Nothing Then
            If hdfID_ORDEN_COMBUSTIBLE_PROD.Value = "" Then
                Dim dr As DataRow = Me.OrdenDetalle.Tables(0).NewRow
                dr("ID_ORDEN_COMBUSTIBLE_PROD") = NuevoID_ORDEN_COMBUSTIBLE_PROD()
                dr("ID_PRODUCTO") = lProducto.ID_PRODUCTO
                dr("PRODUCTO") = lProducto.NOMBRE_PRODUCTO
                dr("CANTIDAD") = Convert.ToDecimal(Me.txtCANTIDAD.Text).ToString("##0")
                dr("PRECIO_VENTA") = Convert.ToDecimal(Me.txtPRECIO_UNITARIO.Text).ToString("##0.00")
                dr("TOTAL") = Math.Round(Convert.ToDecimal(Me.txtCANTIDAD.Text) * Convert.ToDecimal(Me.txtPRECIO_UNITARIO.Text), 2).ToString("##0.00")
                Me.OrdenDetalle.Tables(0).Rows.Add(dr)
            Else
                For Each fila As DataRow In OrdenDetalle.Tables(0).Rows
                    If Convert.ToInt32(fila("ID_ORDEN_COMBUSTIBLE_PROD")) = Convert.ToInt32(hdfID_ORDEN_COMBUSTIBLE_PROD.Value) Then
                        fila("ID_PRODUCTO") = lProducto.ID_PRODUCTO
                        fila("PRODUCTO") = lProducto.NOMBRE_PRODUCTO
                        fila("CANTIDAD") = Convert.ToDecimal(Me.txtCANTIDAD.Text).ToString("##0.00")
                        fila("PRECIO_VENTA") = Convert.ToDecimal(Me.txtPRECIO_UNITARIO.Text).ToString("##0.00")
                        fila("TOTAL") = Math.Round(Convert.ToDecimal(Me.txtCANTIDAD.Text) * Convert.ToDecimal(Me.txtPRECIO_UNITARIO.Text), 2).ToString("##0.00")
                        fila.AcceptChanges()
                        Exit For
                    End If
                Next
            End If
            Me.grdDetalle.Enabled = True
            Me.btnAgregar.Text = "Agregar"
        Else
            AsignarMensaje(" * Producto no existe.")
            Return
        End If
        grdDetalle.DataSource = Me.OrdenDetalle
        grdDetalle.DataBind()
        Me.hdfID_ORDEN_COMBUSTIBLE_PROD.Value = ""
        Me.txtID_PRODUCTO.Text = ""
        Me.txtCANTIDAD.Text = ""
        Me.txtPRECIO_UNITARIO.Text = ""
        Me.lblTOTAL.Text = "0.00"
        Me.grdDetalle.Enabled = True
    End Sub

    Private Function NuevoID_ORDEN_COMBUSTIBLE_PROD() As Decimal
        Dim maxObject As Object

        maxObject = Me.OrdenDetalle.Tables(0).Compute("Max(ID_ORDEN_COMBUSTIBLE_PROD)", "PRODUCTO <> ''")
        If Not IsDBNull(maxObject) Then
            Return Convert.ToDecimal(maxObject) + 1
        Else
            Return 1
        End If
    End Function

    Protected Sub grdDetalle_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grdDetalle.RowCommand
        If e.CommandName = "Editar" Then
            For Each fila As DataRow In OrdenDetalle.Tables(0).Rows
                If fila("ID_ORDEN_COMBUSTIBLE_PROD") = Convert.ToInt32(e.CommandArgument) Then
                    Me.hdfID_ORDEN_COMBUSTIBLE_PROD.Value = fila("ID_ORDEN_COMBUSTIBLE_PROD")
                    Me.txtID_PRODUCTO.Text = fila("PRODUCTO")
                    Me.txtPRECIO_UNITARIO.Text = CDec(fila("PRECIO_VENTA")).ToString("##0.00")
                    Me.txtCANTIDAD.Text = fila("CANTIDAD")
                    Me.lblTOTAL.Text = Math.Round(CDec(fila("PRECIO_VENTA")) * CDec(fila("CANTIDAD")), 2).ToString("##0.00")
                    Me.grdDetalle.Enabled = False
                    Me.btnAgregar.Text = "Actualizar"
                    Exit For
                End If
            Next
        ElseIf e.CommandName = "Eliminar" Then
            For Each fila As DataRow In OrdenDetalle.Tables(0).Rows
                If fila("ID_ORDEN_COMBUSTIBLE_PROD") = Convert.ToInt32(e.CommandArgument) Then
                    Me.OrdenDetalle.Tables(0).Rows.Remove(fila)
                    grdDetalle.DataSource = Me.OrdenDetalle
                    grdDetalle.DataBind()
                    Exit For
                End If
            Next
        End If
    End Sub

    Protected Sub ddlTIPO_PROVEEDOR1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlTIPO_PROVEEDOR1.SelectedIndexChanged
        Me.txtCODIGO.Text = ""
        Me.txtSOCIO.Text = ""
        Me.txtSOCIO.Visible = (ddlTIPO_PROVEEDOR1.SelectedValue = TipoProveedor.Cañero)
        Me.txtNOMBRE_CLIENTE.Text = ""
        Me.RecuperarPlacasPorTransportista(-1)
        Me.txtPLACA_VEHIC.Text = ""
        Me.cbxMOTORISTA.Text = ""
        Me.txtDUI.Text = ""
        Me.txtLICENCIA.Text = ""
        Me.ddlSECCION1.Enabled = False
        Me.ddlSECCION1.SelectedIndex = -1
    End Sub

    Protected Sub txtSOCIO_TextChanged(sender As Object, e As System.EventArgs) Handles txtSOCIO.TextChanged
        ObtenerCliente()
    End Sub

    Protected Sub cbxMOTORISTA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxMOTORISTA.ValueChanged
        Me.RecuperarDocumentosMotorista()
    End Sub
End Class
