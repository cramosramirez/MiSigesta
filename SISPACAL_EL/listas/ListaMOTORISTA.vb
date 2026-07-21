''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaMOTORISTA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MOTORISTA',
''' es una representación en memoria de los registros de la tabla MOTORISTA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMOTORISTA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaMOTORISTA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As MOTORISTA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As MOTORISTA
        Get
            Return CType((List(index)), MOTORISTA)
        End Get
        Set(ByVal Value As MOTORISTA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As MOTORISTA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MOTORISTA = CType(List(i), MOTORISTA)
            If s.ID_MOTORISTA = value.ID_MOTORISTA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_MOTORISTA As Int32) As MOTORISTA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MOTORISTA = CType(List(i), MOTORISTA)
            If s.ID_MOTORISTA = ID_MOTORISTA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As MOTORISTAEnumerator
        Return New MOTORISTAEnumerator(Me)
    End Function

    Public Class MOTORISTAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaMOTORISTA)
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
