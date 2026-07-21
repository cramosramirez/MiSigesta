Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cTRANSPORTEcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaTRANSPORTE As String) As listaTRANSPORTE
        Try
            Dim lista As listaTRANSPORTE
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaTRANSPORTE) Is Nothing Then Return New listaTRANSPORTE
            lista = TryCast(_SESION(nombreSesion_ucListaTRANSPORTE), listaTRANSPORTE)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_TRANSPORTE As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaTRANSPORTE = _SESION(REFERENCIA)

            If ID_TRANSPORTE > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_TRANSPORTE = ID_TRANSPORTE Then
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
    Public Function Actualizar(ByVal ID_TRANSPORTE As Int32, ByVal CODTRANSPORT As Int32, _
                            ByVal PLACA As String, ByVal ID_TIPOTRANS As Int32, _
                            ByVal REMOLQUE As String, ByVal MARCA As String, ByVal CAPACIDAD As Decimal, _
                            ByVal REFERENCIA As String) As Int32

        Try

            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaTRANSPORTE = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_TRANSPORTE = ID_TRANSPORTE Then
                        mDetalle(i).CODTRANSPORT = CODTRANSPORT
                        mDetalle(i).PLACA = PLACA
                        mDetalle(i).ID_TIPOTRANS = ID_TIPOTRANS
                        mDetalle(i).REMOLQUE = REMOLQUE
                        mDetalle(i).MARCA = MARCA
                        mDetalle(i).CAPACIDAD = CAPACIDAD
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
