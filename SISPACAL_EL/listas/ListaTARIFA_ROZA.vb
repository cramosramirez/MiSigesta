''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTARIFA_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TARIFA_ROZA',
''' es una representación en memoria de los registros de la tabla TARIFA_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTARIFA_ROZA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTARIFA_ROZA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TARIFA_ROZA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TARIFA_ROZA
        Get
            Return CType((List(index)), TARIFA_ROZA)
        End Get
        Set(ByVal Value As TARIFA_ROZA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TARIFA_ROZA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TARIFA_ROZA = CType(List(i), TARIFA_ROZA)
            If s.ID_TARIFA_ROZA = value.ID_TARIFA_ROZA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TARIFA_ROZA As Int32) As TARIFA_ROZA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TARIFA_ROZA = CType(List(i), TARIFA_ROZA)
            If s.ID_TARIFA_ROZA = ID_TARIFA_ROZA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TARIFA_ROZAEnumerator
        Return New TARIFA_ROZAEnumerator(Me)
    End Function

    Public Class TARIFA_ROZAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTARIFA_ROZA)
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
