<Serializable(), Table(Name:="TIPOSUELO")> Public Class TIPOSUELO
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_TIPO_SUELO As Int32
    <Column(Name:="ID_TIPO_SUELO", Storage:="ID_TIPO_SUELO", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_SUELO() As Int32
        Get
            Return _ID_TIPO_SUELO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_SUELO = Value
            OnPropertyChanged("ID_TIPO_SUELO")
        End Set
    End Property

    Private _NOMBRE_TIPO_SUELO As String
    <Column(Name:="NOMBRE_TIPO_SUELO", Storage:="NOMBRE_TIPO_SUELO", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOMBRE_TIPO_SUELO() As String
        Get
            Return _NOMBRE_TIPO_SUELO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_SUELO = Value
            OnPropertyChanged("NOMBRE_TIPO_SUELO")
        End Set
    End Property
End Class


