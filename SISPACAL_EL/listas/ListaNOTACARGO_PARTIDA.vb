<Serializable()> Public Class listaNOTACARGO_PARTIDA

    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaNOTACARGO_PARTIDA)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As NOTACARGO_PARTIDA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As NOTACARGO_PARTIDA
        Get
            Return CType((List(index)), NOTACARGO_PARTIDA)
        End Get
        Set(ByVal Value As NOTACARGO_PARTIDA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As NOTACARGO_PARTIDA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As NOTACARGO_PARTIDA = CType(List(i), NOTACARGO_PARTIDA)
            If s.ID_NOTACARGO_PARTIDA = value.ID_NOTACARGO_PARTIDA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_NOTACARGO_PARTIDA As Int32) As NOTACARGO_PARTIDA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As NOTACARGO_PARTIDA = CType(List(i), NOTACARGO_PARTIDA)
            If s.ID_NOTACARGO_PARTIDA = ID_NOTACARGO_PARTIDA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As NOTACARGO_PARTIDAEnumerator
        Return New NOTACARGO_PARTIDAEnumerator(Me)
    End Function

    Public Class NOTACARGO_PARTIDAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaNOTACARGO_PARTIDA)
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
