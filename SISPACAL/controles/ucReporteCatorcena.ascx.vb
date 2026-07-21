Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.RL
Imports SISPACAL.DL
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.Common
Imports System.Data
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports System.Collections.Generic

Partial Class controles_ucReporteCatorcena
    Inherits ucBase
    Dim reporte As ReportDocument
    Dim ds As DS_DS1
    Dim dsCatorcena As DS_CATORCENA
    Dim dsComprobantes As DS_COMPROBANTES


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        Else
            'If Me.ucCriterios1.ES_POSTBACK Then Exit Sub
            MostrarReporte()
        End If
    End Sub

    Private Property ID_REPORTE As Integer
        Get
            If Me.ViewState("ID_REPORTE") Is Nothing Then
                Return 0
            Else
                Return Me.ViewState("ID_REPORTE")
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("ID_REPORTE") = value
        End Set
    End Property

    Private Property PARAMETRO As Integer
        Get
            If Me.ViewState("PARAMETRO") Is Nothing Then
                Return 0
            Else
                Return Me.ViewState("PARAMETRO")
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("PARAMETRO") = value
        End Set
    End Property

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("VerReporte", "Ver reporte", False, IconoBarra.Reporte, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("VerReporte", True)
        Me.ucBarraNavegacion1.CargarOpciones()

        If Me.Request.QueryString("n").ToString <> "" AndAlso IsNumeric(Me.Request.QueryString("n").ToString) Then
            Me.ID_REPORTE = Convert.ToInt32(Me.Request.QueryString("n").ToString)
        Else
            Me.ID_REPORTE = 0
        End If

        Select Case Me.ID_REPORTE
            Case 1
                Dim listaCampos As New List(Of CampoOrdenamiento)
                Me.lblTitulo.Text = "REPORTE: Calculo de Azucar y Pago"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerES_ANTICIPO = True
                Me.ucCriterios1.VerORDENAMIENTO = True

                listaCampos.Add(New CampoOrdenamiento("CODIPROVEE", "CODIGO"))
                listaCampos.Add(New CampoOrdenamiento("NOMBRE_PROVEEDOR", "NOMBRE"))
                listaCampos.Add(New CampoOrdenamiento("REND_CATORCENA", "RENDIMIENTO"))
                listaCampos.Add(New CampoOrdenamiento("PAGO_AZUCAR_CATORCENA", "PAGO US$"))
                Me.ucCriterios1.AsignarCamposOrdenamiento(listaCampos)
            Case 2
                Me.lblTitulo.Text = "REPORTE: Resumen Diario de Materia Prima"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerCODICOOPERATIVA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
            Case 3
                Me.lblTitulo.Text = "REPORTE: Rendimiento por Agrónomo"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
            Case 4
                Me.lblTitulo.Text = "REPORTE: Resumen Flete"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
            Case 5
                Me.lblTitulo.Text = "REPORTE: Detalle Transporte/Cañero"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
                Me.ucCriterios1.VerDETALLE_LA_CABANA = True
            Case 6
                Me.lblTitulo.Text = "REPORTE: Resumen revisión Flete/Cliente"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerCODICOOPERATIVA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
                Me.ucCriterios1.VerDETALLE_LA_CABANA = True
            Case 7
                Me.lblTitulo.Text = "REPORTE: Resumen Roza por Cañero"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerCODICOOPERATIVA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
            Case 8
                Me.lblTitulo.Text = "REPORTE: Resumen Roza por Provedor Roza"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
            Case 9
                Me.lblTitulo.Text = "REPORTE: Resumen de cargado por Cargadora/Cañero"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
            Case 10
                Me.lblTitulo.Text = "REPORTE: Resume de cargado por Cañero/Cargadora"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerCODICOOPERATIVA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
            Case 11
                'Catorcena - Planilla (8)
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
                Me.ucCriterios1.VerTIPO_PAGO = True
            Case 12
                Me.lblTitulo.Text = "REPORTE: Descuentos de planilla"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
            Case 13
                Me.lblTitulo.Text = "REPORTE: Comprobante Retención"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
            Case 14
                Me.lblTitulo.Text = "REPORTE: Constancia de Renta"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False
            Case 15
                Me.lblTitulo.Text = "REPORTE: Hoja de Liquidación"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
            Case 16
                Me.lblTitulo.Text = "REPORTE: Listado de Cheques"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
            Case 17
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Salir", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()

                Me.lblTitulo.Text = "REPORTE: Emision de Cheques"
                Me.ucCriterios1.Visible = False
                If Me.ID_REPORTE = 17 Then
                    If Me.Request.QueryString("idgen").ToString <> "" Then
                        Me.PARAMETRO = Convert.ToInt32(Me.Request.QueryString("idgen").ToString)
                    End If
                Else
                    If Me.Request.QueryString("idplan").ToString <> "" Then
                        Me.PARAMETRO = Convert.ToInt32(Me.Request.QueryString("idplan").ToString)
                    End If
                End If
                MostrarReporte()
            Case 18
                Me.lblTitulo.Text = "REPORTE: Operadores por Cargadora y Cosechadora"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
            Case 19
                Me.lblTitulo.Text = "REPORTE: Descuentos de Catorcena"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False

            Case 20
                Me.lblTitulo.Text = "REPORTE: Comprobantes de Ley"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
                Me.ucCriterios1.VerTIPO_DOCUMENTO = True
                Me.ucCriterios1.VerNO_DOCUMENTO_RET_FAC_CCF = True
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False

            Case 21
                Me.lblTitulo.Text = "REPORTE: Inconsistencia de Cierre Catorcena"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerCORTE_CATORCENA = True
                Me.ucCriterios1.VerFECHA_PROGRAMACION_CORTE = True

            Case 22
                Me.lblTitulo.Text = "REPORTE: Proveedores sin Cuenta Contable Asignada"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True

            Case 23
                Me.lblTitulo.Text = "REPORTE: Operadores por Cargadora y Cosechadora"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerTIPO_TARIFA_CARGADORA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True

            Case 24
                Me.lblTitulo.Text = "REPORTE: Entrega de Caña por Catorcena-Cañeros"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerCODISOCIO = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True

            Case 25
                Me.lblTitulo.Text = "REPORTE: Entrega de Caña por Catorcena-Transportistas"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerCODTRANSPORT = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True

            Case 26
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Salir", False, "../Imagenes/Salir.png")
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()

                Me.lblTitulo.Text = "REPORTE: Emision de Cheques"
                Me.ucCriterios1.Visible = False
                If Me.ID_REPORTE = 26 Then
                    If Me.Request.QueryString("idgen").ToString <> "" Then
                        Me.PARAMETRO = Convert.ToInt32(Me.Request.QueryString("idgen").ToString)
                    End If
                Else
                    If Me.Request.QueryString("idplan").ToString <> "" Then
                        Me.PARAMETRO = Convert.ToInt32(Me.Request.QueryString("idplan").ToString)
                    End If
                End If
                MostrarReporte()

            Case 27
                Me.lblTitulo.Text = "REPORTE: Entrega Transportista Descuento Diesel"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerCODTRANSPORT = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True

            Case 28
                Dim listaCampos As New List(Of CampoOrdenamiento)
                Me.lblTitulo.Text = "REPORTE: RENDIMIENTO EN LIBRAS POR TONELADA DE CAÑA - PRODUCTOR"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerES_ANTICIPO = False
                Me.ucCriterios1.VerORDENAMIENTO = True

                listaCampos.Add(New CampoOrdenamiento("CODIPROVEE", "CODIGO"))
                listaCampos.Add(New CampoOrdenamiento("NOMBRE_PROVEEDOR", "NOMBRE"))
                listaCampos.Add(New CampoOrdenamiento("REND_CATORCENA", "RENDIMIENTO"))
                Me.ucCriterios1.AsignarCamposOrdenamiento(listaCampos)

            Case 29
                Me.lblTitulo.Text = "REPORTE: Resumen revisión Flete/Cliente x Lote"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerCODICOOPERATIVA = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True

            Case 30
                Me.lblTitulo.Text = "REPORTE: RESUMEN CARGADO DE AUTO VOLTEO"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerCODICOOPERATIVA = False
                Me.ucCriterios1.VerDETALLE_PAGINA = True

            Case 31
                Me.lblTitulo.Text = "REPORTE: Hoja de Liquidación del ingenio"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True

            Case 32
                Me.lblTitulo.Text = "REPORTE: Resumen Roza por Provedor Roza"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerPROVEEDOR_ROZA = True
                Me.ucCriterios1.VerRANGO_DIAS_ZAFRA_DESCRIP = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
        End Select
    End Sub

    Private Sub MostrarReporte()
        Try
            Select Case Me.ID_REPORTE
                Case 1
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_DS1.CALCULO_AZUCAR_PAGODataTable
                    Dim adapter As New DS_DS1TableAdapters.CALCULO_AZUCAR_PAGOTableAdapter


                    Dim campoOrden As FieldDefinition
                    Select Case Me.ucCriterios1.TIPO_PLANILLA
                        Case 0
                            If Me.ucCriterios1.ID_CATORCENA = -1 Then
                                reporte = New CalculoAzucarPagoAnticipo
                                adapter.FillPorZafra(dt, Me.ucCriterios1.ID_ZAFRA)
                            Else
                                reporte = New CalculoAzucarPago
                                adapter.FillPorCatorcena(dt, Me.ucCriterios1.ID_CATORCENA)
                            End If
                        Case 1
                            reporte = New CalculoAzucarPagoAnticipo
                            adapter.FillPorAnticipo(dt, Me.ucCriterios1.ID_CATORCENA)
                        Case 2
                            reporte = New CalculoAzucarPagoValorFinal
                            adapter.FillPorComplementoVFP(dt, Me.ucCriterios1.ID_CATORCENA)
                        Case 3
                            reporte = New CalculoAzucarPagoIncentivo
                            adapter.FillPorIncentivo(dt, Me.ucCriterios1.ID_CATORCENA)
                    End Select
                    ds = New DS_DS1
                    ds.Tables("CALCULO_AZUCAR_PAGO").Merge(dt)

                    campoOrden = reporte.Database.Tables.Item(0).Fields.Item(Me.ucCriterios1.CAMPO_ORDEN)
                    reporte.DataDefinition.SortFields.Item(0).Field = campoOrden
                    If Me.ucCriterios1.TIPO_ORDEN = SortOrder.Ascending Then
                        reporte.DataDefinition.SortFields.Item(0).SortDirection = CrystalDecisions.Shared.SortDirection.AscendingOrder
                    ElseIf Me.ucCriterios1.TIPO_ORDEN = SortOrder.Descending Then
                        reporte.DataDefinition.SortFields.Item(0).SortDirection = CrystalDecisions.Shared.SortDirection.DescendingOrder
                    End If
                    reporte.SetDataSource(ds)

                Case 2
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_DIARIO_INGRESO_MATERIADataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_DIARIO_INGRESO_MATERIATableAdapter
                    reporte = New ResumenDiarioIngresoMateriaPrima
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/ResumenDiarioIngresoMateriaPrima.rpt"))
                    If Me.ucCriterios1.CODICOOPERATIVA <> "" Then
                        adapter.FillPorCooperativa(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODICOOPERATIVA.Trim)
                    Else
                        adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    End If
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_DIARIO_INGRESO_MATERIA").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 3
                    Dim lCatorcena As CATORCENA_ZAFRA
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    lCatorcena = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.ucCriterios1.ID_CATORCENA)
                    Dim dt As New DS_CATORCENA.RENDIMIENTO_CLIENTE_POR_AGRONOMODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RENDIMIENTO_CLIENTE_POR_AGRONOMOTableAdapter
                    reporte = New RendimientosClientesPorAgronomo
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/RendimientosClientesPorAgronomo.rpt"))
                    adapter.Fill(dt, lCatorcena.CATORCENA, Me.ucCriterios1.ID_ZAFRA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RENDIMIENTO_CLIENTE_POR_AGRONOMO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 4
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_FLETE_TRANSPORTISTADataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_FLETE_TRANSPORTISTATableAdapter
                    reporte = New ResumenFleteDeTransportista
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/ResumenFleteDeTransportista.rpt"))
                    adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_FLETE_TRANSPORTISTA").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)

                Case 5
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.DETA_TRANSPORTE_CANERODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.DETA_TRANSPORTE_CANEROTableAdapter
                    reporte = New DetalleTransporteCaneroParaTrasnportista
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/DetalleTransporteCaneroParaTrasnportista.rpt"))
                    If Me.ucCriterios1.DETALLE_LA_CABANA Then
                        adapter.FillPorCatorcenaIngCabana(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    Else
                        adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    End If
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("DETA_TRANSPORTE_CANERO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 6
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.DETA_TRANSPORTE_CANERODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.DETA_TRANSPORTE_CANEROTableAdapter
                    reporte = New ResumenRevisionFleteClienteTransporte
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/ResumenRevisionFleteClienteTransporte.rpt"))
                    If Me.ucCriterios1.DETALLE_LA_CABANA Then
                        adapter.FillPorCatorcenaIngCabana(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    Else
                        If Me.ucCriterios1.CODICOOPERATIVA <> "" Then
                            adapter.FillPorCooperativa(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODICOOPERATIVA.Trim)
                        Else
                            adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                        End If
                    End If

                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("DETA_TRANSPORTE_CANERO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 7
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_ROZA_CANERODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_ROZA_CANEROTableAdapter
                    reporte = New ResumenRozaPorCanero
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/ResumenRozaPorCanero.rpt"))
                    If Me.ucCriterios1.CODICOOPERATIVA <> "" Then
                        adapter.FillPorCooperativa(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODICOOPERATIVA.Trim)
                    Else
                        adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    End If
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_ROZA_CANERO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 8
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_PROVEEDORROZA_CANERODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_PROVEEDORROZA_CANEROTableAdapter
                    reporte = New ResumenRozaPorProveedorRoza
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/ResumenRozaPorProveedorRoza.rpt"))
                    adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_PROVEEDORROZA_CANERO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 9
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_CARGADO_POR_CARGADORADataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_CARGADO_POR_CARGADORATableAdapter
                    reporte = New ResumenCargadoPorCargadoraCanero
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/ResumenCargadoPorCargadoraCanero.rpt"))
                    adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_CARGADO_POR_CARGADORA").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 10
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_CARGADO_POR_CANERODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_CARGADO_POR_CANEROTableAdapter
                    reporte = New ResumenCargadoPorCaneroCargadora
                    'reporte.Load(Server.MapPath("../Reportes/Catorcena/ResumenCargadoPorCaneroCargadora.rpt"))
                    If Me.ucCriterios1.CODICOOPERATIVA <> "" Then
                        adapter.FillPorCooperativa(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODICOOPERATIVA.Trim)
                    Else
                        adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    End If
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_CARGADO_POR_CANERO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 11
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PLANILLA) Then
                        Me.AsignarMensaje("* Seleccione el tipo de planilla", True)
                        Return
                    End If
                    Dim dt As New DS_DS1.PlanillaDataTable
                    Dim adapter As New DS_DS1TableAdapters.PlanillaTableAdapter
                    Select Case Me.ucCriterios1.ID_TIPO_PLANILLA
                        Case Enumeradores.TipoPlanilla.Cañeros
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New PlanillaCanerosContribuyentes
                            Else
                                reporte = New PlanillaCanerosNoContribuyentes
                            End If
                        Case Enumeradores.TipoPlanilla.Transportistas
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New PlanillaTransportistasContribuyentes
                            Else
                                reporte = New PlanillaTransportistasNoContribuyentes
                            End If
                        Case Enumeradores.TipoPlanilla.FrenteRozaParticular
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New PlanillaRozaContribuyentes
                            Else
                                reporte = New PlanillaRozaNoContribuyentes
                            End If
                        Case Enumeradores.TipoPlanilla.Cargadoras
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New PlanillaCargadorasContribuyentes
                            Else
                                reporte = New PlanillaCanerosNoContribuyentes
                            End If
                        Case Enumeradores.TipoPlanilla.AnticipoCaneros
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New PlanillaAnticipoCanerosContribuyentes
                            Else
                                reporte = New PlanillaAnticipoCanerosNoContribuyentes
                            End If
                        Case Enumeradores.TipoPlanilla.ComplementoValorFinalPago
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New PlanillaComplementoVFPCanerosContribuyentes
                            Else
                                reporte = New PlanillaComplementoVFPCanerosNoContribuyentes
                            End If
                        Case Enumeradores.TipoPlanilla.CompensacionEntregaCana
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New PlanillaCompensacionCanerosContribuyentes
                            Else
                                reporte = New PlanillaCompensacionCanerosNoContribuyentes
                            End If
                    End Select
                    If Me.ucCriterios1.ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.AnticipoCaneros Then
                        adapter.FillParaAnticipo(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE, Me.ucCriterios1.ID_TIPO_PLANILLA)
                    ElseIf Me.ucCriterios1.ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoValorFinalPago Then
                        adapter.FillParaComplementoVFP(dt, Me.ucCriterios1.TIPO_PAGO, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE, Me.ucCriterios1.ID_TIPO_PLANILLA)
                    ElseIf Me.ucCriterios1.ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.CompensacionEntregaCana Then
                        adapter.FillPorPlanillaBase(dt, Me.ucCriterios1.TIPO_PAGO, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE, Me.ucCriterios1.ID_TIPO_PLANILLA, Me.ucCriterios1.ID_RANGO_COMPE)
                    Else
                        adapter.FillPorCatorcena(dt, Me.ucCriterios1.TIPO_PAGO, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE, Me.ucCriterios1.ID_TIPO_PLANILLA)
                    End If
                    ds = New DS_DS1
                    ds.Tables("PLANILLA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 14
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PLANILLA) Then
                        Me.AsignarMensaje("* Seleccione el tipo de planilla", True)
                        Return
                    End If

                    Select Case Me.ucCriterios1.ID_TIPO_PLANILLA
                        Case Enumeradores.TipoPlanilla.Transportistas, Enumeradores.TipoPlanilla.ComplementoTransportistas
                            Dim dt As New DS_CATORCENA.CONSTANCIA_RETENCIONDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.CONSTANCIA_RETENCIONTableAdapter
                            reporte = New ConstanciaRetencionRenta
                            adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("CONSTANCIA_RETENCION").Merge(dt)
                            reporte.SetDataSource(dsCatorcena)

                        Case Enumeradores.TipoPlanilla.IncentivoProductores
                            Dim dt As New DS_CATORCENA.CONSTANCIA_RETENCIONDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.CONSTANCIA_RETENCIONTableAdapter
                            reporte = New ConstanciaRetencionRentaIncentivo
                            adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("CONSTANCIA_RETENCION").Merge(dt)
                            reporte.SetDataSource(dsCatorcena)
                    End Select

                Case 15
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PLANILLA) Then
                        Me.AsignarMensaje("* Seleccione el tipo de planilla", True)
                        Return
                    End If
                    Select Case Me.ucCriterios1.ID_TIPO_PLANILLA
                        Case Enumeradores.TipoPlanilla.Cañeros
                            Dim dt As New DS_CATORCENA.LIQUIDACION_CANEROSDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_CANEROSTableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionCaneroContribuyente
                            Else
                                reporte = New HojaLiquidacionCaneroNoContribuyente
                            End If
                            adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_CANEROS").Merge(dt)
                        Case Enumeradores.TipoPlanilla.Transportistas
                            Dim dt As New DS_CATORCENA.LIQUIDACION_TRANSPORTISTASDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_TRANSPORTISTASTableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionTransportistaContribuyente
                            Else
                                reporte = New HojaLiquidacionTransportistaNoContribuyente
                            End If
                            adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_TRANSPORTISTAS").Merge(dt)
                        Case Enumeradores.TipoPlanilla.ComplementoTransportistas
                            Dim dt As New DS_CATORCENA.LIQUIDACION_TRANSPORTISTASDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_TRANSPORTISTASTableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionTransportistaContribuyente
                            Else
                                reporte = New HojaLiquidacionTransportistaNoContribuyente
                            End If
                            adapter.FillPorTipoPlanilla(dt, Enumeradores.TipoPlanilla.ComplementoTransportistas, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_TRANSPORTISTAS").Merge(dt)
                        Case Enumeradores.TipoPlanilla.FrenteRozaParticular
                            Dim dt As New DS_CATORCENA.LIQUIDACION_PROVEEDORES_ROZADataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_PROVEEDORES_ROZATableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionProveedorRozaContribuyente
                            Else
                                reporte = New HojaLiquidacionProveedorRozaNoContribuyente
                            End If
                            adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_PROVEEDORES_ROZA").Merge(dt)
                        Case Enumeradores.TipoPlanilla.Cargadoras
                            Dim dt As New DS_CATORCENA.LIQUIDACION_CARGADORASDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_CARGADORASTableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionCargadoraContribuyente
                            Else
                                reporte = New HojaLiquidacionCargadoraNoContribuyente
                            End If
                            adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_CARGADORAS").Merge(dt)
                        Case Enumeradores.TipoPlanilla.AnticipoCaneros
                            Dim dt As New DS_CATORCENA.LIQUIDACION_CANEROSDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_CANEROSTableAdapter

                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                If Me.ucCriterios1.ID_CATORCENA = 21 Then
                                    reporte = New HojaLiquidacionAnticipoCaneroContribuyente01A
                                Else
                                    reporte = New HojaLiquidacionAnticipoCaneroContribuyente
                                End If
                            Else
                                If Me.ucCriterios1.ID_CATORCENA = 21 Then
                                    reporte = New HojaLiquidacionAnticipoCaneroNoContribuyente01A
                                Else
                                    reporte = New HojaLiquidacionAnticipoCaneroNoContribuyente
                                End If
                            End If
                            adapter.FillPorAnticipo(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_CANEROS").Merge(dt)
                        Case Enumeradores.TipoPlanilla.ComplementoValorFinalPago
                            Dim dt As New DS_CATORCENA.LIQUIDACION_CANEROSDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_CANEROSTableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionComplementoVFPCaneroContribuyente
                            Else
                                reporte = New HojaLiquidacionComplementoVFPCaneroNoContribuyente
                            End If
                            adapter.FillPorComplementoVFP(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_CANEROS").Merge(dt)
                        Case Enumeradores.TipoPlanilla.ComplementoVFP_Adicional
                            Dim dt As New DS_CATORCENA.LIQUIDACION_CANEROSDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_CANEROSTableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionComplementoVFP_Adicional_CaneroContribuyente
                            Else
                                reporte = New HojaLiquidacionComplementoVFP_Adicional_CaneroNoContribuyente
                            End If
                            adapter.FillPorComplementoVFP_Adicional(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_CANEROS").Merge(dt)
                        Case Enumeradores.TipoPlanilla.CompensacionEntregaCana
                            Dim dt As New DS_CATORCENA.LIQUIDACION_CANEROSDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_CANEROSTableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionCompensacionCaneroContribuyente
                            Else
                                reporte = New HojaLiquidacionCompensacionCaneroNoContribuyente
                            End If
                            If Me.ucCriterios1.ID_RANGO_COMPE > 0 Then
                                adapter.FillPorPlanillaBase(dt, Enumeradores.TipoPlanilla.CompensacionEntregaCana, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE, Me.ucCriterios1.ID_RANGO_COMPE)
                                dsCatorcena = New DS_CATORCENA
                                dsCatorcena.Tables("LIQUIDACION_CANEROS").Merge(dt)
                            Else
                                Return
                            End If
                        Case Enumeradores.TipoPlanilla.IncentivoProductores
                            Dim dt As New DS_CATORCENA.LIQUIDACION_CANEROSDataTable
                            Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_CANEROSTableAdapter
                            If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                                reporte = New HojaLiquidacionIncentivoCaneroContribuyente
                            Else
                                reporte = New HojaLiquidacionIncentivoCaneroNoContribuyente
                            End If
                            adapter.FillPorIncentivo(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                            dsCatorcena = New DS_CATORCENA
                            dsCatorcena.Tables("LIQUIDACION_CANEROS").Merge(dt)

                    End Select
                    reporte.SetDataSource(dsCatorcena)

                Case 16
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PLANILLA) Then
                        Me.AsignarMensaje("* Seleccione el tipo de planilla", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.LISTADO_CHEQUES_PLANILLADataTable
                    Dim adapter As New DS_CATORCENATableAdapters.LISTADO_CHEQUES_PLANILLATableAdapter
                    reporte = New ListadoCheques
                    adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, Me.ucCriterios1.ES_CONTRIBUYENTE)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("LISTADO_CHEQUES_PLANILLA").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)

                Case 17
                    Dim dt As New DS_CATORCENA.CHEQUESDataTable
                    Dim adapter As New DS_CATORCENATableAdapters.CHEQUESTableAdapter
                    reporte = New Cheques
                    adapter.Fill(dt, Me.PARAMETRO)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("CHEQUES").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)

                Case 18
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.OPERADORES_CARGADORA_COSEDataTable
                    Dim adapter As New DS_CATORCENATableAdapters.OPERADORES_CARGADORA_COSETableAdapter
                    reporte = New OperadoresCargadoraCosechadora
                    adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("OPERADORES_CARGADORA_COSE").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)

                Case 19
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PLANILLA) Then
                        Me.AsignarMensaje("* Seleccione el tipo de planilla", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.DESCUENTOSDataTable
                    Dim adapter As New DS_CATORCENATableAdapters.DESCUENTOSTableAdapter
                    Select Case Me.ucCriterios1.ID_TIPO_PLANILLA
                        Case Enumeradores.TipoPlanilla.Cañeros, Enumeradores.TipoPlanilla.AnticipoCaneros,
                             Enumeradores.TipoPlanilla.ComplementoValorFinalPago
                            reporte = New DescuentosCanero
                        Case Enumeradores.TipoPlanilla.Transportistas
                            reporte = New DescuentosTransportista
                        Case Enumeradores.TipoPlanilla.FrenteRozaParticular
                            reporte = New DescuentosProveedorRoza
                    End Select
                    adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("DESCUENTOS").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 20
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PLANILLA) Then
                        Me.AsignarMensaje("* Seleccione el tipo de planilla", True)
                        Return
                    End If
                    If ucCriterios1.NO_DOCUMENTO_INICIAL = "" Then
                        Me.AsignarMensaje("* Ingrese el numero inicial de comprobante", True)
                        Return
                    End If
                    If Not Utilerias.EsNumeroEntero(ucCriterios1.NO_DOCUMENTO_INICIAL) Then
                        Me.AsignarMensaje("* El numero de comprobante debe ser un numero entero", True)
                        Return
                    End If
                    Select Case Me.ucCriterios1.TIPO_DOCUMENTO
                        Case 1 'Comprobante de retención 1%
                            Dim dt As New DS_COMPROBANTES.COMPROBANTE_RETENCIONDataTable
                            Dim adapter As New DS_COMPROBANTESTableAdapters.COMPROBANTE_RETENCIONTableAdapter
                            reporte = New ComprobanteRetencion
                            If Not ucCriterios1.ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.AnticipoCaneros Then
                                adapter.Fill(dt, 1, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, -1, -1, -1)
                            Else
                                adapter.FillPorAnticipo(dt, 1, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, -1, -1, -1)
                            End If
                            dsComprobantes = New DS_COMPROBANTES
                            dsComprobantes.Tables("COMPROBANTE_RETENCION").Merge(dt)
                        Case 2 'Comprobante de retención NO CONTRIBUYENTES
                            Dim dt As New DS_COMPROBANTES.COMPROBANTE_RETENCIONDataTable
                            Dim adapter As New DS_COMPROBANTESTableAdapters.COMPROBANTE_RETENCIONTableAdapter
                            reporte = New ComprobanteRetencion
                            If Not ucCriterios1.ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.AnticipoCaneros Then
                                adapter.Fill(dt, 2, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, -1, -1, -1)
                            Else
                                adapter.FillPorAnticipo(dt, 2, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, -1, -1, -1)
                            End If
                            dsComprobantes = New DS_COMPROBANTES
                            dsComprobantes.Tables("COMPROBANTE_RETENCION").Merge(dt)
                        Case 3 'Comprobante de credito fiscal
                            Dim dt As New DS_COMPROBANTES.FACTURACION_SERVICIOS_DEL__INGENIODataTable
                            Dim adapter As New DS_COMPROBANTESTableAdapters.FACTURACION_SERVICIOS_DEL__INGENIOTableAdapter
                            reporte = New CreditoFiscalServiciosIngenio
                            adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, 1, -1, -1, -1)
                            dsComprobantes = New DS_COMPROBANTES
                            dsComprobantes.Tables("FACTURACION_SERVICIOS_DEL _INGENIO").Merge(dt)
                        Case 4 'Factura
                            Dim dt As New DS_COMPROBANTES.FACTURACION_SERVICIOS_DEL__INGENIODataTable
                            Dim adapter As New DS_COMPROBANTESTableAdapters.FACTURACION_SERVICIOS_DEL__INGENIOTableAdapter
                            reporte = New FacturaServiciosIngenio
                            adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, 0, -1, -1, -1)
                            dsComprobantes = New DS_COMPROBANTES
                            dsComprobantes.Tables("FACTURACION_SERVICIOS_DEL _INGENIO").Merge(dt)
                    End Select
                    reporte.SetDataSource(dsComprobantes)

                Case 21
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If Me.ucCriterios1.CORTE_CATORCENA = "" Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_PROGRAMACION_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha/hora de corte", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.INCONSISTENCIAS_ENVIOSDataTable
                    Dim adapter As New DS_CATORCENATableAdapters.INCONSISTENCIAS_ENVIOSTableAdapter
                    reporte = New InconsistenciaEnvios
                    adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, CInt(Me.ucCriterios1.CORTE_CATORCENA), Me.ucCriterios1.FECHA_PROGRAMACION_CORTE)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("INCONSISTENCIAS_ENVIOS").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("pCorte", CInt(Me.ucCriterios1.CORTE_CATORCENA))
                    reporte.SetParameterValue("pFechaCorte", Me.ucCriterios1.FECHA_PROGRAMACION_CORTE)

                Case 22
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.PROVEEDOR_SIN_CUENTA_CONTABLEDataTable
                    Dim adapter As New DS_CATORCENATableAdapters.PROVEEDOR_SIN_CUENTA_CONTABLETableAdapter
                    reporte = New ProveedorSinCuentaContable
                    adapter.Fill(dt, Me.ucCriterios1.ID_CATORCENA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("PROVEEDOR_SIN_CUENTA_CONTABLE").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)

                Case 23
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_CARGADO_POR_CARGADORADataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_CARGADO_POR_CARGADORATableAdapter
                    reporte = New ResumenCargadoTipoTarifaPorCargadoraCanero
                    adapter.FillPorTipoTarifa(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.TIPO_TARIFA_CARGADORA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_CARGADO_POR_CARGADORA").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 24
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESUMEN_PAGO_CANEROS_ZAFRADataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESUMEN_PAGO_CANEROS_ZAFRATableAdapter
                    reporte = New ResumenPagoCanerosZafra
                    adapter.Fill(dt, Me.ucCriterios1.CODIPROVEEDOR, Me.ucCriterios1.CODISOCIO, Me.ucCriterios1.ID_ZAFRA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESUMEN_PAGO_CANEROS_ZAFRA").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 25
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESUMEN_PAGO_TRANSPORTISTAS_ZAFRADataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESUMEN_PAGO_TRANSPORTISTAS_ZAFRATableAdapter
                    Dim iCodTransport As Int32
                    reporte = New ResumenPagoTransportistasZafra
                    If Me.ucCriterios1.CODTRANSPORT = "" Then iCodTransport = -1 Else iCodTransport = Convert.ToInt32(Me.ucCriterios1.CODTRANSPORT)
                    adapter.Fill(dt, iCodTransport, Me.ucCriterios1.ID_ZAFRA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESUMEN_PAGO_TRANSPORTISTAS_ZAFRA").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 26
                    Dim dt As New DS_CATORCENA.CHEQUESDataTable
                    Dim adapter As New DS_CATORCENATableAdapters.CHEQUESTableAdapter
                    reporte = New Cheques
                    adapter.FillPorAnticipo(dt, Me.PARAMETRO)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("CHEQUES").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)

                Case 27
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESUMEN_PAGO_TRANSPORTISTAS_ZAFRADataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESUMEN_PAGO_TRANSPORTISTAS_ZAFRATableAdapter
                    Dim iCodTransport As Int32
                    reporte = New ResumenPagoTransportistasZafraDesctoDiesel
                    If Me.ucCriterios1.CODTRANSPORT = "" Then iCodTransport = -1 Else iCodTransport = Convert.ToInt32(Me.ucCriterios1.CODTRANSPORT)
                    adapter.Fill(dt, iCodTransport, Me.ucCriterios1.ID_ZAFRA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESUMEN_PAGO_TRANSPORTISTAS_ZAFRA").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 28
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_DS1.CALCULO_AZUCAR_PAGODataTable
                    Dim adapter As New DS_DS1TableAdapters.CALCULO_AZUCAR_PAGOTableAdapter


                    Dim campoOrden As FieldDefinition

                    reporte = New CalculoAzucarFabrica
                    adapter.FillPorCatorcena(dt, Me.ucCriterios1.ID_CATORCENA)

                    ds = New DS_DS1
                    ds.Tables("CALCULO_AZUCAR_PAGO").Merge(dt)

                    campoOrden = reporte.Database.Tables.Item(0).Fields.Item(Me.ucCriterios1.CAMPO_ORDEN)
                    reporte.DataDefinition.SortFields.Item(0).Field = campoOrden
                    If Me.ucCriterios1.TIPO_ORDEN = SortOrder.Ascending Then
                        reporte.DataDefinition.SortFields.Item(0).SortDirection = CrystalDecisions.Shared.SortDirection.AscendingOrder
                    ElseIf Me.ucCriterios1.TIPO_ORDEN = SortOrder.Descending Then
                        reporte.DataDefinition.SortFields.Item(0).SortDirection = CrystalDecisions.Shared.SortDirection.DescendingOrder
                    End If
                    reporte.SetDataSource(ds)

                Case 29
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.DETA_TRANSPORTE_CANERODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.DETA_TRANSPORTE_CANEROTableAdapter
                    reporte = New ResumenRevisionFleteClienteLoteTransporte
                    If Me.ucCriterios1.CODICOOPERATIVA <> "" Then
                        adapter.FillPorCooperativa(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODICOOPERATIVA.Trim)
                    Else
                        adapter.Fill(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    End If
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("DETA_TRANSPORTE_CANERO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 30
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_CARGADO_POR_CANERODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_CARGADO_POR_CANEROTableAdapter
                    reporte = New ResumenCargadoPorTransportistaCargadoraVolteo
                    adapter.FillTransportista(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.ID_CATORCENA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_CARGADO_POR_CANERO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 31
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PLANILLA) Then
                        Me.AsignarMensaje("* Seleccione el tipo de planilla", True)
                        Return
                    End If

                    Dim dt As New DS_CATORCENA.LIQUIDACION_CANEROSDataTable
                    Dim adapter As New DS_CATORCENATableAdapters.LIQUIDACION_CANEROSTableAdapter
                    If Me.ucCriterios1.ES_CONTRIBUYENTE Then
                        reporte = New HojaLiquidacionCaneroContribuyente
                    Else
                        reporte = New HojaLiquidacionCaneroNoContribuyente
                    End If
                    adapter.FillIngenio(dt, Me.ucCriterios1.ID_TIPO_PLANILLA, Me.ucCriterios1.ID_CATORCENA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("LIQUIDACION_CANEROS").Merge(dt)

                    reporte.SetDataSource(dsCatorcena)

                Case 32
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.DIA_ZAFRA_A) Then
                        Me.AsignarMensaje("* Seleccione el dia zafra inicial", True)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.DIA_ZAFRA_B) Then
                        Me.AsignarMensaje("* Seleccione el dia zafra final", True)
                        Return
                    End If
                    Dim dt As New DS_CATORCENA.RESU_PROVEEDORROZA_CANERODataTable
                    Dim adapter As New DS_CATORCENATableAdapters.RESU_PROVEEDORROZA_CANEROTableAdapter
                    reporte = New ResumenRozaPorProveedorRoza
                    adapter.FillPorDiaZafra(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.DIA_ZAFRA_A, Me.ucCriterios1.DIA_ZAFRA_B, Me.ucCriterios1.ID_PROVEEDOR_ROZA)
                    dsCatorcena = New DS_CATORCENA
                    dsCatorcena.Tables("RESU_PROVEEDORROZA_CANERO").Merge(dt)
                    reporte.SetDataSource(dsCatorcena)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)
            End Select
            'reporte.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Context.Response, False, "")
            crvReportes.ReportSource = reporte

        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            Me.AsignarMensaje("", True, False)
            MostrarReporte()
        End If
        If CommandName = "CerrarVentana" Then
            Dim strscript As String = "<script language=javascript>window.top.close();</script>"
            If Not Page.ClientScript.IsStartupScriptRegistered("clientScript") Then
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "clientScript", strscript)
            End If
        End If
    End Sub

    Protected Sub Page_Unload(sender As Object, e As System.EventArgs) Handles Me.Unload
        LiberarReporte(reporte)
    End Sub

    Private Sub LiberarReporte(ByRef rc As ReportDocument)
        If Not rc Is Nothing Then
            rc.Close()
            rc.Dispose()
            rc = Nothing
        End If
        crvReportes.Dispose()
        crvReportes.ReportSource = Nothing
        GC.Collect()
    End Sub

End Class

