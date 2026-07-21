Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cSALBODE_DETAcache
    Private _SESION As HttpSessionState


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_uclistaSALBODE_DETA As String) As listaSALBODE_DETA
        Try
            Dim lista As listaSALBODE_DETA
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_uclistaSALBODE_DETA) Is Nothing Then Return New listaSALBODE_DETA
            lista = TryCast(_SESION(nombreSesion_uclistaSALBODE_DETA), listaSALBODE_DETA)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_SALBODE_DETA As Int32, ByVal ID_SALBODE_ENCA As Int32, _
                            ByVal CANT_ANULADA As Decimal, _
                            ByVal CANT_ENTREGADA As Decimal,
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaSALBODE_DETA = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_SALBODE_DETA = ID_SALBODE_DETA Then
                        mDetalle(i).ID_SALBODE_ENCA = ID_SALBODE_ENCA
                        mDetalle(i).CANT_ANULADA = CANT_ANULADA
                        mDetalle(i).CANT_ENTREGADA = CANT_ENTREGADA
                        'If mDetalle(i).CANTIDAD - mDetalle(i).CANT_ANULADA - mDetalle(i).CANT_ENTREGADA = 0 Then
                        '    mDetalle(i).ID_ESTADO = Enumeradores.EstadoSolicAgricola.Finalizada
                        'Else
                        '    mDetalle(i).ID_ESTADO = Enumeradores.EstadoSolicAgricola.Pendiente
                        'End If
                        mDetalle(i).ID_ESTADO = Enumeradores.EstadoSolicAgricola.Pendiente
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
