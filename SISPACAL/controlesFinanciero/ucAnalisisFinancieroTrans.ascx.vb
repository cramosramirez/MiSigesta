Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesFinanciero_ucAnalisisFinancieroTrans
    Inherits ucBase

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


    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub Limpiar()
        Me.speCODTRANSPORT.Value = Nothing
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.ucListaPRE_ANALISIS_DETA_TRANS1.CargarDatosPorUID_REF("~")
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.txtFECHA.Text = cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy")
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Reporte", "Ver Reporte", False, IconoBarra.Reporte, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.ucListaPRE_ANALISIS_DETA_TRANS1.CargarDatosPorUID_REF("~")
    End Sub

    Private Sub MostrarAnalisis()
        Dim bPreAnalisisEncaTrans As New cPRE_ANALISIS_ENCA_TRANS
        Dim lstPreAnalisisEncaTrans As listaPRE_ANALISIS_ENCA_TRANS

        Me.UID_REF = Guid.NewGuid.ToString

        bPreAnalisisEncaTrans.PROC_Generar_Pre_Analisis_Finan_Trans(Me.cbxZAFRA.Value, Me.speCODTRANSPORT.Value, Me.UID_REF, cFechaHora.ObtenerFecha, Me.ObtenerUsuario)

        lstPreAnalisisEncaTrans = bPreAnalisisEncaTrans.ObtenerListaPorUID_REF(Me.UID_REF)
        If lstPreAnalisisEncaTrans IsNot Nothing AndAlso lstPreAnalisisEncaTrans.Count > 0 Then
            Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(lstPreAnalisisEncaTrans(0).CODTRANSPORT)
            Me.txtNOMBRE_TRANSPORTISTA.Text = lstPreAnalisisEncaTrans(0).NOMBRE_TRANSPORTISTA
        End If

        Me.ucListaPRE_ANALISIS_DETA_TRANS1.CargarDatosPorUID_REF(Me.UID_REF)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Cancelar" Then
            Me.Limpiar()

        ElseIf CommandName = "Reporte" Then
            Dim bPreAnalisis As New cPRE_ANALISIS_ENCA_TRANS
            Dim lstPreAnalisis As listaPRE_ANALISIS_ENCA_TRANS = bPreAnalisis.ObtenerListaPorUID_REF(Me.UID_REF)
            If lstPreAnalisis IsNot Nothing AndAlso lstPreAnalisis.Count > 0 Then
                lstPreAnalisis(0).COMENTARIO = ""
                lstPreAnalisis(0).IMPRESO = True
                bPreAnalisis.ActualizarPRE_ANALISIS_ENCA_TRANS(lstPreAnalisis(0))
            End If
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarProyeccionFinancieraTrans('" + Me.UID_REF + "')", True)
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaTransportista1.Inicializar()
        Me.pcBusquedaTransportista.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODTRANSPORT As Int32) Handles ucBusquedaTransportista1.Aceptar
        Dim lEntidad As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(CODTRANSPORT)

        If lEntidad IsNot Nothing Then
            Me.speCODTRANSPORT.Value = lEntidad.CODTRANSPORT
            Me.txtNOMBRE_TRANSPORTISTA.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
        End If
        Me.pcBusquedaTransportista.ShowOnPageLoad = False
        Me.MostrarAnalisis()
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaTransportista1.Cancelar
        Me.pcBusquedaTransportista.ShowOnPageLoad = False
    End Sub

    Protected Sub speCODTRANSPORT_ValueChanged(sender As Object, e As EventArgs) Handles speCODTRANSPORT.ValueChanged
        If speCODTRANSPORT.Value IsNot Nothing Then
            Me.MostrarAnalisis()
        Else
            Me.Limpiar()
        End If
    End Sub
End Class
