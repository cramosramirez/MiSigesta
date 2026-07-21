Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleORDEN_COMPRA_AGRI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ORDEN_COMPRA_AGRI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleORDEN_COMPRA_AGRI
    Inherits ucBase
 
#Region"Propiedades"


    Private _ID_ORDEN As Int32
    Public Property ID_ORDEN() As Int32
        Get
            If Me.ViewState("ID_ORDEN") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ORDEN"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_ORDEN") = Value
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
    Private mComponente As New cORDEN_COMPRA_AGRI
    Private mEntidad As ORDEN_COMPRA_AGRI
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
        If Not Me.ViewState("ID_ORDEN") Is Nothing Then Me._ID_ORDEN = Me.ViewState("ID_ORDEN")
        Me.CargarProductos()
        Me.SetearSubTotalIvaTotal()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ORDEN_COMPRA_AGRI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        Dim lSolicitud As SOLIC_AGRICOLA

        mEntidad = New ORDEN_COMPRA_AGRI
        mEntidad.ID_ORDEN = ID_ORDEN
 
        If mComponente.ObtenerORDEN_COMPRA_AGRI(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ORDEN.Text = mEntidad.ID_ORDEN.ToString()
        Me.cbxPROVEEDOR_AGRICOLA.Value = mEntidad.ID_PROVEE
        Me.txtCODI_ORDEN.Text = mEntidad.CODI_ORDEN
        Me.dteFECHA.Value = mEntidad.FECHA
        Me.speCODIPROVEE.Value = Utilerias.RecuperarCODIPROVEE(mEntidad.CODIPROVEEDOR)
        Me.CargarInfoProveedor(mEntidad.CODIPROVEEDOR)
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA

        If mEntidad.ID_SOLICITUD = -1 Then
            Me.speNUM_SOLICITUD.Value = Nothing
            Me.trSolicitudAgri.Visible = False
        Else
            lSolicitud = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(mEntidad.ID_SOLICITUD)
            If lSolicitud IsNot Nothing Then
                Me.speNUM_SOLICITUD.Value = lSolicitud.NUM_SOLICITUD
            End If
            Me.trSolicitudAgri.Visible = True
        End If
        Me.cbxCONDICION_COMPRA.Value = mEntidad.CONDI_COMPRA

        Me.LISTA_ORDEN_DETA_AGRI = (New cORDEN_DETA_AGRI).ObtenerListaPorORDEN_COMPRA_AGRI(mEntidad.ID_ORDEN)
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaORDEN_DETA_AGRI1.PermitirEditarInline = False
        Me.ucListaORDEN_DETA_AGRI1.PermitirEditarInline2 = False
        Me.ucListaORDEN_DETA_AGRI1.PermitirEliminar = False
        Me.ucListaORDEN_DETA_AGRI1.Visible = True
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaORDEN_DETA_AGRI1.CargarDatosCache(Me.lblREFERENCIA.Text)
            Me.SetearSubTotalIvaTotal()
        End If
    End Sub

    Public Property LISTA_ORDEN_DETA_AGRI As listaORDEN_DETA_AGRI
        Set(value As listaORDEN_DETA_AGRI)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaORDEN_DETA_AGRI) Else Return New listaORDEN_DETA_AGRI
        End Get
    End Property
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_ORDEN.ClientEnabled = False
        Me.txtCODI_ORDEN.ClientEnabled = False
        Me.dteFECHA.ClientEnabled = False
        Me.cbxPROVEEDOR_AGRICOLA.ClientEnabled = _nuevo
        Me.speCODIPROVEE.ClientEnabled = False
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.txtNIT.ClientEnabled = False
        Me.txtNRC.ClientEnabled = False
        Me.txtACTIVIDAD.ClientEnabled = False
        Me.cbxZAFRA.ClientEnabled = _nuevo
        Me.speNUM_SOLICITUD.ClientEnabled = False
        Me.cbxCONDICION_COMPRA.ClientEnabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/07/2017	Created
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
        Me.txtID_ORDEN.Text = ""
        Me.txtCODI_ORDEN.Text = ""
        Me.dteFECHA.Date = cFechaHora.ObtenerFecha
        Me.cbxPROVEEDOR_AGRICOLA.Value = Nothing
        Me.speCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtNIT.Text = ""
        Me.txtNRC.Text = ""
        Me.txtACTIVIDAD.Text = ""
        Me.cbxPRODUCTOdeta.Text = ""
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Value = Nothing
        Me.spePRECIO_UNITARIOdeta.Value = Nothing
        Me.speSUB_TOTALdeta.Value = Nothing

        Me.speCODIPROVEE.Value = 14015
        Me.CargarInfoProveedor("0140150000")
        Me.trSolicitudAgri.Visible = False
        Me.speNUM_SOLICITUD.Value = Nothing
        Me.cbxCONDICION_COMPRA.Value = 3
        Me.LISTA_ORDEN_DETA_AGRI = New listaORDEN_DETA_AGRI
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ORDEN_COMPRA_AGRI
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim listaDetalle As listaORDEN_DETA_AGRI
        Dim bDocumentoDeta As New cORDEN_DETA_AGRI

        mEntidad = New ORDEN_COMPRA_AGRI
        If Me._nuevo Then
            mEntidad.ID_ORDEN = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerORDEN_COMPRA_AGRI(CInt(Me.txtID_ORDEN.Text))
        End If

        If Me.cbxPROVEEDOR_AGRICOLA.Value Is Nothing Then
            Return "* Seleccione el proveedor agricola"
        End If
        If Me.speCODIPROVEE.Text = "" Then
            Return "* Ingrese el codigo de productor"
        End If
        If Me.cbxCONDICION_COMPRA.Value Is Nothing Then
            Return "* Seleccione la condicion de compra"
        End If

        listaDetalle = Me.LISTA_ORDEN_DETA_AGRI
        If listaDetalle Is Nothing OrElse listaDetalle.Count = 0 Then
            Return "* No se encontro detalle de productos en la orden de compra"
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

        mEntidad.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLA.Value
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.NO_ORDEN = -1
        mEntidad.CODI_ORDEN = ""
        mEntidad.FECHA = Me.dteFECHA.Date
        If Not Me.trSolicitudAgri.Visible Then
            mEntidad.ID_SOLICITUD = -1
        End If
        mEntidad.CODIPROVEEDOR = Utilerias.FormatearCODIPROVEEDOR(Me.speCODIPROVEE.Value)
        mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value
        mEntidad.SUB_TOTAL = dTotal
        mEntidad.IVA = Math.Round(dTotal * Utilerias.TasaIva, 2)
        mEntidad.TOTAL = dTotal + Math.Round(dTotal * Utilerias.TasaIva, 2)

        If Me._nuevo Then
            mEntidad.CCF_NOMBRE = "INJIBOA S.A."
            mEntidad.LUGAR_ENTREGA = "KM 68 1/2 CARRETERA SAN VICENTE A ZACATECOLUCA CANTON SAN ANTONIO CAMINOS, SAN VICENTE"
            mEntidad.CONTACTO = "2399-4992  -  2399-4963"
        End If


        If mComponente.ActualizarORDEN_COMPRA_AGRI(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If

        For Each lEntidad As ORDEN_DETA_AGRI In listaDetalle
            If lEntidad.CANTIDAD > 0 Then
                lEntidad.ID_ORDEN_DETA = If(Me._nuevo, 0, lEntidad.ID_ORDEN_DETA)
                lEntidad.ID_ORDEN = mEntidad.ID_ORDEN
                bDocumentoDeta.ActualizarORDEN_DETA_AGRI(lEntidad)
            End If
        Next

        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarOrdenCompraPorOrden(" + mEntidad.ID_ORDEN.ToString + ")", True)

        Me.txtID_ORDEN.Text = mEntidad.ID_ORDEN.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Public Sub SetearSubTotalIvaTotal()
        Dim dSubTOTAL As Decimal = 0
        Dim dIva As Decimal = 0
        Dim dTotal As Decimal = 0
        Dim listaProd As listaORDEN_DETA_AGRI = Me.LISTA_ORDEN_DETA_AGRI

        If listaProd IsNot Nothing AndAlso listaProd.Count > 0 Then
            For Each lProducto As ORDEN_DETA_AGRI In Me.LISTA_ORDEN_DETA_AGRI
                dSubTOTAL += lProducto.TOTAL
            Next
        End If
        dIva = Math.Round(Math.Round(dSubTOTAL, 2) * Utilerias.TasaIva, 2)
        dTotal = Math.Round(dSubTOTAL, 2) + Math.Round(Math.Round(dSubTOTAL, 2) * Utilerias.TasaIva, 2)
        Me.SUB_TOTAL = dSubTOTAL
        Me.IVA = Math.Round(Math.Round(dSubTOTAL, 2) * Utilerias.TasaIva, 2)
        Me.TOTAL = Math.Round(dSubTOTAL, 2) + Math.Round(Math.Round(dSubTOTAL, 2) * Utilerias.TasaIva, 2)
    End Sub

    Protected Sub cpVistaDetalleORDEN_COMPRA_AGRI_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpVistaDetalleORDEN_COMPRA_AGRI.Callback
        Me.SetearSubTotalIvaTotal()
    End Sub

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

    Protected Sub cbxPROVEEDOR_AGRICOLA_ValueChanged(sender As Object, e As EventArgs) Handles cbxPROVEEDOR_AGRICOLA.ValueChanged
        Me.CargarProductos()
        Me.LISTA_ORDEN_DETA_AGRI = New listaORDEN_DETA_AGRI
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()
        Me.cbxPRODUCTOdeta.Text = ""
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANTIDADdeta.Value = Nothing
        Me.spePRECIO_UNITARIOdeta.Value = Nothing
        Me.speSUB_TOTALdeta.Value = Nothing
        Me.cbxPRODUCTOdeta.Focus()
    End Sub

    Private Sub CargarProductos()
        Dim idProveedor As Int32 = 0
        Dim idCuentaFinan As Int32 = 0
        Dim lista As listaPRODUCTO

        idProveedor = Me.cbxPROVEEDOR_AGRICOLA.Value
        lista = (New cPRODUCTO).ObtenerListaPorCriterios(idProveedor, -1, -1, -1, 1, -1, "NOMBRE_PRODUCTO")
        If Not (lista IsNot Nothing AndAlso lista.Count > 0) Then
            lista = New listaPRODUCTO
        End If
        Me.cbxPRODUCTOdeta.DataSource = lista
        Me.cbxPRODUCTOdeta.DataBind()
    End Sub

    Protected Sub cbxPRODUCTOdeta_ValueChanged(sender As Object, e As EventArgs) Handles cbxPRODUCTOdeta.ValueChanged
        If Me.cbxPRODUCTOdeta.Value IsNot Nothing AndAlso Me.cbxPRODUCTOdeta.SelectedIndex >= 0 Then
            Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(Me.cbxPRODUCTOdeta.Value)
            Me.txtPRESENTACIONdeta.Text = lProducto.PRESENTACION
            Me.spePRECIO_UNITARIOdeta.Value = lProducto.PRECIO_UNITARIO
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
        Dim lOrdenDeta As New ORDEN_DETA_AGRI
        Dim lProducto As PRODUCTO

        If Me.cbxPROVEEDOR_AGRICOLA.Value Is Nothing Then
            Me.AsignarMensaje("* Seleccione el Proveedor Agricola", True, False)
            Return
        End If
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

        lOrdenDeta.ID_ORDEN_DETA = Me.ObtenerIdProd(Me.LISTA_ORDEN_DETA_AGRI)
        lOrdenDeta.ID_ORDEN = 0
        lOrdenDeta.ID_PRODUCTO = If(Me.cbxPRODUCTOdeta.SelectedIndex >= 0, Me.cbxPRODUCTOdeta.Value, -1)
        If lOrdenDeta.ID_PRODUCTO <> -1 Then
            lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lOrdenDeta.ID_PRODUCTO)
            If lProducto IsNot Nothing Then
                lOrdenDeta.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
            End If
        Else
            lOrdenDeta.NOMBRE_PRODUCTO = Me.cbxPRODUCTOdeta.Text.ToUpper
        End If
        lOrdenDeta.CANTIDAD = Me.speCANTIDADdeta.Value
        lOrdenDeta.PRECIO_UNITARIO = Me.spePRECIO_UNITARIOdeta.Value
        lOrdenDeta.TOTAL = Me.speSUB_TOTALdeta.Value
        lOrdenDeta.PRESENTACION = Me.txtPRESENTACIONdeta.Text.ToUpper
        lOrdenDeta.UNIDAD = ""
        lOrdenDeta.REFERENCIA = Me.lblREFERENCIA.Text

        Me.LISTA_ORDEN_DETA_AGRI.Add(lOrdenDeta)
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

    Private Function ObtenerIdProd(ByVal lista As listaORDEN_DETA_AGRI) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_ORDEN_DETA > Id Then
                Id = lista(i).ID_ORDEN_DETA
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub ucListaORDEN_DETA_AGRI1_Eliminando(ID_ORDEN_DETA As Integer) Handles ucListaORDEN_DETA_AGRI1.Eliminando
        Me.SetearSubTotalIvaTotal()
    End Sub
End Class
