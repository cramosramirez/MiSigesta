Public Class dbFechaHora
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

    Public Function ObtenerFechaHora() As DateTime
        Dim strSQL As New StringBuilder
        Dim obj As Object
        Dim fecHora As DateTime = Today
        strSQL.AppendLine("SELECT GETDATE()")

        obj = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
        If IsDate(obj) Then
            fecHora = obj
            fecHora = New DateTime(fecHora.Year, fecHora.Month, fecHora.Day, fecHora.Hour, fecHora.Minute, 0)
        End If
        'Return New DateTime(2015, 11, 18, 15, 0, 0)
        Return fecHora
    End Function

    Public Function ObtenerFecha() As DateTime
        Dim strSQL As New StringBuilder
        Dim obj As Object
        Dim fecHora As DateTime = Today
        strSQL.AppendLine("SELECT GETDATE()")

        obj = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
        If IsDate(obj) Then
            fecHora = obj
            fecHora = New DateTime(fecHora.Year, fecHora.Month, fecHora.Day, 0, 0, 0)
        End If
        'Return New DateTime(2015, 11, 18, 15, 0, 0)
        Return fecHora
    End Function
End Class


