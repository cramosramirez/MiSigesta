<Serializable()> Public Class ListaENVIO_ROZA_PS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As ListaENVIO_ROZA_PS)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ENVIO_ROZA_PS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ENVIO_ROZA_PS
        Get
            Return CType((List(index)), ENVIO_ROZA_PS)
        End Get
        Set(ByVal Value As ENVIO_ROZA_PS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ENVIO_ROZA_PS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_ROZA_PS = CType(List(i), ENVIO_ROZA_PS)
            If s.ID_ENVIO_ROZA = value.ID_ENVIO_ROZA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ENVIO_ROZA As Int32) As ENVIO_ROZA_PS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_ROZA_PS = CType(List(i), ENVIO_ROZA_PS)
            If s.ID_ENVIO_ROZA = ID_ENVIO_ROZA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function



    Public Shadows Function GetEnumerator() As ENVIO_ROZA_PSEnumerator
        Return New ENVIO_ROZA_PSEnumerator(Me)
    End Function

    Public Class ENVIO_ROZA_PSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As ListaENVIO_ROZA_PS)
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
