''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTROL_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTROL_ROZA',
''' es una representación en memoria de los registros de la tabla CONTROL_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTROL_ROZA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTROL_ROZA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTROL_ROZA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTROL_ROZA
        Get
            Return CType((List(index)), CONTROL_ROZA)
        End Get
        Set(ByVal Value As CONTROL_ROZA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTROL_ROZA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTROL_ROZA = CType(List(i), CONTROL_ROZA)
            If s.ID_CONTROL_ROZA = value.ID_CONTROL_ROZA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CONTROL_ROZA As Int32) As CONTROL_ROZA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTROL_ROZA = CType(List(i), CONTROL_ROZA)
            If s.ID_CONTROL_ROZA = ID_CONTROL_ROZA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTROL_ROZAEnumerator
        Return New CONTROL_ROZAEnumerator(Me)
    End Function

    Public Class CONTROL_ROZAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTROL_ROZA)
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
