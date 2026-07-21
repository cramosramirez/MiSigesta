Imports SISPACAL.EL
Imports SISPACAL.BL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores
Partial Class controlesCenso_ucReporteQuerqueoInjiboaRela
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
                Me.lblTitulo.Text = "EJECUCION QUERQUEO x FRENTES SEGÚN ENVIO"
                Me.ucCriteriosQuerqueoInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerPERIODO = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerPRODUCTOR = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerDETALLE_POR_PAGINA = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerAGRUPAR_POR_LOTE = True
            Case 2
                Me.lblTitulo.Text = "SERVICIO DE QUERQUEO MANUAL A PRODUCTORES DE CAÑA - SEGÚN ENVIOS"
                Me.ucCriteriosQuerqueoInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerPERIODO = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerTIPO_PRODUCTOR = True
            Case 3
                Me.lblTitulo.Text = "EJECUCION QUERQUEO - PRODUCTOR PARTICULAR / FRENTE"
                Me.ucCriteriosQuerqueoInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerPERIODO = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerDETALLE_POR_PAGINA = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerAGRUPAR_POR_LOTE = True
            Case 4
                Me.lblTitulo.Text = "EJECUCION QUERQUEO - FRENTE DE QUERQUEO / PRODUCTORES"
                Me.ucCriteriosQuerqueoInjiboaRela1.VerZAFRA = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerPERIODO = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerTIPO_PRODUCTOR2 = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerDETALLE_POR_PAGINA = True
                Me.ucCriteriosQuerqueoInjiboaRela1.VerAGRUPAR_POR_LOTE = True
        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            Select Case Me.ID_REPORTE
                Case 1
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New QuerqueoManualDetalleFrenteCatorcenalInjiboaRel
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")),
                                        CInt(PARAMETROS("CATORCENA")),
                                        CInt(PARAMETROS("DIA_ZAFRA1")), CInt(PARAMETROS("DIA_ZAFRA2")),
                                        PARAMETROS("CODIPROVEEDOR"), CInt(PARAMETROS("PERIODO")),
                                        CInt(PARAMETROS("TIPO_FRENTE")), CInt(PARAMETROS("ID_PROVEEDOR_QUERQUEO_S")),
                                        CBool(PARAMETROS("DETALLE_POR_PAGINA")),
                                        CBool(PARAMETROS("AGRUPAR_POR_LOTE")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 2
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New QuerqueoManualResumenFrenteProductor
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")),
                                        CInt(PARAMETROS("CATORCENA")),
                                        CInt(PARAMETROS("DIA_ZAFRA1")), CInt(PARAMETROS("DIA_ZAFRA2")),
                                        CInt(PARAMETROS("PERIODO")), CInt(PARAMETROS("TIPO_PRODUCTOR")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 3
                    If PARAMETROS Is Nothing Then Return
                    Dim reporte As New QuerqueoManualDetalleProductorFrente
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
                    Dim reporte As New QuerqueoManualDetalleFrenteCatorcenalProductor
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")),
                                        CInt(PARAMETROS("CATORCENA")),
                                        CInt(PARAMETROS("DIA_ZAFRA1")), CInt(PARAMETROS("DIA_ZAFRA2")),
                                        CInt(PARAMETROS("PERIODO")), PARAMETROS("TIPO_PRODUCTOR"),
                                        CBool(PARAMETROS("DETALLE_POR_PAGINA")),
                                        CBool(PARAMETROS("AGRUPAR_POR_LOTE")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)


            End Select

        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            If Me.ucCriteriosQuerqueoInjiboaRela1.ID_ZAFRA = -1 Then
                AsignarMensaje("Seleccione la zafra", True, False)
                Return
            End If
            If Me.ID_REPORTE >= 1 AndAlso Me.ID_REPORTE <= 4 Then
                If Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO = -1 Then
                    AsignarMensaje("Seleccione el periodo", True, False)
                    Return
                End If
                If Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO = 1 AndAlso
                            (Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA1 = -1 OrElse Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA2 = -1) Then
                    AsignarMensaje("Ingrese fecha inicial y final del periodo", True, False)
                    Return
                End If
                If Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO = 4 AndAlso
                            Me.ucCriteriosQuerqueoInjiboaRela1.CATORCENA = -1 Then
                    AsignarMensaje("Seleccione un corte ", True, False)
                    Return
                End If
            End If

            AsignarMensaje("", True, False)
            Me.PARAMETROS = New Dictionary(Of String, String)

            Select Case Me.ID_REPORTE
                Case 1
                    If Me.ucCriteriosQuerqueoInjiboaRela1.CODIPROVEEDOR = "" Then
                        AsignarMensaje("Seleccione un productor ", True, False)
                        Return
                    ElseIf Me.ucCriteriosQuerqueoInjiboaRela1.TIPO_FRENTE = -1 Then
                        AsignarMensaje("Seleccione un tipo de frente de roza ", True, False)
                        Return
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosQuerqueoInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA1", "-1")
                    Me.PARAMETROS.Add("DIA_ZAFRA2", "-1")
                    Me.PARAMETROS.Add("CATORCENA", -1)
                    Me.PARAMETROS.Add("PERIODO", Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO)
                    Select Case Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO
                        Case 1 'DIAS ZAFRA
                            Me.PARAMETROS("DIA_ZAFRA1") = Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA1
                            Me.PARAMETROS("DIA_ZAFRA2") = Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA2
                        Case 4 'POR CORTE
                            Me.PARAMETROS("CATORCENA") = Me.ucCriteriosQuerqueoInjiboaRela1.CATORCENA
                    End Select
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosQuerqueoInjiboaRela1.CODIPROVEEDOR)
                    Me.PARAMETROS.Add("ID_PROVEEDOR_QUERQUEO_S", -1)
                    Me.PARAMETROS.Add("TIPO_FRENTE", Me.ucCriteriosQuerqueoInjiboaRela1.TIPO_FRENTE)
                    If Me.ucCriteriosQuerqueoInjiboaRela1.TIPO_FRENTE = 5 Then
                        Me.PARAMETROS("ID_PROVEEDOR_QUERQUEO_S") = Me.ucCriteriosQuerqueoInjiboaRela1.ID_PROVEE_QQ
                    End If
                    Me.PARAMETROS.Add("DETALLE_POR_PAGINA", Me.ucCriteriosQuerqueoInjiboaRela1.DETALLE_POR_PAGINA.ToString)
                    Me.PARAMETROS.Add("AGRUPAR_POR_LOTE", Me.ucCriteriosQuerqueoInjiboaRela1.AGRUPAR_POR_LOTE)

                Case 2
                    If Me.ucCriteriosQuerqueoInjiboaRela1.TIPO_PRODUCTOR = -1 Then
                        AsignarMensaje("Seleccione el tipo de productor", True, False)
                        Return
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosQuerqueoInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA1", "-1")
                    Me.PARAMETROS.Add("DIA_ZAFRA2", "-1")
                    Me.PARAMETROS.Add("CATORCENA", -1)
                    Me.PARAMETROS.Add("PERIODO", Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO)
                    Me.PARAMETROS.Add("TIPO_PRODUCTOR", Me.ucCriteriosQuerqueoInjiboaRela1.TIPO_PRODUCTOR)
                    Select Case Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO
                        Case 1 'DIAS ZAFRA
                            Me.PARAMETROS("DIA_ZAFRA1") = Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA1
                            Me.PARAMETROS("DIA_ZAFRA2") = Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA2
                        Case 4 'POR CORTE
                            Me.PARAMETROS("CATORCENA") = Me.ucCriteriosQuerqueoInjiboaRela1.CATORCENA
                    End Select

                Case 3
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosQuerqueoInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA1", "-1")
                    Me.PARAMETROS.Add("DIA_ZAFRA2", "-1")
                    Me.PARAMETROS.Add("CATORCENA", -1)
                    Me.PARAMETROS.Add("PERIODO", Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO)
                    Select Case Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO
                        Case 1 'DIAS ZAFRA
                            Me.PARAMETROS("DIA_ZAFRA1") = Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA1
                            Me.PARAMETROS("DIA_ZAFRA2") = Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA2
                        Case 4 'POR CORTE
                            Me.PARAMETROS("CATORCENA") = Me.ucCriteriosQuerqueoInjiboaRela1.CATORCENA
                    End Select
                    Me.PARAMETROS.Add("DETALLE_POR_PAGINA", Me.ucCriteriosQuerqueoInjiboaRela1.DETALLE_POR_PAGINA.ToString)
                    Me.PARAMETROS.Add("AGRUPAR_POR_LOTE", Me.ucCriteriosQuerqueoInjiboaRela1.AGRUPAR_POR_LOTE)

                Case 4
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosQuerqueoInjiboaRela1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA1", "-1")
                    Me.PARAMETROS.Add("DIA_ZAFRA2", "-1")
                    Me.PARAMETROS.Add("CATORCENA", -1)
                    Me.PARAMETROS.Add("PERIODO", Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO)
                    Me.PARAMETROS.Add("TIPO_PRODUCTOR", Me.ucCriteriosQuerqueoInjiboaRela1.TIPO_PRODUCTOR2)
                    Select Case Me.ucCriteriosQuerqueoInjiboaRela1.PERIODO
                        Case 1 'DIAS ZAFRA
                            Me.PARAMETROS("DIA_ZAFRA1") = Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA1
                            Me.PARAMETROS("DIA_ZAFRA2") = Me.ucCriteriosQuerqueoInjiboaRela1.DIA_ZAFRA2
                        Case 4 'POR CORTE
                            Me.PARAMETROS("CATORCENA") = Me.ucCriteriosQuerqueoInjiboaRela1.CATORCENA
                    End Select
                    Me.PARAMETROS.Add("DETALLE_POR_PAGINA", Me.ucCriteriosQuerqueoInjiboaRela1.DETALLE_POR_PAGINA.ToString)
                    Me.PARAMETROS.Add("AGRUPAR_POR_LOTE", Me.ucCriteriosQuerqueoInjiboaRela1.AGRUPAR_POR_LOTE)
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
