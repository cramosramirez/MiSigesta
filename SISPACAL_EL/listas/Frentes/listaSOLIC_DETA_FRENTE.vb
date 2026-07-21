<Serializable()> Public Class listaSOLIC_DETA_FRENTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_DETA_FRENTE)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_DETA_FRENTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Item(ByVal index As Integer) As SOLIC_DETA_FRENTE
        Get
            Return CType((List(index)), SOLIC_DETA_FRENTE)
        End Get
        Set(ByVal Value As SOLIC_DETA_FRENTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_DETA_FRENTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_DETA_FRENTE = CType(List(i), SOLIC_DETA_FRENTE)
            If s.ID_SOLIC_DETA = value.ID_SOLIC_DETA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SOLIC_DETA As Int32) As SOLIC_DETA_FRENTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_DETA_FRENTE = CType(List(i), SOLIC_DETA_FRENTE)
            If s.ID_SOLIC_DETA = ID_SOLIC_DETA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_DETA_FRENTEEnumerator
        Return New SOLIC_DETA_FRENTEEnumerator(Me)
    End Function

    Public Class SOLIC_DETA_FRENTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_DETA_FRENTE)
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
