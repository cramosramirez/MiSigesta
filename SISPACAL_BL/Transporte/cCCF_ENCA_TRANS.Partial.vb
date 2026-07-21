Partial Public Class cCCF_ENCA_TRANS

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CCF_ENCA_TRANS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CCF_TRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	27/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCCF_ENCA_TRANS(ByVal ID_CCF_TRANS As Int32) As Integer
        Try
            mEntidad.ID_CCF_TRANS = ID_CCF_TRANS
            Return Me.EliminarCCF_ENCA_TRANS(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CCF_ENCA_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	27/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCCF_ENCA_TRANS(ByVal aEntidad As CCF_ENCA_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bCrediEnca As New cCREDITO_ENCA_TRANS
            Dim bCCFDeta As New cCCF_DETA_TRANS
            Dim listaCrediMov As listaCREDITO_MOV_TRANS = (New cCREDITO_MOV_TRANS).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_CCF)

            If listaCrediMov IsNot Nothing AndAlso listaCrediMov.Count > 0 Then
                Me.sError = "No se puede eliminar Comprobante debido a que existen descuentos relacionados"
                Return -1
            Else
                Dim lDetalle As listaCCF_DETA_TRANS = (New cCCF_DETA_TRANS).ObtenerListaPorCCF_ENCA_TRANS(aEntidad.ID_CCF_TRANS)
                Dim listaCrediEnca As listaCREDITO_ENCA_TRANS = (New cCREDITO_ENCA_TRANS).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_CCF)

                If lDetalle IsNot Nothing AndAlso lDetalle.Count > 0 Then
                    For i As Int32 = 0 To lDetalle.Count - 1
                        bCCFDeta.EliminarCCF_DETA_TRANS(lDetalle(i).ID_CCF_DETA_TRANS)
                    Next
                End If

                If listaCrediEnca IsNot Nothing AndAlso listaCrediEnca.Count > 0 Then
                    For i As Int32 = 0 To listaCrediEnca.Count - 1
                        bCrediEnca.EliminarCREDITO_ENCA_TRANS(listaCrediEnca(i).ID_CREDITO_ENCA)
                    Next
                End If
            End If

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
