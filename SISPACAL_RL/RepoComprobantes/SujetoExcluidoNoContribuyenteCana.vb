Imports SISPACAL.BL
Imports SISPACAL.EL


Public Class SujetoExcluidoNoContribuyenteCana

    Public Sub Cargar(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Integer, ByVal ID_TIPO_COMPROB As Integer, ByVal ES_CONTRIBUYENTE As Integer, ByVal ID_COMPROB_CONCE As Integer, Optional NO_DOCTO_INI As Integer = -1, Optional NO_DOCTO_FIN As Integer = -1)
        Me.DS_COMPROBANTES1.Clear()
        Me.REPO_COMPROBANTESTableAdapter1.FillPorCriterios(Me.DS_COMPROBANTES1.REPO_COMPROBANTES, ID_CATORCENA, ID_TIPO_PLANILLA, ID_TIPO_COMPROB, ID_COMPROB_CONCE, ES_CONTRIBUYENTE, NO_DOCTO_INI, NO_DOCTO_FIN)

        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)


        If lCatorcena IsNot Nothing Then
            Me.xrPeriodo.Text = "PERIODO DEL " + lCatorcena.FECHA_INICIO.ToString("dd/MM/yyyy") + " AL " + lCatorcena.FECHA_FIN.ToString("dd/MM/yyyy")
            If ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoValorFinalPago Then
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(lCatorcena.ID_ZAFRA)
                Me.xrPeriodo.Text = "PERIODO DEL " + lZafra.FECHA_INICIO.ToString("dd/MM/yyyy") + " AL " + lCatorcena.FECHA_FIN.ToString("dd/MM/yyyy")
            End If

            Me.xrCorte.Text = "CORTE #" + lCatorcena.NO_CATORCENA.ToString
        End If
    End Sub

End Class