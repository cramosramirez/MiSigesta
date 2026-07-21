<Serializable()> Public Class listaTOPOGRAFIA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTOPOGRAFIA)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TOPOGRAFIA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TOPOGRAFIA
        Get
            Return CType((List(index)), TOPOGRAFIA)
        End Get
        Set(ByVal Value As TOPOGRAFIA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TOPOGRAFIA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TOPOGRAFIA = CType(List(i), TOPOGRAFIA)
            If s.ID_TOPOGRAFIA = value.ID_TOPOGRAFIA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TOPOGRAFIA As Int32) As TOPOGRAFIA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TOPOGRAFIA = CType(List(i), TOPOGRAFIA)
            If s.ID_TOPOGRAFIA = ID_TOPOGRAFIA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TOPOGRAFIAEnumerator
        Return New TOPOGRAFIAEnumerator(Me)
    End Function

    Public Class TOPOGRAFIAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTOPOGRAFIA)
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


