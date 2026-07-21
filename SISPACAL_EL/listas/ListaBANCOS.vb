''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaBANCOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'BANCOS',
''' es una representación en memoria de los registros de la tabla BANCOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaBANCOS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaBANCOS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As BANCOS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As BANCOS
        Get
            Return CType((List(index)), BANCOS)
        End Get
        Set(ByVal Value As BANCOS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As BANCOS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BANCOS = CType(List(i), BANCOS)
            If s.CODIBANCO = value.CODIBANCO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODIBANCO As Int32) As BANCOS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BANCOS = CType(List(i), BANCOS)
            If s.CODIBANCO = CODIBANCO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As BANCOSEnumerator
        Return New BANCOSEnumerator(Me)
    End Function

    Public Class BANCOSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaBANCOS)
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
