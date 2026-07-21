''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaDIA_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DIA_ZAFRA',
''' es una representación en memoria de los registros de la tabla DIA_ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDIA_ZAFRA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaDIA_ZAFRA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As DIA_ZAFRA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As DIA_ZAFRA
        Get
            Return CType((List(index)), DIA_ZAFRA)
        End Get
        Set(ByVal Value As DIA_ZAFRA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As DIA_ZAFRA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DIA_ZAFRA = CType(List(i), DIA_ZAFRA)
            If s.ID_DIA_ZAFRA = value.ID_DIA_ZAFRA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DIA_ZAFRA As Int32) As DIA_ZAFRA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DIA_ZAFRA = CType(List(i), DIA_ZAFRA)
            If s.ID_DIA_ZAFRA = ID_DIA_ZAFRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As DIA_ZAFRAEnumerator
        Return New DIA_ZAFRAEnumerator(Me)
    End Function

    Public Class DIA_ZAFRAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaDIA_ZAFRA)
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
