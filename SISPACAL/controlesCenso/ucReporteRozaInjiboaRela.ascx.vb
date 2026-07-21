Imports SISPACAL.EL
Imports SISPACAL.BL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores
Partial Class controlesCenso_ucReporteRozaInjiboaRela
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
                Me.lblTitulo.Text = "EJECUCION ROZA x FRENTES SEGÚN ENVIO"
                Me.ucCriteriosRozaInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosRozaInjiboaRela1.VerPERIODO = True
                Me.ucCriteriosRozaInjiboaRela1.VerPRODUCTOR = True
                Me.ucCriteriosRozaInjiboaRela1.VerDETALLE_POR_PAGINA = True
                Me.ucCriteriosRozaInjiboaRela1.VerAGRUPAR_POR_LOTE = True
            Case 2
                Me.lblTitulo.Text = "SERVICIO DE ROZA MANUAL A PRODUCTORES DE CAÑA - SEGÚN ENVIOS"
                Me.ucCriteriosRozaInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosRozaInjiboaRela1.VerPERIODO = True
                Me.ucCriteriosRozaInjiboaRela1.VerTIPO_PRODUCTOR = True
            Case 3
                Me.lblTitulo.Text = "EJECUCION ROZA - PRODUCTOR PARTICULAR / FRENTE"
                Me.ucCriteriosRozaInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosRozaInjiboaRela1.VerPERIODO = True
                Me.ucCriteriosRozaInjiboaRela1.VerDETALLE_POR_PAGINA = True
                Me.ucCriteriosRozaInjiboaRela1.VerAGRUPAR_POR_LOTE = True
            Case 4
                Me.lblTitulo.Text = "EJECUCION ROZA - FRENTE DE ROZA / PRODUCTORES"
                Me.ucCriteriosRozaInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosRozaInjiboaRela1.VerPERIODO = True
                Me.ucCriteriosRozaInjiboaRela1.VerTIPO_PRODUCTOR2 = True
                Me.ucCriteriosRozaInjiboaRela1.VerDETALLE_POR_PAGINA = True
                Me.ucCriteriosRozaInjiboaRela1.VerAGRUPAR_POR_LOTE = True
            Case 5
                Me.lblTitulo.Text = "REPORTE: Entrega de Caña por Catorcena-Carga Particular"
                Me.ucCriteriosRozaInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosRozaInjiboaRela1.VerPROVEEDORES_CARGA = True
                Me.ucCriteriosRozaInjiboaRela1.VerDETALLE_POR_PAGINA = True
        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            Select Case Me.ID_REPORTE
                Case 1
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New RozaManualDetalleFrenteCatorcenalInjiboaRel
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")),
                                        CInt(PARAMETROS("CATORCENA")),
                                        CInt(PARAMETROS("DIA_ZAFRA1")), CInt(PARAMETROS("DIA_ZAFRA2")),
                                        PARAMETROS("CODIPROVEEDOR"), CInt(PARAMETROS("PERIODO")),
                                        CInt(PARAMETROS("TIPO_FRENTE")), CInt(PARAMETROS("ID_PROVEEDOR_ROZA_S")),
                                        CBool(PARAMETROS("DETALLE_POR_PAGINA")),
                                        CBool(PARAMETROS("AGRUPAR_POR_LOTE")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 2
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New RozaManualResumenFrenteProductor
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")),
                                        CInt(PARAMETROS("CATORCENA")),
                                        CInt(PARAMETROS("DIA_ZAFRA1")), CInt(PARAMETROS("DIA_ZAFRA2")),
                                        CInt(PARAMETROS("PERIODO")), CInt(PARAMETROS("TIPO_PRODUCTOR")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 3
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New RozaManualDetalleProductorFrente
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")),
                                        CInt(PARAMETROS("CATORCENA")),
                                        CInt(PARAMETROS("DIA_ZAFRA1")), CInt(PARAMETROS("DIA_ZAFRA2")),
                                        CInt(PARAMETROS("PERIODO")), "PRODUCTORES EXTERNOS",
                                        CBool(PARAMETROS("DETALLE_POR_PAGINA")),
                                        CBool(PARAMETROS("AGRUPAR_POR_LOTE")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 4
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New RozaManualDetalleFrenteCatorcenalProductor
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")),
                                        CInt(PARAMETROS("CATORCENA")),
                                        CInt(PARAMETROS("DIA_ZAFRA1")), CInt(PARAMETROS("DIA_ZAFRA2")),
                                        CInt(PARAMETROS("PERIODO")), PARAMETROS("TIPO_PRODUCTOR"),
                                        CBool(PARAMETROS("DETALLE_POR_PAGINA")),
                                        CBool(PARAMETROS("AGRUPAR_POR_LOTE")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 5
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New ResumenPagoCargadorasZafra
                    reporte.CargarDatos(CInt(PARAMETROS("ID_PROVEEDOR_CARGA")),
                                        CInt(PARAMETROS("ID_ZAFRA")),
                                        CBool(PARAMETROS("DETALLE_POR_PAGINA")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
            End Select

        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            If Me.ucCriteriosRozaInjiboaRela1.ID_ZAFRA = -1 Then
                AsignarMensaje("Seleccione la zafra", True, False)
                Return
            End If
            If Me.ID_REPORTE >= 1 AndAlso Me.ID_REPORTE <= 4 Then
                If Me.ucCriteriosRozaInjiboaRela1.PERIODO = -1 Then
                    AsignarMensaje("Seleccione el periodo", True, False)
                    Return
                End If
                If Me.ucCriteriosRozaInjiboaRela1.PERIODO = 1 AndAlso
                            (Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA1 = -1 OrElse Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA2 = -1) Then
                    AsignarMensaje("Ingrese fecha inicial y final del periodo", True, False)
                    Return
                End If
                If Me.ucCriteriosRozaInjiboaRela1.PERIODO = 4 AndAlso
                            Me.ucCriteriosRozaInjiboaRela1.CATORCENA = -1 Then
                    AsignarMensaje("Seleccione un corte ", True, False)
                    Return
                End If
            End If

            AsignarMensaje("", True, False)
            Me.PARAMETROS = New Dictionary(Of String, String)

            Select Case Me.ID_REPORTE
                Case 1
                    If Me.ucCriteriosRozaInjiboaRela1.CODIPROVEEDOR = "" Then
                        AsignarMensaje("Seleccione un productor ", True, False)
                        Return
                    ElseIf Me.ucCriteriosRozaInjiboaRela1.TIPO_FRENTE = -1 Then
                        AsignarMensaje("Seleccione un tipo de frente de roza ", True, False)
                        Return
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosRozaInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA1", "-1")
                    Me.PARAMETROS.Add("DIA_ZAFRA2", "-1")
                    Me.PARAMETROS.Add("CATORCENA", -1)
                    Me.PARAMETROS.Add("PERIODO", Me.ucCriteriosRozaInjiboaRela1.PERIODO)
                    Select Case Me.ucCriteriosRozaInjiboaRela1.PERIODO
                        Case 1 'DIAS ZAFRA
                            Me.PARAMETROS("DIA_ZAFRA1") = Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA1
                            Me.PARAMETROS("DIA_ZAFRA2") = Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA2
                        Case 4 'POR CORTE
                            Me.PARAMETROS("CATORCENA") = Me.ucCriteriosRozaInjiboaRela1.CATORCENA
                    End Select
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosRozaInjiboaRela1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ID_PROVEEDOR_ROZA_S", -1)
                    Me.PARAMETROS.Add("TIPO_FRENTE", Me.ucCriteriosRozaInjiboaRela1.TIPO_FRENTE)
                    If Me.ucCriteriosRozaInjiboaRela1.TIPO_FRENTE = 5 Then
                        Me.PARAMETROS("ID_PROVEEDOR_ROZA_S") = Me.ucCriteriosRozaInjiboaRela1.ID_PROVEEDOR_ROZA
                    End If
                    Me.PARAMETROS.Add("DETALLE_POR_PAGINA", Me.ucCriteriosRozaInjiboaRela1.DETALLE_POR_PAGINA.ToString)
                    Me.PARAMETROS.Add("AGRUPAR_POR_LOTE", Me.ucCriteriosRozaInjiboaRela1.AGRUPAR_POR_LOTE)

                Case 2
                    If Me.ucCriteriosRozaInjiboaRela1.TIPO_PRODUCTOR = -1 Then
                        AsignarMensaje("Seleccione el tipo de productor", True, False)
                        Return
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosRozaInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA1", "-1")
                    Me.PARAMETROS.Add("DIA_ZAFRA2", "-1")
                    Me.PARAMETROS.Add("CATORCENA", -1)
                    Me.PARAMETROS.Add("PERIODO", Me.ucCriteriosRozaInjiboaRela1.PERIODO)
                    Me.PARAMETROS.Add("TIPO_PRODUCTOR", Me.ucCriteriosRozaInjiboaRela1.TIPO_PRODUCTOR)
                    Select Case Me.ucCriteriosRozaInjiboaRela1.PERIODO
                        Case 1 'DIAS ZAFRA
                            Me.PARAMETROS("DIA_ZAFRA1") = Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA1
                            Me.PARAMETROS("DIA_ZAFRA2") = Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA2
                        Case 4 'POR CORTE
                            Me.PARAMETROS("CATORCENA") = Me.ucCriteriosRozaInjiboaRela1.CATORCENA
                    End Select

                Case 3
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosRozaInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA1", "-1")
                    Me.PARAMETROS.Add("DIA_ZAFRA2", "-1")
                    Me.PARAMETROS.Add("CATORCENA", -1)
                    Me.PARAMETROS.Add("PERIODO", Me.ucCriteriosRozaInjiboaRela1.PERIODO)
                    Select Case Me.ucCriteriosRozaInjiboaRela1.PERIODO
                        Case 1 'DIAS ZAFRA
                            Me.PARAMETROS("DIA_ZAFRA1") = Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA1
                            Me.PARAMETROS("DIA_ZAFRA2") = Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA2
                        Case 4 'POR CORTE
                            Me.PARAMETROS("CATORCENA") = Me.ucCriteriosRozaInjiboaRela1.CATORCENA
                    End Select
                    Me.PARAMETROS.Add("DETALLE_POR_PAGINA", Me.ucCriteriosRozaInjiboaRela1.DETALLE_POR_PAGINA.ToString)
                    Me.PARAMETROS.Add("AGRUPAR_POR_LOTE", Me.ucCriteriosRozaInjiboaRela1.AGRUPAR_POR_LOTE)

                Case 4
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosRozaInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA1", "-1")
                    Me.PARAMETROS.Add("DIA_ZAFRA2", "-1")
                    Me.PARAMETROS.Add("CATORCENA", -1)
                    Me.PARAMETROS.Add("PERIODO", Me.ucCriteriosRozaInjiboaRela1.PERIODO)
                    Me.PARAMETROS.Add("TIPO_PRODUCTOR", Me.ucCriteriosRozaInjiboaRela1.TIPO_PRODUCTOR2)
                    Select Case Me.ucCriteriosRozaInjiboaRela1.PERIODO
                        Case 1 'DIAS ZAFRA
                            Me.PARAMETROS("DIA_ZAFRA1") = Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA1
                            Me.PARAMETROS("DIA_ZAFRA2") = Me.ucCriteriosRozaInjiboaRela1.DIA_ZAFRA2
                        Case 4 'POR CORTE
                            Me.PARAMETROS("CATORCENA") = Me.ucCriteriosRozaInjiboaRela1.CATORCENA
                    End Select
                    Me.PARAMETROS.Add("DETALLE_POR_PAGINA", Me.ucCriteriosRozaInjiboaRela1.DETALLE_POR_PAGINA.ToString)
                    Me.PARAMETROS.Add("AGRUPAR_POR_LOTE", Me.ucCriteriosRozaInjiboaRela1.AGRUPAR_POR_LOTE)

                Case 5
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosRozaInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS("ID_PROVEEDOR_CARGA") = Me.ucCriteriosRozaInjiboaRela1.ID_PROVEEDOR_CARGA
                    Me.PARAMETROS.Add("DETALLE_POR_PAGINA", Me.ucCriteriosRozaInjiboaRela1.DETALLE_POR_PAGINA)
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
