Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesCenso_ucFormulaDextrana
    Inherits ucBase


    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()

        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lParametrosCosecha As listaPARAM_PRECOSECHA

        If lZafra IsNot Nothing Then
            txtZAFRA.Text = lZafra.NOMBRE_ZAFRA
            lParametrosCosecha = (New cPARAM_PRECOSECHA).ObtenerListaPorZAFRA(lZafra.ID_ZAFRA)
            If lParametrosCosecha IsNot Nothing AndAlso lParametrosCosecha.Count > 0 Then
                Me.speCONSTANTE_A.Value = lParametrosCosecha(0).CTE_A_DEXTRA
                Me.speCONSTANTE_B.Value = lParametrosCosecha(0).CTE_B_DEXTRA
            Else
                Me.speCONSTANTE_A.Value = 0
                Me.speCONSTANTE_B.Value = 0
            End If
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Guardar" Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
            Dim lParametrosCosecha As listaPARAM_PRECOSECHA
            Dim lEntidad As New PARAM_PRECOSECHA
            Dim bParametro As New cPARAM_PRECOSECHA

            If lZafra IsNot Nothing Then
                txtZAFRA.Text = lZafra.NOMBRE_ZAFRA
                lParametrosCosecha = bParametro.ObtenerListaPorZAFRA(lZafra.ID_ZAFRA)
                If lParametrosCosecha IsNot Nothing AndAlso lParametrosCosecha.Count > 0 Then
                    lEntidad = lParametrosCosecha(0)
                Else
                    lEntidad.ID_PARAM_PRECOSECHA = 0
                End If
                lEntidad.ID_ZAFRA = lZafra.ID_ZAFRA
                lEntidad.USUARIO_CREA = Me.ObtenerUsuario
                lEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                lEntidad.FECHA_CT = cFechaHora.ObtenerFechaHora
                lEntidad.CTE_A_DEXTRA = speCONSTANTE_A.Value
                lEntidad.CTE_B_DEXTRA = speCONSTANTE_B.Value
            End If
            If bParametro.ActualizarPARAM_PRECOSECHA(lEntidad) <= -1 Then
                AsignarMensaje("Error al guardar formula: " + bParametro.sError, True, False)
            Else
                AsignarMensaje("La formula se guardo con exito", False, True, True)
            End If
        End If
    End Sub
End Class
