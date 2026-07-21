Imports SISPACAL.BL
Imports SISPACAL.DL
Imports SISPACAL.EL

Public Class SolicitudMaduranteVuelo
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
            Me.xrCUENTA_FINAN.Text = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(lEntidad.ID_CUENTA_FINAN).NOMBRE_CUENTA
            Me.xrNO_SOLICITUD.Text = lEntidad.NUM_SOLICITUD.ToString
            Me.xrDUI.Text = "DUI: " + Utilerias.FormatearDUI(lEntidad.DUI)

            mSUBTOTAL = lEntidad.SUB_TOTAL
            mIVA = lEntidad.IVA
            mTOTAL = lEntidad.TOTAL

            If lVuelos IsNot Nothing AndAlso lVuelos.Count > 0 Then
                mAGUA_MZ = lVuelos(0).MZ_REGAR_AGUA
                mAGUA_PRECIO_UNIT = lVuelos(0).PRECIO_UNIT_AGUA
                mAGUA_TOTAL = lVuelos(0).PRECIO_TOTAL_AGUA
                mRIEGO_MZ = lVuelos(0).MZ_HORAS_VUELO
                mRIEGO_PRECIO_UNIT = lVuelos(0).PRECIO_UNIT_VUELO
                mRIEGO_TOTAL = lVuelos(0).PRECIO_TOTAL_VUELO
            End If

            If Me.DS_SIGESTA1.SOLIC_AGRICOLA_MADURANTE.Rows.Count > 0 Then
                Dim sCodSocio As String = Me.DS_SIGESTA1.SOLIC_AGRICOLA_MADURANTE.Rows(0)("CODISOCIO")
                If Utilerias.RecuperarCODISOCIO(sCodSocio) <> "" Then
                    Dim lSocio As PROVEEDOR =
                    (New cPROVEEDOR).ObtenerPROVEEDOR(Me.DS_SIGESTA1.SOLIC_AGRICOLA_MADURANTE.Rows(0)("CODISOCIO"))
                    If lSocio IsNot Nothing Then
                        Me.xrSocio.Text = "Socio: (" + lSocio.NOMBRES + " " + lSocio.APELLIDOS + ") Código:" + Utilerias.RecuperarCODISOCIO(sCodSocio)
                    End If
                End If
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
        Dim detalle As SolicitudSubReporteMadurante = TryCast(Me.XrSubreport2.ReportSource, SolicitudSubReporteMadurante)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("NOMBRE_PROVEEDOR") Is DBNull.Value Then
                detalle.CargarProducto(mID_SOLICITUD, mAGUA_MZ, mAGUA_PRECIO_UNIT, mAGUA_TOTAL, mRIEGO_MZ, mRIEGO_PRECIO_UNIT, mRIEGO_TOTAL, mSUBTOTAL, mIVA, mTOTAL)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class