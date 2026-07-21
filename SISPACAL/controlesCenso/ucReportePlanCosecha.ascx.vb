Imports SISPACAL.EL
Imports SISPACAL.BL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesCenso_ucReportePlanCosecha
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
                Me.lblTitulo.Text = "REPORTE: PLANEACION DE COSECHA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 2 'Orden de Análisis
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ORDEN DE ANÁLISIS DE PRE-COSECHA"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idorden").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_ANALISIS_PRE", Convert.ToInt32(Me.Request.QueryString("idorden").ToString))
                    Me.CargarDatosReporte()
                End If
            Case 3 'Solicitud Agrícola 
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: SOLICITUD DE PRODUCTOS"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idsolic").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_SOLICITUD", Convert.ToInt32(Me.Request.QueryString("idsolic").ToString))
                    Me.CargarDatosReporte()
                End If
            Case 4 'Análisis Financiero
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ANALISIS FINANCIERO"
                Me.ucCriterios1.Visible = False
                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idsolic").ToString <> "" Then
                    Dim lSolicAgricola As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(Convert.ToInt32(Me.Request.QueryString("idsolic").ToString))
                    Dim lSolicLotes As listaSOLIC_AGRICOLA_LOTE = (New cSOLIC_AGRICOLA_LOTE).ObtenerListaPorSOLIC_AGRICOLA(Convert.ToInt32(Me.Request.QueryString("idsolic").ToString))
                    If lSolicLotes IsNot Nothing AndAlso lSolicLotes.Count > 0 Then
                        Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lSolicLotes(0).ACCESLOTE)
                        Dim lContratoFinan As CONTRATO_FINAN = (New cCONTRATO_FINAN).ObtenerPorZAFRA_CONTRATO(lSolicLotes(0).ID_ZAFRA, lLote.CODICONTRATO)
                        If lContratoFinan IsNot Nothing Then
                            Me.PARAMETROS.Add("ID_CONTRATO_FINAN", lContratoFinan.ID_CONTRATO_FINAN)
                            Me.PARAMETROS.Add("TOTAL", lSolicAgricola.TOTAL)
                        Else
                            Me.PARAMETROS.Add("ID_CONTRATO_FINAN", -1)
                            Me.PARAMETROS.Add("MONTO_SOLIC", 0)
                        End If
                    Else
                        Me.PARAMETROS.Add("ID_CONTRATO_FINAN", -1)
                        Me.PARAMETROS.Add("MONTO_SOLIC", 0)
                    End If
                    Me.CargarDatosReporte()
                End If

            Case 5 'Resultado de Análisis
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: HOJA DE ANALISIS DE MUESTRA DE CAÑA"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idorden").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_ANALISIS_PRE", Convert.ToInt32(Me.Request.QueryString("idorden").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 6 'Orden Combustible
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ORDEN DE COMBUSTIBLE Y OTROS PRODUCTOS"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idcombus").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_ORDEN_COMBUS", Convert.ToInt32(Me.Request.QueryString("idcombus").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 7
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ORDEN DE ROZA"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("z").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_ZAFRA", Convert.ToInt32(Me.Request.QueryString("z").ToString))
                End If
                If Me.Request.QueryString("u").ToString <> "" Then
                    Me.PARAMETROS.Add("USUARIO", Me.Request.QueryString("u").ToString)
                End If
                If Me.Request.QueryString("f").ToString <> "" Then
                    Dim a As String() = Me.Request.QueryString("f").ToString.Split("F")
                    Dim fecha As DateTime = New DateTime(CInt(a(0)), CInt(a(1)), CInt(a(2)), CInt(a(3)), CInt(a(4)), CInt(a(5)))
                    Me.PARAMETROS.Add("FECHA", fecha)
                End If
                If Me.PARAMETROS.Count > 0 Then Me.CargarDatosReporte()

            Case 8 'Proforma
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: PROFORMA DE ENVIO"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("p").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_PROFORMA", Convert.ToInt32(Me.Request.QueryString("p").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 9 'Solicitud Aplicación
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: APLICACIÓN DE MADURANTE"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idsolic").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_SOLICITUD", Convert.ToInt32(Me.Request.QueryString("idsolic").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 10
                Me.lblTitulo.Text = "REPORTE: PLAN DE COSECHA AJUSTADO"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTIPOitem = False
                Me.ucCriterios1.VerSUB_TIPOitem = False
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTERCIOitem = False
                Me.ucCriterios1.VerSUB_TERCIOitem = False
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.TIPO_DETALLE = 1
                Me.ucCriterios1.VerMULTICANTON = True
                Me.ucCriterios1.VerFORMA_COSECHA = True
                Me.ucCriterios1.VerEDAD_LOTE = True

            Case 11
                Me.lblTitulo.Text = "REPORTE: PLAN DE COSECHA CONTRATOS VRS EJECUCIÓN DEL PLAN"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerVARIEDADitem = False
                Me.ucCriterios1.VerTIPOitem = False
                Me.ucCriterios1.VerSUB_TIPOitem = False
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTERCIOitem = False
                Me.ucCriterios1.VerSUB_TERCIOitem = False
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.TIPO_DETALLE = 1
                Me.ucCriterios1.VerMULTICANTON = True
                Me.ucCriterios1.VerFORMA_COSECHA = True
                Me.ucCriterios1.VerEDAD_LOTE = True

            Case 12
                Me.lblTitulo.Text = "REPORTE: PLAN DE COSECHA EJECUCIÓN / VARIACION"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTIPOitem = False
                Me.ucCriterios1.VerSUB_TIPOitem = False
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTERCIOitem = False
                Me.ucCriterios1.VerSUB_TERCIOitem = False
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerMOLIENDA_DIARIA_AJUSTADA = True
                Me.ucCriterios1.TIPO_DETALLE = 2
                Me.ucCriterios1.VerMULTICANTON = True
                Me.ucCriterios1.VerFORMA_COSECHA = True
                Me.ucCriterios1.VerEDAD_LOTE = True

            Case 13
                Me.lblTitulo.Text = "REPORTE: EJECUCIÓN ZAFRA - POR CATORCENA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 14
                Me.lblTitulo.Text = "REPORTE: EJECUCIÓN PLAN DE COSECHA - POR FORMA DE COSECHA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerVARIEDADitem = False
                Me.ucCriterios1.VerTIPOitem = False
                Me.ucCriterios1.VerSUB_TIPOitem = False
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTERCIOitem = False
                Me.ucCriterios1.VerSUB_TERCIOitem = False
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.TIPO_DETALLE = 2
                Me.ucCriterios1.VerMULTICANTON = True

            Case 15
                Me.lblTitulo.Text = "PROVEEDORES POR MZ - CONTRATOS VRS PLAN DE COSECHA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 16
                Me.lblTitulo.Text = "EJECUCION DE ZAFRA - PROVEEDORES LBS/TC"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 17
                Me.lblTitulo.Text = "PROVEEDORES POR TC/MZ - CONTRATOS VRS PLAN DE COSECHA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 18
                Me.lblTitulo.Text = "RECURSO DEL CAT POR TIPO DE TRANSPORTE"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerMULTICANTON = True


            Case 19
                Me.lblTitulo.Text = "REPORTE: EJECUCION ZAFRA - RENDIMIENTO AGRICOLA E INDUSTRIAL"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 20
                Me.lblTitulo.Text = "REPORTE: EJECUCION ZAFRA - TIPO CAÑA/FORMA COSECHA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 21
                Me.lblTitulo.Text = "REPORTE: EJECUCION ZAFRA - FORMA COSECHA/TIPO CAÑA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 22
                Me.lblTitulo.Text = "REPORTE: EJECUCION ZAFRA - RENDIMIENTOS COSECHADORAS"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 23
                Me.lblTitulo.Text = "REPORTE: EJECUCION ZAFRA - RENDIMIENTOS CARGADORAS"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 24
                Me.lblTitulo.Text = "REPORTE: EJECUCION ZAFRA - RENDIMIENTOS TRANSPORTE"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 25
                Me.lblTitulo.Text = "REPORTE: EJECUCION PLAN DE COSECHA - EDAD/CICLO CAÑA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = False
                Me.ucCriterios1.VerTERCIO = False
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 26
                Me.lblTitulo.Text = "REPORTE: PLAN DE COSECHA POR ZONA - EDAD/CICLO CAÑA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = False
                Me.ucCriterios1.VerTERCIO = False
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True

            Case 27
                Me.lblTitulo.Text = "REPORTE: PLAN DE COSECHA EJECUCIÓN / FABRICA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTIPOitem = False
                Me.ucCriterios1.VerSUB_TIPOitem = False
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTERCIOitem = False
                Me.ucCriterios1.VerSUB_TERCIOitem = False
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerMOLIENDA_DIARIA_AJUSTADA = True
                Me.ucCriterios1.TIPO_DETALLE = 2
                Me.ucCriterios1.VerMULTICANTON = True
                Me.ucCriterios1.VerFORMA_COSECHA = True
                Me.ucCriterios1.VerEDAD_LOTE = True

            Case 28
                Me.lblTitulo.Text = "REPORTE: PLAN DE COSECHA POR ZONA - VARIEDAD CAÑA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = False
                Me.ucCriterios1.VerTERCIO = False
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True
                Me.ucCriterios1.TIPO_DETALLE2 = 6

            Case 29
                Me.lblTitulo.Text = "REPORTE: PLAN DE COSECHA POR ZONA - VARIEDAD CAÑA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = False
                Me.ucCriterios1.VerTERCIO = False
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True
                Me.ucCriterios1.TIPO_DETALLE2 = 6

            Case 30
                Me.lblTitulo.Text = "REPORTE: EJECUCIÓN PLAN DE COSECHA POR PRODUCTOR - TOTAL LOTE"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = False
                Me.ucCriterios1.VerTERCIO = False
                Me.ucCriterios1.VerTIPO_DETALLE2 = True
                Me.ucCriterios1.VerMULTICANTON = True
                Me.ucCriterios1.VerCODIGOS_RELACIONADOS = True
                Me.ucCriterios1.TIPO_DETALLE2 = 6

            Case 31
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: SOLICITUD PARA REQUISICIÓN"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idreq").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_REQENCA", Convert.ToInt32(Me.Request.QueryString("idreq").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 32
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: HOJA DE CONTRATO"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("con").ToString <> "" Then
                    Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(Me.Request.QueryString("con").ToString)
                    If lContrato IsNot Nothing Then
                        Me.PARAMETROS.Add("CODICONTRATO", Me.Request.QueryString("con").ToString)
                        Me.PARAMETROS.Add("TIPO_CONTRATO", lContrato.TIPO_CONTRATO)
                        Me.CargarDatosReporte()
                    End If
                End If

            Case 33 'Solicitud Anticipo 
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: SOLICITUD DE ANTICIPO"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idanti").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_ANTICIPO", Convert.ToInt32(Me.Request.QueryString("idanti").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 34
                Me.lblTitulo.Text = "REPORTE: INVENTARIO DE CAÑA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False

            Case 35
                Me.lblTitulo.Text = "REPORTE: INVENTARIO DE TRANSPORTE"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CENSO = False

            Case 36 'Orden de Compra y Retiro (Por solicitud)
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ORDEN DE COMPRA Y RETIRO"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idsolic").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_SOLICITUD", Convert.ToInt32(Me.Request.QueryString("idsolic").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 37 'Orden de Compra y Retiro (Por Orden de Compra)
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ORDEN DE COMPRA Y RETIRO"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idorden").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_ORDEN", Convert.ToInt32(Me.Request.QueryString("idorden").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 38 'Contrato de Transporte
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: CONTRATO DE TRANSPORTE"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("con").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_CONTRA_TRANS", Convert.ToInt32(Me.Request.QueryString("con").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 39
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: HOJA DE CONTRATO"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("con").ToString <> "" Then
                    Dim lContrato As CONTRATO_LG = (New cCONTRATO_LG).ObtenerCONTRATO_LG(Me.Request.QueryString("con").ToString)
                    If lContrato IsNot Nothing Then
                        Me.PARAMETROS.Add("CODICONTRATO", Me.Request.QueryString("con").ToString)
                        Me.PARAMETROS.Add("TIPO_CONTRATO", lContrato.TIPO_CONTRATO)
                        Me.CargarDatosReporte()
                    End If
                End If

            Case 40
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: CARTA DE AUTORIZACION DE SERVICIOS"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("con").ToString <> "" Then
                    Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(Me.Request.QueryString("con").ToString)
                    If lContrato IsNot Nothing Then
                        Me.PARAMETROS.Add("CODICONTRATO", Me.Request.QueryString("con").ToString)
                        Me.CargarDatosReporte()
                    End If
                End If
            Case 41
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ANEXO CONTRATO LEGAL"
                Me.ucCriterios1.Visible = False

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("con").ToString <> "" Then
                    Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(Me.Request.QueryString("con").ToString)
                    If lContrato IsNot Nothing Then
                        Me.PARAMETROS.Add("CODICONTRATO", Me.Request.QueryString("con").ToString)
                        Me.CargarDatosReporte()
                    End If
                End If
        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try

            If PARAMETROS Is Nothing Then Return

            Select Case Me.ID_REPORTE
                Case 1

                    Dim lZafra As ZAFRA
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)

                    Select Case Me.ucCriterios1.TIPO_DETALLE
                        Case 1
                            If Me.ucCriterios1.ID_CENSO = -2 Then
                                Dim reporteAct As New PlanCosechaPorLoteActualizado
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporteAct.CargarDatosPorFecha(PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"))
                                Else
                                    reporteAct.CargarDatos(PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"))
                                End If
                                reporteAct.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporteAct)
                            Else
                                Dim reporte As New PlanCosechaPorLote
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA_COMPA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"))
                                Else
                                    reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA_COMPA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            End If

                        Case 2
                            Dim reporte As New PlanCosechaPorZona
                            If PARAMETROS.ContainsKey("FECHA1") Then
                                reporte.CargarDatosPorFecha(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), "", PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA_COMPA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), "", PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA_COMPA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New PlanCosechaPorSubZona
                            If PARAMETROS.ContainsKey("FECHA1") Then
                                reporte.CargarDatosPorFecha(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), "", PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA_COMPA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), "", PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA_COMPA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 4
                            Dim reporte As New PlanCosechaPorCanton
                            If PARAMETROS.ContainsKey("FECHA1") Then
                                reporte.CargarDatosPorFecha(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), "", PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA_COMPA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), "", PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("CODIVARIEDAD"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), CInt(PARAMETROS("TERCIO")), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_ZAFRA_COMPA")), CInt(PARAMETROS("HORAS_AJUSTE")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("ID_SUB_TIPO_CANA")))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 2
                    Dim reporte As New OrdenAnalisisMuestra
                    reporte.CargarOrden(CInt(PARAMETROS("ID_ANALISIS_PRE")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 3
                    Dim lSolicitud As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(CInt(PARAMETROS("ID_SOLICITUD")))
                    If lSolicitud IsNot Nothing Then
                        Dim lSolicVuelo As listaSOLIC_AGRICOLA_VUELO = (New cSOLIC_AGRICOLA_VUELO).ObtenerListaPorSOLIC_AGRICOLA(lSolicitud.ID_SOLICITUD)
                        If lSolicVuelo IsNot Nothing AndAlso lSolicVuelo.Count > 0 Then
                            Dim reporte As New SolicitudMaduranteVuelo
                            reporte.CargarSolicitud(CInt(PARAMETROS("ID_SOLICITUD")))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Else
                            Dim reporte As New SolicitudInsumoAgricolaExterno
                            reporte.CargarDatos(CInt(PARAMETROS("ID_SOLICITUD")))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        End If
                    End If


                Case 4
                    Dim reporte As New AnalisisFinanciero
                    'reporte.CargarDatos(CInt(PARAMETROS("ID_CONTRATO_FINAN")), CDec(PARAMETROS("TOTAL")))
                    'reporte.ResumeLayout()
                    'Me.ucVisorReporte1.CargarDatos(reporte)

                Case 5
                    Dim reporte As New HojaAnalisisMuestraCana
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ANALISIS_PRE")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 6
                    Dim reporte As New OrdenCombustibleCodigoBarra
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ORDEN_COMBUS")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 7
                    Dim reporte As New OrdenRozaCosecha
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("USUARIO"), CDate(PARAMETROS("FECHA")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 8
                    Dim reporte As New SISPACAL.RL.Proforma
                    reporte.CargarProforma(CInt(PARAMETROS("ID_PROFORMA")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 9
                    Dim reporte As New SolicitudAplicaMadurante
                    reporte.CargarDatos(CInt(PARAMETROS("ID_SOLICITUD")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 10
                    Dim reporte As New PlanCosechaAjustadoPorLote
                    reporte.CargarDatos(2, CInt(PARAMETROS("ID_CENSO")), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("ZONA"), _
                                         PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                         PARAMETROS("CODIVARIEDAD"), PARAMETROS("FORMA_COSECHA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"), _
                                         PARAMETROS("NOMBRE_PROVEEDOR"), PARAMETROS("ID_ZAFRA"), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("ESTADO_LOTE"), PARAMETROS("EDAD_LOTE"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 11
                    Select Case Me.ucCriterios1.TIPO_DETALLE
                        Case 1
                            Dim reporte As New PlanCosechaContratosVrsEjecucionPorLote
                            reporte.CargarDatos(1, CInt(PARAMETROS("ID_CENSO")), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("FORMA_COSECHA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), PARAMETROS("ID_ZAFRA"), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("ESTADO_LOTE"), PARAMETROS("EDAD_LOTE"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 12
                    Select Case Me.ucCriterios1.TIPO_DETALLE
                        Case 1
                            Dim reporte As New PlanCosechaEjecucionPorLote
                            reporte.CargarDatos(1, CInt(PARAMETROS("ID_CENSO")), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("FORMA_COSECHA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), PARAMETROS("ID_ZAFRA"), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("ESTADO_LOTE"), PARAMETROS("EDAD_LOTE"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New rptSigestaEjec010_Zona
                            reporte.CargarDatos("ZONA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), CDec(PARAMETROS("MOLIENDA_DIARIA_AJUSTADA")))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 13
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 3 'Zona
                            Dim reporte As New rptSigestaEjec003_Zona
                            reporte.CargarDatos("ZONA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)

                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec003_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)

                    End Select

                Case 14
                    Select Case Me.ucCriterios1.TIPO_DETALLE
                        Case 2 'Zona
                            Dim reporte As New rptSigestaEjec011_Zona
                            reporte.CargarDatos("ZONA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), CDec(PARAMETROS("MOLIENDA_DIARIA_AJUSTADA")))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 15
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec004_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 16
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec006_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 17
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec005_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 18
                    Select Case Me.ucCriterios1.TIPO_DETALLE
                        Case 2 'Zona
                            Dim reporte As New ProgramacionCosechaTransporte
                            reporte.CargarDatos("ZONA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 19
                    Dim reporte As New rptSigestaEjec012_Zafra
                    reporte.CargarDatos(PARAMETROS("ZONA"), _
                                            PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                            PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                            PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 20
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec001_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 21
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec002_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 22
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec007_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 23
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec008_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 24
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec009_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("CODIVARIEDAD"), PARAMETROS("ID_TIPO_CANA"), PARAMETROS("FECHA1"), PARAMETROS("FECHA2"), PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("SEMANA"), PARAMETROS("CATORCENA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 25
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec015_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 26
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec016_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 27
                    Select Case Me.ucCriterios1.TIPO_DETALLE
                        Case 2
                            Dim reporte As New rptSigestaEjec010_ZonaFabrica
                            reporte.CargarDatos("ZONA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), CDec(PARAMETROS("MOLIENDA_DIARIA_AJUSTADA")))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 28
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec017_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 29
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec018_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 30
                    Select Case Me.ucCriterios1.TIPO_DETALLE2
                        Case 6 'Zafra
                            Dim reporte As New rptSigestaEjec019_Zafra
                            reporte.CargarDatos("ZAFRA", PARAMETROS("ZONA"), _
                                                 PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), _
                                                 PARAMETROS("NOMBRE_PROVEEDOR"), _
                                                 PARAMETROS("ID_ZAFRA"), PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), PARAMETROS("CODIGOS_RELACIONADOS"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 31
                    Dim reporte As New SolicitudParaRequisicion
                    reporte.CargarSolicitud(PARAMETROS("ID_REQENCA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 32
                    If PARAMETROS("TIPO_CONTRATO") = 1 Then
                        Dim reporte As New ContratoPersonaNatural

                        reporte.CargarDatos(PARAMETROS("CODICONTRATO"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    Else
                        Dim reporte As New ContratoSociedadCooperativa

                        reporte.CargarDatos(PARAMETROS("CODICONTRATO"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 33
                    Dim reporte As New SolicitudAnticipo02

                    reporte.CargarDatos(PARAMETROS("ID_ANTICIPO"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 34
                    Dim reporte As New InventarioCana

                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), False)
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 35
                    Dim reporte As New InventarioCanaTransporte

                    reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), True)
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 36
                    Dim lSolicitud As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(PARAMETROS("ID_SOLICITUD"))
                    If lSolicitud IsNot Nothing Then
                        If lSolicitud.CONDI_COMPRA = 1 OrElse lSolicitud.CONDI_COMPRA = 2 Then
                            Dim reporte As New OrdenCompraAgricola
                            reporte.CargarDatos(PARAMETROS("ID_SOLICITUD"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Else
                            Dim reporte As New OrdenSuministroConsignacion
                            reporte.CargarDatos(PARAMETROS("ID_SOLICITUD"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        End If
                    End If

                Case 37
                    Dim lOrden As ORDEN_COMPRA_AGRI = (New cORDEN_COMPRA_AGRI).ObtenerORDEN_COMPRA_AGRI(PARAMETROS("ID_ORDEN"))
                    If lOrden IsNot Nothing Then
                        If lOrden.CONDI_COMPRA = 1 OrElse lOrden.CONDI_COMPRA = 2 Then
                            Dim reporte As New OrdenCompraAgricola
                            reporte.CargarDatosPorOrden(PARAMETROS("ID_ORDEN"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Else
                            Dim reporte As New OrdenSuministroConsignacion
                            reporte.CargarDatosPorOrden(PARAMETROS("ID_ORDEN"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        End If
                    End If

                Case 38
                    Dim reporte As New ContratoTransporteLegal
                    reporte.CargarDatos(PARAMETROS("ID_CONTRA_TRANS"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 39
                    If PARAMETROS("TIPO_CONTRATO") = 1 Then
                        Dim reporte As New ContratoPersonaNatural

                        reporte.CargarDatosContratoLegal(PARAMETROS("CODICONTRATO"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    Else
                        Dim reporte As New ContratoSociedadCooperativa

                        reporte.CargarDatosContratoLegal(PARAMETROS("CODICONTRATO"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 40
                    Dim reporte As New CartaAutorizacionServicios
                    reporte.CargarDatos(PARAMETROS("CODICONTRATO"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 41
                    Dim reporte As New AnexoContratoLegal
                    reporte.CargarDatos(PARAMETROS("CODICONTRATO"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

            End Select
        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            If Me.ucCriterios1.ID_ZAFRA = -1 Then
                Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                Return
            End If
            If Me.ucCriterios1.VerID_CENSO AndAlso Me.ucCriterios1.ID_CENSO = -1 Then
                Me.AsignarMensaje("Seleccione un censo", False, True, True)
                Return
            End If
            If Me.ucCriterios1.VerVARIEDAD AndAlso Me.ucCriterios1.ID_CICLO = -1 Then
                Me.AsignarMensaje("Seleccione un ciclo", False, True, True)
                Return
            End If
            If Me.ucCriterios1.VerTIPO_DETALLE AndAlso (Me.ucCriterios1.TIPO_DETALLE = -1 OrElse Me.ucCriterios1.TIPO_DETALLE = 0) Then
                Me.AsignarMensaje("Seleccione el tipo de reporte a mostrar", False, True, True)
                Return
            End If
            If Me.ucCriterios1.VerTIPO_DETALLE2 AndAlso (Me.ucCriterios1.TIPO_DETALLE2 = -1 OrElse Me.ucCriterios1.TIPO_DETALLE2 = 0) Then
                Me.AsignarMensaje("Seleccione el tipo de reporte a mostrar", False, True, True)
                Return
            End If
            Me.PARAMETROS = New Dictionary(Of String, Object)
            Select Case Me.ID_REPORTE
                Case 1
                    Dim lZafraAnt As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA - 1)
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_CENSO", Me.ucCriterios1.ID_CENSO) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                    Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA) : Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO)
                    Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriterios1.CODIPROVEE) : Me.PARAMETROS.Add("CODISOCIO", Me.ucCriterios1.CODISOCIO)
                    If Me.ucCriterios1.FECHA1 <> #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 <> #12:00:00 AM# Then
                        Me.PARAMETROS.Add("FECHA1", Me.ucCriterios1.FECHA1.ToString("yyyy/MM/dd")) : Me.PARAMETROS.Add("FECHA2", Me.ucCriterios1.FECHA2.ToString("yyyy/MM/dd"))
                    Else
                        If (Me.ucCriterios1.FECHA1 <> #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 = #12:00:00 AM#) OrElse _
                        (Me.ucCriterios1.FECHA1 = #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 <> #12:00:00 AM#) Then
                            Me.AsignarMensaje("Si filtra por Periodo de roza debe ingresar ambas fechas", False, True, True)
                            Return
                        End If
                    End If
                    Me.PARAMETROS.Add("CODIVARIEDAD", Me.ucCriterios1.CODIVARIEDAD)
                    Me.PARAMETROS.Add("ID_TIPO_CANA", Me.ucCriterios1.ID_TIPO_CANA)
                    Me.PARAMETROS.Add("ID_SUB_TIPO_CANA", Me.ucCriterios1.ID_SUB_TIPO_CANA)
                    Me.PARAMETROS.Add("HORAS_AJUSTE", Me.ucCriterios1.HORAS_AJUSTE)
                    Me.PARAMETROS.Add("SEMANA", Me.ucCriterios1.SEMANA)
                    Me.PARAMETROS.Add("CATORCENA", Me.ucCriterios1.CATORCENA)
                    Me.PARAMETROS.Add("SUB_TERCIO", Me.ucCriterios1.SUB_TERCIO)
                    Me.PARAMETROS.Add("TERCIO", Me.ucCriterios1.TERCIO)
                    Me.PARAMETROS.Add("NOMBRE_PROVEEDOR", Me.ucCriterios1.NOMBRE_PROVEEDOR.ToUpper)
                    Me.PARAMETROS.Add("ID_CICLO", Me.ucCriterios1.ID_CICLO)
                    If Me.ucCriterios1.ID_CENSO = -2 Then
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA)
                    Else
                        If lZafraAnt IsNot Nothing Then
                            Me.PARAMETROS.Add("ID_ZAFRA_COMPA", lZafraAnt.ID_ZAFRA.ToString)
                        Else
                            Me.PARAMETROS.Add("ID_ZAFRA_COMPA", "-1")
                        End If
                    End If

                    If Me.ucCriterios1.CANTONES.Count > 0 Then
                        Dim fechaHora As DateTime = cFechaHora.ObtenerFechaHora
                        Dim bFiltro As New cFILTRO_CANTON

                        'Eliminar filtros de hace una hora
                        bFiltro.EliminarFiltroPorUsuarioFecha(Me.ObtenerUsuario, fechaHora.AddHours(-1))

                        'Agregar filtros seleccionados
                        For Each lCanton As CANTON In Me.ucCriterios1.CANTONES
                            Dim lFiltro As New FILTRO_CANTON
                            lFiltro.ID_FILTRO_CANTON = 0
                            lFiltro.USUARIO_CREA = Me.ObtenerUsuario
                            lFiltro.FECHA_CREA = fechaHora
                            lFiltro.CODI_DEPTO = lCanton.CODI_DEPTO
                            lFiltro.CODI_MUNI = lCanton.CODI_MUNI
                            lFiltro.CODI_CANTON = lCanton.CODI_CANTON

                            bFiltro.ActualizarFILTRO_CANTON(lFiltro)
                        Next

                        Me.PARAMETROS.Add("USUARIO_CREA", Me.ObtenerUsuario)
                        Me.PARAMETROS.Add("FECHA_CREA", fechaHora)
                    Else
                        Me.PARAMETROS.Add("USUARIO_CREA", "")
                        Me.PARAMETROS.Add("FECHA_CREA", Now)
                    End If

                Case 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_CENSO", Me.ucCriterios1.ID_CENSO)
                    Me.PARAMETROS.Add("FECHA1", #12:00:00 AM#) : Me.PARAMETROS.Add("FECHA2", #12:00:00 AM#)
                    If Me.ucCriterios1.FECHA1 <> #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 <> #12:00:00 AM# Then
                        Me.PARAMETROS("FECHA1") = Me.ucCriterios1.FECHA1
                        Me.PARAMETROS("FECHA2") = Me.ucCriterios1.FECHA2
                    Else
                        If (Me.ucCriterios1.FECHA1 <> #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 = #12:00:00 AM#) OrElse _
                        (Me.ucCriterios1.FECHA1 = #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 <> #12:00:00 AM#) Then
                            Me.AsignarMensaje("Si filtra por Periodo de roza debe ingresar ambas fechas", False, True, True)
                            Return
                        End If
                    End If
                    Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                    Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA)
                    Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO) : Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriterios1.CODIPROVEE) : Me.PARAMETROS.Add("CODISOCIO", Me.ucCriterios1.CODISOCIO)
                    Me.PARAMETROS.Add("CODIVARIEDAD", Me.ucCriterios1.CODIVARIEDAD)
                    Me.PARAMETROS.Add("ID_TIPO_CANA", Me.ucCriterios1.ID_TIPO_CANA)
                    Me.PARAMETROS.Add("SEMANA", Me.ucCriterios1.SEMANA)
                    Me.PARAMETROS.Add("CATORCENA", Me.ucCriterios1.CATORCENA)
                    Me.PARAMETROS.Add("NOMBRE_PROVEEDOR", Me.ucCriterios1.NOMBRE_PROVEEDOR.ToUpper)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA)
                    Me.PARAMETROS.Add("ID_CICLO", Me.ucCriterios1.ID_CICLO)
                    Me.PARAMETROS.Add("MOLIENDA_DIARIA_AJUSTADA", Me.ucCriterios1.MOLIENDA_DIARIA_AJUSTADA)
                    Me.PARAMETROS.Add("EDAD_LOTE", Me.ucCriterios1.EDAD_LOTE)
                    Me.PARAMETROS.Add("CODIGOS_RELACIONADOS", Me.ucCriterios1.CODIGOS_RELACIONADOS)
                    If Me.ucCriterios1.CANTONES.Count > 0 Then
                        Dim fechaHora As DateTime = cFechaHora.ObtenerFechaHora
                        Dim bFiltro As New cFILTRO_CANTON

                        'Eliminar filtros de hace una hora
                        bFiltro.EliminarFiltroPorUsuarioFecha(Me.ObtenerUsuario, fechaHora.AddHours(-1))

                        'Agregar filtros seleccionados
                        For Each lCanton As CANTON In Me.ucCriterios1.CANTONES
                            Dim lFiltro As New FILTRO_CANTON
                            lFiltro.ID_FILTRO_CANTON = 0
                            lFiltro.USUARIO_CREA = Me.ObtenerUsuario
                            lFiltro.FECHA_CREA = fechaHora
                            lFiltro.CODI_DEPTO = lCanton.CODI_DEPTO
                            lFiltro.CODI_MUNI = lCanton.CODI_MUNI
                            lFiltro.CODI_CANTON = lCanton.CODI_CANTON

                            bFiltro.ActualizarFILTRO_CANTON(lFiltro)
                        Next

                        Me.PARAMETROS.Add("USUARIO_CREA", Me.ObtenerUsuario)
                        Me.PARAMETROS.Add("FECHA_CREA", fechaHora)
                    Else
                        Me.PARAMETROS.Add("USUARIO_CREA", "")
                        Me.PARAMETROS.Add("FECHA_CREA", Now)
                    End If
                    If Me.ucCriterios1.VerFORMA_COSECHA Then
                        Me.PARAMETROS.Add("FORMA_COSECHA", Me.ucCriterios1.FORMA_COSECHA)
                        Me.PARAMETROS.Add("ESTADO_LOTE", Me.ucCriterios1.ESTADO_LOTE)
                    End If
                Case 34, 35
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA)
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

