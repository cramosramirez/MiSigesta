<Serializable(), Table(Name:="USO_MADURANTE")> Public Class USO_MADURANTE
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_USO_MAD As Int32
    <Column(Name:="ID_USO_MAD", Storage:="ID_USO_MAD", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_USO_MAD() As Int32
        Get
            Return _ID_USO_MAD
        End Get
        Set(ByVal Value As Int32)
            _ID_USO_MAD = Value
            OnPropertyChanged("ID_USO_MAD")
        End Set
    End Property

    Private _NOMBRE_USO_MAD As String
    <Column(Name:="NOMBRE_USO_MAD", Storage:="NOMBRE_USO_MAD", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOMBRE_USO_MAD() As String
        Get
            Return _NOMBRE_USO_MAD
        End Get
        Set(ByVal Value As String)
            _NOMBRE_USO_MAD = Value
            OnPropertyChanged("NOMBRE_USO_MAD")
        End Set
    End Property
End Class


