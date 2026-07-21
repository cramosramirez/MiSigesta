Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.DL

Public Class QuerqueoManualResumenFrenteProductor

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal CATORCENA As Integer,
                           ByVal DIA_ZAFRA1 As Int32, ByVal DIA_ZAFRA2 As Int32,
                           ByVal PERIODO As Integer, ByVal TIPO As Integer)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)

        Select Case PERIODO
            Case 1
                Dim l As DIA_ZAFRA
                Dim lstCatorcena As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, False, "CATORCENA")

                Me.txtPeriodo.Text = "FECHAS DEL "
                l = (New cDIA_ZAFRA).ObtenerPorZAFRA_DIA(ID_ZAFRA, DIA_ZAFRA1)
                If l IsNot Nothing Then
                    Me.txtPeriodo.Text = Me.txtPeriodo.Text + l.FECHA.ToString("dd/MM/yyyy")
                    If lstCatorcena IsNot Nothing Then
                        For i As Integer = 0 To lstCatorcena.Count - 1
                            If lstCatorcena(i).FECHA_INICIO <= l.FECHA AndAlso
                                    lstCatorcena(i).FECHA_FIN >= l.FECHA Then
                                Me.txtCorte.Text = lstCatorcena(i).CATORCENA.ToString
                                Exit For
                            End If
                        Next
                        If txtCorte.Text = "" Then txtCorte.Text = lZafra.CATORCENA.ToString
                    Else
                        Me.txtCorte.Text = "1"
                    End If
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
                Me.txtCorte.Text = lZafra.CATORCENA.ToString
            Case 3
                Me.txtPeriodo.Text = "TODOS LOS CORTES"
                Me.txtCorte.Text = lZafra.CATORCENA.ToString
            Case 4
                Me.txtPeriodo.Text = "CORTE " + CATORCENA.ToString
                Me.txtCorte.Text = CATORCENA.ToString
        End Select
        If lZafra IsNot Nothing Then
            Me.txtZafra.Text = Me.txtZafra.Text + " " + lZafra.NOMBRE_ZAFRA
        End If

        ' EJECUCIÓN DEL PROCEDIMIENTO
        Me.DS_CATORCENA1.Clear()
        Me.RPT_ROZA_PRODUCTORES_ENVIOTableAdapter1.FillPorQuerqueo(DS_CATORCENA1.RPT_ROZA_PRODUCTORES_ENVIO, ID_ZAFRA, CATORCENA,
                                                    DIA_ZAFRA1, DIA_ZAFRA2, TIPO)
        ' ***************************
        Select Case TIPO
            Case 1
                txtTipoProductor.Text = "TOTAL PRODUCTORES"
            Case 2
                txtTipoProductor.Text = "PRODUCTORES EXTERNOS"
            Case 3
                txtTipoProductor.Text = "INJIBOA, S.A. DE C.V. - GRUPO JD"
        End Select
    End Sub
End Class