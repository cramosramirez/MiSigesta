Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cSOLIC_DETA_FRENTEcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerLista(ByVal nombreSesion_uclistaSOLIC_DETA_FRENTE As String) As listaSOLIC_DETA_FRENTE
        Try
            Dim lista As listaSOLIC_DETA_FRENTE
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_uclistaSOLIC_DETA_FRENTE) Is Nothing Then Return New listaSOLIC_DETA_FRENTE
            lista = TryCast(_SESION(nombreSesion_uclistaSOLIC_DETA_FRENTE), listaSOLIC_DETA_FRENTE)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function Eliminar(ByVal ID_SOLIC_DETA As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaSOLIC_DETA_FRENTE = _SESION(REFERENCIA)

            If ID_SOLIC_DETA > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_SOLIC_DETA = ID_SOLIC_DETA Then
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

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function Actualizar(ByVal ID_SOLIC_DETA As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PROVEE As Int32,
                            ByVal ID_PRODUCTO As Int32, ByVal NOMBRE_PRODUCTO As String, ByVal PRESENTACION As String, ByVal CANTIDAD As Decimal,
                            ByVal PRECIO_UNITARIO As Decimal, ByVal SUB_TOTAL As Decimal,
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaSOLIC_DETA_FRENTE = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_SOLIC_DETA = ID_SOLIC_DETA Then
                        mDetalle(i).ID_SOLICITUD = ID_SOLICITUD
                        mDetalle(i).ID_PROVEE = ID_PROVEE
                        mDetalle(i).ID_PRODUCTO = ID_PRODUCTO
                        mDetalle(i).NOMBRE_PRODUCTO = If(NOMBRE_PRODUCTO = Nothing, "", NOMBRE_PRODUCTO.Trim.ToUpper)
                        mDetalle(i).PRESENTACION = If(PRESENTACION = Nothing, "", PRESENTACION.Trim.ToUpper)
                        mDetalle(i).CANTIDAD = CANTIDAD
                        mDetalle(i).PRECIO_UNITARIO = PRECIO_UNITARIO
                        mDetalle(i).SUB_TOTAL = SUB_TOTAL
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
