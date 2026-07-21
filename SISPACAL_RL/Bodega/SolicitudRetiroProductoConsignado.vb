Public Class SolicitudRetiroProductoConsignado
    Private mID_SALBODE_ENCA As Int32

    Public Sub Cargar(ByVal ID_SALBODE_ENCA As Int32)
        mID_SALBODE_ENCA = ID_SALBODE_ENCA
        Me.DS_SIFAG1.Clear()
        Me.SALBODE_ENCATableAdapter1.FillPorId(DS_SIFAG1.SALBODE_ENCA, ID_SALBODE_ENCA)
        Me.DisplayName = "SolicitudRetirodeProductosEnConsignacion"
    End Sub

    Private Sub subrepoDetalle_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles subrepoDetalle.BeforePrint
        Dim detalle As SolicitudRetiroDetalle = TryCast(Me.subrepoDetalle.ReportSource, SolicitudRetiroDetalle)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("ID_SALBODE_ENCA") Is DBNull.Value Then
                detalle.CargarDetalle(mID_SALBODE_ENCA)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class