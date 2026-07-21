Public Class ProgramacionCosecha

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal FECHA_INI_COSECHA As DateTime, ByVal FECHA_FIN_COSECHA As DateTime, ByVal CODIAGRON As String, ByVal CON_CUOTA_DIARIA As Boolean)
        If FECHA_INI_COSECHA.Year = FECHA_FIN_COSECHA.Year Then
            Me.xrlPERIODO.Text = FECHA_INI_COSECHA.ToString("dd DE MMMM").ToUpper
        Else
            Me.xrlPERIODO.Text = FECHA_INI_COSECHA.ToString("dd DE MMMM yyyy").ToUpper
        End If
        Me.xrlPERIODO.Text += " AL " + FECHA_FIN_COSECHA.ToString("dd DE MMMM yyyy").ToUpper
        If CON_CUOTA_DIARIA Then
            RPT_PROGRAMACION_COSECHATableAdapter1.FillPorCriteriosConCuota(DS_SIGESTA1.RPT_PROGRAMACION_COSECHA, ID_ZAFRA, FECHA_INI_COSECHA, FECHA_FIN_COSECHA, CODIAGRON)
        Else
            RPT_PROGRAMACION_COSECHATableAdapter1.FillPorCriterios(DS_SIGESTA1.RPT_PROGRAMACION_COSECHA, ID_ZAFRA, FECHA_INI_COSECHA, FECHA_FIN_COSECHA, CODIAGRON)
        End If
    End Sub
End Class