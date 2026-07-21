''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaAJUSTE_POL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'AJUSTE_POL',
''' es una representación en memoria de los registros de la tabla AJUSTE_POL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaAJUSTE_POL
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaAJUSTE_POL )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As AJUSTE_POL)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As AJUSTE_POL
        Get
            Return CType((List(index)), AJUSTE_POL)
        End Get
        Set(ByVal Value As AJUSTE_POL)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As AJUSTE_POL) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As AJUSTE_POL = CType(List(i), AJUSTE_POL)
            If s.DENSIDAD = value.DENSIDAD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal DENSIDAD As Int32) As AJUSTE_POL
        Dim i As Integer = 0
        While i < List.Count
            Dim s As AJUSTE_POL = CType(List(i), AJUSTE_POL)
            If s.DENSIDAD = DENSIDAD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As AJUSTE_POLEnumerator
        Return New AJUSTE_POLEnumerator(Me)
    End Function

    Public Class AJUSTE_POLEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaAJUSTE_POL)
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
