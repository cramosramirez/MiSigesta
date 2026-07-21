''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCICLO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CICLO',
''' es una representación en memoria de los registros de la tabla CICLO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	27/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCICLO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCICLO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CICLO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CICLO
        Get
            Return CType((List(index)), CICLO)
        End Get
        Set(ByVal Value As CICLO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CICLO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CICLO = CType(List(i), CICLO)
            If s.ID_CICLO = value.ID_CICLO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CICLO As Int32) As CICLO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CICLO = CType(List(i), CICLO)
            If s.ID_CICLO = ID_CICLO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CICLOEnumerator
        Return New CICLOEnumerator(Me)
    End Function

    Public Class CICLOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCICLO)
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
