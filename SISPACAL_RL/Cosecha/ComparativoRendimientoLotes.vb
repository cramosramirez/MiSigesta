Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class ComparativoRendimientoLotes

    Public Sub CargarDatos(ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal ZONA As String, ByVal ACCESLOTE As String, ByVal ID_ZAFRA1 As Integer, ByVal ID_ZAFRA2 As Integer)
        Dim lZafra As ZAFRA
        Dim idZafraMenor As Integer

        If ID_ZAFRA1 > ID_ZAFRA2 Then
            idZafraMenor = ID_ZAFRA2
            ID_ZAFRA2 = ID_ZAFRA1
            ID_ZAFRA1 = idZafraMenor
        End If

        lZafra = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA1)
        If lZafra IsNot Nothing Then xrZafra1.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA

        lZafra = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA2)
        If lZafra IsNot Nothing Then
            xrZafra2.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
            xrDatos.Text = "DATOS SEGÚN CONTRATO ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If
        If CODIPROVEE.Length > 6 Then CODIPROVEE = Strings.Left(CODIPROVEE, 6)
        Me.DS_CATORCENA1.Clear()
        Me.RPT_COMPARATIVO_REND_LOTETableAdapter1.SetCommandTimeOut(900000)
        Me.RPT_COMPARATIVO_REND_LOTETableAdapter1.FillPorCriterios(Me.DS_CATORCENA1.RPT_COMPARATIVO_REND_LOTE, ID_ZAFRA1, ID_ZAFRA2, CODIPROVEE, CODISOCIO, ZONA, ACCESLOTE)
    End Sub

End Class