Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.DL

Public Class RozaManualDetalleFrenteCatorcenalProductor

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal CATORCENA As Integer,
                           ByVal DIA_ZAFRA1 As Int32, ByVal DIA_ZAFRA2 As Int32,
                           ByVal PERIODO As Integer, ByVal TIPO As String,
                           Optional DetallePorPagina As Boolean = False,
                           Optional AgruparLote As Boolean = False)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        Dim dt As DS_CATORCENA.RPT_ROZA_PARTICULARESDataTable

        Select Case PERIODO
            Case 1
                Dim l As DIA_ZAFRA

                Me.txtPeriodo.Text = "FECHAS DEL "
                l = (New cDIA_ZAFRA).ObtenerPorZAFRA_DIA(ID_ZAFRA, DIA_ZAFRA1)
                If l IsNot Nothing Then
                    Me.txtPeriodo.Text = Me.txtPeriodo.Text + l.FECHA.ToString("dd/MM/yyyy")
                Else
                    Me.txtPeriodo.Text = Me.txtPeriodo.Text + Today.ToString("dd/MM/yyyy")
                End If
                Me.txtPeriodo.Text = Me.txtPeriodo.Text + " AL "
                l = (New cDIA_ZAFRA).ObtenerPorZAFRA_DIA(ID_ZAFRA, DIA_ZAFRA2)
                If l IsNot Nothing Then
                    Me.txtPeriodo.Text = Me.txtPeriodo.Text + l.FECHA.ToString("dd/MM/yyyy")
                Else
                    Me.txtPeriodo.Text = Me.txtPeriodo.Text + Today.AddDays(-1).ToString("dd/MM/yyyy")
                End If

            Case 2
                Me.txtPeriodo.Text = "ACUMULADO A LA FECHA " + Now.ToString("dd/MM/yyyy HH:mm")
            Case 3
                Me.txtPeriodo.Text = "TODOS LOS CORTES"
            Case 4
                Me.txtPeriodo.Text = "CORTE " + CATORCENA.ToString
        End Select
        If lZafra IsNot Nothing Then
            Me.txtTITULO.Text = Me.txtTITULO.Text + lZafra.NOMBRE_ZAFRA
        End If

        ' Encabezado de página
        Me.txtTITULO2.Text = Me.txtTITULO.Text
        Me.txtPeriodo2.Text = Me.txtPeriodo.Text
        Me.txt01.Text = Me.txt01.Text + " - " + TIPO
        Me.txt02.Text = Me.txt02.Text + " - " + TIPO

        ' EJECUCIÓN DEL PROCEDIMIENTO
        Me.DS_CATORCENA1.Clear()
        Me.RPT_ROZA_PARTICULARESTableAdapter1.FillBy(DS_CATORCENA1.RPT_ROZA_PARTICULARES, ID_ZAFRA, CATORCENA,
                                                    DIA_ZAFRA1, DIA_ZAFRA2, TIPO)
        ' ***************************

        dt = DS_CATORCENA1.RPT_ROZA_PARTICULARES

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            If dt(0).T_TC_ENTREGADO_PARTI > 0 Then
                txtTARIFA_ROZA2.Text = Format(Math.Round(dt(0).T_TOTAL_PARTI / dt(0).T_TC_ENTREGADO_PARTI, 2), "#,##0.00")
            Else
                txtTARIFA_ROZA2.Text = "-"
            End If
            If dt(0).T_TC_ENTREGADO_RZ36 > 0 Then
                txtTARIFA_ROZA3.Text = Format(Math.Round(dt(0).T_TOTAL_RZ36 / dt(0).T_TC_ENTREGADO_RZ36, 2), "#,##0.00")
            Else
                txtTARIFA_ROZA3.Text = "-"
            End If
        End If

        If DetallePorPagina Then
            piePROVEEDOR_ROZA.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            xrTotalesReporte.Visible = False
        Else
            piePROVEEDOR_ROZA.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
            xrTotalesReporte.Visible = True
        End If

        If AgruparLote Then
            Detail.Visible = False
            xrSubTotalTitulo.Visible = False
        Else
            xrSubTotalCODILOTE.Visible = False
            xrSubTotalNOMBLOTE.Visible = False
        End If
    End Sub
End Class