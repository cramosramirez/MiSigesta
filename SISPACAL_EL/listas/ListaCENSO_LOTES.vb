''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCENSO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CENSO_LOTES',
''' es una representación en memoria de los registros de la tabla CENSO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCENSO_LOTES
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCENSO_LOTES )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CENSO_LOTES)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CENSO_LOTES
        Get
            Return CType((List(index)), CENSO_LOTES)
        End Get
        Set(ByVal Value As CENSO_LOTES)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CENSO_LOTES) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CENSO_LOTES = CType(List(i), CENSO_LOTES)
            If s.ID_CENSO_LOTES = value.ID_CENSO_LOTES Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CENSO_LOTES As Int32) As CENSO_LOTES
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CENSO_LOTES = CType(List(i), CENSO_LOTES)
            If s.ID_CENSO_LOTES = ID_CENSO_LOTES Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CENSO_LOTESEnumerator
        Return New CENSO_LOTESEnumerator(Me)
    End Function

    Public Class CENSO_LOTESEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCENSO_LOTES)
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
