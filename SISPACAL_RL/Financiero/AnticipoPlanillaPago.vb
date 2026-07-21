Public Class AnticipoPlanillaPago


    Public Sub Cargar(ByVal ID_ZAFRA As Integer)
        Me.DS_SIFAG1.Clear()
        Me.REPO_ANTICIPO_PLANILLA_PAGOTableAdapter1.FillPorCriterios(Me.DS_SIFAG1.REPO_ANTICIPO_PLANILLA_PAGO, ID_ZAFRA)
    End Sub
End Class