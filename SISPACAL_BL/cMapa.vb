
<System.ComponentModel.DataObject()> _
Public Class cMapa
    Inherits controladorBase

#Region " Privadas "
    Private mDb As New dbMapa()
#End Region

    Public Function ObtenerListaPorUBICACION_GEOGRAFICA(ByVal ANIOZAFRA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal ZONA As String, Optional CON_ENTREGA_CANA As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES
        Try
            Return mDb.ObtenerListaPorUBICACION_GEOGRAFICA(ANIOZAFRA, CODI_DEPTO, CODI_MUNI, ZONA, CON_ENTREGA_CANA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPorcentajeCanaQuemada(ByVal ID_ZAFRA As Integer, ByVal NOMBRE_DEPTO As String, ByVal NOMBRE_MUNI As String, ByVal CANTON As String, ByVal ZONA As String) As Decimal
        Try
            Return mDb.ObtenerPorcentajeCanaQuemada(ID_ZAFRA, NOMBRE_DEPTO, NOMBRE_MUNI, CANTON, ZONA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerInfoContratadoEntregado(ByVal ID_CENSO As Int32, _
                                                        ByVal CODI_DEPTO As String, _
                                                        ByVal CODI_MUNI As String, _
                                                        ByVal CODI_CANTON As String, _
                                                        ByVal ZONA As String, _
                                                        ByVal SUB_ZONA As String) As Dictionary(Of String, Object)
        Try
            Return mDb.ObtenerInfoContratadoEntregado(ID_CENSO, CODI_DEPTO, CODI_MUNI, CODI_CANTON, ZONA, SUB_ZONA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetEntregaPorCatorcena(ByVal NOMBRE_ZAFRA As String, _
                                                        ByVal CODI_DEPTO As String, _
                                                        ByVal CODI_MUNI As String, _
                                                        ByVal CODI_CANTON As String, _
                                                        ByVal ZONA As String, _
                                                        ByVal SUB_ZONA As String) As DataSet
        Try
            Return mDb.ObtenerDataSetEntregaPorCatorcena(NOMBRE_ZAFRA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, ZONA, SUB_ZONA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetRendimientoPorCatorcena(ByVal NOMBRE_ZAFRA As String, _
                                                        ByVal CODI_DEPTO As String, _
                                                        ByVal CODI_MUNI As String, _
                                                        ByVal CODI_CANTON As String, _
                                                        ByVal ZONA As String, _
                                                        ByVal SUB_ZONA As String) As DataSet
        Try
            Return mDb.ObtenerDataSetRendimientoPorCatorcena(NOMBRE_ZAFRA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, ZONA, SUB_ZONA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetEntregaPorTercio(ByVal ID_ZAFRA As Int32, _
                                                        ByVal CODI_DEPTO As String, _
                                                        ByVal CODI_MUNI As String, _
                                                        ByVal CODI_CANTON As String, _
                                                        ByVal ZONA As String, _
                                                        ByVal SUB_ZONA As String) As DataSet
        Try
            Return mDb.ObtenerDataSetEntregaPorTercio(ID_ZAFRA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, ZONA, SUB_ZONA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetRendimientoPorTercio(ByVal ID_ZAFRA As Int32, _
                                                        ByVal CODI_DEPTO As String, _
                                                        ByVal CODI_MUNI As String, _
                                                        ByVal CODI_CANTON As String, _
                                                        ByVal ZONA As String, _
                                                        ByVal SUB_ZONA As String) As DataSet
        Try
            Return mDb.ObtenerDataSetRendimientoPorTercio(ID_ZAFRA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, ZONA, SUB_ZONA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
