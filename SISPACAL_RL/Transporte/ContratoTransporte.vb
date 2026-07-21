Public Class ContratoTransporte
    Public Sub CargarDatos(ByVal ID_CONTRA_TRANS As Integer)
        DS_TRANSPORTE1.Clear()
        CONTRATO_TRANSTableAdapter1.FillPorCodTransportista(DS_TRANSPORTE1.CONTRATO_TRANS, ID_CONTRA_TRANS)
    End Sub


End Class