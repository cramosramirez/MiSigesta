Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cSOLIC_AGRICOLA_PRODUCTOcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaSOLIC_AGRICOLA_PRODUCTO
        Try
            Dim lista As listaSOLIC_AGRICOLA_PRODUCTO
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaSOLIC_AGRICOLA_PRODUCTO
            lista = TryCast(_SESION(nombreSesion), listaSOLIC_AGRICOLA_PRODUCTO)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_SOLIC_AGRI_PROD As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mLotes As listaSOLIC_AGRICOLA_PRODUCTO = _SESION(REFERENCIA)

            If ID_SOLIC_AGRI_PROD > 0 AndAlso mLotes IsNot Nothing Then
                For i As Integer = 0 To mLotes.Count - 1
                    If mLotes(i).ID_SOLIC_AGRI_PROD = ID_SOLIC_AGRI_PROD Then
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
    Public Function Actualizar(ByVal ID_SOLIC_AGRI_PROD As Int32, ByVal ID_SOLICITUD As Int32, _
                                    ByVal ID_PRODUCTO As Int32, ByVal CANT_X_MZ As Decimal, _
                                    ByVal TOTAL_PRODUCTO As Decimal, ByVal PRECIO_UNITARIO As Decimal, _
                                    ByVal PRECIO_TOTAL As Decimal, ByVal ZAFRA As String, _
                                    ByVal MZ As Decimal, _
                                    ByVal NOMBRE_PRODUCTO As String, _
                                    ByVal PRESENTACION As String, _
                                    ByVal ID_PROVEE As Int32, _
                                    ByVal ID_PROVEE_ADJU As Int32, _
                                    ByVal CANT_ADJU As Decimal, _
                                    ByVal PRECIO_ADJU As Decimal, _
                                    ByVal TOTAL_ADJU As Decimal, _
                                    ByVal REFERENCIA As String) As Integer

        Try
           

            _SESION = HttpContext.Current.Session
            Dim mLotes As listaSOLIC_AGRICOLA_PRODUCTO = _SESION(REFERENCIA)

            If mLotes IsNot Nothing Then
                For i As Integer = 0 To mLotes.Count - 1
                    If mLotes(i).ID_SOLIC_AGRI_PROD = ID_SOLIC_AGRI_PROD Then
                        mLotes(i).ID_SOLICITUD = ID_SOLICITUD
                        mLotes(i).ID_PRODUCTO = ID_PRODUCTO
                        mLotes(i).CANT_X_MZ = CANT_X_MZ
                        mLotes(i).TOTAL_PRODUCTO = TOTAL_PRODUCTO
                        mLotes(i).PRECIO_UNITARIO = PRECIO_UNITARIO
                        mLotes(i).PRECIO_TOTAL = PRECIO_TOTAL
                        mLotes(i).ZAFRA = ZAFRA
                        mLotes(i).NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
                        mLotes(i).PRESENTACION = PRESENTACION
                        mLotes(i).ID_PROVEE = ID_PROVEE
                        mLotes(i).ID_PROVEE_ADJU = ID_PROVEE_ADJU
                        mLotes(i).CANT_ADJU = CANT_ADJU
                        mLotes(i).PRECIO_ADJU = PRECIO_ADJU
                        mLotes(i).TOTAL_ADJU = TOTAL_ADJU
                        mLotes(i).REFERENCIA = REFERENCIA
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

