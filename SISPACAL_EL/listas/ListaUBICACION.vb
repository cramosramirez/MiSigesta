''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaUBICACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'UBICACION',
''' es una representación en memoria de los registros de la tabla UBICACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaUBICACION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaUBICACION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As UBICACION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As UBICACION
        Get
            Return CType((List(index)), UBICACION)
        End Get
        Set(ByVal Value As UBICACION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As UBICACION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As UBICACION = CType(List(i), UBICACION)
            If s.CODIUBICACION = value.CODIUBICACION Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODIUBICACION As String) As UBICACION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As UBICACION = CType(List(i), UBICACION)
            If s.CODIUBICACION = CODIUBICACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As UBICACIONEnumerator
        Return New UBICACIONEnumerator(Me)
    End Function

    Public Class UBICACIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaUBICACION)
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
