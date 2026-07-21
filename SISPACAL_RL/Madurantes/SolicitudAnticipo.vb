Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.Text

Public Class SolicitudAnticipo

    Public Sub CargarDatos(ByVal ID_ANTICIPO As Int32)
        Dim listaContratos As listaSOLIC_ANTICIPO_CONTRATOS = (New cSOLIC_ANTICIPO_CONTRATOS).ObtenerListaPorSOLIC_ANTICIPO(ID_ANTICIPO)
        Dim lista As New List(Of Int32)
        Dim sContratos As New StringBuilder

        If listaContratos IsNot Nothing AndAlso listaContratos.Count > 0 Then
            For i As Int32 = 0 To listaContratos.Count - 1
                Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(listaContratos(i).CODICONTRATO)
                If lContrato IsNot Nothing Then lista.Add(lContrato.NO_CONTRATO)
            Next
        End If
        lista.Sort()

        For i As Int32 = 0 To lista.Count - 1
            sContratos.Append(lista(i))
            If i < lista.Count - 1 Then sContratos.Append(", ")
        Next

        Dim sRet As String = Me.xrCuerpo.Rtf
        sRet = sRet.Replace("X_CONTRATOS", sContratos.ToString)
        Me.xrCuerpo.Rtf = sRet

        'Me.SoliC_ANTICIPOTableAdapter1.FillPorId(DS_SIGESTA1.SOLIC_ANTICIPO, ID_ANTICIPO)
    End Sub

End Class