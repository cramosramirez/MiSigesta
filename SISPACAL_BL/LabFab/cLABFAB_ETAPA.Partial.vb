Partial Public Class cLABFAB_ETAPA

    Public Function ObtenerETAPA_PorANALISISXDIA(ByVal ID_ANALISISXDIA As Int32) As LABFAB_ETAPA
        Dim lEtapa As LABFAB_ETAPA
        Dim lAnalisisXdia As LABFAB_ANALISISXDIA = (New cLABFAB_ANALISISXDIA).ObtenerLABFAB_ANALISISXDIA(ID_ANALISISXDIA)
        Dim lAnalisis As LABFAB_ANALISIS
        Dim lMuestra As LABFAB_MUESTRA

        Try

            lEtapa = Nothing
            If lAnalisisXdia IsNot Nothing Then
                lAnalisis = (New cLABFAB_ANALISIS).ObtenerLABFAB_ANALISIS(lAnalisisXdia.ID_ANALISIS)
                If lAnalisis IsNot Nothing Then
                    lMuestra = (New cLABFAB_MUESTRA).ObtenerLABFAB_MUESTRA(lAnalisis.ID_MUESTRA)
                    lEtapa = Me.ObtenerLABFAB_ETAPA(lMuestra.ID_ETAPA)
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return lEtapa
    End Function


    Public Function ObtenerETAPA_PorANALISIS(ByVal ID_ANALISIS As Int32) As LABFAB_ETAPA
        Dim lEtapa As LABFAB_ETAPA
        Dim lAnalisis As LABFAB_ANALISIS = (New cLABFAB_ANALISIS).ObtenerLABFAB_ANALISIS(ID_ANALISIS)
        Dim lMuestra As LABFAB_MUESTRA

        Try
            lEtapa = Nothing
            If lAnalisis IsNot Nothing Then
                lMuestra = (New cLABFAB_MUESTRA).ObtenerLABFAB_MUESTRA(lAnalisis.ID_MUESTRA)
                lEtapa = Me.ObtenerLABFAB_ETAPA(lMuestra.ID_ETAPA)
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return lEtapa
    End Function

End Class
