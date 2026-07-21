Partial Public Class cSALBODE_ENCA


    Public Function PROC_Generar_SalBodega(ByVal ID_ZAFRA As Int32, ByVal USUARIO As String, ByVal SOLICITUDES As String, ByVal RETIRO_PROD As Boolean) As Int32
        Try
            Dim Mensaje As String = ""
            Dim lRet As Int32 = 0

            lRet = mDb.PROC_Generar_SalBodega(ID_ZAFRA, USUARIO, SOLICITUDES, RETIRO_PROD, Mensaje)
            Me.sError = Mensaje
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function PROC_Calcular_Entrega_Producto(ByVal ID_SALBODE_ENCA As Int32, ByVal ID_PRODUCTO As Int32) As Dictionary(Of String, Decimal)
        Try
            Return mDb.PROC_Calcular_Entrega_Producto(ID_SALBODE_ENCA, ID_PRODUCTO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaSIN_DOCUMENTO_SALIDA(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSALBODE_ENCA
        Try
            Return mDb.ObtenerListaSIN_DOCUMENTO_SALIDA(asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaCON_DOCUMENTO_SALIDA(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSALBODE_ENCA
        Try
            Return mDb.ObtenerListaCON_DOCUMENTO_SALIDA(asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SALBODE_ENCA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SALBODE_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSALBODE_ENCA(ByVal ID_SALBODE_ENCA As Int32) As Integer
        Try
            mEntidad.ID_SALBODE_ENCA = ID_SALBODE_ENCA
            Return Me.EliminarSALBODE_ENCA(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SALBODE_ENCA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSALBODE_ENCA(ByVal aEntidad As SALBODE_ENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bSalBodeDeta As New cSALBODE_DETA
            Dim listaDetalle As listaSALBODE_DETA = bSalBodeDeta.ObtenerListaPorSALBODE_ENCA(aEntidad.ID_SALBODE_ENCA)
            Dim listaDoctoSal As listaDOCUMENTO_SALIDA_ENCA

            'Verificar que la Solicitud de Retiro no posea salida de bodega asociada
            listaDoctoSal = (New cDOCUMENTO_SALIDA_ENCA).ObtenerListaPorSALBODE_ENCA(aEntidad.ID_SALBODE_ENCA)
            If listaDoctoSal IsNot Nothing AndAlso listaDoctoSal.Count > 0 Then
                Me.sError = "La Solicitud de Retiro de producto ya tiene Salida de Bodega relacionada, no es posible eliminarla"
                Return -1
            End If

            If listaDetalle IsNot Nothing AndAlso listaDetalle.Count > 0 Then
                For i As Int32 = 0 To listaDetalle.Count - 1
                    bSalBodeDeta.EliminarSALBODE_DETA(listaDetalle(i).ID_SALBODE_DETA)
                Next
            End If

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
