Partial Public Class cCENSO_LOTES

    Public Function EliminarListaPorCENSO(ByVal ID_CENSO As Integer) As Int32
        Try
            mDb.EliminarListaPorCENSO(ID_CENSO)
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function GenerarCENSO_LOTES(ByVal ID_CENSO As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Int32
        Try
            Return mDb.GenerarCENSO_LOTES(ID_CENSO, USUARIO_CREA, FECHA_CREA)
        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPorCENSO_LOTE(ByVal ID_CENSO As Integer, ByVal ACCESLOTE As String) As CENSO_LOTES
        Try
            Return mDb.ObtenerPorCENSO_LOTE(ID_CENSO, ACCESLOTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPorZAFRA_LOTE(ByVal ID_ZAFRA As Integer, ByVal ACCESLOTE As String) As CENSO_LOTES
        Try
            Return mDb.ObtenerPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaIngresoCenso(ByVal ID_ZAFRA As Integer, ByVal ZONA As String, ByVal ID_CENSO As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCENSO_LOTES
        Try
            Dim mListaCENSO_LOTES As New listaCENSO_LOTES
            mListaCENSO_LOTES = mDb.ObtenerListaParaIngresoCenso(ID_ZAFRA, ZONA, ID_CENSO, asColumnaOrden, asTipoOrden)
            Return mListaCENSO_LOTES
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCENSOporLOTE(ByVal ID_CENSO_LOTES As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal MZ_ENTREGAR As Decimal, ByVal TONEL_MZ_ENTREGAR As Decimal, ByVal ID_CENSO As Int32, ByVal ID_MOTIVO_VARIACION As Int32, ByVal OBSERVACION As String, ByVal CORRELATIVO As INT32) As Integer
        Try
            Dim lCenso As CENSO = (New cCENSO).ObtenerCENSO(ID_CENSO)
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
            Dim lEntidad As New CENSO_LOTES

            If ID_CENSO_LOTES = 0 Then
                lEntidad.ID_CENSO_LOTES = 0
                lEntidad.ID_ZAFRA = ID_ZAFRA
                lEntidad.ID_CENSO = ID_CENSO
                lEntidad.ACCESLOTE = ACCESLOTE

                lEntidad.FECHA_VERIFICACION = lCenso.FECHA_CENSO
                lEntidad.MZ_ENTREGAR = MZ_ENTREGAR
                lEntidad.TONEL_MZ_ENTREGAR = TONEL_MZ_ENTREGAR
                lEntidad.TONEL_ENTREGAR = Math.Round(MZ_ENTREGAR * TONEL_MZ_ENTREGAR, 2)

                'Obtener rendimiento promedio ponderado del lote en esta zafra
                'si no se cuenta con este tomar el de la zafra pasada
                'si no se cuenta con este tomar el de la zona
                lEntidad.LBS_ENTREGAR = lEntidad.TONEL_ENTREGAR * 201
                lEntidad.VALOR_ENTREGAR = lEntidad.LBS_ENTREGAR * lZafra.PRECIO_LIBRA_AZUCAR

                If ID_MOTIVO_VARIACION > 0 Then lEntidad.ID_MOTIVO_VARIACION = ID_MOTIVO_VARIACION Else lEntidad.ID_MOTIVO_VARIACION = -1
                If OBSERVACION <> "" AndAlso OBSERVACION IsNot Nothing Then
                    lEntidad.OBSERVACION = OBSERVACION
                End If
                lEntidad.USUARIO_CREA = Utilerias.ObtenerUsuario
                lEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lEntidad.USUARIO_ACT = Utilerias.ObtenerUsuario
                lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            Else
                lEntidad = Me.ObtenerCENSO_LOTES(ID_CENSO_LOTES)
                lEntidad.MZ_ENTREGAR = MZ_ENTREGAR
                lEntidad.TONEL_MZ_ENTREGAR = TONEL_MZ_ENTREGAR
                lEntidad.TONEL_ENTREGAR = Math.Round(MZ_ENTREGAR * TONEL_MZ_ENTREGAR, 2)
                lEntidad.LBS_ENTREGAR = lEntidad.TONEL_ENTREGAR * 201
                lEntidad.VALOR_ENTREGAR = lEntidad.LBS_ENTREGAR * lZafra.PRECIO_LIBRA_AZUCAR
                lEntidad.USUARIO_ACT = Utilerias.ObtenerUsuario
                lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            End If

            Return Me.ActualizarCENSO_LOTES(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
