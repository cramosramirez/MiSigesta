Public Class cUtilidades
    Inherits controladorBase

    Public Shared Function ConvertirNumeroaLetras(ByVal numero As Decimal, Optional moneda As String = "") As String
        Try
            Dim mDb As New dbUtilidades
            Return mDb.ConvertirNumeroaLetras(numero, moneda)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
