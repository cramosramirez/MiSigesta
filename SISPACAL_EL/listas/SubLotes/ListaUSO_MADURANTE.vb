<Serializable()> Public Class listaUSO_MADURANTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaUSO_MADURANTE)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As USO_MADURANTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As USO_MADURANTE
        Get
            Return CType((List(index)), USO_MADURANTE)
        End Get
        Set(ByVal Value As USO_MADURANTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As USO_MADURANTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As USO_MADURANTE = CType(List(i), USO_MADURANTE)
            If s.ID_USO_MAD = value.ID_USO_MAD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_USO_MAD As Int32) As USO_MADURANTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As USO_MADURANTE = CType(List(i), USO_MADURANTE)
            If s.ID_USO_MAD = ID_USO_MAD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As USO_MADURANTEEnumerator
        Return New USO_MADURANTEEnumerator(Me)
    End Function

    Public Class USO_MADURANTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaUSO_MADURANTE)
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



