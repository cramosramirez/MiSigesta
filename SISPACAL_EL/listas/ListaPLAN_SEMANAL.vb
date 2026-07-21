''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLAN_SEMANAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLAN_SEMANAL',
''' es una representación en memoria de los registros de la tabla PLAN_SEMANAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLAN_SEMANAL
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLAN_SEMANAL )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLAN_SEMANAL)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLAN_SEMANAL
        Get
            Return CType((List(index)), PLAN_SEMANAL)
        End Get
        Set(ByVal Value As PLAN_SEMANAL)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLAN_SEMANAL) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_SEMANAL = CType(List(i), PLAN_SEMANAL)
            If s.ID_PLAN_SEMANAL = value.ID_PLAN_SEMANAL Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLAN_SEMANAL As Int32) As PLAN_SEMANAL
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_SEMANAL = CType(List(i), PLAN_SEMANAL)
            If s.ID_PLAN_SEMANAL = ID_PLAN_SEMANAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLAN_SEMANALEnumerator
        Return New PLAN_SEMANALEnumerator(Me)
    End Function

    Public Class PLAN_SEMANALEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLAN_SEMANAL)
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
