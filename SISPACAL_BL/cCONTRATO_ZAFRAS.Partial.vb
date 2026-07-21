Partial Public Class cCONTRATO_ZAFRAS


    Public Function ObtenerCONTRATO_ZAFRASPorZAFRA_CONTRATO(ByVal ID_ZAFRA As Int32, ByVal CODICONTRATO As String) As CONTRATO_ZAFRAS
        Try
            Return mDb.ObtenerCONTRATO_ZAFRASPorZAFRA_CONTRATO(ID_ZAFRA, CODICONTRATO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCONTRATO_ZAFRASPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As CONTRATO_ZAFRAS
        Try
            Return mDb.ObtenerCONTRATO_ZAFRASPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_ZAFRAS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CONTRATO_ZAFRAS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_ZAFRAS(ByVal ID_CONTRATO_ZAFRAS As Int32) As Integer
        Try
            Dim lRet As Int32 = 0
            Dim lEntidad As CONTRATO_ZAFRAS = Me.ObtenerCONTRATO_ZAFRAS(ID_CONTRATO_ZAFRAS)
            Dim lotes As listaLOTES_COSECHA = (New cLOTES_COSECHA).ObtenerListaPorCONTRATO_ZAFRA(lEntidad.CODICONTRATO, lEntidad.ID_ZAFRA)
            Dim bLotesCosecha As New cLOTES_COSECHA
            Dim cantLotesConCanaEntregada As Decimal = 0
            Me.sError = ""

            If lEntidad IsNot Nothing AndAlso lotes IsNot Nothing AndAlso lotes.Count > 0 Then
                'Eliminar lotes en Lotes cosecha siempre que no hayan entregado caña
                For i As Int32 = 0 To lotes.Count - 1
                    If lotes(i).TONEL_ENTREGADA = 0 Then
                        bLotesCosecha.EliminarLOTES_COSECHA(lotes(i).ID_LOTES_COSECHA)
                    Else
                        cantLotesConCanaEntregada += lotes(i).TONEL_ENTREGADA
                    End If

                Next
            End If

            If cantLotesConCanaEntregada = 0 Then
                mEntidad.ID_CONTRATO_ZAFRAS = ID_CONTRATO_ZAFRAS
                lRet = mDb.Eliminar(mEntidad)
            End If
            

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
