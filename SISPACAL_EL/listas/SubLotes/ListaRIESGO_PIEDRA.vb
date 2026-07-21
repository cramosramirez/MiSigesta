<Serializable()> Public Class listaRIESGO_PIEDRA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaRIESGO_PIEDRA)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As RIESGO_PIEDRA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As RIESGO_PIEDRA
        Get
            Return CType((List(index)), RIESGO_PIEDRA)
        End Get
        Set(ByVal Value As RIESGO_PIEDRA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As RIESGO_PIEDRA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As RIESGO_PIEDRA = CType(List(i), RIESGO_PIEDRA)
            If s.ID_RIESGO_PIEDRA = value.ID_RIESGO_PIEDRA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_RIESGO_PIEDRA As Int32) As RIESGO_PIEDRA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As RIESGO_PIEDRA = CType(List(i), RIESGO_PIEDRA)
            If s.ID_RIESGO_PIEDRA = ID_RIESGO_PIEDRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As RIESGO_PIEDRAEnumerator
        Return New RIESGO_PIEDRAEnumerator(Me)
    End Function

    Public Class RIESGO_PIEDRAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaRIESGO_PIEDRA)
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

