Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.EL
Imports SISPACAL.BL
Imports SISPACAL.RL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Partial Class controlesFinanciero_ucReporteFinanciero
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

            Case 1 'Proyección Financiera - Solicitud Agrícola
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: PROYECCION FINANCIERA"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("id") IsNot Nothing AndAlso Me.Request.QueryString("id").ToString <> "" Then
                    Dim lSolicAgricola As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(Convert.ToInt32(Me.Request.QueryString("id").ToString))
                    Dim lSolicLotes As listaSOLIC_AGRICOLA_LOTE = (New cSOLIC_AGRICOLA_LOTE).ObtenerListaPorSOLIC_AGRICOLA(Convert.ToInt32(Me.Request.QueryString("id").ToString))
                    If lSolicLotes IsNot Nothing AndAlso lSolicLotes.Count > 0 Then
                        Dim bPreAnalisisEnca As New cPRE_ANALISIS_ENCA
                        Dim sContratos As New StringBuilder
                        Dim sUID_REF As String = Guid.NewGuid.ToString
                        For i As Int32 = 0 To lSolicLotes.Count - 1
                            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lSolicLotes(i).ACCESLOTE)
                            If Not sContratos.ToString.Contains(lLote.CODICONTRATO) Then
                                sContratos.Append(lLote.CODICONTRATO)
                                sContratos.Append(";")
                            End If
                        Next
                        bPreAnalisisEnca.PROC_Generar_Pre_Analisis_Finan(lSolicAgricola.ID_ZAFRA, lSolicAgricola.ID_ZAFRA + 1, lSolicAgricola.CODIPROVEEDOR, sContratos.ToString, sUID_REF, cFechaHora.ObtenerFecha, Me.ObtenerUsuario, lSolicAgricola.TOTAL, 0, "", lSolicAgricola.UID_SOLIC_AGRICOLA.ToString)
                        Me.PARAMETROS.Add("UID", sUID_REF)
                    End If
                    Me.CargarDatosReporte()
                End If

            Case 2 'Proyección Financiera
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: PROYECCION FINANCIERA"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("uid") IsNot Nothing AndAlso Me.Request.QueryString("uid").ToString <> "" Then
                    Dim lPreAnalisis As listaPRE_ANALISIS_ENCA = (New cPRE_ANALISIS_ENCA).ObtenerListaPorUID_REF(Me.Request.QueryString("uid").ToString)

                    If lPreAnalisis IsNot Nothing AndAlso lPreAnalisis.Count > 0 Then
                        Me.PARAMETROS.Add("UID", lPreAnalisis(0).UID_REF)
                    End If
                    Me.CargarDatosReporte()
                End If


            Case 3 'Orden Irrevocable de Pago
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ORDEN IRREVOCABLE DE PAGO"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idopi") IsNot Nothing AndAlso Me.Request.QueryString("idopi").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_OPI", Convert.ToInt32(Me.Request.QueryString("idopi").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 4 'Análisis Financiero de la OPI
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: PROYECCION FINANCIERA"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("id") IsNot Nothing AndAlso Me.Request.QueryString("id").ToString <> "" Then
                    Dim lSolicOIP As SOLIC_OPI = (New cSOLIC_OPI).ObtenerSOLIC_OPI(Convert.ToInt32(Me.Request.QueryString("id").ToString))
                    Dim lSolicLotes As listaSOLIC_OIP_LOTE = (New cSOLIC_OIP_LOTE).ObtenerListaPorSOLIC_OPI(Convert.ToInt32(Me.Request.QueryString("id").ToString))

                    If lSolicLotes IsNot Nothing AndAlso lSolicLotes.Count > 0 Then
                        Dim bPreAnalisisEnca As New cPRE_ANALISIS_ENCA
                        Dim sContratos As New StringBuilder
                        Dim sUID_REF As String = Guid.NewGuid.ToString

                        bPreAnalisisEnca.PROC_Generar_Pre_Analisis_Finan(lSolicOIP.ID_ZAFRA, lSolicOIP.ID_ZAFRA + 1, lSolicOIP.CODIPROVEEDOR, "", sUID_REF, cFechaHora.ObtenerFecha, Me.ObtenerUsuario, lSolicOIP.MONTO, 0, "OIP", lSolicOIP.UID_OPI_CONTRATO.ToString)
                        Me.PARAMETROS.Add("UID", sUID_REF)
                    End If
                    Me.CargarDatosReporte()
                End If

            Case 5 'Análisis Financiero de Anticipo
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ANALISIS FINANCIERO ANTICIPO"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("id") IsNot Nothing AndAlso Me.Request.QueryString("id").ToString <> "" Then
                    Dim lSolicAnticipo As SOLIC_ANTICIPO = (New cSOLIC_ANTICIPO).ObtenerSOLIC_ANTICIPO(Convert.ToInt32(Me.Request.QueryString("id").ToString))
                    Dim lSolicLotes As listaSOLIC_ANTICIPO_LOTE = (New cSOLIC_ANTICIPO_LOTE).ObtenerListaPorSOLIC_ANTICIPO(Convert.ToInt32(Me.Request.QueryString("id").ToString))
                    If lSolicLotes IsNot Nothing AndAlso lSolicLotes.Count > 0 Then
                        Dim bPreAnalisisEnca As New cPRE_ANALISIS_ENCA
                        Dim sContratos As New StringBuilder
                        Dim sUID_REF As String = Guid.NewGuid.ToString

                        bPreAnalisisEnca.PROC_Generar_Pre_Analisis_Finan(lSolicAnticipo.ID_ZAFRA, lSolicAnticipo.ID_ZAFRA + 5, lSolicAnticipo.CODIPROVEEDOR, "", sUID_REF, cFechaHora.ObtenerFecha, Me.ObtenerUsuario, lSolicAnticipo.MONTO, 0, "ANTICIPO", lSolicAnticipo.UID_ANTICIPO_CONTRATO.ToString)
                        Me.PARAMETROS.Add("UID", sUID_REF)
                    End If
                    Me.CargarDatosReporte()
                End If

            Case 6 'Ingreso de Bodega
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: INGRESO DE PRODUCTOS EN CONSIGNACION"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("iddocto") IsNot Nothing AndAlso Me.Request.QueryString("iddocto").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_DOCENTRA_ENCA", Convert.ToInt32(Me.Request.QueryString("iddocto").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 7 'Solicitud de Retiro de Bodega
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: SOLICITUD DE RETIRO DE PRODUCTOS EN CONSIGNACION"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("id") IsNot Nothing AndAlso Me.Request.QueryString("id").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_SALBODE_ENCA", Convert.ToInt32(Me.Request.QueryString("id").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 8 'Salida de Bodega
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: SALIDA DE PRODUCTOS EN CONSIGNACION"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("iddocto") IsNot Nothing AndAlso Me.Request.QueryString("iddocto").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_DOCSAL_ENCA", Convert.ToInt32(Me.Request.QueryString("iddocto").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 9 'Orden Irrevocable de Pago Transportista
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ORDEN IRREVOCABLE DE PAGO"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("idopi") IsNot Nothing AndAlso Me.Request.QueryString("idopi").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_OPI", Convert.ToInt32(Me.Request.QueryString("idopi").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 10 'Solicitud de Insumos para Servicio de transporte
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: SOLICITUD DE INSUMOS PARA SERVICIO DE TRANSPORTE"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("id") IsNot Nothing AndAlso Me.Request.QueryString("id").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_SOLICITUD", Convert.ToInt32(Me.Request.QueryString("id").ToString))
                    Me.CargarDatosReporte()
                End If

            Case 11 'Proyección Financiera Transporte
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: PROYECCION FINANCIERA TRANSPORTE"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("uid") IsNot Nothing AndAlso Me.Request.QueryString("uid").ToString <> "" Then
                    Dim lPreAnalisis As listaPRE_ANALISIS_ENCA_TRANS = (New cPRE_ANALISIS_ENCA_TRANS).ObtenerListaPorUID_REF(Me.Request.QueryString("uid").ToString)

                    If lPreAnalisis IsNot Nothing AndAlso lPreAnalisis.Count > 0 Then
                        Me.PARAMETROS.Add("UID", lPreAnalisis(0).UID_REF)
                    End If
                    Me.CargarDatosReporte()
                End If

            Case 12 'Analisis Financiero
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: ANALISIS FINANCIERO"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("uid") IsNot Nothing AndAlso Me.Request.QueryString("uid").ToString <> "" Then
                    Dim lPreAnalisis As listaPRE_ANALISIS_ENCA = (New cPRE_ANALISIS_ENCA).ObtenerListaPorUID_REF(Me.Request.QueryString("uid").ToString)

                    If lPreAnalisis IsNot Nothing AndAlso lPreAnalisis.Count > 0 Then
                        Me.PARAMETROS.Add("UID", lPreAnalisis(0).UID_REF)
                    End If
                    Me.CargarDatosReporte()
                End If

            Case 13 'Solicitud de Insumos para Frentes
                Me.ucBarraNavegacion1.LimpiarOpciones()
                Me.ucBarraNavegacion1.CrearOpcion("CerrarVentana", "Cerrar", False, IconoBarra.Salir, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("CerrarVentana", True)
                Me.ucBarraNavegacion1.CargarOpciones()
                Me.ucBarraNavegacion1.PermitirSalir = False

                Me.lblTitulo.Text = "REPORTE: SOLICITUD DE INSUMOS PARA FRENTES"

                Me.PARAMETROS = New Dictionary(Of String, Object)
                If Me.Request.QueryString("id") IsNot Nothing AndAlso Me.Request.QueryString("id").ToString <> "" Then
                    Me.PARAMETROS.Add("ID_SOLICITUD", Convert.ToInt32(Me.Request.QueryString("id").ToString))
                    Me.CargarDatosReporte()
                End If

        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            If PARAMETROS Is Nothing Then Return

            Select Case Me.ID_REPORTE
                Case 1, 2
                    Dim reporte As New ProyeccionFinanciera
                    reporte.CargarDatosFormatoOIP_SolicAgricola(PARAMETROS("UID"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 3
                    Dim reporte As New OrdenIrrevocablePago
                    reporte.CargarDatos(CInt(PARAMETROS("ID_OPI")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 4
                    Dim reporte As New ProyeccionFinanciera
                    reporte.CargarDatosFormatoOIP_SolicAgricola(PARAMETROS("UID"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 5
                    Dim reporte As New ProyeccionFinanciera
                    reporte.CargarDatosFormatoAnticipo(PARAMETROS("UID"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 6
                    Dim reporte As New DoctoIngresoBodegaPorTransf
                    reporte.Cargar(CInt(PARAMETROS("ID_DOCENTRA_ENCA")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 7
                    Dim lSalBode As SALBODE_ENCA = (New cSALBODE_ENCA).ObtenerSALBODE_ENCA(CInt(PARAMETROS("ID_SALBODE_ENCA")))
                    If lSalBode IsNot Nothing Then
                        If lSalBode.RETIRO_PROD Then
                            Dim reporte As New SolicitudRetiroProductoConsignadoProductor
                            reporte.Cargar(CInt(PARAMETROS("ID_SALBODE_ENCA")))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        Else
                            Dim reporte As New SolicitudRetiroProductoConsignado
                            reporte.Cargar(CInt(PARAMETROS("ID_SALBODE_ENCA")))
                            reporte.ResumeLayout()
                            Me.ucVisorReporte1.CargarDatos(reporte)
                        End If
                    End If

                Case 8
                    Dim reporte As New DoctoSalidaBodega
                    reporte.Cargar(CInt(PARAMETROS("ID_DOCSAL_ENCA")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 9
                    Dim reporte As New OrdenIrrevocablePagoTransportista
                    reporte.CargarDatos(CInt(PARAMETROS("ID_OPI")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 10
                    Dim reporte As New SolicitudInsumoTransporte
                    reporte.CargarDatos(CInt(PARAMETROS("ID_SOLICITUD")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 11
                    Dim reporte As New ProyeccionFinancieraTrans
                    reporte.CargarDatos(PARAMETROS("UID"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 12
                    Dim reporte As New AnalisisFinanciero
                    reporte.CargarDatosFormatoOIP_SolicAgricola(PARAMETROS("UID"))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

                Case 13
                    Dim reporte As New SolicitudInsumoFrentes
                    reporte.CargarDatos(CInt(PARAMETROS("ID_SOLICITUD")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)
            End Select

        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            Me.PARAMETROS = New Dictionary(Of String, Object)
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
