Partial Public Class cSUB_ZONAS

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function Recuperar(ByVal ZONA As String, Optional agregarVacio As Boolean = False, Optional agregarTodos As Boolean = False) As listaSUB_ZONAS
        Try
            Dim lSubZonas As SUB_ZONAS
            Dim mListaSUB_ZONAS As New listaSUB_ZONAS
            mListaSUB_ZONAS = mDb.ObtenerListaPorID(ZONA, "DESCRIP_SUB_ZONA")
            If agregarVacio Then
                lSubZonas = New SUB_ZONAS
                lSubZonas.ZONA = ZONA
                lSubZonas.SUB_ZONA = ""
                lSubZonas.DESCRIP_SUB_ZONA = ""
                mListaSUB_ZONAS.Insertar(0, lSubZonas)
            End If
            If agregarTodos Then
                lSubZonas = New SUB_ZONAS
                lSubZonas.ZONA = ZONA
                lSubZonas.SUB_ZONA = ""
                lSubZonas.DESCRIP_SUB_ZONA = "[Todos]"
                mListaSUB_ZONAS.Insertar(0, lSubZonas)
            End If
            Return mListaSUB_ZONAS
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista()
        Try
            Return mDb.ObtenerLista()

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
