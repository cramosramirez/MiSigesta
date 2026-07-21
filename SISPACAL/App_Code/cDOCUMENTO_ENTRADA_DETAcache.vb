Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cDOCUMENTO_ENTRADA_DETAcache
    Private _SESION As HttpSessionState


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaDOCUMENTO_ENTRADA_DETA As String) As listaDOCUMENTO_ENTRADA_DETA
        Try
            Dim lista As listaDOCUMENTO_ENTRADA_DETA
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaDOCUMENTO_ENTRADA_DETA) Is Nothing Then Return New listaDOCUMENTO_ENTRADA_DETA
            lista = TryCast(_SESION(nombreSesion_ucListaDOCUMENTO_ENTRADA_DETA), listaDOCUMENTO_ENTRADA_DETA)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_DOCENTRA_ENCA_DETA As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaDOCUMENTO_ENTRADA_DETA = _SESION(REFERENCIA)

            If ID_DOCENTRA_ENCA_DETA > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_DOCENTRA_ENCA_DETA = ID_DOCENTRA_ENCA_DETA Then
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
    Public Function Actualizar(ByVal ID_DOCENTRA_ENCA_DETA As Int32, ByVal ID_DOCENTRA_ENCA As Int32, _
                            ByVal ID_PRODUCTO As Int32, ByVal CANTIDAD As Decimal, _
                            ByVal PRECIO_UNITARIO As Decimal, ByVal TOTAL As Decimal, ByVal FECHA_VTO As DateTime, _
                            ByVal REFERENCIA As String) As Integer

        Try

            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaDOCUMENTO_ENTRADA_DETA = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_DOCENTRA_ENCA_DETA = ID_DOCENTRA_ENCA_DETA Then
                        mDetalle(i).ID_DOCENTRA_ENCA = ID_DOCENTRA_ENCA
                        mDetalle(i).ID_PRODUCTO = ID_PRODUCTO
                        mDetalle(i).CANTIDAD = CANTIDAD
                        mDetalle(i).PRECIO_UNITARIO = PRECIO_UNITARIO
                        mDetalle(i).TOTAL = Math.Round(CANTIDAD * PRECIO_UNITARIO, 2)
                        mDetalle(i).FECHA_VTO = FECHA_VTO
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


