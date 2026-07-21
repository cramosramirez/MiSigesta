Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cSOLIC_AGRICOLA_LOTEcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaSOLIC_AGRICOLA_LOTE
        Try
            Dim lista As listaSOLIC_AGRICOLA_LOTE
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaSOLIC_AGRICOLA_LOTE
            lista = TryCast(_SESION(nombreSesion), listaSOLIC_AGRICOLA_LOTE)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_SOLIC_AGRI_LOTE As Int32, ByVal ID_SOLICITUD As Int32, _
                                    ByVal ID_ZAFRA As Int32, _
                                    ByVal ACCESLOTE As String, ByVal MZ As Decimal, _
                                    ByVal TONEL_ESTI As Decimal, ByVal ZAFRA As String, ByVal CODIVARIEDA As String, _
                                    ByVal REFERENCIA As String) As Integer

        Try
            Dim lEntidad As New SOLIC_AGRICOLA_LOTE
            lEntidad.ID_SOLIC_AGRI_LOTE = ID_SOLIC_AGRI_LOTE
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.MZ = MZ
            Dim lLotesCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(ACCESLOTE, ID_ZAFRA)
            If lLotesCosecha IsNot Nothing Then
                lEntidad.TONEL_ESTI = Math.Round(MZ * lLotesCosecha.TONEL_MZ_CENSO, 2)
            Else
                lEntidad.TONEL_ESTI = TONEL_ESTI
            End If
            lEntidad.RIEGO_APLICADO = False
            lEntidad.ZAFRA = ZAFRA
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mLotes As listaSOLIC_AGRICOLA_LOTE = _SESION(REFERENCIA)

            If mLotes IsNot Nothing Then
                For i As Integer = 0 To mLotes.Count - 1
                    If mLotes(i).ID_SOLIC_AGRI_LOTE = lEntidad.ID_SOLIC_AGRI_LOTE Then
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
