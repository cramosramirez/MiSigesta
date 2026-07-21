Imports DevExpress.XtraReports.UI

Public Class ReciboCargadora

    Public Sub Cargar(ByVal ID_ZAFRA As Integer, ByVal ID_CATORCENA As Integer, ByVal ES_CONTRIBUYENTE As Boolean)

        Me.DS_CATORCENA1.Clear()
        Me.RECIBO_CARGADORATableAdapter1.FillPorCriterios(Me.DS_CATORCENA1.RECIBO_CARGADORA, ID_ZAFRA, ID_CATORCENA, ES_CONTRIBUYENTE)

        If ES_CONTRIBUYENTE Then
            Me.xrRETENCION.Text = "RETENCION 1% IVA"
            Me.DisplayName = "Recibos para Cargadora Retencion 1 por ciento"
        Else
            Me.xrRETENCION.Text = "RETENCION 13% IVA"
            Me.DisplayName = "Recibos para Cargadora Retencion 13 por ciento"
        End If
    End Sub
    
End Class