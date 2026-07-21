Public Class LiquidacionContribuyentePlanilla

    Public Sub CargarDatos(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Integer, ByVal CODIGO As String)
        Me.DS_CATORCENA1.Clear()
        Me.RPT_LIQUIDACION_PLANILLA_CATORCENATableAdapter1.FillPorCriterios(Me.DS_CATORCENA1.RPT_LIQUIDACION_PLANILLA_CATORCENA,
                                ID_CATORCENA, ID_TIPO_PLANILLA, CODIGO)
    End Sub
End Class