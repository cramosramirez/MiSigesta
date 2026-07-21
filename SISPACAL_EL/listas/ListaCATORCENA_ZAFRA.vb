''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCATORCENA_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CATORCENA_ZAFRA',
''' es una representación en memoria de los registros de la tabla CATORCENA_ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCATORCENA_ZAFRA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCATORCENA_ZAFRA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CATORCENA_ZAFRA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CATORCENA_ZAFRA
        Get
            Return CType((List(index)), CATORCENA_ZAFRA)
        End Get
        Set(ByVal Value As CATORCENA_ZAFRA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CATORCENA_ZAFRA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CATORCENA_ZAFRA = CType(List(i), CATORCENA_ZAFRA)
            If s.ID_CATORCENA = value.ID_CATORCENA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CATORCENA As Int32) As CATORCENA_ZAFRA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CATORCENA_ZAFRA = CType(List(i), CATORCENA_ZAFRA)
            If s.ID_CATORCENA = ID_CATORCENA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CATORCENA_ZAFRAEnumerator
        Return New CATORCENA_ZAFRAEnumerator(Me)
    End Function

    Public Class CATORCENA_ZAFRAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCATORCENA_ZAFRA)
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
