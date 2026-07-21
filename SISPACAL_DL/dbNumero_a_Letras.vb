Public Class dbNumero_a_Letras
    Inherits dbBase

    Public Overrides Function Actualizar(aEntidad As entidadBase) As Integer

    End Function

    Public Overrides Function Agregar(aEntidad As entidadBase) As Integer

    End Function

    Public Overrides Function Eliminar(aEntidad As entidadBase) As Integer

    End Function

    Public Overrides Function ObtenerID(aEntidad As entidadBase) As Object

    End Function

    Public Overrides Function Recuperar(aEntidad As entidadBase) As Integer

    End Function

    Public Function Convertir(ByVal numero As Decimal) As String
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lRet As String = ""

        strSQL.Append("SELECT dbo.fNumero_a_Letras(@numero,'') AS RESULTADO")

        arg = New SqlParameter("@numero", SqlDbType.Decimal)
        arg.Value = numero
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                lRet = dr(0)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function
End Class
