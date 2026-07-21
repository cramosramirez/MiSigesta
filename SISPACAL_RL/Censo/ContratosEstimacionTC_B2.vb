Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class ContratosEstimacionTC_B2

    Public Sub CargarDatos(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal ID_ZAFRA_COMPA As Int32)
        Dim lCenso As CENSO = (New cCENSO).ObtenerCENSO(ID_CENSO)
        Dim lZafra As ZAFRA
        Dim lZafraCompa As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA_COMPA)

        If lCenso IsNot Nothing Then
            lZafra = (New cZAFRA).ObtenerZAFRA(lCenso.ID_ZAFRA)

            lblTitulo.Text += lZafra.NOMBRE_ZAFRA
            txtTITULO.Text = lCenso.NOMBRE_CENSO
            lblCanaContratadaZafraActual.Text = "CONTRATADO " + lZafra.NOMBRE_ZAFRA
            lblCanaEntregadaZafraActual.Text = "ENTREGA CAÑA " + lZafra.NOMBRE_ZAFRA
            lblFechaEsticana.Text = lCenso.FECHA_CENSO.ToString("dd/MM/yyyy")

            Me.DisplayName = "RENDIMIENTO EN EJECUCIÓN DE ZAFRA " + Replace(lZafra.NOMBRE_ZAFRA, "/", "-")
        End If
        If lZafraCompa IsNot Nothing Then
            lblCanaEntregadaZafraAnterior.Text = "ENTREGA CAÑA " + lZafraCompa.NOMBRE_ZAFRA
        End If

        Me.CensoTableAdapter1.FillPorLoteEstimacion(Me.DS_SIGESTA1.CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, ID_ZAFRA_COMPA, ID_CENSO)
    End Sub

End Class