Public Class ProyeccionFinancieraSubSaldosMutuos


    Public Sub CargarDetalle(ByVal CODIPROVEEDOR As String)
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERA_MUTUOSTableAdapter1.FillPorProveedor(Me.DS_SIFAG1.PROYECCION_FINANCIERA_MUTUOS, CODIPROVEEDOR)
    End Sub
End Class