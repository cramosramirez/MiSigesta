Imports SISPACAL.EL
Imports SISPACAL.BL

Partial Class controlesContrato_ucBusquedaTransportista
    Inherits ucBase
    Public Event Aceptar(ByVal CODTRANSPORT As String)
    Public Event Cancelar()

    Public ReadOnly Property Transportista As TRANSPORTISTA
        Get
            Dim lista As listaTRANSPORTISTA = Me.ucListaTRANSPORTISTA1.DevolverSeleccionados
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                Return lista(0)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Sub Inicializar()
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.ucListaTRANSPORTISTA1.CargarDatosPorNombreCompleto("~")
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.txtNOMBRE_TRANSPORTISTA.Text.Trim <> "" Then
            Me.ucListaTRANSPORTISTA1.CargarDatosPorNombreCompleto(Me.txtNOMBRE_TRANSPORTISTA.Text.Trim)
        Else
            Me.AsignarMensaje("Ingrese parte del nombre del transportista", False, True, True)
        End If
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Transportista Is Nothing Then
            Me.AsignarMensaje("Seleccione un transportista", False, True, True)
        Else
            RaiseEvent Aceptar(Transportista.CODTRANSPORT)
        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        RaiseEvent Cancelar()
    End Sub

End Class
