Imports SISPACAL.DL
Imports SISPACAL.RL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class frmReportes

    Public Enum Reportes
        EntregaCañaBascula = 1
        EntregaCañaBasculaCorte = 2
        OrdenCombustible = 3
    End Enum

    Private Sub frmReportes_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
        Me.Timer1.Stop()
        Me.Timer1.Enabled = False
    End Sub

    Private _Reporte As Reportes
    Public Property Reporte As Reportes
        Get
            Return _Reporte
        End Get
        Set(value As Reportes)
            _Reporte = value
            If value = Reportes.OrdenCombustible Then
                Me.UcCriterios1.Visible = False
                Me.gOrdenCombustible.Visible = True
                Me.btnActualizar.Visible = True
                Me.CargarOrdenes()
                Me.Timer1.Enabled = True
            Else
                Me.UcCriterios1.Visible = True
                Me.gOrdenCombustible.Visible = False
                Me.btnActualizar.Visible = False
            End If
        End Set
    End Property

    Private Sub CargarOrdenes()
        Dim lOrdenes As listaORDEN_COMBUSTIBLE = (New cORDEN_COMBUSTIBLE).ObtenerUltimosRegistrosPorUsuario(configuracion.usuarioActualiza, 3)
        Dim IdOrden As Integer = -1

        If Me.grdOrdenes.SelectedRows.Count > 0 Then
            For Each fila As DataGridViewRow In Me.grdOrdenes.SelectedRows
                IdOrden = fila.Cells(0).Value
                Exit For
            Next
        End If
        Me.ORDENCOMBUSTIBLEBindingSource.DataSource = lOrdenes
        If IdOrden > -1 Then
            For Each fila As DataGridViewRow In Me.grdOrdenes.Rows
                If fila.Cells(0).Value = IdOrden Then
                    fila.Selected = True
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub ConfigurarReporte()
        Select Case _Reporte
            Case Reportes.EntregaCañaBascula
                Me.Text = "Entrega de Caña en Báscula"

            Case Reportes.EntregaCañaBasculaCorte
                Me.Text = "Entrega de Caña en Báscula - Corte"

            Case Reportes.OrdenCombustible
                Me.Text = "Orden de Combustible"
        End Select
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVerReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnVerReporte.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Select Case _Reporte
                Case Reportes.EntregaCañaBascula
                    Me.Text = "Entrega de Caña en Báscula"
                    Dim reporte = New EntregaCanaBascula
                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.UcCriterios1.FECHA_CORTE)
                    Dim ds As New DS_DS1
                    Dim dt As New DS_DS1.ENTREGA_CANA_BASCULADataTable
                    Dim da As New DS_DS1TableAdapters.ENTREGA_CANA_BASCULATableAdapter

                    Dim dtSubRepo As New DS_DS1.InconsistenciasEnviosDiaZafraDataTable
                    Dim adapterSubRepo As New DS_DS1TableAdapters.InconsistenciasEnviosDiaZafraTableAdapter

                    If lDiaZafra IsNot Nothing AndAlso lDiaZafra.ID_DIA_ZAFRA > 0 Then
                        da.FillPorFechaCorte(dt, Me.UcCriterios1.FECHA_CORTE)
                        adapterSubRepo.FillPorFechaCorte(dtSubRepo, Me.UcCriterios1.ID_ZAFRA, Me.UcCriterios1.FECHA_CORTE)
                    Else
                        da.FillPorFechaCortePendiente(dt, Me.UcCriterios1.FECHA_CORTE)
                        adapterSubRepo.Fill(dtSubRepo, Me.UcCriterios1.ID_ZAFRA, Me.UcCriterios1.FECHA_CORTE)
                    End If
                    ds.Tables("ENTREGA_CANA_BASCULA").Merge(dt)
                    ds.Tables("InconsistenciasEnviosDiaZafra").Merge(dtSubRepo)
                    reporte.SetDataSource(ds)
                    reporte.Subreports(0).SetDataSource(ds)
                    CrystalReportViewer1.ReportSource = reporte

                Case Reportes.EntregaCañaBasculaCorte
                    Dim reporte = New EntregaCanaBascula02
                    Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(Me.UcCriterios1.FECHA_CORTE)
                    Dim ds As New DS_DS1
                    Dim dt As New DS_DS1.ENTREGA_CANA_BASCULADataTable
                    Dim da As New DS_DS1TableAdapters.ENTREGA_CANA_BASCULATableAdapter

                    Dim dtSubRepo As New DS_DS1.InconsistenciasEnviosDiaZafraDataTable
                    Dim adapterSubRepo As New DS_DS1TableAdapters.InconsistenciasEnviosDiaZafraTableAdapter

                    If lDiaZafra IsNot Nothing AndAlso lDiaZafra.ID_DIA_ZAFRA > 0 Then
                        da.FillPorFechaCorte(dt, Me.UcCriterios1.FECHA_CORTE)
                        adapterSubRepo.FillPorFechaCorte(dtSubRepo, Me.UcCriterios1.ID_ZAFRA, Me.UcCriterios1.FECHA_CORTE)
                    Else
                        da.FillPorFechaCortePendiente(dt, Me.UcCriterios1.FECHA_CORTE)
                        adapterSubRepo.Fill(dtSubRepo, Me.UcCriterios1.ID_ZAFRA, Me.UcCriterios1.FECHA_CORTE)
                    End If
                    ds.Tables("ENTREGA_CANA_BASCULA").Merge(dt)
                    ds.Tables("InconsistenciasEnviosDiaZafra").Merge(dtSubRepo)
                    reporte.SetDataSource(ds)
                    reporte.Subreports(0).SetDataSource(ds)
                    CrystalReportViewer1.ReportSource = reporte

                Case Reportes.OrdenCombustible
                    If Me.grdOrdenes.SelectedRows.Count > 0 Then
                        Dim reporte As New OrdenCombustible
                        Dim ds As New DS_DS1
                        Dim dt As New DS_DS1.ORDEN_COMBUSTIBLEDataTable
                        Dim da As New DS_DS1TableAdapters.ORDEN_COMBUSTIBLETableAdapter

                        da.FillPorORDEN_COMBUS(dt, Me.grdOrdenes.SelectedRows(0).Cells(0).Value)
                        ds.Tables("ORDEN_COMBUSTIBLE").Merge(dt)
                        reporte.SetDataSource(ds)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Me.Cursor = System.Windows.Forms.Cursors.Default
                        MsgBox("Seleccione una Orden", vbInformation, Application.ProductName)
                    End If
            End Select
            Me.Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Me.CargarOrdenes()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.CargarOrdenes()
    End Sub
End Class