Imports System.Text
Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class ResultadoAnalisisPrecosechaPorProveedor

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, ByVal FECHA_INI As DateTime, ByVal FECHA_FIN As DateTime, ByVal DIA_ZAFRA As Int32)
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""
        Dim sFechaInicial As String = ""
        Dim sFechaFinal As String = ""

        NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR.ToUpper
        If CODIPROVEE <> "" Then sCodiProvee = Utilerias.FormatoCODIPROVEE(CODIPROVEE)
        If CODISOCIO <> "" Then sCodiSocio = Utilerias.FormatoCODISOCIO(CODISOCIO)
        If FECHA_INI <> #12:00:00 AM# Then sFechaInicial = FECHA_INI.ToString("dd/MM/yyyy")
        If FECHA_FIN <> #12:00:00 AM# Then sFechaFinal = FECHA_FIN.ToString("dd/MM/yyyy")

        Me.DS_SIGESTA1.Clear()
        Me.ANALISIS_LAB_PROVEEDORTableAdapter1.FillPorCriterios(DS_SIGESTA1.ANALISIS_LAB_PROVEEDOR, ID_ZAFRA, sCodiProvee, sCodiSocio, NOMBRE_PROVEEDOR.Replace(" ", "%"), sFechaInicial, sFechaFinal, DIA_ZAFRA)

        If DIA_ZAFRA <> -1 Then
            Me.lblCriterio.Text = "DIA " + DIA_ZAFRA.ToString
        ElseIf sFechaInicial <> "" Then
            Me.lblCriterio.Text = "PERIODO DEL " + sFechaInicial + " AL " + sFechaFinal
        End If
    End Sub

End Class