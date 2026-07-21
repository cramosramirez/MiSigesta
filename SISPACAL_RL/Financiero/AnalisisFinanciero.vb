Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.XtraReports.UI

Public Class AnalisisFinanciero

    Private mID_ZAFRA As Int32

    Private Sub AsignarVIP(ByVal ID_ZAFRA As Integer)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then
            Me.xrVIP.Text = Format(lZafra.PRECIO_LIBRA_AZUCAR, "0.00########")
        End If
    End Sub

    Public Sub CargarDatos(ByVal UID_REF As String)
        Dim encaPreAnalisis As listaPRE_ANALISIS_ENCA = (New cPRE_ANALISIS_ENCA).ObtenerListaPorUID_REF(UID_REF)
        If encaPreAnalisis IsNot Nothing AndAlso encaPreAnalisis.Count > 0 Then mID_ZAFRA = encaPreAnalisis(0).ID_ZAFRA

        Dim lZafra As ZAFRA
        Dim detaPreAnalisis As listaPRE_ANALISIS_DETA = (New cPRE_ANALISIS_DETA).ObtenerListaPorUID_REF(UID_REF)
        Dim monto As Decimal = 0
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERATableAdapter1.FillPorUID(DS_SIFAG1.PROYECCION_FINANCIERA, UID_REF)

        If detaPreAnalisis IsNot Nothing AndAlso detaPreAnalisis.Count > 0 Then
            For i As Int32 = 0 To detaPreAnalisis.Count - 1
                If detaPreAnalisis(i).DESCRIPCION.Contains("MONTO CREDITO") Then
                    monto = detaPreAnalisis(i).MONTO1
                    Exit For
                End If
            Next
        End If

        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA)
        If lZafra IsNot Nothing Then xrZAFRA01.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 1)
        If lZafra IsNot Nothing Then xrZAFRA02.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 1)
        If lZafra IsNot Nothing Then xrZAFRA03.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 1)
        If lZafra IsNot Nothing Then xrZAFRA04.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 1)
        If lZafra IsNot Nothing Then xrZAFRA05.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 1)
        If lZafra IsNot Nothing Then xrZAFRA06.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)

        xrlLabelAutorizaciones.Visible = False
        pnlAutorizacionAnticipo1.Visible = False
        pnlAutorizacionAnticipo2.Visible = False
        pnlAutorizacionOIP_SolicAgricola.Visible = False

        lblTecnico1Firma.Visible = (encaPreAnalisis(0).CODIAGRON <> Nothing)
        lblTecnico2Firma.Visible = (encaPreAnalisis(0).CODIAGRON2 <> Nothing)
        lblTecnico3Firma.Visible = (encaPreAnalisis(0).CODIAGRON3 <> Nothing)
        AsignarVIP(mID_ZAFRA)
    End Sub

    Public Sub CargarDatosFormatoOIP_SolicAgricola(ByVal UID_REF As String)
        Dim encaPreAnalisis As listaPRE_ANALISIS_ENCA = (New cPRE_ANALISIS_ENCA).ObtenerListaPorUID_REF(UID_REF)
        If encaPreAnalisis IsNot Nothing AndAlso encaPreAnalisis.Count > 0 Then mID_ZAFRA = encaPreAnalisis(0).ID_ZAFRA

        Dim lZafra As ZAFRA
        Dim detaPreAnalisis As listaPRE_ANALISIS_DETA = (New cPRE_ANALISIS_DETA).ObtenerListaPorUID_REF(UID_REF)
        Dim monto As Decimal = 0
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERATableAdapter1.FillPorUID(DS_SIFAG1.PROYECCION_FINANCIERA, UID_REF)

        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA)
        If lZafra IsNot Nothing Then xrZAFRA01.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 1)
        If lZafra IsNot Nothing Then xrZAFRA02.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 2)
        If lZafra IsNot Nothing Then xrZAFRA03.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 3)
        If lZafra IsNot Nothing Then xrZAFRA04.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 4)
        If lZafra IsNot Nothing Then xrZAFRA05.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 5)
        If lZafra IsNot Nothing Then xrZAFRA06.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)

        xrlLabelAutorizaciones.Visible = False
        pnlAutorizacionAnticipo1.Visible = False
        pnlAutorizacionAnticipo2.Visible = False
        pnlAutorizacionOIP_SolicAgricola.Visible = True

        lblTecnico1Firma.Visible = (encaPreAnalisis(0).CODIAGRON <> Nothing)
        lblTecnico2Firma.Visible = (encaPreAnalisis(0).CODIAGRON2 <> Nothing)
        lblTecnico3Firma.Visible = (encaPreAnalisis(0).CODIAGRON3 <> Nothing)
        AsignarVIP(mID_ZAFRA)
    End Sub

    Public Sub CargarDatosFormatoAnticipo(ByVal UID_REF As String)
        Dim encaPreAnalisis As listaPRE_ANALISIS_ENCA = (New cPRE_ANALISIS_ENCA).ObtenerListaPorUID_REF(UID_REF)
        If encaPreAnalisis IsNot Nothing AndAlso encaPreAnalisis.Count > 0 Then mID_ZAFRA = encaPreAnalisis(0).ID_ZAFRA

        Dim lZafra As ZAFRA
        Dim detaPreAnalisis As listaPRE_ANALISIS_DETA = (New cPRE_ANALISIS_DETA).ObtenerListaPorUID_REF(UID_REF)
        Dim montoSolicitado As Decimal = 0
        Dim montoOtorgado As Decimal = 0
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERATableAdapter1.FillPorUID(DS_SIFAG1.PROYECCION_FINANCIERA, UID_REF)

        If detaPreAnalisis IsNot Nothing AndAlso detaPreAnalisis.Count > 0 Then
            For i As Int32 = 0 To detaPreAnalisis.Count - 1
                If detaPreAnalisis(i).DESCRIPCION.Contains("MONTO CREDITO") Then
                    montoSolicitado = detaPreAnalisis(i).MONTO1
                End If
                If detaPreAnalisis(i).NUMERO <> "" AndAlso
                    Not detaPreAnalisis(i).DESCRIPCION.Contains("COSTO CORTE") AndAlso
                    Not detaPreAnalisis(i).DESCRIPCION.Contains("COSTO ALZADO") AndAlso
                    Not detaPreAnalisis(i).DESCRIPCION.Contains("COSTO TRANSPORTE") Then
                    montoOtorgado += detaPreAnalisis(i).MONTO1
                End If
            Next
        End If

        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA)
        If lZafra IsNot Nothing Then xrZAFRA01.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 1)
        If lZafra IsNot Nothing Then xrZAFRA02.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 2)
        If lZafra IsNot Nothing Then xrZAFRA03.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 3)
        If lZafra IsNot Nothing Then xrZAFRA04.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 4)
        If lZafra IsNot Nothing Then xrZAFRA05.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)
        lZafra = (New cZAFRA).ObtenerZAFRA(mID_ZAFRA + 5)
        If lZafra IsNot Nothing Then xrZAFRA06.Text = ExtraerNombreZafra(lZafra.NOMBRE_ZAFRA)

        xrlLabelAutorizaciones.Visible = True
        pnlAutorizacionOIP_SolicAgricola.Visible = False
        If montoSolicitado > 25000 OrElse montoOtorgado > 25000 Then
            pnlAutorizacionAnticipo2.Visible = True
            pnlAutorizacionAnticipo1.Visible = False
        Else
            pnlAutorizacionAnticipo2.Visible = False
            pnlAutorizacionAnticipo1.Visible = True
        End If

        lblTecnico1Firma.Visible = (encaPreAnalisis(0).CODIAGRON <> Nothing)
        lblTecnico2Firma.Visible = (encaPreAnalisis(0).CODIAGRON2 <> Nothing)
        lblTecnico3Firma.Visible = (encaPreAnalisis(0).CODIAGRON3 <> Nothing)
        AsignarVIP(mID_ZAFRA)
    End Sub

    Private Sub sbrSaldosInsolutos_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbrSaldosInsolutos.BeforePrint
        Dim detalle As ProyeccionFinancieraSubSaldosInsolutos = TryCast(Me.sbrSaldosInsolutos.ReportSource, ProyeccionFinancieraSubSaldosInsolutos)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("CODIPROVEEDOR") Is DBNull.Value Then
                detalle.Cargar(GetCurrentColumnValue("CODIPROVEEDOR"), mID_ZAFRA)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub sbrSaldosActuales_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbrSaldosActuales.BeforePrint
        Dim detalle As ProyeccionFinancieraSubSaldosActuales = TryCast(Me.sbrSaldosActuales.ReportSource, ProyeccionFinancieraSubSaldosActuales)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("CODIPROVEEDOR") Is DBNull.Value Then
                detalle.Cargar(GetCurrentColumnValue("CODIPROVEEDOR"), mID_ZAFRA)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub sbrDetalleOrdenTramite_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbrDetalleOrdenTramite.BeforePrint
        Dim detalle As ProyeccionFinancieraSubOrdenTramite = TryCast(Me.sbrDetalleOrdenTramite.ReportSource, ProyeccionFinancieraSubOrdenTramite)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("ID_ENCA") Is DBNull.Value Then
                detalle.CargarDetalle(CInt(GetCurrentColumnValue("ID_ENCA")))
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub sbrSaldosMutuos_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbrSaldosMutuos.BeforePrint
        Dim detalle As ProyeccionFinancieraSubSaldosMutuos = TryCast(Me.sbrSaldosMutuos.ReportSource, ProyeccionFinancieraSubSaldosMutuos)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("CODIPROVEEDOR") Is DBNull.Value Then
                detalle.CargarDetalle(GetCurrentColumnValue("CODIPROVEEDOR"))
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub sbpAnalisisTC_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbpAnalisisTC.BeforePrint
        Dim detalle As ProyeccionFinancieraSubAnalisisTC = TryCast(Me.sbpAnalisisTC.ReportSource, ProyeccionFinancieraSubAnalisisTC)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("ID_ENCA") Is DBNull.Value Then
                detalle.CargarAnalisisTC(CInt(GetCurrentColumnValue("ID_ENCA")))
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub sbpHistoZafras_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles sbpHistoZafras.BeforePrint
        Dim detalle As ProyeccionFinancieraSubHistoZafras = TryCast(Me.sbpHistoZafras.ReportSource, ProyeccionFinancieraSubHistoZafras)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("ID_ENCA") Is DBNull.Value Then
                detalle.CargarHistoZafras(CInt(GetCurrentColumnValue("ID_ENCA")))
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    'Private Sub xrDetalle_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles xrDetaTotal.BeforePrint, xrDetaZafra1.BeforePrint, xrDetaZafra2.BeforePrint
    '    Dim cell As XRTableCell = TryCast(sender, XRTableCell)
    '    If GetCurrentColumnValue("NUMERO") = "EGR" Then
    '        cell.Text = ""
    '    End If
    'End Sub

    Private Function ExtraerNombreZafra(ByVal s As String)
        Return Strings.Mid(s, 3, 2) + "/" + Strings.Mid(s, 8, 2)
    End Function
End Class