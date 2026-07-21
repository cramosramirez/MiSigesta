''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaMAESTRO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MAESTRO_LOTES',
''' es una representación en memoria de los registros de la tabla MAESTRO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMAESTRO_LOTES
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaMAESTRO_LOTES )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As MAESTRO_LOTES)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As MAESTRO_LOTES
        Get
            Return CType((List(index)), MAESTRO_LOTES)
        End Get
        Set(ByVal Value As MAESTRO_LOTES)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As MAESTRO_LOTES) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MAESTRO_LOTES = CType(List(i), MAESTRO_LOTES)
            If s.ID_MAESTRO = value.ID_MAESTRO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_MAESTRO As Int32) As MAESTRO_LOTES
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MAESTRO_LOTES = CType(List(i), MAESTRO_LOTES)
            If s.ID_MAESTRO = ID_MAESTRO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As MAESTRO_LOTESEnumerator
        Return New MAESTRO_LOTESEnumerator(Me)
    End Function

    Public Class MAESTRO_LOTESEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaMAESTRO_LOTES)
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
