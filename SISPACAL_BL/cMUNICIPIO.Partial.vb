Partial Public Class cMUNICIPIO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function Recuperar(ByVal CODI_DEPTO As String, Optional agregarVacio As Boolean = False, Optional agregarTodos As Boolean = False, Optional conPresencia As Boolean = False) As listaMUNICIPIO
        Try
            Dim lMunicipio As MUNICIPIO
            Dim mListaMUNICIPIO As New listaMUNICIPIO
            If conPresencia Then
                mListaMUNICIPIO = mDb.ObtenerListaPorPresencia(CODI_DEPTO, "NOMBRE_MUNI")
            Else
                mListaMUNICIPIO = mDb.ObtenerListaPorID(CODI_DEPTO, "NOMBRE_MUNI")
            End If
            If agregarVacio Then
                lMunicipio = New MUNICIPIO
                lMunicipio.CODI_DEPTO = CODI_DEPTO
                lMunicipio.CODI_MUNI = ""
                lMunicipio.NOMBRE_MUNI = ""
                mListaMUNICIPIO.Insertar(0, lMunicipio)
            End If
            If agregarTodos Then
                lMunicipio = New MUNICIPIO
                lMunicipio.CODI_DEPTO = CODI_DEPTO
                lMunicipio.CODI_MUNI = ""
                lMunicipio.NOMBRE_MUNI = "[Todos]"
                mListaMUNICIPIO.Insertar(0, lMunicipio)
            End If
            Return mListaMUNICIPIO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
