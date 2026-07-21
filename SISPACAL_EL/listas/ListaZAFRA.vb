''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ZAFRA',
''' es una representación en memoria de los registros de la tabla ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaZAFRA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaZAFRA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ZAFRA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ZAFRA
        Get
            Return CType((List(index)), ZAFRA)
        End Get
        Set(ByVal Value As ZAFRA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ZAFRA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ZAFRA = CType(List(i), ZAFRA)
            If s.ID_ZAFRA = value.ID_ZAFRA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ZAFRA As Int32) As ZAFRA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ZAFRA = CType(List(i), ZAFRA)
            If s.ID_ZAFRA = ID_ZAFRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ZAFRAEnumerator
        Return New ZAFRAEnumerator(Me)
    End Function

    Public Class ZAFRAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaZAFRA)
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
