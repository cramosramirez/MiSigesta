Public Class EstimacionAnticipoFrenteRoza

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal DIA_INI As Int32, ByVal DIA_FIN As Int32)
        Dim totalTC As Decimal = 0
        Dim promDiasEfectivos As Decimal = 0
        Me.DS_CATORCENA1.Clear()
        Me.ESTIMACION_ANTICIPO_ROZA_PARTITableAdapter1.FillPorDiaZafra(DS_CATORCENA1.ESTIMACION_ANTICIPO_ROZA_PARTI, DIA_INI, DIA_FIN, ID_ZAFRA)
        Me.lblDiaCorte.Text = DIA_FIN.ToString

        If DS_CATORCENA1.ESTIMACION_ANTICIPO_ROZA_PARTI.Rows.Count > 0 Then
            Dim fechaIni As DateTime = #12:00:00 AM#
            Dim fechaFin As DateTime = #12:00:00 AM#

            fechaIni = DS_CATORCENA1.ESTIMACION_ANTICIPO_ROZA_PARTI.Rows(0)("FECHA_INI")
            fechaFin = DS_CATORCENA1.ESTIMACION_ANTICIPO_ROZA_PARTI.Rows(0)("FECHA_FIN")

            For Each fila As SISPACAL.DL.DS_CATORCENA.ESTIMACION_ANTICIPO_ROZA_PARTIRow In DS_CATORCENA1.ESTIMACION_ANTICIPO_ROZA_PARTI.Rows
                totalTC += fila.TC_PERIODO
                promDiasEfectivos += fila.PROM_DIA
            Next
            Me.lblPROM_DIAS_EFECTIVOS.Text = (totalTC / promDiasEfectivos).ToString("#,##0.00")
            Me.lblPeriodo.Text = fechaIni.ToString("dd, MMMMM yyyy") + " al " + fechaFin.ToString("dd, MMMMM yyyy")
        End If
    End Sub
End Class