Partial Public Class cSOLIC_AGRICOLA_LOTE
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLIC_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_AGRICOLA_LOTE
        Try
            Dim mListaSOLIC_AGRICOLA_LOTE As New ListaSOLIC_AGRICOLA_LOTE
            mListaSOLIC_AGRICOLA_LOTE = mDb.ObtenerListaPorSOLIC_AGRICOLA(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA_LOTE In mListaSOLIC_AGRICOLA_LOTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA_LOTE
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODICONTRATO As String, ByVal CODIAGRON As String) As listaSOLIC_AGRICOLA_LOTE
        Try
            Return mDb.ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ID_ZAFRA, CODIPROVEEDOR, CODICONTRATO, CODIAGRON)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODICONTRATO As String, ByVal CODIAGRON As String, ByVal ESTADO_LOTE As Integer) As listaSOLIC_AGRICOLA_LOTE
        Try
            Return mDb.ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ID_ZAFRA, CODIPROVEEDOR, CODICONTRATO, CODIAGRON, ESTADO_LOTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
