<Serializable()> Public Class listaSOLIC_ANTICIPO_LIQFINAN
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_ANTICIPO_LIQFINAN)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_ANTICIPO_LIQFINAN)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_ANTICIPO_LIQFINAN
        Get
            Return CType((List(index)), SOLIC_ANTICIPO_LIQFINAN)
        End Get
        Set(ByVal Value As SOLIC_ANTICIPO_LIQFINAN)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_ANTICIPO_LIQFINAN) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO_LIQFINAN = CType(List(i), SOLIC_ANTICIPO_LIQFINAN)
            If s.ID_ANTI_LIQ = value.ID_ANTI_LIQ Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ANTI_LIQ As Int32) As SOLIC_ANTICIPO_LIQFINAN
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO_LIQFINAN = CType(List(i), SOLIC_ANTICIPO_LIQFINAN)
            If s.ID_ANTI_LIQ = ID_ANTI_LIQ Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_ANTICIPO_LIQFINANEnumerator
        Return New SOLIC_ANTICIPO_LIQFINANEnumerator(Me)
    End Function

    Public Class SOLIC_ANTICIPO_LIQFINANEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_ANTICIPO_LIQFINAN)
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
