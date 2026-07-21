''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaZAFGAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ZAFGAS',
''' es una representación en memoria de los registros de la tabla ZAFGAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaZAFGAS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaZAFGAS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ZAFGAS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ZAFGAS
        Get
            Return CType((List(index)), ZAFGAS)
        End Get
        Set(ByVal Value As ZAFGAS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ZAFGAS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ZAFGAS = CType(List(i), ZAFGAS)
            If s.MEDIO = value.MEDIO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal MEDIO As String) As ZAFGAS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ZAFGAS = CType(List(i), ZAFGAS)
            If s.MEDIO = MEDIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ZAFGASEnumerator
        Return New ZAFGASEnumerator(Me)
    End Function

    Public Class ZAFGASEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaZAFGAS)
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
