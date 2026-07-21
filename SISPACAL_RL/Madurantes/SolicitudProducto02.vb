Imports SISPACAL.BL
Imports SISPACAL.DL
Imports SISPACAL.EL

Public Class SolicitudProducto02
    Private mID_SOLICITUD As Int32
    Private mAGUA_MZ As Decimal = 0
    Private mAGUA_PRECIO_UNIT As Decimal = 0
    Private mAGUA_TOTAL As Decimal = 0

    Private mRIEGO_MZ As Decimal = 0
    Private mRIEGO_PRECIO_UNIT As Decimal = 0
    Private mRIEGO_TOTAL As Decimal = 0

    Private mSUBTOTAL As Decimal = 0
    Private mIVA As Decimal = 0
    Private mTOTAL As Decimal = 0

    Public Sub CargarSolicitud(ByVal ID_SOLICITUD As Int32)
        Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(ID_SOLICITUD)
        Dim lVuelos As listaSOLIC_AGRICOLA_VUELO = (New cSOLIC_AGRICOLA_VUELO).ObtenerListaPorSOLIC_AGRICOLA(ID_SOLICITUD)
        Me.SolicituD_AGRICOLA_MADURANTETableAdapter1.FillPorSolicitud(Me.DS_SIGESTA1.SOLIC_AGRICOLA_MADURANTE, ID_SOLICITUD)
        Me.mID_SOLICITUD = ID_SOLICITUD
        If lEntidad IsNot Nothing Then
            Dim lCuentaFinan As CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(lEntidad.ID_CUENTA_FINAN)
            mSUBTOTAL = lEntidad.SUB_TOTAL
            mIVA = lEntidad.IVA
            mTOTAL = lEntidad.TOTAL

            If lCuentaFinan IsNot Nothing Then
                Me.xrParrafo1.Text = Me.xrParrafo1.Text.Replace("_", lCuentaFinan.NOMBRE_CUENTA)
            End If
            If lVuelos IsNot Nothing AndAlso lVuelos.Count > 0 Then
                mAGUA_MZ = lVuelos(0).MZ_REGAR_AGUA
                mAGUA_PRECIO_UNIT = lVuelos(0).PRECIO_UNIT_AGUA
                mAGUA_TOTAL = lVuelos(0).PRECIO_TOTAL_AGUA
                mRIEGO_MZ = lVuelos(0).MZ_HORAS_VUELO
                mRIEGO_PRECIO_UNIT = lVuelos(0).PRECIO_UNIT_VUELO
                mRIEGO_TOTAL = lVuelos(0).PRECIO_TOTAL_VUELO
            End If
        End If
    End Sub

    Private Sub XrSubreport1_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim detalle As SolicitudSubReporteLotes = TryCast(Me.XrSubreport1.ReportSource, SolicitudSubReporteLotes)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("NOMBRE_PROVEEDOR") Is DBNull.Value Then
                detalle.CargarLotes(mID_SOLICITUD)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub XrSubreport2_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Dim detalle As SolicitudSubReporteProducto = TryCast(Me.XrSubreport2.ReportSource, SolicitudSubReporteProducto)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("NOMBRE_PROVEEDOR") Is DBNull.Value Then
                detalle.CargarProducto(mID_SOLICITUD, mSUBTOTAL, mIVA, mTOTAL)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class