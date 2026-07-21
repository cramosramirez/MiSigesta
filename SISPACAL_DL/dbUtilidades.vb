Public Class dbUtilidades
    Inherits dbBase

    Public Overrides Function Actualizar(aEntidad As EL.entidadBase) As Integer

    End Function

    Public Overrides Function Agregar(aEntidad As EL.entidadBase) As Integer

    End Function

    Public Overrides Function Eliminar(aEntidad As EL.entidadBase) As Integer

    End Function

    Public Overrides Function ObtenerID(aEntidad As EL.entidadBase) As Object

    End Function

    Public Overrides Function Recuperar(aEntidad As EL.entidadBase) As Integer

    End Function

    Public Function ConvertirNumeroaLetras(ByVal numero As Decimal, Optional moneda As String = "") As String
        Dim strSQL As New StringBuilder
        Dim obj As Object
        Dim lRet As String = ""

        strSQL.AppendLine("SELECT dbo.fNumero_a_Letras(")
        strSQL.AppendLine(numero.ToString)
        strSQL.AppendLine(",")
        strSQL.AppendLine("'" + moneda + "'")
        strSQL.AppendLine(")")

        obj = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
        If obj IsNot Nothing Then
            lRet = CStr(obj)
        End If
        Return lRet
    End Function
End Class
