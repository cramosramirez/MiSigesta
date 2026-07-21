<Serializable()> Public Class listaSOLIC_ANTICIPO_FRENTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_ANTICIPO_FRENTE)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_ANTICIPO_FRENTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Item(ByVal index As Integer) As SOLIC_ANTICIPO_FRENTE
        Get
            Return CType((List(index)), SOLIC_ANTICIPO_FRENTE)
        End Get
        Set(ByVal Value As SOLIC_ANTICIPO_FRENTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_ANTICIPO_FRENTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO_FRENTE = CType(List(i), SOLIC_ANTICIPO_FRENTE)
            If s.ID_ANTICIPO = value.ID_ANTICIPO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ANTICIPO As Int32) As SOLIC_ANTICIPO_FRENTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO_FRENTE = CType(List(i), SOLIC_ANTICIPO_FRENTE)
            If s.ID_ANTICIPO = ID_ANTICIPO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_ANTICIPO_FRENTEEnumerator
        Return New SOLIC_ANTICIPO_FRENTEEnumerator(Me)
    End Function

    Public Class SOLIC_ANTICIPO_FRENTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_ANTICIPO_FRENTE)
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
