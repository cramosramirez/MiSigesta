Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.RL
Imports SISPACAL.DL
Imports System.Data.Common
Imports System.Data
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Collections.Generic


Partial Class controles_ucReporte
    Inherits ucBase
    Dim reporte As ReportDocument
    Dim ds As DS_DS1

    Private Property PARAMETROS As Dictionary(Of String, Object)
        Get
            If Me.ViewState("PARAMETROS") Is Nothing Then
                Return Nothing
            Else
                Return Me.ViewState("PARAMETROS")
            End If
        End Get
        Set(value As Dictionary(Of String, Object))
            Me.ViewState("PARAMETROS") = value
        End Set
    End Property

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        Else
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
        Set(value As Integer)
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
        Set(value As Integer)
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
            Case 1    'Recibo de entrega de caña
                Me.lblTitulo.Text = "REPORTE: Recibo de entrega de caña"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerNROBOLETA = True
            Case 2    'Diario - Resultados análisis de caña Proveedor
                Me.lblTitulo.Text = "REPORTE: Resultados laboratorio caña por Proveedor"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
            Case 3    'Diario - Entrega de caña en báscula
                Me.lblTitulo.Text = "REPORTE: Entrega de caña en báscula"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_ENTRADA_INICIAL = True
                Me.ucCriterios1.VerFECHA_ENTRADA_FINAL = True
            Case 4    'Diario - Rendimiento teóricos ponderados
                Me.lblTitulo.Text = "REPORTE: Rendimiento teóricos ponderados"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
            Case 5    'Análisis de muestras de cosecha
                Me.lblTitulo.Text = "REPORTE: Análisis de muestras de envios"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_ENTRADA_INICIAL = True
                Me.ucCriterios1.VerFECHA_ENTRADA_FINAL = True
            Case 6    'Redimiento por Agrónomo
                Me.lblTitulo.Text = "REPORTE: Redimiento por Agronomo"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
                Me.ucCriterios1.VerCODIAGRON = True
            Case 7    'Cosecha diaria por Agrónomo
                Me.lblTitulo.Text = "REPORTE: Cosecha diaria por Agronomo"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
                Me.ucCriterios1.VerCODIAGRON = True
            Case 8    'Catorcena - Planilla
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
            Case 9   'Programación Catorcenal de entrega de caña
                Me.lblTitulo.Text = "REPORTE: Programación Catorcenal de entrega de caña"
                Me.ucCriterios1.VerID_PLAN_CATORCENA = True
                Me.ucCriterios1.VerID_PLAN_SEMANAL = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
            Case 10   'Programación Catorcenal de entrega de caña
                Me.lblTitulo.Text = "REPORTE: Rendimiento teóricos ponderados acumulado"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
            Case 11, 111   'Orden de Roza
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Salir", False, "../Imagenes/Salir.png")
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()

                Me.lblTitulo.Text = "REPORTE: Orden de Roza"
                Me.ucCriterios1.Visible = False
                If Me.ID_REPORTE = 11 Then
                    If Me.Request.QueryString("idgen").ToString <> "" Then
                        Me.PARAMETRO = Convert.ToInt32(Me.Request.QueryString("idgen").ToString)
                    End If
                Else
                    If Me.Request.QueryString("idplan").ToString <> "" Then
                        Me.PARAMETRO = Convert.ToInt32(Me.Request.QueryString("idplan").ToString)
                    End If
                End If
                MostrarReporte()

            Case 12   'Orden de Combustible
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Salir", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()

                Me.lblTitulo.Text = "REPORTE: Orden de Combustible"
                Me.ucCriterios1.Visible = False
                If Me.ID_REPORTE = 12 Then
                    If Me.Request.QueryString("oc").ToString <> "" Then
                        Me.PARAMETRO = Convert.ToInt32(Me.Request.QueryString("oc").ToString)
                    End If
                End If
                MostrarReporte()

            Case 13    'Diario - Entrega de caña en báscula
                Me.lblTitulo.Text = "REPORTE: Entrega de caña en báscula - Corte"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True

            Case 14    'Muestras de Laboratorio - CONSAA
                Me.lblTitulo.Text = "REPORTE: Muestras de Laboratorio"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True

            Case 15    'Entrega de caña - CONSAA
                Me.lblTitulo.Text = "REPORTE: Entrega de Caña por proveedor"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_INICIAL = True
                Me.ucCriterios1.VerFECHA_FINAL = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerCODISOCIO = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True

            Case 16
                Me.lblTitulo.Text = "REPORTE: Reporte General de Combustible y otros suministros facturados"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerFECHA_INICIAL = True
                Me.ucCriterios1.VerFECHA_FINAL = True
                Me.ucCriterios1.VerFECHAS_EMISION_FACTURACION = True
                Me.ucCriterios1.VerMOSTRAR_FAC_CCF = True
                Me.ucCriterios1.VerCODIGO_CLIENTE = True
                Me.ucCriterios1.VerPLACA = True
                Me.ucCriterios1.ID_CATORCENA = -1

            Case 17
                Me.lblTitulo.Text = "REPORTE: Reporte de Combustible facturado a transportistas, cañeros e INJIBOA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PROVEEDOR = True
                Me.ucCriterios1.VerFECHA_INICIAL = True
                Me.ucCriterios1.VerFECHA_FINAL = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
                Me.ucCriterios1.VerCODIGO_CLIENTE = True
                Me.ucCriterios1.VerPLACA = True
                Me.ucCriterios1.ID_CATORCENA = -1

            Case 18
                Dim listaCampos As New List(Of CampoOrdenamiento)
                Me.lblTitulo.Text = "REPORTE: Caña contratada - caña entregada"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerCLASIFICACION = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
                listaCampos.Add(New CampoOrdenamiento("CODIPROVEEDOR", "PROVEEDOR"))
                listaCampos.Add(New CampoOrdenamiento("ZONA", "ZONA"))
                Me.ucCriterios1.AsignarClasificacion(listaCampos)

            Case 19
                Me.lblTitulo.Text = "REPORTE: Movimientos de Caña - Lote Contratado"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True

            Case 20
                Me.lblTitulo.Text = "REPORTE: Movimientos de Caña - Totales por Contrato"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True

            Case 21
                Me.lblTitulo.Text = "REPORTE: Entrega de Caña Catorcenal por Lote"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerFECHA_CORTE = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerDETALLE_PAGINA = True
        End Select
    End Sub

    Private Sub MostrarReporte()
        Try
            If PARAMETROS Is Nothing Then Return

            Select Case Me.ID_REPORTE
                Case 1
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.NROBOLETA < 0 Then
                        Me.AsignarMensaje("* Ingrese el número de boleta", True, False)
                        Return
                    End If
                    Dim listaEnvios As listaENVIO = (New cENVIO).ObtenerListaPorBOLETA(Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.NROBOLETA)
                    If listaEnvios IsNot Nothing AndAlso listaEnvios.Count > 0 Then
                        Dim dt As New DS_DS1.RECIBO_CANADataTable
                        Dim adapter As New DS_DS1TableAdapters.RECIBO_CANATableAdapter
                        reporte = New ReciboCana

                        adapter.FillPorENVIO(dt, listaEnvios(0).ID_ENVIO)
                        ds = New DS_DS1
                        ds.Tables("RECIBO_CANA").Merge(dt)
                        reporte.SetDataSource(ds)
                    End If
                Case 2
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.V_LABORA_PAGO_CALIDAD01DataTable
                    Dim adapter As New DS_DS1TableAdapters.V_LABORA_PAGO_CALIDAD01TableAdapter
                    reporte = New ResultadoCorteDiarioProveedor

                    If Me.ucCriterios1.CODIPROVEEDOR <> "" Then
                        adapter.FillPorFechaCorteProveedor(dt, Me.ucCriterios1.FECHA_CORTE, Me.ucCriterios1.CODIPROVEEDOR)
                    Else
                        adapter.FillPorFechaCorte(dt, Me.ucCriterios1.FECHA_CORTE)
                    End If
                    ds = New DS_DS1
                    ds.Tables("V_LABORA_PAGO_CALIDAD01").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 3
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_ENTRADA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha/hora inicial", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_ENTRADA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha/hora final", True, False)
                        Return
                    End If
                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.ucCriterios1.FECHA_CORTE)
                    Dim dt As New DS_DS1.ENTREGA_CANA_BASCULADataTable
                    Dim adapter As New DS_DS1TableAdapters.ENTREGA_CANA_BASCULATableAdapter
                    reporte = New EntregaCanaBascula

                    Dim dtSubRepo As New DS_DS1.InconsistenciasEnviosDiaZafraDataTable
                    Dim adapterSubRepo As New DS_DS1TableAdapters.InconsistenciasEnviosDiaZafraTableAdapter


                    'Verificar si la fecha ingresada corresponde a la fecha de corte
                    'If lDiaZafra IsNot Nothing AndAlso lDiaZafra.ID_DIA_ZAFRA > 0 Then
                    '    adapter.FillPorFechaCorte(dt, Me.ucCriterios1.FECHA_CORTE)
                    '    adapterSubRepo.FillPorFechaCorte(dtSubRepo, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.FECHA_CORTE)
                    'Else
                    '    adapter.FillPorFechaCortePendiente(dt, Me.ucCriterios1.FECHA_CORTE)
                    '    adapterSubRepo.Fill(dtSubRepo, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.FECHA_CORTE)
                    'End If
                    adapter.FillPorRangoFecha(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.FECHA_ENTRADA_INICIAL, Me.ucCriterios1.FECHA_ENTRADA_FINAL)
                    adapterSubRepo.FillPorRangoFecha(dtSubRepo, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.FECHA_ENTRADA_INICIAL, Me.ucCriterios1.FECHA_ENTRADA_FINAL)
                    ds = New DS_DS1
                    ds.Tables("ENTREGA_CANA_BASCULA").Merge(dt)
                    ds.Tables("InconsistenciasEnviosDiaZafra").Merge(dtSubRepo)
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    reporte.SetDataSource(ds)
                    reporte.Subreports(0).SetDataSource(ds)
                    reporte.SetParameterValue("NombreZafra", lZafra.NOMBRE_ZAFRA)
                    reporte.SetParameterValue("FechaInicial", Me.ucCriterios1.FECHA_ENTRADA_INICIAL)
                    reporte.SetParameterValue("FechaFinal", Me.ucCriterios1.FECHA_ENTRADA_FINAL)


                Case 4
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.RPT_COSECHA_DIA_EFICIENCIA85DataTable
                    Dim adapter As New DS_DS1TableAdapters.RPT_COSECHA_DIA_EFICIENCIA85TableAdapter
                    reporte = New RendimientoTeoricoPonderado

                    adapter.FillPorFechaCorte(dt, Me.ucCriterios1.FECHA_CORTE)
                    ds = New DS_DS1
                    ds.Tables("RPT_COSECHA_DIA_EFICIENCIA85").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 5
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_ENTRADA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha/hora inicial", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_ENTRADA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha/hora final", True, False)
                        Return
                    End If

                    Dim dt As New DS_DS1.V_LABORA_PAGO_CALIDAD01DataTable
                    Dim adapter As New DS_DS1TableAdapters.V_LABORA_PAGO_CALIDAD01TableAdapter
                    reporte = New LaboratorioPagoCalidad01

                    adapter.FillPorFechaEntrega(dt, Me.ucCriterios1.FECHA_ENTRADA_INICIAL, Me.ucCriterios1.FECHA_ENTRADA_FINAL)
                    ds = New DS_DS1
                    ds.Tables("V_LABORA_PAGO_CALIDAD01").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 6
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.RENDIMIENTO_POR_AGRONOMODataTable
                    Dim adapter As New DS_DS1TableAdapters.RENDIMIENTO_POR_AGRONOMOTableAdapter
                    reporte = New RendimientoClientePorAgronomo

                    If Me.ucCriterios1.CODIAGRON <> "" Then
                        adapter.FillRendFechaCorteAgronomo(dt, Me.ucCriterios1.FECHA_CORTE, Me.ucCriterios1.CODIAGRON)
                    Else
                        adapter.FillRendPorFecha(dt, Me.ucCriterios1.FECHA_CORTE)
                    End If
                    ds = New DS_DS1
                    ds.Tables("RENDIMIENTO_POR_AGRONOMO").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 7
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.RPT_COSECHA_DIARIADataTable
                    Dim adapter As New DS_DS1TableAdapters.RPT_COSECHA_DIARIATableAdapter
                    reporte = New CosechaDiariaPorAgronomo

                    If Me.ucCriterios1.CODIAGRON <> "" Then
                        adapter.FillPorFechaAgronomo(dt, Me.ucCriterios1.CODIAGRON, Me.ucCriterios1.FECHA_CORTE)
                    Else
                        adapter.FillPorDiaZafra(dt, Me.ucCriterios1.FECHA_CORTE)
                    End If
                    ds = New DS_DS1
                    ds.Tables("RPT_COSECHA_DIARIA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 8
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True, False)
                        Return
                    End If
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PLANILLA) Then
                        Me.AsignarMensaje("* Seleccione el tipo de planilla", True, False)
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
                                reporte = New PlanillaCargadorasNoContribuyentes
                            End If
                    End Select
                    adapter.FillPorCatorcena(dt, Me.ucCriterios1.TIPO_PAGO, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ES_CONTRIBUYENTE, Me.ucCriterios1.ID_TIPO_PLANILLA)
                    ds = New DS_DS1
                    ds.Tables("PLANILLA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 9
                    If IsDBNull(Me.ucCriterios1.ID_PLAN_CATORCENA) Then
                        Me.AsignarMensaje("* Seleccione la catorcena", True, False)
                        Return
                    End If
                    Dim idPlanCatorcena As Integer = Me.ucCriterios1.ID_PLAN_CATORCENA
                    Dim zona As String = ""
                    Dim codiProveedor As String = ""
                    Dim idPlanSemanal As Integer = -1

                    If Me.ucCriterios1.ZONA IsNot Nothing AndAlso Me.ucCriterios1.ZONA <> "" Then
                        zona = Me.ucCriterios1.ZONA
                    End If
                    If Me.ucCriterios1.CODIPROVEEDOR IsNot Nothing AndAlso Me.ucCriterios1.CODIPROVEEDOR <> "" Then
                        codiProveedor = Me.ucCriterios1.CODIPROVEEDOR
                    End If
                    If Not IsDBNull(Me.ucCriterios1.ID_PLAN_SEMANAL) AndAlso Me.ucCriterios1.ID_PLAN_SEMANAL > 0 Then
                        idPlanSemanal = Me.ucCriterios1.ID_PLAN_SEMANAL
                    End If
                    Dim dt As New DS_DS1.PROGRAMA_ENTREGA_CANADataTable
                    Dim adapter As New DS_DS1TableAdapters.PROGRAMA_ENTREGA_CANATableAdapter
                    reporte = New ProgramacionEntregaCana

                    adapter.FillPorCriterios(dt, zona, idPlanCatorcena, codiProveedor, "", idPlanSemanal)
                    ds = New DS_DS1
                    ds.Tables("PROGRAMA_ENTREGA_CANA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 10
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.RENDIMIENTO_TEORICO_POND_CATORCENADataTable
                    Dim adapter As New DS_DS1TableAdapters.RENDIMIENTO_TEORICO_POND_CATORCENATableAdapter
                    reporte = New RendimientoTeoricoPonderadoCatorcena

                    adapter.FillPorFECHA_CORTE(dt, Me.ucCriterios1.FECHA_CORTE.ToString("dd/MM/yyyy"))
                    ds = New DS_DS1
                    ds.Tables("RENDIMIENTO_TEORICO_POND_CATORCENA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 11, 111
                    Dim dt As New DS_DS1.ORDEN_ROZADataTable
                    Dim adapter As New DS_DS1TableAdapters.ORDEN_ROZATableAdapter
                    reporte = New OrdenRoza

                    Select Case Me.ID_REPORTE
                        Case 11
                            adapter.FillPorID_GENERACION(dt, Me.PARAMETRO)
                        Case 111
                            adapter.FillPorID_PLAN_ENTREGA(dt, Me.PARAMETRO)
                    End Select
                    ds = New DS_DS1
                    ds.Tables("ORDEN_ROZA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 12
                    Dim dt As New DS_DS1.ORDEN_COMBUSTIBLEDataTable
                    Dim adapter As New DS_DS1TableAdapters.ORDEN_COMBUSTIBLETableAdapter
                    reporte = New OrdenCombustible

                    adapter.FillPorORDEN_COMBUS(dt, Me.PARAMETRO)
                    ds = New DS_DS1
                    ds.Tables("ORDEN_COMBUSTIBLE").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 13
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.ucCriterios1.FECHA_CORTE)

                    Dim dt As New DS_DS1.ENTREGA_CANA_BASCULADataTable
                    Dim adapter As New DS_DS1TableAdapters.ENTREGA_CANA_BASCULATableAdapter
                    reporte = New EntregaCanaBascula02

                    Dim dtSubRepo As New DS_DS1.InconsistenciasEnviosDiaZafraDataTable
                    Dim adapterSubRepo As New DS_DS1TableAdapters.InconsistenciasEnviosDiaZafraTableAdapter

                    'Verificar si la fecha ingresada corresponde a la fecha de corte
                    If lDiaZafra IsNot Nothing AndAlso lDiaZafra.ID_DIA_ZAFRA > 0 Then
                        adapter.FillPorFechaCorte(dt, Me.ucCriterios1.FECHA_CORTE)
                        adapterSubRepo.FillPorFechaCorte(dtSubRepo, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.FECHA_CORTE)
                    Else
                        adapter.FillPorFechaCortePendiente(dt, Me.ucCriterios1.FECHA_CORTE)
                        adapterSubRepo.Fill(dtSubRepo, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.FECHA_CORTE)
                    End If
                    ds = New DS_DS1
                    ds.Tables("ENTREGA_CANA_BASCULA").Merge(dt)
                    ds.Tables("InconsistenciasEnviosDiaZafra").Merge(dtSubRepo)
                    reporte.SetDataSource(ds)
                    reporte.Subreports(0).SetDataSource(ds)

                Case 14
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.RPT_COSECHA_DIARIADataTable
                    Dim adapter As New DS_DS1TableAdapters.RPT_COSECHA_DIARIATableAdapter
                    reporte = New MuestrasLaboratorio

                    adapter.FillPorDiaZafra(dt, Me.ucCriterios1.FECHA_CORTE)
                    ds = New DS_DS1
                    ds.Tables("RPT_COSECHA_DIARIA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 15
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha inicial", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha final", True, False)
                        Return
                    End If

                    Dim dt As New DS_DS1.RPT_ENTREGA_CANA_CONSAADataTable
                    Dim adapter As New DS_DS1TableAdapters.RPT_ENTREGA_CANA_CONSAATableAdapter
                    reporte = New EntregaCanaCONSAA
                    adapter.Fill(dt, Me.ucCriterios1.FECHA_INICIAL, Me.ucCriterios1.FECHA_FINAL, Me.ucCriterios1.CODIPROVEEDOR, Me.ucCriterios1.CODISOCIO)
                    ds = New DS_DS1
                    ds.Tables("RPT_ENTREGA_CANA_CONSAA").Merge(dt)
                    reporte.SetDataSource(ds)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 16
                    If Me.ucCriterios1.ID_CATORCENA > 0 AndAlso (Me.ucCriterios1.FECHA_INICIAL <> #12:00:00 AM# OrElse Me.ucCriterios1.FECHA_FINAL <> #12:00:00 AM#) Then
                        Me.AsignarMensaje("* No puede ver el reporte por Catorcena y periodo a la vez.<br/>  Para filtrar por catorcena: Seleccione la catorcena y borre las fechas inicial y final<br/> Para filtrar por periodo: Seleccione la catorcena '[SIN CATORCENA]' e ingrese el periodo fecha inicial y final", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.ORDEN_COMBUSTIBLE_LISTADataTable
                    Dim adapter As New DS_DS1TableAdapters.ORDEN_COMBUSTIBLE_LISTATableAdapter
                    Dim sTitulo As String = ""
                    Select Case Me.ucCriterios1.FORMATO_VALES
                        Case 0
                            reporte = New OrdenCombustibleLista
                        Case 1
                            reporte = New OrdenCombustibleListaTipoProveedor
                        Case 2
                            reporte = New OrdenCombustibleListaProducto
                        Case 3
                            reporte = New OrdenCombustibleListaPlaca
                    End Select
                    If Me.ucCriterios1.FECHA_INICIAL = #12:00:00 AM# Then
                        adapter.FillPorCriterios(dt, Me.ucCriterios1.ID_ZAFRA, "", "", "", "", Me.ucCriterios1.CON_FAC_CCF, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODIGO_CLIENTE, -1, Me.ucCriterios1.PLACA)
                        If Me.ucCriterios1.ID_CATORCENA > 0 Then sTitulo = "CORTE # " + (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.ucCriterios1.ID_CATORCENA).CATORCENA.ToString
                    Else
                        If Me.ucCriterios1.FECHA_EMISION_FACTURACION = 1 Then
                            'Emision
                            adapter.FillPorCriterios(dt, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.FECHA_INICIAL.ToString("dd/MM/yyyy"), Me.ucCriterios1.FECHA_FINAL.ToString("dd/MM/yyyy"), "", "", Me.ucCriterios1.CON_FAC_CCF, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODIGO_CLIENTE, -1, Me.ucCriterios1.PLACA)
                            sTitulo = "VALES EMITIDOS DEL " + Me.ucCriterios1.FECHA_INICIAL.ToString("dd/MM/yyyy") + " AL " + Me.ucCriterios1.FECHA_FINAL.ToString("dd/MM/yyyy")
                        Else
                            'Facturacion
                            adapter.FillPorCriterios(dt, Me.ucCriterios1.ID_ZAFRA, "", "", Me.ucCriterios1.FECHA_INICIAL.ToString("dd/MM/yyyy"), Me.ucCriterios1.FECHA_FINAL.ToString("dd/MM/yyyy"), Me.ucCriterios1.CON_FAC_CCF, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODIGO_CLIENTE, -1, Me.ucCriterios1.PLACA)
                            sTitulo = "VALES FACTURADOS DEL " + Me.ucCriterios1.FECHA_INICIAL.ToString("dd/MM/yyyy") + " AL " + Me.ucCriterios1.FECHA_FINAL.ToString("dd/MM/yyyy")
                        End If
                    End If
                    ds = New DS_DS1
                    ds.Tables("ORDEN_COMBUSTIBLE_LISTA").Merge(dt)
                    reporte.SetDataSource(ds)
                    reporte.SetParameterValue("titulo", sTitulo)

                Case 17
                    If IsDBNull(Me.ucCriterios1.ID_TIPO_PROVEEDOR) Then
                        Me.AsignarMensaje("* Seleccione el Tipo de Proveedor", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CATORCENA > 0 AndAlso (Me.ucCriterios1.FECHA_INICIAL <> #12:00:00 AM# OrElse Me.ucCriterios1.FECHA_FINAL <> #12:00:00 AM#) Then
                        Me.AsignarMensaje("* No puede ver el reporte por Catorcena y periodo a la vez.<br/>  Para filtrar por catorcena: Seleccione la catorcena y borre las fechas inicial y final<br/> Para filtrar por periodo: Seleccione la catorcena '[SIN CATORCENA]' e ingrese el periodo fecha inicial y final", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.ORDEN_COMBUSTIBLE_PROVEEDORDataTable
                    Dim adapter As New DS_DS1TableAdapters.ORDEN_COMBUSTIBLE_PROVEEDORTableAdapter
                    Dim sTitulo As String = ""
                    Dim sPeriodo As String = ""
                    reporte = New OrdenCombustiblePorProveedor
                    Select Case Me.ucCriterios1.ID_TIPO_PROVEEDOR
                        Case Enumeradores.TipoProveedor.Cañero, Enumeradores.TipoProveedor.Transportista
                            If Me.ucCriterios1.FECHA_INICIAL = #12:00:00 AM# Then
                                adapter.FillPorCriterios(dt, Me.ucCriterios1.ID_ZAFRA, "", "", "", "", Me.ucCriterios1.ID_TIPO_PROVEEDOR, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODIGO_CLIENTE, 0, Me.ucCriterios1.PLACA)
                                If Me.ucCriterios1.ID_CATORCENA > 0 Then sPeriodo = "CORTE # " + (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.ucCriterios1.ID_CATORCENA).CATORCENA.ToString
                            Else
                                adapter.FillPorCriterios(dt, Me.ucCriterios1.ID_ZAFRA, "", "", Me.ucCriterios1.FECHA_INICIAL.ToString("dd/MM/yyyy"), Me.ucCriterios1.FECHA_FINAL.ToString("dd/MM/yyyy"), Me.ucCriterios1.ID_TIPO_PROVEEDOR, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODIGO_CLIENTE, 0, Me.ucCriterios1.PLACA)
                                sPeriodo = "PERIODO DEL " + Me.ucCriterios1.FECHA_INICIAL.ToString("dd/MM/yyyy") + " AL " + Me.ucCriterios1.FECHA_FINAL.ToString("dd/MM/yyyy")
                            End If
                            If Me.ucCriterios1.ID_TIPO_PROVEEDOR = Enumeradores.TipoProveedor.Cañero Then
                                sTitulo = "DESCUENTO DE COMBUSTIBLE Y OTROS SUMINISTRADOS A PROVEEDORES DE CAÑA"
                            Else
                                sTitulo = "DESCUENTO DE COMBUSTIBLE Y OTROS SUMINISTRADOS A TRANSPORTISTAS"
                            End If
                        Case 300
                            reporte = New OrdenCombustiblePorProveedor
                            If Me.ucCriterios1.FECHA_INICIAL = #12:00:00 AM# Then
                                adapter.FillPorCriterios(dt, Me.ucCriterios1.ID_ZAFRA, "", "", "", "", 2, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODIGO_CLIENTE, 1, Me.ucCriterios1.PLACA)
                                If Me.ucCriterios1.ID_CATORCENA > 0 Then sPeriodo = "CORTE # " + (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.ucCriterios1.ID_CATORCENA).CATORCENA.ToString
                            Else
                                adapter.FillPorCriterios(dt, Me.ucCriterios1.ID_ZAFRA, "", "", Me.ucCriterios1.FECHA_INICIAL.ToString("dd/MM/yyyy"), Me.ucCriterios1.FECHA_FINAL.ToString("dd/MM/yyyy"), 2, Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.CODIGO_CLIENTE, 1, Me.ucCriterios1.PLACA)
                                sPeriodo = "PERIODO DEL " + Me.ucCriterios1.FECHA_INICIAL.ToString("dd/MM/yyyy") + " AL " + Me.ucCriterios1.FECHA_FINAL.ToString("dd/MM/yyyy")
                            End If
                            sTitulo = "COMBUSTIBLE Y OTROS SUMINISTRADOS A INJIBOA"
                    End Select
                    ds = New DS_DS1
                    ds.Tables("ORDEN_COMBUSTIBLE_PROVEEDOR").Merge(dt)
                    reporte.SetDataSource(ds)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)
                    reporte.SetParameterValue("titulo", sTitulo)
                    reporte.SetParameterValue("periodo", sPeriodo)

                Case 18
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.ucCriterios1.FECHA_CORTE)
                    If lDiaZafra Is Nothing Then
                        Me.AsignarMensaje("* La fecha de corte no se encontro en la Zafra seleccionada", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.MOVIMIENTOS_CANA_CONTRATADADataTable
                    Dim adapter As New DS_DS1TableAdapters.MOVIMIENTOS_CANA_CONTRATADATableAdapter

                    adapter.FillTodo(dt, lZafra.NOMBRE_ZAFRA, lDiaZafra.DIAZAFRA, lZafra.ID_ZAFRA, Me.ucCriterios1.CODIPROVEEDOR)
                    ds = New DS_DS1
                    ds.Tables("MOVIMIENTOS_CANA_CONTRATADA").Merge(dt)
                    If Me.ucCriterios1.CLASIFICACION = "CODIPROVEEDOR" Then
                        reporte = New MovimientoCanaContratada01b
                        reporte.SetDataSource(ds)
                    Else
                        reporte = New MovimientoCanaContratada01
                        reporte.SetDataSource(ds)
                    End If
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

                Case 19
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.ucCriterios1.FECHA_CORTE)
                    If lDiaZafra Is Nothing Then
                        Me.AsignarMensaje("* La fecha de corte no se encontro en la Zafra seleccionada", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.MOVIMIENTOS_CANA_CONTRATADADataTable
                    Dim adapter As New DS_DS1TableAdapters.MOVIMIENTOS_CANA_CONTRATADATableAdapter
                    reporte = New MovimientoCanaContratada02
                    adapter.FillTodo(dt, lZafra.NOMBRE_ZAFRA, lDiaZafra.DIAZAFRA, lZafra.ID_ZAFRA, Me.ucCriterios1.CODIPROVEEDOR)
                    ds = New DS_DS1
                    ds.Tables("MOVIMIENTOS_CANA_CONTRATADA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 20
                    If IsDBNull(Me.ucCriterios1.ID_ZAFRA) Then
                        Me.AsignarMensaje("* No existe una zafra activa", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.ucCriterios1.FECHA_CORTE)
                    If lDiaZafra Is Nothing Then
                        Me.AsignarMensaje("* La fecha de corte no se encontro en la Zafra seleccionada", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.MOVIMIENTOS_CANA_CONTRATADADataTable
                    Dim adapter As New DS_DS1TableAdapters.MOVIMIENTOS_CANA_CONTRATADATableAdapter
                    reporte = New MovimientoCanaContratada03
                    adapter.FillTodo(dt, lZafra.NOMBRE_ZAFRA, lDiaZafra.DIAZAFRA, lZafra.ID_ZAFRA, Me.ucCriterios1.CODIPROVEEDOR)
                    ds = New DS_DS1
                    ds.Tables("MOVIMIENTOS_CANA_CONTRATADA").Merge(dt)
                    reporte.SetDataSource(ds)

                Case 21
                    If Me.ucCriterios1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("* Ingrese la fecha de corte", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.CODIPROVEEDOR <> "" AndAlso Not Utilerias.EsNumeroEntero(Me.ucCriterios1.CODIPROVEEDOR) Then
                        Me.AsignarMensaje("* Codigo de proveedor no valido", True, False)
                        Return
                    End If
                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.ucCriterios1.FECHA_CORTE)
                    If lDiaZafra Is Nothing Then
                        Me.AsignarMensaje("* Fecha de corte no existe en el sistema", True, False)
                        Return
                    End If
                    Dim dt As New DS_DS1.ENTREGA_CANA_CATORCENAL_LOTEDataTable
                    Dim adapter As New DS_DS1TableAdapters.ENTREGA_CANA_CATORCENAL_LOTETableAdapter
                    reporte = New EntregaCanaCatorcenalLote
                    adapter.FillPorFechaCorte(dt, Me.ucCriterios1.CODIPROVEEDOR, 0, Me.ucCriterios1.ID_ZAFRA, Me.ucCriterios1.FECHA_CORTE)
                    ds = New DS_DS1
                    ds.Tables("ENTREGA_CANA_CATORCENAL_LOTE").Merge(dt)
                    reporte.SetDataSource(ds)
                    reporte.SetParameterValue("detallePagina", Me.ucCriterios1.DETALLE_POR_PAGINA)

            End Select

            crvReportes.ReportSource = reporte

        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            Me.AsignarMensaje("", True, False)
            Me.PARAMETROS = New Dictionary(Of String, Object)
            Me.PARAMETROS.Add("ES_CARGA_REPORTE", True)
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
