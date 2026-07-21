Partial Public Class cLABFAB_MUESTRA


    Public Function ObtenerMUESTRA_PorANALISIS(ByVal ID_ANALISIS As Int32) As LABFAB_MUESTRA
        Dim lAnalisis As LABFAB_ANALISIS = (New cLABFAB_ANALISIS).ObtenerLABFAB_ANALISIS(ID_ANALISIS)
        Dim lMuestra As LABFAB_MUESTRA

        Try
            lMuestra = Nothing
            If lAnalisis IsNot Nothing Then
                lMuestra = (New cLABFAB_MUESTRA).ObtenerLABFAB_MUESTRA(lAnalisis.ID_MUESTRA)
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return lMuestra
    End Function

End Class
