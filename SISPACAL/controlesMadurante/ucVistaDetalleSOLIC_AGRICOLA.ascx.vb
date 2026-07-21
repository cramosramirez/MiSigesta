Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSOLIC_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_AGRICOLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_AGRICOLA
    Inherits ucBase
    Public Const PrecioAgua As Decimal = 0.5

#Region "Propiedades"

    Public Property GENERAR_ORDEN_COMPRA As Boolean
        Get
            If Me.ViewState("GENERAR_ORDEN_COMPRA") IsNot Nothing Then
                Return CBool(Me.ViewState("GENERAR_ORDEN_COMPRA"))
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("GENERAR_ORDEN_COMPRA") = value
        End Set
    End Property

    Public Property CATEGORIA_PRODUCTO As CategoriaProducto
        Get
            If Me.ViewState("CATEGORIA_PRODUCTO") IsNot Nothing Then
                Return CInt(Me.ViewState("CATEGORIA_PRODUCTO"))
            Else
                Return EtapaRequisicion.Todas
            End If
        End Get
        Set(ByVal value As CategoriaProducto)
            Me.ViewState("CATEGORIA_PRODUCTO") = value
            Me.LimpiarControles()
            Me.ID_SOLICITUD = 0
        End Set
    End Property

    Public Property LISTA_SOLIC_AGRICOLA_LOTE As listaSOLIC_AGRICOLA_LOTE
        Set(value As listaSOLIC_AGRICOLA_LOTE)
            Dim i As Int32 = 1
            If value IsNot Nothing Then
                For Each lEntidad As SOLIC_AGRICOLA_LOTE In value
                    If lEntidad.ID_SOLIC_AGRI_LOTE = 0 Then
                        lEntidad.ID_SOLIC_AGRI_LOTE = i
                        i += 1
                    End If
                    lEntidad.REFERENCIA = Me.lblREFERENCIA_LOTES.Text
                Next
            Else
                value = New listaSOLIC_AGRICOLA_LOTE
            End If
            Session(Me.lblREFERENCIA_LOTES.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA_LOTES.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA_LOTES.Text), listaSOLIC_AGRICOLA_LOTE) Else Return New listaSOLIC_AGRICOLA_LOTE
        End Get
    End Property

    Public Property LISTA_SOLIC_AGRICOLA_PRODUCTO As listaSOLIC_AGRICOLA_PRODUCTO
        Set(value As listaSOLIC_AGRICOLA_PRODUCTO)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaSOLIC_AGRICOLA_PRODUCTO) Else Return New listaSOLIC_AGRICOLA_PRODUCTO
        End Get
    End Property

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
            Me.lblREFERENCIA.Text = Now.ToString("dd/MM/yyyy HH:mm:ss zzz")
            Me.lblREFERENCIA_LOTES.Text = "SOLIC_LOTES" + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm:ss zzz")
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
            If Session(lblREFERENCIA.Text + "TOTAL_MZ") IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text + "TOTAL_MZ")
            End If
            If Session(lblREFERENCIA.Text + "SUB_TOTAL") IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text + "SUB_TOTAL")
            End If
        End If
        If lblREFERENCIA_LOTES.Text <> "" Then
            Session.Remove(lblREFERENCIA_LOTES.Text)
        End If
    End Sub

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLIC_AGRICOLA
    Private mEntidad As SOLIC_AGRICOLA
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

    Public Property SUB_TOTAL() As Decimal
        Get
            If Me.speSUB_TOTAL.Text.Trim = "" Then
                Return 0
            End If
            Return Convert.ToDecimal(Me.speSUB_TOTAL.Text)
        End Get
        Set(ByVal value As Decimal)
            Me.SetearSubTotalIvaTotal()
        End Set
    End Property

    Public Property TOTAL_MZ() As Decimal
        Get
            If speRIEGO_MZ Is Nothing Then
                Return 0
            Else
                Return speRIEGO_MZ.Value
            End If
        End Get
        Set(ByVal value As Decimal)
            If Not speRIEGO_MZ.ClientEnabled Then speRIEGO_MZ.Value = value
            speMZ_TOTALES.Value = value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_SOLICITUD") Is Nothing Then Me._ID_SOLICITUD = Me.ViewState("ID_SOLICITUD")
        If Not IsPostBack Then
            Me.CargarProveedorVuelo()
        End If
        Me.CargarProveedorAgricola()
        Me.CargarProductos()
        If Session(Me.lblREFERENCIA.Text + "TOTAL_MZ") IsNot Nothing Then Me.TOTAL_MZ = Session(Me.lblREFERENCIA.Text + "TOTAL_MZ")
        If Session(Me.lblREFERENCIA.Text + "SUB_TOTAL") IsNot Nothing Then Me.SUB_TOTAL = Session(Me.lblREFERENCIA.Text + "SUB_TOTAL")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lProveedor As PROVEEDOR
        Dim listaSolicProd As New listaSOLIC_AGRICOLA_LOTE
        Dim listaLotesProvee As New listaLOTES
        Dim lContrato As CONTRATO
        Dim mzEsticana As Decimal = 0
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_AGRICOLA
        mEntidad.ID_SOLICITUD = Me.ID_SOLICITUD

        If mComponente.ObtenerSOLIC_AGRICOLA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        Me.txtCCF_NOMBRE.Text = ""
        Me.txtLUGAR_ENTREGA.Text = ""
        Me.txtCONTACTO.Text = ""

        If Me.GENERAR_ORDEN_COMPRA Then
            Me.trPRODUCTO_AGRICOLA_DETA1.Visible = False
            Me.trPRODUCTO_AGRICOLA_DETA2.Visible = False

            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.VerTOTAL_PRODUCTO = False
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.VerPRECIO_UNITARIO = False
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.VerPRECIO_TOTAL = False

            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.VerCANT_ADJU = True
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.VerPRECIO_ADJU = True
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.VerTOTAL_ADJU = True

            Me.txtCCF_NOMBRE.Text = mEntidad.NOMBRE_PROVEEDOR
            lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
            If lProveedor IsNot Nothing Then
                Me.txtLUGAR_ENTREGA.Text = lProveedor.DIRECCION
            End If
        End If
        Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.ID_CUENTA_FINAN = mEntidad.ID_CUENTA_FINAN
        Me.txtID_SOLICITUD.Text = mEntidad.ID_SOLICITUD.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.txtNUM_SOLICITUD.Text = mEntidad.NUM_SOLICITUD
        Me.txtCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(mEntidad.CODIPROVEEDOR)
        lContrato = (New cCONTRATO).ObtenerCONTRATO(mEntidad.CODICONTRATO)
        Me.dteFECHA_SOLIC.Date = mEntidad.FECHA_SOLIC
        If lContrato IsNot Nothing Then Me.cbxContrato.Text = lContrato.NO_CONTRATO.ToString
        Me.txtNOMBRE_PROVEEDOR.Text = mEntidad.NOMBRE_PROVEEDOR
        Me.txtACTIVIDAD.Text = mEntidad.ACTIVIDAD
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtNRC.Text = mEntidad.NRC
        Me.cbxESTADO.Value = mEntidad.ESTADO
        Me.cbxTIPO_FINANCIAMIENTO.Value = mEntidad.ID_CUENTA_FINAN
        Me.cbxCONDICION_COMPRA.Value = mEntidad.CONDI_COMPRA
        Me.DSComboProductos()
        Me.LISTA_SOLIC_AGRICOLA_LOTE = (New cSOLIC_AGRICOLA_LOTE).ObtenerListaPorSOLIC_AGRICOLA(mEntidad.ID_SOLICITUD)
       
        CargarDetalleSolicAgricolaLotes()
        Me.ucListaSOLIC_AGRICOLA_LOTE1.SeleccionarTodos()
        Me.SetearMZ()
        Me.LISTA_SOLIC_AGRICOLA_PRODUCTO = (New cSOLIC_AGRICOLA_PRODUCTO).ObtenerListaPorSOLIC_AGRICOLA(mEntidad.ID_SOLICITUD)


        'Inicializar Valores Adjudicados
        Dim lista_ As listaSOLIC_AGRICOLA_PRODUCTO = Me.LISTA_SOLIC_AGRICOLA_PRODUCTO
        For i As Int32 = 0 To lista_.Count - 1
            If Me.GENERAR_ORDEN_COMPRA Then
                lista_(i).ID_PROVEE_ADJU = lista_(i).ID_PROVEE
                lista_(i).CANT_ADJU = lista_(i).TOTAL_PRODUCTO
                lista_(i).PRECIO_ADJU = lista_(i).PRECIO_UNITARIO
                lista_(i).TOTAL_ADJU = lista_(i).PRECIO_TOTAL
            End If
            lista_(i).REFERENCIA = Me.lblREFERENCIA.Text
        Next
        Me.LISTA_SOLIC_AGRICOLA_PRODUCTO = lista_

        Me.CargarDetalleSolicAgricolaProducto()
        Dim listaSolicVuelo As listaSOLIC_AGRICOLA_VUELO = (New cSOLIC_AGRICOLA_VUELO).ObtenerListaPorSOLIC_AGRICOLA(mEntidad.ID_SOLICITUD)
        If listaSolicVuelo IsNot Nothing AndAlso listaSolicVuelo.Count > 0 Then
            Dim lEntidadVuelo As SOLIC_AGRICOLA_VUELO = listaSolicVuelo(0)
            If lEntidadVuelo.ID_PROVEE <> -1 Then Me.cbxPROVEEDOR_VUELO.Value = lEntidadVuelo.ID_PROVEE
            Me.cbxMEDIO_APLICA.Value = lEntidadVuelo.MEDIO_APLICA
            Me.txtPILOTO.Text = lEntidadVuelo.NOMBRE_PILOTO
            Me.txtDESCRIP_AERONAVE.Text = lEntidadVuelo.DESCRIP_AERONAVE

            If lEntidadVuelo.MZ_REGAR_AGUA > 0 Then Me.chkAplicaAGUA.Checked = True
            Me.speAGUA_MZ.Value = lEntidadVuelo.MZ_REGAR_AGUA
            Me.speAGUA_PRECIO_UNIT.Value = lEntidadVuelo.PRECIO_UNIT_AGUA
            Me.speAGUA_TOTAL.Value = lEntidadVuelo.PRECIO_TOTAL_AGUA

            Me.speRIEGO_MZ.Value = lEntidadVuelo.MZ_HORAS_VUELO
            Me.speRIEGO_PRECIO_UNIT.Value = lEntidadVuelo.PRECIO_UNIT_VUELO
            Me.speRIEGO_TOTAL.Value = lEntidadVuelo.PRECIO_TOTAL_VUELO
        End If
        Me.speSUB_TOTAL.Text = mEntidad.SUB_TOTAL
        Me.speIVA.Text = mEntidad.IVA
        Me.speFOVIAL_COTRANS.Text = mEntidad.FOVIAL_COTRANS
        Me.speTOTAL.Text = mEntidad.TOTAL
       
        Me.dteFECHA_APLICACION.Date = mEntidad.FECHA_APLICA

        Me.cbxPROVEEDOR_AGRICOLAdeta.SelectedIndex = -1
        Me.CargarProductos()
        Me.cbxPRODUCTOdeta.SelectedIndex = -1
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANT_MZdeta.Text = ""
        Me.speCANTIDADdeta.Text = ""
        Me.spePRECIO_UNITARIOdeta.Text = ""
    End Sub

    Public Sub CargarDetalleSolicAgricolaProducto()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
        SetearSubTotalIvaTotal()
    End Sub

    Public Sub CargarDetalleSolicAgricolaLotes()
        If Me.lblREFERENCIA_LOTES.Text <> "" Then
            Me.ucListaSOLIC_AGRICOLA_LOTE1.CargarDatosCache(Me.lblREFERENCIA_LOTES.Text)
        End If
    End Sub

    Public Sub SetearSubTotalIvaTotal()
        Dim subTOTAL As Decimal = 0
        Dim CantidadGalones As Decimal = 0
        Dim IVA As Decimal = 0
        Dim TOTAL As Decimal = 0
        Dim listaProd As listaSOLIC_AGRICOLA_PRODUCTO = Me.LISTA_SOLIC_AGRICOLA_PRODUCTO

        For Each lProducto As SOLIC_AGRICOLA_PRODUCTO In Me.LISTA_SOLIC_AGRICOLA_PRODUCTO
            If Not Me.GENERAR_ORDEN_COMPRA Then
                subTOTAL += lProducto.PRECIO_TOTAL
                If lProducto.NOMBRE_PRODUCTO.ToUpper.Contains("COMBUSTIBLE") Then CantidadGalones += lProducto.TOTAL_PRODUCTO
            Else
                subTOTAL += lProducto.TOTAL_ADJU
                If lProducto.NOMBRE_PRODUCTO.ToUpper.Contains("COMBUSTIBLE") Then CantidadGalones += lProducto.TOTAL_ADJU
            End If
        Next
        If Me.chkAplicaAGUA.Checked Then
            Me.speAGUA_MZ.Value = Me.TOTAL_MZ
            Me.speAGUA_TOTAL.Value = Math.Round(Me.speAGUA_MZ.Value * Me.speAGUA_PRECIO_UNIT.Value, 2)
        Else
            Me.speAGUA_MZ.Value = 0
            Me.speAGUA_PRECIO_UNIT.Value = 0
            Me.speAGUA_TOTAL.Value = 0
        End If
        subTOTAL += Me.speAGUA_TOTAL.Value
        If Me.speRIEGO_MZ.Value > 0 Then
            Me.speRIEGO_TOTAL.Value = Math.Round(Me.speRIEGO_MZ.Value * Me.speRIEGO_PRECIO_UNIT.Value, 2)
        Else
            Me.speRIEGO_PRECIO_UNIT.Value = 0
            Me.speRIEGO_TOTAL.Value = 0
        End If
        subTOTAL += Me.speRIEGO_TOTAL.Value
        If Me.lblREFERENCIA.Text <> "" Then Session(Me.lblREFERENCIA.Text + "SUB_TOTAL") = subTOTAL
        Me.speSUB_TOTAL.Value = subTOTAL
        Me.speIVA.Value = Math.Round(Math.Round(subTOTAL, 2) * Utilerias.TasaIva, 2)
        Me.speFOVIAL_COTRANS.Value = Math.Round(CantidadGalones * Enumeradores.ImpuestoGasolina.Fovial, 2) + _
                Math.Round(CantidadGalones * Enumeradores.ImpuestoGasolina.Cotrans, 2)
        Me.speTOTAL.Value = Math.Round(subTOTAL, 2) + Math.Round(Math.Round(subTOTAL, 2) * Utilerias.TasaIva, 2) + Me.speFOVIAL_COTRANS.Value

        If listaProd IsNot Nothing AndAlso (listaProd.Count > 1 OrElse _
            (listaProd.Count = 1 AndAlso listaProd(0).ID_PRODUCTO > 0)) Then
            Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = False
        Else
            Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = True
        End If
    End Sub

    Private Sub SetearMZ()
        Dim Mz As Decimal = 0
        Dim lista As listaSOLIC_AGRICOLA_LOTE
        'If Me._nuevo Then lista = Me.ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados Else lista = Me.LISTA_SOLIC_AGRICOLA_LOTE
        lista = Me.ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados
        For Each lEntidad As SOLIC_AGRICOLA_LOTE In lista
            Mz += lEntidad.MZ
        Next
        If Me.lblREFERENCIA.Text <> "" Then Session(Me.lblREFERENCIA.Text + "TOTAL_MZ") = Mz
        Me.TOTAL_MZ = Mz
        Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.MZ = Mz
        Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.ZAFRA = Me.cbxZAFRA.Text
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Dim l As LayoutItemBase

        Me.txtNUM_SOLICITUD.ClientEnabled = False
        Me.cbxZAFRA.ClientEnabled = Me._nuevo
        Me.txtCODIPROVEE.ClientEnabled = Me._nuevo AndAlso edicion
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.txtNIT.ClientEnabled = Me._nuevo AndAlso edicion
        Me.txtNRC.ClientEnabled = Me._nuevo AndAlso edicion
        Me.txtACTIVIDAD.ClientEnabled = Me._nuevo AndAlso edicion
        Me.cbxPROVEEDOR_VUELO.ClientEnabled = edicion
        Me.txtPILOTO.ClientEnabled = edicion
        Me.cbxMEDIO_APLICA.ClientEnabled = edicion
        Me.txtDESCRIP_AERONAVE.ClientEnabled = edicion
        Me.chkAplicaAGUA.ClientEnabled = edicion
        Me.speAGUA_PRECIO_UNIT.ClientEnabled = edicion
        Me.speRIEGO_PRECIO_UNIT.ClientEnabled = edicion
        Me.ASPxPageControl1.ActiveTabIndex = 0
        Me.cbxESTADO.ClientEnabled = False
        Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = Me._nuevo
        Me.cbxCONDICION_COMPRA.ClientEnabled = Me._nuevo
        Me.speMZ_TOTALES.ClientEnabled = False
        Me.cbxContrato.ClientEnabled = Me._nuevo AndAlso edicion
        Me.dteFECHA_APLICACION.ClientVisible = Not Me._nuevo AndAlso edicion
        Me.speRIEGO_MZ.ClientEnabled = Not Me._nuevo AndAlso edicion
        Me.ucListaSOLIC_AGRICOLA_LOTE1.MostrarCheckVariaSeleccion = edicion 'Me._nuevo AndAlso edicion
        Me.ucListaSOLIC_AGRICOLA_LOTE1.PermitirEditar = edicion 'Me._nuevo AndAlso edicion
        Me.ucListaSOLIC_AGRICOLA_LOTE1.PermitirEditarInline = edicion 'Me._nuevo AndAlso edicion
        If Me._nuevo Then Me.ucListaSOLIC_AGRICOLA_LOTE1.QuitarSelecciones()
        Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirEliminarInline = edicion 'Me._nuevo AndAlso edicion
        If Me._nuevo Then
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirAgregarInline = edicion 'Me._nuevo AndAlso edicion
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirEditarInline = edicion 'Me._nuevo AndAlso edicion
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirEliminar = edicion
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirEditarInline2 = False
        ElseIf edicion Then
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirAgregarInline = False 'Me._nuevo AndAlso edicion
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirEditarInline = Me.GENERAR_ORDEN_COMPRA
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirEliminar = False
            Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.PermitirEditarInline2 = False 'Me._nuevo AndAlso edicion
        End If
        l = ucVistaDetalleSOLIC_AGRICOLALayout.FindItemOrGroupByName("lyiFechaAplicacion")
        If l IsNot Nothing Then
            If Not Me.GENERAR_ORDEN_COMPRA Then
                l.ClientVisible = Not Me._nuevo AndAlso edicion
            Else
                l.ClientVisible = False
            End If
        End If

        l = ucVistaDetalleSOLIC_AGRICOLALayout.FindItemOrGroupByName("lyiFacturaNombre")
        If l IsNot Nothing Then
            If Me.GENERAR_ORDEN_COMPRA Then
                l.ClientVisible = True
            Else
                l.ClientVisible = False
            End If
        End If
        l = ucVistaDetalleSOLIC_AGRICOLALayout.FindItemOrGroupByName("lyiLugarEntrega")
        If l IsNot Nothing Then
            If Me.GENERAR_ORDEN_COMPRA Then
                l.ClientVisible = True
            Else
                l.ClientVisible = False
            End If
        End If
        l = ucVistaDetalleSOLIC_AGRICOLALayout.FindItemOrGroupByName("lyiContacto")
        If l IsNot Nothing Then
            If Me.GENERAR_ORDEN_COMPRA Then
                l.ClientVisible = True
            Else
                l.ClientVisible = False
            End If
        End If

        Me.chkSelectTodosLotes.ClientVisible = Me._nuevo
    End Sub

    Private Sub CargarProveedorVuelo()
        Dim lista As listaPROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerListaPorTIPO_PROVEEDOR(1, -1, -1, "NOMBRE")
        Dim lProveedor As New PROVEEDOR_AGRICOLA

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                If lista(i).APELLIDOS.Trim <> "" Then
                    lista(i).NOMBRE = lista(i).NOMBRE.Trim + " " + lista(i).APELLIDOS.Trim
                End If
            Next
        End If

        lProveedor.ID_PROVEE = -1
        lProveedor.NOMBRE = ""
        lista.Insertar(0, lProveedor)
        Me.cbxPROVEEDOR_VUELO.DataSource = lista
        Me.cbxPROVEEDOR_VUELO.DataBind()
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

        lista = (New cPRODUCTO).ObtenerListaPorCriterios(idProveedor, -1, idCuentaFinan, -1, 1, enConsigna, "NOMBRE_PRODUCTO")
        'lista = (New cPRODUCTO).ObtenerListaPorCriterios(-1, -1, idCuentaFinan, -1, 1, -1, "NOMBRE_PRODUCTO")
        If Not (lista IsNot Nothing AndAlso lista.Count > 0) Then
            lista = New listaPRODUCTO
        End If

        Me.cbxPRODUCTOdeta.DataSource = lista
        Me.cbxPRODUCTOdeta.DataBind()
        If Me.cbxPRODUCTOdeta.Items.FindByValue(idProducto) IsNot Nothing Then Me.cbxPRODUCTOdeta.Value = idProducto
    End Sub


    Private Sub CargarProveedorAgricola()
        Dim idProveedorSelecc As Int32
        Dim idCuentaFinan As Int32 = -2
        Dim lista As listaPROVEEDOR_AGRICOLA
        Dim bProveedorAgricola As New cPROVEEDOR_AGRICOLA

        If Me.cbxPROVEEDOR_AGRICOLAdeta.Value IsNot Nothing AndAlso Me.cbxPROVEEDOR_AGRICOLAdeta.Value > 0 Then idProveedorSelecc = CInt(Me.cbxPROVEEDOR_AGRICOLAdeta.Value)
        If Me.cbxTIPO_FINANCIAMIENTO.Value IsNot Nothing AndAlso Me.cbxTIPO_FINANCIAMIENTO.Value > 0 Then idCuentaFinan = CInt(Me.cbxTIPO_FINANCIAMIENTO.Value)
        lista = bProveedorAgricola.ObtenerListaPorTIPO_PROVEEDOR(-1, 1, idCuentaFinan, "NOMBRE")
        If Not (lista IsNot Nothing AndAlso lista.Count > 0) Then
            lista = New listaPROVEEDOR_AGRICOLA
        End If

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                If lista(i).APELLIDOS.Trim <> "" Then
                    lista(i).NOMBRE = lista(i).NOMBRE.Trim + " " + lista(i).APELLIDOS.Trim
                End If
            Next
        End If

        Me.cbxPROVEEDOR_AGRICOLAdeta.DataSource = lista
        Me.cbxPROVEEDOR_AGRICOLAdeta.DataBind()
        If Me.cbxPROVEEDOR_AGRICOLAdeta.Items.FindByValue(idProveedorSelecc) IsNot Nothing Then Me.cbxPROVEEDOR_AGRICOLAdeta.Value = idProveedorSelecc
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
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
        Me.GENERAR_ORDEN_COMPRA = False
        Me.txtNUM_SOLICITUD.Text = ""
        Me.txtCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtNIT.Text = ""
        Me.txtNRC.Text = ""
        Me.txtACTIVIDAD.Text = ""
        Me.cbxTIPO_FINANCIAMIENTO.Value = ""
        Me.speMZ_TOTALES.Value = Nothing
        Me.cbxPROVEEDOR_VUELO.Value = ""
        Me.dteFECHA_SOLIC.Date = cFechaHora.ObtenerFecha
        Me.txtPILOTO.Text = ""
        Me.cbxMEDIO_APLICA.Value = ""
        Me.cbxContrato.Text = ""
        Me.txtCCF_NOMBRE.Text = ""
        Me.txtLUGAR_ENTREGA.Text = ""
        Me.txtCONTACTO.Text = ""
        Me.txtDESCRIP_AERONAVE.Text = ""
        Me.chkAplicaAGUA.Checked = False
        Me.speRIEGO_PRECIO_UNIT.Value = 0
        Me.speRIEGO_MZ.Value = 0
        Me.speRIEGO_TOTAL.Value = 0
        Me.speAGUA_PRECIO_UNIT.Value = 0
        Me.speAGUA_MZ.Value = 0
        Me.speAGUA_TOTAL.Value = 0
        Me.speFOVIAL_COTRANS.Value = 0
        Me.cbxCONDICION_COMPRA.SelectedIndex = -1
        Me.LISTA_SOLIC_AGRICOLA_PRODUCTO = New listaSOLIC_AGRICOLA_PRODUCTO
        Me.LISTA_SOLIC_AGRICOLA_LOTE = New listaSOLIC_AGRICOLA_LOTE
        Dim lEntidad As New SOLIC_AGRICOLA_PRODUCTO
        lEntidad.ID_SOLIC_AGRI_PROD = 1
        lEntidad.ID_PRODUCTO = -1
        lEntidad.ID_SOLICITUD = 0
        lEntidad.CANT_X_MZ = 0
        lEntidad.PRECIO_UNITARIO = 0
        lEntidad.PRECIO_TOTAL = 0
        lEntidad.REFERENCIA = Me.lblREFERENCIA.Text
        lEntidad.ZAFRA = cbxZAFRA.Text
        Me.LISTA_SOLIC_AGRICOLA_LOTE = (New cSOLIC_AGRICOLA_LOTE).ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(0, "*", "*", cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario))
        If LISTA_SOLIC_AGRICOLA_LOTE IsNot Nothing AndAlso LISTA_SOLIC_AGRICOLA_LOTE.Count > 0 Then
            For Each lSolicLote As SOLIC_AGRICOLA_LOTE In Me.LISTA_SOLIC_AGRICOLA_LOTE
                Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lSolicLote.ACCESLOTE, Me.cbxZAFRA.Value)
                If lLoteCosecha IsNot Nothing Then
                    lSolicLote.MZ = lLoteCosecha.MZ_ENTREGAR
                    lSolicLote.TONEL_ESTI = lLoteCosecha.TONEL_ENTREGAR
                End If
            Next
        End If
        Me.CargarDetalleSolicAgricolaProducto()
        Me.CargarDetalleSolicAgricolaLotes()
        Me.SetearMZ()
        Me.SetearSubTotalIvaTotal()
        Me.chkSelectTodosLotes.ClientEnabled = True
        Me.chkSelectTodosLotes.Checked = False
        Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.ID_CUENTA_FINAN = 0
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim bSolicAgriLotes As New cSOLIC_AGRICOLA_LOTE
        Dim bSolicAgriProducto As New cSOLIC_AGRICOLA_PRODUCTO
        Dim bSolicAgriVuelo As New cSOLIC_AGRICOLA_VUELO
        Dim bContratoProvision As New cCONTRATO_CTAS_PROVI
        Dim bProveedor As New cPROVEEDOR
        Dim listaProducto As listaSOLIC_AGRICOLA_PRODUCTO
       
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim esProductoFerilizacionAerea As Boolean = False

        mEntidad = New SOLIC_AGRICOLA
        If Me._nuevo Then
            mEntidad.ID_SOLICITUD = 0
            mEntidad.NUM_SOLICITUD = 0
            mEntidad.UID_SOLIC_AGRICOLA = Guid.NewGuid
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFecha
            mEntidad.OBSERVACIONES = Nothing

            mEntidad.ESTADO = Enumeradores.EstadoSolicAgricola.Pendiente
            mEntidad.FECHA_APLICA = Nothing
        Else
            mEntidad = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(Me.ID_SOLICITUD)
        End If

        If ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados.Count = 0 Then
            Return "Seleccione algun lote"
        Else
            'Generando serie de números de contrato
            Dim listaLotes As listaSOLIC_AGRICOLA_LOTE = ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados
            Dim slistaNosContrato As New List(Of String)
            Dim sContratos As New StringBuilder

            For Each lEntidad As SOLIC_AGRICOLA_LOTE In listaLotes
                Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lEntidad.ACCESLOTE)
                If lLote IsNot Nothing Then
                    Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(lLote.CODICONTRATO)
                    If lContrato IsNot Nothing Then
                        If Not slistaNosContrato.Contains(lContrato.NO_CONTRATO.ToString) Then
                            slistaNosContrato.Add(lContrato.NO_CONTRATO.ToString)
                            sContratos.Append(lContrato.NO_CONTRATO.ToString)
                            sContratos.Append(",")
                        End If
                    End If
                End If
            Next
            mEntidad.CONTRATOS = Strings.Left(sContratos.ToString, sContratos.ToString.Length - 1)
        End If
        If Me.cbxTIPO_FINANCIAMIENTO.Value <> CuentaFinanciamiento.VuelosAereosInhibidores Then
            If Me.LISTA_SOLIC_AGRICOLA_PRODUCTO.Count = 0 OrElse _
           (Me.LISTA_SOLIC_AGRICOLA_PRODUCTO.Count = 1 AndAlso Me.LISTA_SOLIC_AGRICOLA_PRODUCTO(0).ID_PRODUCTO = -1) Then
                Return "Seleccione algun producto"
            End If
        End If
        listaProducto = Me.LISTA_SOLIC_AGRICOLA_PRODUCTO
        If Me.cbxCONDICION_COMPRA.Value = Enumeradores.CondicionCompra.Consignacion Then
            For i As Int32 = 0 To listaProducto.Count - 1
                If listaProducto(i).ID_PRODUCTO < 0 Then
                    Return "El producto " + listaProducto(i).NOMBRE_PRODUCTO + " debe eliminarse y seleccionarse del listado de productos consignados."
                End If
            Next
        End If

        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.CODIPROVEEDOR = Utilerias.FormatearCODIPROVEEDOR(Me.txtCODIPROVEE.Value)
        mEntidad.NOMBRE_PROVEEDOR = Me.txtNOMBRE_PROVEEDOR.Text.Trim
        mEntidad.ACTIVIDAD = Me.txtACTIVIDAD.Text.ToUpper.Trim
        mEntidad.FECHA_SOLIC = cFechaHora.ObtenerFecha
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
        mEntidad.DUI = lProveedor.DUI
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.NRC = Me.txtNRC.Text
        If Me.txtNRC.Text = Nothing Then
            mEntidad.TIPO_CONTRIBUYENTE = Enumeradores.TipoContribuyente.Contribuyente
        Else
            mEntidad.TIPO_CONTRIBUYENTE = lProveedor.TIPO_CONTRIBUYENTE
        End If
        mEntidad.ID_CUENTA_FINAN = cbxTIPO_FINANCIAMIENTO.Value
        mEntidad.ID_CATEGORIA = -1
        mEntidad.SUB_TOTAL = Me.speSUB_TOTAL.Value
        mEntidad.IVA = Me.speIVA.Value
        mEntidad.FOVIAL_COTRANS = Me.speFOVIAL_COTRANS.Value
        mEntidad.TOTAL = Me.speTOTAL.Value
        mEntidad.ZAFRA = Me.cbxZAFRA.Text
        mEntidad.CODICONTRATO = Me.cbxContrato.Value
        mEntidad.CONDI_COMPRA = Me.cbxCONDICION_COMPRA.Value

        'Obtener el técnico encargado
        Dim lLotesSolic As listaSOLIC_AGRICOLA_LOTE = ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados
        Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lLotesSolic(0).ACCESLOTE, Me.cbxZAFRA.Value)
        If lLoteCosecha IsNot Nothing Then
            mEntidad.CODIAGRON = lLoteCosecha.CODIAGRON
        End If

        If mComponente.ActualizarSOLIC_AGRICOLA(mEntidad) <= -1 Then
            Return "Error al Guardar registro." + mComponente.sError
        End If

        'Actualizar actividad del proveedor
        If lProveedor IsNot Nothing Then
            lProveedor.ACTIVIDAD = Me.txtACTIVIDAD.Text.Trim.ToUpper
            bProveedor.ActualizarPROVEEDOR(lProveedor)
        End If

        '*************************************
        'Lotes en Solicitud: Creación Registro 
        '*************************************
        Dim lSolicAgriLote As SOLIC_AGRICOLA_LOTE
        For Each lEntidad As SOLIC_AGRICOLA_LOTE In ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados
            If Me._nuevo Then
                lSolicAgriLote = New SOLIC_AGRICOLA_LOTE
                lSolicAgriLote.ID_SOLIC_AGRI_LOTE = 0
                lSolicAgriLote.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                lSolicAgriLote.ID_ZAFRA = mEntidad.ID_ZAFRA
                lSolicAgriLote.ACCESLOTE = lEntidad.ACCESLOTE
                lSolicAgriLote.MZ = lEntidad.MZ
                lSolicAgriLote.TONEL_ESTI = lEntidad.TONEL_ESTI
                lSolicAgriLote.RIEGO_APLICADO = False
                lSolicAgriLote.USUARIO_CREA = Me.ObtenerUsuario
                lSolicAgriLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lSolicAgriLote.USUARIO_ACT = Me.ObtenerUsuario
                lSolicAgriLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lSolicAgriLote.ZAFRA = Me.cbxZAFRA.Text
                lSolicAgriLote.CODIVARIEDA = lEntidad.CODIVARIEDA
                bSolicAgriLotes.ActualizarSOLIC_AGRICOLA_LOTE(lSolicAgriLote)
            ElseIf mEntidad.ESTADO = Enumeradores.EstadoSolicAgricola.Aceptada Then
                lSolicAgriLote = (New cSOLIC_AGRICOLA_LOTE).ObtenerSOLIC_AGRICOLA_LOTE(lEntidad.ID_SOLIC_AGRI_LOTE)
                lSolicAgriLote.RIEGO_APLICADO = True
                lSolicAgriLote.USUARIO_ACT = Me.ObtenerUsuario
                lSolicAgriLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bSolicAgriLotes.ActualizarSOLIC_AGRICOLA_LOTE(lSolicAgriLote)
            End If
        Next

        '*************************************
        'Productos 
        '*************************************
        Dim lSolicAgriProducto As SOLIC_AGRICOLA_PRODUCTO
        If Me.LISTA_SOLIC_AGRICOLA_PRODUCTO IsNot Nothing AndAlso Me.LISTA_SOLIC_AGRICOLA_PRODUCTO.Count > 0 Then
            For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO In Me.LISTA_SOLIC_AGRICOLA_PRODUCTO
                If (New cPRODUCTO).ObtenerPRODUCTO(lEntidad.ID_PRODUCTO).NOMBRE_PRODUCTO.Trim.ToUpper = "FERTILIZACION GRANULADA AEREA" Then
                    esProductoFerilizacionAerea = True
                End If
                If Me._nuevo Then
                    lSolicAgriProducto = lEntidad
                    lSolicAgriProducto.ID_SOLIC_AGRI_PROD = 0
                    lSolicAgriProducto.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                    lSolicAgriProducto.ID_PROVEE_ADJU = -1
                    bSolicAgriProducto.ActualizarSOLIC_AGRICOLA_PRODUCTO(lSolicAgriProducto)
                ElseIf mEntidad.ESTADO = Enumeradores.EstadoSolicAgricola.Aceptada Then
                    lSolicAgriProducto = (New cSOLIC_AGRICOLA_PRODUCTO).ObtenerSOLIC_AGRICOLA_PRODUCTO(lEntidad.ID_SOLIC_AGRI_PROD)
                    lSolicAgriProducto.CANT_X_MZ = lEntidad.CANT_X_MZ
                    lSolicAgriProducto.TOTAL_PRODUCTO = lEntidad.TOTAL_PRODUCTO
                    lSolicAgriProducto.PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO
                    lSolicAgriProducto.PRECIO_TOTAL = lEntidad.PRECIO_TOTAL
                    lSolicAgriProducto.PRESENTACION = lEntidad.PRESENTACION
                    lSolicAgriProducto.UNIDAD = lEntidad.UNIDAD
                    lSolicAgriProducto.USUARIO_ACT = Me.ObtenerUsuario
                    lSolicAgriProducto.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bSolicAgriProducto.ActualizarSOLIC_AGRICOLA_PRODUCTO(lSolicAgriProducto)
                End If
            Next
        End If

        '*************************************
        'Vuelo 
        '*************************************
        Dim lSolicVuelo As SOLIC_AGRICOLA_VUELO
        If Me._nuevo Then
            If Me.speRIEGO_PRECIO_UNIT.Value > 0 OrElse esProductoFerilizacionAerea Then
                lSolicVuelo = New SOLIC_AGRICOLA_VUELO
                lSolicVuelo.ID_SOLIC_AGRI_VUELO = 0
                lSolicVuelo.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                lSolicVuelo.ID_PROVEE = IIf(Me.cbxPROVEEDOR_VUELO.Value = Nothing, -1, Me.cbxPROVEEDOR_VUELO.Value)
                lSolicVuelo.MEDIO_APLICA = Me.cbxMEDIO_APLICA.Value
                lSolicVuelo.DESCRIP_AERONAVE = IIf(Me.txtDESCRIP_AERONAVE.Text.ToUpper.Trim = "", Nothing, Me.txtDESCRIP_AERONAVE.Text.ToUpper.Trim)
                lSolicVuelo.NOMBRE_PILOTO = IIf(Me.txtPILOTO.Text.ToUpper.Trim = "", Nothing, Me.txtPILOTO.Text.ToUpper.Trim)

                lSolicVuelo.PRECIO_UNIT_VUELO = Me.speRIEGO_PRECIO_UNIT.Value
                lSolicVuelo.MZ_HORAS_VUELO = Me.speRIEGO_MZ.Value
                lSolicVuelo.CARGO_VUELO = 0
                lSolicVuelo.PRECIO_TOTAL_VUELO = Me.speRIEGO_TOTAL.Value

                lSolicVuelo.PRECIO_UNIT_AGUA = Me.speAGUA_PRECIO_UNIT.Value
                lSolicVuelo.MZ_REGAR_AGUA = Me.speAGUA_MZ.Value
                lSolicVuelo.PRECIO_TOTAL_AGUA = Me.speAGUA_TOTAL.Value

                lSolicVuelo.USUARIO_CREA = Me.ObtenerUsuario
                lSolicVuelo.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lSolicVuelo.USUARIO_ACT = Me.ObtenerUsuario
                lSolicVuelo.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lSolicVuelo.ZAFRA = Me.cbxZAFRA.Text
                lSolicVuelo.UID_SOLIC_AGRI_VUELO = Guid.NewGuid
                bSolicAgriVuelo.ActualizarSOLIC_AGRICOLA_VUELO(lSolicVuelo)
            End If
        ElseIf mEntidad.ESTADO = Enumeradores.EstadoSolicAgricola.Aceptada Then
            Dim listaSolicVuelo As listaSOLIC_AGRICOLA_VUELO = (New cSOLIC_AGRICOLA_VUELO).ObtenerListaPorSOLIC_AGRICOLA(mEntidad.ID_SOLICITUD)
            If listaSolicVuelo IsNot Nothing AndAlso listaSolicVuelo.Count > 0 Then
                lSolicVuelo = listaSolicVuelo(0)
                lSolicVuelo.ID_PROVEE = Me.cbxPROVEEDOR_VUELO.Value
                lSolicVuelo.MEDIO_APLICA = Me.cbxMEDIO_APLICA.Value
                lSolicVuelo.DESCRIP_AERONAVE = Me.txtDESCRIP_AERONAVE.Text.ToUpper.Trim
                lSolicVuelo.NOMBRE_PILOTO = Me.txtPILOTO.Text.ToUpper.Trim

                lSolicVuelo.PRECIO_UNIT_VUELO = Me.speRIEGO_PRECIO_UNIT.Value
                lSolicVuelo.MZ_HORAS_VUELO = Me.speRIEGO_MZ.Value
                lSolicVuelo.CARGO_VUELO = 0
                lSolicVuelo.PRECIO_TOTAL_VUELO = Me.speRIEGO_TOTAL.Value

                lSolicVuelo.PRECIO_UNIT_AGUA = Me.speAGUA_PRECIO_UNIT.Value
                lSolicVuelo.MZ_REGAR_AGUA = Me.speAGUA_MZ.Value
                lSolicVuelo.PRECIO_TOTAL_AGUA = Me.speAGUA_TOTAL.Value

                lSolicVuelo.USUARIO_ACT = Me.ObtenerUsuario
                lSolicVuelo.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bSolicAgriVuelo.ActualizarSOLIC_AGRICOLA_VUELO(lSolicVuelo)
            End If
        End If

        If Me.cbxCONDICION_COMPRA.Value = 1 Then 'Si es Credito mostrar análisis, de lo contrario no 08-07-2023
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarAnalisisFinanciero(1," + mEntidad.ID_SOLICITUD.ToString + ");" + "MostrarSolicAgricolaMadurante(" + mEntidad.ID_SOLICITUD.ToString + ")", True)
        Else
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarSolicAgricolaMadurante(" + mEntidad.ID_SOLICITUD.ToString + ")", True)
        End If

        Me.txtID_SOLICITUD.Text = mEntidad.ID_SOLICITUD.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function


    Public Function GenerarOrdenCompra() As String
        Dim bSolicAgriProducto As New cSOLIC_AGRICOLA_PRODUCTO
        Dim bOrdenCompra As New cORDEN_COMPRA_AGRI
        Dim listaSoliProductos As listaSOLIC_AGRICOLA_PRODUCTO = Me.LISTA_SOLIC_AGRICOLA_PRODUCTO
        Dim tieneAdj As Boolean = False

        If listaSoliProductos IsNot Nothing AndAlso listaSoliProductos.Count > 0 Then
            For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO In listaSoliProductos
                If lEntidad.CANT_ADJU > 0 Then
                    Dim lSoliProd As SOLIC_AGRICOLA_PRODUCTO = bSolicAgriProducto.ObtenerSOLIC_AGRICOLA_PRODUCTO(lEntidad.ID_SOLIC_AGRI_PROD)
                    If lSoliProd IsNot Nothing Then
                        lSoliProd.ID_PROVEE_ADJU = lEntidad.ID_PROVEE_ADJU
                        lSoliProd.CANT_ADJU = lEntidad.CANT_ADJU
                        lSoliProd.PRECIO_ADJU = lEntidad.PRECIO_ADJU
                        lSoliProd.TOTAL_ADJU = lEntidad.TOTAL_ADJU

                        bSolicAgriProducto.ActualizarSOLIC_AGRICOLA_PRODUCTO(lSoliProd)
                        tieneAdj = True
                    End If
                End If
            Next
        End If

        If Not tieneAdj Then
            Return "Ingrese las cantidades y montos de los productos que han sido adjudicados"
        End If

        'Generar Orden Compra
        bOrdenCompra.PROC_GenerarORDEN_COMPRA_AGRICOLA(Me.ID_SOLICITUD, cFechaHora.ObtenerFecha, _
                                                       Me.txtCCF_NOMBRE.Text.Trim.ToUpper, Me.txtLUGAR_ENTREGA.Text.Trim.ToUpper, Me.txtCONTACTO.Text.Trim.ToUpper, Me.ObtenerUsuario)

        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarOrdenCompraPorSolicitud(" + ID_SOLICITUD.ToString + ")", True)
        Return ""
    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function AplicarProducto() As String
        Dim bSolicAplicaLotes As New cSOLIC_APLICA_LOTE
        Dim bSolicAplicacionLotes As New cSOLIC_APLICACION_LOTE
        Dim bSolicAplicacionProducto As New cSOLIC_APLICACION_PRODUCTO
        Dim bSolicAplicacionVuelo As New cSOLIC_APLICACION_VUELO
        Dim bLotesCosecha As New cLOTES_COSECHA
        Dim lRet As Int32 = 0
        Dim sError As New StringBuilder
        Dim alDatos As New ArrayList
        Dim UID_REF As Guid = Guid.NewGuid
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim fechaInicialAplicacion As Date

        mEntidad = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(Me.ID_SOLICITUD)

        If ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados.Count = 0 Then
            Return "* Seleccione algun lote"
        End If
        If speRIEGO_MZ.Value Is Nothing OrElse speRIEGO_MZ.Value <= 0 Then
            Return "* Las hectareas sobre las que se aplico el producto no puede ser cero"
        End If
        If Me.cbxTIPO_FINANCIAMIENTO.Value <> CuentaFinanciamiento.VuelosAereosInhibidores Then
            If Me.LISTA_SOLIC_AGRICOLA_PRODUCTO.Count = 0 OrElse _
            (Me.LISTA_SOLIC_AGRICOLA_PRODUCTO.Count = 1 AndAlso Me.LISTA_SOLIC_AGRICOLA_PRODUCTO(0).ID_PRODUCTO = -1) Then
                Return "* Seleccione algun producto"
            End If
        End If

        If Me.dteFECHA_APLICACION.Value Is Nothing Then
            Return "* Ingrese la fecha de aplicacion del producto"
        End If
        If mEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes Then
            fechaInicialAplicacion = New DateTime(lZafra.FECHA_INICIO.Year, 9, 1)
            If (Me.dteFECHA_APLICACION.Date < fechaInicialAplicacion OrElse Me.dteFECHA_APLICACION.Date > lZafra.FECHA_FINAL) Then
                Return "* La fecha de aplicacion del producto debe estar comprendida en el periodo del " + fechaInicialAplicacion.ToString("dd/MM/yyyy") + " al " +
                    lZafra.FECHA_FINAL.ToString("dd/MM/yyyy")
            End If
        End If

        'TODO: Deshabilitacion temporal
        'If Me.dteFECHA_APLICACION.Date < mEntidad.FECHA_SOLIC Then
        '    Return "* La fecha de aplicacion no puede ser menor a la fecha de la solicitud"
        'End If

        '*************************************
        'Lotes aplicados en Solicitud: CreaciÃ³n 
        '*************************************
        Dim lSolicAplicacionLote As SOLIC_APLICACION_LOTE
        For Each lEntidad As SOLIC_AGRICOLA_LOTE In ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados
            lSolicAplicacionLote = New SOLIC_APLICACION_LOTE
            lSolicAplicacionLote.ID_SOLIC_APLICACION_LOTE = 0
            lSolicAplicacionLote.ID_SOLICITUD = mEntidad.ID_SOLICITUD
            lSolicAplicacionLote.ID_ZAFRA = mEntidad.ID_ZAFRA
            lSolicAplicacionLote.ACCESLOTE = lEntidad.ACCESLOTE
            lSolicAplicacionLote.MZ = lEntidad.MZ
            lSolicAplicacionLote.TONEL_ESTI = lEntidad.TONEL_ESTI
            lSolicAplicacionLote.RIEGO_APLICADO = False
            lSolicAplicacionLote.USUARIO_CREA = Me.ObtenerUsuario
            lSolicAplicacionLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lSolicAplicacionLote.USUARIO_ACT = Me.ObtenerUsuario
            lSolicAplicacionLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
            lSolicAplicacionLote.ZAFRA = Me.cbxZAFRA.Text
            lSolicAplicacionLote.UID_REFERENCIA = UID_REF
            bSolicAplicacionLotes.ActualizarSOLIC_APLICACION_LOTE(lSolicAplicacionLote)
        Next

        '*************************************
        'Productos 
        '*************************************
        Dim lSolicAplicacionProducto As SOLIC_APLICACION_PRODUCTO
        For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO In Me.LISTA_SOLIC_AGRICOLA_PRODUCTO
            lSolicAplicacionProducto = New SOLIC_APLICACION_PRODUCTO
            lSolicAplicacionProducto.ID_SOLIC_APLICACION_PROD = 0
            lSolicAplicacionProducto.ID_SOLICITUD = mEntidad.ID_SOLICITUD
            lSolicAplicacionProducto.ID_PRODUCTO = lEntidad.ID_PRODUCTO
            lSolicAplicacionProducto.CANT_X_MZ = lEntidad.CANT_X_MZ
            lSolicAplicacionProducto.TOTAL_PRODUCTO = lEntidad.TOTAL_PRODUCTO
            lSolicAplicacionProducto.PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO
            lSolicAplicacionProducto.PRECIO_TOTAL = lEntidad.PRECIO_TOTAL
            lSolicAplicacionProducto.USUARIO_CREA = Me.ObtenerUsuario
            lSolicAplicacionProducto.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lSolicAplicacionProducto.USUARIO_ACT = Me.ObtenerUsuario
            lSolicAplicacionProducto.FECHA_ACT = cFechaHora.ObtenerFechaHora
            lSolicAplicacionProducto.ZAFRA = Me.cbxZAFRA.Text
            lSolicAplicacionProducto.UID_SOLIC_AGRI_PROD = Guid.NewGuid
            lSolicAplicacionProducto.UID_REFERENCIA = UID_REF
            bSolicAplicacionProducto.ActualizarSOLIC_APLICACION_PRODUCTO(lSolicAplicacionProducto)

            Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(lEntidad.ID_PRODUCTO)
            If lProducto IsNot Nothing Then
                If lProducto.VENTSEMA_INI > 0 Then
                    'Es madurante
                    Dim lLotesSolic As listaSOLIC_AGRICOLA_LOTE = ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados

                    For Each lLoteSolic As SOLIC_AGRICOLA_LOTE In lLotesSolic
                        Dim lLoteCosecha As LOTES_COSECHA = bLotesCosecha.ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lLoteSolic.ACCESLOTE, Me.cbxZAFRA.Value)
                        Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lLoteSolic.ACCESLOTE)
                        Dim lSolicAplicaLote As New SOLIC_APLICA_LOTE

                        lSolicAplicaLote.ID_SOLIC_APLICA_LOTE = 0
                        If lLoteCosecha IsNot Nothing Then
                            lSolicAplicaLote.ID_LOTES_COSECHA = lLoteCosecha.ID_LOTES_COSECHA
                        End If
                        lSolicAplicaLote.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                        lSolicAplicaLote.ID_ZAFRA = mEntidad.ID_ZAFRA
                        lSolicAplicaLote.ACCESLOTE = lLoteSolic.ACCESLOTE
                        lSolicAplicaLote.MZ = lLoteSolic.MZ
                        lSolicAplicaLote.FECHA_APLICA = Me.dteFECHA_APLICACION.Date
                        lSolicAplicaLote.ID_PRODUCTO = lProducto.ID_PRODUCTO
                        lSolicAplicaLote.CANT_X_MZ = lSolicAplicacionProducto.CANT_X_MZ
                        lSolicAplicaLote.TOTAL_PRODUCTO = lSolicAplicacionProducto.TOTAL_PRODUCTO
                        lSolicAplicaLote.USUARIO_CREA = Me.ObtenerUsuario
                        lSolicAplicaLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lSolicAplicaLote.USUARIO_ACT = Me.ObtenerUsuario
                        lSolicAplicaLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                        lSolicAplicaLote.ZAFRA = Me.cbxZAFRA.Text
                        lSolicAplicaLote.ID_MAESTRO = lLote.ID_MAESTRO
                        lSolicAplicaLote.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
                        lSolicAplicaLote.FECHA_INI_VENTANA = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1, Me.dteFECHA_APLICACION.Date)
                        lSolicAplicaLote.FECHA_FIN_VENTANA = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1 + ((lProducto.VENTSEMA_FIN - lProducto.VENTSEMA_INI + 1) * 7), Me.dteFECHA_APLICACION.Date)
                        lSolicAplicaLote.FECHA_ROZA_MADURANTE = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1 + _
                                                                   Math.Round(Convert.ToDecimal((lProducto.VENTSEMA_FIN - lProducto.VENTSEMA_INI + 1) * 7) / Convert.ToDecimal(2), 0), Me.dteFECHA_APLICACION.Date)
                        lSolicAplicaLote.TONELADAS = lLoteSolic.TONEL_ESTI
                        lSolicAplicaLote.UID_REFERENCIA = UID_REF
                        lRet = bSolicAplicaLotes.ActualizarSOLIC_APLICA_LOTE(lSolicAplicaLote)
                        If lRet < 0 Then
                            sError.AppendLine("* No se registro la aplicacion del producto para el lote: " + lLote.CODILOTE + " " + lLote.NOMBLOTE)
                        End If

                        If lLoteCosecha IsNot Nothing Then
                            If mEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes AndAlso lSolicAplicaLote.FECHA_ROZA_MADURANTE <> lLoteCosecha.FECHA_ROZA Then
                                lLoteCosecha.FECHA_ROZA = lSolicAplicaLote.FECHA_ROZA_MADURANTE
                                lLoteCosecha.USUARIO_ACT = Me.ObtenerUsuario
                                lLoteCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                lRet = bLotesCosecha.ActualizarLOTES_COSECHA(lLoteCosecha)
                                If lRet < 0 Then
                                    sError.AppendLine("* No se actualizo la fecha de roza de madurante para el lote: " + lLote.CODILOTE + " " + lLote.NOMBLOTE)
                                End If
                            End If
                        End If
                    Next
                End If
            End If
        Next
        '*************************************
        'Vuelo 
        '*************************************
        Dim lSolicAplicacionVuelo As SOLIC_APLICACION_VUELO
        If speRIEGO_MZ.Value > 0 AndAlso speRIEGO_PRECIO_UNIT.Value > 0 Then
            lSolicAplicacionVuelo = New SOLIC_APLICACION_VUELO
            lSolicAplicacionVuelo.ID_SOLIC_APLICACION_VUELO = 0
            lSolicAplicacionVuelo.ID_SOLICITUD = mEntidad.ID_SOLICITUD
            lSolicAplicacionVuelo.ID_PROVEE = IIf(Me.cbxPROVEEDOR_VUELO.Value = Nothing, -1, Me.cbxPROVEEDOR_VUELO.Value)
            lSolicAplicacionVuelo.MEDIO_APLICA = Me.cbxMEDIO_APLICA.Value
            lSolicAplicacionVuelo.DESCRIP_AERONAVE = IIf(Me.txtDESCRIP_AERONAVE.Text.ToUpper.Trim = "", Nothing, Me.txtDESCRIP_AERONAVE.Text.ToUpper.Trim)
            lSolicAplicacionVuelo.NOMBRE_PILOTO = IIf(Me.txtPILOTO.Text.ToUpper.Trim = "", Nothing, Me.txtPILOTO.Text.ToUpper.Trim)

            lSolicAplicacionVuelo.PRECIO_UNIT_VUELO = Me.speRIEGO_PRECIO_UNIT.Value
            lSolicAplicacionVuelo.MZ_HORAS_VUELO = Me.speRIEGO_MZ.Value
            lSolicAplicacionVuelo.CARGO_VUELO = 0
            lSolicAplicacionVuelo.PRECIO_TOTAL_VUELO = Me.speRIEGO_TOTAL.Value

            lSolicAplicacionVuelo.PRECIO_UNIT_AGUA = Me.speAGUA_PRECIO_UNIT.Value
            lSolicAplicacionVuelo.MZ_REGAR_AGUA = Me.speAGUA_MZ.Value
            lSolicAplicacionVuelo.PRECIO_TOTAL_AGUA = Me.speAGUA_TOTAL.Value

            lSolicAplicacionVuelo.USUARIO_CREA = Me.ObtenerUsuario
            lSolicAplicacionVuelo.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lSolicAplicacionVuelo.USUARIO_ACT = Me.ObtenerUsuario
            lSolicAplicacionVuelo.FECHA_ACT = cFechaHora.ObtenerFechaHora
            lSolicAplicacionVuelo.ZAFRA = Me.cbxZAFRA.Text
            lSolicAplicacionVuelo.UID_SOLIC_AGRI_VUELO = Guid.NewGuid
            lSolicAplicacionVuelo.UID_REFERENCIA = UID_REF
            bSolicAplicacionVuelo.ActualizarSOLIC_APLICACION_VUELO(lSolicAplicacionVuelo)
        End If

        '************* Actualizar fecha de aplicación en Solicitud *************
        mEntidad.FECHA_APLICA = Me.dteFECHA_APLICACION.Date
        mComponente.ActualizarSOLIC_AGRICOLA(mEntidad)
        '***********************************************************************

        If sError.ToString <> "" Then
            Return sError.ToString
        End If

        Me.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    ' **** Para una aplicación
    'Public Function AplicarProducto() As String
    '    Dim bSolicAplicaLotes As New cSOLIC_APLICA_LOTE
    '    Dim bSolicAplicacionLotes As New cSOLIC_APLICACION_LOTE
    '    Dim bSolicAplicacionProducto As New cSOLIC_APLICACION_PRODUCTO
    '    Dim bSolicAplicacionVuelo As New cSOLIC_APLICACION_VUELO
    '    Dim bLotesCosecha As New cLOTES_COSECHA
    '    Dim lRet As Int32 = 0
    '    Dim sError As New StringBuilder
    '    Dim alDatos As New ArrayList

    '    Dim lSolicAplicacionProducto As SOLIC_APLICACION_PRODUCTO
    '    Dim lstAplicacionAnterior As listaSOLIC_APLICA_LOTE
    '    Dim lstAplicacionLoteAnterior As listaSOLIC_APLICACION_LOTE
    '    Dim lstAplicacionProducto As listaSOLIC_APLICACION_PRODUCTO
    '    Dim lstAplicacionVuelo As listaSOLIC_APLICACION_VUELO

    '    mEntidad = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(Me.ID_SOLICITUD)

    '    If ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados.Count = 0 Then
    '        Return "* Seleccione algun lote"
    '    End If
    '    If speRIEGO_MZ.Value Is Nothing OrElse speRIEGO_MZ.Value <= 0 Then
    '        Return "* Las Manzanas sobre las que se aplico el producto no puede ser cero"
    '    End If
    '    If Me.cbxTIPO_FINANCIAMIENTO.Value <> CuentaFinanciamiento.VuelosAereosInhibidores Then
    '        If Me.LISTA_SOLIC_AGRICOLA_PRODUCTO.Count = 0 OrElse _
    '        (Me.LISTA_SOLIC_AGRICOLA_PRODUCTO.Count = 1 AndAlso Me.LISTA_SOLIC_AGRICOLA_PRODUCTO(0).ID_PRODUCTO = -1) Then
    '            Return "* Seleccione algun producto"
    '        End If
    '    End If

    '    If Me.dteFECHA_APLICACION.Value Is Nothing Then
    '        Return "* Ingrese la fecha de aplicacion del producto"
    '    End If

    '    'Eliminar aplicaciones anteriores
    '    lstAplicacionAnterior = (New cSOLIC_APLICA_LOTE).ObtenerListaPorSOLIC_AGRICOLA(Me.ID_SOLICITUD)
    '    lstAplicacionLoteAnterior = (New cSOLIC_APLICACION_LOTE).ObtenerListaPorSOLIC_AGRICOLA(Me.ID_SOLICITUD)
    '    lstAplicacionProducto = (New cSOLIC_APLICACION_PRODUCTO).ObtenerListaPorSOLIC_AGRICOLA(Me.ID_SOLICITUD)
    '    lstAplicacionVuelo = (New cSOLIC_APLICACION_VUELO).ObtenerListaPorSOLIC_AGRICOLA(Me.ID_SOLICITUD)

    '    For Each lEntidadAplica As SOLIC_APLICA_LOTE In lstAplicacionAnterior
    '        bSolicAplicaLotes.EliminarSOLIC_APLICA_LOTE(lEntidadAplica.ID_SOLIC_APLICA_LOTE)
    '    Next
    '    For Each lEntidadAplica As SOLIC_APLICACION_LOTE In lstAplicacionLoteAnterior
    '        bSolicAplicacionLotes.EliminarSOLIC_APLICACION_LOTE(lEntidadAplica.ID_SOLIC_APLICACION_LOTE)
    '    Next
    '    For Each lEntidadAplica As SOLIC_APLICACION_PRODUCTO In lstAplicacionProducto
    '        bSolicAplicacionProducto.EliminarSOLIC_APLICACION_PRODUCTO(lEntidadAplica.ID_SOLIC_APLICACION_PROD)
    '    Next
    '    For Each lEntidadAplica As SOLIC_APLICACION_VUELO In lstAplicacionVuelo
    '        bSolicAplicacionVuelo.EliminarSOLIC_APLICACION_VUELO(lEntidadAplica.ID_SOLIC_APLICACION_VUELO)
    '    Next

    '    'TODO: Deshabilitacion temporal
    '    'If Me.dteFECHA_APLICACION.Date < mEntidad.FECHA_SOLIC Then
    '    '    Return "* La fecha de aplicacion no puede ser menor a la fecha de la solicitud"
    '    'End If        

    '    '*************************************
    '    'Lotes aplicados en Solicitud: CreaciÃ³n 
    '    '*************************************
    '    Dim lSolicAplicacionLote As SOLIC_APLICACION_LOTE
    '    For Each lEntidad As SOLIC_AGRICOLA_LOTE In ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados
    '        lSolicAplicacionLote = New SOLIC_APLICACION_LOTE
    '        lSolicAplicacionLote.ID_SOLIC_APLICACION_LOTE = 0
    '        lSolicAplicacionLote.ID_SOLICITUD = mEntidad.ID_SOLICITUD
    '        lSolicAplicacionLote.ID_ZAFRA = mEntidad.ID_ZAFRA
    '        lSolicAplicacionLote.ACCESLOTE = lEntidad.ACCESLOTE
    '        lSolicAplicacionLote.MZ = lEntidad.MZ
    '        lSolicAplicacionLote.TONEL_ESTI = lEntidad.TONEL_ESTI
    '        lSolicAplicacionLote.RIEGO_APLICADO = False
    '        lSolicAplicacionLote.USUARIO_CREA = Me.ObtenerUsuario
    '        lSolicAplicacionLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
    '        lSolicAplicacionLote.USUARIO_ACT = Me.ObtenerUsuario
    '        lSolicAplicacionLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
    '        lSolicAplicacionLote.ZAFRA = Me.cbxZAFRA.Text
    '        bSolicAplicacionLotes.ActualizarSOLIC_APLICACION_LOTE(lSolicAplicacionLote)
    '    Next
    '    '*************************************
    '    'Productos 
    '    '*************************************
    '    For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO In Me.LISTA_SOLIC_AGRICOLA_PRODUCTO
    '        lSolicAplicacionProducto = New SOLIC_APLICACION_PRODUCTO
    '        lSolicAplicacionProducto.ID_SOLIC_APLICACION_PROD = 0
    '        lSolicAplicacionProducto.ID_SOLICITUD = mEntidad.ID_SOLICITUD
    '        lSolicAplicacionProducto.ID_PRODUCTO = lEntidad.ID_PRODUCTO
    '        lSolicAplicacionProducto.CANT_X_MZ = lEntidad.CANT_X_MZ
    '        lSolicAplicacionProducto.TOTAL_PRODUCTO = lEntidad.TOTAL_PRODUCTO
    '        lSolicAplicacionProducto.PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO
    '        lSolicAplicacionProducto.PRECIO_TOTAL = lEntidad.PRECIO_TOTAL
    '        lSolicAplicacionProducto.USUARIO_CREA = Me.ObtenerUsuario
    '        lSolicAplicacionProducto.FECHA_CREA = cFechaHora.ObtenerFechaHora
    '        lSolicAplicacionProducto.USUARIO_ACT = Me.ObtenerUsuario
    '        lSolicAplicacionProducto.FECHA_ACT = cFechaHora.ObtenerFechaHora
    '        lSolicAplicacionProducto.ZAFRA = Me.cbxZAFRA.Text
    '        lSolicAplicacionProducto.UID_SOLIC_AGRI_PROD = Guid.NewGuid
    '        bSolicAplicacionProducto.ActualizarSOLIC_APLICACION_PRODUCTO(lSolicAplicacionProducto)
    '    Next
    '    '*************************************
    '    'Vuelo 
    '    '*************************************
    '    Dim lSolicAplicacionVuelo As SOLIC_APLICACION_VUELO
    '    If speRIEGO_MZ.Value > 0 AndAlso speRIEGO_PRECIO_UNIT.Value > 0 Then
    '        lSolicAplicacionVuelo = New SOLIC_APLICACION_VUELO
    '        lSolicAplicacionVuelo.ID_SOLIC_APLICACION_VUELO = 0
    '        lSolicAplicacionVuelo.ID_SOLICITUD = mEntidad.ID_SOLICITUD
    '        lSolicAplicacionVuelo.ID_PROVEE = IIf(Me.cbxPROVEEDOR_VUELO.Value = Nothing, -1, Me.cbxPROVEEDOR_VUELO.Value)
    '        lSolicAplicacionVuelo.MEDIO_APLICA = Me.cbxMEDIO_APLICA.Value
    '        lSolicAplicacionVuelo.DESCRIP_AERONAVE = IIf(Me.txtDESCRIP_AERONAVE.Text.ToUpper.Trim = "", Nothing, Me.txtDESCRIP_AERONAVE.Text.ToUpper.Trim)
    '        lSolicAplicacionVuelo.NOMBRE_PILOTO = IIf(Me.txtPILOTO.Text.ToUpper.Trim = "", Nothing, Me.txtPILOTO.Text.ToUpper.Trim)

    '        lSolicAplicacionVuelo.PRECIO_UNIT_VUELO = Me.speRIEGO_PRECIO_UNIT.Value
    '        lSolicAplicacionVuelo.MZ_HORAS_VUELO = Me.speRIEGO_MZ.Value
    '        lSolicAplicacionVuelo.CARGO_VUELO = 0
    '        lSolicAplicacionVuelo.PRECIO_TOTAL_VUELO = Me.speRIEGO_TOTAL.Value

    '        lSolicAplicacionVuelo.PRECIO_UNIT_AGUA = Me.speAGUA_PRECIO_UNIT.Value
    '        lSolicAplicacionVuelo.MZ_REGAR_AGUA = Me.speAGUA_MZ.Value
    '        lSolicAplicacionVuelo.PRECIO_TOTAL_AGUA = Me.speAGUA_TOTAL.Value

    '        lSolicAplicacionVuelo.USUARIO_CREA = Me.ObtenerUsuario
    '        lSolicAplicacionVuelo.FECHA_CREA = cFechaHora.ObtenerFechaHora
    '        lSolicAplicacionVuelo.USUARIO_ACT = Me.ObtenerUsuario
    '        lSolicAplicacionVuelo.FECHA_ACT = cFechaHora.ObtenerFechaHora
    '        lSolicAplicacionVuelo.ZAFRA = Me.cbxZAFRA.Text
    '        lSolicAplicacionVuelo.UID_SOLIC_AGRI_VUELO = Guid.NewGuid
    '        bSolicAplicacionVuelo.ActualizarSOLIC_APLICACION_VUELO(lSolicAplicacionVuelo)
    '    End If

    '    'Registrar aplicación de madurantes
    '    For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO In Me.LISTA_SOLIC_AGRICOLA_PRODUCTO
    '        Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(lEntidad.ID_PRODUCTO)
    '        If lProducto IsNot Nothing Then
    '            If lProducto.VENTSEMA_INI > -1 Then
    '                'Es madurante
    '                Dim lLotesSolic As listaSOLIC_AGRICOLA_LOTE = ucListaSOLIC_AGRICOLA_LOTE1.DevolverSeleccionados

    '                For Each lLoteSolic As SOLIC_AGRICOLA_LOTE In lLotesSolic
    '                    Dim lLoteCosecha As LOTES_COSECHA = bLotesCosecha.ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lLoteSolic.ACCESLOTE, Me.cbxZAFRA.Value)
    '                    Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lLoteSolic.ACCESLOTE)
    '                    Dim lSolicAplicaLote As New SOLIC_APLICA_LOTE

    '                    lSolicAplicaLote.ID_SOLIC_APLICA_LOTE = 0
    '                    If lLoteCosecha IsNot Nothing Then
    '                        lSolicAplicaLote.ID_LOTES_COSECHA = lLoteCosecha.ID_LOTES_COSECHA
    '                    End If
    '                    lSolicAplicaLote.ID_SOLICITUD = mEntidad.ID_SOLICITUD
    '                    lSolicAplicaLote.ID_ZAFRA = mEntidad.ID_ZAFRA
    '                    lSolicAplicaLote.ACCESLOTE = lLoteSolic.ACCESLOTE
    '                    lSolicAplicaLote.MZ = lLoteSolic.MZ
    '                    lSolicAplicaLote.FECHA_APLICA = Me.dteFECHA_APLICACION.Date
    '                    lSolicAplicaLote.ID_PRODUCTO = lProducto.ID_PRODUCTO
    '                    lSolicAplicaLote.CANT_X_MZ = lEntidad.CANT_X_MZ
    '                    lSolicAplicaLote.TOTAL_PRODUCTO = lEntidad.TOTAL_PRODUCTO
    '                    lSolicAplicaLote.USUARIO_CREA = Me.ObtenerUsuario
    '                    lSolicAplicaLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
    '                    lSolicAplicaLote.USUARIO_ACT = Me.ObtenerUsuario
    '                    lSolicAplicaLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
    '                    lSolicAplicaLote.ZAFRA = Me.cbxZAFRA.Text
    '                    lSolicAplicaLote.ID_MAESTRO = lLote.ID_MAESTRO
    '                    lSolicAplicaLote.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
    '                    lSolicAplicaLote.FECHA_INI_VENTANA = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1, Me.dteFECHA_APLICACION.Date)
    '                    lSolicAplicaLote.FECHA_FIN_VENTANA = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1 + ((lProducto.VENTSEMA_FIN - lProducto.VENTSEMA_INI + 1) * 7), Me.dteFECHA_APLICACION.Date)
    '                    lSolicAplicaLote.FECHA_ROZA_MADURANTE = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1 + _
    '                                                               Math.Round(Convert.ToDecimal((lProducto.VENTSEMA_FIN - lProducto.VENTSEMA_INI + 1) * 7) / Convert.ToDecimal(2), 0), Me.dteFECHA_APLICACION.Date)
    '                    lRet = bSolicAplicaLotes.ActualizarSOLIC_APLICA_LOTE(lSolicAplicaLote)
    '                    If lRet < 0 Then
    '                        sError.AppendLine("* No se registro la aplicacion del producto para el lote: " + lLote.CODILOTE + " " + lLote.NOMBLOTE)
    '                    End If
    '                Next
    '            End If
    '        End If
    '    Next

    '    '************* Actualizar fecha de aplicación en Solicitud *************
    '    mEntidad.FECHA_APLICA = Me.dteFECHA_APLICACION.Date
    '    mComponente.ActualizarSOLIC_AGRICOLA(mEntidad)
    '    '***********************************************************************

    '    If sError.ToString <> "" Then
    '        Return sError.ToString
    '    End If

    '    Me.ID_SOLICITUD = mEntidad.ID_SOLICITUD
    '    Me._nuevo = False
    '    If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
    '    Me.ViewState.Add("nuevo", Me._nuevo)
    '    Return ""
    'End Function

    Public Function Aceptar() As String
        Dim bSolicAgricola As New cSOLIC_AGRICOLA
        Dim mEntidad As SOLIC_AGRICOLA
        Dim lRet As Int32 = 0
        Dim sError As New StringBuilder

        mEntidad = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(Me.ID_SOLICITUD)
        mEntidad.ESTADO = EstadoSolicAgricola.Aceptada
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        bSolicAgricola.ActualizarSOLIC_AGRICOLA(mEntidad)

        Me.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Public Function Anular() As String
        Dim bSolicAgricola As New cSOLIC_AGRICOLA
        Dim mEntidad As SOLIC_AGRICOLA
        Dim lRet As Int32 = 0
        Dim sError As String

        mEntidad = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(Me.ID_SOLICITUD)
        mEntidad.ESTADO = EstadoSolicAgricola.Anulada
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        bSolicAgricola.ActualizarSOLIC_AGRICOLA(mEntidad)
        sError = bSolicAgricola.sError

        If sError <> "" Then Return sError

        Me.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub txtCODIPROVEE_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE.ValueChanged
        Me.ObtenerProveedor()
        Me.chkSelectTodosLotes.Checked = False
        Me.ucListaSOLIC_AGRICOLA_LOTE1.QuitarSelecciones()
    End Sub

    Private Sub ObtenerContratos(ByVal CODIPROVEE As String)
        Dim lContratos As listaCONTRATO = (New cCONTRATO).ObtenerListaPorCriterios(cbxZAFRA.Value, -1, CODIPROVEE, Utilerias.FormatoCODISOCIO(0))
        If lContratos Is Nothing Then lContratos = New listaCONTRATO
        Me.cbxContrato.DataSource = lContratos
        Me.cbxContrato.DataBind()
        Me.cbxContrato.Text = ""
    End Sub

    Private Sub ObtenerProveedor()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If Me.txtCODIPROVEE.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.txtCODIPROVEE.Text) Then
            Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text) + Utilerias.FormatoCODISOCIO(0)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
            If lProveedor IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                Me.txtNIT.Text = lProveedor.NIT
                Me.txtNRC.Text = lProveedor.CREDITFISCAL
                Me.txtACTIVIDAD.Text = lProveedor.ACTIVIDAD
                Me.ObtenerContratos(Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text))
                ObtenerLotes()

                Dim listaSolicOip As listaSOLIC_OPI = (New cSOLIC_OPI).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, -1, Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text), "", "", Nothing)
                If listaSolicOip IsNot Nothing AndAlso listaSolicOip.Count > 0 Then
                    Me.AsignarMensaje("El productor ya posee OIP para esta zafra", False, True, True)
                End If
            End If
        End If
    End Sub

    Private Sub ObtenerLotes()
        Dim sCodiProveedor As String
        Dim sContrato As String

        If Not Utilerias.EsNumeroEntero(txtCODIPROVEE.Value) Then
            sCodiProveedor = Utilerias.FormatoCODIPROVEE(0)
        Else
            sCodiProveedor = Utilerias.FormatoCODIPROVEE(txtCODIPROVEE.Value) + Utilerias.FormatoCODISOCIO(0)
        End If
        'If Me.cbxTIPO_FINANCIAMIENTO.Value = Enumeradores.CuentaFinanciamiento.Madurantes Then
        '    sContrato = IIf(cbxContrato.Value = Nothing, "-1", cbxContrato.Value)
        'Else
        '    sContrato = ""
        'End If
        sContrato = ""

        Me.LISTA_SOLIC_AGRICOLA_LOTE = (New cSOLIC_AGRICOLA_LOTE).ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(cbxZAFRA.Value, sCodiProveedor, sContrato, cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario), 0)
        Me.CargarDetalleSolicAgricolaLotes()
        Me.chkSelectTodosLotes.Checked = False
        Me.ucListaSOLIC_AGRICOLA_LOTE1.QuitarSelecciones()
    End Sub

    Private Sub ObtenerTarifaVuelo()
        Me.speRIEGO_PRECIO_UNIT.Value = 0
        Me.SetearSubTotalIvaTotal()

        If cbxPROVEEDOR_VUELO.Value IsNot Nothing AndAlso cbxPROVEEDOR_VUELO.Value > 0 AndAlso _
            cbxMEDIO_APLICA.Value IsNot Nothing Then
            Dim lista As listaTARIFA_VUELO
            lista = (New cTARIFA_VUELO).ObtenerListaPorPROVEEDOR_AGRICOLA(cbxPROVEEDOR_VUELO.Value)

            For Each lEntidad As TARIFA_VUELO In lista
                If lEntidad.MEDIO_APLICA = cbxMEDIO_APLICA.Value Then
                    Me.speRIEGO_PRECIO_UNIT.Value = lEntidad.PRECIO
                    Me.SetearSubTotalIvaTotal()
                    Exit For
                End If
            Next
        End If
    End Sub

    Protected Sub cpVistaDetalleSOLIC_AGRICOLA_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpVistaDetalleSOLIC_AGRICOLA.Callback
        Select Case e.Parameter
            Case "TotalizarMZ"
                Me.SetearMZ()
                Me.SetearSubTotalIvaTotal()
            Case "TotalizarMONTO"
                Me.SetearSubTotalIvaTotal()
        End Select
    End Sub

    Protected Sub chkAplicaAGUA_ValueChanged(sender As Object, e As System.EventArgs) Handles chkAplicaAGUA.ValueChanged
        Me.speAGUA_PRECIO_UNIT.Enabled = chkAplicaAGUA.Checked
        Me.speAGUA_PRECIO_UNIT.Value = PrecioAgua
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub speAGUA_PRECIO_UNIT_NumberChanged(sender As Object, e As System.EventArgs) Handles speAGUA_PRECIO_UNIT.NumberChanged
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub speRIEGO_PRECIO_UNIT_NumberChanged(sender As Object, e As System.EventArgs) Handles speRIEGO_PRECIO_UNIT.NumberChanged
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub cbxMEDIO_APLICA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxMEDIO_APLICA.ValueChanged
        ObtenerTarifaVuelo()
    End Sub

    Protected Sub cbxPROVEEDOR_VUELO_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxPROVEEDOR_VUELO.ValueChanged
        cbxMEDIO_APLICA.Value = Nothing
        ObtenerTarifaVuelo()
    End Sub

    Protected Sub cbxContrato_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxContrato.ValueChanged
        Me.ObtenerLotes()
    End Sub

    Protected Sub cbxTIPO_FINANCIAMIENTO_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxTIPO_FINANCIAMIENTO.ValueChanged
        Me.ucListaSOLIC_AGRICOLA_PRODUCTO1.ID_CUENTA_FINAN = Me.cbxTIPO_FINANCIAMIENTO.Value
        Me.DSComboProductos()
    End Sub

    Private Sub DSComboProductos()
        Me.trFOVIAL_COTRANS.Visible = False
        Select Case cbxTIPO_FINANCIAMIENTO.Value
            Case CuentaFinanciamiento.Combustible
                Me.trFOVIAL_COTRANS.Visible = True
            Case CuentaFinanciamiento.Madurantes, CuentaFinanciamiento.InhibidoresFloracion, CuentaFinanciamiento.Insecticidas, CuentaFinanciamiento.VuelosAereosInhibidores,
                 CuentaFinanciamiento.ServiciosMotorizados, CuentaFinanciamiento.Foliares, CuentaFinanciamiento.Bioestimulantes, CuentaFinanciamiento.Herbicidas
                Me.fmlyProveedorVuelo.Visible = True
                Me.trTotalRiego.Visible = True
                Me.trTotalAgua.Visible = True
                Me.speCANT_MZdeta.ClientEnabled = True
                Me.cbxContrato.ClientEnabled = True
            Case Else
                Me.fmlyProveedorVuelo.Visible = False
                Me.trTotalRiego.Visible = False
                Me.trTotalAgua.Visible = False
                Me.speCANT_MZdeta.Text = ""
                Me.speCANT_MZdeta.ClientEnabled = False
                Me.cbxContrato.ClientEnabled = False
        End Select
        Session("ID_CUENTA_FINANsesion") = cbxTIPO_FINANCIAMIENTO.Value
        CargarProveedorAgricola()
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
        'If Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.ServicioMaquinariaAgricola AndAlso cbxPROVEEDOR_AGRICOLAdeta.Value <> 19 Then
        '    Me.speSUB_TOTALdeta.Value = Me.speCANTIDADdeta.Value * Me.spePRECIO_UNITARIOdeta.Value * speMZ_TOTALES.Value
        'Else
        '    Me.speSUB_TOTALdeta.Value = Me.speCANTIDADdeta.Value * Me.spePRECIO_UNITARIOdeta.Value
        'End If
    End Sub

    Protected Sub cbxPROVEEDOR_AGRICOLAdeta_ValueChanged(sender As Object, e As EventArgs) Handles cbxPROVEEDOR_AGRICOLAdeta.ValueChanged
        Me.CargarProductos()
        Me.cbxPRODUCTOdeta.Focus()
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
        Dim lSolicProducto As New SOLIC_AGRICOLA_PRODUCTO
        Dim lProducto As PRODUCTO

        If Me.cbxPROVEEDOR_AGRICOLAdeta.Value Is Nothing Then
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

        lSolicProducto.ID_SOLIC_AGRI_PROD = Me.ObtenerIdProd(Me.LISTA_SOLIC_AGRICOLA_PRODUCTO)
        lSolicProducto.ID_SOLICITUD = 0
        lSolicProducto.ID_PRODUCTO = If(Me.cbxPRODUCTOdeta.SelectedIndex >= 0, Me.cbxPRODUCTOdeta.Value, -1)
        If lSolicProducto.ID_PRODUCTO <> -1 Then
            lProducto = (New cPRODUCTO).ObtenerPRODUCTO(lSolicProducto.ID_PRODUCTO)
            If lProducto IsNot Nothing Then
                lSolicProducto.NOMBRE_PRODUCTO = lProducto.NOMBRE_PRODUCTO
            End If
        Else
            lSolicProducto.NOMBRE_PRODUCTO = Me.cbxPRODUCTOdeta.Text.ToUpper
        End If
        lSolicProducto.CANT_X_MZ = If(Me.speCANT_MZdeta.Text = "", 0, Me.speCANT_MZdeta.Value)
        lSolicProducto.TOTAL_PRODUCTO = Me.speCANTIDADdeta.Value
        lSolicProducto.PRECIO_UNITARIO = Me.spePRECIO_UNITARIOdeta.Value
        lSolicProducto.PRECIO_TOTAL = Me.speSUB_TOTALdeta.Value
        lSolicProducto.USUARIO_CREA = Me.ObtenerUsuario
        lSolicProducto.FECHA_CREA = cFechaHora.ObtenerFechaHora
        lSolicProducto.USUARIO_ACT = Me.ObtenerUsuario
        lSolicProducto.FECHA_ACT = cFechaHora.ObtenerFechaHora
        lSolicProducto.ZAFRA = Me.cbxZAFRA.Text
        lSolicProducto.UID_SOLIC_AGRI_PROD = Guid.NewGuid
        lSolicProducto.PRESENTACION = Me.txtPRESENTACIONdeta.Text.ToUpper
        lSolicProducto.ID_PROVEE = Me.cbxPROVEEDOR_AGRICOLAdeta.Value
        lSolicProducto.ID_PROVEE_ADJU = -1
        lSolicProducto.CANT_ADJU = 0
        lSolicProducto.PRECIO_ADJU = 0
        lSolicProducto.TOTAL_ADJU = 0
        lSolicProducto.UNIDAD = ""
        lSolicProducto.REFERENCIA = Me.lblREFERENCIA.Text

        Me.LISTA_SOLIC_AGRICOLA_PRODUCTO.Add(lSolicProducto)
        Me.CargarDetalleSolicAgricolaProducto()
        Me.AsignarMensaje("", True, False)

        Me.cbxPRODUCTOdeta.SelectedIndex = -1
        Me.txtPRESENTACIONdeta.Text = ""
        Me.speCANT_MZdeta.Text = ""
        Me.speCANTIDADdeta.Text = ""
        Me.spePRECIO_UNITARIOdeta.Text = ""
        Me.speSUB_TOTALdeta.Text = ""
        Me.cbxPRODUCTOdeta.Focus()
    End Sub

    Private Function ObtenerIdProd(ByVal lista As listaSOLIC_AGRICOLA_PRODUCTO) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_SOLIC_AGRI_PROD > Id Then
                Id = lista(i).ID_SOLIC_AGRI_PROD
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub ucListaSOLIC_AGRICOLA_PRODUCTO1_Eliminando(ID_SOLIC_AGRI_PROD As Integer) Handles ucListaSOLIC_AGRICOLA_PRODUCTO1.Eliminando
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub chkSelectTodosLotes_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectTodosLotes.CheckedChanged
        If Me.chkSelectTodosLotes.Checked Then
            Me.ucListaSOLIC_AGRICOLA_LOTE1.SeleccionarTodos()
        Else
            Me.ucListaSOLIC_AGRICOLA_LOTE1.QuitarSelecciones()
        End If
    End Sub

    Protected Sub speRIEGO_MZ_ValueChanged(sender As Object, e As EventArgs) Handles speRIEGO_MZ.ValueChanged
        Me.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub speCANTIDADdeta_NumberChanged(sender As Object, e As EventArgs) Handles speCANTIDADdeta.NumberChanged

    End Sub

    Protected Sub cbxContrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxContrato.SelectedIndexChanged

    End Sub
End Class
