''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSUPERVISOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SUPERVISOR',
''' es una representación en memoria de los registros de la tabla SUPERVISOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSUPERVISOR
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSUPERVISOR )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SUPERVISOR)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SUPERVISOR
        Get
            Return CType((List(index)), SUPERVISOR)
        End Get
        Set(ByVal Value As SUPERVISOR)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SUPERVISOR) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SUPERVISOR = CType(List(i), SUPERVISOR)
            If s.ID_SUPERVISOR = value.ID_SUPERVISOR Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SUPERVISOR As Int32) As SUPERVISOR
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SUPERVISOR = CType(List(i), SUPERVISOR)
            If s.ID_SUPERVISOR = ID_SUPERVISOR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SUPERVISOREnumerator
        Return New SUPERVISOREnumerator(Me)
    End Function

    Public Class SUPERVISOREnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSUPERVISOR)
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
