Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement


Public Class cCCF_DETAcache
    Private _SESION As HttpSessionState


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaCCF_DETA As String) As listaCCF_DETA
        Try
            Dim lista As listaCCF_DETA
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaCCF_DETA) Is Nothing Then Return New listaCCF_DETA
            lista = TryCast(_SESION(nombreSesion_ucListaCCF_DETA), listaCCF_DETA)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_CCF_DETA As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaCCF_DETA = _SESION(REFERENCIA)

            If ID_CCF_DETA > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CCF_DETA = ID_CCF_DETA Then
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
    Public Function Actualizar(ByVal ID_CCF_DETA As Int32, ByVal ID_CCF_ENCA As Int32, _
                            ByVal ID_PRODUCTO As Int32, ByVal NOMBRE_PRODUCTO As String, ByVal PRESENTACION As String, ByVal CANTIDAD As Decimal, _
                            ByVal PRECIO_UNITARIO As Decimal, ByVal TOTAL As Decimal,
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaCCF_DETA = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CCF_DETA = ID_CCF_DETA Then
                        mDetalle(i).ID_CCF_ENCA = ID_CCF_ENCA
                        mDetalle(i).ID_PRODUCTO = ID_PRODUCTO
                        mDetalle(i).NOMBRE_PRODUCTO = NOMBRE_PRODUCTO.Trim.ToUpper
                        mDetalle(i).PRESENTACION = PRESENTACION.Trim.ToUpper
                        mDetalle(i).CANTIDAD = CANTIDAD
                        mDetalle(i).PRECIO_UNITARIO = PRECIO_UNITARIO
                        mDetalle(i).TOTAL = TOTAL
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
