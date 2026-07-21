<Serializable()> Public Class ListaTIPOSUELO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As ListaTIPOSUELO)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPOSUELO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPOSUELO
        Get
            Return CType((List(index)), TIPOSUELO)
        End Get
        Set(ByVal Value As TIPOSUELO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPOSUELO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPOSUELO = CType(List(i), TIPOSUELO)
            If s.ID_TIPO_SUELO = value.ID_TIPO_SUELO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_SUELO As Int32) As TIPOSUELO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPOSUELO = CType(List(i), TIPOSUELO)
            If s.ID_TIPO_SUELO = ID_TIPO_SUELO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPOSUELOEnumerator
        Return New TIPOSUELOEnumerator(Me)
    End Function

    Public Class TIPOSUELOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As ListaTIPOSUELO)
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
