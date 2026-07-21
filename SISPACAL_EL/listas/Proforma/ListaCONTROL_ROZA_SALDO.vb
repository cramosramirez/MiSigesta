''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTROL_ROZA_SALDO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTROL_ROZA_SALDO',
''' es una representación en memoria de los registros de la tabla CONTROL_ROZA_SALDO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/12/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTROL_ROZA_SALDO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTROL_ROZA_SALDO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTROL_ROZA_SALDO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTROL_ROZA_SALDO
        Get
            Return CType((List(index)), CONTROL_ROZA_SALDO)
        End Get
        Set(ByVal Value As CONTROL_ROZA_SALDO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTROL_ROZA_SALDO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTROL_ROZA_SALDO = CType(List(i), CONTROL_ROZA_SALDO)
            If s.ID_ROZA_SALDO = value.ID_ROZA_SALDO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ROZA_SALDO As Int32) As CONTROL_ROZA_SALDO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTROL_ROZA_SALDO = CType(List(i), CONTROL_ROZA_SALDO)
            If s.ID_ROZA_SALDO = ID_ROZA_SALDO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTROL_ROZA_SALDOEnumerator
        Return New CONTROL_ROZA_SALDOEnumerator(Me)
    End Function

    Public Class CONTROL_ROZA_SALDOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTROL_ROZA_SALDO)
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
