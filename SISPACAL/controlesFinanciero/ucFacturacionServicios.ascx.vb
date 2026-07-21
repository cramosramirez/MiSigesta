Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.BL

Partial Class controlesFinanciero_ucFacturacionServicios
    Inherits ucBase



#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_ANTICIPO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.Label1.Text = "Facturación de Productos/Servicios"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("EmitirFactura", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucCriteriosFacturacionServiciosLayout.Visible = True
        Me.ucListaCONTRATO_CTAS_PROVI.Visible = True
        'Me.ucVistaDetalleSOLIC_OPI1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_ANTICIPO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("EmitirFactura", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucCriteriosFacturacionServiciosLayout.Visible = False
        Me.ucListaCONTRATO_CTAS_PROVI.Visible = False
        'Me.ucVistaDetalleSOLIC_OPI1.Visible = True
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("EmitirFactura", "Emitir Factura/CCF", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.cbxTIPO_CONTRIBUYENTE.SelectedIndex = 0
    End Sub
#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim CORR_OPI As Integer = -1
                Dim CODIPROVEE As String = ""
                Dim ID_CUENTA_FINAN As Int32 = -1

                If Me.txtCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.txtCODIPROVEE.Text))
                If Me.cbxTIPO_FINANCIAMIENTO.Text <> "" Then ID_CUENTA_FINAN = Me.cbxTIPO_FINANCIAMIENTO.Value
                Me.ucListaCONTRATO_CTAS_PROVI.CargarDatosPorCriterios(Me.cbxZAFRA.Value, Me.cbxTIPO_CONTRIBUYENTE.Value, CODIPROVEE, Me.txtNOMBRE_PROVEEDOR.Text, ID_CUENTA_FINAN)

            Case "EmitirFactura"
                Dim listaProvi As listaCONTRATO_CTAS_PROVI

                listaProvi = Me.ucListaCONTRATO_CTAS_PROVI.DevolverSeleccionados
                If listaProvi.Count = 0 Then
                    AsignarMensaje("Marque los Finaciamientos a Facturar", False, True, True)
                    Return
                End If

                Me.lblpcError.Text = ""
                Me.speNO_DOCTO.Value = Nothing
                Me.pcGenerarFactCCF.ShowOnPageLoad = True

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub

    Protected Sub btnGenerar_Click(sender As Object, e As System.EventArgs) Handles btnGenerar.Click
        Dim listaSeleccionados As listaCONTRATO_CTAS_PROVI
        Dim bFacturaCCFenca As New cFACTURA_SERVICIOS_ENCA
        Dim bFacturaCCFdeta As New cFACTURA_SERVICIOS_DETA
        Dim lFacturaCCFenca As FACTURA_SERVICIOS_ENCA
        Dim lFacturaCCFdeta As FACTURA_SERVICIOS_DETA
        Dim bContratoProvision As New cCONTRATO_CTAS_PROVI
        Dim lSolicAgricola As SOLIC_AGRICOLA
        Dim noDoctoInicial As Int32
        Dim lRet As Int32 = 0

        If Me.speNO_DOCTO.Value Is Nothing OrElse Me.speNO_DOCTO.Value <= 0 Then
            Me.lblpcError.Text = "Numero de factura CCF no valido"
            Return
        End If
        listaSeleccionados = Me.ucListaCONTRATO_CTAS_PROVI.DevolverSeleccionados

        noDoctoInicial = Convert.ToInt32(Me.speNO_DOCTO.Value)

        For Each lProvision As CONTRATO_CTAS_PROVI In listaSeleccionados
            lProvision = (New cCONTRATO_CTAS_PROVI).ObtenerCONTRATO_CTAS_PROVI(lProvision.ID_CONTRATO_CTAS_PROVI)
            If lProvision IsNot Nothing Then
                Dim lCuentaFto As CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(lProvision.ID_CUENTA_FINAN)
                lSolicAgricola = (New cSOLIC_AGRICOLA).ObtenerPorUID(lProvision.UID_SOLICITUD)

                If lSolicAgricola IsNot Nothing Then
                    lFacturaCCFenca = New FACTURA_SERVICIOS_ENCA
                    lFacturaCCFenca.ID_FACTURA_SERVICIOS_ENCA = 0
                    lFacturaCCFenca.NO_DOCTO = noDoctoInicial
                    If lSolicAgricola.TIPO_CONTRIBUYENTE = 0 Then
                        'Factura
                        lFacturaCCFenca.TIPO_DOCTO = "FAC"
                    ElseIf lSolicAgricola.TIPO_CONTRIBUYENTE = 1 OrElse lSolicAgricola.TIPO_CONTRIBUYENTE = 2 Then
                        'CCF
                        lFacturaCCFenca.TIPO_DOCTO = "CCF"
                    End If
                    lFacturaCCFenca.FECHA_EMISION = cFechaHora.ObtenerFecha
                    lFacturaCCFenca.ESTADO = "E"
                    lFacturaCCFenca.CODICONTRATO = lSolicAgricola.CODICONTRATO
                    lFacturaCCFenca.CODIPROVEEDOR = lSolicAgricola.CODIPROVEEDOR
                    lFacturaCCFenca.NOMBRE_PROVEEDOR = lSolicAgricola.NOMBRE_PROVEEDOR
                    lFacturaCCFenca.GIRO = lSolicAgricola.ACTIVIDAD
                    lFacturaCCFenca.DIRECCION = "-"
                    lFacturaCCFenca.DUI = lSolicAgricola.DUI
                    lFacturaCCFenca.NIT = lSolicAgricola.NIT
                    lFacturaCCFenca.NRC = lSolicAgricola.NRC
                    lFacturaCCFenca.EXENTO = 0
                    lFacturaCCFenca.AFECTO = lProvision.PROVISION
                    lFacturaCCFenca.PORC_DESCUENTO = lCuentaFto.PORC_SUBSIDIO
                    lFacturaCCFenca.DESCUENTO = Math.Round(lProvision.PROVISION * lCuentaFto.PORC_SUBSIDIO, 2)
                    lFacturaCCFenca.SUMAS = lProvision.PROVISION - lFacturaCCFenca.DESCUENTO
                    lFacturaCCFenca.IVA = Math.Round(lFacturaCCFenca.SUMAS * Utilerias.TasaIva, 2)
                    lFacturaCCFenca.TOTAL = lFacturaCCFenca.SUMAS + lFacturaCCFenca.IVA
                    lFacturaCCFenca.CANT_LETRAS = cUtilidades.ConvertirNumeroaLetras(lFacturaCCFenca.TOTAL, "DOLARES")
                    lFacturaCCFenca.ID_ZAFRA = lProvision.ID_ZAFRA
                    lFacturaCCFenca.ZAFRA = lProvision.ZAFRA
                    lFacturaCCFenca.UID_FACTURA_SERVICIOS = Guid.NewGuid
                    lFacturaCCFenca.UID_REFERENCIA = lSolicAgricola.UID_SOLIC_AGRICOLA
                    lFacturaCCFenca.ID_CUENTA_FINAN = lProvision.ID_CUENTA_FINAN
                    lFacturaCCFenca.USUARIO_CREA = Me.ObtenerUsuario
                    lFacturaCCFenca.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lFacturaCCFenca.USUARIO_ACT = Me.ObtenerUsuario
                    lFacturaCCFenca.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    lFacturaCCFenca.USUARIO_ANUL = Nothing
                    lFacturaCCFenca.FECHA_ANUL = Nothing

                    lRet = bFacturaCCFenca.ActualizarFACTURA_SERVICIOS_ENCA(lFacturaCCFenca)
                    If lRet <= 0 Then
                        Me.lblpcError.Text = "Error al generar el encabezado de comprobante No.: " + noDoctoInicial.ToString + " para la descripcion " + lProvision.CONCEPTO
                        Exit Sub
                    End If

                    Select Case lCuentaFto.ID_CUENTA_FINAN
                        Case CuentaFinanciamiento.VuelosAereosMadurantes, CuentaFinanciamiento.VuelosAereosInhibidores
                            Dim lVuelos As listaSOLIC_APLICA_VUELO = (New cSOLIC_APLICA_VUELO).ObtenerListaPorSOLIC_AGRICOLA(lSolicAgricola.ID_SOLICITUD)

                            If lVuelos IsNot Nothing AndAlso lVuelos.Count > 0 Then
                                lFacturaCCFdeta = New FACTURA_SERVICIOS_DETA

                                lFacturaCCFdeta.ID_FACTURA_SERVICIOS_DETA = 0
                                lFacturaCCFdeta.ID_FACTURA_SERVICIOS_ENCA = lFacturaCCFenca.ID_FACTURA_SERVICIOS_ENCA
                                lFacturaCCFdeta.DESCRIPCION = "VUELO AEREO"
                                lFacturaCCFdeta.CANTIDAD = lVuelos(0).MZ_HORAS_VUELO
                                lFacturaCCFdeta.PRECIO_UNITARIO = lVuelos(0).PRECIO_UNIT_VUELO
                                lFacturaCCFdeta.EXENTO = 0
                                lFacturaCCFdeta.AFECTO = lVuelos(0).PRECIO_TOTAL_VUELO
                                lFacturaCCFdeta.USUARIO_CREA = Me.ObtenerUsuario
                                lFacturaCCFdeta.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                lFacturaCCFdeta.USUARIO_ACT = Me.ObtenerUsuario
                                lFacturaCCFdeta.FECHA_ACT = cFechaHora.ObtenerFechaHora

                                lRet = bFacturaCCFdeta.ActualizarFACTURA_SERVICIOS_DETA(lFacturaCCFdeta)
                                If lRet <= 0 Then
                                    Me.lblpcError.Text = "Error al generar el detalle del documento No.: " + noDoctoInicial.ToString + " para la descripcion " + lProvision.CONCEPTO
                                    Exit Sub
                                End If

                                If lVuelos(0).PRECIO_TOTAL_AGUA > 0 Then
                                    lFacturaCCFdeta = New FACTURA_SERVICIOS_DETA

                                    lFacturaCCFdeta.ID_FACTURA_SERVICIOS_DETA = 0
                                    lFacturaCCFdeta.ID_FACTURA_SERVICIOS_ENCA = lFacturaCCFenca.ID_FACTURA_SERVICIOS_ENCA
                                    lFacturaCCFdeta.DESCRIPCION = "AGUA"
                                    lFacturaCCFdeta.CANTIDAD = lVuelos(0).MZ_REGAR_AGUA
                                    lFacturaCCFdeta.PRECIO_UNITARIO = lVuelos(0).PRECIO_UNIT_AGUA
                                    lFacturaCCFdeta.EXENTO = 0
                                    lFacturaCCFdeta.AFECTO = lVuelos(0).PRECIO_TOTAL_AGUA
                                    lFacturaCCFdeta.USUARIO_CREA = Me.ObtenerUsuario
                                    lFacturaCCFdeta.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                    lFacturaCCFdeta.USUARIO_ACT = Me.ObtenerUsuario
                                    lFacturaCCFdeta.FECHA_ACT = cFechaHora.ObtenerFechaHora

                                    lRet = bFacturaCCFdeta.ActualizarFACTURA_SERVICIOS_DETA(lFacturaCCFdeta)
                                    If lRet <= 0 Then
                                        Me.lblpcError.Text = "Error al generar el detalle del documento No.: " + noDoctoInicial.ToString + " para la descripcion " + lProvision.CONCEPTO
                                        Exit Sub
                                    End If
                                End If
                            End If
                            
                        Case Else
                            'Facturación de productos
                            Dim lSolicProductos As listaSOLIC_AGRICOLA_PRODUCTO = (New cSOLIC_AGRICOLA_PRODUCTO).ObtenerListaPorSOLIC_AGRICOLA(lSolicAgricola.ID_SOLICITUD)

                            If lSolicProductos IsNot Nothing AndAlso lSolicProductos.Count > 0 Then
                                For Each lSProducto As SOLIC_AGRICOLA_PRODUCTO In lSolicProductos
                                    Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(lSProducto.ID_PRODUCTO)
                                    lFacturaCCFdeta = New FACTURA_SERVICIOS_DETA

                                    lFacturaCCFdeta.ID_FACTURA_SERVICIOS_DETA = 0
                                    lFacturaCCFdeta.ID_FACTURA_SERVICIOS_ENCA = lFacturaCCFenca.ID_FACTURA_SERVICIOS_ENCA
                                    lFacturaCCFdeta.DESCRIPCION = lProducto.NOMBRE_PRODUCTO
                                    lFacturaCCFdeta.CANTIDAD = lSProducto.TOTAL_PRODUCTO
                                    lFacturaCCFdeta.PRECIO_UNITARIO = lSProducto.PRECIO_UNITARIO
                                    lFacturaCCFdeta.EXENTO = 0
                                    lFacturaCCFdeta.AFECTO = lSProducto.TOTAL_PRODUCTO
                                    lFacturaCCFdeta.USUARIO_CREA = Me.ObtenerUsuario
                                    lFacturaCCFdeta.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                    lFacturaCCFdeta.USUARIO_ACT = Me.ObtenerUsuario
                                    lFacturaCCFdeta.FECHA_ACT = cFechaHora.ObtenerFechaHora

                                    lRet = bFacturaCCFdeta.ActualizarFACTURA_SERVICIOS_DETA(lFacturaCCFdeta)
                                    If lRet <= 0 Then
                                        Me.lblpcError.Text = "Error al generar el detalle del documento No.: " + noDoctoInicial.ToString + " para la descripcion " + lProvision.CONCEPTO
                                        Exit Sub
                                    End If
                                Next
                            End If
                    End Select

                    '*************************************************************************************
                    'Descargar de la cuenta de provision y cargar a cuentas de financiamiento del contrato
                    '*************************************************************************************
                    bContratoProvision.EliminarCONTRATO_CTAS_PROVI(lProvision.ID_CONTRATO_CTAS_PROVI)

                    Dim lContratoCtas As CONTRATO_CTAS
                    Dim bContratoCtas As New cCONTRATO_CTAS
                    Dim lContratoCtasMovtos As CONTRATO_CTAS_MOVTOS
                    Dim bContratoCtasMovtos As New cCONTRATO_CTAS_MOVTOS
                    Dim lContratoFinan As CONTRATO_FINAN = (New cCONTRATO_FINAN).ObtenerPorZAFRA_CONTRATO(lProvision.ID_ZAFRA, lProvision.CODICONTRATO)

                    If lContratoFinan IsNot Nothing Then
                        lContratoCtas = New CONTRATO_CTAS
                        lContratoCtas.ID_CONTRATO_CTAS = 0
                        lContratoCtas.ID_CONTRATO_FINAN = lContratoFinan.ID_CONTRATO_FINAN
                        lContratoCtas.CODICONTRATO = lFacturaCCFenca.CODICONTRATO
                        lContratoCtas.ID_ZAFRA = lFacturaCCFenca.ID_ZAFRA
                        lContratoCtas.ID_CUENTA_FINAN = lFacturaCCFenca.ID_CUENTA_FINAN
                        lContratoCtas.NO_DOCTO_REFERENCIA = lFacturaCCFenca.NO_DOCTO
                        lContratoCtas.UID_REFERENCIA = lFacturaCCFenca.UID_FACTURA_SERVICIOS
                        lContratoCtas.CARGO = 0
                        lContratoCtas.ABONO = 0
                        lContratoCtas.SALDO = 0
                        lContratoCtas.ZAFRA = lFacturaCCFenca.ZAFRA
                        lContratoCtas.USUARIO_CREA = Me.ObtenerUsuario
                        lContratoCtas.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lContratoCtas.USUARIO_ACT = Me.ObtenerUsuario
                        lContratoCtas.FECHA_ACT = cFechaHora.ObtenerFechaHora

                        lRet = bContratoCtas.ActualizarCONTRATO_CTAS(lContratoCtas)
                        If lRet <= 0 Then
                            Me.lblpcError.Text = "Error al generar el cargo para el documento No.: " + noDoctoInicial.ToString + " para la descripcion " + lProvision.CONCEPTO
                            Exit Sub
                        End If

                        lContratoCtasMovtos = New CONTRATO_CTAS_MOVTOS
                        lContratoCtasMovtos.ID_CONTRATO_CTAS_MOVTOS = 0
                        lContratoCtasMovtos.ID_CONTRATO_CTAS = lContratoCtas.ID_CONTRATO_CTAS
                        lContratoCtasMovtos.CODICONTRATO = lFacturaCCFenca.CODICONTRATO
                        lContratoCtasMovtos.ID_ZAFRA = lFacturaCCFenca.ID_ZAFRA
                        lContratoCtasMovtos.FECHA_APLICA = lFacturaCCFenca.FECHA_EMISION
                        lContratoCtasMovtos.CONCEPTO = 0
                        lContratoCtasMovtos.CARGO = lFacturaCCFenca.TOTAL
                        lContratoCtasMovtos.ABONO = 0
                        lContratoCtasMovtos.UID_REFERENCIA = lFacturaCCFenca.UID_FACTURA_SERVICIOS
                        lContratoCtasMovtos.ZAFRA = lProvision.ZAFRA
                        lContratoCtasMovtos.USUARIO_CREA = Me.ObtenerUsuario
                        lContratoCtasMovtos.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lContratoCtasMovtos.USUARIO_ACT = Me.ObtenerUsuario
                        lContratoCtasMovtos.FECHA_ACT = cFechaHora.ObtenerFechaHora

                        lRet = bContratoCtasMovtos.ActualizarCONTRATO_CTAS_MOVTOS(lContratoCtasMovtos)
                        If lRet <= 0 Then
                            Me.lblpcError.Text = "Error al generar el detalle de movimiento para el documento No.: " + noDoctoInicial.ToString + " para la descripcion " + lProvision.CONCEPTO
                            Exit Sub
                        End If
                    End If
                End If
            End If

            noDoctoInicial += 1
        Next

        Me.pcGenerarFactCCF.ShowOnPageLoad = False
        Me.ucListaCONTRATO_CTAS_PROVI.DataBind()
        AsignarMensaje("La generacion de documentos de facturacion se genero con exito", False, True, True)
    End Sub
End Class
