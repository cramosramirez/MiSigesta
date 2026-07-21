<Serializable(), Table(Name:="TOPOGRAFIA")> Public Class TOPOGRAFIA
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_TOPOGRAFIA As Int32
    <Column(Name:="ID_TOPOGRAFIA", Storage:="ID_TOPOGRAFIA", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TOPOGRAFIA() As Int32
        Get
            Return _ID_TOPOGRAFIA
        End Get
        Set(ByVal Value As Int32)
            _ID_TOPOGRAFIA = Value
            OnPropertyChanged("ID_TOPOGRAFIA")
        End Set
    End Property

    Private _NOMBRE_TOPOGRAFIA As String
    <Column(Name:="NOMBRE_TOPOGRAFIA", Storage:="NOMBRE_TOPOGRAFIA", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOMBRE_TOPOGRAFIA() As String
        Get
            Return _NOMBRE_TOPOGRAFIA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TOPOGRAFIA = Value
            OnPropertyChanged("NOMBRE_TOPOGRAFIA")
        End Set
    End Property
End Class

