Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleDOCUMENTO_ENTRADA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla DOCUMENTO_ENTRADA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleDOCUMENTO_ENTRADA_ENCA
    Inherits ucBase

#Region "Propiedades"

    Private _ID_DOCENTRA_ENCA As Int32
    Public Property ID_DOCENTRA_ENCA() As Int32
        Get
            If Me.ViewState("ID_DOCENTRA_ENCA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_DOCENTRA_ENCA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_DOCENTRA_ENCA") = Value
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



    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cDOCUMENTO_ENTRADA_ENCA
    Private mEntidad As DOCUMENTO_ENTRADA_ENCA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_DOCENTRA_ENCA") Is Nothing Then Me._ID_DOCENTRA_ENCA = Me.ViewState("ID_DOCENTRA_ENCA")
        Me.CargarProductos()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New DOCUMENTO_ENTRADA_ENCA
        mEntidad.ID_DOCENTRA_ENCA = ID_DOCENTRA_ENCA

        If mComponente.ObtenerDOCUMENTO_ENTRADA_ENCA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.cbxTIPO_MOVTO.Value = mEntidad.ID_TIPO_MOVTO
        Me.txtID_DOCENTRA_ENCA.Text = mEntidad.ID_DOCENTRA_ENCA.ToString()
        Me.txtNO_DOCUMENTO.Value = mEntidad.NO_DOCUMENTO
        Me.dteFEC_DOCTO.Date = mEntidad.FEC_DOCTO
        Me.cbxBODEGA.Value = mEntidad.ID_BODEGA
        Me.cbxPROVEEDOR_AGRICOLA.Value = mEntidad.ID_PROVEE
        Me.cbxFORMA_ENTREGA.Value = mEntidad.FORMA_ENTREGA
        If mEntidad.ID_ORDEN <> -1 Then
            Me.cbxORDEN_COMPRA.Text = (New cORDEN_COMPRA_AGRI).ObtenerORDEN_COMPRA_AGRI(mEntidad.ID_ORDEN).CODI_ORDEN
        End If
        Me.cbxTIPO_COMPROB.Value = mEntidad.ID_TIPO_COMPROB
        Me.txtNO_COMPROB.Text = mEntidad.NO_COMPROB
        Me.dteFECHA_COMPROB.Date = mEntidad.FECHA_COMPROB
        Me.txtOBSERVACIONES.Text = mEntidad.OBSERVACIONES

        Me.LISTA_DOCUMENTO_ENTRADA_DETA = (New cDOCUMENTO_ENTRADA_DETA).ObtenerListaPorDOCUMENTO_ENTRADA_ENCA(mEntidad.ID_DOCENTRA_ENCA)
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditarInline = False
        Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEliminar = False
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Public Property LISTA_DOCUMENTO_ENTRADA_DETA As listaDOCUMENTO_ENTRADA_DETA
        Set(value As listaDOCUMENTO_ENTRADA_DETA)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaDOCUMENTO_ENTRADA_DETA) Else Return New listaDOCUMENTO_ENTRADA_DETA
        End Get
    End Property

    Private Sub CargarSolicSALBODE()
        Dim lista As listaSALBODE_ENCA
        Dim lEntidad As New SALBODE_ENCA

        lista = (New cSALBODE_ENCA).ObtenerListaCON_DOCUMENTO_SALIDA("NO_DOCUMENTO")
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For Each l As SALBODE_ENCA In lista
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(l.ID_ZAFRA)

                If lZafra IsNot Nothing Then
                    l.USUARIO_CREACION = l.NO_DOCUMENTO.ToString + "-" + lZafra.NOMBRE_ZAFRA
                End If
            Next
        Else
            lista = New listaSALBODE_ENCA
        End If

        lEntidad.ID_SALBODE_ENCA = -1
        lEntidad.USUARIO_CREACION = ""
        lista.Insertar(0, lEntidad)
        'Me.cbxSALBODE_ENCA.DataSource = lista
        'Me.cbxSALBODE_ENCA.DataBind()
    End Sub

    Private Sub IniciarDetalleDOCUMENTO_SALIDA()
        Dim lDeta As DOCUMENTO_ENTRADA_DETA
        Dim lProducto As PRODUCTO
        Dim lCodigoProd As Int32 = -100
        Dim dCantidad As Decimal = 0

        Me.LISTA_DOCUMENTO_ENTRADA_DETA = New listaDOCUMENTO_ENTRADA_DETA
        If Me.speNO_DOCUMENTO_SALIDA.Value IsNot Nothing Then
            Dim listaSalDeta As listaDOCUMENTO_SALIDA_DETA = (New cDOCUMENTO_SALIDA_DETA).ObtenerListaPorDOCUMENTO_SALIDA_ENCA(CInt(Me.speNO_DOCUMENTO_SALIDA.Value), False, "ID_PRODUCTO", "ASC")
            If listaSalDeta IsNot Nothing AndAlso listaSalDeta.Count > 0 Then
                For i As Int32 = 0 To listaSalDeta.Count - 1
                    If lCodigoProd <> -100 AndAlso lCodigoProd <> listaSalDeta(i).ID_PRODUCTO Then
                        lDeta = New DOCUMENTO_ENTRADA_DETA
                        lDeta.ID_DOCENTRA_ENCA_DETA = Me.ObtenerIdProd(Me.LISTA_DOCUMENTO_ENTRADA_DETA)
                        lDeta.ID_DOCENTRA_ENCA = 0
                        lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lCodigoProd)
                        lDeta.ID_PRODUCTO = lCodigoProd
                        lDeta.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
                        lDeta.UNIDAD = ""
                        lDeta.PRESENTACION = lProducto.PRESENTACION
                        lDeta.CANTIDAD = 0
                        lDeta.PRECIO_UNITARIO = 0
                        lDeta.TOTAL = 0
                        lDeta.ID_ORDEN_DETA = -1

                        Me.LISTA_DOCUMENTO_ENTRADA_DETA.Add(lDeta)
                        dCantidad = 0
                        lCodigoProd = listaSalDeta(i).ID_PRODUCTO
                    ElseIf lCodigoProd = -100 Then
                        lCodigoProd = listaSalDeta(i).ID_PRODUCTO
                    End If
                    dCantidad += listaSalDeta(i).CANTIDAD
                Next

                lDeta = New DOCUMENTO_ENTRADA_DETA
                lDeta.ID_DOCENTRA_ENCA_DETA = Me.ObtenerIdProd(Me.LISTA_DOCUMENTO_ENTRADA_DETA)
                lDeta.ID_DOCENTRA_ENCA = 0
                lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lCodigoProd)
                lDeta.ID_PRODUCTO = lProducto.ID_PRODUCTO
                lDeta.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
                lDeta.UNIDAD = ""
                lDeta.PRESENTACION = lProducto.PRESENTACION
                lDeta.CANTIDAD = 0
                lDeta.PRECIO_UNITARIO = 0
                lDeta.ID_ORDEN_DETA = -1
                lDeta.TOTAL = 0

                Me.LISTA_DOCUMENTO_ENTRADA_DETA.Add(lDeta)
                Me.CargarDetalleDocumentoEnca()
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxBODEGA.ClientEnabled = _nuevo
        Me.cbxTIPO_MOVTO.ClientEnabled = _nuevo
        Me.speNO_DOCUMENTO_SALIDA.ClientEnabled = _nuevo
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = _nuevo
        Me.cbxORDEN_COMPRA.ClientEnabled = _nuevo
        Me.cbxTIPO_COMPROB.ClientEnabled = _nuevo
        Me.txtNO_DOCUMENTO.ClientEnabled = False
        Me.dteFEC_DOCTO.ClientEnabled = False
        Me.cbxFORMA_ENTREGA.ClientEnabled = _nuevo
        Me.txtNO_COMPROB.ClientEnabled = _nuevo
        Me.dteFECHA_COMPROB.ClientEnabled = _nuevo
        Me.txtOBSERVACIONES.ClientEnabled = _nuevo
        Me.cbxZAFRA.ClientEnabled = Me._nuevo
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
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
        Me.trInfoProveedor.Visible = False
        Me.trInfoOrdenCompraA.Visible = False
        Me.trInfoOrdenCompraB.Visible = False
        Me.trSalidaBodega.Visible = False
        Me.cbxTIPO_MOVTO.Value = Nothing
        Me.cbxBODEGA.Value = Nothing
        Me.dteFEC_DOCTO.Date = cFechaHora.ObtenerFecha
        Me.speNO_DOCUMENTO_SALIDA.Value = Nothing
        Me.cbxPROVEEDOR_AGRICOLA.Value = Nothing
        Me.cbxFORMA_ENTREGA.Value = Nothing
        Me.cbxORDEN_COMPRA.Value = Nothing
        Me.cbxTIPO_COMPROB.Value = Nothing
        Me.txtNO_COMPROB.Text = ""
        Me.dteFECHA_COMPROB.Value = Nothing
        Me.txtOBSERVACIONES.Text = ""
        Me.LISTA_DOCUMENTO_ENTRADA_DETA = New listaDOCUMENTO_ENTRADA_DETA
        Me.CargarSolicSALBODE()
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditar = False
        Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditarInline = False
        Me.CargarProductos()
    End Sub

    Private Sub CargarOrdenesCompra()
        Dim lista As New listaORDEN_COMPRA_AGRI
        If Me.cbxPROVEEDOR_AGRICOLA.Value IsNot Nothing Then
            lista = (New cORDEN_COMPRA_AGRI).ObtenerListaPorCriterios(Me.cbxPROVEEDOR_AGRICOLA.Value, CondicionCompra.Consignacion, True, "NO_ORDEN")
        End If
        If lista Is Nothing OrElse lista.Count = 0 Then lista = New listaORDEN_COMPRA_AGRI
        Me.cbxORDEN_COMPRA.DataSource = lista
        Me.cbxORDEN_COMPRA.DataBind()
        Me.LISTA_DOCUMENTO_ENTRADA_DETA = New listaDOCUMENTO_ENTRADA_DETA
        Me.CargarDetalleDocumentoEnca()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla DOCUMENTO_ENTRADA_ENCA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim listaDetalle As listaDOCUMENTO_ENTRADA_DETA
        Dim bDocumentoDeta As New cDOCUMENTO_ENTRADA_DETA
        Dim lEntidadIngreso As DOCUMENTO_ENTRADA_ENCA
        Dim sCad As New StringBuilder

        If Me.cbxTIPO_MOVTO.Value Is Nothing Then
            Return "* Seleccione el tipo de movimiento"
        End If
        If Me.cbxBODEGA.Value Is Nothing Then
            Return "* Seleccione la bodega"
        End If
        If Me.dteFEC_DOCTO.Value Is Nothing Then
            Return "* Ingrese la fecha de ingreso"
        End If
        If Me.trInfoProveedor.Visible AndAlso Me.cbxPROVEEDOR_AGRICOLA.Value Is Nothing Then
            Return "* Seleccione el proveedor"
        End If
        If Me.trInfoProveedor.Visible AndAlso Me.cbxFORMA_ENTREGA.Value Is Nothing Then
            Return "* Seleccione la forma de entrega"
        End If
        If Me.trInfoProveedor.Visible AndAlso Me.cbxTIPO_COMPROB.Value Is Nothing Then
            Return "* Ingrese el Tipo de comprobante"
        End If
        If Me.trInfoProveedor.Visible AndAlso Me.txtNO_COMPROB.Text = "" Then
            Return "* Ingrese el No. de comprobante"
        End If
        If Me.trInfoProveedor.Visible AndAlso Me.dteFECHA_COMPROB.Value Is Nothing Then
            Return "* Ingrese la fecha del comprobante"
        End If
        If Me.trInfoProveedor.Visible AndAlso Me.cbxORDEN_COMPRA.Value Is Nothing Then
            Return "* Seleccione la Orden de Compra"
        End If

        If trInfoOrdenCompraA.Visible Then
            'Verificar si el comprobante de CCF ya se ha utilizado
            lEntidadIngreso = mComponente.ObtenerPorInfoCOMPROBANTE(Me.cbxPROVEEDOR_AGRICOLA.Value, Me.cbxTIPO_COMPROB.Value, Me.dteFECHA_COMPROB.Date, Me.txtNO_COMPROB.Text)
            If Me._nuevo AndAlso lEntidadIngreso IsNot Nothing AndAlso lEntidadIngreso.ID_DOCENTRA_ENCA > 0 Then
                Return "* El Tipo, Numero y fecha del comprobante coinciden con un comprobante de Ingreso de Bodega No.: " + lEntidadIngreso.NO_DOCUMENTO.ToString + " de fecha: " + lEntidadIngreso.FEC_DOCTO.ToString("dd/MM/yyyy")
            End If
        End If

        mEntidad = New DOCUMENTO_ENTRADA_ENCA
        If Me._nuevo Then
            mEntidad.ID_DOCENTRA_ENCA = 0
            mEntidad.NO_DOCUMENTO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad.ID_DOCSAL_ENCA = -1
        Else
            mEntidad = mComponente.ObtenerDOCUMENTO_ENTRADA_ENCA(CInt(Me.txtID_DOCENTRA_ENCA.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If

        listaDetalle = Me.LISTA_DOCUMENTO_ENTRADA_DETA
        If listaDetalle Is Nothing OrElse listaDetalle.Count = 0 Then
            Return "* No se encontro detalle de productos a ingresar a bodega"
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
            Return "* No se encontro cantidad de productos a ingresar a bodega"
        End If

        If Me.cbxTIPO_MOVTO.Value = 2 Then
            'Verificar que la Sumatoria de devoluciones de cada producto + la devolución actual no sea mayor que la Salida Original del Producto
            sCad = New StringBuilder
            For Each lEntidad As DOCUMENTO_ENTRADA_DETA In listaDetalle
                Dim totalDevolucion As Decimal = (New cDOCUMENTO_ENTRADA_ENCA).ObtenerCantidadDevueltaProductoDoctoSalida(CInt(Me.speNO_DOCUMENTO_SALIDA.Value), lEntidad.ID_PRODUCTO)
                Dim cantSalida As Decimal = (New cDOCUMENTO_SALIDA_ENCA).ObtenerCantidadProductoDoctoSalida(CInt(Me.speNO_DOCUMENTO_SALIDA.Value), lEntidad.ID_PRODUCTO)
                Dim nomProvee As String = ""

                If totalDevolucion + lEntidad.CANTIDAD > cantSalida Then
                    Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(lEntidad.ID_PRODUCTO)
                    Dim lProveedor As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(lProducto.ID_PROVEE)

                    If lProveedor IsNot Nothing Then nomProvee = lProveedor.NOMBRE
                    sCad.Append("* El Producto " + nomProvee + " - " + lProducto.NOMBRE_PRODUCTO + " " + lProducto.PRESENTACION + " tiene una devolución total mayor al retiro de bodega. Devoluciones efectuadas: " + totalDevolucion.ToString("#,##0.00##") + ", Devolucion actual: " + lEntidad.CANTIDAD.ToString("#,##0.00##") + ", Retiro de bodega fue por: " + cantSalida.ToString("#,##0.00##") + vbCrLf)
                End If
            Next
            If sCad.ToString <> "" Then
                Return sCad.ToString
            End If
        End If

        mEntidad.FEC_DOCTO = Me.dteFEC_DOCTO.Date
        mEntidad.ID_TIPO_MOVTO = Me.cbxTIPO_MOVTO.Value
        mEntidad.UID_DOCUMENTO = Guid.NewGuid
        mEntidad.ID_BODEGA = Me.cbxBODEGA.Value
        If Me.trInfoProveedor.Visible Then
            mEntidad.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLA.Value
            mEntidad.FORMA_ENTREGA = Me.cbxFORMA_ENTREGA.Value
            mEntidad.ID_ORDEN = Me.cbxORDEN_COMPRA.Value
            mEntidad.ID_TIPO_COMPROB = Me.cbxTIPO_COMPROB.Value
            mEntidad.NO_COMPROB = Me.txtNO_COMPROB.Text
            mEntidad.FECHA_COMPROB = Me.dteFECHA_COMPROB.Date
        Else
            mEntidad.ID_PROVEE = -1
            mEntidad.FORMA_ENTREGA = -1
            mEntidad.ID_ORDEN = -1
            mEntidad.ID_TIPO_COMPROB = -1
            mEntidad.NO_COMPROB = Nothing
            mEntidad.FECHA_COMPROB = Nothing
        End If
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.OBSERVACIONES = Me.txtOBSERVACIONES.Text.Trim.ToUpper
        mEntidad.TOTAL = dTotal
        mEntidad.ID_DOCSAL_ENCA = If(Me.cbxTIPO_MOVTO.Value = 2, Me.speNO_DOCUMENTO_SALIDA.Value, -1)

        If mComponente.ActualizarDOCUMENTO_ENTRADA_ENCA(mEntidad) <= 0 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If

        For Each lEntidad As DOCUMENTO_ENTRADA_DETA In listaDetalle
            If lEntidad.CANTIDAD > 0 Then
                lEntidad.ID_DOCENTRA_ENCA_DETA = If(Me._nuevo, 0, lEntidad.ID_DOCENTRA_ENCA_DETA)
                lEntidad.ID_DOCENTRA_ENCA = mEntidad.ID_DOCENTRA_ENCA
                lEntidad.UID_DOCUMENTO_DETA = Guid.NewGuid
                bDocumentoDeta.ActualizarDOCUMENTO_ENTRADA_DETA(lEntidad)
            End If
        Next

        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarDoctoIngresoInventario(" + mEntidad.ID_DOCENTRA_ENCA.ToString + ")", True)

        Me.txtID_DOCENTRA_ENCA.Text = mEntidad.ID_DOCENTRA_ENCA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub cbxORDEN_COMPRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxORDEN_COMPRA.ValueChanged
        Me.CargarItemsEquipoMaterialOrdenCompra()
        Me.ConfigVista()
    End Sub

    Private Sub ConfigVista()
        If Me.cbxFORMA_ENTREGA.Value = 1 Then
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditar = False
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditarInline = False
        ElseIf Me.cbxFORMA_ENTREGA.Value = 2 Then
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditar = True
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditarInline = True
        End If
    End Sub

    Private Sub CargarItemsEquipoMaterialOrdenCompra()
        Dim lista As New listaDOCUMENTO_ENTRADA_DETA
        Dim cantEntregada As Decimal = 0

        If Me.cbxORDEN_COMPRA.Value IsNot Nothing Then
            Dim listaCompra As listaORDEN_DETA_AGRI = (New cORDEN_DETA_AGRI).ObtenerListaPorORDEN_COMPRA_AGRI(CInt(Me.cbxORDEN_COMPRA.Value), False, "ID_ORDEN_DETA")
            If listaCompra IsNot Nothing AndAlso listaCompra.Count > 0 Then
                For Each lEntidad As ORDEN_DETA_AGRI In listaCompra

                    'Verificar si tiene cantidad pendiente de entregar
                    cantEntregada = (New cORDEN_DETA_AGRI).ObtenerCantidadEntregada(lEntidad.ID_ORDEN_DETA)


                    If cantEntregada <> -1 AndAlso lEntidad.CANTIDAD - cantEntregada > 0 Then
                        Dim lIngrDeta As New DOCUMENTO_ENTRADA_DETA

                        lIngrDeta.ID_DOCENTRA_ENCA = 0
                        lIngrDeta.ID_DOCENTRA_ENCA_DETA = lEntidad.ID_ORDEN_DETA
                        lIngrDeta.ID_PRODUCTO = lEntidad.ID_PRODUCTO
                        lIngrDeta.CANTIDAD = lEntidad.CANTIDAD - cantEntregada
                        lIngrDeta.PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO
                        lIngrDeta.TOTAL = lIngrDeta.CANTIDAD * lIngrDeta.PRECIO_UNITARIO
                        lIngrDeta.ID_ORDEN_DETA = lEntidad.ID_ORDEN_DETA
                        lIngrDeta.UNIDAD = lEntidad.UNIDAD.ToUpper
                        lIngrDeta.NOMBRE_PRODUCTO = lEntidad.NOMBRE_PRODUCTO.ToUpper
                        lIngrDeta.PRESENTACION = lEntidad.PRESENTACION
                        lIngrDeta.REFERENCIA = Me.lblREFERENCIA.Text
                        lIngrDeta.UID_DOCUMENTO_DETA = Guid.NewGuid

                        lista.Add(lIngrDeta)
                    End If
                Next
            End If
        End If

        Me.LISTA_DOCUMENTO_ENTRADA_DETA = lista
        Me.CargarDetalleDocumentoEnca()
    End Sub

    Private Sub CargarProductos()
        Dim lista As New listaPRODUCTO
        Dim idProducto As Int32 = 0
        Dim idBodega As Int32 = -1

        If cbxBODEGA.Value IsNot Nothing Then idBodega = cbxBODEGA.Value
        If cbxPRODUCTO.Value IsNot Nothing Then idProducto = cbxPRODUCTO.Value

        lista = (New cPRODUCTO).ObtenerListaPorCriterios(-1, -1, -1, -1, 1, 1, "NOMBRE_PRODUCTO", "ASC")
        If lista Is Nothing Then lista = New listaPRODUCTO

        Me.cbxPRODUCTO.DataSource = lista
        Me.cbxPRODUCTO.DataBind()
        If idProducto <> 0 AndAlso Me.cbxPRODUCTO.Items.FindByValue(CInt(idProducto)) IsNot Nothing Then
            Me.cbxPRODUCTO.SelectedIndex = Me.cbxPRODUCTO.Items.FindByValue(CInt(idProducto)).Index
        Else
            Me.cbxPRODUCTO.Text = ""
        End If
    End Sub

    Protected Sub cbxPRODUCTO_ValueChanged(sender As Object, e As EventArgs) Handles cbxPRODUCTO.ValueChanged
        If cbxPRODUCTO.Value IsNot Nothing Then
            Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(cbxPRODUCTO.Value)
            If lProducto IsNot Nothing Then
                Me.txtPRESENTACION.Text = lProducto.PRESENTACION
                'Me.speCOSTO_UNITARIO.Value = Math.Round(lProducto.PRECIO_UNITARIO, 4)
            End If
            'CalcularMonto()
        End If
    End Sub

    'Private Sub CalcularMonto()
    '    Dim cant As Decimal = 0
    '    Dim costoU As Decimal = 0

    '    If Me.speCANTIDAD_PRODUCTO.Text <> "" Then cant = CDec(Me.speCANTIDAD_PRODUCTO.Value)
    '    If Me.speCOSTO_UNITARIO.Text <> "" Then costoU = CDec(Me.speCOSTO_UNITARIO.Value)
    '    Me.speTOTAL_PRODUCTO.Value = cant * costoU
    'End Sub

    Protected Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim lEntidad As DOCUMENTO_ENTRADA_DETA

        If Me.cbxBODEGA.Value Is Nothing Then
            Me.AsignarMensaje("* Seleccione una bodega", True, False)
            Return
        End If
        If Me.cbxPRODUCTO.Value Is Nothing OrElse Me.cbxPRODUCTO.Value <= 0 Then
            Me.AsignarMensaje("* Seleccione un producto", True, False)
            Return
        End If
        If Me.speCANTIDAD_PRODUCTO.Value Is Nothing OrElse speCANTIDAD_PRODUCTO.Value = 0 Then
            Me.speCANTIDAD_PRODUCTO.Focus()
            Me.AsignarMensaje("* Ingrese la cantidad del producto", True, False)
            Return
        End If
        'If Me.speCOSTO_UNITARIO.Value Is Nothing OrElse speCOSTO_UNITARIO.Value = 0 Then
        '    Me.speCOSTO_UNITARIO.Focus()
        '    Me.AsignarMensaje("* Ingrese el costo unitario del producto", True, False)
        '    Return
        'End If
        If Me.txtPRESENTACION.Text.Trim = "" Then
            Me.AsignarMensaje("* Ingrese la presentacion del producto", True, False)
            Return
        End If
        If Me.LISTA_DOCUMENTO_ENTRADA_DETA IsNot Nothing AndAlso Me.LISTA_DOCUMENTO_ENTRADA_DETA.Count > 0 Then
            Dim lista As listaDOCUMENTO_ENTRADA_DETA = Me.LISTA_DOCUMENTO_ENTRADA_DETA
            For i As Int32 = 0 To lista.Count - 1
                If lista(i).ID_PRODUCTO = Me.cbxPRODUCTO.Value Then
                    Me.AsignarMensaje("* El producto ya ha sido ingresado en este documento", True, False)
                    Return
                End If
            Next
        End If
        lEntidad = New DOCUMENTO_ENTRADA_DETA
        lEntidad.ID_DOCENTRA_ENCA_DETA = Me.ObtenerIdProd(Me.LISTA_DOCUMENTO_ENTRADA_DETA)
        lEntidad.ID_DOCENTRA_ENCA = 0
        lEntidad.ID_ORDEN_DETA = -1
        Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(Me.cbxPRODUCTO.Value)
        If lProducto IsNot Nothing Then
            lEntidad.ID_PRODUCTO = lProducto.ID_PRODUCTO
            lEntidad.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
        Else
            lEntidad.ID_PRODUCTO = -1
            lEntidad.NOMBRE_PRODUCTO = ""
        End If
        lEntidad.CANTIDAD = CDec(Me.speCANTIDAD_PRODUCTO.Value)
        lEntidad.PRECIO_UNITARIO = 0 'CDec(Me.speCOSTO_UNITARIO.Value)
        If Me.dteFECHA_VTO.Date <> #12:00:00 AM# Then
            lEntidad.FECHA_VTO = Me.dteFECHA_VTO.Date
        Else
            lEntidad.FECHA_VTO = Nothing
        End If
        lEntidad.TOTAL = Math.Round(lEntidad.CANTIDAD * lEntidad.PRECIO_UNITARIO, 2)
        lEntidad.PRESENTACION = Me.txtPRESENTACION.Text.ToUpper
        lEntidad.UID_DOCUMENTO_DETA = Guid.NewGuid

        Me.LISTA_DOCUMENTO_ENTRADA_DETA.Add(lEntidad)
        Me.CargarDetalleDocumentoEnca()

        Me.cbxPRODUCTO.Text = ""
        Me.cbxPRODUCTO.Value = Nothing
        Me.txtPRESENTACION.Text = ""
        Me.speCANTIDAD_PRODUCTO.Value = Nothing
        Me.dteFECHA_VTO.Value = Nothing
        'Me.speCOSTO_UNITARIO.Value = Nothing
        'Me.speTOTAL_PRODUCTO.Value = Nothing

        Me.CargarProductos()
        Me.AsignarMensaje("", True, False)
    End Sub

    Private Function ObtenerIdProd(ByVal lista As listaDOCUMENTO_ENTRADA_DETA) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_DOCENTRA_ENCA_DETA > Id Then
                Id = lista(i).ID_DOCENTRA_ENCA_DETA
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub cbxPROVEEDOR_AGRICOLA_ValueChanged(sender As Object, e As EventArgs) Handles cbxPROVEEDOR_AGRICOLA.ValueChanged
        Me.CargarOrdenesCompra()
    End Sub

    Protected Sub cbxFORMA_ENTREGA_ValueChanged(sender As Object, e As EventArgs) Handles cbxFORMA_ENTREGA.ValueChanged
        Me.CargarItemsEquipoMaterialOrdenCompra()
        Me.ConfigVista()
    End Sub

    Protected Sub speNO_DOCUMENTO_SALIDA_ValueChanged(sender As Object, e As EventArgs) Handles speNO_DOCUMENTO_SALIDA.ValueChanged
        If speNO_DOCUMENTO_SALIDA.Value IsNot Nothing AndAlso speNO_DOCUMENTO_SALIDA.Value > 0 Then
            Me.trProductoParteB.Visible = False
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditarInline = True
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEliminar = False
            Me.IniciarDetalleDOCUMENTO_SALIDA()
        Else
            Me.trProductoParteB.Visible = True
            Me.LISTA_DOCUMENTO_ENTRADA_DETA = New listaDOCUMENTO_ENTRADA_DETA
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditarInline = True
            Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEliminar = True
            Me.CargarDetalleDocumentoEnca()
        End If
    End Sub

    Protected Sub cbxTIPO_MOVTO_ValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_MOVTO.ValueChanged
        Select Case CInt(Me.cbxTIPO_MOVTO.Value)
            Case 1
                Me.trInfoProveedor.Visible = True
                Me.trInfoOrdenCompraA.Visible = True
                Me.trInfoOrdenCompraB.Visible = True
                Me.trSalidaBodega.Visible = False
            Case 2
                Me.trInfoProveedor.Visible = False
                Me.trInfoOrdenCompraA.Visible = False
                Me.trInfoOrdenCompraB.Visible = False
                Me.trSalidaBodega.Visible = True
                Me.trProductoParteB.Visible = True
            Case 4
                Me.trInfoProveedor.Visible = False
                Me.trInfoOrdenCompraA.Visible = False
                Me.trInfoOrdenCompraB.Visible = False
                Me.trSalidaBodega.Visible = False
                Me.trProductoParteB.Visible = True
            Case Else
                Me.trInfoProveedor.Visible = False
                Me.trInfoOrdenCompraA.Visible = False
                Me.trInfoOrdenCompraB.Visible = False
                Me.trSalidaBodega.Visible = False
                Me.trProductoParteB.Visible = False
        End Select
        Me.LISTA_DOCUMENTO_ENTRADA_DETA = New listaDOCUMENTO_ENTRADA_DETA
        Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEditarInline = True
        Me.ucListaDOCUMENTO_ENTRADA_DETA1.PermitirEliminar = True
        Me.CargarDetalleDocumentoEnca()
    End Sub
End Class
