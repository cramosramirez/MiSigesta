''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROYFIN_ING
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROYFIN_ING',
''' es una representación en memoria de los registros de la tabla PROYFIN_ING
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROYFIN_ING
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROYFIN_ING )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROYFIN_ING)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROYFIN_ING
        Get
            Return CType((List(index)), PROYFIN_ING)
        End Get
        Set(ByVal Value As PROYFIN_ING)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROYFIN_ING) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROYFIN_ING = CType(List(i), PROYFIN_ING)
            If s.ID_PROYFIN_ING = value.ID_PROYFIN_ING Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROYFIN_ING As Int32) As PROYFIN_ING
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROYFIN_ING = CType(List(i), PROYFIN_ING)
            If s.ID_PROYFIN_ING = ID_PROYFIN_ING Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROYFIN_INGEnumerator
        Return New PROYFIN_INGEnumerator(Me)
    End Function

    Public Class PROYFIN_INGEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROYFIN_ING)
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
