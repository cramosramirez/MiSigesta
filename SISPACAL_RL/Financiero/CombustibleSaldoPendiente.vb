Public Class CombustibleSaldoPendiente
    Dim mID_ZAFRA As Int32
    Dim mID_CATORCENA As Int32

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32)
        Me.DS_SIFAG1.Clear()
        COMBUSTIBLE_SALDO_PENDIENTETableAdapter1.FillPorZafra(DS_SIFAG1.COMBUSTIBLE_SALDO_PENDIENTE, ID_ZAFRA, ID_CATORCENA, 1)

        mID_ZAFRA = ID_ZAFRA
        mID_CATORCENA = ID_CATORCENA
    End Sub

    Private Sub XrSubreport1_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim detalle As CombustibleSaldoResumen = TryCast(Me.XrSubreport1.ReportSource, CombustibleSaldoResumen)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("ZAFRA") Is DBNull.Value Then
                detalle.CargarDatos(mID_ZAFRA, mID_CATORCENA)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class