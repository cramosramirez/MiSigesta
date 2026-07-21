Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cLABFAB_INFOVARSXDIAcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaLABFAB_INFOVARSXDIA
        Try
            Dim lista As listaLABFAB_INFOVARSXDIA
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaLABFAB_INFOVARSXDIA
            lista = TryCast(_SESION(nombreSesion), listaLABFAB_INFOVARSXDIA)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_INFOVARSXDIA As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mVars As listaLABFAB_INFOVARSXDIA = _SESION(REFERENCIA)

            If ID_INFOVARSXDIA > 0 AndAlso mVars IsNot Nothing Then
                For i As Integer = 0 To mVars.Count - 1
                    If mVars(i).ID_INFOVARSXDIA = ID_INFOVARSXDIA Then
                        mVars.RemoveAt(i)
                    End If
                Next
            End If
            _SESION(REFERENCIA) = mVars
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_INFOVARSXDIA As Int32, ByVal ID_INFO As Int32, _
                                    ByVal ID_INFOVAR As Int32, ByVal ID_DIAZAFRA As Int32, _
                                    ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, _
                                    ByVal NOMBRE_VAR As String,
                                    ByVal VALOR As Decimal, _
                                    ByVal REFERENCIA As String) As Int32

        Try
            Dim lVar As LABFAB_INFOVAR = (New cLABFAB_INFOVAR).ObtenerLABFAB_INFOVAR(ID_INFOVAR)
            Dim lEntidad As New LABFAB_INFOVARSXDIA
            lEntidad.ID_INFOVARSXDIA = ID_INFOVARSXDIA
            lEntidad.ID_INFO = ID_INFO
            lEntidad.ID_DIAZAFRA = ID_DIAZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.NOMBRE_VAR = NOMBRE_VAR
            If lVar IsNot Nothing AndAlso (lVar.ID_TIPOVAR = 1 OrElse lVar.ID_TIPOVAR = 2) Then
                lEntidad.VALOR = Math.Round(VALOR, 2)
            End If
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mVars As listaLABFAB_INFOVARSXDIA = _SESION(REFERENCIA)

            If mVars IsNot Nothing Then
                For i As Integer = 0 To mVars.Count - 1
                    If mVars(i).ID_INFOVARSXDIA = lEntidad.ID_INFOVARSXDIA Then
                        mVars(i) = lEntidad
                    End If
                Next
            End If

            _SESION(REFERENCIA) = mVars
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function Agregar(ByVal ID_INFOVARSXDIA As Int32, ByVal ID_INFO As Int32, _
                                    ByVal ID_INFOVAR As Int32, ByVal ID_DIAZAFRA As Int32, _
                                    ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, _
                                    ByVal NOMBRE_VAR As String,
                                    ByVal VALOR As Decimal, _
                                    ByVal REFERENCIA As String) As Int32
        Try
            Dim Id As Int32 = 1
            Dim lVar As LABFAB_INFOVAR = (New cLABFAB_INFOVAR).ObtenerLABFAB_INFOVAR(ID_INFOVAR)
            Dim lEntidad As New LABFAB_INFOVARSXDIA
            lEntidad.ID_INFOVARSXDIA = ID_INFOVARSXDIA
            lEntidad.ID_INFO = ID_INFO
            lEntidad.ID_DIAZAFRA = ID_DIAZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.NOMBRE_VAR = NOMBRE_VAR
            If lVar IsNot Nothing AndAlso lVar.ID_TIPOVAR <> 1 AndAlso lVar.ID_TIPOVAR <> 2 Then
                lEntidad.VALOR = Math.Round(VALOR, 2)
            End If
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mVars As listaLABFAB_INFOVARSXDIA = _SESION(REFERENCIA)

            If mVars IsNot Nothing Then
                If mVars.Count > 0 Then
                    For i As Integer = 0 To mVars.Count - 1
                        If mVars(i).ID_INFOVARSXDIA > Id Then
                            Id = mVars(i).ID_INFOVARSXDIA
                        End If
                    Next
                    Id += 1
                End If
            End If
            lEntidad.ID_INFOVARSXDIA = Id
            mVars.Add(lEntidad)

            _SESION(REFERENCIA) = mVars
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
