<Serializable(), Table(Name:="RIESGO_PIEDRA")> Public Class RIESGO_PIEDRA
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_RIESGO_PIEDRA As Int32
    <Column(Name:="ID_RIESGO_PIEDRA", Storage:="ID_RIESGO_PIEDRA", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_RIESGO_PIEDRA() As Int32
        Get
            Return _ID_RIESGO_PIEDRA
        End Get
        Set(ByVal Value As Int32)
            _ID_RIESGO_PIEDRA = Value
            OnPropertyChanged("ID_RIESGO_PIEDRA")
        End Set
    End Property

    Private _NOMBRE_RIESGO_PIEDRA As String
    <Column(Name:="NOMBRE_RIESGO_PIEDRA", Storage:="NOMBRE_RIESGO_PIEDRA", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOMBRE_RIESGO_PIEDRA() As String
        Get
            Return _NOMBRE_RIESGO_PIEDRA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_RIESGO_PIEDRA = Value
            OnPropertyChanged("NOMBRE_RIESGO_PIEDRA")
        End Set
    End Property
End Class
