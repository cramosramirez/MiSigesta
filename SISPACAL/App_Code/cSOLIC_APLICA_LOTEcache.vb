Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cSOLIC_APLICA_LOTEcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaSOLIC_APLICA_LOTE
        Try
            Dim lista As listaSOLIC_APLICA_LOTE
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaSOLIC_APLICA_LOTE
            lista = TryCast(_SESION(nombreSesion), listaSOLIC_APLICA_LOTE)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_SOLIC_APLICA_LOTE As Int32, ByVal ID_SOLICITUD As Int32, _
                                    ByVal ID_ZAFRA As Int32, _
                                    ByVal ACCESLOTE As String, ByVal MZ As Decimal, _
                                    ByVal FECHA_APLICA As DateTime, ByVal ID_PRODUCTO As Int32, _
                                    ByVal CANT_X_MZ As Decimal, ByVal TOTAL_PRODUCTO As Decimal, _
                                    ByVal ZAFRA As String, ByVal ID_MAESTRO As Int32, _
                                    ByVal REFERENCIA As String) As Integer

        Try
            Dim lEntidad As New SOLIC_APLICA_LOTE
            lEntidad.ID_SOLIC_APLICA_LOTE = ID_SOLIC_APLICA_LOTE
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.MZ = MZ
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.CANT_X_MZ = CANT_X_MZ
            lEntidad.TOTAL_PRODUCTO = TOTAL_PRODUCTO
            lEntidad.ZAFRA = ZAFRA
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mLotes As listaSOLIC_APLICA_LOTE = _SESION(REFERENCIA)

            If mLotes IsNot Nothing Then
                For i As Integer = 0 To mLotes.Count - 1
                    If mLotes(i).ID_SOLIC_APLICA_LOTE = lEntidad.ID_SOLIC_APLICA_LOTE Then
                        mLotes(i) = lEntidad
                    End If
                Next
            End If

            _SESION(REFERENCIA) = mLotes
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class

