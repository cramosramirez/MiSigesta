''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROYFIN_ING_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROYFIN_ING_LOTE',
''' es una representación en memoria de los registros de la tabla PROYFIN_ING_LOTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROYFIN_ING_LOTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROYFIN_ING_LOTE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROYFIN_ING_LOTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROYFIN_ING_LOTE
        Get
            Return CType((List(index)), PROYFIN_ING_LOTE)
        End Get
        Set(ByVal Value As PROYFIN_ING_LOTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROYFIN_ING_LOTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROYFIN_ING_LOTE = CType(List(i), PROYFIN_ING_LOTE)
            If s.ID_PROYFIN_ING_LOTE = value.ID_PROYFIN_ING_LOTE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROYFIN_ING_LOTE As Int32) As PROYFIN_ING_LOTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROYFIN_ING_LOTE = CType(List(i), PROYFIN_ING_LOTE)
            If s.ID_PROYFIN_ING_LOTE = ID_PROYFIN_ING_LOTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROYFIN_ING_LOTEEnumerator
        Return New PROYFIN_ING_LOTEEnumerator(Me)
    End Function

    Public Class PROYFIN_ING_LOTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROYFIN_ING_LOTE)
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
