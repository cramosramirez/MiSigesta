Public Class LiquidacionFrenteQuerqueo

    Public Sub CargarDatos(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Integer, ByVal CODIGO As Integer)
        Me.DS_CATORCENA1.Clear()
        Me.RPT_LIQUIDACION_PLANILLA_QUERQUEOTableAdapter1.FillPorCriterios(Me.DS_CATORCENA1.RPT_LIQUIDACION_PLANILLA_QUERQUEO, ID_CATORCENA, ID_TIPO_PLANILLA, CODIGO)
    End Sub
End Class