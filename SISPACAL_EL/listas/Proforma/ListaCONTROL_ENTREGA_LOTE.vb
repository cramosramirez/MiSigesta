''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTROL_ENTREGA_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTROL_ENTREGA_LOTE',
''' es una representación en memoria de los registros de la tabla CONTROL_ENTREGA_LOTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTROL_ENTREGA_LOTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTROL_ENTREGA_LOTE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTROL_ENTREGA_LOTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTROL_ENTREGA_LOTE
        Get
            Return CType((List(index)), CONTROL_ENTREGA_LOTE)
        End Get
        Set(ByVal Value As CONTROL_ENTREGA_LOTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTROL_ENTREGA_LOTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTROL_ENTREGA_LOTE = CType(List(i), CONTROL_ENTREGA_LOTE)
            If s.ID_CTRL_ENTREGA_LOTE = value.ID_CTRL_ENTREGA_LOTE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CTRL_ENTREGA_LOTE As Int32) As CONTROL_ENTREGA_LOTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTROL_ENTREGA_LOTE = CType(List(i), CONTROL_ENTREGA_LOTE)
            If s.ID_CTRL_ENTREGA_LOTE = ID_CTRL_ENTREGA_LOTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTROL_ENTREGA_LOTEEnumerator
        Return New CONTROL_ENTREGA_LOTEEnumerator(Me)
    End Function

    Public Class CONTROL_ENTREGA_LOTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTROL_ENTREGA_LOTE)
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
