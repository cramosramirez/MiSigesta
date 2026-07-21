Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesContrato_ucAsignacionLotes
    Inherits ucBase

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("AsignarLoteTecnico", "Asignar lotes a técnico", False, IconoBarra.Generar, "onclick", "e.processOnServer=false;MostrarPopup(true)", True)
        Me.ucBarraNavegacion1.CrearOpcion("AsignarZonaTecnico", "Asignar zona a técnico", False, IconoBarra.Generar, , , True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
    
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                Dim idZafra As Int32 = 0

                If lZafra IsNot Nothing Then idZafra = lZafra.ID_ZAFRA
                Me.ucListaLOTES1.ID_ZAFRA = idZafra
                Me.ucListaLOTES1.CargarDatosPorCriterios2(idZafra,
                                                        Me.ucCriteriosLotes1.ZONA,
                                                        Me.ucCriteriosLotes1.SUB_ZONA,
                                                        Me.ucCriteriosLotes1.CODI_DETO,
                                                        Me.ucCriteriosLotes1.CODI_MUNI,
                                                        Me.ucCriteriosLotes1.CODI_CANTON,
                                                        Me.ucCriteriosLotes1.CODIPROVEE,
                                                        Me.ucCriteriosLotes1.CODISOCIO,
                                                        Me.ucCriteriosLotes1.NOMBRE_PROVEEDOR)
            Case "AsignarLoteTecnico"
                Me.lblZona.ClientVisible = False
                Me.cbxZONA.ClientVisible = False
                Me.pcAsignarTecnico.ShowOnPageLoad = True

            Case "AsignarZonaTecnico"
                Me.lblZona.ClientVisible = True
                Me.cbxZONA.ClientVisible = True
                Me.cbxZONA.SelectedIndex = 0
                Me.pcAsignarTecnico.ShowOnPageLoad = True
        End Select
    End Sub

    'Protected Sub cpAsignacionLotes_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpAsignacionLotes.Callback
    '    cpAsignacionLotes.JSProperties.Clear()
    '    cpAsignacionLotes.JSProperties.Add("cpResultado", "")
    '    If cbxAGRONOMO.Value = Nothing Then
    '        cpAsignacionLotes.JSProperties("cpResultado") = "Seleccione un Tecnico Agricola"
    '        Return
    '    End If
    '    Dim lstLotes As listaLOTES = ucListaLOTES1.DevolverSeleccionados
    '    Dim bLotes As New cLOTES
    '    Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

    '    Me.lblZona.ClientVisible = False
    '    Me.cbxZONA.ClientVisible = False

    '    If lstLotes IsNot Nothing AndAlso lstLotes.Count > 0 Then
    '        For i As Integer = 0 To lstLotes.Count - 1
    '            bLotes.AsignarAgronomo("LOTE", lZafraActiva.ID_ZAFRA, "", lstLotes(i).ACCESLOTE, cbxAGRONOMO.Value, Me.ObtenerUsuario)
    '        Next
    '        Me.ucListaLOTES1.DataBind()
    '        cpAsignacionLotes.JSProperties("cpResultado") = "OK"
    '    End If
    'End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim bLotes As New cLOTES
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lstLotes As listaLOTES = ucListaLOTES1.DevolverSeleccionados

        If cbxAGRONOMO.Value Is Nothing OrElse cbxAGRONOMO.Text.Trim.ToUpper.Contains("seleccio") Then
            AsignarMensaje("Seleccione un Tecnico Agricola", False, True, True)
            Return
        End If
        If cbxZONA.ClientVisible AndAlso cbxZONA.Value Is Nothing Then
            AsignarMensaje("Seleccione una zona", False, True, True)
            Return
        End If

        If cbxZONA.ClientVisible Then
            bLotes.AsignarAgronomo("ZONA", lZafraActiva.ID_ZAFRA, cbxZONA.Value, "", cbxAGRONOMO.Value, Me.ObtenerUsuario)
        Else
            If lstLotes IsNot Nothing AndAlso lstLotes.Count > 0 AndAlso lZafraActiva IsNot Nothing Then
                For i As Integer = 0 To lstLotes.Count - 1
                    bLotes.AsignarAgronomo("LOTE", lZafraActiva.ID_ZAFRA, "", lstLotes(i).ACCESLOTE, cbxAGRONOMO.Value, Me.ObtenerUsuario)
                Next
            End If
        End If

        Me.pcAsignarTecnico.ShowOnPageLoad = False
        Me.ucListaLOTES1.QuitarSeleccion()
        AsignarMensaje("Asignacion realizada.", False, True, True)
        Me.ucListaLOTES1.DataBind()
    End Sub
End Class

