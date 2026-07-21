Partial Class DS_SIFAG
End Class

Namespace DS_SIFAGTableAdapters
    
    Partial Class DOCUMENTO_SALIDA_BODEGATableAdapter

    End Class

    Partial Public Class REPO_ORDEN_COMPRA_AGRICOLATableAdapter
    End Class

    Partial Public Class GENERAR_DATA_PLANTILLA_DESCTO_PRODUCTORTableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class
End Namespace
