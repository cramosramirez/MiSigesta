

Partial Public Class DS_SIGESTA
End Class


Partial Public Class DS_SIGESTA
End Class


Partial Public Class DS_SIGESTA
End Class


Partial Public Class DS_SIGESTA
End Class


Partial Public Class DS_SIGESTA
End Class


Partial Public Class DS_SIGESTA
End Class

Namespace DS_SIGESTATableAdapters
    
    Partial Class TIPOCANA_POR_DIAZAFRATableAdapter

    End Class

    Partial Class CENSOTableAdapter

    End Class

    Partial Class ANALISIS_MUESTRAS_TODOTableAdapter

    End Class

    Partial Public Class CONTRATO_FINANTableAdapter
    End Class
End Namespace

Namespace DS_SIGESTATableAdapters

    Partial Public Class RPT_PROGRAMACION_COSECHATableAdapter
    End Class

    Partial Public Class RPT_SIGESTA_EJEC014_COMPA_ZAFRASTableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class

    Partial Public Class CONTRATO_ZAFRATableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class

    Partial Public Class ANALISIS_VMTTableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class

    Partial Public Class RPT_SIGESTA_EJEC001_PLAN_COSECHATableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class

    Partial Public Class RPT_SIGESTA_EJEC003TableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class

    Partial Public Class RPT_SIGESTA_EJEC012_PLAN_COSECHATableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class

    Partial Public Class RPT_SIGESTA_EJEC010TableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class

    Partial Public Class CONTRATO_REND_ESTIMADOTableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class

    Partial Public Class CONTRATO_CANA_ZONATableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class


End Namespace


Namespace DS_SIGESTATableAdapters
    Partial Public Class CONTRATO_REND_ESTIMADOTableAdapter
    End Class
End Namespace
