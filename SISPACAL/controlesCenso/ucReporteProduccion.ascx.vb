Imports SISPACAL.EL
Imports SISPACAL.BL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesCenso_ucReporteProduccion
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
                Me.lblTitulo.Text = "REPORTE: COMPARATIVO DE PRODUCCIÓN Y RENDIMIENTO DE ZAFRAS"

            Case 2
                Me.lblTitulo.Text = "REPORTE: COMPARATIVO DE RENDIMIENTO POR LOTES - ZAFRAS"
                Me.ucCriteriosComparativo1.VerRENDIMIENTO = False
                Me.ucCriteriosComparativo1.VerVIP = False
                Me.ucCriteriosComparativo1.VerTIPO_REPORTE = False
                Me.ucCriteriosComparativo1.VerZONA = True

                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                If lZafra IsNot Nothing Then
                    ucCriteriosComparativo1.ID_ZAFRA1 = lZafra.ID_ZAFRA - 1
                    ucCriteriosComparativo1.ID_ZAFRA2 = lZafra.ID_ZAFRA
                End If
        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            If Me.PARAMETROS Is Nothing Then Return
            Select Case Me.ID_REPORTE
                Case 1
                    Select Case PARAMETROS("TIPO_REPORTE")
                        Case 1
                            Dim reporte As New Comparativo2ZafrasGeneral
                            reporte.Cargar(CInt(PARAMETROS("ID_ZAFRA1")), CInt(PARAMETROS("ID_ZAFRA2")), CDec(PARAMETROS("RENDIMIENTO")), CDec(PARAMETROS("VIP")), PARAMETROS("CODIPROVEEDOR"), False)
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 2
                            Dim reporte As New Comparativo2Zafras
                            reporte.Cargar(CInt(PARAMETROS("ID_ZAFRA1")), CInt(PARAMETROS("ID_ZAFRA2")), CDec(PARAMETROS("RENDIMIENTO")), CDec(PARAMETROS("VIP")), PARAMETROS("CODIPROVEEDOR"), True)
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Case 3
                            Dim reporte As New Comparativo2ZafrasLote
                            reporte.Cargar(CInt(PARAMETROS("ID_ZAFRA1")), CInt(PARAMETROS("ID_ZAFRA2")), CDec(PARAMETROS("RENDIMIENTO")), CDec(PARAMETROS("VIP")), PARAMETROS("CODIPROVEEDOR"), False)
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                    End Select

                Case 2
                    Dim reporte As New ComparativoRendimientoLotes
                    reporte.CargarDatos(PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("ZONA"), "", CInt(PARAMETROS("ID_ZAFRA1")), CInt(PARAMETROS("ID_ZAFRA2")))
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
                    If Me.ucCriteriosComparativo1.ID_ZAFRA1 = -1 Then
                        Me.AsignarMensaje("Seleccione la zafra inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosComparativo1.ID_ZAFRA2 = -1 Then
                        Me.AsignarMensaje("Seleccione la zafra final", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosComparativo1.RENDIMIENTO = -1 Then
                        Me.AsignarMensaje("Ingrese el rendimiento", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosComparativo1.VIP = -1 Then
                        Me.AsignarMensaje("Ingrese el valor inicial de pago", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosComparativo1.TIPO_REPORTE = -1 Then
                        Me.AsignarMensaje("Seleccione el tipo de reporte", False, True, True)
                        Return
                    End If

                    Me.PARAMETROS.Add("ID_ZAFRA1", Me.ucCriteriosComparativo1.ID_ZAFRA1)
                    Me.PARAMETROS.Add("ID_ZAFRA2", Me.ucCriteriosComparativo1.ID_ZAFRA2)
                    Me.PARAMETROS.Add("RENDIMIENTO", Me.ucCriteriosComparativo1.RENDIMIENTO)
                    Me.PARAMETROS.Add("VIP", Me.ucCriteriosComparativo1.VIP)
                    Me.PARAMETROS.Add("CODIPROVEEDOR", Me.ucCriteriosComparativo1.CODIPROVEE)
                    Me.PARAMETROS.Add("TIPO_REPORTE", Me.ucCriteriosComparativo1.TIPO_REPORTE)

                Case 2
                    If Me.ucCriteriosComparativo1.ID_ZAFRA1 = -1 Then
                        Me.AsignarMensaje("Seleccione la zafra inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriteriosComparativo1.ID_ZAFRA2 = -1 Then
                        Me.AsignarMensaje("Seleccione la zafra final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS.Add("ID_ZAFRA1", Me.ucCriteriosComparativo1.ID_ZAFRA1)
                    Me.PARAMETROS.Add("ID_ZAFRA2", Me.ucCriteriosComparativo1.ID_ZAFRA2)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriteriosComparativo1.CODIPROVEE)
                    Me.PARAMETROS.Add("CODISOCIO", Me.ucCriteriosComparativo1.CODISOCIO)
                    Me.PARAMETROS.Add("ZONA", Me.ucCriteriosComparativo1.ZONA)

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
