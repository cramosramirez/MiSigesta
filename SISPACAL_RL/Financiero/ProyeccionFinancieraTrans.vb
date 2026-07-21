Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class ProyeccionFinancieraTrans

    Private mID_ZAFRA As Int32

    Public Sub CargarDatos(ByVal UID_REF As String)
        Dim encaPreAnalisis As listaPRE_ANALISIS_ENCA_TRANS = (New cPRE_ANALISIS_ENCA_TRANS).ObtenerListaPorUID_REF(UID_REF)
        If encaPreAnalisis IsNot Nothing AndAlso encaPreAnalisis.Count > 0 Then mID_ZAFRA = encaPreAnalisis(0).ID_ZAFRA

        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERA_TRANSTableAdapter1.FillPorUID(DS_SIFAG1.PROYECCION_FINANCIERA_TRANS, UID_REF)
    End Sub

    Public Sub CargarDatosFormatoOIP(ByVal UID_REF As String)
        Dim encaPreAnalisis As listaPRE_ANALISIS_ENCA_TRANS = (New cPRE_ANALISIS_ENCA_TRANS).ObtenerListaPorUID_REF(UID_REF)
        If encaPreAnalisis IsNot Nothing AndAlso encaPreAnalisis.Count > 0 Then mID_ZAFRA = encaPreAnalisis(0).ID_ZAFRA

        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERA_TRANSTableAdapter1.FillPorUID(DS_SIFAG1.PROYECCION_FINANCIERA_TRANS, UID_REF)
    End Sub

    Private Sub sbrSaldosInsolutos_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbrSaldosInsolutos.BeforePrint
        Dim detalle As ProyeccionFinancieraTransSubSaldosInsolutos = TryCast(Me.sbrSaldosInsolutos.ReportSource, ProyeccionFinancieraTransSubSaldosInsolutos)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("CODTRANSPORT") Is DBNull.Value Then
                detalle.Cargar(GetCurrentColumnValue("CODTRANSPORT"), mID_ZAFRA)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub sbrSaldosActuales_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbrSaldosActuales.BeforePrint
        Dim detalle As ProyeccionFinancieraTransSubSaldosActuales = TryCast(Me.sbrSaldosActuales.ReportSource, ProyeccionFinancieraTransSubSaldosActuales)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("CODTRANSPORT") Is DBNull.Value Then
                detalle.Cargar(GetCurrentColumnValue("CODTRANSPORT"), mID_ZAFRA)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub sbrDetalleOrdenTramite_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbrDetalleOrdenTramite.BeforePrint
        Dim detalle As ProyeccionFinancieraTransSubOrdenTramite = TryCast(Me.sbrDetalleOrdenTramite.ReportSource, ProyeccionFinancieraTransSubOrdenTramite)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("ID_ENCA") Is DBNull.Value Then
                detalle.CargarDetalle(CInt(GetCurrentColumnValue("ID_ENCA")))
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

 
End Class