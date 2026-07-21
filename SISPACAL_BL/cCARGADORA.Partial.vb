Partial Public Class cCARGADORA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorTIPO_ALZA(ByVal ID_TIPO_ALZA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCARGADORA
        Try
            Return mDb.ObtenerListaPorTIPO_ALZA(ID_TIPO_ALZA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaActivas(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCARGADORA
        Try
            Dim mListaCARGADORA As New listaCARGADORA
            Dim listaFiltrada As New listaCARGADORA

            mListaCARGADORA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If mListaCARGADORA IsNot Nothing AndAlso mListaCARGADORA.Count > 0 Then
                For i As Integer = 0 To mListaCARGADORA.Count - 1
                    If mListaCARGADORA(i).ACTIVO Then
                        listaFiltrada.Add(mListaCARGADORA(i))
                    End If
                Next
            Else
                listaFiltrada = mListaCARGADORA
            End If

            Return listaFiltrada
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
