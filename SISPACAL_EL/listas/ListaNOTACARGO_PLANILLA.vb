<Serializable()> Public Class listaNOTACARGO_PLANILLA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaNOTACARGO_PLANILLA)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As NOTACARGO_PLANILLA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As NOTACARGO_PLANILLA
        Get
            Return CType((List(index)), NOTACARGO_PLANILLA)
        End Get
        Set(ByVal Value As NOTACARGO_PLANILLA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As NOTACARGO_PLANILLA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As NOTACARGO_PLANILLA = CType(List(i), NOTACARGO_PLANILLA)
            If s.ID_NOTACARGO = value.ID_NOTACARGO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_NOTACARGO As Int32) As NOTACARGO_PLANILLA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As NOTACARGO_PLANILLA = CType(List(i), NOTACARGO_PLANILLA)
            If s.ID_NOTACARGO = ID_NOTACARGO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As NOTACARGO_PLANILLAEnumerator
        Return New NOTACARGO_PLANILLAEnumerator(Me)
    End Function

    Public Class NOTACARGO_PLANILLAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaNOTACARGO_PLANILLA)
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
