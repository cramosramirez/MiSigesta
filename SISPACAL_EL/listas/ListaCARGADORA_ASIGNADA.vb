''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCARGADORA_ASIGNADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CARGADORA_ASIGNADA',
''' es una representación en memoria de los registros de la tabla CARGADORA_ASIGNADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCARGADORA_ASIGNADA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCARGADORA_ASIGNADA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CARGADORA_ASIGNADA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CARGADORA_ASIGNADA
        Get
            Return CType((List(index)), CARGADORA_ASIGNADA)
        End Get
        Set(ByVal Value As CARGADORA_ASIGNADA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CARGADORA_ASIGNADA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CARGADORA_ASIGNADA = CType(List(i), CARGADORA_ASIGNADA)
            If s.ID_CARGADORA_ASIG = value.ID_CARGADORA_ASIG Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CARGADORA_ASIG As Int32) As CARGADORA_ASIGNADA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CARGADORA_ASIGNADA = CType(List(i), CARGADORA_ASIGNADA)
            If s.ID_CARGADORA_ASIG = ID_CARGADORA_ASIG Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CARGADORA_ASIGNADAEnumerator
        Return New CARGADORA_ASIGNADAEnumerator(Me)
    End Function

    Public Class CARGADORA_ASIGNADAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCARGADORA_ASIGNADA)
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
