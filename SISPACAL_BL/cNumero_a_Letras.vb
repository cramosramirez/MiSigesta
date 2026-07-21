Public Class cNumero_a_Letras
    Inherits controladorBase

    Public Shared Function Convertir(ByVal numero As Decimal) As String
        Try
            Dim mDb As New dbNumero_a_Letras
            Return mDb.Convertir(numero)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return ""
        End Try
    End Function
End Class
