Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cSOLIC_ANTICIPO_ZAFRAcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaSOLIC_ANTICIPO_ZAFRA As String) As listaSOLIC_ANTICIPO_ZAFRA
        Try
            Dim lista As listaSOLIC_ANTICIPO_ZAFRA
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaSOLIC_ANTICIPO_ZAFRA) Is Nothing Then Return New listaSOLIC_ANTICIPO_ZAFRA
            lista = TryCast(_SESION(nombreSesion_ucListaSOLIC_ANTICIPO_ZAFRA), listaSOLIC_ANTICIPO_ZAFRA)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_ANTI_ZAFRA As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaSOLIC_ANTICIPO_ZAFRA = _SESION(REFERENCIA)

            If ID_ANTI_ZAFRA > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ANTI_ZAFRA = ID_ANTI_ZAFRA Then
                        mDetalle.RemoveAt(i)
                    End If
                Next
            End If
            _SESION(REFERENCIA) = mDetalle
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_ANTI_ZAFRA As Int32, ByVal ID_ANTICIPO As Int32, _
                               ByVal ID_ZAFRA As Int32, ByVal FECHA_ULTMOV As Date, _
                               ByVal CUOTA As Decimal, ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaSOLIC_ANTICIPO_ZAFRA = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ANTI_ZAFRA = ID_ANTI_ZAFRA Then
                        mDetalle(i).ID_ANTICIPO = ID_ANTICIPO
                        mDetalle(i).ID_ZAFRA = ID_ZAFRA
                        mDetalle(i).FECHA_ULTMOV = FECHA_ULTMOV
                        mDetalle(i).CUOTA = CUOTA
                        mDetalle(i).REFERENCIA = REFERENCIA
                    End If
                Next
            End If

            _SESION(REFERENCIA) = mDetalle
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
