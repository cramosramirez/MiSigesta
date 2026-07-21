''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LOTES',
''' es una representación en memoria de los registros de la tabla LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLOTES
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLOTES )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LOTES)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LOTES
        Get
            Return CType((List(index)), LOTES)
        End Get
        Set(ByVal Value As LOTES)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LOTES) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES = CType(List(i), LOTES)
            If s.ACCESLOTE = value.ACCESLOTE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ACCESLOTE As String) As LOTES
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES = CType(List(i), LOTES)
            If s.ACCESLOTE = ACCESLOTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LOTESEnumerator
        Return New LOTESEnumerator(Me)
    End Function

    Public Class LOTESEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLOTES)
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
