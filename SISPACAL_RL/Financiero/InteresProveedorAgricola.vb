Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class InteresProveedorAgricola
    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal CODIPROVEEDOR As String, ByVal ID_CUENTA_FINAN As Integer, ByVal ID_CATORCENA As Integer, ByVal ID_PROVEE As Int32, ByVal ID_PLANILLA_BASE As Int32)
        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)
        DS_SIFAG1.Clear()
        INTERES_PROVEE_AGRICOLATableAdapter1.FillPorCriterios(DS_SIFAG1.INTERES_PROVEE_AGRICOLA, ID_PROVEE, CODIPROVEEDOR, ID_CUENTA_FINAN, ID_CATORCENA, ID_PLANILLA_BASE)

        If lCatorcena IsNot Nothing Then Me.xrABONO_CORTE.Text = "ABONO CORTE " + lCatorcena.NO_CATORCENA.ToString
    End Sub

    Private Sub sbrTasas_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbrTasas.BeforePrint
        Dim detalle As InteresProveedorTasas = TryCast(Me.sbrTasas.ReportSource, InteresProveedorTasas)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("ID_PROVEE") Is DBNull.Value Then
                detalle.CargarDatos(CInt(GetCurrentColumnValue("ID_PROVEE")))
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class