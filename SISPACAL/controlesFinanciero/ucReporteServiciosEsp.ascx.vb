Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.RL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Partial Class controlesFinanciero_ucReporteServiciosEsp
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
                Me.lblTitulo.Text = "REPORTE: SERVICIOS ESPECIALES (QUERQUEO, BARRIDA Y PLOMEO)"
                Me.ucCriteriosServiciosEsp1.VerZAFRA = True
                Me.ucCriteriosServiciosEsp1.VerCATORCENA = True
                Me.ucCriteriosServiciosEsp1.VerSERVICIO_ESPECIAL = True
                Me.ucCriteriosServiciosEsp1.VerFECHA_HORA_CIERRE = True
                Me.ucCriteriosServiciosEsp1.VerPROVEEDOR = True

            Case 2
                Me.lblTitulo.Text = "REPORTE: ANTICIPO DE PLANILLA DE PAGO"
                Me.ucCriteriosServiciosEsp1.VerZAFRA = True
                Me.ucCriteriosServiciosEsp1.VerCATORCENA = False
                Me.ucCriteriosServiciosEsp1.VerSERVICIO_ESPECIAL = False
                Me.ucCriteriosServiciosEsp1.VerFECHA_HORA_CIERRE = False
                Me.ucCriteriosServiciosEsp1.VerPROVEEDOR = False

            Case 3
                Me.lblTitulo.Text = "REPORTE: RECIBO DE PAGO DE CARGADORA"
                Me.ucCriteriosServiciosEsp1.VerZAFRA = True
                Me.ucCriteriosServiciosEsp1.VerCATORCENA = True
                Me.ucCriteriosServiciosEsp1.VerSERVICIO_ESPECIAL = False
                Me.ucCriteriosServiciosEsp1.VerFECHA_HORA_CIERRE = False
                Me.ucCriteriosServiciosEsp1.VerPROVEEDOR = False
                Me.ucCriteriosServiciosEsp1.VerCONTRIBUYENTE = True

        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            Select Case Me.ID_REPORTE
                Case 1
                    If Me.PARAMETROS IsNot Nothing Then
                        Select Case CInt(PARAMETROS("SERVICIO_ESPECIAL"))
                            Case 1
                                Dim reporte As New EnvioConQuerqueo
                                reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("NO_CATORCENA")), PARAMETROS("FECHA"), PARAMETROS("CODIPROVEE"))
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case 2
                                Dim reporte As New EnvioConBarrida
                                reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("NO_CATORCENA")), PARAMETROS("FECHA"), PARAMETROS("CODIPROVEE"))
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                        End Select
                    End If
                Case 2
                    If Me.PARAMETROS IsNot Nothing Then
                        Dim reporte As New AnticipoPlanillaPago
                        reporte.Cargar(CInt(PARAMETROS("ID_ZAFRA")))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 3
                    If Me.PARAMETROS IsNot Nothing Then
                        Dim reporte As New ReciboCargadora
                        reporte.Cargar(CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CATORCENA")), PARAMETROS("ES_CONTRIBUYENTE"))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If
            End Select


        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub


    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            If Me.ucCriteriosServiciosEsp1.ID_ZAFRA = -1 Then
                Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                Return
            End If

            Select Case Me.ID_REPORTE
                Case 1
                    If ucCriteriosServiciosEsp1.NO_CATORCENA = -1 Then
                        Me.AsignarMensaje("Seleccione o ingrese la catorcena", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Me.PARAMETROS.Add("ID_ZAFRA", ucCriteriosServiciosEsp1.ID_ZAFRA)
                    Me.PARAMETROS.Add("NO_CATORCENA", ucCriteriosServiciosEsp1.NO_CATORCENA)
                    Me.PARAMETROS.Add("SERVICIO_ESPECIAL", ucCriteriosServiciosEsp1.SERVICIO_ESPECIAL)
                    Me.PARAMETROS.Add("FECHA", ucCriteriosServiciosEsp1.FECHA_HORA_CIERRE)
                    Me.PARAMETROS.Add("CODIPROVEE", ucCriteriosServiciosEsp1.CODIPROVEE)

                Case 2
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Me.PARAMETROS.Add("ID_ZAFRA", ucCriteriosServiciosEsp1.ID_ZAFRA)

                Case 3
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Me.PARAMETROS.Add("ID_ZAFRA", ucCriteriosServiciosEsp1.ID_ZAFRA)
                    Me.PARAMETROS.Add("ID_CATORCENA", ucCriteriosServiciosEsp1.ID_CATORCENA)
                    Me.PARAMETROS.Add("ES_CONTRIBUYENTE", ucCriteriosServiciosEsp1.ES_CONTRIBUYENTE)
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

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        Else
            CargarDatosReporte()
        End If
    End Sub

End Class
