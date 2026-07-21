''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_DESCUENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_DESCUENTO',
''' es una representación en memoria de los registros de la tabla TIPO_DESCUENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_DESCUENTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_DESCUENTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_DESCUENTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_DESCUENTO
        Get
            Return CType((List(index)), TIPO_DESCUENTO)
        End Get
        Set(ByVal Value As TIPO_DESCUENTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_DESCUENTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_DESCUENTO = CType(List(i), TIPO_DESCUENTO)
            If s.ID_TIPO_DESCTO = value.ID_TIPO_DESCTO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_DESCTO As Int32) As TIPO_DESCUENTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_DESCUENTO = CType(List(i), TIPO_DESCUENTO)
            If s.ID_TIPO_DESCTO = ID_TIPO_DESCTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_DESCUENTOEnumerator
        Return New TIPO_DESCUENTOEnumerator(Me)
    End Function

    Public Class TIPO_DESCUENTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_DESCUENTO)
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
