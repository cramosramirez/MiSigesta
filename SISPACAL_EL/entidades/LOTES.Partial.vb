Partial Public Class LOTES
    Public Sub New()
        Me._ID_LOTE_TRASPASO = -1
    End Sub

    Private _DESCRIPCION As String
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property

    Private _REFERENCIA As String
    Public Property REFERENCIA() As String
        Get
            Return _REFERENCIA
        End Get
        Set(ByVal Value As String)
            _REFERENCIA = Value
            OnPropertyChanged("REFERENCIA")
        End Set
    End Property

    Private _CODISOCIO As String
    Public Property CODISOCIO() As String
        Get
            Return _CODISOCIO
        End Get
        Set(ByVal Value As String)
            _CODISOCIO = Value
            OnPropertyChanged("CODISOCIO")
        End Set
    End Property


    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CODIPROVEEDOR() As String
        Get
            Return _CODIPROVEEDOR
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR = Value
            OnPropertyChanged("CODIPROVEEDOR")
            If Value.Length = 10 Then
                _CODISOCIO = Right(Value, 4)
            End If
        End Set
    End Property

    Private _CODIPROVEEDOROld As String
    Public Property CODIPROVEEDOROld() As String
        Get
            Return _CODIPROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOROld = Value
        End Set
    End Property

    Private _ACCESLOTE_TRASPASAR As String
    Public Property ACCESLOTE_TRASPASAR() As String
        Get
            Return _ACCESLOTE_TRASPASAR
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE_TRASPASAR = Value
            OnPropertyChanged("ACCESLOTE_TRASPASAR")
        End Set
    End Property

    Private _HACIENDA As String
    Public Property HACIENDA() As String
        Get
            Return _HACIENDA
        End Get
        Set(ByVal Value As String)
            _HACIENDA = Value
            OnPropertyChanged("HACIENDA")
        End Set
    End Property
End Class

