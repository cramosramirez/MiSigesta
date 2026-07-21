Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class EstadoCtaProveedorAgricolaTransportista
    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal ID_CUENTA_FINAN As Integer, ByVal ID_PROVEE As Integer, ByVal CODIBANCO As Integer)
        DS_TRANSPORTE1.Clear()
        RepO_ESTADO_PROVEE_DE_TRANSPORTISTATableAdapter1.FillPorCriterios(DS_TRANSPORTE1.REPO_ESTADO_PROVEE_DE_TRANSPORTISTA, ID_ZAFRA, ID_CUENTA_FINAN, ID_PROVEE, CODIBANCO)

        Dim lUltCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lUltCatorcena IsNot Nothing AndAlso lUltCatorcena.NO_CATORCENA > 0 Then
            Dim numCorte As Int32 = lUltCatorcena.NO_CATORCENA

            If numCorte < 10 Then
                tblEnca.DeleteColumn(encaCorte10)
                tblDeta.DeleteColumn(detaCorte10)
                tblTotal.DeleteColumn(totalCorte10)
            End If
            If numCorte < 9 Then
                tblEnca.DeleteColumn(encaCorte9)
                tblDeta.DeleteColumn(detaCorte9)
                tblTotal.DeleteColumn(totalCorte9)
            End If
            If numCorte < 8 Then
                tblEnca.DeleteColumn(encaCorte8)
                tblDeta.DeleteColumn(detaCorte8)
                tblTotal.DeleteColumn(totalCorte8)
            End If
            If numCorte < 7 Then
                tblEnca.DeleteColumn(encaCorte7)
                tblDeta.DeleteColumn(detaCorte7)
                tblTotal.DeleteColumn(totalCorte7)
            End If
            If numCorte < 6 Then
                tblEnca.DeleteColumn(encaCorte6)
                tblDeta.DeleteColumn(detaCorte6)
                tblTotal.DeleteColumn(totalCorte6)
            End If
            If numCorte < 5 Then
                tblEnca.DeleteColumn(encaCorte5)
                tblDeta.DeleteColumn(detaCorte5)
                tblTotal.DeleteColumn(totalCorte5)
            End If
            If numCorte < 4 Then
                tblEnca.DeleteColumn(encaCorte4)
                tblDeta.DeleteColumn(detaCorte4)
                tblTotal.DeleteColumn(totalCorte4)
            End If
            If numCorte < 3 Then
                tblEnca.DeleteColumn(encaCorte3)
                tblDeta.DeleteColumn(detaCorte3)
                tblTotal.DeleteColumn(totalCorte3)
            End If
            If numCorte < 2 Then
                tblEnca.DeleteColumn(encaCorte2)
                tblDeta.DeleteColumn(detaCorte2)
                tblTotal.DeleteColumn(totalCorte2)
            End If
            If numCorte < 1 Then
                tblEnca.DeleteColumn(encaCorte1)
                tblDeta.DeleteColumn(detaCorte1)
                tblTotal.DeleteColumn(totalCorte1)
            End If
        End If
    End Sub
End Class