Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.BL

Partial Class controlesProforma_ucDisponibilidadInventarioRozaPorc
    Inherits ucBase

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
            Me.CargarDatos()
        End If
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Private Sub CargarDatos()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.speDISPO_INVE_ROZA.Value = If(lZafra.DISPO_INVE_ROZA = -1, Nothing, lZafra.DISPO_INVE_ROZA * 100)
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Guardar" Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
            Dim bZafra As New cZAFRA
            Dim lRet As Decimal = -1
            Dim i As Int32 = 0

            If Me.speDISPO_INVE_ROZA.Value IsNot Nothing Then
                If CDec(Me.speDISPO_INVE_ROZA.Value) < CDec(1) OrElse CDec(Me.speDISPO_INVE_ROZA.Value) > CDec(100) Then
                    Me.AsignarMensaje("* Ingrese un porcentaje entre 1 y 100", True, False)
                    Return
                End If
                lRet = CDec(Me.speDISPO_INVE_ROZA.Value) / CDec(100)
            End If
            If lZafra IsNot Nothing Then
                lZafra.DISPO_INVE_ROZA = lRet
                i = bZafra.ActualizarZAFRA(lZafra)
                If i < 0 Then
                    Me.AsignarMensaje("* No se logro actualizar el porcentaje de disponibilidad", True, False)
                Else
                    Me.AsignarMensaje("El porcentaje de disponibilidad ha sido registrado! Haga clic en Cerrar", False, True, True)
                End If
            Else
                Me.AsignarMensaje("* No existe una zafra activa", True, False)
            End If
        End If
    End Sub
End Class
