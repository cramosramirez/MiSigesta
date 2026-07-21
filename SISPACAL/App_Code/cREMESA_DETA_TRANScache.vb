Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cREMESA_DETA_TRANScache
    Private _SESION As HttpSessionState


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaREMESA_DETA_TRANS As String) As listaREMESA_DETA_TRANS
        Try
            Dim lista As listaREMESA_DETA_TRANS
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaREMESA_DETA_TRANS) Is Nothing Then Return New listaREMESA_DETA_TRANS
            lista = TryCast(_SESION(nombreSesion_ucListaREMESA_DETA_TRANS), listaREMESA_DETA_TRANS)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_REMESA_DETA As Int32, ByVal ID_REMESA_ENCA As Int32, _
                            ByVal ABONO_CAPITAL As Decimal, ByVal ABONO_INTERES As Decimal, ByVal ABONO_INTERES_IVA As Decimal, _
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaREMESA_DETA_TRANS = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_REMESA_DETA = ID_REMESA_DETA Then
                        mDetalle(i).ID_REMESA_ENCA = ID_REMESA_ENCA
                        mDetalle(i).ABONO_CAPITAL = ABONO_CAPITAL
                        mDetalle(i).ABONO_INTERES = ABONO_INTERES
                        mDetalle(i).ABONO_INTERES_IVA = ABONO_INTERES_IVA
                        mDetalle(i).TOTAL = ABONO_CAPITAL + ABONO_INTERES + ABONO_INTERES_IVA
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
