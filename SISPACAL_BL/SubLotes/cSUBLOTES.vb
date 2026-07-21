Public Class cSUBLOTES
    Inherits controladorBase

    Private mDb As New dbSUBLOTES()
    Private mEntidad As New SUBLOTES

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSUBLOTES
        Try
            Dim mListaSUBLOTES As New listaSUBLOTES
            mListaSUBLOTES = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaSUBLOTES
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerSUBLOTES(ByRef aEntidad As SUBLOTES) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)

            Return liRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerSUBLOTES(ByVal ID_SUBLOTES As Integer, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SUBLOTES
        Try
            Dim lEntidad As New SUBLOTES
            lEntidad.ID_SUBLOTES = ID_SUBLOTES
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSUBLOTES(ByVal ID_SUBLOTES As Integer) As Integer
        Try
            mEntidad.ID_SUBLOTES = ID_SUBLOTES
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSUBLOTES(ByVal aEntidad As SUBLOTES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarSUBLOTES(ByVal aEntidad As SUBLOTES) As Integer
        Try
            Dim sRet As String
            Dim iRet As Integer

            iRet = mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
            sRet = mDb.ACTUALIZAR_ESTICANA_X_SUBLOTE(aEntidad.ID_SUBLOTES)
            Me.sError = ""

            If sRet <> "" Then
                Me.sError = sRet
                Return -1
            Else
                Return iRet
            End If

        Catch ex As Exception
            Me.sError = ex.Message.ToString
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarSUBLOTES(ByVal aEntidad As SUBLOTES) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorMAESTRO_LOTES(ByVal ID_MAESTRO As Integer, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSUBLOTES
        Try
            Return mDb.ObtenerListaPorMAESTRO_LOTES(ID_MAESTRO, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorLOTES_COSECHA(ByVal ID_LOTES_COSECHA As Integer, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSUBLOTES
        Try
            Return mDb.ObtenerListaPorLOTES_COSECHA(ID_LOTES_COSECHA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCorrelativoPorMaestro(ByVal ID_MAESTRO As Int32) As Int32
        Try
            Return mDb.ObtenerCorrelativoPorMaestro(ID_MAESTRO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerListaSUBLOTES_CONTRATADOS(ByVal CODIPROVEEDOR As String, ByVal ID_ZAFRA_CONTRATO As Int32) As DataSet
        Try
            Return mDb.ObtenerListaSUBLOTES_CONTRATADOS(CODIPROVEEDOR, ID_ZAFRA_CONTRATO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ACTUALIZAR_ESTICANA_X_SUBLOTE(ByVal ID_SUBLOTES As Int32) As String
        Try
            Return mDb.ACTUALIZAR_ESTICANA_X_SUBLOTE(ID_SUBLOTES)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return ex.Message.ToString
        End Try
    End Function

End Class


