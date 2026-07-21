Public Class DoctoSalidaBodega

    Public Sub Cargar(ByVal ID_DOCSAL_ENCA As Int32)
        Me.DS_SIFAG1.Clear()
        Me.DOCUMENTO_SALIDA_BODEGATableAdapter1.FillPorId(DS_SIFAG1.DOCUMENTO_SALIDA_BODEGA, ID_DOCSAL_ENCA)
        Me.DisplayName = "DocumentoSalidadeBodega"
    End Sub

End Class