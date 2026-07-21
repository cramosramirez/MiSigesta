''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCICLO_PERIODO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CICLO_PERIODO',
''' es una representación en memoria de los registros de la tabla CICLO_PERIODO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	27/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCICLO_PERIODO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCICLO_PERIODO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CICLO_PERIODO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CICLO_PERIODO
        Get
            Return CType((List(index)), CICLO_PERIODO)
        End Get
        Set(ByVal Value As CICLO_PERIODO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CICLO_PERIODO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CICLO_PERIODO = CType(List(i), CICLO_PERIODO)
            If s.ID_CICLO_PERIODO = value.ID_CICLO_PERIODO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CICLO_PERIODO As Int32) As CICLO_PERIODO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CICLO_PERIODO = CType(List(i), CICLO_PERIODO)
            If s.ID_CICLO_PERIODO = ID_CICLO_PERIODO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CICLO_PERIODOEnumerator
        Return New CICLO_PERIODOEnumerator(Me)
    End Function

    Public Class CICLO_PERIODOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCICLO_PERIODO)
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
