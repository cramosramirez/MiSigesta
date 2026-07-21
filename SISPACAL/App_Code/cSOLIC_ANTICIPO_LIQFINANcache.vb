Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cSOLIC_ANTICIPO_LIQFINANcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerLista(ByVal nombreSesion_ucListaSOLIC_ANTICIPO_LIQFINAN As String) As listaSOLIC_ANTICIPO_LIQFINAN
        Try
            Dim lista As listaSOLIC_ANTICIPO_LIQFINAN
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaSOLIC_ANTICIPO_LIQFINAN) Is Nothing Then Return New listaSOLIC_ANTICIPO_LIQFINAN
            lista = TryCast(_SESION(nombreSesion_ucListaSOLIC_ANTICIPO_LIQFINAN), listaSOLIC_ANTICIPO_LIQFINAN)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function Actualizar(ByVal ID_ANTI_LIQ As Int32, ByVal ABONO As Decimal,
                            ByVal INTERES_ABO As Decimal, ByVal INTERES_IVA_ABO As Decimal, ByVal SALDO_FIN As Decimal, ByVal UID_REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaSOLIC_ANTICIPO_LIQFINAN = _SESION(UID_REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ANTI_LIQ = ID_ANTI_LIQ Then
                        mDetalle(i).ABONO = ABONO
                        mDetalle(i).INTERES_ABO = INTERES_ABO
                        mDetalle(i).INTERES_IVA_ABO = INTERES_IVA_ABO
                        mDetalle(i).SALDO_FIN = (mDetalle(i).SALDO_INI + mDetalle(i).INTERES + mDetalle(i).INTERES_IVA) - (ABONO + INTERES_ABO + INTERES_IVA_ABO)
                        mDetalle(i).UID_REFERENCIA = UID_REFERENCIA
                    End If
                Next
            End If

            _SESION(UID_REFERENCIA) = mDetalle
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function Liquidar(ByVal ID_ANTI_LIQ As Int32, ByVal UID_REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaSOLIC_ANTICIPO_LIQFINAN = _SESION(UID_REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ANTI_LIQ = ID_ANTI_LIQ Then
                        If (mDetalle(i).SALDO_INI + mDetalle(i).INTERES + mDetalle(i).INTERES_IVA) = (mDetalle(i).ABONO + mDetalle(i).INTERES_ABO + mDetalle(i).INTERES_IVA_ABO) Then
                            mDetalle(i).ABONO = 0
                            mDetalle(i).INTERES_ABO = 0
                            mDetalle(i).INTERES_IVA_ABO = 0
                            mDetalle(i).SALDO_FIN = (mDetalle(i).SALDO_INI + mDetalle(i).INTERES + mDetalle(i).INTERES_IVA)
                            mDetalle(i).UID_REFERENCIA = UID_REFERENCIA
                        Else
                            mDetalle(i).ABONO = mDetalle(i).SALDO_INI
                            mDetalle(i).INTERES_ABO = mDetalle(i).INTERES
                            mDetalle(i).INTERES_IVA_ABO = mDetalle(i).INTERES_IVA
                            mDetalle(i).SALDO_FIN = 0
                            mDetalle(i).UID_REFERENCIA = UID_REFERENCIA
                        End If

                        Exit For
                    End If
                Next
            End If

            _SESION(UID_REFERENCIA) = mDetalle
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
