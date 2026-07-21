<Serializable(), Table(Name:="TIPO_SIEMBRA")> Public Class TIPO_SIEMBRA
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_TIPO_SIEMBRA As Int32
    <Column(Name:="ID_TIPO_SIEMBRA", Storage:="ID_TIPO_SIEMBRA", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_SIEMBRA() As Int32
        Get
            Return _ID_TIPO_SIEMBRA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_SIEMBRA = Value
            OnPropertyChanged("ID_TIPO_SIEMBRA")
        End Set
    End Property

    Private _NOMBRE_TIPO As String
    <Column(Name:="NOMBRE_TIPO", Storage:="NOMBRE_TIPO", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOMBRE_TIPO() As String
        Get
            Return _NOMBRE_TIPO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO = Value
            OnPropertyChanged("NOMBRE_TIPO")
        End Set
    End Property
End Class
