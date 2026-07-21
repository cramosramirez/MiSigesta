Imports SISPACAL.EL
Imports SISPACAL.BL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesCenso_ucReporteCenso
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
                Me.lblTitulo.Text = "REPORTE: Contratos Caña (MZ - TC - $)"
                'ContratoCanaLotesTCUS
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.ID_ZAFRA_AUTOPOSTBACK = False
            Case 2
                Me.lblTitulo.Text = "REPORTE: Contratos Caña (MZ - TC)"
                'ContratoCanaLotesTC
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.ID_ZAFRA_AUTOPOSTBACK = False
            Case 3
                Me.lblTitulo.Text = "REPORTE: Contratos vrs Censos (MZ – TC - $)"
                'CensoGeneralVariacion
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = True
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True
            Case 4
                Me.lblTitulo.Text = "REPORTE: Censo de Caña/Entregado/Por Entregar"
                'AnexoCensoEntregadoEntregar
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = True
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True
            Case 5
                Me.lblTitulo.Text = "REPORTE: Contratos vrs Censos (MZ – TC)"
                'CensoDifContratos
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = True
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True
            Case 6
                Me.lblTitulo.Text = "REPORTE: Censo de Caña/sin Contrato"
                'AnexoCensoSinContrato
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = True
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True

            Case 7
                Me.lblTitulo.Text = "REPORTE: Ejecución Censo caña (MZ – TC - $)"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = True
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True

            Case 8
                Me.lblTitulo.Text = "REPORTE: Ejecución Censo caña (MZ – TC)"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = True
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True

            Case 9
                Me.lblTitulo.Text = "REPORTE: Contrato vrs Ejecucion Censo (MZ – TC)"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = True
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True

            Case 10
                Me.lblTitulo.Text = "REPORTE: CONTRATO VRS EJECUCION CENSO (MZ – TC - $)"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = True
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True

            Case 11
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: Resultados de búsqueda de lotes"
                Me.ucCriterios1.Visible = False

                If Me.Request.QueryString("par").ToString <> "" Then
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Dim sCad As String() = Me.Request.QueryString("par").ToString.Split(";")
                    For i As Integer = 0 To sCad.Length
                        Me.PARAMETROS.Add(i, sCad(i))
                    Next
                End If
                CargarDatosReporte()

            Case 12
                Me.lblTitulo.Text = "REPORTE: VALIDACION CONTRATOS 2014/2015 (MZ – TC)"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = True
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True
            Case 13
                Me.lblTitulo.Text = "REPORTE: CONTRATOS VRS ESTIMACIÓN DE CAÑA (MZ – TC)"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = False
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True
            Case 14
                Me.lblTitulo.Text = "REPORTE: ANALISIS DE EJECUCIÓN ZAFRA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = False
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True
            Case 15
                Me.lblTitulo.Text = "REPORTE: RENDIMIENTO EN EJECUCIÓN ZAFRA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerID_CENSO = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = False
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = True

            Case 16
                Me.lblTitulo.Text = "REPORTE: CONTROL DE ROZA DIARIO / ACUMULADO POR FORMA DE COSECHA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = False
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.VerSUB_ZONA = False
                Me.ucCriterios1.VerDIA_ZAFRA = True
                Me.ucCriterios1.VerMOSTRAR_POR01 = True

            Case 17
                Me.lblTitulo.Text = "REPORTE: ROZA DIARIA EJECUTADA POR FRENTE DE ROZA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = False
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.VerSUB_ZONA = False
                Me.ucCriterios1.VerMOSTRAR_POR02 = True


            Case 18
                Me.lblTitulo.Text = "REPORTE: INVENTARIOS DE CAÑA POR LOTE, TIPO DE CAÑA Y FORMA DE COSECHA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = False
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.VerSUB_ZONA = False
                Me.ucCriterios1.VerMOSTRAR_POR03 = True

            Case 19
                Me.lblTitulo.Text = "REPORTE: ANALISIS CUMPLIMIENTO DE RESOLUCION VMT"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = False
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = False
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.VerSUB_ZONA = False
                Me.ucCriterios1.VerUNIDAD_MEDIDA = True
                Me.ucCriterios1.VerPERIODO = True
                Me.ucCriterios1.VerNIVEL = True

            Case 20
                Me.lblTitulo.Text = "REPORTE: SEGUIMIENTO INTEGRAL EJECUCION PLAN DE COSECHA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerTIPO_DETALLE = False
                Me.ucCriterios1.VerTC_ENTREGADA_ZA = False
                Me.ucCriterios1.VerENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.ENTREGA_CANA_CIERRE = False
                Me.ucCriterios1.VerSUB_ZONA = False
                Me.ucCriterios1.VerMOSTRAR_POR04 = True

            Case 21
                Me.lblTitulo.Text = "REPORTE: Contratos de Esticaña (MZ - TC)"                '
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCANTON = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.ID_ZAFRA_AUTOPOSTBACK = False
        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            Select Case Me.ID_REPORTE
                Case 1
                    If PARAMETROS Is Nothing Then Return
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New ContratoCanaLotesTCUS_A
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New ContratoCanaLotesTCUS_B
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New ContratoCanaLotesTCUS_C
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 4
                            Dim reporte As New ContratoCanaLotesTCUS_D
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 5
                            Dim reporte As New ContratoCanaLotesTCUS_E
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 2
                    If PARAMETROS Is Nothing Then Return
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New ContratoCanaLotesTC_A
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 11
                            Dim reporte As New ContratoCanaLotesTC_A11
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New ContratoCanaLotesTC_B
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New ContratoCanaLotesTC_C
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 4
                            Dim reporte As New ContratoCanaLotesTC_D
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 5
                            Dim reporte As New ContratoCanaLotesTC_E
                            reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 3
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New CensoGeneralVariacion_A
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New CensoGeneralVariacion_B
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New CensoGeneralVariacion_C
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 4
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New AnexoCensoEntregadoEntregar_A
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New AnexoCensoEntregadoEntregar_B
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New AnexoCensoEntregadoEntregar_C
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 5
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New CensoDifContratos_A
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New CensoDifContratos_B
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New CensoDifContratos_C
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 4
                            Dim reporte As New CensoDifContratos_D
                            reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 5
                            Dim reporte As New CensoDifContratos_E
                            reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 6
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New AnexoCensoSinContrato_A
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New AnexoCensoSinContrato_B
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New AnexoCensoSinContrato_C
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                                reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select


                Case 7
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New AnexoCensoEntregadoSaldoTCUS_A
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New AnexoCensoEntregadoSaldoTCUS_B
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New AnexoCensoEntregadoSaldoTCUS_C
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 8
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New AnexoCensoEntregadoSaldoTC_A
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New AnexoCensoEntregadoSaldoTC_B
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New AnexoCensoEntregadoSaldoTC_C
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), "", "")
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 4
                            Dim reporte As New AnexoCensoEntregadoSaldoTC_D
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 5
                            Dim reporte As New AnexoCensoEntregadoSaldoTC_E
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 9
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New ContratoEjecucionCensoTC_A
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New ContratoEjecucionCensoTC_B
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New ContratoEjecucionCensoTC_C
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 4
                            Dim reporte As New ContratoEjecucionCensoTC_D
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 5
                            Dim reporte As New ContratoEjecucionCensoTC_E
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 10
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New ContratoEjecucionCensoTCUS_A
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New ContratoEjecucionCensoTCUS_B
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New ContratoEjecucionCensoTCUS_C
                            If Me.ucCriterios1.ENTREGA_CANA_CIERRE Then
                                reporte.CargarCierreZafra(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            Else
                            End If
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 11
                    If PARAMETROS Is Nothing Then Return
                    'Deben existir 8 parametros
                    If PARAMETROS.Count = 8 Then
                        Dim reporte As New CatalogoLotes
                        reporte.CargarDatos(Me.PARAMETROS("ZONA"), Me.PARAMETROS("SUB_ZONA"), Me.PARAMETROS("CODI_DEPTO"), Me.PARAMETROS("CODI_MUNI"), Me.PARAMETROS("CODI_CANTON"), Me.PARAMETROS("CODIPROVEE"), Me.PARAMETROS("CODISOCIO"), Me.PARAMETROS("CODICONTRATO"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 12
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)

                    Dim reporte As New ValidacionContratosTC_A
                    Select Case Me.PARAMETROS("TC_ENTREGA_ZA")
                        Case 1
                            reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), CInt(PARAMETROS("ID_ZAFRA_COMPA")))
                        Case 2
                            reporte.CargarDatosEnRango(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), CInt(PARAMETROS("ID_ZAFRA_COMPA")))
                        Case 3
                            reporte.CargarDatosFueraRango(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), CInt(PARAMETROS("ID_ZAFRA_COMPA")))
                    End Select

                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 13
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)

                    Dim reporte As New ContratosEstimacionTC_A
                    reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), CInt(PARAMETROS("ID_ZAFRA_COMPA")))
                       
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 14
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)

                    Dim reporte As New ContratosEstimacionTC_B
                    reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), CInt(PARAMETROS("ID_ZAFRA_COMPA")))

                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 15
                    If PARAMETROS Is Nothing Then Return
                    Dim lZafra As ZAFRA
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.ID_CENSO = -1 Then
                        Return
                    End If
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)

                    Dim reporte As New ContratosEstimacionTC_B2
                    reporte.CargarDatos(CInt(PARAMETROS("ID_CENSO")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), CInt(PARAMETROS("ID_ZAFRA_COMPA")))

                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 16
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New InventarioRozaDiaria
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("DIA_ZAFRA"), Me.PARAMETROS("ZONA"), Me.PARAMETROS("OPCION"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 17
                    If PARAMETROS Is Nothing Then Return
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    Dim reporte As New InventarioRozaDiariaProveedor
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("ZONA"), Me.PARAMETROS("OPCION"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 18
                    If PARAMETROS Is Nothing Then Return
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    Dim reporte As New InventarioRozaSaldos
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("ZONA"), Me.PARAMETROS("OPCION"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 19
                    If PARAMETROS Is Nothing Then Return
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    If Me.PARAMETROS("NIVEL") = 1 Then
                        Dim reporte As New AnalisisVMTcompleto
                        reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("ES_TM"), True, PARAMETROS("CATORCENA"), PARAMETROS("ACUMULADO"), PARAMETROS("FECHA_INI"), PARAMETROS("FECHA_FIN"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    Else
                        Dim reporte As New AnalisisVMTgeneral
                        reporte.CargarDatos(PARAMETROS("ID_ZAFRA"), PARAMETROS("ES_TM"), False, PARAMETROS("CATORCENA"), PARAMETROS("ACUMULADO"), PARAMETROS("FECHA_INI"), PARAMETROS("FECHA_FIN"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If
                Case 20
                    If PARAMETROS Is Nothing Then Return
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    Dim reporte As New InventarioCanaSegIntegral
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("ZONA"), Me.PARAMETROS("OPCION"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 21
                    If PARAMETROS Is Nothing Then Return
                    If Me.ucCriterios1.ID_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione la zafra", True, False)
                        Return
                    End If
                    Select Case CInt(Me.PARAMETROS("TIPO_DETALLE"))
                        Case 1
                            Dim reporte As New ContratoCanaLotesTC_A
                            reporte.CargarDatosEsticana(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 11
                            Dim reporte As New ContratoCanaLotesTC_A11
                            reporte.CargarDatosEsticana(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New ContratoCanaLotesTC_B
                            reporte.CargarDatosEsticana(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New ContratoCanaLotesTC_C
                            reporte.CargarDatosEsticana(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 4
                            Dim reporte As New ContratoCanaLotesTC_D
                            reporte.CargarDatosEsticana(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 5
                            Dim reporte As New ContratoCanaLotesTC_E
                            reporte.CargarDatosEsticana(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODI_CANTON"))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select
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
            If Me.ucCriterios1.VerTIPO_DETALLE AndAlso Me.ucCriterios1.TIPO_DETALLE = -1 AndAlso Me.ID_REPORTE <> 12 And Me.ID_REPORTE <> 13 And Me.ID_REPORTE <> 14 And Me.ID_REPORTE <> 15 Then
                Me.AsignarMensaje("Seleccione un formato", False, True, True)
                Return
            End If
            If Me.ucCriterios1.VerTIPO_DETALLE AndAlso ucCriterios1.TIPO_DETALLE = 11 AndAlso Me.ID_REPORTE <> 2 Then
                Me.AsignarMensaje("El formato: Lote por Canton aun no esta implementado en este reporte", False, True, True)
                Return
            End If
            If Me.ID_REPORTE = 12 AndAlso ucCriterios1.TC_ENTREGA_ZA = -1 Then
                Me.AsignarMensaje("Seleccione el limite para TC Entregada en la zafra pasada", False, True, True)
                Return
            End If
            Me.PARAMETROS = New Dictionary(Of String, String)
            If Me.ucCriterios1.VerTIPO_DETALLE Then Me.PARAMETROS.Add("TIPO_DETALLE", ucCriterios1.TIPO_DETALLE)
            Select Case Me.ID_REPORTE
                Case 1, 2, 21
                    Select Case ucCriterios1.TIPO_DETALLE
                        Case 1, 2, 11
                            Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                            Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA) : Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO)
                            Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI) : Me.PARAMETROS.Add("CODI_CANTON", Me.ucCriterios1.CODI_CANTON)
                            Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriterios1.CODIPROVEE) : Me.PARAMETROS.Add("CODISOCIO", Me.ucCriterios1.CODISOCIO)
                        Case 3
                            Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                        Case 4
                            Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                            Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA)
                        Case 5
                            Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                            Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA) : Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO)
                            Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI) : Me.PARAMETROS.Add("CODI_CANTON", Me.ucCriterios1.CODI_CANTON)
                    End Select

                Case 3, 4, 5, 6, 7, 8, 9, 10
                    Select Case ucCriterios1.TIPO_DETALLE
                        Case 1, 2
                            Me.PARAMETROS.Add("ID_CENSO", Me.ucCriterios1.ID_CENSO) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                            Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA) : Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO)
                            Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI) : Me.PARAMETROS.Add("CODI_CANTON", Me.ucCriterios1.CODI_CANTON)
                            Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriterios1.CODIPROVEE) : Me.PARAMETROS.Add("CODISOCIO", Me.ucCriterios1.CODISOCIO)
                        Case 3, 4, 5
                            Me.PARAMETROS.Add("ID_CENSO", Me.ucCriterios1.ID_CENSO) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                            Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA) : Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO)
                            Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI) : Me.PARAMETROS.Add("CODI_CANTON", Me.ucCriterios1.CODI_CANTON)
                    End Select

                Case 12
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerPorNOMBRE_ZAFRA("2014/2015")
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Me.PARAMETROS.Add("TC_ENTREGA_ZA", Me.ucCriterios1.TC_ENTREGA_ZA)
                    Me.PARAMETROS.Add("ID_CENSO", Me.ucCriterios1.ID_CENSO) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                    Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA) : Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO)
                    Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI) : Me.PARAMETROS.Add("CODI_CANTON", Me.ucCriterios1.CODI_CANTON)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriterios1.CODIPROVEE) : Me.PARAMETROS.Add("CODISOCIO", Me.ucCriterios1.CODISOCIO)
                    If lZafra IsNot Nothing Then
                        Me.PARAMETROS.Add("ID_ZAFRA_COMPA", lZafra.ID_ZAFRA.ToString)
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA_COMPA", "-1")
                    End If

                Case 13, 14, 15
                    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Me.PARAMETROS.Add("ID_CENSO", Me.ucCriterios1.ID_CENSO) : Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                    Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA) : Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO)
                    Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI) : Me.PARAMETROS.Add("CODI_CANTON", Me.ucCriterios1.CODI_CANTON)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriterios1.CODIPROVEE) : Me.PARAMETROS.Add("CODISOCIO", Me.ucCriterios1.CODISOCIO)
                    If lZafra IsNot Nothing Then
                        Me.PARAMETROS.Add("ID_ZAFRA_COMPA", lZafra.ID_ZAFRA - 1)
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA_COMPA", "-1")
                    End If
                Case 16, 17, 18, 20
                    If Me.ucCriterios1.VerDIA_ZAFRA AndAlso Me.ucCriterios1.DIA_ZAFRA = -1 Then
                        AsignarMensaje("Seleccione un dia de zafra", True, False)
                        Return
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA)
                    If Me.ucCriterios1.VerDIA_ZAFRA Then
                        Me.PARAMETROS.Add("DIA_ZAFRA", Me.ucCriterios1.DIA_ZAFRA)
                    End If
                    Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)

                    If Me.ucCriterios1.VerMOSTRAR_POR01 Then
                        Me.PARAMETROS.Add("OPCION", Me.ucCriterios1.MOSTRAR_POR01)
                    ElseIf Me.ucCriterios1.VerMOSTRAR_POR02 Then
                        Me.PARAMETROS.Add("OPCION", Me.ucCriterios1.MOSTRAR_POR02)
                    ElseIf Me.ucCriterios1.VerMOSTRAR_POR03 Then
                        Me.PARAMETROS.Add("OPCION", Me.ucCriterios1.MOSTRAR_POR03)
                    ElseIf Me.ucCriterios1.VerMOSTRAR_POR04 Then
                        Me.PARAMETROS.Add("OPCION", Me.ucCriterios1.MOSTRAR_POR04)
                    End If

                Case 19
                    If Me.ucCriterios1.UNIDAD_MEDIDA = -1 Then
                        AsignarMensaje("Seleccione Unidad de Medida", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.PERIODO = -1 Then
                        AsignarMensaje("Seleccione un periodo", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.PERIODO = 1 AndAlso Me.ucCriterios1.CATORCENA = -1 Then
                        AsignarMensaje("Seleccione un corte", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.PERIODO = 3 AndAlso (Me.ucCriterios1.FECHA_INI = "" OrElse Me.ucCriterios1.FECHA_FIN = "") Then
                        AsignarMensaje("Ingrese el periodo", True, False)
                        Return
                    End If
                    If Me.ucCriterios1.NIVEL = -1 Then
                        AsignarMensaje("Seleccione el nivel", True, False)
                        Return
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA)
                    Me.PARAMETROS.Add("ES_TM", If(Me.ucCriterios1.UNIDAD_MEDIDA = 1, True, False))
                    Me.PARAMETROS.Add("CATORCENA", If(Me.ucCriterios1.PERIODO = 1, Me.ucCriterios1.CATORCENA, -1))
                    Me.PARAMETROS.Add("ACUMULADO", If(Me.ucCriterios1.PERIODO = 2, True, False))
                    Me.PARAMETROS.Add("FECHA_INI", If(Me.ucCriterios1.PERIODO = 3, Me.ucCriterios1.FECHA_INI, ""))
                    Me.PARAMETROS.Add("FECHA_FIN", If(Me.ucCriterios1.PERIODO = 3, Me.ucCriterios1.FECHA_FIN, ""))
                    Me.PARAMETROS.Add("NIVEL", Me.ucCriterios1.NIVEL)
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
