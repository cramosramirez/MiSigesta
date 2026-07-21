<Serializable()> Public Class listaCREDITO_MOV_FRENTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCREDITO_MOV_FRENTE)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CREDITO_MOV_FRENTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Item(ByVal index As Integer) As CREDITO_MOV_FRENTE
        Get
            Return CType((List(index)), CREDITO_MOV_FRENTE)
        End Get
        Set(ByVal Value As CREDITO_MOV_FRENTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CREDITO_MOV_FRENTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CREDITO_MOV_FRENTE = CType(List(i), CREDITO_MOV_FRENTE)
            If s.ID_CREDITO_MOV = value.ID_CREDITO_MOV Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CREDITO_MOV As Int32) As CREDITO_MOV_FRENTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CREDITO_MOV_FRENTE = CType(List(i), CREDITO_MOV_FRENTE)
            If s.ID_CREDITO_MOV = ID_CREDITO_MOV Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CREDITO_MOV_FRENTEEnumerator
        Return New CREDITO_MOV_FRENTEEnumerator(Me)
    End Function

    Public Class CREDITO_MOV_FRENTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCREDITO_MOV_FRENTE)
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