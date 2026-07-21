Public Class InteresProveedorTasas

    Public Sub CargarDatos(ByVal ID_PROVEE As Int32)
        Me.DS_SIFAG1.Clear()
        Me.INTERES_PROVEE_AGRICOLA_TASATableAdapter1.FillPorProveedor(Me.DS_SIFAG1.INTERES_PROVEE_AGRICOLA_TASA, ID_PROVEE)
    End Sub
End Class