''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaZONAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ZONAS',
''' es una representación en memoria de los registros de la tabla ZONAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaZONAS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaZONAS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ZONAS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ZONAS
        Get
            Return CType((List(index)), ZONAS)
        End Get
        Set(ByVal Value As ZONAS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ZONAS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ZONAS = CType(List(i), ZONAS)
            If s.ZONA = value.ZONA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ZONA As String) As ZONAS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ZONAS = CType(List(i), ZONAS)
            If s.ZONA = ZONA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ZONASEnumerator
        Return New ZONASEnumerator(Me)
    End Function

    Public Class ZONASEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaZONAS)
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
