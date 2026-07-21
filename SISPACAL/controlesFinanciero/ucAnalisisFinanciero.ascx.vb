Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web
Imports System.Data
Imports System.IO

Partial Class controlesFinanciero_ucAnalisisFinanciero
    Inherits ucBase



    Public Property ID_CONTRATO_FINAN As Int32
        Get
            If Me.ViewState("ID_CONTRATO_FINAN") IsNot Nothing Then
                Return Convert.ToInt32(Me.ViewState("ID_CONTRATO_FINAN"))
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            If Me.ViewState("ID_CONTRATO_FINAN") IsNot Nothing Then Me.ViewState("ID_CONTRATO_FINAN") = value Else Me.ViewState.Add("ID_CONTRATO_FINAN", value)
        End Set
    End Property

    Public Property UID_REF As String
        Get
            If Me.ViewState("UID_REF") IsNot Nothing Then
                Return Me.ViewState("UID_REF")
            Else
                Return ""
            End If
        End Get
        Set(value As String)
            If Me.ViewState("UID_REF") IsNot Nothing Then Me.ViewState("UID_REF") = value Else Me.ViewState.Add("UID_REF", value)
        End Set
    End Property

    Public Property CODIPROVEEDOR As String
        Get
            If Me.ViewState("CODIPROVEEDOR") IsNot Nothing Then
                Return Me.ViewState("CODIPROVEEDOR")
            Else
                Return ""
            End If
        End Get
        Set(value As String)
            If Me.ViewState("CODIPROVEEDOR") IsNot Nothing Then Me.ViewState("CODIPROVEEDOR") = value Else Me.ViewState.Add("CODIPROVEEDOR", value)
        End Set
    End Property

    Public Property CONTRATOS As String
        Get
            If Me.ViewState("CONTRATOS") IsNot Nothing Then
                Return Me.ViewState("CONTRATOS")
            Else
                Return ""
            End If
        End Get
        Set(value As String)
            If Me.ViewState("CONTRATOS") IsNot Nothing Then Me.ViewState("CONTRATOS") = value Else Me.ViewState.Add("CONTRATOS", value)
        End Set
    End Property


    Private Sub CargarContratos()
        Dim lCodiProvee As String
        If Me.speCODIPROVEE.Value IsNot Nothing AndAlso Me.speCODIPROVEE.Value > 0 AndAlso Me.cbxZAFRA.Value IsNot Nothing Then
            lCodiProvee = Utilerias.FormatearCODIPROVEEDOR(Me.speCODIPROVEE.Value)
            Me.ucListaCONTRATO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, -1, lCodiProvee, "")
        Else
            Me.ucListaCONTRATO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, -1, "", "")
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Private Sub Limpiar()
        Me.speCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.CargarContratos()
        'Me.CargarInfoFinancieraContrato(-1)
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("AnalisisFinanciero", "Ver Analisis Financiero", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarExcel", "Generar todos los financiamientos de la zafra", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Reporte", "Ver Reporte", False, IconoBarra.Reporte, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("ReporteNuevo", "Ver Reporte (Nueva version)", False, IconoBarra.Reporte, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("SolicitudAgricola", "Solicitud Agricola", False, IconoBarra.Reporte, "onclick", "e.processOnServer=false;CrearSolicAgricola()", True)
        Me.ucBarraNavegacion1.CrearOpcion("SolicitudOPI", "OPI", False, IconoBarra.Reporte, "onclick", "e.processOnServer=false;CrearSolicOPI()", True)
        Me.ucBarraNavegacion1.CrearOpcion("SolicitudAnticipo", "Anticipo", False, IconoBarra.Reporte, "onclick", "e.processOnServer=false;CrearSolicAnticipo()", True)
        Me.ucBarraNavegacion1.CrearOpcion("Membresia", "Mebresia Gremial", False, IconoBarra.Reporte, "onclick", "e.processOnServer=false;CrearSolicMembresia()", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
    End Sub

    Private Sub InicializarDetalle()
        Dim bPreAnalisisEnca As New cPRE_ANALISIS_ENCA
        Dim lstPreAnalisisEnca As listaPRE_ANALISIS_ENCA
        Dim listaContratos As listaCONTRATO = Me.ucListaCONTRATO1.DevolverSeleccionados
        Dim sContratos As New StringBuilder
        Dim sCodiProveedor As String = ""
        Dim lZafraCol As ZAFRA

        'Verificar que se ha seleccionado al menos un contrato
        If listaContratos Is Nothing OrElse listaContratos.Count = 0 Then
            Me.AsignarMensaje("Seleccione al menos un Contrato", False, True)
            Exit Sub
        End If

        'Verificar que los contratos seleccionados pertenezcan al mismo productor
        For i As Int32 = 0 To listaContratos.Count - 1
            If sCodiProveedor = "" Then
                sCodiProveedor = listaContratos(i).CODIPROVEEDOR
            ElseIf sCodiProveedor <> listaContratos(i).CODIPROVEEDOR Then
                Me.AsignarMensaje("Solo debe seleccionar Contratos que pertencezcan a un mismo proveedor", False, True)
                Exit Sub
            End If

            sContratos.Append(listaContratos(i).CODICONTRATO)
            sContratos.Append(";")
        Next

        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("AnalisisFinanciero", False)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", False)
        Me.ucBarraNavegacion1.VerOpcion("Reporte", True)
        Me.ucBarraNavegacion1.VerOpcion("ReporteNuevo", True)
        Me.ucBarraNavegacion1.VerOpcion("SolicitudAgricola", False)
        Me.ucBarraNavegacion1.VerOpcion("SolicitudOPI", False)
        Me.ucBarraNavegacion1.VerOpcion("SolicitudAnticipo", False)
        Me.ucBarraNavegacion1.VerOpcion("Membresia", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)

        Me.UID_REF = Guid.NewGuid.ToString
        Me.CODIPROVEEDOR = sCodiProveedor
        Me.CONTRATOS = sContratos.ToString

        bPreAnalisisEnca.PROC_Generar_Pre_Analisis_Finan(Me.cbxZAFRA.Value, Me.cbxZAFRA.Value + 5, sCodiProveedor, sContratos.ToString, Me.UID_REF, cFechaHora.ObtenerFecha, Me.ObtenerUsuario)

        lstPreAnalisisEnca = bPreAnalisisEnca.ObtenerListaPorUID_REF(Me.UID_REF)
        If lstPreAnalisisEnca IsNot Nothing AndAlso lstPreAnalisisEnca.Count > 0 Then
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lstPreAnalisisEnca(0).CODIPROVEEDOR)
            Me.txtFECHA.Text = cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy")
            Me.txtCODIPROVEEDOR.Text = lProveedor.CODIPROVEE
            Me.txtNOMBRE_PRODUCTOR.Text = lstPreAnalisisEnca(0).NOMBRE_PROVEEDOR
            Me.txtZONAS.Text = lstPreAnalisisEnca(0).ZONAS
            Me.txtCONTRATOS.Text = lstPreAnalisisEnca(0).CONTRATOS
        End If

        lZafraCol = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value)
        If lZafraCol IsNot Nothing Then Me.ucListaPRE_ANALISIS_DETA1.TextoHeaderZAFRA1 = "ZAFRA " + lZafraCol.NOMBRE_ZAFRA
        lZafraCol = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value + 1)
        If lZafraCol IsNot Nothing Then Me.ucListaPRE_ANALISIS_DETA1.TextoHeaderZAFRA2 = "ZAFRA " + lZafraCol.NOMBRE_ZAFRA
        lZafraCol = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value + 2)
        If lZafraCol IsNot Nothing Then Me.ucListaPRE_ANALISIS_DETA1.TextoHeaderZAFRA3 = "ZAFRA " + lZafraCol.NOMBRE_ZAFRA
        lZafraCol = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value + 3)
        If lZafraCol IsNot Nothing Then Me.ucListaPRE_ANALISIS_DETA1.TextoHeaderZAFRA4 = "ZAFRA " + lZafraCol.NOMBRE_ZAFRA
        lZafraCol = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value + 4)
        If lZafraCol IsNot Nothing Then Me.ucListaPRE_ANALISIS_DETA1.TextoHeaderZAFRA5 = "ZAFRA " + lZafraCol.NOMBRE_ZAFRA
        lZafraCol = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value + 5)
        If lZafraCol IsNot Nothing Then Me.ucListaPRE_ANALISIS_DETA1.TextoHeaderZAFRA6 = "ZAFRA " + lZafraCol.NOMBRE_ZAFRA

        Me.ucListaPRE_ANALISIS_DETA1.CargarDatosPorUID_REF(Me.UID_REF)

        Me.trCriterios.Visible = False
        Me.trFinanciamiento.Visible = True
    End Sub

    Private Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("AnalisisFinanciero", True)
        Me.ucBarraNavegacion1.VerOpcion("GenerarExcel", True)
        Me.ucBarraNavegacion1.VerOpcion("Reporte", False)
        Me.ucBarraNavegacion1.VerOpcion("ReporteNuevo", False)
        Me.ucBarraNavegacion1.VerOpcion("SolicitudAgricola", False)
        Me.ucBarraNavegacion1.VerOpcion("SolicitudOPI", False)
        Me.ucBarraNavegacion1.VerOpcion("SolicitudAnticipo", False)
        Me.ucBarraNavegacion1.VerOpcion("Membresia", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)

        Me.trCriterios.Visible = True
        Me.trFinanciamiento.Visible = False
    End Sub


    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar" Then
            Dim lCodiProvee As String = ""
            If Me.speCODIPROVEE.Value IsNot Nothing AndAlso Me.speCODIPROVEE.Value > 0 AndAlso Me.cbxZAFRA.Value IsNot Nothing Then
                lCodiProvee = Utilerias.FormatoCODIPROVEE(Me.speCODIPROVEE.Value)
            End If
            Me.ucListaCONTRATO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, -1, lCodiProvee, "")

        ElseIf CommandName = "AnalisisFinanciero" Then
            Me.InicializarDetalle()

        ElseIf CommandName = "Cancelar" Then
            Me.InicializarLista()

        ElseIf CommandName = "GenerarExcel" Then
            Dim dt As DataTable = (New cPRE_ANALISIS_ENCA).ReporteExcelFinancieroProductores(Me.cbxZAFRA.Value)
            Me.ExportToExcel(dt, "FinanciamientoProductores" & Now.ToString("dd/MM/yyyy hh.mm.ss") & ".xls")

        ElseIf CommandName = "Reporte" Then
            Dim bPreAnalisis As New cPRE_ANALISIS_ENCA
            Dim lstPreAnalisis As listaPRE_ANALISIS_ENCA = bPreAnalisis.ObtenerListaPorUID_REF(Me.UID_REF)
            If lstPreAnalisis IsNot Nothing AndAlso lstPreAnalisis.Count > 0 Then
                lstPreAnalisis(0).COMENTARIO = Left(Me.txtOBSERVACIONES.Text.Trim.ToUpper, 2000)
                lstPreAnalisis(0).IMPRESO = True
                bPreAnalisis.ActualizarPRE_ANALISIS_ENCA(lstPreAnalisis(0))
            End If
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarProyeccionFinanciera('" + Me.UID_REF + "')", True)
        ElseIf CommandName = "ReporteNuevo" Then
            Dim bPreAnalisisEnca As New cPRE_ANALISIS_ENCA
            Me.UID_REF = Guid.NewGuid.ToString

            bPreAnalisisEnca.PROC_Generar_Analisis_Financiero_proyectado(Me.cbxZAFRA.Value, Me.cbxZAFRA.Value + 5, Me.CODIPROVEEDOR, Me.CONTRATOS, Me.UID_REF, cFechaHora.ObtenerFecha, Me.ObtenerUsuario)

            Dim bPreAnalisis As New cPRE_ANALISIS_ENCA
            Dim lstPreAnalisis As listaPRE_ANALISIS_ENCA = bPreAnalisis.ObtenerListaPorUID_REF(Me.UID_REF)
            If lstPreAnalisis IsNot Nothing AndAlso lstPreAnalisis.Count > 0 Then
                lstPreAnalisis(0).COMENTARIO = Left(Me.txtOBSERVACIONES.Text.Trim.ToUpper, 2000)
                lstPreAnalisis(0).IMPRESO = True
                bPreAnalisis.ActualizarPRE_ANALISIS_ENCA(lstPreAnalisis(0))
            End If
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarAnalisisFinancieroProyectado('" + Me.UID_REF + "')", True)
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaProveedor1.Inicializar()
        Me.pcBusquedaProveedor.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODIPROVEEDOR As String) Handles ucBusquedaProveedor1.Aceptar
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)

        If lProveedor IsNot Nothing Then
            Me.speCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(lProveedor.CODIPROVEEDOR)
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaProveedor1.Cancelar
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Private Sub ExportToExcel(ByVal dt As DataTable, ByVal nombreArchivo As String)
        'Create a dummy GridView
        If dt IsNot Nothing Then
            For i = 0 To dt.Rows.Count - 1
                dt(i)("CODIPROVEEDOR") = Utilerias.RecuperarCODIPROVEE(dt(i)("CODIPROVEEDOR"))
            Next


            Dim GridView1 As New GridView()
            GridView1.AllowPaging = False
            GridView1.DataSource = dt
            GridView1.DataBind()

            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("content-disposition", "attachment;filename=" & nombreArchivo)
            Response.Charset = ""
            Response.ContentType = "application/vnd.ms-excel"
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)

            GridView1.RenderControl(hw)

            'style to format numbers to string
            Dim style As String = "" '= "<style>.textmode{mso-number-format:\#\,\#\#0\.00;}</style>"
            Response.Write(style)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()
        End If
        
    End Sub
End Class
