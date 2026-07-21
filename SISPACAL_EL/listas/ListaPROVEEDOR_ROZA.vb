''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROVEEDOR_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROVEEDOR_ROZA',
''' es una representación en memoria de los registros de la tabla PROVEEDOR_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROVEEDOR_ROZA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROVEEDOR_ROZA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROVEEDOR_ROZA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROVEEDOR_ROZA
        Get
            Return CType((List(index)), PROVEEDOR_ROZA)
        End Get
        Set(ByVal Value As PROVEEDOR_ROZA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROVEEDOR_ROZA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_ROZA = CType(List(i), PROVEEDOR_ROZA)
            If s.ID_PROVEEDOR_ROZA = value.ID_PROVEEDOR_ROZA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROVEEDOR_ROZA As Int32) As PROVEEDOR_ROZA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_ROZA = CType(List(i), PROVEEDOR_ROZA)
            If s.ID_PROVEEDOR_ROZA = ID_PROVEEDOR_ROZA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROVEEDOR_ROZAEnumerator
        Return New PROVEEDOR_ROZAEnumerator(Me)
    End Function

    Public Class PROVEEDOR_ROZAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROVEEDOR_ROZA)
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
