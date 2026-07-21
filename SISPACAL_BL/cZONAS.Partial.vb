Partial Public Class cZONAS

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaZONAS_ACTIVAS(Optional ByVal recuperarHijas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaZONAS
        Try
            Dim lZonas As New listaZONAS
            Dim mListaZONAS As New listaZONAS
            mListaZONAS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If mListaZONAS IsNot Nothing AndAlso mListaZONAS.Count > 0 Then
                For i As Int32 = 0 To mListaZONAS.Count - 1
                    If mListaZONAS(i).ZONA <> "" Then
                        lZonas.Add(mListaZONAS(i))
                    End If
                Next
            End If

            If Not recuperarHijas Then Return lZonas
            If Not mListaZONAS Is Nothing Then
                For Each lEntidad As ZONAS In lZonas
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return lZonas
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
