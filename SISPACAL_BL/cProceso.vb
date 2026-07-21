Public Class cProceso
    Public Shared Function ObtenerCODIAGRON(ByVal USUARIO As String) As String
        Dim lAgronomos As listaAGRONOMO = (New cAGRONOMO).ObtenerListaPorUSUARIO(USUARIO)
        If lAgronomos IsNot Nothing AndAlso lAgronomos.Count > 0 Then
            Return lAgronomos(0).CODIAGRON
        End If
        Return ""
    End Function
End Class
