''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaMONITOR_CAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MONITOR_CAL',
''' es una representación en memoria de los registros de la tabla MONITOR_CAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMONITOR_CAL
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaMONITOR_CAL )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As MONITOR_CAL)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As MONITOR_CAL
        Get
            Return CType((List(index)), MONITOR_CAL)
        End Get
        Set(ByVal Value As MONITOR_CAL)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As MONITOR_CAL) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MONITOR_CAL = CType(List(i), MONITOR_CAL)
            If s.ID_MONITOR = value.ID_MONITOR Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_MONITOR As Int32) As MONITOR_CAL
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MONITOR_CAL = CType(List(i), MONITOR_CAL)
            If s.ID_MONITOR = ID_MONITOR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As MONITOR_CALEnumerator
        Return New MONITOR_CALEnumerator(Me)
    End Function

    Public Class MONITOR_CALEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaMONITOR_CAL)
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
