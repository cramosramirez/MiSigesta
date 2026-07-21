Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cLABFAB_VARcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaLABFAB_VAR
        Try
            Dim lista As listaLABFAB_VAR
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaLABFAB_VAR
            lista = TryCast(_SESION(nombreSesion), listaLABFAB_VAR)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_VAR As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mLotes As listaLABFAB_VAR = _SESION(REFERENCIA)

            If ID_VAR > 0 AndAlso mLotes IsNot Nothing Then
                For i As Integer = 0 To mLotes.Count - 1
                    If mLotes(i).ID_VAR = ID_VAR Then
                        mLotes.RemoveAt(i)
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

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_VAR As Int32, ByVal ID_ANALISIS As Int32, _
                                    ByVal ID_TIPOVAR As Int32, ByVal NOMBRE_VAR As String, _
                                    ByVal DESCRIP_VAR As String, ByVal ID_ANALISIS_REF As Int32, _
                                    ByVal TABLA_REF As String, ByVal COLUM1_REF As String, ByVal COLUM2_REF As String, _
                                    ByVal COLUM_VALOR_REF As String, _
                                    ByVal REFERENCIA As String) As Int32

        Try
            Dim lEntidad As New LABFAB_VAR
            lEntidad.ID_VAR = ID_VAR
            lEntidad.ID_TIPOVAR = ID_TIPOVAR
            lEntidad.NOMBRE_VAR = NOMBRE_VAR
            lEntidad.DESCRIP_VAR = DESCRIP_VAR
            lEntidad.ID_ANALISIS_REF = ID_ANALISIS_REF
            lEntidad.TABLA_REF = TABLA_REF
            lEntidad.COLUM1_REF = COLUM1_REF
            lEntidad.COLUM2_REF = COLUM2_REF
            lEntidad.COLUM_VALOR_REF = COLUM_VALOR_REF
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mLotes As listaLABFAB_VAR = _SESION(REFERENCIA)

            If mLotes IsNot Nothing Then
                For i As Integer = 0 To mLotes.Count - 1
                    If mLotes(i).ID_VAR = lEntidad.ID_VAR Then
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

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function Agregar(ByVal ID_VAR As Int32, ByVal ID_ANALISIS As Int32, _
                                    ByVal ID_TIPOVAR As Int32, ByVal NOMBRE_VAR As String, _
                                    ByVal DESCRIP_VAR As String, ByVal ID_ANALISIS_REF As Int32, _
                                    ByVal TABLA_REF As String, ByVal COLUM1_REF As String, ByVal COLUM2_REF As String, _
                                    ByVal COLUM_VALOR_REF As String, _
                                    ByVal REFERENCIA As String) As Int32
        Try
            Dim Id As Int32 = 1
            Dim lEntidad As New LABFAB_VAR
            lEntidad.ID_VAR = ID_VAR
            lEntidad.ID_TIPOVAR = ID_TIPOVAR
            lEntidad.NOMBRE_VAR = NOMBRE_VAR
            lEntidad.DESCRIP_VAR = DESCRIP_VAR
            lEntidad.ID_ANALISIS_REF = ID_ANALISIS_REF
            lEntidad.TABLA_REF = TABLA_REF
            lEntidad.COLUM1_REF = COLUM1_REF
            lEntidad.COLUM2_REF = COLUM2_REF
            lEntidad.COLUM_VALOR_REF = COLUM_VALOR_REF
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mLotes As listaLABFAB_VAR = _SESION(REFERENCIA)

            If mLotes IsNot Nothing Then
                If mLotes.Count > 0 Then
                    For i As Integer = 0 To mLotes.Count - 1
                        If mLotes(i).ID_VAR > Id Then
                            Id = mLotes(i).ID_VAR
                        End If
                    Next
                    Id += 1
                End If
            End If
            lEntidad.ID_VAR = Id
            mLotes.Add(lEntidad)

            _SESION(REFERENCIA) = mLotes
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
