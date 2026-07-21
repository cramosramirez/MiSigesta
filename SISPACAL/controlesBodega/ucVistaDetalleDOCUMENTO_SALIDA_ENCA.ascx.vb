Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleDOCUMENTO_SALIDA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla DOCUMENTO_SALIDA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleDOCUMENTO_SALIDA_ENCA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_DOCSAL_ENCA As Int32
    Public Property ID_DOCSAL_ENCA() As Int32
        Get
            If Me.ViewState("ID_DOCSAL_ENCA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_DOCSAL_ENCA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_DOCSAL_ENCA") = Value
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
    Private mComponente As New cDOCUMENTO_SALIDA_ENCA
    Private mEntidad As DOCUMENTO_SALIDA_ENCA
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
        If Not Me.ViewState("ID_DOCSAL_ENCA") Is Nothing Then Me._ID_DOCSAL_ENCA = Me.ViewState("ID_DOCSAL_ENCA")
        Me.CargarProductos()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla DOCUMENTO_SALIDA_ENCA
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
        mEntidad = New DOCUMENTO_SALIDA_ENCA
        mEntidad.ID_DOCSAL_ENCA = ID_DOCSAL_ENCA

        If mComponente.ObtenerDOCUMENTO_SALIDA_ENCA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_DOCSAL_ENCA.Text = mEntidad.ID_DOCSAL_ENCA.ToString()
        Me.txtNO_DOCUMENTO.Value = mEntidad.NO_DOCUMENTO
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaDOCUMENTO_SALIDA_DETA1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Public Property LISTA_DOCUMENTO_SALIDA_DETA As listaDOCUMENTO_SALIDA_DETA
        Set(value As listaDOCUMENTO_SALIDA_DETA)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaDOCUMENTO_SALIDA_DETA) Else Return New listaDOCUMENTO_SALIDA_DETA
        End Get
    End Property
 
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
        Me.txtID_DOCSAL_ENCA.ClientEnabled = False
        Me.txtNO_DOCUMENTO.ClientEnabled = False
        Me.cbxID_TIPO_MOVTO.ClientEnabled = _nuevo
        Me.dteFECHA_DOCTO.ClientEnabled = False
        Me.cbxSALBODE_ENCA.ClientEnabled = _nuevo
        Me.cbxBODEGA_ORIGEN.ClientEnabled = _nuevo
        Me.txtOBSERVACIONES.ClientEnabled = _nuevo
        Me.txtENTREGADO.ClientEnabled = _nuevo
        Me.txtRECIBIDO.ClientEnabled = _nuevo
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
        Me.txtID_DOCSAL_ENCA.Text = ""
        Me.txtNO_DOCUMENTO.Text = ""
        Me.cbxID_TIPO_MOVTO.Value = Nothing
        Me.dteFECHA_DOCTO.Value = cFechaHora.ObtenerFecha
        Me.cbxSALBODE_ENCA.Value = Nothing
        Me.cbxBODEGA_ORIGEN.Value = Nothing
        Me.txtOBSERVACIONES.Text = ""
        Me.txtENTREGADO.Text = ""
        Me.txtRECIBIDO.Text = ""

        Me.CargarSolicSALBODE()
        Me.LISTA_DOCUMENTO_SALIDA_DETA = New listaDOCUMENTO_SALIDA_DETA
        Me.CargarDetalleDocumentoEnca()
    End Sub

    Private Sub CargarSolicSALBODE()
        Dim lista As listaSALBODE_ENCA
        Dim lEntidad As New SALBODE_ENCA

        lista = (New cSALBODE_ENCA).ObtenerListaSIN_DOCUMENTO_SALIDA("NO_DOCUMENTO")
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
        Me.cbxSALBODE_ENCA.DataSource = lista
        Me.cbxSALBODE_ENCA.DataBind()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla DOCUMENTO_SALIDA_ENCA
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
        Dim listaDetalle As listaDOCUMENTO_SALIDA_DETA
        Dim bDocumentoDeta As New cDOCUMENTO_SALIDA_DETA
        Dim sValExistencia As String = ""

        mEntidad = New DOCUMENTO_SALIDA_ENCA
        If Me._nuevo Then
            mEntidad.ID_DOCSAL_ENCA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerDOCUMENTO_SALIDA_ENCA(CInt(Me.txtID_DOCSAL_ENCA.Text))
        End If

        If Me.cbxID_TIPO_MOVTO.Value Is Nothing Then
            Return "* Seleccione el Tipo de Movimiento"
        End If
        If Me.dteFECHA_DOCTO.Value Is Nothing Then
            Return "* Ingrese la Fecha de Salida"
        End If
        If Me.cbxBODEGA_ORIGEN.Value Is Nothing Then
            Return "* Seleccione la Bodega"
        End If
        If Me.txtENTREGADO.Text.Trim = "" Then
            Return "* Ingrese el nombre de quien entrega"
        End If
        If Me.txtRECIBIDO.Text.Trim = "" Then
            Return "* Ingrese el nombre de quien recibe"
        End If

        listaDetalle = Me.LISTA_DOCUMENTO_SALIDA_DETA
        If listaDetalle Is Nothing OrElse listaDetalle.Count = 0 Then
            Return "* No se encontro detalle de productos"
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
            Return "* No se encontro cantidad de productos"
        End If
        sValExistencia = Me.ValidarExistencia()
        If sValExistencia <> "" Then
            Return sValExistencia
        End If

        mEntidad.ID_TIPO_MOVTO = Me.cbxID_TIPO_MOVTO.Value
        mEntidad.FECHA_DOCTO = Me.dteFECHA_DOCTO.Date
        mEntidad.UID_DOCUMENTO = Guid.NewGuid
        mEntidad.ID_BODEGA = Me.cbxBODEGA_ORIGEN.Value
        mEntidad.OBSERVACIONES = Me.txtOBSERVACIONES.Text.Trim.ToUpper
        mEntidad.ENTREGADO = Me.txtENTREGADO.Text.Trim.ToUpper
        mEntidad.RECIBIDO = Me.txtRECIBIDO.Text.Trim.ToUpper
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        If Me.cbxSALBODE_ENCA.Value IsNot Nothing AndAlso Me.cbxSALBODE_ENCA.Value > 0 Then
            mEntidad.ID_SALBODE_ENCA = Me.cbxSALBODE_ENCA.Value
        Else
            mEntidad.ID_SALBODE_ENCA = -1
        End If
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value

        If mComponente.ActualizarDOCUMENTO_SALIDA_ENCA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If

        For Each lEntidad As DOCUMENTO_SALIDA_DETA In listaDetalle
            If lEntidad.CANTIDAD > 0 Then
                lEntidad.ID_DOCSAL_ENCA_DETA = If(Me._nuevo, 0, lEntidad.ID_DOCSAL_ENCA_DETA)
                lEntidad.ID_DOCSAL_ENCA = mEntidad.ID_DOCSAL_ENCA
                lEntidad.UID_DOCUMENTO_DETA = Guid.NewGuid
                bDocumentoDeta.ActualizarDOCUMENTO_SALIDA_DETA(lEntidad)
            End If
        Next

        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarDoctoSalidaInventario(" + mEntidad.ID_DOCSAL_ENCA.ToString + ")", True)

        Me.txtID_DOCSAL_ENCA.Text = mEntidad.ID_DOCSAL_ENCA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Private Sub CargarProductos()
        Dim lista As listaPRODUCTO

        lista = (New cPRODUCTO).ObtenerListaPorCriterios(-1, -1, -1, -1, 1, 1, "NOMBRE_PRODUCTO")
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
                Me.speEXISTENCIA.Value = (New cPRODUCTO).ObtenerExistenciaTotal(lProducto.ID_PRODUCTO)
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
        Dim lSalidaDeta As New DOCUMENTO_SALIDA_DETA
        Dim lProducto As PRODUCTO

        If Me.cbxPRODUCTOdeta.Text = "" Then
            Me.AsignarMensaje("* Seleccione o Ingrese el Producto", True, False)
            Return
        End If
        If Me.speCANTIDADdeta.Value = 0 Then
            Me.AsignarMensaje("* Ingrese la Cantidad de Producto", True, False)
            Return
        End If

        lSalidaDeta.ID_DOCSAL_ENCA_DETA = Me.ObtenerIdProd(Me.LISTA_DOCUMENTO_SALIDA_DETA)
        lSalidaDeta.ID_DOCSAL_ENCA = 0
        lSalidaDeta.ID_PRODUCTO = If(Me.cbxPRODUCTOdeta.SelectedIndex >= 0, Me.cbxPRODUCTOdeta.Value, -1)
        If lSalidaDeta.ID_PRODUCTO <> -1 Then
            lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lSalidaDeta.ID_PRODUCTO)
            If lProducto IsNot Nothing Then
                lSalidaDeta.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
            End If
        Else
            lSalidaDeta.NOMBRE_PRODUCTO = Me.cbxPRODUCTOdeta.Text.ToUpper
        End If
        lSalidaDeta.CANTIDAD = Me.speCANTIDADdeta.Value
        lSalidaDeta.PRECIO_UNITARIO = Me.spePRECIO_UNITARIOdeta.Value
        lSalidaDeta.TOTAL = Me.speSUB_TOTALdeta.Value
        lSalidaDeta.PRESENTACION = Me.txtPRESENTACIONdeta.Text.ToUpper
        lSalidaDeta.UNIDAD = ""
        lSalidaDeta.REFERENCIA = Me.lblREFERENCIA.Text

        Me.LISTA_DOCUMENTO_SALIDA_DETA.Add(lSalidaDeta)
        Me.CargarDetalleDocumentoEnca()
        Me.AsignarMensaje("", True, False)

        Me.cbxPRODUCTOdeta.SelectedIndex = -1
        Me.txtPRESENTACIONdeta.Text = ""

        Me.speCANTIDADdeta.Text = ""
        Me.spePRECIO_UNITARIOdeta.Text = ""
        Me.speEXISTENCIA.Value = Nothing
        Me.speSUB_TOTALdeta.Text = ""
        Me.cbxPRODUCTOdeta.Focus()
    End Sub

    Private Function ObtenerIdProd(ByVal lista As listaDOCUMENTO_SALIDA_DETA) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_DOCSAL_ENCA_DETA > Id Then
                Id = lista(i).ID_DOCSAL_ENCA_DETA
            End If
        Next
        Return (Id + 1)
    End Function

    Private Sub IniciarDetalleSALBODE()
        Dim lDeta As DOCUMENTO_SALIDA_DETA
        Dim lProducto As PRODUCTO
        Dim lKardex As KARDEX
        Dim lCodigoProd As Int32 = -100
        Dim dCantidad As Decimal = 0

        Me.LISTA_DOCUMENTO_SALIDA_DETA = New listaDOCUMENTO_SALIDA_DETA
        If Me.cbxSALBODE_ENCA.Value IsNot Nothing Then
            Dim listaSalDeta As listaSALBODE_DETA = (New cSALBODE_DETA).ObtenerListaPorSALBODE_ENCA(Me.cbxSALBODE_ENCA.Value, False, False, "ID_PRODUCTO", "ASC")
            If listaSalDeta IsNot Nothing AndAlso listaSalDeta.Count > 0 Then
                For i As Int32 = 0 To listaSalDeta.Count - 1
                    If lCodigoProd <> -100 AndAlso lCodigoProd <> listaSalDeta(i).ID_PRODUCTO AndAlso dCantidad > 0 Then
                        lDeta = New DOCUMENTO_SALIDA_DETA
                        lDeta.ID_DOCSAL_ENCA_DETA = Me.ObtenerIdProd(Me.LISTA_DOCUMENTO_SALIDA_DETA)
                        lDeta.ID_DOCSAL_ENCA = 0
                        lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lCodigoProd)
                        lKardex = (New cKARDEX).ObtenerKARDEX_UltimoMovtoID_PRODUCTO(Me.cbxBODEGA_ORIGEN.Value, lCodigoProd)
                        lDeta.ID_PRODUCTO = lCodigoProd
                        lDeta.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
                        lDeta.UNIDAD = ""
                        lDeta.PRESENTACION = lProducto.PRESENTACION
                        lDeta.CANTIDAD = dCantidad
                        If lKardex IsNot Nothing Then
                            lDeta.PRECIO_UNITARIO = lKardex.SDO_PRECIO_UNITARIO
                            lDeta.TOTAL = dCantidad * lKardex.SDO_PRECIO_UNITARIO
                        End If
                        Me.LISTA_DOCUMENTO_SALIDA_DETA.Add(lDeta)
                        dCantidad = 0
                        lCodigoProd = listaSalDeta(i).ID_PRODUCTO
                    ElseIf lCodigoProd = -100 Then
                        lCodigoProd = listaSalDeta(i).ID_PRODUCTO
                    End If
                    dCantidad += (listaSalDeta(i).CANTIDAD - listaSalDeta(i).CANT_ANULADA)
                Next

                If dCantidad > 0 Then
                    lDeta = New DOCUMENTO_SALIDA_DETA
                    lDeta.ID_DOCSAL_ENCA_DETA = Me.ObtenerIdProd(Me.LISTA_DOCUMENTO_SALIDA_DETA)
                    lDeta.ID_DOCSAL_ENCA = 0
                    lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lCodigoProd)
                    lKardex = (New cKARDEX).ObtenerKARDEX_UltimoMovtoID_PRODUCTO(Me.cbxBODEGA_ORIGEN.Value, lCodigoProd)
                    lDeta.ID_PRODUCTO = lProducto.ID_PRODUCTO
                    lDeta.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
                    lDeta.UNIDAD = ""
                    lDeta.PRESENTACION = lProducto.PRESENTACION
                    lDeta.CANTIDAD = dCantidad
                    If lKardex IsNot Nothing Then
                        lDeta.PRECIO_UNITARIO = lKardex.SDO_PRECIO_UNITARIO
                        lDeta.TOTAL = dCantidad * lKardex.SDO_PRECIO_UNITARIO
                    End If

                    Me.LISTA_DOCUMENTO_SALIDA_DETA.Add(lDeta)
                End If
                
                Me.CargarDetalleDocumentoEnca()
            End If
        End If

        Me.AsignarMensaje(Me.ValidarExistencia, True, False)
    End Sub

    Private Function ValidarExistencia() As String
        '************************************************
        'Verificar si hay existencias para los productos
        Dim lista As listaDOCUMENTO_SALIDA_DETA = Me.LISTA_DOCUMENTO_SALIDA_DETA
        Dim lProducto As PRODUCTO
        Dim lProveeAgri As PROVEEDOR_AGRICOLA
        Dim lKardex As KARDEX
        Dim str As New StringBuilder

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Int32 = 0 To lista.Count - 1
                lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lista(i).ID_PRODUCTO)
                lProveeAgri = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(lProducto.ID_PROVEE)
                lKardex = (New cKARDEX).ObtenerKARDEX_UltimoMovtoID_PRODUCTO(Me.cbxBODEGA_ORIGEN.Value, lista(i).ID_PRODUCTO)
                If lKardex IsNot Nothing Then
                    If lKardex.SDO_UNIDAD < lista(i).CANTIDAD Then
                        str.Append("* Para el producto: ")
                        str.Append(lProveeAgri.NOMBRE)
                        str.Append(" - ")
                        str.Append(lProducto.NOMBRE_PRODUCTO)
                        str.Append(" ")
                        str.Append(lista(i).PRESENTACION)
                        str.Append(" se tiene en existencia: ")
                        str.Append(Format(lKardex.SDO_UNIDAD, "#,##0.00##"))
                        str.AppendLine(" unidades" + vbCrLf)
                    End If
                Else
                    str.Append("* Para el producto: ")
                    str.Append(lProveeAgri.NOMBRE)
                    str.Append(" - ")
                    str.Append(lProducto.NOMBRE_PRODUCTO)
                    str.Append(" ")
                    str.Append(lista(i).PRESENTACION)
                    str.Append(" se tiene en existencia: 0.00 unidades" + vbCrLf)
                End If
            Next
        End If
        If str.ToString <> "" Then Return str.ToString Else Return ""
    End Function

    Protected Sub cbxSALBODE_ENCA_ValueChanged(sender As Object, e As EventArgs) Handles cbxSALBODE_ENCA.ValueChanged
        If cbxSALBODE_ENCA.Value IsNot Nothing AndAlso cbxSALBODE_ENCA.Value > 0 Then
            Me.trPRODUCTO_AGRICOLA_DETA1.Visible = False
            Me.trPRODUCTO_AGRICOLA_DETA2.Visible = False
            Me.ucListaDOCUMENTO_SALIDA_DETA1.PermitirEliminar = False
            Me.IniciarDetalleSALBODE()
        Else
            Me.trPRODUCTO_AGRICOLA_DETA1.Visible = True
            Me.trPRODUCTO_AGRICOLA_DETA2.Visible = True
            Me.LISTA_DOCUMENTO_SALIDA_DETA = New listaDOCUMENTO_SALIDA_DETA
            Me.ucListaDOCUMENTO_SALIDA_DETA1.PermitirEliminar = True
            Me.CargarDetalleDocumentoEnca()
        End If
    End Sub

    Protected Sub cbxBODEGA_ORIGEN_ValueChanged(sender As Object, e As EventArgs) Handles cbxBODEGA_ORIGEN.ValueChanged
        Me.ucListaDOCUMENTO_SALIDA_DETA1.ID_BODEGA = Me.cbxBODEGA_ORIGEN.Value
    End Sub

    Protected Sub cbxID_TIPO_MOVTO_ValueChanged(sender As Object, e As EventArgs) Handles cbxID_TIPO_MOVTO.ValueChanged
        If cbxID_TIPO_MOVTO.Value IsNot Nothing Then
            Me.cbxSALBODE_ENCA.ClientEnabled = Not Me.cbxID_TIPO_MOVTO.Value = 9
        Else
            Me.cbxSALBODE_ENCA.ClientEnabled = True
        End If
    End Sub
End Class
