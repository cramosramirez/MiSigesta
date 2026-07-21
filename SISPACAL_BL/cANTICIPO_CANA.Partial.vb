Partial Public Class cANTICIPO_CANA
    Public Function ObtenerANTICIPO_CANAPorZAFRA_CATORCENA_ES_COMP_VFP(ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal ES_COMP_VFP As Boolean) As ANTICIPO_CANA
        Dim lista As listaANTICIPO_CANA
        Dim lAnticipo As New ANTICIPO_CANA
        Dim Criterios As New List(Of Criteria)

        lAnticipo.ID_ZAFRA = ID_ZAFRA
        lAnticipo.ID_CATORCENA = ID_CATORCENA
        lAnticipo.ES_COMP_VFP = ES_COMP_VFP

        Criterios.Add(New Criteria("ID_ZAFRA", "=", ID_ZAFRA.ToString, "AND"))
        Criterios.Add(New Criteria("ID_CATORCENA", "=", ID_CATORCENA.ToString, "AND"))
        Criterios.Add(New Criteria("ES_COMP_VFP", "=", IIf(ES_COMP_VFP, "1", "0"), ""))
        lista = (New cANTICIPO_CANA).ObtenerListaPorBusqueda(lAnticipo, Criterios.ToArray)

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            lAnticipo = lista(0)
        Else
            lAnticipo = Nothing
        End If
        Return lAnticipo
    End Function

    Public Function ObtenerANTICIPO_CANAPorZAFRA_ES_COMP_VFP(ByVal ID_ZAFRA As Int32, ByVal ES_COMP_VFP As Boolean) As ANTICIPO_CANA
        Dim lista As listaANTICIPO_CANA
        Dim lAnticipo As New ANTICIPO_CANA
        Dim Criterios As New List(Of Criteria)

        lAnticipo.ID_ZAFRA = ID_ZAFRA
        lAnticipo.ES_COMP_VFP = ES_COMP_VFP

        Criterios.Add(New Criteria("ID_ZAFRA", "=", ID_ZAFRA.ToString, "AND"))
        Criterios.Add(New Criteria("ES_COMP_VFP", "=", IIf(ES_COMP_VFP, "1", "0"), ""))
        lista = (New cANTICIPO_CANA).ObtenerListaPorBusqueda(lAnticipo, Criterios.ToArray)

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            lAnticipo = lista(0)
        Else
            lAnticipo = Nothing
        End If
        Return lAnticipo
    End Function
End Class
