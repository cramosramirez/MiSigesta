Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cORDEN_COMBUSTIBLE_PRODcache

    Private _SESION As HttpSessionState


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_uclistaORDEN_COMBUSTIBLE_PROD As String) As listaORDEN_COMBUSTIBLE_PROD
        Try
            Dim lista As listaORDEN_COMBUSTIBLE_PROD
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_uclistaORDEN_COMBUSTIBLE_PROD) Is Nothing Then Return New listaORDEN_COMBUSTIBLE_PROD
            lista = TryCast(_SESION(nombreSesion_uclistaORDEN_COMBUSTIBLE_PROD), listaORDEN_COMBUSTIBLE_PROD)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_ORDEN_COMBUSTIBLE_PROD As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaORDEN_COMBUSTIBLE_PROD = _SESION(REFERENCIA)

            If ID_ORDEN_COMBUSTIBLE_PROD > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ORDEN_COMBUSTIBLE_PROD = ID_ORDEN_COMBUSTIBLE_PROD Then
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
    Public Function Actualizar(ByVal ID_ORDEN_COMBUSTIBLE_PROD As Int32, ByVal ID_ORDEN_COMBUS As Int32, _
                            ByVal ID_PRODUCTO As Int32, ByVal CANTIDAD As Decimal, _
                            ByVal PRECIO_VENTA As Decimal, ByVal NOMBRE_PRODUCTO As String, _
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaORDEN_COMBUSTIBLE_PROD = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ORDEN_COMBUSTIBLE_PROD = ID_ORDEN_COMBUSTIBLE_PROD Then
                        mDetalle(i).ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
                        mDetalle(i).ID_PRODUCTO = ID_PRODUCTO
                        mDetalle(i).CANTIDAD = CANTIDAD
                        mDetalle(i).PRECIO_VENTA = PRECIO_VENTA
                        mDetalle(i).TOTAL = CANTIDAD * PRECIO_VENTA
                        mDetalle(i).NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
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
