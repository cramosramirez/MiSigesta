Partial Public Class cCCF_ENCA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONCEPTO_CCF(ByVal CONCEPTO_CCF As Int32) As listaCCF_ENCA
        Try
            Return mDb.ObtenerListaPorCONCEPTO_CCF(CONCEPTO_CCF)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CCF_ENCA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CCF_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCCF_ENCA(ByVal ID_CCF_ENCA As Int32) As Integer
        Try
            mEntidad = Me.ObtenerCCF_ENCA(ID_CCF_ENCA)
            Return Me.EliminarCCF_ENCA(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CCF_ENCA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCCF_ENCA(ByVal aEntidad As CCF_ENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bCrediEnca As New cCREDITO_ENCA
            Dim bCCFDeta As New cCCF_DETA
            Dim bCCFDetaSalBode As New cCCF_DETA_SALBODE
            Dim listaCrediMov As listaCREDITO_MOV = (New cCREDITO_MOV).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_REFERENCIA_CCF)

            If listaCrediMov IsNot Nothing AndAlso listaCrediMov.Count > 0 Then
                Me.sError = "No se puede eliminar Comprobante debido a que existen descuentos relacionados"
                Return -1
            Else
                Dim lDetalle As listaCCF_DETA = (New cCCF_DETA).ObtenerListaPorCCF_ENCA(aEntidad.ID_CCF_ENCA)
                Dim lDetalleSalBode As listaCCF_DETA_SALBODE = (New cCCF_DETA_SALBODE).ObtenerListaPorCCF_ENCA(aEntidad.ID_CCF_ENCA)
                Dim listaCrediEnca As listaCREDITO_ENCA = (New cCREDITO_ENCA).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_REFERENCIA_CCF)

                If lDetalle IsNot Nothing AndAlso lDetalle.Count > 0 Then
                    For i As Int32 = 0 To lDetalle.Count - 1
                        bCCFDeta.EliminarCCF_DETA(lDetalle(i).ID_CCF_DETA)
                    Next
                End If

                If lDetalleSalBode IsNot Nothing AndAlso lDetalleSalBode.Count > 0 Then
                    For i As Int32 = 0 To lDetalleSalBode.Count - 1
                        bCCFDetaSalBode.EliminarCCF_DETA_SALBODE(lDetalleSalBode(i).ID_CCF_DETA_SAL)
                    Next
                End If

                If listaCrediEnca IsNot Nothing AndAlso listaCrediEnca.Count > 0 Then
                    For i As Int32 = 0 To listaCrediEnca.Count - 1
                        bCrediEnca.EliminarCREDITO_ENCA(listaCrediEnca(i).ID_CREDITO_ENCA)
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
