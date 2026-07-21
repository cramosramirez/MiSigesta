Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class RendimientoDiarioAcumuladoProveedorLote

    Public Sub CargarDatos(ID_ZAFRA As Int32, CODIPROVEE As String, CODISOCIO As String, NOMBRE_PROVEEDOR As String, FECHA_INICIAL As DateTime, FECHA_FINAL As DateTime)
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""
        Dim sFechaInicial As String = ""
        Dim sFechaFinal As String = ""
        Dim lZafra As ZAFRA

        NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR.ToUpper.Replace(" ", "%")
        If CODIPROVEE <> "" Then sCodiProvee = Utilerias.FormatoCODIPROVEE(CODIPROVEE)
        If CODISOCIO <> "" Then sCodiSocio = Utilerias.FormatoCODISOCIO(CODISOCIO)
        If FECHA_INICIAL <> #12:00:00 AM# Then sFechaInicial = FECHA_INICIAL.ToString("dd/MM/yyyy")
        If FECHA_FINAL <> #12:00:00 AM# Then sFechaFinal = FECHA_FINAL.ToString("dd/MM/yyyy")
        Me.RPT_SIGESTA_REND_DIARIO_ACUMULADOTableAdapter1.FillPorCriterios(Me.DS_SIGESTA1.RPT_SIGESTA_REND_DIARIO_ACUMULADO, _
                                                                           ID_ZAFRA, 1, sFechaInicial, sFechaFinal, sCodiProvee, sCodiSocio, NOMBRE_PROVEEDOR)
        lZafra = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then lblZafra.Text = "ZAFRA: " + lZafra.NOMBRE_ZAFRA
        If FECHA_INICIAL <> #12:00:00 AM# Then Me.lblPeriodo.Text = "PERIODO DEL " + sFechaInicial + " AL " + sFechaFinal
        Me.DisplayName = "ENTREGAS POR PROVEEDOR Y LOTE ZAFRA " + Replace(lZafra.NOMBRE_ZAFRA, "/", "=")
    End Sub
End Class