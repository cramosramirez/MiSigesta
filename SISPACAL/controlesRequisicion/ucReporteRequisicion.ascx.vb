Imports SISPACAL.RL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Partial Class controlesRequisicion_ucReporteRequisicion
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
                Me.lblTitulo.Text = "REPORTE: CONTROL DE REQUISICIONES"

        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            Select Case Me.ID_REPORTE
                Case 1
                    If PARAMETROS Is Nothing Then Return
                    If PARAMETROS("ID_PERIODOREQ") = -1 Then
                        AsignarMensaje("Seleccione el periodo", True, False)
                        Return
                    End If

                    Dim reporte As New ControlRequisiciones
                    reporte.CargaDatos(PARAMETROS("CODI_REQ"), PARAMETROS("ID_PERIODOREQ"), PARAMETROS("ID_SECCION"), PARAMETROS("ID_SOLICITANTE"), PARAMETROS("FECHA_EMISION_INI"), PARAMETROS("FECHA_EMISION_FIN"), PARAMETROS("ETAPA"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
            End Select
        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            If Me.ucCriteriosRequisicion1.ID_PERIODOREQ = -1 Then
                Me.AsignarMensaje("Seleccione un periodo", False, True, True)
                Return
            End If
            If Me.ucCriteriosRequisicion1.FECHA_EMISION_INI <> #12:00:00 AM# AndAlso Me.ucCriteriosRequisicion1.FECHA_EMISION_FIN = #12:00:00 AM# Then
                Me.AsignarMensaje("Ingrese fecha final de emision", False, True, True)
                Return
            End If
            If Me.ucCriteriosRequisicion1.FECHA_EMISION_INI = #12:00:00 AM# AndAlso Me.ucCriteriosRequisicion1.FECHA_EMISION_FIN <> #12:00:00 AM# Then
                Me.AsignarMensaje("Ingrese fecha inicial de emision", False, True, True)
                Return
            End If
            Me.PARAMETROS = New Dictionary(Of String, String)
            Select Case Me.ID_REPORTE
                Case 1
                    Me.PARAMETROS.Add("CODI_REQ", Me.ucCriteriosRequisicion1.CODI_REQ)
                    Me.PARAMETROS.Add("ID_PERIODOREQ", Me.ucCriteriosRequisicion1.ID_PERIODOREQ)
                    Me.PARAMETROS.Add("ID_SECCION", Me.ucCriteriosRequisicion1.ID_SECCION)
                    Me.PARAMETROS.Add("ID_SOLICITANTE", Me.ucCriteriosRequisicion1.ID_SOLICITANTE)
                    Me.PARAMETROS.Add("FECHA_EMISION_INI", Me.ucCriteriosRequisicion1.FECHA_EMISION_INI)
                    Me.PARAMETROS.Add("FECHA_EMISION_FIN", Me.ucCriteriosRequisicion1.FECHA_EMISION_FIN)
                    Me.PARAMETROS.Add("ETAPA", Me.ucCriteriosRequisicion1.ETAPA)

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
