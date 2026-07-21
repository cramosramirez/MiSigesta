Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class TipoCanaPorDiaZafra

    Public Sub Cargar(ByVal ID_ZAFRA As Integer, ByVal FECHA1 As Date, ByVal FECHA2 As Date)
        Me.DS_SIGESTA1.Clear()
        Dim lDiaZafra As DIA_ZAFRA
        Dim dia1 As Integer
        Dim dia2 As Integer
        Dim maxDiaZafraActivo As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(ID_ZAFRA)


        lDiaZafra = (New cDIA_ZAFRA).ObtenerPorFECHA(FECHA1)
        If lDiaZafra IsNot Nothing Then
            dia1 = lDiaZafra.DIAZAFRA
        Else
            If maxDiaZafraActivo.FECHA = FECHA1 Then
                dia1 = maxDiaZafraActivo.DIAZAFRA
            Else
                dia1 = 0
            End If
        End If

        lDiaZafra = (New cDIA_ZAFRA).ObtenerPorFECHA(FECHA2)
        If lDiaZafra IsNot Nothing Then
            dia2 = lDiaZafra.DIAZAFRA
        Else
            dia2 = maxDiaZafraActivo.DIAZAFRA
        End If
        
        Me.TIPOCANA_POR_DIAZAFRATableAdapter1.FillBy(Me.DS_SIGESTA1.TIPOCANA_POR_DIAZAFRA, ID_ZAFRA, dia1, dia2)
        Me.DisplayName = "TipoCanaPorDiaZafra"
    End Sub
End Class