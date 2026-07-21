Partial Public Class dbORDEN_DETA_AGRI

    Public Function ObtenerCantidadEntregada(ByVal ID_ORDEN_DETA As Int32) As Decimal
        Dim strSQL As New StringBuilder
        Dim lRet As Decimal = 0

        strSQL.Append("SELECT ISNULL(SUM(D.CANTIDAD),0) AS CANTIDAD_ENTREGADA ")
        strSQL.Append("FROM DOCUMENTO_ENTRADA_ENCA E, DOCUMENTO_ENTRADA_DETA D ")
        strSQL.Append("WHERE D.ID_ORDEN_DETA = " + CStr(ID_ORDEN_DETA) + " ")
        strSQL.Append("AND E.ID_DOCENTRA_ENCA = D.ID_DOCENTRA_ENCA ")
        strSQL.Append("AND E.ID_TIPO_MOVTO = " + CStr(1))

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
            Return lRet

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

End Class
