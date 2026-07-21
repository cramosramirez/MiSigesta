Public Class ProyeccionFinancieraSubAnalisisTC

    Public Sub CargarAnalisisTC(ByVal ID_ENCA As Integer)
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERA_TCTableAdapter1.FillPorIdEnca(Me.DS_SIFAG1.PROYECCION_FINANCIERA_TC, ID_ENCA)
    End Sub

End Class