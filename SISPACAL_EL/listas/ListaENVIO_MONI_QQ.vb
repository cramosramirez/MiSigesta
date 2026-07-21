''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaENVIO_MONI_QQ
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ENVIO_MONI_QQ',
''' es una representación en memoria de los registros de la tabla ENVIO_MONI_QQ
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaENVIO_MONI_QQ
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaENVIO_MONI_QQ )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ENVIO_MONI_QQ)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ENVIO_MONI_QQ
        Get
            Return CType((List(index)), ENVIO_MONI_QQ)
        End Get
        Set(ByVal Value As ENVIO_MONI_QQ)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ENVIO_MONI_QQ) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_MONI_QQ = CType(List(i), ENVIO_MONI_QQ)
            If s.ID_ENVIO_MQQ = value.ID_ENVIO_MQQ Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ENVIO_MQQ As Int32) As ENVIO_MONI_QQ
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_MONI_QQ = CType(List(i), ENVIO_MONI_QQ)
            If s.ID_ENVIO_MQQ = ID_ENVIO_MQQ Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ENVIO_MONI_QQEnumerator
        Return New ENVIO_MONI_QQEnumerator(Me)
    End Function

    Public Class ENVIO_MONI_QQEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaENVIO_MONI_QQ)
            Me.Local = Mappings
            Me.Base = Local.GetEnumerator()
        End Sub

        ReadOnly Property Current() As Object Implements IEnumerator.Current
            Get
                Return Base.Current
            End Get
        End Property

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Return Base.MoveNext()
        End Function

        Sub Reset() Implements IEnumerator.Reset
            Base.Reset()
        End Sub
    End Class
End Class
