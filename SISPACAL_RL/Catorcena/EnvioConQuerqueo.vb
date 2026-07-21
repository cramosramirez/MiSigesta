Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class EnvioConQuerqueo

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal NO_CATORCENA As Int32, ByVal FECHA As String, ByVal CODIPROVEE As String)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRAPorZAFRA_NOCATORCENA(ID_ZAFRA, NO_CATORCENA)

        If lZafra IsNot Nothing Then
            xrZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If

        xrTitulo.Text = "CATORCENA " + NO_CATORCENA.ToString
        If lCatorcena IsNot Nothing Then
            xrTitulo.Text = xrTitulo.Text + " DEL " + lCatorcena.FECHA_INICIO.ToString("dd/MMMM/yyyy").ToUpper + " AL " + lCatorcena.FECHA_FIN.ToString("dd/MMMM/yyyy").ToUpper
        End If

        Me.DS_CATORCENA1.Clear()
        Me.REPORTE_ENVIO_QUERQUEOTableAdapter1.FillPorCatorcena(Me.DS_CATORCENA1.REPORTE_ENVIO_QUERQUEO, ID_ZAFRA, NO_CATORCENA, FECHA, CODIPROVEE)
        Me.DisplayName = "Envios con servicio de querqueo"
    End Sub
End Class