Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.EL
Imports SISPACAL.BL

Partial Class controlesProforma_ucEmisionProforma
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"


    Private Sub CargarCatorcenas()
        Dim lCatorcenas As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, False, "CATORCENA", "DESC")
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerCatorcenasPorZAFRA_TIPO_CICLO(Me.cbxZAFRA.Value, 2)
        If lista Is Nothing Then lista = New List(Of Int32)
        Me.cbxCATORCENA.DataSource = lista
        Me.cbxCATORCENA.DataBind()
        If lCatorcenas IsNot Nothing AndAlso lCatorcenas.Count > 0 Then
            If Me.cbxCATORCENA.Items.FindByValue(lCatorcenas(0).CATORCENA) IsNot Nothing Then
                Me.cbxCATORCENA.SelectedItem = Me.cbxCATORCENA.Items.FindByValue(lCatorcenas(0).CATORCENA)
            End If
        End If
    End Sub

    Private Sub CargarSemanas()
        Dim listaCad As New List(Of String)
        Dim _Catorcena As Int32 = -1
        If Me.cbxCATORCENA.Text <> "" Then _Catorcena = CInt(Me.cbxCATORCENA.Text)
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerSemanasPorZAFRA_TIPO_CICLO_CATORCENA(Me.cbxZAFRA.Value, 2, _Catorcena)
        If lista Is Nothing Then lista = New List(Of Int32)

        listaCad.Add("[Todas]")
        For Each s As Int32 In lista
            listaCad.Add(s.ToString)
        Next
        Me.cbxSEMANA.DataSource = listaCad
        Me.cbxSEMANA.DataBind()
        If cbxSEMANA.Items.Count > 0 Then cbxSEMANA.SelectedItem = cbxSEMANA.Items.FindByValue("[Todas]")
    End Sub

#End Region

    Public Property ID_ZAFRA_ACTUAL As Int32
        Get
            If Me.ViewState("ID_ZAFRA") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_ZAFRA"))
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_ZAFRA") = value
        End Set
    End Property

    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.lblTitulo.Text = "Emisión de Proforma de Envío"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("EmitirProforma", False)
        Me.ucCriteriosRegistroInventarioQuemaRoza.Visible = True
        Me.ucListaPLAN_COSECHA1.Visible = True
        Me.ucEnvioProforma1.Visible = False
    End Sub

    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("EmitirProforma", True)
        Me.ucCriteriosRegistroInventarioQuemaRoza.Visible = False
        Me.ucListaPLAN_COSECHA1.Visible = False
        Me.ucEnvioProforma1.Visible = True
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim codiAgron As String = cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario)
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Regresar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("EmitirProforma", "Emitir Proforma", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.CargarCatorcenas()
        Me.CargarSemanas()
        Me.ucListaPLAN_COSECHA1.CargarDatosParaProforma(lZafra.ID_ZAFRA, "", "", -1, -1, Nothing, Nothing, "", "", "", -1, "", "", True, 0, cFechaHora.ObtenerFecha)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim ID_ZAFRA As Int32 = -1
                Dim FECHA_INI As Object = Nothing
                Dim FECHA_FIN As Object = Nothing
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""
                Dim NO_CONTRATO As Int32 = -1
                Dim SEMANA As Int32 = -1

                If Me.cbxZAFRA.Value IsNot Nothing Then ID_ZAFRA = cbxZAFRA.Value
                If Me.speCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.speCODIPROVEE.Text))
                If Me.speCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.speCODISOCIO.Text))
                If Me.cbxSEMANA.Value IsNot Nothing AndAlso IsNumeric(Me.cbxSEMANA.Value) Then
                    SEMANA = CInt(Me.cbxSEMANA.Value)
                End If
                Me.ucListaPLAN_COSECHA1.QuitarSeleccion()
                Me.ucListaPLAN_COSECHA1.CargarDatosParaProforma(ID_ZAFRA, Me.cbxZONA.Value, "", -1, SEMANA, FECHA_INI, FECHA_FIN, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text, NO_CONTRATO, "", "", True, 0, cFechaHora.ObtenerFecha)

            Case "EmitirProforma"
                Dim sError As String = ""

                sError = Me.ucEnvioProforma1.EmitirProforma()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                Else
                    Me.ucListaPLAN_COSECHA1.DataBind()
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaPLAN_COSECHA1.DataBind()

               
            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub

    Protected Sub cbxCATORCENA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxCATORCENA.ValueChanged
        Me.CargarSemanas()
    End Sub

    Protected Sub cbxZAFRA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.SelectedIndexChanged
        Me.CargarCatorcenas()
    End Sub

    Protected Sub ucListaPLAN_COSECHA1_EmitiendoProforma(ID_PLAN_COSECHA As Integer) Handles ucListaPLAN_COSECHA1.EmitiendoProforma
        Dim lPlanCosecha As PLAN_COSECHA = (New cPLAN_COSECHA).ObtenerPLAN_COSECHA(ID_PLAN_COSECHA)
        Dim lLoteCosecha As LOTES_COSECHA

        If lPlanCosecha IsNot Nothing Then
            lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lPlanCosecha.ACCESLOTE, lPlanCosecha.ID_ZAFRA)
            If lLoteCosecha IsNot Nothing Then
                If lLoteCosecha.SALDO_ROZA <= 0 Then
                    AsignarMensaje("No se puede emitir proforma debido a que el lote no tiene asignado Saldo de Roza", True, False, False)
                    Return
                End If
                AsignarMensaje("", True, False, False)
                Me.ucEnvioProforma1.ID_LOTES_COSECHA = lLoteCosecha.ID_LOTES_COSECHA
                Me.InicializarDetalle()
            End If
        End If
    End Sub
End Class
