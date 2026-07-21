Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class ProyeccionFinancieraTransSubSaldosActuales

    Public Sub Cargar(ByVal CODTRANSPORT As Int32, ByVal ID_ZAFRA As Int32)
        Me.DS_SIFAG1.Clear()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then Me.xrZAFRA.Text = "SALDOS ZAFRA " + lZafra.NOMBRE_ZAFRA

        Me.PROYECCION_FINANCIERA_SALDO_ACTUALTableAdapter1.FillPorCodtransport(Me.DS_SIFAG1.PROYECCION_FINANCIERA_SALDO_ACTUAL, CODTRANSPORT, ID_ZAFRA)
    End Sub
End Class