Partial Public Class MAESTRO_LOTES
    Private _COD_TIPO_SUELO As String
    <Column(Name:="Cod tipo suelo", Storage:="COD_TIPO_SUELO", DbType:="CHAR(4)", Id:=False), _
     DataObjectField(False, False, True, 4)> _
    Public Property COD_TIPO_SUELO() As String
        Get
            Return _COD_TIPO_SUELO
        End Get
        Set(ByVal Value As String)
            If String.IsNullOrEmpty(Value) Then
                _COD_TIPO_SUELO = Nothing
            Else
                _COD_TIPO_SUELO = Value
            End If
            OnPropertyChanged("COD_TIPO_SUELO")
        End Set
    End Property
End Class
