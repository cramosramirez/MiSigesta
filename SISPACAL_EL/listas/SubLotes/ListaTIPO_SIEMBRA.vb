<Serializable()> Public Class listaTIPO_SIEMBRA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_SIEMBRA)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_SIEMBRA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_SIEMBRA
        Get
            Return CType((List(index)), TIPO_SIEMBRA)
        End Get
        Set(ByVal Value As TIPO_SIEMBRA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_SIEMBRA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_SIEMBRA = CType(List(i), TIPO_SIEMBRA)
            If s.ID_TIPO_SIEMBRA = value.ID_TIPO_SIEMBRA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_SIEMBRA As Int32) As TIPO_SIEMBRA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_SIEMBRA = CType(List(i), TIPO_SIEMBRA)
            If s.ID_TIPO_SIEMBRA = ID_TIPO_SIEMBRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_SIEMBRAEnumerator
        Return New TIPO_SIEMBRAEnumerator(Me)
    End Function

    Public Class TIPO_SIEMBRAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_SIEMBRA)
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

