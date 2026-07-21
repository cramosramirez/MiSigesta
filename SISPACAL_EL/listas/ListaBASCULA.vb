''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaBASCULA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'BASCULA',
''' es una representación en memoria de los registros de la tabla BASCULA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaBASCULA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaBASCULA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As BASCULA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As BASCULA
        Get
            Return CType((List(index)), BASCULA)
        End Get
        Set(ByVal Value As BASCULA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As BASCULA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BASCULA = CType(List(i), BASCULA)
            If s.ID_BASCULA = value.ID_BASCULA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_BASCULA As Int32) As BASCULA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BASCULA = CType(List(i), BASCULA)
            If s.ID_BASCULA = ID_BASCULA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As BASCULAEnumerator
        Return New BASCULAEnumerator(Me)
    End Function

    Public Class BASCULAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaBASCULA)
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
