Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class ContratoTransporteLegal

    Public Sub CargarDatos(ByVal ID_CONTRA_TRANS As Integer)
        DS_TRANSPORTE1.Clear()
        CONTRATO_TRANSTableAdapter1.FillPorCodTransportista(DS_TRANSPORTE1.CONTRATO_TRANS, ID_CONTRA_TRANS)
    End Sub


    Private Sub XrRichText1_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrRichText1.PrintOnPage
        Me.XrRichText1.Rtf = Strings.Replace(XrRichText1.Rtf, "NUMERO_PAGINAS", Replace(Replace(cNumero_a_Letras.Convertir(e.PageCount), " CON 0/100", ""), " CON 00/100", ""))
    End Sub
End Class