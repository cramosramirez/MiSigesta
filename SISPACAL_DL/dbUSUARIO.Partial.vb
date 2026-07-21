
Partial Public Class dbUSUARIO

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera la entidad USUARIO por parámetro USUARIO.
    ''' </summary>
    ''' <param name="pUsuario">Usuario.</param>    
    ''' <history>
    ''' 	[cramos]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPorUSUARIO(ByVal pUsuario As String) As USUARIO
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaUSUARIO
        Dim lUsuario As New USUARIO

        lCriterios.Add(New Criteria("USUARIO", "=", pUsuario, ""))
        lUsuario.USUARIO = pUsuario
        lista = Me.ObtenerListaPorBusqueda(lUsuario, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Return lista(0)
        Else
            Return Nothing
        End If
    End Function
End Class
