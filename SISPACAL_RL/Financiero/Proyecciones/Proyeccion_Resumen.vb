Imports System.Drawing.Printing
Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class Proyeccion_Resumen
    Private mID_ZAFRA As Integer

    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)

        If lZafra IsNot Nothing Then lblZAFRA.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA

        Me.DS_SIFAG1.Clear()
        Me.RPT_PROYECCION_RESUMEN_RFTableAdapter1.FillPorCriterios(DS_SIFAG1.RPT_PROYECCION_RESUMEN_RF, "RF", ID_ZAFRA)

        mID_ZAFRA = ID_ZAFRA
    End Sub

    Private Sub sbpPROYECCION_RESUMEN_RA_BeforePrint(sender As Object, e As PrintEventArgs) Handles sbpPROYECCION_RESUMEN_RA.BeforePrint
        Dim detalle As Proyeccion_Resumen_RA = TryCast(Me.sbpPROYECCION_RESUMEN_RA.ReportSource, Proyeccion_Resumen_RA)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("CONCEPTO") Is DBNull.Value Then
                detalle.CargarDatos(mID_ZAFRA)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub sbpPROYECCION_RESUMEN_RPJ_BeforePrint(sender As Object, e As PrintEventArgs) Handles sbpPROYECCION_RESUMEN_RPJ.BeforePrint
        Dim detalle As Proyeccion_Resumen_RPJ = TryCast(Me.sbpPROYECCION_RESUMEN_RPJ.ReportSource, Proyeccion_Resumen_RPJ)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("CONCEPTO") Is DBNull.Value Then
                detalle.CargarDatos(mID_ZAFRA)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class