Public Class InventarioRozaDiarioPorLote

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal FECHA As DateTime, ByVal AUTORIZADO As Int32)
        Me.xrFechaAnterior.Text = DateAdd(DateInterval.Day, -1, FECHA).ToString("dddd").ToUpper + vbCrLf + _
            DateAdd(DateInterval.Day, -1, FECHA).ToString("dd-MM-yyyy")
        Me.xrFechaActual.Text = FECHA.ToString("dddd").ToUpper + vbCrLf + _
            FECHA.ToString("dd-MM-yyyy").ToUpper
        Me.xrFechaProyeccion.Text = "Proyección " + DateAdd(DateInterval.Day, 1, FECHA).ToString("dddd").ToUpper + vbCrLf + _
            DateAdd(DateInterval.Day, 1, FECHA).ToString("dd-MM-yyyy")

        If AUTORIZADO = -1 Then
            Me.PLAN_COSECHA_DIARIOTableAdapter1.FillPorFecha(Me.DS_SIGESTA1.PLAN_COSECHA_DIARIO, FECHA, ID_ZAFRA)
        Else
            Me.PLAN_COSECHA_DIARIOTableAdapter1.FillPorFechaAutorizado(Me.DS_SIGESTA1.PLAN_COSECHA_DIARIO, FECHA, ID_ZAFRA)
        End If
    End Sub
End Class