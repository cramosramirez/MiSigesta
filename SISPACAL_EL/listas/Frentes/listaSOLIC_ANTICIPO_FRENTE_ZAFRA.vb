<Serializable()> Public Class listaSOLIC_ANTICIPO_FRENTE_ZAFRA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_ANTICIPO_FRENTE_ZAFRA)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_ANTICIPO_FRENTE_ZAFRA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Item(ByVal index As Integer) As SOLIC_ANTICIPO_FRENTE_ZAFRA
        Get
            Return CType((List(index)), SOLIC_ANTICIPO_FRENTE_ZAFRA)
        End Get
        Set(ByVal Value As SOLIC_ANTICIPO_FRENTE_ZAFRA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_ANTICIPO_FRENTE_ZAFRA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO_FRENTE_ZAFRA = CType(List(i), SOLIC_ANTICIPO_FRENTE_ZAFRA)
            If s.ID_ANTI_ZAFRA = value.ID_ANTI_ZAFRA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ANTI_ZAFRA As Int32) As SOLIC_ANTICIPO_FRENTE_ZAFRA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO_FRENTE_ZAFRA = CType(List(i), SOLIC_ANTICIPO_FRENTE_ZAFRA)
            If s.ID_ANTI_ZAFRA = ID_ANTI_ZAFRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_ANTICIPO_FRENTE_ZAFRAEnumerator
        Return New SOLIC_ANTICIPO_FRENTE_ZAFRAEnumerator(Me)
    End Function

    Public Class SOLIC_ANTICIPO_FRENTE_ZAFRAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_ANTICIPO_FRENTE_ZAFRA)
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
