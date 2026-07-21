<Serializable()> Public Class ListaENVIO_SEDIMENTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As ListaENVIO_SEDIMENTO)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ENVIO_SEDIMENTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ENVIO_SEDIMENTO
        Get
            Return CType((List(index)), ENVIO_SEDIMENTO)
        End Get
        Set(ByVal Value As ENVIO_SEDIMENTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ENVIO_SEDIMENTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_SEDIMENTO = CType(List(i), ENVIO_SEDIMENTO)
            If s.ID_ENVIO_SEDI = value.ID_ENVIO_SEDI Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ENVIO_SEDI As Int32) As ENVIO_SEDIMENTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_SEDIMENTO = CType(List(i), ENVIO_SEDIMENTO)
            If s.ID_ENVIO_SEDI = ID_ENVIO_SEDI Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ENVIO_SEDIMENTOEnumerator
        Return New ENVIO_SEDIMENTOEnumerator(Me)
    End Function

    Public Class ENVIO_SEDIMENTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As ListaENVIO_SEDIMENTO)
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
