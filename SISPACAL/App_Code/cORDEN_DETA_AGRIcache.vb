Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Partial Public Class cORDEN_DETA_AGRIcache
    Private _SESION As HttpSessionState


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaORDEN_DETA_AGRI As String) As listaORDEN_DETA_AGRI
        Try
            Dim lista As listaORDEN_DETA_AGRI
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaORDEN_DETA_AGRI) Is Nothing Then Return New listaORDEN_DETA_AGRI
            lista = TryCast(_SESION(nombreSesion_ucListaORDEN_DETA_AGRI), listaORDEN_DETA_AGRI)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_ORDEN_DETA As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaORDEN_DETA_AGRI = _SESION(REFERENCIA)

            If ID_ORDEN_DETA > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ORDEN_DETA = ID_ORDEN_DETA Then
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
    Public Function Actualizar(ByVal ID_ORDEN_DETA As Int32, ByVal ID_ORDEN As Int32, _
                            ByVal ID_PRODUCTO As Int32, ByVal CANTIDAD As Decimal, _
                            ByVal PRECIO_UNITARIO As Decimal, ByVal TOTAL As Decimal,
                            ByVal REFERENCIA As String) As Integer

        Try
            Dim lEntidad As New ORDEN_DETA_AGRI
            lEntidad.ID_ORDEN_DETA = ID_ORDEN_DETA
            lEntidad.ID_ORDEN = If(ID_ORDEN = -1, 0, ID_ORDEN)
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.CANTIDAD = CANTIDAD
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.TOTAL = Math.Round(CANTIDAD * PRECIO_UNITARIO, 2)
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaORDEN_DETA_AGRI = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ORDEN_DETA = lEntidad.ID_ORDEN_DETA Then
                        mDetalle(i).ID_ORDEN = lEntidad.ID_ORDEN
                        mDetalle(i).ID_PRODUCTO = lEntidad.ID_PRODUCTO
                        mDetalle(i).CANTIDAD = lEntidad.CANTIDAD
                        mDetalle(i).PRECIO_UNITARIO = lEntidad.PRECIO_UNITARIO
                        mDetalle(i).TOTAL = lEntidad.TOTAL
                        mDetalle(i).REFERENCIA = lEntidad.REFERENCIA
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
