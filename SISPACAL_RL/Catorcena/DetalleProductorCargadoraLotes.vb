Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class DetalleProductorCargadoraLotes

    Public Sub CargarDatos(ByVal ID_CATORCENA As Integer)
        Dim lCatorcena As CATORCENA_ZAFRA
        Dim lZafra As ZAFRA

        lCatorcena = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)
        If lCatorcena IsNot Nothing Then
            lZafra = (New cZAFRA).ObtenerZAFRA(lCatorcena.ID_ZAFRA)
            Me.xrTitulo.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA + " CORTE #" + lCatorcena.NO_CATORCENA.ToString()
        End If
        Me.DS_CATORCENA1.Clear()
        Me.RPT_CARGADO_X_PRODUCTOR_LOTETableAdapter1.FillPorCriterios(Me.DS_CATORCENA1.RPT_CARGADO_X_PRODUCTOR_LOTE, ID_CATORCENA)
    End Sub
End Class