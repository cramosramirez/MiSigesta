Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cCONTRATO_TRANS_VEHIcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaCONTRATO_TRANS_VEHI As String) As listaCONTRATO_TRANS_VEHI
        Try
            Dim lista As listaCONTRATO_TRANS_VEHI
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaCONTRATO_TRANS_VEHI) Is Nothing Then Return New listaCONTRATO_TRANS_VEHI
            lista = TryCast(_SESION(nombreSesion_ucListaCONTRATO_TRANS_VEHI), listaCONTRATO_TRANS_VEHI)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_CONTRA_TRANS_VEHI As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaCONTRATO_TRANS_VEHI = _SESION(REFERENCIA)

            If ID_CONTRA_TRANS_VEHI > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CONTRA_TRANS_VEHI = ID_CONTRA_TRANS_VEHI Then
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
    Public Function Actualizar(ByVal ID_CONTRA_TRANS_VEHI As Int32, ByVal ID_CONTRA_TRANS As Int32, _
                            ByVal ID_TRANSPORTE As Int32, ByVal ID_TIPOTRANS As Int32, ByVal REMOLQUE As String, ByVal PLACA As String, _
                            ByVal CAPACIDAD As Decimal, ByVal MARCA As String, ByVal ANIO As String, _
                            ByVal ES_CONTRATADO As Boolean, _
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaCONTRATO_TRANS_VEHI = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CONTRA_TRANS_VEHI = ID_CONTRA_TRANS_VEHI Then
                        mDetalle(i).ID_CONTRA_TRANS = ID_CONTRA_TRANS
                        mDetalle(i).ID_TRANSPORTE = ID_TRANSPORTE
                        mDetalle(i).ID_TIPOTRANS = ID_TIPOTRANS
                        mDetalle(i).REMOLQUE = If(REMOLQUE <> Nothing, REMOLQUE.Trim.ToUpper, REMOLQUE)
                        mDetalle(i).PLACA = PLACA.Trim.ToUpper
                        mDetalle(i).CAPACIDAD = CAPACIDAD
                        mDetalle(i).MARCA = If(MARCA <> Nothing, MARCA.Trim.ToUpper, MARCA)
                        mDetalle(i).ANIO = If(ANIO <> Nothing, ANIO.Trim.ToUpper, ANIO)
                        mDetalle(i).ES_CONTRATADO = ES_CONTRATADO
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
