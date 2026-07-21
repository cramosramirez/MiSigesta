''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLAN_COSECHA_DIARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLAN_COSECHA_DIARIO',
''' es una representación en memoria de los registros de la tabla PLAN_COSECHA_DIARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLAN_COSECHA_DIARIO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLAN_COSECHA_DIARIO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLAN_COSECHA_DIARIO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLAN_COSECHA_DIARIO
        Get
            Return CType((List(index)), PLAN_COSECHA_DIARIO)
        End Get
        Set(ByVal Value As PLAN_COSECHA_DIARIO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLAN_COSECHA_DIARIO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_COSECHA_DIARIO = CType(List(i), PLAN_COSECHA_DIARIO)
            If s.ID_PLAN_COSECHA_DIARIO = value.ID_PLAN_COSECHA_DIARIO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLAN_COSECHA_DIARIO As Int32) As PLAN_COSECHA_DIARIO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_COSECHA_DIARIO = CType(List(i), PLAN_COSECHA_DIARIO)
            If s.ID_PLAN_COSECHA_DIARIO = ID_PLAN_COSECHA_DIARIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLAN_COSECHA_DIARIOEnumerator
        Return New PLAN_COSECHA_DIARIOEnumerator(Me)
    End Function

    Public Class PLAN_COSECHA_DIARIOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLAN_COSECHA_DIARIO)
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
