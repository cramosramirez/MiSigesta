Imports SISPACAL.BL
Imports SISPACAL.EL

Partial Class controlesContrato_ucBusquedaProveedor
    Inherits ucBase
    Public Event Aceptar(ByVal CODIPROVEEDOR As String)
    Public Event Cancelar()

    Public ReadOnly Property Proveedor As PROVEEDOR
        Get
            Dim lista As listaPROVEEDOR = Me.ucListaPROVEEDOR1.DevolverSeleccionados
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                Return lista(0)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Sub Inicializar()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.ucListaPROVEEDOR1.CargarDatosPorNombreCompleto("~")
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.txtNOMBRE_PROVEEDOR.Text.Trim <> "" Then
            Me.ucListaPROVEEDOR1.CargarDatosPorNombreCompleto(Me.txtNOMBRE_PROVEEDOR.Text.Trim)
        Else
            Me.AsignarMensaje("Ingrese parte del nombre del proveedor", False, True, True)
        End If
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Proveedor Is Nothing Then
            Me.AsignarMensaje("Seleccione un proveedor", False, True, True)
        Else
            RaiseEvent Aceptar(Proveedor.CODIPROVEEDOR)
        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        RaiseEvent Cancelar()
    End Sub
End Class
