Public Class PagareAnticipo


    Public Sub CargarDatos(ID_PLANILLA_BASE As Int32, FECHA_EMISION As DateTime, FECHA_PAGO As DateTime, _
                           USUARIO_CREA As String, FECHA_CREA As DateTime, GENERAR As Boolean)
        Me.DS_CATORCENA1.Clear()
        Me.PAGARE_ANTICIPOTableAdapter1.FillPorPlanilla(Me.DS_CATORCENA1.PAGARE_ANTICIPO, _
                                ID_PLANILLA_BASE, FECHA_EMISION, FECHA_PAGO, USUARIO_CREA, FECHA_CREA, GENERAR)
    End Sub
End Class