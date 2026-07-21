
Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class rptSigestaEjec014Compa_Zafra
    Public Sub CargarDatos(ByVal ID_ZAFRA_ACTUAL As Int32, ByVal ID_ZAFRA_COMPA As Int32)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA_ACTUAL)
        Dim diaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(ID_ZAFRA_ACTUAL)

        If lZafra IsNot Nothing Then
            Me.xrZAFRA.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If
        If diaZafra IsNot Nothing Then Me.lblDiaZafra.Text = diaZafra.DIAZAFRA.ToString

        Me.RPT_SIGESTA_EJEC014_COMPA_ZAFRASTableAdapter1.SetCommandTimeOut(900000)
        Me.RPT_SIGESTA_EJEC014_COMPA_ZAFRASTableAdapter1.FillPorCriterios(DS_SIGESTA1.RPT_SIGESTA_EJEC014_COMPA_ZAFRAS, ID_ZAFRA_COMPA, ID_ZAFRA_ACTUAL, diaZafra.DIAZAFRA)
    End Sub
End Class