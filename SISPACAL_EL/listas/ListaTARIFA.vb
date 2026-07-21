''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTARIFA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TARIFA',
''' es una representación en memoria de los registros de la tabla TARIFA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTARIFA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTARIFA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TARIFA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TARIFA
        Get
            Return CType((List(index)), TARIFA)
        End Get
        Set(ByVal Value As TARIFA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TARIFA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TARIFA = CType(List(i), TARIFA)
            If s.CODITARIFA = value.CODITARIFA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODITARIFA As String) As TARIFA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TARIFA = CType(List(i), TARIFA)
            If s.CODITARIFA = CODITARIFA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TARIFAEnumerator
        Return New TARIFAEnumerator(Me)
    End Function

    Public Class TARIFAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTARIFA)
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
