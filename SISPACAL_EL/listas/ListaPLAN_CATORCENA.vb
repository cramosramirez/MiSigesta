''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLAN_CATORCENA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLAN_CATORCENA',
''' es una representación en memoria de los registros de la tabla PLAN_CATORCENA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLAN_CATORCENA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLAN_CATORCENA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLAN_CATORCENA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLAN_CATORCENA
        Get
            Return CType((List(index)), PLAN_CATORCENA)
        End Get
        Set(ByVal Value As PLAN_CATORCENA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLAN_CATORCENA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_CATORCENA = CType(List(i), PLAN_CATORCENA)
            If s.ID_PLAN_CATORCENA = value.ID_PLAN_CATORCENA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLAN_CATORCENA As Int32) As PLAN_CATORCENA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_CATORCENA = CType(List(i), PLAN_CATORCENA)
            If s.ID_PLAN_CATORCENA = ID_PLAN_CATORCENA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLAN_CATORCENAEnumerator
        Return New PLAN_CATORCENAEnumerator(Me)
    End Function

    Public Class PLAN_CATORCENAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLAN_CATORCENA)
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
