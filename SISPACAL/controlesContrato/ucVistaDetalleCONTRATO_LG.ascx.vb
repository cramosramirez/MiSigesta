Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTRATO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTRATO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTRATO_LG
    Inherits ucBase

#Region "Propiedades"

    Public Property TIPO_OPERACION As TipoOperacionContrato
        Get
            If Me.ViewState("TIPO_OPERACION") Is Nothing Then
                Return TipoOperacionContrato.Ingreso
            Else
                Return Me.ViewState("TIPO_OPERACION")
            End If
        End Get
        Set(ByVal value As TipoOperacionContrato)
            Me.ViewState("TIPO_OPERACION") = value
            If value = TipoOperacionContrato.Ingreso Then
                Me._CODICONTRATO = ""
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(Me._Enabled)
            ElseIf value = TipoOperacionContrato.Consulta Then
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(False)
            End If
        End Set
    End Property

    Public Property LISTA_LOTES_LG As listaLOTES_LG
        Set(value As listaLOTES_LG)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaLOTES_LG) Else Return New listaLOTES_LG
        End Get
    End Property

    Private _CODICONTRATO As String
    Public Property CODICONTRATO() As String
        Get
            Return Me.txtCODICONTRATO.Text
        End Get
        Set(ByVal Value As String)
            Me.lblREFERENCIA.Text = Now.ToString("dd/MM/yyyy HH:mm:ss")
            Me._CODICONTRATO = Value
            Me.txtCODICONTRATO.Text = Value
            If Me._CODICONTRATO <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ZAFRA As Integer
        Get
            If Me.ViewState("ID_ZAFRA") Is Nothing Then
                Return -1
            End If
            Return CInt(Me.ViewState("ID_ZAFRA"))
        End Get
        Set(value As Integer)
            Me.ViewState("ID_ZAFRA") = value
        End Set
    End Property

    Public Property CODIPROVEEDOR() As String
        Get
            Return Me.txtCODIPROVEEDOR_V.Value
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEEDOR_V.Value = value
        End Set
    End Property

    Public Property CODIPROVEE() As Integer
        Get
            If Me.txtCODIPROVEE_V.Text Is Nothing OrElse Not Utilerias.EsNumeroEntero(Me.txtCODIPROVEE_V.Text) Then
                Return -1
            End If
            Return Me.txtCODIPROVEE_V.Text
        End Get
        Set(ByVal value As Integer)
            Me.txtCODIPROVEE_V.Value = value
        End Set
    End Property

    Public Property ZAFRA() As Integer
        Get
            If Me.cbxZAFRA.Value Is Nothing Then
                Return -1
            End If
            Return Me.cbxZAFRA.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxZAFRA.Value = value
        End Set
    End Property

    Public Property NO_CONTRATO() As Integer
        Get
            If Me.txtNO_CONTRATO.Text Is Nothing Then
                Return -1
            End If
            Return CInt(Me.txtNO_CONTRATO.Text)
        End Get
        Set(ByVal value As Integer)
            Me.txtNO_CONTRATO.Text = value
        End Set
    End Property

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
            If Session(lblREFERENCIA.Text + "MZ") IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text + "MZ")
            End If
            If Session(lblREFERENCIA.Text + "TC_X_AREA") IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text + "TC_X_AREA")
            End If
        End If
    End Sub


    Public Property TIPO_CONTRATO() As Integer
        Get
            If Me.cbxTIPO_CONTRATO.Value Is Nothing Then
                Return -1
            End If
            Return Me.cbxTIPO_CONTRATO.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxTIPO_CONTRATO.Value = value
        End Set
    End Property

    Public Property AREA_CULTIVADA() As Decimal
        Get
            If Me.txtAREA_CULTIVADA.Text.Trim = "" Then
                Return 0
            End If
            Return Convert.ToDecimal(Me.txtAREA_CULTIVADA.Value)
        End Get
        Set(ByVal value As Decimal)
            Me.txtAREA_CULTIVADA.Text = value.ToString("#,###,##0.00")
        End Set
    End Property

    Public Property TONEL_X_AREA() As Decimal
        Get
            If Me.txtTON_AREA.Text.Trim = "" Then
                Return 0
            End If
            Return Convert.ToDecimal(Me.txtTON_AREA.Value)
        End Get
        Set(ByVal value As Decimal)
            Me.txtTON_AREA.Text = value.ToString("#,###,##0.00")
        End Set
    End Property

    Public Property FECHA_CONTRATOCB() As DateTime
        Get
            Return Me.dteFECHA_CONTRATO.Date
        End Get
        Set(ByVal value As DateTime)
            Me.dteFECHA_CONTRATO.Value = value
        End Set
    End Property

    Public Property ESTADO_CONTRATOCB() As Int32
        Get
            If Me.chkACTIVO.Checked Then Return 1 Else Return 0
        End Get
        Set(ByVal value As Int32)
            If value = 0 Then
                Me.chkACTIVO.Checked = False
            Else
                Me.chkACTIVO.Checked = True
            End If
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCONTRATO_LG
    Private mEntidad As CONTRATO_LG
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

    'Protected Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init
    '    Me.CargarDetalleContrato()
    'End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("CODICONTRATO") Is Nothing Then Me._CODICONTRATO = Me.ViewState("CODICONTRATO")
        Me.CargarDetalleContrato()
        Me.CargarZafra()
        If Session(Me.lblREFERENCIA.Text + "MZ") IsNot Nothing Then Me.AREA_CULTIVADA = Session(Me.lblREFERENCIA.Text + "MZ")
        If Session(Me.lblREFERENCIA.Text + "TC_X_AREA") IsNot Nothing Then Me.TONEL_X_AREA = Session(Me.lblREFERENCIA.Text + "TC_X_AREA")
        If Me.pcLotesContratados.ShowOnPageLoad Then
            Me.MostrarLotesTraspasar()
        End If
    End Sub


    Private Sub CargarZafra()
        Dim lZafra As ZAFRA
        Dim lZafras As New listaZAFRA
        Dim lista As New listaZAFRA

        If Me._nuevo Then
            lZafra = (New cZAFRA).ObtenerZafraActiva
            If lZafra IsNot Nothing Then lZafras.Add(lZafra)
            lista = (New cZAFRA).ObtenerLista(False, "NOMBRE_ZAFRA")
            For i = 0 To lista.Count - 1
                If lZafra IsNot Nothing Then
                    If CInt(Right(lista(i).NOMBRE_ZAFRA, 4)) > CInt(Right(lZafra.NOMBRE_ZAFRA, 4)) Then
                        lZafras.Add(lista(i))
                    End If
                Else
                    lZafras.Add(lista(i))
                End If
            Next
        Else
            lZafras = (New cZAFRA).ObtenerLista(False, "NOMBRE_ZAFRA")
        End If
        If Me.cbxZAFRA.FindControl("listBox") IsNot Nothing Then
            Dim listControl As New ASPxListBox
            listControl = Me.cbxZAFRA.FindControl("listBox")
            listControl.DataSource = lZafras
            listControl.DataBind()
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTRATO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lProveedor As PROVEEDOR
        Dim lContratoZafras As listaCONTRATO_ZAFRAS_LG
        Dim listaLotesContra As New listaLOTES_LG
        Dim listaLotesProvee As listaLOTES_LG
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CONTRATO_LG
        mEntidad.CODICONTRATO = CODICONTRATO

        If mComponente.ObtenerCONTRATO_LG(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        Me.txtNO_CONTRATO.Value = mEntidad.NO_CONTRATO
        Me.CargarZafra()
        lContratoZafras = (New cCONTRATO_ZAFRAS_LG).ObtenerListaPorCONTRATO_LG(mEntidad.CODICONTRATO)
        If Me.cbxZAFRA.FindControl("listBox") IsNot Nothing AndAlso lContratoZafras IsNot Nothing AndAlso lContratoZafras.Count > 0 Then
            Dim listControl As New ASPxListBox
            Dim sCad As New StringBuilder
            listControl = Me.cbxZAFRA.FindControl("listBox")

            For Each lContraZ As CONTRATO_ZAFRAS_LG In lContratoZafras
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(lContraZ.ID_ZAFRA)
                If listControl.Items.FindByText(lZafra.NOMBRE_ZAFRA) IsNot Nothing Then
                    listControl.Items.FindByText(lZafra.NOMBRE_ZAFRA).Selected = True
                    If sCad.Length = 0 Then sCad.Append(lZafra.NOMBRE_ZAFRA) Else sCad.Append("," + lZafra.NOMBRE_ZAFRA)
                End If
            Next
            Me.cbxZAFRA.Text = sCad.ToString
        End If
        Me.dteFECHA_CONTRATO.Value = mEntidad.FECHA_CONTRATOCB
        If mEntidad.ESTADO_CONTRATOCB = 0 Then
            Me.chkACTIVO.Checked = False
        ElseIf mEntidad.ESTADO_CONTRATOCB = 1 Then
            Me.chkACTIVO.Checked = True
        End If

        Me.ID_ZAFRA = mEntidad.ID_ZAFRA
        Me.cbxTIPO_CONTRATO.Value = mEntidad.TIPO_CONTRATO
        'Cargar Lotes contratados
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing AndAlso lZafraActiva.ID_ZAFRA <> Me.ID_ZAFRA Then
            listaLotesProvee = (New cLOTES_LG).ObtenerListaPorCONTRATO_LG(mEntidad.CODICONTRATO)
        Else
            listaLotesProvee = (New cLOTES_LG).ObtenerListaPorCONTRATO_LG(mEntidad.CODICONTRATO)
            'listaLotesProvee = Me.ObtenerLotesPorProveedor(mEntidad.CODIPROVEEDOR, mEntidad.ANIOZAFRA)
            'listaLotesContra = (New cLOTES).ObtenerListaPorCONTRATO(mEntidad.CODICONTRATO)
            'If listaLotesProvee IsNot Nothing Then
            '    For i As Integer = 0 To listaLotesProvee.Count - 1
            '        If listaLotesContra.BuscarPorColumna("ID_MAESTRO", listaLotesProvee(i).ID_MAESTRO, True) IsNot Nothing Then
            '            listaLotesProvee(i) = CType(listaLotesContra.BuscarPorColumna("ID_MAESTRO", listaLotesProvee(i).ID_MAESTRO, True), LOTES)
            '        End If
            '        listaLotesProvee(i).CODIUBICACION = Nothing
            '        listaLotesProvee(i).REFERENCIA = Me.lblREFERENCIA.Text
            '    Next
            'End If
        End If
        If listaLotesProvee IsNot Nothing AndAlso listaLotesProvee.Count > 0 Then
            For x As Int32 = 0 To listaLotesProvee.Count - 1
                listaLotesProvee(x).REFERENCIA = Me.lblREFERENCIA.Text
            Next
        End If

        Me.LISTA_LOTES_LG = listaLotesProvee
        Me.CargarDetalleContrato()

        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
        Me.txtCODIPROVEE_V.Value = CInt(lProveedor.CODIPROVEE)
        If mEntidad.TIPO_CONTRATO = Enumeradores.TipoContrato.PersonaNatural Then
            Me.txtPROFESION.Text = lProveedor.PROFESION
        Else
            Me.txtNOMBRE_REPRESENTANTE.Text = mEntidad.APODERADO
            Me.txtDUI_REPRESENTANTE.Text = mEntidad.DUI_APODERADO
            Me.txtNIT_REPRESENTANTE.Text = mEntidad.NIT_APODERADO
        End If
        Me.ConfigurarVistaPorTipoContrato()
        Me.txtNOMBRE_PROVEEDOR.Text = mEntidad.NOMBRES.Trim + " " + mEntidad.APELLIDOS.Trim
        Me.txtTELEFONO_V.Text = mEntidad.TELEFONO
        Me.txtDUI_V.Text = mEntidad.DUI
        Me.txtNIT_V.Text = mEntidad.NIT
        Me.txtNRC_V.Text = mEntidad.CREDITFISCAL
        If mEntidad.EDAD = -1 Then
            If lProveedor IsNot Nothing AndAlso lProveedor.FECHA_NAC <> #12:00:00 AM# Then
                Me.txtEDAD.Text = Utilerias.ObtenerEdad(lProveedor.FECHA_NAC, Me.mEntidad.FECHA_CONTRATOCB)
            Else
                Me.txtEDAD.Text = ""
            End If
        Else
            Me.txtEDAD.Text = mEntidad.EDAD
        End If
        Me.txtNO_FINANCIAMIENTO.Text = mEntidad.FINAN_NUMERO
        Me.txtDIRECCION_V.Text = mEntidad.DIRECCION
        Me.txtOBSERVACIONES.Text = mEntidad.OBSERVACIONES_CONTRATOCB
        Me.dteFECHA_REGISTRO.Value = mEntidad.FECHA_REGISTRO
        Me.txtNUM_REGISTRO.Text = mEntidad.NO_REGISTRO
        Me.txtCODIPROVEEDOR_V.Text = mEntidad.CODIPROVEEDOR
        Me.txtCODICONTRATO.Text = mEntidad.CODICONTRATO
        Me.dteFECHA_REGISTRO.Date = mEntidad.FECHA_REGISTRO
        Me.txtNUM_REGISTRO.Text = mEntidad.NO_REGISTRO
        Me.cbxFINANCIAMIENTO.Text = mEntidad.FINANCOADO
        Me.dteFECHA_CONTRA_LEGAL.Value = mEntidad.FECHA_CONTRA_LEGAL
    End Sub

    Public Sub CargarDetalleContrato()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaLOTES_LG1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
        SetearAREA_TCXAREA()
    End Sub

    Public Sub SetearAREA_TCXAREA()
        Dim MZ As Decimal = 0
        Dim TC As Decimal = 0
        Dim TC_X_AREA As Decimal = 0
        For Each lLotes As LOTES_LG In LISTA_LOTES_LG
            MZ += lLotes.AREA
            TC += lLotes.TONELADAS
            TC_X_AREA += (lLotes.AREA * lLotes.TONELADAS)
        Next
        Me.AREA_CULTIVADA = MZ
        Me.TONEL_X_AREA = TC_X_AREA
        If Me.lblREFERENCIA.Text <> "" Then Session(Me.lblREFERENCIA.Text + "MZ") = MZ
        If Me.lblREFERENCIA.Text <> "" Then Session(Me.lblREFERENCIA.Text + "TC_X_AREA") = TC_X_AREA
    End Sub

    Public Sub RefrescarDetalleLotes()
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)
        Dim lMaestroLotes As listaMAESTRO_LOTES
        Dim lLotesProveedor As New listaLOTES_LG
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim indice As Int32

        If lProveedor IsNot Nothing Then
            lLotesProveedor = Me.LISTA_LOTES_LG
            If Me.cbxTIPO_CONTRATO.Value <> CInt(Enumeradores.TipoContrato.Cooperativa) Then
                lMaestroLotes = (New cMAESTRO_LOTES).ObtenerListaPorPROVEEDOR(lProveedor.CODIPROVEEDOR, False, False, "CODILOTE_COMER")
            Else
                lMaestroLotes = (New cMAESTRO_LOTES).ObtenerListaPorCODIPROVEE(lProveedor.CODIPROVEE)
            End If
            For Each lMaestro As MAESTRO_LOTES In lMaestroLotes
                If lLotesProveedor.BuscarPorColumna("ID_MAESTRO", lMaestro.ID_MAESTRO, True) Is Nothing Then
                    Dim lLote As New LOTES_LG
                    lLote.ACCESLOTE = lZafra.NOMBRE_ZAFRA + lMaestro.CUI
                    lLote.ANIOZAFRA = lZafra.NOMBRE_ZAFRA
                    lLote.CODIPROVEEDOR = lMaestro.CODIPROVEEDOR
                    lLote.CODILOTE = lMaestro.CODILOTE_COMER
                    lLote.CODIVARIEDA = lMaestro.CODIVARIEDA
                    lLote.CODIUBICACION = ""
                    lLote.CODICONTRATO = Me.CODICONTRATO
                    lLote.NOMBLOTE = lMaestro.NOMBRE_COMER
                    lLote.AREA = 0
                    lLote.TONELADAS = 0
                    lLote.TONEL_TC = lLote.AREA * lLote.TONELADAS
                    lLote.ZONA = lMaestro.ZONA
                    lLote.SUB_ZONA = lMaestro.SUB_ZONA
                    lLote.EDAD_LOTE = lMaestro.NO_CORTE
                    lLote.USER_CREA = 3
                    lLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    lLote.ID_MAESTRO = lMaestro.ID_MAESTRO
                    lLote.TIPO_DERECHO = lMaestro.TIPO_DERECHO
                    lLote.RIESGO_PIEDRA = lMaestro.RIESGO_PIEDRA
                    lLote.REPARA_ACCESO = lMaestro.REPARA_ACCESO
                    lLote.SIN_ACCESO_PROPIO = lMaestro.SIN_ACCESO_PROPIO
                    lLote.REFERENCIA = Me.lblREFERENCIA.Text
                    lLotesProveedor.Add(lLote)
                Else
                    indice = lLotesProveedor.BuscarIndicePorColumna("ID_MAESTRO", lMaestro.ID_MAESTRO, True)
                    If indice > -1 Then
                        lLotesProveedor(indice).NOMBLOTE = lMaestro.NOMBRE_COMER
                        lLotesProveedor(indice).CODILOTE = lMaestro.CODILOTE_COMER
                    End If
                End If
            Next
            Me.LISTA_LOTES_LG = lLotesProveedor
            Me.CargarDetalleContrato()
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNO_CONTRATO.ClientEnabled = Me._nuevo AndAlso edicion
        Me.cbxZAFRA.ClientEnabled = edicion
        Me.dteFECHA_CONTRATO.ClientEnabled = edicion
        Me.chkACTIVO.ClientEnabled = edicion
        Me.cbxTIPO_CONTRATO.ClientEnabled = Me._nuevo AndAlso edicion
        Me.txtNOMBRE_REPRESENTANTE.ClientEnabled = (edicion AndAlso cbxTIPO_CONTRATO.Value <> 0)
        Me.txtDUI_REPRESENTANTE.ClientEnabled = (edicion AndAlso cbxTIPO_CONTRATO.Value <> 0)
        Me.txtNIT_REPRESENTANTE.ClientEnabled = (edicion AndAlso cbxTIPO_CONTRATO.Value <> 0)
        Me.txtCODIPROVEE_V.ClientEnabled = Me._nuevo AndAlso edicion
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.txtEDAD.ClientEnabled = False
        Me.txtTELEFONO_V.ClientEnabled = edicion
        Me.txtDUI_V.ClientEnabled = edicion
        Me.txtNIT_V.ClientEnabled = edicion
        Me.txtNRC_V.ClientEnabled = edicion
        Me.txtNO_FINANCIAMIENTO.ClientEnabled = edicion

        Me.txtAREA_CULTIVADA.ReadOnly = True
        Me.txtTON_AREA.ReadOnly = True
        Me.txtDIRECCION_V.ClientEnabled = edicion
        Me.txtOBSERVACIONES.ClientEnabled = edicion
        Me.dteFECHA_REGISTRO.ClientEnabled = edicion
        Me.txtNUM_REGISTRO.ClientEnabled = edicion
        Me.dteFECHA_CONTRA_LEGAL.ClientEnabled = edicion

        Dim item As LayoutItem
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("ContratoActivo")
        If item IsNot Nothing Then item.Visible = Not Me._nuevo
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("afterContratoActivo1")
        If item IsNot Nothing Then item.Visible = Me._nuevo
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("afterContratoActivo2")
        If item IsNot Nothing Then item.Visible = Me._nuevo
        Me.ucListaLOTES_LG1.VerCONTRATO_TRASPASO = (Me._CODICONTRATO <> "")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Me.CargarZafra()
        Me.cbxZAFRA.Text = ""
        Me.txtNO_CONTRATO.Value = Nothing
        Me.dteFECHA_CONTRATO.Value = Nothing
        Me.chkACTIVO.Checked = True
        Me.cbxTIPO_CONTRATO.SelectedIndex = -1
        Me.txtNOMBRE_REPRESENTANTE.Text = ""
        Me.txtNIT_REPRESENTANTE.Text = ""
        Me.txtDUI_REPRESENTANTE.Text = ""
        Me.txtCODIPROVEE_V.Text = ""
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtTELEFONO_V.Text = ""
        Me.txtDUI_V.Text = ""
        Me.txtNIT_V.Text = ""
        Me.txtNRC_V.Text = ""
        Me.txtEDAD.Text = ""
        Me.cbxFINANCIAMIENTO.SelectedIndex = -1
        Me.txtNO_FINANCIAMIENTO.Text = ""
        Me.txtDIRECCION_V.Text = ""
        Me.txtOBSERVACIONES.Text = ""
        Me.dteFECHA_REGISTRO.Value = ""
        Me.txtNUM_REGISTRO.Text = ""
        Me.txtCODIPROVEEDOR_V.Text = ""
        Me.txtCODICONTRATO.Text = ""
        Me.txtAREA_CULTIVADA.Text = ""
        Me.txtTON_AREA.Text = ""
        Me.dteFECHA_CONTRA_LEGAL.Value = Nothing
        Me.dteFechaNac.Value = Nothing
        Me.LISTA_LOTES_LG = New listaLOTES_LG
        Me.CargarDetalleContrato()
        Me.cbxTIPO_CONTRATO.Value = CInt(Enumeradores.TipoContrato.PersonaNatural)
        Me.ucListaLOTES_LG1.PermitirFilaDeFiltro = False
        Me.ucListaLOTES_LG1.VerCODISOCIO_NUMERICO = False
        Me.ucListaLOTES_LG1.VerNOMBRE_SOCIO = False
        Me.ucListaLOTES_LG1.VerRIESGO_PIEDRA = True
        Me.ucListaLOTES_LG1.VerREPARA_ACCESO = True
        Me.ucListaLOTES_LG1.VerSIN_ACCESO_PROPIO = True

        Me.MostrarFormatoContratoJuridico(False)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTRATO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim resError As New StringBuilder
        Dim alDatos As New ArrayList
        Dim lProveedor As New PROVEEDOR
        Dim bLotes As New cLOTES_LG
        Dim bContratoZafras As New cCONTRATO_ZAFRAS_LG
        Dim lotesSelecc As New listaLOTES_LG
        Dim aZafras As String()
        Dim lZafrasCombo As New listaZAFRA
        Dim PERMITIR_MODIFICACION_DATOS As Boolean = True
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        mEntidad = New CONTRATO_LG

        If Me._nuevo Then
            mEntidad.USER_CREA = 5
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad.CODICONTRATO = ""
            mEntidad.ESTADO_CONTRATOCB = 1
            mEntidad.ID_ZAFRA = lZafraActiva.ID_ZAFRA

            'Verificar si ya existe el número de contrato
            Dim getNoContrato As Integer = ObtenerCorrelativo()

            If getNoContrato <> txtNO_CONTRATO.Value Then
                Dim msj As String = "Se ha utilizado el No. de Contrato " + Me.txtNO_CONTRATO.Text + ". El sistema asignara el numero" & getNoContrato.ToString & "; intente guardar de nuevo"
                Me.txtNO_CONTRATO.Value = getNoContrato
                Return msj
            End If
        Else
            mEntidad = (New cCONTRATO_LG).ObtenerCONTRATO_LG(Me.txtCODICONTRATO.Text)
            mEntidad.USER_ACT = 5
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            If Me.chkACTIVO.Checked Then
                mEntidad.ESTADO_CONTRATOCB = 1
            Else
                mEntidad.ESTADO_CONTRATOCB = 0
            End If
        End If

        For Each lLote As LOTES_LG In LISTA_LOTES_LG
            If CInt(Me.txtNO_CONTRATO.Value) = 999 Then
                lotesSelecc.Add(lLote)
            Else
                If lLote.AREA > 0 AndAlso lLote.TONELADAS > 0 Then
                    lotesSelecc.Add(lLote)
                End If
            End If
        Next

        ' SE DESACTIVA TEMPORALMENTE ESTA VALIDACIÓN
        ' ******************************************
        'Verificar si existe maestro de lotes con informaciÃ³n incompleta:
        For Each lLoteVal As LOTES_LG In lotesSelecc
            Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(lLoteVal.ID_MAESTRO)
            If lMaestro IsNot Nothing Then
                resError = New StringBuilder
                If lMaestro.ID_TIPO_CANA = -1 Then
                    resError.Append("Tipo Cana,")
                End If
                If lMaestro.ID_TIPO_ROZA = -1 Then
                    resError.Append("Tipo Roza,")
                End If
                If lMaestro.ID_TIPO_ALZA = -1 Then
                    resError.Append("Tipo Alza,")
                End If
                If lMaestro.ID_TIPO_TRANS = -1 Then
                    resError.Append("Tipo Transporte,")
                End If
                If lMaestro.TARIFA_ROZA = -1 Then
                    resError.Append("Tarifa Roza,")
                End If
                If lMaestro.TARIFA_ALZA = -1 Then
                    resError.Append("Tarifa Alza,")
                End If
                If lMaestro.TARIFA_TRANS = -1 Then
                    resError.Append("Tarifa Trans.,")
                End If
                If lMaestro.TARIFA_CORTA = -1 Then
                    resError.Append("Tarifa Corta,")
                End If
                If lMaestro.TARIFA_LARGA = -1 Then
                    resError.Append("Tarifa Larga,")
                End If
                If resError.ToString <> "" Then
                    Return "En la informacion del maestro para el Lote " + lMaestro.CODILOTE_COMER + " " + lMaestro.NOMBRE_COMER + " se requiere: " + resError.ToString + " antes de asociar contrato"
                End If
            End If
        Next

        If cbxZAFRA.Text = "" Then
            Return "Seleccione al menos una zafra"
        End If
        If lotesSelecc.Count = 0 Then
            Return "No hay lotes contratados"
        End If
        If cbxTIPO_CONTRATO.Value = Enumeradores.TipoContrato.PersonaNatural AndAlso Me.txtDUI_V.Text = "" Then
            Return "El numero de DUI es obligatorio"
        End If

        aZafras = cbxZAFRA.Text.Split(",")

        'Se permite agregar nuevos lotes para un contrato que solo esté contratado para la zafra activa
        PERMITIR_MODIFICACION_DATOS = Me._nuevo OrElse (Not Me._nuevo AndAlso mEntidad.ID_ZAFRA = lZafraActiva.ID_ZAFRA) _
                                                OrElse (Not Me._nuevo AndAlso aZafras.Contains(lZafraActiva.NOMBRE_ZAFRA))

        '*************** Permitir modificar información del contrato si el contrato ha sido creado en la misma zafra
        If PERMITIR_MODIFICACION_DATOS Then
            'El anio zafra se tomará de la primer zafra contratada

            If Me._nuevo Then
                aZafras = cbxZAFRA.Text.Split(",")
                For i As Integer = 0 To aZafras.Count - 1
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerPorNOMBRE_ZAFRA(aZafras(i))
                    If lZafra IsNot Nothing Then
                        mEntidad.ANIOZAFRA = lZafra.NOMBRE_ZAFRA
                        Exit For
                    End If
                Next
            End If
            mEntidad.CODIPROVEEDOR = Me.txtCODIPROVEEDOR_V.Text
            mEntidad.NO_CONTRATO = Me.txtNO_CONTRATO.Value
            mEntidad.FECHA_CONTRATOCB = Me.dteFECHA_CONTRATO.Date
            If Me.cbxTIPO_CONTRATO.Value = Enumeradores.TipoContrato.PersonaNatural Then
                mEntidad.APODERADO = ""
                mEntidad.NIT_APODERADO = ""
                mEntidad.DUI_APODERADO = ""
            Else
                mEntidad.APODERADO = Me.txtNOMBRE_REPRESENTANTE.Text.Trim.ToUpper
                mEntidad.NIT_APODERADO = Me.txtNIT_REPRESENTANTE.Text
                mEntidad.DUI_APODERADO = Me.txtDUI_REPRESENTANTE.Text
            End If
            mEntidad.TIPO_CONTRATO = cbxTIPO_CONTRATO.Value
            mEntidad.CODIPROVEEDOR = Me.txtCODIPROVEEDOR_V.Text
            lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(Me.txtCODIPROVEEDOR_V.Text)
            If lProveedor IsNot Nothing Then
                mEntidad.APELLIDOS = lProveedor.APELLIDOS.ToUpper
                mEntidad.NOMBRES = lProveedor.NOMBRES.ToUpper

                'Actualizar datos del proveedor
                lProveedor.DIRECCION = Me.txtDIRECCION_V.Text.ToUpper
                If cbxTIPO_CONTRATO.Value = Enumeradores.TipoContrato.PersonaNatural Then
                    lProveedor.DUI = Me.txtDUI_V.Text
                Else
                    lProveedor.APODERADO = Me.txtNOMBRE_REPRESENTANTE.Text.ToUpper
                    lProveedor.NIT_APODERADO = Me.txtNIT_REPRESENTANTE.Text
                    lProveedor.DUI_APODERADO = Me.txtDUI_REPRESENTANTE.Text
                End If
                If Me.txtNRC_V.Text.Trim <> "" Then
                    If lProveedor.TIPO_CONTRIBUYENTE = 0 Then lProveedor.TIPO_CONTRIBUYENTE = 1
                    lProveedor.CREDITFISCAL = Me.txtNRC_V.Text
                Else
                    lProveedor.CREDITFISCAL = ""
                End If
                lProveedor.NIT = Me.txtNIT_V.Text
                lProveedor.TELEFONO = Me.txtTELEFONO_V.Text
            End If
            mEntidad.TELEFONO = Me.txtTELEFONO_V.Text
            mEntidad.DUI = Me.txtDUI_V.Text
            mEntidad.NIT = Me.txtNIT_V.Text
            mEntidad.CREDITFISCAL = Me.txtNRC_V.Text
            mEntidad.FINANCOADO = Me.cbxFINANCIAMIENTO.Text.Trim.ToUpper
            mEntidad.FINAN_NUMERO = Me.txtNO_FINANCIAMIENTO.Text
            mEntidad.DIRECCION = Me.txtDIRECCION_V.Text.Trim.ToUpper
            mEntidad.OBSERVACIONES_CONTRATOCB = Me.txtOBSERVACIONES.Text.Trim.ToUpper
            mEntidad.FECHA_REGISTRO = Me.dteFECHA_REGISTRO.Date
            mEntidad.NO_REGISTRO = Me.txtNUM_REGISTRO.Text.Trim.ToUpper
            mEntidad.TOTALMZ_CONTRATOCB = Convert.ToDecimal(Me.txtAREA_CULTIVADA.Text)
            mEntidad.TONELADAS_CONTRATOCB = Convert.ToDecimal(Me.txtTON_AREA.Text)
            mEntidad.FECHA_CONTRA_LEGAL = dteFECHA_CONTRA_LEGAL.Date
            If Me.txtEDAD.Text = "" Then
                mEntidad.EDAD = -1
            Else
                mEntidad.EDAD = Convert.ToInt32(Me.txtEDAD.Text)
            End If
        End If


        'Validar que no existan lotes contratados en otros contratos para las zafras seleccionadas
        aZafras = cbxZAFRA.Text.Split(",")
        For i As Integer = 0 To aZafras.Count - 1
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerPorNOMBRE_ZAFRA(aZafras(i))
            If lZafra IsNot Nothing Then lZafrasCombo.Add(lZafra)
        Next
        For Each lLote As LOTES_LG In lotesSelecc
            If lLote.ID_LOTE_TRASPASO <= 0 Then
                Dim lLotes As listaLOTES_LG
                For i As Integer = 0 To lZafrasCombo.Count - 1
                    If Me._nuevo Then
                        lLotes = (New cLOTES_LG).ObtenerListaPorZAFRA_MAESTRO_LOTES(lZafrasCombo(i).ID_ZAFRA, lLote.ID_MAESTRO)
                    Else
                        lLotes = (New cLOTES_LG).ObtenerListaPorZAFRA_MAESTRO_LOTES(lZafrasCombo(i).ID_ZAFRA, lLote.ID_MAESTRO, Me.txtCODICONTRATO.Text)
                    End If

                    If lLotes IsNot Nothing AndAlso lLotes.Count > 0 Then
                        Dim listaZafrasContra As listaCONTRATO_ZAFRAS_LG = bContratoZafras.ObtenerListaPorCONTRATO_LG(lLotes(0).CODICONTRATO)
                        Dim sZafras As New StringBuilder

                        If listaZafrasContra IsNot Nothing AndAlso listaZafrasContra.Count > 0 Then
                            For s As Int32 = 0 To listaZafrasContra.Count - 1
                                lZafrasCombo.Contiene(Nothing)

                                sZafras.Append((New cZAFRA).ObtenerZAFRA(listaZafrasContra(s).ID_ZAFRA).NOMBRE_ZAFRA)
                                If s < (listaZafrasContra.Count - 1) Then sZafras.Append(", ")
                            Next
                        End If
                        Dim lContrato As CONTRATO_LG = (New cCONTRATO_LG).ObtenerCONTRATO_LG(lLotes(0).CODICONTRATO)
                        Return "El lote " + lLote.CODILOTE + " " + lLote.NOMBLOTE + " es parte del contrato No.: " + lContrato.NO_CONTRATO.ToString + " con fecha: " + lContrato.FECHA_CONTRATOCB.ToString("dd/MM/yyyy") + "  contratado para zafras: " + sZafras.ToString
                    End If
                Next
            End If
        Next

        'Actualizar datos del proveedor
        Dim bProveedor As New cPROVEEDOR

        If PERMITIR_MODIFICACION_DATOS Then
            If bProveedor.ActualizarPROVEEDOR(lProveedor) <> 1 Then
                Return bProveedor.sError
            End If
        End If

        If PERMITIR_MODIFICACION_DATOS Then
            'Validar que los lotes eliminados del contrato no se hayan contratado en zafra anterior
            Dim lLotesContratados As listaLOTES_LG
            lLotesContratados = (New cLOTES_LG).ObtenerListaPorCONTRATO_LG(mEntidad.CODICONTRATO)
            If lLotesContratados IsNot Nothing AndAlso lLotesContratados.Count > 0 Then
                For Each lLoteContra As LOTES_LG In lLotesContratados
                    If lotesSelecc.BuscarPorColumna("ID_MAESTRO", lLoteContra.ID_MAESTRO, True) Is Nothing Then
                        Dim lZafraAnt As ZAFRA = (New cZAFRA).ObtenerZafraAnterior(lZafraActiva.ID_ZAFRA)
                        If lZafraAnt IsNot Nothing Then
                            For Each eEntidad As ZAFRA In lZafrasCombo
                                If eEntidad.ID_ZAFRA = lZafraAnt.ID_ZAFRA Then
                                    Return "* No se puede eliminar el lote " + lLoteContra.CODILOTE + " " + lLoteContra.NOMBLOTE + " porque fue contratado para la Zafra " + lZafraAnt.NOMBRE_ZAFRA
                                End If
                            Next
                        End If
                    End If
                Next
            End If

            If mComponente.ActualizarCONTRATO_LG(mEntidad) <> 1 Then
                Return mComponente.sError
            End If
            Me.txtCODICONTRATO.Text = mEntidad.CODICONTRATO.ToString()
        End If


        '******************************
        'Guardar zafras que comprende el contrato
        '******************************
        Dim lContratoZafras As listaCONTRATO_ZAFRAS_LG
        lContratoZafras = (New cCONTRATO_ZAFRAS_LG).ObtenerListaPorCONTRATO_LG(mEntidad.CODICONTRATO)
        If lContratoZafras IsNot Nothing AndAlso lContratoZafras.Count > 0 Then
            'Agregar zafras que no existan en las que ya tenia el contrato
            For Each lZafra As ZAFRA In lZafrasCombo
                If lContratoZafras.BuscarPorColumna("ID_ZAFRA", lZafra.ID_ZAFRA, True) Is Nothing Then
                    Dim lContratoZafra As New CONTRATO_ZAFRAS_LG
                    lContratoZafra.ID_ZAFRA = lZafra.ID_ZAFRA
                    lContratoZafra.CODICONTRATO = mEntidad.CODICONTRATO
                    lContratoZafra.USUARIO_CREA = Me.ObtenerUsuario
                    lContratoZafra.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lContratoZafra.USUARIO_ACT = Me.ObtenerUsuario
                    lContratoZafra.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bContratoZafras.ActualizarCONTRATO_ZAFRAS_LG(lContratoZafra)
                End If
            Next
            'Eliminar zafras que no existan en las seleccionadas (solo para zafras posteriores a la actual)
            For Each lContraZafra As CONTRATO_ZAFRAS_LG In lContratoZafras
                If lZafrasCombo.BuscarPorId(lContraZafra.ID_ZAFRA) Is Nothing Then
                    If CInt((New cZAFRA).ObtenerZAFRA(lContraZafra.ID_ZAFRA).NOMBRE_ZAFRA.Substring(0, 4)) >= CInt(lZafraActiva.NOMBRE_ZAFRA.Substring(0, 4)) Then
                        bContratoZafras.EliminarCONTRATO_ZAFRAS_LG(lContraZafra.ID_CONTRATO_ZAFRAS)
                        sError = bContratoZafras.sError
                        If sError <> "" Then
                            Return sError
                        End If
                    ElseIf CInt((New cZAFRA).ObtenerZAFRA(lContraZafra.ID_ZAFRA).NOMBRE_ZAFRA.Substring(0, 4)) < CInt(lZafraActiva.NOMBRE_ZAFRA.Substring(0, 4)) Then
                        'Eliminar los lotes de la zafra contratada que ya no está en las zafras seleccionadas siempre que no hayan entregado caña
                        bContratoZafras.EliminarCONTRATO_ZAFRAS_LG(lContraZafra.ID_CONTRATO_ZAFRAS)
                        sError = bContratoZafras.sError
                        If sError <> "" Then
                            Return sError
                        End If
                    End If
                End If
            Next
        Else
            For Each lZafra As ZAFRA In lZafrasCombo
                Dim lContratoZafra As New CONTRATO_ZAFRAS_LG
                lContratoZafra.ID_ZAFRA = lZafra.ID_ZAFRA
                lContratoZafra.CODICONTRATO = mEntidad.CODICONTRATO
                lContratoZafra.USUARIO_CREA = Me.ObtenerUsuario
                lContratoZafra.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lContratoZafra.USUARIO_ACT = Me.ObtenerUsuario
                lContratoZafra.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bContratoZafras.ActualizarCONTRATO_ZAFRAS_LG(lContratoZafra)
            Next
        End If

        '******************************
        'Guardar lotes contratados 
        '******************************
        If PERMITIR_MODIFICACION_DATOS Then

            Dim lLotesContratados As listaLOTES_LG
            lLotesContratados = (New cLOTES_LG).ObtenerListaPorCONTRATO_LG(mEntidad.CODICONTRATO)
            If lLotesContratados IsNot Nothing AndAlso lLotesContratados.Count > 0 Then
                'Agregar lotes que no existan en las que ya tenia el contrato
                For Each lLote As LOTES_LG In lotesSelecc
                    Dim lLoteContra As LOTES_LG
                    Dim sAccesLoteTraspasar As String = ""
                    lLoteContra = lLote
                    If lLotesContratados.BuscarPorColumna("ID_MAESTRO", lLote.ID_MAESTRO, True) Is Nothing Then
                        If lLoteContra.ID_LOTE_TRASPASO <= 0 OrElse
                                (lLoteContra.ID_LOTE_TRASPASO > 0 AndAlso Me.LoteSinEntregasZafraActiva(lLoteContra.ACCESLOTE)) Then
                            sAccesLoteTraspasar = lLoteContra.ACCESLOTE
                            lLoteContra.ACCESLOTE = ""
                        End If
                        If lLoteContra.ID_LOTE_TRASPASO > 0 Then lLoteContra.ACCESLOTE_TRASPASAR = sAccesLoteTraspasar
                        lLoteContra.CODICONTRATO = Me.txtCODICONTRATO.Text
                        lLoteContra.CODIUBICACION = Nothing
                        lLoteContra.CODIAGRON = Nothing
                        lLoteContra.USER_CREA = 1
                        lLoteContra.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lLoteContra.USER_ACT = 1
                        lLoteContra.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    Else
                        lLoteContra.CODIUBICACION = Nothing
                        lLoteContra.CODIAGRON = Nothing
                        lLoteContra.USER_ACT = 1
                        lLoteContra.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    End If
                    If bLotes.ActualizarLOTES_LG(lLoteContra, TipoConcurrencia.Pesimistica) <= -1 Then
                        Return bLotes.sError
                    End If

                    'Actualizar EDAD Y VARIEDAD EN MAESTRO DE LOTES
                    Dim lMaestroLote As New MAESTRO_LOTES
                    Dim bMaestroLote As New cMAESTRO_LOTES
                    lMaestroLote = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(lLote.ID_MAESTRO)
                    If lMaestroLote IsNot Nothing Then
                        lMaestroLote.NO_CORTE = lLote.EDAD_LOTE
                        lMaestroLote.CODIVARIEDA = lLote.CODIVARIEDA
                        lMaestroLote.RIESGO_PIEDRA = lLote.RIESGO_PIEDRA
                        lMaestroLote.REPARA_ACCESO = lLote.REPARA_ACCESO
                        lMaestroLote.SIN_ACCESO_PROPIO = lLote.SIN_ACCESO_PROPIO
                        bMaestroLote.ActualizarMAESTRO_LOTES(lMaestroLote, TipoConcurrencia.Pesimistica)
                    End If
                Next
                'Eliminar lotes que no existan en los seleccionadas
                For Each lLoteContra As LOTES_LG In lLotesContratados
                    If lotesSelecc.BuscarPorColumna("ID_MAESTRO", lLoteContra.ID_MAESTRO, True) Is Nothing Then
                        bLotes.EliminarLOTES_LG(lLoteContra.ACCESLOTE)
                    End If
                Next
            Else
                For Each lLote As LOTES_LG In lotesSelecc
                    Dim lLoteContra As New LOTES_LG
                    Dim sAccesLoteTraspasar As String = ""
                    lLoteContra = lLote
                    If lLoteContra.ID_LOTE_TRASPASO <= 0 OrElse
                                (lLoteContra.ID_LOTE_TRASPASO > 0 AndAlso Me.LoteSinEntregasZafraActiva(lLoteContra.ACCESLOTE)) Then
                        sAccesLoteTraspasar = lLoteContra.ACCESLOTE
                        lLoteContra.ACCESLOTE = ""
                    End If
                    If lLoteContra.ID_LOTE_TRASPASO > 0 Then lLoteContra.ACCESLOTE_TRASPASAR = sAccesLoteTraspasar
                    lLoteContra.CODIUBICACION = Nothing
                    lLoteContra.CODIAGRON = Nothing
                    lLoteContra.CODICONTRATO = Me.txtCODICONTRATO.Text
                    lLoteContra.USER_CREA = 1
                    lLoteContra.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lLoteContra.USER_ACT = 1
                    lLoteContra.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    If bLotes.ActualizarLOTES_LG(lLoteContra, TipoConcurrencia.Pesimistica) <= 0 Then
                        Return bLotes.sError
                    End If
                Next
            End If
        Else
            Dim lLotesContratados As listaLOTES_LG
            lLotesContratados = (New cLOTES_LG).ObtenerListaPorCONTRATO_LG(mEntidad.CODICONTRATO)
            For Each lLote As LOTES_LG In lLotesContratados
                If bLotes.ActualizarLOTES_LG(lLote, TipoConcurrencia.Pesimistica) < 1 Then
                    Return bLotes.sError
                End If
            Next
        End If

        If Me._nuevo Then ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarContratoLegalZafra('" + mEntidad.CODICONTRATO + "')", True)

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Private Function LoteSinEntregasZafraActiva(ByVal ACCESLOTE As String) As Boolean
        Dim lLotesCosecha As listaLOTES_COSECHA
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        lLotesCosecha = (New cLOTES_COSECHA).ObtenerListaPorLOTES(ACCESLOTE)
        If lLotesCosecha IsNot Nothing AndAlso lLotesCosecha.Count > 0 AndAlso lZafraActiva IsNot Nothing Then
            For Each lLoteCosecha As LOTES_COSECHA In lLotesCosecha
                If lLoteCosecha.ID_ZAFRA = lZafraActiva.ID_ZAFRA AndAlso lLoteCosecha.TONEL_ENTREGADA > 0 Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function

    Protected Sub txtCODIPROVEE_V_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE_V.ValueChanged
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtDIRECCION_V.Text = ""
        Me.txtDUI_V.Text = ""
        Me.txtNIT_V.Text = ""
        Me.txtTELEFONO_V.Text = ""
        Me.txtNRC_V.Text = ""
        Me.txtCODIPROVEEDOR_V.Text = ""
        Me.txtPROFESION.Text = ""
        Me.txtEDAD.Text = ""
        Me.LISTA_LOTES_LG = New listaLOTES_LG

        AsignarMensaje("", True, False)
        If txtCODIPROVEE_V.Text <> "" Then
            Dim sCodiProvee As String = Utilerias.FormatearCODIPROVEEDOR(txtCODIPROVEE_V.Text)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(sCodiProvee)
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva

            If lProveedor IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
                Me.txtDIRECCION_V.Text = lProveedor.DIRECCION.Trim
                Me.txtDUI_V.Text = lProveedor.DUI.Trim
                Me.txtNIT_V.Text = lProveedor.NIT.Trim
                Me.txtTELEFONO_V.Text = lProveedor.TELEFONO.Trim
                Me.txtNRC_V.Text = lProveedor.CREDITFISCAL.Trim
                If lProveedor.FECHA_NAC <> #12:00:00 AM# Then
                    Me.dteFechaNac.Date = lProveedor.FECHA_NAC
                    If lProveedor.FECHA_NAC <> #12:00:00 AM# AndAlso Me.dteFECHA_CONTRATO.Date <> #12:00:00 AM# Then
                        Me.txtEDAD.Text = Utilerias.ObtenerEdad(lProveedor.FECHA_NAC, Me.dteFECHA_CONTRATO.Date)
                    Else
                        Me.txtEDAD.Text = ""
                    End If
                Else
                    Me.dteFechaNac.Date = Nothing
                    Me.txtEDAD.Text = ""
                End If
                Me.txtPROFESION.Text = lProveedor.PROFESION
                Me.txtCODIPROVEEDOR_V.Text = lProveedor.CODIPROVEEDOR
                If Me.cbxTIPO_CONTRATO.Value <> Enumeradores.TipoContrato.PersonaNatural Then
                    Me.txtNOMBRE_REPRESENTANTE.Text = lProveedor.APODERADO
                    Me.txtDUI_REPRESENTANTE.Text = lProveedor.DUI_APODERADO
                    Me.txtNIT_REPRESENTANTE.Text = lProveedor.NIT_APODERADO
                End If
                Me.LISTA_LOTES_LG = Me.ObtenerLotesPorProveedor(sCodiProvee, lZafra.ID_ZAFRA)
            Else
                txtCODIPROVEE_V.Text = ""
                Me.txtCODIPROVEEDOR_V.Text = ""
                AsignarMensaje("Codigo de proveedor no existe. Para crearlo seleccione la opcion Ingresar nuevo proveedor", True, False)
            End If
        End If
        Me.CargarDetalleContrato()
    End Sub

    Private Function ObtenerLotesPorProveedor(ByVal CODIPROVEEDOR As String, ByVal ID_ZAFRA_ACTUAL As Int32) As listaLOTES_LG
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)
        Dim bMaestroLote As New cMAESTRO_LOTES
        Dim lMaestroLotes As listaMAESTRO_LOTES
        Dim lLotesProveedor As New listaLOTES_LG
        Dim bLoteCosecha As New cLOTES_COSECHA
        Dim lZafraActual As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA_ACTUAL)

        If lProveedor IsNot Nothing Then
            If Me.cbxTIPO_CONTRATO.Value <> CInt(Enumeradores.TipoContrato.Cooperativa) Then
                lMaestroLotes = (New cMAESTRO_LOTES).ObtenerListaPorPROVEEDOR(lProveedor.CODIPROVEEDOR, False, False, "CODILOTE_COMER")
            Else
                lMaestroLotes = (New cMAESTRO_LOTES).ObtenerListaPorCODIPROVEE(lProveedor.CODIPROVEE)
            End If
            For Each lMaestro As MAESTRO_LOTES In lMaestroLotes
                Dim lLote As New LOTES_LG
                Dim lLoteContratado As LOTES_LG
                Dim lstLoteCosecha As listaLOTES_COSECHA

                lstLoteCosecha = bLoteCosecha.ObtenerUltimaCosechaPorLOTE_FinLote(lMaestro.ID_MAESTRO, "")
                If lstLoteCosecha IsNot Nothing AndAlso lstLoteCosecha.Count > 0 Then
                    '***************************************************************************************************
                    'Actualizar CAT de la última zafra en maestro
                    If lstLoteCosecha(0).ID_TIPO_CANA <> -1 Then lMaestro.ID_TIPO_CANA = lstLoteCosecha(0).ID_TIPO_CANA
                    If lstLoteCosecha(0).ID_TIPO_ROZA <> -1 Then lMaestro.ID_TIPO_ROZA = lstLoteCosecha(0).ID_TIPO_ROZA
                    If lstLoteCosecha(0).ID_TIPO_ALZA <> -1 Then lMaestro.ID_TIPO_ALZA = lstLoteCosecha(0).ID_TIPO_ALZA
                    If lstLoteCosecha(0).ID_TIPO_TRANS <> -1 Then lMaestro.ID_TIPO_TRANS = lstLoteCosecha(0).ID_TIPO_TRANS
                    bMaestroLote.ActualizarMAESTRO_LOTES(lMaestro)

                    lLoteContratado = (New cLOTES_LG).ObtenerLOTES_LG(lstLoteCosecha(0).ACCESLOTE)
                End If

                lLote.ACCESLOTE = lZafraActual.NOMBRE_ZAFRA + lMaestro.CUI
                lLote.ANIOZAFRA = lZafraActual.NOMBRE_ZAFRA
                lLote.CODIPROVEEDOR = lMaestro.CODIPROVEEDOR
                lLote.CODILOTE = lMaestro.CODILOTE_COMER

                lLote.CODIUBICACION = ""
                lLote.CODICONTRATO = ""
                lLote.NOMBLOTE = lMaestro.NOMBRE_COMER
                lLote.AREA = 0
                lLote.TONELADAS = 0
                lLote.TONEL_TC = lLote.AREA * lLote.TONELADAS
                lLote.ZONA = lMaestro.ZONA
                lLote.SUB_ZONA = lMaestro.SUB_ZONA
                lLote.CODIVARIEDA = lMaestro.CODIVARIEDA
                If lstLoteCosecha IsNot Nothing AndAlso lstLoteCosecha.Count > 0 Then
                    lLote.EDAD_LOTE = lstLoteCosecha(0).EDAD_LOTE + 1
                    If lLoteContratado IsNot Nothing Then
                        lLote.CODIVARIEDA = lLoteContratado.CODIVARIEDA
                    End If
                Else
                    lLote.EDAD_LOTE = lMaestro.NO_CORTE
                End If
                lLote.USER_CREA = 3
                lLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lLote.ID_MAESTRO = lMaestro.ID_MAESTRO
                lLote.TIPO_DERECHO = lMaestro.TIPO_DERECHO
                lLote.RIESGO_PIEDRA = lMaestro.RIESGO_PIEDRA
                lLote.REPARA_ACCESO = lMaestro.REPARA_ACCESO
                lLote.SIN_ACCESO_PROPIO = lMaestro.SIN_ACCESO_PROPIO
                lLote.REFERENCIA = Me.lblREFERENCIA.Text
                lLotesProveedor.Add(lLote)
            Next
        End If

        Return lLotesProveedor
    End Function

    Protected Sub cbxTIPO_CONTRATO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxTIPO_CONTRATO.SelectedIndexChanged
        Me.ConfigurarVistaPorTipoContrato()
        If txtCODIPROVEE_V.Text <> "" Then
            Dim sCodiProvee As String = Utilerias.FormatearCODIPROVEEDOR(txtCODIPROVEE_V.Text)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(sCodiProvee)
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva

            If lProveedor IsNot Nothing Then
                If Me.cbxTIPO_CONTRATO.Value <> Enumeradores.TipoContrato.PersonaNatural Then
                    Me.txtNOMBRE_REPRESENTANTE.Text = lProveedor.APODERADO
                    Me.txtDUI_REPRESENTANTE.Text = lProveedor.DUI_APODERADO
                    Me.txtNIT_REPRESENTANTE.Text = lProveedor.NIT_APODERADO
                Else
                    Me.txtDUI_V.Text = lProveedor.DUI
                End If
                Me.LISTA_LOTES_LG = Me.ObtenerLotesPorProveedor(sCodiProvee, lZafra.ID_ZAFRA)
                Me.CargarDetalleContrato()
            End If
        End If
    End Sub

    Private Sub ConfigurarVistaPorTipoContrato()
        Me.ucListaLOTES_LG1.PermitirFilaDeFiltro = False
        ucListaLOTES_LG1.VerCODISOCIO_NUMERICO = False
        ucListaLOTES_LG1.VerNOMBRE_SOCIO = False
        Select Case cbxTIPO_CONTRATO.Value
            Case Enumeradores.TipoContrato.PersonaNatural
                MostrarFormatoContratoJuridico(False)
            Case Enumeradores.TipoContrato.PersonaJuridica
                MostrarFormatoContratoJuridico(True)
            Case Enumeradores.TipoContrato.Cooperativa
                Me.ucListaLOTES_LG1.PermitirFilaDeFiltro = True
                ucListaLOTES_LG1.VerCODISOCIO_NUMERICO = True
                ucListaLOTES_LG1.VerNOMBRE_SOCIO = True
                MostrarFormatoContratoJuridico(True)
        End Select
    End Sub

    Private Sub MostrarFormatoContratoJuridico(ByVal mostrar As Boolean)
        Dim item As LayoutItem
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("NombreRepresentanteLegal")
        If item IsNot Nothing Then item.Visible = mostrar
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("DuiRepresentanteLegal")
        If item IsNot Nothing Then item.Visible = mostrar
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("NitRepresentanteLegal")
        If item IsNot Nothing Then item.Visible = mostrar
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("Dui")
        If item IsNot Nothing Then item.Visible = Not mostrar
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("Edad")
        If item IsNot Nothing Then item.Visible = Not mostrar
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("Profesion")
        If item IsNot Nothing Then item.Visible = Not mostrar
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("afterProfesion1")
        If item IsNot Nothing Then item.Visible = Not mostrar
        item = ucVistaDetalleCONTRATOLayout.FindItemByFieldName("afterProfesion2")
        If item IsNot Nothing Then item.Visible = Not mostrar

        If Not mostrar Then
            Me.txtPROFESION.Text = ""
            Me.txtNOMBRE_REPRESENTANTE.Text = ""
            Me.txtDUI_REPRESENTANTE.Text = ""
            Me.txtNIT_REPRESENTANTE.Text = ""
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As System.EventArgs) Handles btnBuscar.Click
        If cbxZafraTraspaso.Value Is Nothing Then
            Me.lblpcError.Text = "* Seleccione la zafra a la que aplica el contrato"
            Return
        End If
        If txtNoContratoTraspaso.Text = "" Then
            Me.lblpcError.Text = "* Ingrese un No. de Contrato"
            Return
        End If
        If cbxTIPO_DERECHO.Text = "" Then
            Me.lblpcError.Text = "* Seleccione el derecho sobre lote que tendra en el nuevo contrato"
            Return
        End If
        Dim lContratos As listaCONTRATO_LG = (New cCONTRATO_LG).ObtenerListaPorCriterios(CInt(cbxZafraTraspaso.Value), CInt(Me.txtNoContratoTraspaso.Value), "", "")
        If lContratos IsNot Nothing AndAlso lContratos.Count > 0 Then
            If lContratos(0).CODIPROVEEDOR = Me.txtCODIPROVEEDOR_V.Text Then
                Me.lblpcError.Text = "* El contrato no puede ser del mismo proveedor"
                Return
            End If
            Me.lblpcError.Text = ""
            Me.ucListaLOTES_LG2.QuitarSeleccion()
            Me.MostrarLotesTraspasar()
        Else
            Me.lblpcError.Text = "* No. de Contrato no esta registrado para la zafra"
            Return
        End If
    End Sub

    Private Sub MostrarLotesTraspasar()
        If cbxZafraTraspaso.Value IsNot Nothing AndAlso Me.txtNoContratoTraspaso.Text <> "" Then
            Dim lContratos As listaCONTRATO_LG = (New cCONTRATO_LG).ObtenerListaPorCriterios(CInt(cbxZafraTraspaso.Value), CInt(Me.txtNoContratoTraspaso.Value), "", "")
            If lContratos IsNot Nothing AndAlso lContratos.Count > 0 Then
                Me.ucListaLOTES_LG2.CargarDatosPorCONTRATO(lContratos(0).CODICONTRATO)
            End If
        End If
    End Sub

    Public Function ElegirLoteContratado() As String
        If Me.txtCODIPROVEE_V.Text = "" Then
            Return "* Ingrese el codigo de proveedor"
        End If
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing Then Me.cbxZafraTraspaso.Value = lZafraActiva.ID_ZAFRA
        Me.txtNoContratoTraspaso.Text = ""
        Me.cbxTIPO_DERECHO.Text = ""
        Me.ucListaLOTES_LG2.QuitarFiltros()
        Me.ucListaLOTES_LG2.CargarDatosPorCONTRATO("")
        Me.pcLotesContratados.ShowOnPageLoad = True
        Me.txtNoContratoTraspaso.Focus()
        Return ""
    End Function

    Protected Sub btnSeleccionar_Click(sender As Object, e As System.EventArgs) Handles btnSeleccionar.Click
        Dim lLotes As listaLOTES_LG = Me.ucListaLOTES_LG2.DevolverSeleccionados
        If lLotes Is Nothing OrElse lLotes.Count = 0 Then
            Me.lblpcError.Text = "* Seleccione un lote de la lista."
            Return
        End If
        Dim lLote As LOTES_LG = (New cLOTES_LG).ObtenerLOTES_LG(lLotes(0).ACCESLOTE)
        If lLote IsNot Nothing Then
            lLotes = Me.LISTA_LOTES_LG
            If lLotes Is Nothing Then lLotes = New listaLOTES_LG

            'Verificar que el lote no se encuentre agregado al contrato
            For Each l As LOTES_LG In lLotes
                If l.ID_MAESTRO = lLote.ID_MAESTRO Then
                    Me.lblpcError.Text = "* El lote ya se encuentra en el contrato actual."
                    Return
                End If
            Next
            lLote.ANIOZAFRA = Me.cbxZafraTraspaso.Text
            lLote.CODIPROVEEDOR = Me.txtCODIPROVEEDOR_V.Text
            lLote.AREA = 0
            lLote.TONELADAS = 0
            lLote.TONEL_TC = 0
            lLote.TIPO_DERECHO = Me.cbxTIPO_DERECHO.Value
            lLote.REFERENCIA = Me.lblREFERENCIA.Text
            lLote.ID_LOTE_TRASPASO = 999
            lLotes.Add(lLote)

            Me.LISTA_LOTES_LG = lLotes
            Me.CargarDetalleContrato()
            Me.pcLotesContratados.ShowOnPageLoad = False
        End If
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        If Me._nuevo Then
            Me.txtNO_CONTRATO.Value = ObtenerCorrelativo()
        End If
    End Sub

    Public Function HabilitarContratoEjecucion(ByVal pCODICONTRATO As String) As String
        Dim lContratoEjec As CONTRATO
        Dim lLotesEjec As LOTES
        Dim lZafraContraEjec As CONTRATO_ZAFRAS

        Dim bContratoEjec As New cCONTRATO
        Dim bLotesEjec As New cLOTES
        Dim bZafraContraEjec As New cCONTRATO_ZAFRAS

        Dim lContratoLg As CONTRATO_LG
        Dim listaLotesLg As listaLOTES_LG
        Dim lZafraContraLg As listaCONTRATO_ZAFRAS_LG



        lContratoLg = (New cCONTRATO_LG).ObtenerCONTRATO_LG(pCODICONTRATO)
        If lContratoLg IsNot Nothing Then
            lContratoEjec = (New cCONTRATO).ObtenerCONTRATO(pCODICONTRATO)

            If lContratoEjec Is Nothing Then
                lContratoEjec = New CONTRATO
                lContratoEjec.CODICONTRATO = lContratoLg.CODICONTRATO
                lContratoEjec.ANIOZAFRA = lContratoLg.ANIOZAFRA
                lContratoEjec.CODIPROVEEDOR = lContratoLg.CODIPROVEEDOR
                lContratoEjec.FECHA_CONTRATOCB = lContratoLg.FECHA_CONTRATOCB
                lContratoEjec.ESTADO_CONTRATOCB = lContratoLg.ESTADO_CONTRATOCB
                lContratoEjec.FINANCOADO = lContratoLg.FINANCOADO
                lContratoEjec.FINAN_NUMERO = lContratoLg.FINAN_NUMERO
                lContratoEjec.TOTALMZ_CONTRATOCB = lContratoLg.TOTALMZ_CONTRATOCB
                lContratoEjec.TONELADAS_CONTRATOCB = lContratoLg.TONELADAS_CONTRATOCB
                lContratoEjec.OBSERVACIONES_CONTRATOCB = lContratoLg.OBSERVACIONES_CONTRATOCB
                lContratoEjec.USER_CREA = 1
                lContratoEjec.FECHA_CREA = lContratoLg.FECHA_CREA
                lContratoEjec.USER_ACT = 1
                lContratoEjec.FECHA_ACT = lContratoLg.FECHA_ACT
                lContratoEjec.FECHA_REGISTRO = lContratoLg.FECHA_REGISTRO
                lContratoEjec.APELLIDOS = lContratoLg.APELLIDOS
                lContratoEjec.NOMBRES = lContratoLg.NOMBRES
                lContratoEjec.DIRECCION = lContratoLg.DIRECCION
                lContratoEjec.TELEFONO = lContratoLg.TELEFONO
                lContratoEjec.CELULAR = lContratoLg.CELULAR
                lContratoEjec.DUI = lContratoLg.DUI
                lContratoEjec.NIT = lContratoLg.NIT
                lContratoEjec.CREDITFISCAL = lContratoLg.CREDITFISCAL
                lContratoEjec.APODERADO = lContratoLg.APODERADO
                lContratoEjec.DUI_APODERADO = lContratoLg.DUI_APODERADO
                lContratoEjec.NIT_APODERADO = lContratoLg.NIT_APODERADO
                lContratoEjec.ID_ZAFRA = lContratoLg.ID_ZAFRA
                lContratoEjec.NO_CONTRATO = lContratoLg.NO_CONTRATO
                lContratoEjec.TIPO_CONTRATO = lContratoLg.TIPO_CONTRATO
                lContratoEjec.FECHA_CONTRA_LEGAL = lContratoLg.FECHA_CONTRA_LEGAL
                lContratoEjec.EDAD = lContratoLg.EDAD
                bContratoEjec.AgregarCONTRATO(lContratoEjec)

                listaLotesLg = (New cLOTES_LG).ObtenerListaPorCONTRATO_LG(pCODICONTRATO)
                If listaLotesLg IsNot Nothing AndAlso listaLotesLg.Count > 0 Then
                    For Each lEntidadLote As LOTES_LG In listaLotesLg
                        lLotesEjec = New LOTES
                        lLotesEjec.ACCESLOTE = lEntidadLote.ACCESLOTE
                        lLotesEjec.ANIOZAFRA = lEntidadLote.ANIOZAFRA
                        lLotesEjec.CODIPROVEEDOR = lEntidadLote.CODIPROVEEDOR
                        lLotesEjec.CODILOTE = lEntidadLote.CODILOTE
                        lLotesEjec.CODIAGRON = lEntidadLote.CODIAGRON
                        lLotesEjec.CODIVARIEDA = lEntidadLote.CODIVARIEDA
                        lLotesEjec.CODIUBICACION = lEntidadLote.CODIUBICACION
                        lLotesEjec.CODICONTRATO = lEntidadLote.CODICONTRATO
                        lLotesEjec.NOMBLOTE = lEntidadLote.NOMBLOTE
                        lLotesEjec.AREA = lEntidadLote.AREA
                        lLotesEjec.TONELADAS = lEntidadLote.TONELADAS
                        lLotesEjec.TONEL_TC = lEntidadLote.TONEL_TC
                        lLotesEjec.ACCESLOTE = lEntidadLote.ACCESLOTE
                        lLotesEjec.ZONA = lEntidadLote.ZONA
                        lLotesEjec.EDAD_LOTE = lEntidadLote.EDAD_LOTE
                        lLotesEjec.USER_CREA = 1
                        lLotesEjec.FECHA_CREA = lEntidadLote.FECHA_CREA
                        lLotesEjec.USER_ACT = 1
                        lLotesEjec.FECHA_ACT = lEntidadLote.FECHA_ACT
                        lLotesEjec.ID_MAESTRO = lEntidadLote.ID_MAESTRO
                        lLotesEjec.TIPO_DERECHO = lEntidadLote.TIPO_DERECHO
                        lLotesEjec.SUB_ZONA = lEntidadLote.SUB_ZONA

                        lLotesEjec.ID_LOTE_TRASPASO = lEntidadLote.ID_LOTE_TRASPASO
                        lLotesEjec.AREA_CANA = lEntidadLote.AREA_CANA
                        lLotesEjec.RIESGO_PIEDRA = lEntidadLote.RIESGO_PIEDRA
                        lLotesEjec.REPARA_ACCESO = lEntidadLote.REPARA_ACCESO
                        lLotesEjec.SIN_ACCESO_PROPIO = lEntidadLote.SIN_ACCESO_PROPIO
                        bLotesEjec.AgregarLOTES(lLotesEjec)
                    Next
                End If

                lZafraContraLg = (New cCONTRATO_ZAFRAS_LG).ObtenerListaPorCONTRATO_LG(pCODICONTRATO)
                If lZafraContraLg IsNot Nothing AndAlso lZafraContraLg.Count > 0 Then
                    For Each lZafraContra As CONTRATO_ZAFRAS_LG In lZafraContraLg
                        lZafraContraEjec = New CONTRATO_ZAFRAS
                        lZafraContraEjec.ID_CONTRATO_ZAFRAS = 0
                        lZafraContraEjec.CODICONTRATO = lZafraContra.CODICONTRATO
                        lZafraContraEjec.ID_ZAFRA = lZafraContra.ID_ZAFRA
                        lZafraContraEjec.USUARIO_CREA = lZafraContra.USUARIO_CREA
                        lZafraContraEjec.FECHA_CREA = lZafraContra.FECHA_CREA
                        lZafraContraEjec.USUARIO_ACT = lZafraContra.USUARIO_ACT
                        lZafraContraEjec.FECHA_ACT = lZafraContra.FECHA_ACT
                        bZafraContraEjec.ActualizarCONTRATO_ZAFRAS(lZafraContraEjec)
                    Next
                End If
            Else
                Return "El contrato ya fue habilitado en ejecucion"
            End If

        End If

        Return ""

    End Function


    Public Function ObtenerCorrelativo() As Integer
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim aZafras As String()
        Dim idProximaZafra As Int32 = -1

        'Verificar si la zafra del contrato es una zafra activa
        aZafras = cbxZAFRA.Text.Split(",")
        If cbxZAFRA.Text <> "" Then
            For i As Integer = 0 To aZafras.Count - 1
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerPorNOMBRE_ZAFRA(aZafras(i))
                If lZafra IsNot Nothing AndAlso lZafra.ID_ZAFRA = lZafraActiva.ID_ZAFRA Then
                    Return mComponente.ObtenerCorrelativoContratoPorZafra(lZafra.ID_ZAFRA)
                End If
                If idProximaZafra = -1 AndAlso lZafraActiva.ID_ZAFRA < lZafra.ID_ZAFRA Then idProximaZafra = lZafra.ID_ZAFRA
            Next

            'Si no es una zafra activa utilizar el número de zafra siguiente
            Return mComponente.ObtenerCorrelativoContratoPorZafra(idProximaZafra)
        Else
            Return -1
        End If
    End Function
End Class
