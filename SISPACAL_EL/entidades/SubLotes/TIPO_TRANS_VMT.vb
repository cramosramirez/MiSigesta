<Serializable(), Table(Name:="TIPO_TRANS_VMT")> Public Class TIPO_TRANS_VMT
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_TIPO_TRANS_VMT As Int32
    <Column(Name:="ID_TIPO_TRANS_VMT", Storage:="ID_TIPO_TRANS_VMT", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_TRANS_VMT() As Int32
        Get
            Return _ID_TIPO_TRANS_VMT
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_TRANS_VMT = Value
            OnPropertyChanged("ID_TIPO_TRANS_VMT")
        End Set
    End Property

    Private _NOMBRE_TIPO_TRANS_VMT As String
    <Column(Name:="NOMBRE_TIPO_TRANS_VMT", Storage:="NOMBRE_TIPO_TRANS_VMT", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOMBRE_TIPO_TRANS_VMT() As String
        Get
            Return _NOMBRE_TIPO_TRANS_VMT
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_TRANS_VMT = Value
            OnPropertyChanged("NOMBRE_TIPO_TRANS_VMT")
        End Set
    End Property
End Class

