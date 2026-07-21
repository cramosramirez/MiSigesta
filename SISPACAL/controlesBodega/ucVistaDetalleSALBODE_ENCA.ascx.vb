Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSALBODE_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SALBODE_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/08/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSALBODE_ENCA
    Inherits ucBase
 
#Region "Propiedades"

    Private _ID_SALBODE_ENCA As Int32
    Public Property ID_SALBODE_ENCA() As Int32
        Get
            If Me.ViewState("ID_SALBODE_ENCA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_SALBODE_ENCA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_SALBODE_ENCA") = Value
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

    Public Property LISTA_SALBODE_DETA As listaSALBODE_DETA
        Set(value As listaSALBODE_DETA)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaSALBODE_DETA) Else Return New listaSALBODE_DETA
        End Get
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSALBODE_ENCA
    Private mEntidad As SALBODE_ENCA
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
        If Not Me.ViewState("ID_SALBODE_ENCA") Is Nothing Then Me._ID_SALBODE_ENCA = Me.ViewState("ID_SALBODE_ENCA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SALBODE_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/08/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SALBODE_ENCA
        mEntidad.ID_SALBODE_ENCA = ID_SALBODE_ENCA

        If mComponente.ObtenerSALBODE_ENCA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_SALBODE_ENCA.Text = mEntidad.ID_SALBODE_ENCA.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.txtNO_DOCUMENTO.Value = mEntidad.NO_DOCUMENTO
        Me.dteFECHA_DOCTO.Value = mEntidad.FECHA
        Me.txtNUMS_SOLICITUDES.Text = mEntidad.NUMS_SOLICITUDES
        Me.chkRETIRO_PROD.Checked = mEntidad.RETIRO_PROD
        Me.IniciarDetalle(Me.ID_SALBODE_ENCA)
        Me.CargarDetalleDocumentoEnca()
    End Sub

    Private Sub IniciarDetalle(ByVal ID_SALBODE_ENCA As Int32)
        Dim lista As listaSALBODE_DETA = (New cSALBODE_DETA).ObtenerListaPorSALBODE_ENCA(ID_SALBODE_ENCA)

        Me.LISTA_SALBODE_DETA = New listaSALBODE_DETA
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For Each lEntidad As SALBODE_DETA In lista
                lEntidad.CANT_ENTREGADA = If(lEntidad.CANT_ENTREGADA = -1, 0, lEntidad.CANT_ENTREGADA)
                lEntidad.REFERENCIA = Me.lblREFERENCIA.Text
                Me.LISTA_SALBODE_DETA.Add(lEntidad)
            Next
        End If
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaSALBODE_DETA1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/08/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = False
        Me.txtNO_DOCUMENTO.ClientEnabled = False
        Me.dteFECHA_DOCTO.ClientEnabled = False
        Me.txtNUMS_SOLICITUDES.ClientEnabled = False
        Me.chkRETIRO_PROD.ClientEnabled = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/08/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxZAFRA.Value = Nothing
        Me.txtNO_DOCUMENTO.Value = Nothing
        Me.dteFECHA_DOCTO.Value = Nothing
        Me.txtNUMS_SOLICITUDES.Text = ""
        Me.chkRETIRO_PROD.Checked = False
        Me.LISTA_SALBODE_DETA = New listaSALBODE_DETA
        Me.CargarDetalleDocumentoEnca()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SALBODE_ENCA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/08/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim listaDetalle As listaSALBODE_DETA
        Dim listaDoctoSalida As listaDOCUMENTO_SALIDA_ENCA
        Dim bDocumentoDeta As New cSALBODE_DETA
        Dim poseeEntrega As Boolean = False

        mEntidad = New SALBODE_ENCA
        If Me._nuevo Then
            mEntidad.ID_SALBODE_ENCA = 0
        Else
            mEntidad = mComponente.ObtenerSALBODE_ENCA(CInt(Me.txtID_SALBODE_ENCA.Text))
        End If

        If Me.chkRETIRO_PROD.Checked Then
            'Validar que las solicitudes sean de un solo productor
            Dim sCodi As String = ""
            Dim listaDeta As listaSALBODE_DETA = (New cSALBODE_DETA).ObtenerListaPorSALBODE_ENCA(mEntidad.ID_SALBODE_ENCA)
            If listaDeta IsNot Nothing AndAlso listaDeta.Count > 0 Then
                For Each lEntidad As SALBODE_DETA In listaDeta
                    Dim lSolic As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(lEntidad.ID_SOLICITUD)
                    If sCodi = "" Then sCodi = lSolic.CODIPROVEEDOR
                    If sCodi <> lSolic.CODIPROVEEDOR Then
                        Return "* No se puede guardar la Solicitud para retiro por parte de un productor debido a que hay más de un productor en la solicitud"
                    End If
                Next
            End If
        End If

        mEntidad.RETIRO_PROD = Me.chkRETIRO_PROD.Checked
        mComponente.ActualizarSALBODE_ENCA(mEntidad)

        listaDetalle = Me.LISTA_SALBODE_DETA

        If listaDetalle Is Nothing OrElse listaDetalle.Count = 0 Then
            Return "* No se encontro detalle de productos"
        End If

        'Validar que la solicitud tenga una salida de bodega asociada
        For Each lEntidad As SALBODE_DETA In listaDetalle
            If lEntidad.CANT_ENTREGADA > 0 Then
                poseeEntrega = True
                Exit For
            End If
        Next

        listaDoctoSalida = (New cDOCUMENTO_SALIDA_ENCA).ObtenerListaPorSALBODE_ENCA(Me.ID_SALBODE_ENCA)
        If (listaDoctoSalida Is Nothing AndAlso poseeEntrega) OrElse (listaDoctoSalida IsNot Nothing AndAlso listaDoctoSalida.Count = 0 AndAlso poseeEntrega) Then
            Return "* No se pueden registrar las entregas ya que la solicitud no tiene relacionada un Documento de Salida de Bodega"
        End If

        'Validar que las entregas totales de productos sean ingresadas en cada producto sean igual a las entregas calculadas de bodega
        If poseeEntrega Then
            Dim diccProd As New Dictionary(Of Int32, Decimal)
            Dim bSalBodeEnca As New cSALBODE_ENCA
            Dim sCad As New StringBuilder

            For Each lEntidad As SALBODE_DETA In listaDetalle
                If lEntidad.CANTIDAD > 0 Then
                    If Not diccProd.Keys.Contains(lEntidad.ID_PRODUCTO) Then
                        diccProd.Add(lEntidad.ID_PRODUCTO, lEntidad.CANT_ENTREGADA)
                    Else
                        diccProd(lEntidad.ID_PRODUCTO) += lEntidad.CANT_ENTREGADA
                    End If
                End If
            Next

            For Each elemento As KeyValuePair(Of Int32, Decimal) In diccProd
                Dim dicCantEntregadaCalc As Dictionary(Of String, Decimal) = bSalBodeEnca.PROC_Calcular_Entrega_Producto(Me.ID_SALBODE_ENCA, elemento.Key)
                If dicCantEntregadaCalc("ENTREGA") <> elemento.Value Then
                    Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(elemento.Key)
                    Dim lProvee As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(lProducto.ID_PROVEE)
                    If lProducto IsNot Nothing Then
                        sCad.Append("* La cantidad entregada del producto ")
                        If lProvee IsNot Nothing Then
                            sCad.Append(lProvee.NOMBRE)
                            sCad.Append("-")
                        End If
                        sCad.Append(lProducto.NOMBRE_PRODUCTO)
                        sCad.Append(" es diferente a la de bodega. Salida:")
                        sCad.Append(dicCantEntregadaCalc("SALIDA"))
                        sCad.Append(" Devolucion:")
                        sCad.Append(dicCantEntregadaCalc("DEVOLUCION"))
                        sCad.Append(" Entrega:")
                        sCad.Append(dicCantEntregadaCalc("ENTREGA"))
                        sCad.Append(vbCrLf)
                    End If
                End If
            Next
            If sCad.ToString <> "" Then Return sCad.ToString
        End If

        For Each lEntidad As SALBODE_DETA In listaDetalle
            If lEntidad.CANTIDAD > 0 Then
                lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
                If lEntidad.CANT_ENTREGADA = 0 Then
                    lEntidad.CANT_ENTREGADA = -1
                    lEntidad.USUARIO_ACT = Nothing
                    lEntidad.FECHA_ACT = #12:00:00 AM#
                End If
                bDocumentoDeta.ActualizarSALBODE_DETA(lEntidad)
            End If
        Next

        Me.txtID_SALBODE_ENCA.Text = mEntidad.ID_SALBODE_ENCA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub btnSolicIgualEntrega_Click(sender As Object, e As EventArgs) Handles btnSolicIgualEntrega.Click
        Dim lista As listaSALBODE_DETA = Me.LISTA_SALBODE_DETA

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For Each lEntidad As SALBODE_DETA In lista
                lEntidad.CANT_ENTREGADA = lEntidad.CANTIDAD
            Next
        End If
        Me.LISTA_SALBODE_DETA = lista
        Me.CargarDetalleDocumentoEnca()
    End Sub
End Class
