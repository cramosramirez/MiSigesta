Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cCCF_DETA_SALBODEcache

    Private _SESION As HttpSessionState


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaCCF_DETA_SALBODE As String) As listaCCF_DETA_SALBODE
        Try
            Dim lista As listaCCF_DETA_SALBODE
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaCCF_DETA_SALBODE) Is Nothing Then Return New listaCCF_DETA_SALBODE
            lista = TryCast(_SESION(nombreSesion_ucListaCCF_DETA_SALBODE), listaCCF_DETA_SALBODE)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
