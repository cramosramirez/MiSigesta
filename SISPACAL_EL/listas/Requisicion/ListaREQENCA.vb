''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaREQENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'REQENCA',
''' es una representación en memoria de los registros de la tabla REQENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaREQENCA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaREQENCA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As REQENCA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As REQENCA
        Get
            Return CType((List(index)), REQENCA)
        End Get
        Set(ByVal Value As REQENCA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As REQENCA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REQENCA = CType(List(i), REQENCA)
            If s.ID_REQENCA = value.ID_REQENCA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_REQENCA As Int32) As REQENCA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REQENCA = CType(List(i), REQENCA)
            If s.ID_REQENCA = ID_REQENCA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As REQENCAEnumerator
        Return New REQENCAEnumerator(Me)
    End Function

    Public Class REQENCAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaREQENCA)
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
