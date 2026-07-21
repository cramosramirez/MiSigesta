Partial Public Class cPLAN_ENTREGA_CANA
    Public Function EsEntregaProgramada(ByVal ID_ZAFRA As Integer, ByVal ACCESSLOTE As String) As Boolean
        Try
            Return mDb.EsEntregaProgramada(ID_ZAFRA, ACCESSLOTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    Public Function ObtenerManzanasToneladasProgramadas(ByVal NOMBRE_ZAFRA As String, ByVal ACCESLOTE As String, Optional ID_PLAN_SEMANAL_EXCLUIR As Integer = -1) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerManzanasToneladasProgramadas(NOMBRE_ZAFRA, ACCESLOTE, ID_PLAN_SEMANAL_EXCLUIR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPorPLAN_SEMANAL_ACCESLOTE(ByVal ID_PLAN_SEMANAL As Integer, ByVal ACCESLOTE As String) As PLAN_ENTREGA_CANA
        Try
            Return mDb.ObtenerPorPLAN_SEMANAL_ACCESLOTE(ID_PLAN_SEMANAL, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLAN_ENTREGA_CANA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PLAN_ENTREGA_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLAN_ENTREGA_CANA(ByVal ID_PLAN_ENTREGA_CANA As Int32) As Integer
        Try
            mEntidad.ID_PLAN_ENTREGA_CANA = ID_PLAN_ENTREGA_CANA
            Return Me.EliminarPLAN_ENTREGA_CANA(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLAN_ENTREGA_CANA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLAN_ENTREGA_CANA(ByVal aEntidad As PLAN_ENTREGA_CANA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Dim listaOrdenesRozaDetalle As listaORDEN_ROZA_DETA = (New cORDEN_ROZA_DETA).ObtenerListaPorPLAN_ENTREGA_CANA(aEntidad.ID_PLAN_ENTREGA_CANA)
            'Dim bOrdenRozaEnca As New cORDEN_ROZA_ENCA
            'For i As Integer = 0 To listaOrdenesRozaDetalle.Count - 1
            '    'Eliminar orden de roza
            '    bOrdenRozaEnca.EliminarORDEN_ROZA_ENCA(listaOrdenesRozaDetalle(i).ID_ORDEN)
            'Next
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
