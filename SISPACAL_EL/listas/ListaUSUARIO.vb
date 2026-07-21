''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaUSUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'USUARIO',
''' es una representación en memoria de los registros de la tabla USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaUSUARIO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaUSUARIO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As USUARIO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As USUARIO
        Get
            Return CType((List(index)), USUARIO)
        End Get
        Set(ByVal Value As USUARIO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As USUARIO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As USUARIO = CType(List(i), USUARIO)
            If s.USUARIO = value.USUARIO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal USUARIO As String) As USUARIO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As USUARIO = CType(List(i), USUARIO)
            If s.USUARIO = USUARIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As USUARIOEnumerator
        Return New USUARIOEnumerator(Me)
    End Function

    Public Class USUARIOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaUSUARIO)
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
