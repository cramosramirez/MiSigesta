Partial Public Class cTIPO_MOVTO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorENTRADA_SALIDA(ByVal ES_ENTRADA As Boolean) As listaTIPO_MOVTO
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim lista As listaTIPO_MOVTO
            Dim lEntidad As New TIPO_MOVTO

            If ES_ENTRADA Then
                lCriterios.Add(New Criteria("ES_ENTRADA", "=", 1, ""))
                lEntidad.ES_ENTRADA = True
            Else
                lCriterios.Add(New Criteria("ES_SALIDA", "=", 1, ""))
                lEntidad.ES_SALIDA = True
            End If
            lista = Me.ObtenerListaPorBusqueda(lEntidad, lCriterios.ToArray)
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                lista.OrdenarPorColumna("ID_TIPO_MOVTO")
                Return lista
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorENTRADA_SALIDA(ByVal ES_ENTRADA As Boolean, ByVal agregarTodos As Boolean) As listaTIPO_MOVTO
        Try

            Dim lista As listaTIPO_MOVTO
            Dim lEntidad As New TIPO_MOVTO

            lista = Me.ObtenerListaPorENTRADA_SALIDA(ES_ENTRADA)

            If lista IsNot Nothing Then lista = New listaTIPO_MOVTO

            If agregarTodos Then
                lEntidad.ID_TIPO_MOVTO = -1
                lEntidad.NOMBRE_TIPO_MOVTO = "[TODOS]"
                lista.Insertar(0, lEntidad)
            End If

            Return lista

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
