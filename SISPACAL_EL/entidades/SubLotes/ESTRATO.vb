<Serializable(), Table(Name:="ESTRATO")> Public Class ESTRATO
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_ESTRATO As Int32
    <Column(Name:="ID_ESTRATO", Storage:="ID_ESTRATO", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ESTRATO() As Int32
        Get
            Return _ID_ESTRATO
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTRATO = Value
            OnPropertyChanged("ID_ESTRATO")
        End Set
    End Property

    Private _NOMBRE_ESTRATO As String
    <Column(Name:="NOMBRE_ESTRATO", Storage:="NOMBRE_ESTRATO", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOMBRE_ESTRATO() As String
        Get
            Return _NOMBRE_ESTRATO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTRATO = Value
            OnPropertyChanged("NOMBRE_ESTRATO")
        End Set
    End Property
End Class
