Imports SISPACAL.EL
Imports SISPACAL.BL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesCenso_ucReporteLabPrecosecha
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
            CargarDatosReporte()
        End If
    End Sub

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
                Me.lblTitulo.Text = "REPORTE DIARIO DE ANALISIS DE DEXTRANA EN JUGO PRIMARIO"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA_HORA = True
            Case 2
                Me.lblTitulo.Text = "REPORTE DIARIO DE ANALISIS DE ALMIDON EN JUGO PRIMARIO"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA_HORA = True
            Case 3
                Me.lblTitulo.Text = "REPORTE ANALISIS EN MUESTRAS DE PRECOSECHA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA_HORA = True
                Me.ucCriteriosLabPrecosecha1.VerZONAS = True
            Case 4
                Me.lblTitulo.Text = "REPORTE RENDIMIENTOS TEÓRICOS PONDERADOS"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = True
            Case 5
                Me.lblTitulo.Text = "REPORTE INFORMACION LOTE - ANALISIS MUESTRAS ENVIOS"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerFECHA_CORTE = True
                Me.ucCriteriosLabPrecosecha1.VerNROBOLETA = True
            Case 6
                Me.lblTitulo.Text = "REPORTE INFORMACION LOTE - ANALISIS MUESTRAS ENVIOS (COMPLETO)"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA_HORA = True
                Me.ucCriteriosLabPrecosecha1.VerNROBOLETA = True
                Me.ucCriteriosLabPrecosecha1.VerNOMBRE_PROVEEDOR = True
            Case 7
                Me.lblTitulo.Text = "REPORTE PROGRAMACION CATORCENAL"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = True
                Me.ucCriteriosLabPrecosecha1.VerAGRONOMO = True
                Me.ucCriteriosLabPrecosecha1.VerCON_CUOTA_DIARIA = True
            Case 8
                Me.lblTitulo.Text = "REPORTE RESULTADOS DE ANALISIS DE MUESTRAS POR PROVEEDOR/LOTE"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = True
                Me.ucCriteriosLabPrecosecha1.VerCODIPROVEE_SOCIO = True
                Me.ucCriteriosLabPrecosecha1.VerNOMBRE_PROVEEDOR = True
                Me.ucCriteriosLabPrecosecha1.VerNOMBRE_LOTE = True
            Case 9
                Me.lblTitulo.Text = "REPORTE RESULTADOS ACUMULADOS DIARIOS POR LOTE"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = True
                Me.ucCriteriosLabPrecosecha1.VerCODIPROVEE_SOCIO = True
                Me.ucCriteriosLabPrecosecha1.VerNOMBRE_PROVEEDOR = True
            Case 10
                Me.lblTitulo.Text = "REPORTE RUTA DE COSECHA"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = True
            Case 11
                Me.lblTitulo.Text = "REPORTE PROGRAMACION CATORCENAL POR TIPO DE TRANSPORTE  "
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = True
                Me.ucCriteriosLabPrecosecha1.VerAGRONOMO = False
            Case 12
                Me.lblTitulo.Text = "REPORTE PROGRAMACION CATORCENAL POR CANTON - LOTE"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerSEMANA_CATORCENA = True
                Me.ucCriteriosLabPrecosecha1.VerAGRONOMO = True
            Case 13
                Me.lblTitulo.Text = "REPORTE SEGUIMIENTO Y PROGRAMACION DE EQUIPO AGRICOLA Y TRANSPORTE"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerDIA_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerZONAS = True
            Case 14
                Me.lblTitulo.Text = "REPORTE PLAN DE COSECHA DIARIO POR LOTE"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerFECHA_HORA_CORTE = True
                Me.ucCriteriosLabPrecosecha1.VerZONAS = True
                Me.ucCriteriosLabPrecosecha1.VerDIA_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerAUTORIZADO_ENTREGA_CANA = True
                Me.ucCriteriosLabPrecosecha1.FECHA_HORA_CORTE = cFechaHora.ObtenerFechaHora
            Case 15
                Me.lblTitulo.Text = "REPORTE EJECUCION DIARIA Y COMPARATIVO ZAFRA"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerZAFRA_COMPARAR = True
            Case 16
                Me.lblTitulo.Text = "REPORTE RESULTADOS ANALISIS MUESTRAS DE CAÑA CORE SAMPLER - PRODUCTOR / LOTE"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = True
                Me.ucCriteriosLabPrecosecha1.VerCODIPROVEE_SOCIO = True
                Me.ucCriteriosLabPrecosecha1.VerNOMBRE_PROVEEDOR = False
                Me.ucCriteriosLabPrecosecha1.VerNOMBRE_LOTE = False
                Me.ucCriteriosLabPrecosecha1.VerDIA_ZAFRA_CIERRE = True
            Case 17
                Me.lblTitulo.Text = "REPORTE PLAN DE COSECHA POR TERCIO"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = False
                Me.ucCriteriosLabPrecosecha1.VerAGRONOMO = False
                Me.ucCriteriosLabPrecosecha1.VerCON_CUOTA_DIARIA = False

            Case 18
                Me.lblTitulo.Text = "REPORTE INFORMACION LOTE - ANALISIS MUESTRAS ENVIOS"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerFECHA_CORTE = True
                Me.ucCriteriosLabPrecosecha1.VerCODIPROVEE_SOCIO = False
                Me.ucCriteriosLabPrecosecha1.VerNOMBRE_PROVEEDOR = False

            Case 19
                Me.lblTitulo.Text = "ENTREGA DE TIPO DE CANA POR DIAZAFRA"
                Me.ucCriteriosLabPrecosecha1.DESCRIP_CAMPO_ZAFRA = "ZAFRA"
                Me.ucCriteriosLabPrecosecha1.VerID_ZAFRA = True
                Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA = True
                Me.ucCriteriosLabPrecosecha1.VerAGRONOMO = False
                Me.ucCriteriosLabPrecosecha1.VerCON_CUOTA_DIARIA = False
        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            If PARAMETROS Is Nothing OrElse PARAMETROS.Count = 0 Then Return

            Select Case Me.ID_REPORTE
                Case 1
                    Dim reporte As New ResultadoAnalisisPreCosecha
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 2
                    Dim reporte As New ResultadoAnalisisPreCosechaAlmidon
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 3
                    Dim reporte As New ResultadoAnalisisMuestras
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"), Me.PARAMETROS("ZONA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 4
                    Dim reporte As New RendimientosTeoricosPond
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 5
                    Dim reporte As New EnviosVrsAnalisisMuestras
                    reporte.CargarDatos(1, Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_CORTE"), #12:00:00 AM#, #12:00:00 AM#, Me.PARAMETROS("NROBOLETA"), "")
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 6
                    Dim reporte As New EnviosVrsAnalisisMuestras
                    reporte.CargarDatos(2, Me.PARAMETROS("ID_ZAFRA"), #12:00:00 AM#, Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"), Me.PARAMETROS("NROBOLETA"), Me.PARAMETROS("NOMBRE_PROVEEDOR"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 7
                    Dim reporte As New ProgramacionCosecha
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"), Me.PARAMETROS("CODIAGRON"), Me.PARAMETROS("CON_CUOTA_DIARIA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 8
                    Dim reporte As New ResultadoAnalisisPrecosechaTodo
                    reporte.CargarDatos(CInt(Me.PARAMETROS("ID_ZAFRA")), Me.PARAMETROS("CODIPROVEE"), Me.PARAMETROS("CODISOCIO"), Me.PARAMETROS("NOMBRE_PROVEEDOR"), Me.PARAMETROS("NOMBLOTE"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 9
                    Dim reporte As New RendimientoDiarioAcumuladoProveedorLote
                    reporte.CargarDatos(CInt(Me.PARAMETROS("ID_ZAFRA")), Me.PARAMETROS("CODIPROVEE"), Me.PARAMETROS("CODISOCIO"), Me.PARAMETROS("NOMBRE_PROVEEDOR"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 10
                    Dim reporte As New RutaCosecha
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"), "")
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 11
                    Dim reporte As New rptSigestaEjec014_Zona
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"), Me.PARAMETROS("CODIAGRON"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 12
                    Dim reporte As New PlanCosechaEjecucionPorLote
                    reporte.CargarDatosProgramacionCatorcenal(11, Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"), Me.PARAMETROS("SEMANA"), Me.PARAMETROS("CATORCENA"), Me.PARAMETROS("CODIAGRON"), -1)
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 13
                    Dim reporte As New SeguimientoAgricolaCargaTransporte
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("DIAZAFRA"), Me.PARAMETROS("ZONA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 14
                    Dim bPlanCosechaDiario As New cPLAN_COSECHA_DIARIO
                    If bPlanCosechaDiario.GenerarPropuestaCosechaDiaria(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_HORA_CORTE"), Me.ObtenerUsuario, cFechaHora.ObtenerFechaHora) < 0 Then
                        Me.AsignarMensaje("Error al actualizar el Plan de Cosecha Diario: " + bPlanCosechaDiario.sError, True, False, False)
                        Return
                    End If
                    Dim reporte As New PlanCosechaDiarioPorLote
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_HORA_CORTE"), Me.PARAMETROS("ZONA"), Me.PARAMETROS("AUTORIZADO"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 15
                    Dim reporte As New rptSigestaEjec014Compa_Zafra
                    reporte.CargarDatos(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("ID_ZAFRA_COMPARAR"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 16
                    Dim reporte As New ResultadoAnalisisPrecosechaPorProveedor
                    reporte.CargarDatos(CInt(Me.PARAMETROS("ID_ZAFRA")), Me.PARAMETROS("CODIPROVEE"), Me.PARAMETROS("CODISOCIO"), Me.PARAMETROS("NOMBRE_PROVEEDOR"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"), Me.PARAMETROS("DIA_ZAFRA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 17
                    Dim reporte As New TercioEntregaCana
                    reporte.Cargar(Me.PARAMETROS("ID_ZAFRA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 18
                    Dim reporte As New EntregasAnomalas
                    reporte.Cargar(CInt(Me.PARAMETROS("ID_ZAFRA")), CInt(Me.PARAMETROS("DIA_ZAFRA1")), CInt(Me.PARAMETROS("DIA_ZAFRA2")), True)
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
                Case 19
                    Dim reporte As New TipoCanaPorDiaZafra
                    reporte.Cargar(Me.PARAMETROS("ID_ZAFRA"), Me.PARAMETROS("FECHA_INICIAL"), Me.PARAMETROS("FECHA_FINAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
            End Select

        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            If Me.ucCriteriosLabPrecosecha1.ID_ZAFRA = -1 Then
                Me.AsignarMensaje("Seleccione una precosecha/zafra", False, True, True)
                Return
            End If
            If Me.ID_REPORTE <> 5 AndAlso Me.ID_REPORTE <> 6 Then
                If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA_HORA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA1 = #12:00:00 AM# Then
                    Me.AsignarMensaje("Ingrese una fecha/hora inicial", False, True, True)
                    Return
                End If
                If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA_HORA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA2 = #12:00:00 AM# Then
                    Me.AsignarMensaje("Ingrese una fecha/hora final", False, True, True)
                    Return
                End If
            Else
                If Me.ucCriteriosLabPrecosecha1.VerFECHA_CORTE AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_CORTE = #12:00:00 AM# Then
                    Me.AsignarMensaje("Ingrese la fecha de corte", False, True, True)
                    Return
                End If
                If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA_HORA AndAlso _
                    ((Me.ucCriteriosLabPrecosecha1.FECHA1 = #12:00:00 AM# AndAlso Me.ucCriteriosLabPrecosecha1.FECHA2 <> #12:00:00 AM#) OrElse _
                     (Me.ucCriteriosLabPrecosecha1.FECHA1 <> #12:00:00 AM# AndAlso Me.ucCriteriosLabPrecosecha1.FECHA2 = #12:00:00 AM#)) Then
                    Me.AsignarMensaje("Ingrese dos fechas en el periodo", False, True, True)
                    Return
                End If
            End If
            Me.PARAMETROS = New Dictionary(Of String, Object)
            Select Case Me.ID_REPORTE
                Case 1, 2
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA1)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA2)

                Case 3
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA1)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA2)
                    Me.PARAMETROS.Add("ZONA", Me.ucCriteriosLabPrecosecha1.ZONA)

                Case 4
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)
                    

                Case 5
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_CORTE", Me.ucCriteriosLabPrecosecha1.FECHA_CORTE)
                    Me.PARAMETROS.Add("NROBOLETA", Me.ucCriteriosLabPrecosecha1.NROBOLETA)

                Case 6
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA1)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA2)
                    Me.PARAMETROS.Add("NROBOLETA", Me.ucCriteriosLabPrecosecha1.NROBOLETA)
                    Me.PARAMETROS.Add("NOMBRE_PROVEEDOR", Me.ucCriteriosLabPrecosecha1.NOMBRE_PROVEEDOR)

                Case 7
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)
                    Me.PARAMETROS.Add("CODIAGRON", Me.ucCriteriosLabPrecosecha1.CODIAGRON)
                    Me.PARAMETROS.Add("CON_CUOTA_DIARIA", Me.ucCriteriosLabPrecosecha1.CON_CUOTA_DIARIA)

                Case 8
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriteriosLabPrecosecha1.CODIPROVEE)
                    Me.PARAMETROS.Add("CODISOCIO", Me.ucCriteriosLabPrecosecha1.CODISOCIO)
                    Me.PARAMETROS.Add("NOMBRE_PROVEEDOR", Me.ucCriteriosLabPrecosecha1.NOMBRE_PROVEEDOR)
                    Me.PARAMETROS.Add("NOMBLOTE", Me.ucCriteriosLabPrecosecha1.NOMBRE_LOTE)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)

                Case 9
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriteriosLabPrecosecha1.CODIPROVEE)
                    Me.PARAMETROS.Add("CODISOCIO", Me.ucCriteriosLabPrecosecha1.CODISOCIO)
                    Me.PARAMETROS.Add("NOMBRE_PROVEEDOR", Me.ucCriteriosLabPrecosecha1.NOMBRE_PROVEEDOR)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)

                Case 10
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)

                Case 11
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)
                    Me.PARAMETROS.Add("CODIAGRON", Me.ucCriteriosLabPrecosecha1.CODIAGRON)

                Case 12
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA Then
                        If Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL <> #12:00:00 AM# OrElse Me.ucCriteriosLabPrecosecha1.FECHA_FINAL <> #12:00:00 AM# Then
                            If Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL = #12:00:00 AM# Then
                                Me.AsignarMensaje("Ingrese una fecha inicial", False, True, True)
                                Return
                            End If
                            If Me.ucCriteriosLabPrecosecha1.FECHA_FINAL = #12:00:00 AM# Then
                                Me.AsignarMensaje("Ingrese una fecha final", False, True, True)
                                Return
                            End If
                        End If
                        Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                        Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)
                    Else
                        Me.PARAMETROS.Add("FECHA_INICIAL", #12:00:00 AM#)
                        Me.PARAMETROS.Add("FECHA_FINAL", #12:00:00 AM#)
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("SEMANA", Me.ucCriteriosLabPrecosecha1.SEMANA)
                    Me.PARAMETROS.Add("CATORCENA", Me.ucCriteriosLabPrecosecha1.CATORCENA)
                    Me.PARAMETROS.Add("CODIAGRON", Me.ucCriteriosLabPrecosecha1.CODIAGRON)

                Case 13
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIAZAFRA", Me.ucCriteriosLabPrecosecha1.CATORCENA)
                    Me.PARAMETROS.Add("ZONA", Me.ucCriteriosLabPrecosecha1.ZONA)
                    If Me.ucCriteriosLabPrecosecha1.VerDIA_ZAFRA AndAlso Me.ucCriteriosLabPrecosecha1.DIA_ZAFRA = -1 Then
                        Me.AsignarMensaje("Seleccione un dia zafra", False, True, True)
                        Return
                    End If

                Case 14
                    If Me.ucCriteriosLabPrecosecha1.VerFECHA_HORA_CORTE AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_HORA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.VerAUTORIZADO_ENTREGA_CANA AndAlso Me.ucCriteriosLabPrecosecha1.AUTORIZADO_ENTREGA = 0 Then
                        Me.AsignarMensaje("Seleccione si desea ver Propuesta o Lotes autorizados", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_HORA_CORTE", Me.ucCriteriosLabPrecosecha1.FECHA_HORA_CORTE)
                    Me.PARAMETROS.Add("ZONA", Me.ucCriteriosLabPrecosecha1.ZONA)
                    Me.PARAMETROS.Add("AUTORIZADO", Me.ucCriteriosLabPrecosecha1.AUTORIZADO_ENTREGA)

                Case 15
                    If Me.ucCriteriosLabPrecosecha1.ID_ZAFRA = Me.ucCriteriosLabPrecosecha1.ID_ZAFRA_COMPARAR Then
                        Me.AsignarMensaje("La zafra a comparar no puede ser igual a la zafra", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.ID_ZAFRA_COMPARAR = -1 Then
                        Me.AsignarMensaje("Seleccione la zafra con la que comparara", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("ID_ZAFRA_COMPARAR", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA_COMPARAR)

                Case 16
                    If Me.ucCriteriosLabPrecosecha1.CODIPROVEE = "" Then
                        Me.AsignarMensaje("Ingrese el codigo de proveedor", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.DIA_ZAFRA_CIERRE <> -1 AndAlso (Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL <> #12:00:00 AM# OrElse _
                                                                                    Me.ucCriteriosLabPrecosecha1.FECHA_FINAL <> #12:00:00 AM#) Then
                        Me.AsignarMensaje("Solo puede elegir generar el reporte por Dia Zafra Cerrado o Rango de fechas pero no por ambos", False, True, True)
                        Return
                    End If

                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriteriosLabPrecosecha1.CODIPROVEE)
                    Me.PARAMETROS.Add("CODISOCIO", Me.ucCriteriosLabPrecosecha1.CODISOCIO)
                    Me.PARAMETROS.Add("NOMBRE_PROVEEDOR", "")
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)
                    Me.PARAMETROS.Add("DIA_ZAFRA", Me.ucCriteriosLabPrecosecha1.DIA_ZAFRA_CIERRE)

                Case 17
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)

                Case 18
                    If Me.ucCriteriosLabPrecosecha1.VerFECHA_CORTE AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_CORTE = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese la fecha de corte", False, True, True)
                        Return
                    End If

                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.ucCriteriosLabPrecosecha1.FECHA_CORTE)
                    If lDiaZafra IsNot Nothing Then
                        Me.PARAMETROS = New Dictionary(Of String, Object)
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                        Me.PARAMETROS.Add("DIA_ZAFRA1", lDiaZafra.DIAZAFRA)
                        Me.PARAMETROS.Add("DIA_ZAFRA2", lDiaZafra.DIAZAFRA)
                    Else
                        Me.AsignarMensaje("La fecha de corte no existe", False, True, True)
                        Return
                    End If

                Case 19
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosLabPrecosecha1.VerPERIODO_FECHA AndAlso Me.ucCriteriosLabPrecosecha1.FECHA_FINAL = #12:00:00 AM# Then
                        Me.AsignarMensaje("Ingrese una fecha final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosLabPrecosecha1.ID_ZAFRA)
                    Me.PARAMETROS.Add("FECHA_INICIAL", Me.ucCriteriosLabPrecosecha1.FECHA_INICIAL)
                    Me.PARAMETROS.Add("FECHA_FINAL", Me.ucCriteriosLabPrecosecha1.FECHA_FINAL)
                    

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
