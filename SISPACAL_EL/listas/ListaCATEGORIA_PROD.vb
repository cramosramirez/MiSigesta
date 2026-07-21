''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCATEGORIA_PROD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CATEGORIA_PROD',
''' es una representación en memoria de los registros de la tabla CATEGORIA_PROD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCATEGORIA_PROD
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCATEGORIA_PROD )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CATEGORIA_PROD)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CATEGORIA_PROD
        Get
            Return CType((List(index)), CATEGORIA_PROD)
        End Get
        Set(ByVal Value As CATEGORIA_PROD)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CATEGORIA_PROD) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CATEGORIA_PROD = CType(List(i), CATEGORIA_PROD)
            If s.ID_CATEGORIA = value.ID_CATEGORIA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CATEGORIA As Int32) As CATEGORIA_PROD
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CATEGORIA_PROD = CType(List(i), CATEGORIA_PROD)
            If s.ID_CATEGORIA = ID_CATEGORIA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CATEGORIA_PRODEnumerator
        Return New CATEGORIA_PRODEnumerator(Me)
    End Function

    Public Class CATEGORIA_PRODEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCATEGORIA_PROD)
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
