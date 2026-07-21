Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.Text

Public Class AnexoContratoLegal

    Public Sub CargarDatos(ByVal CODICONTRATO As String)
        Me.DS_SIGESTA1.Clear()
        Me.GENERA_CONTRATO_LEGAL_ANEXOTableAdapter1.FillPorContrato(Me.DS_SIGESTA1.GENERA_CONTRATO_LEGAL_ANEXO, CODICONTRATO)
    End Sub

End Class