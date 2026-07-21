Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.RL
Imports SISPACAL.DL
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.Common
Imports System.Data
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports System.Collections.Generic

Partial Class controles_ucReporteEstimacionAnticipoRoza
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
                Dim listaCampos As New List(Of CampoOrdenamiento)
                Me.lblTitulo.Text = "REPORTE: ESTIMACION DE ANTICIPO A FRENTES DE ROZA PARTICULARES"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerRANGO_DIAS_ZAFRA = True

            Case 2
                Me.lblTitulo.Text = "REPORTE: PAGARE DE ANTICIPO POR PLANILLA"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False

            Case 3
                Me.lblTitulo.Text = "REPORTE: RECIBOS VARIOS DE PRODUCTOR"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False
                Me.ucCriterios1.VerGRUPO_DESCUENTO = True

            Case 4
                Me.lblTitulo.Text = "REPORTE: COMBUSTIBLE PENDIENTE DE PAGO"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = False
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False
                Me.ucCriterios1.VerGRUPO_DESCUENTO = False

            Case 5
                Me.lblTitulo.Text = "REPORTE: RECIBOS VARIOS DE TRANSPORTE"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = True
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False
                Me.ucCriterios1.VerGRUPO_DESCUENTO = True

            Case 6
                Me.lblTitulo.Text = "REPORTE: RECIBO DE COMBUSTIBLE CONSOLIDADO"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = False
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False
                Me.ucCriterios1.VerGRUPO_DESCUENTO = False

            Case 7
                Me.lblTitulo.Text = "REPORTE: CARGADO POR PRODUCTOR / EQUIPO / LOTE"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerID_CATORCENA = True
                Me.ucCriterios1.VerID_TIPO_PLANILLA = False
                Me.ucCriterios1.VerTIPO_CONTRIBUYENTE = False
                Me.ucCriterios1.VerGRUPO_DESCUENTO = False

        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            Select Me.ID_REPORTE
                Case 1
                    Dim reporte As New EstimacionAnticipoFrenteRoza
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), PARAMETROS("DIA_ZAFRA_INICIAL"), PARAMETROS("DIA_ZAFRA_FINAL"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 2
                    If Me.PARAMETROS IsNot Nothing Then
                        Dim reporte As New PagareAnticipo
                        reporte.CargarDatos(CInt(PARAMETROS("ID_PLANILLA_BASE")), PARAMETROS("FECHA_EMISION"), PARAMETROS("FECHA_PAGO"), _
                                           PARAMETROS("USUARIO_CREA"), PARAMETROS("FECHA_CREA"), 0)
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 3
                    If Me.PARAMETROS IsNot Nothing Then
                        Dim reporte As New ReciboProductor
                        reporte.CargarDatos(CInt(PARAMETROS("ID_CATORCENA")), CInt(PARAMETROS("ID_TIPO_PLANILLA")), CInt(PARAMETROS("ID_GRUPO_DESC")))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 4
                    If Me.PARAMETROS IsNot Nothing Then
                        Dim reporte As New CombustibleSaldoPendiente
                        reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CATORCENA")))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 5
                    If Me.PARAMETROS IsNot Nothing Then
                        Dim reporte As New ReciboTransporte
                        reporte.CargarDatos(CInt(PARAMETROS("ID_CATORCENA")), CInt(PARAMETROS("ID_TIPO_PLANILLA")), CInt(PARAMETROS("ID_GRUPO_DESC")))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 6
                    If Me.PARAMETROS IsNot Nothing Then
                        Dim reporte As New ReciboConsolidadoCombustible
                        reporte.CargarDatos(CInt(PARAMETROS("ID_CATORCENA")))
                        reporte.ResumeLayout()
                        Me.ucVisorReporte1.CargarDatos(reporte)
                    End If

                Case 7
                    If Me.PARAMETROS IsNot Nothing Then
                        Dim reporte As New DetalleProductorCargadoraLotes
                        reporte.CargarDatos(CInt(PARAMETROS("ID_CATORCENA")))
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
            If Me.ucCriterios1.ID_ZAFRA = -1 Then
                Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                Return
            End If

            Select Case Me.ID_REPORTE
                Case 1
                    If Me.ucCriterios1.DIA_ZAFRA_INICIAL = -1 Then
                        Me.AsignarMensaje("Seleccione un dia zafra inicial", False, True, True)
                        Return
                    End If
                    If Me.ucCriterios1.DIA_ZAFRA_FINAL = -1 Then
                        Me.AsignarMensaje("Seleccione un dia zafra final", False, True, True)
                        Return
                    End If
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Me.PARAMETROS.Add("ID_ZAFRA", ucCriterios1.ID_ZAFRA)
                    Me.PARAMETROS.Add("DIA_ZAFRA_INICIAL", ucCriterios1.DIA_ZAFRA_INICIAL)
                    Me.PARAMETROS.Add("DIA_ZAFRA_FINAL", ucCriterios1.DIA_ZAFRA_FINAL)

                Case 2
                    Dim lstPlanilla As listaPLANILLA = (New cPLANILLA).ObtenerListaPorCRITERIOS(Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, "", "", False)

                    If lstPlanilla IsNot Nothing AndAlso lstPlanilla.Count > 0 Then
                        Me.PARAMETROS = New Dictionary(Of String, String)
                        Me.PARAMETROS.Add("ID_PLANILLA_BASE", lstPlanilla(0).ID_PLANILLA_BASE)
                        Me.PARAMETROS.Add("FECHA_EMISION", cFechaHora.ObtenerFecha)
                        Me.PARAMETROS.Add("FECHA_PAGO", cFechaHora.ObtenerFecha)
                        Me.PARAMETROS.Add("USUARIO_CREA", Me.ObtenerUsuario)
                        Me.PARAMETROS.Add("FECHA_CREA", cFechaHora.ObtenerFechaHora)
                    End If

                Case 4
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA)
                    Me.PARAMETROS.Add("ID_CATORCENA", Me.ucCriterios1.ID_CATORCENA)
                       

                Case 3, 5
                    Dim lstPlanilla As listaPLANILLA = (New cPLANILLA).ObtenerListaPorCRITERIOS(Me.ucCriterios1.ID_CATORCENA, Me.ucCriterios1.ID_TIPO_PLANILLA, "", "", False)

                    If Me.ucCriterios1.ID_GRUPO_DESC = -1 Then
                        Me.AsignarMensaje("Seleccione el tipo de descuento", False, True, True)
                        Return
                    End If
                    If lstPlanilla IsNot Nothing AndAlso lstPlanilla.Count > 0 Then
                        Me.PARAMETROS = New Dictionary(Of String, String)
                        Me.PARAMETROS.Add("ID_CATORCENA", Me.ucCriterios1.ID_CATORCENA)
                        Me.PARAMETROS.Add("ID_TIPO_PLANILLA", Me.ucCriterios1.ID_TIPO_PLANILLA)
                        Me.PARAMETROS.Add("ID_GRUPO_DESC", Me.ucCriterios1.ID_GRUPO_DESC)
                    End If

                Case 6, 7
                    Me.PARAMETROS = New Dictionary(Of String, String)
                    Me.PARAMETROS.Add("ID_CATORCENA", Me.ucCriterios1.ID_CATORCENA)

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
