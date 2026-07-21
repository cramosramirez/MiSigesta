Partial Public Class cDEPARTAMENTO
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function Recuperar(Optional agregarVacio As Boolean = False, Optional agregarTodos As Boolean = False, Optional conPresencia As Boolean = False) As listaDEPARTAMENTO
        Try
            Dim lDepartamento As DEPARTAMENTO
            Dim mListaDEPARTAMENTO As New listaDEPARTAMENTO
            If conPresencia Then
                mListaDEPARTAMENTO = mDb.ObtenerListaPorPresencia("NOMBRE_DEPTO")
            Else
                mListaDEPARTAMENTO = mDb.ObtenerListaPorID("NOMBRE_DEPTO")
            End If
            If agregarVacio Then
                lDepartamento = New DEPARTAMENTO
                lDepartamento.CODI_DEPTO = ""
                lDepartamento.NOMBRE_DEPTO = ""
                mListaDEPARTAMENTO.Insertar(0, lDepartamento)
            End If
            If agregarTodos Then
                lDepartamento = New DEPARTAMENTO
                lDepartamento.CODI_DEPTO = ""
                lDepartamento.NOMBRE_DEPTO = "[Todos]"
                mListaDEPARTAMENTO.Insertar(0, lDepartamento)
            End If
            Return mListaDEPARTAMENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
