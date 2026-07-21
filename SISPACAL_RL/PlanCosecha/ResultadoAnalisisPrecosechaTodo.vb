Imports System.Text
Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class ResultadoAnalisisPrecosechaTodo

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, ByVal NOMLOTE As String, ByVal FECHA_INI As DateTime, ByVal FECHA_FIN As DateTime)
        Dim sCriterios As New StringBuilder
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""
        Dim sFechaInicial As String = ""
        Dim sFechaFinal As String = ""

        NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR.ToUpper
        NOMLOTE = NOMLOTE.ToUpper
        If CODIPROVEE <> "" Then sCodiProvee = Utilerias.FormatoCODIPROVEE(CODIPROVEE)
        If CODISOCIO <> "" Then sCodiSocio = Utilerias.FormatoCODISOCIO(CODISOCIO)
        If FECHA_INI <> #12:00:00 AM# Then sFechaInicial = FECHA_INI.ToString("dd/MM/yyyy")
        If FECHA_FIN <> #12:00:00 AM# Then sFechaFinal = FECHA_FIN.ToString("dd/MM/yyyy")

        Me.ANALISIS_MUESTRAS_TODOTableAdapter1.FillPorCriterios(DS_SIGESTA1.ANALISIS_MUESTRAS_TODO, ID_ZAFRA, sCodiProvee, sCodiSocio, NOMBRE_PROVEEDOR.Replace(" ", "%"), NOMLOTE.Replace(" ", "%"), sFechaInicial, sFechaFinal)
        If CODIPROVEE <> "" Then
            sCriterios.Append("Cod. Provee.: ")
            sCriterios.Append(CODIPROVEE)
            sCriterios.Append("  ")
        End If
        If CODISOCIO <> "" Then
            sCriterios.Append("Cod. Socio.: ")
            sCriterios.Append(CODISOCIO)
            sCriterios.Append("  ")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            sCriterios.Append("Productor: ")
            sCriterios.Append(NOMBRE_PROVEEDOR)
            sCriterios.Append("  ")
        End If
        If NOMLOTE <> "" Then
            sCriterios.Append("Lote: ")
            sCriterios.Append(NOMLOTE)
            sCriterios.Append("  ")
        End If
        If sFechaInicial <> "" Then
            sCriterios.Append("Periodo: ")
            sCriterios.Append("Del ")
            sCriterios.Append(sFechaInicial)
        End If
        If sFechaFinal <> "" Then
            sCriterios.Append(" al ")
            sCriterios.Append(sFechaFinal)
        End If
        lblCriterios.Text = sCriterios.ToString.Trim
    End Sub

End Class