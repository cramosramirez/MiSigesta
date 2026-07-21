Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()>
Public Class cSOLIC_OIP_LOTEcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaSOLIC_OIP_LOTE
        Try
            Dim lista As listaSOLIC_OIP_LOTE
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaSOLIC_OIP_LOTE
            lista = TryCast(_SESION(nombreSesion), listaSOLIC_OIP_LOTE)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function Actualizar(ByVal ID_SOLI_LOTE As Int32, ByVal ID_OPI As Int32,
                                    ByVal ACCESLOTE As String, ByVal MZ As Decimal,
                                    ByVal TONEL_ESTI As Decimal,
                                    ByVal ID_ZAFRA As Int32,
                                    ByVal REFERENCIA As String) As Integer

        Try
            Dim lEntidad As New SOLIC_OIP_LOTE
            lEntidad.ID_SOLI_LOTE = ID_SOLI_LOTE
            lEntidad.ID_OPI = ID_OPI
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.MZ = MZ
            Dim lLotesCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(ACCESLOTE, ID_ZAFRA)
            If lLotesCosecha IsNot Nothing Then
                lEntidad.TONEL_ESTI = Math.Round(MZ * lLotesCosecha.TONEL_MZ_CENSO, 2)
            Else
                lEntidad.TONEL_ESTI = TONEL_ESTI
            End If
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mLotes As listaSOLIC_OIP_LOTE = _SESION(REFERENCIA)

            If mLotes IsNot Nothing Then
                For i As Integer = 0 To mLotes.Count - 1
                    If mLotes(i).ID_SOLI_LOTE = lEntidad.ID_SOLI_LOTE Then
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



