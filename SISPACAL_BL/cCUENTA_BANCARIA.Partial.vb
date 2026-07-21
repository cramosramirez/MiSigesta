Partial Public Class cCUENTA_BANCARIA
    Public Function ObtenerCuentasBancariasActivas() As listaCUENTA_BANCARIA
        Try
            Dim mListaCUENTA_BANCARIA As New listaCUENTA_BANCARIA
            Dim mListaResultado As New listaCUENTA_BANCARIA
            mListaCUENTA_BANCARIA = mDb.ObtenerListaPorID("NO_CUENTA")
            If mListaCUENTA_BANCARIA IsNot Nothing AndAlso mListaCUENTA_BANCARIA.Count > 0 Then
                For i As Integer = 0 To mListaCUENTA_BANCARIA.Count - 1
                    If mListaCUENTA_BANCARIA(i).ACTIVO Then
                        mListaResultado.Add(mListaCUENTA_BANCARIA(i))
                    End If
                Next
            End If
            
            Return mListaResultado
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
