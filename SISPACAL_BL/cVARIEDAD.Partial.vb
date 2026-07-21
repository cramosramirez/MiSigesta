Partial Public Class cVARIEDAD
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function RecuperarPorTipo(Optional agregarVacio As Boolean = False, Optional agregarTodos As Boolean = False, Optional ID_TIPO As Int32 = -1) As listaVARIEDAD
        Try
            Dim lVariedad As VARIEDAD
            Dim mListaVARIEDAD As New listaVARIEDAD

            mListaVARIEDAD = mDb.ObtenerListaPorCriterios(ID_TIPO)

            If agregarVacio Then
                lVariedad = New VARIEDAD
                lVariedad.CODIVARIEDA = ""
                lVariedad.NOM_VARIEDAD = ""
                mListaVARIEDAD.Insertar(0, lVariedad)
            End If
            If agregarTodos Then
                lVariedad = New VARIEDAD
                lVariedad.CODIVARIEDA = ""
                lVariedad.NOM_VARIEDAD = "[Todos]"
                mListaVARIEDAD.Insertar(0, lVariedad)
            End If
            Return mListaVARIEDAD
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_TIPO As Int32) As listaVARIEDAD
        Try
            Return mDb.ObtenerListaPorCriterios(ID_TIPO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
