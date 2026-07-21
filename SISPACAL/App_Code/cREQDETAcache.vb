Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cREQDETAcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaREQDETA
        Try
            Dim lista As listaREQDETA
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaREQDETA
            lista = TryCast(_SESION(nombreSesion), listaREQDETA)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_REQDETA As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaREQDETA = _SESION(REFERENCIA)

            If ID_REQDETA > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_REQDETA = ID_REQDETA Then
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
    Public Function Actualizar(ByVal ID_REQDETA As Int32, ByVal ID_REQENCA As Int32, _
                                    ByVal CODIGO As String, ByVal CANTIDAD As String, _
                                    ByVal UNIDAD As String, ByVal DESCRIPCION As String, _
                                    ByVal OBSERVACION As String, _
                                    ByVal REFERENCIA As String) As Integer

        Try
            Dim lEntidad As New REQDETA
            lEntidad.ID_REQDETA = ID_REQDETA
            lEntidad.ID_REQENCA = If(ID_REQENCA = -1, 0, ID_REQENCA)
            lEntidad.CODIGO = If(CODIGO = Nothing, "", CODIGO.Trim.ToUpper)
            lEntidad.CANTIDAD = If(CANTIDAD = Nothing, "", CANTIDAD.Trim.ToUpper)
            lEntidad.UNIDAD = If(UNIDAD = Nothing, "", UNIDAD.Trim.ToUpper)
            lEntidad.DESCRIPCION = If(DESCRIPCION = Nothing, "", DESCRIPCION.Trim.ToUpper)
            lEntidad.OBSERVACION = If(OBSERVACION = Nothing, "", OBSERVACION.Trim.ToUpper)
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaREQDETA = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_REQDETA = lEntidad.ID_REQDETA Then
                        mDetalle(i) = lEntidad
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

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function Agregar(ByVal ID_REQDETA As Int32, ByVal ID_REQENCA As Int32, _
                            ByVal CODIGO As String, ByVal CANTIDAD As String, _
                            ByVal UNIDAD As String, ByVal DESCRIPCION As String, _
                            ByVal OBSERVACION As String, _
                            ByVal REFERENCIA As String) As Integer
        Try
            Dim Id As Int32 = 1
            Dim lEntidad As New REQDETA
            lEntidad.ID_REQDETA = ID_REQDETA
            lEntidad.ID_REQENCA = If(ID_REQENCA = -1, 0, ID_REQENCA)
            lEntidad.CODIGO = If(CODIGO = Nothing, "", CODIGO.Trim.ToUpper)
            lEntidad.CANTIDAD = If(CANTIDAD = Nothing, "", CANTIDAD.Trim.ToUpper)
            lEntidad.UNIDAD = If(UNIDAD = Nothing, "", UNIDAD.Trim.ToUpper)
            lEntidad.DESCRIPCION = If(DESCRIPCION = Nothing, "", DESCRIPCION.Trim.ToUpper)
            lEntidad.OBSERVACION = If(OBSERVACION = Nothing, "", OBSERVACION.Trim.ToUpper)
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaREQDETA = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                If mDetalle.Count > 0 Then
                    For i As Integer = 0 To mDetalle.Count - 1
                        If mDetalle(i).ID_REQDETA > Id Then
                            Id = mDetalle(i).ID_REQDETA
                        End If
                    Next
                    Id += 1
                End If
            End If
            lEntidad.ID_REQDETA = Id
            mDetalle.Add(lEntidad)

            _SESION(REFERENCIA) = mDetalle
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
