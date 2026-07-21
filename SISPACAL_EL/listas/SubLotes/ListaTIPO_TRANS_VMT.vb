<Serializable()> Public Class listaTIPO_TRANS_VMT
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_TRANS_VMT)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_TRANS_VMT)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_TRANS_VMT
        Get
            Return CType((List(index)), TIPO_TRANS_VMT)
        End Get
        Set(ByVal Value As TIPO_TRANS_VMT)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_TRANS_VMT) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_TRANS_VMT = CType(List(i), TIPO_TRANS_VMT)
            If s.ID_TIPO_TRANS_VMT = value.ID_TIPO_TRANS_VMT Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_TRANS_VMT As Int32) As TIPO_TRANS_VMT
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_TRANS_VMT = CType(List(i), TIPO_TRANS_VMT)
            If s.ID_TIPO_TRANS_VMT = ID_TIPO_TRANS_VMT Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_TRANS_VMTEnumerator
        Return New TIPO_TRANS_VMTEnumerator(Me)
    End Function

    Public Class TIPO_TRANS_VMTEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_TRANS_VMT)
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

