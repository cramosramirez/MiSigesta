Imports SISPACAL.BL
Imports SISPACAL.RL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.EL.Enumeradores

Partial Class controlesBodega_ucReporteBodega
    Inherits ucBase

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

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        Else
            CargarDatosReporte()
        End If
    End Sub

    Private Property PARAMETROS As Dictionary(Of String, String)
        Get
            If Me.ViewState("PARAMETROS") Is Nothing Then
                Return Nothing
            Else
                Return Me.ViewState("PARAMETROS")
            End If
        End Get
        Set(value As Dictionary(Of String, String))
            Me.ViewState("PARAMETROS") = value
        End Set
    End Property

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("VerReporte", "Ver reporte", False, "reports_groupheader_16x16", "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("VerReporte", True)
        Me.ucBarraNavegacion1.CargarOpciones()

        If Me.Request.QueryString("n").ToString <> "" AndAlso IsNumeric(Me.Request.QueryString("n").ToString) Then
            Me.ID_REPORTE = Convert.ToInt32(Me.Request.QueryString("n").ToString)
        Else
            Me.ID_REPORTE = 0
        End If

        Select Case Me.ID_REPORTE
            Case 1
                Me.lblTitulo.Text = "REPORTE DE KARDEX"
                Me.ucCriteriosBodega1.VerZAFRA = True

            Case 2
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = True
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = True
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.lblTitulo.Text = "DETALLE DE FACTURACION DE PRODUCTOS CONSIGNADOS"

            Case 3
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = True
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = True
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.lblTitulo.Text = "APLICACIONES DE VUELO"

            Case 4
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = True
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = True
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.lblTitulo.Text = "APLICACION DE VUELO - SERVICIO DE AGUA"

            Case 5
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.lblTitulo.Text = "ESTADO DE CUENTA DE PRODUCTORES"

            Case 6
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerCATORCENA = True
                Me.ucCriteriosBodega1.VerTIPO_PLANILLA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.lblTitulo.Text = "INTERESES PROVEEDORES AGRICOLAS"

            Case 7
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerCATORCENA = True
                Me.ucCriteriosBodega1.VerTIPO_PLANILLA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.lblTitulo.Text = "INTERESES JIBOA"

            Case 8
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = False
                Me.ucCriteriosBodega1.VerTRANSPORTISTA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO_TRANS = True
                Me.lblTitulo.Text = "ESTADO DE CUENTA DE TRANSPORTISTAS"

            Case 9
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = True
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = True
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.lblTitulo.Text = "DETALLE DE PRODUCTOS SOLICITADOS"

            Case 10
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.lblTitulo.Text = "SALDOS DE FINANCIAMIENTOS DE PRODUCTORES"

            Case 11
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = False
                Me.ucCriteriosBodega1.VerTRANSPORTISTA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA_CREDITO_TRANS = True
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO_TRANS = False
                Me.ucCriteriosBodega1.VerFECHA = True
                Me.ucCriteriosBodega1.FECHA = Today
                Me.lblTitulo.Text = "SALDOS DE FINANCIAMIENTOS DE TRANSPORTISTAS"

            Case 12
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.ucCriteriosBodega1.VerFECHA = True
                Me.ucCriteriosBodega1.FECHA = Today
                Me.lblTitulo.Text = "SALDO ACUMULADO DE FINANCIAMIENTOS DE PRODUCTORES"

            Case 13
                Me.ucCriteriosBodega1.APLICA_PARA_SOLICITUD_AGRICOLA = True
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.ucCriteriosBodega1.VerDETALLE = True
                Me.ucCriteriosBodega1.VerOCULTAR_SIN_SALDO = True
                Me.lblTitulo.Text = "ESTADO DE CUENTA DE PROVEEDORES AGRICOLAS DE PRODUCTORES DE CAÑA"

            Case 14
                Me.ucCriteriosBodega1.APLICA_SOLO_CASA_COMERCIAL = False
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False 'True
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.lblTitulo.Text = "ESTADO DE CUENTA DE PROVEEDORES DE TRANSPORTISTAS"


            Case 15
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = True
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.ucCriteriosBodega1.VerCATORCENA = True
                Me.ucCriteriosBodega1.VerRESUMEN_POR_OPERADOR = True
                Me.ucCriteriosBodega1.PorCorte_y_PorFechas = True
                Me.lblTitulo.Text = "OPERADORES DE TRACTOR POR LOTE"

            Case 16
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.ucCriteriosBodega1.VerTOTAL = True
                Me.lblTitulo.Text = "SALDOS INSOLUTOS POR PRODUCTOR Y TIPO DE FINANCIAMIENTO"

            Case 17
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.lblTitulo.Text = "FICHA TECNICA DE LOTE"

            Case 18
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.ucCriteriosBodega1.VerTOTAL = True
                Me.lblTitulo.Text = "SALDOS INSOLUTOS Y REAL ZAFRA ACTUAL - PRODUCTOR Y TIPO DE FINANCIAMIENTO"

            Case 19
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA_BANCOS = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = True
                Me.lblTitulo.Text = "SALDOS INSOLUTOS Y REAL ZAFRA ACTUAL - PROVEEDOR Y TIPO DE FINANCIAMIENTO"

            Case 20
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.ucCriteriosBodega1.VerZONA = True
                Me.lblTitulo.Text = "ANALISIS DE MUESTRAS DE CAÑA PRECOSECHA POR PRODUCTOR"

            Case 21
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.lblTitulo.Text = "PRODUCTOS EN CONSIGNACION PENDIENTES"

            Case 22
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.ucCriteriosBodega1.VerFECHA = True
                Me.ucCriteriosBodega1.FECHA = Today
                Me.lblTitulo.Text = "RUTA DIARIA DE COSECHA"

            Case 23
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerCATORCENA = True
                Me.ucCriteriosBodega1.VerTIPO_PLANILLA_FRENTES = True
                Me.ucCriteriosBodega1.VerPROVEEDOR = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.ucCriteriosBodega1.VerFECHA = False
                Me.ucCriteriosBodega1.FECHA = Today
                Me.lblTitulo.Text = "LIQUIDACIÓN DE FRENTES DE ROZA Y QUERQUEROS"

            Case 24
                Me.ucCriteriosBodega1.VerBODEGA = False
                Me.ucCriteriosBodega1.VerPRODUCTO = False
                Me.ucCriteriosBodega1.VerZAFRA = True
                Me.ucCriteriosBodega1.VerCATORCENA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_AGRICOLA = False
                Me.ucCriteriosBodega1.VerPROVEEDOR_VUELO = False
                Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
                Me.ucCriteriosBodega1.VerCUENTA_FINANCIAMIENTO = False
                Me.ucCriteriosBodega1.VerFECHA = False
                Me.ucCriteriosBodega1.FECHA = Today
                Me.lblTitulo.Text = "PROYECCION DE RESULTADOS FINANCIEROS - RESUMEN"
        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            Select Case Me.ID_REPORTE
                Case 1
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New Kardex
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("ID_BODEGA"), "", PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("ID_PRODUCTO"), "")
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 2
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New ProductoConsignadoEntregado
                    reporte.Cargar(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("ID_PROVEE"), PARAMETROS("ID_CUENTA_FINAN"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 3
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New AplicacionesVuelo
                    reporte.Cargar(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("ID_PROVEE"), PARAMETROS("ID_CUENTA_FINAN"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 4
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New AplicacionesVueloAgua
                    reporte.Cargar(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("ID_PROVEE"), PARAMETROS("ID_CUENTA_FINAN"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 5
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New EstadoCtaProductor
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("ID_CUENTA_FINAN"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 6
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New InteresProveedorAgricola
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("ID_CUENTA_FINAN"), PARAMETROS("ID_CATORCENA"), PARAMETROS("ID_PROVEE"), PARAMETROS("ID_PLANILLA_BASE"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 7
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New InteresJiboa
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("ID_CATORCENA"), PARAMETROS("ID_PLANILLA_BASE"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 8
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New EstadoCtaTransportista
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODTRANSPORT"), PARAMETROS("ID_CUENTA_FINAN"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 9
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New ProductoSolicitado
                    reporte.Cargar(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("ID_PROVEE"), PARAMETROS("ID_CUENTA_FINAN"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 10
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New SaldosZafraProductores01
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 11
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New SaldosZafraTransportistas
                    Dim fecha As Date
                    Dim anio As Int32 = Convert.ToInt32(Strings.Left(PARAMETROS("FECHA"), 4))
                    Dim mes As Int32 = Convert.ToInt32(Strings.Mid(PARAMETROS("FECHA"), 5, 2))
                    Dim dia As Int32 = Convert.ToInt32(Strings.Right(PARAMETROS("FECHA"), 2))

                    fecha = New DateTime(anio, mes, dia)
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODTRANSPORT"), PARAMETROS("ID_PROVEE"), fecha)
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 12
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New SaldosZafraProductores02
                    Dim fecha As Date
                    Dim anio As Int32 = Convert.ToInt32(Strings.Left(PARAMETROS("FECHA"), 4))
                    Dim mes As Int32 = Convert.ToInt32(Strings.Mid(PARAMETROS("FECHA"), 5, 2))
                    Dim dia As Int32 = Convert.ToInt32(Strings.Right(PARAMETROS("FECHA"), 2))

                    fecha = New DateTime(anio, mes, dia)
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), fecha, PARAMETROS("ID_PROVEE"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 13
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New EstadoCtaProveedorAgricolaProductor
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("ID_CUENTA_FINAN"), PARAMETROS("ID_PROVEE"), PARAMETROS("CODIBANCO"), PARAMETROS("ES_DETALLE"), PARAMETROS("ES_OCULTAR_SIN_SALDO"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 14
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New EstadoCtaProveedorAgricolaTransportista
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("ID_CUENTA_FINAN"), PARAMETROS("ID_PROVEE"), PARAMETROS("CODIBANCO"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)


                Case 15
                    If PARAMETROS Is Nothing Then Return
                    If PARAMETROS("ES_RESUMEN_POR_OPERADOR") = 1 Then
                        Dim reporte As New TractoristasAutoVolteoResumen
                        reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("ID_CATORCENA"), PARAMETROS("FECHA_INICIAL"), PARAMETROS("FECHA_FINAL"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    Else
                        Dim reporte As New TractoristasAutoVolteo
                        reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("ID_CATORCENA"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If


                Case 16
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New SaldosInsolutosPorProveeFinan
                    reporte.Cargar(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("ID_CUENTA_FINAN"), PARAMETROS("ES_TOTAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 17
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New FichaTecnicaLote
                    reporte.CargarDatos(PARAMETROS("CODIPROVEEDOR"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 18
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New SaldosInsolutosPorProveeFinanReal
                    reporte.Cargar(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("ID_CUENTA_FINAN"), PARAMETROS("ES_TOTAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 19
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New SaldosInsolutosPorProveeAgricola
                    reporte.Cargar(PARAMETROS("ID_ZAFRA"), PARAMETROS("ID_PROVEE"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("ID_CUENTA_FINAN"), PARAMETROS("ES_BANCO"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 20
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New AnalisisPrecosechaPorLote
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("ZONA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 21
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New ProductoConsignadoPendiente
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("CODIPROVEEDOR"), PARAMETROS("ID_PROVEE"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 22
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New RutaDiariaCosecha
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("FECHA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 23
                    If PARAMETROS Is Nothing Then Return

                    Select Case CInt(PARAMETROS("ID_TIPO_PLANILLA_FRENTES"))
                        Case SISPACAL.EL.Enumeradores.TipoPlanilla.FrenteRozaParticular, SISPACAL.EL.Enumeradores.TipoPlanilla.FrenteQuerqueoParticular
                            Dim reporte As New HojaLiquidacionFrenteParticular
                            reporte.CargarDatos(PARAMETROS("ID_CATORCENA"), CInt(PARAMETROS("ID_TIPO_PLANILLA_FRENTES")), -1)
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case SISPACAL.EL.Enumeradores.TipoPlanilla.FrenteRozaINJIBOA, SISPACAL.EL.Enumeradores.TipoPlanilla.FrenteQuerqueoINJIBOA
                            Dim reporte As New LiquidacionFrenteQuerqueo
                            reporte.CargarDatos(PARAMETROS("ID_CATORCENA"), CInt(PARAMETROS("ID_TIPO_PLANILLA_FRENTES")), -1)
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select


                Case 24
                    If PARAMETROS Is Nothing Then Return

                    Dim reporte As New Proyeccion_Resumen
                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
            End Select
        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            Me.PARAMETROS = New Dictionary(Of String, String)

            Select Case Me.ID_REPORTE
                Case 1
                    If Me.ucCriteriosBodega1.ID_BODEGA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una bodega", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_BODEGA", Me.ucCriteriosBodega1.ID_BODEGA)
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    Me.PARAMETROS.Add("ID_PRODUCTO", Me.ucCriteriosBodega1.ID_PRODUCTO)
                    If ucCriteriosBodega1.PERIODO = 1 Then
                        Me.PARAMETROS.Add("FECHA1", cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy"))
                        Me.PARAMETROS.Add("FECHA2", "")
                    Else
                        If ucCriteriosBodega1.FECHA_INICIAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Ingrese la fecha inicial del periodo", False, True, True)
                            Return
                        End If
                        If ucCriteriosBodega1.FECHA_FINAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Ingrese la fecha final del periodo", False, True, True)
                            Return
                        End If
                        Me.PARAMETROS.Add("FECHA1", ucCriteriosBodega1.FECHA_INICIAL)
                        Me.PARAMETROS.Add("FECHA2", ucCriteriosBodega1.FECHA_FINAL)
                    End If

                Case 2
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA)
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    If ucCriteriosBodega1.PERIODO = 1 Then
                        Me.PARAMETROS.Add("FECHA1", cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy"))
                        Me.PARAMETROS.Add("FECHA2", "")
                    Else
                        If ucCriteriosBodega1.FECHA_INICIAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Ingrese la fecha inicial del periodo", False, True, True)
                            Return
                        End If
                        If ucCriteriosBodega1.FECHA_FINAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Ingrese la fecha final del periodo", False, True, True)
                            Return
                        End If
                        Me.PARAMETROS.Add("FECHA1", ucCriteriosBodega1.FECHA_INICIAL)
                        Me.PARAMETROS.Add("FECHA2", ucCriteriosBodega1.FECHA_FINAL)
                    End If

                Case 3, 4
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_VUELO)
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    If ucCriteriosBodega1.PERIODO = 1 Then
                        Me.PARAMETROS.Add("FECHA1", cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy"))
                        Me.PARAMETROS.Add("FECHA2", "")
                    Else
                        If ucCriteriosBodega1.FECHA_INICIAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Ingrese la fecha inicial del periodo", False, True, True)
                            Return
                        End If
                        If ucCriteriosBodega1.FECHA_FINAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Ingrese la fecha final del periodo", False, True, True)
                            Return
                        End If
                        Me.PARAMETROS.Add("FECHA1", ucCriteriosBodega1.FECHA_INICIAL)
                        Me.PARAMETROS.Add("FECHA2", ucCriteriosBodega1.FECHA_FINAL)
                    End If

                Case 5
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)

                Case 6, 7
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    If Me.ucCriteriosBodega1.ID_CATORCENA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una catorcena", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_CATORCENA", Me.ucCriteriosBodega1.ID_CATORCENA)
                    End If
                    If Me.ucCriteriosBodega1.ID_TIPO_PLANILLA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione un tipo de planilla", False, True, True)
                        Return
                    Else
                        Dim lstPlanillaBase As SISPACAL.EL.listaPLANILLA_BASE = (New cPLANILLA_BASE).ObtenerListaPorZAFRA_CATORCENA_TIPO_PLANILLA(Me.ucCriteriosBodega1.ID_ZAFRA, _
                            Me.ucCriteriosBodega1.ID_CATORCENA, Me.ucCriteriosBodega1.ID_TIPO_PLANILLA)
                        If lstPlanillaBase IsNot Nothing AndAlso lstPlanillaBase.Count > 0 Then
                            Me.PARAMETROS.Add("ID_PLANILLA_BASE", lstPlanillaBase(0).ID_PLANILLA_BASE)
                        Else
                            Me.PARAMETROS.Add("ID_PLANILLA_BASE", 0)
                        End If
                    End If
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA)
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)

                Case 8
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("CODTRANSPORT", Me.ucCriteriosBodega1.CODTRANSPORT)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN_TRANS)

                Case 9
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA)
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    If ucCriteriosBodega1.PERIODO = 1 Then
                        Me.PARAMETROS.Add("FECHA1", cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy"))
                        Me.PARAMETROS.Add("FECHA2", "")
                    Else
                        If ucCriteriosBodega1.FECHA_INICIAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Ingrese la fecha inicial del periodo", False, True, True)
                            Return
                        End If
                        If ucCriteriosBodega1.FECHA_FINAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Ingrese la fecha final del periodo", False, True, True)
                            Return
                        End If
                        Me.PARAMETROS.Add("FECHA1", ucCriteriosBodega1.FECHA_INICIAL)
                        Me.PARAMETROS.Add("FECHA2", ucCriteriosBodega1.FECHA_FINAL)
                    End If

                Case 10
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)

                Case 12
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    If Me.ucCriteriosBodega1.FECHA = Nothing Then
                        Me.AsignarMensaje("Ingrese una fecha", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS.Add("FECHA", Me.ucCriteriosBodega1.FECHA.ToString("yyyyMMdd"))
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA)

                Case 11
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("CODTRANSPORT", Me.ucCriteriosBodega1.CODTRANSPORT)
                    If Me.ucCriteriosBodega1.FECHA = Nothing Then
                        Me.AsignarMensaje("Ingrese una fecha", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS.Add("FECHA", Me.ucCriteriosBodega1.FECHA.ToString("yyyyMMdd"))
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA_CREDITO_TRANS)

                Case 13
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    Me.PARAMETROS.Add("CODIBANCO", -1)
                    Me.PARAMETROS.Add("ES_DETALLE", Me.ucCriteriosBodega1.ES_DETALLE)
                    Me.PARAMETROS.Add("ES_OCULTAR_SIN_SALDO", Me.ucCriteriosBodega1.ES_OCULTAR_SIN_SALDO)

                Case 14
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    Me.PARAMETROS.Add("CODIBANCO", -1)

                Case 15
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    If Me.ucCriteriosBodega1.ID_CATORCENA = -1 Then
                        If ucCriteriosBodega1.FECHA_INICIAL = Nothing OrElse ucCriteriosBodega1.FECHA_FINAL = Nothing Then
                            Me.PARAMETROS = Nothing : Me.AsignarMensaje("Defina rango de fechas del periodo", False, True, True)
                            Return
                        End If
                    End If
                    Me.PARAMETROS.Add("ID_CATORCENA", Me.ucCriteriosBodega1.ID_CATORCENA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosBodega1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosBodega1.FECHA_FINAL)
                    Me.PARAMETROS.Add("ES_RESUMEN_POR_OPERADOR", Me.ucCriteriosBodega1.ES_RESUMEN_POR_OPERADOR)

                Case 16
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    Me.PARAMETROS.Add("ES_TOTAL", Me.ucCriteriosBodega1.ES_TOTAL)

                Case 17
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)

                Case 18
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    Me.PARAMETROS.Add("ES_TOTAL", Me.ucCriteriosBodega1.ES_TOTAL)

                Case 19
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA_BANCOS)
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ES_BANCO", Me.ucCriteriosBodega1.ES_BANCO)
                    If Me.ucCriteriosBodega1.ES_BANCO Then
                        If Me.ucCriteriosBodega1.ID_CUENTA_FINAN = -1 OrElse Me.ucCriteriosBodega1.ID_CUENTA_FINAN = 1 Then
                            Me.PARAMETROS.Add("ID_CUENTA_FINAN", 1)
                        Else
                            Me.PARAMETROS.Add("ID_CUENTA_FINAN", -2)
                        End If
                    Else
                        Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosBodega1.ID_CUENTA_FINAN)
                    End If

                Case 20
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ZONA", Me.ucCriteriosBodega1.ZONA)

                Case 21
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("ID_PROVEE", Me.ucCriteriosBodega1.ID_PROVEEDOR_AGRICOLA_BANCOS)
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosBodega1.CODIPROVEEDOR)

                Case 22
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    If Me.ucCriteriosBodega1.FECHA = Nothing Then
                        Me.AsignarMensaje("Ingrese una fecha", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS.Add("FECHA", Me.ucCriteriosBodega1.FECHA.ToString("yyyyMMdd"))

                Case 23
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
                    If Me.ucCriteriosBodega1.ID_CATORCENA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una catorcena", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_CATORCENA", Me.ucCriteriosBodega1.ID_CATORCENA)
                    End If
                    If Me.ucCriteriosBodega1.ID_TIPO_PLANILLA_FRENTES = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione un tipo de planilla", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_TIPO_PLANILLA_FRENTES", Me.ucCriteriosBodega1.ID_TIPO_PLANILLA_FRENTES)
                    End If

                Case 24
                    If Me.ucCriteriosBodega1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosBodega1.ID_ZAFRA)
                    End If
            End Select

            Me.CargarDatosReporte()
        End If
        If CommandName = "CerrarVentana" Then
            Dim strscript As String = "<script language=javascript>window.top.close();</script>"
            If Not Page.ClientScript.IsStartupScriptRegistered("clientScript") Then
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "clientScript", strscript)
            End If
        End If
    End Sub

End Class

