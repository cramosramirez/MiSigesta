''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTARIFA_VUELO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TARIFA_VUELO',
''' es una representación en memoria de los registros de la tabla TARIFA_VUELO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTARIFA_VUELO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTARIFA_VUELO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TARIFA_VUELO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TARIFA_VUELO
        Get
            Return CType((List(index)), TARIFA_VUELO)
        End Get
        Set(ByVal Value As TARIFA_VUELO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TARIFA_VUELO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TARIFA_VUELO = CType(List(i), TARIFA_VUELO)
            If s.ID_TARIFA = value.ID_TARIFA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TARIFA As Int32) As TARIFA_VUELO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TARIFA_VUELO = CType(List(i), TARIFA_VUELO)
            If s.ID_TARIFA = ID_TARIFA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TARIFA_VUELOEnumerator
        Return New TARIFA_VUELOEnumerator(Me)
    End Function

    Public Class TARIFA_VUELOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTARIFA_VUELO)
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
