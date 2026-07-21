''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCHEQUE_PARTIDA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CHEQUE_PARTIDA',
''' es una representación en memoria de los registros de la tabla CHEQUE_PARTIDA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCHEQUE_PARTIDA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCHEQUE_PARTIDA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CHEQUE_PARTIDA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CHEQUE_PARTIDA
        Get
            Return CType((List(index)), CHEQUE_PARTIDA)
        End Get
        Set(ByVal Value As CHEQUE_PARTIDA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CHEQUE_PARTIDA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CHEQUE_PARTIDA = CType(List(i), CHEQUE_PARTIDA)
            If s.ID_CHEQUE_PARTIDA = value.ID_CHEQUE_PARTIDA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CHEQUE_PARTIDA As Int32) As CHEQUE_PARTIDA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CHEQUE_PARTIDA = CType(List(i), CHEQUE_PARTIDA)
            If s.ID_CHEQUE_PARTIDA = ID_CHEQUE_PARTIDA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CHEQUE_PARTIDAEnumerator
        Return New CHEQUE_PARTIDAEnumerator(Me)
    End Function

    Public Class CHEQUE_PARTIDAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCHEQUE_PARTIDA)
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
