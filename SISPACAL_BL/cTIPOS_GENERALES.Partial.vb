Partial Public Class cTIPOS_GENERALES
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function RecuperarPorTipo(Optional agregarVacio As Boolean = False, Optional agregarTodos As Boolean = False, Optional ID_TIPO As Int32 = -1, Optional ID_TIPO_TABLA As Int32 = -1, Optional ID_TIPO_PADRE As Int32 = -1) As listaTIPOS_GENERALES
        Try
            Dim lEntidad As TIPOS_GENERALES
            Dim mLista As New listaTIPOS_GENERALES

            mLista = mDb.ObtenerListaPorCriterios(ID_TIPO, ID_TIPO_TABLA, ID_TIPO_PADRE)

            If agregarVacio Then
                lEntidad = New TIPOS_GENERALES
                lEntidad.ID_TIPO = -1
                lEntidad.NOM_TIPO = ""
                mLista.Insertar(0, lEntidad)
            End If
            If agregarTodos Then
                lEntidad = New TIPOS_GENERALES
                lEntidad.ID_TIPO = -1
                lEntidad.NOM_TIPO = "[Todos]"
                mLista.Insertar(0, lEntidad)
            End If
            Return mLista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_TIPO As Int32, ByVal ID_TIPO_TABLA As Int32, ByVal ID_TIPO_PADRE As Int32) As listaTIPOS_GENERALES
        Try
            Return mDb.ObtenerListaPorCriterios(ID_TIPO, ID_TIPO_TABLA, ID_TIPO_PADRE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
