Public Class cFechaHora
    Inherits controladorBase

#Region " Privadas "
#End Region

    Public Shared Function ObtenerFechaHora() As DateTime
        Try
            Dim dbFechaH As New dbFechaHora
            Return dbFechaH.ObtenerFechaHora

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function ObtenerFecha() As DateTime
        Try
            Dim dbFechaH As New dbFechaHora
            Return dbFechaH.ObtenerFecha

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
