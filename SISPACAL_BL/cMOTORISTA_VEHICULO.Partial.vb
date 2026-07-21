Partial Public Class cMOTORISTA_VEHICULO

     ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TRANSPORTISTA.
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaMOTORISTA_VEHICULO
        Try
            Dim mListaMOTORISTA_VEHICULO As New listaMOTORISTA_VEHICULO
            Return mDb.ObtenerListaPorTRANSPORTISTA(CODTRANSPORT, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TRANSPORTISTA.
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <param name="PLACAVEHIC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMOTORISTA_VEHICULOPorTRANSPORTISTA_PLACA(ByVal CODTRANSPORT As Int32, ByVal PLACAVEHIC As String) As MOTORISTA_VEHICULO
        Try
            Dim mListaMOTORISTA_VEHICULO As New listaMOTORISTA_VEHICULO
            Return mDb.ObtenerMOTORISTA_VEHICULOPorTRANSPORTISTA_PLACA(CODTRANSPORT, PLACAVEHIC)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMOTORISTA_VEHICULOPorTRANSPORTE_MOTORISTA(ByVal ID_TRANSPORTE As Int32, ByVal ID_MOTORISTA As Int32) As MOTORISTA_VEHICULO
        Try
            Dim mListaMOTORISTA_VEHICULO As New listaMOTORISTA_VEHICULO
            Return mDb.ObtenerMOTORISTA_VEHICULOPorTRANSPORTE_MOTORISTA(ID_TRANSPORTE, ID_MOTORISTA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
