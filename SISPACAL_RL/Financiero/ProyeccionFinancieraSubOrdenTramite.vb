Public Class ProyeccionFinancieraSubOrdenTramite

    Public Sub CargarDetalle(ByVal ID_ENCA As Int32)
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERA_DOCTOTableAdapter1.FillPorIdEnca(Me.DS_SIFAG1.PROYECCION_FINANCIERA_DOCTO, ID_ENCA)
    End Sub

End Class