Partial Public Class PLAN_SEMANAL

    Private _DESCRIPCION_FECHAS As String
    Public Property DESCRIPCION_FECHAS() As String
        Get
            Return _DESCRIPCION_FECHAS
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_FECHAS = Value
        End Set
    End Property

End Class
