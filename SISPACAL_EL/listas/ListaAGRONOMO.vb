''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaAGRONOMO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'AGRONOMO',
''' es una representación en memoria de los registros de la tabla AGRONOMO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaAGRONOMO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaAGRONOMO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As AGRONOMO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As AGRONOMO
        Get
            Return CType((List(index)), AGRONOMO)
        End Get
        Set(ByVal Value As AGRONOMO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As AGRONOMO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As AGRONOMO = CType(List(i), AGRONOMO)
            If s.CODIAGRON = value.CODIAGRON Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODIAGRON As String) As AGRONOMO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As AGRONOMO = CType(List(i), AGRONOMO)
            If s.CODIAGRON = CODIAGRON Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As AGRONOMOEnumerator
        Return New AGRONOMOEnumerator(Me)
    End Function

    Public Class AGRONOMOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaAGRONOMO)
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
