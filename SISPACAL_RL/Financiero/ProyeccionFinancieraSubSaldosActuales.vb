Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class ProyeccionFinancieraSubSaldosActuales

    Public Sub Cargar(ByVal CODIPROVEEDOR As String, ByVal ID_ZAFRA As Int32)
        Me.DS_SIFAG1.Clear()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then Me.xrZAFRA.Text = "SALDOS ZAFRA " + lZafra.NOMBRE_ZAFRA

        Me.PROYECCION_FINANCIERA_SALDO_ACTUALTableAdapter1.FillPorCodiproveedor(Me.DS_SIFAG1.PROYECCION_FINANCIERA_SALDO_ACTUAL, ID_ZAFRA, CODIPROVEEDOR)
    End Sub
End Class