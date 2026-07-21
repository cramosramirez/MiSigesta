''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaFILTRO_ORDEN_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FILTRO_ORDEN_ROZA',
''' es una representación en memoria de los registros de la tabla FILTRO_ORDEN_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFILTRO_ORDEN_ROZA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaFILTRO_ORDEN_ROZA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As FILTRO_ORDEN_ROZA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As FILTRO_ORDEN_ROZA
        Get
            Return CType((List(index)), FILTRO_ORDEN_ROZA)
        End Get
        Set(ByVal Value As FILTRO_ORDEN_ROZA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As FILTRO_ORDEN_ROZA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As FILTRO_ORDEN_ROZA = CType(List(i), FILTRO_ORDEN_ROZA)
            If s.ID_FILTRO_ORDEN_ROZA = value.ID_FILTRO_ORDEN_ROZA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_FILTRO_ORDEN_ROZA As Int32) As FILTRO_ORDEN_ROZA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As FILTRO_ORDEN_ROZA = CType(List(i), FILTRO_ORDEN_ROZA)
            If s.ID_FILTRO_ORDEN_ROZA = ID_FILTRO_ORDEN_ROZA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As FILTRO_ORDEN_ROZAEnumerator
        Return New FILTRO_ORDEN_ROZAEnumerator(Me)
    End Function

    Public Class FILTRO_ORDEN_ROZAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaFILTRO_ORDEN_ROZA)
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
