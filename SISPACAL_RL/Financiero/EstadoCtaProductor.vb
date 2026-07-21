Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class EstadoCtaProductor
    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal CODIPROVEEDOR As String, ByVal ID_CUENTA_FINAN As Integer)
        DS_TRANSPORTE1.Clear()
        REPO_ESTADO_CTAPRODUTableAdapter1.FillPorCriterios(DS_TRANSPORTE1.REPO_ESTADO_CTAPRODU, ID_ZAFRA, CODIPROVEEDOR, ID_CUENTA_FINAN)

        Dim lUltCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lUltCatorcena IsNot Nothing AndAlso lUltCatorcena.NO_CATORCENA > 0 Then
            Dim numCorte As Int32 = lUltCatorcena.NO_CATORCENA

            If numCorte < 10 Then
                tblEnca.DeleteColumn(encaCorte10)
                tblDeta.DeleteColumn(detaCorte10)
                tblDeta.DeleteColumn(intCorte10)
                tblTotal.DeleteColumn(totalCorte10)
                tblTotal.DeleteColumn(totalintCorte10)
            End If
            If numCorte < 9 Then
                tblEnca.DeleteColumn(encaCorte9)
                tblDeta.DeleteColumn(detaCorte9)
                tblDeta.DeleteColumn(intCorte9)
                tblTotal.DeleteColumn(totalCorte9)
                tblTotal.DeleteColumn(totalintCorte9)
            End If
            If numCorte < 8 Then
                tblEnca.DeleteColumn(encaCorte8)
                tblDeta.DeleteColumn(detaCorte8)
                tblDeta.DeleteColumn(intCorte8)
                tblTotal.DeleteColumn(totalCorte8)
                tblTotal.DeleteColumn(totalintCorte8)
            End If
            If numCorte < 7 Then
                tblEnca.DeleteColumn(encaCorte7)
                tblDeta.DeleteColumn(detaCorte7)
                tblDeta.DeleteColumn(intCorte7)
                tblTotal.DeleteColumn(totalCorte7)
                tblTotal.DeleteColumn(totalintCorte7)
            End If
            If numCorte < 6 Then
                tblEnca.DeleteColumn(encaCorte6)
                tblDeta.DeleteColumn(detaCorte6)
                tblDeta.DeleteColumn(intCorte6)
                tblTotal.DeleteColumn(totalCorte6)
                tblTotal.DeleteColumn(totalintCorte6)
            End If
            If numCorte < 5 Then
                tblEnca.DeleteColumn(encaCorte5)
                tblDeta.DeleteColumn(detaCorte5)
                tblDeta.DeleteColumn(intCorte5)
                tblTotal.DeleteColumn(totalCorte5)
                tblTotal.DeleteColumn(totalintCorte5)
            End If
            If numCorte < 4 Then
                tblEnca.DeleteColumn(encaCorte4)
                tblDeta.DeleteColumn(detaCorte4)
                tblDeta.DeleteColumn(intCorte4)
                tblTotal.DeleteColumn(totalCorte4)
                tblTotal.DeleteColumn(totalintCorte4)
            End If
            If numCorte < 3 Then
                tblEnca.DeleteColumn(encaCorte3)
                tblDeta.DeleteColumn(detaCorte3)
                tblDeta.DeleteColumn(intCorte3)
                tblTotal.DeleteColumn(totalCorte3)
                tblTotal.DeleteColumn(totalintCorte3)
            End If
            If numCorte < 2 Then
                tblEnca.DeleteColumn(encaCorte2)
                tblDeta.DeleteColumn(detaCorte2)
                tblDeta.DeleteColumn(intCorte2)
                tblTotal.DeleteColumn(totalCorte2)
                tblTotal.DeleteColumn(totalintCorte2)
            End If
            If numCorte < 1 Then
                tblEnca.DeleteColumn(encaCorte1)
                tblDeta.DeleteColumn(detaCorte1)
                tblDeta.DeleteColumn(intCorte1)
                tblTotal.DeleteColumn(totalCorte1)
                tblTotal.DeleteColumn(totalintCorte1)
            End If
        End If
    End Sub
End Class