Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class AnalisisPrecosechaPorLote


    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, Optional ZONA As String = "")
        Me.DS_SIFAG1.Clear()
        Me.RPT_ANALISIS_PRECOSECHA_X_LOTETableAdapter1.FillPorZafraProvee(Me.DS_SIFAG1.RPT_ANALISIS_PRECOSECHA_X_LOTE, ID_ZAFRA, CODIPROVEEDOR, ZONA)

        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then
            xlblSubtitulo.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If
    End Sub

End Class