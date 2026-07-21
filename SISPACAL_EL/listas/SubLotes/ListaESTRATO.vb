<Serializable()> Public Class listaESTRATO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaESTRATO)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ESTRATO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ESTRATO
        Get
            Return CType((List(index)), ESTRATO)
        End Get
        Set(ByVal Value As ESTRATO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ESTRATO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ESTRATO = CType(List(i), ESTRATO)
            If s.ID_ESTRATO = value.ID_ESTRATO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ESTRATO As Int32) As ESTRATO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ESTRATO = CType(List(i), ESTRATO)
            If s.ID_ESTRATO = ID_ESTRATO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ESTRATOEnumerator
        Return New ESTRATOEnumerator(Me)
    End Function

    Public Class ESTRATOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaESTRATO)
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

